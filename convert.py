# convert.py
# adapted from 
import lxml.etree as ET
from xml.dom import minidom
import getopt
from os.path import basename
import sys
import re


class CMSIS_SVD_Forth:
    def usage(self, prog):
        print(f'{prog} --svd <cmsis-svd-file> [-o <outputfile>]')

    def mock_write(self, text):
        with open(self.outputfile, "a") as fh:
            fh.write(text)
        real_write = type(sys.stdout).write
        real_write(sys.stdout, text)

    def main(self, argv):
        svdfile = None

        try:
            opts, args = getopt.getopt(argv[1:], "", ["svd="])
        except getopt.GetoptError:
            self.usage(basename(f"{argv[0]}"))
            sys.exit(1)

        if len(argv) <= 1:
            usage(f"{argv[0]}")
            sys.exit(1)

        for opt, arg in opts:
            if opt == '--svd':
                svdfile = arg
            elif opt == '-o':
                self.outputfile, outputfile = arg, arg
                with open(outputfile, "w") as fh:
                    pass  # truncate the file
                    sys.stdout.write = self.mock_write  # decode to both stdout and outputfile

        assert svdfile is not None
        doc = minidom.parse(svdfile)
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
              <xsl:value-of select="baseAddress" /> Device: <xsl:value-of select="$device" /> 
              <xsl:text>  
              </xsl:text>
              
              <xsl:for-each select="registers/register" >
            <xsl:value-of select="$device" /><xsl:text> </xsl:text><xsl:value-of select="addressOffset" /> Register: <xsl:value-of select="$device"/>:<xsl:value-of select="name" /> <xsl:text> 
              </xsl:text>
              </xsl:for-each> 
              
              <xsl:text>  
            
              </xsl:text>
            </xsl:for-each> 
          </xsl:template>
        </xsl:stylesheet>
        '''
        dom = ET.XML(doc.toxml())
        xslt = ET.XML(extractXSL)
        transform = ET.XSLT(xslt)
        newdom = transform(dom)
        print(re.sub('0x', '$', str(newdom), count=0, flags=0))

if __name__ == "__main__":
    CMSIS_SVD_Forth().main(sys.argv)
    sys.exit(0)