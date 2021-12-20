\ STM32G030 Register Bitfield Definitions for Mecrisp-Stellaris Forth by Matthias Koch. 
\ bitfield.xsl takes STM32Fxx.svd, config.xml and produces bitfield.fs
\ Written by Terry Porter "terry@tjporter.com.au" 2016 - 2020 and released under the GPL V2.
\ Requires: bit ( u -- u ) 1 swap lshift 1-foldable ;	\ turn a bit position into a binary number.

\ IWDG.KR (write-only) Reset:$00000000
: IWDG.KR.KEY ( %bbbbbbbbbbbbbbbb -- x addr ) IWDG.KR ; \ IWDG.KR.KEY, Key value (write only, read               $0000)

\ IWDG.PR (read-write) Reset:$00000000
: IWDG.PR.PR ( %bbb -- x addr ) IWDG.PR ; \ IWDG.PR.PR, Prescaler divider

\ IWDG.RLR (read-write) Reset:$00000FFF
: IWDG.RLR.RL ( %bbbbbbbbbbb -- x addr ) IWDG.RLR ; \ IWDG.RLR.RL, Watchdog counter reload               value

\ IWDG.SR (read-only) Reset:$00000000
: IWDG.SR.WVU? ( --  1|0 ) 2 bit IWDG.SR bit@ ; \ IWDG.SR.WVU, Watchdog counter window value               update
: IWDG.SR.RVU? ( --  1|0 ) 1 bit IWDG.SR bit@ ; \ IWDG.SR.RVU, Watchdog counter reload value               update
: IWDG.SR.PVU? ( --  1|0 ) 0 bit IWDG.SR bit@ ; \ IWDG.SR.PVU, Watchdog prescaler value               update

\ IWDG.WINR (read-write) Reset:$00000FFF
: IWDG.WINR.WIN ( %bbbbbbbbbbb -- x addr ) IWDG.WINR ; \ IWDG.WINR.WIN, Watchdog counter window               value

\ WWDG.CR (read-write) Reset:$0000007F
: WWDG.CR.WDGA ( -- x addr ) 7 bit WWDG.CR ; \ WWDG.CR.WDGA, Activation bit
: WWDG.CR.T ( %bbbbbbb -- x addr ) WWDG.CR ; \ WWDG.CR.T, 7-bit counter (MSB to LSB)

\ WWDG.CFR (read-write) Reset:$0000007F
: WWDG.CFR.WDGTB ( %bbb -- x addr ) 11 lshift WWDG.CFR ; \ WWDG.CFR.WDGTB, Timer base
: WWDG.CFR.EWI ( -- x addr ) 9 bit WWDG.CFR ; \ WWDG.CFR.EWI, Early wakeup interrupt
: WWDG.CFR.W ( %bbbbbbb -- x addr ) WWDG.CFR ; \ WWDG.CFR.W, 7-bit window value

\ WWDG.SR (read-write) Reset:$00000000
: WWDG.SR.EWIF ( -- x addr ) 0 bit WWDG.SR ; \ WWDG.SR.EWIF, Early wakeup interrupt               flag

\ FLASH.ACR (read-write) Reset:$00000600
: FLASH.ACR.LATENCY ( %bbb -- x addr ) FLASH.ACR ; \ FLASH.ACR.LATENCY, Latency
: FLASH.ACR.PRFTEN ( -- x addr ) 8 bit FLASH.ACR ; \ FLASH.ACR.PRFTEN, Prefetch enable
: FLASH.ACR.ICEN ( -- x addr ) 9 bit FLASH.ACR ; \ FLASH.ACR.ICEN, Instruction cache enable
: FLASH.ACR.ICRST ( -- x addr ) 11 bit FLASH.ACR ; \ FLASH.ACR.ICRST, Instruction cache reset
: FLASH.ACR.EMPTY ( -- x addr ) 16 bit FLASH.ACR ; \ FLASH.ACR.EMPTY, Flash User area empty
: FLASH.ACR.DBG_SWEN ( -- x addr ) 18 bit FLASH.ACR ; \ FLASH.ACR.DBG_SWEN, Debug access software               enable

\ FLASH.KEYR (write-only) Reset:$00000000
: FLASH.KEYR.KEYR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) FLASH.KEYR ; \ FLASH.KEYR.KEYR, KEYR

\ FLASH.OPTKEYR (write-only) Reset:$00000000
: FLASH.OPTKEYR.OPTKEYR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) FLASH.OPTKEYR ; \ FLASH.OPTKEYR.OPTKEYR, Option byte key

\ FLASH.SR (read-write) Reset:$00000000
: FLASH.SR.EOP ( -- x addr ) 0 bit FLASH.SR ; \ FLASH.SR.EOP, End of operation
: FLASH.SR.OPERR ( -- x addr ) 1 bit FLASH.SR ; \ FLASH.SR.OPERR, Operation error
: FLASH.SR.PROGERR ( -- x addr ) 3 bit FLASH.SR ; \ FLASH.SR.PROGERR, Programming error
: FLASH.SR.WRPERR ( -- x addr ) 4 bit FLASH.SR ; \ FLASH.SR.WRPERR, Write protected error
: FLASH.SR.PGAERR ( -- x addr ) 5 bit FLASH.SR ; \ FLASH.SR.PGAERR, Programming alignment               error
: FLASH.SR.SIZERR ( -- x addr ) 6 bit FLASH.SR ; \ FLASH.SR.SIZERR, Size error
: FLASH.SR.PGSERR ( -- x addr ) 7 bit FLASH.SR ; \ FLASH.SR.PGSERR, Programming sequence error
: FLASH.SR.MISERR ( -- x addr ) 8 bit FLASH.SR ; \ FLASH.SR.MISERR, Fast programming data miss               error
: FLASH.SR.FASTERR ( -- x addr ) 9 bit FLASH.SR ; \ FLASH.SR.FASTERR, Fast programming error
: FLASH.SR.RDERR ( -- x addr ) 14 bit FLASH.SR ; \ FLASH.SR.RDERR, PCROP read error
: FLASH.SR.OPTVERR ( -- x addr ) 15 bit FLASH.SR ; \ FLASH.SR.OPTVERR, Option and Engineering bits loading               validity error
: FLASH.SR.BSY ( -- x addr ) 16 bit FLASH.SR ; \ FLASH.SR.BSY, Busy
: FLASH.SR.CFGBSY ( -- x addr ) 18 bit FLASH.SR ; \ FLASH.SR.CFGBSY, Programming or erase configuration               busy.

\ FLASH.CR (read-write) Reset:$C0000000
: FLASH.CR.PG ( -- x addr ) 0 bit FLASH.CR ; \ FLASH.CR.PG, Programming
: FLASH.CR.PER ( -- x addr ) 1 bit FLASH.CR ; \ FLASH.CR.PER, Page erase
: FLASH.CR.MER ( -- x addr ) 2 bit FLASH.CR ; \ FLASH.CR.MER, Mass erase
: FLASH.CR.PNB ( %bbbbbb -- x addr ) 3 lshift FLASH.CR ; \ FLASH.CR.PNB, Page number
: FLASH.CR.STRT ( -- x addr ) 16 bit FLASH.CR ; \ FLASH.CR.STRT, Start
: FLASH.CR.OPTSTRT ( -- x addr ) 17 bit FLASH.CR ; \ FLASH.CR.OPTSTRT, Options modification start
: FLASH.CR.FSTPG ( -- x addr ) 18 bit FLASH.CR ; \ FLASH.CR.FSTPG, Fast programming
: FLASH.CR.EOPIE ( -- x addr ) 24 bit FLASH.CR ; \ FLASH.CR.EOPIE, End of operation interrupt               enable
: FLASH.CR.ERRIE ( -- x addr ) 25 bit FLASH.CR ; \ FLASH.CR.ERRIE, Error interrupt enable
: FLASH.CR.RDERRIE ( -- x addr ) 26 bit FLASH.CR ; \ FLASH.CR.RDERRIE, PCROP read error interrupt               enable
: FLASH.CR.OBL_LAUNCH ( -- x addr ) 27 bit FLASH.CR ; \ FLASH.CR.OBL_LAUNCH, Force the option byte               loading
: FLASH.CR.SEC_PROT ( -- x addr ) 28 bit FLASH.CR ; \ FLASH.CR.SEC_PROT, Securable memory area protection               enable
: FLASH.CR.OPTLOCK ( -- x addr ) 30 bit FLASH.CR ; \ FLASH.CR.OPTLOCK, Options Lock
: FLASH.CR.LOCK ( -- x addr ) 31 bit FLASH.CR ; \ FLASH.CR.LOCK, FLASH_CR Lock

\ FLASH.ECCR (multiple-access)  Reset:$00000000
: FLASH.ECCR.ADDR_ECC ( %bbbbbbbbbbbbbb -- x addr ) FLASH.ECCR ; \ FLASH.ECCR.ADDR_ECC, ECC fail address
: FLASH.ECCR.SYSF_ECC ( -- x addr ) 20 bit FLASH.ECCR ; \ FLASH.ECCR.SYSF_ECC, ECC fail for Corrected ECC Error or               Double ECC Error in info block
: FLASH.ECCR.ECCIE ( -- x addr ) 24 bit FLASH.ECCR ; \ FLASH.ECCR.ECCIE, ECC correction interrupt               enable
: FLASH.ECCR.ECCC ( -- x addr ) 30 bit FLASH.ECCR ; \ FLASH.ECCR.ECCC, ECC correction
: FLASH.ECCR.ECCD ( -- x addr ) 31 bit FLASH.ECCR ; \ FLASH.ECCR.ECCD, ECC detection

\ FLASH.OPTR (read-write) Reset:$F0000000
: FLASH.OPTR.RDP ( %bbbbbbbb -- x addr ) FLASH.OPTR ; \ FLASH.OPTR.RDP, Read protection level
: FLASH.OPTR.BOREN ( -- x addr ) 8 bit FLASH.OPTR ; \ FLASH.OPTR.BOREN, BOR reset Level
: FLASH.OPTR.BORF_LEV ( %bb -- x addr ) 9 lshift FLASH.OPTR ; \ FLASH.OPTR.BORF_LEV, These bits contain the VDD supply level               threshold that activates the reset
: FLASH.OPTR.BORR_LEV ( %bb -- x addr ) 11 lshift FLASH.OPTR ; \ FLASH.OPTR.BORR_LEV, These bits contain the VDD supply level               threshold that releases the reset.
: FLASH.OPTR.nRST_STOP ( -- x addr ) 13 bit FLASH.OPTR ; \ FLASH.OPTR.nRST_STOP, nRST_STOP
: FLASH.OPTR.nRST_STDBY ( -- x addr ) 14 bit FLASH.OPTR ; \ FLASH.OPTR.nRST_STDBY, nRST_STDBY
: FLASH.OPTR.nRSTS_HDW ( -- x addr ) 15 bit FLASH.OPTR ; \ FLASH.OPTR.nRSTS_HDW, nRSTS_HDW
: FLASH.OPTR.IDWG_SW ( -- x addr ) 16 bit FLASH.OPTR ; \ FLASH.OPTR.IDWG_SW, Independent watchdog               selection
: FLASH.OPTR.IWDG_STOP ( -- x addr ) 17 bit FLASH.OPTR ; \ FLASH.OPTR.IWDG_STOP, Independent watchdog counter freeze in               Stop mode
: FLASH.OPTR.IWDG_STDBY ( -- x addr ) 18 bit FLASH.OPTR ; \ FLASH.OPTR.IWDG_STDBY, Independent watchdog counter freeze in               Standby mode
: FLASH.OPTR.WWDG_SW ( -- x addr ) 19 bit FLASH.OPTR ; \ FLASH.OPTR.WWDG_SW, Window watchdog selection
: FLASH.OPTR.RAM_PARITY_CHECK ( -- x addr ) 22 bit FLASH.OPTR ; \ FLASH.OPTR.RAM_PARITY_CHECK, SRAM parity check control
: FLASH.OPTR.nBOOT_SEL ( -- x addr ) 24 bit FLASH.OPTR ; \ FLASH.OPTR.nBOOT_SEL, nBOOT_SEL
: FLASH.OPTR.nBOOT1 ( -- x addr ) 25 bit FLASH.OPTR ; \ FLASH.OPTR.nBOOT1, Boot configuration
: FLASH.OPTR.nBOOT0 ( -- x addr ) 26 bit FLASH.OPTR ; \ FLASH.OPTR.nBOOT0, nBOOT0 option bit
: FLASH.OPTR.NRST_MODE ( %bb -- x addr ) 27 lshift FLASH.OPTR ; \ FLASH.OPTR.NRST_MODE, NRST_MODE
: FLASH.OPTR.IRHEN ( -- x addr ) 29 bit FLASH.OPTR ; \ FLASH.OPTR.IRHEN, Internal reset holder enable               bit

\ FLASH.PCROP1ASR (read-only) Reset:$F0000000
: FLASH.PCROP1ASR.PCROP1A_STRT? ( --  x ) FLASH.PCROP1ASR @ ; \ FLASH.PCROP1ASR.PCROP1A_STRT, PCROP1A area start offset

\ FLASH.PCROP1AER (read-only) Reset:$F0000000
: FLASH.PCROP1AER.PCROP1A_END? ( --  x ) FLASH.PCROP1AER @ ; \ FLASH.PCROP1AER.PCROP1A_END, PCROP1A area end offset
: FLASH.PCROP1AER.PCROP_RDP? ( --  1|0 ) 31 bit FLASH.PCROP1AER bit@ ; \ FLASH.PCROP1AER.PCROP_RDP, PCROP area preserved when RDP level               decreased

\ FLASH.WRP1AR (read-only) Reset:$F0000000
: FLASH.WRP1AR.WRP1A_STRT? ( --  x ) FLASH.WRP1AR @ ; \ FLASH.WRP1AR.WRP1A_STRT, WRP area A start offset
: FLASH.WRP1AR.WRP1A_END? ( --  x ) 16 lshift FLASH.WRP1AR @ ; \ FLASH.WRP1AR.WRP1A_END, WRP area A end offset

\ FLASH.WRP1BR (read-only) Reset:$F0000000
: FLASH.WRP1BR.WRP1B_STRT? ( --  x ) FLASH.WRP1BR @ ; \ FLASH.WRP1BR.WRP1B_STRT, WRP area B start offset
: FLASH.WRP1BR.WRP1B_END? ( --  x ) 16 lshift FLASH.WRP1BR @ ; \ FLASH.WRP1BR.WRP1B_END, WRP area B end offset

\ FLASH.PCROP1BSR (read-only) Reset:$F0000000
: FLASH.PCROP1BSR.PCROP1B_STRT? ( --  x ) FLASH.PCROP1BSR @ ; \ FLASH.PCROP1BSR.PCROP1B_STRT, PCROP1B area start offset

\ FLASH.PCROP1BER (read-only) Reset:$F0000000
: FLASH.PCROP1BER.PCROP1B_END? ( --  x ) FLASH.PCROP1BER @ ; \ FLASH.PCROP1BER.PCROP1B_END, PCROP1B area end offset

\ FLASH.SECR (read-only) Reset:$F0000000
: FLASH.SECR.SEC_SIZE? ( --  x ) FLASH.SECR @ ; \ FLASH.SECR.SEC_SIZE, Securable memory area size
: FLASH.SECR.BOOT_LOCK? ( --  1|0 ) 16 bit FLASH.SECR bit@ ; \ FLASH.SECR.BOOT_LOCK, used to force boot from user               area

\ RCC.CR (read-write) Reset:$00000063
: RCC.CR.HSION ( -- x addr ) 8 bit RCC.CR ; \ RCC.CR.HSION, HSI16 clock enable
: RCC.CR.HSIKERON ( -- x addr ) 9 bit RCC.CR ; \ RCC.CR.HSIKERON, HSI16 always enable for peripheral               kernels
: RCC.CR.HSIRDY ( -- x addr ) 10 bit RCC.CR ; \ RCC.CR.HSIRDY, HSI16 clock ready flag
: RCC.CR.HSIDIV ( %bbb -- x addr ) 11 lshift RCC.CR ; \ RCC.CR.HSIDIV, HSI16 clock division               factor
: RCC.CR.HSEON ( -- x addr ) 16 bit RCC.CR ; \ RCC.CR.HSEON, HSE clock enable
: RCC.CR.HSERDY ( -- x addr ) 17 bit RCC.CR ; \ RCC.CR.HSERDY, HSE clock ready flag
: RCC.CR.HSEBYP ( -- x addr ) 18 bit RCC.CR ; \ RCC.CR.HSEBYP, HSE crystal oscillator               bypass
: RCC.CR.CSSON ( -- x addr ) 19 bit RCC.CR ; \ RCC.CR.CSSON, Clock security system               enable
: RCC.CR.PLLON ( -- x addr ) 24 bit RCC.CR ; \ RCC.CR.PLLON, PLL enable
: RCC.CR.PLLRDY ( -- x addr ) 25 bit RCC.CR ; \ RCC.CR.PLLRDY, PLL clock ready flag

\ RCC.ICSCR (multiple-access)  Reset:$10000000
: RCC.ICSCR.HSICAL ( %bbbbbbbb -- x addr ) RCC.ICSCR ; \ RCC.ICSCR.HSICAL, HSI16 clock calibration
: RCC.ICSCR.HSITRIM ( %bbbbbbb -- x addr ) 8 lshift RCC.ICSCR ; \ RCC.ICSCR.HSITRIM, HSI16 clock trimming

\ RCC.CFGR (multiple-access)  Reset:$00000000
: RCC.CFGR.MCOPRE ( %bbb -- x addr ) 28 lshift RCC.CFGR ; \ RCC.CFGR.MCOPRE, Microcontroller clock output               prescaler
: RCC.CFGR.MCOSEL ( %bbb -- x addr ) 24 lshift RCC.CFGR ; \ RCC.CFGR.MCOSEL, Microcontroller clock               output
: RCC.CFGR.PPRE ( %bbb -- x addr ) 12 lshift RCC.CFGR ; \ RCC.CFGR.PPRE, APB prescaler
: RCC.CFGR.HPRE ( %bbbb -- x addr ) 8 lshift RCC.CFGR ; \ RCC.CFGR.HPRE, AHB prescaler
: RCC.CFGR.SWS? ( %bbb -- 1|0 ) 3 lshift RCC.CFGR bit@ ; \ RCC.CFGR.SWS, System clock switch status
: RCC.CFGR.SW ( %bbb -- x addr ) RCC.CFGR ; \ RCC.CFGR.SW, System clock switch

\ RCC.PLLSYSCFGR (read-write) Reset:$00001000
: RCC.PLLSYSCFGR.PLLSRC ( %bb -- x addr ) RCC.PLLSYSCFGR ; \ RCC.PLLSYSCFGR.PLLSRC, PLL input clock source
: RCC.PLLSYSCFGR.PLLM ( %bbb -- x addr ) 4 lshift RCC.PLLSYSCFGR ; \ RCC.PLLSYSCFGR.PLLM, Division factor M of the PLL input clock               divider
: RCC.PLLSYSCFGR.PLLN ( %bbbbbbb -- x addr ) 8 lshift RCC.PLLSYSCFGR ; \ RCC.PLLSYSCFGR.PLLN, PLL frequency multiplication factor               N
: RCC.PLLSYSCFGR.PLLPEN ( -- x addr ) 16 bit RCC.PLLSYSCFGR ; \ RCC.PLLSYSCFGR.PLLPEN, PLLPCLK clock output               enable
: RCC.PLLSYSCFGR.PLLP ( %bbbbb -- x addr ) 17 lshift RCC.PLLSYSCFGR ; \ RCC.PLLSYSCFGR.PLLP, PLL VCO division factor P for PLLPCLK               clock output
: RCC.PLLSYSCFGR.PLLQEN ( -- x addr ) 24 bit RCC.PLLSYSCFGR ; \ RCC.PLLSYSCFGR.PLLQEN, PLLQCLK clock output               enable
: RCC.PLLSYSCFGR.PLLQ ( %bbb -- x addr ) 25 lshift RCC.PLLSYSCFGR ; \ RCC.PLLSYSCFGR.PLLQ, PLL VCO division factor Q for PLLQCLK               clock output
: RCC.PLLSYSCFGR.PLLREN ( -- x addr ) 28 bit RCC.PLLSYSCFGR ; \ RCC.PLLSYSCFGR.PLLREN, PLLRCLK clock output               enable
: RCC.PLLSYSCFGR.PLLR ( %bbb -- x addr ) 29 lshift RCC.PLLSYSCFGR ; \ RCC.PLLSYSCFGR.PLLR, PLL VCO division factor R for PLLRCLK               clock output

\ RCC.CIER (read-write) Reset:$00000000
: RCC.CIER.LSIRDYIE ( -- x addr ) 0 bit RCC.CIER ; \ RCC.CIER.LSIRDYIE, LSI ready interrupt enable
: RCC.CIER.LSERDYIE ( -- x addr ) 1 bit RCC.CIER ; \ RCC.CIER.LSERDYIE, LSE ready interrupt enable
: RCC.CIER.HSIRDYIE ( -- x addr ) 3 bit RCC.CIER ; \ RCC.CIER.HSIRDYIE, HSI ready interrupt enable
: RCC.CIER.HSERDYIE ( -- x addr ) 4 bit RCC.CIER ; \ RCC.CIER.HSERDYIE, HSE ready interrupt enable
: RCC.CIER.PLLSYSRDYIE ( -- x addr ) 5 bit RCC.CIER ; \ RCC.CIER.PLLSYSRDYIE, PLL ready interrupt enable

\ RCC.CIFR (read-only) Reset:$00000000
: RCC.CIFR.LSIRDYF? ( --  1|0 ) 0 bit RCC.CIFR bit@ ; \ RCC.CIFR.LSIRDYF, LSI ready interrupt flag
: RCC.CIFR.LSERDYF? ( --  1|0 ) 1 bit RCC.CIFR bit@ ; \ RCC.CIFR.LSERDYF, LSE ready interrupt flag
: RCC.CIFR.HSIRDYF? ( --  1|0 ) 3 bit RCC.CIFR bit@ ; \ RCC.CIFR.HSIRDYF, HSI ready interrupt flag
: RCC.CIFR.HSERDYF? ( --  1|0 ) 4 bit RCC.CIFR bit@ ; \ RCC.CIFR.HSERDYF, HSE ready interrupt flag
: RCC.CIFR.PLLSYSRDYF? ( --  1|0 ) 5 bit RCC.CIFR bit@ ; \ RCC.CIFR.PLLSYSRDYF, PLL ready interrupt flag
: RCC.CIFR.CSSF? ( --  1|0 ) 8 bit RCC.CIFR bit@ ; \ RCC.CIFR.CSSF, Clock security system interrupt               flag
: RCC.CIFR.LSECSSF? ( --  1|0 ) 9 bit RCC.CIFR bit@ ; \ RCC.CIFR.LSECSSF, LSE Clock security system interrupt               flag

\ RCC.CICR (write-only) Reset:$00000000
: RCC.CICR.LSIRDYC ( -- x addr ) 0 bit RCC.CICR ; \ RCC.CICR.LSIRDYC, LSI ready interrupt clear
: RCC.CICR.LSERDYC ( -- x addr ) 1 bit RCC.CICR ; \ RCC.CICR.LSERDYC, LSE ready interrupt clear
: RCC.CICR.HSIRDYC ( -- x addr ) 3 bit RCC.CICR ; \ RCC.CICR.HSIRDYC, HSI ready interrupt clear
: RCC.CICR.HSERDYC ( -- x addr ) 4 bit RCC.CICR ; \ RCC.CICR.HSERDYC, HSE ready interrupt clear
: RCC.CICR.PLLSYSRDYC ( -- x addr ) 5 bit RCC.CICR ; \ RCC.CICR.PLLSYSRDYC, PLL ready interrupt clear
: RCC.CICR.CSSC ( -- x addr ) 8 bit RCC.CICR ; \ RCC.CICR.CSSC, Clock security system interrupt               clear
: RCC.CICR.LSECSSC ( -- x addr ) 9 bit RCC.CICR ; \ RCC.CICR.LSECSSC, LSE Clock security system interrupt               clear

\ RCC.AHBRSTR (read-write) Reset:$00000000
: RCC.AHBRSTR.DMARST ( -- x addr ) 0 bit RCC.AHBRSTR ; \ RCC.AHBRSTR.DMARST, DMA1 reset
: RCC.AHBRSTR.FLASHRST ( -- x addr ) 8 bit RCC.AHBRSTR ; \ RCC.AHBRSTR.FLASHRST, FLITF reset
: RCC.AHBRSTR.CRCRST ( -- x addr ) 12 bit RCC.AHBRSTR ; \ RCC.AHBRSTR.CRCRST, CRC reset

\ RCC.IOPRSTR (read-write) Reset:$00000000
: RCC.IOPRSTR.IOPARST ( -- x addr ) 0 bit RCC.IOPRSTR ; \ RCC.IOPRSTR.IOPARST, I/O port A reset
: RCC.IOPRSTR.IOPBRST ( -- x addr ) 1 bit RCC.IOPRSTR ; \ RCC.IOPRSTR.IOPBRST, I/O port B reset
: RCC.IOPRSTR.IOPCRST ( -- x addr ) 2 bit RCC.IOPRSTR ; \ RCC.IOPRSTR.IOPCRST, I/O port C reset
: RCC.IOPRSTR.IOPDRST ( -- x addr ) 3 bit RCC.IOPRSTR ; \ RCC.IOPRSTR.IOPDRST, I/O port D reset
: RCC.IOPRSTR.IOPFRST ( -- x addr ) 5 bit RCC.IOPRSTR ; \ RCC.IOPRSTR.IOPFRST, I/O port F reset

\ RCC.APBRSTR1 (read-write) Reset:$00000000
: RCC.APBRSTR1.TIM2RST ( -- x addr ) 0 bit RCC.APBRSTR1 ; \ RCC.APBRSTR1.TIM2RST, TIM2 timer reset
: RCC.APBRSTR1.TIM3RST ( -- x addr ) 1 bit RCC.APBRSTR1 ; \ RCC.APBRSTR1.TIM3RST, TIM3 timer reset
: RCC.APBRSTR1.SPI2RST ( -- x addr ) 14 bit RCC.APBRSTR1 ; \ RCC.APBRSTR1.SPI2RST, SPI2 reset
: RCC.APBRSTR1.USART2RST ( -- x addr ) 17 bit RCC.APBRSTR1 ; \ RCC.APBRSTR1.USART2RST, USART2 reset
: RCC.APBRSTR1.I2C1RST ( -- x addr ) 21 bit RCC.APBRSTR1 ; \ RCC.APBRSTR1.I2C1RST, I2C1 reset
: RCC.APBRSTR1.I2C2RST ( -- x addr ) 22 bit RCC.APBRSTR1 ; \ RCC.APBRSTR1.I2C2RST, I2C2 reset
: RCC.APBRSTR1.DBGRST ( -- x addr ) 27 bit RCC.APBRSTR1 ; \ RCC.APBRSTR1.DBGRST, Debug support reset
: RCC.APBRSTR1.PWRRST ( -- x addr ) 28 bit RCC.APBRSTR1 ; \ RCC.APBRSTR1.PWRRST, Power interface reset

\ RCC.APBRSTR2 (read-write) Reset:$00000000
: RCC.APBRSTR2.SYSCFGRST ( -- x addr ) 0 bit RCC.APBRSTR2 ; \ RCC.APBRSTR2.SYSCFGRST, SYSCFG, COMP and VREFBUF               reset
: RCC.APBRSTR2.TIM1RST ( -- x addr ) 11 bit RCC.APBRSTR2 ; \ RCC.APBRSTR2.TIM1RST, TIM1 timer reset
: RCC.APBRSTR2.SPI1RST ( -- x addr ) 12 bit RCC.APBRSTR2 ; \ RCC.APBRSTR2.SPI1RST, SPI1 reset
: RCC.APBRSTR2.USART1RST ( -- x addr ) 14 bit RCC.APBRSTR2 ; \ RCC.APBRSTR2.USART1RST, USART1 reset
: RCC.APBRSTR2.TIM14RST ( -- x addr ) 15 bit RCC.APBRSTR2 ; \ RCC.APBRSTR2.TIM14RST, TIM14 timer reset
: RCC.APBRSTR2.TIM16RST ( -- x addr ) 17 bit RCC.APBRSTR2 ; \ RCC.APBRSTR2.TIM16RST, TIM16 timer reset
: RCC.APBRSTR2.TIM17RST ( -- x addr ) 18 bit RCC.APBRSTR2 ; \ RCC.APBRSTR2.TIM17RST, TIM17 timer reset
: RCC.APBRSTR2.ADCRST ( -- x addr ) 20 bit RCC.APBRSTR2 ; \ RCC.APBRSTR2.ADCRST, ADC reset

\ RCC.IOPENR (read-write) Reset:$00000000
: RCC.IOPENR.IOPAEN ( -- x addr ) 0 bit RCC.IOPENR ; \ RCC.IOPENR.IOPAEN, I/O port A clock enable
: RCC.IOPENR.IOPBEN ( -- x addr ) 1 bit RCC.IOPENR ; \ RCC.IOPENR.IOPBEN, I/O port B clock enable
: RCC.IOPENR.IOPCEN ( -- x addr ) 2 bit RCC.IOPENR ; \ RCC.IOPENR.IOPCEN, I/O port C clock enable
: RCC.IOPENR.IOPDEN ( -- x addr ) 3 bit RCC.IOPENR ; \ RCC.IOPENR.IOPDEN, I/O port D clock enable
: RCC.IOPENR.IOPFEN ( -- x addr ) 5 bit RCC.IOPENR ; \ RCC.IOPENR.IOPFEN, I/O port F clock enable

\ RCC.AHBENR (read-write) Reset:$00000000
: RCC.AHBENR.DMAEN ( -- x addr ) 0 bit RCC.AHBENR ; \ RCC.AHBENR.DMAEN, DMA clock enable
: RCC.AHBENR.FLASHEN ( -- x addr ) 8 bit RCC.AHBENR ; \ RCC.AHBENR.FLASHEN, Flash memory interface clock               enable
: RCC.AHBENR.CRCEN ( -- x addr ) 12 bit RCC.AHBENR ; \ RCC.AHBENR.CRCEN, CRC clock enable

\ RCC.APBENR1 (read-write) Reset:$00000000
: RCC.APBENR1.TIM2EN ( -- x addr ) 0 bit RCC.APBENR1 ; \ RCC.APBENR1.TIM2EN, TIM2 timer clock enable
: RCC.APBENR1.TIM3EN ( -- x addr ) 1 bit RCC.APBENR1 ; \ RCC.APBENR1.TIM3EN, TIM3 timer clock enable
: RCC.APBENR1.RTCAPBEN ( -- x addr ) 10 bit RCC.APBENR1 ; \ RCC.APBENR1.RTCAPBEN, RTC APB clock enable
: RCC.APBENR1.WWDGEN ( -- x addr ) 11 bit RCC.APBENR1 ; \ RCC.APBENR1.WWDGEN, WWDG clock enable
: RCC.APBENR1.SPI2EN ( -- x addr ) 14 bit RCC.APBENR1 ; \ RCC.APBENR1.SPI2EN, SPI2 clock enable
: RCC.APBENR1.USART2EN ( -- x addr ) 17 bit RCC.APBENR1 ; \ RCC.APBENR1.USART2EN, USART2 clock enable
: RCC.APBENR1.I2C1EN ( -- x addr ) 21 bit RCC.APBENR1 ; \ RCC.APBENR1.I2C1EN, I2C1 clock enable
: RCC.APBENR1.I2C2EN ( -- x addr ) 22 bit RCC.APBENR1 ; \ RCC.APBENR1.I2C2EN, I2C2 clock enable
: RCC.APBENR1.DBGEN ( -- x addr ) 27 bit RCC.APBENR1 ; \ RCC.APBENR1.DBGEN, Debug support clock enable
: RCC.APBENR1.PWREN ( -- x addr ) 28 bit RCC.APBENR1 ; \ RCC.APBENR1.PWREN, Power interface clock               enable

\ RCC.APBENR2 (read-write) Reset:$00000000
: RCC.APBENR2.SYSCFGEN ( -- x addr ) 0 bit RCC.APBENR2 ; \ RCC.APBENR2.SYSCFGEN, SYSCFG, COMP and VREFBUF clock               enable
: RCC.APBENR2.TIM1EN ( -- x addr ) 11 bit RCC.APBENR2 ; \ RCC.APBENR2.TIM1EN, TIM1 timer clock enable
: RCC.APBENR2.SPI1EN ( -- x addr ) 12 bit RCC.APBENR2 ; \ RCC.APBENR2.SPI1EN, SPI1 clock enable
: RCC.APBENR2.USART1EN ( -- x addr ) 14 bit RCC.APBENR2 ; \ RCC.APBENR2.USART1EN, USART1 clock enable
: RCC.APBENR2.TIM14EN ( -- x addr ) 15 bit RCC.APBENR2 ; \ RCC.APBENR2.TIM14EN, TIM14 timer clock enable
: RCC.APBENR2.TIM16EN ( -- x addr ) 17 bit RCC.APBENR2 ; \ RCC.APBENR2.TIM16EN, TIM16 timer clock enable
: RCC.APBENR2.TIM17EN ( -- x addr ) 18 bit RCC.APBENR2 ; \ RCC.APBENR2.TIM17EN, TIM16 timer clock enable
: RCC.APBENR2.ADCEN ( -- x addr ) 20 bit RCC.APBENR2 ; \ RCC.APBENR2.ADCEN, ADC clock enable

\ RCC.IOPSMENR (read-write) Reset:$00000000
: RCC.IOPSMENR.IOPASMEN ( -- x addr ) 0 bit RCC.IOPSMENR ; \ RCC.IOPSMENR.IOPASMEN, I/O port A clock enable during Sleep               mode
: RCC.IOPSMENR.IOPBSMEN ( -- x addr ) 1 bit RCC.IOPSMENR ; \ RCC.IOPSMENR.IOPBSMEN, I/O port B clock enable during Sleep               mode
: RCC.IOPSMENR.IOPCSMEN ( -- x addr ) 2 bit RCC.IOPSMENR ; \ RCC.IOPSMENR.IOPCSMEN, I/O port C clock enable during Sleep               mode
: RCC.IOPSMENR.IOPDSMEN ( -- x addr ) 3 bit RCC.IOPSMENR ; \ RCC.IOPSMENR.IOPDSMEN, I/O port D clock enable during Sleep               mode
: RCC.IOPSMENR.IOPFSMEN ( -- x addr ) 5 bit RCC.IOPSMENR ; \ RCC.IOPSMENR.IOPFSMEN, I/O port F clock enable during Sleep               mode

\ RCC.AHBSMENR (read-write) Reset:$00000000
: RCC.AHBSMENR.DMASMEN ( -- x addr ) 0 bit RCC.AHBSMENR ; \ RCC.AHBSMENR.DMASMEN, DMA clock enable during Sleep               mode
: RCC.AHBSMENR.FLASHSMEN ( -- x addr ) 8 bit RCC.AHBSMENR ; \ RCC.AHBSMENR.FLASHSMEN, Flash memory interface clock enable               during Sleep mode
: RCC.AHBSMENR.SRAMSMEN ( -- x addr ) 9 bit RCC.AHBSMENR ; \ RCC.AHBSMENR.SRAMSMEN, SRAM clock enable during Sleep               mode
: RCC.AHBSMENR.CRCSMEN ( -- x addr ) 12 bit RCC.AHBSMENR ; \ RCC.AHBSMENR.CRCSMEN, CRC clock enable during Sleep               mode

\ RCC.APBSMENR1 (read-write) Reset:$00000000
: RCC.APBSMENR1.TIM2SMEN ( -- x addr ) 0 bit RCC.APBSMENR1 ; \ RCC.APBSMENR1.TIM2SMEN, TIM2 timer clock enable during Sleep               mode
: RCC.APBSMENR1.TIM3SMEN ( -- x addr ) 1 bit RCC.APBSMENR1 ; \ RCC.APBSMENR1.TIM3SMEN, TIM3 timer clock enable during Sleep               mode
: RCC.APBSMENR1.RTCAPBSMEN ( -- x addr ) 10 bit RCC.APBSMENR1 ; \ RCC.APBSMENR1.RTCAPBSMEN, RTC APB clock enable during Sleep               mode
: RCC.APBSMENR1.WWDGSMEN ( -- x addr ) 11 bit RCC.APBSMENR1 ; \ RCC.APBSMENR1.WWDGSMEN, WWDG clock enable during Sleep               mode
: RCC.APBSMENR1.SPI2SMEN ( -- x addr ) 14 bit RCC.APBSMENR1 ; \ RCC.APBSMENR1.SPI2SMEN, SPI2 clock enable during Sleep               mode
: RCC.APBSMENR1.USART2SMEN ( -- x addr ) 17 bit RCC.APBSMENR1 ; \ RCC.APBSMENR1.USART2SMEN, USART2 clock enable during Sleep               mode
: RCC.APBSMENR1.I2C1SMEN ( -- x addr ) 21 bit RCC.APBSMENR1 ; \ RCC.APBSMENR1.I2C1SMEN, I2C1 clock enable during Sleep               mode
: RCC.APBSMENR1.I2C2SMEN ( -- x addr ) 22 bit RCC.APBSMENR1 ; \ RCC.APBSMENR1.I2C2SMEN, I2C2 clock enable during Sleep               mode
: RCC.APBSMENR1.DBGSMEN ( -- x addr ) 27 bit RCC.APBSMENR1 ; \ RCC.APBSMENR1.DBGSMEN, Debug support clock enable during Sleep               mode
: RCC.APBSMENR1.PWRSMEN ( -- x addr ) 28 bit RCC.APBSMENR1 ; \ RCC.APBSMENR1.PWRSMEN, Power interface clock enable during               Sleep mode

\ RCC.APBSMENR2 (read-write) Reset:$00000000
: RCC.APBSMENR2.SYSCFGSMEN ( -- x addr ) 0 bit RCC.APBSMENR2 ; \ RCC.APBSMENR2.SYSCFGSMEN, SYSCFG, COMP and VREFBUF clock enable               during Sleep mode
: RCC.APBSMENR2.TIM1SMEN ( -- x addr ) 11 bit RCC.APBSMENR2 ; \ RCC.APBSMENR2.TIM1SMEN, TIM1 timer clock enable during Sleep               mode
: RCC.APBSMENR2.SPI1SMEN ( -- x addr ) 12 bit RCC.APBSMENR2 ; \ RCC.APBSMENR2.SPI1SMEN, SPI1 clock enable during Sleep               mode
: RCC.APBSMENR2.USART1SMEN ( -- x addr ) 14 bit RCC.APBSMENR2 ; \ RCC.APBSMENR2.USART1SMEN, USART1 clock enable during Sleep               mode
: RCC.APBSMENR2.TIM14SMEN ( -- x addr ) 15 bit RCC.APBSMENR2 ; \ RCC.APBSMENR2.TIM14SMEN, TIM14 timer clock enable during Sleep               mode
: RCC.APBSMENR2.TIM16SMEN ( -- x addr ) 17 bit RCC.APBSMENR2 ; \ RCC.APBSMENR2.TIM16SMEN, TIM16 timer clock enable during Sleep               mode
: RCC.APBSMENR2.TIM17SMEN ( -- x addr ) 18 bit RCC.APBSMENR2 ; \ RCC.APBSMENR2.TIM17SMEN, TIM16 timer clock enable during Sleep               mode
: RCC.APBSMENR2.ADCSMEN ( -- x addr ) 20 bit RCC.APBSMENR2 ; \ RCC.APBSMENR2.ADCSMEN, ADC clock enable during Sleep               mode

\ RCC.CCIPR (read-write) Reset:$00000000
: RCC.CCIPR.USART1SEL ( %bb -- x addr ) RCC.CCIPR ; \ RCC.CCIPR.USART1SEL, USART1 clock source               selection
: RCC.CCIPR.I2C1SEL ( %bb -- x addr ) 12 lshift RCC.CCIPR ; \ RCC.CCIPR.I2C1SEL, I2C1 clock source               selection
: RCC.CCIPR.I2S2SEL ( %bb -- x addr ) 14 lshift RCC.CCIPR ; \ RCC.CCIPR.I2S2SEL, I2S1 clock source               selection
: RCC.CCIPR.TIM1SEL ( -- x addr ) 22 bit RCC.CCIPR ; \ RCC.CCIPR.TIM1SEL, TIM1 clock source               selection
: RCC.CCIPR.RNGSEL ( %bb -- x addr ) 26 lshift RCC.CCIPR ; \ RCC.CCIPR.RNGSEL, RNG clock source selection
: RCC.CCIPR.RNGDIV ( %bb -- x addr ) 28 lshift RCC.CCIPR ; \ RCC.CCIPR.RNGDIV, Division factor of RNG clock               divider
: RCC.CCIPR.ADCSEL ( %bb -- x addr ) 30 lshift RCC.CCIPR ; \ RCC.CCIPR.ADCSEL, ADCs clock source               selection

\ RCC.BDCR (read-write) Reset:$00000000
: RCC.BDCR.LSEON ( -- x addr ) 0 bit RCC.BDCR ; \ RCC.BDCR.LSEON, LSE oscillator enable
: RCC.BDCR.LSERDY ( -- x addr ) 1 bit RCC.BDCR ; \ RCC.BDCR.LSERDY, LSE oscillator ready
: RCC.BDCR.LSEBYP ( -- x addr ) 2 bit RCC.BDCR ; \ RCC.BDCR.LSEBYP, LSE oscillator bypass
: RCC.BDCR.LSEDRV ( %bb -- x addr ) 3 lshift RCC.BDCR ; \ RCC.BDCR.LSEDRV, LSE oscillator drive               capability
: RCC.BDCR.LSECSSON ( -- x addr ) 5 bit RCC.BDCR ; \ RCC.BDCR.LSECSSON, CSS on LSE enable
: RCC.BDCR.LSECSSD ( -- x addr ) 6 bit RCC.BDCR ; \ RCC.BDCR.LSECSSD, CSS on LSE failure               Detection
: RCC.BDCR.RTCSEL ( %bb -- x addr ) 8 lshift RCC.BDCR ; \ RCC.BDCR.RTCSEL, RTC clock source selection
: RCC.BDCR.RTCEN ( -- x addr ) 15 bit RCC.BDCR ; \ RCC.BDCR.RTCEN, RTC clock enable
: RCC.BDCR.BDRST ( -- x addr ) 16 bit RCC.BDCR ; \ RCC.BDCR.BDRST, RTC domain software reset
: RCC.BDCR.LSCOEN ( -- x addr ) 24 bit RCC.BDCR ; \ RCC.BDCR.LSCOEN, Low-speed clock output (LSCO)               enable
: RCC.BDCR.LSCOSEL ( -- x addr ) 25 bit RCC.BDCR ; \ RCC.BDCR.LSCOSEL, Low-speed clock output               selection

\ RCC.CSR (read-write) Reset:$00000000
: RCC.CSR.LSION ( -- x addr ) 0 bit RCC.CSR ; \ RCC.CSR.LSION, LSI oscillator enable
: RCC.CSR.LSIRDY ( -- x addr ) 1 bit RCC.CSR ; \ RCC.CSR.LSIRDY, LSI oscillator ready
: RCC.CSR.RMVF ( -- x addr ) 23 bit RCC.CSR ; \ RCC.CSR.RMVF, Remove reset flags
: RCC.CSR.OBLRSTF ( -- x addr ) 25 bit RCC.CSR ; \ RCC.CSR.OBLRSTF, Option byte loader reset               flag
: RCC.CSR.PINRSTF ( -- x addr ) 26 bit RCC.CSR ; \ RCC.CSR.PINRSTF, Pin reset flag
: RCC.CSR.PWRRSTF ( -- x addr ) 27 bit RCC.CSR ; \ RCC.CSR.PWRRSTF, BOR or POR/PDR flag
: RCC.CSR.SFTRSTF ( -- x addr ) 28 bit RCC.CSR ; \ RCC.CSR.SFTRSTF, Software reset flag
: RCC.CSR.IWDGRSTF ( -- x addr ) 29 bit RCC.CSR ; \ RCC.CSR.IWDGRSTF, Independent window watchdog reset               flag
: RCC.CSR.WWDGRSTF ( -- x addr ) 30 bit RCC.CSR ; \ RCC.CSR.WWDGRSTF, Window watchdog reset flag
: RCC.CSR.LPWRRSTF ( -- x addr ) 31 bit RCC.CSR ; \ RCC.CSR.LPWRRSTF, Low-power reset flag

\ PWR.CR1 (read-write) Reset:$00000200
: PWR.CR1.LPR ( -- x addr ) 14 bit PWR.CR1 ; \ PWR.CR1.LPR, Low-power run
: PWR.CR1.VOS ( %bb -- x addr ) 9 lshift PWR.CR1 ; \ PWR.CR1.VOS, Voltage scaling range               selection
: PWR.CR1.DBP ( -- x addr ) 8 bit PWR.CR1 ; \ PWR.CR1.DBP, Disable backup domain write               protection
: PWR.CR1.FPD_LPSLP ( -- x addr ) 5 bit PWR.CR1 ; \ PWR.CR1.FPD_LPSLP, Flash memory powered down during               Low-power sleep mode
: PWR.CR1.FPD_LPRUN ( -- x addr ) 4 bit PWR.CR1 ; \ PWR.CR1.FPD_LPRUN, Flash memory powered down during               Low-power run mode
: PWR.CR1.FPD_STOP ( -- x addr ) 3 bit PWR.CR1 ; \ PWR.CR1.FPD_STOP, Flash memory powered down during Stop               mode
: PWR.CR1.LPMS ( %bbb -- x addr ) PWR.CR1 ; \ PWR.CR1.LPMS, Low-power mode selection

\ PWR.CR2 (read-write) Reset:$00000000
: PWR.CR2.PVDE ( -- x addr ) 0 bit PWR.CR2 ; \ PWR.CR2.PVDE, Power voltage detector               enable
: PWR.CR2.PVDFT ( %bbb -- x addr ) 1 lshift PWR.CR2 ; \ PWR.CR2.PVDFT, Power voltage detector falling threshold               selection
: PWR.CR2.PVDRT ( %bbb -- x addr ) 4 lshift PWR.CR2 ; \ PWR.CR2.PVDRT, Power voltage detector rising threshold               selection

\ PWR.CR3 (read-write) Reset:0X00008000
: PWR.CR3.EWUP1 ( -- x addr ) 0 bit PWR.CR3 ; \ PWR.CR3.EWUP1, Enable Wakeup pin WKUP1
: PWR.CR3.EWUP2 ( -- x addr ) 1 bit PWR.CR3 ; \ PWR.CR3.EWUP2, Enable Wakeup pin WKUP2
: PWR.CR3.EWUP4 ( -- x addr ) 3 bit PWR.CR3 ; \ PWR.CR3.EWUP4, Enable Wakeup pin WKUP4
: PWR.CR3.EWUP5 ( -- x addr ) 4 bit PWR.CR3 ; \ PWR.CR3.EWUP5, Enable WKUP5 wakeup pin
: PWR.CR3.EWUP6 ( -- x addr ) 5 bit PWR.CR3 ; \ PWR.CR3.EWUP6, Enable WKUP6 wakeup pin
: PWR.CR3.RRS ( -- x addr ) 8 bit PWR.CR3 ; \ PWR.CR3.RRS, SRAM retention in Standby               mode
: PWR.CR3.ULPEN ( -- x addr ) 9 bit PWR.CR3 ; \ PWR.CR3.ULPEN, Enable the periodical sampling mode for               PDR detection
: PWR.CR3.APC ( -- x addr ) 10 bit PWR.CR3 ; \ PWR.CR3.APC, Apply pull-up and pull-down               configuration
: PWR.CR3.EIWUL ( -- x addr ) 15 bit PWR.CR3 ; \ PWR.CR3.EIWUL, Enable internal wakeup               line

\ PWR.CR4 (read-write) Reset:$00000000
: PWR.CR4.WP1 ( -- x addr ) 0 bit PWR.CR4 ; \ PWR.CR4.WP1, Wakeup pin WKUP1 polarity
: PWR.CR4.WP2 ( -- x addr ) 1 bit PWR.CR4 ; \ PWR.CR4.WP2, Wakeup pin WKUP2 polarity
: PWR.CR4.WP4 ( -- x addr ) 3 bit PWR.CR4 ; \ PWR.CR4.WP4, Wakeup pin WKUP4 polarity
: PWR.CR4.WP5 ( -- x addr ) 4 bit PWR.CR4 ; \ PWR.CR4.WP5, Wakeup pin WKUP5 polarity
: PWR.CR4.WP6 ( -- x addr ) 5 bit PWR.CR4 ; \ PWR.CR4.WP6, WKUP6 wakeup pin polarity
: PWR.CR4.VBE ( -- x addr ) 8 bit PWR.CR4 ; \ PWR.CR4.VBE, VBAT battery charging               enable
: PWR.CR4.VBRS ( -- x addr ) 9 bit PWR.CR4 ; \ PWR.CR4.VBRS, VBAT battery charging resistor               selection

\ PWR.SR1 (read-only) Reset:$00000000
: PWR.SR1.WUF1? ( --  1|0 ) 0 bit PWR.SR1 bit@ ; \ PWR.SR1.WUF1, Wakeup flag 1
: PWR.SR1.WUF2? ( --  1|0 ) 1 bit PWR.SR1 bit@ ; \ PWR.SR1.WUF2, Wakeup flag 2
: PWR.SR1.WUF4? ( --  1|0 ) 3 bit PWR.SR1 bit@ ; \ PWR.SR1.WUF4, Wakeup flag 4
: PWR.SR1.WUF5? ( --  1|0 ) 4 bit PWR.SR1 bit@ ; \ PWR.SR1.WUF5, Wakeup flag 5
: PWR.SR1.WUF6? ( --  1|0 ) 5 bit PWR.SR1 bit@ ; \ PWR.SR1.WUF6, Wakeup flag 6
: PWR.SR1.SBF? ( --  1|0 ) 8 bit PWR.SR1 bit@ ; \ PWR.SR1.SBF, Standby flag
: PWR.SR1.WUFI? ( --  1|0 ) 15 bit PWR.SR1 bit@ ; \ PWR.SR1.WUFI, Wakeup flag internal

\ PWR.SR2 (read-only) Reset:$00000000
: PWR.SR2.PVDO? ( --  1|0 ) 11 bit PWR.SR2 bit@ ; \ PWR.SR2.PVDO, Power voltage detector               output
: PWR.SR2.VOSF? ( --  1|0 ) 10 bit PWR.SR2 bit@ ; \ PWR.SR2.VOSF, Voltage scaling flag
: PWR.SR2.REGLPF? ( --  1|0 ) 9 bit PWR.SR2 bit@ ; \ PWR.SR2.REGLPF, Low-power regulator flag
: PWR.SR2.REGLPS? ( --  1|0 ) 8 bit PWR.SR2 bit@ ; \ PWR.SR2.REGLPS, Low-power regulator               started
: PWR.SR2.FLASH_RDY? ( --  1|0 ) 7 bit PWR.SR2 bit@ ; \ PWR.SR2.FLASH_RDY, Flash ready flag

\ PWR.SCR (write-only) Reset:$00000000
: PWR.SCR.CSBF ( -- x addr ) 8 bit PWR.SCR ; \ PWR.SCR.CSBF, Clear standby flag
: PWR.SCR.CWUF6 ( -- x addr ) 5 bit PWR.SCR ; \ PWR.SCR.CWUF6, Clear wakeup flag 6
: PWR.SCR.CWUF5 ( -- x addr ) 4 bit PWR.SCR ; \ PWR.SCR.CWUF5, Clear wakeup flag 5
: PWR.SCR.CWUF4 ( -- x addr ) 3 bit PWR.SCR ; \ PWR.SCR.CWUF4, Clear wakeup flag 4
: PWR.SCR.CWUF2 ( -- x addr ) 1 bit PWR.SCR ; \ PWR.SCR.CWUF2, Clear wakeup flag 2
: PWR.SCR.CWUF1 ( -- x addr ) 0 bit PWR.SCR ; \ PWR.SCR.CWUF1, Clear wakeup flag 1

\ PWR.PUCRA (read-write) Reset:$00000000
: PWR.PUCRA.PU15 ( -- x addr ) 15 bit PWR.PUCRA ; \ PWR.PUCRA.PU15, Port A pull-up bit y               (y=0..15)
: PWR.PUCRA.PU14 ( -- x addr ) 14 bit PWR.PUCRA ; \ PWR.PUCRA.PU14, Port A pull-up bit y               (y=0..15)
: PWR.PUCRA.PU13 ( -- x addr ) 13 bit PWR.PUCRA ; \ PWR.PUCRA.PU13, Port A pull-up bit y               (y=0..15)
: PWR.PUCRA.PU12 ( -- x addr ) 12 bit PWR.PUCRA ; \ PWR.PUCRA.PU12, Port A pull-up bit y               (y=0..15)
: PWR.PUCRA.PU11 ( -- x addr ) 11 bit PWR.PUCRA ; \ PWR.PUCRA.PU11, Port A pull-up bit y               (y=0..15)
: PWR.PUCRA.PU10 ( -- x addr ) 10 bit PWR.PUCRA ; \ PWR.PUCRA.PU10, Port A pull-up bit y               (y=0..15)
: PWR.PUCRA.PU9 ( -- x addr ) 9 bit PWR.PUCRA ; \ PWR.PUCRA.PU9, Port A pull-up bit y               (y=0..15)
: PWR.PUCRA.PU8 ( -- x addr ) 8 bit PWR.PUCRA ; \ PWR.PUCRA.PU8, Port A pull-up bit y               (y=0..15)
: PWR.PUCRA.PU7 ( -- x addr ) 7 bit PWR.PUCRA ; \ PWR.PUCRA.PU7, Port A pull-up bit y               (y=0..15)
: PWR.PUCRA.PU6 ( -- x addr ) 6 bit PWR.PUCRA ; \ PWR.PUCRA.PU6, Port A pull-up bit y               (y=0..15)
: PWR.PUCRA.PU5 ( -- x addr ) 5 bit PWR.PUCRA ; \ PWR.PUCRA.PU5, Port A pull-up bit y               (y=0..15)
: PWR.PUCRA.PU4 ( -- x addr ) 4 bit PWR.PUCRA ; \ PWR.PUCRA.PU4, Port A pull-up bit y               (y=0..15)
: PWR.PUCRA.PU3 ( -- x addr ) 3 bit PWR.PUCRA ; \ PWR.PUCRA.PU3, Port A pull-up bit y               (y=0..15)
: PWR.PUCRA.PU2 ( -- x addr ) 2 bit PWR.PUCRA ; \ PWR.PUCRA.PU2, Port A pull-up bit y               (y=0..15)
: PWR.PUCRA.PU1 ( -- x addr ) 1 bit PWR.PUCRA ; \ PWR.PUCRA.PU1, Port A pull-up bit y               (y=0..15)
: PWR.PUCRA.PU0 ( -- x addr ) 0 bit PWR.PUCRA ; \ PWR.PUCRA.PU0, Port A pull-up bit y               (y=0..15)

\ PWR.PDCRA (read-write) Reset:$00000000
: PWR.PDCRA.PD15 ( -- x addr ) 15 bit PWR.PDCRA ; \ PWR.PDCRA.PD15, Port A pull-down bit y               (y=0..15)
: PWR.PDCRA.PD14 ( -- x addr ) 14 bit PWR.PDCRA ; \ PWR.PDCRA.PD14, Port A pull-down bit y               (y=0..15)
: PWR.PDCRA.PD13 ( -- x addr ) 13 bit PWR.PDCRA ; \ PWR.PDCRA.PD13, Port A pull-down bit y               (y=0..15)
: PWR.PDCRA.PD12 ( -- x addr ) 12 bit PWR.PDCRA ; \ PWR.PDCRA.PD12, Port A pull-down bit y               (y=0..15)
: PWR.PDCRA.PD11 ( -- x addr ) 11 bit PWR.PDCRA ; \ PWR.PDCRA.PD11, Port A pull-down bit y               (y=0..15)
: PWR.PDCRA.PD10 ( -- x addr ) 10 bit PWR.PDCRA ; \ PWR.PDCRA.PD10, Port A pull-down bit y               (y=0..15)
: PWR.PDCRA.PD9 ( -- x addr ) 9 bit PWR.PDCRA ; \ PWR.PDCRA.PD9, Port A pull-down bit y               (y=0..15)
: PWR.PDCRA.PD8 ( -- x addr ) 8 bit PWR.PDCRA ; \ PWR.PDCRA.PD8, Port A pull-down bit y               (y=0..15)
: PWR.PDCRA.PD7 ( -- x addr ) 7 bit PWR.PDCRA ; \ PWR.PDCRA.PD7, Port A pull-down bit y               (y=0..15)
: PWR.PDCRA.PD6 ( -- x addr ) 6 bit PWR.PDCRA ; \ PWR.PDCRA.PD6, Port A pull-down bit y               (y=0..15)
: PWR.PDCRA.PD5 ( -- x addr ) 5 bit PWR.PDCRA ; \ PWR.PDCRA.PD5, Port A pull-down bit y               (y=0..15)
: PWR.PDCRA.PD4 ( -- x addr ) 4 bit PWR.PDCRA ; \ PWR.PDCRA.PD4, Port A pull-down bit y               (y=0..15)
: PWR.PDCRA.PD3 ( -- x addr ) 3 bit PWR.PDCRA ; \ PWR.PDCRA.PD3, Port A pull-down bit y               (y=0..15)
: PWR.PDCRA.PD2 ( -- x addr ) 2 bit PWR.PDCRA ; \ PWR.PDCRA.PD2, Port A pull-down bit y               (y=0..15)
: PWR.PDCRA.PD1 ( -- x addr ) 1 bit PWR.PDCRA ; \ PWR.PDCRA.PD1, Port A pull-down bit y               (y=0..15)
: PWR.PDCRA.PD0 ( -- x addr ) 0 bit PWR.PDCRA ; \ PWR.PDCRA.PD0, Port A pull-down bit y               (y=0..15)

\ PWR.PUCRB (read-write) Reset:$00000000
: PWR.PUCRB.PU15 ( -- x addr ) 15 bit PWR.PUCRB ; \ PWR.PUCRB.PU15, Port B pull-up bit y               (y=0..15)
: PWR.PUCRB.PU14 ( -- x addr ) 14 bit PWR.PUCRB ; \ PWR.PUCRB.PU14, Port B pull-up bit y               (y=0..15)
: PWR.PUCRB.PU13 ( -- x addr ) 13 bit PWR.PUCRB ; \ PWR.PUCRB.PU13, Port B pull-up bit y               (y=0..15)
: PWR.PUCRB.PU12 ( -- x addr ) 12 bit PWR.PUCRB ; \ PWR.PUCRB.PU12, Port B pull-up bit y               (y=0..15)
: PWR.PUCRB.PU11 ( -- x addr ) 11 bit PWR.PUCRB ; \ PWR.PUCRB.PU11, Port B pull-up bit y               (y=0..15)
: PWR.PUCRB.PU10 ( -- x addr ) 10 bit PWR.PUCRB ; \ PWR.PUCRB.PU10, Port B pull-up bit y               (y=0..15)
: PWR.PUCRB.PU9 ( -- x addr ) 9 bit PWR.PUCRB ; \ PWR.PUCRB.PU9, Port B pull-up bit y               (y=0..15)
: PWR.PUCRB.PU8 ( -- x addr ) 8 bit PWR.PUCRB ; \ PWR.PUCRB.PU8, Port B pull-up bit y               (y=0..15)
: PWR.PUCRB.PU7 ( -- x addr ) 7 bit PWR.PUCRB ; \ PWR.PUCRB.PU7, Port B pull-up bit y               (y=0..15)
: PWR.PUCRB.PU6 ( -- x addr ) 6 bit PWR.PUCRB ; \ PWR.PUCRB.PU6, Port B pull-up bit y               (y=0..15)
: PWR.PUCRB.PU5 ( -- x addr ) 5 bit PWR.PUCRB ; \ PWR.PUCRB.PU5, Port B pull-up bit y               (y=0..15)
: PWR.PUCRB.PU4 ( -- x addr ) 4 bit PWR.PUCRB ; \ PWR.PUCRB.PU4, Port B pull-up bit y               (y=0..15)
: PWR.PUCRB.PU3 ( -- x addr ) 3 bit PWR.PUCRB ; \ PWR.PUCRB.PU3, Port B pull-up bit y               (y=0..15)
: PWR.PUCRB.PU2 ( -- x addr ) 2 bit PWR.PUCRB ; \ PWR.PUCRB.PU2, Port B pull-up bit y               (y=0..15)
: PWR.PUCRB.PU1 ( -- x addr ) 1 bit PWR.PUCRB ; \ PWR.PUCRB.PU1, Port B pull-up bit y               (y=0..15)
: PWR.PUCRB.PU0 ( -- x addr ) 0 bit PWR.PUCRB ; \ PWR.PUCRB.PU0, Port B pull-up bit y               (y=0..15)

\ PWR.PDCRB (read-write) Reset:$00000000
: PWR.PDCRB.PD15 ( -- x addr ) 15 bit PWR.PDCRB ; \ PWR.PDCRB.PD15, Port B pull-down bit y               (y=0..15)
: PWR.PDCRB.PD14 ( -- x addr ) 14 bit PWR.PDCRB ; \ PWR.PDCRB.PD14, Port B pull-down bit y               (y=0..15)
: PWR.PDCRB.PD13 ( -- x addr ) 13 bit PWR.PDCRB ; \ PWR.PDCRB.PD13, Port B pull-down bit y               (y=0..15)
: PWR.PDCRB.PD12 ( -- x addr ) 12 bit PWR.PDCRB ; \ PWR.PDCRB.PD12, Port B pull-down bit y               (y=0..15)
: PWR.PDCRB.PD11 ( -- x addr ) 11 bit PWR.PDCRB ; \ PWR.PDCRB.PD11, Port B pull-down bit y               (y=0..15)
: PWR.PDCRB.PD10 ( -- x addr ) 10 bit PWR.PDCRB ; \ PWR.PDCRB.PD10, Port B pull-down bit y               (y=0..15)
: PWR.PDCRB.PD9 ( -- x addr ) 9 bit PWR.PDCRB ; \ PWR.PDCRB.PD9, Port B pull-down bit y               (y=0..15)
: PWR.PDCRB.PD8 ( -- x addr ) 8 bit PWR.PDCRB ; \ PWR.PDCRB.PD8, Port B pull-down bit y               (y=0..15)
: PWR.PDCRB.PD7 ( -- x addr ) 7 bit PWR.PDCRB ; \ PWR.PDCRB.PD7, Port B pull-down bit y               (y=0..15)
: PWR.PDCRB.PD6 ( -- x addr ) 6 bit PWR.PDCRB ; \ PWR.PDCRB.PD6, Port B pull-down bit y               (y=0..15)
: PWR.PDCRB.PD5 ( -- x addr ) 5 bit PWR.PDCRB ; \ PWR.PDCRB.PD5, Port B pull-down bit y               (y=0..15)
: PWR.PDCRB.PD4 ( -- x addr ) 4 bit PWR.PDCRB ; \ PWR.PDCRB.PD4, Port B pull-down bit y               (y=0..15)
: PWR.PDCRB.PD3 ( -- x addr ) 3 bit PWR.PDCRB ; \ PWR.PDCRB.PD3, Port B pull-down bit y               (y=0..15)
: PWR.PDCRB.PD2 ( -- x addr ) 2 bit PWR.PDCRB ; \ PWR.PDCRB.PD2, Port B pull-down bit y               (y=0..15)
: PWR.PDCRB.PD1 ( -- x addr ) 1 bit PWR.PDCRB ; \ PWR.PDCRB.PD1, Port B pull-down bit y               (y=0..15)
: PWR.PDCRB.PD0 ( -- x addr ) 0 bit PWR.PDCRB ; \ PWR.PDCRB.PD0, Port B pull-down bit y               (y=0..15)

\ PWR.PUCRC (read-write) Reset:$00000000
: PWR.PUCRC.PU15 ( -- x addr ) 15 bit PWR.PUCRC ; \ PWR.PUCRC.PU15, Port C pull-up bit y               (y=0..15)
: PWR.PUCRC.PU14 ( -- x addr ) 14 bit PWR.PUCRC ; \ PWR.PUCRC.PU14, Port C pull-up bit y               (y=0..15)
: PWR.PUCRC.PU13 ( -- x addr ) 13 bit PWR.PUCRC ; \ PWR.PUCRC.PU13, Port C pull-up bit y               (y=0..15)
: PWR.PUCRC.PU7 ( -- x addr ) 7 bit PWR.PUCRC ; \ PWR.PUCRC.PU7, Port C pull-up bit y               (y=0..15)
: PWR.PUCRC.PU6 ( -- x addr ) 6 bit PWR.PUCRC ; \ PWR.PUCRC.PU6, Port C pull-up bit y               (y=0..15)

\ PWR.PDCRC (read-write) Reset:$00000000
: PWR.PDCRC.PD15 ( -- x addr ) 15 bit PWR.PDCRC ; \ PWR.PDCRC.PD15, Port C pull-down bit y               (y=0..15)
: PWR.PDCRC.PD14 ( -- x addr ) 14 bit PWR.PDCRC ; \ PWR.PDCRC.PD14, Port C pull-down bit y               (y=0..15)
: PWR.PDCRC.PD13 ( -- x addr ) 13 bit PWR.PDCRC ; \ PWR.PDCRC.PD13, Port C pull-down bit y               (y=0..15)
: PWR.PDCRC.PD12 ( -- x addr ) 12 bit PWR.PDCRC ; \ PWR.PDCRC.PD12, Port C pull-down bit y               (y=0..15)
: PWR.PDCRC.PD11 ( -- x addr ) 11 bit PWR.PDCRC ; \ PWR.PDCRC.PD11, Port C pull-down bit y               (y=0..15)
: PWR.PDCRC.PD10 ( -- x addr ) 10 bit PWR.PDCRC ; \ PWR.PDCRC.PD10, Port C pull-down bit y               (y=0..15)
: PWR.PDCRC.PD9 ( -- x addr ) 9 bit PWR.PDCRC ; \ PWR.PDCRC.PD9, Port C pull-down bit y               (y=0..15)
: PWR.PDCRC.PD8 ( -- x addr ) 8 bit PWR.PDCRC ; \ PWR.PDCRC.PD8, Port C pull-down bit y               (y=0..15)
: PWR.PDCRC.PD7 ( -- x addr ) 7 bit PWR.PDCRC ; \ PWR.PDCRC.PD7, Port C pull-down bit y               (y=0..15)
: PWR.PDCRC.PD6 ( -- x addr ) 6 bit PWR.PDCRC ; \ PWR.PDCRC.PD6, Port C pull-down bit y               (y=0..15)
: PWR.PDCRC.PD5 ( -- x addr ) 5 bit PWR.PDCRC ; \ PWR.PDCRC.PD5, Port C pull-down bit y               (y=0..15)
: PWR.PDCRC.PD4 ( -- x addr ) 4 bit PWR.PDCRC ; \ PWR.PDCRC.PD4, Port C pull-down bit y               (y=0..15)
: PWR.PDCRC.PD3 ( -- x addr ) 3 bit PWR.PDCRC ; \ PWR.PDCRC.PD3, Port C pull-down bit y               (y=0..15)
: PWR.PDCRC.PD2 ( -- x addr ) 2 bit PWR.PDCRC ; \ PWR.PDCRC.PD2, Port C pull-down bit y               (y=0..15)
: PWR.PDCRC.PD1 ( -- x addr ) 1 bit PWR.PDCRC ; \ PWR.PDCRC.PD1, Port C pull-down bit y               (y=0..15)
: PWR.PDCRC.PD0 ( -- x addr ) 0 bit PWR.PDCRC ; \ PWR.PDCRC.PD0, Port C pull-down bit y               (y=0..15)

\ PWR.PUCRD (read-write) Reset:$00000000
: PWR.PUCRD.PU3 ( -- x addr ) 3 bit PWR.PUCRD ; \ PWR.PUCRD.PU3, Port D pull-up bit y               (y=0..15)
: PWR.PUCRD.PU2 ( -- x addr ) 2 bit PWR.PUCRD ; \ PWR.PUCRD.PU2, Port D pull-up bit y               (y=0..15)
: PWR.PUCRD.PU1 ( -- x addr ) 1 bit PWR.PUCRD ; \ PWR.PUCRD.PU1, Port D pull-up bit y               (y=0..15)
: PWR.PUCRD.PU0 ( -- x addr ) 0 bit PWR.PUCRD ; \ PWR.PUCRD.PU0, Port D pull-up bit y               (y=0..15)

\ PWR.PDCRD (read-write) Reset:$00000000
: PWR.PDCRD.PD9 ( -- x addr ) 9 bit PWR.PDCRD ; \ PWR.PDCRD.PD9, Port D pull-down bit y               (y=0..15)
: PWR.PDCRD.PD8 ( -- x addr ) 8 bit PWR.PDCRD ; \ PWR.PDCRD.PD8, Port D pull-down bit y               (y=0..15)
: PWR.PDCRD.PD6 ( -- x addr ) 6 bit PWR.PDCRD ; \ PWR.PDCRD.PD6, Port D pull-down bit y               (y=0..15)
: PWR.PDCRD.PD5 ( -- x addr ) 5 bit PWR.PDCRD ; \ PWR.PDCRD.PD5, Port D pull-down bit y               (y=0..15)
: PWR.PDCRD.PD4 ( -- x addr ) 4 bit PWR.PDCRD ; \ PWR.PDCRD.PD4, Port D pull-down bit y               (y=0..15)
: PWR.PDCRD.PD3 ( -- x addr ) 3 bit PWR.PDCRD ; \ PWR.PDCRD.PD3, Port D pull-down bit y               (y=0..15)
: PWR.PDCRD.PD2 ( -- x addr ) 2 bit PWR.PDCRD ; \ PWR.PDCRD.PD2, Port D pull-down bit y               (y=0..15)
: PWR.PDCRD.PD1 ( -- x addr ) 1 bit PWR.PDCRD ; \ PWR.PDCRD.PD1, Port D pull-down bit y               (y=0..15)
: PWR.PDCRD.PD0 ( -- x addr ) 0 bit PWR.PDCRD ; \ PWR.PDCRD.PD0, Port D pull-down bit y               (y=0..15)

\ PWR.PUCRF (read-write) Reset:$00000000
: PWR.PUCRF.PU2 ( -- x addr ) 2 bit PWR.PUCRF ; \ PWR.PUCRF.PU2, Port F pull-up bit y               (y=0..15)
: PWR.PUCRF.PU1 ( -- x addr ) 1 bit PWR.PUCRF ; \ PWR.PUCRF.PU1, Port F pull-up bit y               (y=0..15)
: PWR.PUCRF.PU0 ( -- x addr ) 0 bit PWR.PUCRF ; \ PWR.PUCRF.PU0, Port F pull-up bit y               (y=0..15)

\ PWR.PDCRF (read-write) Reset:$00000000
: PWR.PDCRF.PD2 ( -- x addr ) 2 bit PWR.PDCRF ; \ PWR.PDCRF.PD2, Port F pull-down bit y               (y=0..15)
: PWR.PDCRF.PD1 ( -- x addr ) 1 bit PWR.PDCRF ; \ PWR.PDCRF.PD1, Port F pull-down bit y               (y=0..15)
: PWR.PDCRF.PD0 ( -- x addr ) 0 bit PWR.PDCRF ; \ PWR.PDCRF.PD0, Port F pull-down bit y               (y=0..15)

\ DMA.ISR (read-only) Reset:$00000000
: DMA.ISR.GIF0? ( --  1|0 ) 0 bit DMA.ISR bit@ ; \ DMA.ISR.GIF0, Channel global interrupt               flag
: DMA.ISR.TCIF1? ( --  1|0 ) 1 bit DMA.ISR bit@ ; \ DMA.ISR.TCIF1, Channel transfer complete               flag
: DMA.ISR.HTIF2? ( --  1|0 ) 2 bit DMA.ISR bit@ ; \ DMA.ISR.HTIF2, Channel half transfer flag
: DMA.ISR.TEIF3? ( --  1|0 ) 3 bit DMA.ISR bit@ ; \ DMA.ISR.TEIF3, Channel transfer error               flag
: DMA.ISR.GIF4? ( --  1|0 ) 4 bit DMA.ISR bit@ ; \ DMA.ISR.GIF4, Channel global interrupt               flag
: DMA.ISR.TCIF5? ( --  1|0 ) 5 bit DMA.ISR bit@ ; \ DMA.ISR.TCIF5, Channel transfer complete               flag
: DMA.ISR.HTIF6? ( --  1|0 ) 6 bit DMA.ISR bit@ ; \ DMA.ISR.HTIF6, Channel half transfer flag
: DMA.ISR.TEIF7? ( --  1|0 ) 7 bit DMA.ISR bit@ ; \ DMA.ISR.TEIF7, Channel transfer error               flag
: DMA.ISR.GIF8? ( --  1|0 ) 8 bit DMA.ISR bit@ ; \ DMA.ISR.GIF8, Channel global interrupt               flag
: DMA.ISR.TCIF9? ( --  1|0 ) 9 bit DMA.ISR bit@ ; \ DMA.ISR.TCIF9, Channel transfer complete               flag
: DMA.ISR.HTIF10? ( --  1|0 ) 10 bit DMA.ISR bit@ ; \ DMA.ISR.HTIF10, Channel half transfer flag
: DMA.ISR.TEIF11? ( --  1|0 ) 11 bit DMA.ISR bit@ ; \ DMA.ISR.TEIF11, Channel transfer error               flag
: DMA.ISR.GIF12? ( --  1|0 ) 12 bit DMA.ISR bit@ ; \ DMA.ISR.GIF12, Channel global interrupt               flag
: DMA.ISR.TCIF13? ( --  1|0 ) 13 bit DMA.ISR bit@ ; \ DMA.ISR.TCIF13, Channel transfer complete               flag
: DMA.ISR.HTIF14? ( --  1|0 ) 14 bit DMA.ISR bit@ ; \ DMA.ISR.HTIF14, Channel half transfer flag
: DMA.ISR.TEIF15? ( --  1|0 ) 15 bit DMA.ISR bit@ ; \ DMA.ISR.TEIF15, Channel transfer error               flag
: DMA.ISR.GIF16? ( --  1|0 ) 16 bit DMA.ISR bit@ ; \ DMA.ISR.GIF16, Channel global interrupt               flag
: DMA.ISR.TCIF17? ( --  1|0 ) 17 bit DMA.ISR bit@ ; \ DMA.ISR.TCIF17, Channel transfer complete               flag
: DMA.ISR.HTIF18? ( --  1|0 ) 18 bit DMA.ISR bit@ ; \ DMA.ISR.HTIF18, Channel half transfer flag
: DMA.ISR.TEIF19? ( --  1|0 ) 19 bit DMA.ISR bit@ ; \ DMA.ISR.TEIF19, Channel transfer error               flag
: DMA.ISR.GIF20? ( --  1|0 ) 20 bit DMA.ISR bit@ ; \ DMA.ISR.GIF20, Channel global interrupt               flag
: DMA.ISR.TCIF21? ( --  1|0 ) 21 bit DMA.ISR bit@ ; \ DMA.ISR.TCIF21, Channel transfer complete               flag
: DMA.ISR.HTIF22? ( --  1|0 ) 22 bit DMA.ISR bit@ ; \ DMA.ISR.HTIF22, Channel half transfer flag
: DMA.ISR.TEIF23? ( --  1|0 ) 23 bit DMA.ISR bit@ ; \ DMA.ISR.TEIF23, Channel transfer error               flag
: DMA.ISR.GIF24? ( --  1|0 ) 24 bit DMA.ISR bit@ ; \ DMA.ISR.GIF24, Channel global interrupt               flag
: DMA.ISR.TCIF25? ( --  1|0 ) 25 bit DMA.ISR bit@ ; \ DMA.ISR.TCIF25, Channel transfer complete               flag
: DMA.ISR.HTIF26? ( --  1|0 ) 26 bit DMA.ISR bit@ ; \ DMA.ISR.HTIF26, Channel half transfer flag
: DMA.ISR.TEIF27? ( --  1|0 ) 27 bit DMA.ISR bit@ ; \ DMA.ISR.TEIF27, Channel transfer error               flag

\ DMA.IFCR (read-only) Reset:$00000000
: DMA.IFCR.CGIF0? ( --  1|0 ) 0 bit DMA.IFCR bit@ ; \ DMA.IFCR.CGIF0, Channel global interrupt               flag
: DMA.IFCR.CTCIF1? ( --  1|0 ) 1 bit DMA.IFCR bit@ ; \ DMA.IFCR.CTCIF1, Channel transfer complete               flag
: DMA.IFCR.CHTIF2? ( --  1|0 ) 2 bit DMA.IFCR bit@ ; \ DMA.IFCR.CHTIF2, Channel half transfer flag
: DMA.IFCR.CTEIF3? ( --  1|0 ) 3 bit DMA.IFCR bit@ ; \ DMA.IFCR.CTEIF3, Channel transfer error               flag
: DMA.IFCR.CGIF4? ( --  1|0 ) 4 bit DMA.IFCR bit@ ; \ DMA.IFCR.CGIF4, Channel global interrupt               flag
: DMA.IFCR.CTCIF5? ( --  1|0 ) 5 bit DMA.IFCR bit@ ; \ DMA.IFCR.CTCIF5, Channel transfer complete               flag
: DMA.IFCR.CHTIF6? ( --  1|0 ) 6 bit DMA.IFCR bit@ ; \ DMA.IFCR.CHTIF6, Channel half transfer flag
: DMA.IFCR.CTEIF7? ( --  1|0 ) 7 bit DMA.IFCR bit@ ; \ DMA.IFCR.CTEIF7, Channel transfer error               flag
: DMA.IFCR.CGIF8? ( --  1|0 ) 8 bit DMA.IFCR bit@ ; \ DMA.IFCR.CGIF8, Channel global interrupt               flag
: DMA.IFCR.CTCIF9? ( --  1|0 ) 9 bit DMA.IFCR bit@ ; \ DMA.IFCR.CTCIF9, Channel transfer complete               flag
: DMA.IFCR.CHTIF10? ( --  1|0 ) 10 bit DMA.IFCR bit@ ; \ DMA.IFCR.CHTIF10, Channel half transfer flag
: DMA.IFCR.CTEIF11? ( --  1|0 ) 11 bit DMA.IFCR bit@ ; \ DMA.IFCR.CTEIF11, Channel transfer error               flag
: DMA.IFCR.CGIF12? ( --  1|0 ) 12 bit DMA.IFCR bit@ ; \ DMA.IFCR.CGIF12, Channel global interrupt               flag
: DMA.IFCR.CTCIF13? ( --  1|0 ) 13 bit DMA.IFCR bit@ ; \ DMA.IFCR.CTCIF13, Channel transfer complete               flag
: DMA.IFCR.CHTIF14? ( --  1|0 ) 14 bit DMA.IFCR bit@ ; \ DMA.IFCR.CHTIF14, Channel half transfer flag
: DMA.IFCR.CTEIF15? ( --  1|0 ) 15 bit DMA.IFCR bit@ ; \ DMA.IFCR.CTEIF15, Channel transfer error               flag
: DMA.IFCR.CGIF16? ( --  1|0 ) 16 bit DMA.IFCR bit@ ; \ DMA.IFCR.CGIF16, Channel global interrupt               flag
: DMA.IFCR.CTCIF17? ( --  1|0 ) 17 bit DMA.IFCR bit@ ; \ DMA.IFCR.CTCIF17, Channel transfer complete               flag
: DMA.IFCR.CHTIF18? ( --  1|0 ) 18 bit DMA.IFCR bit@ ; \ DMA.IFCR.CHTIF18, Channel half transfer flag
: DMA.IFCR.CTEIF19? ( --  1|0 ) 19 bit DMA.IFCR bit@ ; \ DMA.IFCR.CTEIF19, Channel transfer error               flag
: DMA.IFCR.CGIF20? ( --  1|0 ) 20 bit DMA.IFCR bit@ ; \ DMA.IFCR.CGIF20, Channel global interrupt               flag
: DMA.IFCR.CTCIF21? ( --  1|0 ) 21 bit DMA.IFCR bit@ ; \ DMA.IFCR.CTCIF21, Channel transfer complete               flag
: DMA.IFCR.CHTIF22? ( --  1|0 ) 22 bit DMA.IFCR bit@ ; \ DMA.IFCR.CHTIF22, Channel half transfer flag
: DMA.IFCR.CTEIF23? ( --  1|0 ) 23 bit DMA.IFCR bit@ ; \ DMA.IFCR.CTEIF23, Channel transfer error               flag
: DMA.IFCR.CGIF24? ( --  1|0 ) 24 bit DMA.IFCR bit@ ; \ DMA.IFCR.CGIF24, Channel global interrupt               flag
: DMA.IFCR.CTCIF25? ( --  1|0 ) 25 bit DMA.IFCR bit@ ; \ DMA.IFCR.CTCIF25, Channel transfer complete               flag
: DMA.IFCR.CHTIF26? ( --  1|0 ) 26 bit DMA.IFCR bit@ ; \ DMA.IFCR.CHTIF26, Channel half transfer flag
: DMA.IFCR.CTEIF27? ( --  1|0 ) 27 bit DMA.IFCR bit@ ; \ DMA.IFCR.CTEIF27, Channel transfer error               flag

\ DMA.CCR1 (read-write) Reset:$00000000
: DMA.CCR1.EN ( -- x addr ) 0 bit DMA.CCR1 ; \ DMA.CCR1.EN, Channel enable
: DMA.CCR1.TCIE ( -- x addr ) 1 bit DMA.CCR1 ; \ DMA.CCR1.TCIE, Transfer complete interrupt               enable
: DMA.CCR1.HTIE ( -- x addr ) 2 bit DMA.CCR1 ; \ DMA.CCR1.HTIE, Half transfer interrupt               enable
: DMA.CCR1.TEIE ( -- x addr ) 3 bit DMA.CCR1 ; \ DMA.CCR1.TEIE, Transfer error interrupt               enable
: DMA.CCR1.DIR ( -- x addr ) 4 bit DMA.CCR1 ; \ DMA.CCR1.DIR, Data transfer direction
: DMA.CCR1.CIRC ( -- x addr ) 5 bit DMA.CCR1 ; \ DMA.CCR1.CIRC, Circular mode
: DMA.CCR1.PINC ( -- x addr ) 6 bit DMA.CCR1 ; \ DMA.CCR1.PINC, Peripheral increment mode
: DMA.CCR1.MINC ( -- x addr ) 7 bit DMA.CCR1 ; \ DMA.CCR1.MINC, Memory increment mode
: DMA.CCR1.PSIZE ( %bb -- x addr ) 8 lshift DMA.CCR1 ; \ DMA.CCR1.PSIZE, Peripheral size
: DMA.CCR1.MSIZE ( %bb -- x addr ) 10 lshift DMA.CCR1 ; \ DMA.CCR1.MSIZE, Memory size
: DMA.CCR1.PL ( %bb -- x addr ) 12 lshift DMA.CCR1 ; \ DMA.CCR1.PL, Channel priority level
: DMA.CCR1.MEM2MEM ( -- x addr ) 14 bit DMA.CCR1 ; \ DMA.CCR1.MEM2MEM, Memory to memory mode

\ DMA.CCR2 (read-write) Reset:$00000000
: DMA.CCR2.EN ( -- x addr ) 0 bit DMA.CCR2 ; \ DMA.CCR2.EN, Channel enable
: DMA.CCR2.TCIE ( -- x addr ) 1 bit DMA.CCR2 ; \ DMA.CCR2.TCIE, Transfer complete interrupt               enable
: DMA.CCR2.HTIE ( -- x addr ) 2 bit DMA.CCR2 ; \ DMA.CCR2.HTIE, Half transfer interrupt               enable
: DMA.CCR2.TEIE ( -- x addr ) 3 bit DMA.CCR2 ; \ DMA.CCR2.TEIE, Transfer error interrupt               enable
: DMA.CCR2.DIR ( -- x addr ) 4 bit DMA.CCR2 ; \ DMA.CCR2.DIR, Data transfer direction
: DMA.CCR2.CIRC ( -- x addr ) 5 bit DMA.CCR2 ; \ DMA.CCR2.CIRC, Circular mode
: DMA.CCR2.PINC ( -- x addr ) 6 bit DMA.CCR2 ; \ DMA.CCR2.PINC, Peripheral increment mode
: DMA.CCR2.MINC ( -- x addr ) 7 bit DMA.CCR2 ; \ DMA.CCR2.MINC, Memory increment mode
: DMA.CCR2.PSIZE ( %bb -- x addr ) 8 lshift DMA.CCR2 ; \ DMA.CCR2.PSIZE, Peripheral size
: DMA.CCR2.MSIZE ( %bb -- x addr ) 10 lshift DMA.CCR2 ; \ DMA.CCR2.MSIZE, Memory size
: DMA.CCR2.PL ( %bb -- x addr ) 12 lshift DMA.CCR2 ; \ DMA.CCR2.PL, Channel priority level
: DMA.CCR2.MEM2MEM ( -- x addr ) 14 bit DMA.CCR2 ; \ DMA.CCR2.MEM2MEM, Memory to memory mode

\ DMA.CCR3 (read-write) Reset:$00000000
: DMA.CCR3.EN ( -- x addr ) 0 bit DMA.CCR3 ; \ DMA.CCR3.EN, Channel enable
: DMA.CCR3.TCIE ( -- x addr ) 1 bit DMA.CCR3 ; \ DMA.CCR3.TCIE, Transfer complete interrupt               enable
: DMA.CCR3.HTIE ( -- x addr ) 2 bit DMA.CCR3 ; \ DMA.CCR3.HTIE, Half transfer interrupt               enable
: DMA.CCR3.TEIE ( -- x addr ) 3 bit DMA.CCR3 ; \ DMA.CCR3.TEIE, Transfer error interrupt               enable
: DMA.CCR3.DIR ( -- x addr ) 4 bit DMA.CCR3 ; \ DMA.CCR3.DIR, Data transfer direction
: DMA.CCR3.CIRC ( -- x addr ) 5 bit DMA.CCR3 ; \ DMA.CCR3.CIRC, Circular mode
: DMA.CCR3.PINC ( -- x addr ) 6 bit DMA.CCR3 ; \ DMA.CCR3.PINC, Peripheral increment mode
: DMA.CCR3.MINC ( -- x addr ) 7 bit DMA.CCR3 ; \ DMA.CCR3.MINC, Memory increment mode
: DMA.CCR3.PSIZE ( %bb -- x addr ) 8 lshift DMA.CCR3 ; \ DMA.CCR3.PSIZE, Peripheral size
: DMA.CCR3.MSIZE ( %bb -- x addr ) 10 lshift DMA.CCR3 ; \ DMA.CCR3.MSIZE, Memory size
: DMA.CCR3.PL ( %bb -- x addr ) 12 lshift DMA.CCR3 ; \ DMA.CCR3.PL, Channel priority level
: DMA.CCR3.MEM2MEM ( -- x addr ) 14 bit DMA.CCR3 ; \ DMA.CCR3.MEM2MEM, Memory to memory mode

\ DMA.CCR4 (read-write) Reset:$00000000
: DMA.CCR4.EN ( -- x addr ) 0 bit DMA.CCR4 ; \ DMA.CCR4.EN, Channel enable
: DMA.CCR4.TCIE ( -- x addr ) 1 bit DMA.CCR4 ; \ DMA.CCR4.TCIE, Transfer complete interrupt               enable
: DMA.CCR4.HTIE ( -- x addr ) 2 bit DMA.CCR4 ; \ DMA.CCR4.HTIE, Half transfer interrupt               enable
: DMA.CCR4.TEIE ( -- x addr ) 3 bit DMA.CCR4 ; \ DMA.CCR4.TEIE, Transfer error interrupt               enable
: DMA.CCR4.DIR ( -- x addr ) 4 bit DMA.CCR4 ; \ DMA.CCR4.DIR, Data transfer direction
: DMA.CCR4.CIRC ( -- x addr ) 5 bit DMA.CCR4 ; \ DMA.CCR4.CIRC, Circular mode
: DMA.CCR4.PINC ( -- x addr ) 6 bit DMA.CCR4 ; \ DMA.CCR4.PINC, Peripheral increment mode
: DMA.CCR4.MINC ( -- x addr ) 7 bit DMA.CCR4 ; \ DMA.CCR4.MINC, Memory increment mode
: DMA.CCR4.PSIZE ( %bb -- x addr ) 8 lshift DMA.CCR4 ; \ DMA.CCR4.PSIZE, Peripheral size
: DMA.CCR4.MSIZE ( %bb -- x addr ) 10 lshift DMA.CCR4 ; \ DMA.CCR4.MSIZE, Memory size
: DMA.CCR4.PL ( %bb -- x addr ) 12 lshift DMA.CCR4 ; \ DMA.CCR4.PL, Channel priority level
: DMA.CCR4.MEM2MEM ( -- x addr ) 14 bit DMA.CCR4 ; \ DMA.CCR4.MEM2MEM, Memory to memory mode

\ DMA.CCR5 (read-write) Reset:$00000000
: DMA.CCR5.EN ( -- x addr ) 0 bit DMA.CCR5 ; \ DMA.CCR5.EN, Channel enable
: DMA.CCR5.TCIE ( -- x addr ) 1 bit DMA.CCR5 ; \ DMA.CCR5.TCIE, Transfer complete interrupt               enable
: DMA.CCR5.HTIE ( -- x addr ) 2 bit DMA.CCR5 ; \ DMA.CCR5.HTIE, Half transfer interrupt               enable
: DMA.CCR5.TEIE ( -- x addr ) 3 bit DMA.CCR5 ; \ DMA.CCR5.TEIE, Transfer error interrupt               enable
: DMA.CCR5.DIR ( -- x addr ) 4 bit DMA.CCR5 ; \ DMA.CCR5.DIR, Data transfer direction
: DMA.CCR5.CIRC ( -- x addr ) 5 bit DMA.CCR5 ; \ DMA.CCR5.CIRC, Circular mode
: DMA.CCR5.PINC ( -- x addr ) 6 bit DMA.CCR5 ; \ DMA.CCR5.PINC, Peripheral increment mode
: DMA.CCR5.MINC ( -- x addr ) 7 bit DMA.CCR5 ; \ DMA.CCR5.MINC, Memory increment mode
: DMA.CCR5.PSIZE ( %bb -- x addr ) 8 lshift DMA.CCR5 ; \ DMA.CCR5.PSIZE, Peripheral size
: DMA.CCR5.MSIZE ( %bb -- x addr ) 10 lshift DMA.CCR5 ; \ DMA.CCR5.MSIZE, Memory size
: DMA.CCR5.PL ( %bb -- x addr ) 12 lshift DMA.CCR5 ; \ DMA.CCR5.PL, Channel priority level
: DMA.CCR5.MEM2MEM ( -- x addr ) 14 bit DMA.CCR5 ; \ DMA.CCR5.MEM2MEM, Memory to memory mode

\ DMA.CNDTR1 (read-write) Reset:$00000000
: DMA.CNDTR1.NDT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA.CNDTR1 ; \ DMA.CNDTR1.NDT, Number of data to transfer

\ DMA.CNDTR2 (read-write) Reset:$00000000
: DMA.CNDTR2.NDT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA.CNDTR2 ; \ DMA.CNDTR2.NDT, Number of data to transfer

\ DMA.CNDTR3 (read-write) Reset:$00000000
: DMA.CNDTR3.NDT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA.CNDTR3 ; \ DMA.CNDTR3.NDT, Number of data to transfer

\ DMA.CNDTR4 (read-write) Reset:$00000000
: DMA.CNDTR4.NDT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA.CNDTR4 ; \ DMA.CNDTR4.NDT, Number of data to transfer

\ DMA.CNDTR5 (read-write) Reset:$00000000
: DMA.CNDTR5.NDT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA.CNDTR5 ; \ DMA.CNDTR5.NDT, Number of data to transfer

\ DMA.CPAR1 (read-write) Reset:$00000000
: DMA.CPAR1.PA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA.CPAR1 ; \ DMA.CPAR1.PA, Peripheral address

\ DMA.CPAR2 (read-write) Reset:$00000000
: DMA.CPAR2.PA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA.CPAR2 ; \ DMA.CPAR2.PA, Peripheral address

\ DMA.CPAR3 (read-write) Reset:$00000000
: DMA.CPAR3.PA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA.CPAR3 ; \ DMA.CPAR3.PA, Peripheral address

\ DMA.CPAR4 (read-write) Reset:$00000000
: DMA.CPAR4.PA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA.CPAR4 ; \ DMA.CPAR4.PA, Peripheral address

\ DMA.CPAR5 (read-write) Reset:$00000000
: DMA.CPAR5.PA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA.CPAR5 ; \ DMA.CPAR5.PA, Peripheral address

\ DMA.CMAR1 (read-write) Reset:$00000000
: DMA.CMAR1.MA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA.CMAR1 ; \ DMA.CMAR1.MA, Memory address

\ DMA.CMAR2 (read-write) Reset:$00000000
: DMA.CMAR2.MA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA.CMAR2 ; \ DMA.CMAR2.MA, Memory address

\ DMA.CMAR3 (read-write) Reset:$00000000
: DMA.CMAR3.MA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA.CMAR3 ; \ DMA.CMAR3.MA, Memory address

\ DMA.CMAR4 (read-write) Reset:$00000000
: DMA.CMAR4.MA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA.CMAR4 ; \ DMA.CMAR4.MA, Memory address

\ DMA.CMAR5 (read-write) Reset:$00000000
: DMA.CMAR5.MA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA.CMAR5 ; \ DMA.CMAR5.MA, Memory address

\ DMAMUX.C0CR (read-write) Reset:$00000000
: DMAMUX.C0CR.DMAREQ_ID ( %bbbbbbbb -- x addr ) DMAMUX.C0CR ; \ DMAMUX.C0CR.DMAREQ_ID, Input DMA request line               selected
: DMAMUX.C0CR.SOIE ( -- x addr ) 8 bit DMAMUX.C0CR ; \ DMAMUX.C0CR.SOIE, Interrupt enable at synchronization               event overrun
: DMAMUX.C0CR.EGE ( -- x addr ) 9 bit DMAMUX.C0CR ; \ DMAMUX.C0CR.EGE, Event generation               enable/disable
: DMAMUX.C0CR.SE ( -- x addr ) 16 bit DMAMUX.C0CR ; \ DMAMUX.C0CR.SE, Synchronous operating mode               enable/disable
: DMAMUX.C0CR.SPOL ( %bb -- x addr ) 17 lshift DMAMUX.C0CR ; \ DMAMUX.C0CR.SPOL, Synchronization event type selector               Defines the synchronization event on the selected               synchronization input:
: DMAMUX.C0CR.NBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX.C0CR ; \ DMAMUX.C0CR.NBREQ, Number of DMA requests to forward               Defines the number of DMA requests forwarded before               output event is generated. In synchronous mode, it               also defines the number of DMA requests to forward               after a synchronization event, then stop forwarding.               The actual number of DMA requests forwarded is               NBREQ+1. Note: This field can only be written when               both SE and EGE bits are reset.
: DMAMUX.C0CR.SYNC_ID ( %bbbbb -- x addr ) 24 lshift DMAMUX.C0CR ; \ DMAMUX.C0CR.SYNC_ID, Synchronization input               selected

\ DMAMUX.C1CR (read-write) Reset:$00000000
: DMAMUX.C1CR.DMAREQ_ID ( %bbbbbbbb -- x addr ) DMAMUX.C1CR ; \ DMAMUX.C1CR.DMAREQ_ID, Input DMA request line               selected
: DMAMUX.C1CR.SOIE ( -- x addr ) 8 bit DMAMUX.C1CR ; \ DMAMUX.C1CR.SOIE, Interrupt enable at synchronization               event overrun
: DMAMUX.C1CR.EGE ( -- x addr ) 9 bit DMAMUX.C1CR ; \ DMAMUX.C1CR.EGE, Event generation               enable/disable
: DMAMUX.C1CR.SE ( -- x addr ) 16 bit DMAMUX.C1CR ; \ DMAMUX.C1CR.SE, Synchronous operating mode               enable/disable
: DMAMUX.C1CR.SPOL ( %bb -- x addr ) 17 lshift DMAMUX.C1CR ; \ DMAMUX.C1CR.SPOL, Synchronization event type selector               Defines the synchronization event on the selected               synchronization input:
: DMAMUX.C1CR.NBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX.C1CR ; \ DMAMUX.C1CR.NBREQ, Number of DMA requests to forward               Defines the number of DMA requests forwarded before               output event is generated. In synchronous mode, it               also defines the number of DMA requests to forward               after a synchronization event, then stop forwarding.               The actual number of DMA requests forwarded is               NBREQ+1. Note: This field can only be written when               both SE and EGE bits are reset.
: DMAMUX.C1CR.SYNC_ID ( %bbbbb -- x addr ) 24 lshift DMAMUX.C1CR ; \ DMAMUX.C1CR.SYNC_ID, Synchronization input               selected

\ DMAMUX.C2CR (read-write) Reset:$00000000
: DMAMUX.C2CR.DMAREQ_ID ( %bbbbbbbb -- x addr ) DMAMUX.C2CR ; \ DMAMUX.C2CR.DMAREQ_ID, Input DMA request line               selected
: DMAMUX.C2CR.SOIE ( -- x addr ) 8 bit DMAMUX.C2CR ; \ DMAMUX.C2CR.SOIE, Interrupt enable at synchronization               event overrun
: DMAMUX.C2CR.EGE ( -- x addr ) 9 bit DMAMUX.C2CR ; \ DMAMUX.C2CR.EGE, Event generation               enable/disable
: DMAMUX.C2CR.SE ( -- x addr ) 16 bit DMAMUX.C2CR ; \ DMAMUX.C2CR.SE, Synchronous operating mode               enable/disable
: DMAMUX.C2CR.SPOL ( %bb -- x addr ) 17 lshift DMAMUX.C2CR ; \ DMAMUX.C2CR.SPOL, Synchronization event type selector               Defines the synchronization event on the selected               synchronization input:
: DMAMUX.C2CR.NBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX.C2CR ; \ DMAMUX.C2CR.NBREQ, Number of DMA requests to forward               Defines the number of DMA requests forwarded before               output event is generated. In synchronous mode, it               also defines the number of DMA requests to forward               after a synchronization event, then stop forwarding.               The actual number of DMA requests forwarded is               NBREQ+1. Note: This field can only be written when               both SE and EGE bits are reset.
: DMAMUX.C2CR.SYNC_ID ( %bbbbb -- x addr ) 24 lshift DMAMUX.C2CR ; \ DMAMUX.C2CR.SYNC_ID, Synchronization input               selected

\ DMAMUX.C3CR (read-write) Reset:$00000000
: DMAMUX.C3CR.DMAREQ_ID ( %bbbbbbbb -- x addr ) DMAMUX.C3CR ; \ DMAMUX.C3CR.DMAREQ_ID, Input DMA request line               selected
: DMAMUX.C3CR.SOIE ( -- x addr ) 8 bit DMAMUX.C3CR ; \ DMAMUX.C3CR.SOIE, Interrupt enable at synchronization               event overrun
: DMAMUX.C3CR.EGE ( -- x addr ) 9 bit DMAMUX.C3CR ; \ DMAMUX.C3CR.EGE, Event generation               enable/disable
: DMAMUX.C3CR.SE ( -- x addr ) 16 bit DMAMUX.C3CR ; \ DMAMUX.C3CR.SE, Synchronous operating mode               enable/disable
: DMAMUX.C3CR.SPOL ( %bb -- x addr ) 17 lshift DMAMUX.C3CR ; \ DMAMUX.C3CR.SPOL, Synchronization event type selector               Defines the synchronization event on the selected               synchronization input:
: DMAMUX.C3CR.NBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX.C3CR ; \ DMAMUX.C3CR.NBREQ, Number of DMA requests to forward               Defines the number of DMA requests forwarded before               output event is generated. In synchronous mode, it               also defines the number of DMA requests to forward               after a synchronization event, then stop forwarding.               The actual number of DMA requests forwarded is               NBREQ+1. Note: This field can only be written when               both SE and EGE bits are reset.
: DMAMUX.C3CR.SYNC_ID ( %bbbbb -- x addr ) 24 lshift DMAMUX.C3CR ; \ DMAMUX.C3CR.SYNC_ID, Synchronization input               selected

\ DMAMUX.C4CR (read-write) Reset:$00000000
: DMAMUX.C4CR.DMAREQ_ID ( %bbbbbbbb -- x addr ) DMAMUX.C4CR ; \ DMAMUX.C4CR.DMAREQ_ID, Input DMA request line               selected
: DMAMUX.C4CR.SOIE ( -- x addr ) 8 bit DMAMUX.C4CR ; \ DMAMUX.C4CR.SOIE, Interrupt enable at synchronization               event overrun
: DMAMUX.C4CR.EGE ( -- x addr ) 9 bit DMAMUX.C4CR ; \ DMAMUX.C4CR.EGE, Event generation               enable/disable
: DMAMUX.C4CR.SE ( -- x addr ) 16 bit DMAMUX.C4CR ; \ DMAMUX.C4CR.SE, Synchronous operating mode               enable/disable
: DMAMUX.C4CR.SPOL ( %bb -- x addr ) 17 lshift DMAMUX.C4CR ; \ DMAMUX.C4CR.SPOL, Synchronization event type selector               Defines the synchronization event on the selected               synchronization input:
: DMAMUX.C4CR.NBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX.C4CR ; \ DMAMUX.C4CR.NBREQ, Number of DMA requests to forward               Defines the number of DMA requests forwarded before               output event is generated. In synchronous mode, it               also defines the number of DMA requests to forward               after a synchronization event, then stop forwarding.               The actual number of DMA requests forwarded is               NBREQ+1. Note: This field can only be written when               both SE and EGE bits are reset.
: DMAMUX.C4CR.SYNC_ID ( %bbbbb -- x addr ) 24 lshift DMAMUX.C4CR ; \ DMAMUX.C4CR.SYNC_ID, Synchronization input               selected

\ DMAMUX.C5CR (read-write) Reset:$00000000
: DMAMUX.C5CR.DMAREQ_ID ( %bbbbbbbb -- x addr ) DMAMUX.C5CR ; \ DMAMUX.C5CR.DMAREQ_ID, Input DMA request line               selected
: DMAMUX.C5CR.SOIE ( -- x addr ) 8 bit DMAMUX.C5CR ; \ DMAMUX.C5CR.SOIE, Interrupt enable at synchronization               event overrun
: DMAMUX.C5CR.EGE ( -- x addr ) 9 bit DMAMUX.C5CR ; \ DMAMUX.C5CR.EGE, Event generation               enable/disable
: DMAMUX.C5CR.SE ( -- x addr ) 16 bit DMAMUX.C5CR ; \ DMAMUX.C5CR.SE, Synchronous operating mode               enable/disable
: DMAMUX.C5CR.SPOL ( %bb -- x addr ) 17 lshift DMAMUX.C5CR ; \ DMAMUX.C5CR.SPOL, Synchronization event type selector               Defines the synchronization event on the selected               synchronization input:
: DMAMUX.C5CR.NBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX.C5CR ; \ DMAMUX.C5CR.NBREQ, Number of DMA requests to forward               Defines the number of DMA requests forwarded before               output event is generated. In synchronous mode, it               also defines the number of DMA requests to forward               after a synchronization event, then stop forwarding.               The actual number of DMA requests forwarded is               NBREQ+1. Note: This field can only be written when               both SE and EGE bits are reset.
: DMAMUX.C5CR.SYNC_ID ( %bbbbb -- x addr ) 24 lshift DMAMUX.C5CR ; \ DMAMUX.C5CR.SYNC_ID, Synchronization input               selected

\ DMAMUX.C6CR (read-write) Reset:$00000000
: DMAMUX.C6CR.DMAREQ_ID ( %bbbbbbbb -- x addr ) DMAMUX.C6CR ; \ DMAMUX.C6CR.DMAREQ_ID, Input DMA request line               selected
: DMAMUX.C6CR.SOIE ( -- x addr ) 8 bit DMAMUX.C6CR ; \ DMAMUX.C6CR.SOIE, Interrupt enable at synchronization               event overrun
: DMAMUX.C6CR.EGE ( -- x addr ) 9 bit DMAMUX.C6CR ; \ DMAMUX.C6CR.EGE, Event generation               enable/disable
: DMAMUX.C6CR.SE ( -- x addr ) 16 bit DMAMUX.C6CR ; \ DMAMUX.C6CR.SE, Synchronous operating mode               enable/disable
: DMAMUX.C6CR.SPOL ( %bb -- x addr ) 17 lshift DMAMUX.C6CR ; \ DMAMUX.C6CR.SPOL, Synchronization event type selector               Defines the synchronization event on the selected               synchronization input:
: DMAMUX.C6CR.NBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX.C6CR ; \ DMAMUX.C6CR.NBREQ, Number of DMA requests to forward               Defines the number of DMA requests forwarded before               output event is generated. In synchronous mode, it               also defines the number of DMA requests to forward               after a synchronization event, then stop forwarding.               The actual number of DMA requests forwarded is               NBREQ+1. Note: This field can only be written when               both SE and EGE bits are reset.
: DMAMUX.C6CR.SYNC_ID ( %bbbbb -- x addr ) 24 lshift DMAMUX.C6CR ; \ DMAMUX.C6CR.SYNC_ID, Synchronization input               selected

\ DMAMUX.RG0CR (read-write) Reset:$00000000
: DMAMUX.RG0CR.SIG_ID ( %bbbbb -- x addr ) DMAMUX.RG0CR ; \ DMAMUX.RG0CR.SIG_ID, DMA request trigger input               selected
: DMAMUX.RG0CR.OIE ( -- x addr ) 8 bit DMAMUX.RG0CR ; \ DMAMUX.RG0CR.OIE, Interrupt enable at trigger event               overrun
: DMAMUX.RG0CR.GE ( -- x addr ) 16 bit DMAMUX.RG0CR ; \ DMAMUX.RG0CR.GE, DMA request generator channel               enable/disable
: DMAMUX.RG0CR.GPOL ( %bb -- x addr ) 17 lshift DMAMUX.RG0CR ; \ DMAMUX.RG0CR.GPOL, DMA request generator trigger event type               selection Defines the trigger event on the selected               DMA request trigger input
: DMAMUX.RG0CR.GNBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX.RG0CR ; \ DMAMUX.RG0CR.GNBREQ, Number of DMA requests to generate               Defines the number of DMA requests generated after a               trigger event, then stop generating. The actual               number of generated DMA requests is GNBREQ+1. Note:               This field can only be written when GE bit is               reset.

\ DMAMUX.RG1CR (read-write) Reset:$00000000
: DMAMUX.RG1CR.SIG_ID ( %bbbbb -- x addr ) DMAMUX.RG1CR ; \ DMAMUX.RG1CR.SIG_ID, DMA request trigger input               selected
: DMAMUX.RG1CR.OIE ( -- x addr ) 8 bit DMAMUX.RG1CR ; \ DMAMUX.RG1CR.OIE, Interrupt enable at trigger event               overrun
: DMAMUX.RG1CR.GE ( -- x addr ) 16 bit DMAMUX.RG1CR ; \ DMAMUX.RG1CR.GE, DMA request generator channel               enable/disable
: DMAMUX.RG1CR.GPOL ( %bb -- x addr ) 17 lshift DMAMUX.RG1CR ; \ DMAMUX.RG1CR.GPOL, DMA request generator trigger event type               selection Defines the trigger event on the selected               DMA request trigger input
: DMAMUX.RG1CR.GNBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX.RG1CR ; \ DMAMUX.RG1CR.GNBREQ, Number of DMA requests to generate               Defines the number of DMA requests generated after a               trigger event, then stop generating. The actual               number of generated DMA requests is GNBREQ+1. Note:               This field can only be written when GE bit is               reset.

\ DMAMUX.RG2CR (read-write) Reset:$00000000
: DMAMUX.RG2CR.SIG_ID ( %bbbbb -- x addr ) DMAMUX.RG2CR ; \ DMAMUX.RG2CR.SIG_ID, DMA request trigger input               selected
: DMAMUX.RG2CR.OIE ( -- x addr ) 8 bit DMAMUX.RG2CR ; \ DMAMUX.RG2CR.OIE, Interrupt enable at trigger event               overrun
: DMAMUX.RG2CR.GE ( -- x addr ) 16 bit DMAMUX.RG2CR ; \ DMAMUX.RG2CR.GE, DMA request generator channel               enable/disable
: DMAMUX.RG2CR.GPOL ( %bb -- x addr ) 17 lshift DMAMUX.RG2CR ; \ DMAMUX.RG2CR.GPOL, DMA request generator trigger event type               selection Defines the trigger event on the selected               DMA request trigger input
: DMAMUX.RG2CR.GNBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX.RG2CR ; \ DMAMUX.RG2CR.GNBREQ, Number of DMA requests to generate               Defines the number of DMA requests generated after a               trigger event, then stop generating. The actual               number of generated DMA requests is GNBREQ+1. Note:               This field can only be written when GE bit is               reset.

\ DMAMUX.RG3CR (read-write) Reset:$00000000
: DMAMUX.RG3CR.SIG_ID ( %bbbbb -- x addr ) DMAMUX.RG3CR ; \ DMAMUX.RG3CR.SIG_ID, DMA request trigger input               selected
: DMAMUX.RG3CR.OIE ( -- x addr ) 8 bit DMAMUX.RG3CR ; \ DMAMUX.RG3CR.OIE, Interrupt enable at trigger event               overrun
: DMAMUX.RG3CR.GE ( -- x addr ) 16 bit DMAMUX.RG3CR ; \ DMAMUX.RG3CR.GE, DMA request generator channel               enable/disable
: DMAMUX.RG3CR.GPOL ( %bb -- x addr ) 17 lshift DMAMUX.RG3CR ; \ DMAMUX.RG3CR.GPOL, DMA request generator trigger event type               selection Defines the trigger event on the selected               DMA request trigger input
: DMAMUX.RG3CR.GNBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX.RG3CR ; \ DMAMUX.RG3CR.GNBREQ, Number of DMA requests to generate               Defines the number of DMA requests generated after a               trigger event, then stop generating. The actual               number of generated DMA requests is GNBREQ+1. Note:               This field can only be written when GE bit is               reset.

\ DMAMUX.RGSR (read-only) Reset:$00000000
: DMAMUX.RGSR.OF? ( --  x ) DMAMUX.RGSR @ ; \ DMAMUX.RGSR.OF, Trigger event overrun flag The flag is               set when a trigger event occurs on DMA request               generator channel x, while the DMA request generator               counter value is lower than GNBREQ. The flag is               cleared by writing 1 to the corresponding COFx bit in               DMAMUX_RGCFR register.

\ DMAMUX.RGCFR (write-only) Reset:$00000000
: DMAMUX.RGCFR.COF ( %bbbb -- x addr ) DMAMUX.RGCFR ; \ DMAMUX.RGCFR.COF, Clear trigger event overrun flag Upon               setting, this bit clears the corresponding overrun               flag OFx in the DMAMUX_RGCSR register.

\ GPIOA.MODER (read-write) Reset:$EBFFFFFF
: GPIOA.MODER.MODER15 ( %bb -- x addr ) 30 lshift GPIOA.MODER ; \ GPIOA.MODER.MODER15, Port x configuration bits (y =               0..15)
: GPIOA.MODER.MODER14 ( %bb -- x addr ) 28 lshift GPIOA.MODER ; \ GPIOA.MODER.MODER14, Port x configuration bits (y =               0..15)
: GPIOA.MODER.MODER13 ( %bb -- x addr ) 26 lshift GPIOA.MODER ; \ GPIOA.MODER.MODER13, Port x configuration bits (y =               0..15)
: GPIOA.MODER.MODER12 ( %bb -- x addr ) 24 lshift GPIOA.MODER ; \ GPIOA.MODER.MODER12, Port x configuration bits (y =               0..15)
: GPIOA.MODER.MODER11 ( %bb -- x addr ) 22 lshift GPIOA.MODER ; \ GPIOA.MODER.MODER11, Port x configuration bits (y =               0..15)
: GPIOA.MODER.MODER10 ( %bb -- x addr ) 20 lshift GPIOA.MODER ; \ GPIOA.MODER.MODER10, Port x configuration bits (y =               0..15)
: GPIOA.MODER.MODER9 ( %bb -- x addr ) 18 lshift GPIOA.MODER ; \ GPIOA.MODER.MODER9, Port x configuration bits (y =               0..15)
: GPIOA.MODER.MODER8 ( %bb -- x addr ) 16 lshift GPIOA.MODER ; \ GPIOA.MODER.MODER8, Port x configuration bits (y =               0..15)
: GPIOA.MODER.MODER7 ( %bb -- x addr ) 14 lshift GPIOA.MODER ; \ GPIOA.MODER.MODER7, Port x configuration bits (y =               0..15)
: GPIOA.MODER.MODER6 ( %bb -- x addr ) 12 lshift GPIOA.MODER ; \ GPIOA.MODER.MODER6, Port x configuration bits (y =               0..15)
: GPIOA.MODER.MODER5 ( %bb -- x addr ) 10 lshift GPIOA.MODER ; \ GPIOA.MODER.MODER5, Port x configuration bits (y =               0..15)
: GPIOA.MODER.MODER4 ( %bb -- x addr ) 8 lshift GPIOA.MODER ; \ GPIOA.MODER.MODER4, Port x configuration bits (y =               0..15)
: GPIOA.MODER.MODER3 ( %bb -- x addr ) 6 lshift GPIOA.MODER ; \ GPIOA.MODER.MODER3, Port x configuration bits (y =               0..15)
: GPIOA.MODER.MODER2 ( %bb -- x addr ) 4 lshift GPIOA.MODER ; \ GPIOA.MODER.MODER2, Port x configuration bits (y =               0..15)
: GPIOA.MODER.MODER1 ( %bb -- x addr ) 2 lshift GPIOA.MODER ; \ GPIOA.MODER.MODER1, Port x configuration bits (y =               0..15)
: GPIOA.MODER.MODER0 ( %bb -- x addr ) GPIOA.MODER ; \ GPIOA.MODER.MODER0, Port x configuration bits (y =               0..15)

\ GPIOA.OTYPER (read-write) Reset:$00000000
: GPIOA.OTYPER.OT15 ( -- x addr ) 15 bit GPIOA.OTYPER ; \ GPIOA.OTYPER.OT15, Port x configuration bits (y =               0..15)
: GPIOA.OTYPER.OT14 ( -- x addr ) 14 bit GPIOA.OTYPER ; \ GPIOA.OTYPER.OT14, Port x configuration bits (y =               0..15)
: GPIOA.OTYPER.OT13 ( -- x addr ) 13 bit GPIOA.OTYPER ; \ GPIOA.OTYPER.OT13, Port x configuration bits (y =               0..15)
: GPIOA.OTYPER.OT12 ( -- x addr ) 12 bit GPIOA.OTYPER ; \ GPIOA.OTYPER.OT12, Port x configuration bits (y =               0..15)
: GPIOA.OTYPER.OT11 ( -- x addr ) 11 bit GPIOA.OTYPER ; \ GPIOA.OTYPER.OT11, Port x configuration bits (y =               0..15)
: GPIOA.OTYPER.OT10 ( -- x addr ) 10 bit GPIOA.OTYPER ; \ GPIOA.OTYPER.OT10, Port x configuration bits (y =               0..15)
: GPIOA.OTYPER.OT9 ( -- x addr ) 9 bit GPIOA.OTYPER ; \ GPIOA.OTYPER.OT9, Port x configuration bits (y =               0..15)
: GPIOA.OTYPER.OT8 ( -- x addr ) 8 bit GPIOA.OTYPER ; \ GPIOA.OTYPER.OT8, Port x configuration bits (y =               0..15)
: GPIOA.OTYPER.OT7 ( -- x addr ) 7 bit GPIOA.OTYPER ; \ GPIOA.OTYPER.OT7, Port x configuration bits (y =               0..15)
: GPIOA.OTYPER.OT6 ( -- x addr ) 6 bit GPIOA.OTYPER ; \ GPIOA.OTYPER.OT6, Port x configuration bits (y =               0..15)
: GPIOA.OTYPER.OT5 ( -- x addr ) 5 bit GPIOA.OTYPER ; \ GPIOA.OTYPER.OT5, Port x configuration bits (y =               0..15)
: GPIOA.OTYPER.OT4 ( -- x addr ) 4 bit GPIOA.OTYPER ; \ GPIOA.OTYPER.OT4, Port x configuration bits (y =               0..15)
: GPIOA.OTYPER.OT3 ( -- x addr ) 3 bit GPIOA.OTYPER ; \ GPIOA.OTYPER.OT3, Port x configuration bits (y =               0..15)
: GPIOA.OTYPER.OT2 ( -- x addr ) 2 bit GPIOA.OTYPER ; \ GPIOA.OTYPER.OT2, Port x configuration bits (y =               0..15)
: GPIOA.OTYPER.OT1 ( -- x addr ) 1 bit GPIOA.OTYPER ; \ GPIOA.OTYPER.OT1, Port x configuration bits (y =               0..15)
: GPIOA.OTYPER.OT0 ( -- x addr ) 0 bit GPIOA.OTYPER ; \ GPIOA.OTYPER.OT0, Port x configuration bits (y =               0..15)

\ GPIOA.OSPEEDR (read-write) Reset:$0C000000
: GPIOA.OSPEEDR.OSPEEDR15 ( %bb -- x addr ) 30 lshift GPIOA.OSPEEDR ; \ GPIOA.OSPEEDR.OSPEEDR15, Port x configuration bits (y =               0..15)
: GPIOA.OSPEEDR.OSPEEDR14 ( %bb -- x addr ) 28 lshift GPIOA.OSPEEDR ; \ GPIOA.OSPEEDR.OSPEEDR14, Port x configuration bits (y =               0..15)
: GPIOA.OSPEEDR.OSPEEDR13 ( %bb -- x addr ) 26 lshift GPIOA.OSPEEDR ; \ GPIOA.OSPEEDR.OSPEEDR13, Port x configuration bits (y =               0..15)
: GPIOA.OSPEEDR.OSPEEDR12 ( %bb -- x addr ) 24 lshift GPIOA.OSPEEDR ; \ GPIOA.OSPEEDR.OSPEEDR12, Port x configuration bits (y =               0..15)
: GPIOA.OSPEEDR.OSPEEDR11 ( %bb -- x addr ) 22 lshift GPIOA.OSPEEDR ; \ GPIOA.OSPEEDR.OSPEEDR11, Port x configuration bits (y =               0..15)
: GPIOA.OSPEEDR.OSPEEDR10 ( %bb -- x addr ) 20 lshift GPIOA.OSPEEDR ; \ GPIOA.OSPEEDR.OSPEEDR10, Port x configuration bits (y =               0..15)
: GPIOA.OSPEEDR.OSPEEDR9 ( %bb -- x addr ) 18 lshift GPIOA.OSPEEDR ; \ GPIOA.OSPEEDR.OSPEEDR9, Port x configuration bits (y =               0..15)
: GPIOA.OSPEEDR.OSPEEDR8 ( %bb -- x addr ) 16 lshift GPIOA.OSPEEDR ; \ GPIOA.OSPEEDR.OSPEEDR8, Port x configuration bits (y =               0..15)
: GPIOA.OSPEEDR.OSPEEDR7 ( %bb -- x addr ) 14 lshift GPIOA.OSPEEDR ; \ GPIOA.OSPEEDR.OSPEEDR7, Port x configuration bits (y =               0..15)
: GPIOA.OSPEEDR.OSPEEDR6 ( %bb -- x addr ) 12 lshift GPIOA.OSPEEDR ; \ GPIOA.OSPEEDR.OSPEEDR6, Port x configuration bits (y =               0..15)
: GPIOA.OSPEEDR.OSPEEDR5 ( %bb -- x addr ) 10 lshift GPIOA.OSPEEDR ; \ GPIOA.OSPEEDR.OSPEEDR5, Port x configuration bits (y =               0..15)
: GPIOA.OSPEEDR.OSPEEDR4 ( %bb -- x addr ) 8 lshift GPIOA.OSPEEDR ; \ GPIOA.OSPEEDR.OSPEEDR4, Port x configuration bits (y =               0..15)
: GPIOA.OSPEEDR.OSPEEDR3 ( %bb -- x addr ) 6 lshift GPIOA.OSPEEDR ; \ GPIOA.OSPEEDR.OSPEEDR3, Port x configuration bits (y =               0..15)
: GPIOA.OSPEEDR.OSPEEDR2 ( %bb -- x addr ) 4 lshift GPIOA.OSPEEDR ; \ GPIOA.OSPEEDR.OSPEEDR2, Port x configuration bits (y =               0..15)
: GPIOA.OSPEEDR.OSPEEDR1 ( %bb -- x addr ) 2 lshift GPIOA.OSPEEDR ; \ GPIOA.OSPEEDR.OSPEEDR1, Port x configuration bits (y =               0..15)
: GPIOA.OSPEEDR.OSPEEDR0 ( %bb -- x addr ) GPIOA.OSPEEDR ; \ GPIOA.OSPEEDR.OSPEEDR0, Port x configuration bits (y =               0..15)

\ GPIOA.PUPDR (read-write) Reset:$24000000
: GPIOA.PUPDR.PUPDR15 ( %bb -- x addr ) 30 lshift GPIOA.PUPDR ; \ GPIOA.PUPDR.PUPDR15, Port x configuration bits (y =               0..15)
: GPIOA.PUPDR.PUPDR14 ( %bb -- x addr ) 28 lshift GPIOA.PUPDR ; \ GPIOA.PUPDR.PUPDR14, Port x configuration bits (y =               0..15)
: GPIOA.PUPDR.PUPDR13 ( %bb -- x addr ) 26 lshift GPIOA.PUPDR ; \ GPIOA.PUPDR.PUPDR13, Port x configuration bits (y =               0..15)
: GPIOA.PUPDR.PUPDR12 ( %bb -- x addr ) 24 lshift GPIOA.PUPDR ; \ GPIOA.PUPDR.PUPDR12, Port x configuration bits (y =               0..15)
: GPIOA.PUPDR.PUPDR11 ( %bb -- x addr ) 22 lshift GPIOA.PUPDR ; \ GPIOA.PUPDR.PUPDR11, Port x configuration bits (y =               0..15)
: GPIOA.PUPDR.PUPDR10 ( %bb -- x addr ) 20 lshift GPIOA.PUPDR ; \ GPIOA.PUPDR.PUPDR10, Port x configuration bits (y =               0..15)
: GPIOA.PUPDR.PUPDR9 ( %bb -- x addr ) 18 lshift GPIOA.PUPDR ; \ GPIOA.PUPDR.PUPDR9, Port x configuration bits (y =               0..15)
: GPIOA.PUPDR.PUPDR8 ( %bb -- x addr ) 16 lshift GPIOA.PUPDR ; \ GPIOA.PUPDR.PUPDR8, Port x configuration bits (y =               0..15)
: GPIOA.PUPDR.PUPDR7 ( %bb -- x addr ) 14 lshift GPIOA.PUPDR ; \ GPIOA.PUPDR.PUPDR7, Port x configuration bits (y =               0..15)
: GPIOA.PUPDR.PUPDR6 ( %bb -- x addr ) 12 lshift GPIOA.PUPDR ; \ GPIOA.PUPDR.PUPDR6, Port x configuration bits (y =               0..15)
: GPIOA.PUPDR.PUPDR5 ( %bb -- x addr ) 10 lshift GPIOA.PUPDR ; \ GPIOA.PUPDR.PUPDR5, Port x configuration bits (y =               0..15)
: GPIOA.PUPDR.PUPDR4 ( %bb -- x addr ) 8 lshift GPIOA.PUPDR ; \ GPIOA.PUPDR.PUPDR4, Port x configuration bits (y =               0..15)
: GPIOA.PUPDR.PUPDR3 ( %bb -- x addr ) 6 lshift GPIOA.PUPDR ; \ GPIOA.PUPDR.PUPDR3, Port x configuration bits (y =               0..15)
: GPIOA.PUPDR.PUPDR2 ( %bb -- x addr ) 4 lshift GPIOA.PUPDR ; \ GPIOA.PUPDR.PUPDR2, Port x configuration bits (y =               0..15)
: GPIOA.PUPDR.PUPDR1 ( %bb -- x addr ) 2 lshift GPIOA.PUPDR ; \ GPIOA.PUPDR.PUPDR1, Port x configuration bits (y =               0..15)
: GPIOA.PUPDR.PUPDR0 ( %bb -- x addr ) GPIOA.PUPDR ; \ GPIOA.PUPDR.PUPDR0, Port x configuration bits (y =               0..15)

\ GPIOA.IDR (read-only) Reset:$00000000
: GPIOA.IDR.IDR15? ( --  1|0 ) 15 bit GPIOA.IDR bit@ ; \ GPIOA.IDR.IDR15, Port input data (y =               0..15)
: GPIOA.IDR.IDR14? ( --  1|0 ) 14 bit GPIOA.IDR bit@ ; \ GPIOA.IDR.IDR14, Port input data (y =               0..15)
: GPIOA.IDR.IDR13? ( --  1|0 ) 13 bit GPIOA.IDR bit@ ; \ GPIOA.IDR.IDR13, Port input data (y =               0..15)
: GPIOA.IDR.IDR12? ( --  1|0 ) 12 bit GPIOA.IDR bit@ ; \ GPIOA.IDR.IDR12, Port input data (y =               0..15)
: GPIOA.IDR.IDR11? ( --  1|0 ) 11 bit GPIOA.IDR bit@ ; \ GPIOA.IDR.IDR11, Port input data (y =               0..15)
: GPIOA.IDR.IDR10? ( --  1|0 ) 10 bit GPIOA.IDR bit@ ; \ GPIOA.IDR.IDR10, Port input data (y =               0..15)
: GPIOA.IDR.IDR9? ( --  1|0 ) 9 bit GPIOA.IDR bit@ ; \ GPIOA.IDR.IDR9, Port input data (y =               0..15)
: GPIOA.IDR.IDR8? ( --  1|0 ) 8 bit GPIOA.IDR bit@ ; \ GPIOA.IDR.IDR8, Port input data (y =               0..15)
: GPIOA.IDR.IDR7? ( --  1|0 ) 7 bit GPIOA.IDR bit@ ; \ GPIOA.IDR.IDR7, Port input data (y =               0..15)
: GPIOA.IDR.IDR6? ( --  1|0 ) 6 bit GPIOA.IDR bit@ ; \ GPIOA.IDR.IDR6, Port input data (y =               0..15)
: GPIOA.IDR.IDR5? ( --  1|0 ) 5 bit GPIOA.IDR bit@ ; \ GPIOA.IDR.IDR5, Port input data (y =               0..15)
: GPIOA.IDR.IDR4? ( --  1|0 ) 4 bit GPIOA.IDR bit@ ; \ GPIOA.IDR.IDR4, Port input data (y =               0..15)
: GPIOA.IDR.IDR3? ( --  1|0 ) 3 bit GPIOA.IDR bit@ ; \ GPIOA.IDR.IDR3, Port input data (y =               0..15)
: GPIOA.IDR.IDR2? ( --  1|0 ) 2 bit GPIOA.IDR bit@ ; \ GPIOA.IDR.IDR2, Port input data (y =               0..15)
: GPIOA.IDR.IDR1? ( --  1|0 ) 1 bit GPIOA.IDR bit@ ; \ GPIOA.IDR.IDR1, Port input data (y =               0..15)
: GPIOA.IDR.IDR0? ( --  1|0 ) 0 bit GPIOA.IDR bit@ ; \ GPIOA.IDR.IDR0, Port input data (y =               0..15)

\ GPIOA.ODR (read-write) Reset:$00000000
: GPIOA.ODR.ODR15 ( -- x addr ) 15 bit GPIOA.ODR ; \ GPIOA.ODR.ODR15, Port output data (y =               0..15)
: GPIOA.ODR.ODR14 ( -- x addr ) 14 bit GPIOA.ODR ; \ GPIOA.ODR.ODR14, Port output data (y =               0..15)
: GPIOA.ODR.ODR13 ( -- x addr ) 13 bit GPIOA.ODR ; \ GPIOA.ODR.ODR13, Port output data (y =               0..15)
: GPIOA.ODR.ODR12 ( -- x addr ) 12 bit GPIOA.ODR ; \ GPIOA.ODR.ODR12, Port output data (y =               0..15)
: GPIOA.ODR.ODR11 ( -- x addr ) 11 bit GPIOA.ODR ; \ GPIOA.ODR.ODR11, Port output data (y =               0..15)
: GPIOA.ODR.ODR10 ( -- x addr ) 10 bit GPIOA.ODR ; \ GPIOA.ODR.ODR10, Port output data (y =               0..15)
: GPIOA.ODR.ODR9 ( -- x addr ) 9 bit GPIOA.ODR ; \ GPIOA.ODR.ODR9, Port output data (y =               0..15)
: GPIOA.ODR.ODR8 ( -- x addr ) 8 bit GPIOA.ODR ; \ GPIOA.ODR.ODR8, Port output data (y =               0..15)
: GPIOA.ODR.ODR7 ( -- x addr ) 7 bit GPIOA.ODR ; \ GPIOA.ODR.ODR7, Port output data (y =               0..15)
: GPIOA.ODR.ODR6 ( -- x addr ) 6 bit GPIOA.ODR ; \ GPIOA.ODR.ODR6, Port output data (y =               0..15)
: GPIOA.ODR.ODR5 ( -- x addr ) 5 bit GPIOA.ODR ; \ GPIOA.ODR.ODR5, Port output data (y =               0..15)
: GPIOA.ODR.ODR4 ( -- x addr ) 4 bit GPIOA.ODR ; \ GPIOA.ODR.ODR4, Port output data (y =               0..15)
: GPIOA.ODR.ODR3 ( -- x addr ) 3 bit GPIOA.ODR ; \ GPIOA.ODR.ODR3, Port output data (y =               0..15)
: GPIOA.ODR.ODR2 ( -- x addr ) 2 bit GPIOA.ODR ; \ GPIOA.ODR.ODR2, Port output data (y =               0..15)
: GPIOA.ODR.ODR1 ( -- x addr ) 1 bit GPIOA.ODR ; \ GPIOA.ODR.ODR1, Port output data (y =               0..15)
: GPIOA.ODR.ODR0 ( -- x addr ) 0 bit GPIOA.ODR ; \ GPIOA.ODR.ODR0, Port output data (y =               0..15)

\ GPIOA.BSRR (write-only) Reset:$00000000
: GPIOA.BSRR.BR15 ( -- ) 31 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BR15, Port x reset bit y (y =               0..15)
: GPIOA.BSRR.BR14 ( -- ) 30 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BR14, Port x reset bit y (y =               0..15)
: GPIOA.BSRR.BR13 ( -- ) 29 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BR13, Port x reset bit y (y =               0..15)
: GPIOA.BSRR.BR12 ( -- ) 28 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BR12, Port x reset bit y (y =               0..15)
: GPIOA.BSRR.BR11 ( -- ) 27 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BR11, Port x reset bit y (y =               0..15)
: GPIOA.BSRR.BR10 ( -- ) 26 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BR10, Port x reset bit y (y =               0..15)
: GPIOA.BSRR.BR9 ( -- ) 25 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BR9, Port x reset bit y (y =               0..15)
: GPIOA.BSRR.BR8 ( -- ) 24 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BR8, Port x reset bit y (y =               0..15)
: GPIOA.BSRR.BR7 ( -- ) 23 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BR7, Port x reset bit y (y =               0..15)
: GPIOA.BSRR.BR6 ( -- ) 22 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BR6, Port x reset bit y (y =               0..15)
: GPIOA.BSRR.BR5 ( -- ) 21 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BR5, Port x reset bit y (y =               0..15)
: GPIOA.BSRR.BR4 ( -- ) 20 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BR4, Port x reset bit y (y =               0..15)
: GPIOA.BSRR.BR3 ( -- ) 19 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BR3, Port x reset bit y (y =               0..15)
: GPIOA.BSRR.BR2 ( -- ) 18 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BR2, Port x reset bit y (y =               0..15)
: GPIOA.BSRR.BR1 ( -- ) 17 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BR1, Port x reset bit y (y =               0..15)
: GPIOA.BSRR.BR0 ( -- ) 16 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BR0, Port x set bit y (y=               0..15)
: GPIOA.BSRR.BS15 ( -- ) 15 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BS15, Port x set bit y (y=               0..15)
: GPIOA.BSRR.BS14 ( -- ) 14 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BS14, Port x set bit y (y=               0..15)
: GPIOA.BSRR.BS13 ( -- ) 13 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BS13, Port x set bit y (y=               0..15)
: GPIOA.BSRR.BS12 ( -- ) 12 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BS12, Port x set bit y (y=               0..15)
: GPIOA.BSRR.BS11 ( -- ) 11 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BS11, Port x set bit y (y=               0..15)
: GPIOA.BSRR.BS10 ( -- ) 10 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BS10, Port x set bit y (y=               0..15)
: GPIOA.BSRR.BS9 ( -- ) 9 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BS9, Port x set bit y (y=               0..15)
: GPIOA.BSRR.BS8 ( -- ) 8 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BS8, Port x set bit y (y=               0..15)
: GPIOA.BSRR.BS7 ( -- ) 7 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BS7, Port x set bit y (y=               0..15)
: GPIOA.BSRR.BS6 ( -- ) 6 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BS6, Port x set bit y (y=               0..15)
: GPIOA.BSRR.BS5 ( -- ) 5 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BS5, Port x set bit y (y=               0..15)
: GPIOA.BSRR.BS4 ( -- ) 4 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BS4, Port x set bit y (y=               0..15)
: GPIOA.BSRR.BS3 ( -- ) 3 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BS3, Port x set bit y (y=               0..15)
: GPIOA.BSRR.BS2 ( -- ) 2 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BS2, Port x set bit y (y=               0..15)
: GPIOA.BSRR.BS1 ( -- ) 1 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BS1, Port x set bit y (y=               0..15)
: GPIOA.BSRR.BS0 ( -- ) 0 bit GPIOA.BSRR ! ; \ GPIOA.BSRR.BS0, Port x set bit y (y=               0..15)

\ GPIOA.LCKR (read-write) Reset:$00000000
: GPIOA.LCKR.LCKK ( -- x addr ) 16 bit GPIOA.LCKR ; \ GPIOA.LCKR.LCKK, Port x lock bit y (y=               0..15)
: GPIOA.LCKR.LCK15 ( -- x addr ) 15 bit GPIOA.LCKR ; \ GPIOA.LCKR.LCK15, Port x lock bit y (y=               0..15)
: GPIOA.LCKR.LCK14 ( -- x addr ) 14 bit GPIOA.LCKR ; \ GPIOA.LCKR.LCK14, Port x lock bit y (y=               0..15)
: GPIOA.LCKR.LCK13 ( -- x addr ) 13 bit GPIOA.LCKR ; \ GPIOA.LCKR.LCK13, Port x lock bit y (y=               0..15)
: GPIOA.LCKR.LCK12 ( -- x addr ) 12 bit GPIOA.LCKR ; \ GPIOA.LCKR.LCK12, Port x lock bit y (y=               0..15)
: GPIOA.LCKR.LCK11 ( -- x addr ) 11 bit GPIOA.LCKR ; \ GPIOA.LCKR.LCK11, Port x lock bit y (y=               0..15)
: GPIOA.LCKR.LCK10 ( -- x addr ) 10 bit GPIOA.LCKR ; \ GPIOA.LCKR.LCK10, Port x lock bit y (y=               0..15)
: GPIOA.LCKR.LCK9 ( -- x addr ) 9 bit GPIOA.LCKR ; \ GPIOA.LCKR.LCK9, Port x lock bit y (y=               0..15)
: GPIOA.LCKR.LCK8 ( -- x addr ) 8 bit GPIOA.LCKR ; \ GPIOA.LCKR.LCK8, Port x lock bit y (y=               0..15)
: GPIOA.LCKR.LCK7 ( -- x addr ) 7 bit GPIOA.LCKR ; \ GPIOA.LCKR.LCK7, Port x lock bit y (y=               0..15)
: GPIOA.LCKR.LCK6 ( -- x addr ) 6 bit GPIOA.LCKR ; \ GPIOA.LCKR.LCK6, Port x lock bit y (y=               0..15)
: GPIOA.LCKR.LCK5 ( -- x addr ) 5 bit GPIOA.LCKR ; \ GPIOA.LCKR.LCK5, Port x lock bit y (y=               0..15)
: GPIOA.LCKR.LCK4 ( -- x addr ) 4 bit GPIOA.LCKR ; \ GPIOA.LCKR.LCK4, Port x lock bit y (y=               0..15)
: GPIOA.LCKR.LCK3 ( -- x addr ) 3 bit GPIOA.LCKR ; \ GPIOA.LCKR.LCK3, Port x lock bit y (y=               0..15)
: GPIOA.LCKR.LCK2 ( -- x addr ) 2 bit GPIOA.LCKR ; \ GPIOA.LCKR.LCK2, Port x lock bit y (y=               0..15)
: GPIOA.LCKR.LCK1 ( -- x addr ) 1 bit GPIOA.LCKR ; \ GPIOA.LCKR.LCK1, Port x lock bit y (y=               0..15)
: GPIOA.LCKR.LCK0 ( -- x addr ) 0 bit GPIOA.LCKR ; \ GPIOA.LCKR.LCK0, Port x lock bit y (y=               0..15)

\ GPIOA.AFRL (read-write) Reset:$00000000
: GPIOA.AFRL.AFSEL7 ( %bbbb -- x addr ) 28 lshift GPIOA.AFRL ; \ GPIOA.AFRL.AFSEL7, Alternate function selection for port x               bit y (y = 0..7)
: GPIOA.AFRL.AFSEL6 ( %bbbb -- x addr ) 24 lshift GPIOA.AFRL ; \ GPIOA.AFRL.AFSEL6, Alternate function selection for port x               bit y (y = 0..7)
: GPIOA.AFRL.AFSEL5 ( %bbbb -- x addr ) 20 lshift GPIOA.AFRL ; \ GPIOA.AFRL.AFSEL5, Alternate function selection for port x               bit y (y = 0..7)
: GPIOA.AFRL.AFSEL4 ( %bbbb -- x addr ) 16 lshift GPIOA.AFRL ; \ GPIOA.AFRL.AFSEL4, Alternate function selection for port x               bit y (y = 0..7)
: GPIOA.AFRL.AFSEL3 ( %bbbb -- x addr ) 12 lshift GPIOA.AFRL ; \ GPIOA.AFRL.AFSEL3, Alternate function selection for port x               bit y (y = 0..7)
: GPIOA.AFRL.AFSEL2 ( %bbbb -- x addr ) 8 lshift GPIOA.AFRL ; \ GPIOA.AFRL.AFSEL2, Alternate function selection for port x               bit y (y = 0..7)
: GPIOA.AFRL.AFSEL1 ( %bbbb -- x addr ) 4 lshift GPIOA.AFRL ; \ GPIOA.AFRL.AFSEL1, Alternate function selection for port x               bit y (y = 0..7)
: GPIOA.AFRL.AFSEL0 ( %bbbb -- x addr ) GPIOA.AFRL ; \ GPIOA.AFRL.AFSEL0, Alternate function selection for port x               bit y (y = 0..7)

\ GPIOA.AFRH (read-write) Reset:$00000000
: GPIOA.AFRH.AFSEL15 ( %bbbb -- x addr ) 28 lshift GPIOA.AFRH ; \ GPIOA.AFRH.AFSEL15, Alternate function selection for port x               bit y (y = 8..15)
: GPIOA.AFRH.AFSEL14 ( %bbbb -- x addr ) 24 lshift GPIOA.AFRH ; \ GPIOA.AFRH.AFSEL14, Alternate function selection for port x               bit y (y = 8..15)
: GPIOA.AFRH.AFSEL13 ( %bbbb -- x addr ) 20 lshift GPIOA.AFRH ; \ GPIOA.AFRH.AFSEL13, Alternate function selection for port x               bit y (y = 8..15)
: GPIOA.AFRH.AFSEL12 ( %bbbb -- x addr ) 16 lshift GPIOA.AFRH ; \ GPIOA.AFRH.AFSEL12, Alternate function selection for port x               bit y (y = 8..15)
: GPIOA.AFRH.AFSEL11 ( %bbbb -- x addr ) 12 lshift GPIOA.AFRH ; \ GPIOA.AFRH.AFSEL11, Alternate function selection for port x               bit y (y = 8..15)
: GPIOA.AFRH.AFSEL10 ( %bbbb -- x addr ) 8 lshift GPIOA.AFRH ; \ GPIOA.AFRH.AFSEL10, Alternate function selection for port x               bit y (y = 8..15)
: GPIOA.AFRH.AFSEL9 ( %bbbb -- x addr ) 4 lshift GPIOA.AFRH ; \ GPIOA.AFRH.AFSEL9, Alternate function selection for port x               bit y (y = 8..15)
: GPIOA.AFRH.AFSEL8 ( %bbbb -- x addr ) GPIOA.AFRH ; \ GPIOA.AFRH.AFSEL8, Alternate function selection for port x               bit y (y = 8..15)

\ GPIOA.BRR (write-only) Reset:$00000000
: GPIOA.BRR.BR0 ( -- ) 0 bit GPIOA.BRR ! ; \ GPIOA.BRR.BR0, Port Reset bit
: GPIOA.BRR.BR1 ( -- ) 1 bit GPIOA.BRR ! ; \ GPIOA.BRR.BR1, Port Reset bit
: GPIOA.BRR.BR2 ( -- ) 2 bit GPIOA.BRR ! ; \ GPIOA.BRR.BR2, Port Reset bit
: GPIOA.BRR.BR3 ( -- ) 3 bit GPIOA.BRR ! ; \ GPIOA.BRR.BR3, Port Reset bit
: GPIOA.BRR.BR4 ( -- ) 4 bit GPIOA.BRR ! ; \ GPIOA.BRR.BR4, Port Reset bit
: GPIOA.BRR.BR5 ( -- ) 5 bit GPIOA.BRR ! ; \ GPIOA.BRR.BR5, Port Reset bit
: GPIOA.BRR.BR6 ( -- ) 6 bit GPIOA.BRR ! ; \ GPIOA.BRR.BR6, Port Reset bit
: GPIOA.BRR.BR7 ( -- ) 7 bit GPIOA.BRR ! ; \ GPIOA.BRR.BR7, Port Reset bit
: GPIOA.BRR.BR8 ( -- ) 8 bit GPIOA.BRR ! ; \ GPIOA.BRR.BR8, Port Reset bit
: GPIOA.BRR.BR9 ( -- ) 9 bit GPIOA.BRR ! ; \ GPIOA.BRR.BR9, Port Reset bit
: GPIOA.BRR.BR10 ( -- ) 10 bit GPIOA.BRR ! ; \ GPIOA.BRR.BR10, Port Reset bit
: GPIOA.BRR.BR11 ( -- ) 11 bit GPIOA.BRR ! ; \ GPIOA.BRR.BR11, Port Reset bit
: GPIOA.BRR.BR12 ( -- ) 12 bit GPIOA.BRR ! ; \ GPIOA.BRR.BR12, Port Reset bit
: GPIOA.BRR.BR13 ( -- ) 13 bit GPIOA.BRR ! ; \ GPIOA.BRR.BR13, Port Reset bit
: GPIOA.BRR.BR14 ( -- ) 14 bit GPIOA.BRR ! ; \ GPIOA.BRR.BR14, Port Reset bit
: GPIOA.BRR.BR15 ( -- ) 15 bit GPIOA.BRR ! ; \ GPIOA.BRR.BR15, Port Reset bit

\ GPIOB.MODER (read-write) Reset:$FFFFFFFF
: GPIOB.MODER.MODER15 ( %bb -- x addr ) 30 lshift GPIOB.MODER ; \ GPIOB.MODER.MODER15, Port x configuration bits (y =               0..15)
: GPIOB.MODER.MODER14 ( %bb -- x addr ) 28 lshift GPIOB.MODER ; \ GPIOB.MODER.MODER14, Port x configuration bits (y =               0..15)
: GPIOB.MODER.MODER13 ( %bb -- x addr ) 26 lshift GPIOB.MODER ; \ GPIOB.MODER.MODER13, Port x configuration bits (y =               0..15)
: GPIOB.MODER.MODER12 ( %bb -- x addr ) 24 lshift GPIOB.MODER ; \ GPIOB.MODER.MODER12, Port x configuration bits (y =               0..15)
: GPIOB.MODER.MODER11 ( %bb -- x addr ) 22 lshift GPIOB.MODER ; \ GPIOB.MODER.MODER11, Port x configuration bits (y =               0..15)
: GPIOB.MODER.MODER10 ( %bb -- x addr ) 20 lshift GPIOB.MODER ; \ GPIOB.MODER.MODER10, Port x configuration bits (y =               0..15)
: GPIOB.MODER.MODER9 ( %bb -- x addr ) 18 lshift GPIOB.MODER ; \ GPIOB.MODER.MODER9, Port x configuration bits (y =               0..15)
: GPIOB.MODER.MODER8 ( %bb -- x addr ) 16 lshift GPIOB.MODER ; \ GPIOB.MODER.MODER8, Port x configuration bits (y =               0..15)
: GPIOB.MODER.MODER7 ( %bb -- x addr ) 14 lshift GPIOB.MODER ; \ GPIOB.MODER.MODER7, Port x configuration bits (y =               0..15)
: GPIOB.MODER.MODER6 ( %bb -- x addr ) 12 lshift GPIOB.MODER ; \ GPIOB.MODER.MODER6, Port x configuration bits (y =               0..15)
: GPIOB.MODER.MODER5 ( %bb -- x addr ) 10 lshift GPIOB.MODER ; \ GPIOB.MODER.MODER5, Port x configuration bits (y =               0..15)
: GPIOB.MODER.MODER4 ( %bb -- x addr ) 8 lshift GPIOB.MODER ; \ GPIOB.MODER.MODER4, Port x configuration bits (y =               0..15)
: GPIOB.MODER.MODER3 ( %bb -- x addr ) 6 lshift GPIOB.MODER ; \ GPIOB.MODER.MODER3, Port x configuration bits (y =               0..15)
: GPIOB.MODER.MODER2 ( %bb -- x addr ) 4 lshift GPIOB.MODER ; \ GPIOB.MODER.MODER2, Port x configuration bits (y =               0..15)
: GPIOB.MODER.MODER1 ( %bb -- x addr ) 2 lshift GPIOB.MODER ; \ GPIOB.MODER.MODER1, Port x configuration bits (y =               0..15)
: GPIOB.MODER.MODER0 ( %bb -- x addr ) GPIOB.MODER ; \ GPIOB.MODER.MODER0, Port x configuration bits (y =               0..15)

\ GPIOB.OTYPER (read-write) Reset:$00000000
: GPIOB.OTYPER.OT15 ( -- x addr ) 15 bit GPIOB.OTYPER ; \ GPIOB.OTYPER.OT15, Port x configuration bits (y =               0..15)
: GPIOB.OTYPER.OT14 ( -- x addr ) 14 bit GPIOB.OTYPER ; \ GPIOB.OTYPER.OT14, Port x configuration bits (y =               0..15)
: GPIOB.OTYPER.OT13 ( -- x addr ) 13 bit GPIOB.OTYPER ; \ GPIOB.OTYPER.OT13, Port x configuration bits (y =               0..15)
: GPIOB.OTYPER.OT12 ( -- x addr ) 12 bit GPIOB.OTYPER ; \ GPIOB.OTYPER.OT12, Port x configuration bits (y =               0..15)
: GPIOB.OTYPER.OT11 ( -- x addr ) 11 bit GPIOB.OTYPER ; \ GPIOB.OTYPER.OT11, Port x configuration bits (y =               0..15)
: GPIOB.OTYPER.OT10 ( -- x addr ) 10 bit GPIOB.OTYPER ; \ GPIOB.OTYPER.OT10, Port x configuration bits (y =               0..15)
: GPIOB.OTYPER.OT9 ( -- x addr ) 9 bit GPIOB.OTYPER ; \ GPIOB.OTYPER.OT9, Port x configuration bits (y =               0..15)
: GPIOB.OTYPER.OT8 ( -- x addr ) 8 bit GPIOB.OTYPER ; \ GPIOB.OTYPER.OT8, Port x configuration bits (y =               0..15)
: GPIOB.OTYPER.OT7 ( -- x addr ) 7 bit GPIOB.OTYPER ; \ GPIOB.OTYPER.OT7, Port x configuration bits (y =               0..15)
: GPIOB.OTYPER.OT6 ( -- x addr ) 6 bit GPIOB.OTYPER ; \ GPIOB.OTYPER.OT6, Port x configuration bits (y =               0..15)
: GPIOB.OTYPER.OT5 ( -- x addr ) 5 bit GPIOB.OTYPER ; \ GPIOB.OTYPER.OT5, Port x configuration bits (y =               0..15)
: GPIOB.OTYPER.OT4 ( -- x addr ) 4 bit GPIOB.OTYPER ; \ GPIOB.OTYPER.OT4, Port x configuration bits (y =               0..15)
: GPIOB.OTYPER.OT3 ( -- x addr ) 3 bit GPIOB.OTYPER ; \ GPIOB.OTYPER.OT3, Port x configuration bits (y =               0..15)
: GPIOB.OTYPER.OT2 ( -- x addr ) 2 bit GPIOB.OTYPER ; \ GPIOB.OTYPER.OT2, Port x configuration bits (y =               0..15)
: GPIOB.OTYPER.OT1 ( -- x addr ) 1 bit GPIOB.OTYPER ; \ GPIOB.OTYPER.OT1, Port x configuration bits (y =               0..15)
: GPIOB.OTYPER.OT0 ( -- x addr ) 0 bit GPIOB.OTYPER ; \ GPIOB.OTYPER.OT0, Port x configuration bits (y =               0..15)

\ GPIOB.OSPEEDR (read-write) Reset:$00000000
: GPIOB.OSPEEDR.OSPEEDR15 ( %bb -- x addr ) 30 lshift GPIOB.OSPEEDR ; \ GPIOB.OSPEEDR.OSPEEDR15, Port x configuration bits (y =               0..15)
: GPIOB.OSPEEDR.OSPEEDR14 ( %bb -- x addr ) 28 lshift GPIOB.OSPEEDR ; \ GPIOB.OSPEEDR.OSPEEDR14, Port x configuration bits (y =               0..15)
: GPIOB.OSPEEDR.OSPEEDR13 ( %bb -- x addr ) 26 lshift GPIOB.OSPEEDR ; \ GPIOB.OSPEEDR.OSPEEDR13, Port x configuration bits (y =               0..15)
: GPIOB.OSPEEDR.OSPEEDR12 ( %bb -- x addr ) 24 lshift GPIOB.OSPEEDR ; \ GPIOB.OSPEEDR.OSPEEDR12, Port x configuration bits (y =               0..15)
: GPIOB.OSPEEDR.OSPEEDR11 ( %bb -- x addr ) 22 lshift GPIOB.OSPEEDR ; \ GPIOB.OSPEEDR.OSPEEDR11, Port x configuration bits (y =               0..15)
: GPIOB.OSPEEDR.OSPEEDR10 ( %bb -- x addr ) 20 lshift GPIOB.OSPEEDR ; \ GPIOB.OSPEEDR.OSPEEDR10, Port x configuration bits (y =               0..15)
: GPIOB.OSPEEDR.OSPEEDR9 ( %bb -- x addr ) 18 lshift GPIOB.OSPEEDR ; \ GPIOB.OSPEEDR.OSPEEDR9, Port x configuration bits (y =               0..15)
: GPIOB.OSPEEDR.OSPEEDR8 ( %bb -- x addr ) 16 lshift GPIOB.OSPEEDR ; \ GPIOB.OSPEEDR.OSPEEDR8, Port x configuration bits (y =               0..15)
: GPIOB.OSPEEDR.OSPEEDR7 ( %bb -- x addr ) 14 lshift GPIOB.OSPEEDR ; \ GPIOB.OSPEEDR.OSPEEDR7, Port x configuration bits (y =               0..15)
: GPIOB.OSPEEDR.OSPEEDR6 ( %bb -- x addr ) 12 lshift GPIOB.OSPEEDR ; \ GPIOB.OSPEEDR.OSPEEDR6, Port x configuration bits (y =               0..15)
: GPIOB.OSPEEDR.OSPEEDR5 ( %bb -- x addr ) 10 lshift GPIOB.OSPEEDR ; \ GPIOB.OSPEEDR.OSPEEDR5, Port x configuration bits (y =               0..15)
: GPIOB.OSPEEDR.OSPEEDR4 ( %bb -- x addr ) 8 lshift GPIOB.OSPEEDR ; \ GPIOB.OSPEEDR.OSPEEDR4, Port x configuration bits (y =               0..15)
: GPIOB.OSPEEDR.OSPEEDR3 ( %bb -- x addr ) 6 lshift GPIOB.OSPEEDR ; \ GPIOB.OSPEEDR.OSPEEDR3, Port x configuration bits (y =               0..15)
: GPIOB.OSPEEDR.OSPEEDR2 ( %bb -- x addr ) 4 lshift GPIOB.OSPEEDR ; \ GPIOB.OSPEEDR.OSPEEDR2, Port x configuration bits (y =               0..15)
: GPIOB.OSPEEDR.OSPEEDR1 ( %bb -- x addr ) 2 lshift GPIOB.OSPEEDR ; \ GPIOB.OSPEEDR.OSPEEDR1, Port x configuration bits (y =               0..15)
: GPIOB.OSPEEDR.OSPEEDR0 ( %bb -- x addr ) GPIOB.OSPEEDR ; \ GPIOB.OSPEEDR.OSPEEDR0, Port x configuration bits (y =               0..15)

\ GPIOB.PUPDR (read-write) Reset:$00000000
: GPIOB.PUPDR.PUPDR15 ( %bb -- x addr ) 30 lshift GPIOB.PUPDR ; \ GPIOB.PUPDR.PUPDR15, Port x configuration bits (y =               0..15)
: GPIOB.PUPDR.PUPDR14 ( %bb -- x addr ) 28 lshift GPIOB.PUPDR ; \ GPIOB.PUPDR.PUPDR14, Port x configuration bits (y =               0..15)
: GPIOB.PUPDR.PUPDR13 ( %bb -- x addr ) 26 lshift GPIOB.PUPDR ; \ GPIOB.PUPDR.PUPDR13, Port x configuration bits (y =               0..15)
: GPIOB.PUPDR.PUPDR12 ( %bb -- x addr ) 24 lshift GPIOB.PUPDR ; \ GPIOB.PUPDR.PUPDR12, Port x configuration bits (y =               0..15)
: GPIOB.PUPDR.PUPDR11 ( %bb -- x addr ) 22 lshift GPIOB.PUPDR ; \ GPIOB.PUPDR.PUPDR11, Port x configuration bits (y =               0..15)
: GPIOB.PUPDR.PUPDR10 ( %bb -- x addr ) 20 lshift GPIOB.PUPDR ; \ GPIOB.PUPDR.PUPDR10, Port x configuration bits (y =               0..15)
: GPIOB.PUPDR.PUPDR9 ( %bb -- x addr ) 18 lshift GPIOB.PUPDR ; \ GPIOB.PUPDR.PUPDR9, Port x configuration bits (y =               0..15)
: GPIOB.PUPDR.PUPDR8 ( %bb -- x addr ) 16 lshift GPIOB.PUPDR ; \ GPIOB.PUPDR.PUPDR8, Port x configuration bits (y =               0..15)
: GPIOB.PUPDR.PUPDR7 ( %bb -- x addr ) 14 lshift GPIOB.PUPDR ; \ GPIOB.PUPDR.PUPDR7, Port x configuration bits (y =               0..15)
: GPIOB.PUPDR.PUPDR6 ( %bb -- x addr ) 12 lshift GPIOB.PUPDR ; \ GPIOB.PUPDR.PUPDR6, Port x configuration bits (y =               0..15)
: GPIOB.PUPDR.PUPDR5 ( %bb -- x addr ) 10 lshift GPIOB.PUPDR ; \ GPIOB.PUPDR.PUPDR5, Port x configuration bits (y =               0..15)
: GPIOB.PUPDR.PUPDR4 ( %bb -- x addr ) 8 lshift GPIOB.PUPDR ; \ GPIOB.PUPDR.PUPDR4, Port x configuration bits (y =               0..15)
: GPIOB.PUPDR.PUPDR3 ( %bb -- x addr ) 6 lshift GPIOB.PUPDR ; \ GPIOB.PUPDR.PUPDR3, Port x configuration bits (y =               0..15)
: GPIOB.PUPDR.PUPDR2 ( %bb -- x addr ) 4 lshift GPIOB.PUPDR ; \ GPIOB.PUPDR.PUPDR2, Port x configuration bits (y =               0..15)
: GPIOB.PUPDR.PUPDR1 ( %bb -- x addr ) 2 lshift GPIOB.PUPDR ; \ GPIOB.PUPDR.PUPDR1, Port x configuration bits (y =               0..15)
: GPIOB.PUPDR.PUPDR0 ( %bb -- x addr ) GPIOB.PUPDR ; \ GPIOB.PUPDR.PUPDR0, Port x configuration bits (y =               0..15)

\ GPIOB.IDR (read-only) Reset:$00000000
: GPIOB.IDR.IDR15? ( --  1|0 ) 15 bit GPIOB.IDR bit@ ; \ GPIOB.IDR.IDR15, Port input data (y =               0..15)
: GPIOB.IDR.IDR14? ( --  1|0 ) 14 bit GPIOB.IDR bit@ ; \ GPIOB.IDR.IDR14, Port input data (y =               0..15)
: GPIOB.IDR.IDR13? ( --  1|0 ) 13 bit GPIOB.IDR bit@ ; \ GPIOB.IDR.IDR13, Port input data (y =               0..15)
: GPIOB.IDR.IDR12? ( --  1|0 ) 12 bit GPIOB.IDR bit@ ; \ GPIOB.IDR.IDR12, Port input data (y =               0..15)
: GPIOB.IDR.IDR11? ( --  1|0 ) 11 bit GPIOB.IDR bit@ ; \ GPIOB.IDR.IDR11, Port input data (y =               0..15)
: GPIOB.IDR.IDR10? ( --  1|0 ) 10 bit GPIOB.IDR bit@ ; \ GPIOB.IDR.IDR10, Port input data (y =               0..15)
: GPIOB.IDR.IDR9? ( --  1|0 ) 9 bit GPIOB.IDR bit@ ; \ GPIOB.IDR.IDR9, Port input data (y =               0..15)
: GPIOB.IDR.IDR8? ( --  1|0 ) 8 bit GPIOB.IDR bit@ ; \ GPIOB.IDR.IDR8, Port input data (y =               0..15)
: GPIOB.IDR.IDR7? ( --  1|0 ) 7 bit GPIOB.IDR bit@ ; \ GPIOB.IDR.IDR7, Port input data (y =               0..15)
: GPIOB.IDR.IDR6? ( --  1|0 ) 6 bit GPIOB.IDR bit@ ; \ GPIOB.IDR.IDR6, Port input data (y =               0..15)
: GPIOB.IDR.IDR5? ( --  1|0 ) 5 bit GPIOB.IDR bit@ ; \ GPIOB.IDR.IDR5, Port input data (y =               0..15)
: GPIOB.IDR.IDR4? ( --  1|0 ) 4 bit GPIOB.IDR bit@ ; \ GPIOB.IDR.IDR4, Port input data (y =               0..15)
: GPIOB.IDR.IDR3? ( --  1|0 ) 3 bit GPIOB.IDR bit@ ; \ GPIOB.IDR.IDR3, Port input data (y =               0..15)
: GPIOB.IDR.IDR2? ( --  1|0 ) 2 bit GPIOB.IDR bit@ ; \ GPIOB.IDR.IDR2, Port input data (y =               0..15)
: GPIOB.IDR.IDR1? ( --  1|0 ) 1 bit GPIOB.IDR bit@ ; \ GPIOB.IDR.IDR1, Port input data (y =               0..15)
: GPIOB.IDR.IDR0? ( --  1|0 ) 0 bit GPIOB.IDR bit@ ; \ GPIOB.IDR.IDR0, Port input data (y =               0..15)

\ GPIOB.ODR (read-write) Reset:$00000000
: GPIOB.ODR.ODR15 ( -- x addr ) 15 bit GPIOB.ODR ; \ GPIOB.ODR.ODR15, Port output data (y =               0..15)
: GPIOB.ODR.ODR14 ( -- x addr ) 14 bit GPIOB.ODR ; \ GPIOB.ODR.ODR14, Port output data (y =               0..15)
: GPIOB.ODR.ODR13 ( -- x addr ) 13 bit GPIOB.ODR ; \ GPIOB.ODR.ODR13, Port output data (y =               0..15)
: GPIOB.ODR.ODR12 ( -- x addr ) 12 bit GPIOB.ODR ; \ GPIOB.ODR.ODR12, Port output data (y =               0..15)
: GPIOB.ODR.ODR11 ( -- x addr ) 11 bit GPIOB.ODR ; \ GPIOB.ODR.ODR11, Port output data (y =               0..15)
: GPIOB.ODR.ODR10 ( -- x addr ) 10 bit GPIOB.ODR ; \ GPIOB.ODR.ODR10, Port output data (y =               0..15)
: GPIOB.ODR.ODR9 ( -- x addr ) 9 bit GPIOB.ODR ; \ GPIOB.ODR.ODR9, Port output data (y =               0..15)
: GPIOB.ODR.ODR8 ( -- x addr ) 8 bit GPIOB.ODR ; \ GPIOB.ODR.ODR8, Port output data (y =               0..15)
: GPIOB.ODR.ODR7 ( -- x addr ) 7 bit GPIOB.ODR ; \ GPIOB.ODR.ODR7, Port output data (y =               0..15)
: GPIOB.ODR.ODR6 ( -- x addr ) 6 bit GPIOB.ODR ; \ GPIOB.ODR.ODR6, Port output data (y =               0..15)
: GPIOB.ODR.ODR5 ( -- x addr ) 5 bit GPIOB.ODR ; \ GPIOB.ODR.ODR5, Port output data (y =               0..15)
: GPIOB.ODR.ODR4 ( -- x addr ) 4 bit GPIOB.ODR ; \ GPIOB.ODR.ODR4, Port output data (y =               0..15)
: GPIOB.ODR.ODR3 ( -- x addr ) 3 bit GPIOB.ODR ; \ GPIOB.ODR.ODR3, Port output data (y =               0..15)
: GPIOB.ODR.ODR2 ( -- x addr ) 2 bit GPIOB.ODR ; \ GPIOB.ODR.ODR2, Port output data (y =               0..15)
: GPIOB.ODR.ODR1 ( -- x addr ) 1 bit GPIOB.ODR ; \ GPIOB.ODR.ODR1, Port output data (y =               0..15)
: GPIOB.ODR.ODR0 ( -- x addr ) 0 bit GPIOB.ODR ; \ GPIOB.ODR.ODR0, Port output data (y =               0..15)

\ GPIOB.BSRR (write-only) Reset:$00000000
: GPIOB.BSRR.BR15 ( -- ) 31 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BR15, Port x reset bit y (y =               0..15)
: GPIOB.BSRR.BR14 ( -- ) 30 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BR14, Port x reset bit y (y =               0..15)
: GPIOB.BSRR.BR13 ( -- ) 29 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BR13, Port x reset bit y (y =               0..15)
: GPIOB.BSRR.BR12 ( -- ) 28 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BR12, Port x reset bit y (y =               0..15)
: GPIOB.BSRR.BR11 ( -- ) 27 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BR11, Port x reset bit y (y =               0..15)
: GPIOB.BSRR.BR10 ( -- ) 26 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BR10, Port x reset bit y (y =               0..15)
: GPIOB.BSRR.BR9 ( -- ) 25 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BR9, Port x reset bit y (y =               0..15)
: GPIOB.BSRR.BR8 ( -- ) 24 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BR8, Port x reset bit y (y =               0..15)
: GPIOB.BSRR.BR7 ( -- ) 23 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BR7, Port x reset bit y (y =               0..15)
: GPIOB.BSRR.BR6 ( -- ) 22 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BR6, Port x reset bit y (y =               0..15)
: GPIOB.BSRR.BR5 ( -- ) 21 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BR5, Port x reset bit y (y =               0..15)
: GPIOB.BSRR.BR4 ( -- ) 20 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BR4, Port x reset bit y (y =               0..15)
: GPIOB.BSRR.BR3 ( -- ) 19 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BR3, Port x reset bit y (y =               0..15)
: GPIOB.BSRR.BR2 ( -- ) 18 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BR2, Port x reset bit y (y =               0..15)
: GPIOB.BSRR.BR1 ( -- ) 17 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BR1, Port x reset bit y (y =               0..15)
: GPIOB.BSRR.BR0 ( -- ) 16 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BR0, Port x set bit y (y=               0..15)
: GPIOB.BSRR.BS15 ( -- ) 15 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BS15, Port x set bit y (y=               0..15)
: GPIOB.BSRR.BS14 ( -- ) 14 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BS14, Port x set bit y (y=               0..15)
: GPIOB.BSRR.BS13 ( -- ) 13 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BS13, Port x set bit y (y=               0..15)
: GPIOB.BSRR.BS12 ( -- ) 12 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BS12, Port x set bit y (y=               0..15)
: GPIOB.BSRR.BS11 ( -- ) 11 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BS11, Port x set bit y (y=               0..15)
: GPIOB.BSRR.BS10 ( -- ) 10 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BS10, Port x set bit y (y=               0..15)
: GPIOB.BSRR.BS9 ( -- ) 9 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BS9, Port x set bit y (y=               0..15)
: GPIOB.BSRR.BS8 ( -- ) 8 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BS8, Port x set bit y (y=               0..15)
: GPIOB.BSRR.BS7 ( -- ) 7 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BS7, Port x set bit y (y=               0..15)
: GPIOB.BSRR.BS6 ( -- ) 6 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BS6, Port x set bit y (y=               0..15)
: GPIOB.BSRR.BS5 ( -- ) 5 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BS5, Port x set bit y (y=               0..15)
: GPIOB.BSRR.BS4 ( -- ) 4 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BS4, Port x set bit y (y=               0..15)
: GPIOB.BSRR.BS3 ( -- ) 3 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BS3, Port x set bit y (y=               0..15)
: GPIOB.BSRR.BS2 ( -- ) 2 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BS2, Port x set bit y (y=               0..15)
: GPIOB.BSRR.BS1 ( -- ) 1 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BS1, Port x set bit y (y=               0..15)
: GPIOB.BSRR.BS0 ( -- ) 0 bit GPIOB.BSRR ! ; \ GPIOB.BSRR.BS0, Port x set bit y (y=               0..15)

\ GPIOB.LCKR (read-write) Reset:$00000000
: GPIOB.LCKR.LCKK ( -- x addr ) 16 bit GPIOB.LCKR ; \ GPIOB.LCKR.LCKK, Port x lock bit y (y=               0..15)
: GPIOB.LCKR.LCK15 ( -- x addr ) 15 bit GPIOB.LCKR ; \ GPIOB.LCKR.LCK15, Port x lock bit y (y=               0..15)
: GPIOB.LCKR.LCK14 ( -- x addr ) 14 bit GPIOB.LCKR ; \ GPIOB.LCKR.LCK14, Port x lock bit y (y=               0..15)
: GPIOB.LCKR.LCK13 ( -- x addr ) 13 bit GPIOB.LCKR ; \ GPIOB.LCKR.LCK13, Port x lock bit y (y=               0..15)
: GPIOB.LCKR.LCK12 ( -- x addr ) 12 bit GPIOB.LCKR ; \ GPIOB.LCKR.LCK12, Port x lock bit y (y=               0..15)
: GPIOB.LCKR.LCK11 ( -- x addr ) 11 bit GPIOB.LCKR ; \ GPIOB.LCKR.LCK11, Port x lock bit y (y=               0..15)
: GPIOB.LCKR.LCK10 ( -- x addr ) 10 bit GPIOB.LCKR ; \ GPIOB.LCKR.LCK10, Port x lock bit y (y=               0..15)
: GPIOB.LCKR.LCK9 ( -- x addr ) 9 bit GPIOB.LCKR ; \ GPIOB.LCKR.LCK9, Port x lock bit y (y=               0..15)
: GPIOB.LCKR.LCK8 ( -- x addr ) 8 bit GPIOB.LCKR ; \ GPIOB.LCKR.LCK8, Port x lock bit y (y=               0..15)
: GPIOB.LCKR.LCK7 ( -- x addr ) 7 bit GPIOB.LCKR ; \ GPIOB.LCKR.LCK7, Port x lock bit y (y=               0..15)
: GPIOB.LCKR.LCK6 ( -- x addr ) 6 bit GPIOB.LCKR ; \ GPIOB.LCKR.LCK6, Port x lock bit y (y=               0..15)
: GPIOB.LCKR.LCK5 ( -- x addr ) 5 bit GPIOB.LCKR ; \ GPIOB.LCKR.LCK5, Port x lock bit y (y=               0..15)
: GPIOB.LCKR.LCK4 ( -- x addr ) 4 bit GPIOB.LCKR ; \ GPIOB.LCKR.LCK4, Port x lock bit y (y=               0..15)
: GPIOB.LCKR.LCK3 ( -- x addr ) 3 bit GPIOB.LCKR ; \ GPIOB.LCKR.LCK3, Port x lock bit y (y=               0..15)
: GPIOB.LCKR.LCK2 ( -- x addr ) 2 bit GPIOB.LCKR ; \ GPIOB.LCKR.LCK2, Port x lock bit y (y=               0..15)
: GPIOB.LCKR.LCK1 ( -- x addr ) 1 bit GPIOB.LCKR ; \ GPIOB.LCKR.LCK1, Port x lock bit y (y=               0..15)
: GPIOB.LCKR.LCK0 ( -- x addr ) 0 bit GPIOB.LCKR ; \ GPIOB.LCKR.LCK0, Port x lock bit y (y=               0..15)

\ GPIOB.AFRL (read-write) Reset:$00000000
: GPIOB.AFRL.AFSEL7 ( %bbbb -- x addr ) 28 lshift GPIOB.AFRL ; \ GPIOB.AFRL.AFSEL7, Alternate function selection for port x               bit y (y = 0..7)
: GPIOB.AFRL.AFSEL6 ( %bbbb -- x addr ) 24 lshift GPIOB.AFRL ; \ GPIOB.AFRL.AFSEL6, Alternate function selection for port x               bit y (y = 0..7)
: GPIOB.AFRL.AFSEL5 ( %bbbb -- x addr ) 20 lshift GPIOB.AFRL ; \ GPIOB.AFRL.AFSEL5, Alternate function selection for port x               bit y (y = 0..7)
: GPIOB.AFRL.AFSEL4 ( %bbbb -- x addr ) 16 lshift GPIOB.AFRL ; \ GPIOB.AFRL.AFSEL4, Alternate function selection for port x               bit y (y = 0..7)
: GPIOB.AFRL.AFSEL3 ( %bbbb -- x addr ) 12 lshift GPIOB.AFRL ; \ GPIOB.AFRL.AFSEL3, Alternate function selection for port x               bit y (y = 0..7)
: GPIOB.AFRL.AFSEL2 ( %bbbb -- x addr ) 8 lshift GPIOB.AFRL ; \ GPIOB.AFRL.AFSEL2, Alternate function selection for port x               bit y (y = 0..7)
: GPIOB.AFRL.AFSEL1 ( %bbbb -- x addr ) 4 lshift GPIOB.AFRL ; \ GPIOB.AFRL.AFSEL1, Alternate function selection for port x               bit y (y = 0..7)
: GPIOB.AFRL.AFSEL0 ( %bbbb -- x addr ) GPIOB.AFRL ; \ GPIOB.AFRL.AFSEL0, Alternate function selection for port x               bit y (y = 0..7)

\ GPIOB.AFRH (read-write) Reset:$00000000
: GPIOB.AFRH.AFSEL15 ( %bbbb -- x addr ) 28 lshift GPIOB.AFRH ; \ GPIOB.AFRH.AFSEL15, Alternate function selection for port x               bit y (y = 8..15)
: GPIOB.AFRH.AFSEL14 ( %bbbb -- x addr ) 24 lshift GPIOB.AFRH ; \ GPIOB.AFRH.AFSEL14, Alternate function selection for port x               bit y (y = 8..15)
: GPIOB.AFRH.AFSEL13 ( %bbbb -- x addr ) 20 lshift GPIOB.AFRH ; \ GPIOB.AFRH.AFSEL13, Alternate function selection for port x               bit y (y = 8..15)
: GPIOB.AFRH.AFSEL12 ( %bbbb -- x addr ) 16 lshift GPIOB.AFRH ; \ GPIOB.AFRH.AFSEL12, Alternate function selection for port x               bit y (y = 8..15)
: GPIOB.AFRH.AFSEL11 ( %bbbb -- x addr ) 12 lshift GPIOB.AFRH ; \ GPIOB.AFRH.AFSEL11, Alternate function selection for port x               bit y (y = 8..15)
: GPIOB.AFRH.AFSEL10 ( %bbbb -- x addr ) 8 lshift GPIOB.AFRH ; \ GPIOB.AFRH.AFSEL10, Alternate function selection for port x               bit y (y = 8..15)
: GPIOB.AFRH.AFSEL9 ( %bbbb -- x addr ) 4 lshift GPIOB.AFRH ; \ GPIOB.AFRH.AFSEL9, Alternate function selection for port x               bit y (y = 8..15)
: GPIOB.AFRH.AFSEL8 ( %bbbb -- x addr ) GPIOB.AFRH ; \ GPIOB.AFRH.AFSEL8, Alternate function selection for port x               bit y (y = 8..15)

\ GPIOB.BRR (write-only) Reset:$00000000
: GPIOB.BRR.BR0 ( -- ) 0 bit GPIOB.BRR ! ; \ GPIOB.BRR.BR0, Port Reset bit
: GPIOB.BRR.BR1 ( -- ) 1 bit GPIOB.BRR ! ; \ GPIOB.BRR.BR1, Port Reset bit
: GPIOB.BRR.BR2 ( -- ) 2 bit GPIOB.BRR ! ; \ GPIOB.BRR.BR2, Port Reset bit
: GPIOB.BRR.BR3 ( -- ) 3 bit GPIOB.BRR ! ; \ GPIOB.BRR.BR3, Port Reset bit
: GPIOB.BRR.BR4 ( -- ) 4 bit GPIOB.BRR ! ; \ GPIOB.BRR.BR4, Port Reset bit
: GPIOB.BRR.BR5 ( -- ) 5 bit GPIOB.BRR ! ; \ GPIOB.BRR.BR5, Port Reset bit
: GPIOB.BRR.BR6 ( -- ) 6 bit GPIOB.BRR ! ; \ GPIOB.BRR.BR6, Port Reset bit
: GPIOB.BRR.BR7 ( -- ) 7 bit GPIOB.BRR ! ; \ GPIOB.BRR.BR7, Port Reset bit
: GPIOB.BRR.BR8 ( -- ) 8 bit GPIOB.BRR ! ; \ GPIOB.BRR.BR8, Port Reset bit
: GPIOB.BRR.BR9 ( -- ) 9 bit GPIOB.BRR ! ; \ GPIOB.BRR.BR9, Port Reset bit
: GPIOB.BRR.BR10 ( -- ) 10 bit GPIOB.BRR ! ; \ GPIOB.BRR.BR10, Port Reset bit
: GPIOB.BRR.BR11 ( -- ) 11 bit GPIOB.BRR ! ; \ GPIOB.BRR.BR11, Port Reset bit
: GPIOB.BRR.BR12 ( -- ) 12 bit GPIOB.BRR ! ; \ GPIOB.BRR.BR12, Port Reset bit
: GPIOB.BRR.BR13 ( -- ) 13 bit GPIOB.BRR ! ; \ GPIOB.BRR.BR13, Port Reset bit
: GPIOB.BRR.BR14 ( -- ) 14 bit GPIOB.BRR ! ; \ GPIOB.BRR.BR14, Port Reset bit
: GPIOB.BRR.BR15 ( -- ) 15 bit GPIOB.BRR ! ; \ GPIOB.BRR.BR15, Port Reset bit

\ GPIOC.MODER (read-write) Reset:$FFFFFFFF
: GPIOC.MODER.MODER15 ( %bb -- x addr ) 30 lshift GPIOC.MODER ; \ GPIOC.MODER.MODER15, Port x configuration bits (y =               0..15)
: GPIOC.MODER.MODER14 ( %bb -- x addr ) 28 lshift GPIOC.MODER ; \ GPIOC.MODER.MODER14, Port x configuration bits (y =               0..15)
: GPIOC.MODER.MODER13 ( %bb -- x addr ) 26 lshift GPIOC.MODER ; \ GPIOC.MODER.MODER13, Port x configuration bits (y =               0..15)
: GPIOC.MODER.MODER12 ( %bb -- x addr ) 24 lshift GPIOC.MODER ; \ GPIOC.MODER.MODER12, Port x configuration bits (y =               0..15)
: GPIOC.MODER.MODER11 ( %bb -- x addr ) 22 lshift GPIOC.MODER ; \ GPIOC.MODER.MODER11, Port x configuration bits (y =               0..15)
: GPIOC.MODER.MODER10 ( %bb -- x addr ) 20 lshift GPIOC.MODER ; \ GPIOC.MODER.MODER10, Port x configuration bits (y =               0..15)
: GPIOC.MODER.MODER9 ( %bb -- x addr ) 18 lshift GPIOC.MODER ; \ GPIOC.MODER.MODER9, Port x configuration bits (y =               0..15)
: GPIOC.MODER.MODER8 ( %bb -- x addr ) 16 lshift GPIOC.MODER ; \ GPIOC.MODER.MODER8, Port x configuration bits (y =               0..15)
: GPIOC.MODER.MODER7 ( %bb -- x addr ) 14 lshift GPIOC.MODER ; \ GPIOC.MODER.MODER7, Port x configuration bits (y =               0..15)
: GPIOC.MODER.MODER6 ( %bb -- x addr ) 12 lshift GPIOC.MODER ; \ GPIOC.MODER.MODER6, Port x configuration bits (y =               0..15)
: GPIOC.MODER.MODER5 ( %bb -- x addr ) 10 lshift GPIOC.MODER ; \ GPIOC.MODER.MODER5, Port x configuration bits (y =               0..15)
: GPIOC.MODER.MODER4 ( %bb -- x addr ) 8 lshift GPIOC.MODER ; \ GPIOC.MODER.MODER4, Port x configuration bits (y =               0..15)
: GPIOC.MODER.MODER3 ( %bb -- x addr ) 6 lshift GPIOC.MODER ; \ GPIOC.MODER.MODER3, Port x configuration bits (y =               0..15)
: GPIOC.MODER.MODER2 ( %bb -- x addr ) 4 lshift GPIOC.MODER ; \ GPIOC.MODER.MODER2, Port x configuration bits (y =               0..15)
: GPIOC.MODER.MODER1 ( %bb -- x addr ) 2 lshift GPIOC.MODER ; \ GPIOC.MODER.MODER1, Port x configuration bits (y =               0..15)
: GPIOC.MODER.MODER0 ( %bb -- x addr ) GPIOC.MODER ; \ GPIOC.MODER.MODER0, Port x configuration bits (y =               0..15)

\ GPIOC.OTYPER (read-write) Reset:$00000000
: GPIOC.OTYPER.OT15 ( -- x addr ) 15 bit GPIOC.OTYPER ; \ GPIOC.OTYPER.OT15, Port x configuration bits (y =               0..15)
: GPIOC.OTYPER.OT14 ( -- x addr ) 14 bit GPIOC.OTYPER ; \ GPIOC.OTYPER.OT14, Port x configuration bits (y =               0..15)
: GPIOC.OTYPER.OT13 ( -- x addr ) 13 bit GPIOC.OTYPER ; \ GPIOC.OTYPER.OT13, Port x configuration bits (y =               0..15)
: GPIOC.OTYPER.OT12 ( -- x addr ) 12 bit GPIOC.OTYPER ; \ GPIOC.OTYPER.OT12, Port x configuration bits (y =               0..15)
: GPIOC.OTYPER.OT11 ( -- x addr ) 11 bit GPIOC.OTYPER ; \ GPIOC.OTYPER.OT11, Port x configuration bits (y =               0..15)
: GPIOC.OTYPER.OT10 ( -- x addr ) 10 bit GPIOC.OTYPER ; \ GPIOC.OTYPER.OT10, Port x configuration bits (y =               0..15)
: GPIOC.OTYPER.OT9 ( -- x addr ) 9 bit GPIOC.OTYPER ; \ GPIOC.OTYPER.OT9, Port x configuration bits (y =               0..15)
: GPIOC.OTYPER.OT8 ( -- x addr ) 8 bit GPIOC.OTYPER ; \ GPIOC.OTYPER.OT8, Port x configuration bits (y =               0..15)
: GPIOC.OTYPER.OT7 ( -- x addr ) 7 bit GPIOC.OTYPER ; \ GPIOC.OTYPER.OT7, Port x configuration bits (y =               0..15)
: GPIOC.OTYPER.OT6 ( -- x addr ) 6 bit GPIOC.OTYPER ; \ GPIOC.OTYPER.OT6, Port x configuration bits (y =               0..15)
: GPIOC.OTYPER.OT5 ( -- x addr ) 5 bit GPIOC.OTYPER ; \ GPIOC.OTYPER.OT5, Port x configuration bits (y =               0..15)
: GPIOC.OTYPER.OT4 ( -- x addr ) 4 bit GPIOC.OTYPER ; \ GPIOC.OTYPER.OT4, Port x configuration bits (y =               0..15)
: GPIOC.OTYPER.OT3 ( -- x addr ) 3 bit GPIOC.OTYPER ; \ GPIOC.OTYPER.OT3, Port x configuration bits (y =               0..15)
: GPIOC.OTYPER.OT2 ( -- x addr ) 2 bit GPIOC.OTYPER ; \ GPIOC.OTYPER.OT2, Port x configuration bits (y =               0..15)
: GPIOC.OTYPER.OT1 ( -- x addr ) 1 bit GPIOC.OTYPER ; \ GPIOC.OTYPER.OT1, Port x configuration bits (y =               0..15)
: GPIOC.OTYPER.OT0 ( -- x addr ) 0 bit GPIOC.OTYPER ; \ GPIOC.OTYPER.OT0, Port x configuration bits (y =               0..15)

\ GPIOC.OSPEEDR (read-write) Reset:$00000000
: GPIOC.OSPEEDR.OSPEEDR15 ( %bb -- x addr ) 30 lshift GPIOC.OSPEEDR ; \ GPIOC.OSPEEDR.OSPEEDR15, Port x configuration bits (y =               0..15)
: GPIOC.OSPEEDR.OSPEEDR14 ( %bb -- x addr ) 28 lshift GPIOC.OSPEEDR ; \ GPIOC.OSPEEDR.OSPEEDR14, Port x configuration bits (y =               0..15)
: GPIOC.OSPEEDR.OSPEEDR13 ( %bb -- x addr ) 26 lshift GPIOC.OSPEEDR ; \ GPIOC.OSPEEDR.OSPEEDR13, Port x configuration bits (y =               0..15)
: GPIOC.OSPEEDR.OSPEEDR12 ( %bb -- x addr ) 24 lshift GPIOC.OSPEEDR ; \ GPIOC.OSPEEDR.OSPEEDR12, Port x configuration bits (y =               0..15)
: GPIOC.OSPEEDR.OSPEEDR11 ( %bb -- x addr ) 22 lshift GPIOC.OSPEEDR ; \ GPIOC.OSPEEDR.OSPEEDR11, Port x configuration bits (y =               0..15)
: GPIOC.OSPEEDR.OSPEEDR10 ( %bb -- x addr ) 20 lshift GPIOC.OSPEEDR ; \ GPIOC.OSPEEDR.OSPEEDR10, Port x configuration bits (y =               0..15)
: GPIOC.OSPEEDR.OSPEEDR9 ( %bb -- x addr ) 18 lshift GPIOC.OSPEEDR ; \ GPIOC.OSPEEDR.OSPEEDR9, Port x configuration bits (y =               0..15)
: GPIOC.OSPEEDR.OSPEEDR8 ( %bb -- x addr ) 16 lshift GPIOC.OSPEEDR ; \ GPIOC.OSPEEDR.OSPEEDR8, Port x configuration bits (y =               0..15)
: GPIOC.OSPEEDR.OSPEEDR7 ( %bb -- x addr ) 14 lshift GPIOC.OSPEEDR ; \ GPIOC.OSPEEDR.OSPEEDR7, Port x configuration bits (y =               0..15)
: GPIOC.OSPEEDR.OSPEEDR6 ( %bb -- x addr ) 12 lshift GPIOC.OSPEEDR ; \ GPIOC.OSPEEDR.OSPEEDR6, Port x configuration bits (y =               0..15)
: GPIOC.OSPEEDR.OSPEEDR5 ( %bb -- x addr ) 10 lshift GPIOC.OSPEEDR ; \ GPIOC.OSPEEDR.OSPEEDR5, Port x configuration bits (y =               0..15)
: GPIOC.OSPEEDR.OSPEEDR4 ( %bb -- x addr ) 8 lshift GPIOC.OSPEEDR ; \ GPIOC.OSPEEDR.OSPEEDR4, Port x configuration bits (y =               0..15)
: GPIOC.OSPEEDR.OSPEEDR3 ( %bb -- x addr ) 6 lshift GPIOC.OSPEEDR ; \ GPIOC.OSPEEDR.OSPEEDR3, Port x configuration bits (y =               0..15)
: GPIOC.OSPEEDR.OSPEEDR2 ( %bb -- x addr ) 4 lshift GPIOC.OSPEEDR ; \ GPIOC.OSPEEDR.OSPEEDR2, Port x configuration bits (y =               0..15)
: GPIOC.OSPEEDR.OSPEEDR1 ( %bb -- x addr ) 2 lshift GPIOC.OSPEEDR ; \ GPIOC.OSPEEDR.OSPEEDR1, Port x configuration bits (y =               0..15)
: GPIOC.OSPEEDR.OSPEEDR0 ( %bb -- x addr ) GPIOC.OSPEEDR ; \ GPIOC.OSPEEDR.OSPEEDR0, Port x configuration bits (y =               0..15)

\ GPIOC.PUPDR (read-write) Reset:$00000000
: GPIOC.PUPDR.PUPDR15 ( %bb -- x addr ) 30 lshift GPIOC.PUPDR ; \ GPIOC.PUPDR.PUPDR15, Port x configuration bits (y =               0..15)
: GPIOC.PUPDR.PUPDR14 ( %bb -- x addr ) 28 lshift GPIOC.PUPDR ; \ GPIOC.PUPDR.PUPDR14, Port x configuration bits (y =               0..15)
: GPIOC.PUPDR.PUPDR13 ( %bb -- x addr ) 26 lshift GPIOC.PUPDR ; \ GPIOC.PUPDR.PUPDR13, Port x configuration bits (y =               0..15)
: GPIOC.PUPDR.PUPDR12 ( %bb -- x addr ) 24 lshift GPIOC.PUPDR ; \ GPIOC.PUPDR.PUPDR12, Port x configuration bits (y =               0..15)
: GPIOC.PUPDR.PUPDR11 ( %bb -- x addr ) 22 lshift GPIOC.PUPDR ; \ GPIOC.PUPDR.PUPDR11, Port x configuration bits (y =               0..15)
: GPIOC.PUPDR.PUPDR10 ( %bb -- x addr ) 20 lshift GPIOC.PUPDR ; \ GPIOC.PUPDR.PUPDR10, Port x configuration bits (y =               0..15)
: GPIOC.PUPDR.PUPDR9 ( %bb -- x addr ) 18 lshift GPIOC.PUPDR ; \ GPIOC.PUPDR.PUPDR9, Port x configuration bits (y =               0..15)
: GPIOC.PUPDR.PUPDR8 ( %bb -- x addr ) 16 lshift GPIOC.PUPDR ; \ GPIOC.PUPDR.PUPDR8, Port x configuration bits (y =               0..15)
: GPIOC.PUPDR.PUPDR7 ( %bb -- x addr ) 14 lshift GPIOC.PUPDR ; \ GPIOC.PUPDR.PUPDR7, Port x configuration bits (y =               0..15)
: GPIOC.PUPDR.PUPDR6 ( %bb -- x addr ) 12 lshift GPIOC.PUPDR ; \ GPIOC.PUPDR.PUPDR6, Port x configuration bits (y =               0..15)
: GPIOC.PUPDR.PUPDR5 ( %bb -- x addr ) 10 lshift GPIOC.PUPDR ; \ GPIOC.PUPDR.PUPDR5, Port x configuration bits (y =               0..15)
: GPIOC.PUPDR.PUPDR4 ( %bb -- x addr ) 8 lshift GPIOC.PUPDR ; \ GPIOC.PUPDR.PUPDR4, Port x configuration bits (y =               0..15)
: GPIOC.PUPDR.PUPDR3 ( %bb -- x addr ) 6 lshift GPIOC.PUPDR ; \ GPIOC.PUPDR.PUPDR3, Port x configuration bits (y =               0..15)
: GPIOC.PUPDR.PUPDR2 ( %bb -- x addr ) 4 lshift GPIOC.PUPDR ; \ GPIOC.PUPDR.PUPDR2, Port x configuration bits (y =               0..15)
: GPIOC.PUPDR.PUPDR1 ( %bb -- x addr ) 2 lshift GPIOC.PUPDR ; \ GPIOC.PUPDR.PUPDR1, Port x configuration bits (y =               0..15)
: GPIOC.PUPDR.PUPDR0 ( %bb -- x addr ) GPIOC.PUPDR ; \ GPIOC.PUPDR.PUPDR0, Port x configuration bits (y =               0..15)

\ GPIOC.IDR (read-only) Reset:$00000000
: GPIOC.IDR.IDR15? ( --  1|0 ) 15 bit GPIOC.IDR bit@ ; \ GPIOC.IDR.IDR15, Port input data (y =               0..15)
: GPIOC.IDR.IDR14? ( --  1|0 ) 14 bit GPIOC.IDR bit@ ; \ GPIOC.IDR.IDR14, Port input data (y =               0..15)
: GPIOC.IDR.IDR13? ( --  1|0 ) 13 bit GPIOC.IDR bit@ ; \ GPIOC.IDR.IDR13, Port input data (y =               0..15)
: GPIOC.IDR.IDR12? ( --  1|0 ) 12 bit GPIOC.IDR bit@ ; \ GPIOC.IDR.IDR12, Port input data (y =               0..15)
: GPIOC.IDR.IDR11? ( --  1|0 ) 11 bit GPIOC.IDR bit@ ; \ GPIOC.IDR.IDR11, Port input data (y =               0..15)
: GPIOC.IDR.IDR10? ( --  1|0 ) 10 bit GPIOC.IDR bit@ ; \ GPIOC.IDR.IDR10, Port input data (y =               0..15)
: GPIOC.IDR.IDR9? ( --  1|0 ) 9 bit GPIOC.IDR bit@ ; \ GPIOC.IDR.IDR9, Port input data (y =               0..15)
: GPIOC.IDR.IDR8? ( --  1|0 ) 8 bit GPIOC.IDR bit@ ; \ GPIOC.IDR.IDR8, Port input data (y =               0..15)
: GPIOC.IDR.IDR7? ( --  1|0 ) 7 bit GPIOC.IDR bit@ ; \ GPIOC.IDR.IDR7, Port input data (y =               0..15)
: GPIOC.IDR.IDR6? ( --  1|0 ) 6 bit GPIOC.IDR bit@ ; \ GPIOC.IDR.IDR6, Port input data (y =               0..15)
: GPIOC.IDR.IDR5? ( --  1|0 ) 5 bit GPIOC.IDR bit@ ; \ GPIOC.IDR.IDR5, Port input data (y =               0..15)
: GPIOC.IDR.IDR4? ( --  1|0 ) 4 bit GPIOC.IDR bit@ ; \ GPIOC.IDR.IDR4, Port input data (y =               0..15)
: GPIOC.IDR.IDR3? ( --  1|0 ) 3 bit GPIOC.IDR bit@ ; \ GPIOC.IDR.IDR3, Port input data (y =               0..15)
: GPIOC.IDR.IDR2? ( --  1|0 ) 2 bit GPIOC.IDR bit@ ; \ GPIOC.IDR.IDR2, Port input data (y =               0..15)
: GPIOC.IDR.IDR1? ( --  1|0 ) 1 bit GPIOC.IDR bit@ ; \ GPIOC.IDR.IDR1, Port input data (y =               0..15)
: GPIOC.IDR.IDR0? ( --  1|0 ) 0 bit GPIOC.IDR bit@ ; \ GPIOC.IDR.IDR0, Port input data (y =               0..15)

\ GPIOC.ODR (read-write) Reset:$00000000
: GPIOC.ODR.ODR15 ( -- x addr ) 15 bit GPIOC.ODR ; \ GPIOC.ODR.ODR15, Port output data (y =               0..15)
: GPIOC.ODR.ODR14 ( -- x addr ) 14 bit GPIOC.ODR ; \ GPIOC.ODR.ODR14, Port output data (y =               0..15)
: GPIOC.ODR.ODR13 ( -- x addr ) 13 bit GPIOC.ODR ; \ GPIOC.ODR.ODR13, Port output data (y =               0..15)
: GPIOC.ODR.ODR12 ( -- x addr ) 12 bit GPIOC.ODR ; \ GPIOC.ODR.ODR12, Port output data (y =               0..15)
: GPIOC.ODR.ODR11 ( -- x addr ) 11 bit GPIOC.ODR ; \ GPIOC.ODR.ODR11, Port output data (y =               0..15)
: GPIOC.ODR.ODR10 ( -- x addr ) 10 bit GPIOC.ODR ; \ GPIOC.ODR.ODR10, Port output data (y =               0..15)
: GPIOC.ODR.ODR9 ( -- x addr ) 9 bit GPIOC.ODR ; \ GPIOC.ODR.ODR9, Port output data (y =               0..15)
: GPIOC.ODR.ODR8 ( -- x addr ) 8 bit GPIOC.ODR ; \ GPIOC.ODR.ODR8, Port output data (y =               0..15)
: GPIOC.ODR.ODR7 ( -- x addr ) 7 bit GPIOC.ODR ; \ GPIOC.ODR.ODR7, Port output data (y =               0..15)
: GPIOC.ODR.ODR6 ( -- x addr ) 6 bit GPIOC.ODR ; \ GPIOC.ODR.ODR6, Port output data (y =               0..15)
: GPIOC.ODR.ODR5 ( -- x addr ) 5 bit GPIOC.ODR ; \ GPIOC.ODR.ODR5, Port output data (y =               0..15)
: GPIOC.ODR.ODR4 ( -- x addr ) 4 bit GPIOC.ODR ; \ GPIOC.ODR.ODR4, Port output data (y =               0..15)
: GPIOC.ODR.ODR3 ( -- x addr ) 3 bit GPIOC.ODR ; \ GPIOC.ODR.ODR3, Port output data (y =               0..15)
: GPIOC.ODR.ODR2 ( -- x addr ) 2 bit GPIOC.ODR ; \ GPIOC.ODR.ODR2, Port output data (y =               0..15)
: GPIOC.ODR.ODR1 ( -- x addr ) 1 bit GPIOC.ODR ; \ GPIOC.ODR.ODR1, Port output data (y =               0..15)
: GPIOC.ODR.ODR0 ( -- x addr ) 0 bit GPIOC.ODR ; \ GPIOC.ODR.ODR0, Port output data (y =               0..15)

\ GPIOC.BSRR (write-only) Reset:$00000000
: GPIOC.BSRR.BR15 ( -- ) 31 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BR15, Port x reset bit y (y =               0..15)
: GPIOC.BSRR.BR14 ( -- ) 30 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BR14, Port x reset bit y (y =               0..15)
: GPIOC.BSRR.BR13 ( -- ) 29 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BR13, Port x reset bit y (y =               0..15)
: GPIOC.BSRR.BR12 ( -- ) 28 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BR12, Port x reset bit y (y =               0..15)
: GPIOC.BSRR.BR11 ( -- ) 27 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BR11, Port x reset bit y (y =               0..15)
: GPIOC.BSRR.BR10 ( -- ) 26 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BR10, Port x reset bit y (y =               0..15)
: GPIOC.BSRR.BR9 ( -- ) 25 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BR9, Port x reset bit y (y =               0..15)
: GPIOC.BSRR.BR8 ( -- ) 24 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BR8, Port x reset bit y (y =               0..15)
: GPIOC.BSRR.BR7 ( -- ) 23 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BR7, Port x reset bit y (y =               0..15)
: GPIOC.BSRR.BR6 ( -- ) 22 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BR6, Port x reset bit y (y =               0..15)
: GPIOC.BSRR.BR5 ( -- ) 21 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BR5, Port x reset bit y (y =               0..15)
: GPIOC.BSRR.BR4 ( -- ) 20 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BR4, Port x reset bit y (y =               0..15)
: GPIOC.BSRR.BR3 ( -- ) 19 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BR3, Port x reset bit y (y =               0..15)
: GPIOC.BSRR.BR2 ( -- ) 18 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BR2, Port x reset bit y (y =               0..15)
: GPIOC.BSRR.BR1 ( -- ) 17 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BR1, Port x reset bit y (y =               0..15)
: GPIOC.BSRR.BR0 ( -- ) 16 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BR0, Port x set bit y (y=               0..15)
: GPIOC.BSRR.BS15 ( -- ) 15 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BS15, Port x set bit y (y=               0..15)
: GPIOC.BSRR.BS14 ( -- ) 14 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BS14, Port x set bit y (y=               0..15)
: GPIOC.BSRR.BS13 ( -- ) 13 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BS13, Port x set bit y (y=               0..15)
: GPIOC.BSRR.BS12 ( -- ) 12 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BS12, Port x set bit y (y=               0..15)
: GPIOC.BSRR.BS11 ( -- ) 11 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BS11, Port x set bit y (y=               0..15)
: GPIOC.BSRR.BS10 ( -- ) 10 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BS10, Port x set bit y (y=               0..15)
: GPIOC.BSRR.BS9 ( -- ) 9 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BS9, Port x set bit y (y=               0..15)
: GPIOC.BSRR.BS8 ( -- ) 8 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BS8, Port x set bit y (y=               0..15)
: GPIOC.BSRR.BS7 ( -- ) 7 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BS7, Port x set bit y (y=               0..15)
: GPIOC.BSRR.BS6 ( -- ) 6 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BS6, Port x set bit y (y=               0..15)
: GPIOC.BSRR.BS5 ( -- ) 5 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BS5, Port x set bit y (y=               0..15)
: GPIOC.BSRR.BS4 ( -- ) 4 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BS4, Port x set bit y (y=               0..15)
: GPIOC.BSRR.BS3 ( -- ) 3 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BS3, Port x set bit y (y=               0..15)
: GPIOC.BSRR.BS2 ( -- ) 2 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BS2, Port x set bit y (y=               0..15)
: GPIOC.BSRR.BS1 ( -- ) 1 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BS1, Port x set bit y (y=               0..15)
: GPIOC.BSRR.BS0 ( -- ) 0 bit GPIOC.BSRR ! ; \ GPIOC.BSRR.BS0, Port x set bit y (y=               0..15)

\ GPIOC.LCKR (read-write) Reset:$00000000
: GPIOC.LCKR.LCKK ( -- x addr ) 16 bit GPIOC.LCKR ; \ GPIOC.LCKR.LCKK, Port x lock bit y (y=               0..15)
: GPIOC.LCKR.LCK15 ( -- x addr ) 15 bit GPIOC.LCKR ; \ GPIOC.LCKR.LCK15, Port x lock bit y (y=               0..15)
: GPIOC.LCKR.LCK14 ( -- x addr ) 14 bit GPIOC.LCKR ; \ GPIOC.LCKR.LCK14, Port x lock bit y (y=               0..15)
: GPIOC.LCKR.LCK13 ( -- x addr ) 13 bit GPIOC.LCKR ; \ GPIOC.LCKR.LCK13, Port x lock bit y (y=               0..15)
: GPIOC.LCKR.LCK12 ( -- x addr ) 12 bit GPIOC.LCKR ; \ GPIOC.LCKR.LCK12, Port x lock bit y (y=               0..15)
: GPIOC.LCKR.LCK11 ( -- x addr ) 11 bit GPIOC.LCKR ; \ GPIOC.LCKR.LCK11, Port x lock bit y (y=               0..15)
: GPIOC.LCKR.LCK10 ( -- x addr ) 10 bit GPIOC.LCKR ; \ GPIOC.LCKR.LCK10, Port x lock bit y (y=               0..15)
: GPIOC.LCKR.LCK9 ( -- x addr ) 9 bit GPIOC.LCKR ; \ GPIOC.LCKR.LCK9, Port x lock bit y (y=               0..15)
: GPIOC.LCKR.LCK8 ( -- x addr ) 8 bit GPIOC.LCKR ; \ GPIOC.LCKR.LCK8, Port x lock bit y (y=               0..15)
: GPIOC.LCKR.LCK7 ( -- x addr ) 7 bit GPIOC.LCKR ; \ GPIOC.LCKR.LCK7, Port x lock bit y (y=               0..15)
: GPIOC.LCKR.LCK6 ( -- x addr ) 6 bit GPIOC.LCKR ; \ GPIOC.LCKR.LCK6, Port x lock bit y (y=               0..15)
: GPIOC.LCKR.LCK5 ( -- x addr ) 5 bit GPIOC.LCKR ; \ GPIOC.LCKR.LCK5, Port x lock bit y (y=               0..15)
: GPIOC.LCKR.LCK4 ( -- x addr ) 4 bit GPIOC.LCKR ; \ GPIOC.LCKR.LCK4, Port x lock bit y (y=               0..15)
: GPIOC.LCKR.LCK3 ( -- x addr ) 3 bit GPIOC.LCKR ; \ GPIOC.LCKR.LCK3, Port x lock bit y (y=               0..15)
: GPIOC.LCKR.LCK2 ( -- x addr ) 2 bit GPIOC.LCKR ; \ GPIOC.LCKR.LCK2, Port x lock bit y (y=               0..15)
: GPIOC.LCKR.LCK1 ( -- x addr ) 1 bit GPIOC.LCKR ; \ GPIOC.LCKR.LCK1, Port x lock bit y (y=               0..15)
: GPIOC.LCKR.LCK0 ( -- x addr ) 0 bit GPIOC.LCKR ; \ GPIOC.LCKR.LCK0, Port x lock bit y (y=               0..15)

\ GPIOC.AFRL (read-write) Reset:$00000000
: GPIOC.AFRL.AFSEL7 ( %bbbb -- x addr ) 28 lshift GPIOC.AFRL ; \ GPIOC.AFRL.AFSEL7, Alternate function selection for port x               bit y (y = 0..7)
: GPIOC.AFRL.AFSEL6 ( %bbbb -- x addr ) 24 lshift GPIOC.AFRL ; \ GPIOC.AFRL.AFSEL6, Alternate function selection for port x               bit y (y = 0..7)
: GPIOC.AFRL.AFSEL5 ( %bbbb -- x addr ) 20 lshift GPIOC.AFRL ; \ GPIOC.AFRL.AFSEL5, Alternate function selection for port x               bit y (y = 0..7)
: GPIOC.AFRL.AFSEL4 ( %bbbb -- x addr ) 16 lshift GPIOC.AFRL ; \ GPIOC.AFRL.AFSEL4, Alternate function selection for port x               bit y (y = 0..7)
: GPIOC.AFRL.AFSEL3 ( %bbbb -- x addr ) 12 lshift GPIOC.AFRL ; \ GPIOC.AFRL.AFSEL3, Alternate function selection for port x               bit y (y = 0..7)
: GPIOC.AFRL.AFSEL2 ( %bbbb -- x addr ) 8 lshift GPIOC.AFRL ; \ GPIOC.AFRL.AFSEL2, Alternate function selection for port x               bit y (y = 0..7)
: GPIOC.AFRL.AFSEL1 ( %bbbb -- x addr ) 4 lshift GPIOC.AFRL ; \ GPIOC.AFRL.AFSEL1, Alternate function selection for port x               bit y (y = 0..7)
: GPIOC.AFRL.AFSEL0 ( %bbbb -- x addr ) GPIOC.AFRL ; \ GPIOC.AFRL.AFSEL0, Alternate function selection for port x               bit y (y = 0..7)

\ GPIOC.AFRH (read-write) Reset:$00000000
: GPIOC.AFRH.AFSEL15 ( %bbbb -- x addr ) 28 lshift GPIOC.AFRH ; \ GPIOC.AFRH.AFSEL15, Alternate function selection for port x               bit y (y = 8..15)
: GPIOC.AFRH.AFSEL14 ( %bbbb -- x addr ) 24 lshift GPIOC.AFRH ; \ GPIOC.AFRH.AFSEL14, Alternate function selection for port x               bit y (y = 8..15)
: GPIOC.AFRH.AFSEL13 ( %bbbb -- x addr ) 20 lshift GPIOC.AFRH ; \ GPIOC.AFRH.AFSEL13, Alternate function selection for port x               bit y (y = 8..15)
: GPIOC.AFRH.AFSEL12 ( %bbbb -- x addr ) 16 lshift GPIOC.AFRH ; \ GPIOC.AFRH.AFSEL12, Alternate function selection for port x               bit y (y = 8..15)
: GPIOC.AFRH.AFSEL11 ( %bbbb -- x addr ) 12 lshift GPIOC.AFRH ; \ GPIOC.AFRH.AFSEL11, Alternate function selection for port x               bit y (y = 8..15)
: GPIOC.AFRH.AFSEL10 ( %bbbb -- x addr ) 8 lshift GPIOC.AFRH ; \ GPIOC.AFRH.AFSEL10, Alternate function selection for port x               bit y (y = 8..15)
: GPIOC.AFRH.AFSEL9 ( %bbbb -- x addr ) 4 lshift GPIOC.AFRH ; \ GPIOC.AFRH.AFSEL9, Alternate function selection for port x               bit y (y = 8..15)
: GPIOC.AFRH.AFSEL8 ( %bbbb -- x addr ) GPIOC.AFRH ; \ GPIOC.AFRH.AFSEL8, Alternate function selection for port x               bit y (y = 8..15)

\ GPIOC.BRR (write-only) Reset:$00000000
: GPIOC.BRR.BR0 ( -- ) 0 bit GPIOC.BRR ! ; \ GPIOC.BRR.BR0, Port Reset bit
: GPIOC.BRR.BR1 ( -- ) 1 bit GPIOC.BRR ! ; \ GPIOC.BRR.BR1, Port Reset bit
: GPIOC.BRR.BR2 ( -- ) 2 bit GPIOC.BRR ! ; \ GPIOC.BRR.BR2, Port Reset bit
: GPIOC.BRR.BR3 ( -- ) 3 bit GPIOC.BRR ! ; \ GPIOC.BRR.BR3, Port Reset bit
: GPIOC.BRR.BR4 ( -- ) 4 bit GPIOC.BRR ! ; \ GPIOC.BRR.BR4, Port Reset bit
: GPIOC.BRR.BR5 ( -- ) 5 bit GPIOC.BRR ! ; \ GPIOC.BRR.BR5, Port Reset bit
: GPIOC.BRR.BR6 ( -- ) 6 bit GPIOC.BRR ! ; \ GPIOC.BRR.BR6, Port Reset bit
: GPIOC.BRR.BR7 ( -- ) 7 bit GPIOC.BRR ! ; \ GPIOC.BRR.BR7, Port Reset bit
: GPIOC.BRR.BR8 ( -- ) 8 bit GPIOC.BRR ! ; \ GPIOC.BRR.BR8, Port Reset bit
: GPIOC.BRR.BR9 ( -- ) 9 bit GPIOC.BRR ! ; \ GPIOC.BRR.BR9, Port Reset bit
: GPIOC.BRR.BR10 ( -- ) 10 bit GPIOC.BRR ! ; \ GPIOC.BRR.BR10, Port Reset bit
: GPIOC.BRR.BR11 ( -- ) 11 bit GPIOC.BRR ! ; \ GPIOC.BRR.BR11, Port Reset bit
: GPIOC.BRR.BR12 ( -- ) 12 bit GPIOC.BRR ! ; \ GPIOC.BRR.BR12, Port Reset bit
: GPIOC.BRR.BR13 ( -- ) 13 bit GPIOC.BRR ! ; \ GPIOC.BRR.BR13, Port Reset bit
: GPIOC.BRR.BR14 ( -- ) 14 bit GPIOC.BRR ! ; \ GPIOC.BRR.BR14, Port Reset bit
: GPIOC.BRR.BR15 ( -- ) 15 bit GPIOC.BRR ! ; \ GPIOC.BRR.BR15, Port Reset bit

\ GPIOD.MODER (read-write) Reset:$FFFFFFFF
: GPIOD.MODER.MODER15 ( %bb -- x addr ) 30 lshift GPIOD.MODER ; \ GPIOD.MODER.MODER15, Port x configuration bits (y =               0..15)
: GPIOD.MODER.MODER14 ( %bb -- x addr ) 28 lshift GPIOD.MODER ; \ GPIOD.MODER.MODER14, Port x configuration bits (y =               0..15)
: GPIOD.MODER.MODER13 ( %bb -- x addr ) 26 lshift GPIOD.MODER ; \ GPIOD.MODER.MODER13, Port x configuration bits (y =               0..15)
: GPIOD.MODER.MODER12 ( %bb -- x addr ) 24 lshift GPIOD.MODER ; \ GPIOD.MODER.MODER12, Port x configuration bits (y =               0..15)
: GPIOD.MODER.MODER11 ( %bb -- x addr ) 22 lshift GPIOD.MODER ; \ GPIOD.MODER.MODER11, Port x configuration bits (y =               0..15)
: GPIOD.MODER.MODER10 ( %bb -- x addr ) 20 lshift GPIOD.MODER ; \ GPIOD.MODER.MODER10, Port x configuration bits (y =               0..15)
: GPIOD.MODER.MODER9 ( %bb -- x addr ) 18 lshift GPIOD.MODER ; \ GPIOD.MODER.MODER9, Port x configuration bits (y =               0..15)
: GPIOD.MODER.MODER8 ( %bb -- x addr ) 16 lshift GPIOD.MODER ; \ GPIOD.MODER.MODER8, Port x configuration bits (y =               0..15)
: GPIOD.MODER.MODER7 ( %bb -- x addr ) 14 lshift GPIOD.MODER ; \ GPIOD.MODER.MODER7, Port x configuration bits (y =               0..15)
: GPIOD.MODER.MODER6 ( %bb -- x addr ) 12 lshift GPIOD.MODER ; \ GPIOD.MODER.MODER6, Port x configuration bits (y =               0..15)
: GPIOD.MODER.MODER5 ( %bb -- x addr ) 10 lshift GPIOD.MODER ; \ GPIOD.MODER.MODER5, Port x configuration bits (y =               0..15)
: GPIOD.MODER.MODER4 ( %bb -- x addr ) 8 lshift GPIOD.MODER ; \ GPIOD.MODER.MODER4, Port x configuration bits (y =               0..15)
: GPIOD.MODER.MODER3 ( %bb -- x addr ) 6 lshift GPIOD.MODER ; \ GPIOD.MODER.MODER3, Port x configuration bits (y =               0..15)
: GPIOD.MODER.MODER2 ( %bb -- x addr ) 4 lshift GPIOD.MODER ; \ GPIOD.MODER.MODER2, Port x configuration bits (y =               0..15)
: GPIOD.MODER.MODER1 ( %bb -- x addr ) 2 lshift GPIOD.MODER ; \ GPIOD.MODER.MODER1, Port x configuration bits (y =               0..15)
: GPIOD.MODER.MODER0 ( %bb -- x addr ) GPIOD.MODER ; \ GPIOD.MODER.MODER0, Port x configuration bits (y =               0..15)

\ GPIOD.OTYPER (read-write) Reset:$00000000
: GPIOD.OTYPER.OT15 ( -- x addr ) 15 bit GPIOD.OTYPER ; \ GPIOD.OTYPER.OT15, Port x configuration bits (y =               0..15)
: GPIOD.OTYPER.OT14 ( -- x addr ) 14 bit GPIOD.OTYPER ; \ GPIOD.OTYPER.OT14, Port x configuration bits (y =               0..15)
: GPIOD.OTYPER.OT13 ( -- x addr ) 13 bit GPIOD.OTYPER ; \ GPIOD.OTYPER.OT13, Port x configuration bits (y =               0..15)
: GPIOD.OTYPER.OT12 ( -- x addr ) 12 bit GPIOD.OTYPER ; \ GPIOD.OTYPER.OT12, Port x configuration bits (y =               0..15)
: GPIOD.OTYPER.OT11 ( -- x addr ) 11 bit GPIOD.OTYPER ; \ GPIOD.OTYPER.OT11, Port x configuration bits (y =               0..15)
: GPIOD.OTYPER.OT10 ( -- x addr ) 10 bit GPIOD.OTYPER ; \ GPIOD.OTYPER.OT10, Port x configuration bits (y =               0..15)
: GPIOD.OTYPER.OT9 ( -- x addr ) 9 bit GPIOD.OTYPER ; \ GPIOD.OTYPER.OT9, Port x configuration bits (y =               0..15)
: GPIOD.OTYPER.OT8 ( -- x addr ) 8 bit GPIOD.OTYPER ; \ GPIOD.OTYPER.OT8, Port x configuration bits (y =               0..15)
: GPIOD.OTYPER.OT7 ( -- x addr ) 7 bit GPIOD.OTYPER ; \ GPIOD.OTYPER.OT7, Port x configuration bits (y =               0..15)
: GPIOD.OTYPER.OT6 ( -- x addr ) 6 bit GPIOD.OTYPER ; \ GPIOD.OTYPER.OT6, Port x configuration bits (y =               0..15)
: GPIOD.OTYPER.OT5 ( -- x addr ) 5 bit GPIOD.OTYPER ; \ GPIOD.OTYPER.OT5, Port x configuration bits (y =               0..15)
: GPIOD.OTYPER.OT4 ( -- x addr ) 4 bit GPIOD.OTYPER ; \ GPIOD.OTYPER.OT4, Port x configuration bits (y =               0..15)
: GPIOD.OTYPER.OT3 ( -- x addr ) 3 bit GPIOD.OTYPER ; \ GPIOD.OTYPER.OT3, Port x configuration bits (y =               0..15)
: GPIOD.OTYPER.OT2 ( -- x addr ) 2 bit GPIOD.OTYPER ; \ GPIOD.OTYPER.OT2, Port x configuration bits (y =               0..15)
: GPIOD.OTYPER.OT1 ( -- x addr ) 1 bit GPIOD.OTYPER ; \ GPIOD.OTYPER.OT1, Port x configuration bits (y =               0..15)
: GPIOD.OTYPER.OT0 ( -- x addr ) 0 bit GPIOD.OTYPER ; \ GPIOD.OTYPER.OT0, Port x configuration bits (y =               0..15)

\ GPIOD.OSPEEDR (read-write) Reset:$00000000
: GPIOD.OSPEEDR.OSPEEDR15 ( %bb -- x addr ) 30 lshift GPIOD.OSPEEDR ; \ GPIOD.OSPEEDR.OSPEEDR15, Port x configuration bits (y =               0..15)
: GPIOD.OSPEEDR.OSPEEDR14 ( %bb -- x addr ) 28 lshift GPIOD.OSPEEDR ; \ GPIOD.OSPEEDR.OSPEEDR14, Port x configuration bits (y =               0..15)
: GPIOD.OSPEEDR.OSPEEDR13 ( %bb -- x addr ) 26 lshift GPIOD.OSPEEDR ; \ GPIOD.OSPEEDR.OSPEEDR13, Port x configuration bits (y =               0..15)
: GPIOD.OSPEEDR.OSPEEDR12 ( %bb -- x addr ) 24 lshift GPIOD.OSPEEDR ; \ GPIOD.OSPEEDR.OSPEEDR12, Port x configuration bits (y =               0..15)
: GPIOD.OSPEEDR.OSPEEDR11 ( %bb -- x addr ) 22 lshift GPIOD.OSPEEDR ; \ GPIOD.OSPEEDR.OSPEEDR11, Port x configuration bits (y =               0..15)
: GPIOD.OSPEEDR.OSPEEDR10 ( %bb -- x addr ) 20 lshift GPIOD.OSPEEDR ; \ GPIOD.OSPEEDR.OSPEEDR10, Port x configuration bits (y =               0..15)
: GPIOD.OSPEEDR.OSPEEDR9 ( %bb -- x addr ) 18 lshift GPIOD.OSPEEDR ; \ GPIOD.OSPEEDR.OSPEEDR9, Port x configuration bits (y =               0..15)
: GPIOD.OSPEEDR.OSPEEDR8 ( %bb -- x addr ) 16 lshift GPIOD.OSPEEDR ; \ GPIOD.OSPEEDR.OSPEEDR8, Port x configuration bits (y =               0..15)
: GPIOD.OSPEEDR.OSPEEDR7 ( %bb -- x addr ) 14 lshift GPIOD.OSPEEDR ; \ GPIOD.OSPEEDR.OSPEEDR7, Port x configuration bits (y =               0..15)
: GPIOD.OSPEEDR.OSPEEDR6 ( %bb -- x addr ) 12 lshift GPIOD.OSPEEDR ; \ GPIOD.OSPEEDR.OSPEEDR6, Port x configuration bits (y =               0..15)
: GPIOD.OSPEEDR.OSPEEDR5 ( %bb -- x addr ) 10 lshift GPIOD.OSPEEDR ; \ GPIOD.OSPEEDR.OSPEEDR5, Port x configuration bits (y =               0..15)
: GPIOD.OSPEEDR.OSPEEDR4 ( %bb -- x addr ) 8 lshift GPIOD.OSPEEDR ; \ GPIOD.OSPEEDR.OSPEEDR4, Port x configuration bits (y =               0..15)
: GPIOD.OSPEEDR.OSPEEDR3 ( %bb -- x addr ) 6 lshift GPIOD.OSPEEDR ; \ GPIOD.OSPEEDR.OSPEEDR3, Port x configuration bits (y =               0..15)
: GPIOD.OSPEEDR.OSPEEDR2 ( %bb -- x addr ) 4 lshift GPIOD.OSPEEDR ; \ GPIOD.OSPEEDR.OSPEEDR2, Port x configuration bits (y =               0..15)
: GPIOD.OSPEEDR.OSPEEDR1 ( %bb -- x addr ) 2 lshift GPIOD.OSPEEDR ; \ GPIOD.OSPEEDR.OSPEEDR1, Port x configuration bits (y =               0..15)
: GPIOD.OSPEEDR.OSPEEDR0 ( %bb -- x addr ) GPIOD.OSPEEDR ; \ GPIOD.OSPEEDR.OSPEEDR0, Port x configuration bits (y =               0..15)

\ GPIOD.PUPDR (read-write) Reset:$00000000
: GPIOD.PUPDR.PUPDR15 ( %bb -- x addr ) 30 lshift GPIOD.PUPDR ; \ GPIOD.PUPDR.PUPDR15, Port x configuration bits (y =               0..15)
: GPIOD.PUPDR.PUPDR14 ( %bb -- x addr ) 28 lshift GPIOD.PUPDR ; \ GPIOD.PUPDR.PUPDR14, Port x configuration bits (y =               0..15)
: GPIOD.PUPDR.PUPDR13 ( %bb -- x addr ) 26 lshift GPIOD.PUPDR ; \ GPIOD.PUPDR.PUPDR13, Port x configuration bits (y =               0..15)
: GPIOD.PUPDR.PUPDR12 ( %bb -- x addr ) 24 lshift GPIOD.PUPDR ; \ GPIOD.PUPDR.PUPDR12, Port x configuration bits (y =               0..15)
: GPIOD.PUPDR.PUPDR11 ( %bb -- x addr ) 22 lshift GPIOD.PUPDR ; \ GPIOD.PUPDR.PUPDR11, Port x configuration bits (y =               0..15)
: GPIOD.PUPDR.PUPDR10 ( %bb -- x addr ) 20 lshift GPIOD.PUPDR ; \ GPIOD.PUPDR.PUPDR10, Port x configuration bits (y =               0..15)
: GPIOD.PUPDR.PUPDR9 ( %bb -- x addr ) 18 lshift GPIOD.PUPDR ; \ GPIOD.PUPDR.PUPDR9, Port x configuration bits (y =               0..15)
: GPIOD.PUPDR.PUPDR8 ( %bb -- x addr ) 16 lshift GPIOD.PUPDR ; \ GPIOD.PUPDR.PUPDR8, Port x configuration bits (y =               0..15)
: GPIOD.PUPDR.PUPDR7 ( %bb -- x addr ) 14 lshift GPIOD.PUPDR ; \ GPIOD.PUPDR.PUPDR7, Port x configuration bits (y =               0..15)
: GPIOD.PUPDR.PUPDR6 ( %bb -- x addr ) 12 lshift GPIOD.PUPDR ; \ GPIOD.PUPDR.PUPDR6, Port x configuration bits (y =               0..15)
: GPIOD.PUPDR.PUPDR5 ( %bb -- x addr ) 10 lshift GPIOD.PUPDR ; \ GPIOD.PUPDR.PUPDR5, Port x configuration bits (y =               0..15)
: GPIOD.PUPDR.PUPDR4 ( %bb -- x addr ) 8 lshift GPIOD.PUPDR ; \ GPIOD.PUPDR.PUPDR4, Port x configuration bits (y =               0..15)
: GPIOD.PUPDR.PUPDR3 ( %bb -- x addr ) 6 lshift GPIOD.PUPDR ; \ GPIOD.PUPDR.PUPDR3, Port x configuration bits (y =               0..15)
: GPIOD.PUPDR.PUPDR2 ( %bb -- x addr ) 4 lshift GPIOD.PUPDR ; \ GPIOD.PUPDR.PUPDR2, Port x configuration bits (y =               0..15)
: GPIOD.PUPDR.PUPDR1 ( %bb -- x addr ) 2 lshift GPIOD.PUPDR ; \ GPIOD.PUPDR.PUPDR1, Port x configuration bits (y =               0..15)
: GPIOD.PUPDR.PUPDR0 ( %bb -- x addr ) GPIOD.PUPDR ; \ GPIOD.PUPDR.PUPDR0, Port x configuration bits (y =               0..15)

\ GPIOD.IDR (read-only) Reset:$00000000
: GPIOD.IDR.IDR15? ( --  1|0 ) 15 bit GPIOD.IDR bit@ ; \ GPIOD.IDR.IDR15, Port input data (y =               0..15)
: GPIOD.IDR.IDR14? ( --  1|0 ) 14 bit GPIOD.IDR bit@ ; \ GPIOD.IDR.IDR14, Port input data (y =               0..15)
: GPIOD.IDR.IDR13? ( --  1|0 ) 13 bit GPIOD.IDR bit@ ; \ GPIOD.IDR.IDR13, Port input data (y =               0..15)
: GPIOD.IDR.IDR12? ( --  1|0 ) 12 bit GPIOD.IDR bit@ ; \ GPIOD.IDR.IDR12, Port input data (y =               0..15)
: GPIOD.IDR.IDR11? ( --  1|0 ) 11 bit GPIOD.IDR bit@ ; \ GPIOD.IDR.IDR11, Port input data (y =               0..15)
: GPIOD.IDR.IDR10? ( --  1|0 ) 10 bit GPIOD.IDR bit@ ; \ GPIOD.IDR.IDR10, Port input data (y =               0..15)
: GPIOD.IDR.IDR9? ( --  1|0 ) 9 bit GPIOD.IDR bit@ ; \ GPIOD.IDR.IDR9, Port input data (y =               0..15)
: GPIOD.IDR.IDR8? ( --  1|0 ) 8 bit GPIOD.IDR bit@ ; \ GPIOD.IDR.IDR8, Port input data (y =               0..15)
: GPIOD.IDR.IDR7? ( --  1|0 ) 7 bit GPIOD.IDR bit@ ; \ GPIOD.IDR.IDR7, Port input data (y =               0..15)
: GPIOD.IDR.IDR6? ( --  1|0 ) 6 bit GPIOD.IDR bit@ ; \ GPIOD.IDR.IDR6, Port input data (y =               0..15)
: GPIOD.IDR.IDR5? ( --  1|0 ) 5 bit GPIOD.IDR bit@ ; \ GPIOD.IDR.IDR5, Port input data (y =               0..15)
: GPIOD.IDR.IDR4? ( --  1|0 ) 4 bit GPIOD.IDR bit@ ; \ GPIOD.IDR.IDR4, Port input data (y =               0..15)
: GPIOD.IDR.IDR3? ( --  1|0 ) 3 bit GPIOD.IDR bit@ ; \ GPIOD.IDR.IDR3, Port input data (y =               0..15)
: GPIOD.IDR.IDR2? ( --  1|0 ) 2 bit GPIOD.IDR bit@ ; \ GPIOD.IDR.IDR2, Port input data (y =               0..15)
: GPIOD.IDR.IDR1? ( --  1|0 ) 1 bit GPIOD.IDR bit@ ; \ GPIOD.IDR.IDR1, Port input data (y =               0..15)
: GPIOD.IDR.IDR0? ( --  1|0 ) 0 bit GPIOD.IDR bit@ ; \ GPIOD.IDR.IDR0, Port input data (y =               0..15)

\ GPIOD.ODR (read-write) Reset:$00000000
: GPIOD.ODR.ODR15 ( -- x addr ) 15 bit GPIOD.ODR ; \ GPIOD.ODR.ODR15, Port output data (y =               0..15)
: GPIOD.ODR.ODR14 ( -- x addr ) 14 bit GPIOD.ODR ; \ GPIOD.ODR.ODR14, Port output data (y =               0..15)
: GPIOD.ODR.ODR13 ( -- x addr ) 13 bit GPIOD.ODR ; \ GPIOD.ODR.ODR13, Port output data (y =               0..15)
: GPIOD.ODR.ODR12 ( -- x addr ) 12 bit GPIOD.ODR ; \ GPIOD.ODR.ODR12, Port output data (y =               0..15)
: GPIOD.ODR.ODR11 ( -- x addr ) 11 bit GPIOD.ODR ; \ GPIOD.ODR.ODR11, Port output data (y =               0..15)
: GPIOD.ODR.ODR10 ( -- x addr ) 10 bit GPIOD.ODR ; \ GPIOD.ODR.ODR10, Port output data (y =               0..15)
: GPIOD.ODR.ODR9 ( -- x addr ) 9 bit GPIOD.ODR ; \ GPIOD.ODR.ODR9, Port output data (y =               0..15)
: GPIOD.ODR.ODR8 ( -- x addr ) 8 bit GPIOD.ODR ; \ GPIOD.ODR.ODR8, Port output data (y =               0..15)
: GPIOD.ODR.ODR7 ( -- x addr ) 7 bit GPIOD.ODR ; \ GPIOD.ODR.ODR7, Port output data (y =               0..15)
: GPIOD.ODR.ODR6 ( -- x addr ) 6 bit GPIOD.ODR ; \ GPIOD.ODR.ODR6, Port output data (y =               0..15)
: GPIOD.ODR.ODR5 ( -- x addr ) 5 bit GPIOD.ODR ; \ GPIOD.ODR.ODR5, Port output data (y =               0..15)
: GPIOD.ODR.ODR4 ( -- x addr ) 4 bit GPIOD.ODR ; \ GPIOD.ODR.ODR4, Port output data (y =               0..15)
: GPIOD.ODR.ODR3 ( -- x addr ) 3 bit GPIOD.ODR ; \ GPIOD.ODR.ODR3, Port output data (y =               0..15)
: GPIOD.ODR.ODR2 ( -- x addr ) 2 bit GPIOD.ODR ; \ GPIOD.ODR.ODR2, Port output data (y =               0..15)
: GPIOD.ODR.ODR1 ( -- x addr ) 1 bit GPIOD.ODR ; \ GPIOD.ODR.ODR1, Port output data (y =               0..15)
: GPIOD.ODR.ODR0 ( -- x addr ) 0 bit GPIOD.ODR ; \ GPIOD.ODR.ODR0, Port output data (y =               0..15)

\ GPIOD.BSRR (write-only) Reset:$00000000
: GPIOD.BSRR.BR15 ( -- ) 31 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BR15, Port x reset bit y (y =               0..15)
: GPIOD.BSRR.BR14 ( -- ) 30 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BR14, Port x reset bit y (y =               0..15)
: GPIOD.BSRR.BR13 ( -- ) 29 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BR13, Port x reset bit y (y =               0..15)
: GPIOD.BSRR.BR12 ( -- ) 28 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BR12, Port x reset bit y (y =               0..15)
: GPIOD.BSRR.BR11 ( -- ) 27 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BR11, Port x reset bit y (y =               0..15)
: GPIOD.BSRR.BR10 ( -- ) 26 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BR10, Port x reset bit y (y =               0..15)
: GPIOD.BSRR.BR9 ( -- ) 25 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BR9, Port x reset bit y (y =               0..15)
: GPIOD.BSRR.BR8 ( -- ) 24 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BR8, Port x reset bit y (y =               0..15)
: GPIOD.BSRR.BR7 ( -- ) 23 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BR7, Port x reset bit y (y =               0..15)
: GPIOD.BSRR.BR6 ( -- ) 22 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BR6, Port x reset bit y (y =               0..15)
: GPIOD.BSRR.BR5 ( -- ) 21 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BR5, Port x reset bit y (y =               0..15)
: GPIOD.BSRR.BR4 ( -- ) 20 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BR4, Port x reset bit y (y =               0..15)
: GPIOD.BSRR.BR3 ( -- ) 19 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BR3, Port x reset bit y (y =               0..15)
: GPIOD.BSRR.BR2 ( -- ) 18 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BR2, Port x reset bit y (y =               0..15)
: GPIOD.BSRR.BR1 ( -- ) 17 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BR1, Port x reset bit y (y =               0..15)
: GPIOD.BSRR.BR0 ( -- ) 16 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BR0, Port x set bit y (y=               0..15)
: GPIOD.BSRR.BS15 ( -- ) 15 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BS15, Port x set bit y (y=               0..15)
: GPIOD.BSRR.BS14 ( -- ) 14 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BS14, Port x set bit y (y=               0..15)
: GPIOD.BSRR.BS13 ( -- ) 13 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BS13, Port x set bit y (y=               0..15)
: GPIOD.BSRR.BS12 ( -- ) 12 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BS12, Port x set bit y (y=               0..15)
: GPIOD.BSRR.BS11 ( -- ) 11 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BS11, Port x set bit y (y=               0..15)
: GPIOD.BSRR.BS10 ( -- ) 10 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BS10, Port x set bit y (y=               0..15)
: GPIOD.BSRR.BS9 ( -- ) 9 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BS9, Port x set bit y (y=               0..15)
: GPIOD.BSRR.BS8 ( -- ) 8 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BS8, Port x set bit y (y=               0..15)
: GPIOD.BSRR.BS7 ( -- ) 7 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BS7, Port x set bit y (y=               0..15)
: GPIOD.BSRR.BS6 ( -- ) 6 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BS6, Port x set bit y (y=               0..15)
: GPIOD.BSRR.BS5 ( -- ) 5 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BS5, Port x set bit y (y=               0..15)
: GPIOD.BSRR.BS4 ( -- ) 4 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BS4, Port x set bit y (y=               0..15)
: GPIOD.BSRR.BS3 ( -- ) 3 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BS3, Port x set bit y (y=               0..15)
: GPIOD.BSRR.BS2 ( -- ) 2 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BS2, Port x set bit y (y=               0..15)
: GPIOD.BSRR.BS1 ( -- ) 1 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BS1, Port x set bit y (y=               0..15)
: GPIOD.BSRR.BS0 ( -- ) 0 bit GPIOD.BSRR ! ; \ GPIOD.BSRR.BS0, Port x set bit y (y=               0..15)

\ GPIOD.LCKR (read-write) Reset:$00000000
: GPIOD.LCKR.LCKK ( -- x addr ) 16 bit GPIOD.LCKR ; \ GPIOD.LCKR.LCKK, Port x lock bit y (y=               0..15)
: GPIOD.LCKR.LCK15 ( -- x addr ) 15 bit GPIOD.LCKR ; \ GPIOD.LCKR.LCK15, Port x lock bit y (y=               0..15)
: GPIOD.LCKR.LCK14 ( -- x addr ) 14 bit GPIOD.LCKR ; \ GPIOD.LCKR.LCK14, Port x lock bit y (y=               0..15)
: GPIOD.LCKR.LCK13 ( -- x addr ) 13 bit GPIOD.LCKR ; \ GPIOD.LCKR.LCK13, Port x lock bit y (y=               0..15)
: GPIOD.LCKR.LCK12 ( -- x addr ) 12 bit GPIOD.LCKR ; \ GPIOD.LCKR.LCK12, Port x lock bit y (y=               0..15)
: GPIOD.LCKR.LCK11 ( -- x addr ) 11 bit GPIOD.LCKR ; \ GPIOD.LCKR.LCK11, Port x lock bit y (y=               0..15)
: GPIOD.LCKR.LCK10 ( -- x addr ) 10 bit GPIOD.LCKR ; \ GPIOD.LCKR.LCK10, Port x lock bit y (y=               0..15)
: GPIOD.LCKR.LCK9 ( -- x addr ) 9 bit GPIOD.LCKR ; \ GPIOD.LCKR.LCK9, Port x lock bit y (y=               0..15)
: GPIOD.LCKR.LCK8 ( -- x addr ) 8 bit GPIOD.LCKR ; \ GPIOD.LCKR.LCK8, Port x lock bit y (y=               0..15)
: GPIOD.LCKR.LCK7 ( -- x addr ) 7 bit GPIOD.LCKR ; \ GPIOD.LCKR.LCK7, Port x lock bit y (y=               0..15)
: GPIOD.LCKR.LCK6 ( -- x addr ) 6 bit GPIOD.LCKR ; \ GPIOD.LCKR.LCK6, Port x lock bit y (y=               0..15)
: GPIOD.LCKR.LCK5 ( -- x addr ) 5 bit GPIOD.LCKR ; \ GPIOD.LCKR.LCK5, Port x lock bit y (y=               0..15)
: GPIOD.LCKR.LCK4 ( -- x addr ) 4 bit GPIOD.LCKR ; \ GPIOD.LCKR.LCK4, Port x lock bit y (y=               0..15)
: GPIOD.LCKR.LCK3 ( -- x addr ) 3 bit GPIOD.LCKR ; \ GPIOD.LCKR.LCK3, Port x lock bit y (y=               0..15)
: GPIOD.LCKR.LCK2 ( -- x addr ) 2 bit GPIOD.LCKR ; \ GPIOD.LCKR.LCK2, Port x lock bit y (y=               0..15)
: GPIOD.LCKR.LCK1 ( -- x addr ) 1 bit GPIOD.LCKR ; \ GPIOD.LCKR.LCK1, Port x lock bit y (y=               0..15)
: GPIOD.LCKR.LCK0 ( -- x addr ) 0 bit GPIOD.LCKR ; \ GPIOD.LCKR.LCK0, Port x lock bit y (y=               0..15)

\ GPIOD.AFRL (read-write) Reset:$00000000
: GPIOD.AFRL.AFSEL7 ( %bbbb -- x addr ) 28 lshift GPIOD.AFRL ; \ GPIOD.AFRL.AFSEL7, Alternate function selection for port x               bit y (y = 0..7)
: GPIOD.AFRL.AFSEL6 ( %bbbb -- x addr ) 24 lshift GPIOD.AFRL ; \ GPIOD.AFRL.AFSEL6, Alternate function selection for port x               bit y (y = 0..7)
: GPIOD.AFRL.AFSEL5 ( %bbbb -- x addr ) 20 lshift GPIOD.AFRL ; \ GPIOD.AFRL.AFSEL5, Alternate function selection for port x               bit y (y = 0..7)
: GPIOD.AFRL.AFSEL4 ( %bbbb -- x addr ) 16 lshift GPIOD.AFRL ; \ GPIOD.AFRL.AFSEL4, Alternate function selection for port x               bit y (y = 0..7)
: GPIOD.AFRL.AFSEL3 ( %bbbb -- x addr ) 12 lshift GPIOD.AFRL ; \ GPIOD.AFRL.AFSEL3, Alternate function selection for port x               bit y (y = 0..7)
: GPIOD.AFRL.AFSEL2 ( %bbbb -- x addr ) 8 lshift GPIOD.AFRL ; \ GPIOD.AFRL.AFSEL2, Alternate function selection for port x               bit y (y = 0..7)
: GPIOD.AFRL.AFSEL1 ( %bbbb -- x addr ) 4 lshift GPIOD.AFRL ; \ GPIOD.AFRL.AFSEL1, Alternate function selection for port x               bit y (y = 0..7)
: GPIOD.AFRL.AFSEL0 ( %bbbb -- x addr ) GPIOD.AFRL ; \ GPIOD.AFRL.AFSEL0, Alternate function selection for port x               bit y (y = 0..7)

\ GPIOD.AFRH (read-write) Reset:$00000000
: GPIOD.AFRH.AFSEL15 ( %bbbb -- x addr ) 28 lshift GPIOD.AFRH ; \ GPIOD.AFRH.AFSEL15, Alternate function selection for port x               bit y (y = 8..15)
: GPIOD.AFRH.AFSEL14 ( %bbbb -- x addr ) 24 lshift GPIOD.AFRH ; \ GPIOD.AFRH.AFSEL14, Alternate function selection for port x               bit y (y = 8..15)
: GPIOD.AFRH.AFSEL13 ( %bbbb -- x addr ) 20 lshift GPIOD.AFRH ; \ GPIOD.AFRH.AFSEL13, Alternate function selection for port x               bit y (y = 8..15)
: GPIOD.AFRH.AFSEL12 ( %bbbb -- x addr ) 16 lshift GPIOD.AFRH ; \ GPIOD.AFRH.AFSEL12, Alternate function selection for port x               bit y (y = 8..15)
: GPIOD.AFRH.AFSEL11 ( %bbbb -- x addr ) 12 lshift GPIOD.AFRH ; \ GPIOD.AFRH.AFSEL11, Alternate function selection for port x               bit y (y = 8..15)
: GPIOD.AFRH.AFSEL10 ( %bbbb -- x addr ) 8 lshift GPIOD.AFRH ; \ GPIOD.AFRH.AFSEL10, Alternate function selection for port x               bit y (y = 8..15)
: GPIOD.AFRH.AFSEL9 ( %bbbb -- x addr ) 4 lshift GPIOD.AFRH ; \ GPIOD.AFRH.AFSEL9, Alternate function selection for port x               bit y (y = 8..15)
: GPIOD.AFRH.AFSEL8 ( %bbbb -- x addr ) GPIOD.AFRH ; \ GPIOD.AFRH.AFSEL8, Alternate function selection for port x               bit y (y = 8..15)

\ GPIOD.BRR (write-only) Reset:$00000000
: GPIOD.BRR.BR0 ( -- ) 0 bit GPIOD.BRR ! ; \ GPIOD.BRR.BR0, Port Reset bit
: GPIOD.BRR.BR1 ( -- ) 1 bit GPIOD.BRR ! ; \ GPIOD.BRR.BR1, Port Reset bit
: GPIOD.BRR.BR2 ( -- ) 2 bit GPIOD.BRR ! ; \ GPIOD.BRR.BR2, Port Reset bit
: GPIOD.BRR.BR3 ( -- ) 3 bit GPIOD.BRR ! ; \ GPIOD.BRR.BR3, Port Reset bit
: GPIOD.BRR.BR4 ( -- ) 4 bit GPIOD.BRR ! ; \ GPIOD.BRR.BR4, Port Reset bit
: GPIOD.BRR.BR5 ( -- ) 5 bit GPIOD.BRR ! ; \ GPIOD.BRR.BR5, Port Reset bit
: GPIOD.BRR.BR6 ( -- ) 6 bit GPIOD.BRR ! ; \ GPIOD.BRR.BR6, Port Reset bit
: GPIOD.BRR.BR7 ( -- ) 7 bit GPIOD.BRR ! ; \ GPIOD.BRR.BR7, Port Reset bit
: GPIOD.BRR.BR8 ( -- ) 8 bit GPIOD.BRR ! ; \ GPIOD.BRR.BR8, Port Reset bit
: GPIOD.BRR.BR9 ( -- ) 9 bit GPIOD.BRR ! ; \ GPIOD.BRR.BR9, Port Reset bit
: GPIOD.BRR.BR10 ( -- ) 10 bit GPIOD.BRR ! ; \ GPIOD.BRR.BR10, Port Reset bit
: GPIOD.BRR.BR11 ( -- ) 11 bit GPIOD.BRR ! ; \ GPIOD.BRR.BR11, Port Reset bit
: GPIOD.BRR.BR12 ( -- ) 12 bit GPIOD.BRR ! ; \ GPIOD.BRR.BR12, Port Reset bit
: GPIOD.BRR.BR13 ( -- ) 13 bit GPIOD.BRR ! ; \ GPIOD.BRR.BR13, Port Reset bit
: GPIOD.BRR.BR14 ( -- ) 14 bit GPIOD.BRR ! ; \ GPIOD.BRR.BR14, Port Reset bit
: GPIOD.BRR.BR15 ( -- ) 15 bit GPIOD.BRR ! ; \ GPIOD.BRR.BR15, Port Reset bit

\ GPIOF.MODER (read-write) Reset:$FFFFFFFF
: GPIOF.MODER.MODER15 ( %bb -- x addr ) 30 lshift GPIOF.MODER ; \ GPIOF.MODER.MODER15, Port x configuration bits (y =               0..15)
: GPIOF.MODER.MODER14 ( %bb -- x addr ) 28 lshift GPIOF.MODER ; \ GPIOF.MODER.MODER14, Port x configuration bits (y =               0..15)
: GPIOF.MODER.MODER13 ( %bb -- x addr ) 26 lshift GPIOF.MODER ; \ GPIOF.MODER.MODER13, Port x configuration bits (y =               0..15)
: GPIOF.MODER.MODER12 ( %bb -- x addr ) 24 lshift GPIOF.MODER ; \ GPIOF.MODER.MODER12, Port x configuration bits (y =               0..15)
: GPIOF.MODER.MODER11 ( %bb -- x addr ) 22 lshift GPIOF.MODER ; \ GPIOF.MODER.MODER11, Port x configuration bits (y =               0..15)
: GPIOF.MODER.MODER10 ( %bb -- x addr ) 20 lshift GPIOF.MODER ; \ GPIOF.MODER.MODER10, Port x configuration bits (y =               0..15)
: GPIOF.MODER.MODER9 ( %bb -- x addr ) 18 lshift GPIOF.MODER ; \ GPIOF.MODER.MODER9, Port x configuration bits (y =               0..15)
: GPIOF.MODER.MODER8 ( %bb -- x addr ) 16 lshift GPIOF.MODER ; \ GPIOF.MODER.MODER8, Port x configuration bits (y =               0..15)
: GPIOF.MODER.MODER7 ( %bb -- x addr ) 14 lshift GPIOF.MODER ; \ GPIOF.MODER.MODER7, Port x configuration bits (y =               0..15)
: GPIOF.MODER.MODER6 ( %bb -- x addr ) 12 lshift GPIOF.MODER ; \ GPIOF.MODER.MODER6, Port x configuration bits (y =               0..15)
: GPIOF.MODER.MODER5 ( %bb -- x addr ) 10 lshift GPIOF.MODER ; \ GPIOF.MODER.MODER5, Port x configuration bits (y =               0..15)
: GPIOF.MODER.MODER4 ( %bb -- x addr ) 8 lshift GPIOF.MODER ; \ GPIOF.MODER.MODER4, Port x configuration bits (y =               0..15)
: GPIOF.MODER.MODER3 ( %bb -- x addr ) 6 lshift GPIOF.MODER ; \ GPIOF.MODER.MODER3, Port x configuration bits (y =               0..15)
: GPIOF.MODER.MODER2 ( %bb -- x addr ) 4 lshift GPIOF.MODER ; \ GPIOF.MODER.MODER2, Port x configuration bits (y =               0..15)
: GPIOF.MODER.MODER1 ( %bb -- x addr ) 2 lshift GPIOF.MODER ; \ GPIOF.MODER.MODER1, Port x configuration bits (y =               0..15)
: GPIOF.MODER.MODER0 ( %bb -- x addr ) GPIOF.MODER ; \ GPIOF.MODER.MODER0, Port x configuration bits (y =               0..15)

\ GPIOF.OTYPER (read-write) Reset:$00000000
: GPIOF.OTYPER.OT15 ( -- x addr ) 15 bit GPIOF.OTYPER ; \ GPIOF.OTYPER.OT15, Port x configuration bits (y =               0..15)
: GPIOF.OTYPER.OT14 ( -- x addr ) 14 bit GPIOF.OTYPER ; \ GPIOF.OTYPER.OT14, Port x configuration bits (y =               0..15)
: GPIOF.OTYPER.OT13 ( -- x addr ) 13 bit GPIOF.OTYPER ; \ GPIOF.OTYPER.OT13, Port x configuration bits (y =               0..15)
: GPIOF.OTYPER.OT12 ( -- x addr ) 12 bit GPIOF.OTYPER ; \ GPIOF.OTYPER.OT12, Port x configuration bits (y =               0..15)
: GPIOF.OTYPER.OT11 ( -- x addr ) 11 bit GPIOF.OTYPER ; \ GPIOF.OTYPER.OT11, Port x configuration bits (y =               0..15)
: GPIOF.OTYPER.OT10 ( -- x addr ) 10 bit GPIOF.OTYPER ; \ GPIOF.OTYPER.OT10, Port x configuration bits (y =               0..15)
: GPIOF.OTYPER.OT9 ( -- x addr ) 9 bit GPIOF.OTYPER ; \ GPIOF.OTYPER.OT9, Port x configuration bits (y =               0..15)
: GPIOF.OTYPER.OT8 ( -- x addr ) 8 bit GPIOF.OTYPER ; \ GPIOF.OTYPER.OT8, Port x configuration bits (y =               0..15)
: GPIOF.OTYPER.OT7 ( -- x addr ) 7 bit GPIOF.OTYPER ; \ GPIOF.OTYPER.OT7, Port x configuration bits (y =               0..15)
: GPIOF.OTYPER.OT6 ( -- x addr ) 6 bit GPIOF.OTYPER ; \ GPIOF.OTYPER.OT6, Port x configuration bits (y =               0..15)
: GPIOF.OTYPER.OT5 ( -- x addr ) 5 bit GPIOF.OTYPER ; \ GPIOF.OTYPER.OT5, Port x configuration bits (y =               0..15)
: GPIOF.OTYPER.OT4 ( -- x addr ) 4 bit GPIOF.OTYPER ; \ GPIOF.OTYPER.OT4, Port x configuration bits (y =               0..15)
: GPIOF.OTYPER.OT3 ( -- x addr ) 3 bit GPIOF.OTYPER ; \ GPIOF.OTYPER.OT3, Port x configuration bits (y =               0..15)
: GPIOF.OTYPER.OT2 ( -- x addr ) 2 bit GPIOF.OTYPER ; \ GPIOF.OTYPER.OT2, Port x configuration bits (y =               0..15)
: GPIOF.OTYPER.OT1 ( -- x addr ) 1 bit GPIOF.OTYPER ; \ GPIOF.OTYPER.OT1, Port x configuration bits (y =               0..15)
: GPIOF.OTYPER.OT0 ( -- x addr ) 0 bit GPIOF.OTYPER ; \ GPIOF.OTYPER.OT0, Port x configuration bits (y =               0..15)

\ GPIOF.OSPEEDR (read-write) Reset:$00000000
: GPIOF.OSPEEDR.OSPEEDR15 ( %bb -- x addr ) 30 lshift GPIOF.OSPEEDR ; \ GPIOF.OSPEEDR.OSPEEDR15, Port x configuration bits (y =               0..15)
: GPIOF.OSPEEDR.OSPEEDR14 ( %bb -- x addr ) 28 lshift GPIOF.OSPEEDR ; \ GPIOF.OSPEEDR.OSPEEDR14, Port x configuration bits (y =               0..15)
: GPIOF.OSPEEDR.OSPEEDR13 ( %bb -- x addr ) 26 lshift GPIOF.OSPEEDR ; \ GPIOF.OSPEEDR.OSPEEDR13, Port x configuration bits (y =               0..15)
: GPIOF.OSPEEDR.OSPEEDR12 ( %bb -- x addr ) 24 lshift GPIOF.OSPEEDR ; \ GPIOF.OSPEEDR.OSPEEDR12, Port x configuration bits (y =               0..15)
: GPIOF.OSPEEDR.OSPEEDR11 ( %bb -- x addr ) 22 lshift GPIOF.OSPEEDR ; \ GPIOF.OSPEEDR.OSPEEDR11, Port x configuration bits (y =               0..15)
: GPIOF.OSPEEDR.OSPEEDR10 ( %bb -- x addr ) 20 lshift GPIOF.OSPEEDR ; \ GPIOF.OSPEEDR.OSPEEDR10, Port x configuration bits (y =               0..15)
: GPIOF.OSPEEDR.OSPEEDR9 ( %bb -- x addr ) 18 lshift GPIOF.OSPEEDR ; \ GPIOF.OSPEEDR.OSPEEDR9, Port x configuration bits (y =               0..15)
: GPIOF.OSPEEDR.OSPEEDR8 ( %bb -- x addr ) 16 lshift GPIOF.OSPEEDR ; \ GPIOF.OSPEEDR.OSPEEDR8, Port x configuration bits (y =               0..15)
: GPIOF.OSPEEDR.OSPEEDR7 ( %bb -- x addr ) 14 lshift GPIOF.OSPEEDR ; \ GPIOF.OSPEEDR.OSPEEDR7, Port x configuration bits (y =               0..15)
: GPIOF.OSPEEDR.OSPEEDR6 ( %bb -- x addr ) 12 lshift GPIOF.OSPEEDR ; \ GPIOF.OSPEEDR.OSPEEDR6, Port x configuration bits (y =               0..15)
: GPIOF.OSPEEDR.OSPEEDR5 ( %bb -- x addr ) 10 lshift GPIOF.OSPEEDR ; \ GPIOF.OSPEEDR.OSPEEDR5, Port x configuration bits (y =               0..15)
: GPIOF.OSPEEDR.OSPEEDR4 ( %bb -- x addr ) 8 lshift GPIOF.OSPEEDR ; \ GPIOF.OSPEEDR.OSPEEDR4, Port x configuration bits (y =               0..15)
: GPIOF.OSPEEDR.OSPEEDR3 ( %bb -- x addr ) 6 lshift GPIOF.OSPEEDR ; \ GPIOF.OSPEEDR.OSPEEDR3, Port x configuration bits (y =               0..15)
: GPIOF.OSPEEDR.OSPEEDR2 ( %bb -- x addr ) 4 lshift GPIOF.OSPEEDR ; \ GPIOF.OSPEEDR.OSPEEDR2, Port x configuration bits (y =               0..15)
: GPIOF.OSPEEDR.OSPEEDR1 ( %bb -- x addr ) 2 lshift GPIOF.OSPEEDR ; \ GPIOF.OSPEEDR.OSPEEDR1, Port x configuration bits (y =               0..15)
: GPIOF.OSPEEDR.OSPEEDR0 ( %bb -- x addr ) GPIOF.OSPEEDR ; \ GPIOF.OSPEEDR.OSPEEDR0, Port x configuration bits (y =               0..15)

\ GPIOF.PUPDR (read-write) Reset:$00000000
: GPIOF.PUPDR.PUPDR15 ( %bb -- x addr ) 30 lshift GPIOF.PUPDR ; \ GPIOF.PUPDR.PUPDR15, Port x configuration bits (y =               0..15)
: GPIOF.PUPDR.PUPDR14 ( %bb -- x addr ) 28 lshift GPIOF.PUPDR ; \ GPIOF.PUPDR.PUPDR14, Port x configuration bits (y =               0..15)
: GPIOF.PUPDR.PUPDR13 ( %bb -- x addr ) 26 lshift GPIOF.PUPDR ; \ GPIOF.PUPDR.PUPDR13, Port x configuration bits (y =               0..15)
: GPIOF.PUPDR.PUPDR12 ( %bb -- x addr ) 24 lshift GPIOF.PUPDR ; \ GPIOF.PUPDR.PUPDR12, Port x configuration bits (y =               0..15)
: GPIOF.PUPDR.PUPDR11 ( %bb -- x addr ) 22 lshift GPIOF.PUPDR ; \ GPIOF.PUPDR.PUPDR11, Port x configuration bits (y =               0..15)
: GPIOF.PUPDR.PUPDR10 ( %bb -- x addr ) 20 lshift GPIOF.PUPDR ; \ GPIOF.PUPDR.PUPDR10, Port x configuration bits (y =               0..15)
: GPIOF.PUPDR.PUPDR9 ( %bb -- x addr ) 18 lshift GPIOF.PUPDR ; \ GPIOF.PUPDR.PUPDR9, Port x configuration bits (y =               0..15)
: GPIOF.PUPDR.PUPDR8 ( %bb -- x addr ) 16 lshift GPIOF.PUPDR ; \ GPIOF.PUPDR.PUPDR8, Port x configuration bits (y =               0..15)
: GPIOF.PUPDR.PUPDR7 ( %bb -- x addr ) 14 lshift GPIOF.PUPDR ; \ GPIOF.PUPDR.PUPDR7, Port x configuration bits (y =               0..15)
: GPIOF.PUPDR.PUPDR6 ( %bb -- x addr ) 12 lshift GPIOF.PUPDR ; \ GPIOF.PUPDR.PUPDR6, Port x configuration bits (y =               0..15)
: GPIOF.PUPDR.PUPDR5 ( %bb -- x addr ) 10 lshift GPIOF.PUPDR ; \ GPIOF.PUPDR.PUPDR5, Port x configuration bits (y =               0..15)
: GPIOF.PUPDR.PUPDR4 ( %bb -- x addr ) 8 lshift GPIOF.PUPDR ; \ GPIOF.PUPDR.PUPDR4, Port x configuration bits (y =               0..15)
: GPIOF.PUPDR.PUPDR3 ( %bb -- x addr ) 6 lshift GPIOF.PUPDR ; \ GPIOF.PUPDR.PUPDR3, Port x configuration bits (y =               0..15)
: GPIOF.PUPDR.PUPDR2 ( %bb -- x addr ) 4 lshift GPIOF.PUPDR ; \ GPIOF.PUPDR.PUPDR2, Port x configuration bits (y =               0..15)
: GPIOF.PUPDR.PUPDR1 ( %bb -- x addr ) 2 lshift GPIOF.PUPDR ; \ GPIOF.PUPDR.PUPDR1, Port x configuration bits (y =               0..15)
: GPIOF.PUPDR.PUPDR0 ( %bb -- x addr ) GPIOF.PUPDR ; \ GPIOF.PUPDR.PUPDR0, Port x configuration bits (y =               0..15)

\ GPIOF.IDR (read-only) Reset:$00000000
: GPIOF.IDR.IDR15? ( --  1|0 ) 15 bit GPIOF.IDR bit@ ; \ GPIOF.IDR.IDR15, Port input data (y =               0..15)
: GPIOF.IDR.IDR14? ( --  1|0 ) 14 bit GPIOF.IDR bit@ ; \ GPIOF.IDR.IDR14, Port input data (y =               0..15)
: GPIOF.IDR.IDR13? ( --  1|0 ) 13 bit GPIOF.IDR bit@ ; \ GPIOF.IDR.IDR13, Port input data (y =               0..15)
: GPIOF.IDR.IDR12? ( --  1|0 ) 12 bit GPIOF.IDR bit@ ; \ GPIOF.IDR.IDR12, Port input data (y =               0..15)
: GPIOF.IDR.IDR11? ( --  1|0 ) 11 bit GPIOF.IDR bit@ ; \ GPIOF.IDR.IDR11, Port input data (y =               0..15)
: GPIOF.IDR.IDR10? ( --  1|0 ) 10 bit GPIOF.IDR bit@ ; \ GPIOF.IDR.IDR10, Port input data (y =               0..15)
: GPIOF.IDR.IDR9? ( --  1|0 ) 9 bit GPIOF.IDR bit@ ; \ GPIOF.IDR.IDR9, Port input data (y =               0..15)
: GPIOF.IDR.IDR8? ( --  1|0 ) 8 bit GPIOF.IDR bit@ ; \ GPIOF.IDR.IDR8, Port input data (y =               0..15)
: GPIOF.IDR.IDR7? ( --  1|0 ) 7 bit GPIOF.IDR bit@ ; \ GPIOF.IDR.IDR7, Port input data (y =               0..15)
: GPIOF.IDR.IDR6? ( --  1|0 ) 6 bit GPIOF.IDR bit@ ; \ GPIOF.IDR.IDR6, Port input data (y =               0..15)
: GPIOF.IDR.IDR5? ( --  1|0 ) 5 bit GPIOF.IDR bit@ ; \ GPIOF.IDR.IDR5, Port input data (y =               0..15)
: GPIOF.IDR.IDR4? ( --  1|0 ) 4 bit GPIOF.IDR bit@ ; \ GPIOF.IDR.IDR4, Port input data (y =               0..15)
: GPIOF.IDR.IDR3? ( --  1|0 ) 3 bit GPIOF.IDR bit@ ; \ GPIOF.IDR.IDR3, Port input data (y =               0..15)
: GPIOF.IDR.IDR2? ( --  1|0 ) 2 bit GPIOF.IDR bit@ ; \ GPIOF.IDR.IDR2, Port input data (y =               0..15)
: GPIOF.IDR.IDR1? ( --  1|0 ) 1 bit GPIOF.IDR bit@ ; \ GPIOF.IDR.IDR1, Port input data (y =               0..15)
: GPIOF.IDR.IDR0? ( --  1|0 ) 0 bit GPIOF.IDR bit@ ; \ GPIOF.IDR.IDR0, Port input data (y =               0..15)

\ GPIOF.ODR (read-write) Reset:$00000000
: GPIOF.ODR.ODR15 ( -- x addr ) 15 bit GPIOF.ODR ; \ GPIOF.ODR.ODR15, Port output data (y =               0..15)
: GPIOF.ODR.ODR14 ( -- x addr ) 14 bit GPIOF.ODR ; \ GPIOF.ODR.ODR14, Port output data (y =               0..15)
: GPIOF.ODR.ODR13 ( -- x addr ) 13 bit GPIOF.ODR ; \ GPIOF.ODR.ODR13, Port output data (y =               0..15)
: GPIOF.ODR.ODR12 ( -- x addr ) 12 bit GPIOF.ODR ; \ GPIOF.ODR.ODR12, Port output data (y =               0..15)
: GPIOF.ODR.ODR11 ( -- x addr ) 11 bit GPIOF.ODR ; \ GPIOF.ODR.ODR11, Port output data (y =               0..15)
: GPIOF.ODR.ODR10 ( -- x addr ) 10 bit GPIOF.ODR ; \ GPIOF.ODR.ODR10, Port output data (y =               0..15)
: GPIOF.ODR.ODR9 ( -- x addr ) 9 bit GPIOF.ODR ; \ GPIOF.ODR.ODR9, Port output data (y =               0..15)
: GPIOF.ODR.ODR8 ( -- x addr ) 8 bit GPIOF.ODR ; \ GPIOF.ODR.ODR8, Port output data (y =               0..15)
: GPIOF.ODR.ODR7 ( -- x addr ) 7 bit GPIOF.ODR ; \ GPIOF.ODR.ODR7, Port output data (y =               0..15)
: GPIOF.ODR.ODR6 ( -- x addr ) 6 bit GPIOF.ODR ; \ GPIOF.ODR.ODR6, Port output data (y =               0..15)
: GPIOF.ODR.ODR5 ( -- x addr ) 5 bit GPIOF.ODR ; \ GPIOF.ODR.ODR5, Port output data (y =               0..15)
: GPIOF.ODR.ODR4 ( -- x addr ) 4 bit GPIOF.ODR ; \ GPIOF.ODR.ODR4, Port output data (y =               0..15)
: GPIOF.ODR.ODR3 ( -- x addr ) 3 bit GPIOF.ODR ; \ GPIOF.ODR.ODR3, Port output data (y =               0..15)
: GPIOF.ODR.ODR2 ( -- x addr ) 2 bit GPIOF.ODR ; \ GPIOF.ODR.ODR2, Port output data (y =               0..15)
: GPIOF.ODR.ODR1 ( -- x addr ) 1 bit GPIOF.ODR ; \ GPIOF.ODR.ODR1, Port output data (y =               0..15)
: GPIOF.ODR.ODR0 ( -- x addr ) 0 bit GPIOF.ODR ; \ GPIOF.ODR.ODR0, Port output data (y =               0..15)

\ GPIOF.BSRR (write-only) Reset:$00000000
: GPIOF.BSRR.BR15 ( -- ) 31 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BR15, Port x reset bit y (y =               0..15)
: GPIOF.BSRR.BR14 ( -- ) 30 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BR14, Port x reset bit y (y =               0..15)
: GPIOF.BSRR.BR13 ( -- ) 29 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BR13, Port x reset bit y (y =               0..15)
: GPIOF.BSRR.BR12 ( -- ) 28 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BR12, Port x reset bit y (y =               0..15)
: GPIOF.BSRR.BR11 ( -- ) 27 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BR11, Port x reset bit y (y =               0..15)
: GPIOF.BSRR.BR10 ( -- ) 26 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BR10, Port x reset bit y (y =               0..15)
: GPIOF.BSRR.BR9 ( -- ) 25 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BR9, Port x reset bit y (y =               0..15)
: GPIOF.BSRR.BR8 ( -- ) 24 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BR8, Port x reset bit y (y =               0..15)
: GPIOF.BSRR.BR7 ( -- ) 23 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BR7, Port x reset bit y (y =               0..15)
: GPIOF.BSRR.BR6 ( -- ) 22 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BR6, Port x reset bit y (y =               0..15)
: GPIOF.BSRR.BR5 ( -- ) 21 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BR5, Port x reset bit y (y =               0..15)
: GPIOF.BSRR.BR4 ( -- ) 20 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BR4, Port x reset bit y (y =               0..15)
: GPIOF.BSRR.BR3 ( -- ) 19 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BR3, Port x reset bit y (y =               0..15)
: GPIOF.BSRR.BR2 ( -- ) 18 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BR2, Port x reset bit y (y =               0..15)
: GPIOF.BSRR.BR1 ( -- ) 17 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BR1, Port x reset bit y (y =               0..15)
: GPIOF.BSRR.BR0 ( -- ) 16 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BR0, Port x set bit y (y=               0..15)
: GPIOF.BSRR.BS15 ( -- ) 15 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BS15, Port x set bit y (y=               0..15)
: GPIOF.BSRR.BS14 ( -- ) 14 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BS14, Port x set bit y (y=               0..15)
: GPIOF.BSRR.BS13 ( -- ) 13 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BS13, Port x set bit y (y=               0..15)
: GPIOF.BSRR.BS12 ( -- ) 12 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BS12, Port x set bit y (y=               0..15)
: GPIOF.BSRR.BS11 ( -- ) 11 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BS11, Port x set bit y (y=               0..15)
: GPIOF.BSRR.BS10 ( -- ) 10 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BS10, Port x set bit y (y=               0..15)
: GPIOF.BSRR.BS9 ( -- ) 9 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BS9, Port x set bit y (y=               0..15)
: GPIOF.BSRR.BS8 ( -- ) 8 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BS8, Port x set bit y (y=               0..15)
: GPIOF.BSRR.BS7 ( -- ) 7 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BS7, Port x set bit y (y=               0..15)
: GPIOF.BSRR.BS6 ( -- ) 6 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BS6, Port x set bit y (y=               0..15)
: GPIOF.BSRR.BS5 ( -- ) 5 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BS5, Port x set bit y (y=               0..15)
: GPIOF.BSRR.BS4 ( -- ) 4 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BS4, Port x set bit y (y=               0..15)
: GPIOF.BSRR.BS3 ( -- ) 3 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BS3, Port x set bit y (y=               0..15)
: GPIOF.BSRR.BS2 ( -- ) 2 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BS2, Port x set bit y (y=               0..15)
: GPIOF.BSRR.BS1 ( -- ) 1 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BS1, Port x set bit y (y=               0..15)
: GPIOF.BSRR.BS0 ( -- ) 0 bit GPIOF.BSRR ! ; \ GPIOF.BSRR.BS0, Port x set bit y (y=               0..15)

\ GPIOF.LCKR (read-write) Reset:$00000000
: GPIOF.LCKR.LCKK ( -- x addr ) 16 bit GPIOF.LCKR ; \ GPIOF.LCKR.LCKK, Port x lock bit y (y=               0..15)
: GPIOF.LCKR.LCK15 ( -- x addr ) 15 bit GPIOF.LCKR ; \ GPIOF.LCKR.LCK15, Port x lock bit y (y=               0..15)
: GPIOF.LCKR.LCK14 ( -- x addr ) 14 bit GPIOF.LCKR ; \ GPIOF.LCKR.LCK14, Port x lock bit y (y=               0..15)
: GPIOF.LCKR.LCK13 ( -- x addr ) 13 bit GPIOF.LCKR ; \ GPIOF.LCKR.LCK13, Port x lock bit y (y=               0..15)
: GPIOF.LCKR.LCK12 ( -- x addr ) 12 bit GPIOF.LCKR ; \ GPIOF.LCKR.LCK12, Port x lock bit y (y=               0..15)
: GPIOF.LCKR.LCK11 ( -- x addr ) 11 bit GPIOF.LCKR ; \ GPIOF.LCKR.LCK11, Port x lock bit y (y=               0..15)
: GPIOF.LCKR.LCK10 ( -- x addr ) 10 bit GPIOF.LCKR ; \ GPIOF.LCKR.LCK10, Port x lock bit y (y=               0..15)
: GPIOF.LCKR.LCK9 ( -- x addr ) 9 bit GPIOF.LCKR ; \ GPIOF.LCKR.LCK9, Port x lock bit y (y=               0..15)
: GPIOF.LCKR.LCK8 ( -- x addr ) 8 bit GPIOF.LCKR ; \ GPIOF.LCKR.LCK8, Port x lock bit y (y=               0..15)
: GPIOF.LCKR.LCK7 ( -- x addr ) 7 bit GPIOF.LCKR ; \ GPIOF.LCKR.LCK7, Port x lock bit y (y=               0..15)
: GPIOF.LCKR.LCK6 ( -- x addr ) 6 bit GPIOF.LCKR ; \ GPIOF.LCKR.LCK6, Port x lock bit y (y=               0..15)
: GPIOF.LCKR.LCK5 ( -- x addr ) 5 bit GPIOF.LCKR ; \ GPIOF.LCKR.LCK5, Port x lock bit y (y=               0..15)
: GPIOF.LCKR.LCK4 ( -- x addr ) 4 bit GPIOF.LCKR ; \ GPIOF.LCKR.LCK4, Port x lock bit y (y=               0..15)
: GPIOF.LCKR.LCK3 ( -- x addr ) 3 bit GPIOF.LCKR ; \ GPIOF.LCKR.LCK3, Port x lock bit y (y=               0..15)
: GPIOF.LCKR.LCK2 ( -- x addr ) 2 bit GPIOF.LCKR ; \ GPIOF.LCKR.LCK2, Port x lock bit y (y=               0..15)
: GPIOF.LCKR.LCK1 ( -- x addr ) 1 bit GPIOF.LCKR ; \ GPIOF.LCKR.LCK1, Port x lock bit y (y=               0..15)
: GPIOF.LCKR.LCK0 ( -- x addr ) 0 bit GPIOF.LCKR ; \ GPIOF.LCKR.LCK0, Port x lock bit y (y=               0..15)

\ GPIOF.AFRL (read-write) Reset:$00000000
: GPIOF.AFRL.AFSEL7 ( %bbbb -- x addr ) 28 lshift GPIOF.AFRL ; \ GPIOF.AFRL.AFSEL7, Alternate function selection for port x               bit y (y = 0..7)
: GPIOF.AFRL.AFSEL6 ( %bbbb -- x addr ) 24 lshift GPIOF.AFRL ; \ GPIOF.AFRL.AFSEL6, Alternate function selection for port x               bit y (y = 0..7)
: GPIOF.AFRL.AFSEL5 ( %bbbb -- x addr ) 20 lshift GPIOF.AFRL ; \ GPIOF.AFRL.AFSEL5, Alternate function selection for port x               bit y (y = 0..7)
: GPIOF.AFRL.AFSEL4 ( %bbbb -- x addr ) 16 lshift GPIOF.AFRL ; \ GPIOF.AFRL.AFSEL4, Alternate function selection for port x               bit y (y = 0..7)
: GPIOF.AFRL.AFSEL3 ( %bbbb -- x addr ) 12 lshift GPIOF.AFRL ; \ GPIOF.AFRL.AFSEL3, Alternate function selection for port x               bit y (y = 0..7)
: GPIOF.AFRL.AFSEL2 ( %bbbb -- x addr ) 8 lshift GPIOF.AFRL ; \ GPIOF.AFRL.AFSEL2, Alternate function selection for port x               bit y (y = 0..7)
: GPIOF.AFRL.AFSEL1 ( %bbbb -- x addr ) 4 lshift GPIOF.AFRL ; \ GPIOF.AFRL.AFSEL1, Alternate function selection for port x               bit y (y = 0..7)
: GPIOF.AFRL.AFSEL0 ( %bbbb -- x addr ) GPIOF.AFRL ; \ GPIOF.AFRL.AFSEL0, Alternate function selection for port x               bit y (y = 0..7)

\ GPIOF.AFRH (read-write) Reset:$00000000
: GPIOF.AFRH.AFSEL15 ( %bbbb -- x addr ) 28 lshift GPIOF.AFRH ; \ GPIOF.AFRH.AFSEL15, Alternate function selection for port x               bit y (y = 8..15)
: GPIOF.AFRH.AFSEL14 ( %bbbb -- x addr ) 24 lshift GPIOF.AFRH ; \ GPIOF.AFRH.AFSEL14, Alternate function selection for port x               bit y (y = 8..15)
: GPIOF.AFRH.AFSEL13 ( %bbbb -- x addr ) 20 lshift GPIOF.AFRH ; \ GPIOF.AFRH.AFSEL13, Alternate function selection for port x               bit y (y = 8..15)
: GPIOF.AFRH.AFSEL12 ( %bbbb -- x addr ) 16 lshift GPIOF.AFRH ; \ GPIOF.AFRH.AFSEL12, Alternate function selection for port x               bit y (y = 8..15)
: GPIOF.AFRH.AFSEL11 ( %bbbb -- x addr ) 12 lshift GPIOF.AFRH ; \ GPIOF.AFRH.AFSEL11, Alternate function selection for port x               bit y (y = 8..15)
: GPIOF.AFRH.AFSEL10 ( %bbbb -- x addr ) 8 lshift GPIOF.AFRH ; \ GPIOF.AFRH.AFSEL10, Alternate function selection for port x               bit y (y = 8..15)
: GPIOF.AFRH.AFSEL9 ( %bbbb -- x addr ) 4 lshift GPIOF.AFRH ; \ GPIOF.AFRH.AFSEL9, Alternate function selection for port x               bit y (y = 8..15)
: GPIOF.AFRH.AFSEL8 ( %bbbb -- x addr ) GPIOF.AFRH ; \ GPIOF.AFRH.AFSEL8, Alternate function selection for port x               bit y (y = 8..15)

\ GPIOF.BRR (write-only) Reset:$00000000
: GPIOF.BRR.BR0 ( -- ) 0 bit GPIOF.BRR ! ; \ GPIOF.BRR.BR0, Port Reset bit
: GPIOF.BRR.BR1 ( -- ) 1 bit GPIOF.BRR ! ; \ GPIOF.BRR.BR1, Port Reset bit
: GPIOF.BRR.BR2 ( -- ) 2 bit GPIOF.BRR ! ; \ GPIOF.BRR.BR2, Port Reset bit
: GPIOF.BRR.BR3 ( -- ) 3 bit GPIOF.BRR ! ; \ GPIOF.BRR.BR3, Port Reset bit
: GPIOF.BRR.BR4 ( -- ) 4 bit GPIOF.BRR ! ; \ GPIOF.BRR.BR4, Port Reset bit
: GPIOF.BRR.BR5 ( -- ) 5 bit GPIOF.BRR ! ; \ GPIOF.BRR.BR5, Port Reset bit
: GPIOF.BRR.BR6 ( -- ) 6 bit GPIOF.BRR ! ; \ GPIOF.BRR.BR6, Port Reset bit
: GPIOF.BRR.BR7 ( -- ) 7 bit GPIOF.BRR ! ; \ GPIOF.BRR.BR7, Port Reset bit
: GPIOF.BRR.BR8 ( -- ) 8 bit GPIOF.BRR ! ; \ GPIOF.BRR.BR8, Port Reset bit
: GPIOF.BRR.BR9 ( -- ) 9 bit GPIOF.BRR ! ; \ GPIOF.BRR.BR9, Port Reset bit
: GPIOF.BRR.BR10 ( -- ) 10 bit GPIOF.BRR ! ; \ GPIOF.BRR.BR10, Port Reset bit
: GPIOF.BRR.BR11 ( -- ) 11 bit GPIOF.BRR ! ; \ GPIOF.BRR.BR11, Port Reset bit
: GPIOF.BRR.BR12 ( -- ) 12 bit GPIOF.BRR ! ; \ GPIOF.BRR.BR12, Port Reset bit
: GPIOF.BRR.BR13 ( -- ) 13 bit GPIOF.BRR ! ; \ GPIOF.BRR.BR13, Port Reset bit
: GPIOF.BRR.BR14 ( -- ) 14 bit GPIOF.BRR ! ; \ GPIOF.BRR.BR14, Port Reset bit
: GPIOF.BRR.BR15 ( -- ) 15 bit GPIOF.BRR ! ; \ GPIOF.BRR.BR15, Port Reset bit

\ CRC.DR (read-write) Reset:$FFFFFFFF
: CRC.DR.DR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) CRC.DR ; \ CRC.DR.DR, Data register bits

\ CRC.IDR (read-write) Reset:$00000000
: CRC.IDR.IDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) CRC.IDR ; \ CRC.IDR.IDR, General-purpose 32-bit data register               bits

\ CRC.CR (multiple-access)  Reset:$00000000
: CRC.CR.REV_OUT ( -- x addr ) 7 bit CRC.CR ; \ CRC.CR.REV_OUT, Reverse output data
: CRC.CR.REV_IN ( %bb -- x addr ) 5 lshift CRC.CR ; \ CRC.CR.REV_IN, Reverse input data
: CRC.CR.POLYSIZE ( %bb -- x addr ) 3 lshift CRC.CR ; \ CRC.CR.POLYSIZE, Polynomial size
: CRC.CR.RESET ( -- x addr ) 0 bit CRC.CR ; \ CRC.CR.RESET, RESET bit

\ CRC.INIT (read-write) Reset:$FFFFFFFF
: CRC.INIT.CRC_INIT ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) CRC.INIT ; \ CRC.INIT.CRC_INIT, Programmable initial CRC               value

\ CRC.POL (read-write) Reset:$04C11DB7
: CRC.POL.POL ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) CRC.POL ; \ CRC.POL.POL, Programmable polynomial

\ EXTI.RTSR1 (read-write) Reset:$00000000
: EXTI.RTSR1.TR0 ( -- x addr ) 0 bit EXTI.RTSR1 ; \ EXTI.RTSR1.TR0, Rising trigger event configuration bit               of Configurable Event input
: EXTI.RTSR1.TR1 ( -- x addr ) 1 bit EXTI.RTSR1 ; \ EXTI.RTSR1.TR1, Rising trigger event configuration bit               of Configurable Event input
: EXTI.RTSR1.TR2 ( -- x addr ) 2 bit EXTI.RTSR1 ; \ EXTI.RTSR1.TR2, Rising trigger event configuration bit               of Configurable Event input
: EXTI.RTSR1.TR3 ( -- x addr ) 3 bit EXTI.RTSR1 ; \ EXTI.RTSR1.TR3, Rising trigger event configuration bit               of Configurable Event input
: EXTI.RTSR1.TR4 ( -- x addr ) 4 bit EXTI.RTSR1 ; \ EXTI.RTSR1.TR4, Rising trigger event configuration bit               of Configurable Event input
: EXTI.RTSR1.TR5 ( -- x addr ) 5 bit EXTI.RTSR1 ; \ EXTI.RTSR1.TR5, Rising trigger event configuration bit               of Configurable Event input
: EXTI.RTSR1.TR6 ( -- x addr ) 6 bit EXTI.RTSR1 ; \ EXTI.RTSR1.TR6, Rising trigger event configuration bit               of Configurable Event input
: EXTI.RTSR1.TR7 ( -- x addr ) 7 bit EXTI.RTSR1 ; \ EXTI.RTSR1.TR7, Rising trigger event configuration bit               of Configurable Event input
: EXTI.RTSR1.TR8 ( -- x addr ) 8 bit EXTI.RTSR1 ; \ EXTI.RTSR1.TR8, Rising trigger event configuration bit               of Configurable Event input
: EXTI.RTSR1.TR9 ( -- x addr ) 9 bit EXTI.RTSR1 ; \ EXTI.RTSR1.TR9, Rising trigger event configuration bit               of Configurable Event input
: EXTI.RTSR1.TR10 ( -- x addr ) 10 bit EXTI.RTSR1 ; \ EXTI.RTSR1.TR10, Rising trigger event configuration bit               of Configurable Event input
: EXTI.RTSR1.TR11 ( -- x addr ) 11 bit EXTI.RTSR1 ; \ EXTI.RTSR1.TR11, Rising trigger event configuration bit               of Configurable Event input
: EXTI.RTSR1.TR12 ( -- x addr ) 12 bit EXTI.RTSR1 ; \ EXTI.RTSR1.TR12, Rising trigger event configuration bit               of Configurable Event input
: EXTI.RTSR1.TR13 ( -- x addr ) 13 bit EXTI.RTSR1 ; \ EXTI.RTSR1.TR13, Rising trigger event configuration bit               of Configurable Event input
: EXTI.RTSR1.TR14 ( -- x addr ) 14 bit EXTI.RTSR1 ; \ EXTI.RTSR1.TR14, Rising trigger event configuration bit               of Configurable Event input
: EXTI.RTSR1.TR15 ( -- x addr ) 15 bit EXTI.RTSR1 ; \ EXTI.RTSR1.TR15, Rising trigger event configuration bit               of Configurable Event input
: EXTI.RTSR1.TR16 ( -- x addr ) 16 bit EXTI.RTSR1 ; \ EXTI.RTSR1.TR16, Rising trigger event configuration bit               of Configurable Event input

\ EXTI.FTSR1 (read-write) Reset:$00000000
: EXTI.FTSR1.TR0 ( -- x addr ) 0 bit EXTI.FTSR1 ; \ EXTI.FTSR1.TR0, Rising trigger event configuration bit               of Configurable Event input
: EXTI.FTSR1.TR1 ( -- x addr ) 1 bit EXTI.FTSR1 ; \ EXTI.FTSR1.TR1, Rising trigger event configuration bit               of Configurable Event input
: EXTI.FTSR1.TR2 ( -- x addr ) 2 bit EXTI.FTSR1 ; \ EXTI.FTSR1.TR2, Rising trigger event configuration bit               of Configurable Event input
: EXTI.FTSR1.TR3 ( -- x addr ) 3 bit EXTI.FTSR1 ; \ EXTI.FTSR1.TR3, Rising trigger event configuration bit               of Configurable Event input
: EXTI.FTSR1.TR4 ( -- x addr ) 4 bit EXTI.FTSR1 ; \ EXTI.FTSR1.TR4, Rising trigger event configuration bit               of Configurable Event input
: EXTI.FTSR1.TR5 ( -- x addr ) 5 bit EXTI.FTSR1 ; \ EXTI.FTSR1.TR5, Rising trigger event configuration bit               of Configurable Event input
: EXTI.FTSR1.TR6 ( -- x addr ) 6 bit EXTI.FTSR1 ; \ EXTI.FTSR1.TR6, Rising trigger event configuration bit               of Configurable Event input
: EXTI.FTSR1.TR7 ( -- x addr ) 7 bit EXTI.FTSR1 ; \ EXTI.FTSR1.TR7, Rising trigger event configuration bit               of Configurable Event input
: EXTI.FTSR1.TR8 ( -- x addr ) 8 bit EXTI.FTSR1 ; \ EXTI.FTSR1.TR8, Rising trigger event configuration bit               of Configurable Event input
: EXTI.FTSR1.TR9 ( -- x addr ) 9 bit EXTI.FTSR1 ; \ EXTI.FTSR1.TR9, Rising trigger event configuration bit               of Configurable Event input
: EXTI.FTSR1.TR10 ( -- x addr ) 10 bit EXTI.FTSR1 ; \ EXTI.FTSR1.TR10, Rising trigger event configuration bit               of Configurable Event input
: EXTI.FTSR1.TR11 ( -- x addr ) 11 bit EXTI.FTSR1 ; \ EXTI.FTSR1.TR11, Rising trigger event configuration bit               of Configurable Event input
: EXTI.FTSR1.TR12 ( -- x addr ) 12 bit EXTI.FTSR1 ; \ EXTI.FTSR1.TR12, Rising trigger event configuration bit               of Configurable Event input
: EXTI.FTSR1.TR13 ( -- x addr ) 13 bit EXTI.FTSR1 ; \ EXTI.FTSR1.TR13, Rising trigger event configuration bit               of Configurable Event input
: EXTI.FTSR1.TR14 ( -- x addr ) 14 bit EXTI.FTSR1 ; \ EXTI.FTSR1.TR14, Rising trigger event configuration bit               of Configurable Event input
: EXTI.FTSR1.TR15 ( -- x addr ) 15 bit EXTI.FTSR1 ; \ EXTI.FTSR1.TR15, Rising trigger event configuration bit               of Configurable Event input
: EXTI.FTSR1.TR16 ( -- x addr ) 16 bit EXTI.FTSR1 ; \ EXTI.FTSR1.TR16, Rising trigger event configuration bit               of Configurable Event input

\ EXTI.SWIER1 (read-write) Reset:$00000000
: EXTI.SWIER1.SWIER0 ( -- x addr ) 0 bit EXTI.SWIER1 ; \ EXTI.SWIER1.SWIER0, Rising trigger event configuration bit               of Configurable Event input
: EXTI.SWIER1.SWIER1 ( -- x addr ) 1 bit EXTI.SWIER1 ; \ EXTI.SWIER1.SWIER1, Rising trigger event configuration bit               of Configurable Event input
: EXTI.SWIER1.SWIER2 ( -- x addr ) 2 bit EXTI.SWIER1 ; \ EXTI.SWIER1.SWIER2, Rising trigger event configuration bit               of Configurable Event input
: EXTI.SWIER1.SWIER3 ( -- x addr ) 3 bit EXTI.SWIER1 ; \ EXTI.SWIER1.SWIER3, Rising trigger event configuration bit               of Configurable Event input
: EXTI.SWIER1.SWIER4 ( -- x addr ) 4 bit EXTI.SWIER1 ; \ EXTI.SWIER1.SWIER4, Rising trigger event configuration bit               of Configurable Event input
: EXTI.SWIER1.SWIER5 ( -- x addr ) 5 bit EXTI.SWIER1 ; \ EXTI.SWIER1.SWIER5, Rising trigger event configuration bit               of Configurable Event input
: EXTI.SWIER1.SWIER6 ( -- x addr ) 6 bit EXTI.SWIER1 ; \ EXTI.SWIER1.SWIER6, Rising trigger event configuration bit               of Configurable Event input
: EXTI.SWIER1.SWIER7 ( -- x addr ) 7 bit EXTI.SWIER1 ; \ EXTI.SWIER1.SWIER7, Rising trigger event configuration bit               of Configurable Event input
: EXTI.SWIER1.SWIER8 ( -- x addr ) 8 bit EXTI.SWIER1 ; \ EXTI.SWIER1.SWIER8, Rising trigger event configuration bit               of Configurable Event input
: EXTI.SWIER1.SWIER9 ( -- x addr ) 9 bit EXTI.SWIER1 ; \ EXTI.SWIER1.SWIER9, Rising trigger event configuration bit               of Configurable Event input
: EXTI.SWIER1.SWIER10 ( -- x addr ) 10 bit EXTI.SWIER1 ; \ EXTI.SWIER1.SWIER10, Rising trigger event configuration bit               of Configurable Event input
: EXTI.SWIER1.SWIER11 ( -- x addr ) 11 bit EXTI.SWIER1 ; \ EXTI.SWIER1.SWIER11, Rising trigger event configuration bit               of Configurable Event input
: EXTI.SWIER1.SWIER12 ( -- x addr ) 12 bit EXTI.SWIER1 ; \ EXTI.SWIER1.SWIER12, Rising trigger event configuration bit               of Configurable Event input
: EXTI.SWIER1.SWIER13 ( -- x addr ) 13 bit EXTI.SWIER1 ; \ EXTI.SWIER1.SWIER13, Rising trigger event configuration bit               of Configurable Event input
: EXTI.SWIER1.SWIER14 ( -- x addr ) 14 bit EXTI.SWIER1 ; \ EXTI.SWIER1.SWIER14, Rising trigger event configuration bit               of Configurable Event input
: EXTI.SWIER1.SWIER15 ( -- x addr ) 15 bit EXTI.SWIER1 ; \ EXTI.SWIER1.SWIER15, Rising trigger event configuration bit               of Configurable Event input
: EXTI.SWIER1.SWIER16 ( -- x addr ) 16 bit EXTI.SWIER1 ; \ EXTI.SWIER1.SWIER16, Rising trigger event configuration bit               of Configurable Event input

\ EXTI.RPR1 (read-write) Reset:$00000000
: EXTI.RPR1.RPIF0 ( -- x addr ) 0 bit EXTI.RPR1 ; \ EXTI.RPR1.RPIF0, configurable event inputs x rising edge               Pending bit.
: EXTI.RPR1.RPIF1 ( -- x addr ) 1 bit EXTI.RPR1 ; \ EXTI.RPR1.RPIF1, configurable event inputs x rising edge               Pending bit.
: EXTI.RPR1.RPIF2 ( -- x addr ) 2 bit EXTI.RPR1 ; \ EXTI.RPR1.RPIF2, configurable event inputs x rising edge               Pending bit.
: EXTI.RPR1.RPIF3 ( -- x addr ) 3 bit EXTI.RPR1 ; \ EXTI.RPR1.RPIF3, configurable event inputs x rising edge               Pending bit.
: EXTI.RPR1.RPIF4 ( -- x addr ) 4 bit EXTI.RPR1 ; \ EXTI.RPR1.RPIF4, configurable event inputs x rising edge               Pending bit.
: EXTI.RPR1.RPIF5 ( -- x addr ) 5 bit EXTI.RPR1 ; \ EXTI.RPR1.RPIF5, configurable event inputs x rising edge               Pending bit
: EXTI.RPR1.RPIF6 ( -- x addr ) 6 bit EXTI.RPR1 ; \ EXTI.RPR1.RPIF6, configurable event inputs x rising edge               Pending bit.
: EXTI.RPR1.RPIF7 ( -- x addr ) 7 bit EXTI.RPR1 ; \ EXTI.RPR1.RPIF7, configurable event inputs x rising edge               Pending bit.
: EXTI.RPR1.RPIF8 ( -- x addr ) 8 bit EXTI.RPR1 ; \ EXTI.RPR1.RPIF8, configurable event inputs x rising edge               Pending bit.
: EXTI.RPR1.RPIF9 ( -- x addr ) 9 bit EXTI.RPR1 ; \ EXTI.RPR1.RPIF9, configurable event inputs x rising edge               Pending bit.
: EXTI.RPR1.RPIF10 ( -- x addr ) 10 bit EXTI.RPR1 ; \ EXTI.RPR1.RPIF10, configurable event inputs x rising edge               Pending bit.
: EXTI.RPR1.RPIF11 ( -- x addr ) 11 bit EXTI.RPR1 ; \ EXTI.RPR1.RPIF11, configurable event inputs x rising edge               Pending bit.
: EXTI.RPR1.RPIF12 ( -- x addr ) 12 bit EXTI.RPR1 ; \ EXTI.RPR1.RPIF12, configurable event inputs x rising edge               Pending bit.
: EXTI.RPR1.RPIF13 ( -- x addr ) 13 bit EXTI.RPR1 ; \ EXTI.RPR1.RPIF13, configurable event inputs x rising edge               Pending bit.
: EXTI.RPR1.RPIF14 ( -- x addr ) 14 bit EXTI.RPR1 ; \ EXTI.RPR1.RPIF14, configurable event inputs x rising edge               Pending bit.
: EXTI.RPR1.RPIF15 ( -- x addr ) 15 bit EXTI.RPR1 ; \ EXTI.RPR1.RPIF15, configurable event inputs x rising edge               Pending bit.
: EXTI.RPR1.RPIF16 ( -- x addr ) 16 bit EXTI.RPR1 ; \ EXTI.RPR1.RPIF16, configurable event inputs x rising edge               Pending bit.

\ EXTI.FPR1 (read-write) Reset:$00000000
: EXTI.FPR1.FPIF0 ( -- x addr ) 0 bit EXTI.FPR1 ; \ EXTI.FPR1.FPIF0, configurable event inputs x falling edge               pending bit.
: EXTI.FPR1.FPIF1 ( -- x addr ) 1 bit EXTI.FPR1 ; \ EXTI.FPR1.FPIF1, configurable event inputs x falling edge               pending bit.
: EXTI.FPR1.FPIF2 ( -- x addr ) 2 bit EXTI.FPR1 ; \ EXTI.FPR1.FPIF2, configurable event inputs x falling edge               pending bit.
: EXTI.FPR1.FPIF3 ( -- x addr ) 3 bit EXTI.FPR1 ; \ EXTI.FPR1.FPIF3, configurable event inputs x falling edge               pending bit.
: EXTI.FPR1.FPIF4 ( -- x addr ) 4 bit EXTI.FPR1 ; \ EXTI.FPR1.FPIF4, configurable event inputs x falling edge               pending bit.
: EXTI.FPR1.FPIF5 ( -- x addr ) 5 bit EXTI.FPR1 ; \ EXTI.FPR1.FPIF5, configurable event inputs x falling edge               pending bit.
: EXTI.FPR1.FPIF6 ( -- x addr ) 6 bit EXTI.FPR1 ; \ EXTI.FPR1.FPIF6, configurable event inputs x falling edge               pending bit.
: EXTI.FPR1.FPIF7 ( -- x addr ) 7 bit EXTI.FPR1 ; \ EXTI.FPR1.FPIF7, configurable event inputs x falling edge               pending bit.
: EXTI.FPR1.FPIF8 ( -- x addr ) 8 bit EXTI.FPR1 ; \ EXTI.FPR1.FPIF8, configurable event inputs x falling edge               pending bit.
: EXTI.FPR1.FPIF9 ( -- x addr ) 9 bit EXTI.FPR1 ; \ EXTI.FPR1.FPIF9, configurable event inputs x falling edge               pending bit.
: EXTI.FPR1.FPIF10 ( -- x addr ) 10 bit EXTI.FPR1 ; \ EXTI.FPR1.FPIF10, configurable event inputs x falling edge               pending bit.
: EXTI.FPR1.FPIF11 ( -- x addr ) 11 bit EXTI.FPR1 ; \ EXTI.FPR1.FPIF11, configurable event inputs x falling edge               pending bit.
: EXTI.FPR1.FPIF12 ( -- x addr ) 12 bit EXTI.FPR1 ; \ EXTI.FPR1.FPIF12, configurable event inputs x falling edge               pending bit.
: EXTI.FPR1.FPIF13 ( -- x addr ) 13 bit EXTI.FPR1 ; \ EXTI.FPR1.FPIF13, configurable event inputs x falling edge               pending bit.
: EXTI.FPR1.FPIF14 ( -- x addr ) 14 bit EXTI.FPR1 ; \ EXTI.FPR1.FPIF14, configurable event inputs x falling edge               pending bit.
: EXTI.FPR1.FPIF15 ( -- x addr ) 15 bit EXTI.FPR1 ; \ EXTI.FPR1.FPIF15, configurable event inputs x falling edge               pending bit.
: EXTI.FPR1.FPIF16 ( -- x addr ) 16 bit EXTI.FPR1 ; \ EXTI.FPR1.FPIF16, configurable event inputs x falling edge               pending bit.

\ EXTI.EXTICR1 (read-write) Reset:$00000000
: EXTI.EXTICR1.EXTI0_7 ( %bbbbbbbb -- x addr ) EXTI.EXTICR1 ; \ EXTI.EXTICR1.EXTI0_7, GPIO port selection
: EXTI.EXTICR1.EXTI8_15 ( %bbbbbbbb -- x addr ) 8 lshift EXTI.EXTICR1 ; \ EXTI.EXTICR1.EXTI8_15, GPIO port selection
: EXTI.EXTICR1.EXTI16_23 ( %bbbbbbbb -- x addr ) 16 lshift EXTI.EXTICR1 ; \ EXTI.EXTICR1.EXTI16_23, GPIO port selection
: EXTI.EXTICR1.EXTI24_31 ( %bbbbbbbb -- x addr ) 24 lshift EXTI.EXTICR1 ; \ EXTI.EXTICR1.EXTI24_31, GPIO port selection

\ EXTI.EXTICR2 (read-write) Reset:$00000000
: EXTI.EXTICR2.EXTI0_7 ( %bbbbbbbb -- x addr ) EXTI.EXTICR2 ; \ EXTI.EXTICR2.EXTI0_7, GPIO port selection
: EXTI.EXTICR2.EXTI8_15 ( %bbbbbbbb -- x addr ) 8 lshift EXTI.EXTICR2 ; \ EXTI.EXTICR2.EXTI8_15, GPIO port selection
: EXTI.EXTICR2.EXTI16_23 ( %bbbbbbbb -- x addr ) 16 lshift EXTI.EXTICR2 ; \ EXTI.EXTICR2.EXTI16_23, GPIO port selection
: EXTI.EXTICR2.EXTI24_31 ( %bbbbbbbb -- x addr ) 24 lshift EXTI.EXTICR2 ; \ EXTI.EXTICR2.EXTI24_31, GPIO port selection

\ EXTI.EXTICR3 (read-write) Reset:$00000000
: EXTI.EXTICR3.EXTI0_7 ( %bbbbbbbb -- x addr ) EXTI.EXTICR3 ; \ EXTI.EXTICR3.EXTI0_7, GPIO port selection
: EXTI.EXTICR3.EXTI8_15 ( %bbbbbbbb -- x addr ) 8 lshift EXTI.EXTICR3 ; \ EXTI.EXTICR3.EXTI8_15, GPIO port selection
: EXTI.EXTICR3.EXTI16_23 ( %bbbbbbbb -- x addr ) 16 lshift EXTI.EXTICR3 ; \ EXTI.EXTICR3.EXTI16_23, GPIO port selection
: EXTI.EXTICR3.EXTI24_31 ( %bbbbbbbb -- x addr ) 24 lshift EXTI.EXTICR3 ; \ EXTI.EXTICR3.EXTI24_31, GPIO port selection

\ EXTI.EXTICR4 (read-write) Reset:$00000000
: EXTI.EXTICR4.EXTI0_7 ( %bbbbbbbb -- x addr ) EXTI.EXTICR4 ; \ EXTI.EXTICR4.EXTI0_7, GPIO port selection
: EXTI.EXTICR4.EXTI8_15 ( %bbbbbbbb -- x addr ) 8 lshift EXTI.EXTICR4 ; \ EXTI.EXTICR4.EXTI8_15, GPIO port selection
: EXTI.EXTICR4.EXTI16_23 ( %bbbbbbbb -- x addr ) 16 lshift EXTI.EXTICR4 ; \ EXTI.EXTICR4.EXTI16_23, GPIO port selection
: EXTI.EXTICR4.EXTI24_31 ( %bbbbbbbb -- x addr ) 24 lshift EXTI.EXTICR4 ; \ EXTI.EXTICR4.EXTI24_31, GPIO port selection

\ EXTI.IMR1 (read-write) Reset:$FFF80000
: EXTI.IMR1.IM0 ( -- x addr ) 0 bit EXTI.IMR1 ; \ EXTI.IMR1.IM0, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM1 ( -- x addr ) 1 bit EXTI.IMR1 ; \ EXTI.IMR1.IM1, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM2 ( -- x addr ) 2 bit EXTI.IMR1 ; \ EXTI.IMR1.IM2, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM3 ( -- x addr ) 3 bit EXTI.IMR1 ; \ EXTI.IMR1.IM3, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM4 ( -- x addr ) 4 bit EXTI.IMR1 ; \ EXTI.IMR1.IM4, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM5 ( -- x addr ) 5 bit EXTI.IMR1 ; \ EXTI.IMR1.IM5, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM6 ( -- x addr ) 6 bit EXTI.IMR1 ; \ EXTI.IMR1.IM6, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM7 ( -- x addr ) 7 bit EXTI.IMR1 ; \ EXTI.IMR1.IM7, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM8 ( -- x addr ) 8 bit EXTI.IMR1 ; \ EXTI.IMR1.IM8, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM9 ( -- x addr ) 9 bit EXTI.IMR1 ; \ EXTI.IMR1.IM9, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM10 ( -- x addr ) 10 bit EXTI.IMR1 ; \ EXTI.IMR1.IM10, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM11 ( -- x addr ) 11 bit EXTI.IMR1 ; \ EXTI.IMR1.IM11, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM12 ( -- x addr ) 12 bit EXTI.IMR1 ; \ EXTI.IMR1.IM12, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM13 ( -- x addr ) 13 bit EXTI.IMR1 ; \ EXTI.IMR1.IM13, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM14 ( -- x addr ) 14 bit EXTI.IMR1 ; \ EXTI.IMR1.IM14, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM15 ( -- x addr ) 15 bit EXTI.IMR1 ; \ EXTI.IMR1.IM15, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM16 ( -- x addr ) 16 bit EXTI.IMR1 ; \ EXTI.IMR1.IM16, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM19 ( -- x addr ) 19 bit EXTI.IMR1 ; \ EXTI.IMR1.IM19, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM20 ( -- x addr ) 20 bit EXTI.IMR1 ; \ EXTI.IMR1.IM20, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM21 ( -- x addr ) 21 bit EXTI.IMR1 ; \ EXTI.IMR1.IM21, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM22 ( -- x addr ) 22 bit EXTI.IMR1 ; \ EXTI.IMR1.IM22, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM23 ( -- x addr ) 23 bit EXTI.IMR1 ; \ EXTI.IMR1.IM23, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM24 ( -- x addr ) 24 bit EXTI.IMR1 ; \ EXTI.IMR1.IM24, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM25 ( -- x addr ) 25 bit EXTI.IMR1 ; \ EXTI.IMR1.IM25, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM26 ( -- x addr ) 26 bit EXTI.IMR1 ; \ EXTI.IMR1.IM26, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM28 ( -- x addr ) 28 bit EXTI.IMR1 ; \ EXTI.IMR1.IM28, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM29 ( -- x addr ) 29 bit EXTI.IMR1 ; \ EXTI.IMR1.IM29, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM30 ( -- x addr ) 30 bit EXTI.IMR1 ; \ EXTI.IMR1.IM30, CPU wakeup with interrupt mask on event               input
: EXTI.IMR1.IM31 ( -- x addr ) 31 bit EXTI.IMR1 ; \ EXTI.IMR1.IM31, CPU wakeup with interrupt mask on event               input

\ EXTI.EMR1 (read-write) Reset:$00000000
: EXTI.EMR1.EM0 ( -- x addr ) 0 bit EXTI.EMR1 ; \ EXTI.EMR1.EM0, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM1 ( -- x addr ) 1 bit EXTI.EMR1 ; \ EXTI.EMR1.EM1, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM2 ( -- x addr ) 2 bit EXTI.EMR1 ; \ EXTI.EMR1.EM2, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM3 ( -- x addr ) 3 bit EXTI.EMR1 ; \ EXTI.EMR1.EM3, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM4 ( -- x addr ) 4 bit EXTI.EMR1 ; \ EXTI.EMR1.EM4, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM5 ( -- x addr ) 5 bit EXTI.EMR1 ; \ EXTI.EMR1.EM5, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM6 ( -- x addr ) 6 bit EXTI.EMR1 ; \ EXTI.EMR1.EM6, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM7 ( -- x addr ) 7 bit EXTI.EMR1 ; \ EXTI.EMR1.EM7, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM8 ( -- x addr ) 8 bit EXTI.EMR1 ; \ EXTI.EMR1.EM8, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM9 ( -- x addr ) 9 bit EXTI.EMR1 ; \ EXTI.EMR1.EM9, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM10 ( -- x addr ) 10 bit EXTI.EMR1 ; \ EXTI.EMR1.EM10, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM11 ( -- x addr ) 11 bit EXTI.EMR1 ; \ EXTI.EMR1.EM11, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM12 ( -- x addr ) 12 bit EXTI.EMR1 ; \ EXTI.EMR1.EM12, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM13 ( -- x addr ) 13 bit EXTI.EMR1 ; \ EXTI.EMR1.EM13, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM14 ( -- x addr ) 14 bit EXTI.EMR1 ; \ EXTI.EMR1.EM14, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM15 ( -- x addr ) 15 bit EXTI.EMR1 ; \ EXTI.EMR1.EM15, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM16 ( -- x addr ) 16 bit EXTI.EMR1 ; \ EXTI.EMR1.EM16, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM19 ( -- x addr ) 19 bit EXTI.EMR1 ; \ EXTI.EMR1.EM19, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM21 ( -- x addr ) 21 bit EXTI.EMR1 ; \ EXTI.EMR1.EM21, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM23 ( -- x addr ) 23 bit EXTI.EMR1 ; \ EXTI.EMR1.EM23, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM25 ( -- x addr ) 25 bit EXTI.EMR1 ; \ EXTI.EMR1.EM25, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM26 ( -- x addr ) 26 bit EXTI.EMR1 ; \ EXTI.EMR1.EM26, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM28 ( -- x addr ) 28 bit EXTI.EMR1 ; \ EXTI.EMR1.EM28, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM29 ( -- x addr ) 29 bit EXTI.EMR1 ; \ EXTI.EMR1.EM29, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM30 ( -- x addr ) 30 bit EXTI.EMR1 ; \ EXTI.EMR1.EM30, CPU wakeup with event mask on event               input
: EXTI.EMR1.EM31 ( -- x addr ) 31 bit EXTI.EMR1 ; \ EXTI.EMR1.EM31, CPU wakeup with event mask on event               input

\ TIM16.CR1 (read-write) Reset:$0000
: TIM16.CR1.CEN ( -- x addr ) 0 bit TIM16.CR1 ; \ TIM16.CR1.CEN, Counter enable
: TIM16.CR1.UDIS ( -- x addr ) 1 bit TIM16.CR1 ; \ TIM16.CR1.UDIS, Update disable
: TIM16.CR1.URS ( -- x addr ) 2 bit TIM16.CR1 ; \ TIM16.CR1.URS, Update request source
: TIM16.CR1.OPM ( -- x addr ) 3 bit TIM16.CR1 ; \ TIM16.CR1.OPM, One-pulse mode
: TIM16.CR1.ARPE ( -- x addr ) 7 bit TIM16.CR1 ; \ TIM16.CR1.ARPE, Auto-reload preload enable
: TIM16.CR1.CKD ( %bb -- x addr ) 8 lshift TIM16.CR1 ; \ TIM16.CR1.CKD, Clock division
: TIM16.CR1.UIFREMAP ( -- x addr ) 11 bit TIM16.CR1 ; \ TIM16.CR1.UIFREMAP, UIF status bit remapping

\ TIM16.CR2 (read-write) Reset:$0000
: TIM16.CR2.OIS1N ( -- x addr ) 9 bit TIM16.CR2 ; \ TIM16.CR2.OIS1N, Output Idle state 1
: TIM16.CR2.OIS1 ( -- x addr ) 8 bit TIM16.CR2 ; \ TIM16.CR2.OIS1, Output Idle state 1
: TIM16.CR2.CCDS ( -- x addr ) 3 bit TIM16.CR2 ; \ TIM16.CR2.CCDS, Capture/compare DMA               selection
: TIM16.CR2.CCUS ( -- x addr ) 2 bit TIM16.CR2 ; \ TIM16.CR2.CCUS, Capture/compare control update               selection
: TIM16.CR2.CCPC ( -- x addr ) 0 bit TIM16.CR2 ; \ TIM16.CR2.CCPC, Capture/compare preloaded               control

\ TIM16.DIER (read-write) Reset:$0000
: TIM16.DIER.COMDE ( -- x addr ) 13 bit TIM16.DIER ; \ TIM16.DIER.COMDE, COM DMA request enable
: TIM16.DIER.CC1DE ( -- x addr ) 9 bit TIM16.DIER ; \ TIM16.DIER.CC1DE, Capture/Compare 1 DMA request               enable
: TIM16.DIER.UDE ( -- x addr ) 8 bit TIM16.DIER ; \ TIM16.DIER.UDE, Update DMA request enable
: TIM16.DIER.BIE ( -- x addr ) 7 bit TIM16.DIER ; \ TIM16.DIER.BIE, Break interrupt enable
: TIM16.DIER.COMIE ( -- x addr ) 5 bit TIM16.DIER ; \ TIM16.DIER.COMIE, COM interrupt enable
: TIM16.DIER.CC1IE ( -- x addr ) 1 bit TIM16.DIER ; \ TIM16.DIER.CC1IE, Capture/Compare 1 interrupt               enable
: TIM16.DIER.UIE ( -- x addr ) 0 bit TIM16.DIER ; \ TIM16.DIER.UIE, Update interrupt enable

\ TIM16.SR (read-write) Reset:$0000
: TIM16.SR.CC1OF ( -- x addr ) 9 bit TIM16.SR ; \ TIM16.SR.CC1OF, Capture/Compare 1 overcapture               flag
: TIM16.SR.BIF ( -- x addr ) 7 bit TIM16.SR ; \ TIM16.SR.BIF, Break interrupt flag
: TIM16.SR.COMIF ( -- x addr ) 5 bit TIM16.SR ; \ TIM16.SR.COMIF, COM interrupt flag
: TIM16.SR.CC1IF ( -- x addr ) 1 bit TIM16.SR ; \ TIM16.SR.CC1IF, Capture/compare 1 interrupt               flag
: TIM16.SR.UIF ( -- x addr ) 0 bit TIM16.SR ; \ TIM16.SR.UIF, Update interrupt flag

\ TIM16.EGR (write-only) Reset:$0000
: TIM16.EGR.BG ( -- x addr ) 7 bit TIM16.EGR ; \ TIM16.EGR.BG, Break generation
: TIM16.EGR.COMG ( -- x addr ) 5 bit TIM16.EGR ; \ TIM16.EGR.COMG, Capture/Compare control update               generation
: TIM16.EGR.CC1G ( -- x addr ) 1 bit TIM16.EGR ; \ TIM16.EGR.CC1G, Capture/compare 1               generation
: TIM16.EGR.UG ( -- x addr ) 0 bit TIM16.EGR ; \ TIM16.EGR.UG, Update generation

\ TIM16.CCMR1_Output (read-write) Reset:$00000000
: TIM16.CCMR1_Output.OC1M_2 ( -- x addr ) 16 bit TIM16.CCMR1_Output ; \ TIM16.CCMR1_Output.OC1M_2, Output Compare 1 mode
: TIM16.CCMR1_Output.OC1M ( %bbb -- x addr ) 4 lshift TIM16.CCMR1_Output ; \ TIM16.CCMR1_Output.OC1M, Output Compare 1 mode
: TIM16.CCMR1_Output.OC1PE ( -- x addr ) 3 bit TIM16.CCMR1_Output ; \ TIM16.CCMR1_Output.OC1PE, Output Compare 1 preload               enable
: TIM16.CCMR1_Output.OC1FE ( -- x addr ) 2 bit TIM16.CCMR1_Output ; \ TIM16.CCMR1_Output.OC1FE, Output Compare 1 fast               enable
: TIM16.CCMR1_Output.CC1S ( %bb -- x addr ) TIM16.CCMR1_Output ; \ TIM16.CCMR1_Output.CC1S, Capture/Compare 1               selection

\ TIM16.CCMR1_Input (read-write) Reset:$00000000
: TIM16.CCMR1_Input.IC1F ( %bbbb -- x addr ) 4 lshift TIM16.CCMR1_Input ; \ TIM16.CCMR1_Input.IC1F, Input capture 1 filter
: TIM16.CCMR1_Input.IC1PSC ( %bb -- x addr ) 2 lshift TIM16.CCMR1_Input ; \ TIM16.CCMR1_Input.IC1PSC, Input capture 1 prescaler
: TIM16.CCMR1_Input.CC1S ( %bb -- x addr ) TIM16.CCMR1_Input ; \ TIM16.CCMR1_Input.CC1S, Capture/Compare 1               selection

\ TIM16.CCER (read-write) Reset:$0000
: TIM16.CCER.CC1NP ( -- x addr ) 3 bit TIM16.CCER ; \ TIM16.CCER.CC1NP, Capture/Compare 1 output               Polarity
: TIM16.CCER.CC1NE ( -- x addr ) 2 bit TIM16.CCER ; \ TIM16.CCER.CC1NE, Capture/Compare 1 complementary output               enable
: TIM16.CCER.CC1P ( -- x addr ) 1 bit TIM16.CCER ; \ TIM16.CCER.CC1P, Capture/Compare 1 output               Polarity
: TIM16.CCER.CC1E ( -- x addr ) 0 bit TIM16.CCER ; \ TIM16.CCER.CC1E, Capture/Compare 1 output               enable

\ TIM16.CNT (multiple-access)  Reset:$00000000
: TIM16.CNT.CNT ( %bbbbbbbbbbbbbbbb -- x addr ) TIM16.CNT ; \ TIM16.CNT.CNT, counter value
: TIM16.CNT.UIFCPY ( -- x addr ) 31 bit TIM16.CNT ; \ TIM16.CNT.UIFCPY, UIF Copy

\ TIM16.PSC (read-write) Reset:$0000
: TIM16.PSC.PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIM16.PSC ; \ TIM16.PSC.PSC, Prescaler value

\ TIM16.ARR (read-write) Reset:$00000000
: TIM16.ARR.ARR ( %bbbbbbbbbbbbbbbb -- x addr ) TIM16.ARR ; \ TIM16.ARR.ARR, Auto-reload value

\ TIM16.RCR (read-write) Reset:$0000
: TIM16.RCR.REP ( %bbbbbbbb -- x addr ) TIM16.RCR ; \ TIM16.RCR.REP, Repetition counter value

\ TIM16.CCR1 (read-write) Reset:$00000000
: TIM16.CCR1.CCR1 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM16.CCR1 ; \ TIM16.CCR1.CCR1, Capture/Compare 1 value

\ TIM16.BDTR (read-write) Reset:$0000
: TIM16.BDTR.DTG ( %bbbbbbbb -- x addr ) TIM16.BDTR ; \ TIM16.BDTR.DTG, Dead-time generator setup
: TIM16.BDTR.LOCK ( %bb -- x addr ) 8 lshift TIM16.BDTR ; \ TIM16.BDTR.LOCK, Lock configuration
: TIM16.BDTR.OSSI ( -- x addr ) 10 bit TIM16.BDTR ; \ TIM16.BDTR.OSSI, Off-state selection for Idle               mode
: TIM16.BDTR.OSSR ( -- x addr ) 11 bit TIM16.BDTR ; \ TIM16.BDTR.OSSR, Off-state selection for Run               mode
: TIM16.BDTR.BKE ( -- x addr ) 12 bit TIM16.BDTR ; \ TIM16.BDTR.BKE, Break enable
: TIM16.BDTR.BKP ( -- x addr ) 13 bit TIM16.BDTR ; \ TIM16.BDTR.BKP, Break polarity
: TIM16.BDTR.AOE ( -- x addr ) 14 bit TIM16.BDTR ; \ TIM16.BDTR.AOE, Automatic output enable
: TIM16.BDTR.MOE ( -- x addr ) 15 bit TIM16.BDTR ; \ TIM16.BDTR.MOE, Main output enable
: TIM16.BDTR.BKF ( %bbbb -- x addr ) 16 lshift TIM16.BDTR ; \ TIM16.BDTR.BKF, Break filter
: TIM16.BDTR.BKDSRM ( -- x addr ) 26 bit TIM16.BDTR ; \ TIM16.BDTR.BKDSRM, Break Disarm
: TIM16.BDTR.BKBID ( -- x addr ) 28 bit TIM16.BDTR ; \ TIM16.BDTR.BKBID, Break Bidirectional

\ TIM16.DCR (read-write) Reset:$0000
: TIM16.DCR.DBL ( %bbbbb -- x addr ) 8 lshift TIM16.DCR ; \ TIM16.DCR.DBL, DMA burst length
: TIM16.DCR.DBA ( %bbbbb -- x addr ) TIM16.DCR ; \ TIM16.DCR.DBA, DMA base address

\ TIM16.DMAR (read-write) Reset:$0000
: TIM16.DMAR.DMAB ( %bbbbbbbbbbbbbbbb -- x addr ) TIM16.DMAR ; \ TIM16.DMAR.DMAB, DMA register for burst               accesses

\ TIM16.AF1 (read-write) Reset:$0000
: TIM16.AF1.BKINE ( -- x addr ) 0 bit TIM16.AF1 ; \ TIM16.AF1.BKINE, BRK BKIN input enable
: TIM16.AF1.BKCMP1E ( -- x addr ) 1 bit TIM16.AF1 ; \ TIM16.AF1.BKCMP1E, BRK COMP1 enable
: TIM16.AF1.BKCMP2E ( -- x addr ) 2 bit TIM16.AF1 ; \ TIM16.AF1.BKCMP2E, BRK COMP2 enable
: TIM16.AF1.BKDFBK1E ( -- x addr ) 8 bit TIM16.AF1 ; \ TIM16.AF1.BKDFBK1E, BRK DFSDM_BREAK1 enable
: TIM16.AF1.BKINP ( -- x addr ) 9 bit TIM16.AF1 ; \ TIM16.AF1.BKINP, BRK BKIN input polarity
: TIM16.AF1.BKCMP1P ( -- x addr ) 10 bit TIM16.AF1 ; \ TIM16.AF1.BKCMP1P, BRK COMP1 input polarity
: TIM16.AF1.BKCMP2P ( -- x addr ) 11 bit TIM16.AF1 ; \ TIM16.AF1.BKCMP2P, BRK COMP2 input polarit

\ TIM16.TISEL (read-write) Reset:$0000
: TIM16.TISEL.TI1SEL ( %bbbb -- x addr ) TIM16.TISEL ; \ TIM16.TISEL.TI1SEL, selects input

\ TIM17.CR1 (read-write) Reset:$0000
: TIM17.CR1.CEN ( -- x addr ) 0 bit TIM17.CR1 ; \ TIM17.CR1.CEN, Counter enable
: TIM17.CR1.UDIS ( -- x addr ) 1 bit TIM17.CR1 ; \ TIM17.CR1.UDIS, Update disable
: TIM17.CR1.URS ( -- x addr ) 2 bit TIM17.CR1 ; \ TIM17.CR1.URS, Update request source
: TIM17.CR1.OPM ( -- x addr ) 3 bit TIM17.CR1 ; \ TIM17.CR1.OPM, One-pulse mode
: TIM17.CR1.ARPE ( -- x addr ) 7 bit TIM17.CR1 ; \ TIM17.CR1.ARPE, Auto-reload preload enable
: TIM17.CR1.CKD ( %bb -- x addr ) 8 lshift TIM17.CR1 ; \ TIM17.CR1.CKD, Clock division
: TIM17.CR1.UIFREMAP ( -- x addr ) 11 bit TIM17.CR1 ; \ TIM17.CR1.UIFREMAP, UIF status bit remapping

\ TIM17.CR2 (read-write) Reset:$0000
: TIM17.CR2.OIS1N ( -- x addr ) 9 bit TIM17.CR2 ; \ TIM17.CR2.OIS1N, Output Idle state 1
: TIM17.CR2.OIS1 ( -- x addr ) 8 bit TIM17.CR2 ; \ TIM17.CR2.OIS1, Output Idle state 1
: TIM17.CR2.CCDS ( -- x addr ) 3 bit TIM17.CR2 ; \ TIM17.CR2.CCDS, Capture/compare DMA               selection
: TIM17.CR2.CCUS ( -- x addr ) 2 bit TIM17.CR2 ; \ TIM17.CR2.CCUS, Capture/compare control update               selection
: TIM17.CR2.CCPC ( -- x addr ) 0 bit TIM17.CR2 ; \ TIM17.CR2.CCPC, Capture/compare preloaded               control

\ TIM17.DIER (read-write) Reset:$0000
: TIM17.DIER.COMDE ( -- x addr ) 13 bit TIM17.DIER ; \ TIM17.DIER.COMDE, COM DMA request enable
: TIM17.DIER.CC1DE ( -- x addr ) 9 bit TIM17.DIER ; \ TIM17.DIER.CC1DE, Capture/Compare 1 DMA request               enable
: TIM17.DIER.UDE ( -- x addr ) 8 bit TIM17.DIER ; \ TIM17.DIER.UDE, Update DMA request enable
: TIM17.DIER.BIE ( -- x addr ) 7 bit TIM17.DIER ; \ TIM17.DIER.BIE, Break interrupt enable
: TIM17.DIER.COMIE ( -- x addr ) 5 bit TIM17.DIER ; \ TIM17.DIER.COMIE, COM interrupt enable
: TIM17.DIER.CC1IE ( -- x addr ) 1 bit TIM17.DIER ; \ TIM17.DIER.CC1IE, Capture/Compare 1 interrupt               enable
: TIM17.DIER.UIE ( -- x addr ) 0 bit TIM17.DIER ; \ TIM17.DIER.UIE, Update interrupt enable

\ TIM17.SR (read-write) Reset:$0000
: TIM17.SR.CC1OF ( -- x addr ) 9 bit TIM17.SR ; \ TIM17.SR.CC1OF, Capture/Compare 1 overcapture               flag
: TIM17.SR.BIF ( -- x addr ) 7 bit TIM17.SR ; \ TIM17.SR.BIF, Break interrupt flag
: TIM17.SR.COMIF ( -- x addr ) 5 bit TIM17.SR ; \ TIM17.SR.COMIF, COM interrupt flag
: TIM17.SR.CC1IF ( -- x addr ) 1 bit TIM17.SR ; \ TIM17.SR.CC1IF, Capture/compare 1 interrupt               flag
: TIM17.SR.UIF ( -- x addr ) 0 bit TIM17.SR ; \ TIM17.SR.UIF, Update interrupt flag

\ TIM17.EGR (write-only) Reset:$0000
: TIM17.EGR.BG ( -- x addr ) 7 bit TIM17.EGR ; \ TIM17.EGR.BG, Break generation
: TIM17.EGR.COMG ( -- x addr ) 5 bit TIM17.EGR ; \ TIM17.EGR.COMG, Capture/Compare control update               generation
: TIM17.EGR.CC1G ( -- x addr ) 1 bit TIM17.EGR ; \ TIM17.EGR.CC1G, Capture/compare 1               generation
: TIM17.EGR.UG ( -- x addr ) 0 bit TIM17.EGR ; \ TIM17.EGR.UG, Update generation

\ TIM17.CCMR1_Output (read-write) Reset:$00000000
: TIM17.CCMR1_Output.OC1M_2 ( -- x addr ) 16 bit TIM17.CCMR1_Output ; \ TIM17.CCMR1_Output.OC1M_2, Output Compare 1 mode
: TIM17.CCMR1_Output.OC1M ( %bbb -- x addr ) 4 lshift TIM17.CCMR1_Output ; \ TIM17.CCMR1_Output.OC1M, Output Compare 1 mode
: TIM17.CCMR1_Output.OC1PE ( -- x addr ) 3 bit TIM17.CCMR1_Output ; \ TIM17.CCMR1_Output.OC1PE, Output Compare 1 preload               enable
: TIM17.CCMR1_Output.OC1FE ( -- x addr ) 2 bit TIM17.CCMR1_Output ; \ TIM17.CCMR1_Output.OC1FE, Output Compare 1 fast               enable
: TIM17.CCMR1_Output.CC1S ( %bb -- x addr ) TIM17.CCMR1_Output ; \ TIM17.CCMR1_Output.CC1S, Capture/Compare 1               selection

\ TIM17.CCMR1_Input (read-write) Reset:$00000000
: TIM17.CCMR1_Input.IC1F ( %bbbb -- x addr ) 4 lshift TIM17.CCMR1_Input ; \ TIM17.CCMR1_Input.IC1F, Input capture 1 filter
: TIM17.CCMR1_Input.IC1PSC ( %bb -- x addr ) 2 lshift TIM17.CCMR1_Input ; \ TIM17.CCMR1_Input.IC1PSC, Input capture 1 prescaler
: TIM17.CCMR1_Input.CC1S ( %bb -- x addr ) TIM17.CCMR1_Input ; \ TIM17.CCMR1_Input.CC1S, Capture/Compare 1               selection

\ TIM17.CCER (read-write) Reset:$0000
: TIM17.CCER.CC1NP ( -- x addr ) 3 bit TIM17.CCER ; \ TIM17.CCER.CC1NP, Capture/Compare 1 output               Polarity
: TIM17.CCER.CC1NE ( -- x addr ) 2 bit TIM17.CCER ; \ TIM17.CCER.CC1NE, Capture/Compare 1 complementary output               enable
: TIM17.CCER.CC1P ( -- x addr ) 1 bit TIM17.CCER ; \ TIM17.CCER.CC1P, Capture/Compare 1 output               Polarity
: TIM17.CCER.CC1E ( -- x addr ) 0 bit TIM17.CCER ; \ TIM17.CCER.CC1E, Capture/Compare 1 output               enable

\ TIM17.CNT (multiple-access)  Reset:$00000000
: TIM17.CNT.CNT ( %bbbbbbbbbbbbbbbb -- x addr ) TIM17.CNT ; \ TIM17.CNT.CNT, counter value
: TIM17.CNT.UIFCPY ( -- x addr ) 31 bit TIM17.CNT ; \ TIM17.CNT.UIFCPY, UIF Copy

\ TIM17.PSC (read-write) Reset:$0000
: TIM17.PSC.PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIM17.PSC ; \ TIM17.PSC.PSC, Prescaler value

\ TIM17.ARR (read-write) Reset:$00000000
: TIM17.ARR.ARR ( %bbbbbbbbbbbbbbbb -- x addr ) TIM17.ARR ; \ TIM17.ARR.ARR, Auto-reload value

\ TIM17.RCR (read-write) Reset:$0000
: TIM17.RCR.REP ( %bbbbbbbb -- x addr ) TIM17.RCR ; \ TIM17.RCR.REP, Repetition counter value

\ TIM17.CCR1 (read-write) Reset:$00000000
: TIM17.CCR1.CCR1 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM17.CCR1 ; \ TIM17.CCR1.CCR1, Capture/Compare 1 value

\ TIM17.BDTR (read-write) Reset:$0000
: TIM17.BDTR.DTG ( %bbbbbbbb -- x addr ) TIM17.BDTR ; \ TIM17.BDTR.DTG, Dead-time generator setup
: TIM17.BDTR.LOCK ( %bb -- x addr ) 8 lshift TIM17.BDTR ; \ TIM17.BDTR.LOCK, Lock configuration
: TIM17.BDTR.OSSI ( -- x addr ) 10 bit TIM17.BDTR ; \ TIM17.BDTR.OSSI, Off-state selection for Idle               mode
: TIM17.BDTR.OSSR ( -- x addr ) 11 bit TIM17.BDTR ; \ TIM17.BDTR.OSSR, Off-state selection for Run               mode
: TIM17.BDTR.BKE ( -- x addr ) 12 bit TIM17.BDTR ; \ TIM17.BDTR.BKE, Break enable
: TIM17.BDTR.BKP ( -- x addr ) 13 bit TIM17.BDTR ; \ TIM17.BDTR.BKP, Break polarity
: TIM17.BDTR.AOE ( -- x addr ) 14 bit TIM17.BDTR ; \ TIM17.BDTR.AOE, Automatic output enable
: TIM17.BDTR.MOE ( -- x addr ) 15 bit TIM17.BDTR ; \ TIM17.BDTR.MOE, Main output enable
: TIM17.BDTR.BKF ( %bbbb -- x addr ) 16 lshift TIM17.BDTR ; \ TIM17.BDTR.BKF, Break filter
: TIM17.BDTR.BKDSRM ( -- x addr ) 26 bit TIM17.BDTR ; \ TIM17.BDTR.BKDSRM, Break Disarm
: TIM17.BDTR.BKBID ( -- x addr ) 28 bit TIM17.BDTR ; \ TIM17.BDTR.BKBID, Break Bidirectional

\ TIM17.DCR (read-write) Reset:$0000
: TIM17.DCR.DBL ( %bbbbb -- x addr ) 8 lshift TIM17.DCR ; \ TIM17.DCR.DBL, DMA burst length
: TIM17.DCR.DBA ( %bbbbb -- x addr ) TIM17.DCR ; \ TIM17.DCR.DBA, DMA base address

\ TIM17.DMAR (read-write) Reset:$0000
: TIM17.DMAR.DMAB ( %bbbbbbbbbbbbbbbb -- x addr ) TIM17.DMAR ; \ TIM17.DMAR.DMAB, DMA register for burst               accesses

\ TIM17.AF1 (read-write) Reset:$0000
: TIM17.AF1.BKINE ( -- x addr ) 0 bit TIM17.AF1 ; \ TIM17.AF1.BKINE, BRK BKIN input enable
: TIM17.AF1.BKCMP1E ( -- x addr ) 1 bit TIM17.AF1 ; \ TIM17.AF1.BKCMP1E, BRK COMP1 enable
: TIM17.AF1.BKCMP2E ( -- x addr ) 2 bit TIM17.AF1 ; \ TIM17.AF1.BKCMP2E, BRK COMP2 enable
: TIM17.AF1.BKDFBK1E ( -- x addr ) 8 bit TIM17.AF1 ; \ TIM17.AF1.BKDFBK1E, BRK DFSDM_BREAK1 enable
: TIM17.AF1.BKINP ( -- x addr ) 9 bit TIM17.AF1 ; \ TIM17.AF1.BKINP, BRK BKIN input polarity
: TIM17.AF1.BKCMP1P ( -- x addr ) 10 bit TIM17.AF1 ; \ TIM17.AF1.BKCMP1P, BRK COMP1 input polarity
: TIM17.AF1.BKCMP2P ( -- x addr ) 11 bit TIM17.AF1 ; \ TIM17.AF1.BKCMP2P, BRK COMP2 input polarit

\ TIM17.TISEL (read-write) Reset:$0000
: TIM17.TISEL.TI1SEL ( %bbbb -- x addr ) TIM17.TISEL ; \ TIM17.TISEL.TI1SEL, selects input

\ USART1.CR1 (read-write) Reset:$0000
: USART1.CR1.RXFFIE ( -- x addr ) 31 bit USART1.CR1 ; \ USART1.CR1.RXFFIE, RXFIFO Full interrupt               enable
: USART1.CR1.TXFEIE ( -- x addr ) 30 bit USART1.CR1 ; \ USART1.CR1.TXFEIE, TXFIFO empty interrupt               enable
: USART1.CR1.FIFOEN ( -- x addr ) 29 bit USART1.CR1 ; \ USART1.CR1.FIFOEN, FIFO mode enable
: USART1.CR1.M1 ( -- x addr ) 28 bit USART1.CR1 ; \ USART1.CR1.M1, Word length
: USART1.CR1.EOBIE ( -- x addr ) 27 bit USART1.CR1 ; \ USART1.CR1.EOBIE, End of Block interrupt               enable
: USART1.CR1.RTOIE ( -- x addr ) 26 bit USART1.CR1 ; \ USART1.CR1.RTOIE, Receiver timeout interrupt               enable
: USART1.CR1.DEAT ( %bbbbb -- x addr ) 21 lshift USART1.CR1 ; \ USART1.CR1.DEAT, DEAT
: USART1.CR1.DEDT ( %bbbbb -- x addr ) 16 lshift USART1.CR1 ; \ USART1.CR1.DEDT, DEDT
: USART1.CR1.OVER8 ( -- x addr ) 15 bit USART1.CR1 ; \ USART1.CR1.OVER8, Oversampling mode
: USART1.CR1.CMIE ( -- x addr ) 14 bit USART1.CR1 ; \ USART1.CR1.CMIE, Character match interrupt               enable
: USART1.CR1.MME ( -- x addr ) 13 bit USART1.CR1 ; \ USART1.CR1.MME, Mute mode enable
: USART1.CR1.M0 ( -- x addr ) 12 bit USART1.CR1 ; \ USART1.CR1.M0, Word length
: USART1.CR1.WAKE ( -- x addr ) 11 bit USART1.CR1 ; \ USART1.CR1.WAKE, Receiver wakeup method
: USART1.CR1.PCE ( -- x addr ) 10 bit USART1.CR1 ; \ USART1.CR1.PCE, Parity control enable
: USART1.CR1.PS ( -- x addr ) 9 bit USART1.CR1 ; \ USART1.CR1.PS, Parity selection
: USART1.CR1.PEIE ( -- x addr ) 8 bit USART1.CR1 ; \ USART1.CR1.PEIE, PE interrupt enable
: USART1.CR1.TXEIE ( -- x addr ) 7 bit USART1.CR1 ; \ USART1.CR1.TXEIE, interrupt enable
: USART1.CR1.TCIE ( -- x addr ) 6 bit USART1.CR1 ; \ USART1.CR1.TCIE, Transmission complete interrupt               enable
: USART1.CR1.RXNEIE ( -- x addr ) 5 bit USART1.CR1 ; \ USART1.CR1.RXNEIE, RXNE interrupt enable
: USART1.CR1.IDLEIE ( -- x addr ) 4 bit USART1.CR1 ; \ USART1.CR1.IDLEIE, IDLE interrupt enable
: USART1.CR1.TE ( -- x addr ) 3 bit USART1.CR1 ; \ USART1.CR1.TE, Transmitter enable
: USART1.CR1.RE ( -- x addr ) 2 bit USART1.CR1 ; \ USART1.CR1.RE, Receiver enable
: USART1.CR1.UESM ( -- x addr ) 1 bit USART1.CR1 ; \ USART1.CR1.UESM, USART enable in Stop mode
: USART1.CR1.UE ( -- x addr ) 0 bit USART1.CR1 ; \ USART1.CR1.UE, USART enable

\ USART1.CR2 (read-write) Reset:$0000
: USART1.CR2.ADD4_7 ( %bbbb -- x addr ) 28 lshift USART1.CR2 ; \ USART1.CR2.ADD4_7, Address of the USART node
: USART1.CR2.ADD0_3 ( %bbbb -- x addr ) 24 lshift USART1.CR2 ; \ USART1.CR2.ADD0_3, Address of the USART node
: USART1.CR2.RTOEN ( -- x addr ) 23 bit USART1.CR2 ; \ USART1.CR2.RTOEN, Receiver timeout enable
: USART1.CR2.ABRMOD ( %bb -- x addr ) 21 lshift USART1.CR2 ; \ USART1.CR2.ABRMOD, Auto baud rate mode
: USART1.CR2.ABREN ( -- x addr ) 20 bit USART1.CR2 ; \ USART1.CR2.ABREN, Auto baud rate enable
: USART1.CR2.MSBFIRST ( -- x addr ) 19 bit USART1.CR2 ; \ USART1.CR2.MSBFIRST, Most significant bit first
: USART1.CR2.TAINV ( -- x addr ) 18 bit USART1.CR2 ; \ USART1.CR2.TAINV, Binary data inversion
: USART1.CR2.TXINV ( -- x addr ) 17 bit USART1.CR2 ; \ USART1.CR2.TXINV, TX pin active level               inversion
: USART1.CR2.RXINV ( -- x addr ) 16 bit USART1.CR2 ; \ USART1.CR2.RXINV, RX pin active level               inversion
: USART1.CR2.SWAP ( -- x addr ) 15 bit USART1.CR2 ; \ USART1.CR2.SWAP, Swap TX/RX pins
: USART1.CR2.LINEN ( -- x addr ) 14 bit USART1.CR2 ; \ USART1.CR2.LINEN, LIN mode enable
: USART1.CR2.STOP ( %bb -- x addr ) 12 lshift USART1.CR2 ; \ USART1.CR2.STOP, STOP bits
: USART1.CR2.CLKEN ( -- x addr ) 11 bit USART1.CR2 ; \ USART1.CR2.CLKEN, Clock enable
: USART1.CR2.CPOL ( -- x addr ) 10 bit USART1.CR2 ; \ USART1.CR2.CPOL, Clock polarity
: USART1.CR2.CPHA ( -- x addr ) 9 bit USART1.CR2 ; \ USART1.CR2.CPHA, Clock phase
: USART1.CR2.LBCL ( -- x addr ) 8 bit USART1.CR2 ; \ USART1.CR2.LBCL, Last bit clock pulse
: USART1.CR2.LBDIE ( -- x addr ) 6 bit USART1.CR2 ; \ USART1.CR2.LBDIE, LIN break detection interrupt               enable
: USART1.CR2.LBDL ( -- x addr ) 5 bit USART1.CR2 ; \ USART1.CR2.LBDL, LIN break detection length
: USART1.CR2.ADDM7 ( -- x addr ) 4 bit USART1.CR2 ; \ USART1.CR2.ADDM7, 7-bit Address Detection/4-bit Address               Detection
: USART1.CR2.DIS_NSS ( -- x addr ) 3 bit USART1.CR2 ; \ USART1.CR2.DIS_NSS, When the DSI_NSS bit is set, the NSS pin               input will be ignored
: USART1.CR2.SLVEN ( -- x addr ) 0 bit USART1.CR2 ; \ USART1.CR2.SLVEN, Synchronous Slave mode               enable

\ USART1.CR3 (read-write) Reset:$0000
: USART1.CR3.TXFTCFG ( %bbb -- x addr ) 29 lshift USART1.CR3 ; \ USART1.CR3.TXFTCFG, TXFIFO threshold               configuration
: USART1.CR3.RXFTIE ( -- x addr ) 28 bit USART1.CR3 ; \ USART1.CR3.RXFTIE, RXFIFO threshold interrupt               enable
: USART1.CR3.RXFTCFG ( %bbb -- x addr ) 25 lshift USART1.CR3 ; \ USART1.CR3.RXFTCFG, Receive FIFO threshold               configuration
: USART1.CR3.TCBGTIE ( -- x addr ) 24 bit USART1.CR3 ; \ USART1.CR3.TCBGTIE, Tr Complete before guard time, interrupt               enable
: USART1.CR3.TXFTIE ( -- x addr ) 23 bit USART1.CR3 ; \ USART1.CR3.TXFTIE, threshold interrupt enable
: USART1.CR3.WUFIE ( -- x addr ) 22 bit USART1.CR3 ; \ USART1.CR3.WUFIE, Wakeup from Stop mode interrupt               enable
: USART1.CR3.WUS ( %bb -- x addr ) 20 lshift USART1.CR3 ; \ USART1.CR3.WUS, Wakeup from Stop mode interrupt flag               selection
: USART1.CR3.SCARCNT ( %bbb -- x addr ) 17 lshift USART1.CR3 ; \ USART1.CR3.SCARCNT, Smartcard auto-retry count
: USART1.CR3.DEP ( -- x addr ) 15 bit USART1.CR3 ; \ USART1.CR3.DEP, Driver enable polarity               selection
: USART1.CR3.DEM ( -- x addr ) 14 bit USART1.CR3 ; \ USART1.CR3.DEM, Driver enable mode
: USART1.CR3.DDRE ( -- x addr ) 13 bit USART1.CR3 ; \ USART1.CR3.DDRE, DMA Disable on Reception               Error
: USART1.CR3.OVRDIS ( -- x addr ) 12 bit USART1.CR3 ; \ USART1.CR3.OVRDIS, Overrun Disable
: USART1.CR3.ONEBIT ( -- x addr ) 11 bit USART1.CR3 ; \ USART1.CR3.ONEBIT, One sample bit method               enable
: USART1.CR3.CTSIE ( -- x addr ) 10 bit USART1.CR3 ; \ USART1.CR3.CTSIE, CTS interrupt enable
: USART1.CR3.CTSE ( -- x addr ) 9 bit USART1.CR3 ; \ USART1.CR3.CTSE, CTS enable
: USART1.CR3.RTSE ( -- x addr ) 8 bit USART1.CR3 ; \ USART1.CR3.RTSE, RTS enable
: USART1.CR3.DMAT ( -- x addr ) 7 bit USART1.CR3 ; \ USART1.CR3.DMAT, DMA enable transmitter
: USART1.CR3.DMAR ( -- x addr ) 6 bit USART1.CR3 ; \ USART1.CR3.DMAR, DMA enable receiver
: USART1.CR3.SCEN ( -- x addr ) 5 bit USART1.CR3 ; \ USART1.CR3.SCEN, Smartcard mode enable
: USART1.CR3.NACK ( -- x addr ) 4 bit USART1.CR3 ; \ USART1.CR3.NACK, Smartcard NACK enable
: USART1.CR3.HDSEL ( -- x addr ) 3 bit USART1.CR3 ; \ USART1.CR3.HDSEL, Half-duplex selection
: USART1.CR3.IRLP ( -- x addr ) 2 bit USART1.CR3 ; \ USART1.CR3.IRLP, Ir low-power
: USART1.CR3.IREN ( -- x addr ) 1 bit USART1.CR3 ; \ USART1.CR3.IREN, Ir mode enable
: USART1.CR3.EIE ( -- x addr ) 0 bit USART1.CR3 ; \ USART1.CR3.EIE, Error interrupt enable

\ USART1.BRR (read-write) Reset:$0000
: USART1.BRR.BRR_4_15 ( %bbbbbbbbbbb -- x addr ) 4 lshift USART1.BRR ; \ USART1.BRR.BRR_4_15, BRR_4_15
: USART1.BRR.BRR_0_3 ( %bbbb -- x addr ) USART1.BRR ; \ USART1.BRR.BRR_0_3, BRR_0_3

\ USART1.GTPR (read-write) Reset:$0000
: USART1.GTPR.GT ( %bbbbbbbb -- x addr ) 8 lshift USART1.GTPR ; \ USART1.GTPR.GT, Guard time value
: USART1.GTPR.PSC ( %bbbbbbbb -- x addr ) USART1.GTPR ; \ USART1.GTPR.PSC, Prescaler value

\ USART1.RTOR (read-write) Reset:$0000
: USART1.RTOR.BLEN ( %bbbbbbbb -- x addr ) 24 lshift USART1.RTOR ; \ USART1.RTOR.BLEN, Block Length
: USART1.RTOR.RTO ( %bbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) USART1.RTOR ; \ USART1.RTOR.RTO, Receiver timeout value

\ USART1.RQR (write-only) Reset:$0000
: USART1.RQR.TXFRQ ( -- x addr ) 4 bit USART1.RQR ; \ USART1.RQR.TXFRQ, Transmit data flush               request
: USART1.RQR.RXFRQ ( -- x addr ) 3 bit USART1.RQR ; \ USART1.RQR.RXFRQ, Receive data flush request
: USART1.RQR.MMRQ ( -- x addr ) 2 bit USART1.RQR ; \ USART1.RQR.MMRQ, Mute mode request
: USART1.RQR.SBKRQ ( -- x addr ) 1 bit USART1.RQR ; \ USART1.RQR.SBKRQ, Send break request
: USART1.RQR.ABRRQ ( -- x addr ) 0 bit USART1.RQR ; \ USART1.RQR.ABRRQ, Auto baud rate request

\ USART1.ISR (read-only) Reset:$00C0
: USART1.ISR.TXFT? ( --  1|0 ) 27 bit USART1.ISR bit@ ; \ USART1.ISR.TXFT, TXFIFO threshold flag
: USART1.ISR.RXFT? ( --  1|0 ) 26 bit USART1.ISR bit@ ; \ USART1.ISR.RXFT, RXFIFO threshold flag
: USART1.ISR.TCBGT? ( --  1|0 ) 25 bit USART1.ISR bit@ ; \ USART1.ISR.TCBGT, Transmission complete before guard time               flag
: USART1.ISR.RXFF? ( --  1|0 ) 24 bit USART1.ISR bit@ ; \ USART1.ISR.RXFF, RXFIFO Full
: USART1.ISR.TXFE? ( --  1|0 ) 23 bit USART1.ISR bit@ ; \ USART1.ISR.TXFE, TXFIFO Empty
: USART1.ISR.REACK? ( --  1|0 ) 22 bit USART1.ISR bit@ ; \ USART1.ISR.REACK, REACK
: USART1.ISR.TEACK? ( --  1|0 ) 21 bit USART1.ISR bit@ ; \ USART1.ISR.TEACK, TEACK
: USART1.ISR.WUF? ( --  1|0 ) 20 bit USART1.ISR bit@ ; \ USART1.ISR.WUF, WUF
: USART1.ISR.RWU? ( --  1|0 ) 19 bit USART1.ISR bit@ ; \ USART1.ISR.RWU, RWU
: USART1.ISR.SBKF? ( --  1|0 ) 18 bit USART1.ISR bit@ ; \ USART1.ISR.SBKF, SBKF
: USART1.ISR.CMF? ( --  1|0 ) 17 bit USART1.ISR bit@ ; \ USART1.ISR.CMF, CMF
: USART1.ISR.BUSY? ( --  1|0 ) 16 bit USART1.ISR bit@ ; \ USART1.ISR.BUSY, BUSY
: USART1.ISR.ABRF? ( --  1|0 ) 15 bit USART1.ISR bit@ ; \ USART1.ISR.ABRF, ABRF
: USART1.ISR.ABRE? ( --  1|0 ) 14 bit USART1.ISR bit@ ; \ USART1.ISR.ABRE, ABRE
: USART1.ISR.UDR? ( --  1|0 ) 13 bit USART1.ISR bit@ ; \ USART1.ISR.UDR, SPI slave underrun error               flag
: USART1.ISR.EOBF? ( --  1|0 ) 12 bit USART1.ISR bit@ ; \ USART1.ISR.EOBF, EOBF
: USART1.ISR.RTOF? ( --  1|0 ) 11 bit USART1.ISR bit@ ; \ USART1.ISR.RTOF, RTOF
: USART1.ISR.CTS? ( --  1|0 ) 10 bit USART1.ISR bit@ ; \ USART1.ISR.CTS, CTS
: USART1.ISR.CTSIF? ( --  1|0 ) 9 bit USART1.ISR bit@ ; \ USART1.ISR.CTSIF, CTSIF
: USART1.ISR.LBDF? ( --  1|0 ) 8 bit USART1.ISR bit@ ; \ USART1.ISR.LBDF, LBDF
: USART1.ISR.TXE? ( --  1|0 ) 7 bit USART1.ISR bit@ ; \ USART1.ISR.TXE, TXE
: USART1.ISR.TC? ( --  1|0 ) 6 bit USART1.ISR bit@ ; \ USART1.ISR.TC, TC
: USART1.ISR.RXNE? ( --  1|0 ) 5 bit USART1.ISR bit@ ; \ USART1.ISR.RXNE, RXNE
: USART1.ISR.IDLE? ( --  1|0 ) 4 bit USART1.ISR bit@ ; \ USART1.ISR.IDLE, IDLE
: USART1.ISR.ORE? ( --  1|0 ) 3 bit USART1.ISR bit@ ; \ USART1.ISR.ORE, ORE
: USART1.ISR.NF? ( --  1|0 ) 2 bit USART1.ISR bit@ ; \ USART1.ISR.NF, NF
: USART1.ISR.FE? ( --  1|0 ) 1 bit USART1.ISR bit@ ; \ USART1.ISR.FE, FE
: USART1.ISR.PE? ( --  1|0 ) 0 bit USART1.ISR bit@ ; \ USART1.ISR.PE, PE

\ USART1.ICR (write-only) Reset:$0000
: USART1.ICR.WUCF ( -- x addr ) 20 bit USART1.ICR ; \ USART1.ICR.WUCF, Wakeup from Stop mode clear               flag
: USART1.ICR.CMCF ( -- x addr ) 17 bit USART1.ICR ; \ USART1.ICR.CMCF, Character match clear flag
: USART1.ICR.UDRCF ( -- x addr ) 13 bit USART1.ICR ; \ USART1.ICR.UDRCF, SPI slave underrun clear               flag
: USART1.ICR.EOBCF ( -- x addr ) 12 bit USART1.ICR ; \ USART1.ICR.EOBCF, End of block clear flag
: USART1.ICR.RTOCF ( -- x addr ) 11 bit USART1.ICR ; \ USART1.ICR.RTOCF, Receiver timeout clear               flag
: USART1.ICR.CTSCF ( -- x addr ) 9 bit USART1.ICR ; \ USART1.ICR.CTSCF, CTS clear flag
: USART1.ICR.LBDCF ( -- x addr ) 8 bit USART1.ICR ; \ USART1.ICR.LBDCF, LIN break detection clear               flag
: USART1.ICR.TCBGTCF ( -- x addr ) 7 bit USART1.ICR ; \ USART1.ICR.TCBGTCF, Transmission complete before Guard time               clear flag
: USART1.ICR.TCCF ( -- x addr ) 6 bit USART1.ICR ; \ USART1.ICR.TCCF, Transmission complete clear               flag
: USART1.ICR.TXFECF ( -- x addr ) 5 bit USART1.ICR ; \ USART1.ICR.TXFECF, TXFIFO empty clear flag
: USART1.ICR.IDLECF ( -- x addr ) 4 bit USART1.ICR ; \ USART1.ICR.IDLECF, Idle line detected clear               flag
: USART1.ICR.ORECF ( -- x addr ) 3 bit USART1.ICR ; \ USART1.ICR.ORECF, Overrun error clear flag
: USART1.ICR.NCF ( -- x addr ) 2 bit USART1.ICR ; \ USART1.ICR.NCF, Noise detected clear flag
: USART1.ICR.FECF ( -- x addr ) 1 bit USART1.ICR ; \ USART1.ICR.FECF, Framing error clear flag
: USART1.ICR.PECF ( -- x addr ) 0 bit USART1.ICR ; \ USART1.ICR.PECF, Parity error clear flag

\ USART1.RDR (read-only) Reset:$0000
: USART1.RDR.RDR? ( --  x ) USART1.RDR @ ; \ USART1.RDR.RDR, Receive data value

\ USART1.TDR (read-write) Reset:$0000
: USART1.TDR.TDR ( %bbbbbbbbb -- x addr ) USART1.TDR ; \ USART1.TDR.TDR, Transmit data value

\ USART1.PRESC (read-write) Reset:$0000
: USART1.PRESC.PRESCALER ( %bbbb -- x addr ) USART1.PRESC ; \ USART1.PRESC.PRESCALER, Clock prescaler

\ USART2.CR1 (read-write) Reset:$0000
: USART2.CR1.RXFFIE ( -- x addr ) 31 bit USART2.CR1 ; \ USART2.CR1.RXFFIE, RXFIFO Full interrupt               enable
: USART2.CR1.TXFEIE ( -- x addr ) 30 bit USART2.CR1 ; \ USART2.CR1.TXFEIE, TXFIFO empty interrupt               enable
: USART2.CR1.FIFOEN ( -- x addr ) 29 bit USART2.CR1 ; \ USART2.CR1.FIFOEN, FIFO mode enable
: USART2.CR1.M1 ( -- x addr ) 28 bit USART2.CR1 ; \ USART2.CR1.M1, Word length
: USART2.CR1.EOBIE ( -- x addr ) 27 bit USART2.CR1 ; \ USART2.CR1.EOBIE, End of Block interrupt               enable
: USART2.CR1.RTOIE ( -- x addr ) 26 bit USART2.CR1 ; \ USART2.CR1.RTOIE, Receiver timeout interrupt               enable
: USART2.CR1.DEAT ( %bbbbb -- x addr ) 21 lshift USART2.CR1 ; \ USART2.CR1.DEAT, DEAT
: USART2.CR1.DEDT ( %bbbbb -- x addr ) 16 lshift USART2.CR1 ; \ USART2.CR1.DEDT, DEDT
: USART2.CR1.OVER8 ( -- x addr ) 15 bit USART2.CR1 ; \ USART2.CR1.OVER8, Oversampling mode
: USART2.CR1.CMIE ( -- x addr ) 14 bit USART2.CR1 ; \ USART2.CR1.CMIE, Character match interrupt               enable
: USART2.CR1.MME ( -- x addr ) 13 bit USART2.CR1 ; \ USART2.CR1.MME, Mute mode enable
: USART2.CR1.M0 ( -- x addr ) 12 bit USART2.CR1 ; \ USART2.CR1.M0, Word length
: USART2.CR1.WAKE ( -- x addr ) 11 bit USART2.CR1 ; \ USART2.CR1.WAKE, Receiver wakeup method
: USART2.CR1.PCE ( -- x addr ) 10 bit USART2.CR1 ; \ USART2.CR1.PCE, Parity control enable
: USART2.CR1.PS ( -- x addr ) 9 bit USART2.CR1 ; \ USART2.CR1.PS, Parity selection
: USART2.CR1.PEIE ( -- x addr ) 8 bit USART2.CR1 ; \ USART2.CR1.PEIE, PE interrupt enable
: USART2.CR1.TXEIE ( -- x addr ) 7 bit USART2.CR1 ; \ USART2.CR1.TXEIE, interrupt enable
: USART2.CR1.TCIE ( -- x addr ) 6 bit USART2.CR1 ; \ USART2.CR1.TCIE, Transmission complete interrupt               enable
: USART2.CR1.RXNEIE ( -- x addr ) 5 bit USART2.CR1 ; \ USART2.CR1.RXNEIE, RXNE interrupt enable
: USART2.CR1.IDLEIE ( -- x addr ) 4 bit USART2.CR1 ; \ USART2.CR1.IDLEIE, IDLE interrupt enable
: USART2.CR1.TE ( -- x addr ) 3 bit USART2.CR1 ; \ USART2.CR1.TE, Transmitter enable
: USART2.CR1.RE ( -- x addr ) 2 bit USART2.CR1 ; \ USART2.CR1.RE, Receiver enable
: USART2.CR1.UESM ( -- x addr ) 1 bit USART2.CR1 ; \ USART2.CR1.UESM, USART enable in Stop mode
: USART2.CR1.UE ( -- x addr ) 0 bit USART2.CR1 ; \ USART2.CR1.UE, USART enable

\ USART2.CR2 (read-write) Reset:$0000
: USART2.CR2.ADD4_7 ( %bbbb -- x addr ) 28 lshift USART2.CR2 ; \ USART2.CR2.ADD4_7, Address of the USART node
: USART2.CR2.ADD0_3 ( %bbbb -- x addr ) 24 lshift USART2.CR2 ; \ USART2.CR2.ADD0_3, Address of the USART node
: USART2.CR2.RTOEN ( -- x addr ) 23 bit USART2.CR2 ; \ USART2.CR2.RTOEN, Receiver timeout enable
: USART2.CR2.ABRMOD ( %bb -- x addr ) 21 lshift USART2.CR2 ; \ USART2.CR2.ABRMOD, Auto baud rate mode
: USART2.CR2.ABREN ( -- x addr ) 20 bit USART2.CR2 ; \ USART2.CR2.ABREN, Auto baud rate enable
: USART2.CR2.MSBFIRST ( -- x addr ) 19 bit USART2.CR2 ; \ USART2.CR2.MSBFIRST, Most significant bit first
: USART2.CR2.TAINV ( -- x addr ) 18 bit USART2.CR2 ; \ USART2.CR2.TAINV, Binary data inversion
: USART2.CR2.TXINV ( -- x addr ) 17 bit USART2.CR2 ; \ USART2.CR2.TXINV, TX pin active level               inversion
: USART2.CR2.RXINV ( -- x addr ) 16 bit USART2.CR2 ; \ USART2.CR2.RXINV, RX pin active level               inversion
: USART2.CR2.SWAP ( -- x addr ) 15 bit USART2.CR2 ; \ USART2.CR2.SWAP, Swap TX/RX pins
: USART2.CR2.LINEN ( -- x addr ) 14 bit USART2.CR2 ; \ USART2.CR2.LINEN, LIN mode enable
: USART2.CR2.STOP ( %bb -- x addr ) 12 lshift USART2.CR2 ; \ USART2.CR2.STOP, STOP bits
: USART2.CR2.CLKEN ( -- x addr ) 11 bit USART2.CR2 ; \ USART2.CR2.CLKEN, Clock enable
: USART2.CR2.CPOL ( -- x addr ) 10 bit USART2.CR2 ; \ USART2.CR2.CPOL, Clock polarity
: USART2.CR2.CPHA ( -- x addr ) 9 bit USART2.CR2 ; \ USART2.CR2.CPHA, Clock phase
: USART2.CR2.LBCL ( -- x addr ) 8 bit USART2.CR2 ; \ USART2.CR2.LBCL, Last bit clock pulse
: USART2.CR2.LBDIE ( -- x addr ) 6 bit USART2.CR2 ; \ USART2.CR2.LBDIE, LIN break detection interrupt               enable
: USART2.CR2.LBDL ( -- x addr ) 5 bit USART2.CR2 ; \ USART2.CR2.LBDL, LIN break detection length
: USART2.CR2.ADDM7 ( -- x addr ) 4 bit USART2.CR2 ; \ USART2.CR2.ADDM7, 7-bit Address Detection/4-bit Address               Detection
: USART2.CR2.DIS_NSS ( -- x addr ) 3 bit USART2.CR2 ; \ USART2.CR2.DIS_NSS, When the DSI_NSS bit is set, the NSS pin               input will be ignored
: USART2.CR2.SLVEN ( -- x addr ) 0 bit USART2.CR2 ; \ USART2.CR2.SLVEN, Synchronous Slave mode               enable

\ USART2.CR3 (read-write) Reset:$0000
: USART2.CR3.TXFTCFG ( %bbb -- x addr ) 29 lshift USART2.CR3 ; \ USART2.CR3.TXFTCFG, TXFIFO threshold               configuration
: USART2.CR3.RXFTIE ( -- x addr ) 28 bit USART2.CR3 ; \ USART2.CR3.RXFTIE, RXFIFO threshold interrupt               enable
: USART2.CR3.RXFTCFG ( %bbb -- x addr ) 25 lshift USART2.CR3 ; \ USART2.CR3.RXFTCFG, Receive FIFO threshold               configuration
: USART2.CR3.TCBGTIE ( -- x addr ) 24 bit USART2.CR3 ; \ USART2.CR3.TCBGTIE, Tr Complete before guard time, interrupt               enable
: USART2.CR3.TXFTIE ( -- x addr ) 23 bit USART2.CR3 ; \ USART2.CR3.TXFTIE, threshold interrupt enable
: USART2.CR3.WUFIE ( -- x addr ) 22 bit USART2.CR3 ; \ USART2.CR3.WUFIE, Wakeup from Stop mode interrupt               enable
: USART2.CR3.WUS ( %bb -- x addr ) 20 lshift USART2.CR3 ; \ USART2.CR3.WUS, Wakeup from Stop mode interrupt flag               selection
: USART2.CR3.SCARCNT ( %bbb -- x addr ) 17 lshift USART2.CR3 ; \ USART2.CR3.SCARCNT, Smartcard auto-retry count
: USART2.CR3.DEP ( -- x addr ) 15 bit USART2.CR3 ; \ USART2.CR3.DEP, Driver enable polarity               selection
: USART2.CR3.DEM ( -- x addr ) 14 bit USART2.CR3 ; \ USART2.CR3.DEM, Driver enable mode
: USART2.CR3.DDRE ( -- x addr ) 13 bit USART2.CR3 ; \ USART2.CR3.DDRE, DMA Disable on Reception               Error
: USART2.CR3.OVRDIS ( -- x addr ) 12 bit USART2.CR3 ; \ USART2.CR3.OVRDIS, Overrun Disable
: USART2.CR3.ONEBIT ( -- x addr ) 11 bit USART2.CR3 ; \ USART2.CR3.ONEBIT, One sample bit method               enable
: USART2.CR3.CTSIE ( -- x addr ) 10 bit USART2.CR3 ; \ USART2.CR3.CTSIE, CTS interrupt enable
: USART2.CR3.CTSE ( -- x addr ) 9 bit USART2.CR3 ; \ USART2.CR3.CTSE, CTS enable
: USART2.CR3.RTSE ( -- x addr ) 8 bit USART2.CR3 ; \ USART2.CR3.RTSE, RTS enable
: USART2.CR3.DMAT ( -- x addr ) 7 bit USART2.CR3 ; \ USART2.CR3.DMAT, DMA enable transmitter
: USART2.CR3.DMAR ( -- x addr ) 6 bit USART2.CR3 ; \ USART2.CR3.DMAR, DMA enable receiver
: USART2.CR3.SCEN ( -- x addr ) 5 bit USART2.CR3 ; \ USART2.CR3.SCEN, Smartcard mode enable
: USART2.CR3.NACK ( -- x addr ) 4 bit USART2.CR3 ; \ USART2.CR3.NACK, Smartcard NACK enable
: USART2.CR3.HDSEL ( -- x addr ) 3 bit USART2.CR3 ; \ USART2.CR3.HDSEL, Half-duplex selection
: USART2.CR3.IRLP ( -- x addr ) 2 bit USART2.CR3 ; \ USART2.CR3.IRLP, Ir low-power
: USART2.CR3.IREN ( -- x addr ) 1 bit USART2.CR3 ; \ USART2.CR3.IREN, Ir mode enable
: USART2.CR3.EIE ( -- x addr ) 0 bit USART2.CR3 ; \ USART2.CR3.EIE, Error interrupt enable

\ USART2.BRR (read-write) Reset:$0000
: USART2.BRR.BRR_4_15 ( %bbbbbbbbbbb -- x addr ) 4 lshift USART2.BRR ; \ USART2.BRR.BRR_4_15, BRR_4_15
: USART2.BRR.BRR_0_3 ( %bbbb -- x addr ) USART2.BRR ; \ USART2.BRR.BRR_0_3, BRR_0_3

\ USART2.GTPR (read-write) Reset:$0000
: USART2.GTPR.GT ( %bbbbbbbb -- x addr ) 8 lshift USART2.GTPR ; \ USART2.GTPR.GT, Guard time value
: USART2.GTPR.PSC ( %bbbbbbbb -- x addr ) USART2.GTPR ; \ USART2.GTPR.PSC, Prescaler value

\ USART2.RTOR (read-write) Reset:$0000
: USART2.RTOR.BLEN ( %bbbbbbbb -- x addr ) 24 lshift USART2.RTOR ; \ USART2.RTOR.BLEN, Block Length
: USART2.RTOR.RTO ( %bbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) USART2.RTOR ; \ USART2.RTOR.RTO, Receiver timeout value

\ USART2.RQR (write-only) Reset:$0000
: USART2.RQR.TXFRQ ( -- x addr ) 4 bit USART2.RQR ; \ USART2.RQR.TXFRQ, Transmit data flush               request
: USART2.RQR.RXFRQ ( -- x addr ) 3 bit USART2.RQR ; \ USART2.RQR.RXFRQ, Receive data flush request
: USART2.RQR.MMRQ ( -- x addr ) 2 bit USART2.RQR ; \ USART2.RQR.MMRQ, Mute mode request
: USART2.RQR.SBKRQ ( -- x addr ) 1 bit USART2.RQR ; \ USART2.RQR.SBKRQ, Send break request
: USART2.RQR.ABRRQ ( -- x addr ) 0 bit USART2.RQR ; \ USART2.RQR.ABRRQ, Auto baud rate request

\ USART2.ISR (read-only) Reset:$00C0
: USART2.ISR.TXFT? ( --  1|0 ) 27 bit USART2.ISR bit@ ; \ USART2.ISR.TXFT, TXFIFO threshold flag
: USART2.ISR.RXFT? ( --  1|0 ) 26 bit USART2.ISR bit@ ; \ USART2.ISR.RXFT, RXFIFO threshold flag
: USART2.ISR.TCBGT? ( --  1|0 ) 25 bit USART2.ISR bit@ ; \ USART2.ISR.TCBGT, Transmission complete before guard time               flag
: USART2.ISR.RXFF? ( --  1|0 ) 24 bit USART2.ISR bit@ ; \ USART2.ISR.RXFF, RXFIFO Full
: USART2.ISR.TXFE? ( --  1|0 ) 23 bit USART2.ISR bit@ ; \ USART2.ISR.TXFE, TXFIFO Empty
: USART2.ISR.REACK? ( --  1|0 ) 22 bit USART2.ISR bit@ ; \ USART2.ISR.REACK, REACK
: USART2.ISR.TEACK? ( --  1|0 ) 21 bit USART2.ISR bit@ ; \ USART2.ISR.TEACK, TEACK
: USART2.ISR.WUF? ( --  1|0 ) 20 bit USART2.ISR bit@ ; \ USART2.ISR.WUF, WUF
: USART2.ISR.RWU? ( --  1|0 ) 19 bit USART2.ISR bit@ ; \ USART2.ISR.RWU, RWU
: USART2.ISR.SBKF? ( --  1|0 ) 18 bit USART2.ISR bit@ ; \ USART2.ISR.SBKF, SBKF
: USART2.ISR.CMF? ( --  1|0 ) 17 bit USART2.ISR bit@ ; \ USART2.ISR.CMF, CMF
: USART2.ISR.BUSY? ( --  1|0 ) 16 bit USART2.ISR bit@ ; \ USART2.ISR.BUSY, BUSY
: USART2.ISR.ABRF? ( --  1|0 ) 15 bit USART2.ISR bit@ ; \ USART2.ISR.ABRF, ABRF
: USART2.ISR.ABRE? ( --  1|0 ) 14 bit USART2.ISR bit@ ; \ USART2.ISR.ABRE, ABRE
: USART2.ISR.UDR? ( --  1|0 ) 13 bit USART2.ISR bit@ ; \ USART2.ISR.UDR, SPI slave underrun error               flag
: USART2.ISR.EOBF? ( --  1|0 ) 12 bit USART2.ISR bit@ ; \ USART2.ISR.EOBF, EOBF
: USART2.ISR.RTOF? ( --  1|0 ) 11 bit USART2.ISR bit@ ; \ USART2.ISR.RTOF, RTOF
: USART2.ISR.CTS? ( --  1|0 ) 10 bit USART2.ISR bit@ ; \ USART2.ISR.CTS, CTS
: USART2.ISR.CTSIF? ( --  1|0 ) 9 bit USART2.ISR bit@ ; \ USART2.ISR.CTSIF, CTSIF
: USART2.ISR.LBDF? ( --  1|0 ) 8 bit USART2.ISR bit@ ; \ USART2.ISR.LBDF, LBDF
: USART2.ISR.TXE? ( --  1|0 ) 7 bit USART2.ISR bit@ ; \ USART2.ISR.TXE, TXE
: USART2.ISR.TC? ( --  1|0 ) 6 bit USART2.ISR bit@ ; \ USART2.ISR.TC, TC
: USART2.ISR.RXNE? ( --  1|0 ) 5 bit USART2.ISR bit@ ; \ USART2.ISR.RXNE, RXNE
: USART2.ISR.IDLE? ( --  1|0 ) 4 bit USART2.ISR bit@ ; \ USART2.ISR.IDLE, IDLE
: USART2.ISR.ORE? ( --  1|0 ) 3 bit USART2.ISR bit@ ; \ USART2.ISR.ORE, ORE
: USART2.ISR.NF? ( --  1|0 ) 2 bit USART2.ISR bit@ ; \ USART2.ISR.NF, NF
: USART2.ISR.FE? ( --  1|0 ) 1 bit USART2.ISR bit@ ; \ USART2.ISR.FE, FE
: USART2.ISR.PE? ( --  1|0 ) 0 bit USART2.ISR bit@ ; \ USART2.ISR.PE, PE

\ USART2.ICR (write-only) Reset:$0000
: USART2.ICR.WUCF ( -- x addr ) 20 bit USART2.ICR ; \ USART2.ICR.WUCF, Wakeup from Stop mode clear               flag
: USART2.ICR.CMCF ( -- x addr ) 17 bit USART2.ICR ; \ USART2.ICR.CMCF, Character match clear flag
: USART2.ICR.UDRCF ( -- x addr ) 13 bit USART2.ICR ; \ USART2.ICR.UDRCF, SPI slave underrun clear               flag
: USART2.ICR.EOBCF ( -- x addr ) 12 bit USART2.ICR ; \ USART2.ICR.EOBCF, End of block clear flag
: USART2.ICR.RTOCF ( -- x addr ) 11 bit USART2.ICR ; \ USART2.ICR.RTOCF, Receiver timeout clear               flag
: USART2.ICR.CTSCF ( -- x addr ) 9 bit USART2.ICR ; \ USART2.ICR.CTSCF, CTS clear flag
: USART2.ICR.LBDCF ( -- x addr ) 8 bit USART2.ICR ; \ USART2.ICR.LBDCF, LIN break detection clear               flag
: USART2.ICR.TCBGTCF ( -- x addr ) 7 bit USART2.ICR ; \ USART2.ICR.TCBGTCF, Transmission complete before Guard time               clear flag
: USART2.ICR.TCCF ( -- x addr ) 6 bit USART2.ICR ; \ USART2.ICR.TCCF, Transmission complete clear               flag
: USART2.ICR.TXFECF ( -- x addr ) 5 bit USART2.ICR ; \ USART2.ICR.TXFECF, TXFIFO empty clear flag
: USART2.ICR.IDLECF ( -- x addr ) 4 bit USART2.ICR ; \ USART2.ICR.IDLECF, Idle line detected clear               flag
: USART2.ICR.ORECF ( -- x addr ) 3 bit USART2.ICR ; \ USART2.ICR.ORECF, Overrun error clear flag
: USART2.ICR.NCF ( -- x addr ) 2 bit USART2.ICR ; \ USART2.ICR.NCF, Noise detected clear flag
: USART2.ICR.FECF ( -- x addr ) 1 bit USART2.ICR ; \ USART2.ICR.FECF, Framing error clear flag
: USART2.ICR.PECF ( -- x addr ) 0 bit USART2.ICR ; \ USART2.ICR.PECF, Parity error clear flag

\ USART2.RDR (read-only) Reset:$0000
: USART2.RDR.RDR? ( --  x ) USART2.RDR @ ; \ USART2.RDR.RDR, Receive data value

\ USART2.TDR (read-write) Reset:$0000
: USART2.TDR.TDR ( %bbbbbbbbb -- x addr ) USART2.TDR ; \ USART2.TDR.TDR, Transmit data value

\ USART2.PRESC (read-write) Reset:$0000
: USART2.PRESC.PRESCALER ( %bbbb -- x addr ) USART2.PRESC ; \ USART2.PRESC.PRESCALER, Clock prescaler

\ SPI1.CR1 (read-write) Reset:$0000
: SPI1.CR1.BIDIMODE ( -- x addr ) 15 bit SPI1.CR1 ; \ SPI1.CR1.BIDIMODE, Bidirectional data mode               enable
: SPI1.CR1.BIDIOE ( -- x addr ) 14 bit SPI1.CR1 ; \ SPI1.CR1.BIDIOE, Output enable in bidirectional               mode
: SPI1.CR1.CRCEN ( -- x addr ) 13 bit SPI1.CR1 ; \ SPI1.CR1.CRCEN, Hardware CRC calculation               enable
: SPI1.CR1.CRCNEXT ( -- x addr ) 12 bit SPI1.CR1 ; \ SPI1.CR1.CRCNEXT, CRC transfer next
: SPI1.CR1.DFF ( -- x addr ) 11 bit SPI1.CR1 ; \ SPI1.CR1.DFF, Data frame format
: SPI1.CR1.RXONLY ( -- x addr ) 10 bit SPI1.CR1 ; \ SPI1.CR1.RXONLY, Receive only
: SPI1.CR1.SSM ( -- x addr ) 9 bit SPI1.CR1 ; \ SPI1.CR1.SSM, Software slave management
: SPI1.CR1.SSI ( -- x addr ) 8 bit SPI1.CR1 ; \ SPI1.CR1.SSI, Internal slave select
: SPI1.CR1.LSBFIRST ( -- x addr ) 7 bit SPI1.CR1 ; \ SPI1.CR1.LSBFIRST, Frame format
: SPI1.CR1.SPE ( -- x addr ) 6 bit SPI1.CR1 ; \ SPI1.CR1.SPE, SPI enable
: SPI1.CR1.BR ( %bbb -- x addr ) 3 lshift SPI1.CR1 ; \ SPI1.CR1.BR, Baud rate control
: SPI1.CR1.MSTR ( -- x addr ) 2 bit SPI1.CR1 ; \ SPI1.CR1.MSTR, Master selection
: SPI1.CR1.CPOL ( -- x addr ) 1 bit SPI1.CR1 ; \ SPI1.CR1.CPOL, Clock polarity
: SPI1.CR1.CPHA ( -- x addr ) 0 bit SPI1.CR1 ; \ SPI1.CR1.CPHA, Clock phase

\ SPI1.CR2 (read-write) Reset:$0000
: SPI1.CR2.RXDMAEN ( -- x addr ) 0 bit SPI1.CR2 ; \ SPI1.CR2.RXDMAEN, Rx buffer DMA enable
: SPI1.CR2.TXDMAEN ( -- x addr ) 1 bit SPI1.CR2 ; \ SPI1.CR2.TXDMAEN, Tx buffer DMA enable
: SPI1.CR2.SSOE ( -- x addr ) 2 bit SPI1.CR2 ; \ SPI1.CR2.SSOE, SS output enable
: SPI1.CR2.NSSP ( -- x addr ) 3 bit SPI1.CR2 ; \ SPI1.CR2.NSSP, NSS pulse management
: SPI1.CR2.FRF ( -- x addr ) 4 bit SPI1.CR2 ; \ SPI1.CR2.FRF, Frame format
: SPI1.CR2.ERRIE ( -- x addr ) 5 bit SPI1.CR2 ; \ SPI1.CR2.ERRIE, Error interrupt enable
: SPI1.CR2.RXNEIE ( -- x addr ) 6 bit SPI1.CR2 ; \ SPI1.CR2.RXNEIE, RX buffer not empty interrupt               enable
: SPI1.CR2.TXEIE ( -- x addr ) 7 bit SPI1.CR2 ; \ SPI1.CR2.TXEIE, Tx buffer empty interrupt               enable
: SPI1.CR2.DS ( %bbbb -- x addr ) 8 lshift SPI1.CR2 ; \ SPI1.CR2.DS, Data size
: SPI1.CR2.FRXTH ( -- x addr ) 12 bit SPI1.CR2 ; \ SPI1.CR2.FRXTH, FIFO reception threshold
: SPI1.CR2.LDMA_RX ( -- x addr ) 13 bit SPI1.CR2 ; \ SPI1.CR2.LDMA_RX, Last DMA transfer for               reception
: SPI1.CR2.LDMA_TX ( -- x addr ) 14 bit SPI1.CR2 ; \ SPI1.CR2.LDMA_TX, Last DMA transfer for               transmission

\ SPI1.SR (multiple-access)  Reset:$0002
: SPI1.SR.RXNE ( -- x addr ) 0 bit SPI1.SR ; \ SPI1.SR.RXNE, Receive buffer not empty
: SPI1.SR.TXE ( -- x addr ) 1 bit SPI1.SR ; \ SPI1.SR.TXE, Transmit buffer empty
: SPI1.SR.CHSIDE ( -- x addr ) 2 bit SPI1.SR ; \ SPI1.SR.CHSIDE, Channel side
: SPI1.SR.UDR? ( -- 1|0 ) 3 bit SPI1.SR bit@ ; \ SPI1.SR.UDR, Underrun flag
: SPI1.SR.CRCERR? ( -- 1|0 ) 4 bit SPI1.SR bit@ ; \ SPI1.SR.CRCERR, CRC error flag
: SPI1.SR.MODF ( -- x addr ) 5 bit SPI1.SR ; \ SPI1.SR.MODF, Mode fault
: SPI1.SR.OVR? ( -- 1|0 ) 6 bit SPI1.SR bit@ ; \ SPI1.SR.OVR, Overrun flag
: SPI1.SR.BSY? ( -- 1|0 ) 7 bit SPI1.SR bit@ ; \ SPI1.SR.BSY, Busy flag
: SPI1.SR.TIFRFE ( -- x addr ) 8 bit SPI1.SR ; \ SPI1.SR.TIFRFE, TI frame format error
: SPI1.SR.FRLVL ( %bb -- x addr ) 9 lshift SPI1.SR ; \ SPI1.SR.FRLVL, FIFO reception level
: SPI1.SR.FTLVL ( %bb -- x addr ) 11 lshift SPI1.SR ; \ SPI1.SR.FTLVL, FIFO transmission level

\ SPI1.DR (read-write) Reset:$0000
: SPI1.DR.DR ( %bbbbbbbbbbbbbbbb -- x addr ) SPI1.DR ; \ SPI1.DR.DR, Data register

\ SPI1.CRCPR (read-write) Reset:$0007
: SPI1.CRCPR.CRCPOLY ( %bbbbbbbbbbbbbbbb -- x addr ) SPI1.CRCPR ; \ SPI1.CRCPR.CRCPOLY, CRC polynomial register

\ SPI1.RXCRCR (read-only) Reset:$0000
: SPI1.RXCRCR.RxCRC? ( --  x ) SPI1.RXCRCR @ ; \ SPI1.RXCRCR.RxCRC, Rx CRC register

\ SPI1.TXCRCR (read-only) Reset:$0000
: SPI1.TXCRCR.TxCRC? ( --  x ) SPI1.TXCRCR @ ; \ SPI1.TXCRCR.TxCRC, Tx CRC register

\ SPI1.I2SCFGR (read-write) Reset:$0000
: SPI1.I2SCFGR.CHLEN ( -- x addr ) 0 bit SPI1.I2SCFGR ; \ SPI1.I2SCFGR.CHLEN, Channel length (number of bits per audio               channel)
: SPI1.I2SCFGR.DATLEN ( %bb -- x addr ) 1 lshift SPI1.I2SCFGR ; \ SPI1.I2SCFGR.DATLEN, Data length to be               transferred
: SPI1.I2SCFGR.CKPOL ( -- x addr ) 3 bit SPI1.I2SCFGR ; \ SPI1.I2SCFGR.CKPOL, Inactive state clock               polarity
: SPI1.I2SCFGR.I2SSTD ( %bb -- x addr ) 4 lshift SPI1.I2SCFGR ; \ SPI1.I2SCFGR.I2SSTD, standard selection
: SPI1.I2SCFGR.PCMSYNC ( -- x addr ) 7 bit SPI1.I2SCFGR ; \ SPI1.I2SCFGR.PCMSYNC, PCM frame synchronization
: SPI1.I2SCFGR.I2SCFG ( %bb -- x addr ) 8 lshift SPI1.I2SCFGR ; \ SPI1.I2SCFGR.I2SCFG, I2S configuration mode
: SPI1.I2SCFGR.SE2 ( -- x addr ) 10 bit SPI1.I2SCFGR ; \ SPI1.I2SCFGR.SE2, I2S enable
: SPI1.I2SCFGR.I2SMOD ( -- x addr ) 11 bit SPI1.I2SCFGR ; \ SPI1.I2SCFGR.I2SMOD, I2S mode selection

\ SPI1.I2SPR (read-write) Reset:$0000
: SPI1.I2SPR.I2SDIV ( %bbbbbbbb -- x addr ) SPI1.I2SPR ; \ SPI1.I2SPR.I2SDIV, linear prescaler
: SPI1.I2SPR.ODD ( -- x addr ) 8 bit SPI1.I2SPR ; \ SPI1.I2SPR.ODD, Odd factor for the               prescaler
: SPI1.I2SPR.MCKOE ( -- x addr ) 9 bit SPI1.I2SPR ; \ SPI1.I2SPR.MCKOE, Master clock output enable

\ SPI2.CR1 (read-write) Reset:$0000
: SPI2.CR1.BIDIMODE ( -- x addr ) 15 bit SPI2.CR1 ; \ SPI2.CR1.BIDIMODE, Bidirectional data mode               enable
: SPI2.CR1.BIDIOE ( -- x addr ) 14 bit SPI2.CR1 ; \ SPI2.CR1.BIDIOE, Output enable in bidirectional               mode
: SPI2.CR1.CRCEN ( -- x addr ) 13 bit SPI2.CR1 ; \ SPI2.CR1.CRCEN, Hardware CRC calculation               enable
: SPI2.CR1.CRCNEXT ( -- x addr ) 12 bit SPI2.CR1 ; \ SPI2.CR1.CRCNEXT, CRC transfer next
: SPI2.CR1.DFF ( -- x addr ) 11 bit SPI2.CR1 ; \ SPI2.CR1.DFF, Data frame format
: SPI2.CR1.RXONLY ( -- x addr ) 10 bit SPI2.CR1 ; \ SPI2.CR1.RXONLY, Receive only
: SPI2.CR1.SSM ( -- x addr ) 9 bit SPI2.CR1 ; \ SPI2.CR1.SSM, Software slave management
: SPI2.CR1.SSI ( -- x addr ) 8 bit SPI2.CR1 ; \ SPI2.CR1.SSI, Internal slave select
: SPI2.CR1.LSBFIRST ( -- x addr ) 7 bit SPI2.CR1 ; \ SPI2.CR1.LSBFIRST, Frame format
: SPI2.CR1.SPE ( -- x addr ) 6 bit SPI2.CR1 ; \ SPI2.CR1.SPE, SPI enable
: SPI2.CR1.BR ( %bbb -- x addr ) 3 lshift SPI2.CR1 ; \ SPI2.CR1.BR, Baud rate control
: SPI2.CR1.MSTR ( -- x addr ) 2 bit SPI2.CR1 ; \ SPI2.CR1.MSTR, Master selection
: SPI2.CR1.CPOL ( -- x addr ) 1 bit SPI2.CR1 ; \ SPI2.CR1.CPOL, Clock polarity
: SPI2.CR1.CPHA ( -- x addr ) 0 bit SPI2.CR1 ; \ SPI2.CR1.CPHA, Clock phase

\ SPI2.CR2 (read-write) Reset:$0000
: SPI2.CR2.RXDMAEN ( -- x addr ) 0 bit SPI2.CR2 ; \ SPI2.CR2.RXDMAEN, Rx buffer DMA enable
: SPI2.CR2.TXDMAEN ( -- x addr ) 1 bit SPI2.CR2 ; \ SPI2.CR2.TXDMAEN, Tx buffer DMA enable
: SPI2.CR2.SSOE ( -- x addr ) 2 bit SPI2.CR2 ; \ SPI2.CR2.SSOE, SS output enable
: SPI2.CR2.NSSP ( -- x addr ) 3 bit SPI2.CR2 ; \ SPI2.CR2.NSSP, NSS pulse management
: SPI2.CR2.FRF ( -- x addr ) 4 bit SPI2.CR2 ; \ SPI2.CR2.FRF, Frame format
: SPI2.CR2.ERRIE ( -- x addr ) 5 bit SPI2.CR2 ; \ SPI2.CR2.ERRIE, Error interrupt enable
: SPI2.CR2.RXNEIE ( -- x addr ) 6 bit SPI2.CR2 ; \ SPI2.CR2.RXNEIE, RX buffer not empty interrupt               enable
: SPI2.CR2.TXEIE ( -- x addr ) 7 bit SPI2.CR2 ; \ SPI2.CR2.TXEIE, Tx buffer empty interrupt               enable
: SPI2.CR2.DS ( %bbbb -- x addr ) 8 lshift SPI2.CR2 ; \ SPI2.CR2.DS, Data size
: SPI2.CR2.FRXTH ( -- x addr ) 12 bit SPI2.CR2 ; \ SPI2.CR2.FRXTH, FIFO reception threshold
: SPI2.CR2.LDMA_RX ( -- x addr ) 13 bit SPI2.CR2 ; \ SPI2.CR2.LDMA_RX, Last DMA transfer for               reception
: SPI2.CR2.LDMA_TX ( -- x addr ) 14 bit SPI2.CR2 ; \ SPI2.CR2.LDMA_TX, Last DMA transfer for               transmission

\ SPI2.SR (multiple-access)  Reset:$0002
: SPI2.SR.RXNE ( -- x addr ) 0 bit SPI2.SR ; \ SPI2.SR.RXNE, Receive buffer not empty
: SPI2.SR.TXE ( -- x addr ) 1 bit SPI2.SR ; \ SPI2.SR.TXE, Transmit buffer empty
: SPI2.SR.CHSIDE ( -- x addr ) 2 bit SPI2.SR ; \ SPI2.SR.CHSIDE, Channel side
: SPI2.SR.UDR? ( -- 1|0 ) 3 bit SPI2.SR bit@ ; \ SPI2.SR.UDR, Underrun flag
: SPI2.SR.CRCERR? ( -- 1|0 ) 4 bit SPI2.SR bit@ ; \ SPI2.SR.CRCERR, CRC error flag
: SPI2.SR.MODF ( -- x addr ) 5 bit SPI2.SR ; \ SPI2.SR.MODF, Mode fault
: SPI2.SR.OVR? ( -- 1|0 ) 6 bit SPI2.SR bit@ ; \ SPI2.SR.OVR, Overrun flag
: SPI2.SR.BSY? ( -- 1|0 ) 7 bit SPI2.SR bit@ ; \ SPI2.SR.BSY, Busy flag
: SPI2.SR.TIFRFE ( -- x addr ) 8 bit SPI2.SR ; \ SPI2.SR.TIFRFE, TI frame format error
: SPI2.SR.FRLVL ( %bb -- x addr ) 9 lshift SPI2.SR ; \ SPI2.SR.FRLVL, FIFO reception level
: SPI2.SR.FTLVL ( %bb -- x addr ) 11 lshift SPI2.SR ; \ SPI2.SR.FTLVL, FIFO transmission level

\ SPI2.DR (read-write) Reset:$0000
: SPI2.DR.DR ( %bbbbbbbbbbbbbbbb -- x addr ) SPI2.DR ; \ SPI2.DR.DR, Data register

\ SPI2.CRCPR (read-write) Reset:$0007
: SPI2.CRCPR.CRCPOLY ( %bbbbbbbbbbbbbbbb -- x addr ) SPI2.CRCPR ; \ SPI2.CRCPR.CRCPOLY, CRC polynomial register

\ SPI2.RXCRCR (read-only) Reset:$0000
: SPI2.RXCRCR.RxCRC? ( --  x ) SPI2.RXCRCR @ ; \ SPI2.RXCRCR.RxCRC, Rx CRC register

\ SPI2.TXCRCR (read-only) Reset:$0000
: SPI2.TXCRCR.TxCRC? ( --  x ) SPI2.TXCRCR @ ; \ SPI2.TXCRCR.TxCRC, Tx CRC register

\ SPI2.I2SCFGR (read-write) Reset:$0000
: SPI2.I2SCFGR.CHLEN ( -- x addr ) 0 bit SPI2.I2SCFGR ; \ SPI2.I2SCFGR.CHLEN, Channel length (number of bits per audio               channel)
: SPI2.I2SCFGR.DATLEN ( %bb -- x addr ) 1 lshift SPI2.I2SCFGR ; \ SPI2.I2SCFGR.DATLEN, Data length to be               transferred
: SPI2.I2SCFGR.CKPOL ( -- x addr ) 3 bit SPI2.I2SCFGR ; \ SPI2.I2SCFGR.CKPOL, Inactive state clock               polarity
: SPI2.I2SCFGR.I2SSTD ( %bb -- x addr ) 4 lshift SPI2.I2SCFGR ; \ SPI2.I2SCFGR.I2SSTD, standard selection
: SPI2.I2SCFGR.PCMSYNC ( -- x addr ) 7 bit SPI2.I2SCFGR ; \ SPI2.I2SCFGR.PCMSYNC, PCM frame synchronization
: SPI2.I2SCFGR.I2SCFG ( %bb -- x addr ) 8 lshift SPI2.I2SCFGR ; \ SPI2.I2SCFGR.I2SCFG, I2S configuration mode
: SPI2.I2SCFGR.SE2 ( -- x addr ) 10 bit SPI2.I2SCFGR ; \ SPI2.I2SCFGR.SE2, I2S enable
: SPI2.I2SCFGR.I2SMOD ( -- x addr ) 11 bit SPI2.I2SCFGR ; \ SPI2.I2SCFGR.I2SMOD, I2S mode selection

\ SPI2.I2SPR (read-write) Reset:$0000
: SPI2.I2SPR.I2SDIV ( %bbbbbbbb -- x addr ) SPI2.I2SPR ; \ SPI2.I2SPR.I2SDIV, linear prescaler
: SPI2.I2SPR.ODD ( -- x addr ) 8 bit SPI2.I2SPR ; \ SPI2.I2SPR.ODD, Odd factor for the               prescaler
: SPI2.I2SPR.MCKOE ( -- x addr ) 9 bit SPI2.I2SPR ; \ SPI2.I2SPR.MCKOE, Master clock output enable

\ TIM1.CR1 (read-write) Reset:$0000
: TIM1.CR1.CEN ( -- x addr ) 0 bit TIM1.CR1 ; \ TIM1.CR1.CEN, Counter enable
: TIM1.CR1.OPM ( -- x addr ) 3 bit TIM1.CR1 ; \ TIM1.CR1.OPM, One-pulse mode
: TIM1.CR1.UDIS ( -- x addr ) 1 bit TIM1.CR1 ; \ TIM1.CR1.UDIS, Update disable
: TIM1.CR1.URS ( -- x addr ) 2 bit TIM1.CR1 ; \ TIM1.CR1.URS, Update request source
: TIM1.CR1.DIR ( -- x addr ) 4 bit TIM1.CR1 ; \ TIM1.CR1.DIR, Direction
: TIM1.CR1.CMS ( %bb -- x addr ) 5 lshift TIM1.CR1 ; \ TIM1.CR1.CMS, Center-aligned mode               selection
: TIM1.CR1.ARPE ( -- x addr ) 7 bit TIM1.CR1 ; \ TIM1.CR1.ARPE, Auto-reload preload enable
: TIM1.CR1.CKD ( %bb -- x addr ) 8 lshift TIM1.CR1 ; \ TIM1.CR1.CKD, Clock division
: TIM1.CR1.UIFREMAP ( -- x addr ) 11 bit TIM1.CR1 ; \ TIM1.CR1.UIFREMAP, UIF status bit remapping

\ TIM1.CR2 (read-write) Reset:$0000
: TIM1.CR2.MMS2 ( %bbbb -- x addr ) 20 lshift TIM1.CR2 ; \ TIM1.CR2.MMS2, Master mode selection 2
: TIM1.CR2.OIS6 ( -- x addr ) 18 bit TIM1.CR2 ; \ TIM1.CR2.OIS6, Output Idle state 6 (OC6               output)
: TIM1.CR2.OIS5 ( -- x addr ) 16 bit TIM1.CR2 ; \ TIM1.CR2.OIS5, Output Idle state 5 (OC5               output)
: TIM1.CR2.OIS4 ( -- x addr ) 14 bit TIM1.CR2 ; \ TIM1.CR2.OIS4, Output Idle state 4
: TIM1.CR2.OIS3N ( -- x addr ) 13 bit TIM1.CR2 ; \ TIM1.CR2.OIS3N, Output Idle state 3
: TIM1.CR2.OIS3 ( -- x addr ) 12 bit TIM1.CR2 ; \ TIM1.CR2.OIS3, Output Idle state 3
: TIM1.CR2.OIS2N ( -- x addr ) 11 bit TIM1.CR2 ; \ TIM1.CR2.OIS2N, Output Idle state 2
: TIM1.CR2.OIS2 ( -- x addr ) 10 bit TIM1.CR2 ; \ TIM1.CR2.OIS2, Output Idle state 2
: TIM1.CR2.OIS1N ( -- x addr ) 9 bit TIM1.CR2 ; \ TIM1.CR2.OIS1N, Output Idle state 1
: TIM1.CR2.OIS1 ( -- x addr ) 8 bit TIM1.CR2 ; \ TIM1.CR2.OIS1, Output Idle state 1
: TIM1.CR2.TI1S ( -- x addr ) 7 bit TIM1.CR2 ; \ TIM1.CR2.TI1S, TI1 selection
: TIM1.CR2.MMS ( %bbb -- x addr ) 4 lshift TIM1.CR2 ; \ TIM1.CR2.MMS, Master mode selection
: TIM1.CR2.CCDS ( -- x addr ) 3 bit TIM1.CR2 ; \ TIM1.CR2.CCDS, Capture/compare DMA               selection
: TIM1.CR2.CCUS ( -- x addr ) 2 bit TIM1.CR2 ; \ TIM1.CR2.CCUS, Capture/compare control update               selection
: TIM1.CR2.CCPC ( -- x addr ) 0 bit TIM1.CR2 ; \ TIM1.CR2.CCPC, Capture/compare preloaded               control

\ TIM1.SMCR (read-write) Reset:$0000
: TIM1.SMCR.SMS ( %bbb -- x addr ) TIM1.SMCR ; \ TIM1.SMCR.SMS, Slave mode selection
: TIM1.SMCR.OCCS ( -- x addr ) 3 bit TIM1.SMCR ; \ TIM1.SMCR.OCCS, OCREF clear selection
: TIM1.SMCR.TS_4 ( %bbb -- x addr ) 4 lshift TIM1.SMCR ; \ TIM1.SMCR.TS_4, Trigger selection
: TIM1.SMCR.MSM ( -- x addr ) 7 bit TIM1.SMCR ; \ TIM1.SMCR.MSM, Master/Slave mode
: TIM1.SMCR.ETF ( %bbbb -- x addr ) 8 lshift TIM1.SMCR ; \ TIM1.SMCR.ETF, External trigger filter
: TIM1.SMCR.ETPS ( %bb -- x addr ) 12 lshift TIM1.SMCR ; \ TIM1.SMCR.ETPS, External trigger prescaler
: TIM1.SMCR.ECE ( -- x addr ) 14 bit TIM1.SMCR ; \ TIM1.SMCR.ECE, External clock enable
: TIM1.SMCR.ETP ( -- x addr ) 15 bit TIM1.SMCR ; \ TIM1.SMCR.ETP, External trigger polarity
: TIM1.SMCR.SMS_3 ( -- x addr ) 16 bit TIM1.SMCR ; \ TIM1.SMCR.SMS_3, Slave mode selection - bit               3
: TIM1.SMCR.TS ( %bb -- x addr ) 20 lshift TIM1.SMCR ; \ TIM1.SMCR.TS, Trigger selection

\ TIM1.DIER (read-write) Reset:$0000
: TIM1.DIER.UIE ( -- x addr ) 0 bit TIM1.DIER ; \ TIM1.DIER.UIE, Update interrupt enable
: TIM1.DIER.CC1IE ( -- x addr ) 1 bit TIM1.DIER ; \ TIM1.DIER.CC1IE, Capture/Compare 1 interrupt               enable
: TIM1.DIER.CC2IE ( -- x addr ) 2 bit TIM1.DIER ; \ TIM1.DIER.CC2IE, Capture/Compare 2 interrupt               enable
: TIM1.DIER.CC3IE ( -- x addr ) 3 bit TIM1.DIER ; \ TIM1.DIER.CC3IE, Capture/Compare 3 interrupt               enable
: TIM1.DIER.CC4IE ( -- x addr ) 4 bit TIM1.DIER ; \ TIM1.DIER.CC4IE, Capture/Compare 4 interrupt               enable
: TIM1.DIER.COMIE ( -- x addr ) 5 bit TIM1.DIER ; \ TIM1.DIER.COMIE, COM interrupt enable
: TIM1.DIER.TIE ( -- x addr ) 6 bit TIM1.DIER ; \ TIM1.DIER.TIE, Trigger interrupt enable
: TIM1.DIER.BIE ( -- x addr ) 7 bit TIM1.DIER ; \ TIM1.DIER.BIE, Break interrupt enable
: TIM1.DIER.UDE ( -- x addr ) 8 bit TIM1.DIER ; \ TIM1.DIER.UDE, Update DMA request enable
: TIM1.DIER.CC1DE ( -- x addr ) 9 bit TIM1.DIER ; \ TIM1.DIER.CC1DE, Capture/Compare 1 DMA request               enable
: TIM1.DIER.CC2DE ( -- x addr ) 10 bit TIM1.DIER ; \ TIM1.DIER.CC2DE, Capture/Compare 2 DMA request               enable
: TIM1.DIER.CC3DE ( -- x addr ) 11 bit TIM1.DIER ; \ TIM1.DIER.CC3DE, Capture/Compare 3 DMA request               enable
: TIM1.DIER.CC4DE ( -- x addr ) 12 bit TIM1.DIER ; \ TIM1.DIER.CC4DE, Capture/Compare 4 DMA request               enable
: TIM1.DIER.COMDE ( -- x addr ) 13 bit TIM1.DIER ; \ TIM1.DIER.COMDE, COM DMA request enable
: TIM1.DIER.TDE ( -- x addr ) 14 bit TIM1.DIER ; \ TIM1.DIER.TDE, Trigger DMA request enable

\ TIM1.SR (read-write) Reset:$0000
: TIM1.SR.UIF ( -- x addr ) 0 bit TIM1.SR ; \ TIM1.SR.UIF, Update interrupt flag
: TIM1.SR.CC1IF ( -- x addr ) 1 bit TIM1.SR ; \ TIM1.SR.CC1IF, Capture/compare 1 interrupt               flag
: TIM1.SR.CC2IF ( -- x addr ) 2 bit TIM1.SR ; \ TIM1.SR.CC2IF, Capture/Compare 2 interrupt               flag
: TIM1.SR.CC3IF ( -- x addr ) 3 bit TIM1.SR ; \ TIM1.SR.CC3IF, Capture/Compare 3 interrupt               flag
: TIM1.SR.CC4IF ( -- x addr ) 4 bit TIM1.SR ; \ TIM1.SR.CC4IF, Capture/Compare 4 interrupt               flag
: TIM1.SR.COMIF ( -- x addr ) 5 bit TIM1.SR ; \ TIM1.SR.COMIF, COM interrupt flag
: TIM1.SR.TIF ( -- x addr ) 6 bit TIM1.SR ; \ TIM1.SR.TIF, Trigger interrupt flag
: TIM1.SR.BIF ( -- x addr ) 7 bit TIM1.SR ; \ TIM1.SR.BIF, Break interrupt flag
: TIM1.SR.B2IF ( -- x addr ) 8 bit TIM1.SR ; \ TIM1.SR.B2IF, Break 2 interrupt flag
: TIM1.SR.CC1OF ( -- x addr ) 9 bit TIM1.SR ; \ TIM1.SR.CC1OF, Capture/Compare 1 overcapture               flag
: TIM1.SR.CC2OF ( -- x addr ) 10 bit TIM1.SR ; \ TIM1.SR.CC2OF, Capture/compare 2 overcapture               flag
: TIM1.SR.CC3OF ( -- x addr ) 11 bit TIM1.SR ; \ TIM1.SR.CC3OF, Capture/Compare 3 overcapture               flag
: TIM1.SR.CC4OF ( -- x addr ) 12 bit TIM1.SR ; \ TIM1.SR.CC4OF, Capture/Compare 4 overcapture               flag
: TIM1.SR.SBIF ( -- x addr ) 13 bit TIM1.SR ; \ TIM1.SR.SBIF, System Break interrupt               flag
: TIM1.SR.CC5IF ( -- x addr ) 16 bit TIM1.SR ; \ TIM1.SR.CC5IF, Compare 5 interrupt flag
: TIM1.SR.CC6IF ( -- x addr ) 17 bit TIM1.SR ; \ TIM1.SR.CC6IF, Compare 6 interrupt flag

\ TIM1.EGR (write-only) Reset:$0000
: TIM1.EGR.UG ( -- x addr ) 0 bit TIM1.EGR ; \ TIM1.EGR.UG, Update generation
: TIM1.EGR.CC1G ( -- x addr ) 1 bit TIM1.EGR ; \ TIM1.EGR.CC1G, Capture/compare 1               generation
: TIM1.EGR.CC2G ( -- x addr ) 2 bit TIM1.EGR ; \ TIM1.EGR.CC2G, Capture/compare 2               generation
: TIM1.EGR.CC3G ( -- x addr ) 3 bit TIM1.EGR ; \ TIM1.EGR.CC3G, Capture/compare 3               generation
: TIM1.EGR.CC4G ( -- x addr ) 4 bit TIM1.EGR ; \ TIM1.EGR.CC4G, Capture/compare 4               generation
: TIM1.EGR.COMG ( -- x addr ) 5 bit TIM1.EGR ; \ TIM1.EGR.COMG, Capture/Compare control update               generation
: TIM1.EGR.TG ( -- x addr ) 6 bit TIM1.EGR ; \ TIM1.EGR.TG, Trigger generation
: TIM1.EGR.BG ( -- x addr ) 7 bit TIM1.EGR ; \ TIM1.EGR.BG, Break generation
: TIM1.EGR.B2G ( -- x addr ) 8 bit TIM1.EGR ; \ TIM1.EGR.B2G, Break 2 generation

\ TIM1.CCMR1_Output (read-write) Reset:$00000000
: TIM1.CCMR1_Output.CC1S ( %bb -- x addr ) TIM1.CCMR1_Output ; \ TIM1.CCMR1_Output.CC1S, Capture/Compare 1               selection
: TIM1.CCMR1_Output.OC1FE ( -- x addr ) 2 bit TIM1.CCMR1_Output ; \ TIM1.CCMR1_Output.OC1FE, Output Compare 1 fast               enable
: TIM1.CCMR1_Output.OC1PE ( -- x addr ) 3 bit TIM1.CCMR1_Output ; \ TIM1.CCMR1_Output.OC1PE, Output Compare 1 preload               enable
: TIM1.CCMR1_Output.OC1M ( %bbb -- x addr ) 4 lshift TIM1.CCMR1_Output ; \ TIM1.CCMR1_Output.OC1M, Output Compare 1 mode
: TIM1.CCMR1_Output.OC1CE ( -- x addr ) 7 bit TIM1.CCMR1_Output ; \ TIM1.CCMR1_Output.OC1CE, Output Compare 1 clear               enable
: TIM1.CCMR1_Output.CC2S ( %bb -- x addr ) 8 lshift TIM1.CCMR1_Output ; \ TIM1.CCMR1_Output.CC2S, Capture/Compare 2               selection
: TIM1.CCMR1_Output.OC2FE ( -- x addr ) 10 bit TIM1.CCMR1_Output ; \ TIM1.CCMR1_Output.OC2FE, Output Compare 2 fast               enable
: TIM1.CCMR1_Output.OC2PE ( -- x addr ) 11 bit TIM1.CCMR1_Output ; \ TIM1.CCMR1_Output.OC2PE, Output Compare 2 preload               enable
: TIM1.CCMR1_Output.OC2M ( %bbb -- x addr ) 12 lshift TIM1.CCMR1_Output ; \ TIM1.CCMR1_Output.OC2M, Output Compare 2 mode
: TIM1.CCMR1_Output.OC2CE ( -- x addr ) 15 bit TIM1.CCMR1_Output ; \ TIM1.CCMR1_Output.OC2CE, Output Compare 2 clear               enable
: TIM1.CCMR1_Output.OC1M_3 ( -- x addr ) 16 bit TIM1.CCMR1_Output ; \ TIM1.CCMR1_Output.OC1M_3, Output Compare 1 mode - bit               3
: TIM1.CCMR1_Output.OC2M_3 ( -- x addr ) 24 bit TIM1.CCMR1_Output ; \ TIM1.CCMR1_Output.OC2M_3, Output Compare 2 mode - bit               3

\ TIM1.CCMR1_Input (read-write) Reset:$00000000
: TIM1.CCMR1_Input.CC1S ( %bb -- x addr ) TIM1.CCMR1_Input ; \ TIM1.CCMR1_Input.CC1S, Capture/Compare 1               selection
: TIM1.CCMR1_Input.OC1FE ( -- x addr ) 2 bit TIM1.CCMR1_Input ; \ TIM1.CCMR1_Input.OC1FE, Output Compare 1 fast               enable
: TIM1.CCMR1_Input.OC1PE ( -- x addr ) 3 bit TIM1.CCMR1_Input ; \ TIM1.CCMR1_Input.OC1PE, Output Compare 1 preload               enable
: TIM1.CCMR1_Input.OC1M ( %bbb -- x addr ) 4 lshift TIM1.CCMR1_Input ; \ TIM1.CCMR1_Input.OC1M, Output Compare 1 mode
: TIM1.CCMR1_Input.OC1CE ( -- x addr ) 7 bit TIM1.CCMR1_Input ; \ TIM1.CCMR1_Input.OC1CE, Output Compare 1 clear               enable
: TIM1.CCMR1_Input.CC2S ( %bb -- x addr ) 8 lshift TIM1.CCMR1_Input ; \ TIM1.CCMR1_Input.CC2S, Capture/Compare 2               selection
: TIM1.CCMR1_Input.OC2FE ( -- x addr ) 10 bit TIM1.CCMR1_Input ; \ TIM1.CCMR1_Input.OC2FE, Output Compare 2 fast               enable
: TIM1.CCMR1_Input.OC2PE ( -- x addr ) 11 bit TIM1.CCMR1_Input ; \ TIM1.CCMR1_Input.OC2PE, Output Compare 2 preload               enable
: TIM1.CCMR1_Input.OC2M ( %bbb -- x addr ) 12 lshift TIM1.CCMR1_Input ; \ TIM1.CCMR1_Input.OC2M, Output Compare 2 mode
: TIM1.CCMR1_Input.OC2CE ( -- x addr ) 15 bit TIM1.CCMR1_Input ; \ TIM1.CCMR1_Input.OC2CE, Output Compare 2 clear               enable

\ TIM1.CCMR2_Output (read-write) Reset:$00000000
: TIM1.CCMR2_Output.CC3S ( %bb -- x addr ) TIM1.CCMR2_Output ; \ TIM1.CCMR2_Output.CC3S, Capture/Compare 3               selection
: TIM1.CCMR2_Output.OC3FE ( -- x addr ) 2 bit TIM1.CCMR2_Output ; \ TIM1.CCMR2_Output.OC3FE, Output compare 3 fast               enable
: TIM1.CCMR2_Output.OC3PE ( -- x addr ) 3 bit TIM1.CCMR2_Output ; \ TIM1.CCMR2_Output.OC3PE, Output compare 3 preload               enable
: TIM1.CCMR2_Output.OC3M ( %bbb -- x addr ) 4 lshift TIM1.CCMR2_Output ; \ TIM1.CCMR2_Output.OC3M, Output compare 3 mode
: TIM1.CCMR2_Output.OC3CE ( -- x addr ) 7 bit TIM1.CCMR2_Output ; \ TIM1.CCMR2_Output.OC3CE, Output compare 3 clear               enable
: TIM1.CCMR2_Output.CC4S ( %bb -- x addr ) 8 lshift TIM1.CCMR2_Output ; \ TIM1.CCMR2_Output.CC4S, Capture/Compare 4               selection
: TIM1.CCMR2_Output.OC4FE ( -- x addr ) 10 bit TIM1.CCMR2_Output ; \ TIM1.CCMR2_Output.OC4FE, Output compare 4 fast               enable
: TIM1.CCMR2_Output.OC4PE ( -- x addr ) 11 bit TIM1.CCMR2_Output ; \ TIM1.CCMR2_Output.OC4PE, Output compare 4 preload               enable
: TIM1.CCMR2_Output.OC4M ( %bbb -- x addr ) 12 lshift TIM1.CCMR2_Output ; \ TIM1.CCMR2_Output.OC4M, Output compare 4 mode
: TIM1.CCMR2_Output.OC4CE ( -- x addr ) 15 bit TIM1.CCMR2_Output ; \ TIM1.CCMR2_Output.OC4CE, Output compare 4 clear               enable
: TIM1.CCMR2_Output.OC3M_3 ( -- x addr ) 16 bit TIM1.CCMR2_Output ; \ TIM1.CCMR2_Output.OC3M_3, Output Compare 3 mode - bit               3
: TIM1.CCMR2_Output.OC4M_3 ( -- x addr ) 24 bit TIM1.CCMR2_Output ; \ TIM1.CCMR2_Output.OC4M_3, Output Compare 4 mode - bit               3

\ TIM1.CCMR2_Input (read-write) Reset:$00000000
: TIM1.CCMR2_Input.CC3S ( %bb -- x addr ) TIM1.CCMR2_Input ; \ TIM1.CCMR2_Input.CC3S, Capture/Compare 3               selection
: TIM1.CCMR2_Input.OC3FE ( -- x addr ) 2 bit TIM1.CCMR2_Input ; \ TIM1.CCMR2_Input.OC3FE, Output compare 3 fast               enable
: TIM1.CCMR2_Input.OC3PE ( -- x addr ) 3 bit TIM1.CCMR2_Input ; \ TIM1.CCMR2_Input.OC3PE, Output compare 3 preload               enable
: TIM1.CCMR2_Input.OC3M ( %bbb -- x addr ) 4 lshift TIM1.CCMR2_Input ; \ TIM1.CCMR2_Input.OC3M, Output compare 3 mode
: TIM1.CCMR2_Input.OC3CE ( -- x addr ) 7 bit TIM1.CCMR2_Input ; \ TIM1.CCMR2_Input.OC3CE, Output compare 3 clear               enable
: TIM1.CCMR2_Input.CC4S ( %bb -- x addr ) 8 lshift TIM1.CCMR2_Input ; \ TIM1.CCMR2_Input.CC4S, Capture/Compare 4               selection
: TIM1.CCMR2_Input.OC4FE ( -- x addr ) 10 bit TIM1.CCMR2_Input ; \ TIM1.CCMR2_Input.OC4FE, Output compare 4 fast               enable
: TIM1.CCMR2_Input.OC4PE ( -- x addr ) 11 bit TIM1.CCMR2_Input ; \ TIM1.CCMR2_Input.OC4PE, Output compare 4 preload               enable
: TIM1.CCMR2_Input.OC4M ( %bbb -- x addr ) 12 lshift TIM1.CCMR2_Input ; \ TIM1.CCMR2_Input.OC4M, Output compare 4 mode
: TIM1.CCMR2_Input.OC4CE ( -- x addr ) 15 bit TIM1.CCMR2_Input ; \ TIM1.CCMR2_Input.OC4CE, Output compare 4 clear               enable

\ TIM1.CCER (read-write) Reset:$0000
: TIM1.CCER.CC1E ( -- x addr ) 0 bit TIM1.CCER ; \ TIM1.CCER.CC1E, Capture/Compare 1 output               enable
: TIM1.CCER.CC1P ( -- x addr ) 1 bit TIM1.CCER ; \ TIM1.CCER.CC1P, Capture/Compare 1 output               Polarity
: TIM1.CCER.CC1NE ( -- x addr ) 2 bit TIM1.CCER ; \ TIM1.CCER.CC1NE, Capture/Compare 1 complementary output               enable
: TIM1.CCER.CC1NP ( -- x addr ) 3 bit TIM1.CCER ; \ TIM1.CCER.CC1NP, Capture/Compare 1 output               Polarity
: TIM1.CCER.CC2E ( -- x addr ) 4 bit TIM1.CCER ; \ TIM1.CCER.CC2E, Capture/Compare 2 output               enable
: TIM1.CCER.CC2P ( -- x addr ) 5 bit TIM1.CCER ; \ TIM1.CCER.CC2P, Capture/Compare 2 output               Polarity
: TIM1.CCER.CC2NE ( -- x addr ) 6 bit TIM1.CCER ; \ TIM1.CCER.CC2NE, Capture/Compare 2 complementary output               enable
: TIM1.CCER.CC2NP ( -- x addr ) 7 bit TIM1.CCER ; \ TIM1.CCER.CC2NP, Capture/Compare 2 output               Polarity
: TIM1.CCER.CC3E ( -- x addr ) 8 bit TIM1.CCER ; \ TIM1.CCER.CC3E, Capture/Compare 3 output               enable
: TIM1.CCER.CC3P ( -- x addr ) 9 bit TIM1.CCER ; \ TIM1.CCER.CC3P, Capture/Compare 3 output               Polarity
: TIM1.CCER.CC3NE ( -- x addr ) 10 bit TIM1.CCER ; \ TIM1.CCER.CC3NE, Capture/Compare 3 complementary output               enable
: TIM1.CCER.CC3NP ( -- x addr ) 11 bit TIM1.CCER ; \ TIM1.CCER.CC3NP, Capture/Compare 3 output               Polarity
: TIM1.CCER.CC4E ( -- x addr ) 12 bit TIM1.CCER ; \ TIM1.CCER.CC4E, Capture/Compare 4 output               enable
: TIM1.CCER.CC4P ( -- x addr ) 13 bit TIM1.CCER ; \ TIM1.CCER.CC4P, Capture/Compare 3 output               Polarity
: TIM1.CCER.CC4NP ( -- x addr ) 15 bit TIM1.CCER ; \ TIM1.CCER.CC4NP, Capture/Compare 4 complementary output               polarity
: TIM1.CCER.CC5E ( -- x addr ) 16 bit TIM1.CCER ; \ TIM1.CCER.CC5E, Capture/Compare 5 output               enable
: TIM1.CCER.CC5P ( -- x addr ) 17 bit TIM1.CCER ; \ TIM1.CCER.CC5P, Capture/Compare 5 output               polarity
: TIM1.CCER.CC6E ( -- x addr ) 20 bit TIM1.CCER ; \ TIM1.CCER.CC6E, Capture/Compare 6 output               enable
: TIM1.CCER.CC6P ( -- x addr ) 21 bit TIM1.CCER ; \ TIM1.CCER.CC6P, Capture/Compare 6 output               polarity

\ TIM1.CNT (multiple-access)  Reset:$00000000
: TIM1.CNT.CNT ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1.CNT ; \ TIM1.CNT.CNT, counter value
: TIM1.CNT.UIFCPY ( -- x addr ) 31 bit TIM1.CNT ; \ TIM1.CNT.UIFCPY, UIF copy

\ TIM1.PSC (read-write) Reset:$0000
: TIM1.PSC.PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1.PSC ; \ TIM1.PSC.PSC, Prescaler value

\ TIM1.ARR (read-write) Reset:$00000000
: TIM1.ARR.ARR ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1.ARR ; \ TIM1.ARR.ARR, Auto-reload value

\ TIM1.RCR (read-write) Reset:$0000
: TIM1.RCR.REP ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1.RCR ; \ TIM1.RCR.REP, Repetition counter value

\ TIM1.CCR1 (read-write) Reset:$00000000
: TIM1.CCR1.CCR1 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1.CCR1 ; \ TIM1.CCR1.CCR1, Capture/Compare 1 value

\ TIM1.CCR2 (read-write) Reset:$00000000
: TIM1.CCR2.CCR2 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1.CCR2 ; \ TIM1.CCR2.CCR2, Capture/Compare 2 value

\ TIM1.CCR3 (read-write) Reset:$00000000
: TIM1.CCR3.CCR3 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1.CCR3 ; \ TIM1.CCR3.CCR3, Capture/Compare value

\ TIM1.CCR4 (read-write) Reset:$00000000
: TIM1.CCR4.CCR4 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1.CCR4 ; \ TIM1.CCR4.CCR4, Capture/Compare value

\ TIM1.BDTR (read-write) Reset:$0000
: TIM1.BDTR.DTG ( %bbbbbbbb -- x addr ) TIM1.BDTR ; \ TIM1.BDTR.DTG, Dead-time generator setup
: TIM1.BDTR.LOCK ( %bb -- x addr ) 8 lshift TIM1.BDTR ; \ TIM1.BDTR.LOCK, Lock configuration
: TIM1.BDTR.OSSI ( -- x addr ) 10 bit TIM1.BDTR ; \ TIM1.BDTR.OSSI, Off-state selection for Idle               mode
: TIM1.BDTR.OSSR ( -- x addr ) 11 bit TIM1.BDTR ; \ TIM1.BDTR.OSSR, Off-state selection for Run               mode
: TIM1.BDTR.BKE ( -- x addr ) 12 bit TIM1.BDTR ; \ TIM1.BDTR.BKE, Break enable
: TIM1.BDTR.BKP ( -- x addr ) 13 bit TIM1.BDTR ; \ TIM1.BDTR.BKP, Break polarity
: TIM1.BDTR.AOE ( -- x addr ) 14 bit TIM1.BDTR ; \ TIM1.BDTR.AOE, Automatic output enable
: TIM1.BDTR.MOE ( -- x addr ) 15 bit TIM1.BDTR ; \ TIM1.BDTR.MOE, Main output enable
: TIM1.BDTR.BKF ( %bbbb -- x addr ) 16 lshift TIM1.BDTR ; \ TIM1.BDTR.BKF, Break filter
: TIM1.BDTR.BK2F ( %bbbb -- x addr ) 20 lshift TIM1.BDTR ; \ TIM1.BDTR.BK2F, Break 2 filter
: TIM1.BDTR.BK2E ( -- x addr ) 24 bit TIM1.BDTR ; \ TIM1.BDTR.BK2E, Break 2 enable
: TIM1.BDTR.BK2P ( -- x addr ) 25 bit TIM1.BDTR ; \ TIM1.BDTR.BK2P, Break 2 polarity
: TIM1.BDTR.BKDSRM ( -- x addr ) 26 bit TIM1.BDTR ; \ TIM1.BDTR.BKDSRM, Break Disarm
: TIM1.BDTR.BK2DSRM ( -- x addr ) 27 bit TIM1.BDTR ; \ TIM1.BDTR.BK2DSRM, Break2 Disarm
: TIM1.BDTR.BKBID ( -- x addr ) 28 bit TIM1.BDTR ; \ TIM1.BDTR.BKBID, Break Bidirectional
: TIM1.BDTR.BK2ID ( -- x addr ) 29 bit TIM1.BDTR ; \ TIM1.BDTR.BK2ID, Break2 bidirectional

\ TIM1.DCR (read-write) Reset:$0000
: TIM1.DCR.DBL ( %bbbbb -- x addr ) 8 lshift TIM1.DCR ; \ TIM1.DCR.DBL, DMA burst length
: TIM1.DCR.DBA ( %bbbbb -- x addr ) TIM1.DCR ; \ TIM1.DCR.DBA, DMA base address

\ TIM1.DMAR (read-write) Reset:$0000
: TIM1.DMAR.DMAB ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1.DMAR ; \ TIM1.DMAR.DMAB, DMA register for burst               accesses

\ TIM1.OR1 (read-write) Reset:$0000
: TIM1.OR1.OCREF_CLR ( -- x addr ) 0 bit TIM1.OR1 ; \ TIM1.OR1.OCREF_CLR, Ocref_clr source selection

\ TIM1.CCMR3_Output (read-write) Reset:$00000000
: TIM1.CCMR3_Output.OC6M_bit3 ( -- x addr ) 24 bit TIM1.CCMR3_Output ; \ TIM1.CCMR3_Output.OC6M_bit3, Output Compare 6 mode bit               3
: TIM1.CCMR3_Output.OC5M_bit3 ( -- x addr ) 16 bit TIM1.CCMR3_Output ; \ TIM1.CCMR3_Output.OC5M_bit3, Output Compare 5 mode bit               3
: TIM1.CCMR3_Output.OC6CE ( -- x addr ) 15 bit TIM1.CCMR3_Output ; \ TIM1.CCMR3_Output.OC6CE, Output compare 6 clear               enable
: TIM1.CCMR3_Output.OC6M ( %bbb -- x addr ) 12 lshift TIM1.CCMR3_Output ; \ TIM1.CCMR3_Output.OC6M, Output compare 6 mode
: TIM1.CCMR3_Output.OC6PE ( -- x addr ) 11 bit TIM1.CCMR3_Output ; \ TIM1.CCMR3_Output.OC6PE, Output compare 6 preload               enable
: TIM1.CCMR3_Output.OC6FE ( -- x addr ) 10 bit TIM1.CCMR3_Output ; \ TIM1.CCMR3_Output.OC6FE, Output compare 6 fast               enable
: TIM1.CCMR3_Output.OC5CE ( -- x addr ) 7 bit TIM1.CCMR3_Output ; \ TIM1.CCMR3_Output.OC5CE, Output compare 5 clear               enable
: TIM1.CCMR3_Output.OC5M ( %bbb -- x addr ) 4 lshift TIM1.CCMR3_Output ; \ TIM1.CCMR3_Output.OC5M, Output compare 5 mode
: TIM1.CCMR3_Output.OC5PE ( -- x addr ) 3 bit TIM1.CCMR3_Output ; \ TIM1.CCMR3_Output.OC5PE, Output compare 5 preload               enable
: TIM1.CCMR3_Output.OC5FE ( -- x addr ) 2 bit TIM1.CCMR3_Output ; \ TIM1.CCMR3_Output.OC5FE, Output compare 5 fast               enable

\ TIM1.CCR5 (read-write) Reset:$00000000
: TIM1.CCR5.CCR5 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1.CCR5 ; \ TIM1.CCR5.CCR5, Capture/Compare value
: TIM1.CCR5.GC5C1 ( -- x addr ) 29 bit TIM1.CCR5 ; \ TIM1.CCR5.GC5C1, Group Channel 5 and Channel               1
: TIM1.CCR5.GC5C2 ( -- x addr ) 30 bit TIM1.CCR5 ; \ TIM1.CCR5.GC5C2, Group Channel 5 and Channel               2
: TIM1.CCR5.GC5C3 ( -- x addr ) 31 bit TIM1.CCR5 ; \ TIM1.CCR5.GC5C3, Group Channel 5 and Channel               3

\ TIM1.CCR6 (read-write) Reset:$00000000
: TIM1.CCR6.CCR6 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1.CCR6 ; \ TIM1.CCR6.CCR6, Capture/Compare value

\ TIM1.AF1 (read-write) Reset:$00000001
: TIM1.AF1.BKINE ( -- x addr ) 0 bit TIM1.AF1 ; \ TIM1.AF1.BKINE, BRK BKIN input enable
: TIM1.AF1.BKCMP1E ( -- x addr ) 1 bit TIM1.AF1 ; \ TIM1.AF1.BKCMP1E, BRK COMP1 enable
: TIM1.AF1.BKCMP2E ( -- x addr ) 2 bit TIM1.AF1 ; \ TIM1.AF1.BKCMP2E, BRK COMP2 enable
: TIM1.AF1.BKINP ( -- x addr ) 9 bit TIM1.AF1 ; \ TIM1.AF1.BKINP, BRK BKIN input polarity
: TIM1.AF1.BKCMP1P ( -- x addr ) 10 bit TIM1.AF1 ; \ TIM1.AF1.BKCMP1P, BRK COMP1 input polarity
: TIM1.AF1.BKCMP2P ( -- x addr ) 11 bit TIM1.AF1 ; \ TIM1.AF1.BKCMP2P, BRK COMP2 input polarity
: TIM1.AF1.ETRSEL ( %bbb -- x addr ) 14 lshift TIM1.AF1 ; \ TIM1.AF1.ETRSEL, ETR source selection

\ TIM1.AF2 (read-write) Reset:$00000001
: TIM1.AF2.BK2INE ( -- x addr ) 0 bit TIM1.AF2 ; \ TIM1.AF2.BK2INE, BRK2 BKIN input enable
: TIM1.AF2.BK2CMP1E ( -- x addr ) 1 bit TIM1.AF2 ; \ TIM1.AF2.BK2CMP1E, BRK2 COMP1 enable
: TIM1.AF2.BK2CMP2E ( -- x addr ) 2 bit TIM1.AF2 ; \ TIM1.AF2.BK2CMP2E, BRK2 COMP2 enable
: TIM1.AF2.BK2DFBK0E ( -- x addr ) 8 bit TIM1.AF2 ; \ TIM1.AF2.BK2DFBK0E, BRK2 DFSDM_BREAK0 enable
: TIM1.AF2.BK2INP ( -- x addr ) 9 bit TIM1.AF2 ; \ TIM1.AF2.BK2INP, BRK2 BKIN input polarity
: TIM1.AF2.BK2CMP1P ( -- x addr ) 10 bit TIM1.AF2 ; \ TIM1.AF2.BK2CMP1P, BRK2 COMP1 input polarity
: TIM1.AF2.BK2CMP2P ( -- x addr ) 11 bit TIM1.AF2 ; \ TIM1.AF2.BK2CMP2P, BRK2 COMP2 input polarity

\ TIM1.TISEL (read-write) Reset:$00000000
: TIM1.TISEL.TI1SEL3_0 ( %bbbb -- x addr ) TIM1.TISEL ; \ TIM1.TISEL.TI1SEL3_0, selects TI1[0] to TI1[15]               input
: TIM1.TISEL.TI2SEL3_0 ( %bbbb -- x addr ) 8 lshift TIM1.TISEL ; \ TIM1.TISEL.TI2SEL3_0, selects TI2[0] to TI2[15]               input
: TIM1.TISEL.TI3SEL3_0 ( %bbbb -- x addr ) 16 lshift TIM1.TISEL ; \ TIM1.TISEL.TI3SEL3_0, selects TI3[0] to TI3[15]               input
: TIM1.TISEL.TI4SEL3_0 ( %bbbb -- x addr ) 24 lshift TIM1.TISEL ; \ TIM1.TISEL.TI4SEL3_0, selects TI4[0] to TI4[15]               input

\ ADC.ISR (read-write) Reset:$00000000
: ADC.ISR.CCRDY ( -- x addr ) 13 bit ADC.ISR ; \ ADC.ISR.CCRDY, Channel Configuration Ready               flag
: ADC.ISR.EOCAL ( -- x addr ) 11 bit ADC.ISR ; \ ADC.ISR.EOCAL, End Of Calibration flag
: ADC.ISR.AWD3 ( -- x addr ) 9 bit ADC.ISR ; \ ADC.ISR.AWD3, ADC analog watchdog 3 flag
: ADC.ISR.AWD2 ( -- x addr ) 8 bit ADC.ISR ; \ ADC.ISR.AWD2, ADC analog watchdog 2 flag
: ADC.ISR.AWD1 ( -- x addr ) 7 bit ADC.ISR ; \ ADC.ISR.AWD1, ADC analog watchdog 1 flag
: ADC.ISR.OVR ( -- x addr ) 4 bit ADC.ISR ; \ ADC.ISR.OVR, ADC group regular overrun               flag
: ADC.ISR.EOS ( -- x addr ) 3 bit ADC.ISR ; \ ADC.ISR.EOS, ADC group regular end of sequence               conversions flag
: ADC.ISR.EOC ( -- x addr ) 2 bit ADC.ISR ; \ ADC.ISR.EOC, ADC group regular end of unitary               conversion flag
: ADC.ISR.EOSMP ( -- x addr ) 1 bit ADC.ISR ; \ ADC.ISR.EOSMP, ADC group regular end of sampling               flag
: ADC.ISR.ADRDY ( -- x addr ) 0 bit ADC.ISR ; \ ADC.ISR.ADRDY, ADC ready flag

\ ADC.IER (read-write) Reset:$00000000
: ADC.IER.CCRDYIE ( -- x addr ) 13 bit ADC.IER ; \ ADC.IER.CCRDYIE, Channel Configuration Ready Interrupt               enable
: ADC.IER.EOCALIE ( -- x addr ) 11 bit ADC.IER ; \ ADC.IER.EOCALIE, End of calibration interrupt               enable
: ADC.IER.AWD3IE ( -- x addr ) 9 bit ADC.IER ; \ ADC.IER.AWD3IE, ADC analog watchdog 3               interrupt
: ADC.IER.AWD2IE ( -- x addr ) 8 bit ADC.IER ; \ ADC.IER.AWD2IE, ADC analog watchdog 2               interrupt
: ADC.IER.AWD1IE ( -- x addr ) 7 bit ADC.IER ; \ ADC.IER.AWD1IE, ADC analog watchdog 1               interrupt
: ADC.IER.OVRIE ( -- x addr ) 4 bit ADC.IER ; \ ADC.IER.OVRIE, ADC group regular overrun               interrupt
: ADC.IER.EOSIE ( -- x addr ) 3 bit ADC.IER ; \ ADC.IER.EOSIE, ADC group regular end of sequence               conversions interrupt
: ADC.IER.EOCIE ( -- x addr ) 2 bit ADC.IER ; \ ADC.IER.EOCIE, ADC group regular end of unitary               conversion interrupt
: ADC.IER.EOSMPIE ( -- x addr ) 1 bit ADC.IER ; \ ADC.IER.EOSMPIE, ADC group regular end of sampling               interrupt
: ADC.IER.ADRDYIE ( -- x addr ) 0 bit ADC.IER ; \ ADC.IER.ADRDYIE, ADC ready interrupt

\ ADC.CR (read-write) Reset:$00000000
: ADC.CR.ADCAL ( -- x addr ) 31 bit ADC.CR ; \ ADC.CR.ADCAL, ADC calibration
: ADC.CR.ADVREGEN ( -- x addr ) 28 bit ADC.CR ; \ ADC.CR.ADVREGEN, ADC voltage regulator               enable
: ADC.CR.ADSTP ( -- x addr ) 4 bit ADC.CR ; \ ADC.CR.ADSTP, ADC group regular conversion               stop
: ADC.CR.ADSTART ( -- x addr ) 2 bit ADC.CR ; \ ADC.CR.ADSTART, ADC group regular conversion               start
: ADC.CR.ADDIS ( -- x addr ) 1 bit ADC.CR ; \ ADC.CR.ADDIS, ADC disable
: ADC.CR.ADEN ( -- x addr ) 0 bit ADC.CR ; \ ADC.CR.ADEN, ADC enable

\ ADC.CFGR1 (read-write) Reset:$00000000
: ADC.CFGR1.AWDCH1CH ( %bbbbb -- x addr ) 26 lshift ADC.CFGR1 ; \ ADC.CFGR1.AWDCH1CH, ADC analog watchdog 1 monitored channel               selection
: ADC.CFGR1.AWD1EN ( -- x addr ) 23 bit ADC.CFGR1 ; \ ADC.CFGR1.AWD1EN, ADC analog watchdog 1 enable on scope               ADC group regular
: ADC.CFGR1.AWD1SGL ( -- x addr ) 22 bit ADC.CFGR1 ; \ ADC.CFGR1.AWD1SGL, ADC analog watchdog 1 monitoring a               single channel or all channels
: ADC.CFGR1.CHSELRMOD ( -- x addr ) 21 bit ADC.CFGR1 ; \ ADC.CFGR1.CHSELRMOD, Mode selection of the ADC_CHSELR               register
: ADC.CFGR1.DISCEN ( -- x addr ) 16 bit ADC.CFGR1 ; \ ADC.CFGR1.DISCEN, ADC group regular sequencer               discontinuous mode
: ADC.CFGR1.AUTOFF ( -- x addr ) 15 bit ADC.CFGR1 ; \ ADC.CFGR1.AUTOFF, Auto-off mode
: ADC.CFGR1.WAIT ( -- x addr ) 14 bit ADC.CFGR1 ; \ ADC.CFGR1.WAIT, Wait conversion mode
: ADC.CFGR1.CONT ( -- x addr ) 13 bit ADC.CFGR1 ; \ ADC.CFGR1.CONT, ADC group regular continuous conversion               mode
: ADC.CFGR1.OVRMOD ( -- x addr ) 12 bit ADC.CFGR1 ; \ ADC.CFGR1.OVRMOD, ADC group regular overrun               configuration
: ADC.CFGR1.EXTEN ( %bb -- x addr ) 10 lshift ADC.CFGR1 ; \ ADC.CFGR1.EXTEN, ADC group regular external trigger               polarity
: ADC.CFGR1.EXTSEL ( %bbb -- x addr ) 6 lshift ADC.CFGR1 ; \ ADC.CFGR1.EXTSEL, ADC group regular external trigger               source
: ADC.CFGR1.ALIGN ( -- x addr ) 5 bit ADC.CFGR1 ; \ ADC.CFGR1.ALIGN, ADC data alignement
: ADC.CFGR1.RES ( %bb -- x addr ) 3 lshift ADC.CFGR1 ; \ ADC.CFGR1.RES, ADC data resolution
: ADC.CFGR1.SCANDIR ( -- x addr ) 2 bit ADC.CFGR1 ; \ ADC.CFGR1.SCANDIR, Scan sequence direction
: ADC.CFGR1.DMACFG ( -- x addr ) 1 bit ADC.CFGR1 ; \ ADC.CFGR1.DMACFG, ADC DMA transfer               configuration
: ADC.CFGR1.DMAEN ( -- x addr ) 0 bit ADC.CFGR1 ; \ ADC.CFGR1.DMAEN, ADC DMA transfer enable

\ ADC.CFGR2 (read-write) Reset:$00000000
: ADC.CFGR2.CKMODE ( %bb -- x addr ) 30 lshift ADC.CFGR2 ; \ ADC.CFGR2.CKMODE, ADC clock mode
: ADC.CFGR2.LFTRIG ( -- x addr ) 29 bit ADC.CFGR2 ; \ ADC.CFGR2.LFTRIG, Low frequency trigger mode               enable
: ADC.CFGR2.TOVS ( -- x addr ) 9 bit ADC.CFGR2 ; \ ADC.CFGR2.TOVS, ADC oversampling discontinuous mode               (triggered mode) for ADC group regular
: ADC.CFGR2.OVSS ( %bbbb -- x addr ) 5 lshift ADC.CFGR2 ; \ ADC.CFGR2.OVSS, ADC oversampling shift
: ADC.CFGR2.OVSR ( %bbb -- x addr ) 2 lshift ADC.CFGR2 ; \ ADC.CFGR2.OVSR, ADC oversampling ratio
: ADC.CFGR2.OVSE ( -- x addr ) 0 bit ADC.CFGR2 ; \ ADC.CFGR2.OVSE, ADC oversampler enable on scope ADC               group regular

\ ADC.SMPR (read-write) Reset:$00000000
: ADC.SMPR.SMP1 ( %bbb -- x addr ) ADC.SMPR ; \ ADC.SMPR.SMP1, Sampling time selection
: ADC.SMPR.SMP2 ( %bbb -- x addr ) 4 lshift ADC.SMPR ; \ ADC.SMPR.SMP2, Sampling time selection
: ADC.SMPR.SMPSEL x addr ) 8 lshift ADC.SMPR ; \ ADC.SMPR.SMPSEL, Channel sampling time               selection

\ ADC.AWD1TR (read-write) Reset:$0FFF0000
: ADC.AWD1TR.HT1 ( %bbbbbbbbbbb -- x addr ) 16 lshift ADC.AWD1TR ; \ ADC.AWD1TR.HT1, ADC analog watchdog 1 threshold               high
: ADC.AWD1TR.LT1 ( %bbbbbbbbbbb -- x addr ) ADC.AWD1TR ; \ ADC.AWD1TR.LT1, ADC analog watchdog 1 threshold               low

\ ADC.AWD2TR (read-write) Reset:$0FFF0000
: ADC.AWD2TR.HT2 ( %bbbbbbbbbbb -- x addr ) 16 lshift ADC.AWD2TR ; \ ADC.AWD2TR.HT2, ADC analog watchdog 2 threshold               high
: ADC.AWD2TR.LT2 ( %bbbbbbbbbbb -- x addr ) ADC.AWD2TR ; \ ADC.AWD2TR.LT2, ADC analog watchdog 2 threshold               low

\ ADC.CHSELR (read-write) Reset:$0FFF0000
: ADC.CHSELR.CHSEL x addr ) ADC.CHSELR ; \ ADC.CHSELR.CHSEL, Channel-x selection

\ ADC.CHSELR_1 (read-write) Reset:$00000000
: ADC.CHSELR_1.SQ1 ( %bbbb -- x addr ) ADC.CHSELR_1 ; \ ADC.CHSELR_1.SQ1, conversion of the sequence
: ADC.CHSELR_1.SQ2 ( %bbbb -- x addr ) 4 lshift ADC.CHSELR_1 ; \ ADC.CHSELR_1.SQ2, conversion of the sequence
: ADC.CHSELR_1.SQ3 ( %bbbb -- x addr ) 8 lshift ADC.CHSELR_1 ; \ ADC.CHSELR_1.SQ3, conversion of the sequence
: ADC.CHSELR_1.SQ4 ( %bbbb -- x addr ) 12 lshift ADC.CHSELR_1 ; \ ADC.CHSELR_1.SQ4, conversion of the sequence
: ADC.CHSELR_1.SQ5 ( %bbbb -- x addr ) 16 lshift ADC.CHSELR_1 ; \ ADC.CHSELR_1.SQ5, conversion of the sequence
: ADC.CHSELR_1.SQ6 ( %bbbb -- x addr ) 20 lshift ADC.CHSELR_1 ; \ ADC.CHSELR_1.SQ6, conversion of the sequence
: ADC.CHSELR_1.SQ7 ( %bbbb -- x addr ) 24 lshift ADC.CHSELR_1 ; \ ADC.CHSELR_1.SQ7, conversion of the sequence
: ADC.CHSELR_1.SQ8 ( %bbbb -- x addr ) 28 lshift ADC.CHSELR_1 ; \ ADC.CHSELR_1.SQ8, conversion of the sequence

\ ADC.AWD3TR (read-write) Reset:$0FFF0000
: ADC.AWD3TR.HT3 ( %bbbbbbbbbbb -- x addr ) 16 lshift ADC.AWD3TR ; \ ADC.AWD3TR.HT3, ADC analog watchdog 3 threshold               high
: ADC.AWD3TR.LT3 ( %bbbbbbbbbbb -- x addr ) ADC.AWD3TR ; \ ADC.AWD3TR.LT3, ADC analog watchdog 3 threshold               high

\ ADC.DR (read-only) Reset:$00000000
: ADC.DR.regularDATA? ( --  x ) ADC.DR @ ; \ ADC.DR.regularDATA, ADC group regular conversion               data

\ ADC.AWD2CR (read-write) Reset:$00000000
: ADC.AWD2CR.AWD2CH x addr ) ADC.AWD2CR ; \ ADC.AWD2CR.AWD2CH, ADC analog watchdog 2 monitored channel               selection

\ ADC.AWD3CR (read-write) Reset:$00000000
: ADC.AWD3CR.AWD3CH x addr ) ADC.AWD3CR ; \ ADC.AWD3CR.AWD3CH, ADC analog watchdog 3 monitored channel               selection

\ ADC.CALFACT (read-write) Reset:$00000000
: ADC.CALFACT.CALFACT ( %bbbbbbb -- x addr ) ADC.CALFACT ; \ ADC.CALFACT.CALFACT, ADC calibration factor in single-ended               mode

\ ADC.CCR (read-write) Reset:$00000000
: ADC.CCR.PRESC ( %bbbb -- x addr ) 18 lshift ADC.CCR ; \ ADC.CCR.PRESC, ADC prescaler
: ADC.CCR.VREFEN ( -- x addr ) 22 bit ADC.CCR ; \ ADC.CCR.VREFEN, VREFINT enable
: ADC.CCR.TSEN ( -- x addr ) 23 bit ADC.CCR ; \ ADC.CCR.TSEN, Temperature sensor enable
: ADC.CCR.VBATEN ( -- x addr ) 24 bit ADC.CCR ; \ ADC.CCR.VBATEN, VBAT enable

\ SYSCFG.CFGR1 (read-write) Reset:$00000000
: SYSCFG.CFGR1.I2C_PAx_FMP ( %bb -- x addr ) 22 lshift SYSCFG.CFGR1 ; \ SYSCFG.CFGR1.I2C_PAx_FMP, Fast Mode Plus (FM+) driving capability               activation bits
: SYSCFG.CFGR1.I2C2_FMP ( -- x addr ) 21 bit SYSCFG.CFGR1 ; \ SYSCFG.CFGR1.I2C2_FMP, FM+ driving capability activation for               I2C2
: SYSCFG.CFGR1.I2C1_FMP ( -- x addr ) 20 bit SYSCFG.CFGR1 ; \ SYSCFG.CFGR1.I2C1_FMP, FM+ driving capability activation for               I2C1
: SYSCFG.CFGR1.I2C_PBx_FMP ( %bbbb -- x addr ) 16 lshift SYSCFG.CFGR1 ; \ SYSCFG.CFGR1.I2C_PBx_FMP, Fast Mode Plus (FM+) driving capability               activation bits
: SYSCFG.CFGR1.BOOSTEN ( -- x addr ) 8 bit SYSCFG.CFGR1 ; \ SYSCFG.CFGR1.BOOSTEN, I/O analog switch voltage booster               enable
: SYSCFG.CFGR1.IR_MOD ( %bb -- x addr ) 6 lshift SYSCFG.CFGR1 ; \ SYSCFG.CFGR1.IR_MOD, IR Modulation Envelope signal               selection.
: SYSCFG.CFGR1.IR_POL ( -- x addr ) 5 bit SYSCFG.CFGR1 ; \ SYSCFG.CFGR1.IR_POL, IR output polarity               selection
: SYSCFG.CFGR1.PA11_PA12_RMP ( -- x addr ) 4 bit SYSCFG.CFGR1 ; \ SYSCFG.CFGR1.PA11_PA12_RMP, PA11 and PA12 remapping               bit.
: SYSCFG.CFGR1.MEM_MODE ( %bb -- x addr ) SYSCFG.CFGR1 ; \ SYSCFG.CFGR1.MEM_MODE, Memory mapping selection               bits

\ SYSCFG.CFGR2 (read-write) Reset:$00000000
: SYSCFG.CFGR2.LOCKUP_LOCK ( -- x addr ) 0 bit SYSCFG.CFGR2 ; \ SYSCFG.CFGR2.LOCKUP_LOCK, Cortex-M0+ LOCKUP bit enable               bit
: SYSCFG.CFGR2.SRAM_PARITY_LOCK ( -- x addr ) 1 bit SYSCFG.CFGR2 ; \ SYSCFG.CFGR2.SRAM_PARITY_LOCK, SRAM parity lock bit
: SYSCFG.CFGR2.PVD_LOCK ( -- x addr ) 2 bit SYSCFG.CFGR2 ; \ SYSCFG.CFGR2.PVD_LOCK, PVD lock enable bit
: SYSCFG.CFGR2.ECC_LOCK ( -- x addr ) 3 bit SYSCFG.CFGR2 ; \ SYSCFG.CFGR2.ECC_LOCK, ECC error lock bit
: SYSCFG.CFGR2.SRAM_PEF ( -- x addr ) 8 bit SYSCFG.CFGR2 ; \ SYSCFG.CFGR2.SRAM_PEF, SRAM parity error flag
: SYSCFG.CFGR2.PA1_CDEN ( -- x addr ) 16 bit SYSCFG.CFGR2 ; \ SYSCFG.CFGR2.PA1_CDEN, PA1_CDEN
: SYSCFG.CFGR2.PA3_CDEN ( -- x addr ) 17 bit SYSCFG.CFGR2 ; \ SYSCFG.CFGR2.PA3_CDEN, PA3_CDEN
: SYSCFG.CFGR2.PA5_CDEN ( -- x addr ) 18 bit SYSCFG.CFGR2 ; \ SYSCFG.CFGR2.PA5_CDEN, PA5_CDEN
: SYSCFG.CFGR2.PA6_CDEN ( -- x addr ) 19 bit SYSCFG.CFGR2 ; \ SYSCFG.CFGR2.PA6_CDEN, PA6_CDEN
: SYSCFG.CFGR2.PA13_CDEN ( -- x addr ) 20 bit SYSCFG.CFGR2 ; \ SYSCFG.CFGR2.PA13_CDEN, PA13_CDEN
: SYSCFG.CFGR2.PB0_CDEN ( -- x addr ) 21 bit SYSCFG.CFGR2 ; \ SYSCFG.CFGR2.PB0_CDEN, PB0_CDEN
: SYSCFG.CFGR2.PB1_CDEN ( -- x addr ) 22 bit SYSCFG.CFGR2 ; \ SYSCFG.CFGR2.PB1_CDEN, PB1_CDEN
: SYSCFG.CFGR2.PB2_CDEN ( -- x addr ) 23 bit SYSCFG.CFGR2 ; \ SYSCFG.CFGR2.PB2_CDEN, PB2_CDEN

\ TAMP.CR1 (read-write) Reset:$FFFF0000
: TAMP.CR1.TAMP1E ( -- x addr ) 0 bit TAMP.CR1 ; \ TAMP.CR1.TAMP1E, TAMP1E
: TAMP.CR1.TAMP2E ( -- x addr ) 1 bit TAMP.CR1 ; \ TAMP.CR1.TAMP2E, TAMP2E
: TAMP.CR1.ITAMP1E ( -- x addr ) 16 bit TAMP.CR1 ; \ TAMP.CR1.ITAMP1E, ITAMP1E
: TAMP.CR1.ITAMP3E ( -- x addr ) 18 bit TAMP.CR1 ; \ TAMP.CR1.ITAMP3E, ITAMP3E
: TAMP.CR1.ITAMP4E ( -- x addr ) 19 bit TAMP.CR1 ; \ TAMP.CR1.ITAMP4E, ITAMP4E
: TAMP.CR1.ITAMP5E ( -- x addr ) 20 bit TAMP.CR1 ; \ TAMP.CR1.ITAMP5E, ITAMP5E
: TAMP.CR1.ITAMP6E ( -- x addr ) 21 bit TAMP.CR1 ; \ TAMP.CR1.ITAMP6E, ITAMP6E

\ TAMP.CR2 (read-write) Reset:$00000000
: TAMP.CR2.TAMP1NOER ( -- x addr ) 0 bit TAMP.CR2 ; \ TAMP.CR2.TAMP1NOER, TAMP1NOER
: TAMP.CR2.TAMP2NOER ( -- x addr ) 1 bit TAMP.CR2 ; \ TAMP.CR2.TAMP2NOER, TAMP2NOER
: TAMP.CR2.TAMP1MSK ( -- x addr ) 16 bit TAMP.CR2 ; \ TAMP.CR2.TAMP1MSK, TAMP1MSK
: TAMP.CR2.TAMP2MSK ( -- x addr ) 17 bit TAMP.CR2 ; \ TAMP.CR2.TAMP2MSK, TAMP2MSK
: TAMP.CR2.TAMP1TRG ( -- x addr ) 24 bit TAMP.CR2 ; \ TAMP.CR2.TAMP1TRG, TAMP1TRG
: TAMP.CR2.TAMP2TRG ( -- x addr ) 25 bit TAMP.CR2 ; \ TAMP.CR2.TAMP2TRG, TAMP2TRG

\ TAMP.FLTCR (read-write) Reset:$00000000
: TAMP.FLTCR.TAMPFREQ ( %bbb -- x addr ) TAMP.FLTCR ; \ TAMP.FLTCR.TAMPFREQ, TAMPFREQ
: TAMP.FLTCR.TAMPFLT ( %bb -- x addr ) 3 lshift TAMP.FLTCR ; \ TAMP.FLTCR.TAMPFLT, TAMPFLT
: TAMP.FLTCR.TAMPPRCH ( %bb -- x addr ) 5 lshift TAMP.FLTCR ; \ TAMP.FLTCR.TAMPPRCH, TAMPPRCH
: TAMP.FLTCR.TAMPPUDIS ( -- x addr ) 7 bit TAMP.FLTCR ; \ TAMP.FLTCR.TAMPPUDIS, TAMPPUDIS

\ TAMP.IER (read-write) Reset:$00000000
: TAMP.IER.TAMP1IE ( -- x addr ) 0 bit TAMP.IER ; \ TAMP.IER.TAMP1IE, TAMP1IE
: TAMP.IER.TAMP2IE ( -- x addr ) 1 bit TAMP.IER ; \ TAMP.IER.TAMP2IE, TAMP2IE
: TAMP.IER.ITAMP1IE ( -- x addr ) 16 bit TAMP.IER ; \ TAMP.IER.ITAMP1IE, ITAMP1IE
: TAMP.IER.ITAMP3IE ( -- x addr ) 18 bit TAMP.IER ; \ TAMP.IER.ITAMP3IE, ITAMP3IE
: TAMP.IER.ITAMP4IE ( -- x addr ) 19 bit TAMP.IER ; \ TAMP.IER.ITAMP4IE, ITAMP4IE
: TAMP.IER.ITAMP5IE ( -- x addr ) 20 bit TAMP.IER ; \ TAMP.IER.ITAMP5IE, ITAMP5IE
: TAMP.IER.ITAMP6IE ( -- x addr ) 21 bit TAMP.IER ; \ TAMP.IER.ITAMP6IE, ITAMP6IE

\ TAMP.SR (read-only) Reset:$00000000
: TAMP.SR.TAMP1F? ( --  1|0 ) 0 bit TAMP.SR bit@ ; \ TAMP.SR.TAMP1F, TAMP1F
: TAMP.SR.TAMP2F? ( --  1|0 ) 1 bit TAMP.SR bit@ ; \ TAMP.SR.TAMP2F, TAMP2F
: TAMP.SR.ITAMP1F? ( --  1|0 ) 16 bit TAMP.SR bit@ ; \ TAMP.SR.ITAMP1F, ITAMP1F
: TAMP.SR.ITAMP3F? ( --  1|0 ) 18 bit TAMP.SR bit@ ; \ TAMP.SR.ITAMP3F, ITAMP3F
: TAMP.SR.ITAMP4F? ( --  1|0 ) 19 bit TAMP.SR bit@ ; \ TAMP.SR.ITAMP4F, ITAMP4F
: TAMP.SR.ITAMP5F? ( --  1|0 ) 20 bit TAMP.SR bit@ ; \ TAMP.SR.ITAMP5F, ITAMP5F
: TAMP.SR.ITAMP6F? ( --  1|0 ) 21 bit TAMP.SR bit@ ; \ TAMP.SR.ITAMP6F, ITAMP6F
: TAMP.SR.ITAMP7F? ( --  1|0 ) 22 bit TAMP.SR bit@ ; \ TAMP.SR.ITAMP7F, ITAMP7F

\ TAMP.MISR (read-only) Reset:$00000000
: TAMP.MISR.TAMP1MF? ( --  1|0 ) 0 bit TAMP.MISR bit@ ; \ TAMP.MISR.TAMP1MF, TAMP1MF:
: TAMP.MISR.TAMP2MF? ( --  1|0 ) 1 bit TAMP.MISR bit@ ; \ TAMP.MISR.TAMP2MF, TAMP2MF
: TAMP.MISR.ITAMP1MF? ( --  1|0 ) 16 bit TAMP.MISR bit@ ; \ TAMP.MISR.ITAMP1MF, ITAMP1MF
: TAMP.MISR.ITAMP3MF? ( --  1|0 ) 18 bit TAMP.MISR bit@ ; \ TAMP.MISR.ITAMP3MF, ITAMP3MF
: TAMP.MISR.ITAMP4MF? ( --  1|0 ) 19 bit TAMP.MISR bit@ ; \ TAMP.MISR.ITAMP4MF, ITAMP4MF
: TAMP.MISR.ITAMP5MF? ( --  1|0 ) 20 bit TAMP.MISR bit@ ; \ TAMP.MISR.ITAMP5MF, ITAMP5MF
: TAMP.MISR.ITAMP6MF? ( --  1|0 ) 21 bit TAMP.MISR bit@ ; \ TAMP.MISR.ITAMP6MF, ITAMP6MF

\ TAMP.SCR (write-only) Reset:$00000000
: TAMP.SCR.CTAMP1F ( -- x addr ) 0 bit TAMP.SCR ; \ TAMP.SCR.CTAMP1F, CTAMP1F
: TAMP.SCR.CTAMP2F ( -- x addr ) 1 bit TAMP.SCR ; \ TAMP.SCR.CTAMP2F, CTAMP2F
: TAMP.SCR.CITAMP1F ( -- x addr ) 16 bit TAMP.SCR ; \ TAMP.SCR.CITAMP1F, CITAMP1F
: TAMP.SCR.CITAMP3F ( -- x addr ) 18 bit TAMP.SCR ; \ TAMP.SCR.CITAMP3F, CITAMP3F
: TAMP.SCR.CITAMP4F ( -- x addr ) 19 bit TAMP.SCR ; \ TAMP.SCR.CITAMP4F, CITAMP4F
: TAMP.SCR.CITAMP5F ( -- x addr ) 20 bit TAMP.SCR ; \ TAMP.SCR.CITAMP5F, CITAMP5F
: TAMP.SCR.CITAMP6F ( -- x addr ) 21 bit TAMP.SCR ; \ TAMP.SCR.CITAMP6F, CITAMP6F
: TAMP.SCR.CITAMP7F ( -- x addr ) 22 bit TAMP.SCR ; \ TAMP.SCR.CITAMP7F, CITAMP7F

\ TAMP.BKP0R (read-write) Reset:$00000000
: TAMP.BKP0R.BKP ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) TAMP.BKP0R ; \ TAMP.BKP0R.BKP, BKP

\ TAMP.BKP1R (read-write) Reset:$00000000
: TAMP.BKP1R.BKP ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) TAMP.BKP1R ; \ TAMP.BKP1R.BKP, BKP

\ TAMP.BKP2R (read-write) Reset:$00000000
: TAMP.BKP2R.BKP ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) TAMP.BKP2R ; \ TAMP.BKP2R.BKP, BKP

\ TAMP.BKP3R (read-write) Reset:$00000000
: TAMP.BKP3R.BKP ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) TAMP.BKP3R ; \ TAMP.BKP3R.BKP, BKP

\ TAMP.BKP4R (read-write) Reset:$00000000
: TAMP.BKP4R.BKP ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) TAMP.BKP4R ; \ TAMP.BKP4R.BKP, BKP

\ I2C1.CR1 (read-write) Reset:$00000000
: I2C1.CR1.PE ( -- x addr ) 0 bit I2C1.CR1 ; \ I2C1.CR1.PE, Peripheral enable
: I2C1.CR1.TXIE ( -- x addr ) 1 bit I2C1.CR1 ; \ I2C1.CR1.TXIE, TX Interrupt enable
: I2C1.CR1.RXIE ( -- x addr ) 2 bit I2C1.CR1 ; \ I2C1.CR1.RXIE, RX Interrupt enable
: I2C1.CR1.ADDRIE ( -- x addr ) 3 bit I2C1.CR1 ; \ I2C1.CR1.ADDRIE, Address match interrupt enable (slave               only)
: I2C1.CR1.NACKIE ( -- x addr ) 4 bit I2C1.CR1 ; \ I2C1.CR1.NACKIE, Not acknowledge received interrupt               enable
: I2C1.CR1.STOPIE ( -- x addr ) 5 bit I2C1.CR1 ; \ I2C1.CR1.STOPIE, STOP detection Interrupt               enable
: I2C1.CR1.TCIE ( -- x addr ) 6 bit I2C1.CR1 ; \ I2C1.CR1.TCIE, Transfer Complete interrupt               enable
: I2C1.CR1.ERRIE ( -- x addr ) 7 bit I2C1.CR1 ; \ I2C1.CR1.ERRIE, Error interrupts enable
: I2C1.CR1.DNF ( %bbbb -- x addr ) 8 lshift I2C1.CR1 ; \ I2C1.CR1.DNF, Digital noise filter
: I2C1.CR1.ANFOFF ( -- x addr ) 12 bit I2C1.CR1 ; \ I2C1.CR1.ANFOFF, Analog noise filter OFF
: I2C1.CR1.TXDMAEN ( -- x addr ) 14 bit I2C1.CR1 ; \ I2C1.CR1.TXDMAEN, DMA transmission requests               enable
: I2C1.CR1.RXDMAEN ( -- x addr ) 15 bit I2C1.CR1 ; \ I2C1.CR1.RXDMAEN, DMA reception requests               enable
: I2C1.CR1.SBC ( -- x addr ) 16 bit I2C1.CR1 ; \ I2C1.CR1.SBC, Slave byte control
: I2C1.CR1.NOSTRETCH ( -- x addr ) 17 bit I2C1.CR1 ; \ I2C1.CR1.NOSTRETCH, Clock stretching disable
: I2C1.CR1.WUPEN ( -- x addr ) 18 bit I2C1.CR1 ; \ I2C1.CR1.WUPEN, Wakeup from STOP enable
: I2C1.CR1.GCEN ( -- x addr ) 19 bit I2C1.CR1 ; \ I2C1.CR1.GCEN, General call enable
: I2C1.CR1.SMBHEN ( -- x addr ) 20 bit I2C1.CR1 ; \ I2C1.CR1.SMBHEN, SMBus Host address enable
: I2C1.CR1.SMBDEN ( -- x addr ) 21 bit I2C1.CR1 ; \ I2C1.CR1.SMBDEN, SMBus Device Default address               enable
: I2C1.CR1.ALERTEN ( -- x addr ) 22 bit I2C1.CR1 ; \ I2C1.CR1.ALERTEN, SMBUS alert enable
: I2C1.CR1.PECEN ( -- x addr ) 23 bit I2C1.CR1 ; \ I2C1.CR1.PECEN, PEC enable

\ I2C1.CR2 (read-write) Reset:$00000000
: I2C1.CR2.PECBYTE ( -- x addr ) 26 bit I2C1.CR2 ; \ I2C1.CR2.PECBYTE, Packet error checking byte
: I2C1.CR2.AUTOEND ( -- x addr ) 25 bit I2C1.CR2 ; \ I2C1.CR2.AUTOEND, Automatic end mode (master               mode)
: I2C1.CR2.RELOAD ( -- x addr ) 24 bit I2C1.CR2 ; \ I2C1.CR2.RELOAD, NBYTES reload mode
: I2C1.CR2.NBYTES ( %bbbbbbbb -- x addr ) 16 lshift I2C1.CR2 ; \ I2C1.CR2.NBYTES, Number of bytes
: I2C1.CR2.NACK ( -- x addr ) 15 bit I2C1.CR2 ; \ I2C1.CR2.NACK, NACK generation (slave               mode)
: I2C1.CR2.STOP ( -- x addr ) 14 bit I2C1.CR2 ; \ I2C1.CR2.STOP, Stop generation (master               mode)
: I2C1.CR2.START ( -- x addr ) 13 bit I2C1.CR2 ; \ I2C1.CR2.START, Start generation
: I2C1.CR2.HEAD10R ( -- x addr ) 12 bit I2C1.CR2 ; \ I2C1.CR2.HEAD10R, 10-bit address header only read               direction (master receiver mode)
: I2C1.CR2.ADD10 ( -- x addr ) 11 bit I2C1.CR2 ; \ I2C1.CR2.ADD10, 10-bit addressing mode (master               mode)
: I2C1.CR2.RD_WRN ( -- x addr ) 10 bit I2C1.CR2 ; \ I2C1.CR2.RD_WRN, Transfer direction (master               mode)
: I2C1.CR2.SADD ( %bbbbbbbbbb -- x addr ) I2C1.CR2 ; \ I2C1.CR2.SADD, Slave address bit (master               mode)

\ I2C1.OAR1 (read-write) Reset:$00000000
: I2C1.OAR1.OA1_0 ( -- x addr ) 0 bit I2C1.OAR1 ; \ I2C1.OAR1.OA1_0, Interface address
: I2C1.OAR1.OA1_7_1 ( %bbbbbbb -- x addr ) 1 lshift I2C1.OAR1 ; \ I2C1.OAR1.OA1_7_1, Interface address
: I2C1.OAR1.OA1_8_9 ( %bb -- x addr ) 8 lshift I2C1.OAR1 ; \ I2C1.OAR1.OA1_8_9, Interface address
: I2C1.OAR1.OA1MODE ( -- x addr ) 10 bit I2C1.OAR1 ; \ I2C1.OAR1.OA1MODE, Own Address 1 10-bit mode
: I2C1.OAR1.OA1EN ( -- x addr ) 15 bit I2C1.OAR1 ; \ I2C1.OAR1.OA1EN, Own Address 1 enable

\ I2C1.OAR2 (read-write) Reset:$00000000
: I2C1.OAR2.OA2 ( %bbbbbbb -- x addr ) 1 lshift I2C1.OAR2 ; \ I2C1.OAR2.OA2, Interface address
: I2C1.OAR2.OA2MSK ( %bbb -- x addr ) 8 lshift I2C1.OAR2 ; \ I2C1.OAR2.OA2MSK, Own Address 2 masks
: I2C1.OAR2.OA2EN ( -- x addr ) 15 bit I2C1.OAR2 ; \ I2C1.OAR2.OA2EN, Own Address 2 enable

\ I2C1.TIMINGR (read-write) Reset:$00000000
: I2C1.TIMINGR.SCLL ( %bbbbbbbb -- x addr ) I2C1.TIMINGR ; \ I2C1.TIMINGR.SCLL, SCL low period (master               mode)
: I2C1.TIMINGR.SCLH ( %bbbbbbbb -- x addr ) 8 lshift I2C1.TIMINGR ; \ I2C1.TIMINGR.SCLH, SCL high period (master               mode)
: I2C1.TIMINGR.SDADEL ( %bbbb -- x addr ) 16 lshift I2C1.TIMINGR ; \ I2C1.TIMINGR.SDADEL, Data hold time
: I2C1.TIMINGR.SCLDEL ( %bbbb -- x addr ) 20 lshift I2C1.TIMINGR ; \ I2C1.TIMINGR.SCLDEL, Data setup time
: I2C1.TIMINGR.PRESC ( %bbbb -- x addr ) 28 lshift I2C1.TIMINGR ; \ I2C1.TIMINGR.PRESC, Timing prescaler

\ I2C1.TIMEOUTR (read-write) Reset:$00000000
: I2C1.TIMEOUTR.TIMEOUTA ( %bbbbbbbbbbb -- x addr ) I2C1.TIMEOUTR ; \ I2C1.TIMEOUTR.TIMEOUTA, Bus timeout A
: I2C1.TIMEOUTR.TIDLE ( -- x addr ) 12 bit I2C1.TIMEOUTR ; \ I2C1.TIMEOUTR.TIDLE, Idle clock timeout               detection
: I2C1.TIMEOUTR.TIMOUTEN ( -- x addr ) 15 bit I2C1.TIMEOUTR ; \ I2C1.TIMEOUTR.TIMOUTEN, Clock timeout enable
: I2C1.TIMEOUTR.TIMEOUTB ( %bbbbbbbbbbb -- x addr ) 16 lshift I2C1.TIMEOUTR ; \ I2C1.TIMEOUTR.TIMEOUTB, Bus timeout B
: I2C1.TIMEOUTR.TEXTEN ( -- x addr ) 31 bit I2C1.TIMEOUTR ; \ I2C1.TIMEOUTR.TEXTEN, Extended clock timeout               enable

\ I2C1.ISR (multiple-access)  Reset:$00000001
: I2C1.ISR.ADDCODE ( %bbbbbbb -- x addr ) 17 lshift I2C1.ISR ; \ I2C1.ISR.ADDCODE, Address match code (Slave               mode)
: I2C1.ISR.DIR ( -- x addr ) 16 bit I2C1.ISR ; \ I2C1.ISR.DIR, Transfer direction (Slave               mode)
: I2C1.ISR.BUSY ( -- x addr ) 15 bit I2C1.ISR ; \ I2C1.ISR.BUSY, Bus busy
: I2C1.ISR.ALERT ( -- x addr ) 13 bit I2C1.ISR ; \ I2C1.ISR.ALERT, SMBus alert
: I2C1.ISR.TIMEOUT? ( -- 1|0 ) 12 bit I2C1.ISR bit@ ; \ I2C1.ISR.TIMEOUT, Timeout or t_low detection               flag
: I2C1.ISR.PECERR ( -- x addr ) 11 bit I2C1.ISR ; \ I2C1.ISR.PECERR, PEC Error in reception
: I2C1.ISR.OVR ( -- x addr ) 10 bit I2C1.ISR ; \ I2C1.ISR.OVR, Overrun/Underrun (slave               mode)
: I2C1.ISR.ARLO ( -- x addr ) 9 bit I2C1.ISR ; \ I2C1.ISR.ARLO, Arbitration lost
: I2C1.ISR.BERR ( -- x addr ) 8 bit I2C1.ISR ; \ I2C1.ISR.BERR, Bus error
: I2C1.ISR.TCR ( -- x addr ) 7 bit I2C1.ISR ; \ I2C1.ISR.TCR, Transfer Complete Reload
: I2C1.ISR.TC ( -- x addr ) 6 bit I2C1.ISR ; \ I2C1.ISR.TC, Transfer Complete (master               mode)
: I2C1.ISR.STOPF? ( -- 1|0 ) 5 bit I2C1.ISR bit@ ; \ I2C1.ISR.STOPF, Stop detection flag
: I2C1.ISR.NACKF? ( -- 1|0 ) 4 bit I2C1.ISR bit@ ; \ I2C1.ISR.NACKF, Not acknowledge received               flag
: I2C1.ISR.ADDR ( -- x addr ) 3 bit I2C1.ISR ; \ I2C1.ISR.ADDR, Address matched (slave               mode)
: I2C1.ISR.RXNE ( -- x addr ) 2 bit I2C1.ISR ; \ I2C1.ISR.RXNE, Receive data register not empty               (receivers)
: I2C1.ISR.TXIS? ( -- 1|0 ) 1 bit I2C1.ISR bit@ ; \ I2C1.ISR.TXIS, Transmit interrupt status               (transmitters)
: I2C1.ISR.TXE ( -- x addr ) 0 bit I2C1.ISR ; \ I2C1.ISR.TXE, Transmit data register empty               (transmitters)

\ I2C1.ICR (write-only) Reset:$00000000
: I2C1.ICR.ALERTCF ( -- x addr ) 13 bit I2C1.ICR ; \ I2C1.ICR.ALERTCF, Alert flag clear
: I2C1.ICR.TIMOUTCF ( -- x addr ) 12 bit I2C1.ICR ; \ I2C1.ICR.TIMOUTCF, Timeout detection flag               clear
: I2C1.ICR.PECCF ( -- x addr ) 11 bit I2C1.ICR ; \ I2C1.ICR.PECCF, PEC Error flag clear
: I2C1.ICR.OVRCF ( -- x addr ) 10 bit I2C1.ICR ; \ I2C1.ICR.OVRCF, Overrun/Underrun flag               clear
: I2C1.ICR.ARLOCF ( -- x addr ) 9 bit I2C1.ICR ; \ I2C1.ICR.ARLOCF, Arbitration lost flag               clear
: I2C1.ICR.BERRCF ( -- x addr ) 8 bit I2C1.ICR ; \ I2C1.ICR.BERRCF, Bus error flag clear
: I2C1.ICR.STOPCF ( -- x addr ) 5 bit I2C1.ICR ; \ I2C1.ICR.STOPCF, Stop detection flag clear
: I2C1.ICR.NACKCF ( -- x addr ) 4 bit I2C1.ICR ; \ I2C1.ICR.NACKCF, Not Acknowledge flag clear
: I2C1.ICR.ADDRCF ( -- x addr ) 3 bit I2C1.ICR ; \ I2C1.ICR.ADDRCF, Address Matched flag clear

\ I2C1.PECR (read-only) Reset:$00000000
: I2C1.PECR.PEC? ( --  x ) I2C1.PECR @ ; \ I2C1.PECR.PEC, Packet error checking               register

\ I2C1.RXDR (read-only) Reset:$00000000
: I2C1.RXDR.RXDATA? ( --  x ) I2C1.RXDR @ ; \ I2C1.RXDR.RXDATA, 8-bit receive data

\ I2C1.TXDR (read-write) Reset:$00000000
: I2C1.TXDR.TXDATA ( %bbbbbbbb -- x addr ) I2C1.TXDR ; \ I2C1.TXDR.TXDATA, 8-bit transmit data

\ I2C2.CR1 (read-write) Reset:$00000000
: I2C2.CR1.PE ( -- x addr ) 0 bit I2C2.CR1 ; \ I2C2.CR1.PE, Peripheral enable
: I2C2.CR1.TXIE ( -- x addr ) 1 bit I2C2.CR1 ; \ I2C2.CR1.TXIE, TX Interrupt enable
: I2C2.CR1.RXIE ( -- x addr ) 2 bit I2C2.CR1 ; \ I2C2.CR1.RXIE, RX Interrupt enable
: I2C2.CR1.ADDRIE ( -- x addr ) 3 bit I2C2.CR1 ; \ I2C2.CR1.ADDRIE, Address match interrupt enable (slave               only)
: I2C2.CR1.NACKIE ( -- x addr ) 4 bit I2C2.CR1 ; \ I2C2.CR1.NACKIE, Not acknowledge received interrupt               enable
: I2C2.CR1.STOPIE ( -- x addr ) 5 bit I2C2.CR1 ; \ I2C2.CR1.STOPIE, STOP detection Interrupt               enable
: I2C2.CR1.TCIE ( -- x addr ) 6 bit I2C2.CR1 ; \ I2C2.CR1.TCIE, Transfer Complete interrupt               enable
: I2C2.CR1.ERRIE ( -- x addr ) 7 bit I2C2.CR1 ; \ I2C2.CR1.ERRIE, Error interrupts enable
: I2C2.CR1.DNF ( %bbbb -- x addr ) 8 lshift I2C2.CR1 ; \ I2C2.CR1.DNF, Digital noise filter
: I2C2.CR1.ANFOFF ( -- x addr ) 12 bit I2C2.CR1 ; \ I2C2.CR1.ANFOFF, Analog noise filter OFF
: I2C2.CR1.TXDMAEN ( -- x addr ) 14 bit I2C2.CR1 ; \ I2C2.CR1.TXDMAEN, DMA transmission requests               enable
: I2C2.CR1.RXDMAEN ( -- x addr ) 15 bit I2C2.CR1 ; \ I2C2.CR1.RXDMAEN, DMA reception requests               enable
: I2C2.CR1.SBC ( -- x addr ) 16 bit I2C2.CR1 ; \ I2C2.CR1.SBC, Slave byte control
: I2C2.CR1.NOSTRETCH ( -- x addr ) 17 bit I2C2.CR1 ; \ I2C2.CR1.NOSTRETCH, Clock stretching disable
: I2C2.CR1.WUPEN ( -- x addr ) 18 bit I2C2.CR1 ; \ I2C2.CR1.WUPEN, Wakeup from STOP enable
: I2C2.CR1.GCEN ( -- x addr ) 19 bit I2C2.CR1 ; \ I2C2.CR1.GCEN, General call enable
: I2C2.CR1.SMBHEN ( -- x addr ) 20 bit I2C2.CR1 ; \ I2C2.CR1.SMBHEN, SMBus Host address enable
: I2C2.CR1.SMBDEN ( -- x addr ) 21 bit I2C2.CR1 ; \ I2C2.CR1.SMBDEN, SMBus Device Default address               enable
: I2C2.CR1.ALERTEN ( -- x addr ) 22 bit I2C2.CR1 ; \ I2C2.CR1.ALERTEN, SMBUS alert enable
: I2C2.CR1.PECEN ( -- x addr ) 23 bit I2C2.CR1 ; \ I2C2.CR1.PECEN, PEC enable

\ I2C2.CR2 (read-write) Reset:$00000000
: I2C2.CR2.PECBYTE ( -- x addr ) 26 bit I2C2.CR2 ; \ I2C2.CR2.PECBYTE, Packet error checking byte
: I2C2.CR2.AUTOEND ( -- x addr ) 25 bit I2C2.CR2 ; \ I2C2.CR2.AUTOEND, Automatic end mode (master               mode)
: I2C2.CR2.RELOAD ( -- x addr ) 24 bit I2C2.CR2 ; \ I2C2.CR2.RELOAD, NBYTES reload mode
: I2C2.CR2.NBYTES ( %bbbbbbbb -- x addr ) 16 lshift I2C2.CR2 ; \ I2C2.CR2.NBYTES, Number of bytes
: I2C2.CR2.NACK ( -- x addr ) 15 bit I2C2.CR2 ; \ I2C2.CR2.NACK, NACK generation (slave               mode)
: I2C2.CR2.STOP ( -- x addr ) 14 bit I2C2.CR2 ; \ I2C2.CR2.STOP, Stop generation (master               mode)
: I2C2.CR2.START ( -- x addr ) 13 bit I2C2.CR2 ; \ I2C2.CR2.START, Start generation
: I2C2.CR2.HEAD10R ( -- x addr ) 12 bit I2C2.CR2 ; \ I2C2.CR2.HEAD10R, 10-bit address header only read               direction (master receiver mode)
: I2C2.CR2.ADD10 ( -- x addr ) 11 bit I2C2.CR2 ; \ I2C2.CR2.ADD10, 10-bit addressing mode (master               mode)
: I2C2.CR2.RD_WRN ( -- x addr ) 10 bit I2C2.CR2 ; \ I2C2.CR2.RD_WRN, Transfer direction (master               mode)
: I2C2.CR2.SADD ( %bbbbbbbbbb -- x addr ) I2C2.CR2 ; \ I2C2.CR2.SADD, Slave address bit (master               mode)

\ I2C2.OAR1 (read-write) Reset:$00000000
: I2C2.OAR1.OA1_0 ( -- x addr ) 0 bit I2C2.OAR1 ; \ I2C2.OAR1.OA1_0, Interface address
: I2C2.OAR1.OA1_7_1 ( %bbbbbbb -- x addr ) 1 lshift I2C2.OAR1 ; \ I2C2.OAR1.OA1_7_1, Interface address
: I2C2.OAR1.OA1_8_9 ( %bb -- x addr ) 8 lshift I2C2.OAR1 ; \ I2C2.OAR1.OA1_8_9, Interface address
: I2C2.OAR1.OA1MODE ( -- x addr ) 10 bit I2C2.OAR1 ; \ I2C2.OAR1.OA1MODE, Own Address 1 10-bit mode
: I2C2.OAR1.OA1EN ( -- x addr ) 15 bit I2C2.OAR1 ; \ I2C2.OAR1.OA1EN, Own Address 1 enable

\ I2C2.OAR2 (read-write) Reset:$00000000
: I2C2.OAR2.OA2 ( %bbbbbbb -- x addr ) 1 lshift I2C2.OAR2 ; \ I2C2.OAR2.OA2, Interface address
: I2C2.OAR2.OA2MSK ( %bbb -- x addr ) 8 lshift I2C2.OAR2 ; \ I2C2.OAR2.OA2MSK, Own Address 2 masks
: I2C2.OAR2.OA2EN ( -- x addr ) 15 bit I2C2.OAR2 ; \ I2C2.OAR2.OA2EN, Own Address 2 enable

\ I2C2.TIMINGR (read-write) Reset:$00000000
: I2C2.TIMINGR.SCLL ( %bbbbbbbb -- x addr ) I2C2.TIMINGR ; \ I2C2.TIMINGR.SCLL, SCL low period (master               mode)
: I2C2.TIMINGR.SCLH ( %bbbbbbbb -- x addr ) 8 lshift I2C2.TIMINGR ; \ I2C2.TIMINGR.SCLH, SCL high period (master               mode)
: I2C2.TIMINGR.SDADEL ( %bbbb -- x addr ) 16 lshift I2C2.TIMINGR ; \ I2C2.TIMINGR.SDADEL, Data hold time
: I2C2.TIMINGR.SCLDEL ( %bbbb -- x addr ) 20 lshift I2C2.TIMINGR ; \ I2C2.TIMINGR.SCLDEL, Data setup time
: I2C2.TIMINGR.PRESC ( %bbbb -- x addr ) 28 lshift I2C2.TIMINGR ; \ I2C2.TIMINGR.PRESC, Timing prescaler

\ I2C2.TIMEOUTR (read-write) Reset:$00000000
: I2C2.TIMEOUTR.TIMEOUTA ( %bbbbbbbbbbb -- x addr ) I2C2.TIMEOUTR ; \ I2C2.TIMEOUTR.TIMEOUTA, Bus timeout A
: I2C2.TIMEOUTR.TIDLE ( -- x addr ) 12 bit I2C2.TIMEOUTR ; \ I2C2.TIMEOUTR.TIDLE, Idle clock timeout               detection
: I2C2.TIMEOUTR.TIMOUTEN ( -- x addr ) 15 bit I2C2.TIMEOUTR ; \ I2C2.TIMEOUTR.TIMOUTEN, Clock timeout enable
: I2C2.TIMEOUTR.TIMEOUTB ( %bbbbbbbbbbb -- x addr ) 16 lshift I2C2.TIMEOUTR ; \ I2C2.TIMEOUTR.TIMEOUTB, Bus timeout B
: I2C2.TIMEOUTR.TEXTEN ( -- x addr ) 31 bit I2C2.TIMEOUTR ; \ I2C2.TIMEOUTR.TEXTEN, Extended clock timeout               enable

\ I2C2.ISR (multiple-access)  Reset:$00000001
: I2C2.ISR.ADDCODE ( %bbbbbbb -- x addr ) 17 lshift I2C2.ISR ; \ I2C2.ISR.ADDCODE, Address match code (Slave               mode)
: I2C2.ISR.DIR ( -- x addr ) 16 bit I2C2.ISR ; \ I2C2.ISR.DIR, Transfer direction (Slave               mode)
: I2C2.ISR.BUSY ( -- x addr ) 15 bit I2C2.ISR ; \ I2C2.ISR.BUSY, Bus busy
: I2C2.ISR.ALERT ( -- x addr ) 13 bit I2C2.ISR ; \ I2C2.ISR.ALERT, SMBus alert
: I2C2.ISR.TIMEOUT? ( -- 1|0 ) 12 bit I2C2.ISR bit@ ; \ I2C2.ISR.TIMEOUT, Timeout or t_low detection               flag
: I2C2.ISR.PECERR ( -- x addr ) 11 bit I2C2.ISR ; \ I2C2.ISR.PECERR, PEC Error in reception
: I2C2.ISR.OVR ( -- x addr ) 10 bit I2C2.ISR ; \ I2C2.ISR.OVR, Overrun/Underrun (slave               mode)
: I2C2.ISR.ARLO ( -- x addr ) 9 bit I2C2.ISR ; \ I2C2.ISR.ARLO, Arbitration lost
: I2C2.ISR.BERR ( -- x addr ) 8 bit I2C2.ISR ; \ I2C2.ISR.BERR, Bus error
: I2C2.ISR.TCR ( -- x addr ) 7 bit I2C2.ISR ; \ I2C2.ISR.TCR, Transfer Complete Reload
: I2C2.ISR.TC ( -- x addr ) 6 bit I2C2.ISR ; \ I2C2.ISR.TC, Transfer Complete (master               mode)
: I2C2.ISR.STOPF? ( -- 1|0 ) 5 bit I2C2.ISR bit@ ; \ I2C2.ISR.STOPF, Stop detection flag
: I2C2.ISR.NACKF? ( -- 1|0 ) 4 bit I2C2.ISR bit@ ; \ I2C2.ISR.NACKF, Not acknowledge received               flag
: I2C2.ISR.ADDR ( -- x addr ) 3 bit I2C2.ISR ; \ I2C2.ISR.ADDR, Address matched (slave               mode)
: I2C2.ISR.RXNE ( -- x addr ) 2 bit I2C2.ISR ; \ I2C2.ISR.RXNE, Receive data register not empty               (receivers)
: I2C2.ISR.TXIS? ( -- 1|0 ) 1 bit I2C2.ISR bit@ ; \ I2C2.ISR.TXIS, Transmit interrupt status               (transmitters)
: I2C2.ISR.TXE ( -- x addr ) 0 bit I2C2.ISR ; \ I2C2.ISR.TXE, Transmit data register empty               (transmitters)

\ I2C2.ICR (write-only) Reset:$00000000
: I2C2.ICR.ALERTCF ( -- x addr ) 13 bit I2C2.ICR ; \ I2C2.ICR.ALERTCF, Alert flag clear
: I2C2.ICR.TIMOUTCF ( -- x addr ) 12 bit I2C2.ICR ; \ I2C2.ICR.TIMOUTCF, Timeout detection flag               clear
: I2C2.ICR.PECCF ( -- x addr ) 11 bit I2C2.ICR ; \ I2C2.ICR.PECCF, PEC Error flag clear
: I2C2.ICR.OVRCF ( -- x addr ) 10 bit I2C2.ICR ; \ I2C2.ICR.OVRCF, Overrun/Underrun flag               clear
: I2C2.ICR.ARLOCF ( -- x addr ) 9 bit I2C2.ICR ; \ I2C2.ICR.ARLOCF, Arbitration lost flag               clear
: I2C2.ICR.BERRCF ( -- x addr ) 8 bit I2C2.ICR ; \ I2C2.ICR.BERRCF, Bus error flag clear
: I2C2.ICR.STOPCF ( -- x addr ) 5 bit I2C2.ICR ; \ I2C2.ICR.STOPCF, Stop detection flag clear
: I2C2.ICR.NACKCF ( -- x addr ) 4 bit I2C2.ICR ; \ I2C2.ICR.NACKCF, Not Acknowledge flag clear
: I2C2.ICR.ADDRCF ( -- x addr ) 3 bit I2C2.ICR ; \ I2C2.ICR.ADDRCF, Address Matched flag clear

\ I2C2.PECR (read-only) Reset:$00000000
: I2C2.PECR.PEC? ( --  x ) I2C2.PECR @ ; \ I2C2.PECR.PEC, Packet error checking               register

\ I2C2.RXDR (read-only) Reset:$00000000
: I2C2.RXDR.RXDATA? ( --  x ) I2C2.RXDR @ ; \ I2C2.RXDR.RXDATA, 8-bit receive data

\ I2C2.TXDR (read-write) Reset:$00000000
: I2C2.TXDR.TXDATA ( %bbbbbbbb -- x addr ) I2C2.TXDR ; \ I2C2.TXDR.TXDATA, 8-bit transmit data

\ RTC.TR (read-write) Reset:$00000000
: RTC.TR.PM ( -- x addr ) 22 bit RTC.TR ; \ RTC.TR.PM, AM/PM notation
: RTC.TR.HT ( %bb -- x addr ) 20 lshift RTC.TR ; \ RTC.TR.HT, Hour tens in BCD format
: RTC.TR.HU ( %bbbb -- x addr ) 16 lshift RTC.TR ; \ RTC.TR.HU, Hour units in BCD format
: RTC.TR.MNT ( %bbb -- x addr ) 12 lshift RTC.TR ; \ RTC.TR.MNT, Minute tens in BCD format
: RTC.TR.MNU ( %bbbb -- x addr ) 8 lshift RTC.TR ; \ RTC.TR.MNU, Minute units in BCD format
: RTC.TR.ST ( %bbb -- x addr ) 4 lshift RTC.TR ; \ RTC.TR.ST, Second tens in BCD format
: RTC.TR.SU ( %bbbb -- x addr ) RTC.TR ; \ RTC.TR.SU, Second units in BCD format

\ RTC.DR (read-write) Reset:$00002101
: RTC.DR.YT ( %bbbb -- x addr ) 20 lshift RTC.DR ; \ RTC.DR.YT, Year tens in BCD format
: RTC.DR.YU ( %bbbb -- x addr ) 16 lshift RTC.DR ; \ RTC.DR.YU, Year units in BCD format
: RTC.DR.WDU ( %bbb -- x addr ) 13 lshift RTC.DR ; \ RTC.DR.WDU, Week day units
: RTC.DR.MT ( -- x addr ) 12 bit RTC.DR ; \ RTC.DR.MT, Month tens in BCD format
: RTC.DR.MU ( %bbbb -- x addr ) 8 lshift RTC.DR ; \ RTC.DR.MU, Month units in BCD format
: RTC.DR.DT ( %bb -- x addr ) 4 lshift RTC.DR ; \ RTC.DR.DT, Date tens in BCD format
: RTC.DR.DU ( %bbbb -- x addr ) RTC.DR ; \ RTC.DR.DU, Date units in BCD format

\ RTC.SSR (read-only) Reset:$00000000
: RTC.SSR.SS? ( --  x ) RTC.SSR @ ; \ RTC.SSR.SS, Sub second value

\ RTC.ICSR (multiple-access)  Reset:$00000007
: RTC.ICSR.ALRAWF? ( -- 1|0 ) 0 bit RTC.ICSR bit@ ; \ RTC.ICSR.ALRAWF, Alarm A write flag
: RTC.ICSR.ALRBWF? ( -- 1|0 ) 1 bit RTC.ICSR bit@ ; \ RTC.ICSR.ALRBWF, Alarm B write flag
: RTC.ICSR.WUTWF? ( -- 1|0 ) 2 bit RTC.ICSR bit@ ; \ RTC.ICSR.WUTWF, Wakeup timer write flag
: RTC.ICSR.SHPF ( -- x addr ) 3 bit RTC.ICSR ; \ RTC.ICSR.SHPF, Shift operation pending
: RTC.ICSR.INITS? ( -- 1|0 ) 4 bit RTC.ICSR bit@ ; \ RTC.ICSR.INITS, Initialization status flag
: RTC.ICSR.RSF? ( -- 1|0 ) 5 bit RTC.ICSR bit@ ; \ RTC.ICSR.RSF, Registers synchronization               flag
: RTC.ICSR.INITF? ( -- 1|0 ) 6 bit RTC.ICSR bit@ ; \ RTC.ICSR.INITF, Initialization flag
: RTC.ICSR.INIT ( -- x addr ) 7 bit RTC.ICSR ; \ RTC.ICSR.INIT, Initialization mode
: RTC.ICSR.RECALPF ( -- x addr ) 16 bit RTC.ICSR ; \ RTC.ICSR.RECALPF, Recalibration pending Flag

\ RTC.PRER (read-write) Reset:$007F00FF
: RTC.PRER.PREDIV_A ( %bbbbbbb -- x addr ) 16 lshift RTC.PRER ; \ RTC.PRER.PREDIV_A, Asynchronous prescaler               factor
: RTC.PRER.PREDIV_S ( %bbbbbbbbbbbbbbb -- x addr ) RTC.PRER ; \ RTC.PRER.PREDIV_S, Synchronous prescaler               factor

\ RTC.WUTR (read-write) Reset:$0000FFFF
: RTC.WUTR.WUT ( %bbbbbbbbbbbbbbbb -- x addr ) RTC.WUTR ; \ RTC.WUTR.WUT, Wakeup auto-reload value               bits

\ RTC.CR (read-write) Reset:$00000000
: RTC.CR.WUCKSEL ( %bbb -- x addr ) RTC.CR ; \ RTC.CR.WUCKSEL, WUCKSEL
: RTC.CR.TSEDGE ( -- x addr ) 3 bit RTC.CR ; \ RTC.CR.TSEDGE, TSEDGE
: RTC.CR.REFCKON ( -- x addr ) 4 bit RTC.CR ; \ RTC.CR.REFCKON, REFCKON
: RTC.CR.BYPSHAD ( -- x addr ) 5 bit RTC.CR ; \ RTC.CR.BYPSHAD, BYPSHAD
: RTC.CR.FMT ( -- x addr ) 6 bit RTC.CR ; \ RTC.CR.FMT, FMT
: RTC.CR.ALRAE ( -- x addr ) 8 bit RTC.CR ; \ RTC.CR.ALRAE, ALRAE
: RTC.CR.ALRBE ( -- x addr ) 9 bit RTC.CR ; \ RTC.CR.ALRBE, ALRBE
: RTC.CR.WUTE ( -- x addr ) 10 bit RTC.CR ; \ RTC.CR.WUTE, WUTE
: RTC.CR.TSE ( -- x addr ) 11 bit RTC.CR ; \ RTC.CR.TSE, TSE
: RTC.CR.ALRAIE ( -- x addr ) 12 bit RTC.CR ; \ RTC.CR.ALRAIE, ALRAIE
: RTC.CR.ALRBIE ( -- x addr ) 13 bit RTC.CR ; \ RTC.CR.ALRBIE, ALRBIE
: RTC.CR.WUTIE ( -- x addr ) 14 bit RTC.CR ; \ RTC.CR.WUTIE, WUTIE
: RTC.CR.TSIE ( -- x addr ) 15 bit RTC.CR ; \ RTC.CR.TSIE, TSIE
: RTC.CR.ADD1H ( -- x addr ) 16 bit RTC.CR ; \ RTC.CR.ADD1H, ADD1H
: RTC.CR.SUB1H ( -- x addr ) 17 bit RTC.CR ; \ RTC.CR.SUB1H, SUB1H
: RTC.CR.BKP ( -- x addr ) 18 bit RTC.CR ; \ RTC.CR.BKP, BKP
: RTC.CR.COSEL ( -- x addr ) 19 bit RTC.CR ; \ RTC.CR.COSEL, COSEL
: RTC.CR.POL ( -- x addr ) 20 bit RTC.CR ; \ RTC.CR.POL, POL
: RTC.CR.OSEL ( %bb -- x addr ) 21 lshift RTC.CR ; \ RTC.CR.OSEL, OSEL
: RTC.CR.COE ( -- x addr ) 23 bit RTC.CR ; \ RTC.CR.COE, COE
: RTC.CR.ITSE ( -- x addr ) 24 bit RTC.CR ; \ RTC.CR.ITSE, ITSE
: RTC.CR.TAMPTS ( -- x addr ) 25 bit RTC.CR ; \ RTC.CR.TAMPTS, TAMPTS
: RTC.CR.TAMPOE ( -- x addr ) 26 bit RTC.CR ; \ RTC.CR.TAMPOE, TAMPOE
: RTC.CR.TAMPALRM_PU ( -- x addr ) 29 bit RTC.CR ; \ RTC.CR.TAMPALRM_PU, TAMPALRM_PU
: RTC.CR.TAMPALRM_TYPE ( -- x addr ) 30 bit RTC.CR ; \ RTC.CR.TAMPALRM_TYPE, TAMPALRM_TYPE
: RTC.CR.OUT2EN ( -- x addr ) 31 bit RTC.CR ; \ RTC.CR.OUT2EN, OUT2EN

\ RTC.WPR (write-only) Reset:$00000000
: RTC.WPR.KEY ( %bbbbbbbb -- x addr ) RTC.WPR ; \ RTC.WPR.KEY, Write protection key

\ RTC.CALR (read-write) Reset:$00000000
: RTC.CALR.CALP ( -- x addr ) 15 bit RTC.CALR ; \ RTC.CALR.CALP, Increase frequency of RTC by 488.5               ppm
: RTC.CALR.CALW8 ( -- x addr ) 14 bit RTC.CALR ; \ RTC.CALR.CALW8, Use an 8-second calibration cycle               period
: RTC.CALR.CALW16 ( -- x addr ) 13 bit RTC.CALR ; \ RTC.CALR.CALW16, Use a 16-second calibration cycle               period
: RTC.CALR.CALM ( %bbbbbbbbb -- x addr ) RTC.CALR ; \ RTC.CALR.CALM, Calibration minus

\ RTC.SHIFTR (write-only) Reset:$00000000
: RTC.SHIFTR.ADD1S ( -- x addr ) 31 bit RTC.SHIFTR ; \ RTC.SHIFTR.ADD1S, Add one second
: RTC.SHIFTR.SUBFS ( %bbbbbbbbbbbbbbb -- x addr ) RTC.SHIFTR ; \ RTC.SHIFTR.SUBFS, Subtract a fraction of a               second

\ RTC.TSTR (read-only) Reset:$00000000
: RTC.TSTR.SU? ( --  x ) RTC.TSTR @ ; \ RTC.TSTR.SU, Second units in BCD format
: RTC.TSTR.ST? ( --  x ) 4 lshift RTC.TSTR @ ; \ RTC.TSTR.ST, Second tens in BCD format
: RTC.TSTR.MNU? ( --  x ) 8 lshift RTC.TSTR @ ; \ RTC.TSTR.MNU, Minute units in BCD format
: RTC.TSTR.MNT? ( --  x ) 12 lshift RTC.TSTR @ ; \ RTC.TSTR.MNT, Minute tens in BCD format
: RTC.TSTR.HU? ( --  x ) 16 lshift RTC.TSTR @ ; \ RTC.TSTR.HU, Hour units in BCD format
: RTC.TSTR.HT? ( --  x ) 20 lshift RTC.TSTR @ ; \ RTC.TSTR.HT, Hour tens in BCD format
: RTC.TSTR.PM? ( --  1|0 ) 22 bit RTC.TSTR bit@ ; \ RTC.TSTR.PM, AM/PM notation

\ RTC.TSDR (read-only) Reset:$00000000
: RTC.TSDR.WDU? ( --  x ) 13 lshift RTC.TSDR @ ; \ RTC.TSDR.WDU, Week day units
: RTC.TSDR.MT? ( --  1|0 ) 12 bit RTC.TSDR bit@ ; \ RTC.TSDR.MT, Month tens in BCD format
: RTC.TSDR.MU? ( --  x ) 8 lshift RTC.TSDR @ ; \ RTC.TSDR.MU, Month units in BCD format
: RTC.TSDR.DT? ( --  x ) 4 lshift RTC.TSDR @ ; \ RTC.TSDR.DT, Date tens in BCD format
: RTC.TSDR.DU? ( --  x ) RTC.TSDR @ ; \ RTC.TSDR.DU, Date units in BCD format

\ RTC.TSSSR (read-only) Reset:$00000000
: RTC.TSSSR.SS? ( --  x ) RTC.TSSSR @ ; \ RTC.TSSSR.SS, Sub second value

\ RTC.ALRMAR (read-write) Reset:$00000000
: RTC.ALRMAR.MSK4 ( -- x addr ) 31 bit RTC.ALRMAR ; \ RTC.ALRMAR.MSK4, Alarm A date mask
: RTC.ALRMAR.WDSEL ( -- x addr ) 30 bit RTC.ALRMAR ; \ RTC.ALRMAR.WDSEL, Week day selection
: RTC.ALRMAR.DT ( %bb -- x addr ) 28 lshift RTC.ALRMAR ; \ RTC.ALRMAR.DT, Date tens in BCD format
: RTC.ALRMAR.DU ( %bbbb -- x addr ) 24 lshift RTC.ALRMAR ; \ RTC.ALRMAR.DU, Date units or day in BCD               format
: RTC.ALRMAR.MSK3 ( -- x addr ) 23 bit RTC.ALRMAR ; \ RTC.ALRMAR.MSK3, Alarm A hours mask
: RTC.ALRMAR.PM ( -- x addr ) 22 bit RTC.ALRMAR ; \ RTC.ALRMAR.PM, AM/PM notation
: RTC.ALRMAR.HT ( %bb -- x addr ) 20 lshift RTC.ALRMAR ; \ RTC.ALRMAR.HT, Hour tens in BCD format
: RTC.ALRMAR.HU ( %bbbb -- x addr ) 16 lshift RTC.ALRMAR ; \ RTC.ALRMAR.HU, Hour units in BCD format
: RTC.ALRMAR.MSK2 ( -- x addr ) 15 bit RTC.ALRMAR ; \ RTC.ALRMAR.MSK2, Alarm A minutes mask
: RTC.ALRMAR.MNT ( %bbb -- x addr ) 12 lshift RTC.ALRMAR ; \ RTC.ALRMAR.MNT, Minute tens in BCD format
: RTC.ALRMAR.MNU ( %bbbb -- x addr ) 8 lshift RTC.ALRMAR ; \ RTC.ALRMAR.MNU, Minute units in BCD format
: RTC.ALRMAR.MSK1 ( -- x addr ) 7 bit RTC.ALRMAR ; \ RTC.ALRMAR.MSK1, Alarm A seconds mask
: RTC.ALRMAR.ST ( %bbb -- x addr ) 4 lshift RTC.ALRMAR ; \ RTC.ALRMAR.ST, Second tens in BCD format
: RTC.ALRMAR.SU ( %bbbb -- x addr ) RTC.ALRMAR ; \ RTC.ALRMAR.SU, Second units in BCD format

\ RTC.ALRMASSR (read-write) Reset:$00000000
: RTC.ALRMASSR.MASKSS ( %bbbb -- x addr ) 24 lshift RTC.ALRMASSR ; \ RTC.ALRMASSR.MASKSS, Mask the most-significant bits starting               at this bit
: RTC.ALRMASSR.SS ( %bbbbbbbbbbbbbbb -- x addr ) RTC.ALRMASSR ; \ RTC.ALRMASSR.SS, Sub seconds value

\ RTC.ALRMBR (read-write) Reset:$00000000
: RTC.ALRMBR.MSK4 ( -- x addr ) 31 bit RTC.ALRMBR ; \ RTC.ALRMBR.MSK4, Alarm B date mask
: RTC.ALRMBR.WDSEL ( -- x addr ) 30 bit RTC.ALRMBR ; \ RTC.ALRMBR.WDSEL, Week day selection
: RTC.ALRMBR.DT ( %bb -- x addr ) 28 lshift RTC.ALRMBR ; \ RTC.ALRMBR.DT, Date tens in BCD format
: RTC.ALRMBR.DU ( %bbbb -- x addr ) 24 lshift RTC.ALRMBR ; \ RTC.ALRMBR.DU, Date units or day in BCD               format
: RTC.ALRMBR.MSK3 ( -- x addr ) 23 bit RTC.ALRMBR ; \ RTC.ALRMBR.MSK3, Alarm B hours mask
: RTC.ALRMBR.PM ( -- x addr ) 22 bit RTC.ALRMBR ; \ RTC.ALRMBR.PM, AM/PM notation
: RTC.ALRMBR.HT ( %bb -- x addr ) 20 lshift RTC.ALRMBR ; \ RTC.ALRMBR.HT, Hour tens in BCD format
: RTC.ALRMBR.HU ( %bbbb -- x addr ) 16 lshift RTC.ALRMBR ; \ RTC.ALRMBR.HU, Hour units in BCD format
: RTC.ALRMBR.MSK2 ( -- x addr ) 15 bit RTC.ALRMBR ; \ RTC.ALRMBR.MSK2, Alarm B minutes mask
: RTC.ALRMBR.MNT ( %bbb -- x addr ) 12 lshift RTC.ALRMBR ; \ RTC.ALRMBR.MNT, Minute tens in BCD format
: RTC.ALRMBR.MNU ( %bbbb -- x addr ) 8 lshift RTC.ALRMBR ; \ RTC.ALRMBR.MNU, Minute units in BCD format
: RTC.ALRMBR.MSK1 ( -- x addr ) 7 bit RTC.ALRMBR ; \ RTC.ALRMBR.MSK1, Alarm B seconds mask
: RTC.ALRMBR.ST ( %bbb -- x addr ) 4 lshift RTC.ALRMBR ; \ RTC.ALRMBR.ST, Second tens in BCD format
: RTC.ALRMBR.SU ( %bbbb -- x addr ) RTC.ALRMBR ; \ RTC.ALRMBR.SU, Second units in BCD format

\ RTC.ALRMBSSR (read-write) Reset:$00000000
: RTC.ALRMBSSR.MASKSS ( %bbbb -- x addr ) 24 lshift RTC.ALRMBSSR ; \ RTC.ALRMBSSR.MASKSS, Mask the most-significant bits starting               at this bit
: RTC.ALRMBSSR.SS ( %bbbbbbbbbbbbbbb -- x addr ) RTC.ALRMBSSR ; \ RTC.ALRMBSSR.SS, Sub seconds value

\ RTC.SR (read-only) Reset:$00000000
: RTC.SR.ALRAF? ( --  1|0 ) 0 bit RTC.SR bit@ ; \ RTC.SR.ALRAF, ALRAF
: RTC.SR.ALRBF? ( --  1|0 ) 1 bit RTC.SR bit@ ; \ RTC.SR.ALRBF, ALRBF
: RTC.SR.WUTF? ( --  1|0 ) 2 bit RTC.SR bit@ ; \ RTC.SR.WUTF, WUTF
: RTC.SR.TSF? ( --  1|0 ) 3 bit RTC.SR bit@ ; \ RTC.SR.TSF, TSF
: RTC.SR.TSOVF? ( --  1|0 ) 4 bit RTC.SR bit@ ; \ RTC.SR.TSOVF, TSOVF
: RTC.SR.ITSF? ( --  1|0 ) 5 bit RTC.SR bit@ ; \ RTC.SR.ITSF, ITSF

\ RTC.MISR (read-only) Reset:$00000000
: RTC.MISR.ALRAMF? ( --  1|0 ) 0 bit RTC.MISR bit@ ; \ RTC.MISR.ALRAMF, ALRAMF
: RTC.MISR.ALRBMF? ( --  1|0 ) 1 bit RTC.MISR bit@ ; \ RTC.MISR.ALRBMF, ALRBMF
: RTC.MISR.WUTMF? ( --  1|0 ) 2 bit RTC.MISR bit@ ; \ RTC.MISR.WUTMF, WUTMF
: RTC.MISR.TSMF? ( --  1|0 ) 3 bit RTC.MISR bit@ ; \ RTC.MISR.TSMF, TSMF
: RTC.MISR.TSOVMF? ( --  1|0 ) 4 bit RTC.MISR bit@ ; \ RTC.MISR.TSOVMF, TSOVMF
: RTC.MISR.ITSMF? ( --  1|0 ) 5 bit RTC.MISR bit@ ; \ RTC.MISR.ITSMF, ITSMF

\ RTC.SCR (read-write) Reset:$00000000
: RTC.SCR.CALRAF ( -- x addr ) 0 bit RTC.SCR ; \ RTC.SCR.CALRAF, CALRAF
: RTC.SCR.CALRBF ( -- x addr ) 1 bit RTC.SCR ; \ RTC.SCR.CALRBF, CALRBF
: RTC.SCR.CWUTF ( -- x addr ) 2 bit RTC.SCR ; \ RTC.SCR.CWUTF, CWUTF
: RTC.SCR.CTSF ( -- x addr ) 3 bit RTC.SCR ; \ RTC.SCR.CTSF, CTSF
: RTC.SCR.CTSOVF ( -- x addr ) 4 bit RTC.SCR ; \ RTC.SCR.CTSOVF, CTSOVF
: RTC.SCR.CITSF ( -- x addr ) 5 bit RTC.SCR ; \ RTC.SCR.CITSF, CITSF

\ TIM14.CR1 (read-write) Reset:$0000
: TIM14.CR1.UIFREMAP ( -- x addr ) 11 bit TIM14.CR1 ; \ TIM14.CR1.UIFREMAP, UIF status bit remapping
: TIM14.CR1.CKD ( %bb -- x addr ) 8 lshift TIM14.CR1 ; \ TIM14.CR1.CKD, Clock division
: TIM14.CR1.ARPE ( -- x addr ) 7 bit TIM14.CR1 ; \ TIM14.CR1.ARPE, Auto-reload preload enable
: TIM14.CR1.OPM ( -- x addr ) 3 bit TIM14.CR1 ; \ TIM14.CR1.OPM, One-pulse mode
: TIM14.CR1.URS ( -- x addr ) 2 bit TIM14.CR1 ; \ TIM14.CR1.URS, Update request source
: TIM14.CR1.UDIS ( -- x addr ) 1 bit TIM14.CR1 ; \ TIM14.CR1.UDIS, Update disable
: TIM14.CR1.CEN ( -- x addr ) 0 bit TIM14.CR1 ; \ TIM14.CR1.CEN, Counter enable

\ TIM14.DIER (read-write) Reset:$0000
: TIM14.DIER.CC1IE ( -- x addr ) 1 bit TIM14.DIER ; \ TIM14.DIER.CC1IE, Capture/Compare 1 interrupt               enable
: TIM14.DIER.UIE ( -- x addr ) 0 bit TIM14.DIER ; \ TIM14.DIER.UIE, Update interrupt enable

\ TIM14.SR (read-write) Reset:$0000
: TIM14.SR.CC1OF ( -- x addr ) 9 bit TIM14.SR ; \ TIM14.SR.CC1OF, Capture/Compare 1 overcapture               flag
: TIM14.SR.CC1IF ( -- x addr ) 1 bit TIM14.SR ; \ TIM14.SR.CC1IF, Capture/compare 1 interrupt               flag
: TIM14.SR.UIF ( -- x addr ) 0 bit TIM14.SR ; \ TIM14.SR.UIF, Update interrupt flag

\ TIM14.EGR (write-only) Reset:$0000
: TIM14.EGR.CC1G ( -- x addr ) 1 bit TIM14.EGR ; \ TIM14.EGR.CC1G, Capture/compare 1               generation
: TIM14.EGR.UG ( -- x addr ) 0 bit TIM14.EGR ; \ TIM14.EGR.UG, Update generation

\ TIM14.CCMR1_Output (read-write) Reset:$00000000
: TIM14.CCMR1_Output.CC1S ( %bb -- x addr ) TIM14.CCMR1_Output ; \ TIM14.CCMR1_Output.CC1S, CC1S
: TIM14.CCMR1_Output.OC1FE ( -- x addr ) 2 bit TIM14.CCMR1_Output ; \ TIM14.CCMR1_Output.OC1FE, OC1FE
: TIM14.CCMR1_Output.OC1PE ( -- x addr ) 3 bit TIM14.CCMR1_Output ; \ TIM14.CCMR1_Output.OC1PE, OC1PE
: TIM14.CCMR1_Output.OC1M ( %bbb -- x addr ) 4 lshift TIM14.CCMR1_Output ; \ TIM14.CCMR1_Output.OC1M, OC1M
: TIM14.CCMR1_Output.OC1CE ( -- x addr ) 7 bit TIM14.CCMR1_Output ; \ TIM14.CCMR1_Output.OC1CE, OC1CE
: TIM14.CCMR1_Output.OC1M_3 ( -- x addr ) 16 bit TIM14.CCMR1_Output ; \ TIM14.CCMR1_Output.OC1M_3, Output Compare 1 mode - bit               3

\ TIM14.CCMR1_Input (read-write) Reset:$00000000
: TIM14.CCMR1_Input.IC1F ( %bbbb -- x addr ) 4 lshift TIM14.CCMR1_Input ; \ TIM14.CCMR1_Input.IC1F, Input capture 1 filter
: TIM14.CCMR1_Input.ICPCS ( %bb -- x addr ) 2 lshift TIM14.CCMR1_Input ; \ TIM14.CCMR1_Input.ICPCS, Input capture 1 prescaler
: TIM14.CCMR1_Input.CC1S ( %bb -- x addr ) TIM14.CCMR1_Input ; \ TIM14.CCMR1_Input.CC1S, Capture/Compare 1               selection

\ TIM14.CCER (read-write) Reset:$0000
: TIM14.CCER.CC1NP ( -- x addr ) 3 bit TIM14.CCER ; \ TIM14.CCER.CC1NP, Capture/Compare 1 output               Polarity
: TIM14.CCER.CC1P ( -- x addr ) 1 bit TIM14.CCER ; \ TIM14.CCER.CC1P, Capture/Compare 1 output               Polarity
: TIM14.CCER.CC1E ( -- x addr ) 0 bit TIM14.CCER ; \ TIM14.CCER.CC1E, Capture/Compare 1 output               enable

\ TIM14.CNT (read-write) Reset:$00000000
: TIM14.CNT.CNT ( %bbbbbbbbbbbbbbbb -- x addr ) TIM14.CNT ; \ TIM14.CNT.CNT, low counter value
: TIM14.CNT.UIFCPY ( -- x addr ) 31 bit TIM14.CNT ; \ TIM14.CNT.UIFCPY, UIF Copy

\ TIM14.PSC (read-write) Reset:$0000
: TIM14.PSC.PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIM14.PSC ; \ TIM14.PSC.PSC, Prescaler value

\ TIM14.ARR (read-write) Reset:$00000000
: TIM14.ARR.ARR ( %bbbbbbbbbbbbbbbb -- x addr ) TIM14.ARR ; \ TIM14.ARR.ARR, Low Auto-reload value

\ TIM14.CCR1 (read-write) Reset:$00000000
: TIM14.CCR1.CCR1 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM14.CCR1 ; \ TIM14.CCR1.CCR1, Low Capture/Compare 1               value

\ TIM14.TISEL (read-write) Reset:$0000
: TIM14.TISEL.TISEL ( %bbbb -- x addr ) TIM14.TISEL ; \ TIM14.TISEL.TISEL, TI1[0] to TI1[15] input               selection

\ TIM2.CR1 (read-write) Reset:$0000
: TIM2.CR1.UIFREMAP ( -- x addr ) 11 bit TIM2.CR1 ; \ TIM2.CR1.UIFREMAP, UIF status bit remapping
: TIM2.CR1.CKD ( %bb -- x addr ) 8 lshift TIM2.CR1 ; \ TIM2.CR1.CKD, Clock division
: TIM2.CR1.ARPE ( -- x addr ) 7 bit TIM2.CR1 ; \ TIM2.CR1.ARPE, Auto-reload preload enable
: TIM2.CR1.CMS ( %bb -- x addr ) 5 lshift TIM2.CR1 ; \ TIM2.CR1.CMS, Center-aligned mode               selection
: TIM2.CR1.DIR ( -- x addr ) 4 bit TIM2.CR1 ; \ TIM2.CR1.DIR, Direction
: TIM2.CR1.OPM ( -- x addr ) 3 bit TIM2.CR1 ; \ TIM2.CR1.OPM, One-pulse mode
: TIM2.CR1.URS ( -- x addr ) 2 bit TIM2.CR1 ; \ TIM2.CR1.URS, Update request source
: TIM2.CR1.UDIS ( -- x addr ) 1 bit TIM2.CR1 ; \ TIM2.CR1.UDIS, Update disable
: TIM2.CR1.CEN ( -- x addr ) 0 bit TIM2.CR1 ; \ TIM2.CR1.CEN, Counter enable

\ TIM2.CR2 (read-write) Reset:$0000
: TIM2.CR2.TI1S ( -- x addr ) 7 bit TIM2.CR2 ; \ TIM2.CR2.TI1S, TI1 selection
: TIM2.CR2.MMS ( %bbb -- x addr ) 4 lshift TIM2.CR2 ; \ TIM2.CR2.MMS, Master mode selection
: TIM2.CR2.CCDS ( -- x addr ) 3 bit TIM2.CR2 ; \ TIM2.CR2.CCDS, Capture/compare DMA               selection

\ TIM2.SMCR (read-write) Reset:$0000
: TIM2.SMCR.TS_4_3 ( %bb -- x addr ) 20 lshift TIM2.SMCR ; \ TIM2.SMCR.TS_4_3, Trigger selection
: TIM2.SMCR.SMS_3 ( -- x addr ) 16 bit TIM2.SMCR ; \ TIM2.SMCR.SMS_3, Slave mode selection - bit               3
: TIM2.SMCR.ETP ( -- x addr ) 15 bit TIM2.SMCR ; \ TIM2.SMCR.ETP, External trigger polarity
: TIM2.SMCR.ECE ( -- x addr ) 14 bit TIM2.SMCR ; \ TIM2.SMCR.ECE, External clock enable
: TIM2.SMCR.ETPS ( %bb -- x addr ) 12 lshift TIM2.SMCR ; \ TIM2.SMCR.ETPS, External trigger prescaler
: TIM2.SMCR.ETF ( %bbbb -- x addr ) 8 lshift TIM2.SMCR ; \ TIM2.SMCR.ETF, External trigger filter
: TIM2.SMCR.MSM ( -- x addr ) 7 bit TIM2.SMCR ; \ TIM2.SMCR.MSM, Master/Slave mode
: TIM2.SMCR.TS ( %bbb -- x addr ) 4 lshift TIM2.SMCR ; \ TIM2.SMCR.TS, Trigger selection
: TIM2.SMCR.OCCS ( -- x addr ) 3 bit TIM2.SMCR ; \ TIM2.SMCR.OCCS, OCREF clear selection
: TIM2.SMCR.SMS ( %bbb -- x addr ) TIM2.SMCR ; \ TIM2.SMCR.SMS, Slave mode selection

\ TIM2.DIER (read-write) Reset:$0000
: TIM2.DIER.TDE ( -- x addr ) 14 bit TIM2.DIER ; \ TIM2.DIER.TDE, Trigger DMA request enable
: TIM2.DIER.CC4DE ( -- x addr ) 12 bit TIM2.DIER ; \ TIM2.DIER.CC4DE, Capture/Compare 4 DMA request               enable
: TIM2.DIER.CC3DE ( -- x addr ) 11 bit TIM2.DIER ; \ TIM2.DIER.CC3DE, Capture/Compare 3 DMA request               enable
: TIM2.DIER.CC2DE ( -- x addr ) 10 bit TIM2.DIER ; \ TIM2.DIER.CC2DE, Capture/Compare 2 DMA request               enable
: TIM2.DIER.CC1DE ( -- x addr ) 9 bit TIM2.DIER ; \ TIM2.DIER.CC1DE, Capture/Compare 1 DMA request               enable
: TIM2.DIER.UDE ( -- x addr ) 8 bit TIM2.DIER ; \ TIM2.DIER.UDE, Update DMA request enable
: TIM2.DIER.TIE ( -- x addr ) 6 bit TIM2.DIER ; \ TIM2.DIER.TIE, Trigger interrupt enable
: TIM2.DIER.CC4IE ( -- x addr ) 4 bit TIM2.DIER ; \ TIM2.DIER.CC4IE, Capture/Compare 4 interrupt               enable
: TIM2.DIER.CC3IE ( -- x addr ) 3 bit TIM2.DIER ; \ TIM2.DIER.CC3IE, Capture/Compare 3 interrupt               enable
: TIM2.DIER.CC2IE ( -- x addr ) 2 bit TIM2.DIER ; \ TIM2.DIER.CC2IE, Capture/Compare 2 interrupt               enable
: TIM2.DIER.CC1IE ( -- x addr ) 1 bit TIM2.DIER ; \ TIM2.DIER.CC1IE, Capture/Compare 1 interrupt               enable
: TIM2.DIER.UIE ( -- x addr ) 0 bit TIM2.DIER ; \ TIM2.DIER.UIE, Update interrupt enable

\ TIM2.SR (read-write) Reset:$0000
: TIM2.SR.CC4OF ( -- x addr ) 12 bit TIM2.SR ; \ TIM2.SR.CC4OF, Capture/Compare 4 overcapture               flag
: TIM2.SR.CC3OF ( -- x addr ) 11 bit TIM2.SR ; \ TIM2.SR.CC3OF, Capture/Compare 3 overcapture               flag
: TIM2.SR.CC2OF ( -- x addr ) 10 bit TIM2.SR ; \ TIM2.SR.CC2OF, Capture/compare 2 overcapture               flag
: TIM2.SR.CC1OF ( -- x addr ) 9 bit TIM2.SR ; \ TIM2.SR.CC1OF, Capture/Compare 1 overcapture               flag
: TIM2.SR.TIF ( -- x addr ) 6 bit TIM2.SR ; \ TIM2.SR.TIF, Trigger interrupt flag
: TIM2.SR.CC4IF ( -- x addr ) 4 bit TIM2.SR ; \ TIM2.SR.CC4IF, Capture/Compare 4 interrupt               flag
: TIM2.SR.CC3IF ( -- x addr ) 3 bit TIM2.SR ; \ TIM2.SR.CC3IF, Capture/Compare 3 interrupt               flag
: TIM2.SR.CC2IF ( -- x addr ) 2 bit TIM2.SR ; \ TIM2.SR.CC2IF, Capture/Compare 2 interrupt               flag
: TIM2.SR.CC1IF ( -- x addr ) 1 bit TIM2.SR ; \ TIM2.SR.CC1IF, Capture/compare 1 interrupt               flag
: TIM2.SR.UIF ( -- x addr ) 0 bit TIM2.SR ; \ TIM2.SR.UIF, Update interrupt flag

\ TIM2.EGR (write-only) Reset:$0000
: TIM2.EGR.TG ( -- x addr ) 6 bit TIM2.EGR ; \ TIM2.EGR.TG, Trigger generation
: TIM2.EGR.CC4G ( -- x addr ) 4 bit TIM2.EGR ; \ TIM2.EGR.CC4G, Capture/compare 4               generation
: TIM2.EGR.CC3G ( -- x addr ) 3 bit TIM2.EGR ; \ TIM2.EGR.CC3G, Capture/compare 3               generation
: TIM2.EGR.CC2G ( -- x addr ) 2 bit TIM2.EGR ; \ TIM2.EGR.CC2G, Capture/compare 2               generation
: TIM2.EGR.CC1G ( -- x addr ) 1 bit TIM2.EGR ; \ TIM2.EGR.CC1G, Capture/compare 1               generation
: TIM2.EGR.UG ( -- x addr ) 0 bit TIM2.EGR ; \ TIM2.EGR.UG, Update generation

\ TIM2.CCMR1_Output (read-write) Reset:$00000000
: TIM2.CCMR1_Output.OC2M_3 ( -- x addr ) 24 bit TIM2.CCMR1_Output ; \ TIM2.CCMR1_Output.OC2M_3, Output Compare 2 mode - bit               3
: TIM2.CCMR1_Output.OC1M_3 ( -- x addr ) 16 bit TIM2.CCMR1_Output ; \ TIM2.CCMR1_Output.OC1M_3, Output Compare 1 mode - bit               3
: TIM2.CCMR1_Output.OC2CE ( -- x addr ) 15 bit TIM2.CCMR1_Output ; \ TIM2.CCMR1_Output.OC2CE, Output compare 2 clear               enable
: TIM2.CCMR1_Output.OC2M ( %bbb -- x addr ) 12 lshift TIM2.CCMR1_Output ; \ TIM2.CCMR1_Output.OC2M, Output compare 2 mode
: TIM2.CCMR1_Output.OC2PE ( -- x addr ) 11 bit TIM2.CCMR1_Output ; \ TIM2.CCMR1_Output.OC2PE, Output compare 2 preload               enable
: TIM2.CCMR1_Output.OC2FE ( -- x addr ) 10 bit TIM2.CCMR1_Output ; \ TIM2.CCMR1_Output.OC2FE, Output compare 2 fast               enable
: TIM2.CCMR1_Output.CC2S ( %bb -- x addr ) 8 lshift TIM2.CCMR1_Output ; \ TIM2.CCMR1_Output.CC2S, Capture/Compare 2               selection
: TIM2.CCMR1_Output.OC1CE ( -- x addr ) 7 bit TIM2.CCMR1_Output ; \ TIM2.CCMR1_Output.OC1CE, Output compare 1 clear               enable
: TIM2.CCMR1_Output.OC1M ( %bbb -- x addr ) 4 lshift TIM2.CCMR1_Output ; \ TIM2.CCMR1_Output.OC1M, Output compare 1 mode
: TIM2.CCMR1_Output.OC1PE ( -- x addr ) 3 bit TIM2.CCMR1_Output ; \ TIM2.CCMR1_Output.OC1PE, Output compare 1 preload               enable
: TIM2.CCMR1_Output.OC1FE ( -- x addr ) 2 bit TIM2.CCMR1_Output ; \ TIM2.CCMR1_Output.OC1FE, Output compare 1 fast               enable
: TIM2.CCMR1_Output.CC1S ( %bb -- x addr ) TIM2.CCMR1_Output ; \ TIM2.CCMR1_Output.CC1S, Capture/Compare 1               selection

\ TIM2.CCMR1_Input (read-write) Reset:$00000000
: TIM2.CCMR1_Input.IC2F ( %bbbb -- x addr ) 12 lshift TIM2.CCMR1_Input ; \ TIM2.CCMR1_Input.IC2F, Input capture 2 filter
: TIM2.CCMR1_Input.IC2PSC ( %bb -- x addr ) 10 lshift TIM2.CCMR1_Input ; \ TIM2.CCMR1_Input.IC2PSC, Input capture 2 prescaler
: TIM2.CCMR1_Input.CC2S ( %bb -- x addr ) 8 lshift TIM2.CCMR1_Input ; \ TIM2.CCMR1_Input.CC2S, Capture/compare 2               selection
: TIM2.CCMR1_Input.IC1F ( %bbbb -- x addr ) 4 lshift TIM2.CCMR1_Input ; \ TIM2.CCMR1_Input.IC1F, Input capture 1 filter
: TIM2.CCMR1_Input.IC1PSC ( %bb -- x addr ) 2 lshift TIM2.CCMR1_Input ; \ TIM2.CCMR1_Input.IC1PSC, Input capture 1 prescaler
: TIM2.CCMR1_Input.CC1S ( %bb -- x addr ) TIM2.CCMR1_Input ; \ TIM2.CCMR1_Input.CC1S, Capture/Compare 1               selection

\ TIM2.CCMR2_Output (read-write) Reset:$00000000
: TIM2.CCMR2_Output.OC4M_3 ( -- x addr ) 24 bit TIM2.CCMR2_Output ; \ TIM2.CCMR2_Output.OC4M_3, Output Compare 4 mode - bit               3
: TIM2.CCMR2_Output.OC3M_3 ( -- x addr ) 16 bit TIM2.CCMR2_Output ; \ TIM2.CCMR2_Output.OC3M_3, Output Compare 3 mode - bit               3
: TIM2.CCMR2_Output.OC4CE ( -- x addr ) 15 bit TIM2.CCMR2_Output ; \ TIM2.CCMR2_Output.OC4CE, Output compare 4 clear               enable
: TIM2.CCMR2_Output.OC4M ( %bbb -- x addr ) 12 lshift TIM2.CCMR2_Output ; \ TIM2.CCMR2_Output.OC4M, Output compare 4 mode
: TIM2.CCMR2_Output.OC4PE ( -- x addr ) 11 bit TIM2.CCMR2_Output ; \ TIM2.CCMR2_Output.OC4PE, Output compare 4 preload               enable
: TIM2.CCMR2_Output.OC4FE ( -- x addr ) 10 bit TIM2.CCMR2_Output ; \ TIM2.CCMR2_Output.OC4FE, Output compare 4 fast               enable
: TIM2.CCMR2_Output.CC4S ( %bb -- x addr ) 8 lshift TIM2.CCMR2_Output ; \ TIM2.CCMR2_Output.CC4S, Capture/Compare 4               selection
: TIM2.CCMR2_Output.OC3CE ( -- x addr ) 7 bit TIM2.CCMR2_Output ; \ TIM2.CCMR2_Output.OC3CE, Output compare 3 clear               enable
: TIM2.CCMR2_Output.OC3M ( %bbb -- x addr ) 4 lshift TIM2.CCMR2_Output ; \ TIM2.CCMR2_Output.OC3M, Output compare 3 mode
: TIM2.CCMR2_Output.OC3PE ( -- x addr ) 3 bit TIM2.CCMR2_Output ; \ TIM2.CCMR2_Output.OC3PE, Output compare 3 preload               enable
: TIM2.CCMR2_Output.OC3FE ( -- x addr ) 2 bit TIM2.CCMR2_Output ; \ TIM2.CCMR2_Output.OC3FE, Output compare 3 fast               enable
: TIM2.CCMR2_Output.CC3S ( %bb -- x addr ) TIM2.CCMR2_Output ; \ TIM2.CCMR2_Output.CC3S, Capture/Compare 3               selection

\ TIM2.CCMR2_Input (read-write) Reset:$00000000
: TIM2.CCMR2_Input.IC4F ( %bbbb -- x addr ) 12 lshift TIM2.CCMR2_Input ; \ TIM2.CCMR2_Input.IC4F, Input capture 4 filter
: TIM2.CCMR2_Input.IC4PSC ( %bb -- x addr ) 10 lshift TIM2.CCMR2_Input ; \ TIM2.CCMR2_Input.IC4PSC, Input capture 4 prescaler
: TIM2.CCMR2_Input.CC4S ( %bb -- x addr ) 8 lshift TIM2.CCMR2_Input ; \ TIM2.CCMR2_Input.CC4S, Capture/Compare 4               selection
: TIM2.CCMR2_Input.IC3F ( %bbbb -- x addr ) 4 lshift TIM2.CCMR2_Input ; \ TIM2.CCMR2_Input.IC3F, Input capture 3 filter
: TIM2.CCMR2_Input.IC3PSC ( %bb -- x addr ) 2 lshift TIM2.CCMR2_Input ; \ TIM2.CCMR2_Input.IC3PSC, Input capture 3 prescaler
: TIM2.CCMR2_Input.CC3S ( %bb -- x addr ) TIM2.CCMR2_Input ; \ TIM2.CCMR2_Input.CC3S, Capture/Compare 3               selection

\ TIM2.CCER (read-write) Reset:$0000
: TIM2.CCER.CC4NP ( -- x addr ) 15 bit TIM2.CCER ; \ TIM2.CCER.CC4NP, Capture/Compare 4 output               Polarity
: TIM2.CCER.CC4P ( -- x addr ) 13 bit TIM2.CCER ; \ TIM2.CCER.CC4P, Capture/Compare 3 output               Polarity
: TIM2.CCER.CC4E ( -- x addr ) 12 bit TIM2.CCER ; \ TIM2.CCER.CC4E, Capture/Compare 4 output               enable
: TIM2.CCER.CC3NP ( -- x addr ) 11 bit TIM2.CCER ; \ TIM2.CCER.CC3NP, Capture/Compare 3 output               Polarity
: TIM2.CCER.CC3P ( -- x addr ) 9 bit TIM2.CCER ; \ TIM2.CCER.CC3P, Capture/Compare 3 output               Polarity
: TIM2.CCER.CC3E ( -- x addr ) 8 bit TIM2.CCER ; \ TIM2.CCER.CC3E, Capture/Compare 3 output               enable
: TIM2.CCER.CC2NP ( -- x addr ) 7 bit TIM2.CCER ; \ TIM2.CCER.CC2NP, Capture/Compare 2 output               Polarity
: TIM2.CCER.CC2P ( -- x addr ) 5 bit TIM2.CCER ; \ TIM2.CCER.CC2P, Capture/Compare 2 output               Polarity
: TIM2.CCER.CC2E ( -- x addr ) 4 bit TIM2.CCER ; \ TIM2.CCER.CC2E, Capture/Compare 2 output               enable
: TIM2.CCER.CC1NP ( -- x addr ) 3 bit TIM2.CCER ; \ TIM2.CCER.CC1NP, Capture/Compare 1 output               Polarity
: TIM2.CCER.CC1P ( -- x addr ) 1 bit TIM2.CCER ; \ TIM2.CCER.CC1P, Capture/Compare 1 output               Polarity
: TIM2.CCER.CC1E ( -- x addr ) 0 bit TIM2.CCER ; \ TIM2.CCER.CC1E, Capture/Compare 1 output               enable

\ TIM2.CNT (read-write) Reset:$00000000
: TIM2.CNT.CNT_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2.CNT ; \ TIM2.CNT.CNT_H, High counter value (TIM2               only)
: TIM2.CNT.CNT_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2.CNT ; \ TIM2.CNT.CNT_L, Low counter value

\ TIM2.PSC (read-write) Reset:$0000
: TIM2.PSC.PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2.PSC ; \ TIM2.PSC.PSC, Prescaler value

\ TIM2.ARR (read-write) Reset:$00000000
: TIM2.ARR.ARR_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2.ARR ; \ TIM2.ARR.ARR_H, High Auto-reload value (TIM2               only)
: TIM2.ARR.ARR_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2.ARR ; \ TIM2.ARR.ARR_L, Low Auto-reload value

\ TIM2.CCR1 (read-write) Reset:$00000000
: TIM2.CCR1.CCR1_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2.CCR1 ; \ TIM2.CCR1.CCR1_H, High Capture/Compare 1 value (TIM2               only)
: TIM2.CCR1.CCR1_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2.CCR1 ; \ TIM2.CCR1.CCR1_L, Low Capture/Compare 1               value

\ TIM2.CCR2 (read-write) Reset:$00000000
: TIM2.CCR2.CCR2_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2.CCR2 ; \ TIM2.CCR2.CCR2_H, High Capture/Compare 2 value (TIM2               only)
: TIM2.CCR2.CCR2_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2.CCR2 ; \ TIM2.CCR2.CCR2_L, Low Capture/Compare 2               value

\ TIM2.CCR3 (read-write) Reset:$00000000
: TIM2.CCR3.CCR3_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2.CCR3 ; \ TIM2.CCR3.CCR3_H, High Capture/Compare value (TIM2               only)
: TIM2.CCR3.CCR3_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2.CCR3 ; \ TIM2.CCR3.CCR3_L, Low Capture/Compare value

\ TIM2.CCR4 (read-write) Reset:$00000000
: TIM2.CCR4.CCR4_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2.CCR4 ; \ TIM2.CCR4.CCR4_H, High Capture/Compare value (TIM2               only)
: TIM2.CCR4.CCR4_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2.CCR4 ; \ TIM2.CCR4.CCR4_L, Low Capture/Compare value

\ TIM2.DCR (read-write) Reset:$0000
: TIM2.DCR.DBL ( %bbbbb -- x addr ) 8 lshift TIM2.DCR ; \ TIM2.DCR.DBL, DMA burst length
: TIM2.DCR.DBA ( %bbbbb -- x addr ) TIM2.DCR ; \ TIM2.DCR.DBA, DMA base address

\ TIM2.DMAR (read-write) Reset:$0000
: TIM2.DMAR.DMAB ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2.DMAR ; \ TIM2.DMAR.DMAB, DMA register for burst               accesses

\ TIM2.OR1 (read-write) Reset:$0000
: TIM2.OR1.IOCREF_CLR ( -- x addr ) 0 bit TIM2.OR1 ; \ TIM2.OR1.IOCREF_CLR, IOCREF_CLR

\ TIM2.AF1 (read-write) Reset:$0000
: TIM2.AF1.ETRSEL ( %bbbb -- x addr ) 14 lshift TIM2.AF1 ; \ TIM2.AF1.ETRSEL, External trigger source               selection

\ TIM2.TISEL (read-write) Reset:$0000
: TIM2.TISEL.TI1SEL ( %bbbb -- x addr ) TIM2.TISEL ; \ TIM2.TISEL.TI1SEL, TI1SEL
: TIM2.TISEL.TI2SEL ( %bbbb -- x addr ) 8 lshift TIM2.TISEL ; \ TIM2.TISEL.TI2SEL, TI2SEL

\ TIM3.CR1 (read-write) Reset:$0000
: TIM3.CR1.UIFREMAP ( -- x addr ) 11 bit TIM3.CR1 ; \ TIM3.CR1.UIFREMAP, UIF status bit remapping
: TIM3.CR1.CKD ( %bb -- x addr ) 8 lshift TIM3.CR1 ; \ TIM3.CR1.CKD, Clock division
: TIM3.CR1.ARPE ( -- x addr ) 7 bit TIM3.CR1 ; \ TIM3.CR1.ARPE, Auto-reload preload enable
: TIM3.CR1.CMS ( %bb -- x addr ) 5 lshift TIM3.CR1 ; \ TIM3.CR1.CMS, Center-aligned mode               selection
: TIM3.CR1.DIR ( -- x addr ) 4 bit TIM3.CR1 ; \ TIM3.CR1.DIR, Direction
: TIM3.CR1.OPM ( -- x addr ) 3 bit TIM3.CR1 ; \ TIM3.CR1.OPM, One-pulse mode
: TIM3.CR1.URS ( -- x addr ) 2 bit TIM3.CR1 ; \ TIM3.CR1.URS, Update request source
: TIM3.CR1.UDIS ( -- x addr ) 1 bit TIM3.CR1 ; \ TIM3.CR1.UDIS, Update disable
: TIM3.CR1.CEN ( -- x addr ) 0 bit TIM3.CR1 ; \ TIM3.CR1.CEN, Counter enable

\ TIM3.CR2 (read-write) Reset:$0000
: TIM3.CR2.TI1S ( -- x addr ) 7 bit TIM3.CR2 ; \ TIM3.CR2.TI1S, TI1 selection
: TIM3.CR2.MMS ( %bbb -- x addr ) 4 lshift TIM3.CR2 ; \ TIM3.CR2.MMS, Master mode selection
: TIM3.CR2.CCDS ( -- x addr ) 3 bit TIM3.CR2 ; \ TIM3.CR2.CCDS, Capture/compare DMA               selection

\ TIM3.SMCR (read-write) Reset:$0000
: TIM3.SMCR.TS_4_3 ( %bb -- x addr ) 20 lshift TIM3.SMCR ; \ TIM3.SMCR.TS_4_3, Trigger selection
: TIM3.SMCR.SMS_3 ( -- x addr ) 16 bit TIM3.SMCR ; \ TIM3.SMCR.SMS_3, Slave mode selection - bit               3
: TIM3.SMCR.ETP ( -- x addr ) 15 bit TIM3.SMCR ; \ TIM3.SMCR.ETP, External trigger polarity
: TIM3.SMCR.ECE ( -- x addr ) 14 bit TIM3.SMCR ; \ TIM3.SMCR.ECE, External clock enable
: TIM3.SMCR.ETPS ( %bb -- x addr ) 12 lshift TIM3.SMCR ; \ TIM3.SMCR.ETPS, External trigger prescaler
: TIM3.SMCR.ETF ( %bbbb -- x addr ) 8 lshift TIM3.SMCR ; \ TIM3.SMCR.ETF, External trigger filter
: TIM3.SMCR.MSM ( -- x addr ) 7 bit TIM3.SMCR ; \ TIM3.SMCR.MSM, Master/Slave mode
: TIM3.SMCR.TS ( %bbb -- x addr ) 4 lshift TIM3.SMCR ; \ TIM3.SMCR.TS, Trigger selection
: TIM3.SMCR.OCCS ( -- x addr ) 3 bit TIM3.SMCR ; \ TIM3.SMCR.OCCS, OCREF clear selection
: TIM3.SMCR.SMS ( %bbb -- x addr ) TIM3.SMCR ; \ TIM3.SMCR.SMS, Slave mode selection

\ TIM3.DIER (read-write) Reset:$0000
: TIM3.DIER.TDE ( -- x addr ) 14 bit TIM3.DIER ; \ TIM3.DIER.TDE, Trigger DMA request enable
: TIM3.DIER.CC4DE ( -- x addr ) 12 bit TIM3.DIER ; \ TIM3.DIER.CC4DE, Capture/Compare 4 DMA request               enable
: TIM3.DIER.CC3DE ( -- x addr ) 11 bit TIM3.DIER ; \ TIM3.DIER.CC3DE, Capture/Compare 3 DMA request               enable
: TIM3.DIER.CC2DE ( -- x addr ) 10 bit TIM3.DIER ; \ TIM3.DIER.CC2DE, Capture/Compare 2 DMA request               enable
: TIM3.DIER.CC1DE ( -- x addr ) 9 bit TIM3.DIER ; \ TIM3.DIER.CC1DE, Capture/Compare 1 DMA request               enable
: TIM3.DIER.UDE ( -- x addr ) 8 bit TIM3.DIER ; \ TIM3.DIER.UDE, Update DMA request enable
: TIM3.DIER.TIE ( -- x addr ) 6 bit TIM3.DIER ; \ TIM3.DIER.TIE, Trigger interrupt enable
: TIM3.DIER.CC4IE ( -- x addr ) 4 bit TIM3.DIER ; \ TIM3.DIER.CC4IE, Capture/Compare 4 interrupt               enable
: TIM3.DIER.CC3IE ( -- x addr ) 3 bit TIM3.DIER ; \ TIM3.DIER.CC3IE, Capture/Compare 3 interrupt               enable
: TIM3.DIER.CC2IE ( -- x addr ) 2 bit TIM3.DIER ; \ TIM3.DIER.CC2IE, Capture/Compare 2 interrupt               enable
: TIM3.DIER.CC1IE ( -- x addr ) 1 bit TIM3.DIER ; \ TIM3.DIER.CC1IE, Capture/Compare 1 interrupt               enable
: TIM3.DIER.UIE ( -- x addr ) 0 bit TIM3.DIER ; \ TIM3.DIER.UIE, Update interrupt enable

\ TIM3.SR (read-write) Reset:$0000
: TIM3.SR.CC4OF ( -- x addr ) 12 bit TIM3.SR ; \ TIM3.SR.CC4OF, Capture/Compare 4 overcapture               flag
: TIM3.SR.CC3OF ( -- x addr ) 11 bit TIM3.SR ; \ TIM3.SR.CC3OF, Capture/Compare 3 overcapture               flag
: TIM3.SR.CC2OF ( -- x addr ) 10 bit TIM3.SR ; \ TIM3.SR.CC2OF, Capture/compare 2 overcapture               flag
: TIM3.SR.CC1OF ( -- x addr ) 9 bit TIM3.SR ; \ TIM3.SR.CC1OF, Capture/Compare 1 overcapture               flag
: TIM3.SR.TIF ( -- x addr ) 6 bit TIM3.SR ; \ TIM3.SR.TIF, Trigger interrupt flag
: TIM3.SR.CC4IF ( -- x addr ) 4 bit TIM3.SR ; \ TIM3.SR.CC4IF, Capture/Compare 4 interrupt               flag
: TIM3.SR.CC3IF ( -- x addr ) 3 bit TIM3.SR ; \ TIM3.SR.CC3IF, Capture/Compare 3 interrupt               flag
: TIM3.SR.CC2IF ( -- x addr ) 2 bit TIM3.SR ; \ TIM3.SR.CC2IF, Capture/Compare 2 interrupt               flag
: TIM3.SR.CC1IF ( -- x addr ) 1 bit TIM3.SR ; \ TIM3.SR.CC1IF, Capture/compare 1 interrupt               flag
: TIM3.SR.UIF ( -- x addr ) 0 bit TIM3.SR ; \ TIM3.SR.UIF, Update interrupt flag

\ TIM3.EGR (write-only) Reset:$0000
: TIM3.EGR.TG ( -- x addr ) 6 bit TIM3.EGR ; \ TIM3.EGR.TG, Trigger generation
: TIM3.EGR.CC4G ( -- x addr ) 4 bit TIM3.EGR ; \ TIM3.EGR.CC4G, Capture/compare 4               generation
: TIM3.EGR.CC3G ( -- x addr ) 3 bit TIM3.EGR ; \ TIM3.EGR.CC3G, Capture/compare 3               generation
: TIM3.EGR.CC2G ( -- x addr ) 2 bit TIM3.EGR ; \ TIM3.EGR.CC2G, Capture/compare 2               generation
: TIM3.EGR.CC1G ( -- x addr ) 1 bit TIM3.EGR ; \ TIM3.EGR.CC1G, Capture/compare 1               generation
: TIM3.EGR.UG ( -- x addr ) 0 bit TIM3.EGR ; \ TIM3.EGR.UG, Update generation

\ TIM3.CCMR1_Output (read-write) Reset:$00000000
: TIM3.CCMR1_Output.OC2M_3 ( -- x addr ) 24 bit TIM3.CCMR1_Output ; \ TIM3.CCMR1_Output.OC2M_3, Output Compare 2 mode - bit               3
: TIM3.CCMR1_Output.OC1M_3 ( -- x addr ) 16 bit TIM3.CCMR1_Output ; \ TIM3.CCMR1_Output.OC1M_3, Output Compare 1 mode - bit               3
: TIM3.CCMR1_Output.OC2CE ( -- x addr ) 15 bit TIM3.CCMR1_Output ; \ TIM3.CCMR1_Output.OC2CE, Output compare 2 clear               enable
: TIM3.CCMR1_Output.OC2M ( %bbb -- x addr ) 12 lshift TIM3.CCMR1_Output ; \ TIM3.CCMR1_Output.OC2M, Output compare 2 mode
: TIM3.CCMR1_Output.OC2PE ( -- x addr ) 11 bit TIM3.CCMR1_Output ; \ TIM3.CCMR1_Output.OC2PE, Output compare 2 preload               enable
: TIM3.CCMR1_Output.OC2FE ( -- x addr ) 10 bit TIM3.CCMR1_Output ; \ TIM3.CCMR1_Output.OC2FE, Output compare 2 fast               enable
: TIM3.CCMR1_Output.CC2S ( %bb -- x addr ) 8 lshift TIM3.CCMR1_Output ; \ TIM3.CCMR1_Output.CC2S, Capture/Compare 2               selection
: TIM3.CCMR1_Output.OC1CE ( -- x addr ) 7 bit TIM3.CCMR1_Output ; \ TIM3.CCMR1_Output.OC1CE, Output compare 1 clear               enable
: TIM3.CCMR1_Output.OC1M ( %bbb -- x addr ) 4 lshift TIM3.CCMR1_Output ; \ TIM3.CCMR1_Output.OC1M, Output compare 1 mode
: TIM3.CCMR1_Output.OC1PE ( -- x addr ) 3 bit TIM3.CCMR1_Output ; \ TIM3.CCMR1_Output.OC1PE, Output compare 1 preload               enable
: TIM3.CCMR1_Output.OC1FE ( -- x addr ) 2 bit TIM3.CCMR1_Output ; \ TIM3.CCMR1_Output.OC1FE, Output compare 1 fast               enable
: TIM3.CCMR1_Output.CC1S ( %bb -- x addr ) TIM3.CCMR1_Output ; \ TIM3.CCMR1_Output.CC1S, Capture/Compare 1               selection

\ TIM3.CCMR1_Input (read-write) Reset:$00000000
: TIM3.CCMR1_Input.IC2F ( %bbbb -- x addr ) 12 lshift TIM3.CCMR1_Input ; \ TIM3.CCMR1_Input.IC2F, Input capture 2 filter
: TIM3.CCMR1_Input.IC2PSC ( %bb -- x addr ) 10 lshift TIM3.CCMR1_Input ; \ TIM3.CCMR1_Input.IC2PSC, Input capture 2 prescaler
: TIM3.CCMR1_Input.CC2S ( %bb -- x addr ) 8 lshift TIM3.CCMR1_Input ; \ TIM3.CCMR1_Input.CC2S, Capture/compare 2               selection
: TIM3.CCMR1_Input.IC1F ( %bbbb -- x addr ) 4 lshift TIM3.CCMR1_Input ; \ TIM3.CCMR1_Input.IC1F, Input capture 1 filter
: TIM3.CCMR1_Input.IC1PSC ( %bb -- x addr ) 2 lshift TIM3.CCMR1_Input ; \ TIM3.CCMR1_Input.IC1PSC, Input capture 1 prescaler
: TIM3.CCMR1_Input.CC1S ( %bb -- x addr ) TIM3.CCMR1_Input ; \ TIM3.CCMR1_Input.CC1S, Capture/Compare 1               selection

\ TIM3.CCMR2_Output (read-write) Reset:$00000000
: TIM3.CCMR2_Output.OC4M_3 ( -- x addr ) 24 bit TIM3.CCMR2_Output ; \ TIM3.CCMR2_Output.OC4M_3, Output Compare 4 mode - bit               3
: TIM3.CCMR2_Output.OC3M_3 ( -- x addr ) 16 bit TIM3.CCMR2_Output ; \ TIM3.CCMR2_Output.OC3M_3, Output Compare 3 mode - bit               3
: TIM3.CCMR2_Output.OC4CE ( -- x addr ) 15 bit TIM3.CCMR2_Output ; \ TIM3.CCMR2_Output.OC4CE, Output compare 4 clear               enable
: TIM3.CCMR2_Output.OC4M ( %bbb -- x addr ) 12 lshift TIM3.CCMR2_Output ; \ TIM3.CCMR2_Output.OC4M, Output compare 4 mode
: TIM3.CCMR2_Output.OC4PE ( -- x addr ) 11 bit TIM3.CCMR2_Output ; \ TIM3.CCMR2_Output.OC4PE, Output compare 4 preload               enable
: TIM3.CCMR2_Output.OC4FE ( -- x addr ) 10 bit TIM3.CCMR2_Output ; \ TIM3.CCMR2_Output.OC4FE, Output compare 4 fast               enable
: TIM3.CCMR2_Output.CC4S ( %bb -- x addr ) 8 lshift TIM3.CCMR2_Output ; \ TIM3.CCMR2_Output.CC4S, Capture/Compare 4               selection
: TIM3.CCMR2_Output.OC3CE ( -- x addr ) 7 bit TIM3.CCMR2_Output ; \ TIM3.CCMR2_Output.OC3CE, Output compare 3 clear               enable
: TIM3.CCMR2_Output.OC3M ( %bbb -- x addr ) 4 lshift TIM3.CCMR2_Output ; \ TIM3.CCMR2_Output.OC3M, Output compare 3 mode
: TIM3.CCMR2_Output.OC3PE ( -- x addr ) 3 bit TIM3.CCMR2_Output ; \ TIM3.CCMR2_Output.OC3PE, Output compare 3 preload               enable
: TIM3.CCMR2_Output.OC3FE ( -- x addr ) 2 bit TIM3.CCMR2_Output ; \ TIM3.CCMR2_Output.OC3FE, Output compare 3 fast               enable
: TIM3.CCMR2_Output.CC3S ( %bb -- x addr ) TIM3.CCMR2_Output ; \ TIM3.CCMR2_Output.CC3S, Capture/Compare 3               selection

\ TIM3.CCMR2_Input (read-write) Reset:$00000000
: TIM3.CCMR2_Input.IC4F ( %bbbb -- x addr ) 12 lshift TIM3.CCMR2_Input ; \ TIM3.CCMR2_Input.IC4F, Input capture 4 filter
: TIM3.CCMR2_Input.IC4PSC ( %bb -- x addr ) 10 lshift TIM3.CCMR2_Input ; \ TIM3.CCMR2_Input.IC4PSC, Input capture 4 prescaler
: TIM3.CCMR2_Input.CC4S ( %bb -- x addr ) 8 lshift TIM3.CCMR2_Input ; \ TIM3.CCMR2_Input.CC4S, Capture/Compare 4               selection
: TIM3.CCMR2_Input.IC3F ( %bbbb -- x addr ) 4 lshift TIM3.CCMR2_Input ; \ TIM3.CCMR2_Input.IC3F, Input capture 3 filter
: TIM3.CCMR2_Input.IC3PSC ( %bb -- x addr ) 2 lshift TIM3.CCMR2_Input ; \ TIM3.CCMR2_Input.IC3PSC, Input capture 3 prescaler
: TIM3.CCMR2_Input.CC3S ( %bb -- x addr ) TIM3.CCMR2_Input ; \ TIM3.CCMR2_Input.CC3S, Capture/Compare 3               selection

\ TIM3.CCER (read-write) Reset:$0000
: TIM3.CCER.CC4NP ( -- x addr ) 15 bit TIM3.CCER ; \ TIM3.CCER.CC4NP, Capture/Compare 4 output               Polarity
: TIM3.CCER.CC4P ( -- x addr ) 13 bit TIM3.CCER ; \ TIM3.CCER.CC4P, Capture/Compare 3 output               Polarity
: TIM3.CCER.CC4E ( -- x addr ) 12 bit TIM3.CCER ; \ TIM3.CCER.CC4E, Capture/Compare 4 output               enable
: TIM3.CCER.CC3NP ( -- x addr ) 11 bit TIM3.CCER ; \ TIM3.CCER.CC3NP, Capture/Compare 3 output               Polarity
: TIM3.CCER.CC3P ( -- x addr ) 9 bit TIM3.CCER ; \ TIM3.CCER.CC3P, Capture/Compare 3 output               Polarity
: TIM3.CCER.CC3E ( -- x addr ) 8 bit TIM3.CCER ; \ TIM3.CCER.CC3E, Capture/Compare 3 output               enable
: TIM3.CCER.CC2NP ( -- x addr ) 7 bit TIM3.CCER ; \ TIM3.CCER.CC2NP, Capture/Compare 2 output               Polarity
: TIM3.CCER.CC2P ( -- x addr ) 5 bit TIM3.CCER ; \ TIM3.CCER.CC2P, Capture/Compare 2 output               Polarity
: TIM3.CCER.CC2E ( -- x addr ) 4 bit TIM3.CCER ; \ TIM3.CCER.CC2E, Capture/Compare 2 output               enable
: TIM3.CCER.CC1NP ( -- x addr ) 3 bit TIM3.CCER ; \ TIM3.CCER.CC1NP, Capture/Compare 1 output               Polarity
: TIM3.CCER.CC1P ( -- x addr ) 1 bit TIM3.CCER ; \ TIM3.CCER.CC1P, Capture/Compare 1 output               Polarity
: TIM3.CCER.CC1E ( -- x addr ) 0 bit TIM3.CCER ; \ TIM3.CCER.CC1E, Capture/Compare 1 output               enable

\ TIM3.CNT (read-write) Reset:$00000000
: TIM3.CNT.CNT_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM3.CNT ; \ TIM3.CNT.CNT_H, High counter value (TIM2               only)
: TIM3.CNT.CNT_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3.CNT ; \ TIM3.CNT.CNT_L, Low counter value

\ TIM3.PSC (read-write) Reset:$0000
: TIM3.PSC.PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3.PSC ; \ TIM3.PSC.PSC, Prescaler value

\ TIM3.ARR (read-write) Reset:$00000000
: TIM3.ARR.ARR_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM3.ARR ; \ TIM3.ARR.ARR_H, High Auto-reload value (TIM2               only)
: TIM3.ARR.ARR_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3.ARR ; \ TIM3.ARR.ARR_L, Low Auto-reload value

\ TIM3.CCR1 (read-write) Reset:$00000000
: TIM3.CCR1.CCR1_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM3.CCR1 ; \ TIM3.CCR1.CCR1_H, High Capture/Compare 1 value (TIM2               only)
: TIM3.CCR1.CCR1_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3.CCR1 ; \ TIM3.CCR1.CCR1_L, Low Capture/Compare 1               value

\ TIM3.CCR2 (read-write) Reset:$00000000
: TIM3.CCR2.CCR2_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM3.CCR2 ; \ TIM3.CCR2.CCR2_H, High Capture/Compare 2 value (TIM2               only)
: TIM3.CCR2.CCR2_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3.CCR2 ; \ TIM3.CCR2.CCR2_L, Low Capture/Compare 2               value

\ TIM3.CCR3 (read-write) Reset:$00000000
: TIM3.CCR3.CCR3_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM3.CCR3 ; \ TIM3.CCR3.CCR3_H, High Capture/Compare value (TIM2               only)
: TIM3.CCR3.CCR3_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3.CCR3 ; \ TIM3.CCR3.CCR3_L, Low Capture/Compare value

\ TIM3.CCR4 (read-write) Reset:$00000000
: TIM3.CCR4.CCR4_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM3.CCR4 ; \ TIM3.CCR4.CCR4_H, High Capture/Compare value (TIM2               only)
: TIM3.CCR4.CCR4_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3.CCR4 ; \ TIM3.CCR4.CCR4_L, Low Capture/Compare value

\ TIM3.DCR (read-write) Reset:$0000
: TIM3.DCR.DBL ( %bbbbb -- x addr ) 8 lshift TIM3.DCR ; \ TIM3.DCR.DBL, DMA burst length
: TIM3.DCR.DBA ( %bbbbb -- x addr ) TIM3.DCR ; \ TIM3.DCR.DBA, DMA base address

\ TIM3.DMAR (read-write) Reset:$0000
: TIM3.DMAR.DMAB ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3.DMAR ; \ TIM3.DMAR.DMAB, DMA register for burst               accesses

\ TIM3.OR1 (read-write) Reset:$0000
: TIM3.OR1.IOCREF_CLR ( -- x addr ) 0 bit TIM3.OR1 ; \ TIM3.OR1.IOCREF_CLR, IOCREF_CLR

\ TIM3.AF1 (read-write) Reset:$0000
: TIM3.AF1.ETRSEL ( %bbbb -- x addr ) 14 lshift TIM3.AF1 ; \ TIM3.AF1.ETRSEL, External trigger source               selection

\ TIM3.TISEL (read-write) Reset:$0000
: TIM3.TISEL.TI1SEL ( %bbbb -- x addr ) TIM3.TISEL ; \ TIM3.TISEL.TI1SEL, TI1SEL
: TIM3.TISEL.TI2SEL ( %bbbb -- x addr ) 8 lshift TIM3.TISEL ; \ TIM3.TISEL.TI2SEL, TI2SEL

\ NVIC.ISER (read-write) Reset:$00000000
: NVIC.ISER.SETENA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) NVIC.ISER ; \ NVIC.ISER.SETENA, SETENA

\ NVIC.ICER (read-write) Reset:$00000000
: NVIC.ICER.CLRENA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) NVIC.ICER ; \ NVIC.ICER.CLRENA, CLRENA

\ NVIC.ISPR (read-write) Reset:$00000000
: NVIC.ISPR.SETPEND ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) NVIC.ISPR ; \ NVIC.ISPR.SETPEND, SETPEND

\ NVIC.ICPR (read-write) Reset:$00000000
: NVIC.ICPR.CLRPEND ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) NVIC.ICPR ; \ NVIC.ICPR.CLRPEND, CLRPEND

\ NVIC.IPR0 (read-write) Reset:$00000000
: NVIC.IPR0.PRI_0 ( %bbbbbbbb -- x addr ) NVIC.IPR0 ; \ NVIC.IPR0.PRI_0, priority for interrupt 0
: NVIC.IPR0.PRI_1 ( %bbbbbbbb -- x addr ) 8 lshift NVIC.IPR0 ; \ NVIC.IPR0.PRI_1, priority for interrupt 1
: NVIC.IPR0.PRI_2 ( %bbbbbbbb -- x addr ) 16 lshift NVIC.IPR0 ; \ NVIC.IPR0.PRI_2, priority for interrupt 2
: NVIC.IPR0.PRI_3 ( %bbbbbbbb -- x addr ) 24 lshift NVIC.IPR0 ; \ NVIC.IPR0.PRI_3, priority for interrupt 3

\ NVIC.IPR1 (read-write) Reset:$00000000
: NVIC.IPR1.PRI_4 ( %bbbbbbbb -- x addr ) NVIC.IPR1 ; \ NVIC.IPR1.PRI_4, priority for interrupt n
: NVIC.IPR1.PRI_5 ( %bbbbbbbb -- x addr ) 8 lshift NVIC.IPR1 ; \ NVIC.IPR1.PRI_5, priority for interrupt n
: NVIC.IPR1.PRI_6 ( %bbbbbbbb -- x addr ) 16 lshift NVIC.IPR1 ; \ NVIC.IPR1.PRI_6, priority for interrupt n
: NVIC.IPR1.PRI_7 ( %bbbbbbbb -- x addr ) 24 lshift NVIC.IPR1 ; \ NVIC.IPR1.PRI_7, priority for interrupt n

\ NVIC.IPR2 (read-write) Reset:$00000000
: NVIC.IPR2.PRI_8 ( %bbbbbbbb -- x addr ) NVIC.IPR2 ; \ NVIC.IPR2.PRI_8, priority for interrupt n
: NVIC.IPR2.PRI_9 ( %bbbbbbbb -- x addr ) 8 lshift NVIC.IPR2 ; \ NVIC.IPR2.PRI_9, priority for interrupt n
: NVIC.IPR2.PRI_10 ( %bbbbbbbb -- x addr ) 16 lshift NVIC.IPR2 ; \ NVIC.IPR2.PRI_10, priority for interrupt n
: NVIC.IPR2.PRI_11 ( %bbbbbbbb -- x addr ) 24 lshift NVIC.IPR2 ; \ NVIC.IPR2.PRI_11, priority for interrupt n

\ NVIC.IPR3 (read-write) Reset:$00000000
: NVIC.IPR3.PRI_12 ( %bbbbbbbb -- x addr ) NVIC.IPR3 ; \ NVIC.IPR3.PRI_12, priority for interrupt n
: NVIC.IPR3.PRI_13 ( %bbbbbbbb -- x addr ) 8 lshift NVIC.IPR3 ; \ NVIC.IPR3.PRI_13, priority for interrupt n
: NVIC.IPR3.PRI_14 ( %bbbbbbbb -- x addr ) 16 lshift NVIC.IPR3 ; \ NVIC.IPR3.PRI_14, priority for interrupt n
: NVIC.IPR3.PRI_15 ( %bbbbbbbb -- x addr ) 24 lshift NVIC.IPR3 ; \ NVIC.IPR3.PRI_15, priority for interrupt n

\ NVIC.IPR4 (read-write) Reset:$00000000
: NVIC.IPR4.PRI_16 ( %bbbbbbbb -- x addr ) NVIC.IPR4 ; \ NVIC.IPR4.PRI_16, priority for interrupt n
: NVIC.IPR4.PRI_17 ( %bbbbbbbb -- x addr ) 8 lshift NVIC.IPR4 ; \ NVIC.IPR4.PRI_17, priority for interrupt n
: NVIC.IPR4.PRI_18 ( %bbbbbbbb -- x addr ) 16 lshift NVIC.IPR4 ; \ NVIC.IPR4.PRI_18, priority for interrupt n
: NVIC.IPR4.PRI_19 ( %bbbbbbbb -- x addr ) 24 lshift NVIC.IPR4 ; \ NVIC.IPR4.PRI_19, priority for interrupt n

\ NVIC.IPR5 (read-write) Reset:$00000000
: NVIC.IPR5.PRI_20 ( %bbbbbbbb -- x addr ) NVIC.IPR5 ; \ NVIC.IPR5.PRI_20, priority for interrupt n
: NVIC.IPR5.PRI_21 ( %bbbbbbbb -- x addr ) 8 lshift NVIC.IPR5 ; \ NVIC.IPR5.PRI_21, priority for interrupt n
: NVIC.IPR5.PRI_22 ( %bbbbbbbb -- x addr ) 16 lshift NVIC.IPR5 ; \ NVIC.IPR5.PRI_22, priority for interrupt n
: NVIC.IPR5.PRI_23 ( %bbbbbbbb -- x addr ) 24 lshift NVIC.IPR5 ; \ NVIC.IPR5.PRI_23, priority for interrupt n

\ NVIC.IPR6 (read-write) Reset:$00000000
: NVIC.IPR6.PRI_24 ( %bbbbbbbb -- x addr ) NVIC.IPR6 ; \ NVIC.IPR6.PRI_24, priority for interrupt n
: NVIC.IPR6.PRI_25 ( %bbbbbbbb -- x addr ) 8 lshift NVIC.IPR6 ; \ NVIC.IPR6.PRI_25, priority for interrupt n
: NVIC.IPR6.PRI_26 ( %bbbbbbbb -- x addr ) 16 lshift NVIC.IPR6 ; \ NVIC.IPR6.PRI_26, priority for interrupt n
: NVIC.IPR6.PRI_27 ( %bbbbbbbb -- x addr ) 24 lshift NVIC.IPR6 ; \ NVIC.IPR6.PRI_27, priority for interrupt n

\ NVIC.IPR7 (read-write) Reset:$00000000
: NVIC.IPR7.PRI_28 ( %bbbbbbbb -- x addr ) NVIC.IPR7 ; \ NVIC.IPR7.PRI_28, priority for interrupt n
: NVIC.IPR7.PRI_29 ( %bbbbbbbb -- x addr ) 8 lshift NVIC.IPR7 ; \ NVIC.IPR7.PRI_29, priority for interrupt n
: NVIC.IPR7.PRI_30 ( %bbbbbbbb -- x addr ) 16 lshift NVIC.IPR7 ; \ NVIC.IPR7.PRI_30, priority for interrupt n
: NVIC.IPR7.PRI_31 ( %bbbbbbbb -- x addr ) 24 lshift NVIC.IPR7 ; \ NVIC.IPR7.PRI_31, priority for interrupt n

\ NVIC.IPR8 (read-write) Reset:$00000000

\ MPU.MPU_TYPER (read-only) Reset:0X00000800
: MPU.MPU_TYPER.SEPARATE? ( --  1|0 ) 0 bit MPU.MPU_TYPER bit@ ; \ MPU.MPU_TYPER.SEPARATE, Separate flag
: MPU.MPU_TYPER.DREGION? ( --  x ) 8 lshift MPU.MPU_TYPER @ ; \ MPU.MPU_TYPER.DREGION, Number of MPU data regions
: MPU.MPU_TYPER.IREGION? ( --  x ) 16 lshift MPU.MPU_TYPER @ ; \ MPU.MPU_TYPER.IREGION, Number of MPU instruction               regions

\ MPU.MPU_CTRL (read-only) Reset:0X00000000
: MPU.MPU_CTRL.ENABLE? ( --  1|0 ) 0 bit MPU.MPU_CTRL bit@ ; \ MPU.MPU_CTRL.ENABLE, Enables the MPU
: MPU.MPU_CTRL.HFNMIENA? ( --  1|0 ) 1 bit MPU.MPU_CTRL bit@ ; \ MPU.MPU_CTRL.HFNMIENA, Enables the operation of MPU during hard               fault
: MPU.MPU_CTRL.PRIVDEFENA? ( --  1|0 ) 2 bit MPU.MPU_CTRL bit@ ; \ MPU.MPU_CTRL.PRIVDEFENA, Enable priviliged software access to               default memory map

\ MPU.MPU_RNR (read-write) Reset:0X00000000
: MPU.MPU_RNR.REGION ( %bbbbbbbb -- x addr ) MPU.MPU_RNR ; \ MPU.MPU_RNR.REGION, MPU region

\ MPU.MPU_RBAR (read-write) Reset:0X00000000
: MPU.MPU_RBAR.REGION ( %bbbb -- x addr ) MPU.MPU_RBAR ; \ MPU.MPU_RBAR.REGION, MPU region field
: MPU.MPU_RBAR.VALID ( -- x addr ) 4 bit MPU.MPU_RBAR ; \ MPU.MPU_RBAR.VALID, MPU region number valid
: MPU.MPU_RBAR.ADDR x addr ) 5 lshift MPU.MPU_RBAR ; \ MPU.MPU_RBAR.ADDR, Region base address field

\ MPU.MPU_RASR (read-write) Reset:0X00000000
: MPU.MPU_RASR.ENABLE ( -- x addr ) 0 bit MPU.MPU_RASR ; \ MPU.MPU_RASR.ENABLE, Region enable bit.
: MPU.MPU_RASR.SIZE ( %bbbbb -- x addr ) 1 lshift MPU.MPU_RASR ; \ MPU.MPU_RASR.SIZE, Size of the MPU protection               region
: MPU.MPU_RASR.SRD ( %bbbbbbbb -- x addr ) 8 lshift MPU.MPU_RASR ; \ MPU.MPU_RASR.SRD, Subregion disable bits
: MPU.MPU_RASR.B ( -- x addr ) 16 bit MPU.MPU_RASR ; \ MPU.MPU_RASR.B, memory attribute
: MPU.MPU_RASR.C ( -- x addr ) 17 bit MPU.MPU_RASR ; \ MPU.MPU_RASR.C, memory attribute
: MPU.MPU_RASR.S ( -- x addr ) 18 bit MPU.MPU_RASR ; \ MPU.MPU_RASR.S, Shareable memory attribute
: MPU.MPU_RASR.TEX ( %bbb -- x addr ) 19 lshift MPU.MPU_RASR ; \ MPU.MPU_RASR.TEX, memory attribute
: MPU.MPU_RASR.AP ( %bbb -- x addr ) 24 lshift MPU.MPU_RASR ; \ MPU.MPU_RASR.AP, Access permission
: MPU.MPU_RASR.XN ( -- x addr ) 28 bit MPU.MPU_RASR ; \ MPU.MPU_RASR.XN, Instruction access disable               bit

\ STK.CSR (read-write) Reset:0X00000000
: STK.CSR.ENABLE ( -- x addr ) 0 bit STK.CSR ; \ STK.CSR.ENABLE, Counter enable
: STK.CSR.TICKINT ( -- x addr ) 1 bit STK.CSR ; \ STK.CSR.TICKINT, SysTick exception request               enable
: STK.CSR.CLKSOURCE ( -- x addr ) 2 bit STK.CSR ; \ STK.CSR.CLKSOURCE, Clock source selection
: STK.CSR.COUNTFLAG ( -- x addr ) 16 bit STK.CSR ; \ STK.CSR.COUNTFLAG, COUNTFLAG

\ STK.RVR (read-write) Reset:0X00000000
: STK.RVR.RELOAD ( %bbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) STK.RVR ; \ STK.RVR.RELOAD, RELOAD value

\ STK.CVR (read-write) Reset:0X00000000
: STK.CVR.CURRENT ( %bbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) STK.CVR ; \ STK.CVR.CURRENT, Current counter value

\ STK.CALIB (read-write) Reset:0X00000000
: STK.CALIB.TENMS ( %bbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) STK.CALIB ; \ STK.CALIB.TENMS, Calibration value
: STK.CALIB.SKEW ( -- x addr ) 30 bit STK.CALIB ; \ STK.CALIB.SKEW, SKEW flag: Indicates whether the TENMS               value is exact
: STK.CALIB.NOREF ( -- x addr ) 31 bit STK.CALIB ; \ STK.CALIB.NOREF, NOREF flag. Reads as zero

\ SCB.CPUID (read-only) Reset:$410FC241
: SCB.CPUID.Revision? ( --  x ) SCB.CPUID @ ; \ SCB.CPUID.Revision, Revision number
: SCB.CPUID.PartNo? ( --  x ) 4 lshift SCB.CPUID @ ; \ SCB.CPUID.PartNo, Part number of the               processor
: SCB.CPUID.Architecture? ( --  x ) 16 lshift SCB.CPUID @ ; \ SCB.CPUID.Architecture, Reads as $F
: SCB.CPUID.Variant? ( --  x ) 20 lshift SCB.CPUID @ ; \ SCB.CPUID.Variant, Variant number
: SCB.CPUID.Implementer? ( --  x ) 24 lshift SCB.CPUID @ ; \ SCB.CPUID.Implementer, Implementer code

\ SCB.ICSR (read-write) Reset:$00000000
: SCB.ICSR.VECTACTIVE ( %bbbbbbbbb -- x addr ) SCB.ICSR ; \ SCB.ICSR.VECTACTIVE, Active vector
: SCB.ICSR.RETTOBASE ( -- x addr ) 11 bit SCB.ICSR ; \ SCB.ICSR.RETTOBASE, Return to base level
: SCB.ICSR.VECTPENDING ( %bbbbbbb -- x addr ) 12 lshift SCB.ICSR ; \ SCB.ICSR.VECTPENDING, Pending vector
: SCB.ICSR.ISRPENDING ( -- x addr ) 22 bit SCB.ICSR ; \ SCB.ICSR.ISRPENDING, Interrupt pending flag
: SCB.ICSR.PENDSTCLR ( -- x addr ) 25 bit SCB.ICSR ; \ SCB.ICSR.PENDSTCLR, SysTick exception clear-pending               bit
: SCB.ICSR.PENDSTSET ( -- x addr ) 26 bit SCB.ICSR ; \ SCB.ICSR.PENDSTSET, SysTick exception set-pending               bit
: SCB.ICSR.PENDSVCLR ( -- x addr ) 27 bit SCB.ICSR ; \ SCB.ICSR.PENDSVCLR, PendSV clear-pending bit
: SCB.ICSR.PENDSVSET ( -- x addr ) 28 bit SCB.ICSR ; \ SCB.ICSR.PENDSVSET, PendSV set-pending bit
: SCB.ICSR.NMIPENDSET ( -- x addr ) 31 bit SCB.ICSR ; \ SCB.ICSR.NMIPENDSET, NMI set-pending bit.

\ SCB.VTOR (read-write) Reset:$00000000
: SCB.VTOR.TBLOFF x addr ) 7 lshift SCB.VTOR ; \ SCB.VTOR.TBLOFF, Vector table base offset               field

\ SCB.AIRCR (read-write) Reset:$00000000
: SCB.AIRCR.VECTCLRACTIVE ( -- x addr ) 1 bit SCB.AIRCR ; \ SCB.AIRCR.VECTCLRACTIVE, VECTCLRACTIVE
: SCB.AIRCR.SYSRESETREQ ( -- x addr ) 2 bit SCB.AIRCR ; \ SCB.AIRCR.SYSRESETREQ, SYSRESETREQ
: SCB.AIRCR.ENDIANESS ( -- x addr ) 15 bit SCB.AIRCR ; \ SCB.AIRCR.ENDIANESS, ENDIANESS
: SCB.AIRCR.VECTKEYSTAT ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift SCB.AIRCR ; \ SCB.AIRCR.VECTKEYSTAT, Register key

\ SCB.SCR (read-write) Reset:$00000000
: SCB.SCR.SLEEPONEXIT ( -- x addr ) 1 bit SCB.SCR ; \ SCB.SCR.SLEEPONEXIT, SLEEPONEXIT
: SCB.SCR.SLEEPDEEP ( -- x addr ) 2 bit SCB.SCR ; \ SCB.SCR.SLEEPDEEP, SLEEPDEEP
: SCB.SCR.SEVEONPEND ( -- x addr ) 4 bit SCB.SCR ; \ SCB.SCR.SEVEONPEND, Send Event on Pending bit

\ SCB.CCR (read-write) Reset:$00000000
: SCB.CCR.NONBASETHRDENA ( -- x addr ) 0 bit SCB.CCR ; \ SCB.CCR.NONBASETHRDENA, Configures how the processor enters               Thread mode
: SCB.CCR.USERSETMPEND ( -- x addr ) 1 bit SCB.CCR ; \ SCB.CCR.USERSETMPEND, USERSETMPEND
: SCB.CCR.UNALIGN__TRP ( -- x addr ) 3 bit SCB.CCR ; \ SCB.CCR.UNALIGN__TRP, UNALIGN_ TRP
: SCB.CCR.DIV_0_TRP ( -- x addr ) 4 bit SCB.CCR ; \ SCB.CCR.DIV_0_TRP, DIV_0_TRP
: SCB.CCR.BFHFNMIGN ( -- x addr ) 8 bit SCB.CCR ; \ SCB.CCR.BFHFNMIGN, BFHFNMIGN
: SCB.CCR.STKALIGN ( -- x addr ) 9 bit SCB.CCR ; \ SCB.CCR.STKALIGN, STKALIGN

\ SCB.SHPR2 (read-write) Reset:$00000000
: SCB.SHPR2.PRI_11 ( %bbbbbbbb -- x addr ) 24 lshift SCB.SHPR2 ; \ SCB.SHPR2.PRI_11, Priority of system handler               11

\ SCB.SHPR3 (read-write) Reset:$00000000
: SCB.SHPR3.PRI_14 ( %bbbbbbbb -- x addr ) 16 lshift SCB.SHPR3 ; \ SCB.SHPR3.PRI_14, Priority of system handler               14
: SCB.SHPR3.PRI_15 ( %bbbbbbbb -- x addr ) 24 lshift SCB.SHPR3 ; \ SCB.SHPR3.PRI_15, Priority of system handler               15

\ VREFBUF.CSR (multiple-access)  Reset:$00000002
: VREFBUF.CSR.ENVR ( -- x addr ) 0 bit VREFBUF.CSR ; \ VREFBUF.CSR.ENVR, Voltage reference buffer mode enable               This bit is used to enable the voltage reference               buffer mode.
: VREFBUF.CSR.HIZ ( -- x addr ) 1 bit VREFBUF.CSR ; \ VREFBUF.CSR.HIZ, High impedance mode This bit controls               the analog switch to connect or not the VREF+ pin.               Refer to Table196: VREF buffer modes for the mode               descriptions depending on ENVR bit               configuration.
: VREFBUF.CSR.VRR ( -- x addr ) 3 bit VREFBUF.CSR ; \ VREFBUF.CSR.VRR, Voltage reference buffer               ready
: VREFBUF.CSR.VRS ( %bbb -- x addr ) 4 lshift VREFBUF.CSR ; \ VREFBUF.CSR.VRS, Voltage reference scale These bits               select the value generated by the voltage reference               buffer. Other: Reserved

\ VREFBUF.CCR (read-write) Reset:$00000000
: VREFBUF.CCR.TRIM ( %bbbbbb -- x addr ) VREFBUF.CCR ; \ VREFBUF.CCR.TRIM, Trimming code These bits are               automatically initialized after reset with the               trimming value stored in the Flash memory during the               production test. Writing into these bits allows to               tune the internal reference buffer               voltage.

\ DBG.IDCODE (read-only) Reset:$00000000
: DBG.IDCODE.DEV_ID? ( --  x ) DBG.IDCODE @ ; \ DBG.IDCODE.DEV_ID, Device identifier
: DBG.IDCODE.REV_ID? ( --  x ) 16 lshift DBG.IDCODE @ ; \ DBG.IDCODE.REV_ID, Revision identifie

\ DBG.CR (read-write) Reset:$00000000
: DBG.CR.DBG_STOP ( -- x addr ) 1 bit DBG.CR ; \ DBG.CR.DBG_STOP, Debug Stop mode
: DBG.CR.DBG_STANDBY ( -- x addr ) 2 bit DBG.CR ; \ DBG.CR.DBG_STANDBY, Debug Standby mode

\ DBG.APB_FZ1 (read-write) Reset:$00000000
: DBG.APB_FZ1.DBG_TIM2_STOP ( -- x addr ) 0 bit DBG.APB_FZ1 ; \ DBG.APB_FZ1.DBG_TIM2_STOP, TIM2 counter stopped when core is               halted
: DBG.APB_FZ1.DBG_TIM3_STOP ( -- x addr ) 1 bit DBG.APB_FZ1 ; \ DBG.APB_FZ1.DBG_TIM3_STOP, TIM3 counter stopped when core is               halted
: DBG.APB_FZ1.DBG_RTC_STOP ( -- x addr ) 10 bit DBG.APB_FZ1 ; \ DBG.APB_FZ1.DBG_RTC_STOP, RTC counter stopped when core is               halted
: DBG.APB_FZ1.DBG_WWDG_STOP ( -- x addr ) 11 bit DBG.APB_FZ1 ; \ DBG.APB_FZ1.DBG_WWDG_STOP, Window watchdog counter stopped when               core is halted
: DBG.APB_FZ1.DBG_IWDG_STOP ( -- x addr ) 12 bit DBG.APB_FZ1 ; \ DBG.APB_FZ1.DBG_IWDG_STOP, Independent watchdog counter stopped               when core is halted
: DBG.APB_FZ1.DBG_I2C1_STOP ( -- x addr ) 21 bit DBG.APB_FZ1 ; \ DBG.APB_FZ1.DBG_I2C1_STOP, I2C1 SMBUS timeout counter stopped when               core is halted

\ DBG.APB_FZ2 (read-write) Reset:$00000000
: DBG.APB_FZ2.DBG_TIM1_STOP ( -- x addr ) 11 bit DBG.APB_FZ2 ; \ DBG.APB_FZ2.DBG_TIM1_STOP, TIM1 counter stopped when core is               halted
: DBG.APB_FZ2.DBG_TIM14_STOP ( -- x addr ) 15 bit DBG.APB_FZ2 ; \ DBG.APB_FZ2.DBG_TIM14_STOP, DBG_TIM14_STOP
: DBG.APB_FZ2.DBG_TIM16_STOP ( -- x addr ) 17 bit DBG.APB_FZ2 ; \ DBG.APB_FZ2.DBG_TIM16_STOP, DBG_TIM16_STOP
: DBG.APB_FZ2.DBG_TIM17_STOP ( -- x addr ) 18 bit DBG.APB_FZ2 ; \ DBG.APB_FZ2.DBG_TIM17_STOP, DBG_TIM17_STOP

\ NVIC_STIR.STIR (read-write) Reset:$00000000
: NVIC_STIR.STIR.INTID ( %bbbbbbbbb -- x addr ) NVIC_STIR.STIR ; \ NVIC_STIR.STIR.INTID, Software generated interrupt               ID

\ SCB_ACTRL.ACTRL (read-write) Reset:$00000000
: SCB_ACTRL.ACTRL.DISMCYCINT ( -- x addr ) 0 bit SCB_ACTRL.ACTRL ; \ SCB_ACTRL.ACTRL.DISMCYCINT, DISMCYCINT
: SCB_ACTRL.ACTRL.DISDEFWBUF ( -- x addr ) 1 bit SCB_ACTRL.ACTRL ; \ SCB_ACTRL.ACTRL.DISDEFWBUF, DISDEFWBUF
: SCB_ACTRL.ACTRL.DISFOLD ( -- x addr ) 2 bit SCB_ACTRL.ACTRL ; \ SCB_ACTRL.ACTRL.DISFOLD, DISFOLD
: SCB_ACTRL.ACTRL.DISFPCA ( -- x addr ) 8 bit SCB_ACTRL.ACTRL ; \ SCB_ACTRL.ACTRL.DISFPCA, DISFPCA
: SCB_ACTRL.ACTRL.DISOOFP ( -- x addr ) 9 bit SCB_ACTRL.ACTRL ; \ SCB_ACTRL.ACTRL.DISOOFP, DISOOFP

\ FPU_CPACR.CPACR (read-write) Reset:$0000000
: FPU_CPACR.CPACR.CP ( %bbbb -- x addr ) 20 lshift FPU_CPACR.CPACR ; \ FPU_CPACR.CPACR.CP, CP

\ FPU.FPCCR (read-write) Reset:$00000000
: FPU.FPCCR.LSPACT ( -- x addr ) 0 bit FPU.FPCCR ; \ FPU.FPCCR.LSPACT, LSPACT
: FPU.FPCCR.USER ( -- x addr ) 1 bit FPU.FPCCR ; \ FPU.FPCCR.USER, USER
: FPU.FPCCR.THREAD ( -- x addr ) 3 bit FPU.FPCCR ; \ FPU.FPCCR.THREAD, THREAD
: FPU.FPCCR.HFRDY ( -- x addr ) 4 bit FPU.FPCCR ; \ FPU.FPCCR.HFRDY, HFRDY
: FPU.FPCCR.MMRDY ( -- x addr ) 5 bit FPU.FPCCR ; \ FPU.FPCCR.MMRDY, MMRDY
: FPU.FPCCR.BFRDY ( -- x addr ) 6 bit FPU.FPCCR ; \ FPU.FPCCR.BFRDY, BFRDY
: FPU.FPCCR.MONRDY ( -- x addr ) 8 bit FPU.FPCCR ; \ FPU.FPCCR.MONRDY, MONRDY
: FPU.FPCCR.LSPEN ( -- x addr ) 30 bit FPU.FPCCR ; \ FPU.FPCCR.LSPEN, LSPEN
: FPU.FPCCR.ASPEN ( -- x addr ) 31 bit FPU.FPCCR ; \ FPU.FPCCR.ASPEN, ASPEN

\ FPU.FPCAR (read-write) Reset:$00000000
: FPU.FPCAR.ADDRESS x addr ) 3 lshift FPU.FPCAR ; \ FPU.FPCAR.ADDRESS, Location of unpopulated               floating-point

\ FPU.FPSCR (read-write) Reset:$00000000
: FPU.FPSCR.IOC ( -- x addr ) 0 bit FPU.FPSCR ; \ FPU.FPSCR.IOC, Invalid operation cumulative exception               bit
: FPU.FPSCR.DZC ( -- x addr ) 1 bit FPU.FPSCR ; \ FPU.FPSCR.DZC, Division by zero cumulative exception               bit.
: FPU.FPSCR.OFC ( -- x addr ) 2 bit FPU.FPSCR ; \ FPU.FPSCR.OFC, Overflow cumulative exception               bit
: FPU.FPSCR.UFC ( -- x addr ) 3 bit FPU.FPSCR ; \ FPU.FPSCR.UFC, Underflow cumulative exception               bit
: FPU.FPSCR.IXC ( -- x addr ) 4 bit FPU.FPSCR ; \ FPU.FPSCR.IXC, Inexact cumulative exception               bit
: FPU.FPSCR.IDC ( -- x addr ) 7 bit FPU.FPSCR ; \ FPU.FPSCR.IDC, Input denormal cumulative exception               bit.
: FPU.FPSCR.RMode ( %bb -- x addr ) 22 lshift FPU.FPSCR ; \ FPU.FPSCR.RMode, Rounding Mode control               field
: FPU.FPSCR.FZ ( -- x addr ) 24 bit FPU.FPSCR ; \ FPU.FPSCR.FZ, Flush-to-zero mode control               bit:
: FPU.FPSCR.DN ( -- x addr ) 25 bit FPU.FPSCR ; \ FPU.FPSCR.DN, Default NaN mode control               bit
: FPU.FPSCR.AHP ( -- x addr ) 26 bit FPU.FPSCR ; \ FPU.FPSCR.AHP, Alternative half-precision control               bit
: FPU.FPSCR.V ( -- x addr ) 28 bit FPU.FPSCR ; \ FPU.FPSCR.V, Overflow condition code               flag
: FPU.FPSCR.C ( -- x addr ) 29 bit FPU.FPSCR ; \ FPU.FPSCR.C, Carry condition code flag
: FPU.FPSCR.Z ( -- x addr ) 30 bit FPU.FPSCR ; \ FPU.FPSCR.Z, Zero condition code flag
: FPU.FPSCR.N ( -- x addr ) 31 bit FPU.FPSCR ; \ FPU.FPSCR.N, Negative condition code               flag

\ SYSCFG_ITLINE.ITLINE0 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE0.WWDG? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE0 bit@ ; \ SYSCFG_ITLINE.ITLINE0.WWDG, Window watchdog interrupt pending               flag

\ SYSCFG_ITLINE.ITLINE1 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE1.PVDOUT? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE1 bit@ ; \ SYSCFG_ITLINE.ITLINE1.PVDOUT, PVD supply monitoring interrupt request               pending (EXTI line 16).

\ SYSCFG_ITLINE.ITLINE2 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE2.TAMP? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE2 bit@ ; \ SYSCFG_ITLINE.ITLINE2.TAMP, TAMP
: SYSCFG_ITLINE.ITLINE2.RTC? ( --  1|0 ) 1 bit SYSCFG_ITLINE.ITLINE2 bit@ ; \ SYSCFG_ITLINE.ITLINE2.RTC, RTC

\ SYSCFG_ITLINE.ITLINE3 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE3.FLASH_ITF? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE3 bit@ ; \ SYSCFG_ITLINE.ITLINE3.FLASH_ITF, FLASH_ITF
: SYSCFG_ITLINE.ITLINE3.FLASH_ECC? ( --  1|0 ) 1 bit SYSCFG_ITLINE.ITLINE3 bit@ ; \ SYSCFG_ITLINE.ITLINE3.FLASH_ECC, FLASH_ECC

\ SYSCFG_ITLINE.ITLINE4 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE4.RCC? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE4 bit@ ; \ SYSCFG_ITLINE.ITLINE4.RCC, RCC

\ SYSCFG_ITLINE.ITLINE5 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE5.EXTI0? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE5 bit@ ; \ SYSCFG_ITLINE.ITLINE5.EXTI0, EXTI0
: SYSCFG_ITLINE.ITLINE5.EXTI1? ( --  1|0 ) 1 bit SYSCFG_ITLINE.ITLINE5 bit@ ; \ SYSCFG_ITLINE.ITLINE5.EXTI1, EXTI1

\ SYSCFG_ITLINE.ITLINE6 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE6.EXTI2? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE6 bit@ ; \ SYSCFG_ITLINE.ITLINE6.EXTI2, EXTI2
: SYSCFG_ITLINE.ITLINE6.EXTI3? ( --  1|0 ) 1 bit SYSCFG_ITLINE.ITLINE6 bit@ ; \ SYSCFG_ITLINE.ITLINE6.EXTI3, EXTI3

\ SYSCFG_ITLINE.ITLINE7 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE7.EXTI4? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE7 bit@ ; \ SYSCFG_ITLINE.ITLINE7.EXTI4, EXTI4
: SYSCFG_ITLINE.ITLINE7.EXTI5? ( --  1|0 ) 1 bit SYSCFG_ITLINE.ITLINE7 bit@ ; \ SYSCFG_ITLINE.ITLINE7.EXTI5, EXTI5
: SYSCFG_ITLINE.ITLINE7.EXTI6? ( --  1|0 ) 2 bit SYSCFG_ITLINE.ITLINE7 bit@ ; \ SYSCFG_ITLINE.ITLINE7.EXTI6, EXTI6
: SYSCFG_ITLINE.ITLINE7.EXTI7? ( --  1|0 ) 3 bit SYSCFG_ITLINE.ITLINE7 bit@ ; \ SYSCFG_ITLINE.ITLINE7.EXTI7, EXTI7
: SYSCFG_ITLINE.ITLINE7.EXTI8? ( --  1|0 ) 4 bit SYSCFG_ITLINE.ITLINE7 bit@ ; \ SYSCFG_ITLINE.ITLINE7.EXTI8, EXTI8
: SYSCFG_ITLINE.ITLINE7.EXTI9? ( --  1|0 ) 5 bit SYSCFG_ITLINE.ITLINE7 bit@ ; \ SYSCFG_ITLINE.ITLINE7.EXTI9, EXTI9
: SYSCFG_ITLINE.ITLINE7.EXTI10? ( --  1|0 ) 6 bit SYSCFG_ITLINE.ITLINE7 bit@ ; \ SYSCFG_ITLINE.ITLINE7.EXTI10, EXTI10
: SYSCFG_ITLINE.ITLINE7.EXTI11? ( --  1|0 ) 7 bit SYSCFG_ITLINE.ITLINE7 bit@ ; \ SYSCFG_ITLINE.ITLINE7.EXTI11, EXTI11
: SYSCFG_ITLINE.ITLINE7.EXTI12? ( --  1|0 ) 8 bit SYSCFG_ITLINE.ITLINE7 bit@ ; \ SYSCFG_ITLINE.ITLINE7.EXTI12, EXTI12
: SYSCFG_ITLINE.ITLINE7.EXTI13? ( --  1|0 ) 9 bit SYSCFG_ITLINE.ITLINE7 bit@ ; \ SYSCFG_ITLINE.ITLINE7.EXTI13, EXTI13
: SYSCFG_ITLINE.ITLINE7.EXTI14? ( --  1|0 ) 10 bit SYSCFG_ITLINE.ITLINE7 bit@ ; \ SYSCFG_ITLINE.ITLINE7.EXTI14, EXTI14
: SYSCFG_ITLINE.ITLINE7.EXTI15? ( --  1|0 ) 11 bit SYSCFG_ITLINE.ITLINE7 bit@ ; \ SYSCFG_ITLINE.ITLINE7.EXTI15, EXTI15

\ SYSCFG_ITLINE.ITLINE9 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE9.DMA1_CH1? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE9 bit@ ; \ SYSCFG_ITLINE.ITLINE9.DMA1_CH1, DMA1_CH1

\ SYSCFG_ITLINE.ITLINE10 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE10.DMA1_CH2? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE10 bit@ ; \ SYSCFG_ITLINE.ITLINE10.DMA1_CH2, DMA1_CH1
: SYSCFG_ITLINE.ITLINE10.DMA1_CH3? ( --  1|0 ) 1 bit SYSCFG_ITLINE.ITLINE10 bit@ ; \ SYSCFG_ITLINE.ITLINE10.DMA1_CH3, DMA1_CH3

\ SYSCFG_ITLINE.ITLINE11 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE11.DMAMUX? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE11 bit@ ; \ SYSCFG_ITLINE.ITLINE11.DMAMUX, DMAMUX
: SYSCFG_ITLINE.ITLINE11.DMA1_CH4? ( --  1|0 ) 1 bit SYSCFG_ITLINE.ITLINE11 bit@ ; \ SYSCFG_ITLINE.ITLINE11.DMA1_CH4, DMA1_CH4
: SYSCFG_ITLINE.ITLINE11.DMA1_CH5? ( --  1|0 ) 2 bit SYSCFG_ITLINE.ITLINE11 bit@ ; \ SYSCFG_ITLINE.ITLINE11.DMA1_CH5, DMA1_CH5

\ SYSCFG_ITLINE.ITLINE12 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE12.ADC? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE12 bit@ ; \ SYSCFG_ITLINE.ITLINE12.ADC, ADC

\ SYSCFG_ITLINE.ITLINE13 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE13.TIM1_CCU? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE13 bit@ ; \ SYSCFG_ITLINE.ITLINE13.TIM1_CCU, TIM1_CCU
: SYSCFG_ITLINE.ITLINE13.TIM1_TRG? ( --  1|0 ) 1 bit SYSCFG_ITLINE.ITLINE13 bit@ ; \ SYSCFG_ITLINE.ITLINE13.TIM1_TRG, TIM1_TRG
: SYSCFG_ITLINE.ITLINE13.TIM1_UPD? ( --  1|0 ) 2 bit SYSCFG_ITLINE.ITLINE13 bit@ ; \ SYSCFG_ITLINE.ITLINE13.TIM1_UPD, TIM1_UPD
: SYSCFG_ITLINE.ITLINE13.TIM1_BRK? ( --  1|0 ) 3 bit SYSCFG_ITLINE.ITLINE13 bit@ ; \ SYSCFG_ITLINE.ITLINE13.TIM1_BRK, TIM1_BRK

\ SYSCFG_ITLINE.ITLINE14 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE14.TIM1_CC? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE14 bit@ ; \ SYSCFG_ITLINE.ITLINE14.TIM1_CC, TIM1_CC

\ SYSCFG_ITLINE.ITLINE15 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE15.TIM2? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE15 bit@ ; \ SYSCFG_ITLINE.ITLINE15.TIM2, TIM2

\ SYSCFG_ITLINE.ITLINE16 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE16.TIM3? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE16 bit@ ; \ SYSCFG_ITLINE.ITLINE16.TIM3, TIM3

\ SYSCFG_ITLINE.ITLINE19 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE19.TIM14? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE19 bit@ ; \ SYSCFG_ITLINE.ITLINE19.TIM14, TIM14

\ SYSCFG_ITLINE.ITLINE21 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE21.TIM16? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE21 bit@ ; \ SYSCFG_ITLINE.ITLINE21.TIM16, TIM16

\ SYSCFG_ITLINE.ITLINE22 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE22.TIM17? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE22 bit@ ; \ SYSCFG_ITLINE.ITLINE22.TIM17, TIM17

\ SYSCFG_ITLINE.ITLINE23 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE23.I2C1? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE23 bit@ ; \ SYSCFG_ITLINE.ITLINE23.I2C1, I2C1

\ SYSCFG_ITLINE.ITLINE24 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE24.I2C2? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE24 bit@ ; \ SYSCFG_ITLINE.ITLINE24.I2C2, I2C2

\ SYSCFG_ITLINE.ITLINE25 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE25.SPI1? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE25 bit@ ; \ SYSCFG_ITLINE.ITLINE25.SPI1, SPI1

\ SYSCFG_ITLINE.ITLINE26 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE26.SPI2? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE26 bit@ ; \ SYSCFG_ITLINE.ITLINE26.SPI2, SPI2

\ SYSCFG_ITLINE.ITLINE27 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE27.USART1? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE27 bit@ ; \ SYSCFG_ITLINE.ITLINE27.USART1, USART1

\ SYSCFG_ITLINE.ITLINE28 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE28.USART2? ( --  1|0 ) 0 bit SYSCFG_ITLINE.ITLINE28 bit@ ; \ SYSCFG_ITLINE.ITLINE28.USART2, USART2

\ SYSCFG_ITLINE.ITLINE29 (read-only) Reset:$00000000
: SYSCFG_ITLINE.ITLINE29.USART5? ( --  1|0 ) 2 bit SYSCFG_ITLINE.ITLINE29 bit@ ; \ SYSCFG_ITLINE.ITLINE29.USART5, USART5
