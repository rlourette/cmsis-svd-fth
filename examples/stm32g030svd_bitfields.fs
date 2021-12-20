\ STM32G030 Register Bitfield Definitions for Mecrisp-Stellaris Forth by Matthias Koch. 
\ bitfield.xsl takes STM32Fxx.svd, config.xml and produces bitfield.fs
\ Written by Terry Porter "terry@tjporter.com.au" 2016 - 2020 and released under the GPL V2.
\ Requires: bit ( u -- u ) 1 swap lshift 1-foldable ;	\ turn a bit position into a binary number.

\ IWDG_KR (write-only) Reset:$00000000
: IWDG_KR.KEY ( %bbbbbbbbbbbbbbbb -- x addr ) IWDG_KR ; \ IWDG_KR.KEY, Key value (write only, read               $0000)

\ IWDG_PR (read-write) Reset:$00000000
: IWDG_PR.PR ( %bbb -- x addr ) IWDG_PR ; \ IWDG_PR.PR, Prescaler divider

\ IWDG_RLR (read-write) Reset:$00000FFF
: IWDG_RLR.RL ( %bbbbbbbbbbb -- x addr ) IWDG_RLR ; \ IWDG_RLR.RL, Watchdog counter reload               value

\ IWDG_SR (read-only) Reset:$00000000
: IWDG_SR.WVU? ( --  1|0 ) 2 bit IWDG_SR bit@ ; \ IWDG_SR.WVU, Watchdog counter window value               update
: IWDG_SR.RVU? ( --  1|0 ) 1 bit IWDG_SR bit@ ; \ IWDG_SR.RVU, Watchdog counter reload value               update
: IWDG_SR.PVU? ( --  1|0 ) 0 bit IWDG_SR bit@ ; \ IWDG_SR.PVU, Watchdog prescaler value               update

\ IWDG_WINR (read-write) Reset:$00000FFF
: IWDG_WINR.WIN ( %bbbbbbbbbbb -- x addr ) IWDG_WINR ; \ IWDG_WINR.WIN, Watchdog counter window               value

\ WWDG_CR (read-write) Reset:$0000007F
: WWDG_CR.WDGA ( -- x addr ) 7 bit WWDG_CR ; \ WWDG_CR.WDGA, Activation bit
: WWDG_CR.T ( %bbbbbbb -- x addr ) WWDG_CR ; \ WWDG_CR.T, 7-bit counter (MSB to LSB)

\ WWDG_CFR (read-write) Reset:$0000007F
: WWDG_CFR.WDGTB ( %bbb -- x addr ) 11 lshift WWDG_CFR ; \ WWDG_CFR.WDGTB, Timer base
: WWDG_CFR.EWI ( -- x addr ) 9 bit WWDG_CFR ; \ WWDG_CFR.EWI, Early wakeup interrupt
: WWDG_CFR.W ( %bbbbbbb -- x addr ) WWDG_CFR ; \ WWDG_CFR.W, 7-bit window value

\ WWDG_SR (read-write) Reset:$00000000
: WWDG_SR.EWIF ( -- x addr ) 0 bit WWDG_SR ; \ WWDG_SR.EWIF, Early wakeup interrupt               flag

\ FLASH_ACR (read-write) Reset:$00000600
: FLASH_ACR.LATENCY ( %bbb -- x addr ) FLASH_ACR ; \ FLASH_ACR.LATENCY, Latency
: FLASH_ACR.PRFTEN ( -- x addr ) 8 bit FLASH_ACR ; \ FLASH_ACR.PRFTEN, Prefetch enable
: FLASH_ACR.ICEN ( -- x addr ) 9 bit FLASH_ACR ; \ FLASH_ACR.ICEN, Instruction cache enable
: FLASH_ACR.ICRST ( -- x addr ) 11 bit FLASH_ACR ; \ FLASH_ACR.ICRST, Instruction cache reset
: FLASH_ACR.EMPTY ( -- x addr ) 16 bit FLASH_ACR ; \ FLASH_ACR.EMPTY, Flash User area empty
: FLASH_ACR.DBG_SWEN ( -- x addr ) 18 bit FLASH_ACR ; \ FLASH_ACR.DBG_SWEN, Debug access software               enable

\ FLASH_KEYR (write-only) Reset:$00000000
: FLASH_KEYR.KEYR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) FLASH_KEYR ; \ FLASH_KEYR.KEYR, KEYR

\ FLASH_OPTKEYR (write-only) Reset:$00000000
: FLASH_OPTKEYR.OPTKEYR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) FLASH_OPTKEYR ; \ FLASH_OPTKEYR.OPTKEYR, Option byte key

\ FLASH_SR (read-write) Reset:$00000000
: FLASH_SR.EOP ( -- x addr ) 0 bit FLASH_SR ; \ FLASH_SR.EOP, End of operation
: FLASH_SR.OPERR ( -- x addr ) 1 bit FLASH_SR ; \ FLASH_SR.OPERR, Operation error
: FLASH_SR.PROGERR ( -- x addr ) 3 bit FLASH_SR ; \ FLASH_SR.PROGERR, Programming error
: FLASH_SR.WRPERR ( -- x addr ) 4 bit FLASH_SR ; \ FLASH_SR.WRPERR, Write protected error
: FLASH_SR.PGAERR ( -- x addr ) 5 bit FLASH_SR ; \ FLASH_SR.PGAERR, Programming alignment               error
: FLASH_SR.SIZERR ( -- x addr ) 6 bit FLASH_SR ; \ FLASH_SR.SIZERR, Size error
: FLASH_SR.PGSERR ( -- x addr ) 7 bit FLASH_SR ; \ FLASH_SR.PGSERR, Programming sequence error
: FLASH_SR.MISERR ( -- x addr ) 8 bit FLASH_SR ; \ FLASH_SR.MISERR, Fast programming data miss               error
: FLASH_SR.FASTERR ( -- x addr ) 9 bit FLASH_SR ; \ FLASH_SR.FASTERR, Fast programming error
: FLASH_SR.RDERR ( -- x addr ) 14 bit FLASH_SR ; \ FLASH_SR.RDERR, PCROP read error
: FLASH_SR.OPTVERR ( -- x addr ) 15 bit FLASH_SR ; \ FLASH_SR.OPTVERR, Option and Engineering bits loading               validity error
: FLASH_SR.BSY ( -- x addr ) 16 bit FLASH_SR ; \ FLASH_SR.BSY, Busy
: FLASH_SR.CFGBSY ( -- x addr ) 18 bit FLASH_SR ; \ FLASH_SR.CFGBSY, Programming or erase configuration               busy.

\ FLASH_CR (read-write) Reset:$C0000000
: FLASH_CR.PG ( -- x addr ) 0 bit FLASH_CR ; \ FLASH_CR.PG, Programming
: FLASH_CR.PER ( -- x addr ) 1 bit FLASH_CR ; \ FLASH_CR.PER, Page erase
: FLASH_CR.MER ( -- x addr ) 2 bit FLASH_CR ; \ FLASH_CR.MER, Mass erase
: FLASH_CR.PNB ( %bbbbbb -- x addr ) 3 lshift FLASH_CR ; \ FLASH_CR.PNB, Page number
: FLASH_CR.STRT ( -- x addr ) 16 bit FLASH_CR ; \ FLASH_CR.STRT, Start
: FLASH_CR.OPTSTRT ( -- x addr ) 17 bit FLASH_CR ; \ FLASH_CR.OPTSTRT, Options modification start
: FLASH_CR.FSTPG ( -- x addr ) 18 bit FLASH_CR ; \ FLASH_CR.FSTPG, Fast programming
: FLASH_CR.EOPIE ( -- x addr ) 24 bit FLASH_CR ; \ FLASH_CR.EOPIE, End of operation interrupt               enable
: FLASH_CR.ERRIE ( -- x addr ) 25 bit FLASH_CR ; \ FLASH_CR.ERRIE, Error interrupt enable
: FLASH_CR.RDERRIE ( -- x addr ) 26 bit FLASH_CR ; \ FLASH_CR.RDERRIE, PCROP read error interrupt               enable
: FLASH_CR.OBL_LAUNCH ( -- x addr ) 27 bit FLASH_CR ; \ FLASH_CR.OBL_LAUNCH, Force the option byte               loading
: FLASH_CR.SEC_PROT ( -- x addr ) 28 bit FLASH_CR ; \ FLASH_CR.SEC_PROT, Securable memory area protection               enable
: FLASH_CR.OPTLOCK ( -- x addr ) 30 bit FLASH_CR ; \ FLASH_CR.OPTLOCK, Options Lock
: FLASH_CR.LOCK ( -- x addr ) 31 bit FLASH_CR ; \ FLASH_CR.LOCK, FLASH_CR Lock

\ FLASH_ECCR (multiple-access)  Reset:$00000000
: FLASH_ECCR.ADDR_ECC ( %bbbbbbbbbbbbbb -- x addr ) FLASH_ECCR ; \ FLASH_ECCR.ADDR_ECC, ECC fail address
: FLASH_ECCR.SYSF_ECC ( -- x addr ) 20 bit FLASH_ECCR ; \ FLASH_ECCR.SYSF_ECC, ECC fail for Corrected ECC Error or               Double ECC Error in info block
: FLASH_ECCR.ECCIE ( -- x addr ) 24 bit FLASH_ECCR ; \ FLASH_ECCR.ECCIE, ECC correction interrupt               enable
: FLASH_ECCR.ECCC ( -- x addr ) 30 bit FLASH_ECCR ; \ FLASH_ECCR.ECCC, ECC correction
: FLASH_ECCR.ECCD ( -- x addr ) 31 bit FLASH_ECCR ; \ FLASH_ECCR.ECCD, ECC detection

\ FLASH_OPTR (read-write) Reset:$F0000000
: FLASH_OPTR.RDP ( %bbbbbbbb -- x addr ) FLASH_OPTR ; \ FLASH_OPTR.RDP, Read protection level
: FLASH_OPTR.BOREN ( -- x addr ) 8 bit FLASH_OPTR ; \ FLASH_OPTR.BOREN, BOR reset Level
: FLASH_OPTR.BORF_LEV ( %bb -- x addr ) 9 lshift FLASH_OPTR ; \ FLASH_OPTR.BORF_LEV, These bits contain the VDD supply level               threshold that activates the reset
: FLASH_OPTR.BORR_LEV ( %bb -- x addr ) 11 lshift FLASH_OPTR ; \ FLASH_OPTR.BORR_LEV, These bits contain the VDD supply level               threshold that releases the reset.
: FLASH_OPTR.nRST_STOP ( -- x addr ) 13 bit FLASH_OPTR ; \ FLASH_OPTR.nRST_STOP, nRST_STOP
: FLASH_OPTR.nRST_STDBY ( -- x addr ) 14 bit FLASH_OPTR ; \ FLASH_OPTR.nRST_STDBY, nRST_STDBY
: FLASH_OPTR.nRSTS_HDW ( -- x addr ) 15 bit FLASH_OPTR ; \ FLASH_OPTR.nRSTS_HDW, nRSTS_HDW
: FLASH_OPTR.IDWG_SW ( -- x addr ) 16 bit FLASH_OPTR ; \ FLASH_OPTR.IDWG_SW, Independent watchdog               selection
: FLASH_OPTR.IWDG_STOP ( -- x addr ) 17 bit FLASH_OPTR ; \ FLASH_OPTR.IWDG_STOP, Independent watchdog counter freeze in               Stop mode
: FLASH_OPTR.IWDG_STDBY ( -- x addr ) 18 bit FLASH_OPTR ; \ FLASH_OPTR.IWDG_STDBY, Independent watchdog counter freeze in               Standby mode
: FLASH_OPTR.WWDG_SW ( -- x addr ) 19 bit FLASH_OPTR ; \ FLASH_OPTR.WWDG_SW, Window watchdog selection
: FLASH_OPTR.RAM_PARITY_CHECK ( -- x addr ) 22 bit FLASH_OPTR ; \ FLASH_OPTR.RAM_PARITY_CHECK, SRAM parity check control
: FLASH_OPTR.nBOOT_SEL ( -- x addr ) 24 bit FLASH_OPTR ; \ FLASH_OPTR.nBOOT_SEL, nBOOT_SEL
: FLASH_OPTR.nBOOT1 ( -- x addr ) 25 bit FLASH_OPTR ; \ FLASH_OPTR.nBOOT1, Boot configuration
: FLASH_OPTR.nBOOT0 ( -- x addr ) 26 bit FLASH_OPTR ; \ FLASH_OPTR.nBOOT0, nBOOT0 option bit
: FLASH_OPTR.NRST_MODE ( %bb -- x addr ) 27 lshift FLASH_OPTR ; \ FLASH_OPTR.NRST_MODE, NRST_MODE
: FLASH_OPTR.IRHEN ( -- x addr ) 29 bit FLASH_OPTR ; \ FLASH_OPTR.IRHEN, Internal reset holder enable               bit

\ FLASH_PCROP1ASR (read-only) Reset:$F0000000
: FLASH_PCROP1ASR.PCROP1A_STRT? ( --  x ) FLASH_PCROP1ASR @ ; \ FLASH_PCROP1ASR.PCROP1A_STRT, PCROP1A area start offset

\ FLASH_PCROP1AER (read-only) Reset:$F0000000
: FLASH_PCROP1AER.PCROP1A_END? ( --  x ) FLASH_PCROP1AER @ ; \ FLASH_PCROP1AER.PCROP1A_END, PCROP1A area end offset
: FLASH_PCROP1AER.PCROP_RDP? ( --  1|0 ) 31 bit FLASH_PCROP1AER bit@ ; \ FLASH_PCROP1AER.PCROP_RDP, PCROP area preserved when RDP level               decreased

\ FLASH_WRP1AR (read-only) Reset:$F0000000
: FLASH_WRP1AR.WRP1A_STRT? ( --  x ) FLASH_WRP1AR @ ; \ FLASH_WRP1AR.WRP1A_STRT, WRP area A start offset
: FLASH_WRP1AR.WRP1A_END? ( --  x ) 16 lshift FLASH_WRP1AR @ ; \ FLASH_WRP1AR.WRP1A_END, WRP area A end offset

\ FLASH_WRP1BR (read-only) Reset:$F0000000
: FLASH_WRP1BR.WRP1B_STRT? ( --  x ) FLASH_WRP1BR @ ; \ FLASH_WRP1BR.WRP1B_STRT, WRP area B start offset
: FLASH_WRP1BR.WRP1B_END? ( --  x ) 16 lshift FLASH_WRP1BR @ ; \ FLASH_WRP1BR.WRP1B_END, WRP area B end offset

\ FLASH_PCROP1BSR (read-only) Reset:$F0000000
: FLASH_PCROP1BSR.PCROP1B_STRT? ( --  x ) FLASH_PCROP1BSR @ ; \ FLASH_PCROP1BSR.PCROP1B_STRT, PCROP1B area start offset

\ FLASH_PCROP1BER (read-only) Reset:$F0000000
: FLASH_PCROP1BER.PCROP1B_END? ( --  x ) FLASH_PCROP1BER @ ; \ FLASH_PCROP1BER.PCROP1B_END, PCROP1B area end offset

\ FLASH_SECR (read-only) Reset:$F0000000
: FLASH_SECR.SEC_SIZE? ( --  x ) FLASH_SECR @ ; \ FLASH_SECR.SEC_SIZE, Securable memory area size
: FLASH_SECR.BOOT_LOCK? ( --  1|0 ) 16 bit FLASH_SECR bit@ ; \ FLASH_SECR.BOOT_LOCK, used to force boot from user               area

\ RCC_CR (read-write) Reset:$00000063
: RCC_CR.HSION ( -- x addr ) 8 bit RCC_CR ; \ RCC_CR.HSION, HSI16 clock enable
: RCC_CR.HSIKERON ( -- x addr ) 9 bit RCC_CR ; \ RCC_CR.HSIKERON, HSI16 always enable for peripheral               kernels
: RCC_CR.HSIRDY ( -- x addr ) 10 bit RCC_CR ; \ RCC_CR.HSIRDY, HSI16 clock ready flag
: RCC_CR.HSIDIV ( %bbb -- x addr ) 11 lshift RCC_CR ; \ RCC_CR.HSIDIV, HSI16 clock division               factor
: RCC_CR.HSEON ( -- x addr ) 16 bit RCC_CR ; \ RCC_CR.HSEON, HSE clock enable
: RCC_CR.HSERDY ( -- x addr ) 17 bit RCC_CR ; \ RCC_CR.HSERDY, HSE clock ready flag
: RCC_CR.HSEBYP ( -- x addr ) 18 bit RCC_CR ; \ RCC_CR.HSEBYP, HSE crystal oscillator               bypass
: RCC_CR.CSSON ( -- x addr ) 19 bit RCC_CR ; \ RCC_CR.CSSON, Clock security system               enable
: RCC_CR.PLLON ( -- x addr ) 24 bit RCC_CR ; \ RCC_CR.PLLON, PLL enable
: RCC_CR.PLLRDY ( -- x addr ) 25 bit RCC_CR ; \ RCC_CR.PLLRDY, PLL clock ready flag

\ RCC_ICSCR (multiple-access)  Reset:$10000000
: RCC_ICSCR.HSICAL ( %bbbbbbbb -- x addr ) RCC_ICSCR ; \ RCC_ICSCR.HSICAL, HSI16 clock calibration
: RCC_ICSCR.HSITRIM ( %bbbbbbb -- x addr ) 8 lshift RCC_ICSCR ; \ RCC_ICSCR.HSITRIM, HSI16 clock trimming

\ RCC_CFGR (multiple-access)  Reset:$00000000
: RCC_CFGR.MCOPRE ( %bbb -- x addr ) 28 lshift RCC_CFGR ; \ RCC_CFGR.MCOPRE, Microcontroller clock output               prescaler
: RCC_CFGR.MCOSEL ( %bbb -- x addr ) 24 lshift RCC_CFGR ; \ RCC_CFGR.MCOSEL, Microcontroller clock               output
: RCC_CFGR.PPRE ( %bbb -- x addr ) 12 lshift RCC_CFGR ; \ RCC_CFGR.PPRE, APB prescaler
: RCC_CFGR.HPRE ( %bbbb -- x addr ) 8 lshift RCC_CFGR ; \ RCC_CFGR.HPRE, AHB prescaler
: RCC_CFGR.SWS? ( %bbb -- 1|0 ) 3 lshift RCC_CFGR bit@ ; \ RCC_CFGR.SWS, System clock switch status
: RCC_CFGR.SW ( %bbb -- x addr ) RCC_CFGR ; \ RCC_CFGR.SW, System clock switch

\ RCC_PLLSYSCFGR (read-write) Reset:$00001000
: RCC_PLLSYSCFGR.PLLSRC ( %bb -- x addr ) RCC_PLLSYSCFGR ; \ RCC_PLLSYSCFGR.PLLSRC, PLL input clock source
: RCC_PLLSYSCFGR.PLLM ( %bbb -- x addr ) 4 lshift RCC_PLLSYSCFGR ; \ RCC_PLLSYSCFGR.PLLM, Division factor M of the PLL input clock               divider
: RCC_PLLSYSCFGR.PLLN ( %bbbbbbb -- x addr ) 8 lshift RCC_PLLSYSCFGR ; \ RCC_PLLSYSCFGR.PLLN, PLL frequency multiplication factor               N
: RCC_PLLSYSCFGR.PLLPEN ( -- x addr ) 16 bit RCC_PLLSYSCFGR ; \ RCC_PLLSYSCFGR.PLLPEN, PLLPCLK clock output               enable
: RCC_PLLSYSCFGR.PLLP ( %bbbbb -- x addr ) 17 lshift RCC_PLLSYSCFGR ; \ RCC_PLLSYSCFGR.PLLP, PLL VCO division factor P for PLLPCLK               clock output
: RCC_PLLSYSCFGR.PLLQEN ( -- x addr ) 24 bit RCC_PLLSYSCFGR ; \ RCC_PLLSYSCFGR.PLLQEN, PLLQCLK clock output               enable
: RCC_PLLSYSCFGR.PLLQ ( %bbb -- x addr ) 25 lshift RCC_PLLSYSCFGR ; \ RCC_PLLSYSCFGR.PLLQ, PLL VCO division factor Q for PLLQCLK               clock output
: RCC_PLLSYSCFGR.PLLREN ( -- x addr ) 28 bit RCC_PLLSYSCFGR ; \ RCC_PLLSYSCFGR.PLLREN, PLLRCLK clock output               enable
: RCC_PLLSYSCFGR.PLLR ( %bbb -- x addr ) 29 lshift RCC_PLLSYSCFGR ; \ RCC_PLLSYSCFGR.PLLR, PLL VCO division factor R for PLLRCLK               clock output

\ RCC_CIER (read-write) Reset:$00000000
: RCC_CIER.LSIRDYIE ( -- x addr ) 0 bit RCC_CIER ; \ RCC_CIER.LSIRDYIE, LSI ready interrupt enable
: RCC_CIER.LSERDYIE ( -- x addr ) 1 bit RCC_CIER ; \ RCC_CIER.LSERDYIE, LSE ready interrupt enable
: RCC_CIER.HSIRDYIE ( -- x addr ) 3 bit RCC_CIER ; \ RCC_CIER.HSIRDYIE, HSI ready interrupt enable
: RCC_CIER.HSERDYIE ( -- x addr ) 4 bit RCC_CIER ; \ RCC_CIER.HSERDYIE, HSE ready interrupt enable
: RCC_CIER.PLLSYSRDYIE ( -- x addr ) 5 bit RCC_CIER ; \ RCC_CIER.PLLSYSRDYIE, PLL ready interrupt enable

\ RCC_CIFR (read-only) Reset:$00000000
: RCC_CIFR.LSIRDYF? ( --  1|0 ) 0 bit RCC_CIFR bit@ ; \ RCC_CIFR.LSIRDYF, LSI ready interrupt flag
: RCC_CIFR.LSERDYF? ( --  1|0 ) 1 bit RCC_CIFR bit@ ; \ RCC_CIFR.LSERDYF, LSE ready interrupt flag
: RCC_CIFR.HSIRDYF? ( --  1|0 ) 3 bit RCC_CIFR bit@ ; \ RCC_CIFR.HSIRDYF, HSI ready interrupt flag
: RCC_CIFR.HSERDYF? ( --  1|0 ) 4 bit RCC_CIFR bit@ ; \ RCC_CIFR.HSERDYF, HSE ready interrupt flag
: RCC_CIFR.PLLSYSRDYF? ( --  1|0 ) 5 bit RCC_CIFR bit@ ; \ RCC_CIFR.PLLSYSRDYF, PLL ready interrupt flag
: RCC_CIFR.CSSF? ( --  1|0 ) 8 bit RCC_CIFR bit@ ; \ RCC_CIFR.CSSF, Clock security system interrupt               flag
: RCC_CIFR.LSECSSF? ( --  1|0 ) 9 bit RCC_CIFR bit@ ; \ RCC_CIFR.LSECSSF, LSE Clock security system interrupt               flag

\ RCC_CICR (write-only) Reset:$00000000
: RCC_CICR.LSIRDYC ( -- x addr ) 0 bit RCC_CICR ; \ RCC_CICR.LSIRDYC, LSI ready interrupt clear
: RCC_CICR.LSERDYC ( -- x addr ) 1 bit RCC_CICR ; \ RCC_CICR.LSERDYC, LSE ready interrupt clear
: RCC_CICR.HSIRDYC ( -- x addr ) 3 bit RCC_CICR ; \ RCC_CICR.HSIRDYC, HSI ready interrupt clear
: RCC_CICR.HSERDYC ( -- x addr ) 4 bit RCC_CICR ; \ RCC_CICR.HSERDYC, HSE ready interrupt clear
: RCC_CICR.PLLSYSRDYC ( -- x addr ) 5 bit RCC_CICR ; \ RCC_CICR.PLLSYSRDYC, PLL ready interrupt clear
: RCC_CICR.CSSC ( -- x addr ) 8 bit RCC_CICR ; \ RCC_CICR.CSSC, Clock security system interrupt               clear
: RCC_CICR.LSECSSC ( -- x addr ) 9 bit RCC_CICR ; \ RCC_CICR.LSECSSC, LSE Clock security system interrupt               clear

\ RCC_AHBRSTR (read-write) Reset:$00000000
: RCC_AHBRSTR.DMARST ( -- x addr ) 0 bit RCC_AHBRSTR ; \ RCC_AHBRSTR.DMARST, DMA1 reset
: RCC_AHBRSTR.FLASHRST ( -- x addr ) 8 bit RCC_AHBRSTR ; \ RCC_AHBRSTR.FLASHRST, FLITF reset
: RCC_AHBRSTR.CRCRST ( -- x addr ) 12 bit RCC_AHBRSTR ; \ RCC_AHBRSTR.CRCRST, CRC reset

\ RCC_IOPRSTR (read-write) Reset:$00000000
: RCC_IOPRSTR.IOPARST ( -- x addr ) 0 bit RCC_IOPRSTR ; \ RCC_IOPRSTR.IOPARST, I/O port A reset
: RCC_IOPRSTR.IOPBRST ( -- x addr ) 1 bit RCC_IOPRSTR ; \ RCC_IOPRSTR.IOPBRST, I/O port B reset
: RCC_IOPRSTR.IOPCRST ( -- x addr ) 2 bit RCC_IOPRSTR ; \ RCC_IOPRSTR.IOPCRST, I/O port C reset
: RCC_IOPRSTR.IOPDRST ( -- x addr ) 3 bit RCC_IOPRSTR ; \ RCC_IOPRSTR.IOPDRST, I/O port D reset
: RCC_IOPRSTR.IOPFRST ( -- x addr ) 5 bit RCC_IOPRSTR ; \ RCC_IOPRSTR.IOPFRST, I/O port F reset

\ RCC_APBRSTR1 (read-write) Reset:$00000000
: RCC_APBRSTR1.TIM2RST ( -- x addr ) 0 bit RCC_APBRSTR1 ; \ RCC_APBRSTR1.TIM2RST, TIM2 timer reset
: RCC_APBRSTR1.TIM3RST ( -- x addr ) 1 bit RCC_APBRSTR1 ; \ RCC_APBRSTR1.TIM3RST, TIM3 timer reset
: RCC_APBRSTR1.SPI2RST ( -- x addr ) 14 bit RCC_APBRSTR1 ; \ RCC_APBRSTR1.SPI2RST, SPI2 reset
: RCC_APBRSTR1.USART2RST ( -- x addr ) 17 bit RCC_APBRSTR1 ; \ RCC_APBRSTR1.USART2RST, USART2 reset
: RCC_APBRSTR1.I2C1RST ( -- x addr ) 21 bit RCC_APBRSTR1 ; \ RCC_APBRSTR1.I2C1RST, I2C1 reset
: RCC_APBRSTR1.I2C2RST ( -- x addr ) 22 bit RCC_APBRSTR1 ; \ RCC_APBRSTR1.I2C2RST, I2C2 reset
: RCC_APBRSTR1.DBGRST ( -- x addr ) 27 bit RCC_APBRSTR1 ; \ RCC_APBRSTR1.DBGRST, Debug support reset
: RCC_APBRSTR1.PWRRST ( -- x addr ) 28 bit RCC_APBRSTR1 ; \ RCC_APBRSTR1.PWRRST, Power interface reset

\ RCC_APBRSTR2 (read-write) Reset:$00000000
: RCC_APBRSTR2.SYSCFGRST ( -- x addr ) 0 bit RCC_APBRSTR2 ; \ RCC_APBRSTR2.SYSCFGRST, SYSCFG, COMP and VREFBUF               reset
: RCC_APBRSTR2.TIM1RST ( -- x addr ) 11 bit RCC_APBRSTR2 ; \ RCC_APBRSTR2.TIM1RST, TIM1 timer reset
: RCC_APBRSTR2.SPI1RST ( -- x addr ) 12 bit RCC_APBRSTR2 ; \ RCC_APBRSTR2.SPI1RST, SPI1 reset
: RCC_APBRSTR2.USART1RST ( -- x addr ) 14 bit RCC_APBRSTR2 ; \ RCC_APBRSTR2.USART1RST, USART1 reset
: RCC_APBRSTR2.TIM14RST ( -- x addr ) 15 bit RCC_APBRSTR2 ; \ RCC_APBRSTR2.TIM14RST, TIM14 timer reset
: RCC_APBRSTR2.TIM16RST ( -- x addr ) 17 bit RCC_APBRSTR2 ; \ RCC_APBRSTR2.TIM16RST, TIM16 timer reset
: RCC_APBRSTR2.TIM17RST ( -- x addr ) 18 bit RCC_APBRSTR2 ; \ RCC_APBRSTR2.TIM17RST, TIM17 timer reset
: RCC_APBRSTR2.ADCRST ( -- x addr ) 20 bit RCC_APBRSTR2 ; \ RCC_APBRSTR2.ADCRST, ADC reset

\ RCC_IOPENR (read-write) Reset:$00000000
: RCC_IOPENR.IOPAEN ( -- x addr ) 0 bit RCC_IOPENR ; \ RCC_IOPENR.IOPAEN, I/O port A clock enable
: RCC_IOPENR.IOPBEN ( -- x addr ) 1 bit RCC_IOPENR ; \ RCC_IOPENR.IOPBEN, I/O port B clock enable
: RCC_IOPENR.IOPCEN ( -- x addr ) 2 bit RCC_IOPENR ; \ RCC_IOPENR.IOPCEN, I/O port C clock enable
: RCC_IOPENR.IOPDEN ( -- x addr ) 3 bit RCC_IOPENR ; \ RCC_IOPENR.IOPDEN, I/O port D clock enable
: RCC_IOPENR.IOPFEN ( -- x addr ) 5 bit RCC_IOPENR ; \ RCC_IOPENR.IOPFEN, I/O port F clock enable

\ RCC_AHBENR (read-write) Reset:$00000000
: RCC_AHBENR.DMAEN ( -- x addr ) 0 bit RCC_AHBENR ; \ RCC_AHBENR.DMAEN, DMA clock enable
: RCC_AHBENR.FLASHEN ( -- x addr ) 8 bit RCC_AHBENR ; \ RCC_AHBENR.FLASHEN, Flash memory interface clock               enable
: RCC_AHBENR.CRCEN ( -- x addr ) 12 bit RCC_AHBENR ; \ RCC_AHBENR.CRCEN, CRC clock enable

\ RCC_APBENR1 (read-write) Reset:$00000000
: RCC_APBENR1.TIM2EN ( -- x addr ) 0 bit RCC_APBENR1 ; \ RCC_APBENR1.TIM2EN, TIM2 timer clock enable
: RCC_APBENR1.TIM3EN ( -- x addr ) 1 bit RCC_APBENR1 ; \ RCC_APBENR1.TIM3EN, TIM3 timer clock enable
: RCC_APBENR1.RTCAPBEN ( -- x addr ) 10 bit RCC_APBENR1 ; \ RCC_APBENR1.RTCAPBEN, RTC APB clock enable
: RCC_APBENR1.WWDGEN ( -- x addr ) 11 bit RCC_APBENR1 ; \ RCC_APBENR1.WWDGEN, WWDG clock enable
: RCC_APBENR1.SPI2EN ( -- x addr ) 14 bit RCC_APBENR1 ; \ RCC_APBENR1.SPI2EN, SPI2 clock enable
: RCC_APBENR1.USART2EN ( -- x addr ) 17 bit RCC_APBENR1 ; \ RCC_APBENR1.USART2EN, USART2 clock enable
: RCC_APBENR1.I2C1EN ( -- x addr ) 21 bit RCC_APBENR1 ; \ RCC_APBENR1.I2C1EN, I2C1 clock enable
: RCC_APBENR1.I2C2EN ( -- x addr ) 22 bit RCC_APBENR1 ; \ RCC_APBENR1.I2C2EN, I2C2 clock enable
: RCC_APBENR1.DBGEN ( -- x addr ) 27 bit RCC_APBENR1 ; \ RCC_APBENR1.DBGEN, Debug support clock enable
: RCC_APBENR1.PWREN ( -- x addr ) 28 bit RCC_APBENR1 ; \ RCC_APBENR1.PWREN, Power interface clock               enable

\ RCC_APBENR2 (read-write) Reset:$00000000
: RCC_APBENR2.SYSCFGEN ( -- x addr ) 0 bit RCC_APBENR2 ; \ RCC_APBENR2.SYSCFGEN, SYSCFG, COMP and VREFBUF clock               enable
: RCC_APBENR2.TIM1EN ( -- x addr ) 11 bit RCC_APBENR2 ; \ RCC_APBENR2.TIM1EN, TIM1 timer clock enable
: RCC_APBENR2.SPI1EN ( -- x addr ) 12 bit RCC_APBENR2 ; \ RCC_APBENR2.SPI1EN, SPI1 clock enable
: RCC_APBENR2.USART1EN ( -- x addr ) 14 bit RCC_APBENR2 ; \ RCC_APBENR2.USART1EN, USART1 clock enable
: RCC_APBENR2.TIM14EN ( -- x addr ) 15 bit RCC_APBENR2 ; \ RCC_APBENR2.TIM14EN, TIM14 timer clock enable
: RCC_APBENR2.TIM16EN ( -- x addr ) 17 bit RCC_APBENR2 ; \ RCC_APBENR2.TIM16EN, TIM16 timer clock enable
: RCC_APBENR2.TIM17EN ( -- x addr ) 18 bit RCC_APBENR2 ; \ RCC_APBENR2.TIM17EN, TIM16 timer clock enable
: RCC_APBENR2.ADCEN ( -- x addr ) 20 bit RCC_APBENR2 ; \ RCC_APBENR2.ADCEN, ADC clock enable

\ RCC_IOPSMENR (read-write) Reset:$00000000
: RCC_IOPSMENR.IOPASMEN ( -- x addr ) 0 bit RCC_IOPSMENR ; \ RCC_IOPSMENR.IOPASMEN, I/O port A clock enable during Sleep               mode
: RCC_IOPSMENR.IOPBSMEN ( -- x addr ) 1 bit RCC_IOPSMENR ; \ RCC_IOPSMENR.IOPBSMEN, I/O port B clock enable during Sleep               mode
: RCC_IOPSMENR.IOPCSMEN ( -- x addr ) 2 bit RCC_IOPSMENR ; \ RCC_IOPSMENR.IOPCSMEN, I/O port C clock enable during Sleep               mode
: RCC_IOPSMENR.IOPDSMEN ( -- x addr ) 3 bit RCC_IOPSMENR ; \ RCC_IOPSMENR.IOPDSMEN, I/O port D clock enable during Sleep               mode
: RCC_IOPSMENR.IOPFSMEN ( -- x addr ) 5 bit RCC_IOPSMENR ; \ RCC_IOPSMENR.IOPFSMEN, I/O port F clock enable during Sleep               mode

\ RCC_AHBSMENR (read-write) Reset:$00000000
: RCC_AHBSMENR.DMASMEN ( -- x addr ) 0 bit RCC_AHBSMENR ; \ RCC_AHBSMENR.DMASMEN, DMA clock enable during Sleep               mode
: RCC_AHBSMENR.FLASHSMEN ( -- x addr ) 8 bit RCC_AHBSMENR ; \ RCC_AHBSMENR.FLASHSMEN, Flash memory interface clock enable               during Sleep mode
: RCC_AHBSMENR.SRAMSMEN ( -- x addr ) 9 bit RCC_AHBSMENR ; \ RCC_AHBSMENR.SRAMSMEN, SRAM clock enable during Sleep               mode
: RCC_AHBSMENR.CRCSMEN ( -- x addr ) 12 bit RCC_AHBSMENR ; \ RCC_AHBSMENR.CRCSMEN, CRC clock enable during Sleep               mode

\ RCC_APBSMENR1 (read-write) Reset:$00000000
: RCC_APBSMENR1.TIM2SMEN ( -- x addr ) 0 bit RCC_APBSMENR1 ; \ RCC_APBSMENR1.TIM2SMEN, TIM2 timer clock enable during Sleep               mode
: RCC_APBSMENR1.TIM3SMEN ( -- x addr ) 1 bit RCC_APBSMENR1 ; \ RCC_APBSMENR1.TIM3SMEN, TIM3 timer clock enable during Sleep               mode
: RCC_APBSMENR1.RTCAPBSMEN ( -- x addr ) 10 bit RCC_APBSMENR1 ; \ RCC_APBSMENR1.RTCAPBSMEN, RTC APB clock enable during Sleep               mode
: RCC_APBSMENR1.WWDGSMEN ( -- x addr ) 11 bit RCC_APBSMENR1 ; \ RCC_APBSMENR1.WWDGSMEN, WWDG clock enable during Sleep               mode
: RCC_APBSMENR1.SPI2SMEN ( -- x addr ) 14 bit RCC_APBSMENR1 ; \ RCC_APBSMENR1.SPI2SMEN, SPI2 clock enable during Sleep               mode
: RCC_APBSMENR1.USART2SMEN ( -- x addr ) 17 bit RCC_APBSMENR1 ; \ RCC_APBSMENR1.USART2SMEN, USART2 clock enable during Sleep               mode
: RCC_APBSMENR1.I2C1SMEN ( -- x addr ) 21 bit RCC_APBSMENR1 ; \ RCC_APBSMENR1.I2C1SMEN, I2C1 clock enable during Sleep               mode
: RCC_APBSMENR1.I2C2SMEN ( -- x addr ) 22 bit RCC_APBSMENR1 ; \ RCC_APBSMENR1.I2C2SMEN, I2C2 clock enable during Sleep               mode
: RCC_APBSMENR1.DBGSMEN ( -- x addr ) 27 bit RCC_APBSMENR1 ; \ RCC_APBSMENR1.DBGSMEN, Debug support clock enable during Sleep               mode
: RCC_APBSMENR1.PWRSMEN ( -- x addr ) 28 bit RCC_APBSMENR1 ; \ RCC_APBSMENR1.PWRSMEN, Power interface clock enable during               Sleep mode

\ RCC_APBSMENR2 (read-write) Reset:$00000000
: RCC_APBSMENR2.SYSCFGSMEN ( -- x addr ) 0 bit RCC_APBSMENR2 ; \ RCC_APBSMENR2.SYSCFGSMEN, SYSCFG, COMP and VREFBUF clock enable               during Sleep mode
: RCC_APBSMENR2.TIM1SMEN ( -- x addr ) 11 bit RCC_APBSMENR2 ; \ RCC_APBSMENR2.TIM1SMEN, TIM1 timer clock enable during Sleep               mode
: RCC_APBSMENR2.SPI1SMEN ( -- x addr ) 12 bit RCC_APBSMENR2 ; \ RCC_APBSMENR2.SPI1SMEN, SPI1 clock enable during Sleep               mode
: RCC_APBSMENR2.USART1SMEN ( -- x addr ) 14 bit RCC_APBSMENR2 ; \ RCC_APBSMENR2.USART1SMEN, USART1 clock enable during Sleep               mode
: RCC_APBSMENR2.TIM14SMEN ( -- x addr ) 15 bit RCC_APBSMENR2 ; \ RCC_APBSMENR2.TIM14SMEN, TIM14 timer clock enable during Sleep               mode
: RCC_APBSMENR2.TIM16SMEN ( -- x addr ) 17 bit RCC_APBSMENR2 ; \ RCC_APBSMENR2.TIM16SMEN, TIM16 timer clock enable during Sleep               mode
: RCC_APBSMENR2.TIM17SMEN ( -- x addr ) 18 bit RCC_APBSMENR2 ; \ RCC_APBSMENR2.TIM17SMEN, TIM16 timer clock enable during Sleep               mode
: RCC_APBSMENR2.ADCSMEN ( -- x addr ) 20 bit RCC_APBSMENR2 ; \ RCC_APBSMENR2.ADCSMEN, ADC clock enable during Sleep               mode

\ RCC_CCIPR (read-write) Reset:$00000000
: RCC_CCIPR.USART1SEL ( %bb -- x addr ) RCC_CCIPR ; \ RCC_CCIPR.USART1SEL, USART1 clock source               selection
: RCC_CCIPR.I2C1SEL ( %bb -- x addr ) 12 lshift RCC_CCIPR ; \ RCC_CCIPR.I2C1SEL, I2C1 clock source               selection
: RCC_CCIPR.I2S2SEL ( %bb -- x addr ) 14 lshift RCC_CCIPR ; \ RCC_CCIPR.I2S2SEL, I2S1 clock source               selection
: RCC_CCIPR.TIM1SEL ( -- x addr ) 22 bit RCC_CCIPR ; \ RCC_CCIPR.TIM1SEL, TIM1 clock source               selection
: RCC_CCIPR.RNGSEL ( %bb -- x addr ) 26 lshift RCC_CCIPR ; \ RCC_CCIPR.RNGSEL, RNG clock source selection
: RCC_CCIPR.RNGDIV ( %bb -- x addr ) 28 lshift RCC_CCIPR ; \ RCC_CCIPR.RNGDIV, Division factor of RNG clock               divider
: RCC_CCIPR.ADCSEL ( %bb -- x addr ) 30 lshift RCC_CCIPR ; \ RCC_CCIPR.ADCSEL, ADCs clock source               selection

\ RCC_BDCR (read-write) Reset:$00000000
: RCC_BDCR.LSEON ( -- x addr ) 0 bit RCC_BDCR ; \ RCC_BDCR.LSEON, LSE oscillator enable
: RCC_BDCR.LSERDY ( -- x addr ) 1 bit RCC_BDCR ; \ RCC_BDCR.LSERDY, LSE oscillator ready
: RCC_BDCR.LSEBYP ( -- x addr ) 2 bit RCC_BDCR ; \ RCC_BDCR.LSEBYP, LSE oscillator bypass
: RCC_BDCR.LSEDRV ( %bb -- x addr ) 3 lshift RCC_BDCR ; \ RCC_BDCR.LSEDRV, LSE oscillator drive               capability
: RCC_BDCR.LSECSSON ( -- x addr ) 5 bit RCC_BDCR ; \ RCC_BDCR.LSECSSON, CSS on LSE enable
: RCC_BDCR.LSECSSD ( -- x addr ) 6 bit RCC_BDCR ; \ RCC_BDCR.LSECSSD, CSS on LSE failure               Detection
: RCC_BDCR.RTCSEL ( %bb -- x addr ) 8 lshift RCC_BDCR ; \ RCC_BDCR.RTCSEL, RTC clock source selection
: RCC_BDCR.RTCEN ( -- x addr ) 15 bit RCC_BDCR ; \ RCC_BDCR.RTCEN, RTC clock enable
: RCC_BDCR.BDRST ( -- x addr ) 16 bit RCC_BDCR ; \ RCC_BDCR.BDRST, RTC domain software reset
: RCC_BDCR.LSCOEN ( -- x addr ) 24 bit RCC_BDCR ; \ RCC_BDCR.LSCOEN, Low-speed clock output (LSCO)               enable
: RCC_BDCR.LSCOSEL ( -- x addr ) 25 bit RCC_BDCR ; \ RCC_BDCR.LSCOSEL, Low-speed clock output               selection

\ RCC_CSR (read-write) Reset:$00000000
: RCC_CSR.LSION ( -- x addr ) 0 bit RCC_CSR ; \ RCC_CSR.LSION, LSI oscillator enable
: RCC_CSR.LSIRDY ( -- x addr ) 1 bit RCC_CSR ; \ RCC_CSR.LSIRDY, LSI oscillator ready
: RCC_CSR.RMVF ( -- x addr ) 23 bit RCC_CSR ; \ RCC_CSR.RMVF, Remove reset flags
: RCC_CSR.OBLRSTF ( -- x addr ) 25 bit RCC_CSR ; \ RCC_CSR.OBLRSTF, Option byte loader reset               flag
: RCC_CSR.PINRSTF ( -- x addr ) 26 bit RCC_CSR ; \ RCC_CSR.PINRSTF, Pin reset flag
: RCC_CSR.PWRRSTF ( -- x addr ) 27 bit RCC_CSR ; \ RCC_CSR.PWRRSTF, BOR or POR/PDR flag
: RCC_CSR.SFTRSTF ( -- x addr ) 28 bit RCC_CSR ; \ RCC_CSR.SFTRSTF, Software reset flag
: RCC_CSR.IWDGRSTF ( -- x addr ) 29 bit RCC_CSR ; \ RCC_CSR.IWDGRSTF, Independent window watchdog reset               flag
: RCC_CSR.WWDGRSTF ( -- x addr ) 30 bit RCC_CSR ; \ RCC_CSR.WWDGRSTF, Window watchdog reset flag
: RCC_CSR.LPWRRSTF ( -- x addr ) 31 bit RCC_CSR ; \ RCC_CSR.LPWRRSTF, Low-power reset flag

\ PWR_CR1 (read-write) Reset:$00000200
: PWR_CR1.LPR ( -- x addr ) 14 bit PWR_CR1 ; \ PWR_CR1.LPR, Low-power run
: PWR_CR1.VOS ( %bb -- x addr ) 9 lshift PWR_CR1 ; \ PWR_CR1.VOS, Voltage scaling range               selection
: PWR_CR1.DBP ( -- x addr ) 8 bit PWR_CR1 ; \ PWR_CR1.DBP, Disable backup domain write               protection
: PWR_CR1.FPD_LPSLP ( -- x addr ) 5 bit PWR_CR1 ; \ PWR_CR1.FPD_LPSLP, Flash memory powered down during               Low-power sleep mode
: PWR_CR1.FPD_LPRUN ( -- x addr ) 4 bit PWR_CR1 ; \ PWR_CR1.FPD_LPRUN, Flash memory powered down during               Low-power run mode
: PWR_CR1.FPD_STOP ( -- x addr ) 3 bit PWR_CR1 ; \ PWR_CR1.FPD_STOP, Flash memory powered down during Stop               mode
: PWR_CR1.LPMS ( %bbb -- x addr ) PWR_CR1 ; \ PWR_CR1.LPMS, Low-power mode selection

\ PWR_CR2 (read-write) Reset:$00000000
: PWR_CR2.PVDE ( -- x addr ) 0 bit PWR_CR2 ; \ PWR_CR2.PVDE, Power voltage detector               enable
: PWR_CR2.PVDFT ( %bbb -- x addr ) 1 lshift PWR_CR2 ; \ PWR_CR2.PVDFT, Power voltage detector falling threshold               selection
: PWR_CR2.PVDRT ( %bbb -- x addr ) 4 lshift PWR_CR2 ; \ PWR_CR2.PVDRT, Power voltage detector rising threshold               selection

\ PWR_CR3 (read-write) Reset:0X00008000
: PWR_CR3.EWUP1 ( -- x addr ) 0 bit PWR_CR3 ; \ PWR_CR3.EWUP1, Enable Wakeup pin WKUP1
: PWR_CR3.EWUP2 ( -- x addr ) 1 bit PWR_CR3 ; \ PWR_CR3.EWUP2, Enable Wakeup pin WKUP2
: PWR_CR3.EWUP4 ( -- x addr ) 3 bit PWR_CR3 ; \ PWR_CR3.EWUP4, Enable Wakeup pin WKUP4
: PWR_CR3.EWUP5 ( -- x addr ) 4 bit PWR_CR3 ; \ PWR_CR3.EWUP5, Enable WKUP5 wakeup pin
: PWR_CR3.EWUP6 ( -- x addr ) 5 bit PWR_CR3 ; \ PWR_CR3.EWUP6, Enable WKUP6 wakeup pin
: PWR_CR3.RRS ( -- x addr ) 8 bit PWR_CR3 ; \ PWR_CR3.RRS, SRAM retention in Standby               mode
: PWR_CR3.ULPEN ( -- x addr ) 9 bit PWR_CR3 ; \ PWR_CR3.ULPEN, Enable the periodical sampling mode for               PDR detection
: PWR_CR3.APC ( -- x addr ) 10 bit PWR_CR3 ; \ PWR_CR3.APC, Apply pull-up and pull-down               configuration
: PWR_CR3.EIWUL ( -- x addr ) 15 bit PWR_CR3 ; \ PWR_CR3.EIWUL, Enable internal wakeup               line

\ PWR_CR4 (read-write) Reset:$00000000
: PWR_CR4.WP1 ( -- x addr ) 0 bit PWR_CR4 ; \ PWR_CR4.WP1, Wakeup pin WKUP1 polarity
: PWR_CR4.WP2 ( -- x addr ) 1 bit PWR_CR4 ; \ PWR_CR4.WP2, Wakeup pin WKUP2 polarity
: PWR_CR4.WP4 ( -- x addr ) 3 bit PWR_CR4 ; \ PWR_CR4.WP4, Wakeup pin WKUP4 polarity
: PWR_CR4.WP5 ( -- x addr ) 4 bit PWR_CR4 ; \ PWR_CR4.WP5, Wakeup pin WKUP5 polarity
: PWR_CR4.WP6 ( -- x addr ) 5 bit PWR_CR4 ; \ PWR_CR4.WP6, WKUP6 wakeup pin polarity
: PWR_CR4.VBE ( -- x addr ) 8 bit PWR_CR4 ; \ PWR_CR4.VBE, VBAT battery charging               enable
: PWR_CR4.VBRS ( -- x addr ) 9 bit PWR_CR4 ; \ PWR_CR4.VBRS, VBAT battery charging resistor               selection

\ PWR_SR1 (read-only) Reset:$00000000
: PWR_SR1.WUF1? ( --  1|0 ) 0 bit PWR_SR1 bit@ ; \ PWR_SR1.WUF1, Wakeup flag 1
: PWR_SR1.WUF2? ( --  1|0 ) 1 bit PWR_SR1 bit@ ; \ PWR_SR1.WUF2, Wakeup flag 2
: PWR_SR1.WUF4? ( --  1|0 ) 3 bit PWR_SR1 bit@ ; \ PWR_SR1.WUF4, Wakeup flag 4
: PWR_SR1.WUF5? ( --  1|0 ) 4 bit PWR_SR1 bit@ ; \ PWR_SR1.WUF5, Wakeup flag 5
: PWR_SR1.WUF6? ( --  1|0 ) 5 bit PWR_SR1 bit@ ; \ PWR_SR1.WUF6, Wakeup flag 6
: PWR_SR1.SBF? ( --  1|0 ) 8 bit PWR_SR1 bit@ ; \ PWR_SR1.SBF, Standby flag
: PWR_SR1.WUFI? ( --  1|0 ) 15 bit PWR_SR1 bit@ ; \ PWR_SR1.WUFI, Wakeup flag internal

\ PWR_SR2 (read-only) Reset:$00000000
: PWR_SR2.PVDO? ( --  1|0 ) 11 bit PWR_SR2 bit@ ; \ PWR_SR2.PVDO, Power voltage detector               output
: PWR_SR2.VOSF? ( --  1|0 ) 10 bit PWR_SR2 bit@ ; \ PWR_SR2.VOSF, Voltage scaling flag
: PWR_SR2.REGLPF? ( --  1|0 ) 9 bit PWR_SR2 bit@ ; \ PWR_SR2.REGLPF, Low-power regulator flag
: PWR_SR2.REGLPS? ( --  1|0 ) 8 bit PWR_SR2 bit@ ; \ PWR_SR2.REGLPS, Low-power regulator               started
: PWR_SR2.FLASH_RDY? ( --  1|0 ) 7 bit PWR_SR2 bit@ ; \ PWR_SR2.FLASH_RDY, Flash ready flag

\ PWR_SCR (write-only) Reset:$00000000
: PWR_SCR.CSBF ( -- x addr ) 8 bit PWR_SCR ; \ PWR_SCR.CSBF, Clear standby flag
: PWR_SCR.CWUF6 ( -- x addr ) 5 bit PWR_SCR ; \ PWR_SCR.CWUF6, Clear wakeup flag 6
: PWR_SCR.CWUF5 ( -- x addr ) 4 bit PWR_SCR ; \ PWR_SCR.CWUF5, Clear wakeup flag 5
: PWR_SCR.CWUF4 ( -- x addr ) 3 bit PWR_SCR ; \ PWR_SCR.CWUF4, Clear wakeup flag 4
: PWR_SCR.CWUF2 ( -- x addr ) 1 bit PWR_SCR ; \ PWR_SCR.CWUF2, Clear wakeup flag 2
: PWR_SCR.CWUF1 ( -- x addr ) 0 bit PWR_SCR ; \ PWR_SCR.CWUF1, Clear wakeup flag 1

\ PWR_PUCRA (read-write) Reset:$00000000
: PWR_PUCRA.PU15 ( -- x addr ) 15 bit PWR_PUCRA ; \ PWR_PUCRA.PU15, Port A pull-up bit y               (y=0..15)
: PWR_PUCRA.PU14 ( -- x addr ) 14 bit PWR_PUCRA ; \ PWR_PUCRA.PU14, Port A pull-up bit y               (y=0..15)
: PWR_PUCRA.PU13 ( -- x addr ) 13 bit PWR_PUCRA ; \ PWR_PUCRA.PU13, Port A pull-up bit y               (y=0..15)
: PWR_PUCRA.PU12 ( -- x addr ) 12 bit PWR_PUCRA ; \ PWR_PUCRA.PU12, Port A pull-up bit y               (y=0..15)
: PWR_PUCRA.PU11 ( -- x addr ) 11 bit PWR_PUCRA ; \ PWR_PUCRA.PU11, Port A pull-up bit y               (y=0..15)
: PWR_PUCRA.PU10 ( -- x addr ) 10 bit PWR_PUCRA ; \ PWR_PUCRA.PU10, Port A pull-up bit y               (y=0..15)
: PWR_PUCRA.PU9 ( -- x addr ) 9 bit PWR_PUCRA ; \ PWR_PUCRA.PU9, Port A pull-up bit y               (y=0..15)
: PWR_PUCRA.PU8 ( -- x addr ) 8 bit PWR_PUCRA ; \ PWR_PUCRA.PU8, Port A pull-up bit y               (y=0..15)
: PWR_PUCRA.PU7 ( -- x addr ) 7 bit PWR_PUCRA ; \ PWR_PUCRA.PU7, Port A pull-up bit y               (y=0..15)
: PWR_PUCRA.PU6 ( -- x addr ) 6 bit PWR_PUCRA ; \ PWR_PUCRA.PU6, Port A pull-up bit y               (y=0..15)
: PWR_PUCRA.PU5 ( -- x addr ) 5 bit PWR_PUCRA ; \ PWR_PUCRA.PU5, Port A pull-up bit y               (y=0..15)
: PWR_PUCRA.PU4 ( -- x addr ) 4 bit PWR_PUCRA ; \ PWR_PUCRA.PU4, Port A pull-up bit y               (y=0..15)
: PWR_PUCRA.PU3 ( -- x addr ) 3 bit PWR_PUCRA ; \ PWR_PUCRA.PU3, Port A pull-up bit y               (y=0..15)
: PWR_PUCRA.PU2 ( -- x addr ) 2 bit PWR_PUCRA ; \ PWR_PUCRA.PU2, Port A pull-up bit y               (y=0..15)
: PWR_PUCRA.PU1 ( -- x addr ) 1 bit PWR_PUCRA ; \ PWR_PUCRA.PU1, Port A pull-up bit y               (y=0..15)
: PWR_PUCRA.PU0 ( -- x addr ) 0 bit PWR_PUCRA ; \ PWR_PUCRA.PU0, Port A pull-up bit y               (y=0..15)

\ PWR_PDCRA (read-write) Reset:$00000000
: PWR_PDCRA.PD15 ( -- x addr ) 15 bit PWR_PDCRA ; \ PWR_PDCRA.PD15, Port A pull-down bit y               (y=0..15)
: PWR_PDCRA.PD14 ( -- x addr ) 14 bit PWR_PDCRA ; \ PWR_PDCRA.PD14, Port A pull-down bit y               (y=0..15)
: PWR_PDCRA.PD13 ( -- x addr ) 13 bit PWR_PDCRA ; \ PWR_PDCRA.PD13, Port A pull-down bit y               (y=0..15)
: PWR_PDCRA.PD12 ( -- x addr ) 12 bit PWR_PDCRA ; \ PWR_PDCRA.PD12, Port A pull-down bit y               (y=0..15)
: PWR_PDCRA.PD11 ( -- x addr ) 11 bit PWR_PDCRA ; \ PWR_PDCRA.PD11, Port A pull-down bit y               (y=0..15)
: PWR_PDCRA.PD10 ( -- x addr ) 10 bit PWR_PDCRA ; \ PWR_PDCRA.PD10, Port A pull-down bit y               (y=0..15)
: PWR_PDCRA.PD9 ( -- x addr ) 9 bit PWR_PDCRA ; \ PWR_PDCRA.PD9, Port A pull-down bit y               (y=0..15)
: PWR_PDCRA.PD8 ( -- x addr ) 8 bit PWR_PDCRA ; \ PWR_PDCRA.PD8, Port A pull-down bit y               (y=0..15)
: PWR_PDCRA.PD7 ( -- x addr ) 7 bit PWR_PDCRA ; \ PWR_PDCRA.PD7, Port A pull-down bit y               (y=0..15)
: PWR_PDCRA.PD6 ( -- x addr ) 6 bit PWR_PDCRA ; \ PWR_PDCRA.PD6, Port A pull-down bit y               (y=0..15)
: PWR_PDCRA.PD5 ( -- x addr ) 5 bit PWR_PDCRA ; \ PWR_PDCRA.PD5, Port A pull-down bit y               (y=0..15)
: PWR_PDCRA.PD4 ( -- x addr ) 4 bit PWR_PDCRA ; \ PWR_PDCRA.PD4, Port A pull-down bit y               (y=0..15)
: PWR_PDCRA.PD3 ( -- x addr ) 3 bit PWR_PDCRA ; \ PWR_PDCRA.PD3, Port A pull-down bit y               (y=0..15)
: PWR_PDCRA.PD2 ( -- x addr ) 2 bit PWR_PDCRA ; \ PWR_PDCRA.PD2, Port A pull-down bit y               (y=0..15)
: PWR_PDCRA.PD1 ( -- x addr ) 1 bit PWR_PDCRA ; \ PWR_PDCRA.PD1, Port A pull-down bit y               (y=0..15)
: PWR_PDCRA.PD0 ( -- x addr ) 0 bit PWR_PDCRA ; \ PWR_PDCRA.PD0, Port A pull-down bit y               (y=0..15)

\ PWR_PUCRB (read-write) Reset:$00000000
: PWR_PUCRB.PU15 ( -- x addr ) 15 bit PWR_PUCRB ; \ PWR_PUCRB.PU15, Port B pull-up bit y               (y=0..15)
: PWR_PUCRB.PU14 ( -- x addr ) 14 bit PWR_PUCRB ; \ PWR_PUCRB.PU14, Port B pull-up bit y               (y=0..15)
: PWR_PUCRB.PU13 ( -- x addr ) 13 bit PWR_PUCRB ; \ PWR_PUCRB.PU13, Port B pull-up bit y               (y=0..15)
: PWR_PUCRB.PU12 ( -- x addr ) 12 bit PWR_PUCRB ; \ PWR_PUCRB.PU12, Port B pull-up bit y               (y=0..15)
: PWR_PUCRB.PU11 ( -- x addr ) 11 bit PWR_PUCRB ; \ PWR_PUCRB.PU11, Port B pull-up bit y               (y=0..15)
: PWR_PUCRB.PU10 ( -- x addr ) 10 bit PWR_PUCRB ; \ PWR_PUCRB.PU10, Port B pull-up bit y               (y=0..15)
: PWR_PUCRB.PU9 ( -- x addr ) 9 bit PWR_PUCRB ; \ PWR_PUCRB.PU9, Port B pull-up bit y               (y=0..15)
: PWR_PUCRB.PU8 ( -- x addr ) 8 bit PWR_PUCRB ; \ PWR_PUCRB.PU8, Port B pull-up bit y               (y=0..15)
: PWR_PUCRB.PU7 ( -- x addr ) 7 bit PWR_PUCRB ; \ PWR_PUCRB.PU7, Port B pull-up bit y               (y=0..15)
: PWR_PUCRB.PU6 ( -- x addr ) 6 bit PWR_PUCRB ; \ PWR_PUCRB.PU6, Port B pull-up bit y               (y=0..15)
: PWR_PUCRB.PU5 ( -- x addr ) 5 bit PWR_PUCRB ; \ PWR_PUCRB.PU5, Port B pull-up bit y               (y=0..15)
: PWR_PUCRB.PU4 ( -- x addr ) 4 bit PWR_PUCRB ; \ PWR_PUCRB.PU4, Port B pull-up bit y               (y=0..15)
: PWR_PUCRB.PU3 ( -- x addr ) 3 bit PWR_PUCRB ; \ PWR_PUCRB.PU3, Port B pull-up bit y               (y=0..15)
: PWR_PUCRB.PU2 ( -- x addr ) 2 bit PWR_PUCRB ; \ PWR_PUCRB.PU2, Port B pull-up bit y               (y=0..15)
: PWR_PUCRB.PU1 ( -- x addr ) 1 bit PWR_PUCRB ; \ PWR_PUCRB.PU1, Port B pull-up bit y               (y=0..15)
: PWR_PUCRB.PU0 ( -- x addr ) 0 bit PWR_PUCRB ; \ PWR_PUCRB.PU0, Port B pull-up bit y               (y=0..15)

\ PWR_PDCRB (read-write) Reset:$00000000
: PWR_PDCRB.PD15 ( -- x addr ) 15 bit PWR_PDCRB ; \ PWR_PDCRB.PD15, Port B pull-down bit y               (y=0..15)
: PWR_PDCRB.PD14 ( -- x addr ) 14 bit PWR_PDCRB ; \ PWR_PDCRB.PD14, Port B pull-down bit y               (y=0..15)
: PWR_PDCRB.PD13 ( -- x addr ) 13 bit PWR_PDCRB ; \ PWR_PDCRB.PD13, Port B pull-down bit y               (y=0..15)
: PWR_PDCRB.PD12 ( -- x addr ) 12 bit PWR_PDCRB ; \ PWR_PDCRB.PD12, Port B pull-down bit y               (y=0..15)
: PWR_PDCRB.PD11 ( -- x addr ) 11 bit PWR_PDCRB ; \ PWR_PDCRB.PD11, Port B pull-down bit y               (y=0..15)
: PWR_PDCRB.PD10 ( -- x addr ) 10 bit PWR_PDCRB ; \ PWR_PDCRB.PD10, Port B pull-down bit y               (y=0..15)
: PWR_PDCRB.PD9 ( -- x addr ) 9 bit PWR_PDCRB ; \ PWR_PDCRB.PD9, Port B pull-down bit y               (y=0..15)
: PWR_PDCRB.PD8 ( -- x addr ) 8 bit PWR_PDCRB ; \ PWR_PDCRB.PD8, Port B pull-down bit y               (y=0..15)
: PWR_PDCRB.PD7 ( -- x addr ) 7 bit PWR_PDCRB ; \ PWR_PDCRB.PD7, Port B pull-down bit y               (y=0..15)
: PWR_PDCRB.PD6 ( -- x addr ) 6 bit PWR_PDCRB ; \ PWR_PDCRB.PD6, Port B pull-down bit y               (y=0..15)
: PWR_PDCRB.PD5 ( -- x addr ) 5 bit PWR_PDCRB ; \ PWR_PDCRB.PD5, Port B pull-down bit y               (y=0..15)
: PWR_PDCRB.PD4 ( -- x addr ) 4 bit PWR_PDCRB ; \ PWR_PDCRB.PD4, Port B pull-down bit y               (y=0..15)
: PWR_PDCRB.PD3 ( -- x addr ) 3 bit PWR_PDCRB ; \ PWR_PDCRB.PD3, Port B pull-down bit y               (y=0..15)
: PWR_PDCRB.PD2 ( -- x addr ) 2 bit PWR_PDCRB ; \ PWR_PDCRB.PD2, Port B pull-down bit y               (y=0..15)
: PWR_PDCRB.PD1 ( -- x addr ) 1 bit PWR_PDCRB ; \ PWR_PDCRB.PD1, Port B pull-down bit y               (y=0..15)
: PWR_PDCRB.PD0 ( -- x addr ) 0 bit PWR_PDCRB ; \ PWR_PDCRB.PD0, Port B pull-down bit y               (y=0..15)

\ PWR_PUCRC (read-write) Reset:$00000000
: PWR_PUCRC.PU15 ( -- x addr ) 15 bit PWR_PUCRC ; \ PWR_PUCRC.PU15, Port C pull-up bit y               (y=0..15)
: PWR_PUCRC.PU14 ( -- x addr ) 14 bit PWR_PUCRC ; \ PWR_PUCRC.PU14, Port C pull-up bit y               (y=0..15)
: PWR_PUCRC.PU13 ( -- x addr ) 13 bit PWR_PUCRC ; \ PWR_PUCRC.PU13, Port C pull-up bit y               (y=0..15)
: PWR_PUCRC.PU7 ( -- x addr ) 7 bit PWR_PUCRC ; \ PWR_PUCRC.PU7, Port C pull-up bit y               (y=0..15)
: PWR_PUCRC.PU6 ( -- x addr ) 6 bit PWR_PUCRC ; \ PWR_PUCRC.PU6, Port C pull-up bit y               (y=0..15)

\ PWR_PDCRC (read-write) Reset:$00000000
: PWR_PDCRC.PD15 ( -- x addr ) 15 bit PWR_PDCRC ; \ PWR_PDCRC.PD15, Port C pull-down bit y               (y=0..15)
: PWR_PDCRC.PD14 ( -- x addr ) 14 bit PWR_PDCRC ; \ PWR_PDCRC.PD14, Port C pull-down bit y               (y=0..15)
: PWR_PDCRC.PD13 ( -- x addr ) 13 bit PWR_PDCRC ; \ PWR_PDCRC.PD13, Port C pull-down bit y               (y=0..15)
: PWR_PDCRC.PD12 ( -- x addr ) 12 bit PWR_PDCRC ; \ PWR_PDCRC.PD12, Port C pull-down bit y               (y=0..15)
: PWR_PDCRC.PD11 ( -- x addr ) 11 bit PWR_PDCRC ; \ PWR_PDCRC.PD11, Port C pull-down bit y               (y=0..15)
: PWR_PDCRC.PD10 ( -- x addr ) 10 bit PWR_PDCRC ; \ PWR_PDCRC.PD10, Port C pull-down bit y               (y=0..15)
: PWR_PDCRC.PD9 ( -- x addr ) 9 bit PWR_PDCRC ; \ PWR_PDCRC.PD9, Port C pull-down bit y               (y=0..15)
: PWR_PDCRC.PD8 ( -- x addr ) 8 bit PWR_PDCRC ; \ PWR_PDCRC.PD8, Port C pull-down bit y               (y=0..15)
: PWR_PDCRC.PD7 ( -- x addr ) 7 bit PWR_PDCRC ; \ PWR_PDCRC.PD7, Port C pull-down bit y               (y=0..15)
: PWR_PDCRC.PD6 ( -- x addr ) 6 bit PWR_PDCRC ; \ PWR_PDCRC.PD6, Port C pull-down bit y               (y=0..15)
: PWR_PDCRC.PD5 ( -- x addr ) 5 bit PWR_PDCRC ; \ PWR_PDCRC.PD5, Port C pull-down bit y               (y=0..15)
: PWR_PDCRC.PD4 ( -- x addr ) 4 bit PWR_PDCRC ; \ PWR_PDCRC.PD4, Port C pull-down bit y               (y=0..15)
: PWR_PDCRC.PD3 ( -- x addr ) 3 bit PWR_PDCRC ; \ PWR_PDCRC.PD3, Port C pull-down bit y               (y=0..15)
: PWR_PDCRC.PD2 ( -- x addr ) 2 bit PWR_PDCRC ; \ PWR_PDCRC.PD2, Port C pull-down bit y               (y=0..15)
: PWR_PDCRC.PD1 ( -- x addr ) 1 bit PWR_PDCRC ; \ PWR_PDCRC.PD1, Port C pull-down bit y               (y=0..15)
: PWR_PDCRC.PD0 ( -- x addr ) 0 bit PWR_PDCRC ; \ PWR_PDCRC.PD0, Port C pull-down bit y               (y=0..15)

\ PWR_PUCRD (read-write) Reset:$00000000
: PWR_PUCRD.PU3 ( -- x addr ) 3 bit PWR_PUCRD ; \ PWR_PUCRD.PU3, Port D pull-up bit y               (y=0..15)
: PWR_PUCRD.PU2 ( -- x addr ) 2 bit PWR_PUCRD ; \ PWR_PUCRD.PU2, Port D pull-up bit y               (y=0..15)
: PWR_PUCRD.PU1 ( -- x addr ) 1 bit PWR_PUCRD ; \ PWR_PUCRD.PU1, Port D pull-up bit y               (y=0..15)
: PWR_PUCRD.PU0 ( -- x addr ) 0 bit PWR_PUCRD ; \ PWR_PUCRD.PU0, Port D pull-up bit y               (y=0..15)

\ PWR_PDCRD (read-write) Reset:$00000000
: PWR_PDCRD.PD9 ( -- x addr ) 9 bit PWR_PDCRD ; \ PWR_PDCRD.PD9, Port D pull-down bit y               (y=0..15)
: PWR_PDCRD.PD8 ( -- x addr ) 8 bit PWR_PDCRD ; \ PWR_PDCRD.PD8, Port D pull-down bit y               (y=0..15)
: PWR_PDCRD.PD6 ( -- x addr ) 6 bit PWR_PDCRD ; \ PWR_PDCRD.PD6, Port D pull-down bit y               (y=0..15)
: PWR_PDCRD.PD5 ( -- x addr ) 5 bit PWR_PDCRD ; \ PWR_PDCRD.PD5, Port D pull-down bit y               (y=0..15)
: PWR_PDCRD.PD4 ( -- x addr ) 4 bit PWR_PDCRD ; \ PWR_PDCRD.PD4, Port D pull-down bit y               (y=0..15)
: PWR_PDCRD.PD3 ( -- x addr ) 3 bit PWR_PDCRD ; \ PWR_PDCRD.PD3, Port D pull-down bit y               (y=0..15)
: PWR_PDCRD.PD2 ( -- x addr ) 2 bit PWR_PDCRD ; \ PWR_PDCRD.PD2, Port D pull-down bit y               (y=0..15)
: PWR_PDCRD.PD1 ( -- x addr ) 1 bit PWR_PDCRD ; \ PWR_PDCRD.PD1, Port D pull-down bit y               (y=0..15)
: PWR_PDCRD.PD0 ( -- x addr ) 0 bit PWR_PDCRD ; \ PWR_PDCRD.PD0, Port D pull-down bit y               (y=0..15)

\ PWR_PUCRF (read-write) Reset:$00000000
: PWR_PUCRF.PU2 ( -- x addr ) 2 bit PWR_PUCRF ; \ PWR_PUCRF.PU2, Port F pull-up bit y               (y=0..15)
: PWR_PUCRF.PU1 ( -- x addr ) 1 bit PWR_PUCRF ; \ PWR_PUCRF.PU1, Port F pull-up bit y               (y=0..15)
: PWR_PUCRF.PU0 ( -- x addr ) 0 bit PWR_PUCRF ; \ PWR_PUCRF.PU0, Port F pull-up bit y               (y=0..15)

\ PWR_PDCRF (read-write) Reset:$00000000
: PWR_PDCRF.PD2 ( -- x addr ) 2 bit PWR_PDCRF ; \ PWR_PDCRF.PD2, Port F pull-down bit y               (y=0..15)
: PWR_PDCRF.PD1 ( -- x addr ) 1 bit PWR_PDCRF ; \ PWR_PDCRF.PD1, Port F pull-down bit y               (y=0..15)
: PWR_PDCRF.PD0 ( -- x addr ) 0 bit PWR_PDCRF ; \ PWR_PDCRF.PD0, Port F pull-down bit y               (y=0..15)

\ DMA_ISR (read-only) Reset:$00000000
: DMA_ISR.GIF0? ( --  1|0 ) 0 bit DMA_ISR bit@ ; \ DMA_ISR.GIF0, Channel global interrupt               flag
: DMA_ISR.TCIF1? ( --  1|0 ) 1 bit DMA_ISR bit@ ; \ DMA_ISR.TCIF1, Channel transfer complete               flag
: DMA_ISR.HTIF2? ( --  1|0 ) 2 bit DMA_ISR bit@ ; \ DMA_ISR.HTIF2, Channel half transfer flag
: DMA_ISR.TEIF3? ( --  1|0 ) 3 bit DMA_ISR bit@ ; \ DMA_ISR.TEIF3, Channel transfer error               flag
: DMA_ISR.GIF4? ( --  1|0 ) 4 bit DMA_ISR bit@ ; \ DMA_ISR.GIF4, Channel global interrupt               flag
: DMA_ISR.TCIF5? ( --  1|0 ) 5 bit DMA_ISR bit@ ; \ DMA_ISR.TCIF5, Channel transfer complete               flag
: DMA_ISR.HTIF6? ( --  1|0 ) 6 bit DMA_ISR bit@ ; \ DMA_ISR.HTIF6, Channel half transfer flag
: DMA_ISR.TEIF7? ( --  1|0 ) 7 bit DMA_ISR bit@ ; \ DMA_ISR.TEIF7, Channel transfer error               flag
: DMA_ISR.GIF8? ( --  1|0 ) 8 bit DMA_ISR bit@ ; \ DMA_ISR.GIF8, Channel global interrupt               flag
: DMA_ISR.TCIF9? ( --  1|0 ) 9 bit DMA_ISR bit@ ; \ DMA_ISR.TCIF9, Channel transfer complete               flag
: DMA_ISR.HTIF10? ( --  1|0 ) 10 bit DMA_ISR bit@ ; \ DMA_ISR.HTIF10, Channel half transfer flag
: DMA_ISR.TEIF11? ( --  1|0 ) 11 bit DMA_ISR bit@ ; \ DMA_ISR.TEIF11, Channel transfer error               flag
: DMA_ISR.GIF12? ( --  1|0 ) 12 bit DMA_ISR bit@ ; \ DMA_ISR.GIF12, Channel global interrupt               flag
: DMA_ISR.TCIF13? ( --  1|0 ) 13 bit DMA_ISR bit@ ; \ DMA_ISR.TCIF13, Channel transfer complete               flag
: DMA_ISR.HTIF14? ( --  1|0 ) 14 bit DMA_ISR bit@ ; \ DMA_ISR.HTIF14, Channel half transfer flag
: DMA_ISR.TEIF15? ( --  1|0 ) 15 bit DMA_ISR bit@ ; \ DMA_ISR.TEIF15, Channel transfer error               flag
: DMA_ISR.GIF16? ( --  1|0 ) 16 bit DMA_ISR bit@ ; \ DMA_ISR.GIF16, Channel global interrupt               flag
: DMA_ISR.TCIF17? ( --  1|0 ) 17 bit DMA_ISR bit@ ; \ DMA_ISR.TCIF17, Channel transfer complete               flag
: DMA_ISR.HTIF18? ( --  1|0 ) 18 bit DMA_ISR bit@ ; \ DMA_ISR.HTIF18, Channel half transfer flag
: DMA_ISR.TEIF19? ( --  1|0 ) 19 bit DMA_ISR bit@ ; \ DMA_ISR.TEIF19, Channel transfer error               flag
: DMA_ISR.GIF20? ( --  1|0 ) 20 bit DMA_ISR bit@ ; \ DMA_ISR.GIF20, Channel global interrupt               flag
: DMA_ISR.TCIF21? ( --  1|0 ) 21 bit DMA_ISR bit@ ; \ DMA_ISR.TCIF21, Channel transfer complete               flag
: DMA_ISR.HTIF22? ( --  1|0 ) 22 bit DMA_ISR bit@ ; \ DMA_ISR.HTIF22, Channel half transfer flag
: DMA_ISR.TEIF23? ( --  1|0 ) 23 bit DMA_ISR bit@ ; \ DMA_ISR.TEIF23, Channel transfer error               flag
: DMA_ISR.GIF24? ( --  1|0 ) 24 bit DMA_ISR bit@ ; \ DMA_ISR.GIF24, Channel global interrupt               flag
: DMA_ISR.TCIF25? ( --  1|0 ) 25 bit DMA_ISR bit@ ; \ DMA_ISR.TCIF25, Channel transfer complete               flag
: DMA_ISR.HTIF26? ( --  1|0 ) 26 bit DMA_ISR bit@ ; \ DMA_ISR.HTIF26, Channel half transfer flag
: DMA_ISR.TEIF27? ( --  1|0 ) 27 bit DMA_ISR bit@ ; \ DMA_ISR.TEIF27, Channel transfer error               flag

\ DMA_IFCR (read-only) Reset:$00000000
: DMA_IFCR.CGIF0? ( --  1|0 ) 0 bit DMA_IFCR bit@ ; \ DMA_IFCR.CGIF0, Channel global interrupt               flag
: DMA_IFCR.CTCIF1? ( --  1|0 ) 1 bit DMA_IFCR bit@ ; \ DMA_IFCR.CTCIF1, Channel transfer complete               flag
: DMA_IFCR.CHTIF2? ( --  1|0 ) 2 bit DMA_IFCR bit@ ; \ DMA_IFCR.CHTIF2, Channel half transfer flag
: DMA_IFCR.CTEIF3? ( --  1|0 ) 3 bit DMA_IFCR bit@ ; \ DMA_IFCR.CTEIF3, Channel transfer error               flag
: DMA_IFCR.CGIF4? ( --  1|0 ) 4 bit DMA_IFCR bit@ ; \ DMA_IFCR.CGIF4, Channel global interrupt               flag
: DMA_IFCR.CTCIF5? ( --  1|0 ) 5 bit DMA_IFCR bit@ ; \ DMA_IFCR.CTCIF5, Channel transfer complete               flag
: DMA_IFCR.CHTIF6? ( --  1|0 ) 6 bit DMA_IFCR bit@ ; \ DMA_IFCR.CHTIF6, Channel half transfer flag
: DMA_IFCR.CTEIF7? ( --  1|0 ) 7 bit DMA_IFCR bit@ ; \ DMA_IFCR.CTEIF7, Channel transfer error               flag
: DMA_IFCR.CGIF8? ( --  1|0 ) 8 bit DMA_IFCR bit@ ; \ DMA_IFCR.CGIF8, Channel global interrupt               flag
: DMA_IFCR.CTCIF9? ( --  1|0 ) 9 bit DMA_IFCR bit@ ; \ DMA_IFCR.CTCIF9, Channel transfer complete               flag
: DMA_IFCR.CHTIF10? ( --  1|0 ) 10 bit DMA_IFCR bit@ ; \ DMA_IFCR.CHTIF10, Channel half transfer flag
: DMA_IFCR.CTEIF11? ( --  1|0 ) 11 bit DMA_IFCR bit@ ; \ DMA_IFCR.CTEIF11, Channel transfer error               flag
: DMA_IFCR.CGIF12? ( --  1|0 ) 12 bit DMA_IFCR bit@ ; \ DMA_IFCR.CGIF12, Channel global interrupt               flag
: DMA_IFCR.CTCIF13? ( --  1|0 ) 13 bit DMA_IFCR bit@ ; \ DMA_IFCR.CTCIF13, Channel transfer complete               flag
: DMA_IFCR.CHTIF14? ( --  1|0 ) 14 bit DMA_IFCR bit@ ; \ DMA_IFCR.CHTIF14, Channel half transfer flag
: DMA_IFCR.CTEIF15? ( --  1|0 ) 15 bit DMA_IFCR bit@ ; \ DMA_IFCR.CTEIF15, Channel transfer error               flag
: DMA_IFCR.CGIF16? ( --  1|0 ) 16 bit DMA_IFCR bit@ ; \ DMA_IFCR.CGIF16, Channel global interrupt               flag
: DMA_IFCR.CTCIF17? ( --  1|0 ) 17 bit DMA_IFCR bit@ ; \ DMA_IFCR.CTCIF17, Channel transfer complete               flag
: DMA_IFCR.CHTIF18? ( --  1|0 ) 18 bit DMA_IFCR bit@ ; \ DMA_IFCR.CHTIF18, Channel half transfer flag
: DMA_IFCR.CTEIF19? ( --  1|0 ) 19 bit DMA_IFCR bit@ ; \ DMA_IFCR.CTEIF19, Channel transfer error               flag
: DMA_IFCR.CGIF20? ( --  1|0 ) 20 bit DMA_IFCR bit@ ; \ DMA_IFCR.CGIF20, Channel global interrupt               flag
: DMA_IFCR.CTCIF21? ( --  1|0 ) 21 bit DMA_IFCR bit@ ; \ DMA_IFCR.CTCIF21, Channel transfer complete               flag
: DMA_IFCR.CHTIF22? ( --  1|0 ) 22 bit DMA_IFCR bit@ ; \ DMA_IFCR.CHTIF22, Channel half transfer flag
: DMA_IFCR.CTEIF23? ( --  1|0 ) 23 bit DMA_IFCR bit@ ; \ DMA_IFCR.CTEIF23, Channel transfer error               flag
: DMA_IFCR.CGIF24? ( --  1|0 ) 24 bit DMA_IFCR bit@ ; \ DMA_IFCR.CGIF24, Channel global interrupt               flag
: DMA_IFCR.CTCIF25? ( --  1|0 ) 25 bit DMA_IFCR bit@ ; \ DMA_IFCR.CTCIF25, Channel transfer complete               flag
: DMA_IFCR.CHTIF26? ( --  1|0 ) 26 bit DMA_IFCR bit@ ; \ DMA_IFCR.CHTIF26, Channel half transfer flag
: DMA_IFCR.CTEIF27? ( --  1|0 ) 27 bit DMA_IFCR bit@ ; \ DMA_IFCR.CTEIF27, Channel transfer error               flag

\ DMA_CCR1 (read-write) Reset:$00000000
: DMA_CCR1.EN ( -- x addr ) 0 bit DMA_CCR1 ; \ DMA_CCR1.EN, Channel enable
: DMA_CCR1.TCIE ( -- x addr ) 1 bit DMA_CCR1 ; \ DMA_CCR1.TCIE, Transfer complete interrupt               enable
: DMA_CCR1.HTIE ( -- x addr ) 2 bit DMA_CCR1 ; \ DMA_CCR1.HTIE, Half transfer interrupt               enable
: DMA_CCR1.TEIE ( -- x addr ) 3 bit DMA_CCR1 ; \ DMA_CCR1.TEIE, Transfer error interrupt               enable
: DMA_CCR1.DIR ( -- x addr ) 4 bit DMA_CCR1 ; \ DMA_CCR1.DIR, Data transfer direction
: DMA_CCR1.CIRC ( -- x addr ) 5 bit DMA_CCR1 ; \ DMA_CCR1.CIRC, Circular mode
: DMA_CCR1.PINC ( -- x addr ) 6 bit DMA_CCR1 ; \ DMA_CCR1.PINC, Peripheral increment mode
: DMA_CCR1.MINC ( -- x addr ) 7 bit DMA_CCR1 ; \ DMA_CCR1.MINC, Memory increment mode
: DMA_CCR1.PSIZE ( %bb -- x addr ) 8 lshift DMA_CCR1 ; \ DMA_CCR1.PSIZE, Peripheral size
: DMA_CCR1.MSIZE ( %bb -- x addr ) 10 lshift DMA_CCR1 ; \ DMA_CCR1.MSIZE, Memory size
: DMA_CCR1.PL ( %bb -- x addr ) 12 lshift DMA_CCR1 ; \ DMA_CCR1.PL, Channel priority level
: DMA_CCR1.MEM2MEM ( -- x addr ) 14 bit DMA_CCR1 ; \ DMA_CCR1.MEM2MEM, Memory to memory mode

\ DMA_CCR2 (read-write) Reset:$00000000
: DMA_CCR2.EN ( -- x addr ) 0 bit DMA_CCR2 ; \ DMA_CCR2.EN, Channel enable
: DMA_CCR2.TCIE ( -- x addr ) 1 bit DMA_CCR2 ; \ DMA_CCR2.TCIE, Transfer complete interrupt               enable
: DMA_CCR2.HTIE ( -- x addr ) 2 bit DMA_CCR2 ; \ DMA_CCR2.HTIE, Half transfer interrupt               enable
: DMA_CCR2.TEIE ( -- x addr ) 3 bit DMA_CCR2 ; \ DMA_CCR2.TEIE, Transfer error interrupt               enable
: DMA_CCR2.DIR ( -- x addr ) 4 bit DMA_CCR2 ; \ DMA_CCR2.DIR, Data transfer direction
: DMA_CCR2.CIRC ( -- x addr ) 5 bit DMA_CCR2 ; \ DMA_CCR2.CIRC, Circular mode
: DMA_CCR2.PINC ( -- x addr ) 6 bit DMA_CCR2 ; \ DMA_CCR2.PINC, Peripheral increment mode
: DMA_CCR2.MINC ( -- x addr ) 7 bit DMA_CCR2 ; \ DMA_CCR2.MINC, Memory increment mode
: DMA_CCR2.PSIZE ( %bb -- x addr ) 8 lshift DMA_CCR2 ; \ DMA_CCR2.PSIZE, Peripheral size
: DMA_CCR2.MSIZE ( %bb -- x addr ) 10 lshift DMA_CCR2 ; \ DMA_CCR2.MSIZE, Memory size
: DMA_CCR2.PL ( %bb -- x addr ) 12 lshift DMA_CCR2 ; \ DMA_CCR2.PL, Channel priority level
: DMA_CCR2.MEM2MEM ( -- x addr ) 14 bit DMA_CCR2 ; \ DMA_CCR2.MEM2MEM, Memory to memory mode

\ DMA_CCR3 (read-write) Reset:$00000000
: DMA_CCR3.EN ( -- x addr ) 0 bit DMA_CCR3 ; \ DMA_CCR3.EN, Channel enable
: DMA_CCR3.TCIE ( -- x addr ) 1 bit DMA_CCR3 ; \ DMA_CCR3.TCIE, Transfer complete interrupt               enable
: DMA_CCR3.HTIE ( -- x addr ) 2 bit DMA_CCR3 ; \ DMA_CCR3.HTIE, Half transfer interrupt               enable
: DMA_CCR3.TEIE ( -- x addr ) 3 bit DMA_CCR3 ; \ DMA_CCR3.TEIE, Transfer error interrupt               enable
: DMA_CCR3.DIR ( -- x addr ) 4 bit DMA_CCR3 ; \ DMA_CCR3.DIR, Data transfer direction
: DMA_CCR3.CIRC ( -- x addr ) 5 bit DMA_CCR3 ; \ DMA_CCR3.CIRC, Circular mode
: DMA_CCR3.PINC ( -- x addr ) 6 bit DMA_CCR3 ; \ DMA_CCR3.PINC, Peripheral increment mode
: DMA_CCR3.MINC ( -- x addr ) 7 bit DMA_CCR3 ; \ DMA_CCR3.MINC, Memory increment mode
: DMA_CCR3.PSIZE ( %bb -- x addr ) 8 lshift DMA_CCR3 ; \ DMA_CCR3.PSIZE, Peripheral size
: DMA_CCR3.MSIZE ( %bb -- x addr ) 10 lshift DMA_CCR3 ; \ DMA_CCR3.MSIZE, Memory size
: DMA_CCR3.PL ( %bb -- x addr ) 12 lshift DMA_CCR3 ; \ DMA_CCR3.PL, Channel priority level
: DMA_CCR3.MEM2MEM ( -- x addr ) 14 bit DMA_CCR3 ; \ DMA_CCR3.MEM2MEM, Memory to memory mode

\ DMA_CCR4 (read-write) Reset:$00000000
: DMA_CCR4.EN ( -- x addr ) 0 bit DMA_CCR4 ; \ DMA_CCR4.EN, Channel enable
: DMA_CCR4.TCIE ( -- x addr ) 1 bit DMA_CCR4 ; \ DMA_CCR4.TCIE, Transfer complete interrupt               enable
: DMA_CCR4.HTIE ( -- x addr ) 2 bit DMA_CCR4 ; \ DMA_CCR4.HTIE, Half transfer interrupt               enable
: DMA_CCR4.TEIE ( -- x addr ) 3 bit DMA_CCR4 ; \ DMA_CCR4.TEIE, Transfer error interrupt               enable
: DMA_CCR4.DIR ( -- x addr ) 4 bit DMA_CCR4 ; \ DMA_CCR4.DIR, Data transfer direction
: DMA_CCR4.CIRC ( -- x addr ) 5 bit DMA_CCR4 ; \ DMA_CCR4.CIRC, Circular mode
: DMA_CCR4.PINC ( -- x addr ) 6 bit DMA_CCR4 ; \ DMA_CCR4.PINC, Peripheral increment mode
: DMA_CCR4.MINC ( -- x addr ) 7 bit DMA_CCR4 ; \ DMA_CCR4.MINC, Memory increment mode
: DMA_CCR4.PSIZE ( %bb -- x addr ) 8 lshift DMA_CCR4 ; \ DMA_CCR4.PSIZE, Peripheral size
: DMA_CCR4.MSIZE ( %bb -- x addr ) 10 lshift DMA_CCR4 ; \ DMA_CCR4.MSIZE, Memory size
: DMA_CCR4.PL ( %bb -- x addr ) 12 lshift DMA_CCR4 ; \ DMA_CCR4.PL, Channel priority level
: DMA_CCR4.MEM2MEM ( -- x addr ) 14 bit DMA_CCR4 ; \ DMA_CCR4.MEM2MEM, Memory to memory mode

\ DMA_CCR5 (read-write) Reset:$00000000
: DMA_CCR5.EN ( -- x addr ) 0 bit DMA_CCR5 ; \ DMA_CCR5.EN, Channel enable
: DMA_CCR5.TCIE ( -- x addr ) 1 bit DMA_CCR5 ; \ DMA_CCR5.TCIE, Transfer complete interrupt               enable
: DMA_CCR5.HTIE ( -- x addr ) 2 bit DMA_CCR5 ; \ DMA_CCR5.HTIE, Half transfer interrupt               enable
: DMA_CCR5.TEIE ( -- x addr ) 3 bit DMA_CCR5 ; \ DMA_CCR5.TEIE, Transfer error interrupt               enable
: DMA_CCR5.DIR ( -- x addr ) 4 bit DMA_CCR5 ; \ DMA_CCR5.DIR, Data transfer direction
: DMA_CCR5.CIRC ( -- x addr ) 5 bit DMA_CCR5 ; \ DMA_CCR5.CIRC, Circular mode
: DMA_CCR5.PINC ( -- x addr ) 6 bit DMA_CCR5 ; \ DMA_CCR5.PINC, Peripheral increment mode
: DMA_CCR5.MINC ( -- x addr ) 7 bit DMA_CCR5 ; \ DMA_CCR5.MINC, Memory increment mode
: DMA_CCR5.PSIZE ( %bb -- x addr ) 8 lshift DMA_CCR5 ; \ DMA_CCR5.PSIZE, Peripheral size
: DMA_CCR5.MSIZE ( %bb -- x addr ) 10 lshift DMA_CCR5 ; \ DMA_CCR5.MSIZE, Memory size
: DMA_CCR5.PL ( %bb -- x addr ) 12 lshift DMA_CCR5 ; \ DMA_CCR5.PL, Channel priority level
: DMA_CCR5.MEM2MEM ( -- x addr ) 14 bit DMA_CCR5 ; \ DMA_CCR5.MEM2MEM, Memory to memory mode

\ DMA_CNDTR1 (read-write) Reset:$00000000
: DMA_CNDTR1.NDT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA_CNDTR1 ; \ DMA_CNDTR1.NDT, Number of data to transfer

\ DMA_CNDTR2 (read-write) Reset:$00000000
: DMA_CNDTR2.NDT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA_CNDTR2 ; \ DMA_CNDTR2.NDT, Number of data to transfer

\ DMA_CNDTR3 (read-write) Reset:$00000000
: DMA_CNDTR3.NDT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA_CNDTR3 ; \ DMA_CNDTR3.NDT, Number of data to transfer

\ DMA_CNDTR4 (read-write) Reset:$00000000
: DMA_CNDTR4.NDT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA_CNDTR4 ; \ DMA_CNDTR4.NDT, Number of data to transfer

\ DMA_CNDTR5 (read-write) Reset:$00000000
: DMA_CNDTR5.NDT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA_CNDTR5 ; \ DMA_CNDTR5.NDT, Number of data to transfer

\ DMA_CPAR1 (read-write) Reset:$00000000
: DMA_CPAR1.PA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA_CPAR1 ; \ DMA_CPAR1.PA, Peripheral address

\ DMA_CPAR2 (read-write) Reset:$00000000
: DMA_CPAR2.PA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA_CPAR2 ; \ DMA_CPAR2.PA, Peripheral address

\ DMA_CPAR3 (read-write) Reset:$00000000
: DMA_CPAR3.PA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA_CPAR3 ; \ DMA_CPAR3.PA, Peripheral address

\ DMA_CPAR4 (read-write) Reset:$00000000
: DMA_CPAR4.PA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA_CPAR4 ; \ DMA_CPAR4.PA, Peripheral address

\ DMA_CPAR5 (read-write) Reset:$00000000
: DMA_CPAR5.PA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA_CPAR5 ; \ DMA_CPAR5.PA, Peripheral address

\ DMA_CMAR1 (read-write) Reset:$00000000
: DMA_CMAR1.MA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA_CMAR1 ; \ DMA_CMAR1.MA, Memory address

\ DMA_CMAR2 (read-write) Reset:$00000000
: DMA_CMAR2.MA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA_CMAR2 ; \ DMA_CMAR2.MA, Memory address

\ DMA_CMAR3 (read-write) Reset:$00000000
: DMA_CMAR3.MA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA_CMAR3 ; \ DMA_CMAR3.MA, Memory address

\ DMA_CMAR4 (read-write) Reset:$00000000
: DMA_CMAR4.MA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA_CMAR4 ; \ DMA_CMAR4.MA, Memory address

\ DMA_CMAR5 (read-write) Reset:$00000000
: DMA_CMAR5.MA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA_CMAR5 ; \ DMA_CMAR5.MA, Memory address

\ DMAMUX_C0CR (read-write) Reset:$00000000
: DMAMUX_C0CR.DMAREQ_ID ( %bbbbbbbb -- x addr ) DMAMUX_C0CR ; \ DMAMUX_C0CR.DMAREQ_ID, Input DMA request line               selected
: DMAMUX_C0CR.SOIE ( -- x addr ) 8 bit DMAMUX_C0CR ; \ DMAMUX_C0CR.SOIE, Interrupt enable at synchronization               event overrun
: DMAMUX_C0CR.EGE ( -- x addr ) 9 bit DMAMUX_C0CR ; \ DMAMUX_C0CR.EGE, Event generation               enable/disable
: DMAMUX_C0CR.SE ( -- x addr ) 16 bit DMAMUX_C0CR ; \ DMAMUX_C0CR.SE, Synchronous operating mode               enable/disable
: DMAMUX_C0CR.SPOL ( %bb -- x addr ) 17 lshift DMAMUX_C0CR ; \ DMAMUX_C0CR.SPOL, Synchronization event type selector               Defines the synchronization event on the selected               synchronization input:
: DMAMUX_C0CR.NBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX_C0CR ; \ DMAMUX_C0CR.NBREQ, Number of DMA requests to forward               Defines the number of DMA requests forwarded before               output event is generated. In synchronous mode, it               also defines the number of DMA requests to forward               after a synchronization event, then stop forwarding.               The actual number of DMA requests forwarded is               NBREQ+1. Note: This field can only be written when               both SE and EGE bits are reset.
: DMAMUX_C0CR.SYNC_ID ( %bbbbb -- x addr ) 24 lshift DMAMUX_C0CR ; \ DMAMUX_C0CR.SYNC_ID, Synchronization input               selected

\ DMAMUX_C1CR (read-write) Reset:$00000000
: DMAMUX_C1CR.DMAREQ_ID ( %bbbbbbbb -- x addr ) DMAMUX_C1CR ; \ DMAMUX_C1CR.DMAREQ_ID, Input DMA request line               selected
: DMAMUX_C1CR.SOIE ( -- x addr ) 8 bit DMAMUX_C1CR ; \ DMAMUX_C1CR.SOIE, Interrupt enable at synchronization               event overrun
: DMAMUX_C1CR.EGE ( -- x addr ) 9 bit DMAMUX_C1CR ; \ DMAMUX_C1CR.EGE, Event generation               enable/disable
: DMAMUX_C1CR.SE ( -- x addr ) 16 bit DMAMUX_C1CR ; \ DMAMUX_C1CR.SE, Synchronous operating mode               enable/disable
: DMAMUX_C1CR.SPOL ( %bb -- x addr ) 17 lshift DMAMUX_C1CR ; \ DMAMUX_C1CR.SPOL, Synchronization event type selector               Defines the synchronization event on the selected               synchronization input:
: DMAMUX_C1CR.NBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX_C1CR ; \ DMAMUX_C1CR.NBREQ, Number of DMA requests to forward               Defines the number of DMA requests forwarded before               output event is generated. In synchronous mode, it               also defines the number of DMA requests to forward               after a synchronization event, then stop forwarding.               The actual number of DMA requests forwarded is               NBREQ+1. Note: This field can only be written when               both SE and EGE bits are reset.
: DMAMUX_C1CR.SYNC_ID ( %bbbbb -- x addr ) 24 lshift DMAMUX_C1CR ; \ DMAMUX_C1CR.SYNC_ID, Synchronization input               selected

\ DMAMUX_C2CR (read-write) Reset:$00000000
: DMAMUX_C2CR.DMAREQ_ID ( %bbbbbbbb -- x addr ) DMAMUX_C2CR ; \ DMAMUX_C2CR.DMAREQ_ID, Input DMA request line               selected
: DMAMUX_C2CR.SOIE ( -- x addr ) 8 bit DMAMUX_C2CR ; \ DMAMUX_C2CR.SOIE, Interrupt enable at synchronization               event overrun
: DMAMUX_C2CR.EGE ( -- x addr ) 9 bit DMAMUX_C2CR ; \ DMAMUX_C2CR.EGE, Event generation               enable/disable
: DMAMUX_C2CR.SE ( -- x addr ) 16 bit DMAMUX_C2CR ; \ DMAMUX_C2CR.SE, Synchronous operating mode               enable/disable
: DMAMUX_C2CR.SPOL ( %bb -- x addr ) 17 lshift DMAMUX_C2CR ; \ DMAMUX_C2CR.SPOL, Synchronization event type selector               Defines the synchronization event on the selected               synchronization input:
: DMAMUX_C2CR.NBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX_C2CR ; \ DMAMUX_C2CR.NBREQ, Number of DMA requests to forward               Defines the number of DMA requests forwarded before               output event is generated. In synchronous mode, it               also defines the number of DMA requests to forward               after a synchronization event, then stop forwarding.               The actual number of DMA requests forwarded is               NBREQ+1. Note: This field can only be written when               both SE and EGE bits are reset.
: DMAMUX_C2CR.SYNC_ID ( %bbbbb -- x addr ) 24 lshift DMAMUX_C2CR ; \ DMAMUX_C2CR.SYNC_ID, Synchronization input               selected

\ DMAMUX_C3CR (read-write) Reset:$00000000
: DMAMUX_C3CR.DMAREQ_ID ( %bbbbbbbb -- x addr ) DMAMUX_C3CR ; \ DMAMUX_C3CR.DMAREQ_ID, Input DMA request line               selected
: DMAMUX_C3CR.SOIE ( -- x addr ) 8 bit DMAMUX_C3CR ; \ DMAMUX_C3CR.SOIE, Interrupt enable at synchronization               event overrun
: DMAMUX_C3CR.EGE ( -- x addr ) 9 bit DMAMUX_C3CR ; \ DMAMUX_C3CR.EGE, Event generation               enable/disable
: DMAMUX_C3CR.SE ( -- x addr ) 16 bit DMAMUX_C3CR ; \ DMAMUX_C3CR.SE, Synchronous operating mode               enable/disable
: DMAMUX_C3CR.SPOL ( %bb -- x addr ) 17 lshift DMAMUX_C3CR ; \ DMAMUX_C3CR.SPOL, Synchronization event type selector               Defines the synchronization event on the selected               synchronization input:
: DMAMUX_C3CR.NBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX_C3CR ; \ DMAMUX_C3CR.NBREQ, Number of DMA requests to forward               Defines the number of DMA requests forwarded before               output event is generated. In synchronous mode, it               also defines the number of DMA requests to forward               after a synchronization event, then stop forwarding.               The actual number of DMA requests forwarded is               NBREQ+1. Note: This field can only be written when               both SE and EGE bits are reset.
: DMAMUX_C3CR.SYNC_ID ( %bbbbb -- x addr ) 24 lshift DMAMUX_C3CR ; \ DMAMUX_C3CR.SYNC_ID, Synchronization input               selected

\ DMAMUX_C4CR (read-write) Reset:$00000000
: DMAMUX_C4CR.DMAREQ_ID ( %bbbbbbbb -- x addr ) DMAMUX_C4CR ; \ DMAMUX_C4CR.DMAREQ_ID, Input DMA request line               selected
: DMAMUX_C4CR.SOIE ( -- x addr ) 8 bit DMAMUX_C4CR ; \ DMAMUX_C4CR.SOIE, Interrupt enable at synchronization               event overrun
: DMAMUX_C4CR.EGE ( -- x addr ) 9 bit DMAMUX_C4CR ; \ DMAMUX_C4CR.EGE, Event generation               enable/disable
: DMAMUX_C4CR.SE ( -- x addr ) 16 bit DMAMUX_C4CR ; \ DMAMUX_C4CR.SE, Synchronous operating mode               enable/disable
: DMAMUX_C4CR.SPOL ( %bb -- x addr ) 17 lshift DMAMUX_C4CR ; \ DMAMUX_C4CR.SPOL, Synchronization event type selector               Defines the synchronization event on the selected               synchronization input:
: DMAMUX_C4CR.NBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX_C4CR ; \ DMAMUX_C4CR.NBREQ, Number of DMA requests to forward               Defines the number of DMA requests forwarded before               output event is generated. In synchronous mode, it               also defines the number of DMA requests to forward               after a synchronization event, then stop forwarding.               The actual number of DMA requests forwarded is               NBREQ+1. Note: This field can only be written when               both SE and EGE bits are reset.
: DMAMUX_C4CR.SYNC_ID ( %bbbbb -- x addr ) 24 lshift DMAMUX_C4CR ; \ DMAMUX_C4CR.SYNC_ID, Synchronization input               selected

\ DMAMUX_C5CR (read-write) Reset:$00000000
: DMAMUX_C5CR.DMAREQ_ID ( %bbbbbbbb -- x addr ) DMAMUX_C5CR ; \ DMAMUX_C5CR.DMAREQ_ID, Input DMA request line               selected
: DMAMUX_C5CR.SOIE ( -- x addr ) 8 bit DMAMUX_C5CR ; \ DMAMUX_C5CR.SOIE, Interrupt enable at synchronization               event overrun
: DMAMUX_C5CR.EGE ( -- x addr ) 9 bit DMAMUX_C5CR ; \ DMAMUX_C5CR.EGE, Event generation               enable/disable
: DMAMUX_C5CR.SE ( -- x addr ) 16 bit DMAMUX_C5CR ; \ DMAMUX_C5CR.SE, Synchronous operating mode               enable/disable
: DMAMUX_C5CR.SPOL ( %bb -- x addr ) 17 lshift DMAMUX_C5CR ; \ DMAMUX_C5CR.SPOL, Synchronization event type selector               Defines the synchronization event on the selected               synchronization input:
: DMAMUX_C5CR.NBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX_C5CR ; \ DMAMUX_C5CR.NBREQ, Number of DMA requests to forward               Defines the number of DMA requests forwarded before               output event is generated. In synchronous mode, it               also defines the number of DMA requests to forward               after a synchronization event, then stop forwarding.               The actual number of DMA requests forwarded is               NBREQ+1. Note: This field can only be written when               both SE and EGE bits are reset.
: DMAMUX_C5CR.SYNC_ID ( %bbbbb -- x addr ) 24 lshift DMAMUX_C5CR ; \ DMAMUX_C5CR.SYNC_ID, Synchronization input               selected

\ DMAMUX_C6CR (read-write) Reset:$00000000
: DMAMUX_C6CR.DMAREQ_ID ( %bbbbbbbb -- x addr ) DMAMUX_C6CR ; \ DMAMUX_C6CR.DMAREQ_ID, Input DMA request line               selected
: DMAMUX_C6CR.SOIE ( -- x addr ) 8 bit DMAMUX_C6CR ; \ DMAMUX_C6CR.SOIE, Interrupt enable at synchronization               event overrun
: DMAMUX_C6CR.EGE ( -- x addr ) 9 bit DMAMUX_C6CR ; \ DMAMUX_C6CR.EGE, Event generation               enable/disable
: DMAMUX_C6CR.SE ( -- x addr ) 16 bit DMAMUX_C6CR ; \ DMAMUX_C6CR.SE, Synchronous operating mode               enable/disable
: DMAMUX_C6CR.SPOL ( %bb -- x addr ) 17 lshift DMAMUX_C6CR ; \ DMAMUX_C6CR.SPOL, Synchronization event type selector               Defines the synchronization event on the selected               synchronization input:
: DMAMUX_C6CR.NBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX_C6CR ; \ DMAMUX_C6CR.NBREQ, Number of DMA requests to forward               Defines the number of DMA requests forwarded before               output event is generated. In synchronous mode, it               also defines the number of DMA requests to forward               after a synchronization event, then stop forwarding.               The actual number of DMA requests forwarded is               NBREQ+1. Note: This field can only be written when               both SE and EGE bits are reset.
: DMAMUX_C6CR.SYNC_ID ( %bbbbb -- x addr ) 24 lshift DMAMUX_C6CR ; \ DMAMUX_C6CR.SYNC_ID, Synchronization input               selected

\ DMAMUX_RG0CR (read-write) Reset:$00000000
: DMAMUX_RG0CR.SIG_ID ( %bbbbb -- x addr ) DMAMUX_RG0CR ; \ DMAMUX_RG0CR.SIG_ID, DMA request trigger input               selected
: DMAMUX_RG0CR.OIE ( -- x addr ) 8 bit DMAMUX_RG0CR ; \ DMAMUX_RG0CR.OIE, Interrupt enable at trigger event               overrun
: DMAMUX_RG0CR.GE ( -- x addr ) 16 bit DMAMUX_RG0CR ; \ DMAMUX_RG0CR.GE, DMA request generator channel               enable/disable
: DMAMUX_RG0CR.GPOL ( %bb -- x addr ) 17 lshift DMAMUX_RG0CR ; \ DMAMUX_RG0CR.GPOL, DMA request generator trigger event type               selection Defines the trigger event on the selected               DMA request trigger input
: DMAMUX_RG0CR.GNBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX_RG0CR ; \ DMAMUX_RG0CR.GNBREQ, Number of DMA requests to generate               Defines the number of DMA requests generated after a               trigger event, then stop generating. The actual               number of generated DMA requests is GNBREQ+1. Note:               This field can only be written when GE bit is               reset.

\ DMAMUX_RG1CR (read-write) Reset:$00000000
: DMAMUX_RG1CR.SIG_ID ( %bbbbb -- x addr ) DMAMUX_RG1CR ; \ DMAMUX_RG1CR.SIG_ID, DMA request trigger input               selected
: DMAMUX_RG1CR.OIE ( -- x addr ) 8 bit DMAMUX_RG1CR ; \ DMAMUX_RG1CR.OIE, Interrupt enable at trigger event               overrun
: DMAMUX_RG1CR.GE ( -- x addr ) 16 bit DMAMUX_RG1CR ; \ DMAMUX_RG1CR.GE, DMA request generator channel               enable/disable
: DMAMUX_RG1CR.GPOL ( %bb -- x addr ) 17 lshift DMAMUX_RG1CR ; \ DMAMUX_RG1CR.GPOL, DMA request generator trigger event type               selection Defines the trigger event on the selected               DMA request trigger input
: DMAMUX_RG1CR.GNBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX_RG1CR ; \ DMAMUX_RG1CR.GNBREQ, Number of DMA requests to generate               Defines the number of DMA requests generated after a               trigger event, then stop generating. The actual               number of generated DMA requests is GNBREQ+1. Note:               This field can only be written when GE bit is               reset.

\ DMAMUX_RG2CR (read-write) Reset:$00000000
: DMAMUX_RG2CR.SIG_ID ( %bbbbb -- x addr ) DMAMUX_RG2CR ; \ DMAMUX_RG2CR.SIG_ID, DMA request trigger input               selected
: DMAMUX_RG2CR.OIE ( -- x addr ) 8 bit DMAMUX_RG2CR ; \ DMAMUX_RG2CR.OIE, Interrupt enable at trigger event               overrun
: DMAMUX_RG2CR.GE ( -- x addr ) 16 bit DMAMUX_RG2CR ; \ DMAMUX_RG2CR.GE, DMA request generator channel               enable/disable
: DMAMUX_RG2CR.GPOL ( %bb -- x addr ) 17 lshift DMAMUX_RG2CR ; \ DMAMUX_RG2CR.GPOL, DMA request generator trigger event type               selection Defines the trigger event on the selected               DMA request trigger input
: DMAMUX_RG2CR.GNBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX_RG2CR ; \ DMAMUX_RG2CR.GNBREQ, Number of DMA requests to generate               Defines the number of DMA requests generated after a               trigger event, then stop generating. The actual               number of generated DMA requests is GNBREQ+1. Note:               This field can only be written when GE bit is               reset.

\ DMAMUX_RG3CR (read-write) Reset:$00000000
: DMAMUX_RG3CR.SIG_ID ( %bbbbb -- x addr ) DMAMUX_RG3CR ; \ DMAMUX_RG3CR.SIG_ID, DMA request trigger input               selected
: DMAMUX_RG3CR.OIE ( -- x addr ) 8 bit DMAMUX_RG3CR ; \ DMAMUX_RG3CR.OIE, Interrupt enable at trigger event               overrun
: DMAMUX_RG3CR.GE ( -- x addr ) 16 bit DMAMUX_RG3CR ; \ DMAMUX_RG3CR.GE, DMA request generator channel               enable/disable
: DMAMUX_RG3CR.GPOL ( %bb -- x addr ) 17 lshift DMAMUX_RG3CR ; \ DMAMUX_RG3CR.GPOL, DMA request generator trigger event type               selection Defines the trigger event on the selected               DMA request trigger input
: DMAMUX_RG3CR.GNBREQ ( %bbbbb -- x addr ) 19 lshift DMAMUX_RG3CR ; \ DMAMUX_RG3CR.GNBREQ, Number of DMA requests to generate               Defines the number of DMA requests generated after a               trigger event, then stop generating. The actual               number of generated DMA requests is GNBREQ+1. Note:               This field can only be written when GE bit is               reset.

\ DMAMUX_RGSR (read-only) Reset:$00000000
: DMAMUX_RGSR.OF? ( --  x ) DMAMUX_RGSR @ ; \ DMAMUX_RGSR.OF, Trigger event overrun flag The flag is               set when a trigger event occurs on DMA request               generator channel x, while the DMA request generator               counter value is lower than GNBREQ. The flag is               cleared by writing 1 to the corresponding COFx bit in               DMAMUX_RGCFR register.

\ DMAMUX_RGCFR (write-only) Reset:$00000000
: DMAMUX_RGCFR.COF ( %bbbb -- x addr ) DMAMUX_RGCFR ; \ DMAMUX_RGCFR.COF, Clear trigger event overrun flag Upon               setting, this bit clears the corresponding overrun               flag OFx in the DMAMUX_RGCSR register.

\ GPIOA_MODER (read-write) Reset:$EBFFFFFF
: GPIOA_MODER.MODER15 ( %bb -- x addr ) 30 lshift GPIOA_MODER ; \ GPIOA_MODER.MODER15, Port x configuration bits (y =               0..15)
: GPIOA_MODER.MODER14 ( %bb -- x addr ) 28 lshift GPIOA_MODER ; \ GPIOA_MODER.MODER14, Port x configuration bits (y =               0..15)
: GPIOA_MODER.MODER13 ( %bb -- x addr ) 26 lshift GPIOA_MODER ; \ GPIOA_MODER.MODER13, Port x configuration bits (y =               0..15)
: GPIOA_MODER.MODER12 ( %bb -- x addr ) 24 lshift GPIOA_MODER ; \ GPIOA_MODER.MODER12, Port x configuration bits (y =               0..15)
: GPIOA_MODER.MODER11 ( %bb -- x addr ) 22 lshift GPIOA_MODER ; \ GPIOA_MODER.MODER11, Port x configuration bits (y =               0..15)
: GPIOA_MODER.MODER10 ( %bb -- x addr ) 20 lshift GPIOA_MODER ; \ GPIOA_MODER.MODER10, Port x configuration bits (y =               0..15)
: GPIOA_MODER.MODER9 ( %bb -- x addr ) 18 lshift GPIOA_MODER ; \ GPIOA_MODER.MODER9, Port x configuration bits (y =               0..15)
: GPIOA_MODER.MODER8 ( %bb -- x addr ) 16 lshift GPIOA_MODER ; \ GPIOA_MODER.MODER8, Port x configuration bits (y =               0..15)
: GPIOA_MODER.MODER7 ( %bb -- x addr ) 14 lshift GPIOA_MODER ; \ GPIOA_MODER.MODER7, Port x configuration bits (y =               0..15)
: GPIOA_MODER.MODER6 ( %bb -- x addr ) 12 lshift GPIOA_MODER ; \ GPIOA_MODER.MODER6, Port x configuration bits (y =               0..15)
: GPIOA_MODER.MODER5 ( %bb -- x addr ) 10 lshift GPIOA_MODER ; \ GPIOA_MODER.MODER5, Port x configuration bits (y =               0..15)
: GPIOA_MODER.MODER4 ( %bb -- x addr ) 8 lshift GPIOA_MODER ; \ GPIOA_MODER.MODER4, Port x configuration bits (y =               0..15)
: GPIOA_MODER.MODER3 ( %bb -- x addr ) 6 lshift GPIOA_MODER ; \ GPIOA_MODER.MODER3, Port x configuration bits (y =               0..15)
: GPIOA_MODER.MODER2 ( %bb -- x addr ) 4 lshift GPIOA_MODER ; \ GPIOA_MODER.MODER2, Port x configuration bits (y =               0..15)
: GPIOA_MODER.MODER1 ( %bb -- x addr ) 2 lshift GPIOA_MODER ; \ GPIOA_MODER.MODER1, Port x configuration bits (y =               0..15)
: GPIOA_MODER.MODER0 ( %bb -- x addr ) GPIOA_MODER ; \ GPIOA_MODER.MODER0, Port x configuration bits (y =               0..15)

\ GPIOA_OTYPER (read-write) Reset:$00000000
: GPIOA_OTYPER.OT15 ( -- x addr ) 15 bit GPIOA_OTYPER ; \ GPIOA_OTYPER.OT15, Port x configuration bits (y =               0..15)
: GPIOA_OTYPER.OT14 ( -- x addr ) 14 bit GPIOA_OTYPER ; \ GPIOA_OTYPER.OT14, Port x configuration bits (y =               0..15)
: GPIOA_OTYPER.OT13 ( -- x addr ) 13 bit GPIOA_OTYPER ; \ GPIOA_OTYPER.OT13, Port x configuration bits (y =               0..15)
: GPIOA_OTYPER.OT12 ( -- x addr ) 12 bit GPIOA_OTYPER ; \ GPIOA_OTYPER.OT12, Port x configuration bits (y =               0..15)
: GPIOA_OTYPER.OT11 ( -- x addr ) 11 bit GPIOA_OTYPER ; \ GPIOA_OTYPER.OT11, Port x configuration bits (y =               0..15)
: GPIOA_OTYPER.OT10 ( -- x addr ) 10 bit GPIOA_OTYPER ; \ GPIOA_OTYPER.OT10, Port x configuration bits (y =               0..15)
: GPIOA_OTYPER.OT9 ( -- x addr ) 9 bit GPIOA_OTYPER ; \ GPIOA_OTYPER.OT9, Port x configuration bits (y =               0..15)
: GPIOA_OTYPER.OT8 ( -- x addr ) 8 bit GPIOA_OTYPER ; \ GPIOA_OTYPER.OT8, Port x configuration bits (y =               0..15)
: GPIOA_OTYPER.OT7 ( -- x addr ) 7 bit GPIOA_OTYPER ; \ GPIOA_OTYPER.OT7, Port x configuration bits (y =               0..15)
: GPIOA_OTYPER.OT6 ( -- x addr ) 6 bit GPIOA_OTYPER ; \ GPIOA_OTYPER.OT6, Port x configuration bits (y =               0..15)
: GPIOA_OTYPER.OT5 ( -- x addr ) 5 bit GPIOA_OTYPER ; \ GPIOA_OTYPER.OT5, Port x configuration bits (y =               0..15)
: GPIOA_OTYPER.OT4 ( -- x addr ) 4 bit GPIOA_OTYPER ; \ GPIOA_OTYPER.OT4, Port x configuration bits (y =               0..15)
: GPIOA_OTYPER.OT3 ( -- x addr ) 3 bit GPIOA_OTYPER ; \ GPIOA_OTYPER.OT3, Port x configuration bits (y =               0..15)
: GPIOA_OTYPER.OT2 ( -- x addr ) 2 bit GPIOA_OTYPER ; \ GPIOA_OTYPER.OT2, Port x configuration bits (y =               0..15)
: GPIOA_OTYPER.OT1 ( -- x addr ) 1 bit GPIOA_OTYPER ; \ GPIOA_OTYPER.OT1, Port x configuration bits (y =               0..15)
: GPIOA_OTYPER.OT0 ( -- x addr ) 0 bit GPIOA_OTYPER ; \ GPIOA_OTYPER.OT0, Port x configuration bits (y =               0..15)

\ GPIOA_OSPEEDR (read-write) Reset:$0C000000
: GPIOA_OSPEEDR.OSPEEDR15 ( %bb -- x addr ) 30 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR.OSPEEDR15, Port x configuration bits (y =               0..15)
: GPIOA_OSPEEDR.OSPEEDR14 ( %bb -- x addr ) 28 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR.OSPEEDR14, Port x configuration bits (y =               0..15)
: GPIOA_OSPEEDR.OSPEEDR13 ( %bb -- x addr ) 26 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR.OSPEEDR13, Port x configuration bits (y =               0..15)
: GPIOA_OSPEEDR.OSPEEDR12 ( %bb -- x addr ) 24 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR.OSPEEDR12, Port x configuration bits (y =               0..15)
: GPIOA_OSPEEDR.OSPEEDR11 ( %bb -- x addr ) 22 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR.OSPEEDR11, Port x configuration bits (y =               0..15)
: GPIOA_OSPEEDR.OSPEEDR10 ( %bb -- x addr ) 20 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR.OSPEEDR10, Port x configuration bits (y =               0..15)
: GPIOA_OSPEEDR.OSPEEDR9 ( %bb -- x addr ) 18 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR.OSPEEDR9, Port x configuration bits (y =               0..15)
: GPIOA_OSPEEDR.OSPEEDR8 ( %bb -- x addr ) 16 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR.OSPEEDR8, Port x configuration bits (y =               0..15)
: GPIOA_OSPEEDR.OSPEEDR7 ( %bb -- x addr ) 14 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR.OSPEEDR7, Port x configuration bits (y =               0..15)
: GPIOA_OSPEEDR.OSPEEDR6 ( %bb -- x addr ) 12 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR.OSPEEDR6, Port x configuration bits (y =               0..15)
: GPIOA_OSPEEDR.OSPEEDR5 ( %bb -- x addr ) 10 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR.OSPEEDR5, Port x configuration bits (y =               0..15)
: GPIOA_OSPEEDR.OSPEEDR4 ( %bb -- x addr ) 8 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR.OSPEEDR4, Port x configuration bits (y =               0..15)
: GPIOA_OSPEEDR.OSPEEDR3 ( %bb -- x addr ) 6 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR.OSPEEDR3, Port x configuration bits (y =               0..15)
: GPIOA_OSPEEDR.OSPEEDR2 ( %bb -- x addr ) 4 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR.OSPEEDR2, Port x configuration bits (y =               0..15)
: GPIOA_OSPEEDR.OSPEEDR1 ( %bb -- x addr ) 2 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR.OSPEEDR1, Port x configuration bits (y =               0..15)
: GPIOA_OSPEEDR.OSPEEDR0 ( %bb -- x addr ) GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR.OSPEEDR0, Port x configuration bits (y =               0..15)

\ GPIOA_PUPDR (read-write) Reset:$24000000
: GPIOA_PUPDR.PUPDR15 ( %bb -- x addr ) 30 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR.PUPDR15, Port x configuration bits (y =               0..15)
: GPIOA_PUPDR.PUPDR14 ( %bb -- x addr ) 28 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR.PUPDR14, Port x configuration bits (y =               0..15)
: GPIOA_PUPDR.PUPDR13 ( %bb -- x addr ) 26 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR.PUPDR13, Port x configuration bits (y =               0..15)
: GPIOA_PUPDR.PUPDR12 ( %bb -- x addr ) 24 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR.PUPDR12, Port x configuration bits (y =               0..15)
: GPIOA_PUPDR.PUPDR11 ( %bb -- x addr ) 22 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR.PUPDR11, Port x configuration bits (y =               0..15)
: GPIOA_PUPDR.PUPDR10 ( %bb -- x addr ) 20 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR.PUPDR10, Port x configuration bits (y =               0..15)
: GPIOA_PUPDR.PUPDR9 ( %bb -- x addr ) 18 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR.PUPDR9, Port x configuration bits (y =               0..15)
: GPIOA_PUPDR.PUPDR8 ( %bb -- x addr ) 16 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR.PUPDR8, Port x configuration bits (y =               0..15)
: GPIOA_PUPDR.PUPDR7 ( %bb -- x addr ) 14 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR.PUPDR7, Port x configuration bits (y =               0..15)
: GPIOA_PUPDR.PUPDR6 ( %bb -- x addr ) 12 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR.PUPDR6, Port x configuration bits (y =               0..15)
: GPIOA_PUPDR.PUPDR5 ( %bb -- x addr ) 10 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR.PUPDR5, Port x configuration bits (y =               0..15)
: GPIOA_PUPDR.PUPDR4 ( %bb -- x addr ) 8 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR.PUPDR4, Port x configuration bits (y =               0..15)
: GPIOA_PUPDR.PUPDR3 ( %bb -- x addr ) 6 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR.PUPDR3, Port x configuration bits (y =               0..15)
: GPIOA_PUPDR.PUPDR2 ( %bb -- x addr ) 4 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR.PUPDR2, Port x configuration bits (y =               0..15)
: GPIOA_PUPDR.PUPDR1 ( %bb -- x addr ) 2 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR.PUPDR1, Port x configuration bits (y =               0..15)
: GPIOA_PUPDR.PUPDR0 ( %bb -- x addr ) GPIOA_PUPDR ; \ GPIOA_PUPDR.PUPDR0, Port x configuration bits (y =               0..15)

\ GPIOA_IDR (read-only) Reset:$00000000
: GPIOA_IDR.IDR15? ( --  1|0 ) 15 bit GPIOA_IDR bit@ ; \ GPIOA_IDR.IDR15, Port input data (y =               0..15)
: GPIOA_IDR.IDR14? ( --  1|0 ) 14 bit GPIOA_IDR bit@ ; \ GPIOA_IDR.IDR14, Port input data (y =               0..15)
: GPIOA_IDR.IDR13? ( --  1|0 ) 13 bit GPIOA_IDR bit@ ; \ GPIOA_IDR.IDR13, Port input data (y =               0..15)
: GPIOA_IDR.IDR12? ( --  1|0 ) 12 bit GPIOA_IDR bit@ ; \ GPIOA_IDR.IDR12, Port input data (y =               0..15)
: GPIOA_IDR.IDR11? ( --  1|0 ) 11 bit GPIOA_IDR bit@ ; \ GPIOA_IDR.IDR11, Port input data (y =               0..15)
: GPIOA_IDR.IDR10? ( --  1|0 ) 10 bit GPIOA_IDR bit@ ; \ GPIOA_IDR.IDR10, Port input data (y =               0..15)
: GPIOA_IDR.IDR9? ( --  1|0 ) 9 bit GPIOA_IDR bit@ ; \ GPIOA_IDR.IDR9, Port input data (y =               0..15)
: GPIOA_IDR.IDR8? ( --  1|0 ) 8 bit GPIOA_IDR bit@ ; \ GPIOA_IDR.IDR8, Port input data (y =               0..15)
: GPIOA_IDR.IDR7? ( --  1|0 ) 7 bit GPIOA_IDR bit@ ; \ GPIOA_IDR.IDR7, Port input data (y =               0..15)
: GPIOA_IDR.IDR6? ( --  1|0 ) 6 bit GPIOA_IDR bit@ ; \ GPIOA_IDR.IDR6, Port input data (y =               0..15)
: GPIOA_IDR.IDR5? ( --  1|0 ) 5 bit GPIOA_IDR bit@ ; \ GPIOA_IDR.IDR5, Port input data (y =               0..15)
: GPIOA_IDR.IDR4? ( --  1|0 ) 4 bit GPIOA_IDR bit@ ; \ GPIOA_IDR.IDR4, Port input data (y =               0..15)
: GPIOA_IDR.IDR3? ( --  1|0 ) 3 bit GPIOA_IDR bit@ ; \ GPIOA_IDR.IDR3, Port input data (y =               0..15)
: GPIOA_IDR.IDR2? ( --  1|0 ) 2 bit GPIOA_IDR bit@ ; \ GPIOA_IDR.IDR2, Port input data (y =               0..15)
: GPIOA_IDR.IDR1? ( --  1|0 ) 1 bit GPIOA_IDR bit@ ; \ GPIOA_IDR.IDR1, Port input data (y =               0..15)
: GPIOA_IDR.IDR0? ( --  1|0 ) 0 bit GPIOA_IDR bit@ ; \ GPIOA_IDR.IDR0, Port input data (y =               0..15)

\ GPIOA_ODR (read-write) Reset:$00000000
: GPIOA_ODR.ODR15 ( -- x addr ) 15 bit GPIOA_ODR ; \ GPIOA_ODR.ODR15, Port output data (y =               0..15)
: GPIOA_ODR.ODR14 ( -- x addr ) 14 bit GPIOA_ODR ; \ GPIOA_ODR.ODR14, Port output data (y =               0..15)
: GPIOA_ODR.ODR13 ( -- x addr ) 13 bit GPIOA_ODR ; \ GPIOA_ODR.ODR13, Port output data (y =               0..15)
: GPIOA_ODR.ODR12 ( -- x addr ) 12 bit GPIOA_ODR ; \ GPIOA_ODR.ODR12, Port output data (y =               0..15)
: GPIOA_ODR.ODR11 ( -- x addr ) 11 bit GPIOA_ODR ; \ GPIOA_ODR.ODR11, Port output data (y =               0..15)
: GPIOA_ODR.ODR10 ( -- x addr ) 10 bit GPIOA_ODR ; \ GPIOA_ODR.ODR10, Port output data (y =               0..15)
: GPIOA_ODR.ODR9 ( -- x addr ) 9 bit GPIOA_ODR ; \ GPIOA_ODR.ODR9, Port output data (y =               0..15)
: GPIOA_ODR.ODR8 ( -- x addr ) 8 bit GPIOA_ODR ; \ GPIOA_ODR.ODR8, Port output data (y =               0..15)
: GPIOA_ODR.ODR7 ( -- x addr ) 7 bit GPIOA_ODR ; \ GPIOA_ODR.ODR7, Port output data (y =               0..15)
: GPIOA_ODR.ODR6 ( -- x addr ) 6 bit GPIOA_ODR ; \ GPIOA_ODR.ODR6, Port output data (y =               0..15)
: GPIOA_ODR.ODR5 ( -- x addr ) 5 bit GPIOA_ODR ; \ GPIOA_ODR.ODR5, Port output data (y =               0..15)
: GPIOA_ODR.ODR4 ( -- x addr ) 4 bit GPIOA_ODR ; \ GPIOA_ODR.ODR4, Port output data (y =               0..15)
: GPIOA_ODR.ODR3 ( -- x addr ) 3 bit GPIOA_ODR ; \ GPIOA_ODR.ODR3, Port output data (y =               0..15)
: GPIOA_ODR.ODR2 ( -- x addr ) 2 bit GPIOA_ODR ; \ GPIOA_ODR.ODR2, Port output data (y =               0..15)
: GPIOA_ODR.ODR1 ( -- x addr ) 1 bit GPIOA_ODR ; \ GPIOA_ODR.ODR1, Port output data (y =               0..15)
: GPIOA_ODR.ODR0 ( -- x addr ) 0 bit GPIOA_ODR ; \ GPIOA_ODR.ODR0, Port output data (y =               0..15)

\ GPIOA_BSRR (write-only) Reset:$00000000
: GPIOA_BSRR.BR15 ( -- ) 31 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BR15, Port x reset bit y (y =               0..15)
: GPIOA_BSRR.BR14 ( -- ) 30 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BR14, Port x reset bit y (y =               0..15)
: GPIOA_BSRR.BR13 ( -- ) 29 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BR13, Port x reset bit y (y =               0..15)
: GPIOA_BSRR.BR12 ( -- ) 28 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BR12, Port x reset bit y (y =               0..15)
: GPIOA_BSRR.BR11 ( -- ) 27 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BR11, Port x reset bit y (y =               0..15)
: GPIOA_BSRR.BR10 ( -- ) 26 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BR10, Port x reset bit y (y =               0..15)
: GPIOA_BSRR.BR9 ( -- ) 25 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BR9, Port x reset bit y (y =               0..15)
: GPIOA_BSRR.BR8 ( -- ) 24 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BR8, Port x reset bit y (y =               0..15)
: GPIOA_BSRR.BR7 ( -- ) 23 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BR7, Port x reset bit y (y =               0..15)
: GPIOA_BSRR.BR6 ( -- ) 22 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BR6, Port x reset bit y (y =               0..15)
: GPIOA_BSRR.BR5 ( -- ) 21 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BR5, Port x reset bit y (y =               0..15)
: GPIOA_BSRR.BR4 ( -- ) 20 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BR4, Port x reset bit y (y =               0..15)
: GPIOA_BSRR.BR3 ( -- ) 19 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BR3, Port x reset bit y (y =               0..15)
: GPIOA_BSRR.BR2 ( -- ) 18 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BR2, Port x reset bit y (y =               0..15)
: GPIOA_BSRR.BR1 ( -- ) 17 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BR1, Port x reset bit y (y =               0..15)
: GPIOA_BSRR.BR0 ( -- ) 16 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BR0, Port x set bit y (y=               0..15)
: GPIOA_BSRR.BS15 ( -- ) 15 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BS15, Port x set bit y (y=               0..15)
: GPIOA_BSRR.BS14 ( -- ) 14 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BS14, Port x set bit y (y=               0..15)
: GPIOA_BSRR.BS13 ( -- ) 13 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BS13, Port x set bit y (y=               0..15)
: GPIOA_BSRR.BS12 ( -- ) 12 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BS12, Port x set bit y (y=               0..15)
: GPIOA_BSRR.BS11 ( -- ) 11 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BS11, Port x set bit y (y=               0..15)
: GPIOA_BSRR.BS10 ( -- ) 10 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BS10, Port x set bit y (y=               0..15)
: GPIOA_BSRR.BS9 ( -- ) 9 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BS9, Port x set bit y (y=               0..15)
: GPIOA_BSRR.BS8 ( -- ) 8 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BS8, Port x set bit y (y=               0..15)
: GPIOA_BSRR.BS7 ( -- ) 7 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BS7, Port x set bit y (y=               0..15)
: GPIOA_BSRR.BS6 ( -- ) 6 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BS6, Port x set bit y (y=               0..15)
: GPIOA_BSRR.BS5 ( -- ) 5 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BS5, Port x set bit y (y=               0..15)
: GPIOA_BSRR.BS4 ( -- ) 4 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BS4, Port x set bit y (y=               0..15)
: GPIOA_BSRR.BS3 ( -- ) 3 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BS3, Port x set bit y (y=               0..15)
: GPIOA_BSRR.BS2 ( -- ) 2 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BS2, Port x set bit y (y=               0..15)
: GPIOA_BSRR.BS1 ( -- ) 1 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BS1, Port x set bit y (y=               0..15)
: GPIOA_BSRR.BS0 ( -- ) 0 bit GPIOA_BSRR ! ; \ GPIOA_BSRR.BS0, Port x set bit y (y=               0..15)

\ GPIOA_LCKR (read-write) Reset:$00000000
: GPIOA_LCKR.LCKK ( -- x addr ) 16 bit GPIOA_LCKR ; \ GPIOA_LCKR.LCKK, Port x lock bit y (y=               0..15)
: GPIOA_LCKR.LCK15 ( -- x addr ) 15 bit GPIOA_LCKR ; \ GPIOA_LCKR.LCK15, Port x lock bit y (y=               0..15)
: GPIOA_LCKR.LCK14 ( -- x addr ) 14 bit GPIOA_LCKR ; \ GPIOA_LCKR.LCK14, Port x lock bit y (y=               0..15)
: GPIOA_LCKR.LCK13 ( -- x addr ) 13 bit GPIOA_LCKR ; \ GPIOA_LCKR.LCK13, Port x lock bit y (y=               0..15)
: GPIOA_LCKR.LCK12 ( -- x addr ) 12 bit GPIOA_LCKR ; \ GPIOA_LCKR.LCK12, Port x lock bit y (y=               0..15)
: GPIOA_LCKR.LCK11 ( -- x addr ) 11 bit GPIOA_LCKR ; \ GPIOA_LCKR.LCK11, Port x lock bit y (y=               0..15)
: GPIOA_LCKR.LCK10 ( -- x addr ) 10 bit GPIOA_LCKR ; \ GPIOA_LCKR.LCK10, Port x lock bit y (y=               0..15)
: GPIOA_LCKR.LCK9 ( -- x addr ) 9 bit GPIOA_LCKR ; \ GPIOA_LCKR.LCK9, Port x lock bit y (y=               0..15)
: GPIOA_LCKR.LCK8 ( -- x addr ) 8 bit GPIOA_LCKR ; \ GPIOA_LCKR.LCK8, Port x lock bit y (y=               0..15)
: GPIOA_LCKR.LCK7 ( -- x addr ) 7 bit GPIOA_LCKR ; \ GPIOA_LCKR.LCK7, Port x lock bit y (y=               0..15)
: GPIOA_LCKR.LCK6 ( -- x addr ) 6 bit GPIOA_LCKR ; \ GPIOA_LCKR.LCK6, Port x lock bit y (y=               0..15)
: GPIOA_LCKR.LCK5 ( -- x addr ) 5 bit GPIOA_LCKR ; \ GPIOA_LCKR.LCK5, Port x lock bit y (y=               0..15)
: GPIOA_LCKR.LCK4 ( -- x addr ) 4 bit GPIOA_LCKR ; \ GPIOA_LCKR.LCK4, Port x lock bit y (y=               0..15)
: GPIOA_LCKR.LCK3 ( -- x addr ) 3 bit GPIOA_LCKR ; \ GPIOA_LCKR.LCK3, Port x lock bit y (y=               0..15)
: GPIOA_LCKR.LCK2 ( -- x addr ) 2 bit GPIOA_LCKR ; \ GPIOA_LCKR.LCK2, Port x lock bit y (y=               0..15)
: GPIOA_LCKR.LCK1 ( -- x addr ) 1 bit GPIOA_LCKR ; \ GPIOA_LCKR.LCK1, Port x lock bit y (y=               0..15)
: GPIOA_LCKR.LCK0 ( -- x addr ) 0 bit GPIOA_LCKR ; \ GPIOA_LCKR.LCK0, Port x lock bit y (y=               0..15)

\ GPIOA_AFRL (read-write) Reset:$00000000
: GPIOA_AFRL.AFSEL7 ( %bbbb -- x addr ) 28 lshift GPIOA_AFRL ; \ GPIOA_AFRL.AFSEL7, Alternate function selection for port x               bit y (y = 0..7)
: GPIOA_AFRL.AFSEL6 ( %bbbb -- x addr ) 24 lshift GPIOA_AFRL ; \ GPIOA_AFRL.AFSEL6, Alternate function selection for port x               bit y (y = 0..7)
: GPIOA_AFRL.AFSEL5 ( %bbbb -- x addr ) 20 lshift GPIOA_AFRL ; \ GPIOA_AFRL.AFSEL5, Alternate function selection for port x               bit y (y = 0..7)
: GPIOA_AFRL.AFSEL4 ( %bbbb -- x addr ) 16 lshift GPIOA_AFRL ; \ GPIOA_AFRL.AFSEL4, Alternate function selection for port x               bit y (y = 0..7)
: GPIOA_AFRL.AFSEL3 ( %bbbb -- x addr ) 12 lshift GPIOA_AFRL ; \ GPIOA_AFRL.AFSEL3, Alternate function selection for port x               bit y (y = 0..7)
: GPIOA_AFRL.AFSEL2 ( %bbbb -- x addr ) 8 lshift GPIOA_AFRL ; \ GPIOA_AFRL.AFSEL2, Alternate function selection for port x               bit y (y = 0..7)
: GPIOA_AFRL.AFSEL1 ( %bbbb -- x addr ) 4 lshift GPIOA_AFRL ; \ GPIOA_AFRL.AFSEL1, Alternate function selection for port x               bit y (y = 0..7)
: GPIOA_AFRL.AFSEL0 ( %bbbb -- x addr ) GPIOA_AFRL ; \ GPIOA_AFRL.AFSEL0, Alternate function selection for port x               bit y (y = 0..7)

\ GPIOA_AFRH (read-write) Reset:$00000000
: GPIOA_AFRH.AFSEL15 ( %bbbb -- x addr ) 28 lshift GPIOA_AFRH ; \ GPIOA_AFRH.AFSEL15, Alternate function selection for port x               bit y (y = 8..15)
: GPIOA_AFRH.AFSEL14 ( %bbbb -- x addr ) 24 lshift GPIOA_AFRH ; \ GPIOA_AFRH.AFSEL14, Alternate function selection for port x               bit y (y = 8..15)
: GPIOA_AFRH.AFSEL13 ( %bbbb -- x addr ) 20 lshift GPIOA_AFRH ; \ GPIOA_AFRH.AFSEL13, Alternate function selection for port x               bit y (y = 8..15)
: GPIOA_AFRH.AFSEL12 ( %bbbb -- x addr ) 16 lshift GPIOA_AFRH ; \ GPIOA_AFRH.AFSEL12, Alternate function selection for port x               bit y (y = 8..15)
: GPIOA_AFRH.AFSEL11 ( %bbbb -- x addr ) 12 lshift GPIOA_AFRH ; \ GPIOA_AFRH.AFSEL11, Alternate function selection for port x               bit y (y = 8..15)
: GPIOA_AFRH.AFSEL10 ( %bbbb -- x addr ) 8 lshift GPIOA_AFRH ; \ GPIOA_AFRH.AFSEL10, Alternate function selection for port x               bit y (y = 8..15)
: GPIOA_AFRH.AFSEL9 ( %bbbb -- x addr ) 4 lshift GPIOA_AFRH ; \ GPIOA_AFRH.AFSEL9, Alternate function selection for port x               bit y (y = 8..15)
: GPIOA_AFRH.AFSEL8 ( %bbbb -- x addr ) GPIOA_AFRH ; \ GPIOA_AFRH.AFSEL8, Alternate function selection for port x               bit y (y = 8..15)

\ GPIOA_BRR (write-only) Reset:$00000000
: GPIOA_BRR.BR0 ( -- ) 0 bit GPIOA_BRR ! ; \ GPIOA_BRR.BR0, Port Reset bit
: GPIOA_BRR.BR1 ( -- ) 1 bit GPIOA_BRR ! ; \ GPIOA_BRR.BR1, Port Reset bit
: GPIOA_BRR.BR2 ( -- ) 2 bit GPIOA_BRR ! ; \ GPIOA_BRR.BR2, Port Reset bit
: GPIOA_BRR.BR3 ( -- ) 3 bit GPIOA_BRR ! ; \ GPIOA_BRR.BR3, Port Reset bit
: GPIOA_BRR.BR4 ( -- ) 4 bit GPIOA_BRR ! ; \ GPIOA_BRR.BR4, Port Reset bit
: GPIOA_BRR.BR5 ( -- ) 5 bit GPIOA_BRR ! ; \ GPIOA_BRR.BR5, Port Reset bit
: GPIOA_BRR.BR6 ( -- ) 6 bit GPIOA_BRR ! ; \ GPIOA_BRR.BR6, Port Reset bit
: GPIOA_BRR.BR7 ( -- ) 7 bit GPIOA_BRR ! ; \ GPIOA_BRR.BR7, Port Reset bit
: GPIOA_BRR.BR8 ( -- ) 8 bit GPIOA_BRR ! ; \ GPIOA_BRR.BR8, Port Reset bit
: GPIOA_BRR.BR9 ( -- ) 9 bit GPIOA_BRR ! ; \ GPIOA_BRR.BR9, Port Reset bit
: GPIOA_BRR.BR10 ( -- ) 10 bit GPIOA_BRR ! ; \ GPIOA_BRR.BR10, Port Reset bit
: GPIOA_BRR.BR11 ( -- ) 11 bit GPIOA_BRR ! ; \ GPIOA_BRR.BR11, Port Reset bit
: GPIOA_BRR.BR12 ( -- ) 12 bit GPIOA_BRR ! ; \ GPIOA_BRR.BR12, Port Reset bit
: GPIOA_BRR.BR13 ( -- ) 13 bit GPIOA_BRR ! ; \ GPIOA_BRR.BR13, Port Reset bit
: GPIOA_BRR.BR14 ( -- ) 14 bit GPIOA_BRR ! ; \ GPIOA_BRR.BR14, Port Reset bit
: GPIOA_BRR.BR15 ( -- ) 15 bit GPIOA_BRR ! ; \ GPIOA_BRR.BR15, Port Reset bit

\ GPIOB_MODER (read-write) Reset:$FFFFFFFF
: GPIOB_MODER.MODER15 ( %bb -- x addr ) 30 lshift GPIOB_MODER ; \ GPIOB_MODER.MODER15, Port x configuration bits (y =               0..15)
: GPIOB_MODER.MODER14 ( %bb -- x addr ) 28 lshift GPIOB_MODER ; \ GPIOB_MODER.MODER14, Port x configuration bits (y =               0..15)
: GPIOB_MODER.MODER13 ( %bb -- x addr ) 26 lshift GPIOB_MODER ; \ GPIOB_MODER.MODER13, Port x configuration bits (y =               0..15)
: GPIOB_MODER.MODER12 ( %bb -- x addr ) 24 lshift GPIOB_MODER ; \ GPIOB_MODER.MODER12, Port x configuration bits (y =               0..15)
: GPIOB_MODER.MODER11 ( %bb -- x addr ) 22 lshift GPIOB_MODER ; \ GPIOB_MODER.MODER11, Port x configuration bits (y =               0..15)
: GPIOB_MODER.MODER10 ( %bb -- x addr ) 20 lshift GPIOB_MODER ; \ GPIOB_MODER.MODER10, Port x configuration bits (y =               0..15)
: GPIOB_MODER.MODER9 ( %bb -- x addr ) 18 lshift GPIOB_MODER ; \ GPIOB_MODER.MODER9, Port x configuration bits (y =               0..15)
: GPIOB_MODER.MODER8 ( %bb -- x addr ) 16 lshift GPIOB_MODER ; \ GPIOB_MODER.MODER8, Port x configuration bits (y =               0..15)
: GPIOB_MODER.MODER7 ( %bb -- x addr ) 14 lshift GPIOB_MODER ; \ GPIOB_MODER.MODER7, Port x configuration bits (y =               0..15)
: GPIOB_MODER.MODER6 ( %bb -- x addr ) 12 lshift GPIOB_MODER ; \ GPIOB_MODER.MODER6, Port x configuration bits (y =               0..15)
: GPIOB_MODER.MODER5 ( %bb -- x addr ) 10 lshift GPIOB_MODER ; \ GPIOB_MODER.MODER5, Port x configuration bits (y =               0..15)
: GPIOB_MODER.MODER4 ( %bb -- x addr ) 8 lshift GPIOB_MODER ; \ GPIOB_MODER.MODER4, Port x configuration bits (y =               0..15)
: GPIOB_MODER.MODER3 ( %bb -- x addr ) 6 lshift GPIOB_MODER ; \ GPIOB_MODER.MODER3, Port x configuration bits (y =               0..15)
: GPIOB_MODER.MODER2 ( %bb -- x addr ) 4 lshift GPIOB_MODER ; \ GPIOB_MODER.MODER2, Port x configuration bits (y =               0..15)
: GPIOB_MODER.MODER1 ( %bb -- x addr ) 2 lshift GPIOB_MODER ; \ GPIOB_MODER.MODER1, Port x configuration bits (y =               0..15)
: GPIOB_MODER.MODER0 ( %bb -- x addr ) GPIOB_MODER ; \ GPIOB_MODER.MODER0, Port x configuration bits (y =               0..15)

\ GPIOB_OTYPER (read-write) Reset:$00000000
: GPIOB_OTYPER.OT15 ( -- x addr ) 15 bit GPIOB_OTYPER ; \ GPIOB_OTYPER.OT15, Port x configuration bits (y =               0..15)
: GPIOB_OTYPER.OT14 ( -- x addr ) 14 bit GPIOB_OTYPER ; \ GPIOB_OTYPER.OT14, Port x configuration bits (y =               0..15)
: GPIOB_OTYPER.OT13 ( -- x addr ) 13 bit GPIOB_OTYPER ; \ GPIOB_OTYPER.OT13, Port x configuration bits (y =               0..15)
: GPIOB_OTYPER.OT12 ( -- x addr ) 12 bit GPIOB_OTYPER ; \ GPIOB_OTYPER.OT12, Port x configuration bits (y =               0..15)
: GPIOB_OTYPER.OT11 ( -- x addr ) 11 bit GPIOB_OTYPER ; \ GPIOB_OTYPER.OT11, Port x configuration bits (y =               0..15)
: GPIOB_OTYPER.OT10 ( -- x addr ) 10 bit GPIOB_OTYPER ; \ GPIOB_OTYPER.OT10, Port x configuration bits (y =               0..15)
: GPIOB_OTYPER.OT9 ( -- x addr ) 9 bit GPIOB_OTYPER ; \ GPIOB_OTYPER.OT9, Port x configuration bits (y =               0..15)
: GPIOB_OTYPER.OT8 ( -- x addr ) 8 bit GPIOB_OTYPER ; \ GPIOB_OTYPER.OT8, Port x configuration bits (y =               0..15)
: GPIOB_OTYPER.OT7 ( -- x addr ) 7 bit GPIOB_OTYPER ; \ GPIOB_OTYPER.OT7, Port x configuration bits (y =               0..15)
: GPIOB_OTYPER.OT6 ( -- x addr ) 6 bit GPIOB_OTYPER ; \ GPIOB_OTYPER.OT6, Port x configuration bits (y =               0..15)
: GPIOB_OTYPER.OT5 ( -- x addr ) 5 bit GPIOB_OTYPER ; \ GPIOB_OTYPER.OT5, Port x configuration bits (y =               0..15)
: GPIOB_OTYPER.OT4 ( -- x addr ) 4 bit GPIOB_OTYPER ; \ GPIOB_OTYPER.OT4, Port x configuration bits (y =               0..15)
: GPIOB_OTYPER.OT3 ( -- x addr ) 3 bit GPIOB_OTYPER ; \ GPIOB_OTYPER.OT3, Port x configuration bits (y =               0..15)
: GPIOB_OTYPER.OT2 ( -- x addr ) 2 bit GPIOB_OTYPER ; \ GPIOB_OTYPER.OT2, Port x configuration bits (y =               0..15)
: GPIOB_OTYPER.OT1 ( -- x addr ) 1 bit GPIOB_OTYPER ; \ GPIOB_OTYPER.OT1, Port x configuration bits (y =               0..15)
: GPIOB_OTYPER.OT0 ( -- x addr ) 0 bit GPIOB_OTYPER ; \ GPIOB_OTYPER.OT0, Port x configuration bits (y =               0..15)

\ GPIOB_OSPEEDR (read-write) Reset:$00000000
: GPIOB_OSPEEDR.OSPEEDR15 ( %bb -- x addr ) 30 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR.OSPEEDR15, Port x configuration bits (y =               0..15)
: GPIOB_OSPEEDR.OSPEEDR14 ( %bb -- x addr ) 28 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR.OSPEEDR14, Port x configuration bits (y =               0..15)
: GPIOB_OSPEEDR.OSPEEDR13 ( %bb -- x addr ) 26 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR.OSPEEDR13, Port x configuration bits (y =               0..15)
: GPIOB_OSPEEDR.OSPEEDR12 ( %bb -- x addr ) 24 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR.OSPEEDR12, Port x configuration bits (y =               0..15)
: GPIOB_OSPEEDR.OSPEEDR11 ( %bb -- x addr ) 22 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR.OSPEEDR11, Port x configuration bits (y =               0..15)
: GPIOB_OSPEEDR.OSPEEDR10 ( %bb -- x addr ) 20 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR.OSPEEDR10, Port x configuration bits (y =               0..15)
: GPIOB_OSPEEDR.OSPEEDR9 ( %bb -- x addr ) 18 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR.OSPEEDR9, Port x configuration bits (y =               0..15)
: GPIOB_OSPEEDR.OSPEEDR8 ( %bb -- x addr ) 16 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR.OSPEEDR8, Port x configuration bits (y =               0..15)
: GPIOB_OSPEEDR.OSPEEDR7 ( %bb -- x addr ) 14 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR.OSPEEDR7, Port x configuration bits (y =               0..15)
: GPIOB_OSPEEDR.OSPEEDR6 ( %bb -- x addr ) 12 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR.OSPEEDR6, Port x configuration bits (y =               0..15)
: GPIOB_OSPEEDR.OSPEEDR5 ( %bb -- x addr ) 10 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR.OSPEEDR5, Port x configuration bits (y =               0..15)
: GPIOB_OSPEEDR.OSPEEDR4 ( %bb -- x addr ) 8 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR.OSPEEDR4, Port x configuration bits (y =               0..15)
: GPIOB_OSPEEDR.OSPEEDR3 ( %bb -- x addr ) 6 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR.OSPEEDR3, Port x configuration bits (y =               0..15)
: GPIOB_OSPEEDR.OSPEEDR2 ( %bb -- x addr ) 4 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR.OSPEEDR2, Port x configuration bits (y =               0..15)
: GPIOB_OSPEEDR.OSPEEDR1 ( %bb -- x addr ) 2 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR.OSPEEDR1, Port x configuration bits (y =               0..15)
: GPIOB_OSPEEDR.OSPEEDR0 ( %bb -- x addr ) GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR.OSPEEDR0, Port x configuration bits (y =               0..15)

\ GPIOB_PUPDR (read-write) Reset:$00000000
: GPIOB_PUPDR.PUPDR15 ( %bb -- x addr ) 30 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR.PUPDR15, Port x configuration bits (y =               0..15)
: GPIOB_PUPDR.PUPDR14 ( %bb -- x addr ) 28 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR.PUPDR14, Port x configuration bits (y =               0..15)
: GPIOB_PUPDR.PUPDR13 ( %bb -- x addr ) 26 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR.PUPDR13, Port x configuration bits (y =               0..15)
: GPIOB_PUPDR.PUPDR12 ( %bb -- x addr ) 24 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR.PUPDR12, Port x configuration bits (y =               0..15)
: GPIOB_PUPDR.PUPDR11 ( %bb -- x addr ) 22 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR.PUPDR11, Port x configuration bits (y =               0..15)
: GPIOB_PUPDR.PUPDR10 ( %bb -- x addr ) 20 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR.PUPDR10, Port x configuration bits (y =               0..15)
: GPIOB_PUPDR.PUPDR9 ( %bb -- x addr ) 18 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR.PUPDR9, Port x configuration bits (y =               0..15)
: GPIOB_PUPDR.PUPDR8 ( %bb -- x addr ) 16 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR.PUPDR8, Port x configuration bits (y =               0..15)
: GPIOB_PUPDR.PUPDR7 ( %bb -- x addr ) 14 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR.PUPDR7, Port x configuration bits (y =               0..15)
: GPIOB_PUPDR.PUPDR6 ( %bb -- x addr ) 12 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR.PUPDR6, Port x configuration bits (y =               0..15)
: GPIOB_PUPDR.PUPDR5 ( %bb -- x addr ) 10 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR.PUPDR5, Port x configuration bits (y =               0..15)
: GPIOB_PUPDR.PUPDR4 ( %bb -- x addr ) 8 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR.PUPDR4, Port x configuration bits (y =               0..15)
: GPIOB_PUPDR.PUPDR3 ( %bb -- x addr ) 6 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR.PUPDR3, Port x configuration bits (y =               0..15)
: GPIOB_PUPDR.PUPDR2 ( %bb -- x addr ) 4 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR.PUPDR2, Port x configuration bits (y =               0..15)
: GPIOB_PUPDR.PUPDR1 ( %bb -- x addr ) 2 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR.PUPDR1, Port x configuration bits (y =               0..15)
: GPIOB_PUPDR.PUPDR0 ( %bb -- x addr ) GPIOB_PUPDR ; \ GPIOB_PUPDR.PUPDR0, Port x configuration bits (y =               0..15)

\ GPIOB_IDR (read-only) Reset:$00000000
: GPIOB_IDR.IDR15? ( --  1|0 ) 15 bit GPIOB_IDR bit@ ; \ GPIOB_IDR.IDR15, Port input data (y =               0..15)
: GPIOB_IDR.IDR14? ( --  1|0 ) 14 bit GPIOB_IDR bit@ ; \ GPIOB_IDR.IDR14, Port input data (y =               0..15)
: GPIOB_IDR.IDR13? ( --  1|0 ) 13 bit GPIOB_IDR bit@ ; \ GPIOB_IDR.IDR13, Port input data (y =               0..15)
: GPIOB_IDR.IDR12? ( --  1|0 ) 12 bit GPIOB_IDR bit@ ; \ GPIOB_IDR.IDR12, Port input data (y =               0..15)
: GPIOB_IDR.IDR11? ( --  1|0 ) 11 bit GPIOB_IDR bit@ ; \ GPIOB_IDR.IDR11, Port input data (y =               0..15)
: GPIOB_IDR.IDR10? ( --  1|0 ) 10 bit GPIOB_IDR bit@ ; \ GPIOB_IDR.IDR10, Port input data (y =               0..15)
: GPIOB_IDR.IDR9? ( --  1|0 ) 9 bit GPIOB_IDR bit@ ; \ GPIOB_IDR.IDR9, Port input data (y =               0..15)
: GPIOB_IDR.IDR8? ( --  1|0 ) 8 bit GPIOB_IDR bit@ ; \ GPIOB_IDR.IDR8, Port input data (y =               0..15)
: GPIOB_IDR.IDR7? ( --  1|0 ) 7 bit GPIOB_IDR bit@ ; \ GPIOB_IDR.IDR7, Port input data (y =               0..15)
: GPIOB_IDR.IDR6? ( --  1|0 ) 6 bit GPIOB_IDR bit@ ; \ GPIOB_IDR.IDR6, Port input data (y =               0..15)
: GPIOB_IDR.IDR5? ( --  1|0 ) 5 bit GPIOB_IDR bit@ ; \ GPIOB_IDR.IDR5, Port input data (y =               0..15)
: GPIOB_IDR.IDR4? ( --  1|0 ) 4 bit GPIOB_IDR bit@ ; \ GPIOB_IDR.IDR4, Port input data (y =               0..15)
: GPIOB_IDR.IDR3? ( --  1|0 ) 3 bit GPIOB_IDR bit@ ; \ GPIOB_IDR.IDR3, Port input data (y =               0..15)
: GPIOB_IDR.IDR2? ( --  1|0 ) 2 bit GPIOB_IDR bit@ ; \ GPIOB_IDR.IDR2, Port input data (y =               0..15)
: GPIOB_IDR.IDR1? ( --  1|0 ) 1 bit GPIOB_IDR bit@ ; \ GPIOB_IDR.IDR1, Port input data (y =               0..15)
: GPIOB_IDR.IDR0? ( --  1|0 ) 0 bit GPIOB_IDR bit@ ; \ GPIOB_IDR.IDR0, Port input data (y =               0..15)

\ GPIOB_ODR (read-write) Reset:$00000000
: GPIOB_ODR.ODR15 ( -- x addr ) 15 bit GPIOB_ODR ; \ GPIOB_ODR.ODR15, Port output data (y =               0..15)
: GPIOB_ODR.ODR14 ( -- x addr ) 14 bit GPIOB_ODR ; \ GPIOB_ODR.ODR14, Port output data (y =               0..15)
: GPIOB_ODR.ODR13 ( -- x addr ) 13 bit GPIOB_ODR ; \ GPIOB_ODR.ODR13, Port output data (y =               0..15)
: GPIOB_ODR.ODR12 ( -- x addr ) 12 bit GPIOB_ODR ; \ GPIOB_ODR.ODR12, Port output data (y =               0..15)
: GPIOB_ODR.ODR11 ( -- x addr ) 11 bit GPIOB_ODR ; \ GPIOB_ODR.ODR11, Port output data (y =               0..15)
: GPIOB_ODR.ODR10 ( -- x addr ) 10 bit GPIOB_ODR ; \ GPIOB_ODR.ODR10, Port output data (y =               0..15)
: GPIOB_ODR.ODR9 ( -- x addr ) 9 bit GPIOB_ODR ; \ GPIOB_ODR.ODR9, Port output data (y =               0..15)
: GPIOB_ODR.ODR8 ( -- x addr ) 8 bit GPIOB_ODR ; \ GPIOB_ODR.ODR8, Port output data (y =               0..15)
: GPIOB_ODR.ODR7 ( -- x addr ) 7 bit GPIOB_ODR ; \ GPIOB_ODR.ODR7, Port output data (y =               0..15)
: GPIOB_ODR.ODR6 ( -- x addr ) 6 bit GPIOB_ODR ; \ GPIOB_ODR.ODR6, Port output data (y =               0..15)
: GPIOB_ODR.ODR5 ( -- x addr ) 5 bit GPIOB_ODR ; \ GPIOB_ODR.ODR5, Port output data (y =               0..15)
: GPIOB_ODR.ODR4 ( -- x addr ) 4 bit GPIOB_ODR ; \ GPIOB_ODR.ODR4, Port output data (y =               0..15)
: GPIOB_ODR.ODR3 ( -- x addr ) 3 bit GPIOB_ODR ; \ GPIOB_ODR.ODR3, Port output data (y =               0..15)
: GPIOB_ODR.ODR2 ( -- x addr ) 2 bit GPIOB_ODR ; \ GPIOB_ODR.ODR2, Port output data (y =               0..15)
: GPIOB_ODR.ODR1 ( -- x addr ) 1 bit GPIOB_ODR ; \ GPIOB_ODR.ODR1, Port output data (y =               0..15)
: GPIOB_ODR.ODR0 ( -- x addr ) 0 bit GPIOB_ODR ; \ GPIOB_ODR.ODR0, Port output data (y =               0..15)

\ GPIOB_BSRR (write-only) Reset:$00000000
: GPIOB_BSRR.BR15 ( -- ) 31 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BR15, Port x reset bit y (y =               0..15)
: GPIOB_BSRR.BR14 ( -- ) 30 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BR14, Port x reset bit y (y =               0..15)
: GPIOB_BSRR.BR13 ( -- ) 29 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BR13, Port x reset bit y (y =               0..15)
: GPIOB_BSRR.BR12 ( -- ) 28 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BR12, Port x reset bit y (y =               0..15)
: GPIOB_BSRR.BR11 ( -- ) 27 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BR11, Port x reset bit y (y =               0..15)
: GPIOB_BSRR.BR10 ( -- ) 26 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BR10, Port x reset bit y (y =               0..15)
: GPIOB_BSRR.BR9 ( -- ) 25 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BR9, Port x reset bit y (y =               0..15)
: GPIOB_BSRR.BR8 ( -- ) 24 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BR8, Port x reset bit y (y =               0..15)
: GPIOB_BSRR.BR7 ( -- ) 23 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BR7, Port x reset bit y (y =               0..15)
: GPIOB_BSRR.BR6 ( -- ) 22 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BR6, Port x reset bit y (y =               0..15)
: GPIOB_BSRR.BR5 ( -- ) 21 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BR5, Port x reset bit y (y =               0..15)
: GPIOB_BSRR.BR4 ( -- ) 20 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BR4, Port x reset bit y (y =               0..15)
: GPIOB_BSRR.BR3 ( -- ) 19 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BR3, Port x reset bit y (y =               0..15)
: GPIOB_BSRR.BR2 ( -- ) 18 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BR2, Port x reset bit y (y =               0..15)
: GPIOB_BSRR.BR1 ( -- ) 17 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BR1, Port x reset bit y (y =               0..15)
: GPIOB_BSRR.BR0 ( -- ) 16 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BR0, Port x set bit y (y=               0..15)
: GPIOB_BSRR.BS15 ( -- ) 15 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BS15, Port x set bit y (y=               0..15)
: GPIOB_BSRR.BS14 ( -- ) 14 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BS14, Port x set bit y (y=               0..15)
: GPIOB_BSRR.BS13 ( -- ) 13 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BS13, Port x set bit y (y=               0..15)
: GPIOB_BSRR.BS12 ( -- ) 12 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BS12, Port x set bit y (y=               0..15)
: GPIOB_BSRR.BS11 ( -- ) 11 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BS11, Port x set bit y (y=               0..15)
: GPIOB_BSRR.BS10 ( -- ) 10 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BS10, Port x set bit y (y=               0..15)
: GPIOB_BSRR.BS9 ( -- ) 9 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BS9, Port x set bit y (y=               0..15)
: GPIOB_BSRR.BS8 ( -- ) 8 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BS8, Port x set bit y (y=               0..15)
: GPIOB_BSRR.BS7 ( -- ) 7 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BS7, Port x set bit y (y=               0..15)
: GPIOB_BSRR.BS6 ( -- ) 6 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BS6, Port x set bit y (y=               0..15)
: GPIOB_BSRR.BS5 ( -- ) 5 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BS5, Port x set bit y (y=               0..15)
: GPIOB_BSRR.BS4 ( -- ) 4 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BS4, Port x set bit y (y=               0..15)
: GPIOB_BSRR.BS3 ( -- ) 3 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BS3, Port x set bit y (y=               0..15)
: GPIOB_BSRR.BS2 ( -- ) 2 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BS2, Port x set bit y (y=               0..15)
: GPIOB_BSRR.BS1 ( -- ) 1 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BS1, Port x set bit y (y=               0..15)
: GPIOB_BSRR.BS0 ( -- ) 0 bit GPIOB_BSRR ! ; \ GPIOB_BSRR.BS0, Port x set bit y (y=               0..15)

\ GPIOB_LCKR (read-write) Reset:$00000000
: GPIOB_LCKR.LCKK ( -- x addr ) 16 bit GPIOB_LCKR ; \ GPIOB_LCKR.LCKK, Port x lock bit y (y=               0..15)
: GPIOB_LCKR.LCK15 ( -- x addr ) 15 bit GPIOB_LCKR ; \ GPIOB_LCKR.LCK15, Port x lock bit y (y=               0..15)
: GPIOB_LCKR.LCK14 ( -- x addr ) 14 bit GPIOB_LCKR ; \ GPIOB_LCKR.LCK14, Port x lock bit y (y=               0..15)
: GPIOB_LCKR.LCK13 ( -- x addr ) 13 bit GPIOB_LCKR ; \ GPIOB_LCKR.LCK13, Port x lock bit y (y=               0..15)
: GPIOB_LCKR.LCK12 ( -- x addr ) 12 bit GPIOB_LCKR ; \ GPIOB_LCKR.LCK12, Port x lock bit y (y=               0..15)
: GPIOB_LCKR.LCK11 ( -- x addr ) 11 bit GPIOB_LCKR ; \ GPIOB_LCKR.LCK11, Port x lock bit y (y=               0..15)
: GPIOB_LCKR.LCK10 ( -- x addr ) 10 bit GPIOB_LCKR ; \ GPIOB_LCKR.LCK10, Port x lock bit y (y=               0..15)
: GPIOB_LCKR.LCK9 ( -- x addr ) 9 bit GPIOB_LCKR ; \ GPIOB_LCKR.LCK9, Port x lock bit y (y=               0..15)
: GPIOB_LCKR.LCK8 ( -- x addr ) 8 bit GPIOB_LCKR ; \ GPIOB_LCKR.LCK8, Port x lock bit y (y=               0..15)
: GPIOB_LCKR.LCK7 ( -- x addr ) 7 bit GPIOB_LCKR ; \ GPIOB_LCKR.LCK7, Port x lock bit y (y=               0..15)
: GPIOB_LCKR.LCK6 ( -- x addr ) 6 bit GPIOB_LCKR ; \ GPIOB_LCKR.LCK6, Port x lock bit y (y=               0..15)
: GPIOB_LCKR.LCK5 ( -- x addr ) 5 bit GPIOB_LCKR ; \ GPIOB_LCKR.LCK5, Port x lock bit y (y=               0..15)
: GPIOB_LCKR.LCK4 ( -- x addr ) 4 bit GPIOB_LCKR ; \ GPIOB_LCKR.LCK4, Port x lock bit y (y=               0..15)
: GPIOB_LCKR.LCK3 ( -- x addr ) 3 bit GPIOB_LCKR ; \ GPIOB_LCKR.LCK3, Port x lock bit y (y=               0..15)
: GPIOB_LCKR.LCK2 ( -- x addr ) 2 bit GPIOB_LCKR ; \ GPIOB_LCKR.LCK2, Port x lock bit y (y=               0..15)
: GPIOB_LCKR.LCK1 ( -- x addr ) 1 bit GPIOB_LCKR ; \ GPIOB_LCKR.LCK1, Port x lock bit y (y=               0..15)
: GPIOB_LCKR.LCK0 ( -- x addr ) 0 bit GPIOB_LCKR ; \ GPIOB_LCKR.LCK0, Port x lock bit y (y=               0..15)

\ GPIOB_AFRL (read-write) Reset:$00000000
: GPIOB_AFRL.AFSEL7 ( %bbbb -- x addr ) 28 lshift GPIOB_AFRL ; \ GPIOB_AFRL.AFSEL7, Alternate function selection for port x               bit y (y = 0..7)
: GPIOB_AFRL.AFSEL6 ( %bbbb -- x addr ) 24 lshift GPIOB_AFRL ; \ GPIOB_AFRL.AFSEL6, Alternate function selection for port x               bit y (y = 0..7)
: GPIOB_AFRL.AFSEL5 ( %bbbb -- x addr ) 20 lshift GPIOB_AFRL ; \ GPIOB_AFRL.AFSEL5, Alternate function selection for port x               bit y (y = 0..7)
: GPIOB_AFRL.AFSEL4 ( %bbbb -- x addr ) 16 lshift GPIOB_AFRL ; \ GPIOB_AFRL.AFSEL4, Alternate function selection for port x               bit y (y = 0..7)
: GPIOB_AFRL.AFSEL3 ( %bbbb -- x addr ) 12 lshift GPIOB_AFRL ; \ GPIOB_AFRL.AFSEL3, Alternate function selection for port x               bit y (y = 0..7)
: GPIOB_AFRL.AFSEL2 ( %bbbb -- x addr ) 8 lshift GPIOB_AFRL ; \ GPIOB_AFRL.AFSEL2, Alternate function selection for port x               bit y (y = 0..7)
: GPIOB_AFRL.AFSEL1 ( %bbbb -- x addr ) 4 lshift GPIOB_AFRL ; \ GPIOB_AFRL.AFSEL1, Alternate function selection for port x               bit y (y = 0..7)
: GPIOB_AFRL.AFSEL0 ( %bbbb -- x addr ) GPIOB_AFRL ; \ GPIOB_AFRL.AFSEL0, Alternate function selection for port x               bit y (y = 0..7)

\ GPIOB_AFRH (read-write) Reset:$00000000
: GPIOB_AFRH.AFSEL15 ( %bbbb -- x addr ) 28 lshift GPIOB_AFRH ; \ GPIOB_AFRH.AFSEL15, Alternate function selection for port x               bit y (y = 8..15)
: GPIOB_AFRH.AFSEL14 ( %bbbb -- x addr ) 24 lshift GPIOB_AFRH ; \ GPIOB_AFRH.AFSEL14, Alternate function selection for port x               bit y (y = 8..15)
: GPIOB_AFRH.AFSEL13 ( %bbbb -- x addr ) 20 lshift GPIOB_AFRH ; \ GPIOB_AFRH.AFSEL13, Alternate function selection for port x               bit y (y = 8..15)
: GPIOB_AFRH.AFSEL12 ( %bbbb -- x addr ) 16 lshift GPIOB_AFRH ; \ GPIOB_AFRH.AFSEL12, Alternate function selection for port x               bit y (y = 8..15)
: GPIOB_AFRH.AFSEL11 ( %bbbb -- x addr ) 12 lshift GPIOB_AFRH ; \ GPIOB_AFRH.AFSEL11, Alternate function selection for port x               bit y (y = 8..15)
: GPIOB_AFRH.AFSEL10 ( %bbbb -- x addr ) 8 lshift GPIOB_AFRH ; \ GPIOB_AFRH.AFSEL10, Alternate function selection for port x               bit y (y = 8..15)
: GPIOB_AFRH.AFSEL9 ( %bbbb -- x addr ) 4 lshift GPIOB_AFRH ; \ GPIOB_AFRH.AFSEL9, Alternate function selection for port x               bit y (y = 8..15)
: GPIOB_AFRH.AFSEL8 ( %bbbb -- x addr ) GPIOB_AFRH ; \ GPIOB_AFRH.AFSEL8, Alternate function selection for port x               bit y (y = 8..15)

\ GPIOB_BRR (write-only) Reset:$00000000
: GPIOB_BRR.BR0 ( -- ) 0 bit GPIOB_BRR ! ; \ GPIOB_BRR.BR0, Port Reset bit
: GPIOB_BRR.BR1 ( -- ) 1 bit GPIOB_BRR ! ; \ GPIOB_BRR.BR1, Port Reset bit
: GPIOB_BRR.BR2 ( -- ) 2 bit GPIOB_BRR ! ; \ GPIOB_BRR.BR2, Port Reset bit
: GPIOB_BRR.BR3 ( -- ) 3 bit GPIOB_BRR ! ; \ GPIOB_BRR.BR3, Port Reset bit
: GPIOB_BRR.BR4 ( -- ) 4 bit GPIOB_BRR ! ; \ GPIOB_BRR.BR4, Port Reset bit
: GPIOB_BRR.BR5 ( -- ) 5 bit GPIOB_BRR ! ; \ GPIOB_BRR.BR5, Port Reset bit
: GPIOB_BRR.BR6 ( -- ) 6 bit GPIOB_BRR ! ; \ GPIOB_BRR.BR6, Port Reset bit
: GPIOB_BRR.BR7 ( -- ) 7 bit GPIOB_BRR ! ; \ GPIOB_BRR.BR7, Port Reset bit
: GPIOB_BRR.BR8 ( -- ) 8 bit GPIOB_BRR ! ; \ GPIOB_BRR.BR8, Port Reset bit
: GPIOB_BRR.BR9 ( -- ) 9 bit GPIOB_BRR ! ; \ GPIOB_BRR.BR9, Port Reset bit
: GPIOB_BRR.BR10 ( -- ) 10 bit GPIOB_BRR ! ; \ GPIOB_BRR.BR10, Port Reset bit
: GPIOB_BRR.BR11 ( -- ) 11 bit GPIOB_BRR ! ; \ GPIOB_BRR.BR11, Port Reset bit
: GPIOB_BRR.BR12 ( -- ) 12 bit GPIOB_BRR ! ; \ GPIOB_BRR.BR12, Port Reset bit
: GPIOB_BRR.BR13 ( -- ) 13 bit GPIOB_BRR ! ; \ GPIOB_BRR.BR13, Port Reset bit
: GPIOB_BRR.BR14 ( -- ) 14 bit GPIOB_BRR ! ; \ GPIOB_BRR.BR14, Port Reset bit
: GPIOB_BRR.BR15 ( -- ) 15 bit GPIOB_BRR ! ; \ GPIOB_BRR.BR15, Port Reset bit

\ GPIOC_MODER (read-write) Reset:$FFFFFFFF
: GPIOC_MODER.MODER15 ( %bb -- x addr ) 30 lshift GPIOC_MODER ; \ GPIOC_MODER.MODER15, Port x configuration bits (y =               0..15)
: GPIOC_MODER.MODER14 ( %bb -- x addr ) 28 lshift GPIOC_MODER ; \ GPIOC_MODER.MODER14, Port x configuration bits (y =               0..15)
: GPIOC_MODER.MODER13 ( %bb -- x addr ) 26 lshift GPIOC_MODER ; \ GPIOC_MODER.MODER13, Port x configuration bits (y =               0..15)
: GPIOC_MODER.MODER12 ( %bb -- x addr ) 24 lshift GPIOC_MODER ; \ GPIOC_MODER.MODER12, Port x configuration bits (y =               0..15)
: GPIOC_MODER.MODER11 ( %bb -- x addr ) 22 lshift GPIOC_MODER ; \ GPIOC_MODER.MODER11, Port x configuration bits (y =               0..15)
: GPIOC_MODER.MODER10 ( %bb -- x addr ) 20 lshift GPIOC_MODER ; \ GPIOC_MODER.MODER10, Port x configuration bits (y =               0..15)
: GPIOC_MODER.MODER9 ( %bb -- x addr ) 18 lshift GPIOC_MODER ; \ GPIOC_MODER.MODER9, Port x configuration bits (y =               0..15)
: GPIOC_MODER.MODER8 ( %bb -- x addr ) 16 lshift GPIOC_MODER ; \ GPIOC_MODER.MODER8, Port x configuration bits (y =               0..15)
: GPIOC_MODER.MODER7 ( %bb -- x addr ) 14 lshift GPIOC_MODER ; \ GPIOC_MODER.MODER7, Port x configuration bits (y =               0..15)
: GPIOC_MODER.MODER6 ( %bb -- x addr ) 12 lshift GPIOC_MODER ; \ GPIOC_MODER.MODER6, Port x configuration bits (y =               0..15)
: GPIOC_MODER.MODER5 ( %bb -- x addr ) 10 lshift GPIOC_MODER ; \ GPIOC_MODER.MODER5, Port x configuration bits (y =               0..15)
: GPIOC_MODER.MODER4 ( %bb -- x addr ) 8 lshift GPIOC_MODER ; \ GPIOC_MODER.MODER4, Port x configuration bits (y =               0..15)
: GPIOC_MODER.MODER3 ( %bb -- x addr ) 6 lshift GPIOC_MODER ; \ GPIOC_MODER.MODER3, Port x configuration bits (y =               0..15)
: GPIOC_MODER.MODER2 ( %bb -- x addr ) 4 lshift GPIOC_MODER ; \ GPIOC_MODER.MODER2, Port x configuration bits (y =               0..15)
: GPIOC_MODER.MODER1 ( %bb -- x addr ) 2 lshift GPIOC_MODER ; \ GPIOC_MODER.MODER1, Port x configuration bits (y =               0..15)
: GPIOC_MODER.MODER0 ( %bb -- x addr ) GPIOC_MODER ; \ GPIOC_MODER.MODER0, Port x configuration bits (y =               0..15)

\ GPIOC_OTYPER (read-write) Reset:$00000000
: GPIOC_OTYPER.OT15 ( -- x addr ) 15 bit GPIOC_OTYPER ; \ GPIOC_OTYPER.OT15, Port x configuration bits (y =               0..15)
: GPIOC_OTYPER.OT14 ( -- x addr ) 14 bit GPIOC_OTYPER ; \ GPIOC_OTYPER.OT14, Port x configuration bits (y =               0..15)
: GPIOC_OTYPER.OT13 ( -- x addr ) 13 bit GPIOC_OTYPER ; \ GPIOC_OTYPER.OT13, Port x configuration bits (y =               0..15)
: GPIOC_OTYPER.OT12 ( -- x addr ) 12 bit GPIOC_OTYPER ; \ GPIOC_OTYPER.OT12, Port x configuration bits (y =               0..15)
: GPIOC_OTYPER.OT11 ( -- x addr ) 11 bit GPIOC_OTYPER ; \ GPIOC_OTYPER.OT11, Port x configuration bits (y =               0..15)
: GPIOC_OTYPER.OT10 ( -- x addr ) 10 bit GPIOC_OTYPER ; \ GPIOC_OTYPER.OT10, Port x configuration bits (y =               0..15)
: GPIOC_OTYPER.OT9 ( -- x addr ) 9 bit GPIOC_OTYPER ; \ GPIOC_OTYPER.OT9, Port x configuration bits (y =               0..15)
: GPIOC_OTYPER.OT8 ( -- x addr ) 8 bit GPIOC_OTYPER ; \ GPIOC_OTYPER.OT8, Port x configuration bits (y =               0..15)
: GPIOC_OTYPER.OT7 ( -- x addr ) 7 bit GPIOC_OTYPER ; \ GPIOC_OTYPER.OT7, Port x configuration bits (y =               0..15)
: GPIOC_OTYPER.OT6 ( -- x addr ) 6 bit GPIOC_OTYPER ; \ GPIOC_OTYPER.OT6, Port x configuration bits (y =               0..15)
: GPIOC_OTYPER.OT5 ( -- x addr ) 5 bit GPIOC_OTYPER ; \ GPIOC_OTYPER.OT5, Port x configuration bits (y =               0..15)
: GPIOC_OTYPER.OT4 ( -- x addr ) 4 bit GPIOC_OTYPER ; \ GPIOC_OTYPER.OT4, Port x configuration bits (y =               0..15)
: GPIOC_OTYPER.OT3 ( -- x addr ) 3 bit GPIOC_OTYPER ; \ GPIOC_OTYPER.OT3, Port x configuration bits (y =               0..15)
: GPIOC_OTYPER.OT2 ( -- x addr ) 2 bit GPIOC_OTYPER ; \ GPIOC_OTYPER.OT2, Port x configuration bits (y =               0..15)
: GPIOC_OTYPER.OT1 ( -- x addr ) 1 bit GPIOC_OTYPER ; \ GPIOC_OTYPER.OT1, Port x configuration bits (y =               0..15)
: GPIOC_OTYPER.OT0 ( -- x addr ) 0 bit GPIOC_OTYPER ; \ GPIOC_OTYPER.OT0, Port x configuration bits (y =               0..15)

\ GPIOC_OSPEEDR (read-write) Reset:$00000000
: GPIOC_OSPEEDR.OSPEEDR15 ( %bb -- x addr ) 30 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR.OSPEEDR15, Port x configuration bits (y =               0..15)
: GPIOC_OSPEEDR.OSPEEDR14 ( %bb -- x addr ) 28 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR.OSPEEDR14, Port x configuration bits (y =               0..15)
: GPIOC_OSPEEDR.OSPEEDR13 ( %bb -- x addr ) 26 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR.OSPEEDR13, Port x configuration bits (y =               0..15)
: GPIOC_OSPEEDR.OSPEEDR12 ( %bb -- x addr ) 24 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR.OSPEEDR12, Port x configuration bits (y =               0..15)
: GPIOC_OSPEEDR.OSPEEDR11 ( %bb -- x addr ) 22 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR.OSPEEDR11, Port x configuration bits (y =               0..15)
: GPIOC_OSPEEDR.OSPEEDR10 ( %bb -- x addr ) 20 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR.OSPEEDR10, Port x configuration bits (y =               0..15)
: GPIOC_OSPEEDR.OSPEEDR9 ( %bb -- x addr ) 18 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR.OSPEEDR9, Port x configuration bits (y =               0..15)
: GPIOC_OSPEEDR.OSPEEDR8 ( %bb -- x addr ) 16 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR.OSPEEDR8, Port x configuration bits (y =               0..15)
: GPIOC_OSPEEDR.OSPEEDR7 ( %bb -- x addr ) 14 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR.OSPEEDR7, Port x configuration bits (y =               0..15)
: GPIOC_OSPEEDR.OSPEEDR6 ( %bb -- x addr ) 12 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR.OSPEEDR6, Port x configuration bits (y =               0..15)
: GPIOC_OSPEEDR.OSPEEDR5 ( %bb -- x addr ) 10 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR.OSPEEDR5, Port x configuration bits (y =               0..15)
: GPIOC_OSPEEDR.OSPEEDR4 ( %bb -- x addr ) 8 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR.OSPEEDR4, Port x configuration bits (y =               0..15)
: GPIOC_OSPEEDR.OSPEEDR3 ( %bb -- x addr ) 6 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR.OSPEEDR3, Port x configuration bits (y =               0..15)
: GPIOC_OSPEEDR.OSPEEDR2 ( %bb -- x addr ) 4 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR.OSPEEDR2, Port x configuration bits (y =               0..15)
: GPIOC_OSPEEDR.OSPEEDR1 ( %bb -- x addr ) 2 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR.OSPEEDR1, Port x configuration bits (y =               0..15)
: GPIOC_OSPEEDR.OSPEEDR0 ( %bb -- x addr ) GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR.OSPEEDR0, Port x configuration bits (y =               0..15)

\ GPIOC_PUPDR (read-write) Reset:$00000000
: GPIOC_PUPDR.PUPDR15 ( %bb -- x addr ) 30 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR.PUPDR15, Port x configuration bits (y =               0..15)
: GPIOC_PUPDR.PUPDR14 ( %bb -- x addr ) 28 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR.PUPDR14, Port x configuration bits (y =               0..15)
: GPIOC_PUPDR.PUPDR13 ( %bb -- x addr ) 26 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR.PUPDR13, Port x configuration bits (y =               0..15)
: GPIOC_PUPDR.PUPDR12 ( %bb -- x addr ) 24 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR.PUPDR12, Port x configuration bits (y =               0..15)
: GPIOC_PUPDR.PUPDR11 ( %bb -- x addr ) 22 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR.PUPDR11, Port x configuration bits (y =               0..15)
: GPIOC_PUPDR.PUPDR10 ( %bb -- x addr ) 20 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR.PUPDR10, Port x configuration bits (y =               0..15)
: GPIOC_PUPDR.PUPDR9 ( %bb -- x addr ) 18 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR.PUPDR9, Port x configuration bits (y =               0..15)
: GPIOC_PUPDR.PUPDR8 ( %bb -- x addr ) 16 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR.PUPDR8, Port x configuration bits (y =               0..15)
: GPIOC_PUPDR.PUPDR7 ( %bb -- x addr ) 14 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR.PUPDR7, Port x configuration bits (y =               0..15)
: GPIOC_PUPDR.PUPDR6 ( %bb -- x addr ) 12 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR.PUPDR6, Port x configuration bits (y =               0..15)
: GPIOC_PUPDR.PUPDR5 ( %bb -- x addr ) 10 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR.PUPDR5, Port x configuration bits (y =               0..15)
: GPIOC_PUPDR.PUPDR4 ( %bb -- x addr ) 8 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR.PUPDR4, Port x configuration bits (y =               0..15)
: GPIOC_PUPDR.PUPDR3 ( %bb -- x addr ) 6 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR.PUPDR3, Port x configuration bits (y =               0..15)
: GPIOC_PUPDR.PUPDR2 ( %bb -- x addr ) 4 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR.PUPDR2, Port x configuration bits (y =               0..15)
: GPIOC_PUPDR.PUPDR1 ( %bb -- x addr ) 2 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR.PUPDR1, Port x configuration bits (y =               0..15)
: GPIOC_PUPDR.PUPDR0 ( %bb -- x addr ) GPIOC_PUPDR ; \ GPIOC_PUPDR.PUPDR0, Port x configuration bits (y =               0..15)

\ GPIOC_IDR (read-only) Reset:$00000000
: GPIOC_IDR.IDR15? ( --  1|0 ) 15 bit GPIOC_IDR bit@ ; \ GPIOC_IDR.IDR15, Port input data (y =               0..15)
: GPIOC_IDR.IDR14? ( --  1|0 ) 14 bit GPIOC_IDR bit@ ; \ GPIOC_IDR.IDR14, Port input data (y =               0..15)
: GPIOC_IDR.IDR13? ( --  1|0 ) 13 bit GPIOC_IDR bit@ ; \ GPIOC_IDR.IDR13, Port input data (y =               0..15)
: GPIOC_IDR.IDR12? ( --  1|0 ) 12 bit GPIOC_IDR bit@ ; \ GPIOC_IDR.IDR12, Port input data (y =               0..15)
: GPIOC_IDR.IDR11? ( --  1|0 ) 11 bit GPIOC_IDR bit@ ; \ GPIOC_IDR.IDR11, Port input data (y =               0..15)
: GPIOC_IDR.IDR10? ( --  1|0 ) 10 bit GPIOC_IDR bit@ ; \ GPIOC_IDR.IDR10, Port input data (y =               0..15)
: GPIOC_IDR.IDR9? ( --  1|0 ) 9 bit GPIOC_IDR bit@ ; \ GPIOC_IDR.IDR9, Port input data (y =               0..15)
: GPIOC_IDR.IDR8? ( --  1|0 ) 8 bit GPIOC_IDR bit@ ; \ GPIOC_IDR.IDR8, Port input data (y =               0..15)
: GPIOC_IDR.IDR7? ( --  1|0 ) 7 bit GPIOC_IDR bit@ ; \ GPIOC_IDR.IDR7, Port input data (y =               0..15)
: GPIOC_IDR.IDR6? ( --  1|0 ) 6 bit GPIOC_IDR bit@ ; \ GPIOC_IDR.IDR6, Port input data (y =               0..15)
: GPIOC_IDR.IDR5? ( --  1|0 ) 5 bit GPIOC_IDR bit@ ; \ GPIOC_IDR.IDR5, Port input data (y =               0..15)
: GPIOC_IDR.IDR4? ( --  1|0 ) 4 bit GPIOC_IDR bit@ ; \ GPIOC_IDR.IDR4, Port input data (y =               0..15)
: GPIOC_IDR.IDR3? ( --  1|0 ) 3 bit GPIOC_IDR bit@ ; \ GPIOC_IDR.IDR3, Port input data (y =               0..15)
: GPIOC_IDR.IDR2? ( --  1|0 ) 2 bit GPIOC_IDR bit@ ; \ GPIOC_IDR.IDR2, Port input data (y =               0..15)
: GPIOC_IDR.IDR1? ( --  1|0 ) 1 bit GPIOC_IDR bit@ ; \ GPIOC_IDR.IDR1, Port input data (y =               0..15)
: GPIOC_IDR.IDR0? ( --  1|0 ) 0 bit GPIOC_IDR bit@ ; \ GPIOC_IDR.IDR0, Port input data (y =               0..15)

\ GPIOC_ODR (read-write) Reset:$00000000
: GPIOC_ODR.ODR15 ( -- x addr ) 15 bit GPIOC_ODR ; \ GPIOC_ODR.ODR15, Port output data (y =               0..15)
: GPIOC_ODR.ODR14 ( -- x addr ) 14 bit GPIOC_ODR ; \ GPIOC_ODR.ODR14, Port output data (y =               0..15)
: GPIOC_ODR.ODR13 ( -- x addr ) 13 bit GPIOC_ODR ; \ GPIOC_ODR.ODR13, Port output data (y =               0..15)
: GPIOC_ODR.ODR12 ( -- x addr ) 12 bit GPIOC_ODR ; \ GPIOC_ODR.ODR12, Port output data (y =               0..15)
: GPIOC_ODR.ODR11 ( -- x addr ) 11 bit GPIOC_ODR ; \ GPIOC_ODR.ODR11, Port output data (y =               0..15)
: GPIOC_ODR.ODR10 ( -- x addr ) 10 bit GPIOC_ODR ; \ GPIOC_ODR.ODR10, Port output data (y =               0..15)
: GPIOC_ODR.ODR9 ( -- x addr ) 9 bit GPIOC_ODR ; \ GPIOC_ODR.ODR9, Port output data (y =               0..15)
: GPIOC_ODR.ODR8 ( -- x addr ) 8 bit GPIOC_ODR ; \ GPIOC_ODR.ODR8, Port output data (y =               0..15)
: GPIOC_ODR.ODR7 ( -- x addr ) 7 bit GPIOC_ODR ; \ GPIOC_ODR.ODR7, Port output data (y =               0..15)
: GPIOC_ODR.ODR6 ( -- x addr ) 6 bit GPIOC_ODR ; \ GPIOC_ODR.ODR6, Port output data (y =               0..15)
: GPIOC_ODR.ODR5 ( -- x addr ) 5 bit GPIOC_ODR ; \ GPIOC_ODR.ODR5, Port output data (y =               0..15)
: GPIOC_ODR.ODR4 ( -- x addr ) 4 bit GPIOC_ODR ; \ GPIOC_ODR.ODR4, Port output data (y =               0..15)
: GPIOC_ODR.ODR3 ( -- x addr ) 3 bit GPIOC_ODR ; \ GPIOC_ODR.ODR3, Port output data (y =               0..15)
: GPIOC_ODR.ODR2 ( -- x addr ) 2 bit GPIOC_ODR ; \ GPIOC_ODR.ODR2, Port output data (y =               0..15)
: GPIOC_ODR.ODR1 ( -- x addr ) 1 bit GPIOC_ODR ; \ GPIOC_ODR.ODR1, Port output data (y =               0..15)
: GPIOC_ODR.ODR0 ( -- x addr ) 0 bit GPIOC_ODR ; \ GPIOC_ODR.ODR0, Port output data (y =               0..15)

\ GPIOC_BSRR (write-only) Reset:$00000000
: GPIOC_BSRR.BR15 ( -- ) 31 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BR15, Port x reset bit y (y =               0..15)
: GPIOC_BSRR.BR14 ( -- ) 30 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BR14, Port x reset bit y (y =               0..15)
: GPIOC_BSRR.BR13 ( -- ) 29 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BR13, Port x reset bit y (y =               0..15)
: GPIOC_BSRR.BR12 ( -- ) 28 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BR12, Port x reset bit y (y =               0..15)
: GPIOC_BSRR.BR11 ( -- ) 27 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BR11, Port x reset bit y (y =               0..15)
: GPIOC_BSRR.BR10 ( -- ) 26 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BR10, Port x reset bit y (y =               0..15)
: GPIOC_BSRR.BR9 ( -- ) 25 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BR9, Port x reset bit y (y =               0..15)
: GPIOC_BSRR.BR8 ( -- ) 24 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BR8, Port x reset bit y (y =               0..15)
: GPIOC_BSRR.BR7 ( -- ) 23 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BR7, Port x reset bit y (y =               0..15)
: GPIOC_BSRR.BR6 ( -- ) 22 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BR6, Port x reset bit y (y =               0..15)
: GPIOC_BSRR.BR5 ( -- ) 21 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BR5, Port x reset bit y (y =               0..15)
: GPIOC_BSRR.BR4 ( -- ) 20 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BR4, Port x reset bit y (y =               0..15)
: GPIOC_BSRR.BR3 ( -- ) 19 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BR3, Port x reset bit y (y =               0..15)
: GPIOC_BSRR.BR2 ( -- ) 18 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BR2, Port x reset bit y (y =               0..15)
: GPIOC_BSRR.BR1 ( -- ) 17 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BR1, Port x reset bit y (y =               0..15)
: GPIOC_BSRR.BR0 ( -- ) 16 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BR0, Port x set bit y (y=               0..15)
: GPIOC_BSRR.BS15 ( -- ) 15 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BS15, Port x set bit y (y=               0..15)
: GPIOC_BSRR.BS14 ( -- ) 14 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BS14, Port x set bit y (y=               0..15)
: GPIOC_BSRR.BS13 ( -- ) 13 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BS13, Port x set bit y (y=               0..15)
: GPIOC_BSRR.BS12 ( -- ) 12 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BS12, Port x set bit y (y=               0..15)
: GPIOC_BSRR.BS11 ( -- ) 11 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BS11, Port x set bit y (y=               0..15)
: GPIOC_BSRR.BS10 ( -- ) 10 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BS10, Port x set bit y (y=               0..15)
: GPIOC_BSRR.BS9 ( -- ) 9 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BS9, Port x set bit y (y=               0..15)
: GPIOC_BSRR.BS8 ( -- ) 8 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BS8, Port x set bit y (y=               0..15)
: GPIOC_BSRR.BS7 ( -- ) 7 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BS7, Port x set bit y (y=               0..15)
: GPIOC_BSRR.BS6 ( -- ) 6 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BS6, Port x set bit y (y=               0..15)
: GPIOC_BSRR.BS5 ( -- ) 5 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BS5, Port x set bit y (y=               0..15)
: GPIOC_BSRR.BS4 ( -- ) 4 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BS4, Port x set bit y (y=               0..15)
: GPIOC_BSRR.BS3 ( -- ) 3 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BS3, Port x set bit y (y=               0..15)
: GPIOC_BSRR.BS2 ( -- ) 2 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BS2, Port x set bit y (y=               0..15)
: GPIOC_BSRR.BS1 ( -- ) 1 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BS1, Port x set bit y (y=               0..15)
: GPIOC_BSRR.BS0 ( -- ) 0 bit GPIOC_BSRR ! ; \ GPIOC_BSRR.BS0, Port x set bit y (y=               0..15)

\ GPIOC_LCKR (read-write) Reset:$00000000
: GPIOC_LCKR.LCKK ( -- x addr ) 16 bit GPIOC_LCKR ; \ GPIOC_LCKR.LCKK, Port x lock bit y (y=               0..15)
: GPIOC_LCKR.LCK15 ( -- x addr ) 15 bit GPIOC_LCKR ; \ GPIOC_LCKR.LCK15, Port x lock bit y (y=               0..15)
: GPIOC_LCKR.LCK14 ( -- x addr ) 14 bit GPIOC_LCKR ; \ GPIOC_LCKR.LCK14, Port x lock bit y (y=               0..15)
: GPIOC_LCKR.LCK13 ( -- x addr ) 13 bit GPIOC_LCKR ; \ GPIOC_LCKR.LCK13, Port x lock bit y (y=               0..15)
: GPIOC_LCKR.LCK12 ( -- x addr ) 12 bit GPIOC_LCKR ; \ GPIOC_LCKR.LCK12, Port x lock bit y (y=               0..15)
: GPIOC_LCKR.LCK11 ( -- x addr ) 11 bit GPIOC_LCKR ; \ GPIOC_LCKR.LCK11, Port x lock bit y (y=               0..15)
: GPIOC_LCKR.LCK10 ( -- x addr ) 10 bit GPIOC_LCKR ; \ GPIOC_LCKR.LCK10, Port x lock bit y (y=               0..15)
: GPIOC_LCKR.LCK9 ( -- x addr ) 9 bit GPIOC_LCKR ; \ GPIOC_LCKR.LCK9, Port x lock bit y (y=               0..15)
: GPIOC_LCKR.LCK8 ( -- x addr ) 8 bit GPIOC_LCKR ; \ GPIOC_LCKR.LCK8, Port x lock bit y (y=               0..15)
: GPIOC_LCKR.LCK7 ( -- x addr ) 7 bit GPIOC_LCKR ; \ GPIOC_LCKR.LCK7, Port x lock bit y (y=               0..15)
: GPIOC_LCKR.LCK6 ( -- x addr ) 6 bit GPIOC_LCKR ; \ GPIOC_LCKR.LCK6, Port x lock bit y (y=               0..15)
: GPIOC_LCKR.LCK5 ( -- x addr ) 5 bit GPIOC_LCKR ; \ GPIOC_LCKR.LCK5, Port x lock bit y (y=               0..15)
: GPIOC_LCKR.LCK4 ( -- x addr ) 4 bit GPIOC_LCKR ; \ GPIOC_LCKR.LCK4, Port x lock bit y (y=               0..15)
: GPIOC_LCKR.LCK3 ( -- x addr ) 3 bit GPIOC_LCKR ; \ GPIOC_LCKR.LCK3, Port x lock bit y (y=               0..15)
: GPIOC_LCKR.LCK2 ( -- x addr ) 2 bit GPIOC_LCKR ; \ GPIOC_LCKR.LCK2, Port x lock bit y (y=               0..15)
: GPIOC_LCKR.LCK1 ( -- x addr ) 1 bit GPIOC_LCKR ; \ GPIOC_LCKR.LCK1, Port x lock bit y (y=               0..15)
: GPIOC_LCKR.LCK0 ( -- x addr ) 0 bit GPIOC_LCKR ; \ GPIOC_LCKR.LCK0, Port x lock bit y (y=               0..15)

\ GPIOC_AFRL (read-write) Reset:$00000000
: GPIOC_AFRL.AFSEL7 ( %bbbb -- x addr ) 28 lshift GPIOC_AFRL ; \ GPIOC_AFRL.AFSEL7, Alternate function selection for port x               bit y (y = 0..7)
: GPIOC_AFRL.AFSEL6 ( %bbbb -- x addr ) 24 lshift GPIOC_AFRL ; \ GPIOC_AFRL.AFSEL6, Alternate function selection for port x               bit y (y = 0..7)
: GPIOC_AFRL.AFSEL5 ( %bbbb -- x addr ) 20 lshift GPIOC_AFRL ; \ GPIOC_AFRL.AFSEL5, Alternate function selection for port x               bit y (y = 0..7)
: GPIOC_AFRL.AFSEL4 ( %bbbb -- x addr ) 16 lshift GPIOC_AFRL ; \ GPIOC_AFRL.AFSEL4, Alternate function selection for port x               bit y (y = 0..7)
: GPIOC_AFRL.AFSEL3 ( %bbbb -- x addr ) 12 lshift GPIOC_AFRL ; \ GPIOC_AFRL.AFSEL3, Alternate function selection for port x               bit y (y = 0..7)
: GPIOC_AFRL.AFSEL2 ( %bbbb -- x addr ) 8 lshift GPIOC_AFRL ; \ GPIOC_AFRL.AFSEL2, Alternate function selection for port x               bit y (y = 0..7)
: GPIOC_AFRL.AFSEL1 ( %bbbb -- x addr ) 4 lshift GPIOC_AFRL ; \ GPIOC_AFRL.AFSEL1, Alternate function selection for port x               bit y (y = 0..7)
: GPIOC_AFRL.AFSEL0 ( %bbbb -- x addr ) GPIOC_AFRL ; \ GPIOC_AFRL.AFSEL0, Alternate function selection for port x               bit y (y = 0..7)

\ GPIOC_AFRH (read-write) Reset:$00000000
: GPIOC_AFRH.AFSEL15 ( %bbbb -- x addr ) 28 lshift GPIOC_AFRH ; \ GPIOC_AFRH.AFSEL15, Alternate function selection for port x               bit y (y = 8..15)
: GPIOC_AFRH.AFSEL14 ( %bbbb -- x addr ) 24 lshift GPIOC_AFRH ; \ GPIOC_AFRH.AFSEL14, Alternate function selection for port x               bit y (y = 8..15)
: GPIOC_AFRH.AFSEL13 ( %bbbb -- x addr ) 20 lshift GPIOC_AFRH ; \ GPIOC_AFRH.AFSEL13, Alternate function selection for port x               bit y (y = 8..15)
: GPIOC_AFRH.AFSEL12 ( %bbbb -- x addr ) 16 lshift GPIOC_AFRH ; \ GPIOC_AFRH.AFSEL12, Alternate function selection for port x               bit y (y = 8..15)
: GPIOC_AFRH.AFSEL11 ( %bbbb -- x addr ) 12 lshift GPIOC_AFRH ; \ GPIOC_AFRH.AFSEL11, Alternate function selection for port x               bit y (y = 8..15)
: GPIOC_AFRH.AFSEL10 ( %bbbb -- x addr ) 8 lshift GPIOC_AFRH ; \ GPIOC_AFRH.AFSEL10, Alternate function selection for port x               bit y (y = 8..15)
: GPIOC_AFRH.AFSEL9 ( %bbbb -- x addr ) 4 lshift GPIOC_AFRH ; \ GPIOC_AFRH.AFSEL9, Alternate function selection for port x               bit y (y = 8..15)
: GPIOC_AFRH.AFSEL8 ( %bbbb -- x addr ) GPIOC_AFRH ; \ GPIOC_AFRH.AFSEL8, Alternate function selection for port x               bit y (y = 8..15)

\ GPIOC_BRR (write-only) Reset:$00000000
: GPIOC_BRR.BR0 ( -- ) 0 bit GPIOC_BRR ! ; \ GPIOC_BRR.BR0, Port Reset bit
: GPIOC_BRR.BR1 ( -- ) 1 bit GPIOC_BRR ! ; \ GPIOC_BRR.BR1, Port Reset bit
: GPIOC_BRR.BR2 ( -- ) 2 bit GPIOC_BRR ! ; \ GPIOC_BRR.BR2, Port Reset bit
: GPIOC_BRR.BR3 ( -- ) 3 bit GPIOC_BRR ! ; \ GPIOC_BRR.BR3, Port Reset bit
: GPIOC_BRR.BR4 ( -- ) 4 bit GPIOC_BRR ! ; \ GPIOC_BRR.BR4, Port Reset bit
: GPIOC_BRR.BR5 ( -- ) 5 bit GPIOC_BRR ! ; \ GPIOC_BRR.BR5, Port Reset bit
: GPIOC_BRR.BR6 ( -- ) 6 bit GPIOC_BRR ! ; \ GPIOC_BRR.BR6, Port Reset bit
: GPIOC_BRR.BR7 ( -- ) 7 bit GPIOC_BRR ! ; \ GPIOC_BRR.BR7, Port Reset bit
: GPIOC_BRR.BR8 ( -- ) 8 bit GPIOC_BRR ! ; \ GPIOC_BRR.BR8, Port Reset bit
: GPIOC_BRR.BR9 ( -- ) 9 bit GPIOC_BRR ! ; \ GPIOC_BRR.BR9, Port Reset bit
: GPIOC_BRR.BR10 ( -- ) 10 bit GPIOC_BRR ! ; \ GPIOC_BRR.BR10, Port Reset bit
: GPIOC_BRR.BR11 ( -- ) 11 bit GPIOC_BRR ! ; \ GPIOC_BRR.BR11, Port Reset bit
: GPIOC_BRR.BR12 ( -- ) 12 bit GPIOC_BRR ! ; \ GPIOC_BRR.BR12, Port Reset bit
: GPIOC_BRR.BR13 ( -- ) 13 bit GPIOC_BRR ! ; \ GPIOC_BRR.BR13, Port Reset bit
: GPIOC_BRR.BR14 ( -- ) 14 bit GPIOC_BRR ! ; \ GPIOC_BRR.BR14, Port Reset bit
: GPIOC_BRR.BR15 ( -- ) 15 bit GPIOC_BRR ! ; \ GPIOC_BRR.BR15, Port Reset bit

\ GPIOD_MODER (read-write) Reset:$FFFFFFFF
: GPIOD_MODER.MODER15 ( %bb -- x addr ) 30 lshift GPIOD_MODER ; \ GPIOD_MODER.MODER15, Port x configuration bits (y =               0..15)
: GPIOD_MODER.MODER14 ( %bb -- x addr ) 28 lshift GPIOD_MODER ; \ GPIOD_MODER.MODER14, Port x configuration bits (y =               0..15)
: GPIOD_MODER.MODER13 ( %bb -- x addr ) 26 lshift GPIOD_MODER ; \ GPIOD_MODER.MODER13, Port x configuration bits (y =               0..15)
: GPIOD_MODER.MODER12 ( %bb -- x addr ) 24 lshift GPIOD_MODER ; \ GPIOD_MODER.MODER12, Port x configuration bits (y =               0..15)
: GPIOD_MODER.MODER11 ( %bb -- x addr ) 22 lshift GPIOD_MODER ; \ GPIOD_MODER.MODER11, Port x configuration bits (y =               0..15)
: GPIOD_MODER.MODER10 ( %bb -- x addr ) 20 lshift GPIOD_MODER ; \ GPIOD_MODER.MODER10, Port x configuration bits (y =               0..15)
: GPIOD_MODER.MODER9 ( %bb -- x addr ) 18 lshift GPIOD_MODER ; \ GPIOD_MODER.MODER9, Port x configuration bits (y =               0..15)
: GPIOD_MODER.MODER8 ( %bb -- x addr ) 16 lshift GPIOD_MODER ; \ GPIOD_MODER.MODER8, Port x configuration bits (y =               0..15)
: GPIOD_MODER.MODER7 ( %bb -- x addr ) 14 lshift GPIOD_MODER ; \ GPIOD_MODER.MODER7, Port x configuration bits (y =               0..15)
: GPIOD_MODER.MODER6 ( %bb -- x addr ) 12 lshift GPIOD_MODER ; \ GPIOD_MODER.MODER6, Port x configuration bits (y =               0..15)
: GPIOD_MODER.MODER5 ( %bb -- x addr ) 10 lshift GPIOD_MODER ; \ GPIOD_MODER.MODER5, Port x configuration bits (y =               0..15)
: GPIOD_MODER.MODER4 ( %bb -- x addr ) 8 lshift GPIOD_MODER ; \ GPIOD_MODER.MODER4, Port x configuration bits (y =               0..15)
: GPIOD_MODER.MODER3 ( %bb -- x addr ) 6 lshift GPIOD_MODER ; \ GPIOD_MODER.MODER3, Port x configuration bits (y =               0..15)
: GPIOD_MODER.MODER2 ( %bb -- x addr ) 4 lshift GPIOD_MODER ; \ GPIOD_MODER.MODER2, Port x configuration bits (y =               0..15)
: GPIOD_MODER.MODER1 ( %bb -- x addr ) 2 lshift GPIOD_MODER ; \ GPIOD_MODER.MODER1, Port x configuration bits (y =               0..15)
: GPIOD_MODER.MODER0 ( %bb -- x addr ) GPIOD_MODER ; \ GPIOD_MODER.MODER0, Port x configuration bits (y =               0..15)

\ GPIOD_OTYPER (read-write) Reset:$00000000
: GPIOD_OTYPER.OT15 ( -- x addr ) 15 bit GPIOD_OTYPER ; \ GPIOD_OTYPER.OT15, Port x configuration bits (y =               0..15)
: GPIOD_OTYPER.OT14 ( -- x addr ) 14 bit GPIOD_OTYPER ; \ GPIOD_OTYPER.OT14, Port x configuration bits (y =               0..15)
: GPIOD_OTYPER.OT13 ( -- x addr ) 13 bit GPIOD_OTYPER ; \ GPIOD_OTYPER.OT13, Port x configuration bits (y =               0..15)
: GPIOD_OTYPER.OT12 ( -- x addr ) 12 bit GPIOD_OTYPER ; \ GPIOD_OTYPER.OT12, Port x configuration bits (y =               0..15)
: GPIOD_OTYPER.OT11 ( -- x addr ) 11 bit GPIOD_OTYPER ; \ GPIOD_OTYPER.OT11, Port x configuration bits (y =               0..15)
: GPIOD_OTYPER.OT10 ( -- x addr ) 10 bit GPIOD_OTYPER ; \ GPIOD_OTYPER.OT10, Port x configuration bits (y =               0..15)
: GPIOD_OTYPER.OT9 ( -- x addr ) 9 bit GPIOD_OTYPER ; \ GPIOD_OTYPER.OT9, Port x configuration bits (y =               0..15)
: GPIOD_OTYPER.OT8 ( -- x addr ) 8 bit GPIOD_OTYPER ; \ GPIOD_OTYPER.OT8, Port x configuration bits (y =               0..15)
: GPIOD_OTYPER.OT7 ( -- x addr ) 7 bit GPIOD_OTYPER ; \ GPIOD_OTYPER.OT7, Port x configuration bits (y =               0..15)
: GPIOD_OTYPER.OT6 ( -- x addr ) 6 bit GPIOD_OTYPER ; \ GPIOD_OTYPER.OT6, Port x configuration bits (y =               0..15)
: GPIOD_OTYPER.OT5 ( -- x addr ) 5 bit GPIOD_OTYPER ; \ GPIOD_OTYPER.OT5, Port x configuration bits (y =               0..15)
: GPIOD_OTYPER.OT4 ( -- x addr ) 4 bit GPIOD_OTYPER ; \ GPIOD_OTYPER.OT4, Port x configuration bits (y =               0..15)
: GPIOD_OTYPER.OT3 ( -- x addr ) 3 bit GPIOD_OTYPER ; \ GPIOD_OTYPER.OT3, Port x configuration bits (y =               0..15)
: GPIOD_OTYPER.OT2 ( -- x addr ) 2 bit GPIOD_OTYPER ; \ GPIOD_OTYPER.OT2, Port x configuration bits (y =               0..15)
: GPIOD_OTYPER.OT1 ( -- x addr ) 1 bit GPIOD_OTYPER ; \ GPIOD_OTYPER.OT1, Port x configuration bits (y =               0..15)
: GPIOD_OTYPER.OT0 ( -- x addr ) 0 bit GPIOD_OTYPER ; \ GPIOD_OTYPER.OT0, Port x configuration bits (y =               0..15)

\ GPIOD_OSPEEDR (read-write) Reset:$00000000
: GPIOD_OSPEEDR.OSPEEDR15 ( %bb -- x addr ) 30 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR.OSPEEDR15, Port x configuration bits (y =               0..15)
: GPIOD_OSPEEDR.OSPEEDR14 ( %bb -- x addr ) 28 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR.OSPEEDR14, Port x configuration bits (y =               0..15)
: GPIOD_OSPEEDR.OSPEEDR13 ( %bb -- x addr ) 26 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR.OSPEEDR13, Port x configuration bits (y =               0..15)
: GPIOD_OSPEEDR.OSPEEDR12 ( %bb -- x addr ) 24 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR.OSPEEDR12, Port x configuration bits (y =               0..15)
: GPIOD_OSPEEDR.OSPEEDR11 ( %bb -- x addr ) 22 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR.OSPEEDR11, Port x configuration bits (y =               0..15)
: GPIOD_OSPEEDR.OSPEEDR10 ( %bb -- x addr ) 20 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR.OSPEEDR10, Port x configuration bits (y =               0..15)
: GPIOD_OSPEEDR.OSPEEDR9 ( %bb -- x addr ) 18 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR.OSPEEDR9, Port x configuration bits (y =               0..15)
: GPIOD_OSPEEDR.OSPEEDR8 ( %bb -- x addr ) 16 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR.OSPEEDR8, Port x configuration bits (y =               0..15)
: GPIOD_OSPEEDR.OSPEEDR7 ( %bb -- x addr ) 14 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR.OSPEEDR7, Port x configuration bits (y =               0..15)
: GPIOD_OSPEEDR.OSPEEDR6 ( %bb -- x addr ) 12 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR.OSPEEDR6, Port x configuration bits (y =               0..15)
: GPIOD_OSPEEDR.OSPEEDR5 ( %bb -- x addr ) 10 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR.OSPEEDR5, Port x configuration bits (y =               0..15)
: GPIOD_OSPEEDR.OSPEEDR4 ( %bb -- x addr ) 8 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR.OSPEEDR4, Port x configuration bits (y =               0..15)
: GPIOD_OSPEEDR.OSPEEDR3 ( %bb -- x addr ) 6 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR.OSPEEDR3, Port x configuration bits (y =               0..15)
: GPIOD_OSPEEDR.OSPEEDR2 ( %bb -- x addr ) 4 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR.OSPEEDR2, Port x configuration bits (y =               0..15)
: GPIOD_OSPEEDR.OSPEEDR1 ( %bb -- x addr ) 2 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR.OSPEEDR1, Port x configuration bits (y =               0..15)
: GPIOD_OSPEEDR.OSPEEDR0 ( %bb -- x addr ) GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR.OSPEEDR0, Port x configuration bits (y =               0..15)

\ GPIOD_PUPDR (read-write) Reset:$00000000
: GPIOD_PUPDR.PUPDR15 ( %bb -- x addr ) 30 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR.PUPDR15, Port x configuration bits (y =               0..15)
: GPIOD_PUPDR.PUPDR14 ( %bb -- x addr ) 28 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR.PUPDR14, Port x configuration bits (y =               0..15)
: GPIOD_PUPDR.PUPDR13 ( %bb -- x addr ) 26 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR.PUPDR13, Port x configuration bits (y =               0..15)
: GPIOD_PUPDR.PUPDR12 ( %bb -- x addr ) 24 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR.PUPDR12, Port x configuration bits (y =               0..15)
: GPIOD_PUPDR.PUPDR11 ( %bb -- x addr ) 22 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR.PUPDR11, Port x configuration bits (y =               0..15)
: GPIOD_PUPDR.PUPDR10 ( %bb -- x addr ) 20 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR.PUPDR10, Port x configuration bits (y =               0..15)
: GPIOD_PUPDR.PUPDR9 ( %bb -- x addr ) 18 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR.PUPDR9, Port x configuration bits (y =               0..15)
: GPIOD_PUPDR.PUPDR8 ( %bb -- x addr ) 16 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR.PUPDR8, Port x configuration bits (y =               0..15)
: GPIOD_PUPDR.PUPDR7 ( %bb -- x addr ) 14 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR.PUPDR7, Port x configuration bits (y =               0..15)
: GPIOD_PUPDR.PUPDR6 ( %bb -- x addr ) 12 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR.PUPDR6, Port x configuration bits (y =               0..15)
: GPIOD_PUPDR.PUPDR5 ( %bb -- x addr ) 10 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR.PUPDR5, Port x configuration bits (y =               0..15)
: GPIOD_PUPDR.PUPDR4 ( %bb -- x addr ) 8 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR.PUPDR4, Port x configuration bits (y =               0..15)
: GPIOD_PUPDR.PUPDR3 ( %bb -- x addr ) 6 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR.PUPDR3, Port x configuration bits (y =               0..15)
: GPIOD_PUPDR.PUPDR2 ( %bb -- x addr ) 4 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR.PUPDR2, Port x configuration bits (y =               0..15)
: GPIOD_PUPDR.PUPDR1 ( %bb -- x addr ) 2 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR.PUPDR1, Port x configuration bits (y =               0..15)
: GPIOD_PUPDR.PUPDR0 ( %bb -- x addr ) GPIOD_PUPDR ; \ GPIOD_PUPDR.PUPDR0, Port x configuration bits (y =               0..15)

\ GPIOD_IDR (read-only) Reset:$00000000
: GPIOD_IDR.IDR15? ( --  1|0 ) 15 bit GPIOD_IDR bit@ ; \ GPIOD_IDR.IDR15, Port input data (y =               0..15)
: GPIOD_IDR.IDR14? ( --  1|0 ) 14 bit GPIOD_IDR bit@ ; \ GPIOD_IDR.IDR14, Port input data (y =               0..15)
: GPIOD_IDR.IDR13? ( --  1|0 ) 13 bit GPIOD_IDR bit@ ; \ GPIOD_IDR.IDR13, Port input data (y =               0..15)
: GPIOD_IDR.IDR12? ( --  1|0 ) 12 bit GPIOD_IDR bit@ ; \ GPIOD_IDR.IDR12, Port input data (y =               0..15)
: GPIOD_IDR.IDR11? ( --  1|0 ) 11 bit GPIOD_IDR bit@ ; \ GPIOD_IDR.IDR11, Port input data (y =               0..15)
: GPIOD_IDR.IDR10? ( --  1|0 ) 10 bit GPIOD_IDR bit@ ; \ GPIOD_IDR.IDR10, Port input data (y =               0..15)
: GPIOD_IDR.IDR9? ( --  1|0 ) 9 bit GPIOD_IDR bit@ ; \ GPIOD_IDR.IDR9, Port input data (y =               0..15)
: GPIOD_IDR.IDR8? ( --  1|0 ) 8 bit GPIOD_IDR bit@ ; \ GPIOD_IDR.IDR8, Port input data (y =               0..15)
: GPIOD_IDR.IDR7? ( --  1|0 ) 7 bit GPIOD_IDR bit@ ; \ GPIOD_IDR.IDR7, Port input data (y =               0..15)
: GPIOD_IDR.IDR6? ( --  1|0 ) 6 bit GPIOD_IDR bit@ ; \ GPIOD_IDR.IDR6, Port input data (y =               0..15)
: GPIOD_IDR.IDR5? ( --  1|0 ) 5 bit GPIOD_IDR bit@ ; \ GPIOD_IDR.IDR5, Port input data (y =               0..15)
: GPIOD_IDR.IDR4? ( --  1|0 ) 4 bit GPIOD_IDR bit@ ; \ GPIOD_IDR.IDR4, Port input data (y =               0..15)
: GPIOD_IDR.IDR3? ( --  1|0 ) 3 bit GPIOD_IDR bit@ ; \ GPIOD_IDR.IDR3, Port input data (y =               0..15)
: GPIOD_IDR.IDR2? ( --  1|0 ) 2 bit GPIOD_IDR bit@ ; \ GPIOD_IDR.IDR2, Port input data (y =               0..15)
: GPIOD_IDR.IDR1? ( --  1|0 ) 1 bit GPIOD_IDR bit@ ; \ GPIOD_IDR.IDR1, Port input data (y =               0..15)
: GPIOD_IDR.IDR0? ( --  1|0 ) 0 bit GPIOD_IDR bit@ ; \ GPIOD_IDR.IDR0, Port input data (y =               0..15)

\ GPIOD_ODR (read-write) Reset:$00000000
: GPIOD_ODR.ODR15 ( -- x addr ) 15 bit GPIOD_ODR ; \ GPIOD_ODR.ODR15, Port output data (y =               0..15)
: GPIOD_ODR.ODR14 ( -- x addr ) 14 bit GPIOD_ODR ; \ GPIOD_ODR.ODR14, Port output data (y =               0..15)
: GPIOD_ODR.ODR13 ( -- x addr ) 13 bit GPIOD_ODR ; \ GPIOD_ODR.ODR13, Port output data (y =               0..15)
: GPIOD_ODR.ODR12 ( -- x addr ) 12 bit GPIOD_ODR ; \ GPIOD_ODR.ODR12, Port output data (y =               0..15)
: GPIOD_ODR.ODR11 ( -- x addr ) 11 bit GPIOD_ODR ; \ GPIOD_ODR.ODR11, Port output data (y =               0..15)
: GPIOD_ODR.ODR10 ( -- x addr ) 10 bit GPIOD_ODR ; \ GPIOD_ODR.ODR10, Port output data (y =               0..15)
: GPIOD_ODR.ODR9 ( -- x addr ) 9 bit GPIOD_ODR ; \ GPIOD_ODR.ODR9, Port output data (y =               0..15)
: GPIOD_ODR.ODR8 ( -- x addr ) 8 bit GPIOD_ODR ; \ GPIOD_ODR.ODR8, Port output data (y =               0..15)
: GPIOD_ODR.ODR7 ( -- x addr ) 7 bit GPIOD_ODR ; \ GPIOD_ODR.ODR7, Port output data (y =               0..15)
: GPIOD_ODR.ODR6 ( -- x addr ) 6 bit GPIOD_ODR ; \ GPIOD_ODR.ODR6, Port output data (y =               0..15)
: GPIOD_ODR.ODR5 ( -- x addr ) 5 bit GPIOD_ODR ; \ GPIOD_ODR.ODR5, Port output data (y =               0..15)
: GPIOD_ODR.ODR4 ( -- x addr ) 4 bit GPIOD_ODR ; \ GPIOD_ODR.ODR4, Port output data (y =               0..15)
: GPIOD_ODR.ODR3 ( -- x addr ) 3 bit GPIOD_ODR ; \ GPIOD_ODR.ODR3, Port output data (y =               0..15)
: GPIOD_ODR.ODR2 ( -- x addr ) 2 bit GPIOD_ODR ; \ GPIOD_ODR.ODR2, Port output data (y =               0..15)
: GPIOD_ODR.ODR1 ( -- x addr ) 1 bit GPIOD_ODR ; \ GPIOD_ODR.ODR1, Port output data (y =               0..15)
: GPIOD_ODR.ODR0 ( -- x addr ) 0 bit GPIOD_ODR ; \ GPIOD_ODR.ODR0, Port output data (y =               0..15)

\ GPIOD_BSRR (write-only) Reset:$00000000
: GPIOD_BSRR.BR15 ( -- ) 31 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BR15, Port x reset bit y (y =               0..15)
: GPIOD_BSRR.BR14 ( -- ) 30 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BR14, Port x reset bit y (y =               0..15)
: GPIOD_BSRR.BR13 ( -- ) 29 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BR13, Port x reset bit y (y =               0..15)
: GPIOD_BSRR.BR12 ( -- ) 28 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BR12, Port x reset bit y (y =               0..15)
: GPIOD_BSRR.BR11 ( -- ) 27 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BR11, Port x reset bit y (y =               0..15)
: GPIOD_BSRR.BR10 ( -- ) 26 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BR10, Port x reset bit y (y =               0..15)
: GPIOD_BSRR.BR9 ( -- ) 25 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BR9, Port x reset bit y (y =               0..15)
: GPIOD_BSRR.BR8 ( -- ) 24 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BR8, Port x reset bit y (y =               0..15)
: GPIOD_BSRR.BR7 ( -- ) 23 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BR7, Port x reset bit y (y =               0..15)
: GPIOD_BSRR.BR6 ( -- ) 22 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BR6, Port x reset bit y (y =               0..15)
: GPIOD_BSRR.BR5 ( -- ) 21 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BR5, Port x reset bit y (y =               0..15)
: GPIOD_BSRR.BR4 ( -- ) 20 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BR4, Port x reset bit y (y =               0..15)
: GPIOD_BSRR.BR3 ( -- ) 19 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BR3, Port x reset bit y (y =               0..15)
: GPIOD_BSRR.BR2 ( -- ) 18 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BR2, Port x reset bit y (y =               0..15)
: GPIOD_BSRR.BR1 ( -- ) 17 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BR1, Port x reset bit y (y =               0..15)
: GPIOD_BSRR.BR0 ( -- ) 16 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BR0, Port x set bit y (y=               0..15)
: GPIOD_BSRR.BS15 ( -- ) 15 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BS15, Port x set bit y (y=               0..15)
: GPIOD_BSRR.BS14 ( -- ) 14 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BS14, Port x set bit y (y=               0..15)
: GPIOD_BSRR.BS13 ( -- ) 13 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BS13, Port x set bit y (y=               0..15)
: GPIOD_BSRR.BS12 ( -- ) 12 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BS12, Port x set bit y (y=               0..15)
: GPIOD_BSRR.BS11 ( -- ) 11 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BS11, Port x set bit y (y=               0..15)
: GPIOD_BSRR.BS10 ( -- ) 10 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BS10, Port x set bit y (y=               0..15)
: GPIOD_BSRR.BS9 ( -- ) 9 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BS9, Port x set bit y (y=               0..15)
: GPIOD_BSRR.BS8 ( -- ) 8 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BS8, Port x set bit y (y=               0..15)
: GPIOD_BSRR.BS7 ( -- ) 7 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BS7, Port x set bit y (y=               0..15)
: GPIOD_BSRR.BS6 ( -- ) 6 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BS6, Port x set bit y (y=               0..15)
: GPIOD_BSRR.BS5 ( -- ) 5 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BS5, Port x set bit y (y=               0..15)
: GPIOD_BSRR.BS4 ( -- ) 4 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BS4, Port x set bit y (y=               0..15)
: GPIOD_BSRR.BS3 ( -- ) 3 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BS3, Port x set bit y (y=               0..15)
: GPIOD_BSRR.BS2 ( -- ) 2 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BS2, Port x set bit y (y=               0..15)
: GPIOD_BSRR.BS1 ( -- ) 1 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BS1, Port x set bit y (y=               0..15)
: GPIOD_BSRR.BS0 ( -- ) 0 bit GPIOD_BSRR ! ; \ GPIOD_BSRR.BS0, Port x set bit y (y=               0..15)

\ GPIOD_LCKR (read-write) Reset:$00000000
: GPIOD_LCKR.LCKK ( -- x addr ) 16 bit GPIOD_LCKR ; \ GPIOD_LCKR.LCKK, Port x lock bit y (y=               0..15)
: GPIOD_LCKR.LCK15 ( -- x addr ) 15 bit GPIOD_LCKR ; \ GPIOD_LCKR.LCK15, Port x lock bit y (y=               0..15)
: GPIOD_LCKR.LCK14 ( -- x addr ) 14 bit GPIOD_LCKR ; \ GPIOD_LCKR.LCK14, Port x lock bit y (y=               0..15)
: GPIOD_LCKR.LCK13 ( -- x addr ) 13 bit GPIOD_LCKR ; \ GPIOD_LCKR.LCK13, Port x lock bit y (y=               0..15)
: GPIOD_LCKR.LCK12 ( -- x addr ) 12 bit GPIOD_LCKR ; \ GPIOD_LCKR.LCK12, Port x lock bit y (y=               0..15)
: GPIOD_LCKR.LCK11 ( -- x addr ) 11 bit GPIOD_LCKR ; \ GPIOD_LCKR.LCK11, Port x lock bit y (y=               0..15)
: GPIOD_LCKR.LCK10 ( -- x addr ) 10 bit GPIOD_LCKR ; \ GPIOD_LCKR.LCK10, Port x lock bit y (y=               0..15)
: GPIOD_LCKR.LCK9 ( -- x addr ) 9 bit GPIOD_LCKR ; \ GPIOD_LCKR.LCK9, Port x lock bit y (y=               0..15)
: GPIOD_LCKR.LCK8 ( -- x addr ) 8 bit GPIOD_LCKR ; \ GPIOD_LCKR.LCK8, Port x lock bit y (y=               0..15)
: GPIOD_LCKR.LCK7 ( -- x addr ) 7 bit GPIOD_LCKR ; \ GPIOD_LCKR.LCK7, Port x lock bit y (y=               0..15)
: GPIOD_LCKR.LCK6 ( -- x addr ) 6 bit GPIOD_LCKR ; \ GPIOD_LCKR.LCK6, Port x lock bit y (y=               0..15)
: GPIOD_LCKR.LCK5 ( -- x addr ) 5 bit GPIOD_LCKR ; \ GPIOD_LCKR.LCK5, Port x lock bit y (y=               0..15)
: GPIOD_LCKR.LCK4 ( -- x addr ) 4 bit GPIOD_LCKR ; \ GPIOD_LCKR.LCK4, Port x lock bit y (y=               0..15)
: GPIOD_LCKR.LCK3 ( -- x addr ) 3 bit GPIOD_LCKR ; \ GPIOD_LCKR.LCK3, Port x lock bit y (y=               0..15)
: GPIOD_LCKR.LCK2 ( -- x addr ) 2 bit GPIOD_LCKR ; \ GPIOD_LCKR.LCK2, Port x lock bit y (y=               0..15)
: GPIOD_LCKR.LCK1 ( -- x addr ) 1 bit GPIOD_LCKR ; \ GPIOD_LCKR.LCK1, Port x lock bit y (y=               0..15)
: GPIOD_LCKR.LCK0 ( -- x addr ) 0 bit GPIOD_LCKR ; \ GPIOD_LCKR.LCK0, Port x lock bit y (y=               0..15)

\ GPIOD_AFRL (read-write) Reset:$00000000
: GPIOD_AFRL.AFSEL7 ( %bbbb -- x addr ) 28 lshift GPIOD_AFRL ; \ GPIOD_AFRL.AFSEL7, Alternate function selection for port x               bit y (y = 0..7)
: GPIOD_AFRL.AFSEL6 ( %bbbb -- x addr ) 24 lshift GPIOD_AFRL ; \ GPIOD_AFRL.AFSEL6, Alternate function selection for port x               bit y (y = 0..7)
: GPIOD_AFRL.AFSEL5 ( %bbbb -- x addr ) 20 lshift GPIOD_AFRL ; \ GPIOD_AFRL.AFSEL5, Alternate function selection for port x               bit y (y = 0..7)
: GPIOD_AFRL.AFSEL4 ( %bbbb -- x addr ) 16 lshift GPIOD_AFRL ; \ GPIOD_AFRL.AFSEL4, Alternate function selection for port x               bit y (y = 0..7)
: GPIOD_AFRL.AFSEL3 ( %bbbb -- x addr ) 12 lshift GPIOD_AFRL ; \ GPIOD_AFRL.AFSEL3, Alternate function selection for port x               bit y (y = 0..7)
: GPIOD_AFRL.AFSEL2 ( %bbbb -- x addr ) 8 lshift GPIOD_AFRL ; \ GPIOD_AFRL.AFSEL2, Alternate function selection for port x               bit y (y = 0..7)
: GPIOD_AFRL.AFSEL1 ( %bbbb -- x addr ) 4 lshift GPIOD_AFRL ; \ GPIOD_AFRL.AFSEL1, Alternate function selection for port x               bit y (y = 0..7)
: GPIOD_AFRL.AFSEL0 ( %bbbb -- x addr ) GPIOD_AFRL ; \ GPIOD_AFRL.AFSEL0, Alternate function selection for port x               bit y (y = 0..7)

\ GPIOD_AFRH (read-write) Reset:$00000000
: GPIOD_AFRH.AFSEL15 ( %bbbb -- x addr ) 28 lshift GPIOD_AFRH ; \ GPIOD_AFRH.AFSEL15, Alternate function selection for port x               bit y (y = 8..15)
: GPIOD_AFRH.AFSEL14 ( %bbbb -- x addr ) 24 lshift GPIOD_AFRH ; \ GPIOD_AFRH.AFSEL14, Alternate function selection for port x               bit y (y = 8..15)
: GPIOD_AFRH.AFSEL13 ( %bbbb -- x addr ) 20 lshift GPIOD_AFRH ; \ GPIOD_AFRH.AFSEL13, Alternate function selection for port x               bit y (y = 8..15)
: GPIOD_AFRH.AFSEL12 ( %bbbb -- x addr ) 16 lshift GPIOD_AFRH ; \ GPIOD_AFRH.AFSEL12, Alternate function selection for port x               bit y (y = 8..15)
: GPIOD_AFRH.AFSEL11 ( %bbbb -- x addr ) 12 lshift GPIOD_AFRH ; \ GPIOD_AFRH.AFSEL11, Alternate function selection for port x               bit y (y = 8..15)
: GPIOD_AFRH.AFSEL10 ( %bbbb -- x addr ) 8 lshift GPIOD_AFRH ; \ GPIOD_AFRH.AFSEL10, Alternate function selection for port x               bit y (y = 8..15)
: GPIOD_AFRH.AFSEL9 ( %bbbb -- x addr ) 4 lshift GPIOD_AFRH ; \ GPIOD_AFRH.AFSEL9, Alternate function selection for port x               bit y (y = 8..15)
: GPIOD_AFRH.AFSEL8 ( %bbbb -- x addr ) GPIOD_AFRH ; \ GPIOD_AFRH.AFSEL8, Alternate function selection for port x               bit y (y = 8..15)

\ GPIOD_BRR (write-only) Reset:$00000000
: GPIOD_BRR.BR0 ( -- ) 0 bit GPIOD_BRR ! ; \ GPIOD_BRR.BR0, Port Reset bit
: GPIOD_BRR.BR1 ( -- ) 1 bit GPIOD_BRR ! ; \ GPIOD_BRR.BR1, Port Reset bit
: GPIOD_BRR.BR2 ( -- ) 2 bit GPIOD_BRR ! ; \ GPIOD_BRR.BR2, Port Reset bit
: GPIOD_BRR.BR3 ( -- ) 3 bit GPIOD_BRR ! ; \ GPIOD_BRR.BR3, Port Reset bit
: GPIOD_BRR.BR4 ( -- ) 4 bit GPIOD_BRR ! ; \ GPIOD_BRR.BR4, Port Reset bit
: GPIOD_BRR.BR5 ( -- ) 5 bit GPIOD_BRR ! ; \ GPIOD_BRR.BR5, Port Reset bit
: GPIOD_BRR.BR6 ( -- ) 6 bit GPIOD_BRR ! ; \ GPIOD_BRR.BR6, Port Reset bit
: GPIOD_BRR.BR7 ( -- ) 7 bit GPIOD_BRR ! ; \ GPIOD_BRR.BR7, Port Reset bit
: GPIOD_BRR.BR8 ( -- ) 8 bit GPIOD_BRR ! ; \ GPIOD_BRR.BR8, Port Reset bit
: GPIOD_BRR.BR9 ( -- ) 9 bit GPIOD_BRR ! ; \ GPIOD_BRR.BR9, Port Reset bit
: GPIOD_BRR.BR10 ( -- ) 10 bit GPIOD_BRR ! ; \ GPIOD_BRR.BR10, Port Reset bit
: GPIOD_BRR.BR11 ( -- ) 11 bit GPIOD_BRR ! ; \ GPIOD_BRR.BR11, Port Reset bit
: GPIOD_BRR.BR12 ( -- ) 12 bit GPIOD_BRR ! ; \ GPIOD_BRR.BR12, Port Reset bit
: GPIOD_BRR.BR13 ( -- ) 13 bit GPIOD_BRR ! ; \ GPIOD_BRR.BR13, Port Reset bit
: GPIOD_BRR.BR14 ( -- ) 14 bit GPIOD_BRR ! ; \ GPIOD_BRR.BR14, Port Reset bit
: GPIOD_BRR.BR15 ( -- ) 15 bit GPIOD_BRR ! ; \ GPIOD_BRR.BR15, Port Reset bit

\ GPIOF_MODER (read-write) Reset:$FFFFFFFF
: GPIOF_MODER.MODER15 ( %bb -- x addr ) 30 lshift GPIOF_MODER ; \ GPIOF_MODER.MODER15, Port x configuration bits (y =               0..15)
: GPIOF_MODER.MODER14 ( %bb -- x addr ) 28 lshift GPIOF_MODER ; \ GPIOF_MODER.MODER14, Port x configuration bits (y =               0..15)
: GPIOF_MODER.MODER13 ( %bb -- x addr ) 26 lshift GPIOF_MODER ; \ GPIOF_MODER.MODER13, Port x configuration bits (y =               0..15)
: GPIOF_MODER.MODER12 ( %bb -- x addr ) 24 lshift GPIOF_MODER ; \ GPIOF_MODER.MODER12, Port x configuration bits (y =               0..15)
: GPIOF_MODER.MODER11 ( %bb -- x addr ) 22 lshift GPIOF_MODER ; \ GPIOF_MODER.MODER11, Port x configuration bits (y =               0..15)
: GPIOF_MODER.MODER10 ( %bb -- x addr ) 20 lshift GPIOF_MODER ; \ GPIOF_MODER.MODER10, Port x configuration bits (y =               0..15)
: GPIOF_MODER.MODER9 ( %bb -- x addr ) 18 lshift GPIOF_MODER ; \ GPIOF_MODER.MODER9, Port x configuration bits (y =               0..15)
: GPIOF_MODER.MODER8 ( %bb -- x addr ) 16 lshift GPIOF_MODER ; \ GPIOF_MODER.MODER8, Port x configuration bits (y =               0..15)
: GPIOF_MODER.MODER7 ( %bb -- x addr ) 14 lshift GPIOF_MODER ; \ GPIOF_MODER.MODER7, Port x configuration bits (y =               0..15)
: GPIOF_MODER.MODER6 ( %bb -- x addr ) 12 lshift GPIOF_MODER ; \ GPIOF_MODER.MODER6, Port x configuration bits (y =               0..15)
: GPIOF_MODER.MODER5 ( %bb -- x addr ) 10 lshift GPIOF_MODER ; \ GPIOF_MODER.MODER5, Port x configuration bits (y =               0..15)
: GPIOF_MODER.MODER4 ( %bb -- x addr ) 8 lshift GPIOF_MODER ; \ GPIOF_MODER.MODER4, Port x configuration bits (y =               0..15)
: GPIOF_MODER.MODER3 ( %bb -- x addr ) 6 lshift GPIOF_MODER ; \ GPIOF_MODER.MODER3, Port x configuration bits (y =               0..15)
: GPIOF_MODER.MODER2 ( %bb -- x addr ) 4 lshift GPIOF_MODER ; \ GPIOF_MODER.MODER2, Port x configuration bits (y =               0..15)
: GPIOF_MODER.MODER1 ( %bb -- x addr ) 2 lshift GPIOF_MODER ; \ GPIOF_MODER.MODER1, Port x configuration bits (y =               0..15)
: GPIOF_MODER.MODER0 ( %bb -- x addr ) GPIOF_MODER ; \ GPIOF_MODER.MODER0, Port x configuration bits (y =               0..15)

\ GPIOF_OTYPER (read-write) Reset:$00000000
: GPIOF_OTYPER.OT15 ( -- x addr ) 15 bit GPIOF_OTYPER ; \ GPIOF_OTYPER.OT15, Port x configuration bits (y =               0..15)
: GPIOF_OTYPER.OT14 ( -- x addr ) 14 bit GPIOF_OTYPER ; \ GPIOF_OTYPER.OT14, Port x configuration bits (y =               0..15)
: GPIOF_OTYPER.OT13 ( -- x addr ) 13 bit GPIOF_OTYPER ; \ GPIOF_OTYPER.OT13, Port x configuration bits (y =               0..15)
: GPIOF_OTYPER.OT12 ( -- x addr ) 12 bit GPIOF_OTYPER ; \ GPIOF_OTYPER.OT12, Port x configuration bits (y =               0..15)
: GPIOF_OTYPER.OT11 ( -- x addr ) 11 bit GPIOF_OTYPER ; \ GPIOF_OTYPER.OT11, Port x configuration bits (y =               0..15)
: GPIOF_OTYPER.OT10 ( -- x addr ) 10 bit GPIOF_OTYPER ; \ GPIOF_OTYPER.OT10, Port x configuration bits (y =               0..15)
: GPIOF_OTYPER.OT9 ( -- x addr ) 9 bit GPIOF_OTYPER ; \ GPIOF_OTYPER.OT9, Port x configuration bits (y =               0..15)
: GPIOF_OTYPER.OT8 ( -- x addr ) 8 bit GPIOF_OTYPER ; \ GPIOF_OTYPER.OT8, Port x configuration bits (y =               0..15)
: GPIOF_OTYPER.OT7 ( -- x addr ) 7 bit GPIOF_OTYPER ; \ GPIOF_OTYPER.OT7, Port x configuration bits (y =               0..15)
: GPIOF_OTYPER.OT6 ( -- x addr ) 6 bit GPIOF_OTYPER ; \ GPIOF_OTYPER.OT6, Port x configuration bits (y =               0..15)
: GPIOF_OTYPER.OT5 ( -- x addr ) 5 bit GPIOF_OTYPER ; \ GPIOF_OTYPER.OT5, Port x configuration bits (y =               0..15)
: GPIOF_OTYPER.OT4 ( -- x addr ) 4 bit GPIOF_OTYPER ; \ GPIOF_OTYPER.OT4, Port x configuration bits (y =               0..15)
: GPIOF_OTYPER.OT3 ( -- x addr ) 3 bit GPIOF_OTYPER ; \ GPIOF_OTYPER.OT3, Port x configuration bits (y =               0..15)
: GPIOF_OTYPER.OT2 ( -- x addr ) 2 bit GPIOF_OTYPER ; \ GPIOF_OTYPER.OT2, Port x configuration bits (y =               0..15)
: GPIOF_OTYPER.OT1 ( -- x addr ) 1 bit GPIOF_OTYPER ; \ GPIOF_OTYPER.OT1, Port x configuration bits (y =               0..15)
: GPIOF_OTYPER.OT0 ( -- x addr ) 0 bit GPIOF_OTYPER ; \ GPIOF_OTYPER.OT0, Port x configuration bits (y =               0..15)

\ GPIOF_OSPEEDR (read-write) Reset:$00000000
: GPIOF_OSPEEDR.OSPEEDR15 ( %bb -- x addr ) 30 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR.OSPEEDR15, Port x configuration bits (y =               0..15)
: GPIOF_OSPEEDR.OSPEEDR14 ( %bb -- x addr ) 28 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR.OSPEEDR14, Port x configuration bits (y =               0..15)
: GPIOF_OSPEEDR.OSPEEDR13 ( %bb -- x addr ) 26 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR.OSPEEDR13, Port x configuration bits (y =               0..15)
: GPIOF_OSPEEDR.OSPEEDR12 ( %bb -- x addr ) 24 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR.OSPEEDR12, Port x configuration bits (y =               0..15)
: GPIOF_OSPEEDR.OSPEEDR11 ( %bb -- x addr ) 22 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR.OSPEEDR11, Port x configuration bits (y =               0..15)
: GPIOF_OSPEEDR.OSPEEDR10 ( %bb -- x addr ) 20 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR.OSPEEDR10, Port x configuration bits (y =               0..15)
: GPIOF_OSPEEDR.OSPEEDR9 ( %bb -- x addr ) 18 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR.OSPEEDR9, Port x configuration bits (y =               0..15)
: GPIOF_OSPEEDR.OSPEEDR8 ( %bb -- x addr ) 16 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR.OSPEEDR8, Port x configuration bits (y =               0..15)
: GPIOF_OSPEEDR.OSPEEDR7 ( %bb -- x addr ) 14 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR.OSPEEDR7, Port x configuration bits (y =               0..15)
: GPIOF_OSPEEDR.OSPEEDR6 ( %bb -- x addr ) 12 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR.OSPEEDR6, Port x configuration bits (y =               0..15)
: GPIOF_OSPEEDR.OSPEEDR5 ( %bb -- x addr ) 10 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR.OSPEEDR5, Port x configuration bits (y =               0..15)
: GPIOF_OSPEEDR.OSPEEDR4 ( %bb -- x addr ) 8 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR.OSPEEDR4, Port x configuration bits (y =               0..15)
: GPIOF_OSPEEDR.OSPEEDR3 ( %bb -- x addr ) 6 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR.OSPEEDR3, Port x configuration bits (y =               0..15)
: GPIOF_OSPEEDR.OSPEEDR2 ( %bb -- x addr ) 4 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR.OSPEEDR2, Port x configuration bits (y =               0..15)
: GPIOF_OSPEEDR.OSPEEDR1 ( %bb -- x addr ) 2 lshift GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR.OSPEEDR1, Port x configuration bits (y =               0..15)
: GPIOF_OSPEEDR.OSPEEDR0 ( %bb -- x addr ) GPIOF_OSPEEDR ; \ GPIOF_OSPEEDR.OSPEEDR0, Port x configuration bits (y =               0..15)

\ GPIOF_PUPDR (read-write) Reset:$00000000
: GPIOF_PUPDR.PUPDR15 ( %bb -- x addr ) 30 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR.PUPDR15, Port x configuration bits (y =               0..15)
: GPIOF_PUPDR.PUPDR14 ( %bb -- x addr ) 28 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR.PUPDR14, Port x configuration bits (y =               0..15)
: GPIOF_PUPDR.PUPDR13 ( %bb -- x addr ) 26 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR.PUPDR13, Port x configuration bits (y =               0..15)
: GPIOF_PUPDR.PUPDR12 ( %bb -- x addr ) 24 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR.PUPDR12, Port x configuration bits (y =               0..15)
: GPIOF_PUPDR.PUPDR11 ( %bb -- x addr ) 22 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR.PUPDR11, Port x configuration bits (y =               0..15)
: GPIOF_PUPDR.PUPDR10 ( %bb -- x addr ) 20 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR.PUPDR10, Port x configuration bits (y =               0..15)
: GPIOF_PUPDR.PUPDR9 ( %bb -- x addr ) 18 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR.PUPDR9, Port x configuration bits (y =               0..15)
: GPIOF_PUPDR.PUPDR8 ( %bb -- x addr ) 16 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR.PUPDR8, Port x configuration bits (y =               0..15)
: GPIOF_PUPDR.PUPDR7 ( %bb -- x addr ) 14 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR.PUPDR7, Port x configuration bits (y =               0..15)
: GPIOF_PUPDR.PUPDR6 ( %bb -- x addr ) 12 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR.PUPDR6, Port x configuration bits (y =               0..15)
: GPIOF_PUPDR.PUPDR5 ( %bb -- x addr ) 10 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR.PUPDR5, Port x configuration bits (y =               0..15)
: GPIOF_PUPDR.PUPDR4 ( %bb -- x addr ) 8 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR.PUPDR4, Port x configuration bits (y =               0..15)
: GPIOF_PUPDR.PUPDR3 ( %bb -- x addr ) 6 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR.PUPDR3, Port x configuration bits (y =               0..15)
: GPIOF_PUPDR.PUPDR2 ( %bb -- x addr ) 4 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR.PUPDR2, Port x configuration bits (y =               0..15)
: GPIOF_PUPDR.PUPDR1 ( %bb -- x addr ) 2 lshift GPIOF_PUPDR ; \ GPIOF_PUPDR.PUPDR1, Port x configuration bits (y =               0..15)
: GPIOF_PUPDR.PUPDR0 ( %bb -- x addr ) GPIOF_PUPDR ; \ GPIOF_PUPDR.PUPDR0, Port x configuration bits (y =               0..15)

\ GPIOF_IDR (read-only) Reset:$00000000
: GPIOF_IDR.IDR15? ( --  1|0 ) 15 bit GPIOF_IDR bit@ ; \ GPIOF_IDR.IDR15, Port input data (y =               0..15)
: GPIOF_IDR.IDR14? ( --  1|0 ) 14 bit GPIOF_IDR bit@ ; \ GPIOF_IDR.IDR14, Port input data (y =               0..15)
: GPIOF_IDR.IDR13? ( --  1|0 ) 13 bit GPIOF_IDR bit@ ; \ GPIOF_IDR.IDR13, Port input data (y =               0..15)
: GPIOF_IDR.IDR12? ( --  1|0 ) 12 bit GPIOF_IDR bit@ ; \ GPIOF_IDR.IDR12, Port input data (y =               0..15)
: GPIOF_IDR.IDR11? ( --  1|0 ) 11 bit GPIOF_IDR bit@ ; \ GPIOF_IDR.IDR11, Port input data (y =               0..15)
: GPIOF_IDR.IDR10? ( --  1|0 ) 10 bit GPIOF_IDR bit@ ; \ GPIOF_IDR.IDR10, Port input data (y =               0..15)
: GPIOF_IDR.IDR9? ( --  1|0 ) 9 bit GPIOF_IDR bit@ ; \ GPIOF_IDR.IDR9, Port input data (y =               0..15)
: GPIOF_IDR.IDR8? ( --  1|0 ) 8 bit GPIOF_IDR bit@ ; \ GPIOF_IDR.IDR8, Port input data (y =               0..15)
: GPIOF_IDR.IDR7? ( --  1|0 ) 7 bit GPIOF_IDR bit@ ; \ GPIOF_IDR.IDR7, Port input data (y =               0..15)
: GPIOF_IDR.IDR6? ( --  1|0 ) 6 bit GPIOF_IDR bit@ ; \ GPIOF_IDR.IDR6, Port input data (y =               0..15)
: GPIOF_IDR.IDR5? ( --  1|0 ) 5 bit GPIOF_IDR bit@ ; \ GPIOF_IDR.IDR5, Port input data (y =               0..15)
: GPIOF_IDR.IDR4? ( --  1|0 ) 4 bit GPIOF_IDR bit@ ; \ GPIOF_IDR.IDR4, Port input data (y =               0..15)
: GPIOF_IDR.IDR3? ( --  1|0 ) 3 bit GPIOF_IDR bit@ ; \ GPIOF_IDR.IDR3, Port input data (y =               0..15)
: GPIOF_IDR.IDR2? ( --  1|0 ) 2 bit GPIOF_IDR bit@ ; \ GPIOF_IDR.IDR2, Port input data (y =               0..15)
: GPIOF_IDR.IDR1? ( --  1|0 ) 1 bit GPIOF_IDR bit@ ; \ GPIOF_IDR.IDR1, Port input data (y =               0..15)
: GPIOF_IDR.IDR0? ( --  1|0 ) 0 bit GPIOF_IDR bit@ ; \ GPIOF_IDR.IDR0, Port input data (y =               0..15)

\ GPIOF_ODR (read-write) Reset:$00000000
: GPIOF_ODR.ODR15 ( -- x addr ) 15 bit GPIOF_ODR ; \ GPIOF_ODR.ODR15, Port output data (y =               0..15)
: GPIOF_ODR.ODR14 ( -- x addr ) 14 bit GPIOF_ODR ; \ GPIOF_ODR.ODR14, Port output data (y =               0..15)
: GPIOF_ODR.ODR13 ( -- x addr ) 13 bit GPIOF_ODR ; \ GPIOF_ODR.ODR13, Port output data (y =               0..15)
: GPIOF_ODR.ODR12 ( -- x addr ) 12 bit GPIOF_ODR ; \ GPIOF_ODR.ODR12, Port output data (y =               0..15)
: GPIOF_ODR.ODR11 ( -- x addr ) 11 bit GPIOF_ODR ; \ GPIOF_ODR.ODR11, Port output data (y =               0..15)
: GPIOF_ODR.ODR10 ( -- x addr ) 10 bit GPIOF_ODR ; \ GPIOF_ODR.ODR10, Port output data (y =               0..15)
: GPIOF_ODR.ODR9 ( -- x addr ) 9 bit GPIOF_ODR ; \ GPIOF_ODR.ODR9, Port output data (y =               0..15)
: GPIOF_ODR.ODR8 ( -- x addr ) 8 bit GPIOF_ODR ; \ GPIOF_ODR.ODR8, Port output data (y =               0..15)
: GPIOF_ODR.ODR7 ( -- x addr ) 7 bit GPIOF_ODR ; \ GPIOF_ODR.ODR7, Port output data (y =               0..15)
: GPIOF_ODR.ODR6 ( -- x addr ) 6 bit GPIOF_ODR ; \ GPIOF_ODR.ODR6, Port output data (y =               0..15)
: GPIOF_ODR.ODR5 ( -- x addr ) 5 bit GPIOF_ODR ; \ GPIOF_ODR.ODR5, Port output data (y =               0..15)
: GPIOF_ODR.ODR4 ( -- x addr ) 4 bit GPIOF_ODR ; \ GPIOF_ODR.ODR4, Port output data (y =               0..15)
: GPIOF_ODR.ODR3 ( -- x addr ) 3 bit GPIOF_ODR ; \ GPIOF_ODR.ODR3, Port output data (y =               0..15)
: GPIOF_ODR.ODR2 ( -- x addr ) 2 bit GPIOF_ODR ; \ GPIOF_ODR.ODR2, Port output data (y =               0..15)
: GPIOF_ODR.ODR1 ( -- x addr ) 1 bit GPIOF_ODR ; \ GPIOF_ODR.ODR1, Port output data (y =               0..15)
: GPIOF_ODR.ODR0 ( -- x addr ) 0 bit GPIOF_ODR ; \ GPIOF_ODR.ODR0, Port output data (y =               0..15)

\ GPIOF_BSRR (write-only) Reset:$00000000
: GPIOF_BSRR.BR15 ( -- ) 31 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BR15, Port x reset bit y (y =               0..15)
: GPIOF_BSRR.BR14 ( -- ) 30 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BR14, Port x reset bit y (y =               0..15)
: GPIOF_BSRR.BR13 ( -- ) 29 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BR13, Port x reset bit y (y =               0..15)
: GPIOF_BSRR.BR12 ( -- ) 28 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BR12, Port x reset bit y (y =               0..15)
: GPIOF_BSRR.BR11 ( -- ) 27 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BR11, Port x reset bit y (y =               0..15)
: GPIOF_BSRR.BR10 ( -- ) 26 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BR10, Port x reset bit y (y =               0..15)
: GPIOF_BSRR.BR9 ( -- ) 25 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BR9, Port x reset bit y (y =               0..15)
: GPIOF_BSRR.BR8 ( -- ) 24 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BR8, Port x reset bit y (y =               0..15)
: GPIOF_BSRR.BR7 ( -- ) 23 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BR7, Port x reset bit y (y =               0..15)
: GPIOF_BSRR.BR6 ( -- ) 22 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BR6, Port x reset bit y (y =               0..15)
: GPIOF_BSRR.BR5 ( -- ) 21 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BR5, Port x reset bit y (y =               0..15)
: GPIOF_BSRR.BR4 ( -- ) 20 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BR4, Port x reset bit y (y =               0..15)
: GPIOF_BSRR.BR3 ( -- ) 19 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BR3, Port x reset bit y (y =               0..15)
: GPIOF_BSRR.BR2 ( -- ) 18 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BR2, Port x reset bit y (y =               0..15)
: GPIOF_BSRR.BR1 ( -- ) 17 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BR1, Port x reset bit y (y =               0..15)
: GPIOF_BSRR.BR0 ( -- ) 16 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BR0, Port x set bit y (y=               0..15)
: GPIOF_BSRR.BS15 ( -- ) 15 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BS15, Port x set bit y (y=               0..15)
: GPIOF_BSRR.BS14 ( -- ) 14 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BS14, Port x set bit y (y=               0..15)
: GPIOF_BSRR.BS13 ( -- ) 13 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BS13, Port x set bit y (y=               0..15)
: GPIOF_BSRR.BS12 ( -- ) 12 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BS12, Port x set bit y (y=               0..15)
: GPIOF_BSRR.BS11 ( -- ) 11 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BS11, Port x set bit y (y=               0..15)
: GPIOF_BSRR.BS10 ( -- ) 10 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BS10, Port x set bit y (y=               0..15)
: GPIOF_BSRR.BS9 ( -- ) 9 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BS9, Port x set bit y (y=               0..15)
: GPIOF_BSRR.BS8 ( -- ) 8 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BS8, Port x set bit y (y=               0..15)
: GPIOF_BSRR.BS7 ( -- ) 7 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BS7, Port x set bit y (y=               0..15)
: GPIOF_BSRR.BS6 ( -- ) 6 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BS6, Port x set bit y (y=               0..15)
: GPIOF_BSRR.BS5 ( -- ) 5 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BS5, Port x set bit y (y=               0..15)
: GPIOF_BSRR.BS4 ( -- ) 4 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BS4, Port x set bit y (y=               0..15)
: GPIOF_BSRR.BS3 ( -- ) 3 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BS3, Port x set bit y (y=               0..15)
: GPIOF_BSRR.BS2 ( -- ) 2 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BS2, Port x set bit y (y=               0..15)
: GPIOF_BSRR.BS1 ( -- ) 1 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BS1, Port x set bit y (y=               0..15)
: GPIOF_BSRR.BS0 ( -- ) 0 bit GPIOF_BSRR ! ; \ GPIOF_BSRR.BS0, Port x set bit y (y=               0..15)

\ GPIOF_LCKR (read-write) Reset:$00000000
: GPIOF_LCKR.LCKK ( -- x addr ) 16 bit GPIOF_LCKR ; \ GPIOF_LCKR.LCKK, Port x lock bit y (y=               0..15)
: GPIOF_LCKR.LCK15 ( -- x addr ) 15 bit GPIOF_LCKR ; \ GPIOF_LCKR.LCK15, Port x lock bit y (y=               0..15)
: GPIOF_LCKR.LCK14 ( -- x addr ) 14 bit GPIOF_LCKR ; \ GPIOF_LCKR.LCK14, Port x lock bit y (y=               0..15)
: GPIOF_LCKR.LCK13 ( -- x addr ) 13 bit GPIOF_LCKR ; \ GPIOF_LCKR.LCK13, Port x lock bit y (y=               0..15)
: GPIOF_LCKR.LCK12 ( -- x addr ) 12 bit GPIOF_LCKR ; \ GPIOF_LCKR.LCK12, Port x lock bit y (y=               0..15)
: GPIOF_LCKR.LCK11 ( -- x addr ) 11 bit GPIOF_LCKR ; \ GPIOF_LCKR.LCK11, Port x lock bit y (y=               0..15)
: GPIOF_LCKR.LCK10 ( -- x addr ) 10 bit GPIOF_LCKR ; \ GPIOF_LCKR.LCK10, Port x lock bit y (y=               0..15)
: GPIOF_LCKR.LCK9 ( -- x addr ) 9 bit GPIOF_LCKR ; \ GPIOF_LCKR.LCK9, Port x lock bit y (y=               0..15)
: GPIOF_LCKR.LCK8 ( -- x addr ) 8 bit GPIOF_LCKR ; \ GPIOF_LCKR.LCK8, Port x lock bit y (y=               0..15)
: GPIOF_LCKR.LCK7 ( -- x addr ) 7 bit GPIOF_LCKR ; \ GPIOF_LCKR.LCK7, Port x lock bit y (y=               0..15)
: GPIOF_LCKR.LCK6 ( -- x addr ) 6 bit GPIOF_LCKR ; \ GPIOF_LCKR.LCK6, Port x lock bit y (y=               0..15)
: GPIOF_LCKR.LCK5 ( -- x addr ) 5 bit GPIOF_LCKR ; \ GPIOF_LCKR.LCK5, Port x lock bit y (y=               0..15)
: GPIOF_LCKR.LCK4 ( -- x addr ) 4 bit GPIOF_LCKR ; \ GPIOF_LCKR.LCK4, Port x lock bit y (y=               0..15)
: GPIOF_LCKR.LCK3 ( -- x addr ) 3 bit GPIOF_LCKR ; \ GPIOF_LCKR.LCK3, Port x lock bit y (y=               0..15)
: GPIOF_LCKR.LCK2 ( -- x addr ) 2 bit GPIOF_LCKR ; \ GPIOF_LCKR.LCK2, Port x lock bit y (y=               0..15)
: GPIOF_LCKR.LCK1 ( -- x addr ) 1 bit GPIOF_LCKR ; \ GPIOF_LCKR.LCK1, Port x lock bit y (y=               0..15)
: GPIOF_LCKR.LCK0 ( -- x addr ) 0 bit GPIOF_LCKR ; \ GPIOF_LCKR.LCK0, Port x lock bit y (y=               0..15)

\ GPIOF_AFRL (read-write) Reset:$00000000
: GPIOF_AFRL.AFSEL7 ( %bbbb -- x addr ) 28 lshift GPIOF_AFRL ; \ GPIOF_AFRL.AFSEL7, Alternate function selection for port x               bit y (y = 0..7)
: GPIOF_AFRL.AFSEL6 ( %bbbb -- x addr ) 24 lshift GPIOF_AFRL ; \ GPIOF_AFRL.AFSEL6, Alternate function selection for port x               bit y (y = 0..7)
: GPIOF_AFRL.AFSEL5 ( %bbbb -- x addr ) 20 lshift GPIOF_AFRL ; \ GPIOF_AFRL.AFSEL5, Alternate function selection for port x               bit y (y = 0..7)
: GPIOF_AFRL.AFSEL4 ( %bbbb -- x addr ) 16 lshift GPIOF_AFRL ; \ GPIOF_AFRL.AFSEL4, Alternate function selection for port x               bit y (y = 0..7)
: GPIOF_AFRL.AFSEL3 ( %bbbb -- x addr ) 12 lshift GPIOF_AFRL ; \ GPIOF_AFRL.AFSEL3, Alternate function selection for port x               bit y (y = 0..7)
: GPIOF_AFRL.AFSEL2 ( %bbbb -- x addr ) 8 lshift GPIOF_AFRL ; \ GPIOF_AFRL.AFSEL2, Alternate function selection for port x               bit y (y = 0..7)
: GPIOF_AFRL.AFSEL1 ( %bbbb -- x addr ) 4 lshift GPIOF_AFRL ; \ GPIOF_AFRL.AFSEL1, Alternate function selection for port x               bit y (y = 0..7)
: GPIOF_AFRL.AFSEL0 ( %bbbb -- x addr ) GPIOF_AFRL ; \ GPIOF_AFRL.AFSEL0, Alternate function selection for port x               bit y (y = 0..7)

\ GPIOF_AFRH (read-write) Reset:$00000000
: GPIOF_AFRH.AFSEL15 ( %bbbb -- x addr ) 28 lshift GPIOF_AFRH ; \ GPIOF_AFRH.AFSEL15, Alternate function selection for port x               bit y (y = 8..15)
: GPIOF_AFRH.AFSEL14 ( %bbbb -- x addr ) 24 lshift GPIOF_AFRH ; \ GPIOF_AFRH.AFSEL14, Alternate function selection for port x               bit y (y = 8..15)
: GPIOF_AFRH.AFSEL13 ( %bbbb -- x addr ) 20 lshift GPIOF_AFRH ; \ GPIOF_AFRH.AFSEL13, Alternate function selection for port x               bit y (y = 8..15)
: GPIOF_AFRH.AFSEL12 ( %bbbb -- x addr ) 16 lshift GPIOF_AFRH ; \ GPIOF_AFRH.AFSEL12, Alternate function selection for port x               bit y (y = 8..15)
: GPIOF_AFRH.AFSEL11 ( %bbbb -- x addr ) 12 lshift GPIOF_AFRH ; \ GPIOF_AFRH.AFSEL11, Alternate function selection for port x               bit y (y = 8..15)
: GPIOF_AFRH.AFSEL10 ( %bbbb -- x addr ) 8 lshift GPIOF_AFRH ; \ GPIOF_AFRH.AFSEL10, Alternate function selection for port x               bit y (y = 8..15)
: GPIOF_AFRH.AFSEL9 ( %bbbb -- x addr ) 4 lshift GPIOF_AFRH ; \ GPIOF_AFRH.AFSEL9, Alternate function selection for port x               bit y (y = 8..15)
: GPIOF_AFRH.AFSEL8 ( %bbbb -- x addr ) GPIOF_AFRH ; \ GPIOF_AFRH.AFSEL8, Alternate function selection for port x               bit y (y = 8..15)

\ GPIOF_BRR (write-only) Reset:$00000000
: GPIOF_BRR.BR0 ( -- ) 0 bit GPIOF_BRR ! ; \ GPIOF_BRR.BR0, Port Reset bit
: GPIOF_BRR.BR1 ( -- ) 1 bit GPIOF_BRR ! ; \ GPIOF_BRR.BR1, Port Reset bit
: GPIOF_BRR.BR2 ( -- ) 2 bit GPIOF_BRR ! ; \ GPIOF_BRR.BR2, Port Reset bit
: GPIOF_BRR.BR3 ( -- ) 3 bit GPIOF_BRR ! ; \ GPIOF_BRR.BR3, Port Reset bit
: GPIOF_BRR.BR4 ( -- ) 4 bit GPIOF_BRR ! ; \ GPIOF_BRR.BR4, Port Reset bit
: GPIOF_BRR.BR5 ( -- ) 5 bit GPIOF_BRR ! ; \ GPIOF_BRR.BR5, Port Reset bit
: GPIOF_BRR.BR6 ( -- ) 6 bit GPIOF_BRR ! ; \ GPIOF_BRR.BR6, Port Reset bit
: GPIOF_BRR.BR7 ( -- ) 7 bit GPIOF_BRR ! ; \ GPIOF_BRR.BR7, Port Reset bit
: GPIOF_BRR.BR8 ( -- ) 8 bit GPIOF_BRR ! ; \ GPIOF_BRR.BR8, Port Reset bit
: GPIOF_BRR.BR9 ( -- ) 9 bit GPIOF_BRR ! ; \ GPIOF_BRR.BR9, Port Reset bit
: GPIOF_BRR.BR10 ( -- ) 10 bit GPIOF_BRR ! ; \ GPIOF_BRR.BR10, Port Reset bit
: GPIOF_BRR.BR11 ( -- ) 11 bit GPIOF_BRR ! ; \ GPIOF_BRR.BR11, Port Reset bit
: GPIOF_BRR.BR12 ( -- ) 12 bit GPIOF_BRR ! ; \ GPIOF_BRR.BR12, Port Reset bit
: GPIOF_BRR.BR13 ( -- ) 13 bit GPIOF_BRR ! ; \ GPIOF_BRR.BR13, Port Reset bit
: GPIOF_BRR.BR14 ( -- ) 14 bit GPIOF_BRR ! ; \ GPIOF_BRR.BR14, Port Reset bit
: GPIOF_BRR.BR15 ( -- ) 15 bit GPIOF_BRR ! ; \ GPIOF_BRR.BR15, Port Reset bit

\ CRC_DR (read-write) Reset:$FFFFFFFF
: CRC_DR.DR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) CRC_DR ; \ CRC_DR.DR, Data register bits

\ CRC_IDR (read-write) Reset:$00000000
: CRC_IDR.IDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) CRC_IDR ; \ CRC_IDR.IDR, General-purpose 32-bit data register               bits

\ CRC_CR (multiple-access)  Reset:$00000000
: CRC_CR.REV_OUT ( -- x addr ) 7 bit CRC_CR ; \ CRC_CR.REV_OUT, Reverse output data
: CRC_CR.REV_IN ( %bb -- x addr ) 5 lshift CRC_CR ; \ CRC_CR.REV_IN, Reverse input data
: CRC_CR.POLYSIZE ( %bb -- x addr ) 3 lshift CRC_CR ; \ CRC_CR.POLYSIZE, Polynomial size
: CRC_CR.RESET ( -- x addr ) 0 bit CRC_CR ; \ CRC_CR.RESET, RESET bit

\ CRC_INIT (read-write) Reset:$FFFFFFFF
: CRC_INIT.CRC_INIT ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) CRC_INIT ; \ CRC_INIT.CRC_INIT, Programmable initial CRC               value

\ CRC_POL (read-write) Reset:$04C11DB7
: CRC_POL.POL ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) CRC_POL ; \ CRC_POL.POL, Programmable polynomial

\ EXTI_RTSR1 (read-write) Reset:$00000000
: EXTI_RTSR1.TR0 ( -- x addr ) 0 bit EXTI_RTSR1 ; \ EXTI_RTSR1.TR0, Rising trigger event configuration bit               of Configurable Event input
: EXTI_RTSR1.TR1 ( -- x addr ) 1 bit EXTI_RTSR1 ; \ EXTI_RTSR1.TR1, Rising trigger event configuration bit               of Configurable Event input
: EXTI_RTSR1.TR2 ( -- x addr ) 2 bit EXTI_RTSR1 ; \ EXTI_RTSR1.TR2, Rising trigger event configuration bit               of Configurable Event input
: EXTI_RTSR1.TR3 ( -- x addr ) 3 bit EXTI_RTSR1 ; \ EXTI_RTSR1.TR3, Rising trigger event configuration bit               of Configurable Event input
: EXTI_RTSR1.TR4 ( -- x addr ) 4 bit EXTI_RTSR1 ; \ EXTI_RTSR1.TR4, Rising trigger event configuration bit               of Configurable Event input
: EXTI_RTSR1.TR5 ( -- x addr ) 5 bit EXTI_RTSR1 ; \ EXTI_RTSR1.TR5, Rising trigger event configuration bit               of Configurable Event input
: EXTI_RTSR1.TR6 ( -- x addr ) 6 bit EXTI_RTSR1 ; \ EXTI_RTSR1.TR6, Rising trigger event configuration bit               of Configurable Event input
: EXTI_RTSR1.TR7 ( -- x addr ) 7 bit EXTI_RTSR1 ; \ EXTI_RTSR1.TR7, Rising trigger event configuration bit               of Configurable Event input
: EXTI_RTSR1.TR8 ( -- x addr ) 8 bit EXTI_RTSR1 ; \ EXTI_RTSR1.TR8, Rising trigger event configuration bit               of Configurable Event input
: EXTI_RTSR1.TR9 ( -- x addr ) 9 bit EXTI_RTSR1 ; \ EXTI_RTSR1.TR9, Rising trigger event configuration bit               of Configurable Event input
: EXTI_RTSR1.TR10 ( -- x addr ) 10 bit EXTI_RTSR1 ; \ EXTI_RTSR1.TR10, Rising trigger event configuration bit               of Configurable Event input
: EXTI_RTSR1.TR11 ( -- x addr ) 11 bit EXTI_RTSR1 ; \ EXTI_RTSR1.TR11, Rising trigger event configuration bit               of Configurable Event input
: EXTI_RTSR1.TR12 ( -- x addr ) 12 bit EXTI_RTSR1 ; \ EXTI_RTSR1.TR12, Rising trigger event configuration bit               of Configurable Event input
: EXTI_RTSR1.TR13 ( -- x addr ) 13 bit EXTI_RTSR1 ; \ EXTI_RTSR1.TR13, Rising trigger event configuration bit               of Configurable Event input
: EXTI_RTSR1.TR14 ( -- x addr ) 14 bit EXTI_RTSR1 ; \ EXTI_RTSR1.TR14, Rising trigger event configuration bit               of Configurable Event input
: EXTI_RTSR1.TR15 ( -- x addr ) 15 bit EXTI_RTSR1 ; \ EXTI_RTSR1.TR15, Rising trigger event configuration bit               of Configurable Event input
: EXTI_RTSR1.TR16 ( -- x addr ) 16 bit EXTI_RTSR1 ; \ EXTI_RTSR1.TR16, Rising trigger event configuration bit               of Configurable Event input

\ EXTI_FTSR1 (read-write) Reset:$00000000
: EXTI_FTSR1.TR0 ( -- x addr ) 0 bit EXTI_FTSR1 ; \ EXTI_FTSR1.TR0, Rising trigger event configuration bit               of Configurable Event input
: EXTI_FTSR1.TR1 ( -- x addr ) 1 bit EXTI_FTSR1 ; \ EXTI_FTSR1.TR1, Rising trigger event configuration bit               of Configurable Event input
: EXTI_FTSR1.TR2 ( -- x addr ) 2 bit EXTI_FTSR1 ; \ EXTI_FTSR1.TR2, Rising trigger event configuration bit               of Configurable Event input
: EXTI_FTSR1.TR3 ( -- x addr ) 3 bit EXTI_FTSR1 ; \ EXTI_FTSR1.TR3, Rising trigger event configuration bit               of Configurable Event input
: EXTI_FTSR1.TR4 ( -- x addr ) 4 bit EXTI_FTSR1 ; \ EXTI_FTSR1.TR4, Rising trigger event configuration bit               of Configurable Event input
: EXTI_FTSR1.TR5 ( -- x addr ) 5 bit EXTI_FTSR1 ; \ EXTI_FTSR1.TR5, Rising trigger event configuration bit               of Configurable Event input
: EXTI_FTSR1.TR6 ( -- x addr ) 6 bit EXTI_FTSR1 ; \ EXTI_FTSR1.TR6, Rising trigger event configuration bit               of Configurable Event input
: EXTI_FTSR1.TR7 ( -- x addr ) 7 bit EXTI_FTSR1 ; \ EXTI_FTSR1.TR7, Rising trigger event configuration bit               of Configurable Event input
: EXTI_FTSR1.TR8 ( -- x addr ) 8 bit EXTI_FTSR1 ; \ EXTI_FTSR1.TR8, Rising trigger event configuration bit               of Configurable Event input
: EXTI_FTSR1.TR9 ( -- x addr ) 9 bit EXTI_FTSR1 ; \ EXTI_FTSR1.TR9, Rising trigger event configuration bit               of Configurable Event input
: EXTI_FTSR1.TR10 ( -- x addr ) 10 bit EXTI_FTSR1 ; \ EXTI_FTSR1.TR10, Rising trigger event configuration bit               of Configurable Event input
: EXTI_FTSR1.TR11 ( -- x addr ) 11 bit EXTI_FTSR1 ; \ EXTI_FTSR1.TR11, Rising trigger event configuration bit               of Configurable Event input
: EXTI_FTSR1.TR12 ( -- x addr ) 12 bit EXTI_FTSR1 ; \ EXTI_FTSR1.TR12, Rising trigger event configuration bit               of Configurable Event input
: EXTI_FTSR1.TR13 ( -- x addr ) 13 bit EXTI_FTSR1 ; \ EXTI_FTSR1.TR13, Rising trigger event configuration bit               of Configurable Event input
: EXTI_FTSR1.TR14 ( -- x addr ) 14 bit EXTI_FTSR1 ; \ EXTI_FTSR1.TR14, Rising trigger event configuration bit               of Configurable Event input
: EXTI_FTSR1.TR15 ( -- x addr ) 15 bit EXTI_FTSR1 ; \ EXTI_FTSR1.TR15, Rising trigger event configuration bit               of Configurable Event input
: EXTI_FTSR1.TR16 ( -- x addr ) 16 bit EXTI_FTSR1 ; \ EXTI_FTSR1.TR16, Rising trigger event configuration bit               of Configurable Event input

\ EXTI_SWIER1 (read-write) Reset:$00000000
: EXTI_SWIER1.SWIER0 ( -- x addr ) 0 bit EXTI_SWIER1 ; \ EXTI_SWIER1.SWIER0, Rising trigger event configuration bit               of Configurable Event input
: EXTI_SWIER1.SWIER1 ( -- x addr ) 1 bit EXTI_SWIER1 ; \ EXTI_SWIER1.SWIER1, Rising trigger event configuration bit               of Configurable Event input
: EXTI_SWIER1.SWIER2 ( -- x addr ) 2 bit EXTI_SWIER1 ; \ EXTI_SWIER1.SWIER2, Rising trigger event configuration bit               of Configurable Event input
: EXTI_SWIER1.SWIER3 ( -- x addr ) 3 bit EXTI_SWIER1 ; \ EXTI_SWIER1.SWIER3, Rising trigger event configuration bit               of Configurable Event input
: EXTI_SWIER1.SWIER4 ( -- x addr ) 4 bit EXTI_SWIER1 ; \ EXTI_SWIER1.SWIER4, Rising trigger event configuration bit               of Configurable Event input
: EXTI_SWIER1.SWIER5 ( -- x addr ) 5 bit EXTI_SWIER1 ; \ EXTI_SWIER1.SWIER5, Rising trigger event configuration bit               of Configurable Event input
: EXTI_SWIER1.SWIER6 ( -- x addr ) 6 bit EXTI_SWIER1 ; \ EXTI_SWIER1.SWIER6, Rising trigger event configuration bit               of Configurable Event input
: EXTI_SWIER1.SWIER7 ( -- x addr ) 7 bit EXTI_SWIER1 ; \ EXTI_SWIER1.SWIER7, Rising trigger event configuration bit               of Configurable Event input
: EXTI_SWIER1.SWIER8 ( -- x addr ) 8 bit EXTI_SWIER1 ; \ EXTI_SWIER1.SWIER8, Rising trigger event configuration bit               of Configurable Event input
: EXTI_SWIER1.SWIER9 ( -- x addr ) 9 bit EXTI_SWIER1 ; \ EXTI_SWIER1.SWIER9, Rising trigger event configuration bit               of Configurable Event input
: EXTI_SWIER1.SWIER10 ( -- x addr ) 10 bit EXTI_SWIER1 ; \ EXTI_SWIER1.SWIER10, Rising trigger event configuration bit               of Configurable Event input
: EXTI_SWIER1.SWIER11 ( -- x addr ) 11 bit EXTI_SWIER1 ; \ EXTI_SWIER1.SWIER11, Rising trigger event configuration bit               of Configurable Event input
: EXTI_SWIER1.SWIER12 ( -- x addr ) 12 bit EXTI_SWIER1 ; \ EXTI_SWIER1.SWIER12, Rising trigger event configuration bit               of Configurable Event input
: EXTI_SWIER1.SWIER13 ( -- x addr ) 13 bit EXTI_SWIER1 ; \ EXTI_SWIER1.SWIER13, Rising trigger event configuration bit               of Configurable Event input
: EXTI_SWIER1.SWIER14 ( -- x addr ) 14 bit EXTI_SWIER1 ; \ EXTI_SWIER1.SWIER14, Rising trigger event configuration bit               of Configurable Event input
: EXTI_SWIER1.SWIER15 ( -- x addr ) 15 bit EXTI_SWIER1 ; \ EXTI_SWIER1.SWIER15, Rising trigger event configuration bit               of Configurable Event input
: EXTI_SWIER1.SWIER16 ( -- x addr ) 16 bit EXTI_SWIER1 ; \ EXTI_SWIER1.SWIER16, Rising trigger event configuration bit               of Configurable Event input

\ EXTI_RPR1 (read-write) Reset:$00000000
: EXTI_RPR1.RPIF0 ( -- x addr ) 0 bit EXTI_RPR1 ; \ EXTI_RPR1.RPIF0, configurable event inputs x rising edge               Pending bit.
: EXTI_RPR1.RPIF1 ( -- x addr ) 1 bit EXTI_RPR1 ; \ EXTI_RPR1.RPIF1, configurable event inputs x rising edge               Pending bit.
: EXTI_RPR1.RPIF2 ( -- x addr ) 2 bit EXTI_RPR1 ; \ EXTI_RPR1.RPIF2, configurable event inputs x rising edge               Pending bit.
: EXTI_RPR1.RPIF3 ( -- x addr ) 3 bit EXTI_RPR1 ; \ EXTI_RPR1.RPIF3, configurable event inputs x rising edge               Pending bit.
: EXTI_RPR1.RPIF4 ( -- x addr ) 4 bit EXTI_RPR1 ; \ EXTI_RPR1.RPIF4, configurable event inputs x rising edge               Pending bit.
: EXTI_RPR1.RPIF5 ( -- x addr ) 5 bit EXTI_RPR1 ; \ EXTI_RPR1.RPIF5, configurable event inputs x rising edge               Pending bit
: EXTI_RPR1.RPIF6 ( -- x addr ) 6 bit EXTI_RPR1 ; \ EXTI_RPR1.RPIF6, configurable event inputs x rising edge               Pending bit.
: EXTI_RPR1.RPIF7 ( -- x addr ) 7 bit EXTI_RPR1 ; \ EXTI_RPR1.RPIF7, configurable event inputs x rising edge               Pending bit.
: EXTI_RPR1.RPIF8 ( -- x addr ) 8 bit EXTI_RPR1 ; \ EXTI_RPR1.RPIF8, configurable event inputs x rising edge               Pending bit.
: EXTI_RPR1.RPIF9 ( -- x addr ) 9 bit EXTI_RPR1 ; \ EXTI_RPR1.RPIF9, configurable event inputs x rising edge               Pending bit.
: EXTI_RPR1.RPIF10 ( -- x addr ) 10 bit EXTI_RPR1 ; \ EXTI_RPR1.RPIF10, configurable event inputs x rising edge               Pending bit.
: EXTI_RPR1.RPIF11 ( -- x addr ) 11 bit EXTI_RPR1 ; \ EXTI_RPR1.RPIF11, configurable event inputs x rising edge               Pending bit.
: EXTI_RPR1.RPIF12 ( -- x addr ) 12 bit EXTI_RPR1 ; \ EXTI_RPR1.RPIF12, configurable event inputs x rising edge               Pending bit.
: EXTI_RPR1.RPIF13 ( -- x addr ) 13 bit EXTI_RPR1 ; \ EXTI_RPR1.RPIF13, configurable event inputs x rising edge               Pending bit.
: EXTI_RPR1.RPIF14 ( -- x addr ) 14 bit EXTI_RPR1 ; \ EXTI_RPR1.RPIF14, configurable event inputs x rising edge               Pending bit.
: EXTI_RPR1.RPIF15 ( -- x addr ) 15 bit EXTI_RPR1 ; \ EXTI_RPR1.RPIF15, configurable event inputs x rising edge               Pending bit.
: EXTI_RPR1.RPIF16 ( -- x addr ) 16 bit EXTI_RPR1 ; \ EXTI_RPR1.RPIF16, configurable event inputs x rising edge               Pending bit.

\ EXTI_FPR1 (read-write) Reset:$00000000
: EXTI_FPR1.FPIF0 ( -- x addr ) 0 bit EXTI_FPR1 ; \ EXTI_FPR1.FPIF0, configurable event inputs x falling edge               pending bit.
: EXTI_FPR1.FPIF1 ( -- x addr ) 1 bit EXTI_FPR1 ; \ EXTI_FPR1.FPIF1, configurable event inputs x falling edge               pending bit.
: EXTI_FPR1.FPIF2 ( -- x addr ) 2 bit EXTI_FPR1 ; \ EXTI_FPR1.FPIF2, configurable event inputs x falling edge               pending bit.
: EXTI_FPR1.FPIF3 ( -- x addr ) 3 bit EXTI_FPR1 ; \ EXTI_FPR1.FPIF3, configurable event inputs x falling edge               pending bit.
: EXTI_FPR1.FPIF4 ( -- x addr ) 4 bit EXTI_FPR1 ; \ EXTI_FPR1.FPIF4, configurable event inputs x falling edge               pending bit.
: EXTI_FPR1.FPIF5 ( -- x addr ) 5 bit EXTI_FPR1 ; \ EXTI_FPR1.FPIF5, configurable event inputs x falling edge               pending bit.
: EXTI_FPR1.FPIF6 ( -- x addr ) 6 bit EXTI_FPR1 ; \ EXTI_FPR1.FPIF6, configurable event inputs x falling edge               pending bit.
: EXTI_FPR1.FPIF7 ( -- x addr ) 7 bit EXTI_FPR1 ; \ EXTI_FPR1.FPIF7, configurable event inputs x falling edge               pending bit.
: EXTI_FPR1.FPIF8 ( -- x addr ) 8 bit EXTI_FPR1 ; \ EXTI_FPR1.FPIF8, configurable event inputs x falling edge               pending bit.
: EXTI_FPR1.FPIF9 ( -- x addr ) 9 bit EXTI_FPR1 ; \ EXTI_FPR1.FPIF9, configurable event inputs x falling edge               pending bit.
: EXTI_FPR1.FPIF10 ( -- x addr ) 10 bit EXTI_FPR1 ; \ EXTI_FPR1.FPIF10, configurable event inputs x falling edge               pending bit.
: EXTI_FPR1.FPIF11 ( -- x addr ) 11 bit EXTI_FPR1 ; \ EXTI_FPR1.FPIF11, configurable event inputs x falling edge               pending bit.
: EXTI_FPR1.FPIF12 ( -- x addr ) 12 bit EXTI_FPR1 ; \ EXTI_FPR1.FPIF12, configurable event inputs x falling edge               pending bit.
: EXTI_FPR1.FPIF13 ( -- x addr ) 13 bit EXTI_FPR1 ; \ EXTI_FPR1.FPIF13, configurable event inputs x falling edge               pending bit.
: EXTI_FPR1.FPIF14 ( -- x addr ) 14 bit EXTI_FPR1 ; \ EXTI_FPR1.FPIF14, configurable event inputs x falling edge               pending bit.
: EXTI_FPR1.FPIF15 ( -- x addr ) 15 bit EXTI_FPR1 ; \ EXTI_FPR1.FPIF15, configurable event inputs x falling edge               pending bit.
: EXTI_FPR1.FPIF16 ( -- x addr ) 16 bit EXTI_FPR1 ; \ EXTI_FPR1.FPIF16, configurable event inputs x falling edge               pending bit.

\ EXTI_EXTICR1 (read-write) Reset:$00000000
: EXTI_EXTICR1.EXTI0_7 ( %bbbbbbbb -- x addr ) EXTI_EXTICR1 ; \ EXTI_EXTICR1.EXTI0_7, GPIO port selection
: EXTI_EXTICR1.EXTI8_15 ( %bbbbbbbb -- x addr ) 8 lshift EXTI_EXTICR1 ; \ EXTI_EXTICR1.EXTI8_15, GPIO port selection
: EXTI_EXTICR1.EXTI16_23 ( %bbbbbbbb -- x addr ) 16 lshift EXTI_EXTICR1 ; \ EXTI_EXTICR1.EXTI16_23, GPIO port selection
: EXTI_EXTICR1.EXTI24_31 ( %bbbbbbbb -- x addr ) 24 lshift EXTI_EXTICR1 ; \ EXTI_EXTICR1.EXTI24_31, GPIO port selection

\ EXTI_EXTICR2 (read-write) Reset:$00000000
: EXTI_EXTICR2.EXTI0_7 ( %bbbbbbbb -- x addr ) EXTI_EXTICR2 ; \ EXTI_EXTICR2.EXTI0_7, GPIO port selection
: EXTI_EXTICR2.EXTI8_15 ( %bbbbbbbb -- x addr ) 8 lshift EXTI_EXTICR2 ; \ EXTI_EXTICR2.EXTI8_15, GPIO port selection
: EXTI_EXTICR2.EXTI16_23 ( %bbbbbbbb -- x addr ) 16 lshift EXTI_EXTICR2 ; \ EXTI_EXTICR2.EXTI16_23, GPIO port selection
: EXTI_EXTICR2.EXTI24_31 ( %bbbbbbbb -- x addr ) 24 lshift EXTI_EXTICR2 ; \ EXTI_EXTICR2.EXTI24_31, GPIO port selection

\ EXTI_EXTICR3 (read-write) Reset:$00000000
: EXTI_EXTICR3.EXTI0_7 ( %bbbbbbbb -- x addr ) EXTI_EXTICR3 ; \ EXTI_EXTICR3.EXTI0_7, GPIO port selection
: EXTI_EXTICR3.EXTI8_15 ( %bbbbbbbb -- x addr ) 8 lshift EXTI_EXTICR3 ; \ EXTI_EXTICR3.EXTI8_15, GPIO port selection
: EXTI_EXTICR3.EXTI16_23 ( %bbbbbbbb -- x addr ) 16 lshift EXTI_EXTICR3 ; \ EXTI_EXTICR3.EXTI16_23, GPIO port selection
: EXTI_EXTICR3.EXTI24_31 ( %bbbbbbbb -- x addr ) 24 lshift EXTI_EXTICR3 ; \ EXTI_EXTICR3.EXTI24_31, GPIO port selection

\ EXTI_EXTICR4 (read-write) Reset:$00000000
: EXTI_EXTICR4.EXTI0_7 ( %bbbbbbbb -- x addr ) EXTI_EXTICR4 ; \ EXTI_EXTICR4.EXTI0_7, GPIO port selection
: EXTI_EXTICR4.EXTI8_15 ( %bbbbbbbb -- x addr ) 8 lshift EXTI_EXTICR4 ; \ EXTI_EXTICR4.EXTI8_15, GPIO port selection
: EXTI_EXTICR4.EXTI16_23 ( %bbbbbbbb -- x addr ) 16 lshift EXTI_EXTICR4 ; \ EXTI_EXTICR4.EXTI16_23, GPIO port selection
: EXTI_EXTICR4.EXTI24_31 ( %bbbbbbbb -- x addr ) 24 lshift EXTI_EXTICR4 ; \ EXTI_EXTICR4.EXTI24_31, GPIO port selection

\ EXTI_IMR1 (read-write) Reset:$FFF80000
: EXTI_IMR1.IM0 ( -- x addr ) 0 bit EXTI_IMR1 ; \ EXTI_IMR1.IM0, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM1 ( -- x addr ) 1 bit EXTI_IMR1 ; \ EXTI_IMR1.IM1, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM2 ( -- x addr ) 2 bit EXTI_IMR1 ; \ EXTI_IMR1.IM2, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM3 ( -- x addr ) 3 bit EXTI_IMR1 ; \ EXTI_IMR1.IM3, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM4 ( -- x addr ) 4 bit EXTI_IMR1 ; \ EXTI_IMR1.IM4, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM5 ( -- x addr ) 5 bit EXTI_IMR1 ; \ EXTI_IMR1.IM5, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM6 ( -- x addr ) 6 bit EXTI_IMR1 ; \ EXTI_IMR1.IM6, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM7 ( -- x addr ) 7 bit EXTI_IMR1 ; \ EXTI_IMR1.IM7, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM8 ( -- x addr ) 8 bit EXTI_IMR1 ; \ EXTI_IMR1.IM8, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM9 ( -- x addr ) 9 bit EXTI_IMR1 ; \ EXTI_IMR1.IM9, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM10 ( -- x addr ) 10 bit EXTI_IMR1 ; \ EXTI_IMR1.IM10, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM11 ( -- x addr ) 11 bit EXTI_IMR1 ; \ EXTI_IMR1.IM11, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM12 ( -- x addr ) 12 bit EXTI_IMR1 ; \ EXTI_IMR1.IM12, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM13 ( -- x addr ) 13 bit EXTI_IMR1 ; \ EXTI_IMR1.IM13, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM14 ( -- x addr ) 14 bit EXTI_IMR1 ; \ EXTI_IMR1.IM14, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM15 ( -- x addr ) 15 bit EXTI_IMR1 ; \ EXTI_IMR1.IM15, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM16 ( -- x addr ) 16 bit EXTI_IMR1 ; \ EXTI_IMR1.IM16, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM19 ( -- x addr ) 19 bit EXTI_IMR1 ; \ EXTI_IMR1.IM19, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM20 ( -- x addr ) 20 bit EXTI_IMR1 ; \ EXTI_IMR1.IM20, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM21 ( -- x addr ) 21 bit EXTI_IMR1 ; \ EXTI_IMR1.IM21, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM22 ( -- x addr ) 22 bit EXTI_IMR1 ; \ EXTI_IMR1.IM22, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM23 ( -- x addr ) 23 bit EXTI_IMR1 ; \ EXTI_IMR1.IM23, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM24 ( -- x addr ) 24 bit EXTI_IMR1 ; \ EXTI_IMR1.IM24, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM25 ( -- x addr ) 25 bit EXTI_IMR1 ; \ EXTI_IMR1.IM25, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM26 ( -- x addr ) 26 bit EXTI_IMR1 ; \ EXTI_IMR1.IM26, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM28 ( -- x addr ) 28 bit EXTI_IMR1 ; \ EXTI_IMR1.IM28, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM29 ( -- x addr ) 29 bit EXTI_IMR1 ; \ EXTI_IMR1.IM29, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM30 ( -- x addr ) 30 bit EXTI_IMR1 ; \ EXTI_IMR1.IM30, CPU wakeup with interrupt mask on event               input
: EXTI_IMR1.IM31 ( -- x addr ) 31 bit EXTI_IMR1 ; \ EXTI_IMR1.IM31, CPU wakeup with interrupt mask on event               input

\ EXTI_EMR1 (read-write) Reset:$00000000
: EXTI_EMR1.EM0 ( -- x addr ) 0 bit EXTI_EMR1 ; \ EXTI_EMR1.EM0, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM1 ( -- x addr ) 1 bit EXTI_EMR1 ; \ EXTI_EMR1.EM1, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM2 ( -- x addr ) 2 bit EXTI_EMR1 ; \ EXTI_EMR1.EM2, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM3 ( -- x addr ) 3 bit EXTI_EMR1 ; \ EXTI_EMR1.EM3, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM4 ( -- x addr ) 4 bit EXTI_EMR1 ; \ EXTI_EMR1.EM4, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM5 ( -- x addr ) 5 bit EXTI_EMR1 ; \ EXTI_EMR1.EM5, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM6 ( -- x addr ) 6 bit EXTI_EMR1 ; \ EXTI_EMR1.EM6, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM7 ( -- x addr ) 7 bit EXTI_EMR1 ; \ EXTI_EMR1.EM7, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM8 ( -- x addr ) 8 bit EXTI_EMR1 ; \ EXTI_EMR1.EM8, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM9 ( -- x addr ) 9 bit EXTI_EMR1 ; \ EXTI_EMR1.EM9, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM10 ( -- x addr ) 10 bit EXTI_EMR1 ; \ EXTI_EMR1.EM10, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM11 ( -- x addr ) 11 bit EXTI_EMR1 ; \ EXTI_EMR1.EM11, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM12 ( -- x addr ) 12 bit EXTI_EMR1 ; \ EXTI_EMR1.EM12, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM13 ( -- x addr ) 13 bit EXTI_EMR1 ; \ EXTI_EMR1.EM13, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM14 ( -- x addr ) 14 bit EXTI_EMR1 ; \ EXTI_EMR1.EM14, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM15 ( -- x addr ) 15 bit EXTI_EMR1 ; \ EXTI_EMR1.EM15, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM16 ( -- x addr ) 16 bit EXTI_EMR1 ; \ EXTI_EMR1.EM16, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM19 ( -- x addr ) 19 bit EXTI_EMR1 ; \ EXTI_EMR1.EM19, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM21 ( -- x addr ) 21 bit EXTI_EMR1 ; \ EXTI_EMR1.EM21, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM23 ( -- x addr ) 23 bit EXTI_EMR1 ; \ EXTI_EMR1.EM23, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM25 ( -- x addr ) 25 bit EXTI_EMR1 ; \ EXTI_EMR1.EM25, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM26 ( -- x addr ) 26 bit EXTI_EMR1 ; \ EXTI_EMR1.EM26, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM28 ( -- x addr ) 28 bit EXTI_EMR1 ; \ EXTI_EMR1.EM28, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM29 ( -- x addr ) 29 bit EXTI_EMR1 ; \ EXTI_EMR1.EM29, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM30 ( -- x addr ) 30 bit EXTI_EMR1 ; \ EXTI_EMR1.EM30, CPU wakeup with event mask on event               input
: EXTI_EMR1.EM31 ( -- x addr ) 31 bit EXTI_EMR1 ; \ EXTI_EMR1.EM31, CPU wakeup with event mask on event               input

\ TIM16_CR1 (read-write) Reset:$0000
: TIM16_CR1.CEN ( -- x addr ) 0 bit TIM16_CR1 ; \ TIM16_CR1.CEN, Counter enable
: TIM16_CR1.UDIS ( -- x addr ) 1 bit TIM16_CR1 ; \ TIM16_CR1.UDIS, Update disable
: TIM16_CR1.URS ( -- x addr ) 2 bit TIM16_CR1 ; \ TIM16_CR1.URS, Update request source
: TIM16_CR1.OPM ( -- x addr ) 3 bit TIM16_CR1 ; \ TIM16_CR1.OPM, One-pulse mode
: TIM16_CR1.ARPE ( -- x addr ) 7 bit TIM16_CR1 ; \ TIM16_CR1.ARPE, Auto-reload preload enable
: TIM16_CR1.CKD ( %bb -- x addr ) 8 lshift TIM16_CR1 ; \ TIM16_CR1.CKD, Clock division
: TIM16_CR1.UIFREMAP ( -- x addr ) 11 bit TIM16_CR1 ; \ TIM16_CR1.UIFREMAP, UIF status bit remapping

\ TIM16_CR2 (read-write) Reset:$0000
: TIM16_CR2.OIS1N ( -- x addr ) 9 bit TIM16_CR2 ; \ TIM16_CR2.OIS1N, Output Idle state 1
: TIM16_CR2.OIS1 ( -- x addr ) 8 bit TIM16_CR2 ; \ TIM16_CR2.OIS1, Output Idle state 1
: TIM16_CR2.CCDS ( -- x addr ) 3 bit TIM16_CR2 ; \ TIM16_CR2.CCDS, Capture/compare DMA               selection
: TIM16_CR2.CCUS ( -- x addr ) 2 bit TIM16_CR2 ; \ TIM16_CR2.CCUS, Capture/compare control update               selection
: TIM16_CR2.CCPC ( -- x addr ) 0 bit TIM16_CR2 ; \ TIM16_CR2.CCPC, Capture/compare preloaded               control

\ TIM16_DIER (read-write) Reset:$0000
: TIM16_DIER.COMDE ( -- x addr ) 13 bit TIM16_DIER ; \ TIM16_DIER.COMDE, COM DMA request enable
: TIM16_DIER.CC1DE ( -- x addr ) 9 bit TIM16_DIER ; \ TIM16_DIER.CC1DE, Capture/Compare 1 DMA request               enable
: TIM16_DIER.UDE ( -- x addr ) 8 bit TIM16_DIER ; \ TIM16_DIER.UDE, Update DMA request enable
: TIM16_DIER.BIE ( -- x addr ) 7 bit TIM16_DIER ; \ TIM16_DIER.BIE, Break interrupt enable
: TIM16_DIER.COMIE ( -- x addr ) 5 bit TIM16_DIER ; \ TIM16_DIER.COMIE, COM interrupt enable
: TIM16_DIER.CC1IE ( -- x addr ) 1 bit TIM16_DIER ; \ TIM16_DIER.CC1IE, Capture/Compare 1 interrupt               enable
: TIM16_DIER.UIE ( -- x addr ) 0 bit TIM16_DIER ; \ TIM16_DIER.UIE, Update interrupt enable

\ TIM16_SR (read-write) Reset:$0000
: TIM16_SR.CC1OF ( -- x addr ) 9 bit TIM16_SR ; \ TIM16_SR.CC1OF, Capture/Compare 1 overcapture               flag
: TIM16_SR.BIF ( -- x addr ) 7 bit TIM16_SR ; \ TIM16_SR.BIF, Break interrupt flag
: TIM16_SR.COMIF ( -- x addr ) 5 bit TIM16_SR ; \ TIM16_SR.COMIF, COM interrupt flag
: TIM16_SR.CC1IF ( -- x addr ) 1 bit TIM16_SR ; \ TIM16_SR.CC1IF, Capture/compare 1 interrupt               flag
: TIM16_SR.UIF ( -- x addr ) 0 bit TIM16_SR ; \ TIM16_SR.UIF, Update interrupt flag

\ TIM16_EGR (write-only) Reset:$0000
: TIM16_EGR.BG ( -- x addr ) 7 bit TIM16_EGR ; \ TIM16_EGR.BG, Break generation
: TIM16_EGR.COMG ( -- x addr ) 5 bit TIM16_EGR ; \ TIM16_EGR.COMG, Capture/Compare control update               generation
: TIM16_EGR.CC1G ( -- x addr ) 1 bit TIM16_EGR ; \ TIM16_EGR.CC1G, Capture/compare 1               generation
: TIM16_EGR.UG ( -- x addr ) 0 bit TIM16_EGR ; \ TIM16_EGR.UG, Update generation

\ TIM16_CCMR1_Output (read-write) Reset:$00000000
: TIM16_CCMR1_Output.OC1M_2 ( -- x addr ) 16 bit TIM16_CCMR1_Output ; \ TIM16_CCMR1_Output.OC1M_2, Output Compare 1 mode
: TIM16_CCMR1_Output.OC1M ( %bbb -- x addr ) 4 lshift TIM16_CCMR1_Output ; \ TIM16_CCMR1_Output.OC1M, Output Compare 1 mode
: TIM16_CCMR1_Output.OC1PE ( -- x addr ) 3 bit TIM16_CCMR1_Output ; \ TIM16_CCMR1_Output.OC1PE, Output Compare 1 preload               enable
: TIM16_CCMR1_Output.OC1FE ( -- x addr ) 2 bit TIM16_CCMR1_Output ; \ TIM16_CCMR1_Output.OC1FE, Output Compare 1 fast               enable
: TIM16_CCMR1_Output.CC1S ( %bb -- x addr ) TIM16_CCMR1_Output ; \ TIM16_CCMR1_Output.CC1S, Capture/Compare 1               selection

\ TIM16_CCMR1_Input (read-write) Reset:$00000000
: TIM16_CCMR1_Input.IC1F ( %bbbb -- x addr ) 4 lshift TIM16_CCMR1_Input ; \ TIM16_CCMR1_Input.IC1F, Input capture 1 filter
: TIM16_CCMR1_Input.IC1PSC ( %bb -- x addr ) 2 lshift TIM16_CCMR1_Input ; \ TIM16_CCMR1_Input.IC1PSC, Input capture 1 prescaler
: TIM16_CCMR1_Input.CC1S ( %bb -- x addr ) TIM16_CCMR1_Input ; \ TIM16_CCMR1_Input.CC1S, Capture/Compare 1               selection

\ TIM16_CCER (read-write) Reset:$0000
: TIM16_CCER.CC1NP ( -- x addr ) 3 bit TIM16_CCER ; \ TIM16_CCER.CC1NP, Capture/Compare 1 output               Polarity
: TIM16_CCER.CC1NE ( -- x addr ) 2 bit TIM16_CCER ; \ TIM16_CCER.CC1NE, Capture/Compare 1 complementary output               enable
: TIM16_CCER.CC1P ( -- x addr ) 1 bit TIM16_CCER ; \ TIM16_CCER.CC1P, Capture/Compare 1 output               Polarity
: TIM16_CCER.CC1E ( -- x addr ) 0 bit TIM16_CCER ; \ TIM16_CCER.CC1E, Capture/Compare 1 output               enable

\ TIM16_CNT (multiple-access)  Reset:$00000000
: TIM16_CNT.CNT ( %bbbbbbbbbbbbbbbb -- x addr ) TIM16_CNT ; \ TIM16_CNT.CNT, counter value
: TIM16_CNT.UIFCPY ( -- x addr ) 31 bit TIM16_CNT ; \ TIM16_CNT.UIFCPY, UIF Copy

\ TIM16_PSC (read-write) Reset:$0000
: TIM16_PSC.PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIM16_PSC ; \ TIM16_PSC.PSC, Prescaler value

\ TIM16_ARR (read-write) Reset:$00000000
: TIM16_ARR.ARR ( %bbbbbbbbbbbbbbbb -- x addr ) TIM16_ARR ; \ TIM16_ARR.ARR, Auto-reload value

\ TIM16_RCR (read-write) Reset:$0000
: TIM16_RCR.REP ( %bbbbbbbb -- x addr ) TIM16_RCR ; \ TIM16_RCR.REP, Repetition counter value

\ TIM16_CCR1 (read-write) Reset:$00000000
: TIM16_CCR1.CCR1 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM16_CCR1 ; \ TIM16_CCR1.CCR1, Capture/Compare 1 value

\ TIM16_BDTR (read-write) Reset:$0000
: TIM16_BDTR.DTG ( %bbbbbbbb -- x addr ) TIM16_BDTR ; \ TIM16_BDTR.DTG, Dead-time generator setup
: TIM16_BDTR.LOCK ( %bb -- x addr ) 8 lshift TIM16_BDTR ; \ TIM16_BDTR.LOCK, Lock configuration
: TIM16_BDTR.OSSI ( -- x addr ) 10 bit TIM16_BDTR ; \ TIM16_BDTR.OSSI, Off-state selection for Idle               mode
: TIM16_BDTR.OSSR ( -- x addr ) 11 bit TIM16_BDTR ; \ TIM16_BDTR.OSSR, Off-state selection for Run               mode
: TIM16_BDTR.BKE ( -- x addr ) 12 bit TIM16_BDTR ; \ TIM16_BDTR.BKE, Break enable
: TIM16_BDTR.BKP ( -- x addr ) 13 bit TIM16_BDTR ; \ TIM16_BDTR.BKP, Break polarity
: TIM16_BDTR.AOE ( -- x addr ) 14 bit TIM16_BDTR ; \ TIM16_BDTR.AOE, Automatic output enable
: TIM16_BDTR.MOE ( -- x addr ) 15 bit TIM16_BDTR ; \ TIM16_BDTR.MOE, Main output enable
: TIM16_BDTR.BKF ( %bbbb -- x addr ) 16 lshift TIM16_BDTR ; \ TIM16_BDTR.BKF, Break filter
: TIM16_BDTR.BKDSRM ( -- x addr ) 26 bit TIM16_BDTR ; \ TIM16_BDTR.BKDSRM, Break Disarm
: TIM16_BDTR.BKBID ( -- x addr ) 28 bit TIM16_BDTR ; \ TIM16_BDTR.BKBID, Break Bidirectional

\ TIM16_DCR (read-write) Reset:$0000
: TIM16_DCR.DBL ( %bbbbb -- x addr ) 8 lshift TIM16_DCR ; \ TIM16_DCR.DBL, DMA burst length
: TIM16_DCR.DBA ( %bbbbb -- x addr ) TIM16_DCR ; \ TIM16_DCR.DBA, DMA base address

\ TIM16_DMAR (read-write) Reset:$0000
: TIM16_DMAR.DMAB ( %bbbbbbbbbbbbbbbb -- x addr ) TIM16_DMAR ; \ TIM16_DMAR.DMAB, DMA register for burst               accesses

\ TIM16_AF1 (read-write) Reset:$0000
: TIM16_AF1.BKINE ( -- x addr ) 0 bit TIM16_AF1 ; \ TIM16_AF1.BKINE, BRK BKIN input enable
: TIM16_AF1.BKCMP1E ( -- x addr ) 1 bit TIM16_AF1 ; \ TIM16_AF1.BKCMP1E, BRK COMP1 enable
: TIM16_AF1.BKCMP2E ( -- x addr ) 2 bit TIM16_AF1 ; \ TIM16_AF1.BKCMP2E, BRK COMP2 enable
: TIM16_AF1.BKDFBK1E ( -- x addr ) 8 bit TIM16_AF1 ; \ TIM16_AF1.BKDFBK1E, BRK DFSDM_BREAK1 enable
: TIM16_AF1.BKINP ( -- x addr ) 9 bit TIM16_AF1 ; \ TIM16_AF1.BKINP, BRK BKIN input polarity
: TIM16_AF1.BKCMP1P ( -- x addr ) 10 bit TIM16_AF1 ; \ TIM16_AF1.BKCMP1P, BRK COMP1 input polarity
: TIM16_AF1.BKCMP2P ( -- x addr ) 11 bit TIM16_AF1 ; \ TIM16_AF1.BKCMP2P, BRK COMP2 input polarit

\ TIM16_TISEL (read-write) Reset:$0000
: TIM16_TISEL.TI1SEL ( %bbbb -- x addr ) TIM16_TISEL ; \ TIM16_TISEL.TI1SEL, selects input

\ TIM17_CR1 (read-write) Reset:$0000
: TIM17_CR1.CEN ( -- x addr ) 0 bit TIM17_CR1 ; \ TIM17_CR1.CEN, Counter enable
: TIM17_CR1.UDIS ( -- x addr ) 1 bit TIM17_CR1 ; \ TIM17_CR1.UDIS, Update disable
: TIM17_CR1.URS ( -- x addr ) 2 bit TIM17_CR1 ; \ TIM17_CR1.URS, Update request source
: TIM17_CR1.OPM ( -- x addr ) 3 bit TIM17_CR1 ; \ TIM17_CR1.OPM, One-pulse mode
: TIM17_CR1.ARPE ( -- x addr ) 7 bit TIM17_CR1 ; \ TIM17_CR1.ARPE, Auto-reload preload enable
: TIM17_CR1.CKD ( %bb -- x addr ) 8 lshift TIM17_CR1 ; \ TIM17_CR1.CKD, Clock division
: TIM17_CR1.UIFREMAP ( -- x addr ) 11 bit TIM17_CR1 ; \ TIM17_CR1.UIFREMAP, UIF status bit remapping

\ TIM17_CR2 (read-write) Reset:$0000
: TIM17_CR2.OIS1N ( -- x addr ) 9 bit TIM17_CR2 ; \ TIM17_CR2.OIS1N, Output Idle state 1
: TIM17_CR2.OIS1 ( -- x addr ) 8 bit TIM17_CR2 ; \ TIM17_CR2.OIS1, Output Idle state 1
: TIM17_CR2.CCDS ( -- x addr ) 3 bit TIM17_CR2 ; \ TIM17_CR2.CCDS, Capture/compare DMA               selection
: TIM17_CR2.CCUS ( -- x addr ) 2 bit TIM17_CR2 ; \ TIM17_CR2.CCUS, Capture/compare control update               selection
: TIM17_CR2.CCPC ( -- x addr ) 0 bit TIM17_CR2 ; \ TIM17_CR2.CCPC, Capture/compare preloaded               control

\ TIM17_DIER (read-write) Reset:$0000
: TIM17_DIER.COMDE ( -- x addr ) 13 bit TIM17_DIER ; \ TIM17_DIER.COMDE, COM DMA request enable
: TIM17_DIER.CC1DE ( -- x addr ) 9 bit TIM17_DIER ; \ TIM17_DIER.CC1DE, Capture/Compare 1 DMA request               enable
: TIM17_DIER.UDE ( -- x addr ) 8 bit TIM17_DIER ; \ TIM17_DIER.UDE, Update DMA request enable
: TIM17_DIER.BIE ( -- x addr ) 7 bit TIM17_DIER ; \ TIM17_DIER.BIE, Break interrupt enable
: TIM17_DIER.COMIE ( -- x addr ) 5 bit TIM17_DIER ; \ TIM17_DIER.COMIE, COM interrupt enable
: TIM17_DIER.CC1IE ( -- x addr ) 1 bit TIM17_DIER ; \ TIM17_DIER.CC1IE, Capture/Compare 1 interrupt               enable
: TIM17_DIER.UIE ( -- x addr ) 0 bit TIM17_DIER ; \ TIM17_DIER.UIE, Update interrupt enable

\ TIM17_SR (read-write) Reset:$0000
: TIM17_SR.CC1OF ( -- x addr ) 9 bit TIM17_SR ; \ TIM17_SR.CC1OF, Capture/Compare 1 overcapture               flag
: TIM17_SR.BIF ( -- x addr ) 7 bit TIM17_SR ; \ TIM17_SR.BIF, Break interrupt flag
: TIM17_SR.COMIF ( -- x addr ) 5 bit TIM17_SR ; \ TIM17_SR.COMIF, COM interrupt flag
: TIM17_SR.CC1IF ( -- x addr ) 1 bit TIM17_SR ; \ TIM17_SR.CC1IF, Capture/compare 1 interrupt               flag
: TIM17_SR.UIF ( -- x addr ) 0 bit TIM17_SR ; \ TIM17_SR.UIF, Update interrupt flag

\ TIM17_EGR (write-only) Reset:$0000
: TIM17_EGR.BG ( -- x addr ) 7 bit TIM17_EGR ; \ TIM17_EGR.BG, Break generation
: TIM17_EGR.COMG ( -- x addr ) 5 bit TIM17_EGR ; \ TIM17_EGR.COMG, Capture/Compare control update               generation
: TIM17_EGR.CC1G ( -- x addr ) 1 bit TIM17_EGR ; \ TIM17_EGR.CC1G, Capture/compare 1               generation
: TIM17_EGR.UG ( -- x addr ) 0 bit TIM17_EGR ; \ TIM17_EGR.UG, Update generation

\ TIM17_CCMR1_Output (read-write) Reset:$00000000
: TIM17_CCMR1_Output.OC1M_2 ( -- x addr ) 16 bit TIM17_CCMR1_Output ; \ TIM17_CCMR1_Output.OC1M_2, Output Compare 1 mode
: TIM17_CCMR1_Output.OC1M ( %bbb -- x addr ) 4 lshift TIM17_CCMR1_Output ; \ TIM17_CCMR1_Output.OC1M, Output Compare 1 mode
: TIM17_CCMR1_Output.OC1PE ( -- x addr ) 3 bit TIM17_CCMR1_Output ; \ TIM17_CCMR1_Output.OC1PE, Output Compare 1 preload               enable
: TIM17_CCMR1_Output.OC1FE ( -- x addr ) 2 bit TIM17_CCMR1_Output ; \ TIM17_CCMR1_Output.OC1FE, Output Compare 1 fast               enable
: TIM17_CCMR1_Output.CC1S ( %bb -- x addr ) TIM17_CCMR1_Output ; \ TIM17_CCMR1_Output.CC1S, Capture/Compare 1               selection

\ TIM17_CCMR1_Input (read-write) Reset:$00000000
: TIM17_CCMR1_Input.IC1F ( %bbbb -- x addr ) 4 lshift TIM17_CCMR1_Input ; \ TIM17_CCMR1_Input.IC1F, Input capture 1 filter
: TIM17_CCMR1_Input.IC1PSC ( %bb -- x addr ) 2 lshift TIM17_CCMR1_Input ; \ TIM17_CCMR1_Input.IC1PSC, Input capture 1 prescaler
: TIM17_CCMR1_Input.CC1S ( %bb -- x addr ) TIM17_CCMR1_Input ; \ TIM17_CCMR1_Input.CC1S, Capture/Compare 1               selection

\ TIM17_CCER (read-write) Reset:$0000
: TIM17_CCER.CC1NP ( -- x addr ) 3 bit TIM17_CCER ; \ TIM17_CCER.CC1NP, Capture/Compare 1 output               Polarity
: TIM17_CCER.CC1NE ( -- x addr ) 2 bit TIM17_CCER ; \ TIM17_CCER.CC1NE, Capture/Compare 1 complementary output               enable
: TIM17_CCER.CC1P ( -- x addr ) 1 bit TIM17_CCER ; \ TIM17_CCER.CC1P, Capture/Compare 1 output               Polarity
: TIM17_CCER.CC1E ( -- x addr ) 0 bit TIM17_CCER ; \ TIM17_CCER.CC1E, Capture/Compare 1 output               enable

\ TIM17_CNT (multiple-access)  Reset:$00000000
: TIM17_CNT.CNT ( %bbbbbbbbbbbbbbbb -- x addr ) TIM17_CNT ; \ TIM17_CNT.CNT, counter value
: TIM17_CNT.UIFCPY ( -- x addr ) 31 bit TIM17_CNT ; \ TIM17_CNT.UIFCPY, UIF Copy

\ TIM17_PSC (read-write) Reset:$0000
: TIM17_PSC.PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIM17_PSC ; \ TIM17_PSC.PSC, Prescaler value

\ TIM17_ARR (read-write) Reset:$00000000
: TIM17_ARR.ARR ( %bbbbbbbbbbbbbbbb -- x addr ) TIM17_ARR ; \ TIM17_ARR.ARR, Auto-reload value

\ TIM17_RCR (read-write) Reset:$0000
: TIM17_RCR.REP ( %bbbbbbbb -- x addr ) TIM17_RCR ; \ TIM17_RCR.REP, Repetition counter value

\ TIM17_CCR1 (read-write) Reset:$00000000
: TIM17_CCR1.CCR1 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM17_CCR1 ; \ TIM17_CCR1.CCR1, Capture/Compare 1 value

\ TIM17_BDTR (read-write) Reset:$0000
: TIM17_BDTR.DTG ( %bbbbbbbb -- x addr ) TIM17_BDTR ; \ TIM17_BDTR.DTG, Dead-time generator setup
: TIM17_BDTR.LOCK ( %bb -- x addr ) 8 lshift TIM17_BDTR ; \ TIM17_BDTR.LOCK, Lock configuration
: TIM17_BDTR.OSSI ( -- x addr ) 10 bit TIM17_BDTR ; \ TIM17_BDTR.OSSI, Off-state selection for Idle               mode
: TIM17_BDTR.OSSR ( -- x addr ) 11 bit TIM17_BDTR ; \ TIM17_BDTR.OSSR, Off-state selection for Run               mode
: TIM17_BDTR.BKE ( -- x addr ) 12 bit TIM17_BDTR ; \ TIM17_BDTR.BKE, Break enable
: TIM17_BDTR.BKP ( -- x addr ) 13 bit TIM17_BDTR ; \ TIM17_BDTR.BKP, Break polarity
: TIM17_BDTR.AOE ( -- x addr ) 14 bit TIM17_BDTR ; \ TIM17_BDTR.AOE, Automatic output enable
: TIM17_BDTR.MOE ( -- x addr ) 15 bit TIM17_BDTR ; \ TIM17_BDTR.MOE, Main output enable
: TIM17_BDTR.BKF ( %bbbb -- x addr ) 16 lshift TIM17_BDTR ; \ TIM17_BDTR.BKF, Break filter
: TIM17_BDTR.BKDSRM ( -- x addr ) 26 bit TIM17_BDTR ; \ TIM17_BDTR.BKDSRM, Break Disarm
: TIM17_BDTR.BKBID ( -- x addr ) 28 bit TIM17_BDTR ; \ TIM17_BDTR.BKBID, Break Bidirectional

\ TIM17_DCR (read-write) Reset:$0000
: TIM17_DCR.DBL ( %bbbbb -- x addr ) 8 lshift TIM17_DCR ; \ TIM17_DCR.DBL, DMA burst length
: TIM17_DCR.DBA ( %bbbbb -- x addr ) TIM17_DCR ; \ TIM17_DCR.DBA, DMA base address

\ TIM17_DMAR (read-write) Reset:$0000
: TIM17_DMAR.DMAB ( %bbbbbbbbbbbbbbbb -- x addr ) TIM17_DMAR ; \ TIM17_DMAR.DMAB, DMA register for burst               accesses

\ TIM17_AF1 (read-write) Reset:$0000
: TIM17_AF1.BKINE ( -- x addr ) 0 bit TIM17_AF1 ; \ TIM17_AF1.BKINE, BRK BKIN input enable
: TIM17_AF1.BKCMP1E ( -- x addr ) 1 bit TIM17_AF1 ; \ TIM17_AF1.BKCMP1E, BRK COMP1 enable
: TIM17_AF1.BKCMP2E ( -- x addr ) 2 bit TIM17_AF1 ; \ TIM17_AF1.BKCMP2E, BRK COMP2 enable
: TIM17_AF1.BKDFBK1E ( -- x addr ) 8 bit TIM17_AF1 ; \ TIM17_AF1.BKDFBK1E, BRK DFSDM_BREAK1 enable
: TIM17_AF1.BKINP ( -- x addr ) 9 bit TIM17_AF1 ; \ TIM17_AF1.BKINP, BRK BKIN input polarity
: TIM17_AF1.BKCMP1P ( -- x addr ) 10 bit TIM17_AF1 ; \ TIM17_AF1.BKCMP1P, BRK COMP1 input polarity
: TIM17_AF1.BKCMP2P ( -- x addr ) 11 bit TIM17_AF1 ; \ TIM17_AF1.BKCMP2P, BRK COMP2 input polarit

\ TIM17_TISEL (read-write) Reset:$0000
: TIM17_TISEL.TI1SEL ( %bbbb -- x addr ) TIM17_TISEL ; \ TIM17_TISEL.TI1SEL, selects input

\ USART1_CR1 (read-write) Reset:$0000
: USART1_CR1.RXFFIE ( -- x addr ) 31 bit USART1_CR1 ; \ USART1_CR1.RXFFIE, RXFIFO Full interrupt               enable
: USART1_CR1.TXFEIE ( -- x addr ) 30 bit USART1_CR1 ; \ USART1_CR1.TXFEIE, TXFIFO empty interrupt               enable
: USART1_CR1.FIFOEN ( -- x addr ) 29 bit USART1_CR1 ; \ USART1_CR1.FIFOEN, FIFO mode enable
: USART1_CR1.M1 ( -- x addr ) 28 bit USART1_CR1 ; \ USART1_CR1.M1, Word length
: USART1_CR1.EOBIE ( -- x addr ) 27 bit USART1_CR1 ; \ USART1_CR1.EOBIE, End of Block interrupt               enable
: USART1_CR1.RTOIE ( -- x addr ) 26 bit USART1_CR1 ; \ USART1_CR1.RTOIE, Receiver timeout interrupt               enable
: USART1_CR1.DEAT ( %bbbbb -- x addr ) 21 lshift USART1_CR1 ; \ USART1_CR1.DEAT, DEAT
: USART1_CR1.DEDT ( %bbbbb -- x addr ) 16 lshift USART1_CR1 ; \ USART1_CR1.DEDT, DEDT
: USART1_CR1.OVER8 ( -- x addr ) 15 bit USART1_CR1 ; \ USART1_CR1.OVER8, Oversampling mode
: USART1_CR1.CMIE ( -- x addr ) 14 bit USART1_CR1 ; \ USART1_CR1.CMIE, Character match interrupt               enable
: USART1_CR1.MME ( -- x addr ) 13 bit USART1_CR1 ; \ USART1_CR1.MME, Mute mode enable
: USART1_CR1.M0 ( -- x addr ) 12 bit USART1_CR1 ; \ USART1_CR1.M0, Word length
: USART1_CR1.WAKE ( -- x addr ) 11 bit USART1_CR1 ; \ USART1_CR1.WAKE, Receiver wakeup method
: USART1_CR1.PCE ( -- x addr ) 10 bit USART1_CR1 ; \ USART1_CR1.PCE, Parity control enable
: USART1_CR1.PS ( -- x addr ) 9 bit USART1_CR1 ; \ USART1_CR1.PS, Parity selection
: USART1_CR1.PEIE ( -- x addr ) 8 bit USART1_CR1 ; \ USART1_CR1.PEIE, PE interrupt enable
: USART1_CR1.TXEIE ( -- x addr ) 7 bit USART1_CR1 ; \ USART1_CR1.TXEIE, interrupt enable
: USART1_CR1.TCIE ( -- x addr ) 6 bit USART1_CR1 ; \ USART1_CR1.TCIE, Transmission complete interrupt               enable
: USART1_CR1.RXNEIE ( -- x addr ) 5 bit USART1_CR1 ; \ USART1_CR1.RXNEIE, RXNE interrupt enable
: USART1_CR1.IDLEIE ( -- x addr ) 4 bit USART1_CR1 ; \ USART1_CR1.IDLEIE, IDLE interrupt enable
: USART1_CR1.TE ( -- x addr ) 3 bit USART1_CR1 ; \ USART1_CR1.TE, Transmitter enable
: USART1_CR1.RE ( -- x addr ) 2 bit USART1_CR1 ; \ USART1_CR1.RE, Receiver enable
: USART1_CR1.UESM ( -- x addr ) 1 bit USART1_CR1 ; \ USART1_CR1.UESM, USART enable in Stop mode
: USART1_CR1.UE ( -- x addr ) 0 bit USART1_CR1 ; \ USART1_CR1.UE, USART enable

\ USART1_CR2 (read-write) Reset:$0000
: USART1_CR2.ADD4_7 ( %bbbb -- x addr ) 28 lshift USART1_CR2 ; \ USART1_CR2.ADD4_7, Address of the USART node
: USART1_CR2.ADD0_3 ( %bbbb -- x addr ) 24 lshift USART1_CR2 ; \ USART1_CR2.ADD0_3, Address of the USART node
: USART1_CR2.RTOEN ( -- x addr ) 23 bit USART1_CR2 ; \ USART1_CR2.RTOEN, Receiver timeout enable
: USART1_CR2.ABRMOD ( %bb -- x addr ) 21 lshift USART1_CR2 ; \ USART1_CR2.ABRMOD, Auto baud rate mode
: USART1_CR2.ABREN ( -- x addr ) 20 bit USART1_CR2 ; \ USART1_CR2.ABREN, Auto baud rate enable
: USART1_CR2.MSBFIRST ( -- x addr ) 19 bit USART1_CR2 ; \ USART1_CR2.MSBFIRST, Most significant bit first
: USART1_CR2.TAINV ( -- x addr ) 18 bit USART1_CR2 ; \ USART1_CR2.TAINV, Binary data inversion
: USART1_CR2.TXINV ( -- x addr ) 17 bit USART1_CR2 ; \ USART1_CR2.TXINV, TX pin active level               inversion
: USART1_CR2.RXINV ( -- x addr ) 16 bit USART1_CR2 ; \ USART1_CR2.RXINV, RX pin active level               inversion
: USART1_CR2.SWAP ( -- x addr ) 15 bit USART1_CR2 ; \ USART1_CR2.SWAP, Swap TX/RX pins
: USART1_CR2.LINEN ( -- x addr ) 14 bit USART1_CR2 ; \ USART1_CR2.LINEN, LIN mode enable
: USART1_CR2.STOP ( %bb -- x addr ) 12 lshift USART1_CR2 ; \ USART1_CR2.STOP, STOP bits
: USART1_CR2.CLKEN ( -- x addr ) 11 bit USART1_CR2 ; \ USART1_CR2.CLKEN, Clock enable
: USART1_CR2.CPOL ( -- x addr ) 10 bit USART1_CR2 ; \ USART1_CR2.CPOL, Clock polarity
: USART1_CR2.CPHA ( -- x addr ) 9 bit USART1_CR2 ; \ USART1_CR2.CPHA, Clock phase
: USART1_CR2.LBCL ( -- x addr ) 8 bit USART1_CR2 ; \ USART1_CR2.LBCL, Last bit clock pulse
: USART1_CR2.LBDIE ( -- x addr ) 6 bit USART1_CR2 ; \ USART1_CR2.LBDIE, LIN break detection interrupt               enable
: USART1_CR2.LBDL ( -- x addr ) 5 bit USART1_CR2 ; \ USART1_CR2.LBDL, LIN break detection length
: USART1_CR2.ADDM7 ( -- x addr ) 4 bit USART1_CR2 ; \ USART1_CR2.ADDM7, 7-bit Address Detection/4-bit Address               Detection
: USART1_CR2.DIS_NSS ( -- x addr ) 3 bit USART1_CR2 ; \ USART1_CR2.DIS_NSS, When the DSI_NSS bit is set, the NSS pin               input will be ignored
: USART1_CR2.SLVEN ( -- x addr ) 0 bit USART1_CR2 ; \ USART1_CR2.SLVEN, Synchronous Slave mode               enable

\ USART1_CR3 (read-write) Reset:$0000
: USART1_CR3.TXFTCFG ( %bbb -- x addr ) 29 lshift USART1_CR3 ; \ USART1_CR3.TXFTCFG, TXFIFO threshold               configuration
: USART1_CR3.RXFTIE ( -- x addr ) 28 bit USART1_CR3 ; \ USART1_CR3.RXFTIE, RXFIFO threshold interrupt               enable
: USART1_CR3.RXFTCFG ( %bbb -- x addr ) 25 lshift USART1_CR3 ; \ USART1_CR3.RXFTCFG, Receive FIFO threshold               configuration
: USART1_CR3.TCBGTIE ( -- x addr ) 24 bit USART1_CR3 ; \ USART1_CR3.TCBGTIE, Tr Complete before guard time, interrupt               enable
: USART1_CR3.TXFTIE ( -- x addr ) 23 bit USART1_CR3 ; \ USART1_CR3.TXFTIE, threshold interrupt enable
: USART1_CR3.WUFIE ( -- x addr ) 22 bit USART1_CR3 ; \ USART1_CR3.WUFIE, Wakeup from Stop mode interrupt               enable
: USART1_CR3.WUS ( %bb -- x addr ) 20 lshift USART1_CR3 ; \ USART1_CR3.WUS, Wakeup from Stop mode interrupt flag               selection
: USART1_CR3.SCARCNT ( %bbb -- x addr ) 17 lshift USART1_CR3 ; \ USART1_CR3.SCARCNT, Smartcard auto-retry count
: USART1_CR3.DEP ( -- x addr ) 15 bit USART1_CR3 ; \ USART1_CR3.DEP, Driver enable polarity               selection
: USART1_CR3.DEM ( -- x addr ) 14 bit USART1_CR3 ; \ USART1_CR3.DEM, Driver enable mode
: USART1_CR3.DDRE ( -- x addr ) 13 bit USART1_CR3 ; \ USART1_CR3.DDRE, DMA Disable on Reception               Error
: USART1_CR3.OVRDIS ( -- x addr ) 12 bit USART1_CR3 ; \ USART1_CR3.OVRDIS, Overrun Disable
: USART1_CR3.ONEBIT ( -- x addr ) 11 bit USART1_CR3 ; \ USART1_CR3.ONEBIT, One sample bit method               enable
: USART1_CR3.CTSIE ( -- x addr ) 10 bit USART1_CR3 ; \ USART1_CR3.CTSIE, CTS interrupt enable
: USART1_CR3.CTSE ( -- x addr ) 9 bit USART1_CR3 ; \ USART1_CR3.CTSE, CTS enable
: USART1_CR3.RTSE ( -- x addr ) 8 bit USART1_CR3 ; \ USART1_CR3.RTSE, RTS enable
: USART1_CR3.DMAT ( -- x addr ) 7 bit USART1_CR3 ; \ USART1_CR3.DMAT, DMA enable transmitter
: USART1_CR3.DMAR ( -- x addr ) 6 bit USART1_CR3 ; \ USART1_CR3.DMAR, DMA enable receiver
: USART1_CR3.SCEN ( -- x addr ) 5 bit USART1_CR3 ; \ USART1_CR3.SCEN, Smartcard mode enable
: USART1_CR3.NACK ( -- x addr ) 4 bit USART1_CR3 ; \ USART1_CR3.NACK, Smartcard NACK enable
: USART1_CR3.HDSEL ( -- x addr ) 3 bit USART1_CR3 ; \ USART1_CR3.HDSEL, Half-duplex selection
: USART1_CR3.IRLP ( -- x addr ) 2 bit USART1_CR3 ; \ USART1_CR3.IRLP, Ir low-power
: USART1_CR3.IREN ( -- x addr ) 1 bit USART1_CR3 ; \ USART1_CR3.IREN, Ir mode enable
: USART1_CR3.EIE ( -- x addr ) 0 bit USART1_CR3 ; \ USART1_CR3.EIE, Error interrupt enable

\ USART1_BRR (read-write) Reset:$0000
: USART1_BRR.BRR_4_15 ( %bbbbbbbbbbb -- x addr ) 4 lshift USART1_BRR ; \ USART1_BRR.BRR_4_15, BRR_4_15
: USART1_BRR.BRR_0_3 ( %bbbb -- x addr ) USART1_BRR ; \ USART1_BRR.BRR_0_3, BRR_0_3

\ USART1_GTPR (read-write) Reset:$0000
: USART1_GTPR.GT ( %bbbbbbbb -- x addr ) 8 lshift USART1_GTPR ; \ USART1_GTPR.GT, Guard time value
: USART1_GTPR.PSC ( %bbbbbbbb -- x addr ) USART1_GTPR ; \ USART1_GTPR.PSC, Prescaler value

\ USART1_RTOR (read-write) Reset:$0000
: USART1_RTOR.BLEN ( %bbbbbbbb -- x addr ) 24 lshift USART1_RTOR ; \ USART1_RTOR.BLEN, Block Length
: USART1_RTOR.RTO ( %bbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) USART1_RTOR ; \ USART1_RTOR.RTO, Receiver timeout value

\ USART1_RQR (write-only) Reset:$0000
: USART1_RQR.TXFRQ ( -- x addr ) 4 bit USART1_RQR ; \ USART1_RQR.TXFRQ, Transmit data flush               request
: USART1_RQR.RXFRQ ( -- x addr ) 3 bit USART1_RQR ; \ USART1_RQR.RXFRQ, Receive data flush request
: USART1_RQR.MMRQ ( -- x addr ) 2 bit USART1_RQR ; \ USART1_RQR.MMRQ, Mute mode request
: USART1_RQR.SBKRQ ( -- x addr ) 1 bit USART1_RQR ; \ USART1_RQR.SBKRQ, Send break request
: USART1_RQR.ABRRQ ( -- x addr ) 0 bit USART1_RQR ; \ USART1_RQR.ABRRQ, Auto baud rate request

\ USART1_ISR (read-only) Reset:$00C0
: USART1_ISR.TXFT? ( --  1|0 ) 27 bit USART1_ISR bit@ ; \ USART1_ISR.TXFT, TXFIFO threshold flag
: USART1_ISR.RXFT? ( --  1|0 ) 26 bit USART1_ISR bit@ ; \ USART1_ISR.RXFT, RXFIFO threshold flag
: USART1_ISR.TCBGT? ( --  1|0 ) 25 bit USART1_ISR bit@ ; \ USART1_ISR.TCBGT, Transmission complete before guard time               flag
: USART1_ISR.RXFF? ( --  1|0 ) 24 bit USART1_ISR bit@ ; \ USART1_ISR.RXFF, RXFIFO Full
: USART1_ISR.TXFE? ( --  1|0 ) 23 bit USART1_ISR bit@ ; \ USART1_ISR.TXFE, TXFIFO Empty
: USART1_ISR.REACK? ( --  1|0 ) 22 bit USART1_ISR bit@ ; \ USART1_ISR.REACK, REACK
: USART1_ISR.TEACK? ( --  1|0 ) 21 bit USART1_ISR bit@ ; \ USART1_ISR.TEACK, TEACK
: USART1_ISR.WUF? ( --  1|0 ) 20 bit USART1_ISR bit@ ; \ USART1_ISR.WUF, WUF
: USART1_ISR.RWU? ( --  1|0 ) 19 bit USART1_ISR bit@ ; \ USART1_ISR.RWU, RWU
: USART1_ISR.SBKF? ( --  1|0 ) 18 bit USART1_ISR bit@ ; \ USART1_ISR.SBKF, SBKF
: USART1_ISR.CMF? ( --  1|0 ) 17 bit USART1_ISR bit@ ; \ USART1_ISR.CMF, CMF
: USART1_ISR.BUSY? ( --  1|0 ) 16 bit USART1_ISR bit@ ; \ USART1_ISR.BUSY, BUSY
: USART1_ISR.ABRF? ( --  1|0 ) 15 bit USART1_ISR bit@ ; \ USART1_ISR.ABRF, ABRF
: USART1_ISR.ABRE? ( --  1|0 ) 14 bit USART1_ISR bit@ ; \ USART1_ISR.ABRE, ABRE
: USART1_ISR.UDR? ( --  1|0 ) 13 bit USART1_ISR bit@ ; \ USART1_ISR.UDR, SPI slave underrun error               flag
: USART1_ISR.EOBF? ( --  1|0 ) 12 bit USART1_ISR bit@ ; \ USART1_ISR.EOBF, EOBF
: USART1_ISR.RTOF? ( --  1|0 ) 11 bit USART1_ISR bit@ ; \ USART1_ISR.RTOF, RTOF
: USART1_ISR.CTS? ( --  1|0 ) 10 bit USART1_ISR bit@ ; \ USART1_ISR.CTS, CTS
: USART1_ISR.CTSIF? ( --  1|0 ) 9 bit USART1_ISR bit@ ; \ USART1_ISR.CTSIF, CTSIF
: USART1_ISR.LBDF? ( --  1|0 ) 8 bit USART1_ISR bit@ ; \ USART1_ISR.LBDF, LBDF
: USART1_ISR.TXE? ( --  1|0 ) 7 bit USART1_ISR bit@ ; \ USART1_ISR.TXE, TXE
: USART1_ISR.TC? ( --  1|0 ) 6 bit USART1_ISR bit@ ; \ USART1_ISR.TC, TC
: USART1_ISR.RXNE? ( --  1|0 ) 5 bit USART1_ISR bit@ ; \ USART1_ISR.RXNE, RXNE
: USART1_ISR.IDLE? ( --  1|0 ) 4 bit USART1_ISR bit@ ; \ USART1_ISR.IDLE, IDLE
: USART1_ISR.ORE? ( --  1|0 ) 3 bit USART1_ISR bit@ ; \ USART1_ISR.ORE, ORE
: USART1_ISR.NF? ( --  1|0 ) 2 bit USART1_ISR bit@ ; \ USART1_ISR.NF, NF
: USART1_ISR.FE? ( --  1|0 ) 1 bit USART1_ISR bit@ ; \ USART1_ISR.FE, FE
: USART1_ISR.PE? ( --  1|0 ) 0 bit USART1_ISR bit@ ; \ USART1_ISR.PE, PE

\ USART1_ICR (write-only) Reset:$0000
: USART1_ICR.WUCF ( -- x addr ) 20 bit USART1_ICR ; \ USART1_ICR.WUCF, Wakeup from Stop mode clear               flag
: USART1_ICR.CMCF ( -- x addr ) 17 bit USART1_ICR ; \ USART1_ICR.CMCF, Character match clear flag
: USART1_ICR.UDRCF ( -- x addr ) 13 bit USART1_ICR ; \ USART1_ICR.UDRCF, SPI slave underrun clear               flag
: USART1_ICR.EOBCF ( -- x addr ) 12 bit USART1_ICR ; \ USART1_ICR.EOBCF, End of block clear flag
: USART1_ICR.RTOCF ( -- x addr ) 11 bit USART1_ICR ; \ USART1_ICR.RTOCF, Receiver timeout clear               flag
: USART1_ICR.CTSCF ( -- x addr ) 9 bit USART1_ICR ; \ USART1_ICR.CTSCF, CTS clear flag
: USART1_ICR.LBDCF ( -- x addr ) 8 bit USART1_ICR ; \ USART1_ICR.LBDCF, LIN break detection clear               flag
: USART1_ICR.TCBGTCF ( -- x addr ) 7 bit USART1_ICR ; \ USART1_ICR.TCBGTCF, Transmission complete before Guard time               clear flag
: USART1_ICR.TCCF ( -- x addr ) 6 bit USART1_ICR ; \ USART1_ICR.TCCF, Transmission complete clear               flag
: USART1_ICR.TXFECF ( -- x addr ) 5 bit USART1_ICR ; \ USART1_ICR.TXFECF, TXFIFO empty clear flag
: USART1_ICR.IDLECF ( -- x addr ) 4 bit USART1_ICR ; \ USART1_ICR.IDLECF, Idle line detected clear               flag
: USART1_ICR.ORECF ( -- x addr ) 3 bit USART1_ICR ; \ USART1_ICR.ORECF, Overrun error clear flag
: USART1_ICR.NCF ( -- x addr ) 2 bit USART1_ICR ; \ USART1_ICR.NCF, Noise detected clear flag
: USART1_ICR.FECF ( -- x addr ) 1 bit USART1_ICR ; \ USART1_ICR.FECF, Framing error clear flag
: USART1_ICR.PECF ( -- x addr ) 0 bit USART1_ICR ; \ USART1_ICR.PECF, Parity error clear flag

\ USART1_RDR (read-only) Reset:$0000
: USART1_RDR.RDR? ( --  x ) USART1_RDR @ ; \ USART1_RDR.RDR, Receive data value

\ USART1_TDR (read-write) Reset:$0000
: USART1_TDR.TDR ( %bbbbbbbbb -- x addr ) USART1_TDR ; \ USART1_TDR.TDR, Transmit data value

\ USART1_PRESC (read-write) Reset:$0000
: USART1_PRESC.PRESCALER ( %bbbb -- x addr ) USART1_PRESC ; \ USART1_PRESC.PRESCALER, Clock prescaler

\ USART2_CR1 (read-write) Reset:$0000
: USART2_CR1.RXFFIE ( -- x addr ) 31 bit USART2_CR1 ; \ USART2_CR1.RXFFIE, RXFIFO Full interrupt               enable
: USART2_CR1.TXFEIE ( -- x addr ) 30 bit USART2_CR1 ; \ USART2_CR1.TXFEIE, TXFIFO empty interrupt               enable
: USART2_CR1.FIFOEN ( -- x addr ) 29 bit USART2_CR1 ; \ USART2_CR1.FIFOEN, FIFO mode enable
: USART2_CR1.M1 ( -- x addr ) 28 bit USART2_CR1 ; \ USART2_CR1.M1, Word length
: USART2_CR1.EOBIE ( -- x addr ) 27 bit USART2_CR1 ; \ USART2_CR1.EOBIE, End of Block interrupt               enable
: USART2_CR1.RTOIE ( -- x addr ) 26 bit USART2_CR1 ; \ USART2_CR1.RTOIE, Receiver timeout interrupt               enable
: USART2_CR1.DEAT ( %bbbbb -- x addr ) 21 lshift USART2_CR1 ; \ USART2_CR1.DEAT, DEAT
: USART2_CR1.DEDT ( %bbbbb -- x addr ) 16 lshift USART2_CR1 ; \ USART2_CR1.DEDT, DEDT
: USART2_CR1.OVER8 ( -- x addr ) 15 bit USART2_CR1 ; \ USART2_CR1.OVER8, Oversampling mode
: USART2_CR1.CMIE ( -- x addr ) 14 bit USART2_CR1 ; \ USART2_CR1.CMIE, Character match interrupt               enable
: USART2_CR1.MME ( -- x addr ) 13 bit USART2_CR1 ; \ USART2_CR1.MME, Mute mode enable
: USART2_CR1.M0 ( -- x addr ) 12 bit USART2_CR1 ; \ USART2_CR1.M0, Word length
: USART2_CR1.WAKE ( -- x addr ) 11 bit USART2_CR1 ; \ USART2_CR1.WAKE, Receiver wakeup method
: USART2_CR1.PCE ( -- x addr ) 10 bit USART2_CR1 ; \ USART2_CR1.PCE, Parity control enable
: USART2_CR1.PS ( -- x addr ) 9 bit USART2_CR1 ; \ USART2_CR1.PS, Parity selection
: USART2_CR1.PEIE ( -- x addr ) 8 bit USART2_CR1 ; \ USART2_CR1.PEIE, PE interrupt enable
: USART2_CR1.TXEIE ( -- x addr ) 7 bit USART2_CR1 ; \ USART2_CR1.TXEIE, interrupt enable
: USART2_CR1.TCIE ( -- x addr ) 6 bit USART2_CR1 ; \ USART2_CR1.TCIE, Transmission complete interrupt               enable
: USART2_CR1.RXNEIE ( -- x addr ) 5 bit USART2_CR1 ; \ USART2_CR1.RXNEIE, RXNE interrupt enable
: USART2_CR1.IDLEIE ( -- x addr ) 4 bit USART2_CR1 ; \ USART2_CR1.IDLEIE, IDLE interrupt enable
: USART2_CR1.TE ( -- x addr ) 3 bit USART2_CR1 ; \ USART2_CR1.TE, Transmitter enable
: USART2_CR1.RE ( -- x addr ) 2 bit USART2_CR1 ; \ USART2_CR1.RE, Receiver enable
: USART2_CR1.UESM ( -- x addr ) 1 bit USART2_CR1 ; \ USART2_CR1.UESM, USART enable in Stop mode
: USART2_CR1.UE ( -- x addr ) 0 bit USART2_CR1 ; \ USART2_CR1.UE, USART enable

\ USART2_CR2 (read-write) Reset:$0000
: USART2_CR2.ADD4_7 ( %bbbb -- x addr ) 28 lshift USART2_CR2 ; \ USART2_CR2.ADD4_7, Address of the USART node
: USART2_CR2.ADD0_3 ( %bbbb -- x addr ) 24 lshift USART2_CR2 ; \ USART2_CR2.ADD0_3, Address of the USART node
: USART2_CR2.RTOEN ( -- x addr ) 23 bit USART2_CR2 ; \ USART2_CR2.RTOEN, Receiver timeout enable
: USART2_CR2.ABRMOD ( %bb -- x addr ) 21 lshift USART2_CR2 ; \ USART2_CR2.ABRMOD, Auto baud rate mode
: USART2_CR2.ABREN ( -- x addr ) 20 bit USART2_CR2 ; \ USART2_CR2.ABREN, Auto baud rate enable
: USART2_CR2.MSBFIRST ( -- x addr ) 19 bit USART2_CR2 ; \ USART2_CR2.MSBFIRST, Most significant bit first
: USART2_CR2.TAINV ( -- x addr ) 18 bit USART2_CR2 ; \ USART2_CR2.TAINV, Binary data inversion
: USART2_CR2.TXINV ( -- x addr ) 17 bit USART2_CR2 ; \ USART2_CR2.TXINV, TX pin active level               inversion
: USART2_CR2.RXINV ( -- x addr ) 16 bit USART2_CR2 ; \ USART2_CR2.RXINV, RX pin active level               inversion
: USART2_CR2.SWAP ( -- x addr ) 15 bit USART2_CR2 ; \ USART2_CR2.SWAP, Swap TX/RX pins
: USART2_CR2.LINEN ( -- x addr ) 14 bit USART2_CR2 ; \ USART2_CR2.LINEN, LIN mode enable
: USART2_CR2.STOP ( %bb -- x addr ) 12 lshift USART2_CR2 ; \ USART2_CR2.STOP, STOP bits
: USART2_CR2.CLKEN ( -- x addr ) 11 bit USART2_CR2 ; \ USART2_CR2.CLKEN, Clock enable
: USART2_CR2.CPOL ( -- x addr ) 10 bit USART2_CR2 ; \ USART2_CR2.CPOL, Clock polarity
: USART2_CR2.CPHA ( -- x addr ) 9 bit USART2_CR2 ; \ USART2_CR2.CPHA, Clock phase
: USART2_CR2.LBCL ( -- x addr ) 8 bit USART2_CR2 ; \ USART2_CR2.LBCL, Last bit clock pulse
: USART2_CR2.LBDIE ( -- x addr ) 6 bit USART2_CR2 ; \ USART2_CR2.LBDIE, LIN break detection interrupt               enable
: USART2_CR2.LBDL ( -- x addr ) 5 bit USART2_CR2 ; \ USART2_CR2.LBDL, LIN break detection length
: USART2_CR2.ADDM7 ( -- x addr ) 4 bit USART2_CR2 ; \ USART2_CR2.ADDM7, 7-bit Address Detection/4-bit Address               Detection
: USART2_CR2.DIS_NSS ( -- x addr ) 3 bit USART2_CR2 ; \ USART2_CR2.DIS_NSS, When the DSI_NSS bit is set, the NSS pin               input will be ignored
: USART2_CR2.SLVEN ( -- x addr ) 0 bit USART2_CR2 ; \ USART2_CR2.SLVEN, Synchronous Slave mode               enable

\ USART2_CR3 (read-write) Reset:$0000
: USART2_CR3.TXFTCFG ( %bbb -- x addr ) 29 lshift USART2_CR3 ; \ USART2_CR3.TXFTCFG, TXFIFO threshold               configuration
: USART2_CR3.RXFTIE ( -- x addr ) 28 bit USART2_CR3 ; \ USART2_CR3.RXFTIE, RXFIFO threshold interrupt               enable
: USART2_CR3.RXFTCFG ( %bbb -- x addr ) 25 lshift USART2_CR3 ; \ USART2_CR3.RXFTCFG, Receive FIFO threshold               configuration
: USART2_CR3.TCBGTIE ( -- x addr ) 24 bit USART2_CR3 ; \ USART2_CR3.TCBGTIE, Tr Complete before guard time, interrupt               enable
: USART2_CR3.TXFTIE ( -- x addr ) 23 bit USART2_CR3 ; \ USART2_CR3.TXFTIE, threshold interrupt enable
: USART2_CR3.WUFIE ( -- x addr ) 22 bit USART2_CR3 ; \ USART2_CR3.WUFIE, Wakeup from Stop mode interrupt               enable
: USART2_CR3.WUS ( %bb -- x addr ) 20 lshift USART2_CR3 ; \ USART2_CR3.WUS, Wakeup from Stop mode interrupt flag               selection
: USART2_CR3.SCARCNT ( %bbb -- x addr ) 17 lshift USART2_CR3 ; \ USART2_CR3.SCARCNT, Smartcard auto-retry count
: USART2_CR3.DEP ( -- x addr ) 15 bit USART2_CR3 ; \ USART2_CR3.DEP, Driver enable polarity               selection
: USART2_CR3.DEM ( -- x addr ) 14 bit USART2_CR3 ; \ USART2_CR3.DEM, Driver enable mode
: USART2_CR3.DDRE ( -- x addr ) 13 bit USART2_CR3 ; \ USART2_CR3.DDRE, DMA Disable on Reception               Error
: USART2_CR3.OVRDIS ( -- x addr ) 12 bit USART2_CR3 ; \ USART2_CR3.OVRDIS, Overrun Disable
: USART2_CR3.ONEBIT ( -- x addr ) 11 bit USART2_CR3 ; \ USART2_CR3.ONEBIT, One sample bit method               enable
: USART2_CR3.CTSIE ( -- x addr ) 10 bit USART2_CR3 ; \ USART2_CR3.CTSIE, CTS interrupt enable
: USART2_CR3.CTSE ( -- x addr ) 9 bit USART2_CR3 ; \ USART2_CR3.CTSE, CTS enable
: USART2_CR3.RTSE ( -- x addr ) 8 bit USART2_CR3 ; \ USART2_CR3.RTSE, RTS enable
: USART2_CR3.DMAT ( -- x addr ) 7 bit USART2_CR3 ; \ USART2_CR3.DMAT, DMA enable transmitter
: USART2_CR3.DMAR ( -- x addr ) 6 bit USART2_CR3 ; \ USART2_CR3.DMAR, DMA enable receiver
: USART2_CR3.SCEN ( -- x addr ) 5 bit USART2_CR3 ; \ USART2_CR3.SCEN, Smartcard mode enable
: USART2_CR3.NACK ( -- x addr ) 4 bit USART2_CR3 ; \ USART2_CR3.NACK, Smartcard NACK enable
: USART2_CR3.HDSEL ( -- x addr ) 3 bit USART2_CR3 ; \ USART2_CR3.HDSEL, Half-duplex selection
: USART2_CR3.IRLP ( -- x addr ) 2 bit USART2_CR3 ; \ USART2_CR3.IRLP, Ir low-power
: USART2_CR3.IREN ( -- x addr ) 1 bit USART2_CR3 ; \ USART2_CR3.IREN, Ir mode enable
: USART2_CR3.EIE ( -- x addr ) 0 bit USART2_CR3 ; \ USART2_CR3.EIE, Error interrupt enable

\ USART2_BRR (read-write) Reset:$0000
: USART2_BRR.BRR_4_15 ( %bbbbbbbbbbb -- x addr ) 4 lshift USART2_BRR ; \ USART2_BRR.BRR_4_15, BRR_4_15
: USART2_BRR.BRR_0_3 ( %bbbb -- x addr ) USART2_BRR ; \ USART2_BRR.BRR_0_3, BRR_0_3

\ USART2_GTPR (read-write) Reset:$0000
: USART2_GTPR.GT ( %bbbbbbbb -- x addr ) 8 lshift USART2_GTPR ; \ USART2_GTPR.GT, Guard time value
: USART2_GTPR.PSC ( %bbbbbbbb -- x addr ) USART2_GTPR ; \ USART2_GTPR.PSC, Prescaler value

\ USART2_RTOR (read-write) Reset:$0000
: USART2_RTOR.BLEN ( %bbbbbbbb -- x addr ) 24 lshift USART2_RTOR ; \ USART2_RTOR.BLEN, Block Length
: USART2_RTOR.RTO ( %bbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) USART2_RTOR ; \ USART2_RTOR.RTO, Receiver timeout value

\ USART2_RQR (write-only) Reset:$0000
: USART2_RQR.TXFRQ ( -- x addr ) 4 bit USART2_RQR ; \ USART2_RQR.TXFRQ, Transmit data flush               request
: USART2_RQR.RXFRQ ( -- x addr ) 3 bit USART2_RQR ; \ USART2_RQR.RXFRQ, Receive data flush request
: USART2_RQR.MMRQ ( -- x addr ) 2 bit USART2_RQR ; \ USART2_RQR.MMRQ, Mute mode request
: USART2_RQR.SBKRQ ( -- x addr ) 1 bit USART2_RQR ; \ USART2_RQR.SBKRQ, Send break request
: USART2_RQR.ABRRQ ( -- x addr ) 0 bit USART2_RQR ; \ USART2_RQR.ABRRQ, Auto baud rate request

\ USART2_ISR (read-only) Reset:$00C0
: USART2_ISR.TXFT? ( --  1|0 ) 27 bit USART2_ISR bit@ ; \ USART2_ISR.TXFT, TXFIFO threshold flag
: USART2_ISR.RXFT? ( --  1|0 ) 26 bit USART2_ISR bit@ ; \ USART2_ISR.RXFT, RXFIFO threshold flag
: USART2_ISR.TCBGT? ( --  1|0 ) 25 bit USART2_ISR bit@ ; \ USART2_ISR.TCBGT, Transmission complete before guard time               flag
: USART2_ISR.RXFF? ( --  1|0 ) 24 bit USART2_ISR bit@ ; \ USART2_ISR.RXFF, RXFIFO Full
: USART2_ISR.TXFE? ( --  1|0 ) 23 bit USART2_ISR bit@ ; \ USART2_ISR.TXFE, TXFIFO Empty
: USART2_ISR.REACK? ( --  1|0 ) 22 bit USART2_ISR bit@ ; \ USART2_ISR.REACK, REACK
: USART2_ISR.TEACK? ( --  1|0 ) 21 bit USART2_ISR bit@ ; \ USART2_ISR.TEACK, TEACK
: USART2_ISR.WUF? ( --  1|0 ) 20 bit USART2_ISR bit@ ; \ USART2_ISR.WUF, WUF
: USART2_ISR.RWU? ( --  1|0 ) 19 bit USART2_ISR bit@ ; \ USART2_ISR.RWU, RWU
: USART2_ISR.SBKF? ( --  1|0 ) 18 bit USART2_ISR bit@ ; \ USART2_ISR.SBKF, SBKF
: USART2_ISR.CMF? ( --  1|0 ) 17 bit USART2_ISR bit@ ; \ USART2_ISR.CMF, CMF
: USART2_ISR.BUSY? ( --  1|0 ) 16 bit USART2_ISR bit@ ; \ USART2_ISR.BUSY, BUSY
: USART2_ISR.ABRF? ( --  1|0 ) 15 bit USART2_ISR bit@ ; \ USART2_ISR.ABRF, ABRF
: USART2_ISR.ABRE? ( --  1|0 ) 14 bit USART2_ISR bit@ ; \ USART2_ISR.ABRE, ABRE
: USART2_ISR.UDR? ( --  1|0 ) 13 bit USART2_ISR bit@ ; \ USART2_ISR.UDR, SPI slave underrun error               flag
: USART2_ISR.EOBF? ( --  1|0 ) 12 bit USART2_ISR bit@ ; \ USART2_ISR.EOBF, EOBF
: USART2_ISR.RTOF? ( --  1|0 ) 11 bit USART2_ISR bit@ ; \ USART2_ISR.RTOF, RTOF
: USART2_ISR.CTS? ( --  1|0 ) 10 bit USART2_ISR bit@ ; \ USART2_ISR.CTS, CTS
: USART2_ISR.CTSIF? ( --  1|0 ) 9 bit USART2_ISR bit@ ; \ USART2_ISR.CTSIF, CTSIF
: USART2_ISR.LBDF? ( --  1|0 ) 8 bit USART2_ISR bit@ ; \ USART2_ISR.LBDF, LBDF
: USART2_ISR.TXE? ( --  1|0 ) 7 bit USART2_ISR bit@ ; \ USART2_ISR.TXE, TXE
: USART2_ISR.TC? ( --  1|0 ) 6 bit USART2_ISR bit@ ; \ USART2_ISR.TC, TC
: USART2_ISR.RXNE? ( --  1|0 ) 5 bit USART2_ISR bit@ ; \ USART2_ISR.RXNE, RXNE
: USART2_ISR.IDLE? ( --  1|0 ) 4 bit USART2_ISR bit@ ; \ USART2_ISR.IDLE, IDLE
: USART2_ISR.ORE? ( --  1|0 ) 3 bit USART2_ISR bit@ ; \ USART2_ISR.ORE, ORE
: USART2_ISR.NF? ( --  1|0 ) 2 bit USART2_ISR bit@ ; \ USART2_ISR.NF, NF
: USART2_ISR.FE? ( --  1|0 ) 1 bit USART2_ISR bit@ ; \ USART2_ISR.FE, FE
: USART2_ISR.PE? ( --  1|0 ) 0 bit USART2_ISR bit@ ; \ USART2_ISR.PE, PE

\ USART2_ICR (write-only) Reset:$0000
: USART2_ICR.WUCF ( -- x addr ) 20 bit USART2_ICR ; \ USART2_ICR.WUCF, Wakeup from Stop mode clear               flag
: USART2_ICR.CMCF ( -- x addr ) 17 bit USART2_ICR ; \ USART2_ICR.CMCF, Character match clear flag
: USART2_ICR.UDRCF ( -- x addr ) 13 bit USART2_ICR ; \ USART2_ICR.UDRCF, SPI slave underrun clear               flag
: USART2_ICR.EOBCF ( -- x addr ) 12 bit USART2_ICR ; \ USART2_ICR.EOBCF, End of block clear flag
: USART2_ICR.RTOCF ( -- x addr ) 11 bit USART2_ICR ; \ USART2_ICR.RTOCF, Receiver timeout clear               flag
: USART2_ICR.CTSCF ( -- x addr ) 9 bit USART2_ICR ; \ USART2_ICR.CTSCF, CTS clear flag
: USART2_ICR.LBDCF ( -- x addr ) 8 bit USART2_ICR ; \ USART2_ICR.LBDCF, LIN break detection clear               flag
: USART2_ICR.TCBGTCF ( -- x addr ) 7 bit USART2_ICR ; \ USART2_ICR.TCBGTCF, Transmission complete before Guard time               clear flag
: USART2_ICR.TCCF ( -- x addr ) 6 bit USART2_ICR ; \ USART2_ICR.TCCF, Transmission complete clear               flag
: USART2_ICR.TXFECF ( -- x addr ) 5 bit USART2_ICR ; \ USART2_ICR.TXFECF, TXFIFO empty clear flag
: USART2_ICR.IDLECF ( -- x addr ) 4 bit USART2_ICR ; \ USART2_ICR.IDLECF, Idle line detected clear               flag
: USART2_ICR.ORECF ( -- x addr ) 3 bit USART2_ICR ; \ USART2_ICR.ORECF, Overrun error clear flag
: USART2_ICR.NCF ( -- x addr ) 2 bit USART2_ICR ; \ USART2_ICR.NCF, Noise detected clear flag
: USART2_ICR.FECF ( -- x addr ) 1 bit USART2_ICR ; \ USART2_ICR.FECF, Framing error clear flag
: USART2_ICR.PECF ( -- x addr ) 0 bit USART2_ICR ; \ USART2_ICR.PECF, Parity error clear flag

\ USART2_RDR (read-only) Reset:$0000
: USART2_RDR.RDR? ( --  x ) USART2_RDR @ ; \ USART2_RDR.RDR, Receive data value

\ USART2_TDR (read-write) Reset:$0000
: USART2_TDR.TDR ( %bbbbbbbbb -- x addr ) USART2_TDR ; \ USART2_TDR.TDR, Transmit data value

\ USART2_PRESC (read-write) Reset:$0000
: USART2_PRESC.PRESCALER ( %bbbb -- x addr ) USART2_PRESC ; \ USART2_PRESC.PRESCALER, Clock prescaler

\ SPI1_CR1 (read-write) Reset:$0000
: SPI1_CR1.BIDIMODE ( -- x addr ) 15 bit SPI1_CR1 ; \ SPI1_CR1.BIDIMODE, Bidirectional data mode               enable
: SPI1_CR1.BIDIOE ( -- x addr ) 14 bit SPI1_CR1 ; \ SPI1_CR1.BIDIOE, Output enable in bidirectional               mode
: SPI1_CR1.CRCEN ( -- x addr ) 13 bit SPI1_CR1 ; \ SPI1_CR1.CRCEN, Hardware CRC calculation               enable
: SPI1_CR1.CRCNEXT ( -- x addr ) 12 bit SPI1_CR1 ; \ SPI1_CR1.CRCNEXT, CRC transfer next
: SPI1_CR1.DFF ( -- x addr ) 11 bit SPI1_CR1 ; \ SPI1_CR1.DFF, Data frame format
: SPI1_CR1.RXONLY ( -- x addr ) 10 bit SPI1_CR1 ; \ SPI1_CR1.RXONLY, Receive only
: SPI1_CR1.SSM ( -- x addr ) 9 bit SPI1_CR1 ; \ SPI1_CR1.SSM, Software slave management
: SPI1_CR1.SSI ( -- x addr ) 8 bit SPI1_CR1 ; \ SPI1_CR1.SSI, Internal slave select
: SPI1_CR1.LSBFIRST ( -- x addr ) 7 bit SPI1_CR1 ; \ SPI1_CR1.LSBFIRST, Frame format
: SPI1_CR1.SPE ( -- x addr ) 6 bit SPI1_CR1 ; \ SPI1_CR1.SPE, SPI enable
: SPI1_CR1.BR ( %bbb -- x addr ) 3 lshift SPI1_CR1 ; \ SPI1_CR1.BR, Baud rate control
: SPI1_CR1.MSTR ( -- x addr ) 2 bit SPI1_CR1 ; \ SPI1_CR1.MSTR, Master selection
: SPI1_CR1.CPOL ( -- x addr ) 1 bit SPI1_CR1 ; \ SPI1_CR1.CPOL, Clock polarity
: SPI1_CR1.CPHA ( -- x addr ) 0 bit SPI1_CR1 ; \ SPI1_CR1.CPHA, Clock phase

\ SPI1_CR2 (read-write) Reset:$0000
: SPI1_CR2.RXDMAEN ( -- x addr ) 0 bit SPI1_CR2 ; \ SPI1_CR2.RXDMAEN, Rx buffer DMA enable
: SPI1_CR2.TXDMAEN ( -- x addr ) 1 bit SPI1_CR2 ; \ SPI1_CR2.TXDMAEN, Tx buffer DMA enable
: SPI1_CR2.SSOE ( -- x addr ) 2 bit SPI1_CR2 ; \ SPI1_CR2.SSOE, SS output enable
: SPI1_CR2.NSSP ( -- x addr ) 3 bit SPI1_CR2 ; \ SPI1_CR2.NSSP, NSS pulse management
: SPI1_CR2.FRF ( -- x addr ) 4 bit SPI1_CR2 ; \ SPI1_CR2.FRF, Frame format
: SPI1_CR2.ERRIE ( -- x addr ) 5 bit SPI1_CR2 ; \ SPI1_CR2.ERRIE, Error interrupt enable
: SPI1_CR2.RXNEIE ( -- x addr ) 6 bit SPI1_CR2 ; \ SPI1_CR2.RXNEIE, RX buffer not empty interrupt               enable
: SPI1_CR2.TXEIE ( -- x addr ) 7 bit SPI1_CR2 ; \ SPI1_CR2.TXEIE, Tx buffer empty interrupt               enable
: SPI1_CR2.DS ( %bbbb -- x addr ) 8 lshift SPI1_CR2 ; \ SPI1_CR2.DS, Data size
: SPI1_CR2.FRXTH ( -- x addr ) 12 bit SPI1_CR2 ; \ SPI1_CR2.FRXTH, FIFO reception threshold
: SPI1_CR2.LDMA_RX ( -- x addr ) 13 bit SPI1_CR2 ; \ SPI1_CR2.LDMA_RX, Last DMA transfer for               reception
: SPI1_CR2.LDMA_TX ( -- x addr ) 14 bit SPI1_CR2 ; \ SPI1_CR2.LDMA_TX, Last DMA transfer for               transmission

\ SPI1_SR (multiple-access)  Reset:$0002
: SPI1_SR.RXNE ( -- x addr ) 0 bit SPI1_SR ; \ SPI1_SR.RXNE, Receive buffer not empty
: SPI1_SR.TXE ( -- x addr ) 1 bit SPI1_SR ; \ SPI1_SR.TXE, Transmit buffer empty
: SPI1_SR.CHSIDE ( -- x addr ) 2 bit SPI1_SR ; \ SPI1_SR.CHSIDE, Channel side
: SPI1_SR.UDR? ( -- 1|0 ) 3 bit SPI1_SR bit@ ; \ SPI1_SR.UDR, Underrun flag
: SPI1_SR.CRCERR? ( -- 1|0 ) 4 bit SPI1_SR bit@ ; \ SPI1_SR.CRCERR, CRC error flag
: SPI1_SR.MODF ( -- x addr ) 5 bit SPI1_SR ; \ SPI1_SR.MODF, Mode fault
: SPI1_SR.OVR? ( -- 1|0 ) 6 bit SPI1_SR bit@ ; \ SPI1_SR.OVR, Overrun flag
: SPI1_SR.BSY? ( -- 1|0 ) 7 bit SPI1_SR bit@ ; \ SPI1_SR.BSY, Busy flag
: SPI1_SR.TIFRFE ( -- x addr ) 8 bit SPI1_SR ; \ SPI1_SR.TIFRFE, TI frame format error
: SPI1_SR.FRLVL ( %bb -- x addr ) 9 lshift SPI1_SR ; \ SPI1_SR.FRLVL, FIFO reception level
: SPI1_SR.FTLVL ( %bb -- x addr ) 11 lshift SPI1_SR ; \ SPI1_SR.FTLVL, FIFO transmission level

\ SPI1_DR (read-write) Reset:$0000
: SPI1_DR.DR ( %bbbbbbbbbbbbbbbb -- x addr ) SPI1_DR ; \ SPI1_DR.DR, Data register

\ SPI1_CRCPR (read-write) Reset:$0007
: SPI1_CRCPR.CRCPOLY ( %bbbbbbbbbbbbbbbb -- x addr ) SPI1_CRCPR ; \ SPI1_CRCPR.CRCPOLY, CRC polynomial register

\ SPI1_RXCRCR (read-only) Reset:$0000
: SPI1_RXCRCR.RxCRC? ( --  x ) SPI1_RXCRCR @ ; \ SPI1_RXCRCR.RxCRC, Rx CRC register

\ SPI1_TXCRCR (read-only) Reset:$0000
: SPI1_TXCRCR.TxCRC? ( --  x ) SPI1_TXCRCR @ ; \ SPI1_TXCRCR.TxCRC, Tx CRC register

\ SPI1_I2SCFGR (read-write) Reset:$0000
: SPI1_I2SCFGR.CHLEN ( -- x addr ) 0 bit SPI1_I2SCFGR ; \ SPI1_I2SCFGR.CHLEN, Channel length (number of bits per audio               channel)
: SPI1_I2SCFGR.DATLEN ( %bb -- x addr ) 1 lshift SPI1_I2SCFGR ; \ SPI1_I2SCFGR.DATLEN, Data length to be               transferred
: SPI1_I2SCFGR.CKPOL ( -- x addr ) 3 bit SPI1_I2SCFGR ; \ SPI1_I2SCFGR.CKPOL, Inactive state clock               polarity
: SPI1_I2SCFGR.I2SSTD ( %bb -- x addr ) 4 lshift SPI1_I2SCFGR ; \ SPI1_I2SCFGR.I2SSTD, standard selection
: SPI1_I2SCFGR.PCMSYNC ( -- x addr ) 7 bit SPI1_I2SCFGR ; \ SPI1_I2SCFGR.PCMSYNC, PCM frame synchronization
: SPI1_I2SCFGR.I2SCFG ( %bb -- x addr ) 8 lshift SPI1_I2SCFGR ; \ SPI1_I2SCFGR.I2SCFG, I2S configuration mode
: SPI1_I2SCFGR.SE2 ( -- x addr ) 10 bit SPI1_I2SCFGR ; \ SPI1_I2SCFGR.SE2, I2S enable
: SPI1_I2SCFGR.I2SMOD ( -- x addr ) 11 bit SPI1_I2SCFGR ; \ SPI1_I2SCFGR.I2SMOD, I2S mode selection

\ SPI1_I2SPR (read-write) Reset:$0000
: SPI1_I2SPR.I2SDIV ( %bbbbbbbb -- x addr ) SPI1_I2SPR ; \ SPI1_I2SPR.I2SDIV, linear prescaler
: SPI1_I2SPR.ODD ( -- x addr ) 8 bit SPI1_I2SPR ; \ SPI1_I2SPR.ODD, Odd factor for the               prescaler
: SPI1_I2SPR.MCKOE ( -- x addr ) 9 bit SPI1_I2SPR ; \ SPI1_I2SPR.MCKOE, Master clock output enable

\ SPI2_CR1 (read-write) Reset:$0000
: SPI2_CR1.BIDIMODE ( -- x addr ) 15 bit SPI2_CR1 ; \ SPI2_CR1.BIDIMODE, Bidirectional data mode               enable
: SPI2_CR1.BIDIOE ( -- x addr ) 14 bit SPI2_CR1 ; \ SPI2_CR1.BIDIOE, Output enable in bidirectional               mode
: SPI2_CR1.CRCEN ( -- x addr ) 13 bit SPI2_CR1 ; \ SPI2_CR1.CRCEN, Hardware CRC calculation               enable
: SPI2_CR1.CRCNEXT ( -- x addr ) 12 bit SPI2_CR1 ; \ SPI2_CR1.CRCNEXT, CRC transfer next
: SPI2_CR1.DFF ( -- x addr ) 11 bit SPI2_CR1 ; \ SPI2_CR1.DFF, Data frame format
: SPI2_CR1.RXONLY ( -- x addr ) 10 bit SPI2_CR1 ; \ SPI2_CR1.RXONLY, Receive only
: SPI2_CR1.SSM ( -- x addr ) 9 bit SPI2_CR1 ; \ SPI2_CR1.SSM, Software slave management
: SPI2_CR1.SSI ( -- x addr ) 8 bit SPI2_CR1 ; \ SPI2_CR1.SSI, Internal slave select
: SPI2_CR1.LSBFIRST ( -- x addr ) 7 bit SPI2_CR1 ; \ SPI2_CR1.LSBFIRST, Frame format
: SPI2_CR1.SPE ( -- x addr ) 6 bit SPI2_CR1 ; \ SPI2_CR1.SPE, SPI enable
: SPI2_CR1.BR ( %bbb -- x addr ) 3 lshift SPI2_CR1 ; \ SPI2_CR1.BR, Baud rate control
: SPI2_CR1.MSTR ( -- x addr ) 2 bit SPI2_CR1 ; \ SPI2_CR1.MSTR, Master selection
: SPI2_CR1.CPOL ( -- x addr ) 1 bit SPI2_CR1 ; \ SPI2_CR1.CPOL, Clock polarity
: SPI2_CR1.CPHA ( -- x addr ) 0 bit SPI2_CR1 ; \ SPI2_CR1.CPHA, Clock phase

\ SPI2_CR2 (read-write) Reset:$0000
: SPI2_CR2.RXDMAEN ( -- x addr ) 0 bit SPI2_CR2 ; \ SPI2_CR2.RXDMAEN, Rx buffer DMA enable
: SPI2_CR2.TXDMAEN ( -- x addr ) 1 bit SPI2_CR2 ; \ SPI2_CR2.TXDMAEN, Tx buffer DMA enable
: SPI2_CR2.SSOE ( -- x addr ) 2 bit SPI2_CR2 ; \ SPI2_CR2.SSOE, SS output enable
: SPI2_CR2.NSSP ( -- x addr ) 3 bit SPI2_CR2 ; \ SPI2_CR2.NSSP, NSS pulse management
: SPI2_CR2.FRF ( -- x addr ) 4 bit SPI2_CR2 ; \ SPI2_CR2.FRF, Frame format
: SPI2_CR2.ERRIE ( -- x addr ) 5 bit SPI2_CR2 ; \ SPI2_CR2.ERRIE, Error interrupt enable
: SPI2_CR2.RXNEIE ( -- x addr ) 6 bit SPI2_CR2 ; \ SPI2_CR2.RXNEIE, RX buffer not empty interrupt               enable
: SPI2_CR2.TXEIE ( -- x addr ) 7 bit SPI2_CR2 ; \ SPI2_CR2.TXEIE, Tx buffer empty interrupt               enable
: SPI2_CR2.DS ( %bbbb -- x addr ) 8 lshift SPI2_CR2 ; \ SPI2_CR2.DS, Data size
: SPI2_CR2.FRXTH ( -- x addr ) 12 bit SPI2_CR2 ; \ SPI2_CR2.FRXTH, FIFO reception threshold
: SPI2_CR2.LDMA_RX ( -- x addr ) 13 bit SPI2_CR2 ; \ SPI2_CR2.LDMA_RX, Last DMA transfer for               reception
: SPI2_CR2.LDMA_TX ( -- x addr ) 14 bit SPI2_CR2 ; \ SPI2_CR2.LDMA_TX, Last DMA transfer for               transmission

\ SPI2_SR (multiple-access)  Reset:$0002
: SPI2_SR.RXNE ( -- x addr ) 0 bit SPI2_SR ; \ SPI2_SR.RXNE, Receive buffer not empty
: SPI2_SR.TXE ( -- x addr ) 1 bit SPI2_SR ; \ SPI2_SR.TXE, Transmit buffer empty
: SPI2_SR.CHSIDE ( -- x addr ) 2 bit SPI2_SR ; \ SPI2_SR.CHSIDE, Channel side
: SPI2_SR.UDR? ( -- 1|0 ) 3 bit SPI2_SR bit@ ; \ SPI2_SR.UDR, Underrun flag
: SPI2_SR.CRCERR? ( -- 1|0 ) 4 bit SPI2_SR bit@ ; \ SPI2_SR.CRCERR, CRC error flag
: SPI2_SR.MODF ( -- x addr ) 5 bit SPI2_SR ; \ SPI2_SR.MODF, Mode fault
: SPI2_SR.OVR? ( -- 1|0 ) 6 bit SPI2_SR bit@ ; \ SPI2_SR.OVR, Overrun flag
: SPI2_SR.BSY? ( -- 1|0 ) 7 bit SPI2_SR bit@ ; \ SPI2_SR.BSY, Busy flag
: SPI2_SR.TIFRFE ( -- x addr ) 8 bit SPI2_SR ; \ SPI2_SR.TIFRFE, TI frame format error
: SPI2_SR.FRLVL ( %bb -- x addr ) 9 lshift SPI2_SR ; \ SPI2_SR.FRLVL, FIFO reception level
: SPI2_SR.FTLVL ( %bb -- x addr ) 11 lshift SPI2_SR ; \ SPI2_SR.FTLVL, FIFO transmission level

\ SPI2_DR (read-write) Reset:$0000
: SPI2_DR.DR ( %bbbbbbbbbbbbbbbb -- x addr ) SPI2_DR ; \ SPI2_DR.DR, Data register

\ SPI2_CRCPR (read-write) Reset:$0007
: SPI2_CRCPR.CRCPOLY ( %bbbbbbbbbbbbbbbb -- x addr ) SPI2_CRCPR ; \ SPI2_CRCPR.CRCPOLY, CRC polynomial register

\ SPI2_RXCRCR (read-only) Reset:$0000
: SPI2_RXCRCR.RxCRC? ( --  x ) SPI2_RXCRCR @ ; \ SPI2_RXCRCR.RxCRC, Rx CRC register

\ SPI2_TXCRCR (read-only) Reset:$0000
: SPI2_TXCRCR.TxCRC? ( --  x ) SPI2_TXCRCR @ ; \ SPI2_TXCRCR.TxCRC, Tx CRC register

\ SPI2_I2SCFGR (read-write) Reset:$0000
: SPI2_I2SCFGR.CHLEN ( -- x addr ) 0 bit SPI2_I2SCFGR ; \ SPI2_I2SCFGR.CHLEN, Channel length (number of bits per audio               channel)
: SPI2_I2SCFGR.DATLEN ( %bb -- x addr ) 1 lshift SPI2_I2SCFGR ; \ SPI2_I2SCFGR.DATLEN, Data length to be               transferred
: SPI2_I2SCFGR.CKPOL ( -- x addr ) 3 bit SPI2_I2SCFGR ; \ SPI2_I2SCFGR.CKPOL, Inactive state clock               polarity
: SPI2_I2SCFGR.I2SSTD ( %bb -- x addr ) 4 lshift SPI2_I2SCFGR ; \ SPI2_I2SCFGR.I2SSTD, standard selection
: SPI2_I2SCFGR.PCMSYNC ( -- x addr ) 7 bit SPI2_I2SCFGR ; \ SPI2_I2SCFGR.PCMSYNC, PCM frame synchronization
: SPI2_I2SCFGR.I2SCFG ( %bb -- x addr ) 8 lshift SPI2_I2SCFGR ; \ SPI2_I2SCFGR.I2SCFG, I2S configuration mode
: SPI2_I2SCFGR.SE2 ( -- x addr ) 10 bit SPI2_I2SCFGR ; \ SPI2_I2SCFGR.SE2, I2S enable
: SPI2_I2SCFGR.I2SMOD ( -- x addr ) 11 bit SPI2_I2SCFGR ; \ SPI2_I2SCFGR.I2SMOD, I2S mode selection

\ SPI2_I2SPR (read-write) Reset:$0000
: SPI2_I2SPR.I2SDIV ( %bbbbbbbb -- x addr ) SPI2_I2SPR ; \ SPI2_I2SPR.I2SDIV, linear prescaler
: SPI2_I2SPR.ODD ( -- x addr ) 8 bit SPI2_I2SPR ; \ SPI2_I2SPR.ODD, Odd factor for the               prescaler
: SPI2_I2SPR.MCKOE ( -- x addr ) 9 bit SPI2_I2SPR ; \ SPI2_I2SPR.MCKOE, Master clock output enable

\ TIM1_CR1 (read-write) Reset:$0000
: TIM1_CR1.CEN ( -- x addr ) 0 bit TIM1_CR1 ; \ TIM1_CR1.CEN, Counter enable
: TIM1_CR1.OPM ( -- x addr ) 3 bit TIM1_CR1 ; \ TIM1_CR1.OPM, One-pulse mode
: TIM1_CR1.UDIS ( -- x addr ) 1 bit TIM1_CR1 ; \ TIM1_CR1.UDIS, Update disable
: TIM1_CR1.URS ( -- x addr ) 2 bit TIM1_CR1 ; \ TIM1_CR1.URS, Update request source
: TIM1_CR1.DIR ( -- x addr ) 4 bit TIM1_CR1 ; \ TIM1_CR1.DIR, Direction
: TIM1_CR1.CMS ( %bb -- x addr ) 5 lshift TIM1_CR1 ; \ TIM1_CR1.CMS, Center-aligned mode               selection
: TIM1_CR1.ARPE ( -- x addr ) 7 bit TIM1_CR1 ; \ TIM1_CR1.ARPE, Auto-reload preload enable
: TIM1_CR1.CKD ( %bb -- x addr ) 8 lshift TIM1_CR1 ; \ TIM1_CR1.CKD, Clock division
: TIM1_CR1.UIFREMAP ( -- x addr ) 11 bit TIM1_CR1 ; \ TIM1_CR1.UIFREMAP, UIF status bit remapping

\ TIM1_CR2 (read-write) Reset:$0000
: TIM1_CR2.MMS2 ( %bbbb -- x addr ) 20 lshift TIM1_CR2 ; \ TIM1_CR2.MMS2, Master mode selection 2
: TIM1_CR2.OIS6 ( -- x addr ) 18 bit TIM1_CR2 ; \ TIM1_CR2.OIS6, Output Idle state 6 (OC6               output)
: TIM1_CR2.OIS5 ( -- x addr ) 16 bit TIM1_CR2 ; \ TIM1_CR2.OIS5, Output Idle state 5 (OC5               output)
: TIM1_CR2.OIS4 ( -- x addr ) 14 bit TIM1_CR2 ; \ TIM1_CR2.OIS4, Output Idle state 4
: TIM1_CR2.OIS3N ( -- x addr ) 13 bit TIM1_CR2 ; \ TIM1_CR2.OIS3N, Output Idle state 3
: TIM1_CR2.OIS3 ( -- x addr ) 12 bit TIM1_CR2 ; \ TIM1_CR2.OIS3, Output Idle state 3
: TIM1_CR2.OIS2N ( -- x addr ) 11 bit TIM1_CR2 ; \ TIM1_CR2.OIS2N, Output Idle state 2
: TIM1_CR2.OIS2 ( -- x addr ) 10 bit TIM1_CR2 ; \ TIM1_CR2.OIS2, Output Idle state 2
: TIM1_CR2.OIS1N ( -- x addr ) 9 bit TIM1_CR2 ; \ TIM1_CR2.OIS1N, Output Idle state 1
: TIM1_CR2.OIS1 ( -- x addr ) 8 bit TIM1_CR2 ; \ TIM1_CR2.OIS1, Output Idle state 1
: TIM1_CR2.TI1S ( -- x addr ) 7 bit TIM1_CR2 ; \ TIM1_CR2.TI1S, TI1 selection
: TIM1_CR2.MMS ( %bbb -- x addr ) 4 lshift TIM1_CR2 ; \ TIM1_CR2.MMS, Master mode selection
: TIM1_CR2.CCDS ( -- x addr ) 3 bit TIM1_CR2 ; \ TIM1_CR2.CCDS, Capture/compare DMA               selection
: TIM1_CR2.CCUS ( -- x addr ) 2 bit TIM1_CR2 ; \ TIM1_CR2.CCUS, Capture/compare control update               selection
: TIM1_CR2.CCPC ( -- x addr ) 0 bit TIM1_CR2 ; \ TIM1_CR2.CCPC, Capture/compare preloaded               control

\ TIM1_SMCR (read-write) Reset:$0000
: TIM1_SMCR.SMS ( %bbb -- x addr ) TIM1_SMCR ; \ TIM1_SMCR.SMS, Slave mode selection
: TIM1_SMCR.OCCS ( -- x addr ) 3 bit TIM1_SMCR ; \ TIM1_SMCR.OCCS, OCREF clear selection
: TIM1_SMCR.TS_4 ( %bbb -- x addr ) 4 lshift TIM1_SMCR ; \ TIM1_SMCR.TS_4, Trigger selection
: TIM1_SMCR.MSM ( -- x addr ) 7 bit TIM1_SMCR ; \ TIM1_SMCR.MSM, Master/Slave mode
: TIM1_SMCR.ETF ( %bbbb -- x addr ) 8 lshift TIM1_SMCR ; \ TIM1_SMCR.ETF, External trigger filter
: TIM1_SMCR.ETPS ( %bb -- x addr ) 12 lshift TIM1_SMCR ; \ TIM1_SMCR.ETPS, External trigger prescaler
: TIM1_SMCR.ECE ( -- x addr ) 14 bit TIM1_SMCR ; \ TIM1_SMCR.ECE, External clock enable
: TIM1_SMCR.ETP ( -- x addr ) 15 bit TIM1_SMCR ; \ TIM1_SMCR.ETP, External trigger polarity
: TIM1_SMCR.SMS_3 ( -- x addr ) 16 bit TIM1_SMCR ; \ TIM1_SMCR.SMS_3, Slave mode selection - bit               3
: TIM1_SMCR.TS ( %bb -- x addr ) 20 lshift TIM1_SMCR ; \ TIM1_SMCR.TS, Trigger selection

\ TIM1_DIER (read-write) Reset:$0000
: TIM1_DIER.UIE ( -- x addr ) 0 bit TIM1_DIER ; \ TIM1_DIER.UIE, Update interrupt enable
: TIM1_DIER.CC1IE ( -- x addr ) 1 bit TIM1_DIER ; \ TIM1_DIER.CC1IE, Capture/Compare 1 interrupt               enable
: TIM1_DIER.CC2IE ( -- x addr ) 2 bit TIM1_DIER ; \ TIM1_DIER.CC2IE, Capture/Compare 2 interrupt               enable
: TIM1_DIER.CC3IE ( -- x addr ) 3 bit TIM1_DIER ; \ TIM1_DIER.CC3IE, Capture/Compare 3 interrupt               enable
: TIM1_DIER.CC4IE ( -- x addr ) 4 bit TIM1_DIER ; \ TIM1_DIER.CC4IE, Capture/Compare 4 interrupt               enable
: TIM1_DIER.COMIE ( -- x addr ) 5 bit TIM1_DIER ; \ TIM1_DIER.COMIE, COM interrupt enable
: TIM1_DIER.TIE ( -- x addr ) 6 bit TIM1_DIER ; \ TIM1_DIER.TIE, Trigger interrupt enable
: TIM1_DIER.BIE ( -- x addr ) 7 bit TIM1_DIER ; \ TIM1_DIER.BIE, Break interrupt enable
: TIM1_DIER.UDE ( -- x addr ) 8 bit TIM1_DIER ; \ TIM1_DIER.UDE, Update DMA request enable
: TIM1_DIER.CC1DE ( -- x addr ) 9 bit TIM1_DIER ; \ TIM1_DIER.CC1DE, Capture/Compare 1 DMA request               enable
: TIM1_DIER.CC2DE ( -- x addr ) 10 bit TIM1_DIER ; \ TIM1_DIER.CC2DE, Capture/Compare 2 DMA request               enable
: TIM1_DIER.CC3DE ( -- x addr ) 11 bit TIM1_DIER ; \ TIM1_DIER.CC3DE, Capture/Compare 3 DMA request               enable
: TIM1_DIER.CC4DE ( -- x addr ) 12 bit TIM1_DIER ; \ TIM1_DIER.CC4DE, Capture/Compare 4 DMA request               enable
: TIM1_DIER.COMDE ( -- x addr ) 13 bit TIM1_DIER ; \ TIM1_DIER.COMDE, COM DMA request enable
: TIM1_DIER.TDE ( -- x addr ) 14 bit TIM1_DIER ; \ TIM1_DIER.TDE, Trigger DMA request enable

\ TIM1_SR (read-write) Reset:$0000
: TIM1_SR.UIF ( -- x addr ) 0 bit TIM1_SR ; \ TIM1_SR.UIF, Update interrupt flag
: TIM1_SR.CC1IF ( -- x addr ) 1 bit TIM1_SR ; \ TIM1_SR.CC1IF, Capture/compare 1 interrupt               flag
: TIM1_SR.CC2IF ( -- x addr ) 2 bit TIM1_SR ; \ TIM1_SR.CC2IF, Capture/Compare 2 interrupt               flag
: TIM1_SR.CC3IF ( -- x addr ) 3 bit TIM1_SR ; \ TIM1_SR.CC3IF, Capture/Compare 3 interrupt               flag
: TIM1_SR.CC4IF ( -- x addr ) 4 bit TIM1_SR ; \ TIM1_SR.CC4IF, Capture/Compare 4 interrupt               flag
: TIM1_SR.COMIF ( -- x addr ) 5 bit TIM1_SR ; \ TIM1_SR.COMIF, COM interrupt flag
: TIM1_SR.TIF ( -- x addr ) 6 bit TIM1_SR ; \ TIM1_SR.TIF, Trigger interrupt flag
: TIM1_SR.BIF ( -- x addr ) 7 bit TIM1_SR ; \ TIM1_SR.BIF, Break interrupt flag
: TIM1_SR.B2IF ( -- x addr ) 8 bit TIM1_SR ; \ TIM1_SR.B2IF, Break 2 interrupt flag
: TIM1_SR.CC1OF ( -- x addr ) 9 bit TIM1_SR ; \ TIM1_SR.CC1OF, Capture/Compare 1 overcapture               flag
: TIM1_SR.CC2OF ( -- x addr ) 10 bit TIM1_SR ; \ TIM1_SR.CC2OF, Capture/compare 2 overcapture               flag
: TIM1_SR.CC3OF ( -- x addr ) 11 bit TIM1_SR ; \ TIM1_SR.CC3OF, Capture/Compare 3 overcapture               flag
: TIM1_SR.CC4OF ( -- x addr ) 12 bit TIM1_SR ; \ TIM1_SR.CC4OF, Capture/Compare 4 overcapture               flag
: TIM1_SR.SBIF ( -- x addr ) 13 bit TIM1_SR ; \ TIM1_SR.SBIF, System Break interrupt               flag
: TIM1_SR.CC5IF ( -- x addr ) 16 bit TIM1_SR ; \ TIM1_SR.CC5IF, Compare 5 interrupt flag
: TIM1_SR.CC6IF ( -- x addr ) 17 bit TIM1_SR ; \ TIM1_SR.CC6IF, Compare 6 interrupt flag

\ TIM1_EGR (write-only) Reset:$0000
: TIM1_EGR.UG ( -- x addr ) 0 bit TIM1_EGR ; \ TIM1_EGR.UG, Update generation
: TIM1_EGR.CC1G ( -- x addr ) 1 bit TIM1_EGR ; \ TIM1_EGR.CC1G, Capture/compare 1               generation
: TIM1_EGR.CC2G ( -- x addr ) 2 bit TIM1_EGR ; \ TIM1_EGR.CC2G, Capture/compare 2               generation
: TIM1_EGR.CC3G ( -- x addr ) 3 bit TIM1_EGR ; \ TIM1_EGR.CC3G, Capture/compare 3               generation
: TIM1_EGR.CC4G ( -- x addr ) 4 bit TIM1_EGR ; \ TIM1_EGR.CC4G, Capture/compare 4               generation
: TIM1_EGR.COMG ( -- x addr ) 5 bit TIM1_EGR ; \ TIM1_EGR.COMG, Capture/Compare control update               generation
: TIM1_EGR.TG ( -- x addr ) 6 bit TIM1_EGR ; \ TIM1_EGR.TG, Trigger generation
: TIM1_EGR.BG ( -- x addr ) 7 bit TIM1_EGR ; \ TIM1_EGR.BG, Break generation
: TIM1_EGR.B2G ( -- x addr ) 8 bit TIM1_EGR ; \ TIM1_EGR.B2G, Break 2 generation

\ TIM1_CCMR1_Output (read-write) Reset:$00000000
: TIM1_CCMR1_Output.CC1S ( %bb -- x addr ) TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output.CC1S, Capture/Compare 1               selection
: TIM1_CCMR1_Output.OC1FE ( -- x addr ) 2 bit TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output.OC1FE, Output Compare 1 fast               enable
: TIM1_CCMR1_Output.OC1PE ( -- x addr ) 3 bit TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output.OC1PE, Output Compare 1 preload               enable
: TIM1_CCMR1_Output.OC1M ( %bbb -- x addr ) 4 lshift TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output.OC1M, Output Compare 1 mode
: TIM1_CCMR1_Output.OC1CE ( -- x addr ) 7 bit TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output.OC1CE, Output Compare 1 clear               enable
: TIM1_CCMR1_Output.CC2S ( %bb -- x addr ) 8 lshift TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output.CC2S, Capture/Compare 2               selection
: TIM1_CCMR1_Output.OC2FE ( -- x addr ) 10 bit TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output.OC2FE, Output Compare 2 fast               enable
: TIM1_CCMR1_Output.OC2PE ( -- x addr ) 11 bit TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output.OC2PE, Output Compare 2 preload               enable
: TIM1_CCMR1_Output.OC2M ( %bbb -- x addr ) 12 lshift TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output.OC2M, Output Compare 2 mode
: TIM1_CCMR1_Output.OC2CE ( -- x addr ) 15 bit TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output.OC2CE, Output Compare 2 clear               enable
: TIM1_CCMR1_Output.OC1M_3 ( -- x addr ) 16 bit TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output.OC1M_3, Output Compare 1 mode - bit               3
: TIM1_CCMR1_Output.OC2M_3 ( -- x addr ) 24 bit TIM1_CCMR1_Output ; \ TIM1_CCMR1_Output.OC2M_3, Output Compare 2 mode - bit               3

\ TIM1_CCMR1_Input (read-write) Reset:$00000000
: TIM1_CCMR1_Input.CC1S ( %bb -- x addr ) TIM1_CCMR1_Input ; \ TIM1_CCMR1_Input.CC1S, Capture/Compare 1               selection
: TIM1_CCMR1_Input.OC1FE ( -- x addr ) 2 bit TIM1_CCMR1_Input ; \ TIM1_CCMR1_Input.OC1FE, Output Compare 1 fast               enable
: TIM1_CCMR1_Input.OC1PE ( -- x addr ) 3 bit TIM1_CCMR1_Input ; \ TIM1_CCMR1_Input.OC1PE, Output Compare 1 preload               enable
: TIM1_CCMR1_Input.OC1M ( %bbb -- x addr ) 4 lshift TIM1_CCMR1_Input ; \ TIM1_CCMR1_Input.OC1M, Output Compare 1 mode
: TIM1_CCMR1_Input.OC1CE ( -- x addr ) 7 bit TIM1_CCMR1_Input ; \ TIM1_CCMR1_Input.OC1CE, Output Compare 1 clear               enable
: TIM1_CCMR1_Input.CC2S ( %bb -- x addr ) 8 lshift TIM1_CCMR1_Input ; \ TIM1_CCMR1_Input.CC2S, Capture/Compare 2               selection
: TIM1_CCMR1_Input.OC2FE ( -- x addr ) 10 bit TIM1_CCMR1_Input ; \ TIM1_CCMR1_Input.OC2FE, Output Compare 2 fast               enable
: TIM1_CCMR1_Input.OC2PE ( -- x addr ) 11 bit TIM1_CCMR1_Input ; \ TIM1_CCMR1_Input.OC2PE, Output Compare 2 preload               enable
: TIM1_CCMR1_Input.OC2M ( %bbb -- x addr ) 12 lshift TIM1_CCMR1_Input ; \ TIM1_CCMR1_Input.OC2M, Output Compare 2 mode
: TIM1_CCMR1_Input.OC2CE ( -- x addr ) 15 bit TIM1_CCMR1_Input ; \ TIM1_CCMR1_Input.OC2CE, Output Compare 2 clear               enable

\ TIM1_CCMR2_Output (read-write) Reset:$00000000
: TIM1_CCMR2_Output.CC3S ( %bb -- x addr ) TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output.CC3S, Capture/Compare 3               selection
: TIM1_CCMR2_Output.OC3FE ( -- x addr ) 2 bit TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output.OC3FE, Output compare 3 fast               enable
: TIM1_CCMR2_Output.OC3PE ( -- x addr ) 3 bit TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output.OC3PE, Output compare 3 preload               enable
: TIM1_CCMR2_Output.OC3M ( %bbb -- x addr ) 4 lshift TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output.OC3M, Output compare 3 mode
: TIM1_CCMR2_Output.OC3CE ( -- x addr ) 7 bit TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output.OC3CE, Output compare 3 clear               enable
: TIM1_CCMR2_Output.CC4S ( %bb -- x addr ) 8 lshift TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output.CC4S, Capture/Compare 4               selection
: TIM1_CCMR2_Output.OC4FE ( -- x addr ) 10 bit TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output.OC4FE, Output compare 4 fast               enable
: TIM1_CCMR2_Output.OC4PE ( -- x addr ) 11 bit TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output.OC4PE, Output compare 4 preload               enable
: TIM1_CCMR2_Output.OC4M ( %bbb -- x addr ) 12 lshift TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output.OC4M, Output compare 4 mode
: TIM1_CCMR2_Output.OC4CE ( -- x addr ) 15 bit TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output.OC4CE, Output compare 4 clear               enable
: TIM1_CCMR2_Output.OC3M_3 ( -- x addr ) 16 bit TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output.OC3M_3, Output Compare 3 mode - bit               3
: TIM1_CCMR2_Output.OC4M_3 ( -- x addr ) 24 bit TIM1_CCMR2_Output ; \ TIM1_CCMR2_Output.OC4M_3, Output Compare 4 mode - bit               3

\ TIM1_CCMR2_Input (read-write) Reset:$00000000
: TIM1_CCMR2_Input.CC3S ( %bb -- x addr ) TIM1_CCMR2_Input ; \ TIM1_CCMR2_Input.CC3S, Capture/Compare 3               selection
: TIM1_CCMR2_Input.OC3FE ( -- x addr ) 2 bit TIM1_CCMR2_Input ; \ TIM1_CCMR2_Input.OC3FE, Output compare 3 fast               enable
: TIM1_CCMR2_Input.OC3PE ( -- x addr ) 3 bit TIM1_CCMR2_Input ; \ TIM1_CCMR2_Input.OC3PE, Output compare 3 preload               enable
: TIM1_CCMR2_Input.OC3M ( %bbb -- x addr ) 4 lshift TIM1_CCMR2_Input ; \ TIM1_CCMR2_Input.OC3M, Output compare 3 mode
: TIM1_CCMR2_Input.OC3CE ( -- x addr ) 7 bit TIM1_CCMR2_Input ; \ TIM1_CCMR2_Input.OC3CE, Output compare 3 clear               enable
: TIM1_CCMR2_Input.CC4S ( %bb -- x addr ) 8 lshift TIM1_CCMR2_Input ; \ TIM1_CCMR2_Input.CC4S, Capture/Compare 4               selection
: TIM1_CCMR2_Input.OC4FE ( -- x addr ) 10 bit TIM1_CCMR2_Input ; \ TIM1_CCMR2_Input.OC4FE, Output compare 4 fast               enable
: TIM1_CCMR2_Input.OC4PE ( -- x addr ) 11 bit TIM1_CCMR2_Input ; \ TIM1_CCMR2_Input.OC4PE, Output compare 4 preload               enable
: TIM1_CCMR2_Input.OC4M ( %bbb -- x addr ) 12 lshift TIM1_CCMR2_Input ; \ TIM1_CCMR2_Input.OC4M, Output compare 4 mode
: TIM1_CCMR2_Input.OC4CE ( -- x addr ) 15 bit TIM1_CCMR2_Input ; \ TIM1_CCMR2_Input.OC4CE, Output compare 4 clear               enable

\ TIM1_CCER (read-write) Reset:$0000
: TIM1_CCER.CC1E ( -- x addr ) 0 bit TIM1_CCER ; \ TIM1_CCER.CC1E, Capture/Compare 1 output               enable
: TIM1_CCER.CC1P ( -- x addr ) 1 bit TIM1_CCER ; \ TIM1_CCER.CC1P, Capture/Compare 1 output               Polarity
: TIM1_CCER.CC1NE ( -- x addr ) 2 bit TIM1_CCER ; \ TIM1_CCER.CC1NE, Capture/Compare 1 complementary output               enable
: TIM1_CCER.CC1NP ( -- x addr ) 3 bit TIM1_CCER ; \ TIM1_CCER.CC1NP, Capture/Compare 1 output               Polarity
: TIM1_CCER.CC2E ( -- x addr ) 4 bit TIM1_CCER ; \ TIM1_CCER.CC2E, Capture/Compare 2 output               enable
: TIM1_CCER.CC2P ( -- x addr ) 5 bit TIM1_CCER ; \ TIM1_CCER.CC2P, Capture/Compare 2 output               Polarity
: TIM1_CCER.CC2NE ( -- x addr ) 6 bit TIM1_CCER ; \ TIM1_CCER.CC2NE, Capture/Compare 2 complementary output               enable
: TIM1_CCER.CC2NP ( -- x addr ) 7 bit TIM1_CCER ; \ TIM1_CCER.CC2NP, Capture/Compare 2 output               Polarity
: TIM1_CCER.CC3E ( -- x addr ) 8 bit TIM1_CCER ; \ TIM1_CCER.CC3E, Capture/Compare 3 output               enable
: TIM1_CCER.CC3P ( -- x addr ) 9 bit TIM1_CCER ; \ TIM1_CCER.CC3P, Capture/Compare 3 output               Polarity
: TIM1_CCER.CC3NE ( -- x addr ) 10 bit TIM1_CCER ; \ TIM1_CCER.CC3NE, Capture/Compare 3 complementary output               enable
: TIM1_CCER.CC3NP ( -- x addr ) 11 bit TIM1_CCER ; \ TIM1_CCER.CC3NP, Capture/Compare 3 output               Polarity
: TIM1_CCER.CC4E ( -- x addr ) 12 bit TIM1_CCER ; \ TIM1_CCER.CC4E, Capture/Compare 4 output               enable
: TIM1_CCER.CC4P ( -- x addr ) 13 bit TIM1_CCER ; \ TIM1_CCER.CC4P, Capture/Compare 3 output               Polarity
: TIM1_CCER.CC4NP ( -- x addr ) 15 bit TIM1_CCER ; \ TIM1_CCER.CC4NP, Capture/Compare 4 complementary output               polarity
: TIM1_CCER.CC5E ( -- x addr ) 16 bit TIM1_CCER ; \ TIM1_CCER.CC5E, Capture/Compare 5 output               enable
: TIM1_CCER.CC5P ( -- x addr ) 17 bit TIM1_CCER ; \ TIM1_CCER.CC5P, Capture/Compare 5 output               polarity
: TIM1_CCER.CC6E ( -- x addr ) 20 bit TIM1_CCER ; \ TIM1_CCER.CC6E, Capture/Compare 6 output               enable
: TIM1_CCER.CC6P ( -- x addr ) 21 bit TIM1_CCER ; \ TIM1_CCER.CC6P, Capture/Compare 6 output               polarity

\ TIM1_CNT (multiple-access)  Reset:$00000000
: TIM1_CNT.CNT ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1_CNT ; \ TIM1_CNT.CNT, counter value
: TIM1_CNT.UIFCPY ( -- x addr ) 31 bit TIM1_CNT ; \ TIM1_CNT.UIFCPY, UIF copy

\ TIM1_PSC (read-write) Reset:$0000
: TIM1_PSC.PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1_PSC ; \ TIM1_PSC.PSC, Prescaler value

\ TIM1_ARR (read-write) Reset:$00000000
: TIM1_ARR.ARR ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1_ARR ; \ TIM1_ARR.ARR, Auto-reload value

\ TIM1_RCR (read-write) Reset:$0000
: TIM1_RCR.REP ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1_RCR ; \ TIM1_RCR.REP, Repetition counter value

\ TIM1_CCR1 (read-write) Reset:$00000000
: TIM1_CCR1.CCR1 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1_CCR1 ; \ TIM1_CCR1.CCR1, Capture/Compare 1 value

\ TIM1_CCR2 (read-write) Reset:$00000000
: TIM1_CCR2.CCR2 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1_CCR2 ; \ TIM1_CCR2.CCR2, Capture/Compare 2 value

\ TIM1_CCR3 (read-write) Reset:$00000000
: TIM1_CCR3.CCR3 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1_CCR3 ; \ TIM1_CCR3.CCR3, Capture/Compare value

\ TIM1_CCR4 (read-write) Reset:$00000000
: TIM1_CCR4.CCR4 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1_CCR4 ; \ TIM1_CCR4.CCR4, Capture/Compare value

\ TIM1_BDTR (read-write) Reset:$0000
: TIM1_BDTR.DTG ( %bbbbbbbb -- x addr ) TIM1_BDTR ; \ TIM1_BDTR.DTG, Dead-time generator setup
: TIM1_BDTR.LOCK ( %bb -- x addr ) 8 lshift TIM1_BDTR ; \ TIM1_BDTR.LOCK, Lock configuration
: TIM1_BDTR.OSSI ( -- x addr ) 10 bit TIM1_BDTR ; \ TIM1_BDTR.OSSI, Off-state selection for Idle               mode
: TIM1_BDTR.OSSR ( -- x addr ) 11 bit TIM1_BDTR ; \ TIM1_BDTR.OSSR, Off-state selection for Run               mode
: TIM1_BDTR.BKE ( -- x addr ) 12 bit TIM1_BDTR ; \ TIM1_BDTR.BKE, Break enable
: TIM1_BDTR.BKP ( -- x addr ) 13 bit TIM1_BDTR ; \ TIM1_BDTR.BKP, Break polarity
: TIM1_BDTR.AOE ( -- x addr ) 14 bit TIM1_BDTR ; \ TIM1_BDTR.AOE, Automatic output enable
: TIM1_BDTR.MOE ( -- x addr ) 15 bit TIM1_BDTR ; \ TIM1_BDTR.MOE, Main output enable
: TIM1_BDTR.BKF ( %bbbb -- x addr ) 16 lshift TIM1_BDTR ; \ TIM1_BDTR.BKF, Break filter
: TIM1_BDTR.BK2F ( %bbbb -- x addr ) 20 lshift TIM1_BDTR ; \ TIM1_BDTR.BK2F, Break 2 filter
: TIM1_BDTR.BK2E ( -- x addr ) 24 bit TIM1_BDTR ; \ TIM1_BDTR.BK2E, Break 2 enable
: TIM1_BDTR.BK2P ( -- x addr ) 25 bit TIM1_BDTR ; \ TIM1_BDTR.BK2P, Break 2 polarity
: TIM1_BDTR.BKDSRM ( -- x addr ) 26 bit TIM1_BDTR ; \ TIM1_BDTR.BKDSRM, Break Disarm
: TIM1_BDTR.BK2DSRM ( -- x addr ) 27 bit TIM1_BDTR ; \ TIM1_BDTR.BK2DSRM, Break2 Disarm
: TIM1_BDTR.BKBID ( -- x addr ) 28 bit TIM1_BDTR ; \ TIM1_BDTR.BKBID, Break Bidirectional
: TIM1_BDTR.BK2ID ( -- x addr ) 29 bit TIM1_BDTR ; \ TIM1_BDTR.BK2ID, Break2 bidirectional

\ TIM1_DCR (read-write) Reset:$0000
: TIM1_DCR.DBL ( %bbbbb -- x addr ) 8 lshift TIM1_DCR ; \ TIM1_DCR.DBL, DMA burst length
: TIM1_DCR.DBA ( %bbbbb -- x addr ) TIM1_DCR ; \ TIM1_DCR.DBA, DMA base address

\ TIM1_DMAR (read-write) Reset:$0000
: TIM1_DMAR.DMAB ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1_DMAR ; \ TIM1_DMAR.DMAB, DMA register for burst               accesses

\ TIM1_OR1 (read-write) Reset:$0000
: TIM1_OR1.OCREF_CLR ( -- x addr ) 0 bit TIM1_OR1 ; \ TIM1_OR1.OCREF_CLR, Ocref_clr source selection

\ TIM1_CCMR3_Output (read-write) Reset:$00000000
: TIM1_CCMR3_Output.OC6M_bit3 ( -- x addr ) 24 bit TIM1_CCMR3_Output ; \ TIM1_CCMR3_Output.OC6M_bit3, Output Compare 6 mode bit               3
: TIM1_CCMR3_Output.OC5M_bit3 ( -- x addr ) 16 bit TIM1_CCMR3_Output ; \ TIM1_CCMR3_Output.OC5M_bit3, Output Compare 5 mode bit               3
: TIM1_CCMR3_Output.OC6CE ( -- x addr ) 15 bit TIM1_CCMR3_Output ; \ TIM1_CCMR3_Output.OC6CE, Output compare 6 clear               enable
: TIM1_CCMR3_Output.OC6M ( %bbb -- x addr ) 12 lshift TIM1_CCMR3_Output ; \ TIM1_CCMR3_Output.OC6M, Output compare 6 mode
: TIM1_CCMR3_Output.OC6PE ( -- x addr ) 11 bit TIM1_CCMR3_Output ; \ TIM1_CCMR3_Output.OC6PE, Output compare 6 preload               enable
: TIM1_CCMR3_Output.OC6FE ( -- x addr ) 10 bit TIM1_CCMR3_Output ; \ TIM1_CCMR3_Output.OC6FE, Output compare 6 fast               enable
: TIM1_CCMR3_Output.OC5CE ( -- x addr ) 7 bit TIM1_CCMR3_Output ; \ TIM1_CCMR3_Output.OC5CE, Output compare 5 clear               enable
: TIM1_CCMR3_Output.OC5M ( %bbb -- x addr ) 4 lshift TIM1_CCMR3_Output ; \ TIM1_CCMR3_Output.OC5M, Output compare 5 mode
: TIM1_CCMR3_Output.OC5PE ( -- x addr ) 3 bit TIM1_CCMR3_Output ; \ TIM1_CCMR3_Output.OC5PE, Output compare 5 preload               enable
: TIM1_CCMR3_Output.OC5FE ( -- x addr ) 2 bit TIM1_CCMR3_Output ; \ TIM1_CCMR3_Output.OC5FE, Output compare 5 fast               enable

\ TIM1_CCR5 (read-write) Reset:$00000000
: TIM1_CCR5.CCR5 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1_CCR5 ; \ TIM1_CCR5.CCR5, Capture/Compare value
: TIM1_CCR5.GC5C1 ( -- x addr ) 29 bit TIM1_CCR5 ; \ TIM1_CCR5.GC5C1, Group Channel 5 and Channel               1
: TIM1_CCR5.GC5C2 ( -- x addr ) 30 bit TIM1_CCR5 ; \ TIM1_CCR5.GC5C2, Group Channel 5 and Channel               2
: TIM1_CCR5.GC5C3 ( -- x addr ) 31 bit TIM1_CCR5 ; \ TIM1_CCR5.GC5C3, Group Channel 5 and Channel               3

\ TIM1_CCR6 (read-write) Reset:$00000000
: TIM1_CCR6.CCR6 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM1_CCR6 ; \ TIM1_CCR6.CCR6, Capture/Compare value

\ TIM1_AF1 (read-write) Reset:$00000001
: TIM1_AF1.BKINE ( -- x addr ) 0 bit TIM1_AF1 ; \ TIM1_AF1.BKINE, BRK BKIN input enable
: TIM1_AF1.BKCMP1E ( -- x addr ) 1 bit TIM1_AF1 ; \ TIM1_AF1.BKCMP1E, BRK COMP1 enable
: TIM1_AF1.BKCMP2E ( -- x addr ) 2 bit TIM1_AF1 ; \ TIM1_AF1.BKCMP2E, BRK COMP2 enable
: TIM1_AF1.BKINP ( -- x addr ) 9 bit TIM1_AF1 ; \ TIM1_AF1.BKINP, BRK BKIN input polarity
: TIM1_AF1.BKCMP1P ( -- x addr ) 10 bit TIM1_AF1 ; \ TIM1_AF1.BKCMP1P, BRK COMP1 input polarity
: TIM1_AF1.BKCMP2P ( -- x addr ) 11 bit TIM1_AF1 ; \ TIM1_AF1.BKCMP2P, BRK COMP2 input polarity
: TIM1_AF1.ETRSEL ( %bbb -- x addr ) 14 lshift TIM1_AF1 ; \ TIM1_AF1.ETRSEL, ETR source selection

\ TIM1_AF2 (read-write) Reset:$00000001
: TIM1_AF2.BK2INE ( -- x addr ) 0 bit TIM1_AF2 ; \ TIM1_AF2.BK2INE, BRK2 BKIN input enable
: TIM1_AF2.BK2CMP1E ( -- x addr ) 1 bit TIM1_AF2 ; \ TIM1_AF2.BK2CMP1E, BRK2 COMP1 enable
: TIM1_AF2.BK2CMP2E ( -- x addr ) 2 bit TIM1_AF2 ; \ TIM1_AF2.BK2CMP2E, BRK2 COMP2 enable
: TIM1_AF2.BK2DFBK0E ( -- x addr ) 8 bit TIM1_AF2 ; \ TIM1_AF2.BK2DFBK0E, BRK2 DFSDM_BREAK0 enable
: TIM1_AF2.BK2INP ( -- x addr ) 9 bit TIM1_AF2 ; \ TIM1_AF2.BK2INP, BRK2 BKIN input polarity
: TIM1_AF2.BK2CMP1P ( -- x addr ) 10 bit TIM1_AF2 ; \ TIM1_AF2.BK2CMP1P, BRK2 COMP1 input polarity
: TIM1_AF2.BK2CMP2P ( -- x addr ) 11 bit TIM1_AF2 ; \ TIM1_AF2.BK2CMP2P, BRK2 COMP2 input polarity

\ TIM1_TISEL (read-write) Reset:$00000000
: TIM1_TISEL.TI1SEL3_0 ( %bbbb -- x addr ) TIM1_TISEL ; \ TIM1_TISEL.TI1SEL3_0, selects TI1[0] to TI1[15]               input
: TIM1_TISEL.TI2SEL3_0 ( %bbbb -- x addr ) 8 lshift TIM1_TISEL ; \ TIM1_TISEL.TI2SEL3_0, selects TI2[0] to TI2[15]               input
: TIM1_TISEL.TI3SEL3_0 ( %bbbb -- x addr ) 16 lshift TIM1_TISEL ; \ TIM1_TISEL.TI3SEL3_0, selects TI3[0] to TI3[15]               input
: TIM1_TISEL.TI4SEL3_0 ( %bbbb -- x addr ) 24 lshift TIM1_TISEL ; \ TIM1_TISEL.TI4SEL3_0, selects TI4[0] to TI4[15]               input

\ ADC_ISR (read-write) Reset:$00000000
: ADC_ISR.CCRDY ( -- x addr ) 13 bit ADC_ISR ; \ ADC_ISR.CCRDY, Channel Configuration Ready               flag
: ADC_ISR.EOCAL ( -- x addr ) 11 bit ADC_ISR ; \ ADC_ISR.EOCAL, End Of Calibration flag
: ADC_ISR.AWD3 ( -- x addr ) 9 bit ADC_ISR ; \ ADC_ISR.AWD3, ADC analog watchdog 3 flag
: ADC_ISR.AWD2 ( -- x addr ) 8 bit ADC_ISR ; \ ADC_ISR.AWD2, ADC analog watchdog 2 flag
: ADC_ISR.AWD1 ( -- x addr ) 7 bit ADC_ISR ; \ ADC_ISR.AWD1, ADC analog watchdog 1 flag
: ADC_ISR.OVR ( -- x addr ) 4 bit ADC_ISR ; \ ADC_ISR.OVR, ADC group regular overrun               flag
: ADC_ISR.EOS ( -- x addr ) 3 bit ADC_ISR ; \ ADC_ISR.EOS, ADC group regular end of sequence               conversions flag
: ADC_ISR.EOC ( -- x addr ) 2 bit ADC_ISR ; \ ADC_ISR.EOC, ADC group regular end of unitary               conversion flag
: ADC_ISR.EOSMP ( -- x addr ) 1 bit ADC_ISR ; \ ADC_ISR.EOSMP, ADC group regular end of sampling               flag
: ADC_ISR.ADRDY ( -- x addr ) 0 bit ADC_ISR ; \ ADC_ISR.ADRDY, ADC ready flag

\ ADC_IER (read-write) Reset:$00000000
: ADC_IER.CCRDYIE ( -- x addr ) 13 bit ADC_IER ; \ ADC_IER.CCRDYIE, Channel Configuration Ready Interrupt               enable
: ADC_IER.EOCALIE ( -- x addr ) 11 bit ADC_IER ; \ ADC_IER.EOCALIE, End of calibration interrupt               enable
: ADC_IER.AWD3IE ( -- x addr ) 9 bit ADC_IER ; \ ADC_IER.AWD3IE, ADC analog watchdog 3               interrupt
: ADC_IER.AWD2IE ( -- x addr ) 8 bit ADC_IER ; \ ADC_IER.AWD2IE, ADC analog watchdog 2               interrupt
: ADC_IER.AWD1IE ( -- x addr ) 7 bit ADC_IER ; \ ADC_IER.AWD1IE, ADC analog watchdog 1               interrupt
: ADC_IER.OVRIE ( -- x addr ) 4 bit ADC_IER ; \ ADC_IER.OVRIE, ADC group regular overrun               interrupt
: ADC_IER.EOSIE ( -- x addr ) 3 bit ADC_IER ; \ ADC_IER.EOSIE, ADC group regular end of sequence               conversions interrupt
: ADC_IER.EOCIE ( -- x addr ) 2 bit ADC_IER ; \ ADC_IER.EOCIE, ADC group regular end of unitary               conversion interrupt
: ADC_IER.EOSMPIE ( -- x addr ) 1 bit ADC_IER ; \ ADC_IER.EOSMPIE, ADC group regular end of sampling               interrupt
: ADC_IER.ADRDYIE ( -- x addr ) 0 bit ADC_IER ; \ ADC_IER.ADRDYIE, ADC ready interrupt

\ ADC_CR (read-write) Reset:$00000000
: ADC_CR.ADCAL ( -- x addr ) 31 bit ADC_CR ; \ ADC_CR.ADCAL, ADC calibration
: ADC_CR.ADVREGEN ( -- x addr ) 28 bit ADC_CR ; \ ADC_CR.ADVREGEN, ADC voltage regulator               enable
: ADC_CR.ADSTP ( -- x addr ) 4 bit ADC_CR ; \ ADC_CR.ADSTP, ADC group regular conversion               stop
: ADC_CR.ADSTART ( -- x addr ) 2 bit ADC_CR ; \ ADC_CR.ADSTART, ADC group regular conversion               start
: ADC_CR.ADDIS ( -- x addr ) 1 bit ADC_CR ; \ ADC_CR.ADDIS, ADC disable
: ADC_CR.ADEN ( -- x addr ) 0 bit ADC_CR ; \ ADC_CR.ADEN, ADC enable

\ ADC_CFGR1 (read-write) Reset:$00000000
: ADC_CFGR1.AWDCH1CH ( %bbbbb -- x addr ) 26 lshift ADC_CFGR1 ; \ ADC_CFGR1.AWDCH1CH, ADC analog watchdog 1 monitored channel               selection
: ADC_CFGR1.AWD1EN ( -- x addr ) 23 bit ADC_CFGR1 ; \ ADC_CFGR1.AWD1EN, ADC analog watchdog 1 enable on scope               ADC group regular
: ADC_CFGR1.AWD1SGL ( -- x addr ) 22 bit ADC_CFGR1 ; \ ADC_CFGR1.AWD1SGL, ADC analog watchdog 1 monitoring a               single channel or all channels
: ADC_CFGR1.CHSELRMOD ( -- x addr ) 21 bit ADC_CFGR1 ; \ ADC_CFGR1.CHSELRMOD, Mode selection of the ADC_CHSELR               register
: ADC_CFGR1.DISCEN ( -- x addr ) 16 bit ADC_CFGR1 ; \ ADC_CFGR1.DISCEN, ADC group regular sequencer               discontinuous mode
: ADC_CFGR1.AUTOFF ( -- x addr ) 15 bit ADC_CFGR1 ; \ ADC_CFGR1.AUTOFF, Auto-off mode
: ADC_CFGR1.WAIT ( -- x addr ) 14 bit ADC_CFGR1 ; \ ADC_CFGR1.WAIT, Wait conversion mode
: ADC_CFGR1.CONT ( -- x addr ) 13 bit ADC_CFGR1 ; \ ADC_CFGR1.CONT, ADC group regular continuous conversion               mode
: ADC_CFGR1.OVRMOD ( -- x addr ) 12 bit ADC_CFGR1 ; \ ADC_CFGR1.OVRMOD, ADC group regular overrun               configuration
: ADC_CFGR1.EXTEN ( %bb -- x addr ) 10 lshift ADC_CFGR1 ; \ ADC_CFGR1.EXTEN, ADC group regular external trigger               polarity
: ADC_CFGR1.EXTSEL ( %bbb -- x addr ) 6 lshift ADC_CFGR1 ; \ ADC_CFGR1.EXTSEL, ADC group regular external trigger               source
: ADC_CFGR1.ALIGN ( -- x addr ) 5 bit ADC_CFGR1 ; \ ADC_CFGR1.ALIGN, ADC data alignement
: ADC_CFGR1.RES ( %bb -- x addr ) 3 lshift ADC_CFGR1 ; \ ADC_CFGR1.RES, ADC data resolution
: ADC_CFGR1.SCANDIR ( -- x addr ) 2 bit ADC_CFGR1 ; \ ADC_CFGR1.SCANDIR, Scan sequence direction
: ADC_CFGR1.DMACFG ( -- x addr ) 1 bit ADC_CFGR1 ; \ ADC_CFGR1.DMACFG, ADC DMA transfer               configuration
: ADC_CFGR1.DMAEN ( -- x addr ) 0 bit ADC_CFGR1 ; \ ADC_CFGR1.DMAEN, ADC DMA transfer enable

\ ADC_CFGR2 (read-write) Reset:$00000000
: ADC_CFGR2.CKMODE ( %bb -- x addr ) 30 lshift ADC_CFGR2 ; \ ADC_CFGR2.CKMODE, ADC clock mode
: ADC_CFGR2.LFTRIG ( -- x addr ) 29 bit ADC_CFGR2 ; \ ADC_CFGR2.LFTRIG, Low frequency trigger mode               enable
: ADC_CFGR2.TOVS ( -- x addr ) 9 bit ADC_CFGR2 ; \ ADC_CFGR2.TOVS, ADC oversampling discontinuous mode               (triggered mode) for ADC group regular
: ADC_CFGR2.OVSS ( %bbbb -- x addr ) 5 lshift ADC_CFGR2 ; \ ADC_CFGR2.OVSS, ADC oversampling shift
: ADC_CFGR2.OVSR ( %bbb -- x addr ) 2 lshift ADC_CFGR2 ; \ ADC_CFGR2.OVSR, ADC oversampling ratio
: ADC_CFGR2.OVSE ( -- x addr ) 0 bit ADC_CFGR2 ; \ ADC_CFGR2.OVSE, ADC oversampler enable on scope ADC               group regular

\ ADC_SMPR (read-write) Reset:$00000000
: ADC_SMPR.SMP1 ( %bbb -- x addr ) ADC_SMPR ; \ ADC_SMPR.SMP1, Sampling time selection
: ADC_SMPR.SMP2 ( %bbb -- x addr ) 4 lshift ADC_SMPR ; \ ADC_SMPR.SMP2, Sampling time selection
: ADC_SMPR.SMPSEL x addr ) 8 lshift ADC_SMPR ; \ ADC_SMPR.SMPSEL, Channel sampling time               selection

\ ADC_AWD1TR (read-write) Reset:$0FFF0000
: ADC_AWD1TR.HT1 ( %bbbbbbbbbbb -- x addr ) 16 lshift ADC_AWD1TR ; \ ADC_AWD1TR.HT1, ADC analog watchdog 1 threshold               high
: ADC_AWD1TR.LT1 ( %bbbbbbbbbbb -- x addr ) ADC_AWD1TR ; \ ADC_AWD1TR.LT1, ADC analog watchdog 1 threshold               low

\ ADC_AWD2TR (read-write) Reset:$0FFF0000
: ADC_AWD2TR.HT2 ( %bbbbbbbbbbb -- x addr ) 16 lshift ADC_AWD2TR ; \ ADC_AWD2TR.HT2, ADC analog watchdog 2 threshold               high
: ADC_AWD2TR.LT2 ( %bbbbbbbbbbb -- x addr ) ADC_AWD2TR ; \ ADC_AWD2TR.LT2, ADC analog watchdog 2 threshold               low

\ ADC_CHSELR (read-write) Reset:$0FFF0000
: ADC_CHSELR.CHSEL x addr ) ADC_CHSELR ; \ ADC_CHSELR.CHSEL, Channel-x selection

\ ADC_CHSELR_1 (read-write) Reset:$00000000
: ADC_CHSELR_1.SQ1 ( %bbbb -- x addr ) ADC_CHSELR_1 ; \ ADC_CHSELR_1.SQ1, conversion of the sequence
: ADC_CHSELR_1.SQ2 ( %bbbb -- x addr ) 4 lshift ADC_CHSELR_1 ; \ ADC_CHSELR_1.SQ2, conversion of the sequence
: ADC_CHSELR_1.SQ3 ( %bbbb -- x addr ) 8 lshift ADC_CHSELR_1 ; \ ADC_CHSELR_1.SQ3, conversion of the sequence
: ADC_CHSELR_1.SQ4 ( %bbbb -- x addr ) 12 lshift ADC_CHSELR_1 ; \ ADC_CHSELR_1.SQ4, conversion of the sequence
: ADC_CHSELR_1.SQ5 ( %bbbb -- x addr ) 16 lshift ADC_CHSELR_1 ; \ ADC_CHSELR_1.SQ5, conversion of the sequence
: ADC_CHSELR_1.SQ6 ( %bbbb -- x addr ) 20 lshift ADC_CHSELR_1 ; \ ADC_CHSELR_1.SQ6, conversion of the sequence
: ADC_CHSELR_1.SQ7 ( %bbbb -- x addr ) 24 lshift ADC_CHSELR_1 ; \ ADC_CHSELR_1.SQ7, conversion of the sequence
: ADC_CHSELR_1.SQ8 ( %bbbb -- x addr ) 28 lshift ADC_CHSELR_1 ; \ ADC_CHSELR_1.SQ8, conversion of the sequence

\ ADC_AWD3TR (read-write) Reset:$0FFF0000
: ADC_AWD3TR.HT3 ( %bbbbbbbbbbb -- x addr ) 16 lshift ADC_AWD3TR ; \ ADC_AWD3TR.HT3, ADC analog watchdog 3 threshold               high
: ADC_AWD3TR.LT3 ( %bbbbbbbbbbb -- x addr ) ADC_AWD3TR ; \ ADC_AWD3TR.LT3, ADC analog watchdog 3 threshold               high

\ ADC_DR (read-only) Reset:$00000000
: ADC_DR.regularDATA? ( --  x ) ADC_DR @ ; \ ADC_DR.regularDATA, ADC group regular conversion               data

\ ADC_AWD2CR (read-write) Reset:$00000000
: ADC_AWD2CR.AWD2CH x addr ) ADC_AWD2CR ; \ ADC_AWD2CR.AWD2CH, ADC analog watchdog 2 monitored channel               selection

\ ADC_AWD3CR (read-write) Reset:$00000000
: ADC_AWD3CR.AWD3CH x addr ) ADC_AWD3CR ; \ ADC_AWD3CR.AWD3CH, ADC analog watchdog 3 monitored channel               selection

\ ADC_CALFACT (read-write) Reset:$00000000
: ADC_CALFACT.CALFACT ( %bbbbbbb -- x addr ) ADC_CALFACT ; \ ADC_CALFACT.CALFACT, ADC calibration factor in single-ended               mode

\ ADC_CCR (read-write) Reset:$00000000
: ADC_CCR.PRESC ( %bbbb -- x addr ) 18 lshift ADC_CCR ; \ ADC_CCR.PRESC, ADC prescaler
: ADC_CCR.VREFEN ( -- x addr ) 22 bit ADC_CCR ; \ ADC_CCR.VREFEN, VREFINT enable
: ADC_CCR.TSEN ( -- x addr ) 23 bit ADC_CCR ; \ ADC_CCR.TSEN, Temperature sensor enable
: ADC_CCR.VBATEN ( -- x addr ) 24 bit ADC_CCR ; \ ADC_CCR.VBATEN, VBAT enable

\ SYSCFG_CFGR1 (read-write) Reset:$00000000
: SYSCFG_CFGR1.I2C_PAx_FMP ( %bb -- x addr ) 22 lshift SYSCFG_CFGR1 ; \ SYSCFG_CFGR1.I2C_PAx_FMP, Fast Mode Plus (FM+) driving capability               activation bits
: SYSCFG_CFGR1.I2C2_FMP ( -- x addr ) 21 bit SYSCFG_CFGR1 ; \ SYSCFG_CFGR1.I2C2_FMP, FM+ driving capability activation for               I2C2
: SYSCFG_CFGR1.I2C1_FMP ( -- x addr ) 20 bit SYSCFG_CFGR1 ; \ SYSCFG_CFGR1.I2C1_FMP, FM+ driving capability activation for               I2C1
: SYSCFG_CFGR1.I2C_PBx_FMP ( %bbbb -- x addr ) 16 lshift SYSCFG_CFGR1 ; \ SYSCFG_CFGR1.I2C_PBx_FMP, Fast Mode Plus (FM+) driving capability               activation bits
: SYSCFG_CFGR1.BOOSTEN ( -- x addr ) 8 bit SYSCFG_CFGR1 ; \ SYSCFG_CFGR1.BOOSTEN, I/O analog switch voltage booster               enable
: SYSCFG_CFGR1.IR_MOD ( %bb -- x addr ) 6 lshift SYSCFG_CFGR1 ; \ SYSCFG_CFGR1.IR_MOD, IR Modulation Envelope signal               selection.
: SYSCFG_CFGR1.IR_POL ( -- x addr ) 5 bit SYSCFG_CFGR1 ; \ SYSCFG_CFGR1.IR_POL, IR output polarity               selection
: SYSCFG_CFGR1.PA11_PA12_RMP ( -- x addr ) 4 bit SYSCFG_CFGR1 ; \ SYSCFG_CFGR1.PA11_PA12_RMP, PA11 and PA12 remapping               bit.
: SYSCFG_CFGR1.MEM_MODE ( %bb -- x addr ) SYSCFG_CFGR1 ; \ SYSCFG_CFGR1.MEM_MODE, Memory mapping selection               bits

\ SYSCFG_CFGR2 (read-write) Reset:$00000000
: SYSCFG_CFGR2.LOCKUP_LOCK ( -- x addr ) 0 bit SYSCFG_CFGR2 ; \ SYSCFG_CFGR2.LOCKUP_LOCK, Cortex-M0+ LOCKUP bit enable               bit
: SYSCFG_CFGR2.SRAM_PARITY_LOCK ( -- x addr ) 1 bit SYSCFG_CFGR2 ; \ SYSCFG_CFGR2.SRAM_PARITY_LOCK, SRAM parity lock bit
: SYSCFG_CFGR2.PVD_LOCK ( -- x addr ) 2 bit SYSCFG_CFGR2 ; \ SYSCFG_CFGR2.PVD_LOCK, PVD lock enable bit
: SYSCFG_CFGR2.ECC_LOCK ( -- x addr ) 3 bit SYSCFG_CFGR2 ; \ SYSCFG_CFGR2.ECC_LOCK, ECC error lock bit
: SYSCFG_CFGR2.SRAM_PEF ( -- x addr ) 8 bit SYSCFG_CFGR2 ; \ SYSCFG_CFGR2.SRAM_PEF, SRAM parity error flag
: SYSCFG_CFGR2.PA1_CDEN ( -- x addr ) 16 bit SYSCFG_CFGR2 ; \ SYSCFG_CFGR2.PA1_CDEN, PA1_CDEN
: SYSCFG_CFGR2.PA3_CDEN ( -- x addr ) 17 bit SYSCFG_CFGR2 ; \ SYSCFG_CFGR2.PA3_CDEN, PA3_CDEN
: SYSCFG_CFGR2.PA5_CDEN ( -- x addr ) 18 bit SYSCFG_CFGR2 ; \ SYSCFG_CFGR2.PA5_CDEN, PA5_CDEN
: SYSCFG_CFGR2.PA6_CDEN ( -- x addr ) 19 bit SYSCFG_CFGR2 ; \ SYSCFG_CFGR2.PA6_CDEN, PA6_CDEN
: SYSCFG_CFGR2.PA13_CDEN ( -- x addr ) 20 bit SYSCFG_CFGR2 ; \ SYSCFG_CFGR2.PA13_CDEN, PA13_CDEN
: SYSCFG_CFGR2.PB0_CDEN ( -- x addr ) 21 bit SYSCFG_CFGR2 ; \ SYSCFG_CFGR2.PB0_CDEN, PB0_CDEN
: SYSCFG_CFGR2.PB1_CDEN ( -- x addr ) 22 bit SYSCFG_CFGR2 ; \ SYSCFG_CFGR2.PB1_CDEN, PB1_CDEN
: SYSCFG_CFGR2.PB2_CDEN ( -- x addr ) 23 bit SYSCFG_CFGR2 ; \ SYSCFG_CFGR2.PB2_CDEN, PB2_CDEN

\ TAMP_CR1 (read-write) Reset:$FFFF0000
: TAMP_CR1.TAMP1E ( -- x addr ) 0 bit TAMP_CR1 ; \ TAMP_CR1.TAMP1E, TAMP1E
: TAMP_CR1.TAMP2E ( -- x addr ) 1 bit TAMP_CR1 ; \ TAMP_CR1.TAMP2E, TAMP2E
: TAMP_CR1.ITAMP1E ( -- x addr ) 16 bit TAMP_CR1 ; \ TAMP_CR1.ITAMP1E, ITAMP1E
: TAMP_CR1.ITAMP3E ( -- x addr ) 18 bit TAMP_CR1 ; \ TAMP_CR1.ITAMP3E, ITAMP3E
: TAMP_CR1.ITAMP4E ( -- x addr ) 19 bit TAMP_CR1 ; \ TAMP_CR1.ITAMP4E, ITAMP4E
: TAMP_CR1.ITAMP5E ( -- x addr ) 20 bit TAMP_CR1 ; \ TAMP_CR1.ITAMP5E, ITAMP5E
: TAMP_CR1.ITAMP6E ( -- x addr ) 21 bit TAMP_CR1 ; \ TAMP_CR1.ITAMP6E, ITAMP6E

\ TAMP_CR2 (read-write) Reset:$00000000
: TAMP_CR2.TAMP1NOER ( -- x addr ) 0 bit TAMP_CR2 ; \ TAMP_CR2.TAMP1NOER, TAMP1NOER
: TAMP_CR2.TAMP2NOER ( -- x addr ) 1 bit TAMP_CR2 ; \ TAMP_CR2.TAMP2NOER, TAMP2NOER
: TAMP_CR2.TAMP1MSK ( -- x addr ) 16 bit TAMP_CR2 ; \ TAMP_CR2.TAMP1MSK, TAMP1MSK
: TAMP_CR2.TAMP2MSK ( -- x addr ) 17 bit TAMP_CR2 ; \ TAMP_CR2.TAMP2MSK, TAMP2MSK
: TAMP_CR2.TAMP1TRG ( -- x addr ) 24 bit TAMP_CR2 ; \ TAMP_CR2.TAMP1TRG, TAMP1TRG
: TAMP_CR2.TAMP2TRG ( -- x addr ) 25 bit TAMP_CR2 ; \ TAMP_CR2.TAMP2TRG, TAMP2TRG

\ TAMP_FLTCR (read-write) Reset:$00000000
: TAMP_FLTCR.TAMPFREQ ( %bbb -- x addr ) TAMP_FLTCR ; \ TAMP_FLTCR.TAMPFREQ, TAMPFREQ
: TAMP_FLTCR.TAMPFLT ( %bb -- x addr ) 3 lshift TAMP_FLTCR ; \ TAMP_FLTCR.TAMPFLT, TAMPFLT
: TAMP_FLTCR.TAMPPRCH ( %bb -- x addr ) 5 lshift TAMP_FLTCR ; \ TAMP_FLTCR.TAMPPRCH, TAMPPRCH
: TAMP_FLTCR.TAMPPUDIS ( -- x addr ) 7 bit TAMP_FLTCR ; \ TAMP_FLTCR.TAMPPUDIS, TAMPPUDIS

\ TAMP_IER (read-write) Reset:$00000000
: TAMP_IER.TAMP1IE ( -- x addr ) 0 bit TAMP_IER ; \ TAMP_IER.TAMP1IE, TAMP1IE
: TAMP_IER.TAMP2IE ( -- x addr ) 1 bit TAMP_IER ; \ TAMP_IER.TAMP2IE, TAMP2IE
: TAMP_IER.ITAMP1IE ( -- x addr ) 16 bit TAMP_IER ; \ TAMP_IER.ITAMP1IE, ITAMP1IE
: TAMP_IER.ITAMP3IE ( -- x addr ) 18 bit TAMP_IER ; \ TAMP_IER.ITAMP3IE, ITAMP3IE
: TAMP_IER.ITAMP4IE ( -- x addr ) 19 bit TAMP_IER ; \ TAMP_IER.ITAMP4IE, ITAMP4IE
: TAMP_IER.ITAMP5IE ( -- x addr ) 20 bit TAMP_IER ; \ TAMP_IER.ITAMP5IE, ITAMP5IE
: TAMP_IER.ITAMP6IE ( -- x addr ) 21 bit TAMP_IER ; \ TAMP_IER.ITAMP6IE, ITAMP6IE

\ TAMP_SR (read-only) Reset:$00000000
: TAMP_SR.TAMP1F? ( --  1|0 ) 0 bit TAMP_SR bit@ ; \ TAMP_SR.TAMP1F, TAMP1F
: TAMP_SR.TAMP2F? ( --  1|0 ) 1 bit TAMP_SR bit@ ; \ TAMP_SR.TAMP2F, TAMP2F
: TAMP_SR.ITAMP1F? ( --  1|0 ) 16 bit TAMP_SR bit@ ; \ TAMP_SR.ITAMP1F, ITAMP1F
: TAMP_SR.ITAMP3F? ( --  1|0 ) 18 bit TAMP_SR bit@ ; \ TAMP_SR.ITAMP3F, ITAMP3F
: TAMP_SR.ITAMP4F? ( --  1|0 ) 19 bit TAMP_SR bit@ ; \ TAMP_SR.ITAMP4F, ITAMP4F
: TAMP_SR.ITAMP5F? ( --  1|0 ) 20 bit TAMP_SR bit@ ; \ TAMP_SR.ITAMP5F, ITAMP5F
: TAMP_SR.ITAMP6F? ( --  1|0 ) 21 bit TAMP_SR bit@ ; \ TAMP_SR.ITAMP6F, ITAMP6F
: TAMP_SR.ITAMP7F? ( --  1|0 ) 22 bit TAMP_SR bit@ ; \ TAMP_SR.ITAMP7F, ITAMP7F

\ TAMP_MISR (read-only) Reset:$00000000
: TAMP_MISR.TAMP1MF? ( --  1|0 ) 0 bit TAMP_MISR bit@ ; \ TAMP_MISR.TAMP1MF, TAMP1MF:
: TAMP_MISR.TAMP2MF? ( --  1|0 ) 1 bit TAMP_MISR bit@ ; \ TAMP_MISR.TAMP2MF, TAMP2MF
: TAMP_MISR.ITAMP1MF? ( --  1|0 ) 16 bit TAMP_MISR bit@ ; \ TAMP_MISR.ITAMP1MF, ITAMP1MF
: TAMP_MISR.ITAMP3MF? ( --  1|0 ) 18 bit TAMP_MISR bit@ ; \ TAMP_MISR.ITAMP3MF, ITAMP3MF
: TAMP_MISR.ITAMP4MF? ( --  1|0 ) 19 bit TAMP_MISR bit@ ; \ TAMP_MISR.ITAMP4MF, ITAMP4MF
: TAMP_MISR.ITAMP5MF? ( --  1|0 ) 20 bit TAMP_MISR bit@ ; \ TAMP_MISR.ITAMP5MF, ITAMP5MF
: TAMP_MISR.ITAMP6MF? ( --  1|0 ) 21 bit TAMP_MISR bit@ ; \ TAMP_MISR.ITAMP6MF, ITAMP6MF

\ TAMP_SCR (write-only) Reset:$00000000
: TAMP_SCR.CTAMP1F ( -- x addr ) 0 bit TAMP_SCR ; \ TAMP_SCR.CTAMP1F, CTAMP1F
: TAMP_SCR.CTAMP2F ( -- x addr ) 1 bit TAMP_SCR ; \ TAMP_SCR.CTAMP2F, CTAMP2F
: TAMP_SCR.CITAMP1F ( -- x addr ) 16 bit TAMP_SCR ; \ TAMP_SCR.CITAMP1F, CITAMP1F
: TAMP_SCR.CITAMP3F ( -- x addr ) 18 bit TAMP_SCR ; \ TAMP_SCR.CITAMP3F, CITAMP3F
: TAMP_SCR.CITAMP4F ( -- x addr ) 19 bit TAMP_SCR ; \ TAMP_SCR.CITAMP4F, CITAMP4F
: TAMP_SCR.CITAMP5F ( -- x addr ) 20 bit TAMP_SCR ; \ TAMP_SCR.CITAMP5F, CITAMP5F
: TAMP_SCR.CITAMP6F ( -- x addr ) 21 bit TAMP_SCR ; \ TAMP_SCR.CITAMP6F, CITAMP6F
: TAMP_SCR.CITAMP7F ( -- x addr ) 22 bit TAMP_SCR ; \ TAMP_SCR.CITAMP7F, CITAMP7F

\ TAMP_BKP0R (read-write) Reset:$00000000
: TAMP_BKP0R.BKP ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) TAMP_BKP0R ; \ TAMP_BKP0R.BKP, BKP

\ TAMP_BKP1R (read-write) Reset:$00000000
: TAMP_BKP1R.BKP ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) TAMP_BKP1R ; \ TAMP_BKP1R.BKP, BKP

\ TAMP_BKP2R (read-write) Reset:$00000000
: TAMP_BKP2R.BKP ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) TAMP_BKP2R ; \ TAMP_BKP2R.BKP, BKP

\ TAMP_BKP3R (read-write) Reset:$00000000
: TAMP_BKP3R.BKP ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) TAMP_BKP3R ; \ TAMP_BKP3R.BKP, BKP

\ TAMP_BKP4R (read-write) Reset:$00000000
: TAMP_BKP4R.BKP ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) TAMP_BKP4R ; \ TAMP_BKP4R.BKP, BKP

\ I2C1_CR1 (read-write) Reset:$00000000
: I2C1_CR1.PE ( -- x addr ) 0 bit I2C1_CR1 ; \ I2C1_CR1.PE, Peripheral enable
: I2C1_CR1.TXIE ( -- x addr ) 1 bit I2C1_CR1 ; \ I2C1_CR1.TXIE, TX Interrupt enable
: I2C1_CR1.RXIE ( -- x addr ) 2 bit I2C1_CR1 ; \ I2C1_CR1.RXIE, RX Interrupt enable
: I2C1_CR1.ADDRIE ( -- x addr ) 3 bit I2C1_CR1 ; \ I2C1_CR1.ADDRIE, Address match interrupt enable (slave               only)
: I2C1_CR1.NACKIE ( -- x addr ) 4 bit I2C1_CR1 ; \ I2C1_CR1.NACKIE, Not acknowledge received interrupt               enable
: I2C1_CR1.STOPIE ( -- x addr ) 5 bit I2C1_CR1 ; \ I2C1_CR1.STOPIE, STOP detection Interrupt               enable
: I2C1_CR1.TCIE ( -- x addr ) 6 bit I2C1_CR1 ; \ I2C1_CR1.TCIE, Transfer Complete interrupt               enable
: I2C1_CR1.ERRIE ( -- x addr ) 7 bit I2C1_CR1 ; \ I2C1_CR1.ERRIE, Error interrupts enable
: I2C1_CR1.DNF ( %bbbb -- x addr ) 8 lshift I2C1_CR1 ; \ I2C1_CR1.DNF, Digital noise filter
: I2C1_CR1.ANFOFF ( -- x addr ) 12 bit I2C1_CR1 ; \ I2C1_CR1.ANFOFF, Analog noise filter OFF
: I2C1_CR1.TXDMAEN ( -- x addr ) 14 bit I2C1_CR1 ; \ I2C1_CR1.TXDMAEN, DMA transmission requests               enable
: I2C1_CR1.RXDMAEN ( -- x addr ) 15 bit I2C1_CR1 ; \ I2C1_CR1.RXDMAEN, DMA reception requests               enable
: I2C1_CR1.SBC ( -- x addr ) 16 bit I2C1_CR1 ; \ I2C1_CR1.SBC, Slave byte control
: I2C1_CR1.NOSTRETCH ( -- x addr ) 17 bit I2C1_CR1 ; \ I2C1_CR1.NOSTRETCH, Clock stretching disable
: I2C1_CR1.WUPEN ( -- x addr ) 18 bit I2C1_CR1 ; \ I2C1_CR1.WUPEN, Wakeup from STOP enable
: I2C1_CR1.GCEN ( -- x addr ) 19 bit I2C1_CR1 ; \ I2C1_CR1.GCEN, General call enable
: I2C1_CR1.SMBHEN ( -- x addr ) 20 bit I2C1_CR1 ; \ I2C1_CR1.SMBHEN, SMBus Host address enable
: I2C1_CR1.SMBDEN ( -- x addr ) 21 bit I2C1_CR1 ; \ I2C1_CR1.SMBDEN, SMBus Device Default address               enable
: I2C1_CR1.ALERTEN ( -- x addr ) 22 bit I2C1_CR1 ; \ I2C1_CR1.ALERTEN, SMBUS alert enable
: I2C1_CR1.PECEN ( -- x addr ) 23 bit I2C1_CR1 ; \ I2C1_CR1.PECEN, PEC enable

\ I2C1_CR2 (read-write) Reset:$00000000
: I2C1_CR2.PECBYTE ( -- x addr ) 26 bit I2C1_CR2 ; \ I2C1_CR2.PECBYTE, Packet error checking byte
: I2C1_CR2.AUTOEND ( -- x addr ) 25 bit I2C1_CR2 ; \ I2C1_CR2.AUTOEND, Automatic end mode (master               mode)
: I2C1_CR2.RELOAD ( -- x addr ) 24 bit I2C1_CR2 ; \ I2C1_CR2.RELOAD, NBYTES reload mode
: I2C1_CR2.NBYTES ( %bbbbbbbb -- x addr ) 16 lshift I2C1_CR2 ; \ I2C1_CR2.NBYTES, Number of bytes
: I2C1_CR2.NACK ( -- x addr ) 15 bit I2C1_CR2 ; \ I2C1_CR2.NACK, NACK generation (slave               mode)
: I2C1_CR2.STOP ( -- x addr ) 14 bit I2C1_CR2 ; \ I2C1_CR2.STOP, Stop generation (master               mode)
: I2C1_CR2.START ( -- x addr ) 13 bit I2C1_CR2 ; \ I2C1_CR2.START, Start generation
: I2C1_CR2.HEAD10R ( -- x addr ) 12 bit I2C1_CR2 ; \ I2C1_CR2.HEAD10R, 10-bit address header only read               direction (master receiver mode)
: I2C1_CR2.ADD10 ( -- x addr ) 11 bit I2C1_CR2 ; \ I2C1_CR2.ADD10, 10-bit addressing mode (master               mode)
: I2C1_CR2.RD_WRN ( -- x addr ) 10 bit I2C1_CR2 ; \ I2C1_CR2.RD_WRN, Transfer direction (master               mode)
: I2C1_CR2.SADD ( %bbbbbbbbbb -- x addr ) I2C1_CR2 ; \ I2C1_CR2.SADD, Slave address bit (master               mode)

\ I2C1_OAR1 (read-write) Reset:$00000000
: I2C1_OAR1.OA1_0 ( -- x addr ) 0 bit I2C1_OAR1 ; \ I2C1_OAR1.OA1_0, Interface address
: I2C1_OAR1.OA1_7_1 ( %bbbbbbb -- x addr ) 1 lshift I2C1_OAR1 ; \ I2C1_OAR1.OA1_7_1, Interface address
: I2C1_OAR1.OA1_8_9 ( %bb -- x addr ) 8 lshift I2C1_OAR1 ; \ I2C1_OAR1.OA1_8_9, Interface address
: I2C1_OAR1.OA1MODE ( -- x addr ) 10 bit I2C1_OAR1 ; \ I2C1_OAR1.OA1MODE, Own Address 1 10-bit mode
: I2C1_OAR1.OA1EN ( -- x addr ) 15 bit I2C1_OAR1 ; \ I2C1_OAR1.OA1EN, Own Address 1 enable

\ I2C1_OAR2 (read-write) Reset:$00000000
: I2C1_OAR2.OA2 ( %bbbbbbb -- x addr ) 1 lshift I2C1_OAR2 ; \ I2C1_OAR2.OA2, Interface address
: I2C1_OAR2.OA2MSK ( %bbb -- x addr ) 8 lshift I2C1_OAR2 ; \ I2C1_OAR2.OA2MSK, Own Address 2 masks
: I2C1_OAR2.OA2EN ( -- x addr ) 15 bit I2C1_OAR2 ; \ I2C1_OAR2.OA2EN, Own Address 2 enable

\ I2C1_TIMINGR (read-write) Reset:$00000000
: I2C1_TIMINGR.SCLL ( %bbbbbbbb -- x addr ) I2C1_TIMINGR ; \ I2C1_TIMINGR.SCLL, SCL low period (master               mode)
: I2C1_TIMINGR.SCLH ( %bbbbbbbb -- x addr ) 8 lshift I2C1_TIMINGR ; \ I2C1_TIMINGR.SCLH, SCL high period (master               mode)
: I2C1_TIMINGR.SDADEL ( %bbbb -- x addr ) 16 lshift I2C1_TIMINGR ; \ I2C1_TIMINGR.SDADEL, Data hold time
: I2C1_TIMINGR.SCLDEL ( %bbbb -- x addr ) 20 lshift I2C1_TIMINGR ; \ I2C1_TIMINGR.SCLDEL, Data setup time
: I2C1_TIMINGR.PRESC ( %bbbb -- x addr ) 28 lshift I2C1_TIMINGR ; \ I2C1_TIMINGR.PRESC, Timing prescaler

\ I2C1_TIMEOUTR (read-write) Reset:$00000000
: I2C1_TIMEOUTR.TIMEOUTA ( %bbbbbbbbbbb -- x addr ) I2C1_TIMEOUTR ; \ I2C1_TIMEOUTR.TIMEOUTA, Bus timeout A
: I2C1_TIMEOUTR.TIDLE ( -- x addr ) 12 bit I2C1_TIMEOUTR ; \ I2C1_TIMEOUTR.TIDLE, Idle clock timeout               detection
: I2C1_TIMEOUTR.TIMOUTEN ( -- x addr ) 15 bit I2C1_TIMEOUTR ; \ I2C1_TIMEOUTR.TIMOUTEN, Clock timeout enable
: I2C1_TIMEOUTR.TIMEOUTB ( %bbbbbbbbbbb -- x addr ) 16 lshift I2C1_TIMEOUTR ; \ I2C1_TIMEOUTR.TIMEOUTB, Bus timeout B
: I2C1_TIMEOUTR.TEXTEN ( -- x addr ) 31 bit I2C1_TIMEOUTR ; \ I2C1_TIMEOUTR.TEXTEN, Extended clock timeout               enable

\ I2C1_ISR (multiple-access)  Reset:$00000001
: I2C1_ISR.ADDCODE ( %bbbbbbb -- x addr ) 17 lshift I2C1_ISR ; \ I2C1_ISR.ADDCODE, Address match code (Slave               mode)
: I2C1_ISR.DIR ( -- x addr ) 16 bit I2C1_ISR ; \ I2C1_ISR.DIR, Transfer direction (Slave               mode)
: I2C1_ISR.BUSY ( -- x addr ) 15 bit I2C1_ISR ; \ I2C1_ISR.BUSY, Bus busy
: I2C1_ISR.ALERT ( -- x addr ) 13 bit I2C1_ISR ; \ I2C1_ISR.ALERT, SMBus alert
: I2C1_ISR.TIMEOUT? ( -- 1|0 ) 12 bit I2C1_ISR bit@ ; \ I2C1_ISR.TIMEOUT, Timeout or t_low detection               flag
: I2C1_ISR.PECERR ( -- x addr ) 11 bit I2C1_ISR ; \ I2C1_ISR.PECERR, PEC Error in reception
: I2C1_ISR.OVR ( -- x addr ) 10 bit I2C1_ISR ; \ I2C1_ISR.OVR, Overrun/Underrun (slave               mode)
: I2C1_ISR.ARLO ( -- x addr ) 9 bit I2C1_ISR ; \ I2C1_ISR.ARLO, Arbitration lost
: I2C1_ISR.BERR ( -- x addr ) 8 bit I2C1_ISR ; \ I2C1_ISR.BERR, Bus error
: I2C1_ISR.TCR ( -- x addr ) 7 bit I2C1_ISR ; \ I2C1_ISR.TCR, Transfer Complete Reload
: I2C1_ISR.TC ( -- x addr ) 6 bit I2C1_ISR ; \ I2C1_ISR.TC, Transfer Complete (master               mode)
: I2C1_ISR.STOPF? ( -- 1|0 ) 5 bit I2C1_ISR bit@ ; \ I2C1_ISR.STOPF, Stop detection flag
: I2C1_ISR.NACKF? ( -- 1|0 ) 4 bit I2C1_ISR bit@ ; \ I2C1_ISR.NACKF, Not acknowledge received               flag
: I2C1_ISR.ADDR ( -- x addr ) 3 bit I2C1_ISR ; \ I2C1_ISR.ADDR, Address matched (slave               mode)
: I2C1_ISR.RXNE ( -- x addr ) 2 bit I2C1_ISR ; \ I2C1_ISR.RXNE, Receive data register not empty               (receivers)
: I2C1_ISR.TXIS? ( -- 1|0 ) 1 bit I2C1_ISR bit@ ; \ I2C1_ISR.TXIS, Transmit interrupt status               (transmitters)
: I2C1_ISR.TXE ( -- x addr ) 0 bit I2C1_ISR ; \ I2C1_ISR.TXE, Transmit data register empty               (transmitters)

\ I2C1_ICR (write-only) Reset:$00000000
: I2C1_ICR.ALERTCF ( -- x addr ) 13 bit I2C1_ICR ; \ I2C1_ICR.ALERTCF, Alert flag clear
: I2C1_ICR.TIMOUTCF ( -- x addr ) 12 bit I2C1_ICR ; \ I2C1_ICR.TIMOUTCF, Timeout detection flag               clear
: I2C1_ICR.PECCF ( -- x addr ) 11 bit I2C1_ICR ; \ I2C1_ICR.PECCF, PEC Error flag clear
: I2C1_ICR.OVRCF ( -- x addr ) 10 bit I2C1_ICR ; \ I2C1_ICR.OVRCF, Overrun/Underrun flag               clear
: I2C1_ICR.ARLOCF ( -- x addr ) 9 bit I2C1_ICR ; \ I2C1_ICR.ARLOCF, Arbitration lost flag               clear
: I2C1_ICR.BERRCF ( -- x addr ) 8 bit I2C1_ICR ; \ I2C1_ICR.BERRCF, Bus error flag clear
: I2C1_ICR.STOPCF ( -- x addr ) 5 bit I2C1_ICR ; \ I2C1_ICR.STOPCF, Stop detection flag clear
: I2C1_ICR.NACKCF ( -- x addr ) 4 bit I2C1_ICR ; \ I2C1_ICR.NACKCF, Not Acknowledge flag clear
: I2C1_ICR.ADDRCF ( -- x addr ) 3 bit I2C1_ICR ; \ I2C1_ICR.ADDRCF, Address Matched flag clear

\ I2C1_PECR (read-only) Reset:$00000000
: I2C1_PECR.PEC? ( --  x ) I2C1_PECR @ ; \ I2C1_PECR.PEC, Packet error checking               register

\ I2C1_RXDR (read-only) Reset:$00000000
: I2C1_RXDR.RXDATA? ( --  x ) I2C1_RXDR @ ; \ I2C1_RXDR.RXDATA, 8-bit receive data

\ I2C1_TXDR (read-write) Reset:$00000000
: I2C1_TXDR.TXDATA ( %bbbbbbbb -- x addr ) I2C1_TXDR ; \ I2C1_TXDR.TXDATA, 8-bit transmit data

\ I2C2_CR1 (read-write) Reset:$00000000
: I2C2_CR1.PE ( -- x addr ) 0 bit I2C2_CR1 ; \ I2C2_CR1.PE, Peripheral enable
: I2C2_CR1.TXIE ( -- x addr ) 1 bit I2C2_CR1 ; \ I2C2_CR1.TXIE, TX Interrupt enable
: I2C2_CR1.RXIE ( -- x addr ) 2 bit I2C2_CR1 ; \ I2C2_CR1.RXIE, RX Interrupt enable
: I2C2_CR1.ADDRIE ( -- x addr ) 3 bit I2C2_CR1 ; \ I2C2_CR1.ADDRIE, Address match interrupt enable (slave               only)
: I2C2_CR1.NACKIE ( -- x addr ) 4 bit I2C2_CR1 ; \ I2C2_CR1.NACKIE, Not acknowledge received interrupt               enable
: I2C2_CR1.STOPIE ( -- x addr ) 5 bit I2C2_CR1 ; \ I2C2_CR1.STOPIE, STOP detection Interrupt               enable
: I2C2_CR1.TCIE ( -- x addr ) 6 bit I2C2_CR1 ; \ I2C2_CR1.TCIE, Transfer Complete interrupt               enable
: I2C2_CR1.ERRIE ( -- x addr ) 7 bit I2C2_CR1 ; \ I2C2_CR1.ERRIE, Error interrupts enable
: I2C2_CR1.DNF ( %bbbb -- x addr ) 8 lshift I2C2_CR1 ; \ I2C2_CR1.DNF, Digital noise filter
: I2C2_CR1.ANFOFF ( -- x addr ) 12 bit I2C2_CR1 ; \ I2C2_CR1.ANFOFF, Analog noise filter OFF
: I2C2_CR1.TXDMAEN ( -- x addr ) 14 bit I2C2_CR1 ; \ I2C2_CR1.TXDMAEN, DMA transmission requests               enable
: I2C2_CR1.RXDMAEN ( -- x addr ) 15 bit I2C2_CR1 ; \ I2C2_CR1.RXDMAEN, DMA reception requests               enable
: I2C2_CR1.SBC ( -- x addr ) 16 bit I2C2_CR1 ; \ I2C2_CR1.SBC, Slave byte control
: I2C2_CR1.NOSTRETCH ( -- x addr ) 17 bit I2C2_CR1 ; \ I2C2_CR1.NOSTRETCH, Clock stretching disable
: I2C2_CR1.WUPEN ( -- x addr ) 18 bit I2C2_CR1 ; \ I2C2_CR1.WUPEN, Wakeup from STOP enable
: I2C2_CR1.GCEN ( -- x addr ) 19 bit I2C2_CR1 ; \ I2C2_CR1.GCEN, General call enable
: I2C2_CR1.SMBHEN ( -- x addr ) 20 bit I2C2_CR1 ; \ I2C2_CR1.SMBHEN, SMBus Host address enable
: I2C2_CR1.SMBDEN ( -- x addr ) 21 bit I2C2_CR1 ; \ I2C2_CR1.SMBDEN, SMBus Device Default address               enable
: I2C2_CR1.ALERTEN ( -- x addr ) 22 bit I2C2_CR1 ; \ I2C2_CR1.ALERTEN, SMBUS alert enable
: I2C2_CR1.PECEN ( -- x addr ) 23 bit I2C2_CR1 ; \ I2C2_CR1.PECEN, PEC enable

\ I2C2_CR2 (read-write) Reset:$00000000
: I2C2_CR2.PECBYTE ( -- x addr ) 26 bit I2C2_CR2 ; \ I2C2_CR2.PECBYTE, Packet error checking byte
: I2C2_CR2.AUTOEND ( -- x addr ) 25 bit I2C2_CR2 ; \ I2C2_CR2.AUTOEND, Automatic end mode (master               mode)
: I2C2_CR2.RELOAD ( -- x addr ) 24 bit I2C2_CR2 ; \ I2C2_CR2.RELOAD, NBYTES reload mode
: I2C2_CR2.NBYTES ( %bbbbbbbb -- x addr ) 16 lshift I2C2_CR2 ; \ I2C2_CR2.NBYTES, Number of bytes
: I2C2_CR2.NACK ( -- x addr ) 15 bit I2C2_CR2 ; \ I2C2_CR2.NACK, NACK generation (slave               mode)
: I2C2_CR2.STOP ( -- x addr ) 14 bit I2C2_CR2 ; \ I2C2_CR2.STOP, Stop generation (master               mode)
: I2C2_CR2.START ( -- x addr ) 13 bit I2C2_CR2 ; \ I2C2_CR2.START, Start generation
: I2C2_CR2.HEAD10R ( -- x addr ) 12 bit I2C2_CR2 ; \ I2C2_CR2.HEAD10R, 10-bit address header only read               direction (master receiver mode)
: I2C2_CR2.ADD10 ( -- x addr ) 11 bit I2C2_CR2 ; \ I2C2_CR2.ADD10, 10-bit addressing mode (master               mode)
: I2C2_CR2.RD_WRN ( -- x addr ) 10 bit I2C2_CR2 ; \ I2C2_CR2.RD_WRN, Transfer direction (master               mode)
: I2C2_CR2.SADD ( %bbbbbbbbbb -- x addr ) I2C2_CR2 ; \ I2C2_CR2.SADD, Slave address bit (master               mode)

\ I2C2_OAR1 (read-write) Reset:$00000000
: I2C2_OAR1.OA1_0 ( -- x addr ) 0 bit I2C2_OAR1 ; \ I2C2_OAR1.OA1_0, Interface address
: I2C2_OAR1.OA1_7_1 ( %bbbbbbb -- x addr ) 1 lshift I2C2_OAR1 ; \ I2C2_OAR1.OA1_7_1, Interface address
: I2C2_OAR1.OA1_8_9 ( %bb -- x addr ) 8 lshift I2C2_OAR1 ; \ I2C2_OAR1.OA1_8_9, Interface address
: I2C2_OAR1.OA1MODE ( -- x addr ) 10 bit I2C2_OAR1 ; \ I2C2_OAR1.OA1MODE, Own Address 1 10-bit mode
: I2C2_OAR1.OA1EN ( -- x addr ) 15 bit I2C2_OAR1 ; \ I2C2_OAR1.OA1EN, Own Address 1 enable

\ I2C2_OAR2 (read-write) Reset:$00000000
: I2C2_OAR2.OA2 ( %bbbbbbb -- x addr ) 1 lshift I2C2_OAR2 ; \ I2C2_OAR2.OA2, Interface address
: I2C2_OAR2.OA2MSK ( %bbb -- x addr ) 8 lshift I2C2_OAR2 ; \ I2C2_OAR2.OA2MSK, Own Address 2 masks
: I2C2_OAR2.OA2EN ( -- x addr ) 15 bit I2C2_OAR2 ; \ I2C2_OAR2.OA2EN, Own Address 2 enable

\ I2C2_TIMINGR (read-write) Reset:$00000000
: I2C2_TIMINGR.SCLL ( %bbbbbbbb -- x addr ) I2C2_TIMINGR ; \ I2C2_TIMINGR.SCLL, SCL low period (master               mode)
: I2C2_TIMINGR.SCLH ( %bbbbbbbb -- x addr ) 8 lshift I2C2_TIMINGR ; \ I2C2_TIMINGR.SCLH, SCL high period (master               mode)
: I2C2_TIMINGR.SDADEL ( %bbbb -- x addr ) 16 lshift I2C2_TIMINGR ; \ I2C2_TIMINGR.SDADEL, Data hold time
: I2C2_TIMINGR.SCLDEL ( %bbbb -- x addr ) 20 lshift I2C2_TIMINGR ; \ I2C2_TIMINGR.SCLDEL, Data setup time
: I2C2_TIMINGR.PRESC ( %bbbb -- x addr ) 28 lshift I2C2_TIMINGR ; \ I2C2_TIMINGR.PRESC, Timing prescaler

\ I2C2_TIMEOUTR (read-write) Reset:$00000000
: I2C2_TIMEOUTR.TIMEOUTA ( %bbbbbbbbbbb -- x addr ) I2C2_TIMEOUTR ; \ I2C2_TIMEOUTR.TIMEOUTA, Bus timeout A
: I2C2_TIMEOUTR.TIDLE ( -- x addr ) 12 bit I2C2_TIMEOUTR ; \ I2C2_TIMEOUTR.TIDLE, Idle clock timeout               detection
: I2C2_TIMEOUTR.TIMOUTEN ( -- x addr ) 15 bit I2C2_TIMEOUTR ; \ I2C2_TIMEOUTR.TIMOUTEN, Clock timeout enable
: I2C2_TIMEOUTR.TIMEOUTB ( %bbbbbbbbbbb -- x addr ) 16 lshift I2C2_TIMEOUTR ; \ I2C2_TIMEOUTR.TIMEOUTB, Bus timeout B
: I2C2_TIMEOUTR.TEXTEN ( -- x addr ) 31 bit I2C2_TIMEOUTR ; \ I2C2_TIMEOUTR.TEXTEN, Extended clock timeout               enable

\ I2C2_ISR (multiple-access)  Reset:$00000001
: I2C2_ISR.ADDCODE ( %bbbbbbb -- x addr ) 17 lshift I2C2_ISR ; \ I2C2_ISR.ADDCODE, Address match code (Slave               mode)
: I2C2_ISR.DIR ( -- x addr ) 16 bit I2C2_ISR ; \ I2C2_ISR.DIR, Transfer direction (Slave               mode)
: I2C2_ISR.BUSY ( -- x addr ) 15 bit I2C2_ISR ; \ I2C2_ISR.BUSY, Bus busy
: I2C2_ISR.ALERT ( -- x addr ) 13 bit I2C2_ISR ; \ I2C2_ISR.ALERT, SMBus alert
: I2C2_ISR.TIMEOUT? ( -- 1|0 ) 12 bit I2C2_ISR bit@ ; \ I2C2_ISR.TIMEOUT, Timeout or t_low detection               flag
: I2C2_ISR.PECERR ( -- x addr ) 11 bit I2C2_ISR ; \ I2C2_ISR.PECERR, PEC Error in reception
: I2C2_ISR.OVR ( -- x addr ) 10 bit I2C2_ISR ; \ I2C2_ISR.OVR, Overrun/Underrun (slave               mode)
: I2C2_ISR.ARLO ( -- x addr ) 9 bit I2C2_ISR ; \ I2C2_ISR.ARLO, Arbitration lost
: I2C2_ISR.BERR ( -- x addr ) 8 bit I2C2_ISR ; \ I2C2_ISR.BERR, Bus error
: I2C2_ISR.TCR ( -- x addr ) 7 bit I2C2_ISR ; \ I2C2_ISR.TCR, Transfer Complete Reload
: I2C2_ISR.TC ( -- x addr ) 6 bit I2C2_ISR ; \ I2C2_ISR.TC, Transfer Complete (master               mode)
: I2C2_ISR.STOPF? ( -- 1|0 ) 5 bit I2C2_ISR bit@ ; \ I2C2_ISR.STOPF, Stop detection flag
: I2C2_ISR.NACKF? ( -- 1|0 ) 4 bit I2C2_ISR bit@ ; \ I2C2_ISR.NACKF, Not acknowledge received               flag
: I2C2_ISR.ADDR ( -- x addr ) 3 bit I2C2_ISR ; \ I2C2_ISR.ADDR, Address matched (slave               mode)
: I2C2_ISR.RXNE ( -- x addr ) 2 bit I2C2_ISR ; \ I2C2_ISR.RXNE, Receive data register not empty               (receivers)
: I2C2_ISR.TXIS? ( -- 1|0 ) 1 bit I2C2_ISR bit@ ; \ I2C2_ISR.TXIS, Transmit interrupt status               (transmitters)
: I2C2_ISR.TXE ( -- x addr ) 0 bit I2C2_ISR ; \ I2C2_ISR.TXE, Transmit data register empty               (transmitters)

\ I2C2_ICR (write-only) Reset:$00000000
: I2C2_ICR.ALERTCF ( -- x addr ) 13 bit I2C2_ICR ; \ I2C2_ICR.ALERTCF, Alert flag clear
: I2C2_ICR.TIMOUTCF ( -- x addr ) 12 bit I2C2_ICR ; \ I2C2_ICR.TIMOUTCF, Timeout detection flag               clear
: I2C2_ICR.PECCF ( -- x addr ) 11 bit I2C2_ICR ; \ I2C2_ICR.PECCF, PEC Error flag clear
: I2C2_ICR.OVRCF ( -- x addr ) 10 bit I2C2_ICR ; \ I2C2_ICR.OVRCF, Overrun/Underrun flag               clear
: I2C2_ICR.ARLOCF ( -- x addr ) 9 bit I2C2_ICR ; \ I2C2_ICR.ARLOCF, Arbitration lost flag               clear
: I2C2_ICR.BERRCF ( -- x addr ) 8 bit I2C2_ICR ; \ I2C2_ICR.BERRCF, Bus error flag clear
: I2C2_ICR.STOPCF ( -- x addr ) 5 bit I2C2_ICR ; \ I2C2_ICR.STOPCF, Stop detection flag clear
: I2C2_ICR.NACKCF ( -- x addr ) 4 bit I2C2_ICR ; \ I2C2_ICR.NACKCF, Not Acknowledge flag clear
: I2C2_ICR.ADDRCF ( -- x addr ) 3 bit I2C2_ICR ; \ I2C2_ICR.ADDRCF, Address Matched flag clear

\ I2C2_PECR (read-only) Reset:$00000000
: I2C2_PECR.PEC? ( --  x ) I2C2_PECR @ ; \ I2C2_PECR.PEC, Packet error checking               register

\ I2C2_RXDR (read-only) Reset:$00000000
: I2C2_RXDR.RXDATA? ( --  x ) I2C2_RXDR @ ; \ I2C2_RXDR.RXDATA, 8-bit receive data

\ I2C2_TXDR (read-write) Reset:$00000000
: I2C2_TXDR.TXDATA ( %bbbbbbbb -- x addr ) I2C2_TXDR ; \ I2C2_TXDR.TXDATA, 8-bit transmit data

\ RTC_TR (read-write) Reset:$00000000
: RTC_TR.PM ( -- x addr ) 22 bit RTC_TR ; \ RTC_TR.PM, AM/PM notation
: RTC_TR.HT ( %bb -- x addr ) 20 lshift RTC_TR ; \ RTC_TR.HT, Hour tens in BCD format
: RTC_TR.HU ( %bbbb -- x addr ) 16 lshift RTC_TR ; \ RTC_TR.HU, Hour units in BCD format
: RTC_TR.MNT ( %bbb -- x addr ) 12 lshift RTC_TR ; \ RTC_TR.MNT, Minute tens in BCD format
: RTC_TR.MNU ( %bbbb -- x addr ) 8 lshift RTC_TR ; \ RTC_TR.MNU, Minute units in BCD format
: RTC_TR.ST ( %bbb -- x addr ) 4 lshift RTC_TR ; \ RTC_TR.ST, Second tens in BCD format
: RTC_TR.SU ( %bbbb -- x addr ) RTC_TR ; \ RTC_TR.SU, Second units in BCD format

\ RTC_DR (read-write) Reset:$00002101
: RTC_DR.YT ( %bbbb -- x addr ) 20 lshift RTC_DR ; \ RTC_DR.YT, Year tens in BCD format
: RTC_DR.YU ( %bbbb -- x addr ) 16 lshift RTC_DR ; \ RTC_DR.YU, Year units in BCD format
: RTC_DR.WDU ( %bbb -- x addr ) 13 lshift RTC_DR ; \ RTC_DR.WDU, Week day units
: RTC_DR.MT ( -- x addr ) 12 bit RTC_DR ; \ RTC_DR.MT, Month tens in BCD format
: RTC_DR.MU ( %bbbb -- x addr ) 8 lshift RTC_DR ; \ RTC_DR.MU, Month units in BCD format
: RTC_DR.DT ( %bb -- x addr ) 4 lshift RTC_DR ; \ RTC_DR.DT, Date tens in BCD format
: RTC_DR.DU ( %bbbb -- x addr ) RTC_DR ; \ RTC_DR.DU, Date units in BCD format

\ RTC_SSR (read-only) Reset:$00000000
: RTC_SSR.SS? ( --  x ) RTC_SSR @ ; \ RTC_SSR.SS, Sub second value

\ RTC_ICSR (multiple-access)  Reset:$00000007
: RTC_ICSR.ALRAWF? ( -- 1|0 ) 0 bit RTC_ICSR bit@ ; \ RTC_ICSR.ALRAWF, Alarm A write flag
: RTC_ICSR.ALRBWF? ( -- 1|0 ) 1 bit RTC_ICSR bit@ ; \ RTC_ICSR.ALRBWF, Alarm B write flag
: RTC_ICSR.WUTWF? ( -- 1|0 ) 2 bit RTC_ICSR bit@ ; \ RTC_ICSR.WUTWF, Wakeup timer write flag
: RTC_ICSR.SHPF ( -- x addr ) 3 bit RTC_ICSR ; \ RTC_ICSR.SHPF, Shift operation pending
: RTC_ICSR.INITS? ( -- 1|0 ) 4 bit RTC_ICSR bit@ ; \ RTC_ICSR.INITS, Initialization status flag
: RTC_ICSR.RSF? ( -- 1|0 ) 5 bit RTC_ICSR bit@ ; \ RTC_ICSR.RSF, Registers synchronization               flag
: RTC_ICSR.INITF? ( -- 1|0 ) 6 bit RTC_ICSR bit@ ; \ RTC_ICSR.INITF, Initialization flag
: RTC_ICSR.INIT ( -- x addr ) 7 bit RTC_ICSR ; \ RTC_ICSR.INIT, Initialization mode
: RTC_ICSR.RECALPF ( -- x addr ) 16 bit RTC_ICSR ; \ RTC_ICSR.RECALPF, Recalibration pending Flag

\ RTC_PRER (read-write) Reset:$007F00FF
: RTC_PRER.PREDIV_A ( %bbbbbbb -- x addr ) 16 lshift RTC_PRER ; \ RTC_PRER.PREDIV_A, Asynchronous prescaler               factor
: RTC_PRER.PREDIV_S ( %bbbbbbbbbbbbbbb -- x addr ) RTC_PRER ; \ RTC_PRER.PREDIV_S, Synchronous prescaler               factor

\ RTC_WUTR (read-write) Reset:$0000FFFF
: RTC_WUTR.WUT ( %bbbbbbbbbbbbbbbb -- x addr ) RTC_WUTR ; \ RTC_WUTR.WUT, Wakeup auto-reload value               bits

\ RTC_CR (read-write) Reset:$00000000
: RTC_CR.WUCKSEL ( %bbb -- x addr ) RTC_CR ; \ RTC_CR.WUCKSEL, WUCKSEL
: RTC_CR.TSEDGE ( -- x addr ) 3 bit RTC_CR ; \ RTC_CR.TSEDGE, TSEDGE
: RTC_CR.REFCKON ( -- x addr ) 4 bit RTC_CR ; \ RTC_CR.REFCKON, REFCKON
: RTC_CR.BYPSHAD ( -- x addr ) 5 bit RTC_CR ; \ RTC_CR.BYPSHAD, BYPSHAD
: RTC_CR.FMT ( -- x addr ) 6 bit RTC_CR ; \ RTC_CR.FMT, FMT
: RTC_CR.ALRAE ( -- x addr ) 8 bit RTC_CR ; \ RTC_CR.ALRAE, ALRAE
: RTC_CR.ALRBE ( -- x addr ) 9 bit RTC_CR ; \ RTC_CR.ALRBE, ALRBE
: RTC_CR.WUTE ( -- x addr ) 10 bit RTC_CR ; \ RTC_CR.WUTE, WUTE
: RTC_CR.TSE ( -- x addr ) 11 bit RTC_CR ; \ RTC_CR.TSE, TSE
: RTC_CR.ALRAIE ( -- x addr ) 12 bit RTC_CR ; \ RTC_CR.ALRAIE, ALRAIE
: RTC_CR.ALRBIE ( -- x addr ) 13 bit RTC_CR ; \ RTC_CR.ALRBIE, ALRBIE
: RTC_CR.WUTIE ( -- x addr ) 14 bit RTC_CR ; \ RTC_CR.WUTIE, WUTIE
: RTC_CR.TSIE ( -- x addr ) 15 bit RTC_CR ; \ RTC_CR.TSIE, TSIE
: RTC_CR.ADD1H ( -- x addr ) 16 bit RTC_CR ; \ RTC_CR.ADD1H, ADD1H
: RTC_CR.SUB1H ( -- x addr ) 17 bit RTC_CR ; \ RTC_CR.SUB1H, SUB1H
: RTC_CR.BKP ( -- x addr ) 18 bit RTC_CR ; \ RTC_CR.BKP, BKP
: RTC_CR.COSEL ( -- x addr ) 19 bit RTC_CR ; \ RTC_CR.COSEL, COSEL
: RTC_CR.POL ( -- x addr ) 20 bit RTC_CR ; \ RTC_CR.POL, POL
: RTC_CR.OSEL ( %bb -- x addr ) 21 lshift RTC_CR ; \ RTC_CR.OSEL, OSEL
: RTC_CR.COE ( -- x addr ) 23 bit RTC_CR ; \ RTC_CR.COE, COE
: RTC_CR.ITSE ( -- x addr ) 24 bit RTC_CR ; \ RTC_CR.ITSE, ITSE
: RTC_CR.TAMPTS ( -- x addr ) 25 bit RTC_CR ; \ RTC_CR.TAMPTS, TAMPTS
: RTC_CR.TAMPOE ( -- x addr ) 26 bit RTC_CR ; \ RTC_CR.TAMPOE, TAMPOE
: RTC_CR.TAMPALRM_PU ( -- x addr ) 29 bit RTC_CR ; \ RTC_CR.TAMPALRM_PU, TAMPALRM_PU
: RTC_CR.TAMPALRM_TYPE ( -- x addr ) 30 bit RTC_CR ; \ RTC_CR.TAMPALRM_TYPE, TAMPALRM_TYPE
: RTC_CR.OUT2EN ( -- x addr ) 31 bit RTC_CR ; \ RTC_CR.OUT2EN, OUT2EN

\ RTC_WPR (write-only) Reset:$00000000
: RTC_WPR.KEY ( %bbbbbbbb -- x addr ) RTC_WPR ; \ RTC_WPR.KEY, Write protection key

\ RTC_CALR (read-write) Reset:$00000000
: RTC_CALR.CALP ( -- x addr ) 15 bit RTC_CALR ; \ RTC_CALR.CALP, Increase frequency of RTC by 488.5               ppm
: RTC_CALR.CALW8 ( -- x addr ) 14 bit RTC_CALR ; \ RTC_CALR.CALW8, Use an 8-second calibration cycle               period
: RTC_CALR.CALW16 ( -- x addr ) 13 bit RTC_CALR ; \ RTC_CALR.CALW16, Use a 16-second calibration cycle               period
: RTC_CALR.CALM ( %bbbbbbbbb -- x addr ) RTC_CALR ; \ RTC_CALR.CALM, Calibration minus

\ RTC_SHIFTR (write-only) Reset:$00000000
: RTC_SHIFTR.ADD1S ( -- x addr ) 31 bit RTC_SHIFTR ; \ RTC_SHIFTR.ADD1S, Add one second
: RTC_SHIFTR.SUBFS ( %bbbbbbbbbbbbbbb -- x addr ) RTC_SHIFTR ; \ RTC_SHIFTR.SUBFS, Subtract a fraction of a               second

\ RTC_TSTR (read-only) Reset:$00000000
: RTC_TSTR.SU? ( --  x ) RTC_TSTR @ ; \ RTC_TSTR.SU, Second units in BCD format
: RTC_TSTR.ST? ( --  x ) 4 lshift RTC_TSTR @ ; \ RTC_TSTR.ST, Second tens in BCD format
: RTC_TSTR.MNU? ( --  x ) 8 lshift RTC_TSTR @ ; \ RTC_TSTR.MNU, Minute units in BCD format
: RTC_TSTR.MNT? ( --  x ) 12 lshift RTC_TSTR @ ; \ RTC_TSTR.MNT, Minute tens in BCD format
: RTC_TSTR.HU? ( --  x ) 16 lshift RTC_TSTR @ ; \ RTC_TSTR.HU, Hour units in BCD format
: RTC_TSTR.HT? ( --  x ) 20 lshift RTC_TSTR @ ; \ RTC_TSTR.HT, Hour tens in BCD format
: RTC_TSTR.PM? ( --  1|0 ) 22 bit RTC_TSTR bit@ ; \ RTC_TSTR.PM, AM/PM notation

\ RTC_TSDR (read-only) Reset:$00000000
: RTC_TSDR.WDU? ( --  x ) 13 lshift RTC_TSDR @ ; \ RTC_TSDR.WDU, Week day units
: RTC_TSDR.MT? ( --  1|0 ) 12 bit RTC_TSDR bit@ ; \ RTC_TSDR.MT, Month tens in BCD format
: RTC_TSDR.MU? ( --  x ) 8 lshift RTC_TSDR @ ; \ RTC_TSDR.MU, Month units in BCD format
: RTC_TSDR.DT? ( --  x ) 4 lshift RTC_TSDR @ ; \ RTC_TSDR.DT, Date tens in BCD format
: RTC_TSDR.DU? ( --  x ) RTC_TSDR @ ; \ RTC_TSDR.DU, Date units in BCD format

\ RTC_TSSSR (read-only) Reset:$00000000
: RTC_TSSSR.SS? ( --  x ) RTC_TSSSR @ ; \ RTC_TSSSR.SS, Sub second value

\ RTC_ALRMAR (read-write) Reset:$00000000
: RTC_ALRMAR.MSK4 ( -- x addr ) 31 bit RTC_ALRMAR ; \ RTC_ALRMAR.MSK4, Alarm A date mask
: RTC_ALRMAR.WDSEL ( -- x addr ) 30 bit RTC_ALRMAR ; \ RTC_ALRMAR.WDSEL, Week day selection
: RTC_ALRMAR.DT ( %bb -- x addr ) 28 lshift RTC_ALRMAR ; \ RTC_ALRMAR.DT, Date tens in BCD format
: RTC_ALRMAR.DU ( %bbbb -- x addr ) 24 lshift RTC_ALRMAR ; \ RTC_ALRMAR.DU, Date units or day in BCD               format
: RTC_ALRMAR.MSK3 ( -- x addr ) 23 bit RTC_ALRMAR ; \ RTC_ALRMAR.MSK3, Alarm A hours mask
: RTC_ALRMAR.PM ( -- x addr ) 22 bit RTC_ALRMAR ; \ RTC_ALRMAR.PM, AM/PM notation
: RTC_ALRMAR.HT ( %bb -- x addr ) 20 lshift RTC_ALRMAR ; \ RTC_ALRMAR.HT, Hour tens in BCD format
: RTC_ALRMAR.HU ( %bbbb -- x addr ) 16 lshift RTC_ALRMAR ; \ RTC_ALRMAR.HU, Hour units in BCD format
: RTC_ALRMAR.MSK2 ( -- x addr ) 15 bit RTC_ALRMAR ; \ RTC_ALRMAR.MSK2, Alarm A minutes mask
: RTC_ALRMAR.MNT ( %bbb -- x addr ) 12 lshift RTC_ALRMAR ; \ RTC_ALRMAR.MNT, Minute tens in BCD format
: RTC_ALRMAR.MNU ( %bbbb -- x addr ) 8 lshift RTC_ALRMAR ; \ RTC_ALRMAR.MNU, Minute units in BCD format
: RTC_ALRMAR.MSK1 ( -- x addr ) 7 bit RTC_ALRMAR ; \ RTC_ALRMAR.MSK1, Alarm A seconds mask
: RTC_ALRMAR.ST ( %bbb -- x addr ) 4 lshift RTC_ALRMAR ; \ RTC_ALRMAR.ST, Second tens in BCD format
: RTC_ALRMAR.SU ( %bbbb -- x addr ) RTC_ALRMAR ; \ RTC_ALRMAR.SU, Second units in BCD format

\ RTC_ALRMASSR (read-write) Reset:$00000000
: RTC_ALRMASSR.MASKSS ( %bbbb -- x addr ) 24 lshift RTC_ALRMASSR ; \ RTC_ALRMASSR.MASKSS, Mask the most-significant bits starting               at this bit
: RTC_ALRMASSR.SS ( %bbbbbbbbbbbbbbb -- x addr ) RTC_ALRMASSR ; \ RTC_ALRMASSR.SS, Sub seconds value

\ RTC_ALRMBR (read-write) Reset:$00000000
: RTC_ALRMBR.MSK4 ( -- x addr ) 31 bit RTC_ALRMBR ; \ RTC_ALRMBR.MSK4, Alarm B date mask
: RTC_ALRMBR.WDSEL ( -- x addr ) 30 bit RTC_ALRMBR ; \ RTC_ALRMBR.WDSEL, Week day selection
: RTC_ALRMBR.DT ( %bb -- x addr ) 28 lshift RTC_ALRMBR ; \ RTC_ALRMBR.DT, Date tens in BCD format
: RTC_ALRMBR.DU ( %bbbb -- x addr ) 24 lshift RTC_ALRMBR ; \ RTC_ALRMBR.DU, Date units or day in BCD               format
: RTC_ALRMBR.MSK3 ( -- x addr ) 23 bit RTC_ALRMBR ; \ RTC_ALRMBR.MSK3, Alarm B hours mask
: RTC_ALRMBR.PM ( -- x addr ) 22 bit RTC_ALRMBR ; \ RTC_ALRMBR.PM, AM/PM notation
: RTC_ALRMBR.HT ( %bb -- x addr ) 20 lshift RTC_ALRMBR ; \ RTC_ALRMBR.HT, Hour tens in BCD format
: RTC_ALRMBR.HU ( %bbbb -- x addr ) 16 lshift RTC_ALRMBR ; \ RTC_ALRMBR.HU, Hour units in BCD format
: RTC_ALRMBR.MSK2 ( -- x addr ) 15 bit RTC_ALRMBR ; \ RTC_ALRMBR.MSK2, Alarm B minutes mask
: RTC_ALRMBR.MNT ( %bbb -- x addr ) 12 lshift RTC_ALRMBR ; \ RTC_ALRMBR.MNT, Minute tens in BCD format
: RTC_ALRMBR.MNU ( %bbbb -- x addr ) 8 lshift RTC_ALRMBR ; \ RTC_ALRMBR.MNU, Minute units in BCD format
: RTC_ALRMBR.MSK1 ( -- x addr ) 7 bit RTC_ALRMBR ; \ RTC_ALRMBR.MSK1, Alarm B seconds mask
: RTC_ALRMBR.ST ( %bbb -- x addr ) 4 lshift RTC_ALRMBR ; \ RTC_ALRMBR.ST, Second tens in BCD format
: RTC_ALRMBR.SU ( %bbbb -- x addr ) RTC_ALRMBR ; \ RTC_ALRMBR.SU, Second units in BCD format

\ RTC_ALRMBSSR (read-write) Reset:$00000000
: RTC_ALRMBSSR.MASKSS ( %bbbb -- x addr ) 24 lshift RTC_ALRMBSSR ; \ RTC_ALRMBSSR.MASKSS, Mask the most-significant bits starting               at this bit
: RTC_ALRMBSSR.SS ( %bbbbbbbbbbbbbbb -- x addr ) RTC_ALRMBSSR ; \ RTC_ALRMBSSR.SS, Sub seconds value

\ RTC_SR (read-only) Reset:$00000000
: RTC_SR.ALRAF? ( --  1|0 ) 0 bit RTC_SR bit@ ; \ RTC_SR.ALRAF, ALRAF
: RTC_SR.ALRBF? ( --  1|0 ) 1 bit RTC_SR bit@ ; \ RTC_SR.ALRBF, ALRBF
: RTC_SR.WUTF? ( --  1|0 ) 2 bit RTC_SR bit@ ; \ RTC_SR.WUTF, WUTF
: RTC_SR.TSF? ( --  1|0 ) 3 bit RTC_SR bit@ ; \ RTC_SR.TSF, TSF
: RTC_SR.TSOVF? ( --  1|0 ) 4 bit RTC_SR bit@ ; \ RTC_SR.TSOVF, TSOVF
: RTC_SR.ITSF? ( --  1|0 ) 5 bit RTC_SR bit@ ; \ RTC_SR.ITSF, ITSF

\ RTC_MISR (read-only) Reset:$00000000
: RTC_MISR.ALRAMF? ( --  1|0 ) 0 bit RTC_MISR bit@ ; \ RTC_MISR.ALRAMF, ALRAMF
: RTC_MISR.ALRBMF? ( --  1|0 ) 1 bit RTC_MISR bit@ ; \ RTC_MISR.ALRBMF, ALRBMF
: RTC_MISR.WUTMF? ( --  1|0 ) 2 bit RTC_MISR bit@ ; \ RTC_MISR.WUTMF, WUTMF
: RTC_MISR.TSMF? ( --  1|0 ) 3 bit RTC_MISR bit@ ; \ RTC_MISR.TSMF, TSMF
: RTC_MISR.TSOVMF? ( --  1|0 ) 4 bit RTC_MISR bit@ ; \ RTC_MISR.TSOVMF, TSOVMF
: RTC_MISR.ITSMF? ( --  1|0 ) 5 bit RTC_MISR bit@ ; \ RTC_MISR.ITSMF, ITSMF

\ RTC_SCR (read-write) Reset:$00000000
: RTC_SCR.CALRAF ( -- x addr ) 0 bit RTC_SCR ; \ RTC_SCR.CALRAF, CALRAF
: RTC_SCR.CALRBF ( -- x addr ) 1 bit RTC_SCR ; \ RTC_SCR.CALRBF, CALRBF
: RTC_SCR.CWUTF ( -- x addr ) 2 bit RTC_SCR ; \ RTC_SCR.CWUTF, CWUTF
: RTC_SCR.CTSF ( -- x addr ) 3 bit RTC_SCR ; \ RTC_SCR.CTSF, CTSF
: RTC_SCR.CTSOVF ( -- x addr ) 4 bit RTC_SCR ; \ RTC_SCR.CTSOVF, CTSOVF
: RTC_SCR.CITSF ( -- x addr ) 5 bit RTC_SCR ; \ RTC_SCR.CITSF, CITSF

\ TIM14_CR1 (read-write) Reset:$0000
: TIM14_CR1.UIFREMAP ( -- x addr ) 11 bit TIM14_CR1 ; \ TIM14_CR1.UIFREMAP, UIF status bit remapping
: TIM14_CR1.CKD ( %bb -- x addr ) 8 lshift TIM14_CR1 ; \ TIM14_CR1.CKD, Clock division
: TIM14_CR1.ARPE ( -- x addr ) 7 bit TIM14_CR1 ; \ TIM14_CR1.ARPE, Auto-reload preload enable
: TIM14_CR1.OPM ( -- x addr ) 3 bit TIM14_CR1 ; \ TIM14_CR1.OPM, One-pulse mode
: TIM14_CR1.URS ( -- x addr ) 2 bit TIM14_CR1 ; \ TIM14_CR1.URS, Update request source
: TIM14_CR1.UDIS ( -- x addr ) 1 bit TIM14_CR1 ; \ TIM14_CR1.UDIS, Update disable
: TIM14_CR1.CEN ( -- x addr ) 0 bit TIM14_CR1 ; \ TIM14_CR1.CEN, Counter enable

\ TIM14_DIER (read-write) Reset:$0000
: TIM14_DIER.CC1IE ( -- x addr ) 1 bit TIM14_DIER ; \ TIM14_DIER.CC1IE, Capture/Compare 1 interrupt               enable
: TIM14_DIER.UIE ( -- x addr ) 0 bit TIM14_DIER ; \ TIM14_DIER.UIE, Update interrupt enable

\ TIM14_SR (read-write) Reset:$0000
: TIM14_SR.CC1OF ( -- x addr ) 9 bit TIM14_SR ; \ TIM14_SR.CC1OF, Capture/Compare 1 overcapture               flag
: TIM14_SR.CC1IF ( -- x addr ) 1 bit TIM14_SR ; \ TIM14_SR.CC1IF, Capture/compare 1 interrupt               flag
: TIM14_SR.UIF ( -- x addr ) 0 bit TIM14_SR ; \ TIM14_SR.UIF, Update interrupt flag

\ TIM14_EGR (write-only) Reset:$0000
: TIM14_EGR.CC1G ( -- x addr ) 1 bit TIM14_EGR ; \ TIM14_EGR.CC1G, Capture/compare 1               generation
: TIM14_EGR.UG ( -- x addr ) 0 bit TIM14_EGR ; \ TIM14_EGR.UG, Update generation

\ TIM14_CCMR1_Output (read-write) Reset:$00000000
: TIM14_CCMR1_Output.CC1S ( %bb -- x addr ) TIM14_CCMR1_Output ; \ TIM14_CCMR1_Output.CC1S, CC1S
: TIM14_CCMR1_Output.OC1FE ( -- x addr ) 2 bit TIM14_CCMR1_Output ; \ TIM14_CCMR1_Output.OC1FE, OC1FE
: TIM14_CCMR1_Output.OC1PE ( -- x addr ) 3 bit TIM14_CCMR1_Output ; \ TIM14_CCMR1_Output.OC1PE, OC1PE
: TIM14_CCMR1_Output.OC1M ( %bbb -- x addr ) 4 lshift TIM14_CCMR1_Output ; \ TIM14_CCMR1_Output.OC1M, OC1M
: TIM14_CCMR1_Output.OC1CE ( -- x addr ) 7 bit TIM14_CCMR1_Output ; \ TIM14_CCMR1_Output.OC1CE, OC1CE
: TIM14_CCMR1_Output.OC1M_3 ( -- x addr ) 16 bit TIM14_CCMR1_Output ; \ TIM14_CCMR1_Output.OC1M_3, Output Compare 1 mode - bit               3

\ TIM14_CCMR1_Input (read-write) Reset:$00000000
: TIM14_CCMR1_Input.IC1F ( %bbbb -- x addr ) 4 lshift TIM14_CCMR1_Input ; \ TIM14_CCMR1_Input.IC1F, Input capture 1 filter
: TIM14_CCMR1_Input.ICPCS ( %bb -- x addr ) 2 lshift TIM14_CCMR1_Input ; \ TIM14_CCMR1_Input.ICPCS, Input capture 1 prescaler
: TIM14_CCMR1_Input.CC1S ( %bb -- x addr ) TIM14_CCMR1_Input ; \ TIM14_CCMR1_Input.CC1S, Capture/Compare 1               selection

\ TIM14_CCER (read-write) Reset:$0000
: TIM14_CCER.CC1NP ( -- x addr ) 3 bit TIM14_CCER ; \ TIM14_CCER.CC1NP, Capture/Compare 1 output               Polarity
: TIM14_CCER.CC1P ( -- x addr ) 1 bit TIM14_CCER ; \ TIM14_CCER.CC1P, Capture/Compare 1 output               Polarity
: TIM14_CCER.CC1E ( -- x addr ) 0 bit TIM14_CCER ; \ TIM14_CCER.CC1E, Capture/Compare 1 output               enable

\ TIM14_CNT (read-write) Reset:$00000000
: TIM14_CNT.CNT ( %bbbbbbbbbbbbbbbb -- x addr ) TIM14_CNT ; \ TIM14_CNT.CNT, low counter value
: TIM14_CNT.UIFCPY ( -- x addr ) 31 bit TIM14_CNT ; \ TIM14_CNT.UIFCPY, UIF Copy

\ TIM14_PSC (read-write) Reset:$0000
: TIM14_PSC.PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIM14_PSC ; \ TIM14_PSC.PSC, Prescaler value

\ TIM14_ARR (read-write) Reset:$00000000
: TIM14_ARR.ARR ( %bbbbbbbbbbbbbbbb -- x addr ) TIM14_ARR ; \ TIM14_ARR.ARR, Low Auto-reload value

\ TIM14_CCR1 (read-write) Reset:$00000000
: TIM14_CCR1.CCR1 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM14_CCR1 ; \ TIM14_CCR1.CCR1, Low Capture/Compare 1               value

\ TIM14_TISEL (read-write) Reset:$0000
: TIM14_TISEL.TISEL ( %bbbb -- x addr ) TIM14_TISEL ; \ TIM14_TISEL.TISEL, TI1[0] to TI1[15] input               selection

\ TIM2_CR1 (read-write) Reset:$0000
: TIM2_CR1.UIFREMAP ( -- x addr ) 11 bit TIM2_CR1 ; \ TIM2_CR1.UIFREMAP, UIF status bit remapping
: TIM2_CR1.CKD ( %bb -- x addr ) 8 lshift TIM2_CR1 ; \ TIM2_CR1.CKD, Clock division
: TIM2_CR1.ARPE ( -- x addr ) 7 bit TIM2_CR1 ; \ TIM2_CR1.ARPE, Auto-reload preload enable
: TIM2_CR1.CMS ( %bb -- x addr ) 5 lshift TIM2_CR1 ; \ TIM2_CR1.CMS, Center-aligned mode               selection
: TIM2_CR1.DIR ( -- x addr ) 4 bit TIM2_CR1 ; \ TIM2_CR1.DIR, Direction
: TIM2_CR1.OPM ( -- x addr ) 3 bit TIM2_CR1 ; \ TIM2_CR1.OPM, One-pulse mode
: TIM2_CR1.URS ( -- x addr ) 2 bit TIM2_CR1 ; \ TIM2_CR1.URS, Update request source
: TIM2_CR1.UDIS ( -- x addr ) 1 bit TIM2_CR1 ; \ TIM2_CR1.UDIS, Update disable
: TIM2_CR1.CEN ( -- x addr ) 0 bit TIM2_CR1 ; \ TIM2_CR1.CEN, Counter enable

\ TIM2_CR2 (read-write) Reset:$0000
: TIM2_CR2.TI1S ( -- x addr ) 7 bit TIM2_CR2 ; \ TIM2_CR2.TI1S, TI1 selection
: TIM2_CR2.MMS ( %bbb -- x addr ) 4 lshift TIM2_CR2 ; \ TIM2_CR2.MMS, Master mode selection
: TIM2_CR2.CCDS ( -- x addr ) 3 bit TIM2_CR2 ; \ TIM2_CR2.CCDS, Capture/compare DMA               selection

\ TIM2_SMCR (read-write) Reset:$0000
: TIM2_SMCR.TS_4_3 ( %bb -- x addr ) 20 lshift TIM2_SMCR ; \ TIM2_SMCR.TS_4_3, Trigger selection
: TIM2_SMCR.SMS_3 ( -- x addr ) 16 bit TIM2_SMCR ; \ TIM2_SMCR.SMS_3, Slave mode selection - bit               3
: TIM2_SMCR.ETP ( -- x addr ) 15 bit TIM2_SMCR ; \ TIM2_SMCR.ETP, External trigger polarity
: TIM2_SMCR.ECE ( -- x addr ) 14 bit TIM2_SMCR ; \ TIM2_SMCR.ECE, External clock enable
: TIM2_SMCR.ETPS ( %bb -- x addr ) 12 lshift TIM2_SMCR ; \ TIM2_SMCR.ETPS, External trigger prescaler
: TIM2_SMCR.ETF ( %bbbb -- x addr ) 8 lshift TIM2_SMCR ; \ TIM2_SMCR.ETF, External trigger filter
: TIM2_SMCR.MSM ( -- x addr ) 7 bit TIM2_SMCR ; \ TIM2_SMCR.MSM, Master/Slave mode
: TIM2_SMCR.TS ( %bbb -- x addr ) 4 lshift TIM2_SMCR ; \ TIM2_SMCR.TS, Trigger selection
: TIM2_SMCR.OCCS ( -- x addr ) 3 bit TIM2_SMCR ; \ TIM2_SMCR.OCCS, OCREF clear selection
: TIM2_SMCR.SMS ( %bbb -- x addr ) TIM2_SMCR ; \ TIM2_SMCR.SMS, Slave mode selection

\ TIM2_DIER (read-write) Reset:$0000
: TIM2_DIER.TDE ( -- x addr ) 14 bit TIM2_DIER ; \ TIM2_DIER.TDE, Trigger DMA request enable
: TIM2_DIER.CC4DE ( -- x addr ) 12 bit TIM2_DIER ; \ TIM2_DIER.CC4DE, Capture/Compare 4 DMA request               enable
: TIM2_DIER.CC3DE ( -- x addr ) 11 bit TIM2_DIER ; \ TIM2_DIER.CC3DE, Capture/Compare 3 DMA request               enable
: TIM2_DIER.CC2DE ( -- x addr ) 10 bit TIM2_DIER ; \ TIM2_DIER.CC2DE, Capture/Compare 2 DMA request               enable
: TIM2_DIER.CC1DE ( -- x addr ) 9 bit TIM2_DIER ; \ TIM2_DIER.CC1DE, Capture/Compare 1 DMA request               enable
: TIM2_DIER.UDE ( -- x addr ) 8 bit TIM2_DIER ; \ TIM2_DIER.UDE, Update DMA request enable
: TIM2_DIER.TIE ( -- x addr ) 6 bit TIM2_DIER ; \ TIM2_DIER.TIE, Trigger interrupt enable
: TIM2_DIER.CC4IE ( -- x addr ) 4 bit TIM2_DIER ; \ TIM2_DIER.CC4IE, Capture/Compare 4 interrupt               enable
: TIM2_DIER.CC3IE ( -- x addr ) 3 bit TIM2_DIER ; \ TIM2_DIER.CC3IE, Capture/Compare 3 interrupt               enable
: TIM2_DIER.CC2IE ( -- x addr ) 2 bit TIM2_DIER ; \ TIM2_DIER.CC2IE, Capture/Compare 2 interrupt               enable
: TIM2_DIER.CC1IE ( -- x addr ) 1 bit TIM2_DIER ; \ TIM2_DIER.CC1IE, Capture/Compare 1 interrupt               enable
: TIM2_DIER.UIE ( -- x addr ) 0 bit TIM2_DIER ; \ TIM2_DIER.UIE, Update interrupt enable

\ TIM2_SR (read-write) Reset:$0000
: TIM2_SR.CC4OF ( -- x addr ) 12 bit TIM2_SR ; \ TIM2_SR.CC4OF, Capture/Compare 4 overcapture               flag
: TIM2_SR.CC3OF ( -- x addr ) 11 bit TIM2_SR ; \ TIM2_SR.CC3OF, Capture/Compare 3 overcapture               flag
: TIM2_SR.CC2OF ( -- x addr ) 10 bit TIM2_SR ; \ TIM2_SR.CC2OF, Capture/compare 2 overcapture               flag
: TIM2_SR.CC1OF ( -- x addr ) 9 bit TIM2_SR ; \ TIM2_SR.CC1OF, Capture/Compare 1 overcapture               flag
: TIM2_SR.TIF ( -- x addr ) 6 bit TIM2_SR ; \ TIM2_SR.TIF, Trigger interrupt flag
: TIM2_SR.CC4IF ( -- x addr ) 4 bit TIM2_SR ; \ TIM2_SR.CC4IF, Capture/Compare 4 interrupt               flag
: TIM2_SR.CC3IF ( -- x addr ) 3 bit TIM2_SR ; \ TIM2_SR.CC3IF, Capture/Compare 3 interrupt               flag
: TIM2_SR.CC2IF ( -- x addr ) 2 bit TIM2_SR ; \ TIM2_SR.CC2IF, Capture/Compare 2 interrupt               flag
: TIM2_SR.CC1IF ( -- x addr ) 1 bit TIM2_SR ; \ TIM2_SR.CC1IF, Capture/compare 1 interrupt               flag
: TIM2_SR.UIF ( -- x addr ) 0 bit TIM2_SR ; \ TIM2_SR.UIF, Update interrupt flag

\ TIM2_EGR (write-only) Reset:$0000
: TIM2_EGR.TG ( -- x addr ) 6 bit TIM2_EGR ; \ TIM2_EGR.TG, Trigger generation
: TIM2_EGR.CC4G ( -- x addr ) 4 bit TIM2_EGR ; \ TIM2_EGR.CC4G, Capture/compare 4               generation
: TIM2_EGR.CC3G ( -- x addr ) 3 bit TIM2_EGR ; \ TIM2_EGR.CC3G, Capture/compare 3               generation
: TIM2_EGR.CC2G ( -- x addr ) 2 bit TIM2_EGR ; \ TIM2_EGR.CC2G, Capture/compare 2               generation
: TIM2_EGR.CC1G ( -- x addr ) 1 bit TIM2_EGR ; \ TIM2_EGR.CC1G, Capture/compare 1               generation
: TIM2_EGR.UG ( -- x addr ) 0 bit TIM2_EGR ; \ TIM2_EGR.UG, Update generation

\ TIM2_CCMR1_Output (read-write) Reset:$00000000
: TIM2_CCMR1_Output.OC2M_3 ( -- x addr ) 24 bit TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output.OC2M_3, Output Compare 2 mode - bit               3
: TIM2_CCMR1_Output.OC1M_3 ( -- x addr ) 16 bit TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output.OC1M_3, Output Compare 1 mode - bit               3
: TIM2_CCMR1_Output.OC2CE ( -- x addr ) 15 bit TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output.OC2CE, Output compare 2 clear               enable
: TIM2_CCMR1_Output.OC2M ( %bbb -- x addr ) 12 lshift TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output.OC2M, Output compare 2 mode
: TIM2_CCMR1_Output.OC2PE ( -- x addr ) 11 bit TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output.OC2PE, Output compare 2 preload               enable
: TIM2_CCMR1_Output.OC2FE ( -- x addr ) 10 bit TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output.OC2FE, Output compare 2 fast               enable
: TIM2_CCMR1_Output.CC2S ( %bb -- x addr ) 8 lshift TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output.CC2S, Capture/Compare 2               selection
: TIM2_CCMR1_Output.OC1CE ( -- x addr ) 7 bit TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output.OC1CE, Output compare 1 clear               enable
: TIM2_CCMR1_Output.OC1M ( %bbb -- x addr ) 4 lshift TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output.OC1M, Output compare 1 mode
: TIM2_CCMR1_Output.OC1PE ( -- x addr ) 3 bit TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output.OC1PE, Output compare 1 preload               enable
: TIM2_CCMR1_Output.OC1FE ( -- x addr ) 2 bit TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output.OC1FE, Output compare 1 fast               enable
: TIM2_CCMR1_Output.CC1S ( %bb -- x addr ) TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output.CC1S, Capture/Compare 1               selection

\ TIM2_CCMR1_Input (read-write) Reset:$00000000
: TIM2_CCMR1_Input.IC2F ( %bbbb -- x addr ) 12 lshift TIM2_CCMR1_Input ; \ TIM2_CCMR1_Input.IC2F, Input capture 2 filter
: TIM2_CCMR1_Input.IC2PSC ( %bb -- x addr ) 10 lshift TIM2_CCMR1_Input ; \ TIM2_CCMR1_Input.IC2PSC, Input capture 2 prescaler
: TIM2_CCMR1_Input.CC2S ( %bb -- x addr ) 8 lshift TIM2_CCMR1_Input ; \ TIM2_CCMR1_Input.CC2S, Capture/compare 2               selection
: TIM2_CCMR1_Input.IC1F ( %bbbb -- x addr ) 4 lshift TIM2_CCMR1_Input ; \ TIM2_CCMR1_Input.IC1F, Input capture 1 filter
: TIM2_CCMR1_Input.IC1PSC ( %bb -- x addr ) 2 lshift TIM2_CCMR1_Input ; \ TIM2_CCMR1_Input.IC1PSC, Input capture 1 prescaler
: TIM2_CCMR1_Input.CC1S ( %bb -- x addr ) TIM2_CCMR1_Input ; \ TIM2_CCMR1_Input.CC1S, Capture/Compare 1               selection

\ TIM2_CCMR2_Output (read-write) Reset:$00000000
: TIM2_CCMR2_Output.OC4M_3 ( -- x addr ) 24 bit TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output.OC4M_3, Output Compare 4 mode - bit               3
: TIM2_CCMR2_Output.OC3M_3 ( -- x addr ) 16 bit TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output.OC3M_3, Output Compare 3 mode - bit               3
: TIM2_CCMR2_Output.OC4CE ( -- x addr ) 15 bit TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output.OC4CE, Output compare 4 clear               enable
: TIM2_CCMR2_Output.OC4M ( %bbb -- x addr ) 12 lshift TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output.OC4M, Output compare 4 mode
: TIM2_CCMR2_Output.OC4PE ( -- x addr ) 11 bit TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output.OC4PE, Output compare 4 preload               enable
: TIM2_CCMR2_Output.OC4FE ( -- x addr ) 10 bit TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output.OC4FE, Output compare 4 fast               enable
: TIM2_CCMR2_Output.CC4S ( %bb -- x addr ) 8 lshift TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output.CC4S, Capture/Compare 4               selection
: TIM2_CCMR2_Output.OC3CE ( -- x addr ) 7 bit TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output.OC3CE, Output compare 3 clear               enable
: TIM2_CCMR2_Output.OC3M ( %bbb -- x addr ) 4 lshift TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output.OC3M, Output compare 3 mode
: TIM2_CCMR2_Output.OC3PE ( -- x addr ) 3 bit TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output.OC3PE, Output compare 3 preload               enable
: TIM2_CCMR2_Output.OC3FE ( -- x addr ) 2 bit TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output.OC3FE, Output compare 3 fast               enable
: TIM2_CCMR2_Output.CC3S ( %bb -- x addr ) TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output.CC3S, Capture/Compare 3               selection

\ TIM2_CCMR2_Input (read-write) Reset:$00000000
: TIM2_CCMR2_Input.IC4F ( %bbbb -- x addr ) 12 lshift TIM2_CCMR2_Input ; \ TIM2_CCMR2_Input.IC4F, Input capture 4 filter
: TIM2_CCMR2_Input.IC4PSC ( %bb -- x addr ) 10 lshift TIM2_CCMR2_Input ; \ TIM2_CCMR2_Input.IC4PSC, Input capture 4 prescaler
: TIM2_CCMR2_Input.CC4S ( %bb -- x addr ) 8 lshift TIM2_CCMR2_Input ; \ TIM2_CCMR2_Input.CC4S, Capture/Compare 4               selection
: TIM2_CCMR2_Input.IC3F ( %bbbb -- x addr ) 4 lshift TIM2_CCMR2_Input ; \ TIM2_CCMR2_Input.IC3F, Input capture 3 filter
: TIM2_CCMR2_Input.IC3PSC ( %bb -- x addr ) 2 lshift TIM2_CCMR2_Input ; \ TIM2_CCMR2_Input.IC3PSC, Input capture 3 prescaler
: TIM2_CCMR2_Input.CC3S ( %bb -- x addr ) TIM2_CCMR2_Input ; \ TIM2_CCMR2_Input.CC3S, Capture/Compare 3               selection

\ TIM2_CCER (read-write) Reset:$0000
: TIM2_CCER.CC4NP ( -- x addr ) 15 bit TIM2_CCER ; \ TIM2_CCER.CC4NP, Capture/Compare 4 output               Polarity
: TIM2_CCER.CC4P ( -- x addr ) 13 bit TIM2_CCER ; \ TIM2_CCER.CC4P, Capture/Compare 3 output               Polarity
: TIM2_CCER.CC4E ( -- x addr ) 12 bit TIM2_CCER ; \ TIM2_CCER.CC4E, Capture/Compare 4 output               enable
: TIM2_CCER.CC3NP ( -- x addr ) 11 bit TIM2_CCER ; \ TIM2_CCER.CC3NP, Capture/Compare 3 output               Polarity
: TIM2_CCER.CC3P ( -- x addr ) 9 bit TIM2_CCER ; \ TIM2_CCER.CC3P, Capture/Compare 3 output               Polarity
: TIM2_CCER.CC3E ( -- x addr ) 8 bit TIM2_CCER ; \ TIM2_CCER.CC3E, Capture/Compare 3 output               enable
: TIM2_CCER.CC2NP ( -- x addr ) 7 bit TIM2_CCER ; \ TIM2_CCER.CC2NP, Capture/Compare 2 output               Polarity
: TIM2_CCER.CC2P ( -- x addr ) 5 bit TIM2_CCER ; \ TIM2_CCER.CC2P, Capture/Compare 2 output               Polarity
: TIM2_CCER.CC2E ( -- x addr ) 4 bit TIM2_CCER ; \ TIM2_CCER.CC2E, Capture/Compare 2 output               enable
: TIM2_CCER.CC1NP ( -- x addr ) 3 bit TIM2_CCER ; \ TIM2_CCER.CC1NP, Capture/Compare 1 output               Polarity
: TIM2_CCER.CC1P ( -- x addr ) 1 bit TIM2_CCER ; \ TIM2_CCER.CC1P, Capture/Compare 1 output               Polarity
: TIM2_CCER.CC1E ( -- x addr ) 0 bit TIM2_CCER ; \ TIM2_CCER.CC1E, Capture/Compare 1 output               enable

\ TIM2_CNT (read-write) Reset:$00000000
: TIM2_CNT.CNT_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2_CNT ; \ TIM2_CNT.CNT_H, High counter value (TIM2               only)
: TIM2_CNT.CNT_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_CNT ; \ TIM2_CNT.CNT_L, Low counter value

\ TIM2_PSC (read-write) Reset:$0000
: TIM2_PSC.PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_PSC ; \ TIM2_PSC.PSC, Prescaler value

\ TIM2_ARR (read-write) Reset:$00000000
: TIM2_ARR.ARR_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2_ARR ; \ TIM2_ARR.ARR_H, High Auto-reload value (TIM2               only)
: TIM2_ARR.ARR_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_ARR ; \ TIM2_ARR.ARR_L, Low Auto-reload value

\ TIM2_CCR1 (read-write) Reset:$00000000
: TIM2_CCR1.CCR1_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2_CCR1 ; \ TIM2_CCR1.CCR1_H, High Capture/Compare 1 value (TIM2               only)
: TIM2_CCR1.CCR1_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_CCR1 ; \ TIM2_CCR1.CCR1_L, Low Capture/Compare 1               value

\ TIM2_CCR2 (read-write) Reset:$00000000
: TIM2_CCR2.CCR2_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2_CCR2 ; \ TIM2_CCR2.CCR2_H, High Capture/Compare 2 value (TIM2               only)
: TIM2_CCR2.CCR2_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_CCR2 ; \ TIM2_CCR2.CCR2_L, Low Capture/Compare 2               value

\ TIM2_CCR3 (read-write) Reset:$00000000
: TIM2_CCR3.CCR3_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2_CCR3 ; \ TIM2_CCR3.CCR3_H, High Capture/Compare value (TIM2               only)
: TIM2_CCR3.CCR3_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_CCR3 ; \ TIM2_CCR3.CCR3_L, Low Capture/Compare value

\ TIM2_CCR4 (read-write) Reset:$00000000
: TIM2_CCR4.CCR4_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2_CCR4 ; \ TIM2_CCR4.CCR4_H, High Capture/Compare value (TIM2               only)
: TIM2_CCR4.CCR4_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_CCR4 ; \ TIM2_CCR4.CCR4_L, Low Capture/Compare value

\ TIM2_DCR (read-write) Reset:$0000
: TIM2_DCR.DBL ( %bbbbb -- x addr ) 8 lshift TIM2_DCR ; \ TIM2_DCR.DBL, DMA burst length
: TIM2_DCR.DBA ( %bbbbb -- x addr ) TIM2_DCR ; \ TIM2_DCR.DBA, DMA base address

\ TIM2_DMAR (read-write) Reset:$0000
: TIM2_DMAR.DMAB ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_DMAR ; \ TIM2_DMAR.DMAB, DMA register for burst               accesses

\ TIM2_OR1 (read-write) Reset:$0000
: TIM2_OR1.IOCREF_CLR ( -- x addr ) 0 bit TIM2_OR1 ; \ TIM2_OR1.IOCREF_CLR, IOCREF_CLR

\ TIM2_AF1 (read-write) Reset:$0000
: TIM2_AF1.ETRSEL ( %bbbb -- x addr ) 14 lshift TIM2_AF1 ; \ TIM2_AF1.ETRSEL, External trigger source               selection

\ TIM2_TISEL (read-write) Reset:$0000
: TIM2_TISEL.TI1SEL ( %bbbb -- x addr ) TIM2_TISEL ; \ TIM2_TISEL.TI1SEL, TI1SEL
: TIM2_TISEL.TI2SEL ( %bbbb -- x addr ) 8 lshift TIM2_TISEL ; \ TIM2_TISEL.TI2SEL, TI2SEL

\ TIM3_CR1 (read-write) Reset:$0000
: TIM3_CR1.UIFREMAP ( -- x addr ) 11 bit TIM3_CR1 ; \ TIM3_CR1.UIFREMAP, UIF status bit remapping
: TIM3_CR1.CKD ( %bb -- x addr ) 8 lshift TIM3_CR1 ; \ TIM3_CR1.CKD, Clock division
: TIM3_CR1.ARPE ( -- x addr ) 7 bit TIM3_CR1 ; \ TIM3_CR1.ARPE, Auto-reload preload enable
: TIM3_CR1.CMS ( %bb -- x addr ) 5 lshift TIM3_CR1 ; \ TIM3_CR1.CMS, Center-aligned mode               selection
: TIM3_CR1.DIR ( -- x addr ) 4 bit TIM3_CR1 ; \ TIM3_CR1.DIR, Direction
: TIM3_CR1.OPM ( -- x addr ) 3 bit TIM3_CR1 ; \ TIM3_CR1.OPM, One-pulse mode
: TIM3_CR1.URS ( -- x addr ) 2 bit TIM3_CR1 ; \ TIM3_CR1.URS, Update request source
: TIM3_CR1.UDIS ( -- x addr ) 1 bit TIM3_CR1 ; \ TIM3_CR1.UDIS, Update disable
: TIM3_CR1.CEN ( -- x addr ) 0 bit TIM3_CR1 ; \ TIM3_CR1.CEN, Counter enable

\ TIM3_CR2 (read-write) Reset:$0000
: TIM3_CR2.TI1S ( -- x addr ) 7 bit TIM3_CR2 ; \ TIM3_CR2.TI1S, TI1 selection
: TIM3_CR2.MMS ( %bbb -- x addr ) 4 lshift TIM3_CR2 ; \ TIM3_CR2.MMS, Master mode selection
: TIM3_CR2.CCDS ( -- x addr ) 3 bit TIM3_CR2 ; \ TIM3_CR2.CCDS, Capture/compare DMA               selection

\ TIM3_SMCR (read-write) Reset:$0000
: TIM3_SMCR.TS_4_3 ( %bb -- x addr ) 20 lshift TIM3_SMCR ; \ TIM3_SMCR.TS_4_3, Trigger selection
: TIM3_SMCR.SMS_3 ( -- x addr ) 16 bit TIM3_SMCR ; \ TIM3_SMCR.SMS_3, Slave mode selection - bit               3
: TIM3_SMCR.ETP ( -- x addr ) 15 bit TIM3_SMCR ; \ TIM3_SMCR.ETP, External trigger polarity
: TIM3_SMCR.ECE ( -- x addr ) 14 bit TIM3_SMCR ; \ TIM3_SMCR.ECE, External clock enable
: TIM3_SMCR.ETPS ( %bb -- x addr ) 12 lshift TIM3_SMCR ; \ TIM3_SMCR.ETPS, External trigger prescaler
: TIM3_SMCR.ETF ( %bbbb -- x addr ) 8 lshift TIM3_SMCR ; \ TIM3_SMCR.ETF, External trigger filter
: TIM3_SMCR.MSM ( -- x addr ) 7 bit TIM3_SMCR ; \ TIM3_SMCR.MSM, Master/Slave mode
: TIM3_SMCR.TS ( %bbb -- x addr ) 4 lshift TIM3_SMCR ; \ TIM3_SMCR.TS, Trigger selection
: TIM3_SMCR.OCCS ( -- x addr ) 3 bit TIM3_SMCR ; \ TIM3_SMCR.OCCS, OCREF clear selection
: TIM3_SMCR.SMS ( %bbb -- x addr ) TIM3_SMCR ; \ TIM3_SMCR.SMS, Slave mode selection

\ TIM3_DIER (read-write) Reset:$0000
: TIM3_DIER.TDE ( -- x addr ) 14 bit TIM3_DIER ; \ TIM3_DIER.TDE, Trigger DMA request enable
: TIM3_DIER.CC4DE ( -- x addr ) 12 bit TIM3_DIER ; \ TIM3_DIER.CC4DE, Capture/Compare 4 DMA request               enable
: TIM3_DIER.CC3DE ( -- x addr ) 11 bit TIM3_DIER ; \ TIM3_DIER.CC3DE, Capture/Compare 3 DMA request               enable
: TIM3_DIER.CC2DE ( -- x addr ) 10 bit TIM3_DIER ; \ TIM3_DIER.CC2DE, Capture/Compare 2 DMA request               enable
: TIM3_DIER.CC1DE ( -- x addr ) 9 bit TIM3_DIER ; \ TIM3_DIER.CC1DE, Capture/Compare 1 DMA request               enable
: TIM3_DIER.UDE ( -- x addr ) 8 bit TIM3_DIER ; \ TIM3_DIER.UDE, Update DMA request enable
: TIM3_DIER.TIE ( -- x addr ) 6 bit TIM3_DIER ; \ TIM3_DIER.TIE, Trigger interrupt enable
: TIM3_DIER.CC4IE ( -- x addr ) 4 bit TIM3_DIER ; \ TIM3_DIER.CC4IE, Capture/Compare 4 interrupt               enable
: TIM3_DIER.CC3IE ( -- x addr ) 3 bit TIM3_DIER ; \ TIM3_DIER.CC3IE, Capture/Compare 3 interrupt               enable
: TIM3_DIER.CC2IE ( -- x addr ) 2 bit TIM3_DIER ; \ TIM3_DIER.CC2IE, Capture/Compare 2 interrupt               enable
: TIM3_DIER.CC1IE ( -- x addr ) 1 bit TIM3_DIER ; \ TIM3_DIER.CC1IE, Capture/Compare 1 interrupt               enable
: TIM3_DIER.UIE ( -- x addr ) 0 bit TIM3_DIER ; \ TIM3_DIER.UIE, Update interrupt enable

\ TIM3_SR (read-write) Reset:$0000
: TIM3_SR.CC4OF ( -- x addr ) 12 bit TIM3_SR ; \ TIM3_SR.CC4OF, Capture/Compare 4 overcapture               flag
: TIM3_SR.CC3OF ( -- x addr ) 11 bit TIM3_SR ; \ TIM3_SR.CC3OF, Capture/Compare 3 overcapture               flag
: TIM3_SR.CC2OF ( -- x addr ) 10 bit TIM3_SR ; \ TIM3_SR.CC2OF, Capture/compare 2 overcapture               flag
: TIM3_SR.CC1OF ( -- x addr ) 9 bit TIM3_SR ; \ TIM3_SR.CC1OF, Capture/Compare 1 overcapture               flag
: TIM3_SR.TIF ( -- x addr ) 6 bit TIM3_SR ; \ TIM3_SR.TIF, Trigger interrupt flag
: TIM3_SR.CC4IF ( -- x addr ) 4 bit TIM3_SR ; \ TIM3_SR.CC4IF, Capture/Compare 4 interrupt               flag
: TIM3_SR.CC3IF ( -- x addr ) 3 bit TIM3_SR ; \ TIM3_SR.CC3IF, Capture/Compare 3 interrupt               flag
: TIM3_SR.CC2IF ( -- x addr ) 2 bit TIM3_SR ; \ TIM3_SR.CC2IF, Capture/Compare 2 interrupt               flag
: TIM3_SR.CC1IF ( -- x addr ) 1 bit TIM3_SR ; \ TIM3_SR.CC1IF, Capture/compare 1 interrupt               flag
: TIM3_SR.UIF ( -- x addr ) 0 bit TIM3_SR ; \ TIM3_SR.UIF, Update interrupt flag

\ TIM3_EGR (write-only) Reset:$0000
: TIM3_EGR.TG ( -- x addr ) 6 bit TIM3_EGR ; \ TIM3_EGR.TG, Trigger generation
: TIM3_EGR.CC4G ( -- x addr ) 4 bit TIM3_EGR ; \ TIM3_EGR.CC4G, Capture/compare 4               generation
: TIM3_EGR.CC3G ( -- x addr ) 3 bit TIM3_EGR ; \ TIM3_EGR.CC3G, Capture/compare 3               generation
: TIM3_EGR.CC2G ( -- x addr ) 2 bit TIM3_EGR ; \ TIM3_EGR.CC2G, Capture/compare 2               generation
: TIM3_EGR.CC1G ( -- x addr ) 1 bit TIM3_EGR ; \ TIM3_EGR.CC1G, Capture/compare 1               generation
: TIM3_EGR.UG ( -- x addr ) 0 bit TIM3_EGR ; \ TIM3_EGR.UG, Update generation

\ TIM3_CCMR1_Output (read-write) Reset:$00000000
: TIM3_CCMR1_Output.OC2M_3 ( -- x addr ) 24 bit TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output.OC2M_3, Output Compare 2 mode - bit               3
: TIM3_CCMR1_Output.OC1M_3 ( -- x addr ) 16 bit TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output.OC1M_3, Output Compare 1 mode - bit               3
: TIM3_CCMR1_Output.OC2CE ( -- x addr ) 15 bit TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output.OC2CE, Output compare 2 clear               enable
: TIM3_CCMR1_Output.OC2M ( %bbb -- x addr ) 12 lshift TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output.OC2M, Output compare 2 mode
: TIM3_CCMR1_Output.OC2PE ( -- x addr ) 11 bit TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output.OC2PE, Output compare 2 preload               enable
: TIM3_CCMR1_Output.OC2FE ( -- x addr ) 10 bit TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output.OC2FE, Output compare 2 fast               enable
: TIM3_CCMR1_Output.CC2S ( %bb -- x addr ) 8 lshift TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output.CC2S, Capture/Compare 2               selection
: TIM3_CCMR1_Output.OC1CE ( -- x addr ) 7 bit TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output.OC1CE, Output compare 1 clear               enable
: TIM3_CCMR1_Output.OC1M ( %bbb -- x addr ) 4 lshift TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output.OC1M, Output compare 1 mode
: TIM3_CCMR1_Output.OC1PE ( -- x addr ) 3 bit TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output.OC1PE, Output compare 1 preload               enable
: TIM3_CCMR1_Output.OC1FE ( -- x addr ) 2 bit TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output.OC1FE, Output compare 1 fast               enable
: TIM3_CCMR1_Output.CC1S ( %bb -- x addr ) TIM3_CCMR1_Output ; \ TIM3_CCMR1_Output.CC1S, Capture/Compare 1               selection

\ TIM3_CCMR1_Input (read-write) Reset:$00000000
: TIM3_CCMR1_Input.IC2F ( %bbbb -- x addr ) 12 lshift TIM3_CCMR1_Input ; \ TIM3_CCMR1_Input.IC2F, Input capture 2 filter
: TIM3_CCMR1_Input.IC2PSC ( %bb -- x addr ) 10 lshift TIM3_CCMR1_Input ; \ TIM3_CCMR1_Input.IC2PSC, Input capture 2 prescaler
: TIM3_CCMR1_Input.CC2S ( %bb -- x addr ) 8 lshift TIM3_CCMR1_Input ; \ TIM3_CCMR1_Input.CC2S, Capture/compare 2               selection
: TIM3_CCMR1_Input.IC1F ( %bbbb -- x addr ) 4 lshift TIM3_CCMR1_Input ; \ TIM3_CCMR1_Input.IC1F, Input capture 1 filter
: TIM3_CCMR1_Input.IC1PSC ( %bb -- x addr ) 2 lshift TIM3_CCMR1_Input ; \ TIM3_CCMR1_Input.IC1PSC, Input capture 1 prescaler
: TIM3_CCMR1_Input.CC1S ( %bb -- x addr ) TIM3_CCMR1_Input ; \ TIM3_CCMR1_Input.CC1S, Capture/Compare 1               selection

\ TIM3_CCMR2_Output (read-write) Reset:$00000000
: TIM3_CCMR2_Output.OC4M_3 ( -- x addr ) 24 bit TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output.OC4M_3, Output Compare 4 mode - bit               3
: TIM3_CCMR2_Output.OC3M_3 ( -- x addr ) 16 bit TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output.OC3M_3, Output Compare 3 mode - bit               3
: TIM3_CCMR2_Output.OC4CE ( -- x addr ) 15 bit TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output.OC4CE, Output compare 4 clear               enable
: TIM3_CCMR2_Output.OC4M ( %bbb -- x addr ) 12 lshift TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output.OC4M, Output compare 4 mode
: TIM3_CCMR2_Output.OC4PE ( -- x addr ) 11 bit TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output.OC4PE, Output compare 4 preload               enable
: TIM3_CCMR2_Output.OC4FE ( -- x addr ) 10 bit TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output.OC4FE, Output compare 4 fast               enable
: TIM3_CCMR2_Output.CC4S ( %bb -- x addr ) 8 lshift TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output.CC4S, Capture/Compare 4               selection
: TIM3_CCMR2_Output.OC3CE ( -- x addr ) 7 bit TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output.OC3CE, Output compare 3 clear               enable
: TIM3_CCMR2_Output.OC3M ( %bbb -- x addr ) 4 lshift TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output.OC3M, Output compare 3 mode
: TIM3_CCMR2_Output.OC3PE ( -- x addr ) 3 bit TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output.OC3PE, Output compare 3 preload               enable
: TIM3_CCMR2_Output.OC3FE ( -- x addr ) 2 bit TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output.OC3FE, Output compare 3 fast               enable
: TIM3_CCMR2_Output.CC3S ( %bb -- x addr ) TIM3_CCMR2_Output ; \ TIM3_CCMR2_Output.CC3S, Capture/Compare 3               selection

\ TIM3_CCMR2_Input (read-write) Reset:$00000000
: TIM3_CCMR2_Input.IC4F ( %bbbb -- x addr ) 12 lshift TIM3_CCMR2_Input ; \ TIM3_CCMR2_Input.IC4F, Input capture 4 filter
: TIM3_CCMR2_Input.IC4PSC ( %bb -- x addr ) 10 lshift TIM3_CCMR2_Input ; \ TIM3_CCMR2_Input.IC4PSC, Input capture 4 prescaler
: TIM3_CCMR2_Input.CC4S ( %bb -- x addr ) 8 lshift TIM3_CCMR2_Input ; \ TIM3_CCMR2_Input.CC4S, Capture/Compare 4               selection
: TIM3_CCMR2_Input.IC3F ( %bbbb -- x addr ) 4 lshift TIM3_CCMR2_Input ; \ TIM3_CCMR2_Input.IC3F, Input capture 3 filter
: TIM3_CCMR2_Input.IC3PSC ( %bb -- x addr ) 2 lshift TIM3_CCMR2_Input ; \ TIM3_CCMR2_Input.IC3PSC, Input capture 3 prescaler
: TIM3_CCMR2_Input.CC3S ( %bb -- x addr ) TIM3_CCMR2_Input ; \ TIM3_CCMR2_Input.CC3S, Capture/Compare 3               selection

\ TIM3_CCER (read-write) Reset:$0000
: TIM3_CCER.CC4NP ( -- x addr ) 15 bit TIM3_CCER ; \ TIM3_CCER.CC4NP, Capture/Compare 4 output               Polarity
: TIM3_CCER.CC4P ( -- x addr ) 13 bit TIM3_CCER ; \ TIM3_CCER.CC4P, Capture/Compare 3 output               Polarity
: TIM3_CCER.CC4E ( -- x addr ) 12 bit TIM3_CCER ; \ TIM3_CCER.CC4E, Capture/Compare 4 output               enable
: TIM3_CCER.CC3NP ( -- x addr ) 11 bit TIM3_CCER ; \ TIM3_CCER.CC3NP, Capture/Compare 3 output               Polarity
: TIM3_CCER.CC3P ( -- x addr ) 9 bit TIM3_CCER ; \ TIM3_CCER.CC3P, Capture/Compare 3 output               Polarity
: TIM3_CCER.CC3E ( -- x addr ) 8 bit TIM3_CCER ; \ TIM3_CCER.CC3E, Capture/Compare 3 output               enable
: TIM3_CCER.CC2NP ( -- x addr ) 7 bit TIM3_CCER ; \ TIM3_CCER.CC2NP, Capture/Compare 2 output               Polarity
: TIM3_CCER.CC2P ( -- x addr ) 5 bit TIM3_CCER ; \ TIM3_CCER.CC2P, Capture/Compare 2 output               Polarity
: TIM3_CCER.CC2E ( -- x addr ) 4 bit TIM3_CCER ; \ TIM3_CCER.CC2E, Capture/Compare 2 output               enable
: TIM3_CCER.CC1NP ( -- x addr ) 3 bit TIM3_CCER ; \ TIM3_CCER.CC1NP, Capture/Compare 1 output               Polarity
: TIM3_CCER.CC1P ( -- x addr ) 1 bit TIM3_CCER ; \ TIM3_CCER.CC1P, Capture/Compare 1 output               Polarity
: TIM3_CCER.CC1E ( -- x addr ) 0 bit TIM3_CCER ; \ TIM3_CCER.CC1E, Capture/Compare 1 output               enable

\ TIM3_CNT (read-write) Reset:$00000000
: TIM3_CNT.CNT_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM3_CNT ; \ TIM3_CNT.CNT_H, High counter value (TIM2               only)
: TIM3_CNT.CNT_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3_CNT ; \ TIM3_CNT.CNT_L, Low counter value

\ TIM3_PSC (read-write) Reset:$0000
: TIM3_PSC.PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3_PSC ; \ TIM3_PSC.PSC, Prescaler value

\ TIM3_ARR (read-write) Reset:$00000000
: TIM3_ARR.ARR_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM3_ARR ; \ TIM3_ARR.ARR_H, High Auto-reload value (TIM2               only)
: TIM3_ARR.ARR_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3_ARR ; \ TIM3_ARR.ARR_L, Low Auto-reload value

\ TIM3_CCR1 (read-write) Reset:$00000000
: TIM3_CCR1.CCR1_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM3_CCR1 ; \ TIM3_CCR1.CCR1_H, High Capture/Compare 1 value (TIM2               only)
: TIM3_CCR1.CCR1_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3_CCR1 ; \ TIM3_CCR1.CCR1_L, Low Capture/Compare 1               value

\ TIM3_CCR2 (read-write) Reset:$00000000
: TIM3_CCR2.CCR2_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM3_CCR2 ; \ TIM3_CCR2.CCR2_H, High Capture/Compare 2 value (TIM2               only)
: TIM3_CCR2.CCR2_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3_CCR2 ; \ TIM3_CCR2.CCR2_L, Low Capture/Compare 2               value

\ TIM3_CCR3 (read-write) Reset:$00000000
: TIM3_CCR3.CCR3_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM3_CCR3 ; \ TIM3_CCR3.CCR3_H, High Capture/Compare value (TIM2               only)
: TIM3_CCR3.CCR3_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3_CCR3 ; \ TIM3_CCR3.CCR3_L, Low Capture/Compare value

\ TIM3_CCR4 (read-write) Reset:$00000000
: TIM3_CCR4.CCR4_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM3_CCR4 ; \ TIM3_CCR4.CCR4_H, High Capture/Compare value (TIM2               only)
: TIM3_CCR4.CCR4_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3_CCR4 ; \ TIM3_CCR4.CCR4_L, Low Capture/Compare value

\ TIM3_DCR (read-write) Reset:$0000
: TIM3_DCR.DBL ( %bbbbb -- x addr ) 8 lshift TIM3_DCR ; \ TIM3_DCR.DBL, DMA burst length
: TIM3_DCR.DBA ( %bbbbb -- x addr ) TIM3_DCR ; \ TIM3_DCR.DBA, DMA base address

\ TIM3_DMAR (read-write) Reset:$0000
: TIM3_DMAR.DMAB ( %bbbbbbbbbbbbbbbb -- x addr ) TIM3_DMAR ; \ TIM3_DMAR.DMAB, DMA register for burst               accesses

\ TIM3_OR1 (read-write) Reset:$0000
: TIM3_OR1.IOCREF_CLR ( -- x addr ) 0 bit TIM3_OR1 ; \ TIM3_OR1.IOCREF_CLR, IOCREF_CLR

\ TIM3_AF1 (read-write) Reset:$0000
: TIM3_AF1.ETRSEL ( %bbbb -- x addr ) 14 lshift TIM3_AF1 ; \ TIM3_AF1.ETRSEL, External trigger source               selection

\ TIM3_TISEL (read-write) Reset:$0000
: TIM3_TISEL.TI1SEL ( %bbbb -- x addr ) TIM3_TISEL ; \ TIM3_TISEL.TI1SEL, TI1SEL
: TIM3_TISEL.TI2SEL ( %bbbb -- x addr ) 8 lshift TIM3_TISEL ; \ TIM3_TISEL.TI2SEL, TI2SEL

\ NVIC_ISER (read-write) Reset:$00000000
: NVIC_ISER.SETENA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) NVIC_ISER ; \ NVIC_ISER.SETENA, SETENA

\ NVIC_ICER (read-write) Reset:$00000000
: NVIC_ICER.CLRENA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) NVIC_ICER ; \ NVIC_ICER.CLRENA, CLRENA

\ NVIC_ISPR (read-write) Reset:$00000000
: NVIC_ISPR.SETPEND ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) NVIC_ISPR ; \ NVIC_ISPR.SETPEND, SETPEND

\ NVIC_ICPR (read-write) Reset:$00000000
: NVIC_ICPR.CLRPEND ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) NVIC_ICPR ; \ NVIC_ICPR.CLRPEND, CLRPEND

\ NVIC_IPR0 (read-write) Reset:$00000000
: NVIC_IPR0.PRI_0 ( %bbbbbbbb -- x addr ) NVIC_IPR0 ; \ NVIC_IPR0.PRI_0, priority for interrupt 0
: NVIC_IPR0.PRI_1 ( %bbbbbbbb -- x addr ) 8 lshift NVIC_IPR0 ; \ NVIC_IPR0.PRI_1, priority for interrupt 1
: NVIC_IPR0.PRI_2 ( %bbbbbbbb -- x addr ) 16 lshift NVIC_IPR0 ; \ NVIC_IPR0.PRI_2, priority for interrupt 2
: NVIC_IPR0.PRI_3 ( %bbbbbbbb -- x addr ) 24 lshift NVIC_IPR0 ; \ NVIC_IPR0.PRI_3, priority for interrupt 3

\ NVIC_IPR1 (read-write) Reset:$00000000
: NVIC_IPR1.PRI_4 ( %bbbbbbbb -- x addr ) NVIC_IPR1 ; \ NVIC_IPR1.PRI_4, priority for interrupt n
: NVIC_IPR1.PRI_5 ( %bbbbbbbb -- x addr ) 8 lshift NVIC_IPR1 ; \ NVIC_IPR1.PRI_5, priority for interrupt n
: NVIC_IPR1.PRI_6 ( %bbbbbbbb -- x addr ) 16 lshift NVIC_IPR1 ; \ NVIC_IPR1.PRI_6, priority for interrupt n
: NVIC_IPR1.PRI_7 ( %bbbbbbbb -- x addr ) 24 lshift NVIC_IPR1 ; \ NVIC_IPR1.PRI_7, priority for interrupt n

\ NVIC_IPR2 (read-write) Reset:$00000000
: NVIC_IPR2.PRI_8 ( %bbbbbbbb -- x addr ) NVIC_IPR2 ; \ NVIC_IPR2.PRI_8, priority for interrupt n
: NVIC_IPR2.PRI_9 ( %bbbbbbbb -- x addr ) 8 lshift NVIC_IPR2 ; \ NVIC_IPR2.PRI_9, priority for interrupt n
: NVIC_IPR2.PRI_10 ( %bbbbbbbb -- x addr ) 16 lshift NVIC_IPR2 ; \ NVIC_IPR2.PRI_10, priority for interrupt n
: NVIC_IPR2.PRI_11 ( %bbbbbbbb -- x addr ) 24 lshift NVIC_IPR2 ; \ NVIC_IPR2.PRI_11, priority for interrupt n

\ NVIC_IPR3 (read-write) Reset:$00000000
: NVIC_IPR3.PRI_12 ( %bbbbbbbb -- x addr ) NVIC_IPR3 ; \ NVIC_IPR3.PRI_12, priority for interrupt n
: NVIC_IPR3.PRI_13 ( %bbbbbbbb -- x addr ) 8 lshift NVIC_IPR3 ; \ NVIC_IPR3.PRI_13, priority for interrupt n
: NVIC_IPR3.PRI_14 ( %bbbbbbbb -- x addr ) 16 lshift NVIC_IPR3 ; \ NVIC_IPR3.PRI_14, priority for interrupt n
: NVIC_IPR3.PRI_15 ( %bbbbbbbb -- x addr ) 24 lshift NVIC_IPR3 ; \ NVIC_IPR3.PRI_15, priority for interrupt n

\ NVIC_IPR4 (read-write) Reset:$00000000
: NVIC_IPR4.PRI_16 ( %bbbbbbbb -- x addr ) NVIC_IPR4 ; \ NVIC_IPR4.PRI_16, priority for interrupt n
: NVIC_IPR4.PRI_17 ( %bbbbbbbb -- x addr ) 8 lshift NVIC_IPR4 ; \ NVIC_IPR4.PRI_17, priority for interrupt n
: NVIC_IPR4.PRI_18 ( %bbbbbbbb -- x addr ) 16 lshift NVIC_IPR4 ; \ NVIC_IPR4.PRI_18, priority for interrupt n
: NVIC_IPR4.PRI_19 ( %bbbbbbbb -- x addr ) 24 lshift NVIC_IPR4 ; \ NVIC_IPR4.PRI_19, priority for interrupt n

\ NVIC_IPR5 (read-write) Reset:$00000000
: NVIC_IPR5.PRI_20 ( %bbbbbbbb -- x addr ) NVIC_IPR5 ; \ NVIC_IPR5.PRI_20, priority for interrupt n
: NVIC_IPR5.PRI_21 ( %bbbbbbbb -- x addr ) 8 lshift NVIC_IPR5 ; \ NVIC_IPR5.PRI_21, priority for interrupt n
: NVIC_IPR5.PRI_22 ( %bbbbbbbb -- x addr ) 16 lshift NVIC_IPR5 ; \ NVIC_IPR5.PRI_22, priority for interrupt n
: NVIC_IPR5.PRI_23 ( %bbbbbbbb -- x addr ) 24 lshift NVIC_IPR5 ; \ NVIC_IPR5.PRI_23, priority for interrupt n

\ NVIC_IPR6 (read-write) Reset:$00000000
: NVIC_IPR6.PRI_24 ( %bbbbbbbb -- x addr ) NVIC_IPR6 ; \ NVIC_IPR6.PRI_24, priority for interrupt n
: NVIC_IPR6.PRI_25 ( %bbbbbbbb -- x addr ) 8 lshift NVIC_IPR6 ; \ NVIC_IPR6.PRI_25, priority for interrupt n
: NVIC_IPR6.PRI_26 ( %bbbbbbbb -- x addr ) 16 lshift NVIC_IPR6 ; \ NVIC_IPR6.PRI_26, priority for interrupt n
: NVIC_IPR6.PRI_27 ( %bbbbbbbb -- x addr ) 24 lshift NVIC_IPR6 ; \ NVIC_IPR6.PRI_27, priority for interrupt n

\ NVIC_IPR7 (read-write) Reset:$00000000
: NVIC_IPR7.PRI_28 ( %bbbbbbbb -- x addr ) NVIC_IPR7 ; \ NVIC_IPR7.PRI_28, priority for interrupt n
: NVIC_IPR7.PRI_29 ( %bbbbbbbb -- x addr ) 8 lshift NVIC_IPR7 ; \ NVIC_IPR7.PRI_29, priority for interrupt n
: NVIC_IPR7.PRI_30 ( %bbbbbbbb -- x addr ) 16 lshift NVIC_IPR7 ; \ NVIC_IPR7.PRI_30, priority for interrupt n
: NVIC_IPR7.PRI_31 ( %bbbbbbbb -- x addr ) 24 lshift NVIC_IPR7 ; \ NVIC_IPR7.PRI_31, priority for interrupt n

\ NVIC_IPR8 (read-write) Reset:$00000000

\ MPU_MPU_TYPER (read-only) Reset:0X00000800
: MPU_MPU_TYPER.SEPARATE? ( --  1|0 ) 0 bit MPU_MPU_TYPER bit@ ; \ MPU_MPU_TYPER.SEPARATE, Separate flag
: MPU_MPU_TYPER.DREGION? ( --  x ) 8 lshift MPU_MPU_TYPER @ ; \ MPU_MPU_TYPER.DREGION, Number of MPU data regions
: MPU_MPU_TYPER.IREGION? ( --  x ) 16 lshift MPU_MPU_TYPER @ ; \ MPU_MPU_TYPER.IREGION, Number of MPU instruction               regions

\ MPU_MPU_CTRL (read-only) Reset:0X00000000
: MPU_MPU_CTRL.ENABLE? ( --  1|0 ) 0 bit MPU_MPU_CTRL bit@ ; \ MPU_MPU_CTRL.ENABLE, Enables the MPU
: MPU_MPU_CTRL.HFNMIENA? ( --  1|0 ) 1 bit MPU_MPU_CTRL bit@ ; \ MPU_MPU_CTRL.HFNMIENA, Enables the operation of MPU during hard               fault
: MPU_MPU_CTRL.PRIVDEFENA? ( --  1|0 ) 2 bit MPU_MPU_CTRL bit@ ; \ MPU_MPU_CTRL.PRIVDEFENA, Enable priviliged software access to               default memory map

\ MPU_MPU_RNR (read-write) Reset:0X00000000
: MPU_MPU_RNR.REGION ( %bbbbbbbb -- x addr ) MPU_MPU_RNR ; \ MPU_MPU_RNR.REGION, MPU region

\ MPU_MPU_RBAR (read-write) Reset:0X00000000
: MPU_MPU_RBAR.REGION ( %bbbb -- x addr ) MPU_MPU_RBAR ; \ MPU_MPU_RBAR.REGION, MPU region field
: MPU_MPU_RBAR.VALID ( -- x addr ) 4 bit MPU_MPU_RBAR ; \ MPU_MPU_RBAR.VALID, MPU region number valid
: MPU_MPU_RBAR.ADDR x addr ) 5 lshift MPU_MPU_RBAR ; \ MPU_MPU_RBAR.ADDR, Region base address field

\ MPU_MPU_RASR (read-write) Reset:0X00000000
: MPU_MPU_RASR.ENABLE ( -- x addr ) 0 bit MPU_MPU_RASR ; \ MPU_MPU_RASR.ENABLE, Region enable bit.
: MPU_MPU_RASR.SIZE ( %bbbbb -- x addr ) 1 lshift MPU_MPU_RASR ; \ MPU_MPU_RASR.SIZE, Size of the MPU protection               region
: MPU_MPU_RASR.SRD ( %bbbbbbbb -- x addr ) 8 lshift MPU_MPU_RASR ; \ MPU_MPU_RASR.SRD, Subregion disable bits
: MPU_MPU_RASR.B ( -- x addr ) 16 bit MPU_MPU_RASR ; \ MPU_MPU_RASR.B, memory attribute
: MPU_MPU_RASR.C ( -- x addr ) 17 bit MPU_MPU_RASR ; \ MPU_MPU_RASR.C, memory attribute
: MPU_MPU_RASR.S ( -- x addr ) 18 bit MPU_MPU_RASR ; \ MPU_MPU_RASR.S, Shareable memory attribute
: MPU_MPU_RASR.TEX ( %bbb -- x addr ) 19 lshift MPU_MPU_RASR ; \ MPU_MPU_RASR.TEX, memory attribute
: MPU_MPU_RASR.AP ( %bbb -- x addr ) 24 lshift MPU_MPU_RASR ; \ MPU_MPU_RASR.AP, Access permission
: MPU_MPU_RASR.XN ( -- x addr ) 28 bit MPU_MPU_RASR ; \ MPU_MPU_RASR.XN, Instruction access disable               bit

\ STK_CSR (read-write) Reset:0X00000000
: STK_CSR.ENABLE ( -- x addr ) 0 bit STK_CSR ; \ STK_CSR.ENABLE, Counter enable
: STK_CSR.TICKINT ( -- x addr ) 1 bit STK_CSR ; \ STK_CSR.TICKINT, SysTick exception request               enable
: STK_CSR.CLKSOURCE ( -- x addr ) 2 bit STK_CSR ; \ STK_CSR.CLKSOURCE, Clock source selection
: STK_CSR.COUNTFLAG ( -- x addr ) 16 bit STK_CSR ; \ STK_CSR.COUNTFLAG, COUNTFLAG

\ STK_RVR (read-write) Reset:0X00000000
: STK_RVR.RELOAD ( %bbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) STK_RVR ; \ STK_RVR.RELOAD, RELOAD value

\ STK_CVR (read-write) Reset:0X00000000
: STK_CVR.CURRENT ( %bbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) STK_CVR ; \ STK_CVR.CURRENT, Current counter value

\ STK_CALIB (read-write) Reset:0X00000000
: STK_CALIB.TENMS ( %bbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) STK_CALIB ; \ STK_CALIB.TENMS, Calibration value
: STK_CALIB.SKEW ( -- x addr ) 30 bit STK_CALIB ; \ STK_CALIB.SKEW, SKEW flag: Indicates whether the TENMS               value is exact
: STK_CALIB.NOREF ( -- x addr ) 31 bit STK_CALIB ; \ STK_CALIB.NOREF, NOREF flag. Reads as zero

\ SCB_CPUID (read-only) Reset:$410FC241
: SCB_CPUID.Revision? ( --  x ) SCB_CPUID @ ; \ SCB_CPUID.Revision, Revision number
: SCB_CPUID.PartNo? ( --  x ) 4 lshift SCB_CPUID @ ; \ SCB_CPUID.PartNo, Part number of the               processor
: SCB_CPUID.Architecture? ( --  x ) 16 lshift SCB_CPUID @ ; \ SCB_CPUID.Architecture, Reads as $F
: SCB_CPUID.Variant? ( --  x ) 20 lshift SCB_CPUID @ ; \ SCB_CPUID.Variant, Variant number
: SCB_CPUID.Implementer? ( --  x ) 24 lshift SCB_CPUID @ ; \ SCB_CPUID.Implementer, Implementer code

\ SCB_ICSR (read-write) Reset:$00000000
: SCB_ICSR.VECTACTIVE ( %bbbbbbbbb -- x addr ) SCB_ICSR ; \ SCB_ICSR.VECTACTIVE, Active vector
: SCB_ICSR.RETTOBASE ( -- x addr ) 11 bit SCB_ICSR ; \ SCB_ICSR.RETTOBASE, Return to base level
: SCB_ICSR.VECTPENDING ( %bbbbbbb -- x addr ) 12 lshift SCB_ICSR ; \ SCB_ICSR.VECTPENDING, Pending vector
: SCB_ICSR.ISRPENDING ( -- x addr ) 22 bit SCB_ICSR ; \ SCB_ICSR.ISRPENDING, Interrupt pending flag
: SCB_ICSR.PENDSTCLR ( -- x addr ) 25 bit SCB_ICSR ; \ SCB_ICSR.PENDSTCLR, SysTick exception clear-pending               bit
: SCB_ICSR.PENDSTSET ( -- x addr ) 26 bit SCB_ICSR ; \ SCB_ICSR.PENDSTSET, SysTick exception set-pending               bit
: SCB_ICSR.PENDSVCLR ( -- x addr ) 27 bit SCB_ICSR ; \ SCB_ICSR.PENDSVCLR, PendSV clear-pending bit
: SCB_ICSR.PENDSVSET ( -- x addr ) 28 bit SCB_ICSR ; \ SCB_ICSR.PENDSVSET, PendSV set-pending bit
: SCB_ICSR.NMIPENDSET ( -- x addr ) 31 bit SCB_ICSR ; \ SCB_ICSR.NMIPENDSET, NMI set-pending bit.

\ SCB_VTOR (read-write) Reset:$00000000
: SCB_VTOR.TBLOFF x addr ) 7 lshift SCB_VTOR ; \ SCB_VTOR.TBLOFF, Vector table base offset               field

\ SCB_AIRCR (read-write) Reset:$00000000
: SCB_AIRCR.VECTCLRACTIVE ( -- x addr ) 1 bit SCB_AIRCR ; \ SCB_AIRCR.VECTCLRACTIVE, VECTCLRACTIVE
: SCB_AIRCR.SYSRESETREQ ( -- x addr ) 2 bit SCB_AIRCR ; \ SCB_AIRCR.SYSRESETREQ, SYSRESETREQ
: SCB_AIRCR.ENDIANESS ( -- x addr ) 15 bit SCB_AIRCR ; \ SCB_AIRCR.ENDIANESS, ENDIANESS
: SCB_AIRCR.VECTKEYSTAT ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift SCB_AIRCR ; \ SCB_AIRCR.VECTKEYSTAT, Register key

\ SCB_SCR (read-write) Reset:$00000000
: SCB_SCR.SLEEPONEXIT ( -- x addr ) 1 bit SCB_SCR ; \ SCB_SCR.SLEEPONEXIT, SLEEPONEXIT
: SCB_SCR.SLEEPDEEP ( -- x addr ) 2 bit SCB_SCR ; \ SCB_SCR.SLEEPDEEP, SLEEPDEEP
: SCB_SCR.SEVEONPEND ( -- x addr ) 4 bit SCB_SCR ; \ SCB_SCR.SEVEONPEND, Send Event on Pending bit

\ SCB_CCR (read-write) Reset:$00000000
: SCB_CCR.NONBASETHRDENA ( -- x addr ) 0 bit SCB_CCR ; \ SCB_CCR.NONBASETHRDENA, Configures how the processor enters               Thread mode
: SCB_CCR.USERSETMPEND ( -- x addr ) 1 bit SCB_CCR ; \ SCB_CCR.USERSETMPEND, USERSETMPEND
: SCB_CCR.UNALIGN__TRP ( -- x addr ) 3 bit SCB_CCR ; \ SCB_CCR.UNALIGN__TRP, UNALIGN_ TRP
: SCB_CCR.DIV_0_TRP ( -- x addr ) 4 bit SCB_CCR ; \ SCB_CCR.DIV_0_TRP, DIV_0_TRP
: SCB_CCR.BFHFNMIGN ( -- x addr ) 8 bit SCB_CCR ; \ SCB_CCR.BFHFNMIGN, BFHFNMIGN
: SCB_CCR.STKALIGN ( -- x addr ) 9 bit SCB_CCR ; \ SCB_CCR.STKALIGN, STKALIGN

\ SCB_SHPR2 (read-write) Reset:$00000000
: SCB_SHPR2.PRI_11 ( %bbbbbbbb -- x addr ) 24 lshift SCB_SHPR2 ; \ SCB_SHPR2.PRI_11, Priority of system handler               11

\ SCB_SHPR3 (read-write) Reset:$00000000
: SCB_SHPR3.PRI_14 ( %bbbbbbbb -- x addr ) 16 lshift SCB_SHPR3 ; \ SCB_SHPR3.PRI_14, Priority of system handler               14
: SCB_SHPR3.PRI_15 ( %bbbbbbbb -- x addr ) 24 lshift SCB_SHPR3 ; \ SCB_SHPR3.PRI_15, Priority of system handler               15

\ VREFBUF_CSR (multiple-access)  Reset:$00000002
: VREFBUF_CSR.ENVR ( -- x addr ) 0 bit VREFBUF_CSR ; \ VREFBUF_CSR.ENVR, Voltage reference buffer mode enable               This bit is used to enable the voltage reference               buffer mode.
: VREFBUF_CSR.HIZ ( -- x addr ) 1 bit VREFBUF_CSR ; \ VREFBUF_CSR.HIZ, High impedance mode This bit controls               the analog switch to connect or not the VREF+ pin.               Refer to Table196: VREF buffer modes for the mode               descriptions depending on ENVR bit               configuration.
: VREFBUF_CSR.VRR ( -- x addr ) 3 bit VREFBUF_CSR ; \ VREFBUF_CSR.VRR, Voltage reference buffer               ready
: VREFBUF_CSR.VRS ( %bbb -- x addr ) 4 lshift VREFBUF_CSR ; \ VREFBUF_CSR.VRS, Voltage reference scale These bits               select the value generated by the voltage reference               buffer. Other: Reserved

\ VREFBUF_CCR (read-write) Reset:$00000000
: VREFBUF_CCR.TRIM ( %bbbbbb -- x addr ) VREFBUF_CCR ; \ VREFBUF_CCR.TRIM, Trimming code These bits are               automatically initialized after reset with the               trimming value stored in the Flash memory during the               production test. Writing into these bits allows to               tune the internal reference buffer               voltage.

\ DBG_IDCODE (read-only) Reset:$00000000
: DBG_IDCODE.DEV_ID? ( --  x ) DBG_IDCODE @ ; \ DBG_IDCODE.DEV_ID, Device identifier
: DBG_IDCODE.REV_ID? ( --  x ) 16 lshift DBG_IDCODE @ ; \ DBG_IDCODE.REV_ID, Revision identifie

\ DBG_CR (read-write) Reset:$00000000
: DBG_CR.DBG_STOP ( -- x addr ) 1 bit DBG_CR ; \ DBG_CR.DBG_STOP, Debug Stop mode
: DBG_CR.DBG_STANDBY ( -- x addr ) 2 bit DBG_CR ; \ DBG_CR.DBG_STANDBY, Debug Standby mode

\ DBG_APB_FZ1 (read-write) Reset:$00000000
: DBG_APB_FZ1.DBG_TIM2_STOP ( -- x addr ) 0 bit DBG_APB_FZ1 ; \ DBG_APB_FZ1.DBG_TIM2_STOP, TIM2 counter stopped when core is               halted
: DBG_APB_FZ1.DBG_TIM3_STOP ( -- x addr ) 1 bit DBG_APB_FZ1 ; \ DBG_APB_FZ1.DBG_TIM3_STOP, TIM3 counter stopped when core is               halted
: DBG_APB_FZ1.DBG_RTC_STOP ( -- x addr ) 10 bit DBG_APB_FZ1 ; \ DBG_APB_FZ1.DBG_RTC_STOP, RTC counter stopped when core is               halted
: DBG_APB_FZ1.DBG_WWDG_STOP ( -- x addr ) 11 bit DBG_APB_FZ1 ; \ DBG_APB_FZ1.DBG_WWDG_STOP, Window watchdog counter stopped when               core is halted
: DBG_APB_FZ1.DBG_IWDG_STOP ( -- x addr ) 12 bit DBG_APB_FZ1 ; \ DBG_APB_FZ1.DBG_IWDG_STOP, Independent watchdog counter stopped               when core is halted
: DBG_APB_FZ1.DBG_I2C1_STOP ( -- x addr ) 21 bit DBG_APB_FZ1 ; \ DBG_APB_FZ1.DBG_I2C1_STOP, I2C1 SMBUS timeout counter stopped when               core is halted

\ DBG_APB_FZ2 (read-write) Reset:$00000000
: DBG_APB_FZ2.DBG_TIM1_STOP ( -- x addr ) 11 bit DBG_APB_FZ2 ; \ DBG_APB_FZ2.DBG_TIM1_STOP, TIM1 counter stopped when core is               halted
: DBG_APB_FZ2.DBG_TIM14_STOP ( -- x addr ) 15 bit DBG_APB_FZ2 ; \ DBG_APB_FZ2.DBG_TIM14_STOP, DBG_TIM14_STOP
: DBG_APB_FZ2.DBG_TIM16_STOP ( -- x addr ) 17 bit DBG_APB_FZ2 ; \ DBG_APB_FZ2.DBG_TIM16_STOP, DBG_TIM16_STOP
: DBG_APB_FZ2.DBG_TIM17_STOP ( -- x addr ) 18 bit DBG_APB_FZ2 ; \ DBG_APB_FZ2.DBG_TIM17_STOP, DBG_TIM17_STOP

\ NVIC_STIR_STIR (read-write) Reset:$00000000
: NVIC_STIR_STIR.INTID ( %bbbbbbbbb -- x addr ) NVIC_STIR_STIR ; \ NVIC_STIR_STIR.INTID, Software generated interrupt               ID

\ SCB_ACTRL_ACTRL (read-write) Reset:$00000000
: SCB_ACTRL_ACTRL.DISMCYCINT ( -- x addr ) 0 bit SCB_ACTRL_ACTRL ; \ SCB_ACTRL_ACTRL.DISMCYCINT, DISMCYCINT
: SCB_ACTRL_ACTRL.DISDEFWBUF ( -- x addr ) 1 bit SCB_ACTRL_ACTRL ; \ SCB_ACTRL_ACTRL.DISDEFWBUF, DISDEFWBUF
: SCB_ACTRL_ACTRL.DISFOLD ( -- x addr ) 2 bit SCB_ACTRL_ACTRL ; \ SCB_ACTRL_ACTRL.DISFOLD, DISFOLD
: SCB_ACTRL_ACTRL.DISFPCA ( -- x addr ) 8 bit SCB_ACTRL_ACTRL ; \ SCB_ACTRL_ACTRL.DISFPCA, DISFPCA
: SCB_ACTRL_ACTRL.DISOOFP ( -- x addr ) 9 bit SCB_ACTRL_ACTRL ; \ SCB_ACTRL_ACTRL.DISOOFP, DISOOFP

\ FPU_CPACR_CPACR (read-write) Reset:$0000000
: FPU_CPACR_CPACR.CP ( %bbbb -- x addr ) 20 lshift FPU_CPACR_CPACR ; \ FPU_CPACR_CPACR.CP, CP

\ FPU_FPCCR (read-write) Reset:$00000000
: FPU_FPCCR.LSPACT ( -- x addr ) 0 bit FPU_FPCCR ; \ FPU_FPCCR.LSPACT, LSPACT
: FPU_FPCCR.USER ( -- x addr ) 1 bit FPU_FPCCR ; \ FPU_FPCCR.USER, USER
: FPU_FPCCR.THREAD ( -- x addr ) 3 bit FPU_FPCCR ; \ FPU_FPCCR.THREAD, THREAD
: FPU_FPCCR.HFRDY ( -- x addr ) 4 bit FPU_FPCCR ; \ FPU_FPCCR.HFRDY, HFRDY
: FPU_FPCCR.MMRDY ( -- x addr ) 5 bit FPU_FPCCR ; \ FPU_FPCCR.MMRDY, MMRDY
: FPU_FPCCR.BFRDY ( -- x addr ) 6 bit FPU_FPCCR ; \ FPU_FPCCR.BFRDY, BFRDY
: FPU_FPCCR.MONRDY ( -- x addr ) 8 bit FPU_FPCCR ; \ FPU_FPCCR.MONRDY, MONRDY
: FPU_FPCCR.LSPEN ( -- x addr ) 30 bit FPU_FPCCR ; \ FPU_FPCCR.LSPEN, LSPEN
: FPU_FPCCR.ASPEN ( -- x addr ) 31 bit FPU_FPCCR ; \ FPU_FPCCR.ASPEN, ASPEN

\ FPU_FPCAR (read-write) Reset:$00000000
: FPU_FPCAR.ADDRESS x addr ) 3 lshift FPU_FPCAR ; \ FPU_FPCAR.ADDRESS, Location of unpopulated               floating-point

\ FPU_FPSCR (read-write) Reset:$00000000
: FPU_FPSCR.IOC ( -- x addr ) 0 bit FPU_FPSCR ; \ FPU_FPSCR.IOC, Invalid operation cumulative exception               bit
: FPU_FPSCR.DZC ( -- x addr ) 1 bit FPU_FPSCR ; \ FPU_FPSCR.DZC, Division by zero cumulative exception               bit.
: FPU_FPSCR.OFC ( -- x addr ) 2 bit FPU_FPSCR ; \ FPU_FPSCR.OFC, Overflow cumulative exception               bit
: FPU_FPSCR.UFC ( -- x addr ) 3 bit FPU_FPSCR ; \ FPU_FPSCR.UFC, Underflow cumulative exception               bit
: FPU_FPSCR.IXC ( -- x addr ) 4 bit FPU_FPSCR ; \ FPU_FPSCR.IXC, Inexact cumulative exception               bit
: FPU_FPSCR.IDC ( -- x addr ) 7 bit FPU_FPSCR ; \ FPU_FPSCR.IDC, Input denormal cumulative exception               bit.
: FPU_FPSCR.RMode ( %bb -- x addr ) 22 lshift FPU_FPSCR ; \ FPU_FPSCR.RMode, Rounding Mode control               field
: FPU_FPSCR.FZ ( -- x addr ) 24 bit FPU_FPSCR ; \ FPU_FPSCR.FZ, Flush-to-zero mode control               bit:
: FPU_FPSCR.DN ( -- x addr ) 25 bit FPU_FPSCR ; \ FPU_FPSCR.DN, Default NaN mode control               bit
: FPU_FPSCR.AHP ( -- x addr ) 26 bit FPU_FPSCR ; \ FPU_FPSCR.AHP, Alternative half-precision control               bit
: FPU_FPSCR.V ( -- x addr ) 28 bit FPU_FPSCR ; \ FPU_FPSCR.V, Overflow condition code               flag
: FPU_FPSCR.C ( -- x addr ) 29 bit FPU_FPSCR ; \ FPU_FPSCR.C, Carry condition code flag
: FPU_FPSCR.Z ( -- x addr ) 30 bit FPU_FPSCR ; \ FPU_FPSCR.Z, Zero condition code flag
: FPU_FPSCR.N ( -- x addr ) 31 bit FPU_FPSCR ; \ FPU_FPSCR.N, Negative condition code               flag

\ SYSCFG_ITLINE_ITLINE0 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE0.WWDG? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE0 bit@ ; \ SYSCFG_ITLINE_ITLINE0.WWDG, Window watchdog interrupt pending               flag

\ SYSCFG_ITLINE_ITLINE1 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE1.PVDOUT? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE1 bit@ ; \ SYSCFG_ITLINE_ITLINE1.PVDOUT, PVD supply monitoring interrupt request               pending (EXTI line 16).

\ SYSCFG_ITLINE_ITLINE2 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE2.TAMP? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE2 bit@ ; \ SYSCFG_ITLINE_ITLINE2.TAMP, TAMP
: SYSCFG_ITLINE_ITLINE2.RTC? ( --  1|0 ) 1 bit SYSCFG_ITLINE_ITLINE2 bit@ ; \ SYSCFG_ITLINE_ITLINE2.RTC, RTC

\ SYSCFG_ITLINE_ITLINE3 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE3.FLASH_ITF? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE3 bit@ ; \ SYSCFG_ITLINE_ITLINE3.FLASH_ITF, FLASH_ITF
: SYSCFG_ITLINE_ITLINE3.FLASH_ECC? ( --  1|0 ) 1 bit SYSCFG_ITLINE_ITLINE3 bit@ ; \ SYSCFG_ITLINE_ITLINE3.FLASH_ECC, FLASH_ECC

\ SYSCFG_ITLINE_ITLINE4 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE4.RCC? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE4 bit@ ; \ SYSCFG_ITLINE_ITLINE4.RCC, RCC

\ SYSCFG_ITLINE_ITLINE5 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE5.EXTI0? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE5 bit@ ; \ SYSCFG_ITLINE_ITLINE5.EXTI0, EXTI0
: SYSCFG_ITLINE_ITLINE5.EXTI1? ( --  1|0 ) 1 bit SYSCFG_ITLINE_ITLINE5 bit@ ; \ SYSCFG_ITLINE_ITLINE5.EXTI1, EXTI1

\ SYSCFG_ITLINE_ITLINE6 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE6.EXTI2? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE6 bit@ ; \ SYSCFG_ITLINE_ITLINE6.EXTI2, EXTI2
: SYSCFG_ITLINE_ITLINE6.EXTI3? ( --  1|0 ) 1 bit SYSCFG_ITLINE_ITLINE6 bit@ ; \ SYSCFG_ITLINE_ITLINE6.EXTI3, EXTI3

\ SYSCFG_ITLINE_ITLINE7 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE7.EXTI4? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE7 bit@ ; \ SYSCFG_ITLINE_ITLINE7.EXTI4, EXTI4
: SYSCFG_ITLINE_ITLINE7.EXTI5? ( --  1|0 ) 1 bit SYSCFG_ITLINE_ITLINE7 bit@ ; \ SYSCFG_ITLINE_ITLINE7.EXTI5, EXTI5
: SYSCFG_ITLINE_ITLINE7.EXTI6? ( --  1|0 ) 2 bit SYSCFG_ITLINE_ITLINE7 bit@ ; \ SYSCFG_ITLINE_ITLINE7.EXTI6, EXTI6
: SYSCFG_ITLINE_ITLINE7.EXTI7? ( --  1|0 ) 3 bit SYSCFG_ITLINE_ITLINE7 bit@ ; \ SYSCFG_ITLINE_ITLINE7.EXTI7, EXTI7
: SYSCFG_ITLINE_ITLINE7.EXTI8? ( --  1|0 ) 4 bit SYSCFG_ITLINE_ITLINE7 bit@ ; \ SYSCFG_ITLINE_ITLINE7.EXTI8, EXTI8
: SYSCFG_ITLINE_ITLINE7.EXTI9? ( --  1|0 ) 5 bit SYSCFG_ITLINE_ITLINE7 bit@ ; \ SYSCFG_ITLINE_ITLINE7.EXTI9, EXTI9
: SYSCFG_ITLINE_ITLINE7.EXTI10? ( --  1|0 ) 6 bit SYSCFG_ITLINE_ITLINE7 bit@ ; \ SYSCFG_ITLINE_ITLINE7.EXTI10, EXTI10
: SYSCFG_ITLINE_ITLINE7.EXTI11? ( --  1|0 ) 7 bit SYSCFG_ITLINE_ITLINE7 bit@ ; \ SYSCFG_ITLINE_ITLINE7.EXTI11, EXTI11
: SYSCFG_ITLINE_ITLINE7.EXTI12? ( --  1|0 ) 8 bit SYSCFG_ITLINE_ITLINE7 bit@ ; \ SYSCFG_ITLINE_ITLINE7.EXTI12, EXTI12
: SYSCFG_ITLINE_ITLINE7.EXTI13? ( --  1|0 ) 9 bit SYSCFG_ITLINE_ITLINE7 bit@ ; \ SYSCFG_ITLINE_ITLINE7.EXTI13, EXTI13
: SYSCFG_ITLINE_ITLINE7.EXTI14? ( --  1|0 ) 10 bit SYSCFG_ITLINE_ITLINE7 bit@ ; \ SYSCFG_ITLINE_ITLINE7.EXTI14, EXTI14
: SYSCFG_ITLINE_ITLINE7.EXTI15? ( --  1|0 ) 11 bit SYSCFG_ITLINE_ITLINE7 bit@ ; \ SYSCFG_ITLINE_ITLINE7.EXTI15, EXTI15

\ SYSCFG_ITLINE_ITLINE9 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE9.DMA1_CH1? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE9 bit@ ; \ SYSCFG_ITLINE_ITLINE9.DMA1_CH1, DMA1_CH1

\ SYSCFG_ITLINE_ITLINE10 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE10.DMA1_CH2? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE10 bit@ ; \ SYSCFG_ITLINE_ITLINE10.DMA1_CH2, DMA1_CH1
: SYSCFG_ITLINE_ITLINE10.DMA1_CH3? ( --  1|0 ) 1 bit SYSCFG_ITLINE_ITLINE10 bit@ ; \ SYSCFG_ITLINE_ITLINE10.DMA1_CH3, DMA1_CH3

\ SYSCFG_ITLINE_ITLINE11 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE11.DMAMUX? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE11 bit@ ; \ SYSCFG_ITLINE_ITLINE11.DMAMUX, DMAMUX
: SYSCFG_ITLINE_ITLINE11.DMA1_CH4? ( --  1|0 ) 1 bit SYSCFG_ITLINE_ITLINE11 bit@ ; \ SYSCFG_ITLINE_ITLINE11.DMA1_CH4, DMA1_CH4
: SYSCFG_ITLINE_ITLINE11.DMA1_CH5? ( --  1|0 ) 2 bit SYSCFG_ITLINE_ITLINE11 bit@ ; \ SYSCFG_ITLINE_ITLINE11.DMA1_CH5, DMA1_CH5

\ SYSCFG_ITLINE_ITLINE12 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE12.ADC? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE12 bit@ ; \ SYSCFG_ITLINE_ITLINE12.ADC, ADC

\ SYSCFG_ITLINE_ITLINE13 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE13.TIM1_CCU? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE13 bit@ ; \ SYSCFG_ITLINE_ITLINE13.TIM1_CCU, TIM1_CCU
: SYSCFG_ITLINE_ITLINE13.TIM1_TRG? ( --  1|0 ) 1 bit SYSCFG_ITLINE_ITLINE13 bit@ ; \ SYSCFG_ITLINE_ITLINE13.TIM1_TRG, TIM1_TRG
: SYSCFG_ITLINE_ITLINE13.TIM1_UPD? ( --  1|0 ) 2 bit SYSCFG_ITLINE_ITLINE13 bit@ ; \ SYSCFG_ITLINE_ITLINE13.TIM1_UPD, TIM1_UPD
: SYSCFG_ITLINE_ITLINE13.TIM1_BRK? ( --  1|0 ) 3 bit SYSCFG_ITLINE_ITLINE13 bit@ ; \ SYSCFG_ITLINE_ITLINE13.TIM1_BRK, TIM1_BRK

\ SYSCFG_ITLINE_ITLINE14 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE14.TIM1_CC? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE14 bit@ ; \ SYSCFG_ITLINE_ITLINE14.TIM1_CC, TIM1_CC

\ SYSCFG_ITLINE_ITLINE15 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE15.TIM2? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE15 bit@ ; \ SYSCFG_ITLINE_ITLINE15.TIM2, TIM2

\ SYSCFG_ITLINE_ITLINE16 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE16.TIM3? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE16 bit@ ; \ SYSCFG_ITLINE_ITLINE16.TIM3, TIM3

\ SYSCFG_ITLINE_ITLINE19 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE19.TIM14? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE19 bit@ ; \ SYSCFG_ITLINE_ITLINE19.TIM14, TIM14

\ SYSCFG_ITLINE_ITLINE21 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE21.TIM16? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE21 bit@ ; \ SYSCFG_ITLINE_ITLINE21.TIM16, TIM16

\ SYSCFG_ITLINE_ITLINE22 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE22.TIM17? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE22 bit@ ; \ SYSCFG_ITLINE_ITLINE22.TIM17, TIM17

\ SYSCFG_ITLINE_ITLINE23 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE23.I2C1? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE23 bit@ ; \ SYSCFG_ITLINE_ITLINE23.I2C1, I2C1

\ SYSCFG_ITLINE_ITLINE24 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE24.I2C2? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE24 bit@ ; \ SYSCFG_ITLINE_ITLINE24.I2C2, I2C2

\ SYSCFG_ITLINE_ITLINE25 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE25.SPI1? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE25 bit@ ; \ SYSCFG_ITLINE_ITLINE25.SPI1, SPI1

\ SYSCFG_ITLINE_ITLINE26 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE26.SPI2? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE26 bit@ ; \ SYSCFG_ITLINE_ITLINE26.SPI2, SPI2

\ SYSCFG_ITLINE_ITLINE27 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE27.USART1? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE27 bit@ ; \ SYSCFG_ITLINE_ITLINE27.USART1, USART1

\ SYSCFG_ITLINE_ITLINE28 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE28.USART2? ( --  1|0 ) 0 bit SYSCFG_ITLINE_ITLINE28 bit@ ; \ SYSCFG_ITLINE_ITLINE28.USART2, USART2

\ SYSCFG_ITLINE_ITLINE29 (read-only) Reset:$00000000
: SYSCFG_ITLINE_ITLINE29.USART5? ( --  1|0 ) 2 bit SYSCFG_ITLINE_ITLINE29 bit@ ; \ SYSCFG_ITLINE_ITLINE29.USART5, USART5
