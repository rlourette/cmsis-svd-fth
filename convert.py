# convert.py
# adapted from 
import lxml.etree as ET
from xml.dom import minidom
import getopt
from os.path import basename
import sys
import re
import io

class CMSIS_SVD_Forth:
    def usage(self, prog):
        print(f'{prog} --svd <cmsis-svd-file> [-o <outputfile>]')

    def mock_write(self, text):
        with open(self.outputfile, "a") as fh:
            fh.write(text)
        real_write = type(sys.stdout).write
        real_write(sys.stdout, text)

    def main(self, argv):
        # --svd examples/STM32G030.svd -o examples/stm32g030svd.fs -b examples/stm32g030svd_bitfields.fs
        svdfile = None

        try:
            opts, args = getopt.getopt(argv[1:], "o:b:", ["svd="])
        except getopt.GetoptError:
            self.usage(basename(f"{argv[0]}"))
            sys.exit(1)

        if len(argv) <= 1:
            usage(f"{argv[0]}")
            sys.exit(1)
        
        registersoutputfile = None
        bitfieldoutputfile = None
        
        for opt, arg in opts:
            if opt == '--svd':
                svdfile = arg
            elif opt == '-o':
                assert bitfieldoutputfile is None
                self.outputfile, registersoutputfile = arg, arg
                with open(registersoutputfile, "w") as fh:
                    pass  # truncate the file
                    sys.stdout.write = self.mock_write  # decode to both stdout and outputfile
            elif opt == '-b':
                assert registersoutputfile is None
                self.outputfile, bitfieldoutputfile = arg, arg
                with open(bitfieldoutputfile, "w") as fh:
                    pass  # truncate the file
                    sys.stdout.write = self.mock_write  # decode to both stdout and outputfile

        assert svdfile is not None
        svdstr = ''
        with io.StringIO(svdstr) as svdstrfh:
            with open(svdfile, 'r') as svdfh:
                Lines = svdfh.readlines()
                for line in Lines:
                    line = re.sub('\n', ' ', line, count=0, flags=0) # 0x to $
                    svdstrfh.write(line)
            svdstrfh.seek(0)
            doc = minidom.parse(svdstrfh)
        # doc.getElementsByTagName returns the NodeList
        peripherals = doc.getElementsByTagName("peripherals")[0]
        peripheralslist = doc.getElementsByTagName("peripheral")
        superperipherals = {}
        for peripheral in peripheralslist:
            if supername := peripheral.getAttribute('derivedFrom'):
                if supername not in superperipherals:
                    superperipherals[supername] = [] # list for holding the drived peripherals.
                superperipherals[supername].append(peripheral) # keep track of the subclasses

        for peripheral in peripheralslist:
            peripheralname = peripheral.getElementsByTagName("name")[0].firstChild.data
            if peripheralname in superperipherals.keys():
                for derivedperipheral in superperipherals[peripheralname]:
                    clone = peripheral.cloneNode(deep=True) # make a deep copy of the super
                    derivedname = derivedperipheral.getElementsByTagName("name")[0].firstChild.data
                    clone.getElementsByTagName("name")[0].firstChild.data = derivedname

                    # update the base Address
                    clone.getElementsByTagName("baseAddress")[0].firstChild.data = derivedperipheral.getElementsByTagName("baseAddress")[0].firstChild.data

                    # update the interrupt in the clone if present
                    derivednodeinterrupts = derivedperipheral.getElementsByTagName("interrupt")
                    if derivednodeinterrupts:
                        # this node needs to be deleted when done.
                        derivedinterruptnode = derivednodeinterrupts[0] # this contains the items to update over those inherited by the super

                        cloneinterruptnode = clone.getElementsByTagName("interrupt")[0]
                        clone.insertBefore(derivedinterruptnode, cloneinterruptnode)
                        clone.removeChild(clone.getElementsByTagName("interrupt")[1])
                    # now replace the derived node in the DOM with the updated cloned node
                    peripherals.insertBefore(clone, derivedperipheral)
                    peripherals.removeChild(derivedperipheral)

        extractXSL = '''
        <xsl:stylesheet version="1.0"
        xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
        <xsl:output method="text"/>
          <xsl:template match="/device">
            <xsl:for-each select="peripherals/peripheral" >
              <xsl:variable name="device" select="name" />
              <xsl:value-of select="baseAddress" /> constant <xsl:value-of select="$device" /> 
              <xsl:text>  
              </xsl:text>
              
              <xsl:for-each select="registers/register" >
            <xsl:value-of select="$device" /><xsl:text> </xsl:text><xsl:value-of select="addressOffset" /> + constant <xsl:value-of select="$device"/>_<xsl:value-of select="name" /> <xsl:text> 
              </xsl:text>
              </xsl:for-each> 
              
              <xsl:text>  
            
              </xsl:text>
            </xsl:for-each> 
          </xsl:template>
        </xsl:stylesheet>
        '''

        bitfieldsXSL = '''
        <xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<!-- Bitfields.xsl by Terry Porter "terry@tjporter.com.au" -->
<!-- <xsl:param name="parameters" select=" 'file:///parameters.txt' " /> -->
<!-- <xsl:param name="file" select="document('referenced.xml')"/> -->


<!-- <xsl:variable name="fileA" select="document('template.xml')"/> -->
<xsl:output method="text"/>
<xsl:template match="/device">
<xsl:text>\ </xsl:text><xsl:value-of select="name"/> <xsl:text> Register Bitfield Definitions for Mecrisp-Stellaris Forth by Matthias Koch. 
</xsl:text>
<xsl:text>\ bitfield.xsl takes STM32Fxx.svd, config.xml and produces bitfield.fs
</xsl:text>
<xsl:text>\ Written by Terry Porter "terry@tjporter.com.au" 2016 - 2020 and released under the GPL V2.
</xsl:text>
<xsl:text>\ Requires: bit ( u -- u ) 1 swap lshift 1-foldable ;	\ turn a bit position into a binary number.
</xsl:text>

<!-- Peripheral select Via template.xml file -->
<xsl:for-each select="peripherals/peripheral">
<!-- <xsl:choose> -->
<!-- <<xsl:when test=" name = $fileA/peripherals/name"> -->
<xsl:variable name="device" select="name" />

<!-- Commented register information-->
<xsl:for-each select="registers/register">
<xsl:variable name="accesstype" select="access"/>
<xsl:variable name="reg" select="name"/>

<xsl:text>
</xsl:text>
<xsl:text>\ </xsl:text>
<xsl:value-of select="$device"/>
<xsl:text>_</xsl:text>
<xsl:value-of select="$reg" />

<!-- Register access type -->
<xsl:text> (</xsl:text>
<!-- multiple access types -->
<xsl:choose>
<xsl:when test ="not ( $accesstype = 'read-only' or $accesstype = 'write-only' or $accesstype = 'read-write')
	 ">
<xsl:text>multiple-access) </xsl:text>
</xsl:when>
</xsl:choose>
<!-- $accesstype = 'read-only' or $accesstype = 'write-only' or $accesstype = 'read-write' -->
<xsl:choose>
<xsl:when test ="( $accesstype = 'read-only' or $accesstype = 'write-only' or $accesstype = 'read-write')
	 ">
<xsl:value-of select="$accesstype"/><xsl:text>)</xsl:text>
</xsl:when>
</xsl:choose>

<!-- register default reset value -->
<xsl:text> Reset:</xsl:text>
<xsl:value-of select="resetValue"/>
<xsl:text>
</xsl:text>

<!-- definition start and Wordname -->
<xsl:for-each select="fields/field">
<xsl:variable name="bitfield" select="name"/>
<xsl:text>: </xsl:text>
<xsl:value-of select="$device"/>
<xsl:text>_</xsl:text>
<xsl:value-of select="$reg"/>
<xsl:text>.</xsl:text>
<xsl:value-of select="$bitfield"/>

<!-- Append ? to bitfield name, null stack input comment if access is read only -->
<xsl:choose>
<xsl:when test ="$accesstype = 'read-only' ">
<xsl:text>? ( -- </xsl:text>
</xsl:when>
</xsl:choose>

<!-- Append ? to bitfield name if access is null and description contains 'flag' or 'status' -->
<xsl:choose>
<xsl:when test ="not ( $accesstype = 'read-only' or $accesstype = 'write-only' or $accesstype = 'read-write')
	and (contains(description, 'flag') or contains(description, 'status')) ">
<xsl:text>?</xsl:text>
</xsl:when>
</xsl:choose>

<!-- Register input parameter field BitWidths -->
<xsl:choose>
<!-- when $accesstype = not 'readonly' -->
 <xsl:when test="not ($accesstype = 'read-only') ">
<xsl:choose>
<xsl:when test ="bitWidth = 1">
<xsl:text> ( --</xsl:text>
</xsl:when>
<xsl:when test ="bitWidth = 2">
<xsl:text> ( %bb --</xsl:text>
</xsl:when>
<xsl:when test ="bitWidth = 3">
<xsl:text> ( %bbb --</xsl:text>
</xsl:when>
<xsl:when test ="bitWidth = 4">
<xsl:text> ( %bbbb --</xsl:text>
</xsl:when>
<xsl:when test ="bitWidth = 5">
<xsl:text> ( %bbbbb --</xsl:text>
</xsl:when>
<xsl:when test ="bitWidth = 6">
<xsl:text> ( %bbbbbb --</xsl:text>
</xsl:when>
<xsl:when test ="bitWidth = 7">
<xsl:text> ( %bbbbbbb --</xsl:text>
</xsl:when>
<xsl:when test ="bitWidth = 8">
<xsl:text> ( %bbbbbbbb --</xsl:text>
</xsl:when>
<xsl:when test ="bitWidth = 9">
<xsl:text> ( %bbbbbbbbb --</xsl:text>
</xsl:when>
<xsl:when test ="bitWidth = 10">
<xsl:text> ( %bbbbbbbbbb --</xsl:text>
</xsl:when>
<xsl:when test ="bitWidth = 12">
<xsl:text> ( %bbbbbbbbbbb --</xsl:text>
</xsl:when>
<xsl:when test ="bitWidth = 14">
<xsl:text> ( %bbbbbbbbbbbbbb --</xsl:text>
</xsl:when>
<xsl:when test ="bitWidth = 15">
<xsl:text> ( %bbbbbbbbbbbbbbb --</xsl:text>
</xsl:when>
<xsl:when test ="bitWidth = 16">
<xsl:text> ( %bbbbbbbbbbbbbbbb --</xsl:text>
</xsl:when>
<xsl:when test ="bitWidth = 20">
<xsl:text> ( %bbbbbbbbbbbbbbbbbbbb --</xsl:text>
</xsl:when>
<xsl:when test ="bitWidth = 24">
<xsl:text> ( %bbbbbbbbbbbbbbbbbbbbbbbb --</xsl:text>
</xsl:when>
<xsl:when test ="bitWidth = 28">
<xsl:text> ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbb --</xsl:text>
</xsl:when>
<xsl:when test ="bitWidth = 32">
<xsl:text> ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb --</xsl:text>
</xsl:when>
</xsl:choose>
</xsl:when>
</xsl:choose>

<!-- stack comment output notation types -->
<!-- access = read-only-->
<xsl:choose>
<xsl:when test ="$accesstype = 'read-only' "> 
<xsl:choose>
<xsl:when test ="bitWidth = 1"><xsl:text> 1|0 ) </xsl:text></xsl:when>
<xsl:when test ="bitWidth > 1"><xsl:text> x ) </xsl:text></xsl:when>
</xsl:choose>
</xsl:when>

<!-- access = read-write or write-only and not $reg = 'BSRR' or $reg = 'BRR'-->
<xsl:when test=" ($accesstype = 'read-write' or $accesstype = 'write-only') ">
<xsl:choose>
<xsl:when test ="bitWidth = 1and not(($accesstype = 'write-only') and (($reg = 'BSRR') or ($reg = 'BRR'))) ">
<xsl:text> x addr ) </xsl:text></xsl:when>
<xsl:when test ="bitWidth > 1 "><xsl:text> x addr ) </xsl:text></xsl:when>
</xsl:choose>
</xsl:when> 
</xsl:choose> 

<!-- Stack output comment = null when access = write-only and $reg = 'BSRR' or $reg = 'BRR'-->
<xsl:choose>
<xsl:when test=" (($accesstype = 'write-only') and (($reg = 'BSRR') or ($reg = 'BRR'))) ">
<xsl:text> ) </xsl:text>
</xsl:when> 
</xsl:choose>

<!-- stack output comment = boolean when access = null and description contains 'flag' or 'status' -->
<xsl:choose>
<xsl:when test ="not ( $accesstype = 'read-only' or $accesstype = 'write-only' or $accesstype = 'read-write')
   and (contains(description, 'flag') or contains(description, 'status')) ">
<xsl:text> 1|0 ) </xsl:text>
</xsl:when>
</xsl:choose>

<!-- stack output comment = ' x addr' when access = null and description contains NOT'flag' or NOT'status' -->
<xsl:choose>
<xsl:when test ="not ( $accesstype = 'read-only' or $accesstype = 'write-only' or $accesstype = 'read-write')
   and not((contains(description, 'flag') or (contains(description, 'status')))) ">
<xsl:text> x addr ) </xsl:text>
</xsl:when>
</xsl:choose>

<!--Word postamble where bit= 1 --> 
<xsl:choose>
<xsl:when test ="bitWidth = 1">
<xsl:value-of select="bitOffset"/>
<xsl:text> bit </xsl:text>
</xsl:when>
</xsl:choose>
	 
<!--Word postamble where bit > 1 --> 
<xsl:choose>
<xsl:when test ="bitWidth > 1">
<xsl:choose>
<xsl:when test ="bitOffset>0">
<xsl:value-of select="bitOffset"/>
<xsl:text> lshift </xsl:text>
</xsl:when>
</xsl:choose> 
</xsl:when>
</xsl:choose>		

<!-- final device_register -->
<xsl:value-of select="$device"/>
<xsl:text>_</xsl:text>
<xsl:value-of select="$reg"/>
<!-- final device_register -->

<!-- final operand (bit@ or @) when $accesstype = 'read-only' -->
<xsl:choose>
<xsl:when test ="$accesstype = 'read-only' ">
<xsl:choose>
<xsl:when test ="bitWidth = 1"><xsl:text> bit@</xsl:text></xsl:when>
<xsl:when test ="bitWidth > 1"><xsl:text> @</xsl:text></xsl:when>
</xsl:choose>
</xsl:when>
</xsl:choose>

<!-- final operand = 'bit@' when access is null and description contains 'flag' or 'status' -->
<xsl:choose>
<xsl:when test ="not ( $accesstype = 'read-only' or $accesstype = 'write-only' or $accesstype = 'read-write')
	and (contains(description, 'flag')or contains(description, 'status')) ">
<xsl:text> bit@</xsl:text>
</xsl:when>
</xsl:choose>

<!--final operand = '!' when $reg = 'BSRR' or 'BRR' -->
<xsl:choose>
<xsl:when test=" (($accesstype = 'write-only') and (($reg = 'BSRR') or ($reg = 'BRR'))) ">
<xsl:text> !</xsl:text>
</xsl:when> 
</xsl:choose>

<!-- Word terminator -->
<xsl:text> ; </xsl:text>

<!-- final comment -->
<xsl:text>\ </xsl:text>
<xsl:value-of select="$device"/>
<xsl:text>_</xsl:text>
<xsl:value-of select="$reg"/>
<xsl:text>.</xsl:text>
<xsl:value-of select="$bitfield"/>
<xsl:text>, </xsl:text>
<xsl:value-of select="description"/>		
<xsl:text>
</xsl:text>

<!-- stylesheet completion -->
</xsl:for-each>
</xsl:for-each>
<!-- </xsl:when> -->
<!-- </xsl:choose> -->
</xsl:for-each>
</xsl:template>
</xsl:stylesheet>

        '''

        if registersoutputfile:
            dom = ET.XML(doc.toxml())
            xslt = ET.XML(extractXSL)
            transform = ET.XSLT(xslt)
            newdom = transform(dom)
            newdomsio = io.StringIO(str(newdom))
            for line in newdomsio:
                line = re.sub('0x', '$', line, count=0, flags=0) # 0x to $
                line = re.sub('Device', 'device', line, count=0, flags=0) # 0x to $
                line = re.sub('Register', 'register', line, count=0, flags=0) # 0x to $
                print(line, end='')

        if bitfieldoutputfile:
            dom = ET.XML(doc.toxml())
            xslt = ET.XML(bitfieldsXSL)
            transform = ET.XSLT(xslt)
            newdom = transform(dom)
            newdomsio = io.StringIO(str(newdom))
            for line in newdomsio:
                line = re.sub('0x', '$', line, count=0, flags=0) # 0x to $
                # line = re.sub('Device', 'device', line, count=0, flags=0) # 0x to $
                # line = re.sub('Register', 'register', line, count=0, flags=0) # 0x to $
                print(line, end='')
if __name__ == "__main__":
    CMSIS_SVD_Forth().main(sys.argv)
    sys.exit(0)