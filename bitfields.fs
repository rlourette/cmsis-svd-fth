\ STM32L053x Register Bitfield Definitions for Mecrisp-Stellaris Forth by Matthias Koch. 
\ bitfield.xsl takes STM32Fxx.svd, config.xml and produces bitfield.fs
\ Written by Terry Porter "terry@tjporter.com.au" 2016 - 2020 and released under the GPL V2.
\ Requires: bit ( u -- u ) 1 swap lshift 1-foldable ;	\ turn a bit position into a binary number.

\ DAC_CR (read-write) Reset:0x00000000
: DAC_CR_DMAUDRIE1 ( -- x addr ) 13 bit DAC_CR ; \ DAC_CR_DMAUDRIE1, DAC channel1 DMA Underrun Interrupt  enable
: DAC_CR_DMAEN1 ( -- x addr ) 12 bit DAC_CR ; \ DAC_CR_DMAEN1, DAC channel1 DMA enable
: DAC_CR_MAMP1 ( %bbbb -- x addr ) 8 lshift DAC_CR ; \ DAC_CR_MAMP1, DAC channel1 mask/amplitude  selector
: DAC_CR_WAVE1 ( %bb -- x addr ) 6 lshift DAC_CR ; \ DAC_CR_WAVE1, DAC channel1 noise/triangle wave  generation enable
: DAC_CR_TSEL1 ( %bbb -- x addr ) 3 lshift DAC_CR ; \ DAC_CR_TSEL1, DAC channel1 trigger  selection
: DAC_CR_TEN1 ( -- x addr ) 2 bit DAC_CR ; \ DAC_CR_TEN1, DAC channel1 trigger  enable
: DAC_CR_BOFF1 ( -- x addr ) 1 bit DAC_CR ; \ DAC_CR_BOFF1, DAC channel1 output buffer  disable
: DAC_CR_EN1 ( -- x addr ) 0 bit DAC_CR ; \ DAC_CR_EN1, DAC channel1 enable

\ DAC_SWTRIGR (write-only) Reset:0x00000000
: DAC_SWTRIGR_SWTRIG1 ( -- x addr ) 0 bit DAC_SWTRIGR ; \ DAC_SWTRIGR_SWTRIG1, DAC channel1 software  trigger

\ DAC_DHR12R1 (read-write) Reset:0x00000000
: DAC_DHR12R1_DACC1DHR ( %bbbbbbbbbbb -- x addr ) DAC_DHR12R1 ; \ DAC_DHR12R1_DACC1DHR, DAC channel1 12-bit right-aligned  data

\ DAC_DHR12L1 (read-write) Reset:0x00000000
: DAC_DHR12L1_DACC1DHR ( %bbbbbbbbbbb -- x addr ) 4 lshift DAC_DHR12L1 ; \ DAC_DHR12L1_DACC1DHR, DAC channel1 12-bit left-aligned  data

\ DAC_DHR8R1 (read-write) Reset:0x00000000
: DAC_DHR8R1_DACC1DHR ( %bbbbbbbb -- x addr ) DAC_DHR8R1 ; \ DAC_DHR8R1_DACC1DHR, DAC channel1 8-bit right-aligned  data

\ DAC_DOR1 (read-only) Reset:0x00000000
: DAC_DOR1_DACC1DOR? ( --  x ) DAC_DOR1 @ ; \ DAC_DOR1_DACC1DOR, DAC channel1 data output

\ DAC_SR (multiple-access)  Reset:0x00000000
: DAC_SR_DMAUDR1? ( -- 1|0 ) 13 bit DAC_SR bit@ ; \ DAC_SR_DMAUDR1, DAC channel1 DMA underrun  flag

\ DMA1_ISR (read-only) Reset:0x00000000
: DMA1_ISR_TEIF7? ( --  1|0 ) 27 bit DMA1_ISR bit@ ; \ DMA1_ISR_TEIF7, Channel x transfer error flag x = 1  ..7
: DMA1_ISR_HTIF7? ( --  1|0 ) 26 bit DMA1_ISR bit@ ; \ DMA1_ISR_HTIF7, Channel x half transfer flag x = 1  ..7
: DMA1_ISR_TCIF7? ( --  1|0 ) 25 bit DMA1_ISR bit@ ; \ DMA1_ISR_TCIF7, Channel x transfer complete flag x = 1  ..7
: DMA1_ISR_GIF7? ( --  1|0 ) 24 bit DMA1_ISR bit@ ; \ DMA1_ISR_GIF7, Channel x global interrupt flag x = 1  ..7
: DMA1_ISR_TEIF6? ( --  1|0 ) 23 bit DMA1_ISR bit@ ; \ DMA1_ISR_TEIF6, Channel x transfer error flag x = 1  ..7
: DMA1_ISR_HTIF6? ( --  1|0 ) 22 bit DMA1_ISR bit@ ; \ DMA1_ISR_HTIF6, Channel x half transfer flag x = 1  ..7
: DMA1_ISR_TCIF6? ( --  1|0 ) 21 bit DMA1_ISR bit@ ; \ DMA1_ISR_TCIF6, Channel x transfer complete flag x = 1  ..7
: DMA1_ISR_GIF6? ( --  1|0 ) 20 bit DMA1_ISR bit@ ; \ DMA1_ISR_GIF6, Channel x global interrupt flag x = 1  ..7
: DMA1_ISR_TEIF5? ( --  1|0 ) 19 bit DMA1_ISR bit@ ; \ DMA1_ISR_TEIF5, Channel x transfer error flag x = 1  ..7
: DMA1_ISR_HTIF5? ( --  1|0 ) 18 bit DMA1_ISR bit@ ; \ DMA1_ISR_HTIF5, Channel x half transfer flag x = 1  ..7
: DMA1_ISR_TCIF5? ( --  1|0 ) 17 bit DMA1_ISR bit@ ; \ DMA1_ISR_TCIF5, Channel x transfer complete flag x = 1  ..7
: DMA1_ISR_GIF5? ( --  1|0 ) 16 bit DMA1_ISR bit@ ; \ DMA1_ISR_GIF5, Channel x global interrupt flag x = 1  ..7
: DMA1_ISR_TEIF4? ( --  1|0 ) 15 bit DMA1_ISR bit@ ; \ DMA1_ISR_TEIF4, Channel x transfer error flag x = 1  ..7
: DMA1_ISR_HTIF4? ( --  1|0 ) 14 bit DMA1_ISR bit@ ; \ DMA1_ISR_HTIF4, Channel x half transfer flag x = 1  ..7
: DMA1_ISR_TCIF4? ( --  1|0 ) 13 bit DMA1_ISR bit@ ; \ DMA1_ISR_TCIF4, Channel x transfer complete flag x = 1  ..7
: DMA1_ISR_GIF4? ( --  1|0 ) 12 bit DMA1_ISR bit@ ; \ DMA1_ISR_GIF4, Channel x global interrupt flag x = 1  ..7
: DMA1_ISR_TEIF3? ( --  1|0 ) 11 bit DMA1_ISR bit@ ; \ DMA1_ISR_TEIF3, Channel x transfer error flag x = 1  ..7
: DMA1_ISR_HTIF3? ( --  1|0 ) 10 bit DMA1_ISR bit@ ; \ DMA1_ISR_HTIF3, Channel x half transfer flag x = 1  ..7
: DMA1_ISR_TCIF3? ( --  1|0 ) 9 bit DMA1_ISR bit@ ; \ DMA1_ISR_TCIF3, Channel x transfer complete flag x = 1  ..7
: DMA1_ISR_GIF3? ( --  1|0 ) 8 bit DMA1_ISR bit@ ; \ DMA1_ISR_GIF3, Channel x global interrupt flag x = 1  ..7
: DMA1_ISR_TEIF2? ( --  1|0 ) 7 bit DMA1_ISR bit@ ; \ DMA1_ISR_TEIF2, Channel x transfer error flag x = 1  ..7
: DMA1_ISR_HTIF2? ( --  1|0 ) 6 bit DMA1_ISR bit@ ; \ DMA1_ISR_HTIF2, Channel x half transfer flag x = 1  ..7
: DMA1_ISR_TCIF2? ( --  1|0 ) 5 bit DMA1_ISR bit@ ; \ DMA1_ISR_TCIF2, Channel x transfer complete flag x = 1  ..7
: DMA1_ISR_GIF2? ( --  1|0 ) 4 bit DMA1_ISR bit@ ; \ DMA1_ISR_GIF2, Channel x global interrupt flag x = 1  ..7
: DMA1_ISR_TEIF1? ( --  1|0 ) 3 bit DMA1_ISR bit@ ; \ DMA1_ISR_TEIF1, Channel x transfer error flag x = 1  ..7
: DMA1_ISR_HTIF1? ( --  1|0 ) 2 bit DMA1_ISR bit@ ; \ DMA1_ISR_HTIF1, Channel x half transfer flag x = 1  ..7
: DMA1_ISR_TCIF1? ( --  1|0 ) 1 bit DMA1_ISR bit@ ; \ DMA1_ISR_TCIF1, Channel x transfer complete flag x = 1  ..7
: DMA1_ISR_GIF1? ( --  1|0 ) 0 bit DMA1_ISR bit@ ; \ DMA1_ISR_GIF1, Channel x global interrupt flag x = 1  ..7

\ DMA1_IFCR (write-only) Reset:0x00000000
: DMA1_IFCR_CTEIF7 ( -- x addr ) 27 bit DMA1_IFCR ; \ DMA1_IFCR_CTEIF7, Channel x transfer error clear x = 1  ..7
: DMA1_IFCR_CHTIF7 ( -- x addr ) 26 bit DMA1_IFCR ; \ DMA1_IFCR_CHTIF7, Channel x half transfer clear x = 1  ..7
: DMA1_IFCR_CTCIF7 ( -- x addr ) 25 bit DMA1_IFCR ; \ DMA1_IFCR_CTCIF7, Channel x transfer complete clear x = 1  ..7
: DMA1_IFCR_CGIF7 ( -- x addr ) 24 bit DMA1_IFCR ; \ DMA1_IFCR_CGIF7, Channel x global interrupt clear x = 1  ..7
: DMA1_IFCR_CTEIF6 ( -- x addr ) 23 bit DMA1_IFCR ; \ DMA1_IFCR_CTEIF6, Channel x transfer error clear x = 1  ..7
: DMA1_IFCR_CHTIF6 ( -- x addr ) 22 bit DMA1_IFCR ; \ DMA1_IFCR_CHTIF6, Channel x half transfer clear x = 1  ..7
: DMA1_IFCR_CTCIF6 ( -- x addr ) 21 bit DMA1_IFCR ; \ DMA1_IFCR_CTCIF6, Channel x transfer complete clear x = 1  ..7
: DMA1_IFCR_CGIF6 ( -- x addr ) 20 bit DMA1_IFCR ; \ DMA1_IFCR_CGIF6, Channel x global interrupt clear x = 1  ..7
: DMA1_IFCR_CTEIF5 ( -- x addr ) 19 bit DMA1_IFCR ; \ DMA1_IFCR_CTEIF5, Channel x transfer error clear x = 1  ..7
: DMA1_IFCR_CHTIF5 ( -- x addr ) 18 bit DMA1_IFCR ; \ DMA1_IFCR_CHTIF5, Channel x half transfer clear x = 1  ..7
: DMA1_IFCR_CTCIF5 ( -- x addr ) 17 bit DMA1_IFCR ; \ DMA1_IFCR_CTCIF5, Channel x transfer complete clear x = 1  ..7
: DMA1_IFCR_CGIF5 ( -- x addr ) 16 bit DMA1_IFCR ; \ DMA1_IFCR_CGIF5, Channel x global interrupt clear x = 1  ..7
: DMA1_IFCR_CTEIF4 ( -- x addr ) 15 bit DMA1_IFCR ; \ DMA1_IFCR_CTEIF4, Channel x transfer error clear x = 1  ..7
: DMA1_IFCR_CHTIF4 ( -- x addr ) 14 bit DMA1_IFCR ; \ DMA1_IFCR_CHTIF4, Channel x half transfer clear x = 1  ..7
: DMA1_IFCR_CTCIF4 ( -- x addr ) 13 bit DMA1_IFCR ; \ DMA1_IFCR_CTCIF4, Channel x transfer complete clear x = 1  ..7
: DMA1_IFCR_CGIF4 ( -- x addr ) 12 bit DMA1_IFCR ; \ DMA1_IFCR_CGIF4, Channel x global interrupt clear x = 1  ..7
: DMA1_IFCR_CTEIF3 ( -- x addr ) 11 bit DMA1_IFCR ; \ DMA1_IFCR_CTEIF3, Channel x transfer error clear x = 1  ..7
: DMA1_IFCR_CHTIF3 ( -- x addr ) 10 bit DMA1_IFCR ; \ DMA1_IFCR_CHTIF3, Channel x half transfer clear x = 1  ..7
: DMA1_IFCR_CTCIF3 ( -- x addr ) 9 bit DMA1_IFCR ; \ DMA1_IFCR_CTCIF3, Channel x transfer complete clear x = 1  ..7
: DMA1_IFCR_CGIF3 ( -- x addr ) 8 bit DMA1_IFCR ; \ DMA1_IFCR_CGIF3, Channel x global interrupt clear x = 1  ..7
: DMA1_IFCR_CTEIF2 ( -- x addr ) 7 bit DMA1_IFCR ; \ DMA1_IFCR_CTEIF2, Channel x transfer error clear x = 1  ..7
: DMA1_IFCR_CHTIF2 ( -- x addr ) 6 bit DMA1_IFCR ; \ DMA1_IFCR_CHTIF2, Channel x half transfer clear x = 1  ..7
: DMA1_IFCR_CTCIF2 ( -- x addr ) 5 bit DMA1_IFCR ; \ DMA1_IFCR_CTCIF2, Channel x transfer complete clear x = 1  ..7
: DMA1_IFCR_CGIF2 ( -- x addr ) 4 bit DMA1_IFCR ; \ DMA1_IFCR_CGIF2, Channel x global interrupt clear x = 1  ..7
: DMA1_IFCR_CTEIF1 ( -- x addr ) 3 bit DMA1_IFCR ; \ DMA1_IFCR_CTEIF1, Channel x transfer error clear x = 1  ..7
: DMA1_IFCR_CHTIF1 ( -- x addr ) 2 bit DMA1_IFCR ; \ DMA1_IFCR_CHTIF1, Channel x half transfer clear x = 1  ..7
: DMA1_IFCR_CTCIF1 ( -- x addr ) 1 bit DMA1_IFCR ; \ DMA1_IFCR_CTCIF1, Channel x transfer complete clear x = 1  ..7
: DMA1_IFCR_CGIF1 ( -- x addr ) 0 bit DMA1_IFCR ; \ DMA1_IFCR_CGIF1, Channel x global interrupt clear x = 1  ..7

\ DMA1_CCR1 (read-write) Reset:0x00000000
: DMA1_CCR1_MEM2MEM ( -- x addr ) 14 bit DMA1_CCR1 ; \ DMA1_CCR1_MEM2MEM, Memory to memory mode
: DMA1_CCR1_PL ( %bb -- x addr ) 12 lshift DMA1_CCR1 ; \ DMA1_CCR1_PL, Channel priority level
: DMA1_CCR1_MSIZE ( %bb -- x addr ) 10 lshift DMA1_CCR1 ; \ DMA1_CCR1_MSIZE, Memory size
: DMA1_CCR1_PSIZE ( %bb -- x addr ) 8 lshift DMA1_CCR1 ; \ DMA1_CCR1_PSIZE, Peripheral size
: DMA1_CCR1_MINC ( -- x addr ) 7 bit DMA1_CCR1 ; \ DMA1_CCR1_MINC, Memory increment mode
: DMA1_CCR1_PINC ( -- x addr ) 6 bit DMA1_CCR1 ; \ DMA1_CCR1_PINC, Peripheral increment mode
: DMA1_CCR1_CIRC ( -- x addr ) 5 bit DMA1_CCR1 ; \ DMA1_CCR1_CIRC, Circular mode
: DMA1_CCR1_DIR ( -- x addr ) 4 bit DMA1_CCR1 ; \ DMA1_CCR1_DIR, Data transfer direction
: DMA1_CCR1_TEIE ( -- x addr ) 3 bit DMA1_CCR1 ; \ DMA1_CCR1_TEIE, Transfer error interrupt  enable
: DMA1_CCR1_HTIE ( -- x addr ) 2 bit DMA1_CCR1 ; \ DMA1_CCR1_HTIE, Half transfer interrupt  enable
: DMA1_CCR1_TCIE ( -- x addr ) 1 bit DMA1_CCR1 ; \ DMA1_CCR1_TCIE, Transfer complete interrupt  enable
: DMA1_CCR1_EN ( -- x addr ) 0 bit DMA1_CCR1 ; \ DMA1_CCR1_EN, Channel enable

\ DMA1_CNDTR1 (read-write) Reset:0x00000000
: DMA1_CNDTR1_NDT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA1_CNDTR1 ; \ DMA1_CNDTR1_NDT, Number of data to transfer

\ DMA1_CPAR1 (read-write) Reset:0x00000000
: DMA1_CPAR1_PA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CPAR1 ; \ DMA1_CPAR1_PA, Peripheral address

\ DMA1_CMAR1 (read-write) Reset:0x00000000
: DMA1_CMAR1_MA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CMAR1 ; \ DMA1_CMAR1_MA, Memory address

\ DMA1_CCR2 (read-write) Reset:0x00000000
: DMA1_CCR2_MEM2MEM ( -- x addr ) 14 bit DMA1_CCR2 ; \ DMA1_CCR2_MEM2MEM, Memory to memory mode
: DMA1_CCR2_PL ( %bb -- x addr ) 12 lshift DMA1_CCR2 ; \ DMA1_CCR2_PL, Channel priority level
: DMA1_CCR2_MSIZE ( %bb -- x addr ) 10 lshift DMA1_CCR2 ; \ DMA1_CCR2_MSIZE, Memory size
: DMA1_CCR2_PSIZE ( %bb -- x addr ) 8 lshift DMA1_CCR2 ; \ DMA1_CCR2_PSIZE, Peripheral size
: DMA1_CCR2_MINC ( -- x addr ) 7 bit DMA1_CCR2 ; \ DMA1_CCR2_MINC, Memory increment mode
: DMA1_CCR2_PINC ( -- x addr ) 6 bit DMA1_CCR2 ; \ DMA1_CCR2_PINC, Peripheral increment mode
: DMA1_CCR2_CIRC ( -- x addr ) 5 bit DMA1_CCR2 ; \ DMA1_CCR2_CIRC, Circular mode
: DMA1_CCR2_DIR ( -- x addr ) 4 bit DMA1_CCR2 ; \ DMA1_CCR2_DIR, Data transfer direction
: DMA1_CCR2_TEIE ( -- x addr ) 3 bit DMA1_CCR2 ; \ DMA1_CCR2_TEIE, Transfer error interrupt  enable
: DMA1_CCR2_HTIE ( -- x addr ) 2 bit DMA1_CCR2 ; \ DMA1_CCR2_HTIE, Half transfer interrupt  enable
: DMA1_CCR2_TCIE ( -- x addr ) 1 bit DMA1_CCR2 ; \ DMA1_CCR2_TCIE, Transfer complete interrupt  enable
: DMA1_CCR2_EN ( -- x addr ) 0 bit DMA1_CCR2 ; \ DMA1_CCR2_EN, Channel enable

\ DMA1_CNDTR2 (read-write) Reset:0x00000000
: DMA1_CNDTR2_NDT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA1_CNDTR2 ; \ DMA1_CNDTR2_NDT, Number of data to transfer

\ DMA1_CPAR2 (read-write) Reset:0x00000000
: DMA1_CPAR2_PA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CPAR2 ; \ DMA1_CPAR2_PA, Peripheral address

\ DMA1_CMAR2 (read-write) Reset:0x00000000
: DMA1_CMAR2_MA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CMAR2 ; \ DMA1_CMAR2_MA, Memory address

\ DMA1_CCR3 (read-write) Reset:0x00000000
: DMA1_CCR3_MEM2MEM ( -- x addr ) 14 bit DMA1_CCR3 ; \ DMA1_CCR3_MEM2MEM, Memory to memory mode
: DMA1_CCR3_PL ( %bb -- x addr ) 12 lshift DMA1_CCR3 ; \ DMA1_CCR3_PL, Channel priority level
: DMA1_CCR3_MSIZE ( %bb -- x addr ) 10 lshift DMA1_CCR3 ; \ DMA1_CCR3_MSIZE, Memory size
: DMA1_CCR3_PSIZE ( %bb -- x addr ) 8 lshift DMA1_CCR3 ; \ DMA1_CCR3_PSIZE, Peripheral size
: DMA1_CCR3_MINC ( -- x addr ) 7 bit DMA1_CCR3 ; \ DMA1_CCR3_MINC, Memory increment mode
: DMA1_CCR3_PINC ( -- x addr ) 6 bit DMA1_CCR3 ; \ DMA1_CCR3_PINC, Peripheral increment mode
: DMA1_CCR3_CIRC ( -- x addr ) 5 bit DMA1_CCR3 ; \ DMA1_CCR3_CIRC, Circular mode
: DMA1_CCR3_DIR ( -- x addr ) 4 bit DMA1_CCR3 ; \ DMA1_CCR3_DIR, Data transfer direction
: DMA1_CCR3_TEIE ( -- x addr ) 3 bit DMA1_CCR3 ; \ DMA1_CCR3_TEIE, Transfer error interrupt  enable
: DMA1_CCR3_HTIE ( -- x addr ) 2 bit DMA1_CCR3 ; \ DMA1_CCR3_HTIE, Half transfer interrupt  enable
: DMA1_CCR3_TCIE ( -- x addr ) 1 bit DMA1_CCR3 ; \ DMA1_CCR3_TCIE, Transfer complete interrupt  enable
: DMA1_CCR3_EN ( -- x addr ) 0 bit DMA1_CCR3 ; \ DMA1_CCR3_EN, Channel enable

\ DMA1_CNDTR3 (read-write) Reset:0x00000000
: DMA1_CNDTR3_NDT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA1_CNDTR3 ; \ DMA1_CNDTR3_NDT, Number of data to transfer

\ DMA1_CPAR3 (read-write) Reset:0x00000000
: DMA1_CPAR3_PA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CPAR3 ; \ DMA1_CPAR3_PA, Peripheral address

\ DMA1_CMAR3 (read-write) Reset:0x00000000
: DMA1_CMAR3_MA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CMAR3 ; \ DMA1_CMAR3_MA, Memory address

\ DMA1_CCR4 (read-write) Reset:0x00000000
: DMA1_CCR4_MEM2MEM ( -- x addr ) 14 bit DMA1_CCR4 ; \ DMA1_CCR4_MEM2MEM, Memory to memory mode
: DMA1_CCR4_PL ( %bb -- x addr ) 12 lshift DMA1_CCR4 ; \ DMA1_CCR4_PL, Channel priority level
: DMA1_CCR4_MSIZE ( %bb -- x addr ) 10 lshift DMA1_CCR4 ; \ DMA1_CCR4_MSIZE, Memory size
: DMA1_CCR4_PSIZE ( %bb -- x addr ) 8 lshift DMA1_CCR4 ; \ DMA1_CCR4_PSIZE, Peripheral size
: DMA1_CCR4_MINC ( -- x addr ) 7 bit DMA1_CCR4 ; \ DMA1_CCR4_MINC, Memory increment mode
: DMA1_CCR4_PINC ( -- x addr ) 6 bit DMA1_CCR4 ; \ DMA1_CCR4_PINC, Peripheral increment mode
: DMA1_CCR4_CIRC ( -- x addr ) 5 bit DMA1_CCR4 ; \ DMA1_CCR4_CIRC, Circular mode
: DMA1_CCR4_DIR ( -- x addr ) 4 bit DMA1_CCR4 ; \ DMA1_CCR4_DIR, Data transfer direction
: DMA1_CCR4_TEIE ( -- x addr ) 3 bit DMA1_CCR4 ; \ DMA1_CCR4_TEIE, Transfer error interrupt  enable
: DMA1_CCR4_HTIE ( -- x addr ) 2 bit DMA1_CCR4 ; \ DMA1_CCR4_HTIE, Half transfer interrupt  enable
: DMA1_CCR4_TCIE ( -- x addr ) 1 bit DMA1_CCR4 ; \ DMA1_CCR4_TCIE, Transfer complete interrupt  enable
: DMA1_CCR4_EN ( -- x addr ) 0 bit DMA1_CCR4 ; \ DMA1_CCR4_EN, Channel enable

\ DMA1_CNDTR4 (read-write) Reset:0x00000000
: DMA1_CNDTR4_NDT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA1_CNDTR4 ; \ DMA1_CNDTR4_NDT, Number of data to transfer

\ DMA1_CPAR4 (read-write) Reset:0x00000000
: DMA1_CPAR4_PA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CPAR4 ; \ DMA1_CPAR4_PA, Peripheral address

\ DMA1_CMAR4 (read-write) Reset:0x00000000
: DMA1_CMAR4_MA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CMAR4 ; \ DMA1_CMAR4_MA, Memory address

\ DMA1_CCR5 (read-write) Reset:0x00000000
: DMA1_CCR5_MEM2MEM ( -- x addr ) 14 bit DMA1_CCR5 ; \ DMA1_CCR5_MEM2MEM, Memory to memory mode
: DMA1_CCR5_PL ( %bb -- x addr ) 12 lshift DMA1_CCR5 ; \ DMA1_CCR5_PL, Channel priority level
: DMA1_CCR5_MSIZE ( %bb -- x addr ) 10 lshift DMA1_CCR5 ; \ DMA1_CCR5_MSIZE, Memory size
: DMA1_CCR5_PSIZE ( %bb -- x addr ) 8 lshift DMA1_CCR5 ; \ DMA1_CCR5_PSIZE, Peripheral size
: DMA1_CCR5_MINC ( -- x addr ) 7 bit DMA1_CCR5 ; \ DMA1_CCR5_MINC, Memory increment mode
: DMA1_CCR5_PINC ( -- x addr ) 6 bit DMA1_CCR5 ; \ DMA1_CCR5_PINC, Peripheral increment mode
: DMA1_CCR5_CIRC ( -- x addr ) 5 bit DMA1_CCR5 ; \ DMA1_CCR5_CIRC, Circular mode
: DMA1_CCR5_DIR ( -- x addr ) 4 bit DMA1_CCR5 ; \ DMA1_CCR5_DIR, Data transfer direction
: DMA1_CCR5_TEIE ( -- x addr ) 3 bit DMA1_CCR5 ; \ DMA1_CCR5_TEIE, Transfer error interrupt  enable
: DMA1_CCR5_HTIE ( -- x addr ) 2 bit DMA1_CCR5 ; \ DMA1_CCR5_HTIE, Half transfer interrupt  enable
: DMA1_CCR5_TCIE ( -- x addr ) 1 bit DMA1_CCR5 ; \ DMA1_CCR5_TCIE, Transfer complete interrupt  enable
: DMA1_CCR5_EN ( -- x addr ) 0 bit DMA1_CCR5 ; \ DMA1_CCR5_EN, Channel enable

\ DMA1_CNDTR5 (read-write) Reset:0x00000000
: DMA1_CNDTR5_NDT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA1_CNDTR5 ; \ DMA1_CNDTR5_NDT, Number of data to transfer

\ DMA1_CPAR5 (read-write) Reset:0x00000000
: DMA1_CPAR5_PA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CPAR5 ; \ DMA1_CPAR5_PA, Peripheral address

\ DMA1_CMAR5 (read-write) Reset:0x00000000
: DMA1_CMAR5_MA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CMAR5 ; \ DMA1_CMAR5_MA, Memory address

\ DMA1_CCR6 (read-write) Reset:0x00000000
: DMA1_CCR6_MEM2MEM ( -- x addr ) 14 bit DMA1_CCR6 ; \ DMA1_CCR6_MEM2MEM, Memory to memory mode
: DMA1_CCR6_PL ( %bb -- x addr ) 12 lshift DMA1_CCR6 ; \ DMA1_CCR6_PL, Channel priority level
: DMA1_CCR6_MSIZE ( %bb -- x addr ) 10 lshift DMA1_CCR6 ; \ DMA1_CCR6_MSIZE, Memory size
: DMA1_CCR6_PSIZE ( %bb -- x addr ) 8 lshift DMA1_CCR6 ; \ DMA1_CCR6_PSIZE, Peripheral size
: DMA1_CCR6_MINC ( -- x addr ) 7 bit DMA1_CCR6 ; \ DMA1_CCR6_MINC, Memory increment mode
: DMA1_CCR6_PINC ( -- x addr ) 6 bit DMA1_CCR6 ; \ DMA1_CCR6_PINC, Peripheral increment mode
: DMA1_CCR6_CIRC ( -- x addr ) 5 bit DMA1_CCR6 ; \ DMA1_CCR6_CIRC, Circular mode
: DMA1_CCR6_DIR ( -- x addr ) 4 bit DMA1_CCR6 ; \ DMA1_CCR6_DIR, Data transfer direction
: DMA1_CCR6_TEIE ( -- x addr ) 3 bit DMA1_CCR6 ; \ DMA1_CCR6_TEIE, Transfer error interrupt  enable
: DMA1_CCR6_HTIE ( -- x addr ) 2 bit DMA1_CCR6 ; \ DMA1_CCR6_HTIE, Half transfer interrupt  enable
: DMA1_CCR6_TCIE ( -- x addr ) 1 bit DMA1_CCR6 ; \ DMA1_CCR6_TCIE, Transfer complete interrupt  enable
: DMA1_CCR6_EN ( -- x addr ) 0 bit DMA1_CCR6 ; \ DMA1_CCR6_EN, Channel enable

\ DMA1_CNDTR6 (read-write) Reset:0x00000000
: DMA1_CNDTR6_NDT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA1_CNDTR6 ; \ DMA1_CNDTR6_NDT, Number of data to transfer

\ DMA1_CPAR6 (read-write) Reset:0x00000000
: DMA1_CPAR6_PA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CPAR6 ; \ DMA1_CPAR6_PA, Peripheral address

\ DMA1_CMAR6 (read-write) Reset:0x00000000
: DMA1_CMAR6_MA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CMAR6 ; \ DMA1_CMAR6_MA, Memory address

\ DMA1_CCR7 (read-write) Reset:0x00000000
: DMA1_CCR7_MEM2MEM ( -- x addr ) 14 bit DMA1_CCR7 ; \ DMA1_CCR7_MEM2MEM, Memory to memory mode
: DMA1_CCR7_PL ( %bb -- x addr ) 12 lshift DMA1_CCR7 ; \ DMA1_CCR7_PL, Channel priority level
: DMA1_CCR7_MSIZE ( %bb -- x addr ) 10 lshift DMA1_CCR7 ; \ DMA1_CCR7_MSIZE, Memory size
: DMA1_CCR7_PSIZE ( %bb -- x addr ) 8 lshift DMA1_CCR7 ; \ DMA1_CCR7_PSIZE, Peripheral size
: DMA1_CCR7_MINC ( -- x addr ) 7 bit DMA1_CCR7 ; \ DMA1_CCR7_MINC, Memory increment mode
: DMA1_CCR7_PINC ( -- x addr ) 6 bit DMA1_CCR7 ; \ DMA1_CCR7_PINC, Peripheral increment mode
: DMA1_CCR7_CIRC ( -- x addr ) 5 bit DMA1_CCR7 ; \ DMA1_CCR7_CIRC, Circular mode
: DMA1_CCR7_DIR ( -- x addr ) 4 bit DMA1_CCR7 ; \ DMA1_CCR7_DIR, Data transfer direction
: DMA1_CCR7_TEIE ( -- x addr ) 3 bit DMA1_CCR7 ; \ DMA1_CCR7_TEIE, Transfer error interrupt  enable
: DMA1_CCR7_HTIE ( -- x addr ) 2 bit DMA1_CCR7 ; \ DMA1_CCR7_HTIE, Half transfer interrupt  enable
: DMA1_CCR7_TCIE ( -- x addr ) 1 bit DMA1_CCR7 ; \ DMA1_CCR7_TCIE, Transfer complete interrupt  enable
: DMA1_CCR7_EN ( -- x addr ) 0 bit DMA1_CCR7 ; \ DMA1_CCR7_EN, Channel enable

\ DMA1_CNDTR7 (read-write) Reset:0x00000000
: DMA1_CNDTR7_NDT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA1_CNDTR7 ; \ DMA1_CNDTR7_NDT, Number of data to transfer

\ DMA1_CPAR7 (read-write) Reset:0x00000000
: DMA1_CPAR7_PA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CPAR7 ; \ DMA1_CPAR7_PA, Peripheral address

\ DMA1_CMAR7 (read-write) Reset:0x00000000
: DMA1_CMAR7_MA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CMAR7 ; \ DMA1_CMAR7_MA, Memory address

\ DMA1_CSELR (read-write) Reset:0x00000000
: DMA1_CSELR_C7S ( %bbbb -- x addr ) 24 lshift DMA1_CSELR ; \ DMA1_CSELR_C7S, DMA channel 7 selection
: DMA1_CSELR_C6S ( %bbbb -- x addr ) 20 lshift DMA1_CSELR ; \ DMA1_CSELR_C6S, DMA channel 6 selection
: DMA1_CSELR_C5S ( %bbbb -- x addr ) 16 lshift DMA1_CSELR ; \ DMA1_CSELR_C5S, DMA channel 5 selection
: DMA1_CSELR_C4S ( %bbbb -- x addr ) 12 lshift DMA1_CSELR ; \ DMA1_CSELR_C4S, DMA channel 4 selection
: DMA1_CSELR_C3S ( %bbbb -- x addr ) 8 lshift DMA1_CSELR ; \ DMA1_CSELR_C3S, DMA channel 3 selection
: DMA1_CSELR_C2S ( %bbbb -- x addr ) 4 lshift DMA1_CSELR ; \ DMA1_CSELR_C2S, DMA channel 2 selection
: DMA1_CSELR_C1S ( %bbbb -- x addr ) DMA1_CSELR ; \ DMA1_CSELR_C1S, DMA channel 1 selection

\ CRC_DR (read-write) Reset:0xFFFFFFFF
: CRC_DR_DR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) CRC_DR ; \ CRC_DR_DR, Data register bits

\ CRC_IDR (read-write) Reset:0x00000000
: CRC_IDR_IDR ( %bbbbbbbb -- x addr ) CRC_IDR ; \ CRC_IDR_IDR, General-purpose 8-bit data register  bits

\ CRC_CR (multiple-access)  Reset:0x00000000
: CRC_CR_REV_OUT ( -- x addr ) 7 bit CRC_CR ; \ CRC_CR_REV_OUT, Reverse output data
: CRC_CR_REV_IN ( %bb -- x addr ) 5 lshift CRC_CR ; \ CRC_CR_REV_IN, Reverse input data
: CRC_CR_POLYSIZE ( %bb -- x addr ) 3 lshift CRC_CR ; \ CRC_CR_POLYSIZE, Polynomial size
: CRC_CR_RESET ( -- x addr ) 0 bit CRC_CR ; \ CRC_CR_RESET, RESET bit

\ CRC_INIT (read-write) Reset:0xFFFFFFFF
: CRC_INIT_CRC_INIT ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) CRC_INIT ; \ CRC_INIT_CRC_INIT, Programmable initial CRC  value

\ CRC_POL (read-write) Reset:0x04C11DB7
: CRC_POL_Polynomialcoefficients ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) CRC_POL ; \ CRC_POL_Polynomialcoefficients, Programmable polynomial

\ GPIOA_MODER (read-write) Reset:0xEBFFFCFF
: GPIOA_MODER_MODE0 ( %bb -- x addr ) GPIOA_MODER ; \ GPIOA_MODER_MODE0, Port x configuration bits y =  0..15
: GPIOA_MODER_MODE1 ( %bb -- x addr ) 2 lshift GPIOA_MODER ; \ GPIOA_MODER_MODE1, Port x configuration bits y =  0..15
: GPIOA_MODER_MODE2 ( %bb -- x addr ) 4 lshift GPIOA_MODER ; \ GPIOA_MODER_MODE2, Port x configuration bits y =  0..15
: GPIOA_MODER_MODE3 ( %bb -- x addr ) 6 lshift GPIOA_MODER ; \ GPIOA_MODER_MODE3, Port x configuration bits y =  0..15
: GPIOA_MODER_MODE4 ( %bb -- x addr ) 8 lshift GPIOA_MODER ; \ GPIOA_MODER_MODE4, Port x configuration bits y =  0..15
: GPIOA_MODER_MODE5 ( %bb -- x addr ) 10 lshift GPIOA_MODER ; \ GPIOA_MODER_MODE5, Port x configuration bits y =  0..15
: GPIOA_MODER_MODE6 ( %bb -- x addr ) 12 lshift GPIOA_MODER ; \ GPIOA_MODER_MODE6, Port x configuration bits y =  0..15
: GPIOA_MODER_MODE7 ( %bb -- x addr ) 14 lshift GPIOA_MODER ; \ GPIOA_MODER_MODE7, Port x configuration bits y =  0..15
: GPIOA_MODER_MODE8 ( %bb -- x addr ) 16 lshift GPIOA_MODER ; \ GPIOA_MODER_MODE8, Port x configuration bits y =  0..15
: GPIOA_MODER_MODE9 ( %bb -- x addr ) 18 lshift GPIOA_MODER ; \ GPIOA_MODER_MODE9, Port x configuration bits y =  0..15
: GPIOA_MODER_MODE10 ( %bb -- x addr ) 20 lshift GPIOA_MODER ; \ GPIOA_MODER_MODE10, Port x configuration bits y =  0..15
: GPIOA_MODER_MODE11 ( %bb -- x addr ) 22 lshift GPIOA_MODER ; \ GPIOA_MODER_MODE11, Port x configuration bits y =  0..15
: GPIOA_MODER_MODE12 ( %bb -- x addr ) 24 lshift GPIOA_MODER ; \ GPIOA_MODER_MODE12, Port x configuration bits y =  0..15
: GPIOA_MODER_MODE13 ( %bb -- x addr ) 26 lshift GPIOA_MODER ; \ GPIOA_MODER_MODE13, Port x configuration bits y =  0..15
: GPIOA_MODER_MODE14 ( %bb -- x addr ) 28 lshift GPIOA_MODER ; \ GPIOA_MODER_MODE14, Port x configuration bits y =  0..15
: GPIOA_MODER_MODE15 ( %bb -- x addr ) 30 lshift GPIOA_MODER ; \ GPIOA_MODER_MODE15, Port x configuration bits y =  0..15

\ GPIOA_OTYPER (read-write) Reset:0x00000000
: GPIOA_OTYPER_OT15 ( -- x addr ) 15 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT15, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT14 ( -- x addr ) 14 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT14, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT13 ( -- x addr ) 13 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT13, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT12 ( -- x addr ) 12 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT12, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT11 ( -- x addr ) 11 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT11, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT10 ( -- x addr ) 10 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT10, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT9 ( -- x addr ) 9 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT9, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT8 ( -- x addr ) 8 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT8, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT7 ( -- x addr ) 7 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT7, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT6 ( -- x addr ) 6 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT6, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT5 ( -- x addr ) 5 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT5, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT4 ( -- x addr ) 4 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT4, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT3 ( -- x addr ) 3 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT3, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT2 ( -- x addr ) 2 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT2, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT1 ( -- x addr ) 1 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT1, Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT0 ( -- x addr ) 0 bit GPIOA_OTYPER ; \ GPIOA_OTYPER_OT0, Port x configuration bits y =  0..15

\ GPIOA_OSPEEDR (read-write) Reset:0x00000000
: GPIOA_OSPEEDR_OSPEED15 ( %bb -- x addr ) 30 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEED15, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEED14 ( %bb -- x addr ) 28 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEED14, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEED13 ( %bb -- x addr ) 26 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEED13, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEED12 ( %bb -- x addr ) 24 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEED12, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEED11 ( %bb -- x addr ) 22 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEED11, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEED10 ( %bb -- x addr ) 20 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEED10, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEED9 ( %bb -- x addr ) 18 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEED9, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEED8 ( %bb -- x addr ) 16 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEED8, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEED7 ( %bb -- x addr ) 14 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEED7, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEED6 ( %bb -- x addr ) 12 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEED6, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEED5 ( %bb -- x addr ) 10 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEED5, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEED4 ( %bb -- x addr ) 8 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEED4, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEED3 ( %bb -- x addr ) 6 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEED3, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEED2 ( %bb -- x addr ) 4 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEED2, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEED1 ( %bb -- x addr ) 2 lshift GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEED1, Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEED0 ( %bb -- x addr ) GPIOA_OSPEEDR ; \ GPIOA_OSPEEDR_OSPEED0, Port x configuration bits y =  0..15

\ GPIOA_PUPDR (read-write) Reset:0x24000000
: GPIOA_PUPDR_PUPD15 ( %bb -- x addr ) 30 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPD15, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPD14 ( %bb -- x addr ) 28 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPD14, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPD13 ( %bb -- x addr ) 26 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPD13, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPD12 ( %bb -- x addr ) 24 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPD12, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPD11 ( %bb -- x addr ) 22 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPD11, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPD10 ( %bb -- x addr ) 20 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPD10, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPD9 ( %bb -- x addr ) 18 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPD9, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPD8 ( %bb -- x addr ) 16 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPD8, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPD7 ( %bb -- x addr ) 14 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPD7, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPD6 ( %bb -- x addr ) 12 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPD6, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPD5 ( %bb -- x addr ) 10 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPD5, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPD4 ( %bb -- x addr ) 8 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPD4, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPD3 ( %bb -- x addr ) 6 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPD3, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPD2 ( %bb -- x addr ) 4 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPD2, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPD1 ( %bb -- x addr ) 2 lshift GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPD1, Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPD0 ( %bb -- x addr ) GPIOA_PUPDR ; \ GPIOA_PUPDR_PUPD0, Port x configuration bits y =  0..15

\ GPIOA_IDR (read-only) Reset:0x00000000
: GPIOA_IDR_ID15? ( --  1|0 ) 15 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_ID15, Port input data bit y =  0..15
: GPIOA_IDR_ID14? ( --  1|0 ) 14 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_ID14, Port input data bit y =  0..15
: GPIOA_IDR_ID13? ( --  1|0 ) 13 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_ID13, Port input data bit y =  0..15
: GPIOA_IDR_ID12? ( --  1|0 ) 12 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_ID12, Port input data bit y =  0..15
: GPIOA_IDR_ID11? ( --  1|0 ) 11 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_ID11, Port input data bit y =  0..15
: GPIOA_IDR_ID10? ( --  1|0 ) 10 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_ID10, Port input data bit y =  0..15
: GPIOA_IDR_ID9? ( --  1|0 ) 9 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_ID9, Port input data bit y =  0..15
: GPIOA_IDR_ID8? ( --  1|0 ) 8 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_ID8, Port input data bit y =  0..15
: GPIOA_IDR_ID7? ( --  1|0 ) 7 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_ID7, Port input data bit y =  0..15
: GPIOA_IDR_ID6? ( --  1|0 ) 6 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_ID6, Port input data bit y =  0..15
: GPIOA_IDR_ID5? ( --  1|0 ) 5 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_ID5, Port input data bit y =  0..15
: GPIOA_IDR_ID4? ( --  1|0 ) 4 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_ID4, Port input data bit y =  0..15
: GPIOA_IDR_ID3? ( --  1|0 ) 3 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_ID3, Port input data bit y =  0..15
: GPIOA_IDR_ID2? ( --  1|0 ) 2 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_ID2, Port input data bit y =  0..15
: GPIOA_IDR_ID1? ( --  1|0 ) 1 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_ID1, Port input data bit y =  0..15
: GPIOA_IDR_ID0? ( --  1|0 ) 0 bit GPIOA_IDR bit@ ; \ GPIOA_IDR_ID0, Port input data bit y =  0..15

\ GPIOA_ODR (read-write) Reset:0x00000000
: GPIOA_ODR_OD15 ( -- x addr ) 15 bit GPIOA_ODR ; \ GPIOA_ODR_OD15, Port output data bit y =  0..15
: GPIOA_ODR_OD14 ( -- x addr ) 14 bit GPIOA_ODR ; \ GPIOA_ODR_OD14, Port output data bit y =  0..15
: GPIOA_ODR_OD13 ( -- x addr ) 13 bit GPIOA_ODR ; \ GPIOA_ODR_OD13, Port output data bit y =  0..15
: GPIOA_ODR_OD12 ( -- x addr ) 12 bit GPIOA_ODR ; \ GPIOA_ODR_OD12, Port output data bit y =  0..15
: GPIOA_ODR_OD11 ( -- x addr ) 11 bit GPIOA_ODR ; \ GPIOA_ODR_OD11, Port output data bit y =  0..15
: GPIOA_ODR_OD10 ( -- x addr ) 10 bit GPIOA_ODR ; \ GPIOA_ODR_OD10, Port output data bit y =  0..15
: GPIOA_ODR_OD9 ( -- x addr ) 9 bit GPIOA_ODR ; \ GPIOA_ODR_OD9, Port output data bit y =  0..15
: GPIOA_ODR_OD8 ( -- x addr ) 8 bit GPIOA_ODR ; \ GPIOA_ODR_OD8, Port output data bit y =  0..15
: GPIOA_ODR_OD7 ( -- x addr ) 7 bit GPIOA_ODR ; \ GPIOA_ODR_OD7, Port output data bit y =  0..15
: GPIOA_ODR_OD6 ( -- x addr ) 6 bit GPIOA_ODR ; \ GPIOA_ODR_OD6, Port output data bit y =  0..15
: GPIOA_ODR_OD5 ( -- x addr ) 5 bit GPIOA_ODR ; \ GPIOA_ODR_OD5, Port output data bit y =  0..15
: GPIOA_ODR_OD4 ( -- x addr ) 4 bit GPIOA_ODR ; \ GPIOA_ODR_OD4, Port output data bit y =  0..15
: GPIOA_ODR_OD3 ( -- x addr ) 3 bit GPIOA_ODR ; \ GPIOA_ODR_OD3, Port output data bit y =  0..15
: GPIOA_ODR_OD2 ( -- x addr ) 2 bit GPIOA_ODR ; \ GPIOA_ODR_OD2, Port output data bit y =  0..15
: GPIOA_ODR_OD1 ( -- x addr ) 1 bit GPIOA_ODR ; \ GPIOA_ODR_OD1, Port output data bit y =  0..15
: GPIOA_ODR_OD0 ( -- x addr ) 0 bit GPIOA_ODR ; \ GPIOA_ODR_OD0, Port output data bit y =  0..15

\ GPIOA_BSRR (write-only) Reset:0x00000000
: GPIOA_BSRR_BR15 ( -- ) 31 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR15, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR14 ( -- ) 30 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR14, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR13 ( -- ) 29 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR13, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR12 ( -- ) 28 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR12, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR11 ( -- ) 27 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR11, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR10 ( -- ) 26 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR10, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR9 ( -- ) 25 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR9, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR8 ( -- ) 24 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR8, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR7 ( -- ) 23 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR7, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR6 ( -- ) 22 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR6, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR5 ( -- ) 21 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR5, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR4 ( -- ) 20 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR4, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR3 ( -- ) 19 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR3, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR2 ( -- ) 18 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR2, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR1 ( -- ) 17 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR1, Port x reset bit y y =  0..15
: GPIOA_BSRR_BR0 ( -- ) 16 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR0, Port x reset bit y y =  0..15
: GPIOA_BSRR_BS15 ( -- ) 15 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS15, Port x set bit y y=  0..15
: GPIOA_BSRR_BS14 ( -- ) 14 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS14, Port x set bit y y=  0..15
: GPIOA_BSRR_BS13 ( -- ) 13 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS13, Port x set bit y y=  0..15
: GPIOA_BSRR_BS12 ( -- ) 12 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS12, Port x set bit y y=  0..15
: GPIOA_BSRR_BS11 ( -- ) 11 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS11, Port x set bit y y=  0..15
: GPIOA_BSRR_BS10 ( -- ) 10 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS10, Port x set bit y y=  0..15
: GPIOA_BSRR_BS9 ( -- ) 9 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS9, Port x set bit y y=  0..15
: GPIOA_BSRR_BS8 ( -- ) 8 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS8, Port x set bit y y=  0..15
: GPIOA_BSRR_BS7 ( -- ) 7 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS7, Port x set bit y y=  0..15
: GPIOA_BSRR_BS6 ( -- ) 6 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS6, Port x set bit y y=  0..15
: GPIOA_BSRR_BS5 ( -- ) 5 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS5, Port x set bit y y=  0..15
: GPIOA_BSRR_BS4 ( -- ) 4 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS4, Port x set bit y y=  0..15
: GPIOA_BSRR_BS3 ( -- ) 3 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS3, Port x set bit y y=  0..15
: GPIOA_BSRR_BS2 ( -- ) 2 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS2, Port x set bit y y=  0..15
: GPIOA_BSRR_BS1 ( -- ) 1 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS1, Port x set bit y y=  0..15
: GPIOA_BSRR_BS0 ( -- ) 0 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS0, Port x set bit y y=  0..15

\ GPIOA_LCKR (read-write) Reset:0x00000000
: GPIOA_LCKR_LCKK ( -- x addr ) 16 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCKK, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK15 ( -- x addr ) 15 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK15, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK14 ( -- x addr ) 14 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK14, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK13 ( -- x addr ) 13 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK13, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK12 ( -- x addr ) 12 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK12, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK11 ( -- x addr ) 11 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK11, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK10 ( -- x addr ) 10 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK10, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK9 ( -- x addr ) 9 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK9, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK8 ( -- x addr ) 8 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK8, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK7 ( -- x addr ) 7 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK7, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK6 ( -- x addr ) 6 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK6, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK5 ( -- x addr ) 5 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK5, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK4 ( -- x addr ) 4 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK4, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK3 ( -- x addr ) 3 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK3, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK2 ( -- x addr ) 2 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK2, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK1 ( -- x addr ) 1 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK1, Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK0 ( -- x addr ) 0 bit GPIOA_LCKR ; \ GPIOA_LCKR_LCK0, Port x lock bit y y=  0..15

\ GPIOA_AFRL (read-write) Reset:0x00000000
: GPIOA_AFRL_AFSEL7 ( %bbbb -- x addr ) 28 lshift GPIOA_AFRL ; \ GPIOA_AFRL_AFSEL7, Alternate function selection for port x  pin y y = 0..7
: GPIOA_AFRL_AFSEL6 ( %bbbb -- x addr ) 24 lshift GPIOA_AFRL ; \ GPIOA_AFRL_AFSEL6, Alternate function selection for port x  pin y y = 0..7
: GPIOA_AFRL_AFSEL5 ( %bbbb -- x addr ) 20 lshift GPIOA_AFRL ; \ GPIOA_AFRL_AFSEL5, Alternate function selection for port x  pin y y = 0..7
: GPIOA_AFRL_AFSEL4 ( %bbbb -- x addr ) 16 lshift GPIOA_AFRL ; \ GPIOA_AFRL_AFSEL4, Alternate function selection for port x  pin y y = 0..7
: GPIOA_AFRL_AFSEL3 ( %bbbb -- x addr ) 12 lshift GPIOA_AFRL ; \ GPIOA_AFRL_AFSEL3, Alternate function selection for port x  pin y y = 0..7
: GPIOA_AFRL_AFSEL2 ( %bbbb -- x addr ) 8 lshift GPIOA_AFRL ; \ GPIOA_AFRL_AFSEL2, Alternate function selection for port x  pin y y = 0..7
: GPIOA_AFRL_AFSEL1 ( %bbbb -- x addr ) 4 lshift GPIOA_AFRL ; \ GPIOA_AFRL_AFSEL1, Alternate function selection for port x  pin y y = 0..7
: GPIOA_AFRL_AFSEL0 ( %bbbb -- x addr ) GPIOA_AFRL ; \ GPIOA_AFRL_AFSEL0, Alternate function selection for port x  pin y y = 0..7

\ GPIOA_AFRH (read-write) Reset:0x00000000
: GPIOA_AFRH_AFSEL15 ( %bbbb -- x addr ) 28 lshift GPIOA_AFRH ; \ GPIOA_AFRH_AFSEL15, Alternate function selection for port x  pin y y = 8..15
: GPIOA_AFRH_AFSEL14 ( %bbbb -- x addr ) 24 lshift GPIOA_AFRH ; \ GPIOA_AFRH_AFSEL14, Alternate function selection for port x  pin y y = 8..15
: GPIOA_AFRH_AFSEL13 ( %bbbb -- x addr ) 20 lshift GPIOA_AFRH ; \ GPIOA_AFRH_AFSEL13, Alternate function selection for port x  pin y y = 8..15
: GPIOA_AFRH_AFSEL12 ( %bbbb -- x addr ) 16 lshift GPIOA_AFRH ; \ GPIOA_AFRH_AFSEL12, Alternate function selection for port x  pin y y = 8..15
: GPIOA_AFRH_AFSEL11 ( %bbbb -- x addr ) 12 lshift GPIOA_AFRH ; \ GPIOA_AFRH_AFSEL11, Alternate function selection for port x  pin y y = 8..15
: GPIOA_AFRH_AFSEL10 ( %bbbb -- x addr ) 8 lshift GPIOA_AFRH ; \ GPIOA_AFRH_AFSEL10, Alternate function selection for port x  pin y y = 8..15
: GPIOA_AFRH_AFSEL9 ( %bbbb -- x addr ) 4 lshift GPIOA_AFRH ; \ GPIOA_AFRH_AFSEL9, Alternate function selection for port x  pin y y = 8..15
: GPIOA_AFRH_AFSEL8 ( %bbbb -- x addr ) GPIOA_AFRH ; \ GPIOA_AFRH_AFSEL8, Alternate function selection for port x  pin y y = 8..15

\ GPIOA_BRR (write-only) Reset:0x00000000
: GPIOA_BRR_BR15 ( -- ) 15 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR15, Port x Reset bit y y= 0 ..  15
: GPIOA_BRR_BR14 ( -- ) 14 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR14, Port x Reset bit y y= 0 ..  15
: GPIOA_BRR_BR13 ( -- ) 13 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR13, Port x Reset bit y y= 0 ..  15
: GPIOA_BRR_BR12 ( -- ) 12 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR12, Port x Reset bit y y= 0 ..  15
: GPIOA_BRR_BR11 ( -- ) 11 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR11, Port x Reset bit y y= 0 ..  15
: GPIOA_BRR_BR10 ( -- ) 10 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR10, Port x Reset bit y y= 0 ..  15
: GPIOA_BRR_BR9 ( -- ) 9 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR9, Port x Reset bit y y= 0 ..  15
: GPIOA_BRR_BR8 ( -- ) 8 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR8, Port x Reset bit y y= 0 ..  15
: GPIOA_BRR_BR7 ( -- ) 7 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR7, Port x Reset bit y y= 0 ..  15
: GPIOA_BRR_BR6 ( -- ) 6 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR6, Port x Reset bit y y= 0 ..  15
: GPIOA_BRR_BR5 ( -- ) 5 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR5, Port x Reset bit y y= 0 ..  15
: GPIOA_BRR_BR4 ( -- ) 4 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR4, Port x Reset bit y y= 0 ..  15
: GPIOA_BRR_BR3 ( -- ) 3 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR3, Port x Reset bit y y= 0 ..  15
: GPIOA_BRR_BR2 ( -- ) 2 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR2, Port x Reset bit y y= 0 ..  15
: GPIOA_BRR_BR1 ( -- ) 1 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR1, Port x Reset bit y y= 0 ..  15
: GPIOA_BRR_BR0 ( -- ) 0 bit GPIOA_BRR ! ; \ GPIOA_BRR_BR0, Port x Reset bit y y= 0 ..  15

\ GPIOB_MODER (read-write) Reset:0xFFFFFFFF
: GPIOB_MODER_MODE15 ( %bb -- x addr ) 30 lshift GPIOB_MODER ; \ GPIOB_MODER_MODE15, Port x configuration bits y =  0..15
: GPIOB_MODER_MODE14 ( %bb -- x addr ) 28 lshift GPIOB_MODER ; \ GPIOB_MODER_MODE14, Port x configuration bits y =  0..15
: GPIOB_MODER_MODE13 ( %bb -- x addr ) 26 lshift GPIOB_MODER ; \ GPIOB_MODER_MODE13, Port x configuration bits y =  0..15
: GPIOB_MODER_MODE12 ( %bb -- x addr ) 24 lshift GPIOB_MODER ; \ GPIOB_MODER_MODE12, Port x configuration bits y =  0..15
: GPIOB_MODER_MODE11 ( %bb -- x addr ) 22 lshift GPIOB_MODER ; \ GPIOB_MODER_MODE11, Port x configuration bits y =  0..15
: GPIOB_MODER_MODE10 ( %bb -- x addr ) 20 lshift GPIOB_MODER ; \ GPIOB_MODER_MODE10, Port x configuration bits y =  0..15
: GPIOB_MODER_MODE9 ( %bb -- x addr ) 18 lshift GPIOB_MODER ; \ GPIOB_MODER_MODE9, Port x configuration bits y =  0..15
: GPIOB_MODER_MODE8 ( %bb -- x addr ) 16 lshift GPIOB_MODER ; \ GPIOB_MODER_MODE8, Port x configuration bits y =  0..15
: GPIOB_MODER_MODE7 ( %bb -- x addr ) 14 lshift GPIOB_MODER ; \ GPIOB_MODER_MODE7, Port x configuration bits y =  0..15
: GPIOB_MODER_MODE6 ( %bb -- x addr ) 12 lshift GPIOB_MODER ; \ GPIOB_MODER_MODE6, Port x configuration bits y =  0..15
: GPIOB_MODER_MODE5 ( %bb -- x addr ) 10 lshift GPIOB_MODER ; \ GPIOB_MODER_MODE5, Port x configuration bits y =  0..15
: GPIOB_MODER_MODE4 ( %bb -- x addr ) 8 lshift GPIOB_MODER ; \ GPIOB_MODER_MODE4, Port x configuration bits y =  0..15
: GPIOB_MODER_MODE3 ( %bb -- x addr ) 6 lshift GPIOB_MODER ; \ GPIOB_MODER_MODE3, Port x configuration bits y =  0..15
: GPIOB_MODER_MODE2 ( %bb -- x addr ) 4 lshift GPIOB_MODER ; \ GPIOB_MODER_MODE2, Port x configuration bits y =  0..15
: GPIOB_MODER_MODE1 ( %bb -- x addr ) 2 lshift GPIOB_MODER ; \ GPIOB_MODER_MODE1, Port x configuration bits y =  0..15
: GPIOB_MODER_MODE0 ( %bb -- x addr ) GPIOB_MODER ; \ GPIOB_MODER_MODE0, Port x configuration bits y =  0..15

\ GPIOB_OTYPER (read-write) Reset:0x00000000
: GPIOB_OTYPER_OT15 ( -- x addr ) 15 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT15, Port x configuration bits y =  0..15
: GPIOB_OTYPER_OT14 ( -- x addr ) 14 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT14, Port x configuration bits y =  0..15
: GPIOB_OTYPER_OT13 ( -- x addr ) 13 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT13, Port x configuration bits y =  0..15
: GPIOB_OTYPER_OT12 ( -- x addr ) 12 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT12, Port x configuration bits y =  0..15
: GPIOB_OTYPER_OT11 ( -- x addr ) 11 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT11, Port x configuration bits y =  0..15
: GPIOB_OTYPER_OT10 ( -- x addr ) 10 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT10, Port x configuration bits y =  0..15
: GPIOB_OTYPER_OT9 ( -- x addr ) 9 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT9, Port x configuration bits y =  0..15
: GPIOB_OTYPER_OT8 ( -- x addr ) 8 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT8, Port x configuration bits y =  0..15
: GPIOB_OTYPER_OT7 ( -- x addr ) 7 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT7, Port x configuration bits y =  0..15
: GPIOB_OTYPER_OT6 ( -- x addr ) 6 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT6, Port x configuration bits y =  0..15
: GPIOB_OTYPER_OT5 ( -- x addr ) 5 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT5, Port x configuration bits y =  0..15
: GPIOB_OTYPER_OT4 ( -- x addr ) 4 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT4, Port x configuration bits y =  0..15
: GPIOB_OTYPER_OT3 ( -- x addr ) 3 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT3, Port x configuration bits y =  0..15
: GPIOB_OTYPER_OT2 ( -- x addr ) 2 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT2, Port x configuration bits y =  0..15
: GPIOB_OTYPER_OT1 ( -- x addr ) 1 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT1, Port x configuration bits y =  0..15
: GPIOB_OTYPER_OT0 ( -- x addr ) 0 bit GPIOB_OTYPER ; \ GPIOB_OTYPER_OT0, Port x configuration bits y =  0..15

\ GPIOB_OSPEEDR (read-write) Reset:0x00000000
: GPIOB_OSPEEDR_OSPEED15 ( %bb -- x addr ) 30 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEED15, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEED14 ( %bb -- x addr ) 28 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEED14, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEED13 ( %bb -- x addr ) 26 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEED13, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEED12 ( %bb -- x addr ) 24 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEED12, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEED11 ( %bb -- x addr ) 22 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEED11, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEED10 ( %bb -- x addr ) 20 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEED10, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEED9 ( %bb -- x addr ) 18 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEED9, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEED8 ( %bb -- x addr ) 16 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEED8, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEED7 ( %bb -- x addr ) 14 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEED7, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEED6 ( %bb -- x addr ) 12 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEED6, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEED5 ( %bb -- x addr ) 10 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEED5, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEED4 ( %bb -- x addr ) 8 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEED4, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEED3 ( %bb -- x addr ) 6 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEED3, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEED2 ( %bb -- x addr ) 4 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEED2, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEED1 ( %bb -- x addr ) 2 lshift GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEED1, Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEED0 ( %bb -- x addr ) GPIOB_OSPEEDR ; \ GPIOB_OSPEEDR_OSPEED0, Port x configuration bits y =  0..15

\ GPIOB_PUPDR (read-write) Reset:0x00000000
: GPIOB_PUPDR_PUPD15 ( %bb -- x addr ) 30 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPD15, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPD14 ( %bb -- x addr ) 28 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPD14, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPD13 ( %bb -- x addr ) 26 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPD13, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPD12 ( %bb -- x addr ) 24 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPD12, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPD11 ( %bb -- x addr ) 22 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPD11, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPD10 ( %bb -- x addr ) 20 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPD10, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPD9 ( %bb -- x addr ) 18 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPD9, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPD8 ( %bb -- x addr ) 16 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPD8, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPD7 ( %bb -- x addr ) 14 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPD7, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPD6 ( %bb -- x addr ) 12 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPD6, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPD5 ( %bb -- x addr ) 10 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPD5, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPD4 ( %bb -- x addr ) 8 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPD4, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPD3 ( %bb -- x addr ) 6 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPD3, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPD2 ( %bb -- x addr ) 4 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPD2, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPD1 ( %bb -- x addr ) 2 lshift GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPD1, Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPD0 ( %bb -- x addr ) GPIOB_PUPDR ; \ GPIOB_PUPDR_PUPD0, Port x configuration bits y =  0..15

\ GPIOB_IDR (read-only) Reset:0x00000000
: GPIOB_IDR_ID15? ( --  1|0 ) 15 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_ID15, Port input data bit y =  0..15
: GPIOB_IDR_ID14? ( --  1|0 ) 14 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_ID14, Port input data bit y =  0..15
: GPIOB_IDR_ID13? ( --  1|0 ) 13 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_ID13, Port input data bit y =  0..15
: GPIOB_IDR_ID12? ( --  1|0 ) 12 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_ID12, Port input data bit y =  0..15
: GPIOB_IDR_ID11? ( --  1|0 ) 11 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_ID11, Port input data bit y =  0..15
: GPIOB_IDR_ID10? ( --  1|0 ) 10 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_ID10, Port input data bit y =  0..15
: GPIOB_IDR_ID9? ( --  1|0 ) 9 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_ID9, Port input data bit y =  0..15
: GPIOB_IDR_ID8? ( --  1|0 ) 8 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_ID8, Port input data bit y =  0..15
: GPIOB_IDR_ID7? ( --  1|0 ) 7 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_ID7, Port input data bit y =  0..15
: GPIOB_IDR_ID6? ( --  1|0 ) 6 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_ID6, Port input data bit y =  0..15
: GPIOB_IDR_ID5? ( --  1|0 ) 5 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_ID5, Port input data bit y =  0..15
: GPIOB_IDR_ID4? ( --  1|0 ) 4 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_ID4, Port input data bit y =  0..15
: GPIOB_IDR_ID3? ( --  1|0 ) 3 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_ID3, Port input data bit y =  0..15
: GPIOB_IDR_ID2? ( --  1|0 ) 2 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_ID2, Port input data bit y =  0..15
: GPIOB_IDR_ID1? ( --  1|0 ) 1 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_ID1, Port input data bit y =  0..15
: GPIOB_IDR_ID0? ( --  1|0 ) 0 bit GPIOB_IDR bit@ ; \ GPIOB_IDR_ID0, Port input data bit y =  0..15

\ GPIOB_ODR (read-write) Reset:0x00000000
: GPIOB_ODR_OD15 ( -- x addr ) 15 bit GPIOB_ODR ; \ GPIOB_ODR_OD15, Port output data bit y =  0..15
: GPIOB_ODR_OD14 ( -- x addr ) 14 bit GPIOB_ODR ; \ GPIOB_ODR_OD14, Port output data bit y =  0..15
: GPIOB_ODR_OD13 ( -- x addr ) 13 bit GPIOB_ODR ; \ GPIOB_ODR_OD13, Port output data bit y =  0..15
: GPIOB_ODR_OD12 ( -- x addr ) 12 bit GPIOB_ODR ; \ GPIOB_ODR_OD12, Port output data bit y =  0..15
: GPIOB_ODR_OD11 ( -- x addr ) 11 bit GPIOB_ODR ; \ GPIOB_ODR_OD11, Port output data bit y =  0..15
: GPIOB_ODR_OD10 ( -- x addr ) 10 bit GPIOB_ODR ; \ GPIOB_ODR_OD10, Port output data bit y =  0..15
: GPIOB_ODR_OD9 ( -- x addr ) 9 bit GPIOB_ODR ; \ GPIOB_ODR_OD9, Port output data bit y =  0..15
: GPIOB_ODR_OD8 ( -- x addr ) 8 bit GPIOB_ODR ; \ GPIOB_ODR_OD8, Port output data bit y =  0..15
: GPIOB_ODR_OD7 ( -- x addr ) 7 bit GPIOB_ODR ; \ GPIOB_ODR_OD7, Port output data bit y =  0..15
: GPIOB_ODR_OD6 ( -- x addr ) 6 bit GPIOB_ODR ; \ GPIOB_ODR_OD6, Port output data bit y =  0..15
: GPIOB_ODR_OD5 ( -- x addr ) 5 bit GPIOB_ODR ; \ GPIOB_ODR_OD5, Port output data bit y =  0..15
: GPIOB_ODR_OD4 ( -- x addr ) 4 bit GPIOB_ODR ; \ GPIOB_ODR_OD4, Port output data bit y =  0..15
: GPIOB_ODR_OD3 ( -- x addr ) 3 bit GPIOB_ODR ; \ GPIOB_ODR_OD3, Port output data bit y =  0..15
: GPIOB_ODR_OD2 ( -- x addr ) 2 bit GPIOB_ODR ; \ GPIOB_ODR_OD2, Port output data bit y =  0..15
: GPIOB_ODR_OD1 ( -- x addr ) 1 bit GPIOB_ODR ; \ GPIOB_ODR_OD1, Port output data bit y =  0..15
: GPIOB_ODR_OD0 ( -- x addr ) 0 bit GPIOB_ODR ; \ GPIOB_ODR_OD0, Port output data bit y =  0..15

\ GPIOB_BSRR (write-only) Reset:0x00000000
: GPIOB_BSRR_BR15 ( -- ) 31 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR15, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR14 ( -- ) 30 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR14, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR13 ( -- ) 29 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR13, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR12 ( -- ) 28 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR12, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR11 ( -- ) 27 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR11, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR10 ( -- ) 26 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR10, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR9 ( -- ) 25 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR9, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR8 ( -- ) 24 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR8, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR7 ( -- ) 23 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR7, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR6 ( -- ) 22 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR6, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR5 ( -- ) 21 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR5, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR4 ( -- ) 20 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR4, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR3 ( -- ) 19 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR3, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR2 ( -- ) 18 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR2, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR1 ( -- ) 17 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR1, Port x reset bit y y =  0..15
: GPIOB_BSRR_BR0 ( -- ) 16 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BR0, Port x reset bit y y =  0..15
: GPIOB_BSRR_BS15 ( -- ) 15 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS15, Port x set bit y y=  0..15
: GPIOB_BSRR_BS14 ( -- ) 14 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS14, Port x set bit y y=  0..15
: GPIOB_BSRR_BS13 ( -- ) 13 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS13, Port x set bit y y=  0..15
: GPIOB_BSRR_BS12 ( -- ) 12 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS12, Port x set bit y y=  0..15
: GPIOB_BSRR_BS11 ( -- ) 11 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS11, Port x set bit y y=  0..15
: GPIOB_BSRR_BS10 ( -- ) 10 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS10, Port x set bit y y=  0..15
: GPIOB_BSRR_BS9 ( -- ) 9 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS9, Port x set bit y y=  0..15
: GPIOB_BSRR_BS8 ( -- ) 8 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS8, Port x set bit y y=  0..15
: GPIOB_BSRR_BS7 ( -- ) 7 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS7, Port x set bit y y=  0..15
: GPIOB_BSRR_BS6 ( -- ) 6 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS6, Port x set bit y y=  0..15
: GPIOB_BSRR_BS5 ( -- ) 5 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS5, Port x set bit y y=  0..15
: GPIOB_BSRR_BS4 ( -- ) 4 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS4, Port x set bit y y=  0..15
: GPIOB_BSRR_BS3 ( -- ) 3 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS3, Port x set bit y y=  0..15
: GPIOB_BSRR_BS2 ( -- ) 2 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS2, Port x set bit y y=  0..15
: GPIOB_BSRR_BS1 ( -- ) 1 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS1, Port x set bit y y=  0..15
: GPIOB_BSRR_BS0 ( -- ) 0 bit GPIOB_BSRR ! ; \ GPIOB_BSRR_BS0, Port x set bit y y=  0..15

\ GPIOB_LCKR (read-write) Reset:0x00000000
: GPIOB_LCKR_LCKK ( -- x addr ) 16 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCKK, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK15 ( -- x addr ) 15 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK15, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK14 ( -- x addr ) 14 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK14, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK13 ( -- x addr ) 13 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK13, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK12 ( -- x addr ) 12 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK12, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK11 ( -- x addr ) 11 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK11, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK10 ( -- x addr ) 10 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK10, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK9 ( -- x addr ) 9 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK9, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK8 ( -- x addr ) 8 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK8, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK7 ( -- x addr ) 7 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK7, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK6 ( -- x addr ) 6 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK6, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK5 ( -- x addr ) 5 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK5, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK4 ( -- x addr ) 4 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK4, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK3 ( -- x addr ) 3 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK3, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK2 ( -- x addr ) 2 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK2, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK1 ( -- x addr ) 1 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK1, Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK0 ( -- x addr ) 0 bit GPIOB_LCKR ; \ GPIOB_LCKR_LCK0, Port x lock bit y y=  0..15

\ GPIOB_AFRL (read-write) Reset:0x00000000
: GPIOB_AFRL_AFSEL7 ( %bbbb -- x addr ) 28 lshift GPIOB_AFRL ; \ GPIOB_AFRL_AFSEL7, Alternate function selection for port x  pin y y = 0..7
: GPIOB_AFRL_AFSEL6 ( %bbbb -- x addr ) 24 lshift GPIOB_AFRL ; \ GPIOB_AFRL_AFSEL6, Alternate function selection for port x  pin y y = 0..7
: GPIOB_AFRL_AFSEL5 ( %bbbb -- x addr ) 20 lshift GPIOB_AFRL ; \ GPIOB_AFRL_AFSEL5, Alternate function selection for port x  pin y y = 0..7
: GPIOB_AFRL_AFSEL4 ( %bbbb -- x addr ) 16 lshift GPIOB_AFRL ; \ GPIOB_AFRL_AFSEL4, Alternate function selection for port x  pin y y = 0..7
: GPIOB_AFRL_AFSEL3 ( %bbbb -- x addr ) 12 lshift GPIOB_AFRL ; \ GPIOB_AFRL_AFSEL3, Alternate function selection for port x  pin y y = 0..7
: GPIOB_AFRL_AFSEL2 ( %bbbb -- x addr ) 8 lshift GPIOB_AFRL ; \ GPIOB_AFRL_AFSEL2, Alternate function selection for port x  pin y y = 0..7
: GPIOB_AFRL_AFSEL1 ( %bbbb -- x addr ) 4 lshift GPIOB_AFRL ; \ GPIOB_AFRL_AFSEL1, Alternate function selection for port x  pin y y = 0..7
: GPIOB_AFRL_AFSEL0 ( %bbbb -- x addr ) GPIOB_AFRL ; \ GPIOB_AFRL_AFSEL0, Alternate function selection for port x  pin y y = 0..7

\ GPIOB_AFRH (read-write) Reset:0x00000000
: GPIOB_AFRH_AFSEL15 ( %bbbb -- x addr ) 28 lshift GPIOB_AFRH ; \ GPIOB_AFRH_AFSEL15, Alternate function selection for port x  pin y y = 8..15
: GPIOB_AFRH_AFSEL14 ( %bbbb -- x addr ) 24 lshift GPIOB_AFRH ; \ GPIOB_AFRH_AFSEL14, Alternate function selection for port x  pin y y = 8..15
: GPIOB_AFRH_AFSEL13 ( %bbbb -- x addr ) 20 lshift GPIOB_AFRH ; \ GPIOB_AFRH_AFSEL13, Alternate function selection for port x  pin y y = 8..15
: GPIOB_AFRH_AFSEL12 ( %bbbb -- x addr ) 16 lshift GPIOB_AFRH ; \ GPIOB_AFRH_AFSEL12, Alternate function selection for port x  pin y y = 8..15
: GPIOB_AFRH_AFSEL11 ( %bbbb -- x addr ) 12 lshift GPIOB_AFRH ; \ GPIOB_AFRH_AFSEL11, Alternate function selection for port x  pin y y = 8..15
: GPIOB_AFRH_AFSEL10 ( %bbbb -- x addr ) 8 lshift GPIOB_AFRH ; \ GPIOB_AFRH_AFSEL10, Alternate function selection for port x  pin y y = 8..15
: GPIOB_AFRH_AFSEL9 ( %bbbb -- x addr ) 4 lshift GPIOB_AFRH ; \ GPIOB_AFRH_AFSEL9, Alternate function selection for port x  pin y y = 8..15
: GPIOB_AFRH_AFSEL8 ( %bbbb -- x addr ) GPIOB_AFRH ; \ GPIOB_AFRH_AFSEL8, Alternate function selection for port x  pin y y = 8..15

\ GPIOB_BRR (write-only) Reset:0x00000000
: GPIOB_BRR_BR15 ( -- ) 15 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR15, Port x Reset bit y y= 0 ..  15
: GPIOB_BRR_BR14 ( -- ) 14 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR14, Port x Reset bit y y= 0 ..  15
: GPIOB_BRR_BR13 ( -- ) 13 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR13, Port x Reset bit y y= 0 ..  15
: GPIOB_BRR_BR12 ( -- ) 12 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR12, Port x Reset bit y y= 0 ..  15
: GPIOB_BRR_BR11 ( -- ) 11 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR11, Port x Reset bit y y= 0 ..  15
: GPIOB_BRR_BR10 ( -- ) 10 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR10, Port x Reset bit y y= 0 ..  15
: GPIOB_BRR_BR9 ( -- ) 9 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR9, Port x Reset bit y y= 0 ..  15
: GPIOB_BRR_BR8 ( -- ) 8 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR8, Port x Reset bit y y= 0 ..  15
: GPIOB_BRR_BR7 ( -- ) 7 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR7, Port x Reset bit y y= 0 ..  15
: GPIOB_BRR_BR6 ( -- ) 6 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR6, Port x Reset bit y y= 0 ..  15
: GPIOB_BRR_BR5 ( -- ) 5 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR5, Port x Reset bit y y= 0 ..  15
: GPIOB_BRR_BR4 ( -- ) 4 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR4, Port x Reset bit y y= 0 ..  15
: GPIOB_BRR_BR3 ( -- ) 3 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR3, Port x Reset bit y y= 0 ..  15
: GPIOB_BRR_BR2 ( -- ) 2 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR2, Port x Reset bit y y= 0 ..  15
: GPIOB_BRR_BR1 ( -- ) 1 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR1, Port x Reset bit y y= 0 ..  15
: GPIOB_BRR_BR0 ( -- ) 0 bit GPIOB_BRR ! ; \ GPIOB_BRR_BR0, Port x Reset bit y y= 0 ..  15

\ GPIOC_MODER (read-write) Reset:0xFFFFFFFF
: GPIOC_MODER_MODE15 ( %bb -- x addr ) 30 lshift GPIOC_MODER ; \ GPIOC_MODER_MODE15, Port x configuration bits y =  0..15
: GPIOC_MODER_MODE14 ( %bb -- x addr ) 28 lshift GPIOC_MODER ; \ GPIOC_MODER_MODE14, Port x configuration bits y =  0..15
: GPIOC_MODER_MODE13 ( %bb -- x addr ) 26 lshift GPIOC_MODER ; \ GPIOC_MODER_MODE13, Port x configuration bits y =  0..15
: GPIOC_MODER_MODE12 ( %bb -- x addr ) 24 lshift GPIOC_MODER ; \ GPIOC_MODER_MODE12, Port x configuration bits y =  0..15
: GPIOC_MODER_MODE11 ( %bb -- x addr ) 22 lshift GPIOC_MODER ; \ GPIOC_MODER_MODE11, Port x configuration bits y =  0..15
: GPIOC_MODER_MODE10 ( %bb -- x addr ) 20 lshift GPIOC_MODER ; \ GPIOC_MODER_MODE10, Port x configuration bits y =  0..15
: GPIOC_MODER_MODE9 ( %bb -- x addr ) 18 lshift GPIOC_MODER ; \ GPIOC_MODER_MODE9, Port x configuration bits y =  0..15
: GPIOC_MODER_MODE8 ( %bb -- x addr ) 16 lshift GPIOC_MODER ; \ GPIOC_MODER_MODE8, Port x configuration bits y =  0..15
: GPIOC_MODER_MODE7 ( %bb -- x addr ) 14 lshift GPIOC_MODER ; \ GPIOC_MODER_MODE7, Port x configuration bits y =  0..15
: GPIOC_MODER_MODE6 ( %bb -- x addr ) 12 lshift GPIOC_MODER ; \ GPIOC_MODER_MODE6, Port x configuration bits y =  0..15
: GPIOC_MODER_MODE5 ( %bb -- x addr ) 10 lshift GPIOC_MODER ; \ GPIOC_MODER_MODE5, Port x configuration bits y =  0..15
: GPIOC_MODER_MODE4 ( %bb -- x addr ) 8 lshift GPIOC_MODER ; \ GPIOC_MODER_MODE4, Port x configuration bits y =  0..15
: GPIOC_MODER_MODE3 ( %bb -- x addr ) 6 lshift GPIOC_MODER ; \ GPIOC_MODER_MODE3, Port x configuration bits y =  0..15
: GPIOC_MODER_MODE2 ( %bb -- x addr ) 4 lshift GPIOC_MODER ; \ GPIOC_MODER_MODE2, Port x configuration bits y =  0..15
: GPIOC_MODER_MODE1 ( %bb -- x addr ) 2 lshift GPIOC_MODER ; \ GPIOC_MODER_MODE1, Port x configuration bits y =  0..15
: GPIOC_MODER_MODE0 ( %bb -- x addr ) GPIOC_MODER ; \ GPIOC_MODER_MODE0, Port x configuration bits y =  0..15

\ GPIOC_OTYPER (read-write) Reset:0x00000000
: GPIOC_OTYPER_OT15 ( -- x addr ) 15 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT15, Port x configuration bits y =  0..15
: GPIOC_OTYPER_OT14 ( -- x addr ) 14 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT14, Port x configuration bits y =  0..15
: GPIOC_OTYPER_OT13 ( -- x addr ) 13 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT13, Port x configuration bits y =  0..15
: GPIOC_OTYPER_OT12 ( -- x addr ) 12 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT12, Port x configuration bits y =  0..15
: GPIOC_OTYPER_OT11 ( -- x addr ) 11 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT11, Port x configuration bits y =  0..15
: GPIOC_OTYPER_OT10 ( -- x addr ) 10 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT10, Port x configuration bits y =  0..15
: GPIOC_OTYPER_OT9 ( -- x addr ) 9 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT9, Port x configuration bits y =  0..15
: GPIOC_OTYPER_OT8 ( -- x addr ) 8 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT8, Port x configuration bits y =  0..15
: GPIOC_OTYPER_OT7 ( -- x addr ) 7 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT7, Port x configuration bits y =  0..15
: GPIOC_OTYPER_OT6 ( -- x addr ) 6 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT6, Port x configuration bits y =  0..15
: GPIOC_OTYPER_OT5 ( -- x addr ) 5 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT5, Port x configuration bits y =  0..15
: GPIOC_OTYPER_OT4 ( -- x addr ) 4 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT4, Port x configuration bits y =  0..15
: GPIOC_OTYPER_OT3 ( -- x addr ) 3 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT3, Port x configuration bits y =  0..15
: GPIOC_OTYPER_OT2 ( -- x addr ) 2 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT2, Port x configuration bits y =  0..15
: GPIOC_OTYPER_OT1 ( -- x addr ) 1 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT1, Port x configuration bits y =  0..15
: GPIOC_OTYPER_OT0 ( -- x addr ) 0 bit GPIOC_OTYPER ; \ GPIOC_OTYPER_OT0, Port x configuration bits y =  0..15

\ GPIOC_OSPEEDR (read-write) Reset:0x00000000
: GPIOC_OSPEEDR_OSPEED15 ( %bb -- x addr ) 30 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEED15, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEED14 ( %bb -- x addr ) 28 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEED14, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEED13 ( %bb -- x addr ) 26 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEED13, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEED12 ( %bb -- x addr ) 24 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEED12, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEED11 ( %bb -- x addr ) 22 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEED11, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEED10 ( %bb -- x addr ) 20 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEED10, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEED9 ( %bb -- x addr ) 18 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEED9, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEED8 ( %bb -- x addr ) 16 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEED8, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEED7 ( %bb -- x addr ) 14 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEED7, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEED6 ( %bb -- x addr ) 12 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEED6, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEED5 ( %bb -- x addr ) 10 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEED5, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEED4 ( %bb -- x addr ) 8 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEED4, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEED3 ( %bb -- x addr ) 6 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEED3, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEED2 ( %bb -- x addr ) 4 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEED2, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEED1 ( %bb -- x addr ) 2 lshift GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEED1, Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEED0 ( %bb -- x addr ) GPIOC_OSPEEDR ; \ GPIOC_OSPEEDR_OSPEED0, Port x configuration bits y =  0..15

\ GPIOC_PUPDR (read-write) Reset:0x00000000
: GPIOC_PUPDR_PUPD15 ( %bb -- x addr ) 30 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPD15, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPD14 ( %bb -- x addr ) 28 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPD14, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPD13 ( %bb -- x addr ) 26 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPD13, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPD12 ( %bb -- x addr ) 24 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPD12, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPD11 ( %bb -- x addr ) 22 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPD11, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPD10 ( %bb -- x addr ) 20 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPD10, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPD9 ( %bb -- x addr ) 18 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPD9, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPD8 ( %bb -- x addr ) 16 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPD8, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPD7 ( %bb -- x addr ) 14 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPD7, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPD6 ( %bb -- x addr ) 12 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPD6, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPD5 ( %bb -- x addr ) 10 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPD5, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPD4 ( %bb -- x addr ) 8 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPD4, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPD3 ( %bb -- x addr ) 6 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPD3, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPD2 ( %bb -- x addr ) 4 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPD2, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPD1 ( %bb -- x addr ) 2 lshift GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPD1, Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPD0 ( %bb -- x addr ) GPIOC_PUPDR ; \ GPIOC_PUPDR_PUPD0, Port x configuration bits y =  0..15

\ GPIOC_IDR (read-only) Reset:0x00000000
: GPIOC_IDR_ID15? ( --  1|0 ) 15 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_ID15, Port input data bit y =  0..15
: GPIOC_IDR_ID14? ( --  1|0 ) 14 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_ID14, Port input data bit y =  0..15
: GPIOC_IDR_ID13? ( --  1|0 ) 13 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_ID13, Port input data bit y =  0..15
: GPIOC_IDR_ID12? ( --  1|0 ) 12 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_ID12, Port input data bit y =  0..15
: GPIOC_IDR_ID11? ( --  1|0 ) 11 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_ID11, Port input data bit y =  0..15
: GPIOC_IDR_ID10? ( --  1|0 ) 10 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_ID10, Port input data bit y =  0..15
: GPIOC_IDR_ID9? ( --  1|0 ) 9 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_ID9, Port input data bit y =  0..15
: GPIOC_IDR_ID8? ( --  1|0 ) 8 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_ID8, Port input data bit y =  0..15
: GPIOC_IDR_ID7? ( --  1|0 ) 7 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_ID7, Port input data bit y =  0..15
: GPIOC_IDR_ID6? ( --  1|0 ) 6 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_ID6, Port input data bit y =  0..15
: GPIOC_IDR_ID5? ( --  1|0 ) 5 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_ID5, Port input data bit y =  0..15
: GPIOC_IDR_ID4? ( --  1|0 ) 4 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_ID4, Port input data bit y =  0..15
: GPIOC_IDR_ID3? ( --  1|0 ) 3 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_ID3, Port input data bit y =  0..15
: GPIOC_IDR_ID2? ( --  1|0 ) 2 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_ID2, Port input data bit y =  0..15
: GPIOC_IDR_ID1? ( --  1|0 ) 1 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_ID1, Port input data bit y =  0..15
: GPIOC_IDR_ID0? ( --  1|0 ) 0 bit GPIOC_IDR bit@ ; \ GPIOC_IDR_ID0, Port input data bit y =  0..15

\ GPIOC_ODR (read-write) Reset:0x00000000
: GPIOC_ODR_OD15 ( -- x addr ) 15 bit GPIOC_ODR ; \ GPIOC_ODR_OD15, Port output data bit y =  0..15
: GPIOC_ODR_OD14 ( -- x addr ) 14 bit GPIOC_ODR ; \ GPIOC_ODR_OD14, Port output data bit y =  0..15
: GPIOC_ODR_OD13 ( -- x addr ) 13 bit GPIOC_ODR ; \ GPIOC_ODR_OD13, Port output data bit y =  0..15
: GPIOC_ODR_OD12 ( -- x addr ) 12 bit GPIOC_ODR ; \ GPIOC_ODR_OD12, Port output data bit y =  0..15
: GPIOC_ODR_OD11 ( -- x addr ) 11 bit GPIOC_ODR ; \ GPIOC_ODR_OD11, Port output data bit y =  0..15
: GPIOC_ODR_OD10 ( -- x addr ) 10 bit GPIOC_ODR ; \ GPIOC_ODR_OD10, Port output data bit y =  0..15
: GPIOC_ODR_OD9 ( -- x addr ) 9 bit GPIOC_ODR ; \ GPIOC_ODR_OD9, Port output data bit y =  0..15
: GPIOC_ODR_OD8 ( -- x addr ) 8 bit GPIOC_ODR ; \ GPIOC_ODR_OD8, Port output data bit y =  0..15
: GPIOC_ODR_OD7 ( -- x addr ) 7 bit GPIOC_ODR ; \ GPIOC_ODR_OD7, Port output data bit y =  0..15
: GPIOC_ODR_OD6 ( -- x addr ) 6 bit GPIOC_ODR ; \ GPIOC_ODR_OD6, Port output data bit y =  0..15
: GPIOC_ODR_OD5 ( -- x addr ) 5 bit GPIOC_ODR ; \ GPIOC_ODR_OD5, Port output data bit y =  0..15
: GPIOC_ODR_OD4 ( -- x addr ) 4 bit GPIOC_ODR ; \ GPIOC_ODR_OD4, Port output data bit y =  0..15
: GPIOC_ODR_OD3 ( -- x addr ) 3 bit GPIOC_ODR ; \ GPIOC_ODR_OD3, Port output data bit y =  0..15
: GPIOC_ODR_OD2 ( -- x addr ) 2 bit GPIOC_ODR ; \ GPIOC_ODR_OD2, Port output data bit y =  0..15
: GPIOC_ODR_OD1 ( -- x addr ) 1 bit GPIOC_ODR ; \ GPIOC_ODR_OD1, Port output data bit y =  0..15
: GPIOC_ODR_OD0 ( -- x addr ) 0 bit GPIOC_ODR ; \ GPIOC_ODR_OD0, Port output data bit y =  0..15

\ GPIOC_BSRR (write-only) Reset:0x00000000
: GPIOC_BSRR_BR15 ( -- ) 31 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR15, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR14 ( -- ) 30 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR14, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR13 ( -- ) 29 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR13, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR12 ( -- ) 28 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR12, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR11 ( -- ) 27 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR11, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR10 ( -- ) 26 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR10, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR9 ( -- ) 25 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR9, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR8 ( -- ) 24 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR8, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR7 ( -- ) 23 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR7, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR6 ( -- ) 22 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR6, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR5 ( -- ) 21 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR5, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR4 ( -- ) 20 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR4, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR3 ( -- ) 19 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR3, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR2 ( -- ) 18 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR2, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR1 ( -- ) 17 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR1, Port x reset bit y y =  0..15
: GPIOC_BSRR_BR0 ( -- ) 16 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BR0, Port x reset bit y y =  0..15
: GPIOC_BSRR_BS15 ( -- ) 15 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS15, Port x set bit y y=  0..15
: GPIOC_BSRR_BS14 ( -- ) 14 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS14, Port x set bit y y=  0..15
: GPIOC_BSRR_BS13 ( -- ) 13 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS13, Port x set bit y y=  0..15
: GPIOC_BSRR_BS12 ( -- ) 12 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS12, Port x set bit y y=  0..15
: GPIOC_BSRR_BS11 ( -- ) 11 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS11, Port x set bit y y=  0..15
: GPIOC_BSRR_BS10 ( -- ) 10 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS10, Port x set bit y y=  0..15
: GPIOC_BSRR_BS9 ( -- ) 9 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS9, Port x set bit y y=  0..15
: GPIOC_BSRR_BS8 ( -- ) 8 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS8, Port x set bit y y=  0..15
: GPIOC_BSRR_BS7 ( -- ) 7 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS7, Port x set bit y y=  0..15
: GPIOC_BSRR_BS6 ( -- ) 6 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS6, Port x set bit y y=  0..15
: GPIOC_BSRR_BS5 ( -- ) 5 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS5, Port x set bit y y=  0..15
: GPIOC_BSRR_BS4 ( -- ) 4 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS4, Port x set bit y y=  0..15
: GPIOC_BSRR_BS3 ( -- ) 3 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS3, Port x set bit y y=  0..15
: GPIOC_BSRR_BS2 ( -- ) 2 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS2, Port x set bit y y=  0..15
: GPIOC_BSRR_BS1 ( -- ) 1 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS1, Port x set bit y y=  0..15
: GPIOC_BSRR_BS0 ( -- ) 0 bit GPIOC_BSRR ! ; \ GPIOC_BSRR_BS0, Port x set bit y y=  0..15

\ GPIOC_LCKR (read-write) Reset:0x00000000
: GPIOC_LCKR_LCKK ( -- x addr ) 16 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCKK, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK15 ( -- x addr ) 15 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK15, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK14 ( -- x addr ) 14 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK14, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK13 ( -- x addr ) 13 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK13, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK12 ( -- x addr ) 12 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK12, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK11 ( -- x addr ) 11 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK11, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK10 ( -- x addr ) 10 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK10, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK9 ( -- x addr ) 9 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK9, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK8 ( -- x addr ) 8 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK8, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK7 ( -- x addr ) 7 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK7, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK6 ( -- x addr ) 6 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK6, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK5 ( -- x addr ) 5 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK5, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK4 ( -- x addr ) 4 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK4, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK3 ( -- x addr ) 3 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK3, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK2 ( -- x addr ) 2 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK2, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK1 ( -- x addr ) 1 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK1, Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK0 ( -- x addr ) 0 bit GPIOC_LCKR ; \ GPIOC_LCKR_LCK0, Port x lock bit y y=  0..15

\ GPIOC_AFRL (read-write) Reset:0x00000000
: GPIOC_AFRL_AFSEL7 ( %bbbb -- x addr ) 28 lshift GPIOC_AFRL ; \ GPIOC_AFRL_AFSEL7, Alternate function selection for port x  pin y y = 0..7
: GPIOC_AFRL_AFSEL6 ( %bbbb -- x addr ) 24 lshift GPIOC_AFRL ; \ GPIOC_AFRL_AFSEL6, Alternate function selection for port x  pin y y = 0..7
: GPIOC_AFRL_AFSEL5 ( %bbbb -- x addr ) 20 lshift GPIOC_AFRL ; \ GPIOC_AFRL_AFSEL5, Alternate function selection for port x  pin y y = 0..7
: GPIOC_AFRL_AFSEL4 ( %bbbb -- x addr ) 16 lshift GPIOC_AFRL ; \ GPIOC_AFRL_AFSEL4, Alternate function selection for port x  pin y y = 0..7
: GPIOC_AFRL_AFSEL3 ( %bbbb -- x addr ) 12 lshift GPIOC_AFRL ; \ GPIOC_AFRL_AFSEL3, Alternate function selection for port x  pin y y = 0..7
: GPIOC_AFRL_AFSEL2 ( %bbbb -- x addr ) 8 lshift GPIOC_AFRL ; \ GPIOC_AFRL_AFSEL2, Alternate function selection for port x  pin y y = 0..7
: GPIOC_AFRL_AFSEL1 ( %bbbb -- x addr ) 4 lshift GPIOC_AFRL ; \ GPIOC_AFRL_AFSEL1, Alternate function selection for port x  pin y y = 0..7
: GPIOC_AFRL_AFSEL0 ( %bbbb -- x addr ) GPIOC_AFRL ; \ GPIOC_AFRL_AFSEL0, Alternate function selection for port x  pin y y = 0..7

\ GPIOC_AFRH (read-write) Reset:0x00000000
: GPIOC_AFRH_AFSEL15 ( %bbbb -- x addr ) 28 lshift GPIOC_AFRH ; \ GPIOC_AFRH_AFSEL15, Alternate function selection for port x  pin y y = 8..15
: GPIOC_AFRH_AFSEL14 ( %bbbb -- x addr ) 24 lshift GPIOC_AFRH ; \ GPIOC_AFRH_AFSEL14, Alternate function selection for port x  pin y y = 8..15
: GPIOC_AFRH_AFSEL13 ( %bbbb -- x addr ) 20 lshift GPIOC_AFRH ; \ GPIOC_AFRH_AFSEL13, Alternate function selection for port x  pin y y = 8..15
: GPIOC_AFRH_AFSEL12 ( %bbbb -- x addr ) 16 lshift GPIOC_AFRH ; \ GPIOC_AFRH_AFSEL12, Alternate function selection for port x  pin y y = 8..15
: GPIOC_AFRH_AFSEL11 ( %bbbb -- x addr ) 12 lshift GPIOC_AFRH ; \ GPIOC_AFRH_AFSEL11, Alternate function selection for port x  pin y y = 8..15
: GPIOC_AFRH_AFSEL10 ( %bbbb -- x addr ) 8 lshift GPIOC_AFRH ; \ GPIOC_AFRH_AFSEL10, Alternate function selection for port x  pin y y = 8..15
: GPIOC_AFRH_AFSEL9 ( %bbbb -- x addr ) 4 lshift GPIOC_AFRH ; \ GPIOC_AFRH_AFSEL9, Alternate function selection for port x  pin y y = 8..15
: GPIOC_AFRH_AFSEL8 ( %bbbb -- x addr ) GPIOC_AFRH ; \ GPIOC_AFRH_AFSEL8, Alternate function selection for port x  pin y y = 8..15

\ GPIOC_BRR (write-only) Reset:0x00000000
: GPIOC_BRR_BR15 ( -- ) 15 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR15, Port x Reset bit y y= 0 ..  15
: GPIOC_BRR_BR14 ( -- ) 14 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR14, Port x Reset bit y y= 0 ..  15
: GPIOC_BRR_BR13 ( -- ) 13 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR13, Port x Reset bit y y= 0 ..  15
: GPIOC_BRR_BR12 ( -- ) 12 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR12, Port x Reset bit y y= 0 ..  15
: GPIOC_BRR_BR11 ( -- ) 11 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR11, Port x Reset bit y y= 0 ..  15
: GPIOC_BRR_BR10 ( -- ) 10 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR10, Port x Reset bit y y= 0 ..  15
: GPIOC_BRR_BR9 ( -- ) 9 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR9, Port x Reset bit y y= 0 ..  15
: GPIOC_BRR_BR8 ( -- ) 8 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR8, Port x Reset bit y y= 0 ..  15
: GPIOC_BRR_BR7 ( -- ) 7 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR7, Port x Reset bit y y= 0 ..  15
: GPIOC_BRR_BR6 ( -- ) 6 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR6, Port x Reset bit y y= 0 ..  15
: GPIOC_BRR_BR5 ( -- ) 5 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR5, Port x Reset bit y y= 0 ..  15
: GPIOC_BRR_BR4 ( -- ) 4 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR4, Port x Reset bit y y= 0 ..  15
: GPIOC_BRR_BR3 ( -- ) 3 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR3, Port x Reset bit y y= 0 ..  15
: GPIOC_BRR_BR2 ( -- ) 2 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR2, Port x Reset bit y y= 0 ..  15
: GPIOC_BRR_BR1 ( -- ) 1 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR1, Port x Reset bit y y= 0 ..  15
: GPIOC_BRR_BR0 ( -- ) 0 bit GPIOC_BRR ! ; \ GPIOC_BRR_BR0, Port x Reset bit y y= 0 ..  15

\ GPIOD_MODER (read-write) Reset:0xFFFFFFFF
: GPIOD_MODER_MODE15 ( %bb -- x addr ) 30 lshift GPIOD_MODER ; \ GPIOD_MODER_MODE15, Port x configuration bits y =  0..15
: GPIOD_MODER_MODE14 ( %bb -- x addr ) 28 lshift GPIOD_MODER ; \ GPIOD_MODER_MODE14, Port x configuration bits y =  0..15
: GPIOD_MODER_MODE13 ( %bb -- x addr ) 26 lshift GPIOD_MODER ; \ GPIOD_MODER_MODE13, Port x configuration bits y =  0..15
: GPIOD_MODER_MODE12 ( %bb -- x addr ) 24 lshift GPIOD_MODER ; \ GPIOD_MODER_MODE12, Port x configuration bits y =  0..15
: GPIOD_MODER_MODE11 ( %bb -- x addr ) 22 lshift GPIOD_MODER ; \ GPIOD_MODER_MODE11, Port x configuration bits y =  0..15
: GPIOD_MODER_MODE10 ( %bb -- x addr ) 20 lshift GPIOD_MODER ; \ GPIOD_MODER_MODE10, Port x configuration bits y =  0..15
: GPIOD_MODER_MODE9 ( %bb -- x addr ) 18 lshift GPIOD_MODER ; \ GPIOD_MODER_MODE9, Port x configuration bits y =  0..15
: GPIOD_MODER_MODE8 ( %bb -- x addr ) 16 lshift GPIOD_MODER ; \ GPIOD_MODER_MODE8, Port x configuration bits y =  0..15
: GPIOD_MODER_MODE7 ( %bb -- x addr ) 14 lshift GPIOD_MODER ; \ GPIOD_MODER_MODE7, Port x configuration bits y =  0..15
: GPIOD_MODER_MODE6 ( %bb -- x addr ) 12 lshift GPIOD_MODER ; \ GPIOD_MODER_MODE6, Port x configuration bits y =  0..15
: GPIOD_MODER_MODE5 ( %bb -- x addr ) 10 lshift GPIOD_MODER ; \ GPIOD_MODER_MODE5, Port x configuration bits y =  0..15
: GPIOD_MODER_MODE4 ( %bb -- x addr ) 8 lshift GPIOD_MODER ; \ GPIOD_MODER_MODE4, Port x configuration bits y =  0..15
: GPIOD_MODER_MODE3 ( %bb -- x addr ) 6 lshift GPIOD_MODER ; \ GPIOD_MODER_MODE3, Port x configuration bits y =  0..15
: GPIOD_MODER_MODE2 ( %bb -- x addr ) 4 lshift GPIOD_MODER ; \ GPIOD_MODER_MODE2, Port x configuration bits y =  0..15
: GPIOD_MODER_MODE1 ( %bb -- x addr ) 2 lshift GPIOD_MODER ; \ GPIOD_MODER_MODE1, Port x configuration bits y =  0..15
: GPIOD_MODER_MODE0 ( %bb -- x addr ) GPIOD_MODER ; \ GPIOD_MODER_MODE0, Port x configuration bits y =  0..15

\ GPIOD_OTYPER (read-write) Reset:0x00000000
: GPIOD_OTYPER_OT15 ( -- x addr ) 15 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT15, Port x configuration bits y =  0..15
: GPIOD_OTYPER_OT14 ( -- x addr ) 14 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT14, Port x configuration bits y =  0..15
: GPIOD_OTYPER_OT13 ( -- x addr ) 13 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT13, Port x configuration bits y =  0..15
: GPIOD_OTYPER_OT12 ( -- x addr ) 12 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT12, Port x configuration bits y =  0..15
: GPIOD_OTYPER_OT11 ( -- x addr ) 11 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT11, Port x configuration bits y =  0..15
: GPIOD_OTYPER_OT10 ( -- x addr ) 10 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT10, Port x configuration bits y =  0..15
: GPIOD_OTYPER_OT9 ( -- x addr ) 9 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT9, Port x configuration bits y =  0..15
: GPIOD_OTYPER_OT8 ( -- x addr ) 8 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT8, Port x configuration bits y =  0..15
: GPIOD_OTYPER_OT7 ( -- x addr ) 7 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT7, Port x configuration bits y =  0..15
: GPIOD_OTYPER_OT6 ( -- x addr ) 6 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT6, Port x configuration bits y =  0..15
: GPIOD_OTYPER_OT5 ( -- x addr ) 5 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT5, Port x configuration bits y =  0..15
: GPIOD_OTYPER_OT4 ( -- x addr ) 4 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT4, Port x configuration bits y =  0..15
: GPIOD_OTYPER_OT3 ( -- x addr ) 3 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT3, Port x configuration bits y =  0..15
: GPIOD_OTYPER_OT2 ( -- x addr ) 2 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT2, Port x configuration bits y =  0..15
: GPIOD_OTYPER_OT1 ( -- x addr ) 1 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT1, Port x configuration bits y =  0..15
: GPIOD_OTYPER_OT0 ( -- x addr ) 0 bit GPIOD_OTYPER ; \ GPIOD_OTYPER_OT0, Port x configuration bits y =  0..15

\ GPIOD_OSPEEDR (read-write) Reset:0x00000000
: GPIOD_OSPEEDR_OSPEED15 ( %bb -- x addr ) 30 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEED15, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEED14 ( %bb -- x addr ) 28 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEED14, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEED13 ( %bb -- x addr ) 26 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEED13, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEED12 ( %bb -- x addr ) 24 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEED12, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEED11 ( %bb -- x addr ) 22 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEED11, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEED10 ( %bb -- x addr ) 20 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEED10, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEED9 ( %bb -- x addr ) 18 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEED9, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEED8 ( %bb -- x addr ) 16 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEED8, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEED7 ( %bb -- x addr ) 14 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEED7, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEED6 ( %bb -- x addr ) 12 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEED6, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEED5 ( %bb -- x addr ) 10 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEED5, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEED4 ( %bb -- x addr ) 8 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEED4, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEED3 ( %bb -- x addr ) 6 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEED3, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEED2 ( %bb -- x addr ) 4 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEED2, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEED1 ( %bb -- x addr ) 2 lshift GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEED1, Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEED0 ( %bb -- x addr ) GPIOD_OSPEEDR ; \ GPIOD_OSPEEDR_OSPEED0, Port x configuration bits y =  0..15

\ GPIOD_PUPDR (read-write) Reset:0x00000000
: GPIOD_PUPDR_PUPD15 ( %bb -- x addr ) 30 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPD15, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPD14 ( %bb -- x addr ) 28 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPD14, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPD13 ( %bb -- x addr ) 26 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPD13, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPD12 ( %bb -- x addr ) 24 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPD12, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPD11 ( %bb -- x addr ) 22 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPD11, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPD10 ( %bb -- x addr ) 20 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPD10, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPD9 ( %bb -- x addr ) 18 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPD9, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPD8 ( %bb -- x addr ) 16 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPD8, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPD7 ( %bb -- x addr ) 14 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPD7, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPD6 ( %bb -- x addr ) 12 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPD6, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPD5 ( %bb -- x addr ) 10 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPD5, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPD4 ( %bb -- x addr ) 8 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPD4, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPD3 ( %bb -- x addr ) 6 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPD3, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPD2 ( %bb -- x addr ) 4 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPD2, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPD1 ( %bb -- x addr ) 2 lshift GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPD1, Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPD0 ( %bb -- x addr ) GPIOD_PUPDR ; \ GPIOD_PUPDR_PUPD0, Port x configuration bits y =  0..15

\ GPIOD_IDR (read-only) Reset:0x00000000
: GPIOD_IDR_ID15? ( --  1|0 ) 15 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_ID15, Port input data bit y =  0..15
: GPIOD_IDR_ID14? ( --  1|0 ) 14 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_ID14, Port input data bit y =  0..15
: GPIOD_IDR_ID13? ( --  1|0 ) 13 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_ID13, Port input data bit y =  0..15
: GPIOD_IDR_ID12? ( --  1|0 ) 12 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_ID12, Port input data bit y =  0..15
: GPIOD_IDR_ID11? ( --  1|0 ) 11 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_ID11, Port input data bit y =  0..15
: GPIOD_IDR_ID10? ( --  1|0 ) 10 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_ID10, Port input data bit y =  0..15
: GPIOD_IDR_ID9? ( --  1|0 ) 9 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_ID9, Port input data bit y =  0..15
: GPIOD_IDR_ID8? ( --  1|0 ) 8 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_ID8, Port input data bit y =  0..15
: GPIOD_IDR_ID7? ( --  1|0 ) 7 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_ID7, Port input data bit y =  0..15
: GPIOD_IDR_ID6? ( --  1|0 ) 6 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_ID6, Port input data bit y =  0..15
: GPIOD_IDR_ID5? ( --  1|0 ) 5 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_ID5, Port input data bit y =  0..15
: GPIOD_IDR_ID4? ( --  1|0 ) 4 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_ID4, Port input data bit y =  0..15
: GPIOD_IDR_ID3? ( --  1|0 ) 3 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_ID3, Port input data bit y =  0..15
: GPIOD_IDR_ID2? ( --  1|0 ) 2 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_ID2, Port input data bit y =  0..15
: GPIOD_IDR_ID1? ( --  1|0 ) 1 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_ID1, Port input data bit y =  0..15
: GPIOD_IDR_ID0? ( --  1|0 ) 0 bit GPIOD_IDR bit@ ; \ GPIOD_IDR_ID0, Port input data bit y =  0..15

\ GPIOD_ODR (read-write) Reset:0x00000000
: GPIOD_ODR_OD15 ( -- x addr ) 15 bit GPIOD_ODR ; \ GPIOD_ODR_OD15, Port output data bit y =  0..15
: GPIOD_ODR_OD14 ( -- x addr ) 14 bit GPIOD_ODR ; \ GPIOD_ODR_OD14, Port output data bit y =  0..15
: GPIOD_ODR_OD13 ( -- x addr ) 13 bit GPIOD_ODR ; \ GPIOD_ODR_OD13, Port output data bit y =  0..15
: GPIOD_ODR_OD12 ( -- x addr ) 12 bit GPIOD_ODR ; \ GPIOD_ODR_OD12, Port output data bit y =  0..15
: GPIOD_ODR_OD11 ( -- x addr ) 11 bit GPIOD_ODR ; \ GPIOD_ODR_OD11, Port output data bit y =  0..15
: GPIOD_ODR_OD10 ( -- x addr ) 10 bit GPIOD_ODR ; \ GPIOD_ODR_OD10, Port output data bit y =  0..15
: GPIOD_ODR_OD9 ( -- x addr ) 9 bit GPIOD_ODR ; \ GPIOD_ODR_OD9, Port output data bit y =  0..15
: GPIOD_ODR_OD8 ( -- x addr ) 8 bit GPIOD_ODR ; \ GPIOD_ODR_OD8, Port output data bit y =  0..15
: GPIOD_ODR_OD7 ( -- x addr ) 7 bit GPIOD_ODR ; \ GPIOD_ODR_OD7, Port output data bit y =  0..15
: GPIOD_ODR_OD6 ( -- x addr ) 6 bit GPIOD_ODR ; \ GPIOD_ODR_OD6, Port output data bit y =  0..15
: GPIOD_ODR_OD5 ( -- x addr ) 5 bit GPIOD_ODR ; \ GPIOD_ODR_OD5, Port output data bit y =  0..15
: GPIOD_ODR_OD4 ( -- x addr ) 4 bit GPIOD_ODR ; \ GPIOD_ODR_OD4, Port output data bit y =  0..15
: GPIOD_ODR_OD3 ( -- x addr ) 3 bit GPIOD_ODR ; \ GPIOD_ODR_OD3, Port output data bit y =  0..15
: GPIOD_ODR_OD2 ( -- x addr ) 2 bit GPIOD_ODR ; \ GPIOD_ODR_OD2, Port output data bit y =  0..15
: GPIOD_ODR_OD1 ( -- x addr ) 1 bit GPIOD_ODR ; \ GPIOD_ODR_OD1, Port output data bit y =  0..15
: GPIOD_ODR_OD0 ( -- x addr ) 0 bit GPIOD_ODR ; \ GPIOD_ODR_OD0, Port output data bit y =  0..15

\ GPIOD_BSRR (write-only) Reset:0x00000000
: GPIOD_BSRR_BR15 ( -- ) 31 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR15, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR14 ( -- ) 30 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR14, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR13 ( -- ) 29 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR13, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR12 ( -- ) 28 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR12, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR11 ( -- ) 27 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR11, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR10 ( -- ) 26 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR10, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR9 ( -- ) 25 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR9, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR8 ( -- ) 24 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR8, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR7 ( -- ) 23 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR7, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR6 ( -- ) 22 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR6, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR5 ( -- ) 21 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR5, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR4 ( -- ) 20 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR4, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR3 ( -- ) 19 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR3, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR2 ( -- ) 18 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR2, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR1 ( -- ) 17 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR1, Port x reset bit y y =  0..15
: GPIOD_BSRR_BR0 ( -- ) 16 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BR0, Port x reset bit y y =  0..15
: GPIOD_BSRR_BS15 ( -- ) 15 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS15, Port x set bit y y=  0..15
: GPIOD_BSRR_BS14 ( -- ) 14 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS14, Port x set bit y y=  0..15
: GPIOD_BSRR_BS13 ( -- ) 13 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS13, Port x set bit y y=  0..15
: GPIOD_BSRR_BS12 ( -- ) 12 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS12, Port x set bit y y=  0..15
: GPIOD_BSRR_BS11 ( -- ) 11 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS11, Port x set bit y y=  0..15
: GPIOD_BSRR_BS10 ( -- ) 10 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS10, Port x set bit y y=  0..15
: GPIOD_BSRR_BS9 ( -- ) 9 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS9, Port x set bit y y=  0..15
: GPIOD_BSRR_BS8 ( -- ) 8 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS8, Port x set bit y y=  0..15
: GPIOD_BSRR_BS7 ( -- ) 7 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS7, Port x set bit y y=  0..15
: GPIOD_BSRR_BS6 ( -- ) 6 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS6, Port x set bit y y=  0..15
: GPIOD_BSRR_BS5 ( -- ) 5 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS5, Port x set bit y y=  0..15
: GPIOD_BSRR_BS4 ( -- ) 4 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS4, Port x set bit y y=  0..15
: GPIOD_BSRR_BS3 ( -- ) 3 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS3, Port x set bit y y=  0..15
: GPIOD_BSRR_BS2 ( -- ) 2 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS2, Port x set bit y y=  0..15
: GPIOD_BSRR_BS1 ( -- ) 1 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS1, Port x set bit y y=  0..15
: GPIOD_BSRR_BS0 ( -- ) 0 bit GPIOD_BSRR ! ; \ GPIOD_BSRR_BS0, Port x set bit y y=  0..15

\ GPIOD_LCKR (read-write) Reset:0x00000000
: GPIOD_LCKR_LCKK ( -- x addr ) 16 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCKK, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK15 ( -- x addr ) 15 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK15, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK14 ( -- x addr ) 14 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK14, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK13 ( -- x addr ) 13 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK13, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK12 ( -- x addr ) 12 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK12, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK11 ( -- x addr ) 11 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK11, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK10 ( -- x addr ) 10 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK10, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK9 ( -- x addr ) 9 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK9, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK8 ( -- x addr ) 8 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK8, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK7 ( -- x addr ) 7 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK7, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK6 ( -- x addr ) 6 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK6, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK5 ( -- x addr ) 5 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK5, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK4 ( -- x addr ) 4 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK4, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK3 ( -- x addr ) 3 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK3, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK2 ( -- x addr ) 2 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK2, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK1 ( -- x addr ) 1 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK1, Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK0 ( -- x addr ) 0 bit GPIOD_LCKR ; \ GPIOD_LCKR_LCK0, Port x lock bit y y=  0..15

\ GPIOD_AFRL (read-write) Reset:0x00000000
: GPIOD_AFRL_AFSEL7 ( %bbbb -- x addr ) 28 lshift GPIOD_AFRL ; \ GPIOD_AFRL_AFSEL7, Alternate function selection for port x  pin y y = 0..7
: GPIOD_AFRL_AFSEL6 ( %bbbb -- x addr ) 24 lshift GPIOD_AFRL ; \ GPIOD_AFRL_AFSEL6, Alternate function selection for port x  pin y y = 0..7
: GPIOD_AFRL_AFSEL5 ( %bbbb -- x addr ) 20 lshift GPIOD_AFRL ; \ GPIOD_AFRL_AFSEL5, Alternate function selection for port x  pin y y = 0..7
: GPIOD_AFRL_AFSEL4 ( %bbbb -- x addr ) 16 lshift GPIOD_AFRL ; \ GPIOD_AFRL_AFSEL4, Alternate function selection for port x  pin y y = 0..7
: GPIOD_AFRL_AFSEL3 ( %bbbb -- x addr ) 12 lshift GPIOD_AFRL ; \ GPIOD_AFRL_AFSEL3, Alternate function selection for port x  pin y y = 0..7
: GPIOD_AFRL_AFSEL2 ( %bbbb -- x addr ) 8 lshift GPIOD_AFRL ; \ GPIOD_AFRL_AFSEL2, Alternate function selection for port x  pin y y = 0..7
: GPIOD_AFRL_AFSEL1 ( %bbbb -- x addr ) 4 lshift GPIOD_AFRL ; \ GPIOD_AFRL_AFSEL1, Alternate function selection for port x  pin y y = 0..7
: GPIOD_AFRL_AFSEL0 ( %bbbb -- x addr ) GPIOD_AFRL ; \ GPIOD_AFRL_AFSEL0, Alternate function selection for port x  pin y y = 0..7

\ GPIOD_AFRH (read-write) Reset:0x00000000
: GPIOD_AFRH_AFSEL15 ( %bbbb -- x addr ) 28 lshift GPIOD_AFRH ; \ GPIOD_AFRH_AFSEL15, Alternate function selection for port x  pin y y = 8..15
: GPIOD_AFRH_AFSEL14 ( %bbbb -- x addr ) 24 lshift GPIOD_AFRH ; \ GPIOD_AFRH_AFSEL14, Alternate function selection for port x  pin y y = 8..15
: GPIOD_AFRH_AFSEL13 ( %bbbb -- x addr ) 20 lshift GPIOD_AFRH ; \ GPIOD_AFRH_AFSEL13, Alternate function selection for port x  pin y y = 8..15
: GPIOD_AFRH_AFSEL12 ( %bbbb -- x addr ) 16 lshift GPIOD_AFRH ; \ GPIOD_AFRH_AFSEL12, Alternate function selection for port x  pin y y = 8..15
: GPIOD_AFRH_AFSEL11 ( %bbbb -- x addr ) 12 lshift GPIOD_AFRH ; \ GPIOD_AFRH_AFSEL11, Alternate function selection for port x  pin y y = 8..15
: GPIOD_AFRH_AFSEL10 ( %bbbb -- x addr ) 8 lshift GPIOD_AFRH ; \ GPIOD_AFRH_AFSEL10, Alternate function selection for port x  pin y y = 8..15
: GPIOD_AFRH_AFSEL9 ( %bbbb -- x addr ) 4 lshift GPIOD_AFRH ; \ GPIOD_AFRH_AFSEL9, Alternate function selection for port x  pin y y = 8..15
: GPIOD_AFRH_AFSEL8 ( %bbbb -- x addr ) GPIOD_AFRH ; \ GPIOD_AFRH_AFSEL8, Alternate function selection for port x  pin y y = 8..15

\ GPIOD_BRR (write-only) Reset:0x00000000
: GPIOD_BRR_BR15 ( -- ) 15 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR15, Port x Reset bit y y= 0 ..  15
: GPIOD_BRR_BR14 ( -- ) 14 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR14, Port x Reset bit y y= 0 ..  15
: GPIOD_BRR_BR13 ( -- ) 13 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR13, Port x Reset bit y y= 0 ..  15
: GPIOD_BRR_BR12 ( -- ) 12 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR12, Port x Reset bit y y= 0 ..  15
: GPIOD_BRR_BR11 ( -- ) 11 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR11, Port x Reset bit y y= 0 ..  15
: GPIOD_BRR_BR10 ( -- ) 10 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR10, Port x Reset bit y y= 0 ..  15
: GPIOD_BRR_BR9 ( -- ) 9 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR9, Port x Reset bit y y= 0 ..  15
: GPIOD_BRR_BR8 ( -- ) 8 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR8, Port x Reset bit y y= 0 ..  15
: GPIOD_BRR_BR7 ( -- ) 7 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR7, Port x Reset bit y y= 0 ..  15
: GPIOD_BRR_BR6 ( -- ) 6 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR6, Port x Reset bit y y= 0 ..  15
: GPIOD_BRR_BR5 ( -- ) 5 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR5, Port x Reset bit y y= 0 ..  15
: GPIOD_BRR_BR4 ( -- ) 4 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR4, Port x Reset bit y y= 0 ..  15
: GPIOD_BRR_BR3 ( -- ) 3 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR3, Port x Reset bit y y= 0 ..  15
: GPIOD_BRR_BR2 ( -- ) 2 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR2, Port x Reset bit y y= 0 ..  15
: GPIOD_BRR_BR1 ( -- ) 1 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR1, Port x Reset bit y y= 0 ..  15
: GPIOD_BRR_BR0 ( -- ) 0 bit GPIOD_BRR ! ; \ GPIOD_BRR_BR0, Port x Reset bit y y= 0 ..  15

\ GPIOH_MODER (read-write) Reset:0xFFFFFFFF
: GPIOH_MODER_MODE15 ( %bb -- x addr ) 30 lshift GPIOH_MODER ; \ GPIOH_MODER_MODE15, Port x configuration bits y =  0..15
: GPIOH_MODER_MODE14 ( %bb -- x addr ) 28 lshift GPIOH_MODER ; \ GPIOH_MODER_MODE14, Port x configuration bits y =  0..15
: GPIOH_MODER_MODE13 ( %bb -- x addr ) 26 lshift GPIOH_MODER ; \ GPIOH_MODER_MODE13, Port x configuration bits y =  0..15
: GPIOH_MODER_MODE12 ( %bb -- x addr ) 24 lshift GPIOH_MODER ; \ GPIOH_MODER_MODE12, Port x configuration bits y =  0..15
: GPIOH_MODER_MODE11 ( %bb -- x addr ) 22 lshift GPIOH_MODER ; \ GPIOH_MODER_MODE11, Port x configuration bits y =  0..15
: GPIOH_MODER_MODE10 ( %bb -- x addr ) 20 lshift GPIOH_MODER ; \ GPIOH_MODER_MODE10, Port x configuration bits y =  0..15
: GPIOH_MODER_MODE9 ( %bb -- x addr ) 18 lshift GPIOH_MODER ; \ GPIOH_MODER_MODE9, Port x configuration bits y =  0..15
: GPIOH_MODER_MODE8 ( %bb -- x addr ) 16 lshift GPIOH_MODER ; \ GPIOH_MODER_MODE8, Port x configuration bits y =  0..15
: GPIOH_MODER_MODE7 ( %bb -- x addr ) 14 lshift GPIOH_MODER ; \ GPIOH_MODER_MODE7, Port x configuration bits y =  0..15
: GPIOH_MODER_MODE6 ( %bb -- x addr ) 12 lshift GPIOH_MODER ; \ GPIOH_MODER_MODE6, Port x configuration bits y =  0..15
: GPIOH_MODER_MODE5 ( %bb -- x addr ) 10 lshift GPIOH_MODER ; \ GPIOH_MODER_MODE5, Port x configuration bits y =  0..15
: GPIOH_MODER_MODE4 ( %bb -- x addr ) 8 lshift GPIOH_MODER ; \ GPIOH_MODER_MODE4, Port x configuration bits y =  0..15
: GPIOH_MODER_MODE3 ( %bb -- x addr ) 6 lshift GPIOH_MODER ; \ GPIOH_MODER_MODE3, Port x configuration bits y =  0..15
: GPIOH_MODER_MODE2 ( %bb -- x addr ) 4 lshift GPIOH_MODER ; \ GPIOH_MODER_MODE2, Port x configuration bits y =  0..15
: GPIOH_MODER_MODE1 ( %bb -- x addr ) 2 lshift GPIOH_MODER ; \ GPIOH_MODER_MODE1, Port x configuration bits y =  0..15
: GPIOH_MODER_MODE0 ( %bb -- x addr ) GPIOH_MODER ; \ GPIOH_MODER_MODE0, Port x configuration bits y =  0..15

\ GPIOH_OTYPER (read-write) Reset:0x00000000
: GPIOH_OTYPER_OT15 ( -- x addr ) 15 bit GPIOH_OTYPER ; \ GPIOH_OTYPER_OT15, Port x configuration bits y =  0..15
: GPIOH_OTYPER_OT14 ( -- x addr ) 14 bit GPIOH_OTYPER ; \ GPIOH_OTYPER_OT14, Port x configuration bits y =  0..15
: GPIOH_OTYPER_OT13 ( -- x addr ) 13 bit GPIOH_OTYPER ; \ GPIOH_OTYPER_OT13, Port x configuration bits y =  0..15
: GPIOH_OTYPER_OT12 ( -- x addr ) 12 bit GPIOH_OTYPER ; \ GPIOH_OTYPER_OT12, Port x configuration bits y =  0..15
: GPIOH_OTYPER_OT11 ( -- x addr ) 11 bit GPIOH_OTYPER ; \ GPIOH_OTYPER_OT11, Port x configuration bits y =  0..15
: GPIOH_OTYPER_OT10 ( -- x addr ) 10 bit GPIOH_OTYPER ; \ GPIOH_OTYPER_OT10, Port x configuration bits y =  0..15
: GPIOH_OTYPER_OT9 ( -- x addr ) 9 bit GPIOH_OTYPER ; \ GPIOH_OTYPER_OT9, Port x configuration bits y =  0..15
: GPIOH_OTYPER_OT8 ( -- x addr ) 8 bit GPIOH_OTYPER ; \ GPIOH_OTYPER_OT8, Port x configuration bits y =  0..15
: GPIOH_OTYPER_OT7 ( -- x addr ) 7 bit GPIOH_OTYPER ; \ GPIOH_OTYPER_OT7, Port x configuration bits y =  0..15
: GPIOH_OTYPER_OT6 ( -- x addr ) 6 bit GPIOH_OTYPER ; \ GPIOH_OTYPER_OT6, Port x configuration bits y =  0..15
: GPIOH_OTYPER_OT5 ( -- x addr ) 5 bit GPIOH_OTYPER ; \ GPIOH_OTYPER_OT5, Port x configuration bits y =  0..15
: GPIOH_OTYPER_OT4 ( -- x addr ) 4 bit GPIOH_OTYPER ; \ GPIOH_OTYPER_OT4, Port x configuration bits y =  0..15
: GPIOH_OTYPER_OT3 ( -- x addr ) 3 bit GPIOH_OTYPER ; \ GPIOH_OTYPER_OT3, Port x configuration bits y =  0..15
: GPIOH_OTYPER_OT2 ( -- x addr ) 2 bit GPIOH_OTYPER ; \ GPIOH_OTYPER_OT2, Port x configuration bits y =  0..15
: GPIOH_OTYPER_OT1 ( -- x addr ) 1 bit GPIOH_OTYPER ; \ GPIOH_OTYPER_OT1, Port x configuration bits y =  0..15
: GPIOH_OTYPER_OT0 ( -- x addr ) 0 bit GPIOH_OTYPER ; \ GPIOH_OTYPER_OT0, Port x configuration bits y =  0..15

\ GPIOH_OSPEEDR (read-write) Reset:0x00000000
: GPIOH_OSPEEDR_OSPEED15 ( %bb -- x addr ) 30 lshift GPIOH_OSPEEDR ; \ GPIOH_OSPEEDR_OSPEED15, Port x configuration bits y =  0..15
: GPIOH_OSPEEDR_OSPEED14 ( %bb -- x addr ) 28 lshift GPIOH_OSPEEDR ; \ GPIOH_OSPEEDR_OSPEED14, Port x configuration bits y =  0..15
: GPIOH_OSPEEDR_OSPEED13 ( %bb -- x addr ) 26 lshift GPIOH_OSPEEDR ; \ GPIOH_OSPEEDR_OSPEED13, Port x configuration bits y =  0..15
: GPIOH_OSPEEDR_OSPEED12 ( %bb -- x addr ) 24 lshift GPIOH_OSPEEDR ; \ GPIOH_OSPEEDR_OSPEED12, Port x configuration bits y =  0..15
: GPIOH_OSPEEDR_OSPEED11 ( %bb -- x addr ) 22 lshift GPIOH_OSPEEDR ; \ GPIOH_OSPEEDR_OSPEED11, Port x configuration bits y =  0..15
: GPIOH_OSPEEDR_OSPEED10 ( %bb -- x addr ) 20 lshift GPIOH_OSPEEDR ; \ GPIOH_OSPEEDR_OSPEED10, Port x configuration bits y =  0..15
: GPIOH_OSPEEDR_OSPEED9 ( %bb -- x addr ) 18 lshift GPIOH_OSPEEDR ; \ GPIOH_OSPEEDR_OSPEED9, Port x configuration bits y =  0..15
: GPIOH_OSPEEDR_OSPEED8 ( %bb -- x addr ) 16 lshift GPIOH_OSPEEDR ; \ GPIOH_OSPEEDR_OSPEED8, Port x configuration bits y =  0..15
: GPIOH_OSPEEDR_OSPEED7 ( %bb -- x addr ) 14 lshift GPIOH_OSPEEDR ; \ GPIOH_OSPEEDR_OSPEED7, Port x configuration bits y =  0..15
: GPIOH_OSPEEDR_OSPEED6 ( %bb -- x addr ) 12 lshift GPIOH_OSPEEDR ; \ GPIOH_OSPEEDR_OSPEED6, Port x configuration bits y =  0..15
: GPIOH_OSPEEDR_OSPEED5 ( %bb -- x addr ) 10 lshift GPIOH_OSPEEDR ; \ GPIOH_OSPEEDR_OSPEED5, Port x configuration bits y =  0..15
: GPIOH_OSPEEDR_OSPEED4 ( %bb -- x addr ) 8 lshift GPIOH_OSPEEDR ; \ GPIOH_OSPEEDR_OSPEED4, Port x configuration bits y =  0..15
: GPIOH_OSPEEDR_OSPEED3 ( %bb -- x addr ) 6 lshift GPIOH_OSPEEDR ; \ GPIOH_OSPEEDR_OSPEED3, Port x configuration bits y =  0..15
: GPIOH_OSPEEDR_OSPEED2 ( %bb -- x addr ) 4 lshift GPIOH_OSPEEDR ; \ GPIOH_OSPEEDR_OSPEED2, Port x configuration bits y =  0..15
: GPIOH_OSPEEDR_OSPEED1 ( %bb -- x addr ) 2 lshift GPIOH_OSPEEDR ; \ GPIOH_OSPEEDR_OSPEED1, Port x configuration bits y =  0..15
: GPIOH_OSPEEDR_OSPEED0 ( %bb -- x addr ) GPIOH_OSPEEDR ; \ GPIOH_OSPEEDR_OSPEED0, Port x configuration bits y =  0..15

\ GPIOH_PUPDR (read-write) Reset:0x00000000
: GPIOH_PUPDR_PUPD15 ( %bb -- x addr ) 30 lshift GPIOH_PUPDR ; \ GPIOH_PUPDR_PUPD15, Port x configuration bits y =  0..15
: GPIOH_PUPDR_PUPD14 ( %bb -- x addr ) 28 lshift GPIOH_PUPDR ; \ GPIOH_PUPDR_PUPD14, Port x configuration bits y =  0..15
: GPIOH_PUPDR_PUPD13 ( %bb -- x addr ) 26 lshift GPIOH_PUPDR ; \ GPIOH_PUPDR_PUPD13, Port x configuration bits y =  0..15
: GPIOH_PUPDR_PUPD12 ( %bb -- x addr ) 24 lshift GPIOH_PUPDR ; \ GPIOH_PUPDR_PUPD12, Port x configuration bits y =  0..15
: GPIOH_PUPDR_PUPD11 ( %bb -- x addr ) 22 lshift GPIOH_PUPDR ; \ GPIOH_PUPDR_PUPD11, Port x configuration bits y =  0..15
: GPIOH_PUPDR_PUPD10 ( %bb -- x addr ) 20 lshift GPIOH_PUPDR ; \ GPIOH_PUPDR_PUPD10, Port x configuration bits y =  0..15
: GPIOH_PUPDR_PUPD9 ( %bb -- x addr ) 18 lshift GPIOH_PUPDR ; \ GPIOH_PUPDR_PUPD9, Port x configuration bits y =  0..15
: GPIOH_PUPDR_PUPD8 ( %bb -- x addr ) 16 lshift GPIOH_PUPDR ; \ GPIOH_PUPDR_PUPD8, Port x configuration bits y =  0..15
: GPIOH_PUPDR_PUPD7 ( %bb -- x addr ) 14 lshift GPIOH_PUPDR ; \ GPIOH_PUPDR_PUPD7, Port x configuration bits y =  0..15
: GPIOH_PUPDR_PUPD6 ( %bb -- x addr ) 12 lshift GPIOH_PUPDR ; \ GPIOH_PUPDR_PUPD6, Port x configuration bits y =  0..15
: GPIOH_PUPDR_PUPD5 ( %bb -- x addr ) 10 lshift GPIOH_PUPDR ; \ GPIOH_PUPDR_PUPD5, Port x configuration bits y =  0..15
: GPIOH_PUPDR_PUPD4 ( %bb -- x addr ) 8 lshift GPIOH_PUPDR ; \ GPIOH_PUPDR_PUPD4, Port x configuration bits y =  0..15
: GPIOH_PUPDR_PUPD3 ( %bb -- x addr ) 6 lshift GPIOH_PUPDR ; \ GPIOH_PUPDR_PUPD3, Port x configuration bits y =  0..15
: GPIOH_PUPDR_PUPD2 ( %bb -- x addr ) 4 lshift GPIOH_PUPDR ; \ GPIOH_PUPDR_PUPD2, Port x configuration bits y =  0..15
: GPIOH_PUPDR_PUPD1 ( %bb -- x addr ) 2 lshift GPIOH_PUPDR ; \ GPIOH_PUPDR_PUPD1, Port x configuration bits y =  0..15
: GPIOH_PUPDR_PUPD0 ( %bb -- x addr ) GPIOH_PUPDR ; \ GPIOH_PUPDR_PUPD0, Port x configuration bits y =  0..15

\ GPIOH_IDR (read-only) Reset:0x00000000
: GPIOH_IDR_ID15? ( --  1|0 ) 15 bit GPIOH_IDR bit@ ; \ GPIOH_IDR_ID15, Port input data bit y =  0..15
: GPIOH_IDR_ID14? ( --  1|0 ) 14 bit GPIOH_IDR bit@ ; \ GPIOH_IDR_ID14, Port input data bit y =  0..15
: GPIOH_IDR_ID13? ( --  1|0 ) 13 bit GPIOH_IDR bit@ ; \ GPIOH_IDR_ID13, Port input data bit y =  0..15
: GPIOH_IDR_ID12? ( --  1|0 ) 12 bit GPIOH_IDR bit@ ; \ GPIOH_IDR_ID12, Port input data bit y =  0..15
: GPIOH_IDR_ID11? ( --  1|0 ) 11 bit GPIOH_IDR bit@ ; \ GPIOH_IDR_ID11, Port input data bit y =  0..15
: GPIOH_IDR_ID10? ( --  1|0 ) 10 bit GPIOH_IDR bit@ ; \ GPIOH_IDR_ID10, Port input data bit y =  0..15
: GPIOH_IDR_ID9? ( --  1|0 ) 9 bit GPIOH_IDR bit@ ; \ GPIOH_IDR_ID9, Port input data bit y =  0..15
: GPIOH_IDR_ID8? ( --  1|0 ) 8 bit GPIOH_IDR bit@ ; \ GPIOH_IDR_ID8, Port input data bit y =  0..15
: GPIOH_IDR_ID7? ( --  1|0 ) 7 bit GPIOH_IDR bit@ ; \ GPIOH_IDR_ID7, Port input data bit y =  0..15
: GPIOH_IDR_ID6? ( --  1|0 ) 6 bit GPIOH_IDR bit@ ; \ GPIOH_IDR_ID6, Port input data bit y =  0..15
: GPIOH_IDR_ID5? ( --  1|0 ) 5 bit GPIOH_IDR bit@ ; \ GPIOH_IDR_ID5, Port input data bit y =  0..15
: GPIOH_IDR_ID4? ( --  1|0 ) 4 bit GPIOH_IDR bit@ ; \ GPIOH_IDR_ID4, Port input data bit y =  0..15
: GPIOH_IDR_ID3? ( --  1|0 ) 3 bit GPIOH_IDR bit@ ; \ GPIOH_IDR_ID3, Port input data bit y =  0..15
: GPIOH_IDR_ID2? ( --  1|0 ) 2 bit GPIOH_IDR bit@ ; \ GPIOH_IDR_ID2, Port input data bit y =  0..15
: GPIOH_IDR_ID1? ( --  1|0 ) 1 bit GPIOH_IDR bit@ ; \ GPIOH_IDR_ID1, Port input data bit y =  0..15
: GPIOH_IDR_ID0? ( --  1|0 ) 0 bit GPIOH_IDR bit@ ; \ GPIOH_IDR_ID0, Port input data bit y =  0..15

\ GPIOH_ODR (read-write) Reset:0x00000000
: GPIOH_ODR_OD15 ( -- x addr ) 15 bit GPIOH_ODR ; \ GPIOH_ODR_OD15, Port output data bit y =  0..15
: GPIOH_ODR_OD14 ( -- x addr ) 14 bit GPIOH_ODR ; \ GPIOH_ODR_OD14, Port output data bit y =  0..15
: GPIOH_ODR_OD13 ( -- x addr ) 13 bit GPIOH_ODR ; \ GPIOH_ODR_OD13, Port output data bit y =  0..15
: GPIOH_ODR_OD12 ( -- x addr ) 12 bit GPIOH_ODR ; \ GPIOH_ODR_OD12, Port output data bit y =  0..15
: GPIOH_ODR_OD11 ( -- x addr ) 11 bit GPIOH_ODR ; \ GPIOH_ODR_OD11, Port output data bit y =  0..15
: GPIOH_ODR_OD10 ( -- x addr ) 10 bit GPIOH_ODR ; \ GPIOH_ODR_OD10, Port output data bit y =  0..15
: GPIOH_ODR_OD9 ( -- x addr ) 9 bit GPIOH_ODR ; \ GPIOH_ODR_OD9, Port output data bit y =  0..15
: GPIOH_ODR_OD8 ( -- x addr ) 8 bit GPIOH_ODR ; \ GPIOH_ODR_OD8, Port output data bit y =  0..15
: GPIOH_ODR_OD7 ( -- x addr ) 7 bit GPIOH_ODR ; \ GPIOH_ODR_OD7, Port output data bit y =  0..15
: GPIOH_ODR_OD6 ( -- x addr ) 6 bit GPIOH_ODR ; \ GPIOH_ODR_OD6, Port output data bit y =  0..15
: GPIOH_ODR_OD5 ( -- x addr ) 5 bit GPIOH_ODR ; \ GPIOH_ODR_OD5, Port output data bit y =  0..15
: GPIOH_ODR_OD4 ( -- x addr ) 4 bit GPIOH_ODR ; \ GPIOH_ODR_OD4, Port output data bit y =  0..15
: GPIOH_ODR_OD3 ( -- x addr ) 3 bit GPIOH_ODR ; \ GPIOH_ODR_OD3, Port output data bit y =  0..15
: GPIOH_ODR_OD2 ( -- x addr ) 2 bit GPIOH_ODR ; \ GPIOH_ODR_OD2, Port output data bit y =  0..15
: GPIOH_ODR_OD1 ( -- x addr ) 1 bit GPIOH_ODR ; \ GPIOH_ODR_OD1, Port output data bit y =  0..15
: GPIOH_ODR_OD0 ( -- x addr ) 0 bit GPIOH_ODR ; \ GPIOH_ODR_OD0, Port output data bit y =  0..15

\ GPIOH_BSRR (write-only) Reset:0x00000000
: GPIOH_BSRR_BR15 ( -- ) 31 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BR15, Port x reset bit y y =  0..15
: GPIOH_BSRR_BR14 ( -- ) 30 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BR14, Port x reset bit y y =  0..15
: GPIOH_BSRR_BR13 ( -- ) 29 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BR13, Port x reset bit y y =  0..15
: GPIOH_BSRR_BR12 ( -- ) 28 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BR12, Port x reset bit y y =  0..15
: GPIOH_BSRR_BR11 ( -- ) 27 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BR11, Port x reset bit y y =  0..15
: GPIOH_BSRR_BR10 ( -- ) 26 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BR10, Port x reset bit y y =  0..15
: GPIOH_BSRR_BR9 ( -- ) 25 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BR9, Port x reset bit y y =  0..15
: GPIOH_BSRR_BR8 ( -- ) 24 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BR8, Port x reset bit y y =  0..15
: GPIOH_BSRR_BR7 ( -- ) 23 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BR7, Port x reset bit y y =  0..15
: GPIOH_BSRR_BR6 ( -- ) 22 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BR6, Port x reset bit y y =  0..15
: GPIOH_BSRR_BR5 ( -- ) 21 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BR5, Port x reset bit y y =  0..15
: GPIOH_BSRR_BR4 ( -- ) 20 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BR4, Port x reset bit y y =  0..15
: GPIOH_BSRR_BR3 ( -- ) 19 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BR3, Port x reset bit y y =  0..15
: GPIOH_BSRR_BR2 ( -- ) 18 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BR2, Port x reset bit y y =  0..15
: GPIOH_BSRR_BR1 ( -- ) 17 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BR1, Port x reset bit y y =  0..15
: GPIOH_BSRR_BR0 ( -- ) 16 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BR0, Port x reset bit y y =  0..15
: GPIOH_BSRR_BS15 ( -- ) 15 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BS15, Port x set bit y y=  0..15
: GPIOH_BSRR_BS14 ( -- ) 14 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BS14, Port x set bit y y=  0..15
: GPIOH_BSRR_BS13 ( -- ) 13 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BS13, Port x set bit y y=  0..15
: GPIOH_BSRR_BS12 ( -- ) 12 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BS12, Port x set bit y y=  0..15
: GPIOH_BSRR_BS11 ( -- ) 11 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BS11, Port x set bit y y=  0..15
: GPIOH_BSRR_BS10 ( -- ) 10 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BS10, Port x set bit y y=  0..15
: GPIOH_BSRR_BS9 ( -- ) 9 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BS9, Port x set bit y y=  0..15
: GPIOH_BSRR_BS8 ( -- ) 8 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BS8, Port x set bit y y=  0..15
: GPIOH_BSRR_BS7 ( -- ) 7 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BS7, Port x set bit y y=  0..15
: GPIOH_BSRR_BS6 ( -- ) 6 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BS6, Port x set bit y y=  0..15
: GPIOH_BSRR_BS5 ( -- ) 5 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BS5, Port x set bit y y=  0..15
: GPIOH_BSRR_BS4 ( -- ) 4 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BS4, Port x set bit y y=  0..15
: GPIOH_BSRR_BS3 ( -- ) 3 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BS3, Port x set bit y y=  0..15
: GPIOH_BSRR_BS2 ( -- ) 2 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BS2, Port x set bit y y=  0..15
: GPIOH_BSRR_BS1 ( -- ) 1 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BS1, Port x set bit y y=  0..15
: GPIOH_BSRR_BS0 ( -- ) 0 bit GPIOH_BSRR ! ; \ GPIOH_BSRR_BS0, Port x set bit y y=  0..15

\ GPIOH_LCKR (read-write) Reset:0x00000000
: GPIOH_LCKR_LCKK ( -- x addr ) 16 bit GPIOH_LCKR ; \ GPIOH_LCKR_LCKK, Port x lock bit y y=  0..15
: GPIOH_LCKR_LCK15 ( -- x addr ) 15 bit GPIOH_LCKR ; \ GPIOH_LCKR_LCK15, Port x lock bit y y=  0..15
: GPIOH_LCKR_LCK14 ( -- x addr ) 14 bit GPIOH_LCKR ; \ GPIOH_LCKR_LCK14, Port x lock bit y y=  0..15
: GPIOH_LCKR_LCK13 ( -- x addr ) 13 bit GPIOH_LCKR ; \ GPIOH_LCKR_LCK13, Port x lock bit y y=  0..15
: GPIOH_LCKR_LCK12 ( -- x addr ) 12 bit GPIOH_LCKR ; \ GPIOH_LCKR_LCK12, Port x lock bit y y=  0..15
: GPIOH_LCKR_LCK11 ( -- x addr ) 11 bit GPIOH_LCKR ; \ GPIOH_LCKR_LCK11, Port x lock bit y y=  0..15
: GPIOH_LCKR_LCK10 ( -- x addr ) 10 bit GPIOH_LCKR ; \ GPIOH_LCKR_LCK10, Port x lock bit y y=  0..15
: GPIOH_LCKR_LCK9 ( -- x addr ) 9 bit GPIOH_LCKR ; \ GPIOH_LCKR_LCK9, Port x lock bit y y=  0..15
: GPIOH_LCKR_LCK8 ( -- x addr ) 8 bit GPIOH_LCKR ; \ GPIOH_LCKR_LCK8, Port x lock bit y y=  0..15
: GPIOH_LCKR_LCK7 ( -- x addr ) 7 bit GPIOH_LCKR ; \ GPIOH_LCKR_LCK7, Port x lock bit y y=  0..15
: GPIOH_LCKR_LCK6 ( -- x addr ) 6 bit GPIOH_LCKR ; \ GPIOH_LCKR_LCK6, Port x lock bit y y=  0..15
: GPIOH_LCKR_LCK5 ( -- x addr ) 5 bit GPIOH_LCKR ; \ GPIOH_LCKR_LCK5, Port x lock bit y y=  0..15
: GPIOH_LCKR_LCK4 ( -- x addr ) 4 bit GPIOH_LCKR ; \ GPIOH_LCKR_LCK4, Port x lock bit y y=  0..15
: GPIOH_LCKR_LCK3 ( -- x addr ) 3 bit GPIOH_LCKR ; \ GPIOH_LCKR_LCK3, Port x lock bit y y=  0..15
: GPIOH_LCKR_LCK2 ( -- x addr ) 2 bit GPIOH_LCKR ; \ GPIOH_LCKR_LCK2, Port x lock bit y y=  0..15
: GPIOH_LCKR_LCK1 ( -- x addr ) 1 bit GPIOH_LCKR ; \ GPIOH_LCKR_LCK1, Port x lock bit y y=  0..15
: GPIOH_LCKR_LCK0 ( -- x addr ) 0 bit GPIOH_LCKR ; \ GPIOH_LCKR_LCK0, Port x lock bit y y=  0..15

\ GPIOH_AFRL (read-write) Reset:0x00000000
: GPIOH_AFRL_AFSEL7 ( %bbbb -- x addr ) 28 lshift GPIOH_AFRL ; \ GPIOH_AFRL_AFSEL7, Alternate function selection for port x  pin y y = 0..7
: GPIOH_AFRL_AFSEL6 ( %bbbb -- x addr ) 24 lshift GPIOH_AFRL ; \ GPIOH_AFRL_AFSEL6, Alternate function selection for port x  pin y y = 0..7
: GPIOH_AFRL_AFSEL5 ( %bbbb -- x addr ) 20 lshift GPIOH_AFRL ; \ GPIOH_AFRL_AFSEL5, Alternate function selection for port x  pin y y = 0..7
: GPIOH_AFRL_AFSEL4 ( %bbbb -- x addr ) 16 lshift GPIOH_AFRL ; \ GPIOH_AFRL_AFSEL4, Alternate function selection for port x  pin y y = 0..7
: GPIOH_AFRL_AFSEL3 ( %bbbb -- x addr ) 12 lshift GPIOH_AFRL ; \ GPIOH_AFRL_AFSEL3, Alternate function selection for port x  pin y y = 0..7
: GPIOH_AFRL_AFSEL2 ( %bbbb -- x addr ) 8 lshift GPIOH_AFRL ; \ GPIOH_AFRL_AFSEL2, Alternate function selection for port x  pin y y = 0..7
: GPIOH_AFRL_AFSEL1 ( %bbbb -- x addr ) 4 lshift GPIOH_AFRL ; \ GPIOH_AFRL_AFSEL1, Alternate function selection for port x  pin y y = 0..7
: GPIOH_AFRL_AFSEL0 ( %bbbb -- x addr ) GPIOH_AFRL ; \ GPIOH_AFRL_AFSEL0, Alternate function selection for port x  pin y y = 0..7

\ GPIOH_AFRH (read-write) Reset:0x00000000
: GPIOH_AFRH_AFSEL15 ( %bbbb -- x addr ) 28 lshift GPIOH_AFRH ; \ GPIOH_AFRH_AFSEL15, Alternate function selection for port x  pin y y = 8..15
: GPIOH_AFRH_AFSEL14 ( %bbbb -- x addr ) 24 lshift GPIOH_AFRH ; \ GPIOH_AFRH_AFSEL14, Alternate function selection for port x  pin y y = 8..15
: GPIOH_AFRH_AFSEL13 ( %bbbb -- x addr ) 20 lshift GPIOH_AFRH ; \ GPIOH_AFRH_AFSEL13, Alternate function selection for port x  pin y y = 8..15
: GPIOH_AFRH_AFSEL12 ( %bbbb -- x addr ) 16 lshift GPIOH_AFRH ; \ GPIOH_AFRH_AFSEL12, Alternate function selection for port x  pin y y = 8..15
: GPIOH_AFRH_AFSEL11 ( %bbbb -- x addr ) 12 lshift GPIOH_AFRH ; \ GPIOH_AFRH_AFSEL11, Alternate function selection for port x  pin y y = 8..15
: GPIOH_AFRH_AFSEL10 ( %bbbb -- x addr ) 8 lshift GPIOH_AFRH ; \ GPIOH_AFRH_AFSEL10, Alternate function selection for port x  pin y y = 8..15
: GPIOH_AFRH_AFSEL9 ( %bbbb -- x addr ) 4 lshift GPIOH_AFRH ; \ GPIOH_AFRH_AFSEL9, Alternate function selection for port x  pin y y = 8..15
: GPIOH_AFRH_AFSEL8 ( %bbbb -- x addr ) GPIOH_AFRH ; \ GPIOH_AFRH_AFSEL8, Alternate function selection for port x  pin y y = 8..15

\ GPIOH_BRR (write-only) Reset:0x00000000
: GPIOH_BRR_BR15 ( -- ) 15 bit GPIOH_BRR ! ; \ GPIOH_BRR_BR15, Port x Reset bit y y= 0 ..  15
: GPIOH_BRR_BR14 ( -- ) 14 bit GPIOH_BRR ! ; \ GPIOH_BRR_BR14, Port x Reset bit y y= 0 ..  15
: GPIOH_BRR_BR13 ( -- ) 13 bit GPIOH_BRR ! ; \ GPIOH_BRR_BR13, Port x Reset bit y y= 0 ..  15
: GPIOH_BRR_BR12 ( -- ) 12 bit GPIOH_BRR ! ; \ GPIOH_BRR_BR12, Port x Reset bit y y= 0 ..  15
: GPIOH_BRR_BR11 ( -- ) 11 bit GPIOH_BRR ! ; \ GPIOH_BRR_BR11, Port x Reset bit y y= 0 ..  15
: GPIOH_BRR_BR10 ( -- ) 10 bit GPIOH_BRR ! ; \ GPIOH_BRR_BR10, Port x Reset bit y y= 0 ..  15
: GPIOH_BRR_BR9 ( -- ) 9 bit GPIOH_BRR ! ; \ GPIOH_BRR_BR9, Port x Reset bit y y= 0 ..  15
: GPIOH_BRR_BR8 ( -- ) 8 bit GPIOH_BRR ! ; \ GPIOH_BRR_BR8, Port x Reset bit y y= 0 ..  15
: GPIOH_BRR_BR7 ( -- ) 7 bit GPIOH_BRR ! ; \ GPIOH_BRR_BR7, Port x Reset bit y y= 0 ..  15
: GPIOH_BRR_BR6 ( -- ) 6 bit GPIOH_BRR ! ; \ GPIOH_BRR_BR6, Port x Reset bit y y= 0 ..  15
: GPIOH_BRR_BR5 ( -- ) 5 bit GPIOH_BRR ! ; \ GPIOH_BRR_BR5, Port x Reset bit y y= 0 ..  15
: GPIOH_BRR_BR4 ( -- ) 4 bit GPIOH_BRR ! ; \ GPIOH_BRR_BR4, Port x Reset bit y y= 0 ..  15
: GPIOH_BRR_BR3 ( -- ) 3 bit GPIOH_BRR ! ; \ GPIOH_BRR_BR3, Port x Reset bit y y= 0 ..  15
: GPIOH_BRR_BR2 ( -- ) 2 bit GPIOH_BRR ! ; \ GPIOH_BRR_BR2, Port x Reset bit y y= 0 ..  15
: GPIOH_BRR_BR1 ( -- ) 1 bit GPIOH_BRR ! ; \ GPIOH_BRR_BR1, Port x Reset bit y y= 0 ..  15
: GPIOH_BRR_BR0 ( -- ) 0 bit GPIOH_BRR ! ; \ GPIOH_BRR_BR0, Port x Reset bit y y= 0 ..  15

\ LCD_CR (read-write) Reset:0x00000000
: LCD_CR_BIAS ( %bb -- x addr ) 5 lshift LCD_CR ; \ LCD_CR_BIAS, Bias selector
: LCD_CR_DUTY ( %bbb -- x addr ) 2 lshift LCD_CR ; \ LCD_CR_DUTY, Duty selection
: LCD_CR_VSEL ( -- x addr ) 1 bit LCD_CR ; \ LCD_CR_VSEL, Voltage source selection
: LCD_CR_LCDEN ( -- x addr ) 0 bit LCD_CR ; \ LCD_CR_LCDEN, LCD controller enable

\ LCD_FCR (read-write) Reset:0x00000000
: LCD_FCR_PS ( %bbbb -- x addr ) 22 lshift LCD_FCR ; \ LCD_FCR_PS, PS 16-bit prescaler
: LCD_FCR_DIV ( %bbbb -- x addr ) 18 lshift LCD_FCR ; \ LCD_FCR_DIV, DIV clock divider
: LCD_FCR_BLINK ( %bb -- x addr ) 16 lshift LCD_FCR ; \ LCD_FCR_BLINK, Blink mode selection
: LCD_FCR_BLINKF ( %bbb -- x addr ) 13 lshift LCD_FCR ; \ LCD_FCR_BLINKF, Blink frequency selection
: LCD_FCR_CC ( %bbb -- x addr ) 10 lshift LCD_FCR ; \ LCD_FCR_CC, Contrast control
: LCD_FCR_DEAD ( %bbb -- x addr ) 7 lshift LCD_FCR ; \ LCD_FCR_DEAD, Dead time duration
: LCD_FCR_PON ( %bbb -- x addr ) 4 lshift LCD_FCR ; \ LCD_FCR_PON, Pulse ON duration
: LCD_FCR_UDDIE ( -- x addr ) 3 bit LCD_FCR ; \ LCD_FCR_UDDIE, Update display done interrupt  enable
: LCD_FCR_SOFIE ( -- x addr ) 1 bit LCD_FCR ; \ LCD_FCR_SOFIE, Start of frame interrupt  enable
: LCD_FCR_HD ( -- x addr ) 0 bit LCD_FCR ; \ LCD_FCR_HD, High drive enable

\ LCD_SR (multiple-access)  Reset:0x00000020
: LCD_SR_FCRSF? ( -- 1|0 ) 5 bit LCD_SR bit@ ; \ LCD_SR_FCRSF, LCD Frame Control Register  Synchronization flag
: LCD_SR_RDY? ( -- 1|0 ) 4 bit LCD_SR bit@ ; \ LCD_SR_RDY, Ready flag
: LCD_SR_UDD ( -- x addr ) 3 bit LCD_SR ; \ LCD_SR_UDD, Update Display Done
: LCD_SR_UDR ( -- x addr ) 2 bit LCD_SR ; \ LCD_SR_UDR, Update display request
: LCD_SR_SOF? ( -- 1|0 ) 1 bit LCD_SR bit@ ; \ LCD_SR_SOF, Start of frame flag
: LCD_SR_ENS ( -- x addr ) 0 bit LCD_SR ; \ LCD_SR_ENS, ENS

\ LCD_CLR (write-only) Reset:0x00000000
: LCD_CLR_UDDC ( -- x addr ) 3 bit LCD_CLR ; \ LCD_CLR_UDDC, Update display done clear
: LCD_CLR_SOFC ( -- x addr ) 1 bit LCD_CLR ; \ LCD_CLR_SOFC, Start of frame flag clear

\ LCD_RAM_COM0 (read-write) Reset:0x00000000
: LCD_RAM_COM0_S30 ( -- x addr ) 30 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S30, S30
: LCD_RAM_COM0_S29 ( -- x addr ) 29 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S29, S29
: LCD_RAM_COM0_S28 ( -- x addr ) 28 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S28, S28
: LCD_RAM_COM0_S27 ( -- x addr ) 27 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S27, S27
: LCD_RAM_COM0_S26 ( -- x addr ) 26 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S26, S26
: LCD_RAM_COM0_S25 ( -- x addr ) 25 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S25, S25
: LCD_RAM_COM0_S24 ( -- x addr ) 24 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S24, S24
: LCD_RAM_COM0_S23 ( -- x addr ) 23 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S23, S23
: LCD_RAM_COM0_S22 ( -- x addr ) 22 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S22, S22
: LCD_RAM_COM0_S21 ( -- x addr ) 21 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S21, S21
: LCD_RAM_COM0_S20 ( -- x addr ) 20 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S20, S20
: LCD_RAM_COM0_S19 ( -- x addr ) 19 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S19, S19
: LCD_RAM_COM0_S18 ( -- x addr ) 18 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S18, S18
: LCD_RAM_COM0_S17 ( -- x addr ) 17 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S17, S17
: LCD_RAM_COM0_S16 ( -- x addr ) 16 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S16, S16
: LCD_RAM_COM0_S15 ( -- x addr ) 15 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S15, S15
: LCD_RAM_COM0_S14 ( -- x addr ) 14 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S14, S14
: LCD_RAM_COM0_S13 ( -- x addr ) 13 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S13, S13
: LCD_RAM_COM0_S12 ( -- x addr ) 12 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S12, S12
: LCD_RAM_COM0_S11 ( -- x addr ) 11 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S11, S11
: LCD_RAM_COM0_S10 ( -- x addr ) 10 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S10, S10
: LCD_RAM_COM0_S09 ( -- x addr ) 9 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S09, S09
: LCD_RAM_COM0_S08 ( -- x addr ) 8 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S08, S08
: LCD_RAM_COM0_S07 ( -- x addr ) 7 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S07, S07
: LCD_RAM_COM0_S06 ( -- x addr ) 6 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S06, S06
: LCD_RAM_COM0_S05 ( -- x addr ) 5 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S05, S05
: LCD_RAM_COM0_S04 ( -- x addr ) 4 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S04, S04
: LCD_RAM_COM0_S03 ( -- x addr ) 3 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S03, S03
: LCD_RAM_COM0_S02 ( -- x addr ) 2 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S02, S02
: LCD_RAM_COM0_S01 ( -- x addr ) 1 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S01, S01
: LCD_RAM_COM0_S00 ( -- x addr ) 0 bit LCD_RAM_COM0 ; \ LCD_RAM_COM0_S00, S00

\ LCD_RAM_COM1 (read-write) Reset:0x00000000
: LCD_RAM_COM1_S31 ( -- x addr ) 31 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S31, S31
: LCD_RAM_COM1_S30 ( -- x addr ) 30 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S30, S30
: LCD_RAM_COM1_S29 ( -- x addr ) 29 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S29, S29
: LCD_RAM_COM1_S28 ( -- x addr ) 28 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S28, S28
: LCD_RAM_COM1_S27 ( -- x addr ) 27 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S27, S27
: LCD_RAM_COM1_S26 ( -- x addr ) 26 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S26, S26
: LCD_RAM_COM1_S25 ( -- x addr ) 25 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S25, S25
: LCD_RAM_COM1_S24 ( -- x addr ) 24 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S24, S24
: LCD_RAM_COM1_S23 ( -- x addr ) 23 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S23, S23
: LCD_RAM_COM1_S22 ( -- x addr ) 22 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S22, S22
: LCD_RAM_COM1_S21 ( -- x addr ) 21 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S21, S21
: LCD_RAM_COM1_S20 ( -- x addr ) 20 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S20, S20
: LCD_RAM_COM1_S19 ( -- x addr ) 19 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S19, S19
: LCD_RAM_COM1_S18 ( -- x addr ) 18 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S18, S18
: LCD_RAM_COM1_S17 ( -- x addr ) 17 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S17, S17
: LCD_RAM_COM1_S16 ( -- x addr ) 16 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S16, S16
: LCD_RAM_COM1_S15 ( -- x addr ) 15 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S15, S15
: LCD_RAM_COM1_S14 ( -- x addr ) 14 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S14, S14
: LCD_RAM_COM1_S13 ( -- x addr ) 13 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S13, S13
: LCD_RAM_COM1_S12 ( -- x addr ) 12 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S12, S12
: LCD_RAM_COM1_S11 ( -- x addr ) 11 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S11, S11
: LCD_RAM_COM1_S10 ( -- x addr ) 10 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S10, S10
: LCD_RAM_COM1_S09 ( -- x addr ) 9 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S09, S09
: LCD_RAM_COM1_S08 ( -- x addr ) 8 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S08, S08
: LCD_RAM_COM1_S07 ( -- x addr ) 7 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S07, S07
: LCD_RAM_COM1_S06 ( -- x addr ) 6 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S06, S06
: LCD_RAM_COM1_S05 ( -- x addr ) 5 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S05, S05
: LCD_RAM_COM1_S04 ( -- x addr ) 4 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S04, S04
: LCD_RAM_COM1_S03 ( -- x addr ) 3 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S03, S03
: LCD_RAM_COM1_S02 ( -- x addr ) 2 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S02, S02
: LCD_RAM_COM1_S01 ( -- x addr ) 1 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S01, S01
: LCD_RAM_COM1_S00 ( -- x addr ) 0 bit LCD_RAM_COM1 ; \ LCD_RAM_COM1_S00, S00

\ LCD_RAM_COM2 (read-write) Reset:0x00000000
: LCD_RAM_COM2_S31 ( -- x addr ) 31 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S31, S31
: LCD_RAM_COM2_S30 ( -- x addr ) 30 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S30, S30
: LCD_RAM_COM2_S29 ( -- x addr ) 29 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S29, S29
: LCD_RAM_COM2_S28 ( -- x addr ) 28 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S28, S28
: LCD_RAM_COM2_S27 ( -- x addr ) 27 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S27, S27
: LCD_RAM_COM2_S26 ( -- x addr ) 26 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S26, S26
: LCD_RAM_COM2_S25 ( -- x addr ) 25 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S25, S25
: LCD_RAM_COM2_S24 ( -- x addr ) 24 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S24, S24
: LCD_RAM_COM2_S23 ( -- x addr ) 23 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S23, S23
: LCD_RAM_COM2_S22 ( -- x addr ) 22 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S22, S22
: LCD_RAM_COM2_S21 ( -- x addr ) 21 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S21, S21
: LCD_RAM_COM2_S20 ( -- x addr ) 20 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S20, S20
: LCD_RAM_COM2_S19 ( -- x addr ) 19 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S19, S19
: LCD_RAM_COM2_S18 ( -- x addr ) 18 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S18, S18
: LCD_RAM_COM2_S17 ( -- x addr ) 17 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S17, S17
: LCD_RAM_COM2_S16 ( -- x addr ) 16 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S16, S16
: LCD_RAM_COM2_S15 ( -- x addr ) 15 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S15, S15
: LCD_RAM_COM2_S14 ( -- x addr ) 14 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S14, S14
: LCD_RAM_COM2_S13 ( -- x addr ) 13 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S13, S13
: LCD_RAM_COM2_S12 ( -- x addr ) 12 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S12, S12
: LCD_RAM_COM2_S11 ( -- x addr ) 11 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S11, S11
: LCD_RAM_COM2_S10 ( -- x addr ) 10 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S10, S10
: LCD_RAM_COM2_S09 ( -- x addr ) 9 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S09, S09
: LCD_RAM_COM2_S08 ( -- x addr ) 8 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S08, S08
: LCD_RAM_COM2_S07 ( -- x addr ) 7 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S07, S07
: LCD_RAM_COM2_S06 ( -- x addr ) 6 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S06, S06
: LCD_RAM_COM2_S05 ( -- x addr ) 5 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S05, S05
: LCD_RAM_COM2_S04 ( -- x addr ) 4 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S04, S04
: LCD_RAM_COM2_S03 ( -- x addr ) 3 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S03, S03
: LCD_RAM_COM2_S02 ( -- x addr ) 2 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S02, S02
: LCD_RAM_COM2_S01 ( -- x addr ) 1 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S01, S01
: LCD_RAM_COM2_S00 ( -- x addr ) 0 bit LCD_RAM_COM2 ; \ LCD_RAM_COM2_S00, S00

\ LCD_RAM_COM3 (read-write) Reset:0x00000000
: LCD_RAM_COM3_S31 ( -- x addr ) 31 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S31, S31
: LCD_RAM_COM3_S30 ( -- x addr ) 30 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S30, S30
: LCD_RAM_COM3_S29 ( -- x addr ) 29 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S29, S29
: LCD_RAM_COM3_S28 ( -- x addr ) 28 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S28, S28
: LCD_RAM_COM3_S27 ( -- x addr ) 27 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S27, S27
: LCD_RAM_COM3_S26 ( -- x addr ) 26 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S26, S26
: LCD_RAM_COM3_S25 ( -- x addr ) 25 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S25, S25
: LCD_RAM_COM3_S24 ( -- x addr ) 24 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S24, S24
: LCD_RAM_COM3_S23 ( -- x addr ) 23 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S23, S23
: LCD_RAM_COM3_S22 ( -- x addr ) 22 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S22, S22
: LCD_RAM_COM3_S21 ( -- x addr ) 21 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S21, S21
: LCD_RAM_COM3_S20 ( -- x addr ) 20 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S20, S20
: LCD_RAM_COM3_S19 ( -- x addr ) 19 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S19, S19
: LCD_RAM_COM3_S18 ( -- x addr ) 18 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S18, S18
: LCD_RAM_COM3_S17 ( -- x addr ) 17 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S17, S17
: LCD_RAM_COM3_S16 ( -- x addr ) 16 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S16, S16
: LCD_RAM_COM3_S15 ( -- x addr ) 15 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S15, S15
: LCD_RAM_COM3_S14 ( -- x addr ) 14 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S14, S14
: LCD_RAM_COM3_S13 ( -- x addr ) 13 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S13, S13
: LCD_RAM_COM3_S12 ( -- x addr ) 12 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S12, S12
: LCD_RAM_COM3_S11 ( -- x addr ) 11 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S11, S11
: LCD_RAM_COM3_S10 ( -- x addr ) 10 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S10, S10
: LCD_RAM_COM3_S09 ( -- x addr ) 9 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S09, S09
: LCD_RAM_COM3_S08 ( -- x addr ) 8 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S08, S08
: LCD_RAM_COM3_S07 ( -- x addr ) 7 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S07, S07
: LCD_RAM_COM3_S06 ( -- x addr ) 6 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S06, S06
: LCD_RAM_COM3_S05 ( -- x addr ) 5 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S05, S05
: LCD_RAM_COM3_S04 ( -- x addr ) 4 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S04, S04
: LCD_RAM_COM3_S03 ( -- x addr ) 3 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S03, S03
: LCD_RAM_COM3_S02 ( -- x addr ) 2 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S02, S02
: LCD_RAM_COM3_S01 ( -- x addr ) 1 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S01, S01
: LCD_RAM_COM3_S00 ( -- x addr ) 0 bit LCD_RAM_COM3 ; \ LCD_RAM_COM3_S00, S00

\ LCD_RAM_COM4 (read-write) Reset:0x00000000
: LCD_RAM_COM4_S31 ( -- x addr ) 31 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S31, S31
: LCD_RAM_COM4_S30 ( -- x addr ) 30 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S30, S30
: LCD_RAM_COM4_S29 ( -- x addr ) 29 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S29, S29
: LCD_RAM_COM4_S28 ( -- x addr ) 28 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S28, S28
: LCD_RAM_COM4_S27 ( -- x addr ) 27 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S27, S27
: LCD_RAM_COM4_S26 ( -- x addr ) 26 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S26, S26
: LCD_RAM_COM4_S25 ( -- x addr ) 25 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S25, S25
: LCD_RAM_COM4_S24 ( -- x addr ) 24 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S24, S24
: LCD_RAM_COM4_S23 ( -- x addr ) 23 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S23, S23
: LCD_RAM_COM4_S22 ( -- x addr ) 22 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S22, S22
: LCD_RAM_COM4_S21 ( -- x addr ) 21 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S21, S21
: LCD_RAM_COM4_S20 ( -- x addr ) 20 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S20, S20
: LCD_RAM_COM4_S19 ( -- x addr ) 19 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S19, S19
: LCD_RAM_COM4_S18 ( -- x addr ) 18 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S18, S18
: LCD_RAM_COM4_S17 ( -- x addr ) 17 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S17, S17
: LCD_RAM_COM4_S16 ( -- x addr ) 16 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S16, S16
: LCD_RAM_COM4_S15 ( -- x addr ) 15 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S15, S15
: LCD_RAM_COM4_S14 ( -- x addr ) 14 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S14, S14
: LCD_RAM_COM4_S13 ( -- x addr ) 13 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S13, S13
: LCD_RAM_COM4_S12 ( -- x addr ) 12 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S12, S12
: LCD_RAM_COM4_S11 ( -- x addr ) 11 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S11, S11
: LCD_RAM_COM4_S10 ( -- x addr ) 10 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S10, S10
: LCD_RAM_COM4_S09 ( -- x addr ) 9 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S09, S09
: LCD_RAM_COM4_S08 ( -- x addr ) 8 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S08, S08
: LCD_RAM_COM4_S07 ( -- x addr ) 7 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S07, S07
: LCD_RAM_COM4_S06 ( -- x addr ) 6 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S06, S06
: LCD_RAM_COM4_S05 ( -- x addr ) 5 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S05, S05
: LCD_RAM_COM4_S04 ( -- x addr ) 4 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S04, S04
: LCD_RAM_COM4_S03 ( -- x addr ) 3 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S03, S03
: LCD_RAM_COM4_S02 ( -- x addr ) 2 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S02, S02
: LCD_RAM_COM4_S01 ( -- x addr ) 1 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S01, S01
: LCD_RAM_COM4_S00 ( -- x addr ) 0 bit LCD_RAM_COM4 ; \ LCD_RAM_COM4_S00, S00

\ LCD_RAM_COM5 (read-write) Reset:0x00000000
: LCD_RAM_COM5_S31 ( -- x addr ) 31 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S31, S31
: LCD_RAM_COM5_S30 ( -- x addr ) 30 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S30, S30
: LCD_RAM_COM5_S29 ( -- x addr ) 29 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S29, S29
: LCD_RAM_COM5_S28 ( -- x addr ) 28 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S28, S28
: LCD_RAM_COM5_S27 ( -- x addr ) 27 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S27, S27
: LCD_RAM_COM5_S26 ( -- x addr ) 26 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S26, S26
: LCD_RAM_COM5_S25 ( -- x addr ) 25 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S25, S25
: LCD_RAM_COM5_S24 ( -- x addr ) 24 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S24, S24
: LCD_RAM_COM5_S23 ( -- x addr ) 23 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S23, S23
: LCD_RAM_COM5_S22 ( -- x addr ) 22 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S22, S22
: LCD_RAM_COM5_S21 ( -- x addr ) 21 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S21, S21
: LCD_RAM_COM5_S20 ( -- x addr ) 20 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S20, S20
: LCD_RAM_COM5_S19 ( -- x addr ) 19 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S19, S19
: LCD_RAM_COM5_S18 ( -- x addr ) 18 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S18, S18
: LCD_RAM_COM5_S17 ( -- x addr ) 17 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S17, S17
: LCD_RAM_COM5_S16 ( -- x addr ) 16 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S16, S16
: LCD_RAM_COM5_S15 ( -- x addr ) 15 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S15, S15
: LCD_RAM_COM5_S14 ( -- x addr ) 14 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S14, S14
: LCD_RAM_COM5_S13 ( -- x addr ) 13 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S13, S13
: LCD_RAM_COM5_S12 ( -- x addr ) 12 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S12, S12
: LCD_RAM_COM5_S11 ( -- x addr ) 11 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S11, S11
: LCD_RAM_COM5_S10 ( -- x addr ) 10 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S10, S10
: LCD_RAM_COM5_S09 ( -- x addr ) 9 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S09, S09
: LCD_RAM_COM5_S08 ( -- x addr ) 8 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S08, S08
: LCD_RAM_COM5_S07 ( -- x addr ) 7 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S07, S07
: LCD_RAM_COM5_S06 ( -- x addr ) 6 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S06, S06
: LCD_RAM_COM5_S05 ( -- x addr ) 5 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S05, S05
: LCD_RAM_COM5_S04 ( -- x addr ) 4 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S04, S04
: LCD_RAM_COM5_S03 ( -- x addr ) 3 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S03, S03
: LCD_RAM_COM5_S02 ( -- x addr ) 2 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S02, S02
: LCD_RAM_COM5_S01 ( -- x addr ) 1 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S01, S01
: LCD_RAM_COM5_S00 ( -- x addr ) 0 bit LCD_RAM_COM5 ; \ LCD_RAM_COM5_S00, S00

\ LCD_RAM_COM6 (read-write) Reset:0x00000000
: LCD_RAM_COM6_S31 ( -- x addr ) 31 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S31, S31
: LCD_RAM_COM6_S30 ( -- x addr ) 30 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S30, S30
: LCD_RAM_COM6_S29 ( -- x addr ) 29 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S29, S29
: LCD_RAM_COM6_S28 ( -- x addr ) 28 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S28, S28
: LCD_RAM_COM6_S27 ( -- x addr ) 27 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S27, S27
: LCD_RAM_COM6_S26 ( -- x addr ) 26 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S26, S26
: LCD_RAM_COM6_S25 ( -- x addr ) 25 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S25, S25
: LCD_RAM_COM6_S24 ( -- x addr ) 24 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S24, S24
: LCD_RAM_COM6_S23 ( -- x addr ) 23 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S23, S23
: LCD_RAM_COM6_S22 ( -- x addr ) 22 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S22, S22
: LCD_RAM_COM6_S21 ( -- x addr ) 21 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S21, S21
: LCD_RAM_COM6_S20 ( -- x addr ) 20 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S20, S20
: LCD_RAM_COM6_S19 ( -- x addr ) 19 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S19, S19
: LCD_RAM_COM6_S18 ( -- x addr ) 18 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S18, S18
: LCD_RAM_COM6_S17 ( -- x addr ) 17 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S17, S17
: LCD_RAM_COM6_S16 ( -- x addr ) 16 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S16, S16
: LCD_RAM_COM6_S15 ( -- x addr ) 15 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S15, S15
: LCD_RAM_COM6_S14 ( -- x addr ) 14 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S14, S14
: LCD_RAM_COM6_S13 ( -- x addr ) 13 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S13, S13
: LCD_RAM_COM6_S12 ( -- x addr ) 12 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S12, S12
: LCD_RAM_COM6_S11 ( -- x addr ) 11 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S11, S11
: LCD_RAM_COM6_S10 ( -- x addr ) 10 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S10, S10
: LCD_RAM_COM6_S09 ( -- x addr ) 9 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S09, S09
: LCD_RAM_COM6_S08 ( -- x addr ) 8 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S08, S08
: LCD_RAM_COM6_S07 ( -- x addr ) 7 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S07, S07
: LCD_RAM_COM6_S06 ( -- x addr ) 6 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S06, S06
: LCD_RAM_COM6_S05 ( -- x addr ) 5 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S05, S05
: LCD_RAM_COM6_S04 ( -- x addr ) 4 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S04, S04
: LCD_RAM_COM6_S03 ( -- x addr ) 3 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S03, S03
: LCD_RAM_COM6_S02 ( -- x addr ) 2 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S02, S02
: LCD_RAM_COM6_S01 ( -- x addr ) 1 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S01, S01
: LCD_RAM_COM6_S00 ( -- x addr ) 0 bit LCD_RAM_COM6 ; \ LCD_RAM_COM6_S00, S00

\ LCD_RAM_COM7 (read-write) Reset:0x00000000
: LCD_RAM_COM7_S31 ( -- x addr ) 31 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S31, S31
: LCD_RAM_COM7_S30 ( -- x addr ) 30 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S30, S30
: LCD_RAM_COM7_S29 ( -- x addr ) 29 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S29, S29
: LCD_RAM_COM7_S28 ( -- x addr ) 28 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S28, S28
: LCD_RAM_COM7_S27 ( -- x addr ) 27 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S27, S27
: LCD_RAM_COM7_S26 ( -- x addr ) 26 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S26, S26
: LCD_RAM_COM7_S25 ( -- x addr ) 25 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S25, S25
: LCD_RAM_COM7_S24 ( -- x addr ) 24 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S24, S24
: LCD_RAM_COM7_S23 ( -- x addr ) 23 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S23, S23
: LCD_RAM_COM7_S22 ( -- x addr ) 22 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S22, S22
: LCD_RAM_COM7_S21 ( -- x addr ) 21 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S21, S21
: LCD_RAM_COM7_S20 ( -- x addr ) 20 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S20, S20
: LCD_RAM_COM7_S19 ( -- x addr ) 19 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S19, S19
: LCD_RAM_COM7_S18 ( -- x addr ) 18 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S18, S18
: LCD_RAM_COM7_S17 ( -- x addr ) 17 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S17, S17
: LCD_RAM_COM7_S16 ( -- x addr ) 16 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S16, S16
: LCD_RAM_COM7_S15 ( -- x addr ) 15 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S15, S15
: LCD_RAM_COM7_S14 ( -- x addr ) 14 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S14, S14
: LCD_RAM_COM7_S13 ( -- x addr ) 13 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S13, S13
: LCD_RAM_COM7_S12 ( -- x addr ) 12 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S12, S12
: LCD_RAM_COM7_S11 ( -- x addr ) 11 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S11, S11
: LCD_RAM_COM7_S10 ( -- x addr ) 10 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S10, S10
: LCD_RAM_COM7_S09 ( -- x addr ) 9 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S09, S09
: LCD_RAM_COM7_S08 ( -- x addr ) 8 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S08, S08
: LCD_RAM_COM7_S07 ( -- x addr ) 7 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S07, S07
: LCD_RAM_COM7_S06 ( -- x addr ) 6 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S06, S06
: LCD_RAM_COM7_S05 ( -- x addr ) 5 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S05, S05
: LCD_RAM_COM7_S04 ( -- x addr ) 4 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S04, S04
: LCD_RAM_COM7_S03 ( -- x addr ) 3 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S03, S03
: LCD_RAM_COM7_S02 ( -- x addr ) 2 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S02, S02
: LCD_RAM_COM7_S01 ( -- x addr ) 1 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S01, S01
: LCD_RAM_COM7_S00 ( -- x addr ) 0 bit LCD_RAM_COM7 ; \ LCD_RAM_COM7_S00, S00

\ LPTIM_ISR (read-only) Reset:0x00000000
: LPTIM_ISR_DOWN? ( --  1|0 ) 6 bit LPTIM_ISR bit@ ; \ LPTIM_ISR_DOWN, Counter direction change up to  down
: LPTIM_ISR_UP? ( --  1|0 ) 5 bit LPTIM_ISR bit@ ; \ LPTIM_ISR_UP, Counter direction change down to  up
: LPTIM_ISR_ARROK? ( --  1|0 ) 4 bit LPTIM_ISR bit@ ; \ LPTIM_ISR_ARROK, Autoreload register update  OK
: LPTIM_ISR_CMPOK? ( --  1|0 ) 3 bit LPTIM_ISR bit@ ; \ LPTIM_ISR_CMPOK, Compare register update OK
: LPTIM_ISR_EXTTRIG? ( --  1|0 ) 2 bit LPTIM_ISR bit@ ; \ LPTIM_ISR_EXTTRIG, External trigger edge  event
: LPTIM_ISR_ARRM? ( --  1|0 ) 1 bit LPTIM_ISR bit@ ; \ LPTIM_ISR_ARRM, Autoreload match
: LPTIM_ISR_CMPM? ( --  1|0 ) 0 bit LPTIM_ISR bit@ ; \ LPTIM_ISR_CMPM, Compare match

\ LPTIM_ICR (write-only) Reset:0x00000000
: LPTIM_ICR_DOWNCF ( -- x addr ) 6 bit LPTIM_ICR ; \ LPTIM_ICR_DOWNCF, Direction change to down Clear  Flag
: LPTIM_ICR_UPCF ( -- x addr ) 5 bit LPTIM_ICR ; \ LPTIM_ICR_UPCF, Direction change to UP Clear  Flag
: LPTIM_ICR_ARROKCF ( -- x addr ) 4 bit LPTIM_ICR ; \ LPTIM_ICR_ARROKCF, Autoreload register update OK Clear  Flag
: LPTIM_ICR_CMPOKCF ( -- x addr ) 3 bit LPTIM_ICR ; \ LPTIM_ICR_CMPOKCF, Compare register update OK Clear  Flag
: LPTIM_ICR_EXTTRIGCF ( -- x addr ) 2 bit LPTIM_ICR ; \ LPTIM_ICR_EXTTRIGCF, External trigger valid edge Clear  Flag
: LPTIM_ICR_ARRMCF ( -- x addr ) 1 bit LPTIM_ICR ; \ LPTIM_ICR_ARRMCF, Autoreload match Clear  Flag
: LPTIM_ICR_CMPMCF ( -- x addr ) 0 bit LPTIM_ICR ; \ LPTIM_ICR_CMPMCF, compare match Clear Flag

\ LPTIM_IER (read-write) Reset:0x00000000
: LPTIM_IER_DOWNIE ( -- x addr ) 6 bit LPTIM_IER ; \ LPTIM_IER_DOWNIE, Direction change to down Interrupt  Enable
: LPTIM_IER_UPIE ( -- x addr ) 5 bit LPTIM_IER ; \ LPTIM_IER_UPIE, Direction change to UP Interrupt  Enable
: LPTIM_IER_ARROKIE ( -- x addr ) 4 bit LPTIM_IER ; \ LPTIM_IER_ARROKIE, Autoreload register update OK Interrupt  Enable
: LPTIM_IER_CMPOKIE ( -- x addr ) 3 bit LPTIM_IER ; \ LPTIM_IER_CMPOKIE, Compare register update OK Interrupt  Enable
: LPTIM_IER_EXTTRIGIE ( -- x addr ) 2 bit LPTIM_IER ; \ LPTIM_IER_EXTTRIGIE, External trigger valid edge Interrupt  Enable
: LPTIM_IER_ARRMIE ( -- x addr ) 1 bit LPTIM_IER ; \ LPTIM_IER_ARRMIE, Autoreload match Interrupt  Enable
: LPTIM_IER_CMPMIE ( -- x addr ) 0 bit LPTIM_IER ; \ LPTIM_IER_CMPMIE, Compare match Interrupt  Enable

\ LPTIM_CFGR (read-write) Reset:0x00000000
: LPTIM_CFGR_ENC ( -- x addr ) 24 bit LPTIM_CFGR ; \ LPTIM_CFGR_ENC, Encoder mode enable
: LPTIM_CFGR_COUNTMODE ( -- x addr ) 23 bit LPTIM_CFGR ; \ LPTIM_CFGR_COUNTMODE, counter mode enabled
: LPTIM_CFGR_PRELOAD ( -- x addr ) 22 bit LPTIM_CFGR ; \ LPTIM_CFGR_PRELOAD, Registers update mode
: LPTIM_CFGR_WAVPOL ( -- x addr ) 21 bit LPTIM_CFGR ; \ LPTIM_CFGR_WAVPOL, Waveform shape polarity
: LPTIM_CFGR_WAVE ( -- x addr ) 20 bit LPTIM_CFGR ; \ LPTIM_CFGR_WAVE, Waveform shape
: LPTIM_CFGR_TIMOUT ( -- x addr ) 19 bit LPTIM_CFGR ; \ LPTIM_CFGR_TIMOUT, Timeout enable
: LPTIM_CFGR_TRIGEN ( %bb -- x addr ) 17 lshift LPTIM_CFGR ; \ LPTIM_CFGR_TRIGEN, Trigger enable and  polarity
: LPTIM_CFGR_TRIGSEL ( %bbb -- x addr ) 13 lshift LPTIM_CFGR ; \ LPTIM_CFGR_TRIGSEL, Trigger selector
: LPTIM_CFGR_PRESC ( %bbb -- x addr ) 9 lshift LPTIM_CFGR ; \ LPTIM_CFGR_PRESC, Clock prescaler
: LPTIM_CFGR_TRGFLT ( %bb -- x addr ) 6 lshift LPTIM_CFGR ; \ LPTIM_CFGR_TRGFLT, Configurable digital filter for  trigger
: LPTIM_CFGR_CKFLT ( %bb -- x addr ) 3 lshift LPTIM_CFGR ; \ LPTIM_CFGR_CKFLT, Configurable digital filter for external  clock
: LPTIM_CFGR_CKPOL ( %bb -- x addr ) 1 lshift LPTIM_CFGR ; \ LPTIM_CFGR_CKPOL, Clock Polarity
: LPTIM_CFGR_CKSEL ( -- x addr ) 0 bit LPTIM_CFGR ; \ LPTIM_CFGR_CKSEL, Clock selector

\ LPTIM_CR (read-write) Reset:0x00000000
: LPTIM_CR_CNTSTRT ( -- x addr ) 2 bit LPTIM_CR ; \ LPTIM_CR_CNTSTRT, Timer start in continuous  mode
: LPTIM_CR_SNGSTRT ( -- x addr ) 1 bit LPTIM_CR ; \ LPTIM_CR_SNGSTRT, LPTIM start in single mode
: LPTIM_CR_ENABLE ( -- x addr ) 0 bit LPTIM_CR ; \ LPTIM_CR_ENABLE, LPTIM Enable

\ LPTIM_CMP (read-write) Reset:0x00000000
: LPTIM_CMP_CMP ( %bbbbbbbbbbbbbbbb -- x addr ) LPTIM_CMP ; \ LPTIM_CMP_CMP, Compare value.

\ LPTIM_ARR (read-write) Reset:0x00000001
: LPTIM_ARR_ARR ( %bbbbbbbbbbbbbbbb -- x addr ) LPTIM_ARR ; \ LPTIM_ARR_ARR, Auto reload value.

\ LPTIM_CNT (read-only) Reset:0x00000000
: LPTIM_CNT_CNT? ( --  x ) LPTIM_CNT @ ; \ LPTIM_CNT_CNT, Counter value.

\ RNG_CR (read-write) Reset:0x00000000
: RNG_CR_IE ( -- x addr ) 3 bit RNG_CR ; \ RNG_CR_IE, Interrupt enable
: RNG_CR_RNGEN ( -- x addr ) 2 bit RNG_CR ; \ RNG_CR_RNGEN, Random number generator  enable

\ RNG_SR (multiple-access)  Reset:0x00000000
: RNG_SR_SEIS? ( -- 1|0 ) 6 bit RNG_SR bit@ ; \ RNG_SR_SEIS, Seed error interrupt  status
: RNG_SR_CEIS? ( -- 1|0 ) 5 bit RNG_SR bit@ ; \ RNG_SR_CEIS, Clock error interrupt  status
: RNG_SR_SECS? ( -- 1|0 ) 2 bit RNG_SR bit@ ; \ RNG_SR_SECS, Seed error current status
: RNG_SR_CECS? ( -- 1|0 ) 1 bit RNG_SR bit@ ; \ RNG_SR_CECS, Clock error current status
: RNG_SR_DRDY ( -- x addr ) 0 bit RNG_SR ; \ RNG_SR_DRDY, Data ready

\ RNG_DR (read-only) Reset:0x00000000
: RNG_DR_RNDATA? ( --  x ) RNG_DR @ ; \ RNG_DR_RNDATA, Random data

\ RTC_TR (read-write) Reset:0x00000000
: RTC_TR_PM ( -- x addr ) 22 bit RTC_TR ; \ RTC_TR_PM, AM/PM notation
: RTC_TR_HT ( %bb -- x addr ) 20 lshift RTC_TR ; \ RTC_TR_HT, Hour tens in BCD format
: RTC_TR_HU ( %bbbb -- x addr ) 16 lshift RTC_TR ; \ RTC_TR_HU, Hour units in BCD format
: RTC_TR_MNT ( %bbb -- x addr ) 12 lshift RTC_TR ; \ RTC_TR_MNT, Minute tens in BCD format
: RTC_TR_MNU ( %bbbb -- x addr ) 8 lshift RTC_TR ; \ RTC_TR_MNU, Minute units in BCD format
: RTC_TR_ST ( %bbb -- x addr ) 4 lshift RTC_TR ; \ RTC_TR_ST, Second tens in BCD format
: RTC_TR_SU ( %bbbb -- x addr ) RTC_TR ; \ RTC_TR_SU, Second units in BCD format

\ RTC_DR (read-write) Reset:0x00000000
: RTC_DR_YT ( %bbbb -- x addr ) 20 lshift RTC_DR ; \ RTC_DR_YT, Year tens in BCD format
: RTC_DR_YU ( %bbbb -- x addr ) 16 lshift RTC_DR ; \ RTC_DR_YU, Year units in BCD format
: RTC_DR_WDU ( %bbb -- x addr ) 13 lshift RTC_DR ; \ RTC_DR_WDU, Week day units
: RTC_DR_MT ( -- x addr ) 12 bit RTC_DR ; \ RTC_DR_MT, Month tens in BCD format
: RTC_DR_MU ( %bbbb -- x addr ) 8 lshift RTC_DR ; \ RTC_DR_MU, Month units in BCD format
: RTC_DR_DT ( %bb -- x addr ) 4 lshift RTC_DR ; \ RTC_DR_DT, Date tens in BCD format
: RTC_DR_DU ( %bbbb -- x addr ) RTC_DR ; \ RTC_DR_DU, Date units in BCD format

\ RTC_CR (multiple-access)  Reset:0x00000000
: RTC_CR_COE ( -- x addr ) 23 bit RTC_CR ; \ RTC_CR_COE, Calibration output enable
: RTC_CR_OSEL ( %bb -- x addr ) 21 lshift RTC_CR ; \ RTC_CR_OSEL, Output selection
: RTC_CR_POL ( -- x addr ) 20 bit RTC_CR ; \ RTC_CR_POL, Output polarity
: RTC_CR_COSEL ( -- x addr ) 19 bit RTC_CR ; \ RTC_CR_COSEL, Calibration output  selection
: RTC_CR_BKP ( -- x addr ) 18 bit RTC_CR ; \ RTC_CR_BKP, Backup
: RTC_CR_SUB1H ( -- x addr ) 17 bit RTC_CR ; \ RTC_CR_SUB1H, Subtract 1 hour winter time  change
: RTC_CR_ADD1H ( -- x addr ) 16 bit RTC_CR ; \ RTC_CR_ADD1H, Add 1 hour summer time  change
: RTC_CR_TSIE ( -- x addr ) 15 bit RTC_CR ; \ RTC_CR_TSIE, Time-stamp interrupt  enable
: RTC_CR_WUTIE ( -- x addr ) 14 bit RTC_CR ; \ RTC_CR_WUTIE, Wakeup timer interrupt  enable
: RTC_CR_ALRBIE ( -- x addr ) 13 bit RTC_CR ; \ RTC_CR_ALRBIE, Alarm B interrupt enable
: RTC_CR_ALRAIE ( -- x addr ) 12 bit RTC_CR ; \ RTC_CR_ALRAIE, Alarm A interrupt enable
: RTC_CR_TSE ( -- x addr ) 11 bit RTC_CR ; \ RTC_CR_TSE, timestamp enable
: RTC_CR_WUTE ( -- x addr ) 10 bit RTC_CR ; \ RTC_CR_WUTE, Wakeup timer enable
: RTC_CR_ALRBE ( -- x addr ) 9 bit RTC_CR ; \ RTC_CR_ALRBE, Alarm B enable
: RTC_CR_ALRAE ( -- x addr ) 8 bit RTC_CR ; \ RTC_CR_ALRAE, Alarm A enable
: RTC_CR_FMT ( -- x addr ) 6 bit RTC_CR ; \ RTC_CR_FMT, Hour format
: RTC_CR_BYPSHAD ( -- x addr ) 5 bit RTC_CR ; \ RTC_CR_BYPSHAD, Bypass the shadow  registers
: RTC_CR_REFCKON ( -- x addr ) 4 bit RTC_CR ; \ RTC_CR_REFCKON, RTC_REFIN reference clock detection  enable 50 or 60 Hz
: RTC_CR_TSEDGE ( -- x addr ) 3 bit RTC_CR ; \ RTC_CR_TSEDGE, Time-stamp event active  edge
: RTC_CR_WUCKSEL ( %bbb -- x addr ) RTC_CR ; \ RTC_CR_WUCKSEL, Wakeup clock selection

\ RTC_ISR (multiple-access)  Reset:0x00000000
: RTC_ISR_TAMP2F? ( -- 1|0 ) 14 bit RTC_ISR bit@ ; \ RTC_ISR_TAMP2F, RTC_TAMP2 detection flag
: RTC_ISR_TAMP1F? ( -- 1|0 ) 13 bit RTC_ISR bit@ ; \ RTC_ISR_TAMP1F, RTC_TAMP1 detection flag
: RTC_ISR_TSOVF? ( -- 1|0 ) 12 bit RTC_ISR bit@ ; \ RTC_ISR_TSOVF, Time-stamp overflow flag
: RTC_ISR_TSF? ( -- 1|0 ) 11 bit RTC_ISR bit@ ; \ RTC_ISR_TSF, Time-stamp flag
: RTC_ISR_WUTF? ( -- 1|0 ) 10 bit RTC_ISR bit@ ; \ RTC_ISR_WUTF, Wakeup timer flag
: RTC_ISR_ALRBF? ( -- 1|0 ) 9 bit RTC_ISR bit@ ; \ RTC_ISR_ALRBF, Alarm B flag
: RTC_ISR_ALRAF? ( -- 1|0 ) 8 bit RTC_ISR bit@ ; \ RTC_ISR_ALRAF, Alarm A flag
: RTC_ISR_INIT ( -- x addr ) 7 bit RTC_ISR ; \ RTC_ISR_INIT, Initialization mode
: RTC_ISR_INITF? ( -- 1|0 ) 6 bit RTC_ISR bit@ ; \ RTC_ISR_INITF, Initialization flag
: RTC_ISR_RSF? ( -- 1|0 ) 5 bit RTC_ISR bit@ ; \ RTC_ISR_RSF, Registers synchronization  flag
: RTC_ISR_INITS? ( -- 1|0 ) 4 bit RTC_ISR bit@ ; \ RTC_ISR_INITS, Initialization status flag
: RTC_ISR_SHPF ( -- x addr ) 3 bit RTC_ISR ; \ RTC_ISR_SHPF, Shift operation pending
: RTC_ISR_WUTWF? ( -- 1|0 ) 2 bit RTC_ISR bit@ ; \ RTC_ISR_WUTWF, Wakeup timer write flag
: RTC_ISR_ALRBWF? ( -- 1|0 ) 1 bit RTC_ISR bit@ ; \ RTC_ISR_ALRBWF, Alarm B write flag
: RTC_ISR_ALRAWF? ( -- 1|0 ) 0 bit RTC_ISR bit@ ; \ RTC_ISR_ALRAWF, Alarm A write flag

\ RTC_PRER (read-write) Reset:0x00000000
: RTC_PRER_PREDIV_A ( %bbbbbbb -- x addr ) 16 lshift RTC_PRER ; \ RTC_PRER_PREDIV_A, Asynchronous prescaler  factor
: RTC_PRER_PREDIV_S ( %bbbbbbbbbbbbbbbb -- x addr ) RTC_PRER ; \ RTC_PRER_PREDIV_S, Synchronous prescaler  factor

\ RTC_WUTR (read-write) Reset:0x00000000
: RTC_WUTR_WUT ( %bbbbbbbbbbbbbbbb -- x addr ) RTC_WUTR ; \ RTC_WUTR_WUT, Wakeup auto-reload value  bits

\ RTC_ALRMAR (read-write) Reset:0x00000000
: RTC_ALRMAR_MSK4 ( -- x addr ) 31 bit RTC_ALRMAR ; \ RTC_ALRMAR_MSK4, Alarm A date mask
: RTC_ALRMAR_WDSEL ( -- x addr ) 30 bit RTC_ALRMAR ; \ RTC_ALRMAR_WDSEL, Week day selection
: RTC_ALRMAR_DT ( %bb -- x addr ) 28 lshift RTC_ALRMAR ; \ RTC_ALRMAR_DT, Date tens in BCD format.
: RTC_ALRMAR_DU ( %bbbb -- x addr ) 24 lshift RTC_ALRMAR ; \ RTC_ALRMAR_DU, Date units or day in BCD  format.
: RTC_ALRMAR_MSK3 ( -- x addr ) 23 bit RTC_ALRMAR ; \ RTC_ALRMAR_MSK3, Alarm A hours mask
: RTC_ALRMAR_PM ( -- x addr ) 22 bit RTC_ALRMAR ; \ RTC_ALRMAR_PM, AM/PM notation
: RTC_ALRMAR_HT ( %bb -- x addr ) 20 lshift RTC_ALRMAR ; \ RTC_ALRMAR_HT, Hour tens in BCD format.
: RTC_ALRMAR_HU ( %bbbb -- x addr ) 16 lshift RTC_ALRMAR ; \ RTC_ALRMAR_HU, Hour units in BCD format.
: RTC_ALRMAR_MSK2 ( -- x addr ) 15 bit RTC_ALRMAR ; \ RTC_ALRMAR_MSK2, Alarm A minutes mask
: RTC_ALRMAR_MNT ( %bbb -- x addr ) 12 lshift RTC_ALRMAR ; \ RTC_ALRMAR_MNT, Minute tens in BCD format.
: RTC_ALRMAR_MNU ( %bbbb -- x addr ) 8 lshift RTC_ALRMAR ; \ RTC_ALRMAR_MNU, Minute units in BCD  format.
: RTC_ALRMAR_MSK1 ( -- x addr ) 7 bit RTC_ALRMAR ; \ RTC_ALRMAR_MSK1, Alarm A seconds mask
: RTC_ALRMAR_ST ( %bbb -- x addr ) 4 lshift RTC_ALRMAR ; \ RTC_ALRMAR_ST, Second tens in BCD format.
: RTC_ALRMAR_SU ( %bbbb -- x addr ) RTC_ALRMAR ; \ RTC_ALRMAR_SU, Second units in BCD  format.

\ RTC_ALRMBR (read-write) Reset:0x00000000
: RTC_ALRMBR_MSK4 ( -- x addr ) 31 bit RTC_ALRMBR ; \ RTC_ALRMBR_MSK4, Alarm B date mask
: RTC_ALRMBR_WDSEL ( -- x addr ) 30 bit RTC_ALRMBR ; \ RTC_ALRMBR_WDSEL, Week day selection
: RTC_ALRMBR_DT ( %bb -- x addr ) 28 lshift RTC_ALRMBR ; \ RTC_ALRMBR_DT, Date tens in BCD format
: RTC_ALRMBR_DU ( %bbbb -- x addr ) 24 lshift RTC_ALRMBR ; \ RTC_ALRMBR_DU, Date units or day in BCD  format
: RTC_ALRMBR_MSK3 ( -- x addr ) 23 bit RTC_ALRMBR ; \ RTC_ALRMBR_MSK3, Alarm B hours mask
: RTC_ALRMBR_PM ( -- x addr ) 22 bit RTC_ALRMBR ; \ RTC_ALRMBR_PM, AM/PM notation
: RTC_ALRMBR_HT ( %bb -- x addr ) 20 lshift RTC_ALRMBR ; \ RTC_ALRMBR_HT, Hour tens in BCD format
: RTC_ALRMBR_HU ( %bbbb -- x addr ) 16 lshift RTC_ALRMBR ; \ RTC_ALRMBR_HU, Hour units in BCD format
: RTC_ALRMBR_MSK2 ( -- x addr ) 15 bit RTC_ALRMBR ; \ RTC_ALRMBR_MSK2, Alarm B minutes mask
: RTC_ALRMBR_MNT ( %bbb -- x addr ) 12 lshift RTC_ALRMBR ; \ RTC_ALRMBR_MNT, Minute tens in BCD format
: RTC_ALRMBR_MNU ( %bbbb -- x addr ) 8 lshift RTC_ALRMBR ; \ RTC_ALRMBR_MNU, Minute units in BCD format
: RTC_ALRMBR_MSK1 ( -- x addr ) 7 bit RTC_ALRMBR ; \ RTC_ALRMBR_MSK1, Alarm B seconds mask
: RTC_ALRMBR_ST ( %bbb -- x addr ) 4 lshift RTC_ALRMBR ; \ RTC_ALRMBR_ST, Second tens in BCD format
: RTC_ALRMBR_SU ( %bbbb -- x addr ) RTC_ALRMBR ; \ RTC_ALRMBR_SU, Second units in BCD format

\ RTC_WPR (write-only) Reset:0x00000000
: RTC_WPR_KEY ( %bbbbbbbb -- x addr ) RTC_WPR ; \ RTC_WPR_KEY, Write protection key

\ RTC_SSR (read-only) Reset:0x00000000
: RTC_SSR_SS? ( --  x ) RTC_SSR @ ; \ RTC_SSR_SS, Sub second value

\ RTC_SHIFTR (write-only) Reset:0x00000000
: RTC_SHIFTR_ADD1S ( -- x addr ) 31 bit RTC_SHIFTR ; \ RTC_SHIFTR_ADD1S, Add one second
: RTC_SHIFTR_SUBFS ( %bbbbbbbbbbbbbbb -- x addr ) RTC_SHIFTR ; \ RTC_SHIFTR_SUBFS, Subtract a fraction of a  second

\ RTC_TSTR (read-only) Reset:0x00000000
: RTC_TSTR_PM? ( --  1|0 ) 22 bit RTC_TSTR bit@ ; \ RTC_TSTR_PM, AM/PM notation
: RTC_TSTR_HT? ( --  x ) 20 lshift RTC_TSTR @ ; \ RTC_TSTR_HT, Hour tens in BCD format.
: RTC_TSTR_HU? ( --  x ) 16 lshift RTC_TSTR @ ; \ RTC_TSTR_HU, Hour units in BCD format.
: RTC_TSTR_MNT? ( --  x ) 12 lshift RTC_TSTR @ ; \ RTC_TSTR_MNT, Minute tens in BCD format.
: RTC_TSTR_MNU? ( --  x ) 8 lshift RTC_TSTR @ ; \ RTC_TSTR_MNU, Minute units in BCD  format.
: RTC_TSTR_ST? ( --  x ) 4 lshift RTC_TSTR @ ; \ RTC_TSTR_ST, Second tens in BCD format.
: RTC_TSTR_SU? ( --  x ) RTC_TSTR @ ; \ RTC_TSTR_SU, Second units in BCD  format.

\ RTC_TSDR (read-only) Reset:0x00000000
: RTC_TSDR_WDU? ( --  x ) 13 lshift RTC_TSDR @ ; \ RTC_TSDR_WDU, Week day units
: RTC_TSDR_MT? ( --  1|0 ) 12 bit RTC_TSDR bit@ ; \ RTC_TSDR_MT, Month tens in BCD format
: RTC_TSDR_MU? ( --  x ) 8 lshift RTC_TSDR @ ; \ RTC_TSDR_MU, Month units in BCD format
: RTC_TSDR_DT? ( --  x ) 4 lshift RTC_TSDR @ ; \ RTC_TSDR_DT, Date tens in BCD format
: RTC_TSDR_DU? ( --  x ) RTC_TSDR @ ; \ RTC_TSDR_DU, Date units in BCD format

\ RTC_TSSSR (read-only) Reset:0x00000000
: RTC_TSSSR_SS? ( --  x ) RTC_TSSSR @ ; \ RTC_TSSSR_SS, Sub second value

\ RTC_CALR (read-write) Reset:0x00000000
: RTC_CALR_CALP ( -- x addr ) 15 bit RTC_CALR ; \ RTC_CALR_CALP, Use an 8-second calibration cycle  period
: RTC_CALR_CALW8 ( -- x addr ) 14 bit RTC_CALR ; \ RTC_CALR_CALW8, Use a 16-second calibration cycle  period
: RTC_CALR_CALW16 ( -- x addr ) 13 bit RTC_CALR ; \ RTC_CALR_CALW16, Reserved
: RTC_CALR_CALM ( %bbbbbbbbb -- x addr ) RTC_CALR ; \ RTC_CALR_CALM, Calibration minus

\ RTC_TAMPCR (read-write) Reset:0x00000000
: RTC_TAMPCR_TAMP2MF ( -- x addr ) 21 bit RTC_TAMPCR ; \ RTC_TAMPCR_TAMP2MF, Tamper 2 mask flag
: RTC_TAMPCR_TAMP2NOERASE ( -- x addr ) 20 bit RTC_TAMPCR ; \ RTC_TAMPCR_TAMP2NOERASE, Tamper 2 no erase
: RTC_TAMPCR_TAMP2IE ( -- x addr ) 19 bit RTC_TAMPCR ; \ RTC_TAMPCR_TAMP2IE, Tamper 2 interrupt enable
: RTC_TAMPCR_TAMP1MF ( -- x addr ) 18 bit RTC_TAMPCR ; \ RTC_TAMPCR_TAMP1MF, Tamper 1 mask flag
: RTC_TAMPCR_TAMP1NOERASE ( -- x addr ) 17 bit RTC_TAMPCR ; \ RTC_TAMPCR_TAMP1NOERASE, Tamper 1 no erase
: RTC_TAMPCR_TAMP1IE ( -- x addr ) 16 bit RTC_TAMPCR ; \ RTC_TAMPCR_TAMP1IE, Tamper 1 interrupt enable
: RTC_TAMPCR_TAMPPUDIS ( -- x addr ) 15 bit RTC_TAMPCR ; \ RTC_TAMPCR_TAMPPUDIS, RTC_TAMPx pull-up disable
: RTC_TAMPCR_TAMPPRCH ( %bb -- x addr ) 13 lshift RTC_TAMPCR ; \ RTC_TAMPCR_TAMPPRCH, RTC_TAMPx precharge  duration
: RTC_TAMPCR_TAMPFLT ( %bb -- x addr ) 11 lshift RTC_TAMPCR ; \ RTC_TAMPCR_TAMPFLT, RTC_TAMPx filter count
: RTC_TAMPCR_TAMPFREQ ( %bbb -- x addr ) 8 lshift RTC_TAMPCR ; \ RTC_TAMPCR_TAMPFREQ, Tamper sampling frequency
: RTC_TAMPCR_TAMPTS ( -- x addr ) 7 bit RTC_TAMPCR ; \ RTC_TAMPCR_TAMPTS, Activate timestamp on tamper detection  event
: RTC_TAMPCR_TAMP2_TRG ( -- x addr ) 4 bit RTC_TAMPCR ; \ RTC_TAMPCR_TAMP2_TRG, Active level for RTC_TAMP2  input
: RTC_TAMPCR_TAMP2E ( -- x addr ) 3 bit RTC_TAMPCR ; \ RTC_TAMPCR_TAMP2E, RTC_TAMP2 input detection  enable
: RTC_TAMPCR_TAMPIE ( -- x addr ) 2 bit RTC_TAMPCR ; \ RTC_TAMPCR_TAMPIE, Tamper interrupt enable
: RTC_TAMPCR_TAMP1TRG ( -- x addr ) 1 bit RTC_TAMPCR ; \ RTC_TAMPCR_TAMP1TRG, Active level for RTC_TAMP1  input
: RTC_TAMPCR_TAMP1E ( -- x addr ) 0 bit RTC_TAMPCR ; \ RTC_TAMPCR_TAMP1E, RTC_TAMP1 input detection  enable

\ RTC_ALRMASSR (read-write) Reset:0x00000000
: RTC_ALRMASSR_MASKSS ( %bbbb -- x addr ) 24 lshift RTC_ALRMASSR ; \ RTC_ALRMASSR_MASKSS, Mask the most-significant bits starting  at this bit
: RTC_ALRMASSR_SS ( %bbbbbbbbbbbbbbb -- x addr ) RTC_ALRMASSR ; \ RTC_ALRMASSR_SS, Sub seconds value

\ RTC_ALRMBSSR (read-write) Reset:0x00000000
: RTC_ALRMBSSR_MASKSS ( %bbbb -- x addr ) 24 lshift RTC_ALRMBSSR ; \ RTC_ALRMBSSR_MASKSS, Mask the most-significant bits starting  at this bit
: RTC_ALRMBSSR_SS ( %bbbbbbbbbbbbbbb -- x addr ) RTC_ALRMBSSR ; \ RTC_ALRMBSSR_SS, Sub seconds value

\ RTC_OR (read-write) Reset:0x00000000
: RTC_OR_RTC_OUT_RMP ( -- x addr ) 1 bit RTC_OR ; \ RTC_OR_RTC_OUT_RMP, RTC_ALARM on PC13 output  type
: RTC_OR_RTC_ALARM_TYPE ( -- x addr ) 0 bit RTC_OR ; \ RTC_OR_RTC_ALARM_TYPE, RTC_ALARM on PC13 output  type

\ RTC_BKP0R (read-write) Reset:0x00000000
: RTC_BKP0R_BKP ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) RTC_BKP0R ; \ RTC_BKP0R_BKP, BKP

\ RTC_BKP1R (read-write) Reset:0x00000000
: RTC_BKP1R_BKP ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) RTC_BKP1R ; \ RTC_BKP1R_BKP, BKP

\ RTC_BKP2R (read-write) Reset:0x00000000
: RTC_BKP2R_BKP ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) RTC_BKP2R ; \ RTC_BKP2R_BKP, BKP

\ RTC_BKP3R (read-write) Reset:0x00000000
: RTC_BKP3R_BKP ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) RTC_BKP3R ; \ RTC_BKP3R_BKP, BKP

\ RTC_BKP4R (read-write) Reset:0x00000000
: RTC_BKP4R_BKP ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) RTC_BKP4R ; \ RTC_BKP4R_BKP, BKP

\ USART1_CR1 (read-write) Reset:0x0000
: USART1_CR1_M1 ( -- x addr ) 28 bit USART1_CR1 ; \ USART1_CR1_M1, Word length
: USART1_CR1_EOBIE ( -- x addr ) 27 bit USART1_CR1 ; \ USART1_CR1_EOBIE, End of Block interrupt  enable
: USART1_CR1_RTOIE ( -- x addr ) 26 bit USART1_CR1 ; \ USART1_CR1_RTOIE, Receiver timeout interrupt  enable
: USART1_CR1_DEAT4 ( -- x addr ) 25 bit USART1_CR1 ; \ USART1_CR1_DEAT4, Driver Enable assertion  time
: USART1_CR1_DEAT3 ( -- x addr ) 24 bit USART1_CR1 ; \ USART1_CR1_DEAT3, DEAT3
: USART1_CR1_DEAT2 ( -- x addr ) 23 bit USART1_CR1 ; \ USART1_CR1_DEAT2, DEAT2
: USART1_CR1_DEAT1 ( -- x addr ) 22 bit USART1_CR1 ; \ USART1_CR1_DEAT1, DEAT1
: USART1_CR1_DEAT0 ( -- x addr ) 21 bit USART1_CR1 ; \ USART1_CR1_DEAT0, DEAT0
: USART1_CR1_DEDT4 ( -- x addr ) 20 bit USART1_CR1 ; \ USART1_CR1_DEDT4, Driver Enable de-assertion  time
: USART1_CR1_DEDT3 ( -- x addr ) 19 bit USART1_CR1 ; \ USART1_CR1_DEDT3, DEDT3
: USART1_CR1_DEDT2 ( -- x addr ) 18 bit USART1_CR1 ; \ USART1_CR1_DEDT2, DEDT2
: USART1_CR1_DEDT1 ( -- x addr ) 17 bit USART1_CR1 ; \ USART1_CR1_DEDT1, DEDT1
: USART1_CR1_DEDT0 ( -- x addr ) 16 bit USART1_CR1 ; \ USART1_CR1_DEDT0, DEDT0
: USART1_CR1_OVER8 ( -- x addr ) 15 bit USART1_CR1 ; \ USART1_CR1_OVER8, Oversampling mode
: USART1_CR1_CMIE ( -- x addr ) 14 bit USART1_CR1 ; \ USART1_CR1_CMIE, Character match interrupt  enable
: USART1_CR1_MME ( -- x addr ) 13 bit USART1_CR1 ; \ USART1_CR1_MME, Mute mode enable
: USART1_CR1_M0 ( -- x addr ) 12 bit USART1_CR1 ; \ USART1_CR1_M0, Word length
: USART1_CR1_WAKE ( -- x addr ) 11 bit USART1_CR1 ; \ USART1_CR1_WAKE, Receiver wakeup method
: USART1_CR1_PCE ( -- x addr ) 10 bit USART1_CR1 ; \ USART1_CR1_PCE, Parity control enable
: USART1_CR1_PS ( -- x addr ) 9 bit USART1_CR1 ; \ USART1_CR1_PS, Parity selection
: USART1_CR1_PEIE ( -- x addr ) 8 bit USART1_CR1 ; \ USART1_CR1_PEIE, PE interrupt enable
: USART1_CR1_TXEIE ( -- x addr ) 7 bit USART1_CR1 ; \ USART1_CR1_TXEIE, interrupt enable
: USART1_CR1_TCIE ( -- x addr ) 6 bit USART1_CR1 ; \ USART1_CR1_TCIE, Transmission complete interrupt  enable
: USART1_CR1_RXNEIE ( -- x addr ) 5 bit USART1_CR1 ; \ USART1_CR1_RXNEIE, RXNE interrupt enable
: USART1_CR1_IDLEIE ( -- x addr ) 4 bit USART1_CR1 ; \ USART1_CR1_IDLEIE, IDLE interrupt enable
: USART1_CR1_TE ( -- x addr ) 3 bit USART1_CR1 ; \ USART1_CR1_TE, Transmitter enable
: USART1_CR1_RE ( -- x addr ) 2 bit USART1_CR1 ; \ USART1_CR1_RE, Receiver enable
: USART1_CR1_UESM ( -- x addr ) 1 bit USART1_CR1 ; \ USART1_CR1_UESM, USART enable in Stop mode
: USART1_CR1_UE ( -- x addr ) 0 bit USART1_CR1 ; \ USART1_CR1_UE, USART enable

\ USART1_CR2 (read-write) Reset:0x0000
: USART1_CR2_ADD4_7 ( %bbbb -- x addr ) 28 lshift USART1_CR2 ; \ USART1_CR2_ADD4_7, Address of the USART node
: USART1_CR2_ADD0_3 ( %bbbb -- x addr ) 24 lshift USART1_CR2 ; \ USART1_CR2_ADD0_3, Address of the USART node
: USART1_CR2_RTOEN ( -- x addr ) 23 bit USART1_CR2 ; \ USART1_CR2_RTOEN, Receiver timeout enable
: USART1_CR2_ABRMOD1 ( -- x addr ) 22 bit USART1_CR2 ; \ USART1_CR2_ABRMOD1, Auto baud rate mode
: USART1_CR2_ABRMOD0 ( -- x addr ) 21 bit USART1_CR2 ; \ USART1_CR2_ABRMOD0, ABRMOD0
: USART1_CR2_ABREN ( -- x addr ) 20 bit USART1_CR2 ; \ USART1_CR2_ABREN, Auto baud rate enable
: USART1_CR2_MSBFIRST ( -- x addr ) 19 bit USART1_CR2 ; \ USART1_CR2_MSBFIRST, Most significant bit first
: USART1_CR2_TAINV ( -- x addr ) 18 bit USART1_CR2 ; \ USART1_CR2_TAINV, Binary data inversion
: USART1_CR2_TXINV ( -- x addr ) 17 bit USART1_CR2 ; \ USART1_CR2_TXINV, TX pin active level  inversion
: USART1_CR2_RXINV ( -- x addr ) 16 bit USART1_CR2 ; \ USART1_CR2_RXINV, RX pin active level  inversion
: USART1_CR2_SWAP ( -- x addr ) 15 bit USART1_CR2 ; \ USART1_CR2_SWAP, Swap TX/RX pins
: USART1_CR2_LINEN ( -- x addr ) 14 bit USART1_CR2 ; \ USART1_CR2_LINEN, LIN mode enable
: USART1_CR2_STOP ( %bb -- x addr ) 12 lshift USART1_CR2 ; \ USART1_CR2_STOP, STOP bits
: USART1_CR2_CLKEN ( -- x addr ) 11 bit USART1_CR2 ; \ USART1_CR2_CLKEN, Clock enable
: USART1_CR2_CPOL ( -- x addr ) 10 bit USART1_CR2 ; \ USART1_CR2_CPOL, Clock polarity
: USART1_CR2_CPHA ( -- x addr ) 9 bit USART1_CR2 ; \ USART1_CR2_CPHA, Clock phase
: USART1_CR2_LBCL ( -- x addr ) 8 bit USART1_CR2 ; \ USART1_CR2_LBCL, Last bit clock pulse
: USART1_CR2_LBDIE ( -- x addr ) 6 bit USART1_CR2 ; \ USART1_CR2_LBDIE, LIN break detection interrupt  enable
: USART1_CR2_LBDL ( -- x addr ) 5 bit USART1_CR2 ; \ USART1_CR2_LBDL, LIN break detection length
: USART1_CR2_ADDM7 ( -- x addr ) 4 bit USART1_CR2 ; \ USART1_CR2_ADDM7, 7-bit Address Detection/4-bit Address  Detection

\ USART1_CR3 (read-write) Reset:0x0000
: USART1_CR3_WUFIE ( -- x addr ) 22 bit USART1_CR3 ; \ USART1_CR3_WUFIE, Wakeup from Stop mode interrupt  enable
: USART1_CR3_WUS ( %bb -- x addr ) 20 lshift USART1_CR3 ; \ USART1_CR3_WUS, Wakeup from Stop mode interrupt flag  selection
: USART1_CR3_SCARCNT ( %bbb -- x addr ) 17 lshift USART1_CR3 ; \ USART1_CR3_SCARCNT, Smartcard auto-retry count
: USART1_CR3_DEP ( -- x addr ) 15 bit USART1_CR3 ; \ USART1_CR3_DEP, Driver enable polarity  selection
: USART1_CR3_DEM ( -- x addr ) 14 bit USART1_CR3 ; \ USART1_CR3_DEM, Driver enable mode
: USART1_CR3_DDRE ( -- x addr ) 13 bit USART1_CR3 ; \ USART1_CR3_DDRE, DMA Disable on Reception  Error
: USART1_CR3_OVRDIS ( -- x addr ) 12 bit USART1_CR3 ; \ USART1_CR3_OVRDIS, Overrun Disable
: USART1_CR3_ONEBIT ( -- x addr ) 11 bit USART1_CR3 ; \ USART1_CR3_ONEBIT, One sample bit method  enable
: USART1_CR3_CTSIE ( -- x addr ) 10 bit USART1_CR3 ; \ USART1_CR3_CTSIE, CTS interrupt enable
: USART1_CR3_CTSE ( -- x addr ) 9 bit USART1_CR3 ; \ USART1_CR3_CTSE, CTS enable
: USART1_CR3_RTSE ( -- x addr ) 8 bit USART1_CR3 ; \ USART1_CR3_RTSE, RTS enable
: USART1_CR3_DMAT ( -- x addr ) 7 bit USART1_CR3 ; \ USART1_CR3_DMAT, DMA enable transmitter
: USART1_CR3_DMAR ( -- x addr ) 6 bit USART1_CR3 ; \ USART1_CR3_DMAR, DMA enable receiver
: USART1_CR3_SCEN ( -- x addr ) 5 bit USART1_CR3 ; \ USART1_CR3_SCEN, Smartcard mode enable
: USART1_CR3_NACK ( -- x addr ) 4 bit USART1_CR3 ; \ USART1_CR3_NACK, Smartcard NACK enable
: USART1_CR3_HDSEL ( -- x addr ) 3 bit USART1_CR3 ; \ USART1_CR3_HDSEL, Half-duplex selection
: USART1_CR3_IRLP ( -- x addr ) 2 bit USART1_CR3 ; \ USART1_CR3_IRLP, Ir low-power
: USART1_CR3_IREN ( -- x addr ) 1 bit USART1_CR3 ; \ USART1_CR3_IREN, Ir mode enable
: USART1_CR3_EIE ( -- x addr ) 0 bit USART1_CR3 ; \ USART1_CR3_EIE, Error interrupt enable

\ USART1_BRR (read-write) Reset:0x0000
: USART1_BRR_DIV_Mantissa ( %bbbbbbbbbbb -- x addr ) 4 lshift USART1_BRR ; \ USART1_BRR_DIV_Mantissa, DIV_Mantissa
: USART1_BRR_DIV_Fraction ( %bbbb -- x addr ) USART1_BRR ; \ USART1_BRR_DIV_Fraction, DIV_Fraction

\ USART1_GTPR (read-write) Reset:0x0000
: USART1_GTPR_GT ( %bbbbbbbb -- x addr ) 8 lshift USART1_GTPR ; \ USART1_GTPR_GT, Guard time value
: USART1_GTPR_PSC ( %bbbbbbbb -- x addr ) USART1_GTPR ; \ USART1_GTPR_PSC, Prescaler value

\ USART1_RTOR (read-write) Reset:0x0000
: USART1_RTOR_BLEN ( %bbbbbbbb -- x addr ) 24 lshift USART1_RTOR ; \ USART1_RTOR_BLEN, Block Length
: USART1_RTOR_RTO ( %bbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) USART1_RTOR ; \ USART1_RTOR_RTO, Receiver timeout value

\ USART1_RQR (write-only) Reset:0x0000
: USART1_RQR_TXFRQ ( -- x addr ) 4 bit USART1_RQR ; \ USART1_RQR_TXFRQ, Transmit data flush  request
: USART1_RQR_RXFRQ ( -- x addr ) 3 bit USART1_RQR ; \ USART1_RQR_RXFRQ, Receive data flush request
: USART1_RQR_MMRQ ( -- x addr ) 2 bit USART1_RQR ; \ USART1_RQR_MMRQ, Mute mode request
: USART1_RQR_SBKRQ ( -- x addr ) 1 bit USART1_RQR ; \ USART1_RQR_SBKRQ, Send break request
: USART1_RQR_ABRRQ ( -- x addr ) 0 bit USART1_RQR ; \ USART1_RQR_ABRRQ, Auto baud rate request

\ USART1_ISR (read-only) Reset:0x00C0
: USART1_ISR_REACK? ( --  1|0 ) 22 bit USART1_ISR bit@ ; \ USART1_ISR_REACK, REACK
: USART1_ISR_TEACK? ( --  1|0 ) 21 bit USART1_ISR bit@ ; \ USART1_ISR_TEACK, TEACK
: USART1_ISR_WUF? ( --  1|0 ) 20 bit USART1_ISR bit@ ; \ USART1_ISR_WUF, WUF
: USART1_ISR_RWU? ( --  1|0 ) 19 bit USART1_ISR bit@ ; \ USART1_ISR_RWU, RWU
: USART1_ISR_SBKF? ( --  1|0 ) 18 bit USART1_ISR bit@ ; \ USART1_ISR_SBKF, SBKF
: USART1_ISR_CMF? ( --  1|0 ) 17 bit USART1_ISR bit@ ; \ USART1_ISR_CMF, CMF
: USART1_ISR_BUSY? ( --  1|0 ) 16 bit USART1_ISR bit@ ; \ USART1_ISR_BUSY, BUSY
: USART1_ISR_ABRF? ( --  1|0 ) 15 bit USART1_ISR bit@ ; \ USART1_ISR_ABRF, ABRF
: USART1_ISR_ABRE? ( --  1|0 ) 14 bit USART1_ISR bit@ ; \ USART1_ISR_ABRE, ABRE
: USART1_ISR_EOBF? ( --  1|0 ) 12 bit USART1_ISR bit@ ; \ USART1_ISR_EOBF, EOBF
: USART1_ISR_RTOF? ( --  1|0 ) 11 bit USART1_ISR bit@ ; \ USART1_ISR_RTOF, RTOF
: USART1_ISR_CTS? ( --  1|0 ) 10 bit USART1_ISR bit@ ; \ USART1_ISR_CTS, CTS
: USART1_ISR_CTSIF? ( --  1|0 ) 9 bit USART1_ISR bit@ ; \ USART1_ISR_CTSIF, CTSIF
: USART1_ISR_LBDF? ( --  1|0 ) 8 bit USART1_ISR bit@ ; \ USART1_ISR_LBDF, LBDF
: USART1_ISR_TXE? ( --  1|0 ) 7 bit USART1_ISR bit@ ; \ USART1_ISR_TXE, TXE
: USART1_ISR_TC? ( --  1|0 ) 6 bit USART1_ISR bit@ ; \ USART1_ISR_TC, TC
: USART1_ISR_RXNE? ( --  1|0 ) 5 bit USART1_ISR bit@ ; \ USART1_ISR_RXNE, RXNE
: USART1_ISR_IDLE? ( --  1|0 ) 4 bit USART1_ISR bit@ ; \ USART1_ISR_IDLE, IDLE
: USART1_ISR_ORE? ( --  1|0 ) 3 bit USART1_ISR bit@ ; \ USART1_ISR_ORE, ORE
: USART1_ISR_NF? ( --  1|0 ) 2 bit USART1_ISR bit@ ; \ USART1_ISR_NF, NF
: USART1_ISR_FE? ( --  1|0 ) 1 bit USART1_ISR bit@ ; \ USART1_ISR_FE, FE
: USART1_ISR_PE? ( --  1|0 ) 0 bit USART1_ISR bit@ ; \ USART1_ISR_PE, PE

\ USART1_ICR (write-only) Reset:0x0000
: USART1_ICR_WUCF ( -- x addr ) 20 bit USART1_ICR ; \ USART1_ICR_WUCF, Wakeup from Stop mode clear  flag
: USART1_ICR_CMCF ( -- x addr ) 17 bit USART1_ICR ; \ USART1_ICR_CMCF, Character match clear flag
: USART1_ICR_EOBCF ( -- x addr ) 12 bit USART1_ICR ; \ USART1_ICR_EOBCF, End of block clear flag
: USART1_ICR_RTOCF ( -- x addr ) 11 bit USART1_ICR ; \ USART1_ICR_RTOCF, Receiver timeout clear  flag
: USART1_ICR_CTSCF ( -- x addr ) 9 bit USART1_ICR ; \ USART1_ICR_CTSCF, CTS clear flag
: USART1_ICR_LBDCF ( -- x addr ) 8 bit USART1_ICR ; \ USART1_ICR_LBDCF, LIN break detection clear  flag
: USART1_ICR_TCCF ( -- x addr ) 6 bit USART1_ICR ; \ USART1_ICR_TCCF, Transmission complete clear  flag
: USART1_ICR_IDLECF ( -- x addr ) 4 bit USART1_ICR ; \ USART1_ICR_IDLECF, Idle line detected clear  flag
: USART1_ICR_ORECF ( -- x addr ) 3 bit USART1_ICR ; \ USART1_ICR_ORECF, Overrun error clear flag
: USART1_ICR_NCF ( -- x addr ) 2 bit USART1_ICR ; \ USART1_ICR_NCF, Noise detected clear flag
: USART1_ICR_FECF ( -- x addr ) 1 bit USART1_ICR ; \ USART1_ICR_FECF, Framing error clear flag
: USART1_ICR_PECF ( -- x addr ) 0 bit USART1_ICR ; \ USART1_ICR_PECF, Parity error clear flag

\ USART1_RDR (read-only) Reset:0x0000
: USART1_RDR_RDR? ( --  x ) USART1_RDR @ ; \ USART1_RDR_RDR, Receive data value

\ USART1_TDR (read-write) Reset:0x0000
: USART1_TDR_TDR ( %bbbbbbbbb -- x addr ) USART1_TDR ; \ USART1_TDR_TDR, Transmit data value

\ USART2_CR1 (read-write) Reset:0x0000
: USART2_CR1_M1 ( -- x addr ) 28 bit USART2_CR1 ; \ USART2_CR1_M1, Word length
: USART2_CR1_EOBIE ( -- x addr ) 27 bit USART2_CR1 ; \ USART2_CR1_EOBIE, End of Block interrupt  enable
: USART2_CR1_RTOIE ( -- x addr ) 26 bit USART2_CR1 ; \ USART2_CR1_RTOIE, Receiver timeout interrupt  enable
: USART2_CR1_DEAT4 ( -- x addr ) 25 bit USART2_CR1 ; \ USART2_CR1_DEAT4, Driver Enable assertion  time
: USART2_CR1_DEAT3 ( -- x addr ) 24 bit USART2_CR1 ; \ USART2_CR1_DEAT3, DEAT3
: USART2_CR1_DEAT2 ( -- x addr ) 23 bit USART2_CR1 ; \ USART2_CR1_DEAT2, DEAT2
: USART2_CR1_DEAT1 ( -- x addr ) 22 bit USART2_CR1 ; \ USART2_CR1_DEAT1, DEAT1
: USART2_CR1_DEAT0 ( -- x addr ) 21 bit USART2_CR1 ; \ USART2_CR1_DEAT0, DEAT0
: USART2_CR1_DEDT4 ( -- x addr ) 20 bit USART2_CR1 ; \ USART2_CR1_DEDT4, Driver Enable de-assertion  time
: USART2_CR1_DEDT3 ( -- x addr ) 19 bit USART2_CR1 ; \ USART2_CR1_DEDT3, DEDT3
: USART2_CR1_DEDT2 ( -- x addr ) 18 bit USART2_CR1 ; \ USART2_CR1_DEDT2, DEDT2
: USART2_CR1_DEDT1 ( -- x addr ) 17 bit USART2_CR1 ; \ USART2_CR1_DEDT1, DEDT1
: USART2_CR1_DEDT0 ( -- x addr ) 16 bit USART2_CR1 ; \ USART2_CR1_DEDT0, DEDT0
: USART2_CR1_OVER8 ( -- x addr ) 15 bit USART2_CR1 ; \ USART2_CR1_OVER8, Oversampling mode
: USART2_CR1_CMIE ( -- x addr ) 14 bit USART2_CR1 ; \ USART2_CR1_CMIE, Character match interrupt  enable
: USART2_CR1_MME ( -- x addr ) 13 bit USART2_CR1 ; \ USART2_CR1_MME, Mute mode enable
: USART2_CR1_M0 ( -- x addr ) 12 bit USART2_CR1 ; \ USART2_CR1_M0, Word length
: USART2_CR1_WAKE ( -- x addr ) 11 bit USART2_CR1 ; \ USART2_CR1_WAKE, Receiver wakeup method
: USART2_CR1_PCE ( -- x addr ) 10 bit USART2_CR1 ; \ USART2_CR1_PCE, Parity control enable
: USART2_CR1_PS ( -- x addr ) 9 bit USART2_CR1 ; \ USART2_CR1_PS, Parity selection
: USART2_CR1_PEIE ( -- x addr ) 8 bit USART2_CR1 ; \ USART2_CR1_PEIE, PE interrupt enable
: USART2_CR1_TXEIE ( -- x addr ) 7 bit USART2_CR1 ; \ USART2_CR1_TXEIE, interrupt enable
: USART2_CR1_TCIE ( -- x addr ) 6 bit USART2_CR1 ; \ USART2_CR1_TCIE, Transmission complete interrupt  enable
: USART2_CR1_RXNEIE ( -- x addr ) 5 bit USART2_CR1 ; \ USART2_CR1_RXNEIE, RXNE interrupt enable
: USART2_CR1_IDLEIE ( -- x addr ) 4 bit USART2_CR1 ; \ USART2_CR1_IDLEIE, IDLE interrupt enable
: USART2_CR1_TE ( -- x addr ) 3 bit USART2_CR1 ; \ USART2_CR1_TE, Transmitter enable
: USART2_CR1_RE ( -- x addr ) 2 bit USART2_CR1 ; \ USART2_CR1_RE, Receiver enable
: USART2_CR1_UESM ( -- x addr ) 1 bit USART2_CR1 ; \ USART2_CR1_UESM, USART enable in Stop mode
: USART2_CR1_UE ( -- x addr ) 0 bit USART2_CR1 ; \ USART2_CR1_UE, USART enable

\ USART2_CR2 (read-write) Reset:0x0000
: USART2_CR2_ADD4_7 ( %bbbb -- x addr ) 28 lshift USART2_CR2 ; \ USART2_CR2_ADD4_7, Address of the USART node
: USART2_CR2_ADD0_3 ( %bbbb -- x addr ) 24 lshift USART2_CR2 ; \ USART2_CR2_ADD0_3, Address of the USART node
: USART2_CR2_RTOEN ( -- x addr ) 23 bit USART2_CR2 ; \ USART2_CR2_RTOEN, Receiver timeout enable
: USART2_CR2_ABRMOD1 ( -- x addr ) 22 bit USART2_CR2 ; \ USART2_CR2_ABRMOD1, Auto baud rate mode
: USART2_CR2_ABRMOD0 ( -- x addr ) 21 bit USART2_CR2 ; \ USART2_CR2_ABRMOD0, ABRMOD0
: USART2_CR2_ABREN ( -- x addr ) 20 bit USART2_CR2 ; \ USART2_CR2_ABREN, Auto baud rate enable
: USART2_CR2_MSBFIRST ( -- x addr ) 19 bit USART2_CR2 ; \ USART2_CR2_MSBFIRST, Most significant bit first
: USART2_CR2_TAINV ( -- x addr ) 18 bit USART2_CR2 ; \ USART2_CR2_TAINV, Binary data inversion
: USART2_CR2_TXINV ( -- x addr ) 17 bit USART2_CR2 ; \ USART2_CR2_TXINV, TX pin active level  inversion
: USART2_CR2_RXINV ( -- x addr ) 16 bit USART2_CR2 ; \ USART2_CR2_RXINV, RX pin active level  inversion
: USART2_CR2_SWAP ( -- x addr ) 15 bit USART2_CR2 ; \ USART2_CR2_SWAP, Swap TX/RX pins
: USART2_CR2_LINEN ( -- x addr ) 14 bit USART2_CR2 ; \ USART2_CR2_LINEN, LIN mode enable
: USART2_CR2_STOP ( %bb -- x addr ) 12 lshift USART2_CR2 ; \ USART2_CR2_STOP, STOP bits
: USART2_CR2_CLKEN ( -- x addr ) 11 bit USART2_CR2 ; \ USART2_CR2_CLKEN, Clock enable
: USART2_CR2_CPOL ( -- x addr ) 10 bit USART2_CR2 ; \ USART2_CR2_CPOL, Clock polarity
: USART2_CR2_CPHA ( -- x addr ) 9 bit USART2_CR2 ; \ USART2_CR2_CPHA, Clock phase
: USART2_CR2_LBCL ( -- x addr ) 8 bit USART2_CR2 ; \ USART2_CR2_LBCL, Last bit clock pulse
: USART2_CR2_LBDIE ( -- x addr ) 6 bit USART2_CR2 ; \ USART2_CR2_LBDIE, LIN break detection interrupt  enable
: USART2_CR2_LBDL ( -- x addr ) 5 bit USART2_CR2 ; \ USART2_CR2_LBDL, LIN break detection length
: USART2_CR2_ADDM7 ( -- x addr ) 4 bit USART2_CR2 ; \ USART2_CR2_ADDM7, 7-bit Address Detection/4-bit Address  Detection

\ USART2_CR3 (read-write) Reset:0x0000
: USART2_CR3_WUFIE ( -- x addr ) 22 bit USART2_CR3 ; \ USART2_CR3_WUFIE, Wakeup from Stop mode interrupt  enable
: USART2_CR3_WUS ( %bb -- x addr ) 20 lshift USART2_CR3 ; \ USART2_CR3_WUS, Wakeup from Stop mode interrupt flag  selection
: USART2_CR3_SCARCNT ( %bbb -- x addr ) 17 lshift USART2_CR3 ; \ USART2_CR3_SCARCNT, Smartcard auto-retry count
: USART2_CR3_DEP ( -- x addr ) 15 bit USART2_CR3 ; \ USART2_CR3_DEP, Driver enable polarity  selection
: USART2_CR3_DEM ( -- x addr ) 14 bit USART2_CR3 ; \ USART2_CR3_DEM, Driver enable mode
: USART2_CR3_DDRE ( -- x addr ) 13 bit USART2_CR3 ; \ USART2_CR3_DDRE, DMA Disable on Reception  Error
: USART2_CR3_OVRDIS ( -- x addr ) 12 bit USART2_CR3 ; \ USART2_CR3_OVRDIS, Overrun Disable
: USART2_CR3_ONEBIT ( -- x addr ) 11 bit USART2_CR3 ; \ USART2_CR3_ONEBIT, One sample bit method  enable
: USART2_CR3_CTSIE ( -- x addr ) 10 bit USART2_CR3 ; \ USART2_CR3_CTSIE, CTS interrupt enable
: USART2_CR3_CTSE ( -- x addr ) 9 bit USART2_CR3 ; \ USART2_CR3_CTSE, CTS enable
: USART2_CR3_RTSE ( -- x addr ) 8 bit USART2_CR3 ; \ USART2_CR3_RTSE, RTS enable
: USART2_CR3_DMAT ( -- x addr ) 7 bit USART2_CR3 ; \ USART2_CR3_DMAT, DMA enable transmitter
: USART2_CR3_DMAR ( -- x addr ) 6 bit USART2_CR3 ; \ USART2_CR3_DMAR, DMA enable receiver
: USART2_CR3_SCEN ( -- x addr ) 5 bit USART2_CR3 ; \ USART2_CR3_SCEN, Smartcard mode enable
: USART2_CR3_NACK ( -- x addr ) 4 bit USART2_CR3 ; \ USART2_CR3_NACK, Smartcard NACK enable
: USART2_CR3_HDSEL ( -- x addr ) 3 bit USART2_CR3 ; \ USART2_CR3_HDSEL, Half-duplex selection
: USART2_CR3_IRLP ( -- x addr ) 2 bit USART2_CR3 ; \ USART2_CR3_IRLP, Ir low-power
: USART2_CR3_IREN ( -- x addr ) 1 bit USART2_CR3 ; \ USART2_CR3_IREN, Ir mode enable
: USART2_CR3_EIE ( -- x addr ) 0 bit USART2_CR3 ; \ USART2_CR3_EIE, Error interrupt enable

\ USART2_BRR (read-write) Reset:0x0000
: USART2_BRR_DIV_Mantissa ( %bbbbbbbbbbb -- x addr ) 4 lshift USART2_BRR ; \ USART2_BRR_DIV_Mantissa, DIV_Mantissa
: USART2_BRR_DIV_Fraction ( %bbbb -- x addr ) USART2_BRR ; \ USART2_BRR_DIV_Fraction, DIV_Fraction

\ USART2_GTPR (read-write) Reset:0x0000
: USART2_GTPR_GT ( %bbbbbbbb -- x addr ) 8 lshift USART2_GTPR ; \ USART2_GTPR_GT, Guard time value
: USART2_GTPR_PSC ( %bbbbbbbb -- x addr ) USART2_GTPR ; \ USART2_GTPR_PSC, Prescaler value

\ USART2_RTOR (read-write) Reset:0x0000
: USART2_RTOR_BLEN ( %bbbbbbbb -- x addr ) 24 lshift USART2_RTOR ; \ USART2_RTOR_BLEN, Block Length
: USART2_RTOR_RTO ( %bbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) USART2_RTOR ; \ USART2_RTOR_RTO, Receiver timeout value

\ USART2_RQR (write-only) Reset:0x0000
: USART2_RQR_TXFRQ ( -- x addr ) 4 bit USART2_RQR ; \ USART2_RQR_TXFRQ, Transmit data flush  request
: USART2_RQR_RXFRQ ( -- x addr ) 3 bit USART2_RQR ; \ USART2_RQR_RXFRQ, Receive data flush request
: USART2_RQR_MMRQ ( -- x addr ) 2 bit USART2_RQR ; \ USART2_RQR_MMRQ, Mute mode request
: USART2_RQR_SBKRQ ( -- x addr ) 1 bit USART2_RQR ; \ USART2_RQR_SBKRQ, Send break request
: USART2_RQR_ABRRQ ( -- x addr ) 0 bit USART2_RQR ; \ USART2_RQR_ABRRQ, Auto baud rate request

\ USART2_ISR (read-only) Reset:0x00C0
: USART2_ISR_REACK? ( --  1|0 ) 22 bit USART2_ISR bit@ ; \ USART2_ISR_REACK, REACK
: USART2_ISR_TEACK? ( --  1|0 ) 21 bit USART2_ISR bit@ ; \ USART2_ISR_TEACK, TEACK
: USART2_ISR_WUF? ( --  1|0 ) 20 bit USART2_ISR bit@ ; \ USART2_ISR_WUF, WUF
: USART2_ISR_RWU? ( --  1|0 ) 19 bit USART2_ISR bit@ ; \ USART2_ISR_RWU, RWU
: USART2_ISR_SBKF? ( --  1|0 ) 18 bit USART2_ISR bit@ ; \ USART2_ISR_SBKF, SBKF
: USART2_ISR_CMF? ( --  1|0 ) 17 bit USART2_ISR bit@ ; \ USART2_ISR_CMF, CMF
: USART2_ISR_BUSY? ( --  1|0 ) 16 bit USART2_ISR bit@ ; \ USART2_ISR_BUSY, BUSY
: USART2_ISR_ABRF? ( --  1|0 ) 15 bit USART2_ISR bit@ ; \ USART2_ISR_ABRF, ABRF
: USART2_ISR_ABRE? ( --  1|0 ) 14 bit USART2_ISR bit@ ; \ USART2_ISR_ABRE, ABRE
: USART2_ISR_EOBF? ( --  1|0 ) 12 bit USART2_ISR bit@ ; \ USART2_ISR_EOBF, EOBF
: USART2_ISR_RTOF? ( --  1|0 ) 11 bit USART2_ISR bit@ ; \ USART2_ISR_RTOF, RTOF
: USART2_ISR_CTS? ( --  1|0 ) 10 bit USART2_ISR bit@ ; \ USART2_ISR_CTS, CTS
: USART2_ISR_CTSIF? ( --  1|0 ) 9 bit USART2_ISR bit@ ; \ USART2_ISR_CTSIF, CTSIF
: USART2_ISR_LBDF? ( --  1|0 ) 8 bit USART2_ISR bit@ ; \ USART2_ISR_LBDF, LBDF
: USART2_ISR_TXE? ( --  1|0 ) 7 bit USART2_ISR bit@ ; \ USART2_ISR_TXE, TXE
: USART2_ISR_TC? ( --  1|0 ) 6 bit USART2_ISR bit@ ; \ USART2_ISR_TC, TC
: USART2_ISR_RXNE? ( --  1|0 ) 5 bit USART2_ISR bit@ ; \ USART2_ISR_RXNE, RXNE
: USART2_ISR_IDLE? ( --  1|0 ) 4 bit USART2_ISR bit@ ; \ USART2_ISR_IDLE, IDLE
: USART2_ISR_ORE? ( --  1|0 ) 3 bit USART2_ISR bit@ ; \ USART2_ISR_ORE, ORE
: USART2_ISR_NF? ( --  1|0 ) 2 bit USART2_ISR bit@ ; \ USART2_ISR_NF, NF
: USART2_ISR_FE? ( --  1|0 ) 1 bit USART2_ISR bit@ ; \ USART2_ISR_FE, FE
: USART2_ISR_PE? ( --  1|0 ) 0 bit USART2_ISR bit@ ; \ USART2_ISR_PE, PE

\ USART2_ICR (write-only) Reset:0x0000
: USART2_ICR_WUCF ( -- x addr ) 20 bit USART2_ICR ; \ USART2_ICR_WUCF, Wakeup from Stop mode clear  flag
: USART2_ICR_CMCF ( -- x addr ) 17 bit USART2_ICR ; \ USART2_ICR_CMCF, Character match clear flag
: USART2_ICR_EOBCF ( -- x addr ) 12 bit USART2_ICR ; \ USART2_ICR_EOBCF, End of block clear flag
: USART2_ICR_RTOCF ( -- x addr ) 11 bit USART2_ICR ; \ USART2_ICR_RTOCF, Receiver timeout clear  flag
: USART2_ICR_CTSCF ( -- x addr ) 9 bit USART2_ICR ; \ USART2_ICR_CTSCF, CTS clear flag
: USART2_ICR_LBDCF ( -- x addr ) 8 bit USART2_ICR ; \ USART2_ICR_LBDCF, LIN break detection clear  flag
: USART2_ICR_TCCF ( -- x addr ) 6 bit USART2_ICR ; \ USART2_ICR_TCCF, Transmission complete clear  flag
: USART2_ICR_IDLECF ( -- x addr ) 4 bit USART2_ICR ; \ USART2_ICR_IDLECF, Idle line detected clear  flag
: USART2_ICR_ORECF ( -- x addr ) 3 bit USART2_ICR ; \ USART2_ICR_ORECF, Overrun error clear flag
: USART2_ICR_NCF ( -- x addr ) 2 bit USART2_ICR ; \ USART2_ICR_NCF, Noise detected clear flag
: USART2_ICR_FECF ( -- x addr ) 1 bit USART2_ICR ; \ USART2_ICR_FECF, Framing error clear flag
: USART2_ICR_PECF ( -- x addr ) 0 bit USART2_ICR ; \ USART2_ICR_PECF, Parity error clear flag

\ USART2_RDR (read-only) Reset:0x0000
: USART2_RDR_RDR? ( --  x ) USART2_RDR @ ; \ USART2_RDR_RDR, Receive data value

\ USART2_TDR (read-write) Reset:0x0000
: USART2_TDR_TDR ( %bbbbbbbbb -- x addr ) USART2_TDR ; \ USART2_TDR_TDR, Transmit data value

\ TSC_CR (read-write) Reset:0x00000000
: TSC_CR_CTPH ( %bbbb -- x addr ) 28 lshift TSC_CR ; \ TSC_CR_CTPH, Charge transfer pulse high
: TSC_CR_CTPL ( %bbbb -- x addr ) 24 lshift TSC_CR ; \ TSC_CR_CTPL, Charge transfer pulse low
: TSC_CR_SSD ( %bbbbbbb -- x addr ) 17 lshift TSC_CR ; \ TSC_CR_SSD, Spread spectrum deviation
: TSC_CR_SSE ( -- x addr ) 16 bit TSC_CR ; \ TSC_CR_SSE, Spread spectrum enable
: TSC_CR_SSPSC ( -- x addr ) 15 bit TSC_CR ; \ TSC_CR_SSPSC, Spread spectrum prescaler
: TSC_CR_PGPSC ( %bbb -- x addr ) 12 lshift TSC_CR ; \ TSC_CR_PGPSC, pulse generator prescaler
: TSC_CR_MCV ( %bbb -- x addr ) 5 lshift TSC_CR ; \ TSC_CR_MCV, Max count value
: TSC_CR_IODEF ( -- x addr ) 4 bit TSC_CR ; \ TSC_CR_IODEF, I/O Default mode
: TSC_CR_SYNCPOL ( -- x addr ) 3 bit TSC_CR ; \ TSC_CR_SYNCPOL, Synchronization pin  polarity
: TSC_CR_AM ( -- x addr ) 2 bit TSC_CR ; \ TSC_CR_AM, Acquisition mode
: TSC_CR_START ( -- x addr ) 1 bit TSC_CR ; \ TSC_CR_START, Start a new acquisition
: TSC_CR_TSCE ( -- x addr ) 0 bit TSC_CR ; \ TSC_CR_TSCE, Touch sensing controller  enable

\ TSC_IER (read-write) Reset:0x00000000
: TSC_IER_MCEIE ( -- x addr ) 1 bit TSC_IER ; \ TSC_IER_MCEIE, Max count error interrupt  enable
: TSC_IER_EOAIE ( -- x addr ) 0 bit TSC_IER ; \ TSC_IER_EOAIE, End of acquisition interrupt  enable

\ TSC_ICR (read-write) Reset:0x00000000
: TSC_ICR_MCEIC ( -- x addr ) 1 bit TSC_ICR ; \ TSC_ICR_MCEIC, Max count error interrupt  clear
: TSC_ICR_EOAIC ( -- x addr ) 0 bit TSC_ICR ; \ TSC_ICR_EOAIC, End of acquisition interrupt  clear

\ TSC_ISR (read-write) Reset:0x00000000
: TSC_ISR_MCEF ( -- x addr ) 1 bit TSC_ISR ; \ TSC_ISR_MCEF, Max count error flag
: TSC_ISR_EOAF ( -- x addr ) 0 bit TSC_ISR ; \ TSC_ISR_EOAF, End of acquisition flag

\ TSC_IOHCR (read-write) Reset:0xFFFFFFFF
: TSC_IOHCR_G8_IO4 ( -- x addr ) 31 bit TSC_IOHCR ; \ TSC_IOHCR_G8_IO4, G8_IO4
: TSC_IOHCR_G8_IO3 ( -- x addr ) 30 bit TSC_IOHCR ; \ TSC_IOHCR_G8_IO3, G8_IO3
: TSC_IOHCR_G8_IO2 ( -- x addr ) 29 bit TSC_IOHCR ; \ TSC_IOHCR_G8_IO2, G8_IO2
: TSC_IOHCR_G8_IO1 ( -- x addr ) 28 bit TSC_IOHCR ; \ TSC_IOHCR_G8_IO1, G8_IO1
: TSC_IOHCR_G7_IO4 ( -- x addr ) 27 bit TSC_IOHCR ; \ TSC_IOHCR_G7_IO4, G7_IO4
: TSC_IOHCR_G7_IO3 ( -- x addr ) 26 bit TSC_IOHCR ; \ TSC_IOHCR_G7_IO3, G7_IO3
: TSC_IOHCR_G7_IO2 ( -- x addr ) 25 bit TSC_IOHCR ; \ TSC_IOHCR_G7_IO2, G7_IO2
: TSC_IOHCR_G7_IO1 ( -- x addr ) 24 bit TSC_IOHCR ; \ TSC_IOHCR_G7_IO1, G7_IO1
: TSC_IOHCR_G6_IO4 ( -- x addr ) 23 bit TSC_IOHCR ; \ TSC_IOHCR_G6_IO4, G6_IO4
: TSC_IOHCR_G6_IO3 ( -- x addr ) 22 bit TSC_IOHCR ; \ TSC_IOHCR_G6_IO3, G6_IO3
: TSC_IOHCR_G6_IO2 ( -- x addr ) 21 bit TSC_IOHCR ; \ TSC_IOHCR_G6_IO2, G6_IO2
: TSC_IOHCR_G6_IO1 ( -- x addr ) 20 bit TSC_IOHCR ; \ TSC_IOHCR_G6_IO1, G6_IO1
: TSC_IOHCR_G5_IO4 ( -- x addr ) 19 bit TSC_IOHCR ; \ TSC_IOHCR_G5_IO4, G5_IO4
: TSC_IOHCR_G5_IO3 ( -- x addr ) 18 bit TSC_IOHCR ; \ TSC_IOHCR_G5_IO3, G5_IO3
: TSC_IOHCR_G5_IO2 ( -- x addr ) 17 bit TSC_IOHCR ; \ TSC_IOHCR_G5_IO2, G5_IO2
: TSC_IOHCR_G5_IO1 ( -- x addr ) 16 bit TSC_IOHCR ; \ TSC_IOHCR_G5_IO1, G5_IO1
: TSC_IOHCR_G4_IO4 ( -- x addr ) 15 bit TSC_IOHCR ; \ TSC_IOHCR_G4_IO4, G4_IO4
: TSC_IOHCR_G4_IO3 ( -- x addr ) 14 bit TSC_IOHCR ; \ TSC_IOHCR_G4_IO3, G4_IO3
: TSC_IOHCR_G4_IO2 ( -- x addr ) 13 bit TSC_IOHCR ; \ TSC_IOHCR_G4_IO2, G4_IO2
: TSC_IOHCR_G4_IO1 ( -- x addr ) 12 bit TSC_IOHCR ; \ TSC_IOHCR_G4_IO1, G4_IO1
: TSC_IOHCR_G3_IO4 ( -- x addr ) 11 bit TSC_IOHCR ; \ TSC_IOHCR_G3_IO4, G3_IO4
: TSC_IOHCR_G3_IO3 ( -- x addr ) 10 bit TSC_IOHCR ; \ TSC_IOHCR_G3_IO3, G3_IO3
: TSC_IOHCR_G3_IO2 ( -- x addr ) 9 bit TSC_IOHCR ; \ TSC_IOHCR_G3_IO2, G3_IO2
: TSC_IOHCR_G3_IO1 ( -- x addr ) 8 bit TSC_IOHCR ; \ TSC_IOHCR_G3_IO1, G3_IO1
: TSC_IOHCR_G2_IO4 ( -- x addr ) 7 bit TSC_IOHCR ; \ TSC_IOHCR_G2_IO4, G2_IO4
: TSC_IOHCR_G2_IO3 ( -- x addr ) 6 bit TSC_IOHCR ; \ TSC_IOHCR_G2_IO3, G2_IO3
: TSC_IOHCR_G2_IO2 ( -- x addr ) 5 bit TSC_IOHCR ; \ TSC_IOHCR_G2_IO2, G2_IO2
: TSC_IOHCR_G2_IO1 ( -- x addr ) 4 bit TSC_IOHCR ; \ TSC_IOHCR_G2_IO1, G2_IO1
: TSC_IOHCR_G1_IO4 ( -- x addr ) 3 bit TSC_IOHCR ; \ TSC_IOHCR_G1_IO4, G1_IO4
: TSC_IOHCR_G1_IO3 ( -- x addr ) 2 bit TSC_IOHCR ; \ TSC_IOHCR_G1_IO3, G1_IO3
: TSC_IOHCR_G1_IO2 ( -- x addr ) 1 bit TSC_IOHCR ; \ TSC_IOHCR_G1_IO2, G1_IO2
: TSC_IOHCR_G1_IO1 ( -- x addr ) 0 bit TSC_IOHCR ; \ TSC_IOHCR_G1_IO1, G1_IO1

\ TSC_IOASCR (read-write) Reset:0x00000000
: TSC_IOASCR_G8_IO4 ( -- x addr ) 31 bit TSC_IOASCR ; \ TSC_IOASCR_G8_IO4, G8_IO4
: TSC_IOASCR_G8_IO3 ( -- x addr ) 30 bit TSC_IOASCR ; \ TSC_IOASCR_G8_IO3, G8_IO3
: TSC_IOASCR_G8_IO2 ( -- x addr ) 29 bit TSC_IOASCR ; \ TSC_IOASCR_G8_IO2, G8_IO2
: TSC_IOASCR_G8_IO1 ( -- x addr ) 28 bit TSC_IOASCR ; \ TSC_IOASCR_G8_IO1, G8_IO1
: TSC_IOASCR_G7_IO4 ( -- x addr ) 27 bit TSC_IOASCR ; \ TSC_IOASCR_G7_IO4, G7_IO4
: TSC_IOASCR_G7_IO3 ( -- x addr ) 26 bit TSC_IOASCR ; \ TSC_IOASCR_G7_IO3, G7_IO3
: TSC_IOASCR_G7_IO2 ( -- x addr ) 25 bit TSC_IOASCR ; \ TSC_IOASCR_G7_IO2, G7_IO2
: TSC_IOASCR_G7_IO1 ( -- x addr ) 24 bit TSC_IOASCR ; \ TSC_IOASCR_G7_IO1, G7_IO1
: TSC_IOASCR_G6_IO4 ( -- x addr ) 23 bit TSC_IOASCR ; \ TSC_IOASCR_G6_IO4, G6_IO4
: TSC_IOASCR_G6_IO3 ( -- x addr ) 22 bit TSC_IOASCR ; \ TSC_IOASCR_G6_IO3, G6_IO3
: TSC_IOASCR_G6_IO2 ( -- x addr ) 21 bit TSC_IOASCR ; \ TSC_IOASCR_G6_IO2, G6_IO2
: TSC_IOASCR_G6_IO1 ( -- x addr ) 20 bit TSC_IOASCR ; \ TSC_IOASCR_G6_IO1, G6_IO1
: TSC_IOASCR_G5_IO4 ( -- x addr ) 19 bit TSC_IOASCR ; \ TSC_IOASCR_G5_IO4, G5_IO4
: TSC_IOASCR_G5_IO3 ( -- x addr ) 18 bit TSC_IOASCR ; \ TSC_IOASCR_G5_IO3, G5_IO3
: TSC_IOASCR_G5_IO2 ( -- x addr ) 17 bit TSC_IOASCR ; \ TSC_IOASCR_G5_IO2, G5_IO2
: TSC_IOASCR_G5_IO1 ( -- x addr ) 16 bit TSC_IOASCR ; \ TSC_IOASCR_G5_IO1, G5_IO1
: TSC_IOASCR_G4_IO4 ( -- x addr ) 15 bit TSC_IOASCR ; \ TSC_IOASCR_G4_IO4, G4_IO4
: TSC_IOASCR_G4_IO3 ( -- x addr ) 14 bit TSC_IOASCR ; \ TSC_IOASCR_G4_IO3, G4_IO3
: TSC_IOASCR_G4_IO2 ( -- x addr ) 13 bit TSC_IOASCR ; \ TSC_IOASCR_G4_IO2, G4_IO2
: TSC_IOASCR_G4_IO1 ( -- x addr ) 12 bit TSC_IOASCR ; \ TSC_IOASCR_G4_IO1, G4_IO1
: TSC_IOASCR_G3_IO4 ( -- x addr ) 11 bit TSC_IOASCR ; \ TSC_IOASCR_G3_IO4, G3_IO4
: TSC_IOASCR_G3_IO3 ( -- x addr ) 10 bit TSC_IOASCR ; \ TSC_IOASCR_G3_IO3, G3_IO3
: TSC_IOASCR_G3_IO2 ( -- x addr ) 9 bit TSC_IOASCR ; \ TSC_IOASCR_G3_IO2, G3_IO2
: TSC_IOASCR_G3_IO1 ( -- x addr ) 8 bit TSC_IOASCR ; \ TSC_IOASCR_G3_IO1, G3_IO1
: TSC_IOASCR_G2_IO4 ( -- x addr ) 7 bit TSC_IOASCR ; \ TSC_IOASCR_G2_IO4, G2_IO4
: TSC_IOASCR_G2_IO3 ( -- x addr ) 6 bit TSC_IOASCR ; \ TSC_IOASCR_G2_IO3, G2_IO3
: TSC_IOASCR_G2_IO2 ( -- x addr ) 5 bit TSC_IOASCR ; \ TSC_IOASCR_G2_IO2, G2_IO2
: TSC_IOASCR_G2_IO1 ( -- x addr ) 4 bit TSC_IOASCR ; \ TSC_IOASCR_G2_IO1, G2_IO1
: TSC_IOASCR_G1_IO4 ( -- x addr ) 3 bit TSC_IOASCR ; \ TSC_IOASCR_G1_IO4, G1_IO4
: TSC_IOASCR_G1_IO3 ( -- x addr ) 2 bit TSC_IOASCR ; \ TSC_IOASCR_G1_IO3, G1_IO3
: TSC_IOASCR_G1_IO2 ( -- x addr ) 1 bit TSC_IOASCR ; \ TSC_IOASCR_G1_IO2, G1_IO2
: TSC_IOASCR_G1_IO1 ( -- x addr ) 0 bit TSC_IOASCR ; \ TSC_IOASCR_G1_IO1, G1_IO1

\ TSC_IOSCR (read-write) Reset:0x00000000
: TSC_IOSCR_G8_IO4 ( -- x addr ) 31 bit TSC_IOSCR ; \ TSC_IOSCR_G8_IO4, G8_IO4
: TSC_IOSCR_G8_IO3 ( -- x addr ) 30 bit TSC_IOSCR ; \ TSC_IOSCR_G8_IO3, G8_IO3
: TSC_IOSCR_G8_IO2 ( -- x addr ) 29 bit TSC_IOSCR ; \ TSC_IOSCR_G8_IO2, G8_IO2
: TSC_IOSCR_G8_IO1 ( -- x addr ) 28 bit TSC_IOSCR ; \ TSC_IOSCR_G8_IO1, G8_IO1
: TSC_IOSCR_G7_IO4 ( -- x addr ) 27 bit TSC_IOSCR ; \ TSC_IOSCR_G7_IO4, G7_IO4
: TSC_IOSCR_G7_IO3 ( -- x addr ) 26 bit TSC_IOSCR ; \ TSC_IOSCR_G7_IO3, G7_IO3
: TSC_IOSCR_G7_IO2 ( -- x addr ) 25 bit TSC_IOSCR ; \ TSC_IOSCR_G7_IO2, G7_IO2
: TSC_IOSCR_G7_IO1 ( -- x addr ) 24 bit TSC_IOSCR ; \ TSC_IOSCR_G7_IO1, G7_IO1
: TSC_IOSCR_G6_IO4 ( -- x addr ) 23 bit TSC_IOSCR ; \ TSC_IOSCR_G6_IO4, G6_IO4
: TSC_IOSCR_G6_IO3 ( -- x addr ) 22 bit TSC_IOSCR ; \ TSC_IOSCR_G6_IO3, G6_IO3
: TSC_IOSCR_G6_IO2 ( -- x addr ) 21 bit TSC_IOSCR ; \ TSC_IOSCR_G6_IO2, G6_IO2
: TSC_IOSCR_G6_IO1 ( -- x addr ) 20 bit TSC_IOSCR ; \ TSC_IOSCR_G6_IO1, G6_IO1
: TSC_IOSCR_G5_IO4 ( -- x addr ) 19 bit TSC_IOSCR ; \ TSC_IOSCR_G5_IO4, G5_IO4
: TSC_IOSCR_G5_IO3 ( -- x addr ) 18 bit TSC_IOSCR ; \ TSC_IOSCR_G5_IO3, G5_IO3
: TSC_IOSCR_G5_IO2 ( -- x addr ) 17 bit TSC_IOSCR ; \ TSC_IOSCR_G5_IO2, G5_IO2
: TSC_IOSCR_G5_IO1 ( -- x addr ) 16 bit TSC_IOSCR ; \ TSC_IOSCR_G5_IO1, G5_IO1
: TSC_IOSCR_G4_IO4 ( -- x addr ) 15 bit TSC_IOSCR ; \ TSC_IOSCR_G4_IO4, G4_IO4
: TSC_IOSCR_G4_IO3 ( -- x addr ) 14 bit TSC_IOSCR ; \ TSC_IOSCR_G4_IO3, G4_IO3
: TSC_IOSCR_G4_IO2 ( -- x addr ) 13 bit TSC_IOSCR ; \ TSC_IOSCR_G4_IO2, G4_IO2
: TSC_IOSCR_G4_IO1 ( -- x addr ) 12 bit TSC_IOSCR ; \ TSC_IOSCR_G4_IO1, G4_IO1
: TSC_IOSCR_G3_IO4 ( -- x addr ) 11 bit TSC_IOSCR ; \ TSC_IOSCR_G3_IO4, G3_IO4
: TSC_IOSCR_G3_IO3 ( -- x addr ) 10 bit TSC_IOSCR ; \ TSC_IOSCR_G3_IO3, G3_IO3
: TSC_IOSCR_G3_IO2 ( -- x addr ) 9 bit TSC_IOSCR ; \ TSC_IOSCR_G3_IO2, G3_IO2
: TSC_IOSCR_G3_IO1 ( -- x addr ) 8 bit TSC_IOSCR ; \ TSC_IOSCR_G3_IO1, G3_IO1
: TSC_IOSCR_G2_IO4 ( -- x addr ) 7 bit TSC_IOSCR ; \ TSC_IOSCR_G2_IO4, G2_IO4
: TSC_IOSCR_G2_IO3 ( -- x addr ) 6 bit TSC_IOSCR ; \ TSC_IOSCR_G2_IO3, G2_IO3
: TSC_IOSCR_G2_IO2 ( -- x addr ) 5 bit TSC_IOSCR ; \ TSC_IOSCR_G2_IO2, G2_IO2
: TSC_IOSCR_G2_IO1 ( -- x addr ) 4 bit TSC_IOSCR ; \ TSC_IOSCR_G2_IO1, G2_IO1
: TSC_IOSCR_G1_IO4 ( -- x addr ) 3 bit TSC_IOSCR ; \ TSC_IOSCR_G1_IO4, G1_IO4
: TSC_IOSCR_G1_IO3 ( -- x addr ) 2 bit TSC_IOSCR ; \ TSC_IOSCR_G1_IO3, G1_IO3
: TSC_IOSCR_G1_IO2 ( -- x addr ) 1 bit TSC_IOSCR ; \ TSC_IOSCR_G1_IO2, G1_IO2
: TSC_IOSCR_G1_IO1 ( -- x addr ) 0 bit TSC_IOSCR ; \ TSC_IOSCR_G1_IO1, G1_IO1

\ TSC_IOCCR (read-write) Reset:0x00000000
: TSC_IOCCR_G8_IO4 ( -- x addr ) 31 bit TSC_IOCCR ; \ TSC_IOCCR_G8_IO4, G8_IO4
: TSC_IOCCR_G8_IO3 ( -- x addr ) 30 bit TSC_IOCCR ; \ TSC_IOCCR_G8_IO3, G8_IO3
: TSC_IOCCR_G8_IO2 ( -- x addr ) 29 bit TSC_IOCCR ; \ TSC_IOCCR_G8_IO2, G8_IO2
: TSC_IOCCR_G8_IO1 ( -- x addr ) 28 bit TSC_IOCCR ; \ TSC_IOCCR_G8_IO1, G8_IO1
: TSC_IOCCR_G7_IO4 ( -- x addr ) 27 bit TSC_IOCCR ; \ TSC_IOCCR_G7_IO4, G7_IO4
: TSC_IOCCR_G7_IO3 ( -- x addr ) 26 bit TSC_IOCCR ; \ TSC_IOCCR_G7_IO3, G7_IO3
: TSC_IOCCR_G7_IO2 ( -- x addr ) 25 bit TSC_IOCCR ; \ TSC_IOCCR_G7_IO2, G7_IO2
: TSC_IOCCR_G7_IO1 ( -- x addr ) 24 bit TSC_IOCCR ; \ TSC_IOCCR_G7_IO1, G7_IO1
: TSC_IOCCR_G6_IO4 ( -- x addr ) 23 bit TSC_IOCCR ; \ TSC_IOCCR_G6_IO4, G6_IO4
: TSC_IOCCR_G6_IO3 ( -- x addr ) 22 bit TSC_IOCCR ; \ TSC_IOCCR_G6_IO3, G6_IO3
: TSC_IOCCR_G6_IO2 ( -- x addr ) 21 bit TSC_IOCCR ; \ TSC_IOCCR_G6_IO2, G6_IO2
: TSC_IOCCR_G6_IO1 ( -- x addr ) 20 bit TSC_IOCCR ; \ TSC_IOCCR_G6_IO1, G6_IO1
: TSC_IOCCR_G5_IO4 ( -- x addr ) 19 bit TSC_IOCCR ; \ TSC_IOCCR_G5_IO4, G5_IO4
: TSC_IOCCR_G5_IO3 ( -- x addr ) 18 bit TSC_IOCCR ; \ TSC_IOCCR_G5_IO3, G5_IO3
: TSC_IOCCR_G5_IO2 ( -- x addr ) 17 bit TSC_IOCCR ; \ TSC_IOCCR_G5_IO2, G5_IO2
: TSC_IOCCR_G5_IO1 ( -- x addr ) 16 bit TSC_IOCCR ; \ TSC_IOCCR_G5_IO1, G5_IO1
: TSC_IOCCR_G4_IO4 ( -- x addr ) 15 bit TSC_IOCCR ; \ TSC_IOCCR_G4_IO4, G4_IO4
: TSC_IOCCR_G4_IO3 ( -- x addr ) 14 bit TSC_IOCCR ; \ TSC_IOCCR_G4_IO3, G4_IO3
: TSC_IOCCR_G4_IO2 ( -- x addr ) 13 bit TSC_IOCCR ; \ TSC_IOCCR_G4_IO2, G4_IO2
: TSC_IOCCR_G4_IO1 ( -- x addr ) 12 bit TSC_IOCCR ; \ TSC_IOCCR_G4_IO1, G4_IO1
: TSC_IOCCR_G3_IO4 ( -- x addr ) 11 bit TSC_IOCCR ; \ TSC_IOCCR_G3_IO4, G3_IO4
: TSC_IOCCR_G3_IO3 ( -- x addr ) 10 bit TSC_IOCCR ; \ TSC_IOCCR_G3_IO3, G3_IO3
: TSC_IOCCR_G3_IO2 ( -- x addr ) 9 bit TSC_IOCCR ; \ TSC_IOCCR_G3_IO2, G3_IO2
: TSC_IOCCR_G3_IO1 ( -- x addr ) 8 bit TSC_IOCCR ; \ TSC_IOCCR_G3_IO1, G3_IO1
: TSC_IOCCR_G2_IO4 ( -- x addr ) 7 bit TSC_IOCCR ; \ TSC_IOCCR_G2_IO4, G2_IO4
: TSC_IOCCR_G2_IO3 ( -- x addr ) 6 bit TSC_IOCCR ; \ TSC_IOCCR_G2_IO3, G2_IO3
: TSC_IOCCR_G2_IO2 ( -- x addr ) 5 bit TSC_IOCCR ; \ TSC_IOCCR_G2_IO2, G2_IO2
: TSC_IOCCR_G2_IO1 ( -- x addr ) 4 bit TSC_IOCCR ; \ TSC_IOCCR_G2_IO1, G2_IO1
: TSC_IOCCR_G1_IO4 ( -- x addr ) 3 bit TSC_IOCCR ; \ TSC_IOCCR_G1_IO4, G1_IO4
: TSC_IOCCR_G1_IO3 ( -- x addr ) 2 bit TSC_IOCCR ; \ TSC_IOCCR_G1_IO3, G1_IO3
: TSC_IOCCR_G1_IO2 ( -- x addr ) 1 bit TSC_IOCCR ; \ TSC_IOCCR_G1_IO2, G1_IO2
: TSC_IOCCR_G1_IO1 ( -- x addr ) 0 bit TSC_IOCCR ; \ TSC_IOCCR_G1_IO1, G1_IO1

\ TSC_IOGCSR (multiple-access)  Reset:0x00000000
: TSC_IOGCSR_G8S? ( -- 1|0 ) 23 bit TSC_IOGCSR bit@ ; \ TSC_IOGCSR_G8S, Analog I/O group x status
: TSC_IOGCSR_G7S? ( -- 1|0 ) 22 bit TSC_IOGCSR bit@ ; \ TSC_IOGCSR_G7S, Analog I/O group x status
: TSC_IOGCSR_G6S? ( -- 1|0 ) 21 bit TSC_IOGCSR bit@ ; \ TSC_IOGCSR_G6S, Analog I/O group x status
: TSC_IOGCSR_G5S? ( -- 1|0 ) 20 bit TSC_IOGCSR bit@ ; \ TSC_IOGCSR_G5S, Analog I/O group x status
: TSC_IOGCSR_G4S? ( -- 1|0 ) 19 bit TSC_IOGCSR bit@ ; \ TSC_IOGCSR_G4S, Analog I/O group x status
: TSC_IOGCSR_G3S? ( -- 1|0 ) 18 bit TSC_IOGCSR bit@ ; \ TSC_IOGCSR_G3S, Analog I/O group x status
: TSC_IOGCSR_G2S? ( -- 1|0 ) 17 bit TSC_IOGCSR bit@ ; \ TSC_IOGCSR_G2S, Analog I/O group x status
: TSC_IOGCSR_G1S? ( -- 1|0 ) 16 bit TSC_IOGCSR bit@ ; \ TSC_IOGCSR_G1S, Analog I/O group x status
: TSC_IOGCSR_G8E ( -- x addr ) 7 bit TSC_IOGCSR ; \ TSC_IOGCSR_G8E, Analog I/O group x enable
: TSC_IOGCSR_G7E ( -- x addr ) 6 bit TSC_IOGCSR ; \ TSC_IOGCSR_G7E, Analog I/O group x enable
: TSC_IOGCSR_G6E ( -- x addr ) 5 bit TSC_IOGCSR ; \ TSC_IOGCSR_G6E, Analog I/O group x enable
: TSC_IOGCSR_G5E ( -- x addr ) 4 bit TSC_IOGCSR ; \ TSC_IOGCSR_G5E, Analog I/O group x enable
: TSC_IOGCSR_G4E ( -- x addr ) 3 bit TSC_IOGCSR ; \ TSC_IOGCSR_G4E, Analog I/O group x enable
: TSC_IOGCSR_G3E ( -- x addr ) 2 bit TSC_IOGCSR ; \ TSC_IOGCSR_G3E, Analog I/O group x enable
: TSC_IOGCSR_G2E ( -- x addr ) 1 bit TSC_IOGCSR ; \ TSC_IOGCSR_G2E, Analog I/O group x enable
: TSC_IOGCSR_G1E ( -- x addr ) 0 bit TSC_IOGCSR ; \ TSC_IOGCSR_G1E, Analog I/O group x enable

\ TSC_IOG1CR (read-only) Reset:0x00000000
: TSC_IOG1CR_CNT? ( --  x ) TSC_IOG1CR @ ; \ TSC_IOG1CR_CNT, Counter value

\ TSC_IOG2CR (read-only) Reset:0x00000000
: TSC_IOG2CR_CNT? ( --  x ) TSC_IOG2CR @ ; \ TSC_IOG2CR_CNT, Counter value

\ TSC_IOG3CR (read-only) Reset:0x00000000
: TSC_IOG3CR_CNT? ( --  x ) TSC_IOG3CR @ ; \ TSC_IOG3CR_CNT, Counter value

\ TSC_IOG4CR (read-only) Reset:0x00000000
: TSC_IOG4CR_CNT? ( --  x ) TSC_IOG4CR @ ; \ TSC_IOG4CR_CNT, Counter value

\ TSC_IOG5CR (read-only) Reset:0x00000000
: TSC_IOG5CR_CNT? ( --  x ) TSC_IOG5CR @ ; \ TSC_IOG5CR_CNT, Counter value

\ TSC_IOG6CR (read-only) Reset:0x00000000
: TSC_IOG6CR_CNT? ( --  x ) TSC_IOG6CR @ ; \ TSC_IOG6CR_CNT, Counter value

\ TSC_IOG7CR (read-only) Reset:0x00000000
: TSC_IOG7CR_CNT? ( --  x ) TSC_IOG7CR @ ; \ TSC_IOG7CR_CNT, Counter value

\ TSC_IOG8CR (read-only) Reset:0x00000000
: TSC_IOG8CR_CNT? ( --  x ) TSC_IOG8CR @ ; \ TSC_IOG8CR_CNT, Counter value

\ IWDG_KR (write-only) Reset:0x00000000
: IWDG_KR_KEY ( %bbbbbbbbbbbbbbbb -- x addr ) IWDG_KR ; \ IWDG_KR_KEY, Key value write only, read  $0000

\ IWDG_PR (read-write) Reset:0x00000000
: IWDG_PR_PR ( %bbb -- x addr ) IWDG_PR ; \ IWDG_PR_PR, Prescaler divider

\ IWDG_RLR (read-write) Reset:0x00000FFF
: IWDG_RLR_RL ( %bbbbbbbbbbb -- x addr ) IWDG_RLR ; \ IWDG_RLR_RL, Watchdog counter reload  value

\ IWDG_SR (read-only) Reset:0x00000000
: IWDG_SR_WVU? ( --  1|0 ) 2 bit IWDG_SR bit@ ; \ IWDG_SR_WVU, Watchdog counter window value  update
: IWDG_SR_RVU? ( --  1|0 ) 1 bit IWDG_SR bit@ ; \ IWDG_SR_RVU, Watchdog counter reload value  update
: IWDG_SR_PVU? ( --  1|0 ) 0 bit IWDG_SR bit@ ; \ IWDG_SR_PVU, Watchdog prescaler value  update

\ IWDG_WINR (read-write) Reset:0x00000FFF
: IWDG_WINR_WIN ( %bbbbbbbbbbb -- x addr ) IWDG_WINR ; \ IWDG_WINR_WIN, Watchdog counter window  value

\ WWDG_CR (read-write) Reset:0x0000007F
: WWDG_CR_WDGA ( -- x addr ) 7 bit WWDG_CR ; \ WWDG_CR_WDGA, Activation bit
: WWDG_CR_T ( %bbbbbbb -- x addr ) WWDG_CR ; \ WWDG_CR_T, 7-bit counter MSB to LSB

\ WWDG_CFR (read-write) Reset:0x0000007F
: WWDG_CFR_EWI ( -- x addr ) 9 bit WWDG_CFR ; \ WWDG_CFR_EWI, Early wakeup interrupt
: WWDG_CFR_WDGTB1 ( -- x addr ) 8 bit WWDG_CFR ; \ WWDG_CFR_WDGTB1, Timer base
: WWDG_CFR_WDGTB0 ( -- x addr ) 7 bit WWDG_CFR ; \ WWDG_CFR_WDGTB0, WDGTB0
: WWDG_CFR_W ( %bbbbbbb -- x addr ) WWDG_CFR ; \ WWDG_CFR_W, 7-bit window value

\ WWDG_SR (multiple-access)  Reset:0x00000000
: WWDG_SR_EWIF? ( -- 1|0 ) 0 bit WWDG_SR bit@ ; \ WWDG_SR_EWIF, Early wakeup interrupt  flag

\ COMP_COMP1_CSR (multiple-access)  Reset:0x0
: COMP_COMP1_CSR_COMP1_EN ( -- x addr ) 0 bit COMP_COMP1_CSR ; \ COMP_COMP1_CSR_COMP1_EN, Comparator 1 enable bit
: COMP_COMP1_CSR_COMP1_INN_SEL ( %bb -- x addr ) 4 lshift COMP_COMP1_CSR ; \ COMP_COMP1_CSR_COMP1_INN_SEL, Comparator 1 Input Minus connection  configuration bit
: COMP_COMP1_CSR_COMP1_WM ( -- x addr ) 8 bit COMP_COMP1_CSR ; \ COMP_COMP1_CSR_COMP1_WM, Comparator 1 window mode selection  bit
: COMP_COMP1_CSR_COMP1_OUT_SEL ( %bbb -- x addr ) 12 lshift COMP_COMP1_CSR ; \ COMP_COMP1_CSR_COMP1_OUT_SEL, COMP1 output select
: COMP_COMP1_CSR_COMP1_POLARITY ( -- x addr ) 15 bit COMP_COMP1_CSR ; \ COMP_COMP1_CSR_COMP1_POLARITY, Comparator 1 polarity selection  bit
: COMP_COMP1_CSR_COMP1_VALUE? ( -- 1|0 ) 30 bit COMP_COMP1_CSR bit@ ; \ COMP_COMP1_CSR_COMP1_VALUE, Comparator 1 output status  bit
: COMP_COMP1_CSR_COMP1_LOCK ( -- x addr ) 31 bit COMP_COMP1_CSR ; \ COMP_COMP1_CSR_COMP1_LOCK, COMP1_CSR register lock  bit

\ COMP_COMP2_CSR (multiple-access)  Reset:0x0
: COMP_COMP2_CSR_COMP2_LOCK ( -- x addr ) 31 bit COMP_COMP2_CSR ; \ COMP_COMP2_CSR_COMP2_LOCK, COMP2_CSR register lock  bit
: COMP_COMP2_CSR_COMP2_VALUE? ( -- 1|0 ) 30 bit COMP_COMP2_CSR bit@ ; \ COMP_COMP2_CSR_COMP2_VALUE, Comparator 2 output status  bit
: COMP_COMP2_CSR_COMP2_POLARITY ( -- x addr ) 15 bit COMP_COMP2_CSR ; \ COMP_COMP2_CSR_COMP2_POLARITY, Comparator 2 polarity selection  bit
: COMP_COMP2_CSR_COMP2_INP_SEL ( %bbb -- x addr ) 8 lshift COMP_COMP2_CSR ; \ COMP_COMP2_CSR_COMP2_INP_SEL, Comparator 2 Input Plus connection  configuration bit
: COMP_COMP2_CSR_COMP2_INN_SEL ( %bbb -- x addr ) 4 lshift COMP_COMP2_CSR ; \ COMP_COMP2_CSR_COMP2_INN_SEL, Comparator 2 Input Minus connection  configuration bit
: COMP_COMP2_CSR_COMP2_SPEED ( -- x addr ) 3 bit COMP_COMP2_CSR ; \ COMP_COMP2_CSR_COMP2_SPEED, Comparator 2 power mode selection  bit
: COMP_COMP2_CSR_COMP2_EN ( -- x addr ) 0 bit COMP_COMP2_CSR ; \ COMP_COMP2_CSR_COMP2_EN, Comparator 2 enable bit
: COMP_COMP2_CSR_COMP2_OUT_SEL ( %bbb -- x addr ) 12 lshift COMP_COMP2_CSR ; \ COMP_COMP2_CSR_COMP2_OUT_SEL, COMP2 output select

\ USB_FS_EP0R (read-write) Reset:0x0
: USB_FS_EP0R_CTR_RX ( -- x addr ) 15 bit USB_FS_EP0R ; \ USB_FS_EP0R_CTR_RX, CTR_RX
: USB_FS_EP0R_DTOG_RX ( -- x addr ) 14 bit USB_FS_EP0R ; \ USB_FS_EP0R_DTOG_RX, DTOG_RX
: USB_FS_EP0R_STAT_RX ( %bb -- x addr ) 12 lshift USB_FS_EP0R ; \ USB_FS_EP0R_STAT_RX, STAT_RX
: USB_FS_EP0R_SETUP ( -- x addr ) 11 bit USB_FS_EP0R ; \ USB_FS_EP0R_SETUP, SETUP
: USB_FS_EP0R_EPTYPE ( %bb -- x addr ) 9 lshift USB_FS_EP0R ; \ USB_FS_EP0R_EPTYPE, EPTYPE
: USB_FS_EP0R_EP_KIND ( -- x addr ) 8 bit USB_FS_EP0R ; \ USB_FS_EP0R_EP_KIND, EP_KIND
: USB_FS_EP0R_CTR_TX ( -- x addr ) 7 bit USB_FS_EP0R ; \ USB_FS_EP0R_CTR_TX, CTR_TX
: USB_FS_EP0R_DTOG_TX ( -- x addr ) 6 bit USB_FS_EP0R ; \ USB_FS_EP0R_DTOG_TX, DTOG_TX
: USB_FS_EP0R_STAT_TX ( %bb -- x addr ) 4 lshift USB_FS_EP0R ; \ USB_FS_EP0R_STAT_TX, STAT_TX
: USB_FS_EP0R_EA ( %bbbb -- x addr ) USB_FS_EP0R ; \ USB_FS_EP0R_EA, EA

\ USB_FS_EP1R (read-write) Reset:0x0
: USB_FS_EP1R_CTR_RX ( -- x addr ) 15 bit USB_FS_EP1R ; \ USB_FS_EP1R_CTR_RX, CTR_RX
: USB_FS_EP1R_DTOG_RX ( -- x addr ) 14 bit USB_FS_EP1R ; \ USB_FS_EP1R_DTOG_RX, DTOG_RX
: USB_FS_EP1R_STAT_RX ( %bb -- x addr ) 12 lshift USB_FS_EP1R ; \ USB_FS_EP1R_STAT_RX, STAT_RX
: USB_FS_EP1R_SETUP ( -- x addr ) 11 bit USB_FS_EP1R ; \ USB_FS_EP1R_SETUP, SETUP
: USB_FS_EP1R_EPTYPE ( %bb -- x addr ) 9 lshift USB_FS_EP1R ; \ USB_FS_EP1R_EPTYPE, EPTYPE
: USB_FS_EP1R_EP_KIND ( -- x addr ) 8 bit USB_FS_EP1R ; \ USB_FS_EP1R_EP_KIND, EP_KIND
: USB_FS_EP1R_CTR_TX ( -- x addr ) 7 bit USB_FS_EP1R ; \ USB_FS_EP1R_CTR_TX, CTR_TX
: USB_FS_EP1R_DTOG_TX ( -- x addr ) 6 bit USB_FS_EP1R ; \ USB_FS_EP1R_DTOG_TX, DTOG_TX
: USB_FS_EP1R_STAT_TX ( %bb -- x addr ) 4 lshift USB_FS_EP1R ; \ USB_FS_EP1R_STAT_TX, STAT_TX
: USB_FS_EP1R_EA ( %bbbb -- x addr ) USB_FS_EP1R ; \ USB_FS_EP1R_EA, EA

\ USB_FS_EP2R (read-write) Reset:0x0
: USB_FS_EP2R_CTR_RX ( -- x addr ) 15 bit USB_FS_EP2R ; \ USB_FS_EP2R_CTR_RX, CTR_RX
: USB_FS_EP2R_DTOG_RX ( -- x addr ) 14 bit USB_FS_EP2R ; \ USB_FS_EP2R_DTOG_RX, DTOG_RX
: USB_FS_EP2R_STAT_RX ( %bb -- x addr ) 12 lshift USB_FS_EP2R ; \ USB_FS_EP2R_STAT_RX, STAT_RX
: USB_FS_EP2R_SETUP ( -- x addr ) 11 bit USB_FS_EP2R ; \ USB_FS_EP2R_SETUP, SETUP
: USB_FS_EP2R_EPTYPE ( %bb -- x addr ) 9 lshift USB_FS_EP2R ; \ USB_FS_EP2R_EPTYPE, EPTYPE
: USB_FS_EP2R_EP_KIND ( -- x addr ) 8 bit USB_FS_EP2R ; \ USB_FS_EP2R_EP_KIND, EP_KIND
: USB_FS_EP2R_CTR_TX ( -- x addr ) 7 bit USB_FS_EP2R ; \ USB_FS_EP2R_CTR_TX, CTR_TX
: USB_FS_EP2R_DTOG_TX ( -- x addr ) 6 bit USB_FS_EP2R ; \ USB_FS_EP2R_DTOG_TX, DTOG_TX
: USB_FS_EP2R_STAT_TX ( %bb -- x addr ) 4 lshift USB_FS_EP2R ; \ USB_FS_EP2R_STAT_TX, STAT_TX
: USB_FS_EP2R_EA ( %bbbb -- x addr ) USB_FS_EP2R ; \ USB_FS_EP2R_EA, EA

\ USB_FS_EP3R (read-write) Reset:0x0
: USB_FS_EP3R_CTR_RX ( -- x addr ) 15 bit USB_FS_EP3R ; \ USB_FS_EP3R_CTR_RX, CTR_RX
: USB_FS_EP3R_DTOG_RX ( -- x addr ) 14 bit USB_FS_EP3R ; \ USB_FS_EP3R_DTOG_RX, DTOG_RX
: USB_FS_EP3R_STAT_RX ( %bb -- x addr ) 12 lshift USB_FS_EP3R ; \ USB_FS_EP3R_STAT_RX, STAT_RX
: USB_FS_EP3R_SETUP ( -- x addr ) 11 bit USB_FS_EP3R ; \ USB_FS_EP3R_SETUP, SETUP
: USB_FS_EP3R_EPTYPE ( %bb -- x addr ) 9 lshift USB_FS_EP3R ; \ USB_FS_EP3R_EPTYPE, EPTYPE
: USB_FS_EP3R_EP_KIND ( -- x addr ) 8 bit USB_FS_EP3R ; \ USB_FS_EP3R_EP_KIND, EP_KIND
: USB_FS_EP3R_CTR_TX ( -- x addr ) 7 bit USB_FS_EP3R ; \ USB_FS_EP3R_CTR_TX, CTR_TX
: USB_FS_EP3R_DTOG_TX ( -- x addr ) 6 bit USB_FS_EP3R ; \ USB_FS_EP3R_DTOG_TX, DTOG_TX
: USB_FS_EP3R_STAT_TX ( %bb -- x addr ) 4 lshift USB_FS_EP3R ; \ USB_FS_EP3R_STAT_TX, STAT_TX
: USB_FS_EP3R_EA ( %bbbb -- x addr ) USB_FS_EP3R ; \ USB_FS_EP3R_EA, EA

\ USB_FS_EP4R (read-write) Reset:0x0
: USB_FS_EP4R_CTR_RX ( -- x addr ) 15 bit USB_FS_EP4R ; \ USB_FS_EP4R_CTR_RX, CTR_RX
: USB_FS_EP4R_DTOG_RX ( -- x addr ) 14 bit USB_FS_EP4R ; \ USB_FS_EP4R_DTOG_RX, DTOG_RX
: USB_FS_EP4R_STAT_RX ( %bb -- x addr ) 12 lshift USB_FS_EP4R ; \ USB_FS_EP4R_STAT_RX, STAT_RX
: USB_FS_EP4R_SETUP ( -- x addr ) 11 bit USB_FS_EP4R ; \ USB_FS_EP4R_SETUP, SETUP
: USB_FS_EP4R_EPTYPE ( %bb -- x addr ) 9 lshift USB_FS_EP4R ; \ USB_FS_EP4R_EPTYPE, EPTYPE
: USB_FS_EP4R_EP_KIND ( -- x addr ) 8 bit USB_FS_EP4R ; \ USB_FS_EP4R_EP_KIND, EP_KIND
: USB_FS_EP4R_CTR_TX ( -- x addr ) 7 bit USB_FS_EP4R ; \ USB_FS_EP4R_CTR_TX, CTR_TX
: USB_FS_EP4R_DTOG_TX ( -- x addr ) 6 bit USB_FS_EP4R ; \ USB_FS_EP4R_DTOG_TX, DTOG_TX
: USB_FS_EP4R_STAT_TX ( %bb -- x addr ) 4 lshift USB_FS_EP4R ; \ USB_FS_EP4R_STAT_TX, STAT_TX
: USB_FS_EP4R_EA ( %bbbb -- x addr ) USB_FS_EP4R ; \ USB_FS_EP4R_EA, EA

\ USB_FS_EP5R (read-write) Reset:0x0
: USB_FS_EP5R_CTR_RX ( -- x addr ) 15 bit USB_FS_EP5R ; \ USB_FS_EP5R_CTR_RX, CTR_RX
: USB_FS_EP5R_DTOG_RX ( -- x addr ) 14 bit USB_FS_EP5R ; \ USB_FS_EP5R_DTOG_RX, DTOG_RX
: USB_FS_EP5R_STAT_RX ( %bb -- x addr ) 12 lshift USB_FS_EP5R ; \ USB_FS_EP5R_STAT_RX, STAT_RX
: USB_FS_EP5R_SETUP ( -- x addr ) 11 bit USB_FS_EP5R ; \ USB_FS_EP5R_SETUP, SETUP
: USB_FS_EP5R_EPTYPE ( %bb -- x addr ) 9 lshift USB_FS_EP5R ; \ USB_FS_EP5R_EPTYPE, EPTYPE
: USB_FS_EP5R_EP_KIND ( -- x addr ) 8 bit USB_FS_EP5R ; \ USB_FS_EP5R_EP_KIND, EP_KIND
: USB_FS_EP5R_CTR_TX ( -- x addr ) 7 bit USB_FS_EP5R ; \ USB_FS_EP5R_CTR_TX, CTR_TX
: USB_FS_EP5R_DTOG_TX ( -- x addr ) 6 bit USB_FS_EP5R ; \ USB_FS_EP5R_DTOG_TX, DTOG_TX
: USB_FS_EP5R_STAT_TX ( %bb -- x addr ) 4 lshift USB_FS_EP5R ; \ USB_FS_EP5R_STAT_TX, STAT_TX
: USB_FS_EP5R_EA ( %bbbb -- x addr ) USB_FS_EP5R ; \ USB_FS_EP5R_EA, EA

\ USB_FS_EP6R (read-write) Reset:0x0
: USB_FS_EP6R_CTR_RX ( -- x addr ) 15 bit USB_FS_EP6R ; \ USB_FS_EP6R_CTR_RX, CTR_RX
: USB_FS_EP6R_DTOG_RX ( -- x addr ) 14 bit USB_FS_EP6R ; \ USB_FS_EP6R_DTOG_RX, DTOG_RX
: USB_FS_EP6R_STAT_RX ( %bb -- x addr ) 12 lshift USB_FS_EP6R ; \ USB_FS_EP6R_STAT_RX, STAT_RX
: USB_FS_EP6R_SETUP ( -- x addr ) 11 bit USB_FS_EP6R ; \ USB_FS_EP6R_SETUP, SETUP
: USB_FS_EP6R_EPTYPE ( %bb -- x addr ) 9 lshift USB_FS_EP6R ; \ USB_FS_EP6R_EPTYPE, EPTYPE
: USB_FS_EP6R_EP_KIND ( -- x addr ) 8 bit USB_FS_EP6R ; \ USB_FS_EP6R_EP_KIND, EP_KIND
: USB_FS_EP6R_CTR_TX ( -- x addr ) 7 bit USB_FS_EP6R ; \ USB_FS_EP6R_CTR_TX, CTR_TX
: USB_FS_EP6R_DTOG_TX ( -- x addr ) 6 bit USB_FS_EP6R ; \ USB_FS_EP6R_DTOG_TX, DTOG_TX
: USB_FS_EP6R_STAT_TX ( %bb -- x addr ) 4 lshift USB_FS_EP6R ; \ USB_FS_EP6R_STAT_TX, STAT_TX
: USB_FS_EP6R_EA ( %bbbb -- x addr ) USB_FS_EP6R ; \ USB_FS_EP6R_EA, EA

\ USB_FS_EP7R (read-write) Reset:0x0
: USB_FS_EP7R_CTR_RX ( -- x addr ) 15 bit USB_FS_EP7R ; \ USB_FS_EP7R_CTR_RX, CTR_RX
: USB_FS_EP7R_DTOG_RX ( -- x addr ) 14 bit USB_FS_EP7R ; \ USB_FS_EP7R_DTOG_RX, DTOG_RX
: USB_FS_EP7R_STAT_RX ( %bb -- x addr ) 12 lshift USB_FS_EP7R ; \ USB_FS_EP7R_STAT_RX, STAT_RX
: USB_FS_EP7R_SETUP ( -- x addr ) 11 bit USB_FS_EP7R ; \ USB_FS_EP7R_SETUP, SETUP
: USB_FS_EP7R_EPTYPE ( %bb -- x addr ) 9 lshift USB_FS_EP7R ; \ USB_FS_EP7R_EPTYPE, EPTYPE
: USB_FS_EP7R_EP_KIND ( -- x addr ) 8 bit USB_FS_EP7R ; \ USB_FS_EP7R_EP_KIND, EP_KIND
: USB_FS_EP7R_CTR_TX ( -- x addr ) 7 bit USB_FS_EP7R ; \ USB_FS_EP7R_CTR_TX, CTR_TX
: USB_FS_EP7R_DTOG_TX ( -- x addr ) 6 bit USB_FS_EP7R ; \ USB_FS_EP7R_DTOG_TX, DTOG_TX
: USB_FS_EP7R_STAT_TX ( %bb -- x addr ) 4 lshift USB_FS_EP7R ; \ USB_FS_EP7R_STAT_TX, STAT_TX
: USB_FS_EP7R_EA ( %bbbb -- x addr ) USB_FS_EP7R ; \ USB_FS_EP7R_EA, EA

\ USB_FS_CNTR (read-write) Reset:0x0
: USB_FS_CNTR_CTRM ( -- x addr ) 15 bit USB_FS_CNTR ; \ USB_FS_CNTR_CTRM, CTRM
: USB_FS_CNTR_PMAOVRM ( -- x addr ) 14 bit USB_FS_CNTR ; \ USB_FS_CNTR_PMAOVRM, PMAOVRM
: USB_FS_CNTR_ERRM ( -- x addr ) 13 bit USB_FS_CNTR ; \ USB_FS_CNTR_ERRM, ERRM
: USB_FS_CNTR_WKUPM ( -- x addr ) 12 bit USB_FS_CNTR ; \ USB_FS_CNTR_WKUPM, WKUPM
: USB_FS_CNTR_SUSPM ( -- x addr ) 11 bit USB_FS_CNTR ; \ USB_FS_CNTR_SUSPM, SUSPM
: USB_FS_CNTR_RESETM ( -- x addr ) 10 bit USB_FS_CNTR ; \ USB_FS_CNTR_RESETM, RESETM
: USB_FS_CNTR_SOFM ( -- x addr ) 9 bit USB_FS_CNTR ; \ USB_FS_CNTR_SOFM, SOFM
: USB_FS_CNTR_ESOFM ( -- x addr ) 8 bit USB_FS_CNTR ; \ USB_FS_CNTR_ESOFM, ESOFM
: USB_FS_CNTR_L1REQM ( -- x addr ) 7 bit USB_FS_CNTR ; \ USB_FS_CNTR_L1REQM, L1REQM
: USB_FS_CNTR_L1RESUME ( -- x addr ) 5 bit USB_FS_CNTR ; \ USB_FS_CNTR_L1RESUME, L1RESUME
: USB_FS_CNTR_RESUME ( -- x addr ) 4 bit USB_FS_CNTR ; \ USB_FS_CNTR_RESUME, RESUME
: USB_FS_CNTR_FSUSP ( -- x addr ) 3 bit USB_FS_CNTR ; \ USB_FS_CNTR_FSUSP, FSUSP
: USB_FS_CNTR_LPMODE ( -- x addr ) 2 bit USB_FS_CNTR ; \ USB_FS_CNTR_LPMODE, LPMODE
: USB_FS_CNTR_PDWN ( -- x addr ) 1 bit USB_FS_CNTR ; \ USB_FS_CNTR_PDWN, PDWN
: USB_FS_CNTR_FRES ( -- x addr ) 0 bit USB_FS_CNTR ; \ USB_FS_CNTR_FRES, FRES

\ USB_FS_ISTR (read-write) Reset:0x0
: USB_FS_ISTR_CTR ( -- x addr ) 15 bit USB_FS_ISTR ; \ USB_FS_ISTR_CTR, CTR
: USB_FS_ISTR_PMAOVR ( -- x addr ) 14 bit USB_FS_ISTR ; \ USB_FS_ISTR_PMAOVR, PMAOVR
: USB_FS_ISTR_ERR ( -- x addr ) 13 bit USB_FS_ISTR ; \ USB_FS_ISTR_ERR, ERR
: USB_FS_ISTR_WKUP ( -- x addr ) 12 bit USB_FS_ISTR ; \ USB_FS_ISTR_WKUP, WKUP
: USB_FS_ISTR_SUSP ( -- x addr ) 11 bit USB_FS_ISTR ; \ USB_FS_ISTR_SUSP, SUSP
: USB_FS_ISTR_RESET ( -- x addr ) 10 bit USB_FS_ISTR ; \ USB_FS_ISTR_RESET, RESET
: USB_FS_ISTR_SOF ( -- x addr ) 9 bit USB_FS_ISTR ; \ USB_FS_ISTR_SOF, SOF
: USB_FS_ISTR_ESOF ( -- x addr ) 8 bit USB_FS_ISTR ; \ USB_FS_ISTR_ESOF, ESOF
: USB_FS_ISTR_L1REQ ( -- x addr ) 7 bit USB_FS_ISTR ; \ USB_FS_ISTR_L1REQ, L1REQ
: USB_FS_ISTR_DIR ( -- x addr ) 4 bit USB_FS_ISTR ; \ USB_FS_ISTR_DIR, DIR
: USB_FS_ISTR_EP_ID ( %bbbb -- x addr ) USB_FS_ISTR ; \ USB_FS_ISTR_EP_ID, EP_ID

\ USB_FS_FNR (read-only) Reset:0x0
: USB_FS_FNR_RXDP? ( --  1|0 ) 15 bit USB_FS_FNR bit@ ; \ USB_FS_FNR_RXDP, RXDP
: USB_FS_FNR_RXDM? ( --  1|0 ) 14 bit USB_FS_FNR bit@ ; \ USB_FS_FNR_RXDM, RXDM
: USB_FS_FNR_LCK? ( --  1|0 ) 13 bit USB_FS_FNR bit@ ; \ USB_FS_FNR_LCK, LCK
: USB_FS_FNR_LSOF? ( --  x ) 11 lshift USB_FS_FNR @ ; \ USB_FS_FNR_LSOF, LSOF
: USB_FS_FNR_FN? ( --  x ) USB_FS_FNR @ ; \ USB_FS_FNR_FN, FN

\ USB_FS_DADDR (read-write) Reset:0x0
: USB_FS_DADDR_EF ( -- x addr ) 7 bit USB_FS_DADDR ; \ USB_FS_DADDR_EF, EF
: USB_FS_DADDR_ADD ( %bbbbbbb -- x addr ) USB_FS_DADDR ; \ USB_FS_DADDR_ADD, ADD

\ USB_FS_BTABLE (read-write) Reset:0x0
: USB_FS_BTABLE_BTABLE x addr ) 3 lshift USB_FS_BTABLE ; \ USB_FS_BTABLE_BTABLE, BTABLE

\ USB_FS_LPMCSR (multiple-access)  Reset:0x0
: USB_FS_LPMCSR_BESL ( %bbbb -- x addr ) 4 lshift USB_FS_LPMCSR ; \ USB_FS_LPMCSR_BESL, BESL
: USB_FS_LPMCSR_REMWAKE ( -- x addr ) 3 bit USB_FS_LPMCSR ; \ USB_FS_LPMCSR_REMWAKE, REMWAKE
: USB_FS_LPMCSR_LPMACK ( -- x addr ) 1 bit USB_FS_LPMCSR ; \ USB_FS_LPMCSR_LPMACK, LPMACK
: USB_FS_LPMCSR_LPMEN ( -- x addr ) 0 bit USB_FS_LPMCSR ; \ USB_FS_LPMCSR_LPMEN, LPMEN

\ USB_FS_BCDR (multiple-access)  Reset:0x0
: USB_FS_BCDR_DPPU ( -- x addr ) 15 bit USB_FS_BCDR ; \ USB_FS_BCDR_DPPU, DPPU
: USB_FS_BCDR_PS2DET ( -- x addr ) 7 bit USB_FS_BCDR ; \ USB_FS_BCDR_PS2DET, PS2DET
: USB_FS_BCDR_SDET ( -- x addr ) 6 bit USB_FS_BCDR ; \ USB_FS_BCDR_SDET, SDET
: USB_FS_BCDR_PDET ( -- x addr ) 5 bit USB_FS_BCDR ; \ USB_FS_BCDR_PDET, PDET
: USB_FS_BCDR_DCDET ( -- x addr ) 4 bit USB_FS_BCDR ; \ USB_FS_BCDR_DCDET, DCDET
: USB_FS_BCDR_SDEN ( -- x addr ) 3 bit USB_FS_BCDR ; \ USB_FS_BCDR_SDEN, SDEN
: USB_FS_BCDR_PDEN ( -- x addr ) 2 bit USB_FS_BCDR ; \ USB_FS_BCDR_PDEN, PDEN
: USB_FS_BCDR_DCDEN ( -- x addr ) 1 bit USB_FS_BCDR ; \ USB_FS_BCDR_DCDEN, DCDEN
: USB_FS_BCDR_BCDEN ( -- x addr ) 0 bit USB_FS_BCDR ; \ USB_FS_BCDR_BCDEN, BCDEN

\ CRS_CR (read-write) Reset:0x00002000
: CRS_CR_TRIM ( %bbbbbb -- x addr ) 8 lshift CRS_CR ; \ CRS_CR_TRIM, HSI48 oscillator smooth  trimming
: CRS_CR_SWSYNC ( -- x addr ) 7 bit CRS_CR ; \ CRS_CR_SWSYNC, Generate software SYNC  event
: CRS_CR_AUTOTRIMEN ( -- x addr ) 6 bit CRS_CR ; \ CRS_CR_AUTOTRIMEN, Automatic trimming enable
: CRS_CR_CEN ( -- x addr ) 5 bit CRS_CR ; \ CRS_CR_CEN, Frequency error counter  enable
: CRS_CR_ESYNCIE ( -- x addr ) 3 bit CRS_CR ; \ CRS_CR_ESYNCIE, Expected SYNC interrupt  enable
: CRS_CR_ERRIE ( -- x addr ) 2 bit CRS_CR ; \ CRS_CR_ERRIE, Synchronization or trimming error  interrupt enable
: CRS_CR_SYNCWARNIE ( -- x addr ) 1 bit CRS_CR ; \ CRS_CR_SYNCWARNIE, SYNC warning interrupt  enable
: CRS_CR_SYNCOKIE ( -- x addr ) 0 bit CRS_CR ; \ CRS_CR_SYNCOKIE, SYNC event OK interrupt  enable

\ CRS_CFGR (read-write) Reset:0x2022BB7F
: CRS_CFGR_SYNCPOL ( -- x addr ) 31 bit CRS_CFGR ; \ CRS_CFGR_SYNCPOL, SYNC polarity selection
: CRS_CFGR_SYNCSRC ( %bb -- x addr ) 28 lshift CRS_CFGR ; \ CRS_CFGR_SYNCSRC, SYNC signal source  selection
: CRS_CFGR_SYNCDIV ( %bbb -- x addr ) 24 lshift CRS_CFGR ; \ CRS_CFGR_SYNCDIV, SYNC divider
: CRS_CFGR_FELIM ( %bbbbbbbb -- x addr ) 16 lshift CRS_CFGR ; \ CRS_CFGR_FELIM, Frequency error limit
: CRS_CFGR_RELOAD ( %bbbbbbbbbbbbbbbb -- x addr ) CRS_CFGR ; \ CRS_CFGR_RELOAD, Counter reload value

\ CRS_ISR (read-only) Reset:0x00000000
: CRS_ISR_FECAP? ( --  x ) 16 lshift CRS_ISR @ ; \ CRS_ISR_FECAP, Frequency error capture
: CRS_ISR_FEDIR? ( --  1|0 ) 15 bit CRS_ISR bit@ ; \ CRS_ISR_FEDIR, Frequency error direction
: CRS_ISR_TRIMOVF? ( --  1|0 ) 10 bit CRS_ISR bit@ ; \ CRS_ISR_TRIMOVF, Trimming overflow or  underflow
: CRS_ISR_SYNCMISS? ( --  1|0 ) 9 bit CRS_ISR bit@ ; \ CRS_ISR_SYNCMISS, SYNC missed
: CRS_ISR_SYNCERR? ( --  1|0 ) 8 bit CRS_ISR bit@ ; \ CRS_ISR_SYNCERR, SYNC error
: CRS_ISR_ESYNCF? ( --  1|0 ) 3 bit CRS_ISR bit@ ; \ CRS_ISR_ESYNCF, Expected SYNC flag
: CRS_ISR_ERRF? ( --  1|0 ) 2 bit CRS_ISR bit@ ; \ CRS_ISR_ERRF, Error flag
: CRS_ISR_SYNCWARNF? ( --  1|0 ) 1 bit CRS_ISR bit@ ; \ CRS_ISR_SYNCWARNF, SYNC warning flag
: CRS_ISR_SYNCOKF? ( --  1|0 ) 0 bit CRS_ISR bit@ ; \ CRS_ISR_SYNCOKF, SYNC event OK flag

\ CRS_ICR (read-write) Reset:0x00000000
: CRS_ICR_ESYNCC ( -- x addr ) 3 bit CRS_ICR ; \ CRS_ICR_ESYNCC, Expected SYNC clear flag
: CRS_ICR_ERRC ( -- x addr ) 2 bit CRS_ICR ; \ CRS_ICR_ERRC, Error clear flag
: CRS_ICR_SYNCWARNC ( -- x addr ) 1 bit CRS_ICR ; \ CRS_ICR_SYNCWARNC, SYNC warning clear flag
: CRS_ICR_SYNCOKC ( -- x addr ) 0 bit CRS_ICR ; \ CRS_ICR_SYNCOKC, SYNC event OK clear flag

\ Firewall_FIREWALL_CSSA (read-write) Reset:0x00000000
: Firewall_FIREWALL_CSSA_ADD ( %bbbbbbbbbbbbbbbb -- x addr ) 8 lshift Firewall_FIREWALL_CSSA ; \ Firewall_FIREWALL_CSSA_ADD, code segment start address

\ Firewall_FIREWALL_CSL (read-write) Reset:0x00000000
: Firewall_FIREWALL_CSL_LENG ( %bbbbbbbbbbbbbb -- x addr ) 8 lshift Firewall_FIREWALL_CSL ; \ Firewall_FIREWALL_CSL_LENG, code segment length

\ Firewall_FIREWALL_NVDSSA (read-write) Reset:0x00000000
: Firewall_FIREWALL_NVDSSA_ADD ( %bbbbbbbbbbbbbbbb -- x addr ) 8 lshift Firewall_FIREWALL_NVDSSA ; \ Firewall_FIREWALL_NVDSSA_ADD, Non-volatile data segment start  address

\ Firewall_FIREWALL_NVDSL (read-write) Reset:0x00000000
: Firewall_FIREWALL_NVDSL_LENG ( %bbbbbbbbbbbbbb -- x addr ) 8 lshift Firewall_FIREWALL_NVDSL ; \ Firewall_FIREWALL_NVDSL_LENG, Non-volatile data segment  length

\ Firewall_FIREWALL_VDSSA (read-write) Reset:0x00000000
: Firewall_FIREWALL_VDSSA_ADD ( %bbbbbbbbbb -- x addr ) 6 lshift Firewall_FIREWALL_VDSSA ; \ Firewall_FIREWALL_VDSSA_ADD, Volatile data segment start  address

\ Firewall_FIREWALL_VDSL (read-write) Reset:0x00000000
: Firewall_FIREWALL_VDSL_LENG ( %bbbbbbbbbb -- x addr ) 6 lshift Firewall_FIREWALL_VDSL ; \ Firewall_FIREWALL_VDSL_LENG, Non-volatile data segment  length

\ Firewall_FIREWALL_CR (read-write) Reset:0x00000000
: Firewall_FIREWALL_CR_VDE ( -- x addr ) 2 bit Firewall_FIREWALL_CR ; \ Firewall_FIREWALL_CR_VDE, Volatile data execution
: Firewall_FIREWALL_CR_VDS ( -- x addr ) 1 bit Firewall_FIREWALL_CR ; \ Firewall_FIREWALL_CR_VDS, Volatile data shared
: Firewall_FIREWALL_CR_FPA ( -- x addr ) 0 bit Firewall_FIREWALL_CR ; \ Firewall_FIREWALL_CR_FPA, Firewall pre alarm

\ RCC_CR (multiple-access)  Reset:0x00000300
: RCC_CR_PLLRDY? ( -- 1|0 ) 25 bit RCC_CR bit@ ; \ RCC_CR_PLLRDY, PLL clock ready flag
: RCC_CR_PLLON ( -- x addr ) 24 bit RCC_CR ; \ RCC_CR_PLLON, PLL enable bit
: RCC_CR_RTCPRE ( %bb -- x addr ) 20 lshift RCC_CR ; \ RCC_CR_RTCPRE, TC/LCD prescaler
: RCC_CR_CSSLSEON ( -- x addr ) 19 bit RCC_CR ; \ RCC_CR_CSSLSEON, Clock security system on HSE enable  bit
: RCC_CR_HSEBYP ( -- x addr ) 18 bit RCC_CR ; \ RCC_CR_HSEBYP, HSE clock bypass bit
: RCC_CR_HSERDY? ( -- 1|0 ) 17 bit RCC_CR bit@ ; \ RCC_CR_HSERDY, HSE clock ready flag
: RCC_CR_HSEON ( -- x addr ) 16 bit RCC_CR ; \ RCC_CR_HSEON, HSE clock enable bit
: RCC_CR_MSIRDY? ( -- 1|0 ) 9 bit RCC_CR bit@ ; \ RCC_CR_MSIRDY, MSI clock ready flag
: RCC_CR_MSION ( -- x addr ) 8 bit RCC_CR ; \ RCC_CR_MSION, MSI clock enable bit
: RCC_CR_HSI16DIVF ( -- x addr ) 4 bit RCC_CR ; \ RCC_CR_HSI16DIVF, HSI16DIVF
: RCC_CR_HSI16DIVEN ( -- x addr ) 3 bit RCC_CR ; \ RCC_CR_HSI16DIVEN, HSI16DIVEN
: RCC_CR_HSI16RDYF? ( -- 1|0 ) 2 bit RCC_CR bit@ ; \ RCC_CR_HSI16RDYF, Internal high-speed clock ready  flag
: RCC_CR_HSI16KERON ( -- x addr ) 1 bit RCC_CR ; \ RCC_CR_HSI16KERON, High-speed internal clock enable bit for  some IP kernels
: RCC_CR_HSI16ON ( -- x addr ) 0 bit RCC_CR ; \ RCC_CR_HSI16ON, 16 MHz high-speed internal clock  enable

\ RCC_ICSCR (multiple-access)  Reset:0x0000B000
: RCC_ICSCR_MSITRIM ( %bbbbbbbb -- x addr ) 24 lshift RCC_ICSCR ; \ RCC_ICSCR_MSITRIM, MSI clock trimming
: RCC_ICSCR_MSICAL ( %bbbbbbbb -- x addr ) 16 lshift RCC_ICSCR ; \ RCC_ICSCR_MSICAL, MSI clock calibration
: RCC_ICSCR_MSIRANGE ( %bbb -- x addr ) 13 lshift RCC_ICSCR ; \ RCC_ICSCR_MSIRANGE, MSI clock ranges
: RCC_ICSCR_HSI16TRIM ( %bbbbb -- x addr ) 8 lshift RCC_ICSCR ; \ RCC_ICSCR_HSI16TRIM, High speed internal clock  trimming
: RCC_ICSCR_HSI16CAL ( %bbbbbbbb -- x addr ) RCC_ICSCR ; \ RCC_ICSCR_HSI16CAL, nternal high speed clock  calibration

\ RCC_CRRCR (multiple-access)  Reset:0x00000000
: RCC_CRRCR_HSI48CAL ( %bbbbbbbb -- x addr ) 8 lshift RCC_CRRCR ; \ RCC_CRRCR_HSI48CAL, 48 MHz HSI clock  calibration
: RCC_CRRCR_HSI48RDY? ( -- 1|0 ) 1 bit RCC_CRRCR bit@ ; \ RCC_CRRCR_HSI48RDY, 48MHz HSI clock ready flag
: RCC_CRRCR_HSI48ON ( -- x addr ) 0 bit RCC_CRRCR ; \ RCC_CRRCR_HSI48ON, 48MHz HSI clock enable bit

\ RCC_CFGR (multiple-access)  Reset:0x00000000
: RCC_CFGR_MCOPRE ( %bbb -- x addr ) 28 lshift RCC_CFGR ; \ RCC_CFGR_MCOPRE, Microcontroller clock output  prescaler
: RCC_CFGR_MCOSEL ( %bbb -- x addr ) 24 lshift RCC_CFGR ; \ RCC_CFGR_MCOSEL, Microcontroller clock output  selection
: RCC_CFGR_PLLDIV ( %bb -- x addr ) 22 lshift RCC_CFGR ; \ RCC_CFGR_PLLDIV, PLL output division
: RCC_CFGR_PLLMUL ( %bbbb -- x addr ) 18 lshift RCC_CFGR ; \ RCC_CFGR_PLLMUL, PLL multiplication factor
: RCC_CFGR_PLLSRC ( -- x addr ) 16 bit RCC_CFGR ; \ RCC_CFGR_PLLSRC, PLL entry clock source
: RCC_CFGR_STOPWUCK ( -- x addr ) 15 bit RCC_CFGR ; \ RCC_CFGR_STOPWUCK, Wake-up from stop clock  selection
: RCC_CFGR_PPRE2 ( %bbb -- x addr ) 11 lshift RCC_CFGR ; \ RCC_CFGR_PPRE2, APB high-speed prescaler  APB2
: RCC_CFGR_PPRE1 ( %bbb -- x addr ) 8 lshift RCC_CFGR ; \ RCC_CFGR_PPRE1, APB low-speed prescaler  APB1
: RCC_CFGR_HPRE ( %bbbb -- x addr ) 4 lshift RCC_CFGR ; \ RCC_CFGR_HPRE, AHB prescaler
: RCC_CFGR_SWS? ( %bb -- 1|0 ) 2 lshift RCC_CFGR bit@ ; \ RCC_CFGR_SWS, System clock switch status
: RCC_CFGR_SW ( %bb -- x addr ) RCC_CFGR ; \ RCC_CFGR_SW, System clock switch

\ RCC_CIER (read-only) Reset:0x00000000
: RCC_CIER_CSSLSE? ( --  1|0 ) 7 bit RCC_CIER bit@ ; \ RCC_CIER_CSSLSE, LSE CSS interrupt flag
: RCC_CIER_HSI48RDYIE? ( --  1|0 ) 6 bit RCC_CIER bit@ ; \ RCC_CIER_HSI48RDYIE, HSI48 ready interrupt flag
: RCC_CIER_MSIRDYIE? ( --  1|0 ) 5 bit RCC_CIER bit@ ; \ RCC_CIER_MSIRDYIE, MSI ready interrupt flag
: RCC_CIER_PLLRDYIE? ( --  1|0 ) 4 bit RCC_CIER bit@ ; \ RCC_CIER_PLLRDYIE, PLL ready interrupt flag
: RCC_CIER_HSERDYIE? ( --  1|0 ) 3 bit RCC_CIER bit@ ; \ RCC_CIER_HSERDYIE, HSE ready interrupt flag
: RCC_CIER_HSI16RDYIE? ( --  1|0 ) 2 bit RCC_CIER bit@ ; \ RCC_CIER_HSI16RDYIE, HSI16 ready interrupt flag
: RCC_CIER_LSERDYIE? ( --  1|0 ) 1 bit RCC_CIER bit@ ; \ RCC_CIER_LSERDYIE, LSE ready interrupt flag
: RCC_CIER_LSIRDYIE? ( --  1|0 ) 0 bit RCC_CIER bit@ ; \ RCC_CIER_LSIRDYIE, LSI ready interrupt flag

\ RCC_CIFR (read-only) Reset:0x00000000
: RCC_CIFR_CSSHSEF? ( --  1|0 ) 8 bit RCC_CIFR bit@ ; \ RCC_CIFR_CSSHSEF, Clock Security System Interrupt  flag
: RCC_CIFR_CSSLSEF? ( --  1|0 ) 7 bit RCC_CIFR bit@ ; \ RCC_CIFR_CSSLSEF, LSE Clock Security System Interrupt  flag
: RCC_CIFR_HSI48RDYF? ( --  1|0 ) 6 bit RCC_CIFR bit@ ; \ RCC_CIFR_HSI48RDYF, HSI48 ready interrupt flag
: RCC_CIFR_MSIRDYF? ( --  1|0 ) 5 bit RCC_CIFR bit@ ; \ RCC_CIFR_MSIRDYF, MSI ready interrupt flag
: RCC_CIFR_PLLRDYF? ( --  1|0 ) 4 bit RCC_CIFR bit@ ; \ RCC_CIFR_PLLRDYF, PLL ready interrupt flag
: RCC_CIFR_HSERDYF? ( --  1|0 ) 3 bit RCC_CIFR bit@ ; \ RCC_CIFR_HSERDYF, HSE ready interrupt flag
: RCC_CIFR_HSI16RDYF? ( --  1|0 ) 2 bit RCC_CIFR bit@ ; \ RCC_CIFR_HSI16RDYF, HSI16 ready interrupt flag
: RCC_CIFR_LSERDYF? ( --  1|0 ) 1 bit RCC_CIFR bit@ ; \ RCC_CIFR_LSERDYF, LSE ready interrupt flag
: RCC_CIFR_LSIRDYF? ( --  1|0 ) 0 bit RCC_CIFR bit@ ; \ RCC_CIFR_LSIRDYF, LSI ready interrupt flag

\ RCC_CICR (read-only) Reset:0x00000000
: RCC_CICR_CSSHSEC? ( --  1|0 ) 8 bit RCC_CICR bit@ ; \ RCC_CICR_CSSHSEC, Clock Security System Interrupt  clear
: RCC_CICR_CSSLSEC? ( --  1|0 ) 7 bit RCC_CICR bit@ ; \ RCC_CICR_CSSLSEC, LSE Clock Security System Interrupt  clear
: RCC_CICR_HSI48RDYC? ( --  1|0 ) 6 bit RCC_CICR bit@ ; \ RCC_CICR_HSI48RDYC, HSI48 ready Interrupt  clear
: RCC_CICR_MSIRDYC? ( --  1|0 ) 5 bit RCC_CICR bit@ ; \ RCC_CICR_MSIRDYC, MSI ready Interrupt clear
: RCC_CICR_PLLRDYC? ( --  1|0 ) 4 bit RCC_CICR bit@ ; \ RCC_CICR_PLLRDYC, PLL ready Interrupt clear
: RCC_CICR_HSERDYC? ( --  1|0 ) 3 bit RCC_CICR bit@ ; \ RCC_CICR_HSERDYC, HSE ready Interrupt clear
: RCC_CICR_HSI16RDYC? ( --  1|0 ) 2 bit RCC_CICR bit@ ; \ RCC_CICR_HSI16RDYC, HSI16 ready Interrupt  clear
: RCC_CICR_LSERDYC? ( --  1|0 ) 1 bit RCC_CICR bit@ ; \ RCC_CICR_LSERDYC, LSE ready Interrupt clear
: RCC_CICR_LSIRDYC? ( --  1|0 ) 0 bit RCC_CICR bit@ ; \ RCC_CICR_LSIRDYC, LSI ready Interrupt clear

\ RCC_IOPRSTR (read-write) Reset:0x00000000
: RCC_IOPRSTR_IOPHRST ( -- x addr ) 7 bit RCC_IOPRSTR ; \ RCC_IOPRSTR_IOPHRST, I/O port H reset
: RCC_IOPRSTR_IOPDRST ( -- x addr ) 3 bit RCC_IOPRSTR ; \ RCC_IOPRSTR_IOPDRST, I/O port D reset
: RCC_IOPRSTR_IOPCRST ( -- x addr ) 2 bit RCC_IOPRSTR ; \ RCC_IOPRSTR_IOPCRST, I/O port A reset
: RCC_IOPRSTR_IOPBRST ( -- x addr ) 1 bit RCC_IOPRSTR ; \ RCC_IOPRSTR_IOPBRST, I/O port B reset
: RCC_IOPRSTR_IOPARST ( -- x addr ) 0 bit RCC_IOPRSTR ; \ RCC_IOPRSTR_IOPARST, I/O port A reset

\ RCC_AHBRSTR (read-write) Reset:0x00000000
: RCC_AHBRSTR_CRYPRST ( -- x addr ) 24 bit RCC_AHBRSTR ; \ RCC_AHBRSTR_CRYPRST, Crypto module reset
: RCC_AHBRSTR_RNGRST ( -- x addr ) 20 bit RCC_AHBRSTR ; \ RCC_AHBRSTR_RNGRST, Random Number Generator module  reset
: RCC_AHBRSTR_TOUCHRST ( -- x addr ) 16 bit RCC_AHBRSTR ; \ RCC_AHBRSTR_TOUCHRST, Touch Sensing reset
: RCC_AHBRSTR_CRCRST ( -- x addr ) 12 bit RCC_AHBRSTR ; \ RCC_AHBRSTR_CRCRST, Test integration module  reset
: RCC_AHBRSTR_MIFRST ( -- x addr ) 8 bit RCC_AHBRSTR ; \ RCC_AHBRSTR_MIFRST, Memory interface reset
: RCC_AHBRSTR_DMARST ( -- x addr ) 0 bit RCC_AHBRSTR ; \ RCC_AHBRSTR_DMARST, DMA reset

\ RCC_APB2RSTR (read-write) Reset:0x000000000
: RCC_APB2RSTR_DBGRST ( -- x addr ) 22 bit RCC_APB2RSTR ; \ RCC_APB2RSTR_DBGRST, DBG reset
: RCC_APB2RSTR_USART1RST ( -- x addr ) 14 bit RCC_APB2RSTR ; \ RCC_APB2RSTR_USART1RST, USART1 reset
: RCC_APB2RSTR_SPI1RST ( -- x addr ) 12 bit RCC_APB2RSTR ; \ RCC_APB2RSTR_SPI1RST, SPI 1 reset
: RCC_APB2RSTR_ADCRST ( -- x addr ) 9 bit RCC_APB2RSTR ; \ RCC_APB2RSTR_ADCRST, ADC interface reset
: RCC_APB2RSTR_TM12RST ( -- x addr ) 5 bit RCC_APB2RSTR ; \ RCC_APB2RSTR_TM12RST, TIM22 timer reset
: RCC_APB2RSTR_TIM21RST ( -- x addr ) 2 bit RCC_APB2RSTR ; \ RCC_APB2RSTR_TIM21RST, TIM21 timer reset
: RCC_APB2RSTR_SYSCFGRST ( -- x addr ) 0 bit RCC_APB2RSTR ; \ RCC_APB2RSTR_SYSCFGRST, System configuration controller  reset

\ RCC_APB1RSTR (read-write) Reset:0x00000000
: RCC_APB1RSTR_LPTIM1RST ( -- x addr ) 31 bit RCC_APB1RSTR ; \ RCC_APB1RSTR_LPTIM1RST, Low power timer reset
: RCC_APB1RSTR_DACRST ( -- x addr ) 29 bit RCC_APB1RSTR ; \ RCC_APB1RSTR_DACRST, DAC interface reset
: RCC_APB1RSTR_PWRRST ( -- x addr ) 28 bit RCC_APB1RSTR ; \ RCC_APB1RSTR_PWRRST, Power interface reset
: RCC_APB1RSTR_CRSRST ( -- x addr ) 27 bit RCC_APB1RSTR ; \ RCC_APB1RSTR_CRSRST, Clock recovery system  reset
: RCC_APB1RSTR_USBRST ( -- x addr ) 23 bit RCC_APB1RSTR ; \ RCC_APB1RSTR_USBRST, USB reset
: RCC_APB1RSTR_I2C2RST ( -- x addr ) 22 bit RCC_APB1RSTR ; \ RCC_APB1RSTR_I2C2RST, I2C2 reset
: RCC_APB1RSTR_I2C1RST ( -- x addr ) 21 bit RCC_APB1RSTR ; \ RCC_APB1RSTR_I2C1RST, I2C1 reset
: RCC_APB1RSTR_LPUART1RST ( -- x addr ) 18 bit RCC_APB1RSTR ; \ RCC_APB1RSTR_LPUART1RST, LPUART1 reset
: RCC_APB1RSTR_LPUART12RST ( -- x addr ) 17 bit RCC_APB1RSTR ; \ RCC_APB1RSTR_LPUART12RST, UART2 reset
: RCC_APB1RSTR_SPI2RST ( -- x addr ) 14 bit RCC_APB1RSTR ; \ RCC_APB1RSTR_SPI2RST, SPI2 reset
: RCC_APB1RSTR_WWDRST ( -- x addr ) 11 bit RCC_APB1RSTR ; \ RCC_APB1RSTR_WWDRST, Window watchdog reset
: RCC_APB1RSTR_LCDRST ( -- x addr ) 9 bit RCC_APB1RSTR ; \ RCC_APB1RSTR_LCDRST, LCD reset
: RCC_APB1RSTR_TIM6RST ( -- x addr ) 4 bit RCC_APB1RSTR ; \ RCC_APB1RSTR_TIM6RST, Timer 6 reset
: RCC_APB1RSTR_TIM2RST ( -- x addr ) 0 bit RCC_APB1RSTR ; \ RCC_APB1RSTR_TIM2RST, Timer2 reset

\ RCC_IOPENR (read-write) Reset:0x00000000
: RCC_IOPENR_IOPHEN ( -- x addr ) 7 bit RCC_IOPENR ; \ RCC_IOPENR_IOPHEN, I/O port H clock enable  bit
: RCC_IOPENR_IOPDEN ( -- x addr ) 3 bit RCC_IOPENR ; \ RCC_IOPENR_IOPDEN, I/O port D clock enable  bit
: RCC_IOPENR_IOPCEN ( -- x addr ) 2 bit RCC_IOPENR ; \ RCC_IOPENR_IOPCEN, IO port A clock enable bit
: RCC_IOPENR_IOPBEN ( -- x addr ) 1 bit RCC_IOPENR ; \ RCC_IOPENR_IOPBEN, IO port B clock enable bit
: RCC_IOPENR_IOPAEN ( -- x addr ) 0 bit RCC_IOPENR ; \ RCC_IOPENR_IOPAEN, IO port A clock enable bit

\ RCC_AHBENR (read-write) Reset:0x00000100
: RCC_AHBENR_CRYPEN ( -- x addr ) 24 bit RCC_AHBENR ; \ RCC_AHBENR_CRYPEN, Crypto clock enable bit
: RCC_AHBENR_RNGEN ( -- x addr ) 20 bit RCC_AHBENR ; \ RCC_AHBENR_RNGEN, Random Number Generator clock enable  bit
: RCC_AHBENR_TOUCHEN ( -- x addr ) 16 bit RCC_AHBENR ; \ RCC_AHBENR_TOUCHEN, Touch Sensing clock enable  bit
: RCC_AHBENR_CRCEN ( -- x addr ) 12 bit RCC_AHBENR ; \ RCC_AHBENR_CRCEN, CRC clock enable bit
: RCC_AHBENR_MIFEN ( -- x addr ) 8 bit RCC_AHBENR ; \ RCC_AHBENR_MIFEN, NVM interface clock enable  bit
: RCC_AHBENR_DMAEN ( -- x addr ) 0 bit RCC_AHBENR ; \ RCC_AHBENR_DMAEN, DMA clock enable bit

\ RCC_APB2ENR (read-write) Reset:0x00000000
: RCC_APB2ENR_DBGEN ( -- x addr ) 22 bit RCC_APB2ENR ; \ RCC_APB2ENR_DBGEN, DBG clock enable bit
: RCC_APB2ENR_USART1EN ( -- x addr ) 14 bit RCC_APB2ENR ; \ RCC_APB2ENR_USART1EN, USART1 clock enable bit
: RCC_APB2ENR_SPI1EN ( -- x addr ) 12 bit RCC_APB2ENR ; \ RCC_APB2ENR_SPI1EN, SPI1 clock enable bit
: RCC_APB2ENR_ADCEN ( -- x addr ) 9 bit RCC_APB2ENR ; \ RCC_APB2ENR_ADCEN, ADC clock enable bit
: RCC_APB2ENR_MIFIEN ( -- x addr ) 7 bit RCC_APB2ENR ; \ RCC_APB2ENR_MIFIEN, MiFaRe Firewall clock enable  bit
: RCC_APB2ENR_TIM22EN ( -- x addr ) 5 bit RCC_APB2ENR ; \ RCC_APB2ENR_TIM22EN, TIM22 timer clock enable  bit
: RCC_APB2ENR_TIM21EN ( -- x addr ) 2 bit RCC_APB2ENR ; \ RCC_APB2ENR_TIM21EN, TIM21 timer clock enable  bit
: RCC_APB2ENR_SYSCFGEN ( -- x addr ) 0 bit RCC_APB2ENR ; \ RCC_APB2ENR_SYSCFGEN, System configuration controller clock  enable bit

\ RCC_APB1ENR (read-write) Reset:0x00000000
: RCC_APB1ENR_LPTIM1EN ( -- x addr ) 31 bit RCC_APB1ENR ; \ RCC_APB1ENR_LPTIM1EN, Low power timer clock enable  bit
: RCC_APB1ENR_DACEN ( -- x addr ) 29 bit RCC_APB1ENR ; \ RCC_APB1ENR_DACEN, DAC interface clock enable  bit
: RCC_APB1ENR_PWREN ( -- x addr ) 28 bit RCC_APB1ENR ; \ RCC_APB1ENR_PWREN, Power interface clock enable  bit
: RCC_APB1ENR_CRSEN ( -- x addr ) 27 bit RCC_APB1ENR ; \ RCC_APB1ENR_CRSEN, Clock recovery system clock enable  bit
: RCC_APB1ENR_USBEN ( -- x addr ) 23 bit RCC_APB1ENR ; \ RCC_APB1ENR_USBEN, USB clock enable bit
: RCC_APB1ENR_I2C2EN ( -- x addr ) 22 bit RCC_APB1ENR ; \ RCC_APB1ENR_I2C2EN, I2C2 clock enable bit
: RCC_APB1ENR_I2C1EN ( -- x addr ) 21 bit RCC_APB1ENR ; \ RCC_APB1ENR_I2C1EN, I2C1 clock enable bit
: RCC_APB1ENR_LPUART1EN ( -- x addr ) 18 bit RCC_APB1ENR ; \ RCC_APB1ENR_LPUART1EN, LPUART1 clock enable bit
: RCC_APB1ENR_USART2EN ( -- x addr ) 17 bit RCC_APB1ENR ; \ RCC_APB1ENR_USART2EN, UART2 clock enable bit
: RCC_APB1ENR_SPI2EN ( -- x addr ) 14 bit RCC_APB1ENR ; \ RCC_APB1ENR_SPI2EN, SPI2 clock enable bit
: RCC_APB1ENR_WWDGEN ( -- x addr ) 11 bit RCC_APB1ENR ; \ RCC_APB1ENR_WWDGEN, Window watchdog clock enable  bit
: RCC_APB1ENR_LCDEN ( -- x addr ) 9 bit RCC_APB1ENR ; \ RCC_APB1ENR_LCDEN, LCD clock enable bit
: RCC_APB1ENR_TIM6EN ( -- x addr ) 4 bit RCC_APB1ENR ; \ RCC_APB1ENR_TIM6EN, Timer 6 clock enable bit
: RCC_APB1ENR_TIM2EN ( -- x addr ) 0 bit RCC_APB1ENR ; \ RCC_APB1ENR_TIM2EN, Timer2 clock enable bit

\ RCC_IOPSMEN (read-write) Reset:0x0000008F
: RCC_IOPSMEN_IOPHSMEN ( -- x addr ) 7 bit RCC_IOPSMEN ; \ RCC_IOPSMEN_IOPHSMEN, IOPHSMEN
: RCC_IOPSMEN_IOPDSMEN ( -- x addr ) 3 bit RCC_IOPSMEN ; \ RCC_IOPSMEN_IOPDSMEN, IOPDSMEN
: RCC_IOPSMEN_IOPCSMEN ( -- x addr ) 2 bit RCC_IOPSMEN ; \ RCC_IOPSMEN_IOPCSMEN, IOPCSMEN
: RCC_IOPSMEN_IOPBSMEN ( -- x addr ) 1 bit RCC_IOPSMEN ; \ RCC_IOPSMEN_IOPBSMEN, IOPBSMEN
: RCC_IOPSMEN_IOPASMEN ( -- x addr ) 0 bit RCC_IOPSMEN ; \ RCC_IOPSMEN_IOPASMEN, IOPASMEN

\ RCC_AHBSMENR (read-write) Reset:0x01111301
: RCC_AHBSMENR_CRYPSMEN ( -- x addr ) 24 bit RCC_AHBSMENR ; \ RCC_AHBSMENR_CRYPSMEN, Crypto clock enable during sleep mode  bit
: RCC_AHBSMENR_RNGSMEN ( -- x addr ) 20 bit RCC_AHBSMENR ; \ RCC_AHBSMENR_RNGSMEN, Random Number Generator clock enable  during sleep mode bit
: RCC_AHBSMENR_TOUCHSMEN ( -- x addr ) 16 bit RCC_AHBSMENR ; \ RCC_AHBSMENR_TOUCHSMEN, Touch Sensing clock enable during sleep  mode bit
: RCC_AHBSMENR_CRCSMEN ( -- x addr ) 12 bit RCC_AHBSMENR ; \ RCC_AHBSMENR_CRCSMEN, CRC clock enable during sleep mode  bit
: RCC_AHBSMENR_SRAMSMEN ( -- x addr ) 9 bit RCC_AHBSMENR ; \ RCC_AHBSMENR_SRAMSMEN, SRAM interface clock enable during sleep  mode bit
: RCC_AHBSMENR_MIFSMEN ( -- x addr ) 8 bit RCC_AHBSMENR ; \ RCC_AHBSMENR_MIFSMEN, NVM interface clock enable during sleep  mode bit
: RCC_AHBSMENR_DMASMEN ( -- x addr ) 0 bit RCC_AHBSMENR ; \ RCC_AHBSMENR_DMASMEN, DMA clock enable during sleep mode  bit

\ RCC_APB2SMENR (read-write) Reset:0x00405225
: RCC_APB2SMENR_DBGSMEN ( -- x addr ) 22 bit RCC_APB2SMENR ; \ RCC_APB2SMENR_DBGSMEN, DBG clock enable during sleep mode  bit
: RCC_APB2SMENR_USART1SMEN ( -- x addr ) 14 bit RCC_APB2SMENR ; \ RCC_APB2SMENR_USART1SMEN, USART1 clock enable during sleep mode  bit
: RCC_APB2SMENR_SPI1SMEN ( -- x addr ) 12 bit RCC_APB2SMENR ; \ RCC_APB2SMENR_SPI1SMEN, SPI1 clock enable during sleep mode  bit
: RCC_APB2SMENR_ADCSMEN ( -- x addr ) 9 bit RCC_APB2SMENR ; \ RCC_APB2SMENR_ADCSMEN, ADC clock enable during sleep mode  bit
: RCC_APB2SMENR_TIM22SMEN ( -- x addr ) 5 bit RCC_APB2SMENR ; \ RCC_APB2SMENR_TIM22SMEN, TIM22 timer clock enable during sleep  mode bit
: RCC_APB2SMENR_TIM21SMEN ( -- x addr ) 2 bit RCC_APB2SMENR ; \ RCC_APB2SMENR_TIM21SMEN, TIM21 timer clock enable during sleep  mode bit
: RCC_APB2SMENR_SYSCFGSMEN ( -- x addr ) 0 bit RCC_APB2SMENR ; \ RCC_APB2SMENR_SYSCFGSMEN, System configuration controller clock  enable during sleep mode bit

\ RCC_APB1SMENR (read-write) Reset:0xB8E64A11
: RCC_APB1SMENR_LPTIM1SMEN ( -- x addr ) 31 bit RCC_APB1SMENR ; \ RCC_APB1SMENR_LPTIM1SMEN, Low power timer clock enable during  sleep mode bit
: RCC_APB1SMENR_DACSMEN ( -- x addr ) 29 bit RCC_APB1SMENR ; \ RCC_APB1SMENR_DACSMEN, DAC interface clock enable during sleep  mode bit
: RCC_APB1SMENR_PWRSMEN ( -- x addr ) 28 bit RCC_APB1SMENR ; \ RCC_APB1SMENR_PWRSMEN, Power interface clock enable during  sleep mode bit
: RCC_APB1SMENR_CRSSMEN ( -- x addr ) 27 bit RCC_APB1SMENR ; \ RCC_APB1SMENR_CRSSMEN, Clock recovery system clock enable  during sleep mode bit
: RCC_APB1SMENR_USBSMEN ( -- x addr ) 23 bit RCC_APB1SMENR ; \ RCC_APB1SMENR_USBSMEN, USB clock enable during sleep mode  bit
: RCC_APB1SMENR_I2C2SMEN ( -- x addr ) 22 bit RCC_APB1SMENR ; \ RCC_APB1SMENR_I2C2SMEN, I2C2 clock enable during sleep mode  bit
: RCC_APB1SMENR_I2C1SMEN ( -- x addr ) 21 bit RCC_APB1SMENR ; \ RCC_APB1SMENR_I2C1SMEN, I2C1 clock enable during sleep mode  bit
: RCC_APB1SMENR_LPUART1SMEN ( -- x addr ) 18 bit RCC_APB1SMENR ; \ RCC_APB1SMENR_LPUART1SMEN, LPUART1 clock enable during sleep mode  bit
: RCC_APB1SMENR_USART2SMEN ( -- x addr ) 17 bit RCC_APB1SMENR ; \ RCC_APB1SMENR_USART2SMEN, UART2 clock enable during sleep mode  bit
: RCC_APB1SMENR_SPI2SMEN ( -- x addr ) 14 bit RCC_APB1SMENR ; \ RCC_APB1SMENR_SPI2SMEN, SPI2 clock enable during sleep mode  bit
: RCC_APB1SMENR_WWDGSMEN ( -- x addr ) 11 bit RCC_APB1SMENR ; \ RCC_APB1SMENR_WWDGSMEN, Window watchdog clock enable during  sleep mode bit
: RCC_APB1SMENR_LCDSMEN ( -- x addr ) 9 bit RCC_APB1SMENR ; \ RCC_APB1SMENR_LCDSMEN, LCD clock enable during sleep mode  bit
: RCC_APB1SMENR_TIM6SMEN ( -- x addr ) 4 bit RCC_APB1SMENR ; \ RCC_APB1SMENR_TIM6SMEN, Timer 6 clock enable during sleep mode  bit
: RCC_APB1SMENR_TIM2SMEN ( -- x addr ) 0 bit RCC_APB1SMENR ; \ RCC_APB1SMENR_TIM2SMEN, Timer2 clock enable during sleep mode  bit

\ RCC_CCIPR (read-write) Reset:0x00000000
: RCC_CCIPR_HSI48MSEL ( -- x addr ) 26 bit RCC_CCIPR ; \ RCC_CCIPR_HSI48MSEL, 48 MHz HSI48 clock source selection  bit
: RCC_CCIPR_LPTIM1SEL1 ( -- x addr ) 19 bit RCC_CCIPR ; \ RCC_CCIPR_LPTIM1SEL1, Low Power Timer clock source selection  bits
: RCC_CCIPR_LPTIM1SEL0 ( -- x addr ) 18 bit RCC_CCIPR ; \ RCC_CCIPR_LPTIM1SEL0, LPTIM1SEL0
: RCC_CCIPR_I2C1SEL1 ( -- x addr ) 13 bit RCC_CCIPR ; \ RCC_CCIPR_I2C1SEL1, I2C1 clock source selection  bits
: RCC_CCIPR_I2C1SEL0 ( -- x addr ) 12 bit RCC_CCIPR ; \ RCC_CCIPR_I2C1SEL0, I2C1SEL0
: RCC_CCIPR_LPUART1SEL1 ( -- x addr ) 11 bit RCC_CCIPR ; \ RCC_CCIPR_LPUART1SEL1, LPUART1 clock source selection  bits
: RCC_CCIPR_LPUART1SEL0 ( -- x addr ) 10 bit RCC_CCIPR ; \ RCC_CCIPR_LPUART1SEL0, LPUART1SEL0
: RCC_CCIPR_USART2SEL1 ( -- x addr ) 3 bit RCC_CCIPR ; \ RCC_CCIPR_USART2SEL1, USART2 clock source selection  bits
: RCC_CCIPR_USART2SEL0 ( -- x addr ) 2 bit RCC_CCIPR ; \ RCC_CCIPR_USART2SEL0, USART2SEL0
: RCC_CCIPR_USART1SEL1 ( -- x addr ) 1 bit RCC_CCIPR ; \ RCC_CCIPR_USART1SEL1, USART1 clock source selection  bits
: RCC_CCIPR_USART1SEL0 ( -- x addr ) 0 bit RCC_CCIPR ; \ RCC_CCIPR_USART1SEL0, USART1SEL0

\ RCC_CSR (multiple-access)  Reset:0x0C000000
: RCC_CSR_LPWRSTF? ( -- 1|0 ) 31 bit RCC_CSR bit@ ; \ RCC_CSR_LPWRSTF, Low-power reset flag
: RCC_CSR_WWDGRSTF? ( -- 1|0 ) 30 bit RCC_CSR bit@ ; \ RCC_CSR_WWDGRSTF, Window watchdog reset flag
: RCC_CSR_IWDGRSTF? ( -- 1|0 ) 29 bit RCC_CSR bit@ ; \ RCC_CSR_IWDGRSTF, Independent watchdog reset  flag
: RCC_CSR_SFTRSTF? ( -- 1|0 ) 28 bit RCC_CSR bit@ ; \ RCC_CSR_SFTRSTF, Software reset flag
: RCC_CSR_PORRSTF? ( -- 1|0 ) 27 bit RCC_CSR bit@ ; \ RCC_CSR_PORRSTF, POR/PDR reset flag
: RCC_CSR_PINRSTF? ( -- 1|0 ) 26 bit RCC_CSR bit@ ; \ RCC_CSR_PINRSTF, PIN reset flag
: RCC_CSR_OBLRSTF ( -- x addr ) 25 bit RCC_CSR ; \ RCC_CSR_OBLRSTF, OBLRSTF
: RCC_CSR_RMVF? ( -- 1|0 ) 24 bit RCC_CSR bit@ ; \ RCC_CSR_RMVF, Remove reset flag
: RCC_CSR_RTCRST ( -- x addr ) 19 bit RCC_CSR ; \ RCC_CSR_RTCRST, RTC software reset bit
: RCC_CSR_RTCEN ( -- x addr ) 18 bit RCC_CSR ; \ RCC_CSR_RTCEN, RTC clock enable bit
: RCC_CSR_RTCSEL ( %bb -- x addr ) 16 lshift RCC_CSR ; \ RCC_CSR_RTCSEL, RTC and LCD clock source selection  bits
: RCC_CSR_CSSLSED? ( -- 1|0 ) 14 bit RCC_CSR bit@ ; \ RCC_CSR_CSSLSED, CSS on LSE failure detection  flag
: RCC_CSR_CSSLSEON ( -- x addr ) 13 bit RCC_CSR ; \ RCC_CSR_CSSLSEON, CSSLSEON
: RCC_CSR_LSEDRV ( %bb -- x addr ) 11 lshift RCC_CSR ; \ RCC_CSR_LSEDRV, LSEDRV
: RCC_CSR_LSEBYP ( -- x addr ) 10 bit RCC_CSR ; \ RCC_CSR_LSEBYP, External low-speed oscillator bypass  bit
: RCC_CSR_LSERDY ( -- x addr ) 9 bit RCC_CSR ; \ RCC_CSR_LSERDY, External low-speed oscillator ready  bit
: RCC_CSR_LSEON ( -- x addr ) 8 bit RCC_CSR ; \ RCC_CSR_LSEON, External low-speed oscillator enable  bit
: RCC_CSR_LSIRDY ( -- x addr ) 1 bit RCC_CSR ; \ RCC_CSR_LSIRDY, Internal low-speed oscillator ready  bit
: RCC_CSR_LSION ( -- x addr ) 0 bit RCC_CSR ; \ RCC_CSR_LSION, Internal low-speed oscillator  enable

\ SYSCFG_CFGR1 (multiple-access)  Reset:0x00000000
: SYSCFG_CFGR1_BOOT_MODE? ( %bb -- 1|0 ) 8 lshift SYSCFG_CFGR1 bit@ ; \ SYSCFG_CFGR1_BOOT_MODE, Boot mode selected by the boot pins  status bits
: SYSCFG_CFGR1_MEM_MODE ( %bb -- x addr ) SYSCFG_CFGR1 ; \ SYSCFG_CFGR1_MEM_MODE, Memory mapping selection  bits

\ SYSCFG_CFGR2 (read-write) Reset:0x00000000
: SYSCFG_CFGR2_I2C2_FMP ( -- x addr ) 13 bit SYSCFG_CFGR2 ; \ SYSCFG_CFGR2_I2C2_FMP, I2C2 Fm+ drive capability enable  bit
: SYSCFG_CFGR2_I2C1_FMP ( -- x addr ) 12 bit SYSCFG_CFGR2 ; \ SYSCFG_CFGR2_I2C1_FMP, I2C1 Fm+ drive capability enable  bit
: SYSCFG_CFGR2_I2C_PB9_FMP ( -- x addr ) 11 bit SYSCFG_CFGR2 ; \ SYSCFG_CFGR2_I2C_PB9_FMP, Fm+ drive capability on PB9 enable  bit
: SYSCFG_CFGR2_I2C_PB8_FMP ( -- x addr ) 10 bit SYSCFG_CFGR2 ; \ SYSCFG_CFGR2_I2C_PB8_FMP, Fm+ drive capability on PB8 enable  bit
: SYSCFG_CFGR2_I2C_PB7_FMP ( -- x addr ) 9 bit SYSCFG_CFGR2 ; \ SYSCFG_CFGR2_I2C_PB7_FMP, Fm+ drive capability on PB7 enable  bit
: SYSCFG_CFGR2_I2C_PB6_FMP ( -- x addr ) 8 bit SYSCFG_CFGR2 ; \ SYSCFG_CFGR2_I2C_PB6_FMP, Fm+ drive capability on PB6 enable  bit
: SYSCFG_CFGR2_CAPA ( %bbb -- x addr ) 1 lshift SYSCFG_CFGR2 ; \ SYSCFG_CFGR2_CAPA, Configuration of internal VLCD rail  connection to optional external  capacitor
: SYSCFG_CFGR2_FWDISEN ( -- x addr ) 0 bit SYSCFG_CFGR2 ; \ SYSCFG_CFGR2_FWDISEN, Firewall disable bit

\ SYSCFG_EXTICR1 (read-write) Reset:0x0000
: SYSCFG_EXTICR1_EXTI3 ( %bbbb -- x addr ) 12 lshift SYSCFG_EXTICR1 ; \ SYSCFG_EXTICR1_EXTI3, EXTI x configuration x = 0 to  3
: SYSCFG_EXTICR1_EXTI2 ( %bbbb -- x addr ) 8 lshift SYSCFG_EXTICR1 ; \ SYSCFG_EXTICR1_EXTI2, EXTI x configuration x = 0 to  3
: SYSCFG_EXTICR1_EXTI1 ( %bbbb -- x addr ) 4 lshift SYSCFG_EXTICR1 ; \ SYSCFG_EXTICR1_EXTI1, EXTI x configuration x = 0 to  3
: SYSCFG_EXTICR1_EXTI0 ( %bbbb -- x addr ) SYSCFG_EXTICR1 ; \ SYSCFG_EXTICR1_EXTI0, EXTI x configuration x = 0 to  3

\ SYSCFG_EXTICR2 (read-write) Reset:0x0000
: SYSCFG_EXTICR2_EXTI7 ( %bbbb -- x addr ) 12 lshift SYSCFG_EXTICR2 ; \ SYSCFG_EXTICR2_EXTI7, EXTI x configuration x = 4 to  7
: SYSCFG_EXTICR2_EXTI6 ( %bbbb -- x addr ) 8 lshift SYSCFG_EXTICR2 ; \ SYSCFG_EXTICR2_EXTI6, EXTI x configuration x = 4 to  7
: SYSCFG_EXTICR2_EXTI5 ( %bbbb -- x addr ) 4 lshift SYSCFG_EXTICR2 ; \ SYSCFG_EXTICR2_EXTI5, EXTI x configuration x = 4 to  7
: SYSCFG_EXTICR2_EXTI4 ( %bbbb -- x addr ) SYSCFG_EXTICR2 ; \ SYSCFG_EXTICR2_EXTI4, EXTI x configuration x = 4 to  7

\ SYSCFG_EXTICR3 (read-write) Reset:0x0000
: SYSCFG_EXTICR3_EXTI11 ( %bbbb -- x addr ) 12 lshift SYSCFG_EXTICR3 ; \ SYSCFG_EXTICR3_EXTI11, EXTI x configuration x = 8 to  11
: SYSCFG_EXTICR3_EXTI10 ( %bbbb -- x addr ) 8 lshift SYSCFG_EXTICR3 ; \ SYSCFG_EXTICR3_EXTI10, EXTI10
: SYSCFG_EXTICR3_EXTI9 ( %bbbb -- x addr ) 4 lshift SYSCFG_EXTICR3 ; \ SYSCFG_EXTICR3_EXTI9, EXTI x configuration x = 8 to  11
: SYSCFG_EXTICR3_EXTI8 ( %bbbb -- x addr ) SYSCFG_EXTICR3 ; \ SYSCFG_EXTICR3_EXTI8, EXTI x configuration x = 8 to  11

\ SYSCFG_EXTICR4 (read-write) Reset:0x0000
: SYSCFG_EXTICR4_EXTI15 ( %bbbb -- x addr ) 12 lshift SYSCFG_EXTICR4 ; \ SYSCFG_EXTICR4_EXTI15, EXTI x configuration x = 12 to  15
: SYSCFG_EXTICR4_EXTI14 ( %bbbb -- x addr ) 8 lshift SYSCFG_EXTICR4 ; \ SYSCFG_EXTICR4_EXTI14, EXTI14
: SYSCFG_EXTICR4_EXTI13 ( %bbbb -- x addr ) 4 lshift SYSCFG_EXTICR4 ; \ SYSCFG_EXTICR4_EXTI13, EXTI13
: SYSCFG_EXTICR4_EXTI12 ( %bbbb -- x addr ) SYSCFG_EXTICR4 ; \ SYSCFG_EXTICR4_EXTI12, EXTI12

\ SYSCFG_CFGR3 (multiple-access)  Reset:0x00000000
: SYSCFG_CFGR3_REF_LOCK ( -- x addr ) 31 bit SYSCFG_CFGR3 ; \ SYSCFG_CFGR3_REF_LOCK, REF_CTRL lock bit
: SYSCFG_CFGR3_VREFINT_RDYF? ( -- 1|0 ) 30 bit SYSCFG_CFGR3 bit@ ; \ SYSCFG_CFGR3_VREFINT_RDYF, VREFINT ready flag
: SYSCFG_CFGR3_VREFINT_COMP_RDYF? ( -- 1|0 ) 29 bit SYSCFG_CFGR3 bit@ ; \ SYSCFG_CFGR3_VREFINT_COMP_RDYF, VREFINT for comparator ready  flag
: SYSCFG_CFGR3_VREFINT_ADC_RDYF? ( -- 1|0 ) 28 bit SYSCFG_CFGR3 bit@ ; \ SYSCFG_CFGR3_VREFINT_ADC_RDYF, VREFINT for ADC ready flag
: SYSCFG_CFGR3_SENSOR_ADC_RDYF? ( -- 1|0 ) 27 bit SYSCFG_CFGR3 bit@ ; \ SYSCFG_CFGR3_SENSOR_ADC_RDYF, Sensor for ADC ready flag
: SYSCFG_CFGR3_REF_RC48MHz_RDYF? ( -- 1|0 ) 26 bit SYSCFG_CFGR3 bit@ ; \ SYSCFG_CFGR3_REF_RC48MHz_RDYF, VREFINT for 48 MHz RC oscillator ready  flag
: SYSCFG_CFGR3_ENREF_RC48MHz ( -- x addr ) 13 bit SYSCFG_CFGR3 ; \ SYSCFG_CFGR3_ENREF_RC48MHz, VREFINT reference for 48 MHz RC  oscillator enable bit
: SYSCFG_CFGR3_ENBUF_VREFINT_COMP ( -- x addr ) 12 bit SYSCFG_CFGR3 ; \ SYSCFG_CFGR3_ENBUF_VREFINT_COMP, VREFINT reference for comparator 2  enable bit
: SYSCFG_CFGR3_ENBUF_SENSOR_ADC ( -- x addr ) 9 bit SYSCFG_CFGR3 ; \ SYSCFG_CFGR3_ENBUF_SENSOR_ADC, Sensor reference for ADC enable  bit
: SYSCFG_CFGR3_ENBUF_BGAP_ADC ( -- x addr ) 8 bit SYSCFG_CFGR3 ; \ SYSCFG_CFGR3_ENBUF_BGAP_ADC, VREFINT reference for ADC enable  bit
: SYSCFG_CFGR3_SEL_VREF_OUT ( %bb -- x addr ) 4 lshift SYSCFG_CFGR3 ; \ SYSCFG_CFGR3_SEL_VREF_OUT, BGAP_ADC connection bit
: SYSCFG_CFGR3_EN_BGAP ( -- x addr ) 0 bit SYSCFG_CFGR3 ; \ SYSCFG_CFGR3_EN_BGAP, Vref Enable bit

\ SPI1_CR1 (read-write) Reset:0x0000
: SPI1_CR1_BIDIMODE ( -- x addr ) 15 bit SPI1_CR1 ; \ SPI1_CR1_BIDIMODE, Bidirectional data mode  enable
: SPI1_CR1_BIDIOE ( -- x addr ) 14 bit SPI1_CR1 ; \ SPI1_CR1_BIDIOE, Output enable in bidirectional  mode
: SPI1_CR1_CRCEN ( -- x addr ) 13 bit SPI1_CR1 ; \ SPI1_CR1_CRCEN, Hardware CRC calculation  enable
: SPI1_CR1_CRCNEXT ( -- x addr ) 12 bit SPI1_CR1 ; \ SPI1_CR1_CRCNEXT, CRC transfer next
: SPI1_CR1_DFF ( -- x addr ) 11 bit SPI1_CR1 ; \ SPI1_CR1_DFF, Data frame format
: SPI1_CR1_RXONLY ( -- x addr ) 10 bit SPI1_CR1 ; \ SPI1_CR1_RXONLY, Receive only
: SPI1_CR1_SSM ( -- x addr ) 9 bit SPI1_CR1 ; \ SPI1_CR1_SSM, Software slave management
: SPI1_CR1_SSI ( -- x addr ) 8 bit SPI1_CR1 ; \ SPI1_CR1_SSI, Internal slave select
: SPI1_CR1_LSBFIRST ( -- x addr ) 7 bit SPI1_CR1 ; \ SPI1_CR1_LSBFIRST, Frame format
: SPI1_CR1_SPE ( -- x addr ) 6 bit SPI1_CR1 ; \ SPI1_CR1_SPE, SPI enable
: SPI1_CR1_BR ( %bbb -- x addr ) 3 lshift SPI1_CR1 ; \ SPI1_CR1_BR, Baud rate control
: SPI1_CR1_MSTR ( -- x addr ) 2 bit SPI1_CR1 ; \ SPI1_CR1_MSTR, Master selection
: SPI1_CR1_CPOL ( -- x addr ) 1 bit SPI1_CR1 ; \ SPI1_CR1_CPOL, Clock polarity
: SPI1_CR1_CPHA ( -- x addr ) 0 bit SPI1_CR1 ; \ SPI1_CR1_CPHA, Clock phase

\ SPI1_CR2 (read-write) Reset:0x0000
: SPI1_CR2_RXDMAEN ( -- x addr ) 0 bit SPI1_CR2 ; \ SPI1_CR2_RXDMAEN, Rx buffer DMA enable
: SPI1_CR2_TXDMAEN ( -- x addr ) 1 bit SPI1_CR2 ; \ SPI1_CR2_TXDMAEN, Tx buffer DMA enable
: SPI1_CR2_SSOE ( -- x addr ) 2 bit SPI1_CR2 ; \ SPI1_CR2_SSOE, SS output enable
: SPI1_CR2_FRF ( -- x addr ) 4 bit SPI1_CR2 ; \ SPI1_CR2_FRF, Frame format
: SPI1_CR2_ERRIE ( -- x addr ) 5 bit SPI1_CR2 ; \ SPI1_CR2_ERRIE, Error interrupt enable
: SPI1_CR2_RXNEIE ( -- x addr ) 6 bit SPI1_CR2 ; \ SPI1_CR2_RXNEIE, RX buffer not empty interrupt  enable
: SPI1_CR2_TXEIE ( -- x addr ) 7 bit SPI1_CR2 ; \ SPI1_CR2_TXEIE, Tx buffer empty interrupt  enable

\ SPI1_SR (multiple-access)  Reset:0x0002
: SPI1_SR_RXNE ( -- x addr ) 0 bit SPI1_SR ; \ SPI1_SR_RXNE, Receive buffer not empty
: SPI1_SR_TXE ( -- x addr ) 1 bit SPI1_SR ; \ SPI1_SR_TXE, Transmit buffer empty
: SPI1_SR_CHSIDE ( -- x addr ) 2 bit SPI1_SR ; \ SPI1_SR_CHSIDE, Channel side
: SPI1_SR_UDR? ( -- 1|0 ) 3 bit SPI1_SR bit@ ; \ SPI1_SR_UDR, Underrun flag
: SPI1_SR_CRCERR? ( -- 1|0 ) 4 bit SPI1_SR bit@ ; \ SPI1_SR_CRCERR, CRC error flag
: SPI1_SR_MODF ( -- x addr ) 5 bit SPI1_SR ; \ SPI1_SR_MODF, Mode fault
: SPI1_SR_OVR? ( -- 1|0 ) 6 bit SPI1_SR bit@ ; \ SPI1_SR_OVR, Overrun flag
: SPI1_SR_BSY? ( -- 1|0 ) 7 bit SPI1_SR bit@ ; \ SPI1_SR_BSY, Busy flag
: SPI1_SR_TIFRFE ( -- x addr ) 8 bit SPI1_SR ; \ SPI1_SR_TIFRFE, TI frame format error

\ SPI1_DR (read-write) Reset:0x0000
: SPI1_DR_DR ( %bbbbbbbbbbbbbbbb -- x addr ) SPI1_DR ; \ SPI1_DR_DR, Data register

\ SPI1_CRCPR (read-write) Reset:0x0007
: SPI1_CRCPR_CRCPOLY ( %bbbbbbbbbbbbbbbb -- x addr ) SPI1_CRCPR ; \ SPI1_CRCPR_CRCPOLY, CRC polynomial register

\ SPI1_RXCRCR (read-only) Reset:0x0000
: SPI1_RXCRCR_RxCRC? ( --  x ) SPI1_RXCRCR @ ; \ SPI1_RXCRCR_RxCRC, Rx CRC register

\ SPI1_TXCRCR (read-only) Reset:0x0000
: SPI1_TXCRCR_TxCRC? ( --  x ) SPI1_TXCRCR @ ; \ SPI1_TXCRCR_TxCRC, Tx CRC register

\ SPI1_I2SCFGR (read-write) Reset:0x0000
: SPI1_I2SCFGR_I2SMOD ( -- x addr ) 11 bit SPI1_I2SCFGR ; \ SPI1_I2SCFGR_I2SMOD, I2S mode selection
: SPI1_I2SCFGR_I2SE ( -- x addr ) 10 bit SPI1_I2SCFGR ; \ SPI1_I2SCFGR_I2SE, I2S Enable
: SPI1_I2SCFGR_I2SCFG ( %bb -- x addr ) 8 lshift SPI1_I2SCFGR ; \ SPI1_I2SCFGR_I2SCFG, I2S configuration mode
: SPI1_I2SCFGR_PCMSYNC ( -- x addr ) 7 bit SPI1_I2SCFGR ; \ SPI1_I2SCFGR_PCMSYNC, PCM frame synchronization
: SPI1_I2SCFGR_I2SSTD ( %bb -- x addr ) 4 lshift SPI1_I2SCFGR ; \ SPI1_I2SCFGR_I2SSTD, I2S standard selection
: SPI1_I2SCFGR_CKPOL ( -- x addr ) 3 bit SPI1_I2SCFGR ; \ SPI1_I2SCFGR_CKPOL, Steady state clock  polarity
: SPI1_I2SCFGR_DATLEN ( %bb -- x addr ) 1 lshift SPI1_I2SCFGR ; \ SPI1_I2SCFGR_DATLEN, Data length to be  transferred
: SPI1_I2SCFGR_CHLEN ( -- x addr ) 0 bit SPI1_I2SCFGR ; \ SPI1_I2SCFGR_CHLEN, Channel length number of bits per audio  channel

\ SPI1_I2SPR (read-write) Reset:0x00000010
: SPI1_I2SPR_MCKOE ( -- x addr ) 9 bit SPI1_I2SPR ; \ SPI1_I2SPR_MCKOE, Master clock output enable
: SPI1_I2SPR_ODD ( -- x addr ) 8 bit SPI1_I2SPR ; \ SPI1_I2SPR_ODD, Odd factor for the  prescaler
: SPI1_I2SPR_I2SDIV ( %bbbbbbbb -- x addr ) SPI1_I2SPR ; \ SPI1_I2SPR_I2SDIV, I2S Linear prescaler

\ SPI2_CR1 (read-write) Reset:0x0000
: SPI2_CR1_BIDIMODE ( -- x addr ) 15 bit SPI2_CR1 ; \ SPI2_CR1_BIDIMODE, Bidirectional data mode  enable
: SPI2_CR1_BIDIOE ( -- x addr ) 14 bit SPI2_CR1 ; \ SPI2_CR1_BIDIOE, Output enable in bidirectional  mode
: SPI2_CR1_CRCEN ( -- x addr ) 13 bit SPI2_CR1 ; \ SPI2_CR1_CRCEN, Hardware CRC calculation  enable
: SPI2_CR1_CRCNEXT ( -- x addr ) 12 bit SPI2_CR1 ; \ SPI2_CR1_CRCNEXT, CRC transfer next
: SPI2_CR1_DFF ( -- x addr ) 11 bit SPI2_CR1 ; \ SPI2_CR1_DFF, Data frame format
: SPI2_CR1_RXONLY ( -- x addr ) 10 bit SPI2_CR1 ; \ SPI2_CR1_RXONLY, Receive only
: SPI2_CR1_SSM ( -- x addr ) 9 bit SPI2_CR1 ; \ SPI2_CR1_SSM, Software slave management
: SPI2_CR1_SSI ( -- x addr ) 8 bit SPI2_CR1 ; \ SPI2_CR1_SSI, Internal slave select
: SPI2_CR1_LSBFIRST ( -- x addr ) 7 bit SPI2_CR1 ; \ SPI2_CR1_LSBFIRST, Frame format
: SPI2_CR1_SPE ( -- x addr ) 6 bit SPI2_CR1 ; \ SPI2_CR1_SPE, SPI enable
: SPI2_CR1_BR ( %bbb -- x addr ) 3 lshift SPI2_CR1 ; \ SPI2_CR1_BR, Baud rate control
: SPI2_CR1_MSTR ( -- x addr ) 2 bit SPI2_CR1 ; \ SPI2_CR1_MSTR, Master selection
: SPI2_CR1_CPOL ( -- x addr ) 1 bit SPI2_CR1 ; \ SPI2_CR1_CPOL, Clock polarity
: SPI2_CR1_CPHA ( -- x addr ) 0 bit SPI2_CR1 ; \ SPI2_CR1_CPHA, Clock phase

\ SPI2_CR2 (read-write) Reset:0x0000
: SPI2_CR2_RXDMAEN ( -- x addr ) 0 bit SPI2_CR2 ; \ SPI2_CR2_RXDMAEN, Rx buffer DMA enable
: SPI2_CR2_TXDMAEN ( -- x addr ) 1 bit SPI2_CR2 ; \ SPI2_CR2_TXDMAEN, Tx buffer DMA enable
: SPI2_CR2_SSOE ( -- x addr ) 2 bit SPI2_CR2 ; \ SPI2_CR2_SSOE, SS output enable
: SPI2_CR2_FRF ( -- x addr ) 4 bit SPI2_CR2 ; \ SPI2_CR2_FRF, Frame format
: SPI2_CR2_ERRIE ( -- x addr ) 5 bit SPI2_CR2 ; \ SPI2_CR2_ERRIE, Error interrupt enable
: SPI2_CR2_RXNEIE ( -- x addr ) 6 bit SPI2_CR2 ; \ SPI2_CR2_RXNEIE, RX buffer not empty interrupt  enable
: SPI2_CR2_TXEIE ( -- x addr ) 7 bit SPI2_CR2 ; \ SPI2_CR2_TXEIE, Tx buffer empty interrupt  enable

\ SPI2_SR (multiple-access)  Reset:0x0002
: SPI2_SR_RXNE ( -- x addr ) 0 bit SPI2_SR ; \ SPI2_SR_RXNE, Receive buffer not empty
: SPI2_SR_TXE ( -- x addr ) 1 bit SPI2_SR ; \ SPI2_SR_TXE, Transmit buffer empty
: SPI2_SR_CHSIDE ( -- x addr ) 2 bit SPI2_SR ; \ SPI2_SR_CHSIDE, Channel side
: SPI2_SR_UDR? ( -- 1|0 ) 3 bit SPI2_SR bit@ ; \ SPI2_SR_UDR, Underrun flag
: SPI2_SR_CRCERR? ( -- 1|0 ) 4 bit SPI2_SR bit@ ; \ SPI2_SR_CRCERR, CRC error flag
: SPI2_SR_MODF ( -- x addr ) 5 bit SPI2_SR ; \ SPI2_SR_MODF, Mode fault
: SPI2_SR_OVR? ( -- 1|0 ) 6 bit SPI2_SR bit@ ; \ SPI2_SR_OVR, Overrun flag
: SPI2_SR_BSY? ( -- 1|0 ) 7 bit SPI2_SR bit@ ; \ SPI2_SR_BSY, Busy flag
: SPI2_SR_TIFRFE ( -- x addr ) 8 bit SPI2_SR ; \ SPI2_SR_TIFRFE, TI frame format error

\ SPI2_DR (read-write) Reset:0x0000
: SPI2_DR_DR ( %bbbbbbbbbbbbbbbb -- x addr ) SPI2_DR ; \ SPI2_DR_DR, Data register

\ SPI2_CRCPR (read-write) Reset:0x0007
: SPI2_CRCPR_CRCPOLY ( %bbbbbbbbbbbbbbbb -- x addr ) SPI2_CRCPR ; \ SPI2_CRCPR_CRCPOLY, CRC polynomial register

\ SPI2_RXCRCR (read-only) Reset:0x0000
: SPI2_RXCRCR_RxCRC? ( --  x ) SPI2_RXCRCR @ ; \ SPI2_RXCRCR_RxCRC, Rx CRC register

\ SPI2_TXCRCR (read-only) Reset:0x0000
: SPI2_TXCRCR_TxCRC? ( --  x ) SPI2_TXCRCR @ ; \ SPI2_TXCRCR_TxCRC, Tx CRC register

\ SPI2_I2SCFGR (read-write) Reset:0x0000
: SPI2_I2SCFGR_I2SMOD ( -- x addr ) 11 bit SPI2_I2SCFGR ; \ SPI2_I2SCFGR_I2SMOD, I2S mode selection
: SPI2_I2SCFGR_I2SE ( -- x addr ) 10 bit SPI2_I2SCFGR ; \ SPI2_I2SCFGR_I2SE, I2S Enable
: SPI2_I2SCFGR_I2SCFG ( %bb -- x addr ) 8 lshift SPI2_I2SCFGR ; \ SPI2_I2SCFGR_I2SCFG, I2S configuration mode
: SPI2_I2SCFGR_PCMSYNC ( -- x addr ) 7 bit SPI2_I2SCFGR ; \ SPI2_I2SCFGR_PCMSYNC, PCM frame synchronization
: SPI2_I2SCFGR_I2SSTD ( %bb -- x addr ) 4 lshift SPI2_I2SCFGR ; \ SPI2_I2SCFGR_I2SSTD, I2S standard selection
: SPI2_I2SCFGR_CKPOL ( -- x addr ) 3 bit SPI2_I2SCFGR ; \ SPI2_I2SCFGR_CKPOL, Steady state clock  polarity
: SPI2_I2SCFGR_DATLEN ( %bb -- x addr ) 1 lshift SPI2_I2SCFGR ; \ SPI2_I2SCFGR_DATLEN, Data length to be  transferred
: SPI2_I2SCFGR_CHLEN ( -- x addr ) 0 bit SPI2_I2SCFGR ; \ SPI2_I2SCFGR_CHLEN, Channel length number of bits per audio  channel

\ SPI2_I2SPR (read-write) Reset:0x00000010
: SPI2_I2SPR_MCKOE ( -- x addr ) 9 bit SPI2_I2SPR ; \ SPI2_I2SPR_MCKOE, Master clock output enable
: SPI2_I2SPR_ODD ( -- x addr ) 8 bit SPI2_I2SPR ; \ SPI2_I2SPR_ODD, Odd factor for the  prescaler
: SPI2_I2SPR_I2SDIV ( %bbbbbbbb -- x addr ) SPI2_I2SPR ; \ SPI2_I2SPR_I2SDIV, I2S Linear prescaler

\ I2C1_CR1 (read-write) Reset:0x00000000
: I2C1_CR1_PE ( -- x addr ) 0 bit I2C1_CR1 ; \ I2C1_CR1_PE, Peripheral enable
: I2C1_CR1_TXIE ( -- x addr ) 1 bit I2C1_CR1 ; \ I2C1_CR1_TXIE, TX Interrupt enable
: I2C1_CR1_RXIE ( -- x addr ) 2 bit I2C1_CR1 ; \ I2C1_CR1_RXIE, RX Interrupt enable
: I2C1_CR1_ADDRIE ( -- x addr ) 3 bit I2C1_CR1 ; \ I2C1_CR1_ADDRIE, Address match interrupt enable slave  only
: I2C1_CR1_NACKIE ( -- x addr ) 4 bit I2C1_CR1 ; \ I2C1_CR1_NACKIE, Not acknowledge received interrupt  enable
: I2C1_CR1_STOPIE ( -- x addr ) 5 bit I2C1_CR1 ; \ I2C1_CR1_STOPIE, STOP detection Interrupt  enable
: I2C1_CR1_TCIE ( -- x addr ) 6 bit I2C1_CR1 ; \ I2C1_CR1_TCIE, Transfer Complete interrupt  enable
: I2C1_CR1_ERRIE ( -- x addr ) 7 bit I2C1_CR1 ; \ I2C1_CR1_ERRIE, Error interrupts enable
: I2C1_CR1_DNF ( %bbbb -- x addr ) 8 lshift I2C1_CR1 ; \ I2C1_CR1_DNF, Digital noise filter
: I2C1_CR1_ANFOFF ( -- x addr ) 12 bit I2C1_CR1 ; \ I2C1_CR1_ANFOFF, Analog noise filter OFF
: I2C1_CR1_TXDMAEN ( -- x addr ) 14 bit I2C1_CR1 ; \ I2C1_CR1_TXDMAEN, DMA transmission requests  enable
: I2C1_CR1_RXDMAEN ( -- x addr ) 15 bit I2C1_CR1 ; \ I2C1_CR1_RXDMAEN, DMA reception requests  enable
: I2C1_CR1_SBC ( -- x addr ) 16 bit I2C1_CR1 ; \ I2C1_CR1_SBC, Slave byte control
: I2C1_CR1_NOSTRETCH ( -- x addr ) 17 bit I2C1_CR1 ; \ I2C1_CR1_NOSTRETCH, Clock stretching disable
: I2C1_CR1_WUPEN ( -- x addr ) 18 bit I2C1_CR1 ; \ I2C1_CR1_WUPEN, Wakeup from STOP enable
: I2C1_CR1_GCEN ( -- x addr ) 19 bit I2C1_CR1 ; \ I2C1_CR1_GCEN, General call enable
: I2C1_CR1_SMBHEN ( -- x addr ) 20 bit I2C1_CR1 ; \ I2C1_CR1_SMBHEN, SMBus Host address enable
: I2C1_CR1_SMBDEN ( -- x addr ) 21 bit I2C1_CR1 ; \ I2C1_CR1_SMBDEN, SMBus Device Default address  enable
: I2C1_CR1_ALERTEN ( -- x addr ) 22 bit I2C1_CR1 ; \ I2C1_CR1_ALERTEN, SMBUS alert enable
: I2C1_CR1_PECEN ( -- x addr ) 23 bit I2C1_CR1 ; \ I2C1_CR1_PECEN, PEC enable

\ I2C1_CR2 (read-write) Reset:0x00000000
: I2C1_CR2_PECBYTE ( -- x addr ) 26 bit I2C1_CR2 ; \ I2C1_CR2_PECBYTE, Packet error checking byte
: I2C1_CR2_AUTOEND ( -- x addr ) 25 bit I2C1_CR2 ; \ I2C1_CR2_AUTOEND, Automatic end mode master  mode
: I2C1_CR2_RELOAD ( -- x addr ) 24 bit I2C1_CR2 ; \ I2C1_CR2_RELOAD, NBYTES reload mode
: I2C1_CR2_NBYTES ( %bbbbbbbb -- x addr ) 16 lshift I2C1_CR2 ; \ I2C1_CR2_NBYTES, Number of bytes
: I2C1_CR2_NACK ( -- x addr ) 15 bit I2C1_CR2 ; \ I2C1_CR2_NACK, NACK generation slave  mode
: I2C1_CR2_STOP ( -- x addr ) 14 bit I2C1_CR2 ; \ I2C1_CR2_STOP, Stop generation master  mode
: I2C1_CR2_START ( -- x addr ) 13 bit I2C1_CR2 ; \ I2C1_CR2_START, Start generation
: I2C1_CR2_HEAD10R ( -- x addr ) 12 bit I2C1_CR2 ; \ I2C1_CR2_HEAD10R, 10-bit address header only read  direction master receiver mode
: I2C1_CR2_ADD10 ( -- x addr ) 11 bit I2C1_CR2 ; \ I2C1_CR2_ADD10, 10-bit addressing mode master  mode
: I2C1_CR2_RD_WRN ( -- x addr ) 10 bit I2C1_CR2 ; \ I2C1_CR2_RD_WRN, Transfer direction master  mode
: I2C1_CR2_SADD ( %bbbbbbbbbb -- x addr ) I2C1_CR2 ; \ I2C1_CR2_SADD, Slave address bit master  mode

\ I2C1_OAR1 (read-write) Reset:0x00000000
: I2C1_OAR1_OA1 ( %bbbbbbbbbb -- x addr ) I2C1_OAR1 ; \ I2C1_OAR1_OA1, Interface address
: I2C1_OAR1_OA1MODE ( -- x addr ) 10 bit I2C1_OAR1 ; \ I2C1_OAR1_OA1MODE, Own Address 1 10-bit mode
: I2C1_OAR1_OA1EN ( -- x addr ) 15 bit I2C1_OAR1 ; \ I2C1_OAR1_OA1EN, Own Address 1 enable

\ I2C1_OAR2 (read-write) Reset:0x00000000
: I2C1_OAR2_OA2 ( %bbbbbbb -- x addr ) 1 lshift I2C1_OAR2 ; \ I2C1_OAR2_OA2, Interface address
: I2C1_OAR2_OA2MSK ( %bbb -- x addr ) 8 lshift I2C1_OAR2 ; \ I2C1_OAR2_OA2MSK, Own Address 2 masks
: I2C1_OAR2_OA2EN ( -- x addr ) 15 bit I2C1_OAR2 ; \ I2C1_OAR2_OA2EN, Own Address 2 enable

\ I2C1_TIMINGR (read-write) Reset:0x00000000
: I2C1_TIMINGR_SCLL ( %bbbbbbbb -- x addr ) I2C1_TIMINGR ; \ I2C1_TIMINGR_SCLL, SCL low period master  mode
: I2C1_TIMINGR_SCLH ( %bbbbbbbb -- x addr ) 8 lshift I2C1_TIMINGR ; \ I2C1_TIMINGR_SCLH, SCL high period master  mode
: I2C1_TIMINGR_SDADEL ( %bbbb -- x addr ) 16 lshift I2C1_TIMINGR ; \ I2C1_TIMINGR_SDADEL, Data hold time
: I2C1_TIMINGR_SCLDEL ( %bbbb -- x addr ) 20 lshift I2C1_TIMINGR ; \ I2C1_TIMINGR_SCLDEL, Data setup time
: I2C1_TIMINGR_PRESC ( %bbbb -- x addr ) 28 lshift I2C1_TIMINGR ; \ I2C1_TIMINGR_PRESC, Timing prescaler

\ I2C1_TIMEOUTR (read-write) Reset:0x00000000
: I2C1_TIMEOUTR_TIMEOUTA ( %bbbbbbbbbbb -- x addr ) I2C1_TIMEOUTR ; \ I2C1_TIMEOUTR_TIMEOUTA, Bus timeout A
: I2C1_TIMEOUTR_TIDLE ( -- x addr ) 12 bit I2C1_TIMEOUTR ; \ I2C1_TIMEOUTR_TIDLE, Idle clock timeout  detection
: I2C1_TIMEOUTR_TIMOUTEN ( -- x addr ) 15 bit I2C1_TIMEOUTR ; \ I2C1_TIMEOUTR_TIMOUTEN, Clock timeout enable
: I2C1_TIMEOUTR_TIMEOUTB ( %bbbbbbbbbbb -- x addr ) 16 lshift I2C1_TIMEOUTR ; \ I2C1_TIMEOUTR_TIMEOUTB, Bus timeout B
: I2C1_TIMEOUTR_TEXTEN ( -- x addr ) 31 bit I2C1_TIMEOUTR ; \ I2C1_TIMEOUTR_TEXTEN, Extended clock timeout  enable

\ I2C1_ISR (multiple-access)  Reset:0x00000001
: I2C1_ISR_ADDCODE ( %bbbbbbb -- x addr ) 17 lshift I2C1_ISR ; \ I2C1_ISR_ADDCODE, Address match code Slave  mode
: I2C1_ISR_DIR ( -- x addr ) 16 bit I2C1_ISR ; \ I2C1_ISR_DIR, Transfer direction Slave  mode
: I2C1_ISR_BUSY ( -- x addr ) 15 bit I2C1_ISR ; \ I2C1_ISR_BUSY, Bus busy
: I2C1_ISR_ALERT ( -- x addr ) 13 bit I2C1_ISR ; \ I2C1_ISR_ALERT, SMBus alert
: I2C1_ISR_TIMEOUT? ( -- 1|0 ) 12 bit I2C1_ISR bit@ ; \ I2C1_ISR_TIMEOUT, Timeout or t_low detection  flag
: I2C1_ISR_PECERR ( -- x addr ) 11 bit I2C1_ISR ; \ I2C1_ISR_PECERR, PEC Error in reception
: I2C1_ISR_OVR ( -- x addr ) 10 bit I2C1_ISR ; \ I2C1_ISR_OVR, Overrun/Underrun slave  mode
: I2C1_ISR_ARLO ( -- x addr ) 9 bit I2C1_ISR ; \ I2C1_ISR_ARLO, Arbitration lost
: I2C1_ISR_BERR ( -- x addr ) 8 bit I2C1_ISR ; \ I2C1_ISR_BERR, Bus error
: I2C1_ISR_TCR ( -- x addr ) 7 bit I2C1_ISR ; \ I2C1_ISR_TCR, Transfer Complete Reload
: I2C1_ISR_TC ( -- x addr ) 6 bit I2C1_ISR ; \ I2C1_ISR_TC, Transfer Complete master  mode
: I2C1_ISR_STOPF? ( -- 1|0 ) 5 bit I2C1_ISR bit@ ; \ I2C1_ISR_STOPF, Stop detection flag
: I2C1_ISR_NACKF? ( -- 1|0 ) 4 bit I2C1_ISR bit@ ; \ I2C1_ISR_NACKF, Not acknowledge received  flag
: I2C1_ISR_ADDR ( -- x addr ) 3 bit I2C1_ISR ; \ I2C1_ISR_ADDR, Address matched slave  mode
: I2C1_ISR_RXNE ( -- x addr ) 2 bit I2C1_ISR ; \ I2C1_ISR_RXNE, Receive data register not empty  receivers
: I2C1_ISR_TXIS? ( -- 1|0 ) 1 bit I2C1_ISR bit@ ; \ I2C1_ISR_TXIS, Transmit interrupt status  transmitters
: I2C1_ISR_TXE ( -- x addr ) 0 bit I2C1_ISR ; \ I2C1_ISR_TXE, Transmit data register empty  transmitters

\ I2C1_ICR (write-only) Reset:0x00000000
: I2C1_ICR_ALERTCF ( -- x addr ) 13 bit I2C1_ICR ; \ I2C1_ICR_ALERTCF, Alert flag clear
: I2C1_ICR_TIMOUTCF ( -- x addr ) 12 bit I2C1_ICR ; \ I2C1_ICR_TIMOUTCF, Timeout detection flag  clear
: I2C1_ICR_PECCF ( -- x addr ) 11 bit I2C1_ICR ; \ I2C1_ICR_PECCF, PEC Error flag clear
: I2C1_ICR_OVRCF ( -- x addr ) 10 bit I2C1_ICR ; \ I2C1_ICR_OVRCF, Overrun/Underrun flag  clear
: I2C1_ICR_ARLOCF ( -- x addr ) 9 bit I2C1_ICR ; \ I2C1_ICR_ARLOCF, Arbitration lost flag  clear
: I2C1_ICR_BERRCF ( -- x addr ) 8 bit I2C1_ICR ; \ I2C1_ICR_BERRCF, Bus error flag clear
: I2C1_ICR_STOPCF ( -- x addr ) 5 bit I2C1_ICR ; \ I2C1_ICR_STOPCF, Stop detection flag clear
: I2C1_ICR_NACKCF ( -- x addr ) 4 bit I2C1_ICR ; \ I2C1_ICR_NACKCF, Not Acknowledge flag clear
: I2C1_ICR_ADDRCF ( -- x addr ) 3 bit I2C1_ICR ; \ I2C1_ICR_ADDRCF, Address Matched flag clear

\ I2C1_PECR (read-only) Reset:0x00000000
: I2C1_PECR_PEC? ( --  x ) I2C1_PECR @ ; \ I2C1_PECR_PEC, Packet error checking  register

\ I2C1_RXDR (read-only) Reset:0x00000000
: I2C1_RXDR_RXDATA? ( --  x ) I2C1_RXDR @ ; \ I2C1_RXDR_RXDATA, 8-bit receive data

\ I2C1_TXDR (read-write) Reset:0x00000000
: I2C1_TXDR_TXDATA ( %bbbbbbbb -- x addr ) I2C1_TXDR ; \ I2C1_TXDR_TXDATA, 8-bit transmit data

\ I2C2_CR1 (read-write) Reset:0x00000000
: I2C2_CR1_PE ( -- x addr ) 0 bit I2C2_CR1 ; \ I2C2_CR1_PE, Peripheral enable
: I2C2_CR1_TXIE ( -- x addr ) 1 bit I2C2_CR1 ; \ I2C2_CR1_TXIE, TX Interrupt enable
: I2C2_CR1_RXIE ( -- x addr ) 2 bit I2C2_CR1 ; \ I2C2_CR1_RXIE, RX Interrupt enable
: I2C2_CR1_ADDRIE ( -- x addr ) 3 bit I2C2_CR1 ; \ I2C2_CR1_ADDRIE, Address match interrupt enable slave  only
: I2C2_CR1_NACKIE ( -- x addr ) 4 bit I2C2_CR1 ; \ I2C2_CR1_NACKIE, Not acknowledge received interrupt  enable
: I2C2_CR1_STOPIE ( -- x addr ) 5 bit I2C2_CR1 ; \ I2C2_CR1_STOPIE, STOP detection Interrupt  enable
: I2C2_CR1_TCIE ( -- x addr ) 6 bit I2C2_CR1 ; \ I2C2_CR1_TCIE, Transfer Complete interrupt  enable
: I2C2_CR1_ERRIE ( -- x addr ) 7 bit I2C2_CR1 ; \ I2C2_CR1_ERRIE, Error interrupts enable
: I2C2_CR1_DNF ( %bbbb -- x addr ) 8 lshift I2C2_CR1 ; \ I2C2_CR1_DNF, Digital noise filter
: I2C2_CR1_ANFOFF ( -- x addr ) 12 bit I2C2_CR1 ; \ I2C2_CR1_ANFOFF, Analog noise filter OFF
: I2C2_CR1_TXDMAEN ( -- x addr ) 14 bit I2C2_CR1 ; \ I2C2_CR1_TXDMAEN, DMA transmission requests  enable
: I2C2_CR1_RXDMAEN ( -- x addr ) 15 bit I2C2_CR1 ; \ I2C2_CR1_RXDMAEN, DMA reception requests  enable
: I2C2_CR1_SBC ( -- x addr ) 16 bit I2C2_CR1 ; \ I2C2_CR1_SBC, Slave byte control
: I2C2_CR1_NOSTRETCH ( -- x addr ) 17 bit I2C2_CR1 ; \ I2C2_CR1_NOSTRETCH, Clock stretching disable
: I2C2_CR1_WUPEN ( -- x addr ) 18 bit I2C2_CR1 ; \ I2C2_CR1_WUPEN, Wakeup from STOP enable
: I2C2_CR1_GCEN ( -- x addr ) 19 bit I2C2_CR1 ; \ I2C2_CR1_GCEN, General call enable
: I2C2_CR1_SMBHEN ( -- x addr ) 20 bit I2C2_CR1 ; \ I2C2_CR1_SMBHEN, SMBus Host address enable
: I2C2_CR1_SMBDEN ( -- x addr ) 21 bit I2C2_CR1 ; \ I2C2_CR1_SMBDEN, SMBus Device Default address  enable
: I2C2_CR1_ALERTEN ( -- x addr ) 22 bit I2C2_CR1 ; \ I2C2_CR1_ALERTEN, SMBUS alert enable
: I2C2_CR1_PECEN ( -- x addr ) 23 bit I2C2_CR1 ; \ I2C2_CR1_PECEN, PEC enable

\ I2C2_CR2 (read-write) Reset:0x00000000
: I2C2_CR2_PECBYTE ( -- x addr ) 26 bit I2C2_CR2 ; \ I2C2_CR2_PECBYTE, Packet error checking byte
: I2C2_CR2_AUTOEND ( -- x addr ) 25 bit I2C2_CR2 ; \ I2C2_CR2_AUTOEND, Automatic end mode master  mode
: I2C2_CR2_RELOAD ( -- x addr ) 24 bit I2C2_CR2 ; \ I2C2_CR2_RELOAD, NBYTES reload mode
: I2C2_CR2_NBYTES ( %bbbbbbbb -- x addr ) 16 lshift I2C2_CR2 ; \ I2C2_CR2_NBYTES, Number of bytes
: I2C2_CR2_NACK ( -- x addr ) 15 bit I2C2_CR2 ; \ I2C2_CR2_NACK, NACK generation slave  mode
: I2C2_CR2_STOP ( -- x addr ) 14 bit I2C2_CR2 ; \ I2C2_CR2_STOP, Stop generation master  mode
: I2C2_CR2_START ( -- x addr ) 13 bit I2C2_CR2 ; \ I2C2_CR2_START, Start generation
: I2C2_CR2_HEAD10R ( -- x addr ) 12 bit I2C2_CR2 ; \ I2C2_CR2_HEAD10R, 10-bit address header only read  direction master receiver mode
: I2C2_CR2_ADD10 ( -- x addr ) 11 bit I2C2_CR2 ; \ I2C2_CR2_ADD10, 10-bit addressing mode master  mode
: I2C2_CR2_RD_WRN ( -- x addr ) 10 bit I2C2_CR2 ; \ I2C2_CR2_RD_WRN, Transfer direction master  mode
: I2C2_CR2_SADD ( %bbbbbbbbbb -- x addr ) I2C2_CR2 ; \ I2C2_CR2_SADD, Slave address bit master  mode

\ I2C2_OAR1 (read-write) Reset:0x00000000
: I2C2_OAR1_OA1 ( %bbbbbbbbbb -- x addr ) I2C2_OAR1 ; \ I2C2_OAR1_OA1, Interface address
: I2C2_OAR1_OA1MODE ( -- x addr ) 10 bit I2C2_OAR1 ; \ I2C2_OAR1_OA1MODE, Own Address 1 10-bit mode
: I2C2_OAR1_OA1EN ( -- x addr ) 15 bit I2C2_OAR1 ; \ I2C2_OAR1_OA1EN, Own Address 1 enable

\ I2C2_OAR2 (read-write) Reset:0x00000000
: I2C2_OAR2_OA2 ( %bbbbbbb -- x addr ) 1 lshift I2C2_OAR2 ; \ I2C2_OAR2_OA2, Interface address
: I2C2_OAR2_OA2MSK ( %bbb -- x addr ) 8 lshift I2C2_OAR2 ; \ I2C2_OAR2_OA2MSK, Own Address 2 masks
: I2C2_OAR2_OA2EN ( -- x addr ) 15 bit I2C2_OAR2 ; \ I2C2_OAR2_OA2EN, Own Address 2 enable

\ I2C2_TIMINGR (read-write) Reset:0x00000000
: I2C2_TIMINGR_SCLL ( %bbbbbbbb -- x addr ) I2C2_TIMINGR ; \ I2C2_TIMINGR_SCLL, SCL low period master  mode
: I2C2_TIMINGR_SCLH ( %bbbbbbbb -- x addr ) 8 lshift I2C2_TIMINGR ; \ I2C2_TIMINGR_SCLH, SCL high period master  mode
: I2C2_TIMINGR_SDADEL ( %bbbb -- x addr ) 16 lshift I2C2_TIMINGR ; \ I2C2_TIMINGR_SDADEL, Data hold time
: I2C2_TIMINGR_SCLDEL ( %bbbb -- x addr ) 20 lshift I2C2_TIMINGR ; \ I2C2_TIMINGR_SCLDEL, Data setup time
: I2C2_TIMINGR_PRESC ( %bbbb -- x addr ) 28 lshift I2C2_TIMINGR ; \ I2C2_TIMINGR_PRESC, Timing prescaler

\ I2C2_TIMEOUTR (read-write) Reset:0x00000000
: I2C2_TIMEOUTR_TIMEOUTA ( %bbbbbbbbbbb -- x addr ) I2C2_TIMEOUTR ; \ I2C2_TIMEOUTR_TIMEOUTA, Bus timeout A
: I2C2_TIMEOUTR_TIDLE ( -- x addr ) 12 bit I2C2_TIMEOUTR ; \ I2C2_TIMEOUTR_TIDLE, Idle clock timeout  detection
: I2C2_TIMEOUTR_TIMOUTEN ( -- x addr ) 15 bit I2C2_TIMEOUTR ; \ I2C2_TIMEOUTR_TIMOUTEN, Clock timeout enable
: I2C2_TIMEOUTR_TIMEOUTB ( %bbbbbbbbbbb -- x addr ) 16 lshift I2C2_TIMEOUTR ; \ I2C2_TIMEOUTR_TIMEOUTB, Bus timeout B
: I2C2_TIMEOUTR_TEXTEN ( -- x addr ) 31 bit I2C2_TIMEOUTR ; \ I2C2_TIMEOUTR_TEXTEN, Extended clock timeout  enable

\ I2C2_ISR (multiple-access)  Reset:0x00000001
: I2C2_ISR_ADDCODE ( %bbbbbbb -- x addr ) 17 lshift I2C2_ISR ; \ I2C2_ISR_ADDCODE, Address match code Slave  mode
: I2C2_ISR_DIR ( -- x addr ) 16 bit I2C2_ISR ; \ I2C2_ISR_DIR, Transfer direction Slave  mode
: I2C2_ISR_BUSY ( -- x addr ) 15 bit I2C2_ISR ; \ I2C2_ISR_BUSY, Bus busy
: I2C2_ISR_ALERT ( -- x addr ) 13 bit I2C2_ISR ; \ I2C2_ISR_ALERT, SMBus alert
: I2C2_ISR_TIMEOUT? ( -- 1|0 ) 12 bit I2C2_ISR bit@ ; \ I2C2_ISR_TIMEOUT, Timeout or t_low detection  flag
: I2C2_ISR_PECERR ( -- x addr ) 11 bit I2C2_ISR ; \ I2C2_ISR_PECERR, PEC Error in reception
: I2C2_ISR_OVR ( -- x addr ) 10 bit I2C2_ISR ; \ I2C2_ISR_OVR, Overrun/Underrun slave  mode
: I2C2_ISR_ARLO ( -- x addr ) 9 bit I2C2_ISR ; \ I2C2_ISR_ARLO, Arbitration lost
: I2C2_ISR_BERR ( -- x addr ) 8 bit I2C2_ISR ; \ I2C2_ISR_BERR, Bus error
: I2C2_ISR_TCR ( -- x addr ) 7 bit I2C2_ISR ; \ I2C2_ISR_TCR, Transfer Complete Reload
: I2C2_ISR_TC ( -- x addr ) 6 bit I2C2_ISR ; \ I2C2_ISR_TC, Transfer Complete master  mode
: I2C2_ISR_STOPF? ( -- 1|0 ) 5 bit I2C2_ISR bit@ ; \ I2C2_ISR_STOPF, Stop detection flag
: I2C2_ISR_NACKF? ( -- 1|0 ) 4 bit I2C2_ISR bit@ ; \ I2C2_ISR_NACKF, Not acknowledge received  flag
: I2C2_ISR_ADDR ( -- x addr ) 3 bit I2C2_ISR ; \ I2C2_ISR_ADDR, Address matched slave  mode
: I2C2_ISR_RXNE ( -- x addr ) 2 bit I2C2_ISR ; \ I2C2_ISR_RXNE, Receive data register not empty  receivers
: I2C2_ISR_TXIS? ( -- 1|0 ) 1 bit I2C2_ISR bit@ ; \ I2C2_ISR_TXIS, Transmit interrupt status  transmitters
: I2C2_ISR_TXE ( -- x addr ) 0 bit I2C2_ISR ; \ I2C2_ISR_TXE, Transmit data register empty  transmitters

\ I2C2_ICR (write-only) Reset:0x00000000
: I2C2_ICR_ALERTCF ( -- x addr ) 13 bit I2C2_ICR ; \ I2C2_ICR_ALERTCF, Alert flag clear
: I2C2_ICR_TIMOUTCF ( -- x addr ) 12 bit I2C2_ICR ; \ I2C2_ICR_TIMOUTCF, Timeout detection flag  clear
: I2C2_ICR_PECCF ( -- x addr ) 11 bit I2C2_ICR ; \ I2C2_ICR_PECCF, PEC Error flag clear
: I2C2_ICR_OVRCF ( -- x addr ) 10 bit I2C2_ICR ; \ I2C2_ICR_OVRCF, Overrun/Underrun flag  clear
: I2C2_ICR_ARLOCF ( -- x addr ) 9 bit I2C2_ICR ; \ I2C2_ICR_ARLOCF, Arbitration lost flag  clear
: I2C2_ICR_BERRCF ( -- x addr ) 8 bit I2C2_ICR ; \ I2C2_ICR_BERRCF, Bus error flag clear
: I2C2_ICR_STOPCF ( -- x addr ) 5 bit I2C2_ICR ; \ I2C2_ICR_STOPCF, Stop detection flag clear
: I2C2_ICR_NACKCF ( -- x addr ) 4 bit I2C2_ICR ; \ I2C2_ICR_NACKCF, Not Acknowledge flag clear
: I2C2_ICR_ADDRCF ( -- x addr ) 3 bit I2C2_ICR ; \ I2C2_ICR_ADDRCF, Address Matched flag clear

\ I2C2_PECR (read-only) Reset:0x00000000
: I2C2_PECR_PEC? ( --  x ) I2C2_PECR @ ; \ I2C2_PECR_PEC, Packet error checking  register

\ I2C2_RXDR (read-only) Reset:0x00000000
: I2C2_RXDR_RXDATA? ( --  x ) I2C2_RXDR @ ; \ I2C2_RXDR_RXDATA, 8-bit receive data

\ I2C2_TXDR (read-write) Reset:0x00000000
: I2C2_TXDR_TXDATA ( %bbbbbbbb -- x addr ) I2C2_TXDR ; \ I2C2_TXDR_TXDATA, 8-bit transmit data

\ PWR_CR (read-write) Reset:0x00001000
: PWR_CR_LPDS ( -- x addr ) 0 bit PWR_CR ; \ PWR_CR_LPDS, Low-power deep sleep
: PWR_CR_PDDS ( -- x addr ) 1 bit PWR_CR ; \ PWR_CR_PDDS, Power down deepsleep
: PWR_CR_CWUF ( -- x addr ) 2 bit PWR_CR ; \ PWR_CR_CWUF, Clear wakeup flag
: PWR_CR_CSBF ( -- x addr ) 3 bit PWR_CR ; \ PWR_CR_CSBF, Clear standby flag
: PWR_CR_PVDE ( -- x addr ) 4 bit PWR_CR ; \ PWR_CR_PVDE, Power voltage detector  enable
: PWR_CR_PLS ( %bbb -- x addr ) 5 lshift PWR_CR ; \ PWR_CR_PLS, PVD level selection
: PWR_CR_DBP ( -- x addr ) 8 bit PWR_CR ; \ PWR_CR_DBP, Disable backup domain write  protection
: PWR_CR_ULP ( -- x addr ) 9 bit PWR_CR ; \ PWR_CR_ULP, Ultra-low-power mode
: PWR_CR_FWU ( -- x addr ) 10 bit PWR_CR ; \ PWR_CR_FWU, Fast wakeup
: PWR_CR_VOS ( %bb -- x addr ) 11 lshift PWR_CR ; \ PWR_CR_VOS, Voltage scaling range  selection
: PWR_CR_DS_EE_KOFF ( -- x addr ) 13 bit PWR_CR ; \ PWR_CR_DS_EE_KOFF, Deep sleep mode with Flash memory kept  off
: PWR_CR_LPRUN ( -- x addr ) 14 bit PWR_CR ; \ PWR_CR_LPRUN, Low power run mode

\ PWR_CSR (multiple-access)  Reset:0x00000000
: PWR_CSR_BRE ( -- x addr ) 9 bit PWR_CSR ; \ PWR_CSR_BRE, Backup regulator enable
: PWR_CSR_EWUP ( -- x addr ) 8 bit PWR_CSR ; \ PWR_CSR_EWUP, Enable WKUP pin
: PWR_CSR_BRR ( -- x addr ) 3 bit PWR_CSR ; \ PWR_CSR_BRR, Backup regulator ready
: PWR_CSR_PVDO ( -- x addr ) 2 bit PWR_CSR ; \ PWR_CSR_PVDO, PVD output
: PWR_CSR_SBF? ( -- 1|0 ) 1 bit PWR_CSR bit@ ; \ PWR_CSR_SBF, Standby flag
: PWR_CSR_WUF? ( -- 1|0 ) 0 bit PWR_CSR bit@ ; \ PWR_CSR_WUF, Wakeup flag
: PWR_CSR_VOSF? ( -- 1|0 ) 4 bit PWR_CSR bit@ ; \ PWR_CSR_VOSF, Voltage Scaling select  flag
: PWR_CSR_REGLPF? ( -- 1|0 ) 5 bit PWR_CSR bit@ ; \ PWR_CSR_REGLPF, Regulator LP flag

\ Flash_ACR (read-write) Reset:0x00000000
: Flash_ACR_LATENCY ( -- x addr ) 0 bit Flash_ACR ; \ Flash_ACR_LATENCY, Latency
: Flash_ACR_PRFTEN ( -- x addr ) 1 bit Flash_ACR ; \ Flash_ACR_PRFTEN, Prefetch enable
: Flash_ACR_SLEEP_PD ( -- x addr ) 3 bit Flash_ACR ; \ Flash_ACR_SLEEP_PD, Flash mode during Sleep
: Flash_ACR_RUN_PD ( -- x addr ) 4 bit Flash_ACR ; \ Flash_ACR_RUN_PD, Flash mode during Run
: Flash_ACR_DESAB_BUF ( -- x addr ) 5 bit Flash_ACR ; \ Flash_ACR_DESAB_BUF, Disable Buffer
: Flash_ACR_PRE_READ ( -- x addr ) 6 bit Flash_ACR ; \ Flash_ACR_PRE_READ, Pre-read data address

\ Flash_PECR (read-write) Reset:0x00000007
: Flash_PECR_PELOCK ( -- x addr ) 0 bit Flash_PECR ; \ Flash_PECR_PELOCK, FLASH_PECR and data EEPROM  lock
: Flash_PECR_PRGLOCK ( -- x addr ) 1 bit Flash_PECR ; \ Flash_PECR_PRGLOCK, Program memory lock
: Flash_PECR_OPTLOCK ( -- x addr ) 2 bit Flash_PECR ; \ Flash_PECR_OPTLOCK, Option bytes block lock
: Flash_PECR_PROG ( -- x addr ) 3 bit Flash_PECR ; \ Flash_PECR_PROG, Program memory selection
: Flash_PECR_DATA ( -- x addr ) 4 bit Flash_PECR ; \ Flash_PECR_DATA, Data EEPROM selection
: Flash_PECR_FTDW ( -- x addr ) 8 bit Flash_PECR ; \ Flash_PECR_FTDW, Fixed time data write for Byte, Half  Word and Word programming
: Flash_PECR_ERASE ( -- x addr ) 9 bit Flash_PECR ; \ Flash_PECR_ERASE, Page or Double Word erase  mode
: Flash_PECR_FPRG ( -- x addr ) 10 bit Flash_PECR ; \ Flash_PECR_FPRG, Half Page/Double Word programming  mode
: Flash_PECR_PARALLELBANK ( -- x addr ) 15 bit Flash_PECR ; \ Flash_PECR_PARALLELBANK, Parallel bank mode
: Flash_PECR_EOPIE ( -- x addr ) 16 bit Flash_PECR ; \ Flash_PECR_EOPIE, End of programming interrupt  enable
: Flash_PECR_ERRIE ( -- x addr ) 17 bit Flash_PECR ; \ Flash_PECR_ERRIE, Error interrupt enable
: Flash_PECR_OBL_LAUNCH ( -- x addr ) 18 bit Flash_PECR ; \ Flash_PECR_OBL_LAUNCH, Launch the option byte  loading

\ Flash_PDKEYR (write-only) Reset:0x00000000
: Flash_PDKEYR_PDKEYR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) Flash_PDKEYR ; \ Flash_PDKEYR_PDKEYR, RUN_PD in FLASH_ACR key

\ Flash_PEKEYR (write-only) Reset:0x00000000
: Flash_PEKEYR_PEKEYR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) Flash_PEKEYR ; \ Flash_PEKEYR_PEKEYR, FLASH_PEC and data EEPROM  key

\ Flash_PRGKEYR (write-only) Reset:0x00000000
: Flash_PRGKEYR_PRGKEYR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) Flash_PRGKEYR ; \ Flash_PRGKEYR_PRGKEYR, Program memory key

\ Flash_OPTKEYR (write-only) Reset:0x00000000
: Flash_OPTKEYR_OPTKEYR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) Flash_OPTKEYR ; \ Flash_OPTKEYR_OPTKEYR, Option byte key

\ Flash_SR (multiple-access)  Reset:0x00000004
: Flash_SR_BSY ( -- x addr ) 0 bit Flash_SR ; \ Flash_SR_BSY, Write/erase operations in  progress
: Flash_SR_EOP ( -- x addr ) 1 bit Flash_SR ; \ Flash_SR_EOP, End of operation
: Flash_SR_ENDHV ( -- x addr ) 2 bit Flash_SR ; \ Flash_SR_ENDHV, End of high voltage
: Flash_SR_READY ( -- x addr ) 3 bit Flash_SR ; \ Flash_SR_READY, Flash memory module ready after low  power mode
: Flash_SR_WRPERR ( -- x addr ) 8 bit Flash_SR ; \ Flash_SR_WRPERR, Write protected error
: Flash_SR_PGAERR ( -- x addr ) 9 bit Flash_SR ; \ Flash_SR_PGAERR, Programming alignment  error
: Flash_SR_SIZERR ( -- x addr ) 10 bit Flash_SR ; \ Flash_SR_SIZERR, Size error
: Flash_SR_OPTVERR ( -- x addr ) 11 bit Flash_SR ; \ Flash_SR_OPTVERR, Option validity error
: Flash_SR_RDERR ( -- x addr ) 14 bit Flash_SR ; \ Flash_SR_RDERR, RDERR
: Flash_SR_NOTZEROERR ( -- x addr ) 16 bit Flash_SR ; \ Flash_SR_NOTZEROERR, NOTZEROERR
: Flash_SR_FWWERR ( -- x addr ) 17 bit Flash_SR ; \ Flash_SR_FWWERR, FWWERR

\ Flash_OBR (read-only) Reset:0x00F80000
: Flash_OBR_RDPRT? ( --  x ) Flash_OBR @ ; \ Flash_OBR_RDPRT, Read protection
: Flash_OBR_BOR_LEV? ( --  x ) 16 lshift Flash_OBR @ ; \ Flash_OBR_BOR_LEV, BOR_LEV
: Flash_OBR_SPRMOD? ( --  1|0 ) 8 bit Flash_OBR bit@ ; \ Flash_OBR_SPRMOD, Selection of protection mode of WPR  bits

\ Flash_WRPR (read-write) Reset:0x00000000
: Flash_WRPR_WRP ( %bbbbbbbbbbbbbbbb -- x addr ) Flash_WRPR ; \ Flash_WRPR_WRP, Write protection

\ EXTI_IMR (read-write) Reset:0xFF840000
: EXTI_IMR_MR0 ( -- x addr ) 0 bit EXTI_IMR ; \ EXTI_IMR_MR0, Interrupt Mask on line 0
: EXTI_IMR_MR1 ( -- x addr ) 1 bit EXTI_IMR ; \ EXTI_IMR_MR1, Interrupt Mask on line 1
: EXTI_IMR_MR2 ( -- x addr ) 2 bit EXTI_IMR ; \ EXTI_IMR_MR2, Interrupt Mask on line 2
: EXTI_IMR_MR3 ( -- x addr ) 3 bit EXTI_IMR ; \ EXTI_IMR_MR3, Interrupt Mask on line 3
: EXTI_IMR_MR4 ( -- x addr ) 4 bit EXTI_IMR ; \ EXTI_IMR_MR4, Interrupt Mask on line 4
: EXTI_IMR_MR5 ( -- x addr ) 5 bit EXTI_IMR ; \ EXTI_IMR_MR5, Interrupt Mask on line 5
: EXTI_IMR_MR6 ( -- x addr ) 6 bit EXTI_IMR ; \ EXTI_IMR_MR6, Interrupt Mask on line 6
: EXTI_IMR_MR7 ( -- x addr ) 7 bit EXTI_IMR ; \ EXTI_IMR_MR7, Interrupt Mask on line 7
: EXTI_IMR_MR8 ( -- x addr ) 8 bit EXTI_IMR ; \ EXTI_IMR_MR8, Interrupt Mask on line 8
: EXTI_IMR_MR9 ( -- x addr ) 9 bit EXTI_IMR ; \ EXTI_IMR_MR9, Interrupt Mask on line 9
: EXTI_IMR_MR10 ( -- x addr ) 10 bit EXTI_IMR ; \ EXTI_IMR_MR10, Interrupt Mask on line 10
: EXTI_IMR_MR11 ( -- x addr ) 11 bit EXTI_IMR ; \ EXTI_IMR_MR11, Interrupt Mask on line 11
: EXTI_IMR_MR12 ( -- x addr ) 12 bit EXTI_IMR ; \ EXTI_IMR_MR12, Interrupt Mask on line 12
: EXTI_IMR_MR13 ( -- x addr ) 13 bit EXTI_IMR ; \ EXTI_IMR_MR13, Interrupt Mask on line 13
: EXTI_IMR_MR14 ( -- x addr ) 14 bit EXTI_IMR ; \ EXTI_IMR_MR14, Interrupt Mask on line 14
: EXTI_IMR_MR15 ( -- x addr ) 15 bit EXTI_IMR ; \ EXTI_IMR_MR15, Interrupt Mask on line 15
: EXTI_IMR_MR16 ( -- x addr ) 16 bit EXTI_IMR ; \ EXTI_IMR_MR16, Interrupt Mask on line 16
: EXTI_IMR_MR17 ( -- x addr ) 17 bit EXTI_IMR ; \ EXTI_IMR_MR17, Interrupt Mask on line 17
: EXTI_IMR_MR19 ( -- x addr ) 19 bit EXTI_IMR ; \ EXTI_IMR_MR19, Interrupt Mask on line 19
: EXTI_IMR_MR21 ( -- x addr ) 21 bit EXTI_IMR ; \ EXTI_IMR_MR21, Interrupt Mask on line 21
: EXTI_IMR_MR22 ( -- x addr ) 22 bit EXTI_IMR ; \ EXTI_IMR_MR22, Interrupt Mask on line 22
: EXTI_IMR_MR23 ( -- x addr ) 23 bit EXTI_IMR ; \ EXTI_IMR_MR23, Interrupt Mask on line 23
: EXTI_IMR_MR25 ( -- x addr ) 25 bit EXTI_IMR ; \ EXTI_IMR_MR25, Interrupt Mask on line 25
: EXTI_IMR_MR27 ( -- x addr ) 27 bit EXTI_IMR ; \ EXTI_IMR_MR27, Interrupt Mask on line 27

\ EXTI_EMR (read-write) Reset:0x00000000
: EXTI_EMR_MR0 ( -- x addr ) 0 bit EXTI_EMR ; \ EXTI_EMR_MR0, Event Mask on line 0
: EXTI_EMR_MR1 ( -- x addr ) 1 bit EXTI_EMR ; \ EXTI_EMR_MR1, Event Mask on line 1
: EXTI_EMR_MR2 ( -- x addr ) 2 bit EXTI_EMR ; \ EXTI_EMR_MR2, Event Mask on line 2
: EXTI_EMR_MR3 ( -- x addr ) 3 bit EXTI_EMR ; \ EXTI_EMR_MR3, Event Mask on line 3
: EXTI_EMR_MR4 ( -- x addr ) 4 bit EXTI_EMR ; \ EXTI_EMR_MR4, Event Mask on line 4
: EXTI_EMR_MR5 ( -- x addr ) 5 bit EXTI_EMR ; \ EXTI_EMR_MR5, Event Mask on line 5
: EXTI_EMR_MR6 ( -- x addr ) 6 bit EXTI_EMR ; \ EXTI_EMR_MR6, Event Mask on line 6
: EXTI_EMR_MR7 ( -- x addr ) 7 bit EXTI_EMR ; \ EXTI_EMR_MR7, Event Mask on line 7
: EXTI_EMR_MR8 ( -- x addr ) 8 bit EXTI_EMR ; \ EXTI_EMR_MR8, Event Mask on line 8
: EXTI_EMR_MR9 ( -- x addr ) 9 bit EXTI_EMR ; \ EXTI_EMR_MR9, Event Mask on line 9
: EXTI_EMR_MR10 ( -- x addr ) 10 bit EXTI_EMR ; \ EXTI_EMR_MR10, Event Mask on line 10
: EXTI_EMR_MR11 ( -- x addr ) 11 bit EXTI_EMR ; \ EXTI_EMR_MR11, Event Mask on line 11
: EXTI_EMR_MR12 ( -- x addr ) 12 bit EXTI_EMR ; \ EXTI_EMR_MR12, Event Mask on line 12
: EXTI_EMR_MR13 ( -- x addr ) 13 bit EXTI_EMR ; \ EXTI_EMR_MR13, Event Mask on line 13
: EXTI_EMR_MR14 ( -- x addr ) 14 bit EXTI_EMR ; \ EXTI_EMR_MR14, Event Mask on line 14
: EXTI_EMR_MR15 ( -- x addr ) 15 bit EXTI_EMR ; \ EXTI_EMR_MR15, Event Mask on line 15
: EXTI_EMR_MR16 ( -- x addr ) 16 bit EXTI_EMR ; \ EXTI_EMR_MR16, Event Mask on line 16
: EXTI_EMR_MR17 ( -- x addr ) 17 bit EXTI_EMR ; \ EXTI_EMR_MR17, Event Mask on line 17
: EXTI_EMR_MR19 ( -- x addr ) 19 bit EXTI_EMR ; \ EXTI_EMR_MR19, Event Mask on line 19
: EXTI_EMR_MR21 ( -- x addr ) 21 bit EXTI_EMR ; \ EXTI_EMR_MR21, Event Mask on line 21
: EXTI_EMR_MR22 ( -- x addr ) 22 bit EXTI_EMR ; \ EXTI_EMR_MR22, Event Mask on line 22
: EXTI_EMR_MR23 ( -- x addr ) 23 bit EXTI_EMR ; \ EXTI_EMR_MR23, Event Mask on line 23
: EXTI_EMR_MR25 ( -- x addr ) 25 bit EXTI_EMR ; \ EXTI_EMR_MR25, Event Mask on line 25
: EXTI_EMR_MR27 ( -- x addr ) 27 bit EXTI_EMR ; \ EXTI_EMR_MR27, Event Mask on line 27

\ EXTI_RTSR (read-write) Reset:0x00000000
: EXTI_RTSR_TR0 ( -- x addr ) 0 bit EXTI_RTSR ; \ EXTI_RTSR_TR0, Rising trigger event configuration of  line 0
: EXTI_RTSR_TR1 ( -- x addr ) 1 bit EXTI_RTSR ; \ EXTI_RTSR_TR1, Rising trigger event configuration of  line 1
: EXTI_RTSR_TR2 ( -- x addr ) 2 bit EXTI_RTSR ; \ EXTI_RTSR_TR2, Rising trigger event configuration of  line 2
: EXTI_RTSR_TR3 ( -- x addr ) 3 bit EXTI_RTSR ; \ EXTI_RTSR_TR3, Rising trigger event configuration of  line 3
: EXTI_RTSR_TR4 ( -- x addr ) 4 bit EXTI_RTSR ; \ EXTI_RTSR_TR4, Rising trigger event configuration of  line 4
: EXTI_RTSR_TR5 ( -- x addr ) 5 bit EXTI_RTSR ; \ EXTI_RTSR_TR5, Rising trigger event configuration of  line 5
: EXTI_RTSR_TR6 ( -- x addr ) 6 bit EXTI_RTSR ; \ EXTI_RTSR_TR6, Rising trigger event configuration of  line 6
: EXTI_RTSR_TR7 ( -- x addr ) 7 bit EXTI_RTSR ; \ EXTI_RTSR_TR7, Rising trigger event configuration of  line 7
: EXTI_RTSR_TR8 ( -- x addr ) 8 bit EXTI_RTSR ; \ EXTI_RTSR_TR8, Rising trigger event configuration of  line 8
: EXTI_RTSR_TR9 ( -- x addr ) 9 bit EXTI_RTSR ; \ EXTI_RTSR_TR9, Rising trigger event configuration of  line 9
: EXTI_RTSR_TR10 ( -- x addr ) 10 bit EXTI_RTSR ; \ EXTI_RTSR_TR10, Rising trigger event configuration of  line 10
: EXTI_RTSR_TR11 ( -- x addr ) 11 bit EXTI_RTSR ; \ EXTI_RTSR_TR11, Rising trigger event configuration of  line 11
: EXTI_RTSR_TR12 ( -- x addr ) 12 bit EXTI_RTSR ; \ EXTI_RTSR_TR12, Rising trigger event configuration of  line 12
: EXTI_RTSR_TR13 ( -- x addr ) 13 bit EXTI_RTSR ; \ EXTI_RTSR_TR13, Rising trigger event configuration of  line 13
: EXTI_RTSR_TR14 ( -- x addr ) 14 bit EXTI_RTSR ; \ EXTI_RTSR_TR14, Rising trigger event configuration of  line 14
: EXTI_RTSR_TR15 ( -- x addr ) 15 bit EXTI_RTSR ; \ EXTI_RTSR_TR15, Rising trigger event configuration of  line 15
: EXTI_RTSR_TR16 ( -- x addr ) 16 bit EXTI_RTSR ; \ EXTI_RTSR_TR16, Rising trigger event configuration of  line 16
: EXTI_RTSR_TR17 ( -- x addr ) 17 bit EXTI_RTSR ; \ EXTI_RTSR_TR17, Rising trigger event configuration of  line 17
: EXTI_RTSR_TR19 ( -- x addr ) 19 bit EXTI_RTSR ; \ EXTI_RTSR_TR19, Rising trigger event configuration of  line 19

\ EXTI_FTSR (read-write) Reset:0x00000000
: EXTI_FTSR_TR0 ( -- x addr ) 0 bit EXTI_FTSR ; \ EXTI_FTSR_TR0, Falling trigger event configuration of  line 0
: EXTI_FTSR_TR1 ( -- x addr ) 1 bit EXTI_FTSR ; \ EXTI_FTSR_TR1, Falling trigger event configuration of  line 1
: EXTI_FTSR_TR2 ( -- x addr ) 2 bit EXTI_FTSR ; \ EXTI_FTSR_TR2, Falling trigger event configuration of  line 2
: EXTI_FTSR_TR3 ( -- x addr ) 3 bit EXTI_FTSR ; \ EXTI_FTSR_TR3, Falling trigger event configuration of  line 3
: EXTI_FTSR_TR4 ( -- x addr ) 4 bit EXTI_FTSR ; \ EXTI_FTSR_TR4, Falling trigger event configuration of  line 4
: EXTI_FTSR_TR5 ( -- x addr ) 5 bit EXTI_FTSR ; \ EXTI_FTSR_TR5, Falling trigger event configuration of  line 5
: EXTI_FTSR_TR6 ( -- x addr ) 6 bit EXTI_FTSR ; \ EXTI_FTSR_TR6, Falling trigger event configuration of  line 6
: EXTI_FTSR_TR7 ( -- x addr ) 7 bit EXTI_FTSR ; \ EXTI_FTSR_TR7, Falling trigger event configuration of  line 7
: EXTI_FTSR_TR8 ( -- x addr ) 8 bit EXTI_FTSR ; \ EXTI_FTSR_TR8, Falling trigger event configuration of  line 8
: EXTI_FTSR_TR9 ( -- x addr ) 9 bit EXTI_FTSR ; \ EXTI_FTSR_TR9, Falling trigger event configuration of  line 9
: EXTI_FTSR_TR10 ( -- x addr ) 10 bit EXTI_FTSR ; \ EXTI_FTSR_TR10, Falling trigger event configuration of  line 10
: EXTI_FTSR_TR11 ( -- x addr ) 11 bit EXTI_FTSR ; \ EXTI_FTSR_TR11, Falling trigger event configuration of  line 11
: EXTI_FTSR_TR12 ( -- x addr ) 12 bit EXTI_FTSR ; \ EXTI_FTSR_TR12, Falling trigger event configuration of  line 12
: EXTI_FTSR_TR13 ( -- x addr ) 13 bit EXTI_FTSR ; \ EXTI_FTSR_TR13, Falling trigger event configuration of  line 13
: EXTI_FTSR_TR14 ( -- x addr ) 14 bit EXTI_FTSR ; \ EXTI_FTSR_TR14, Falling trigger event configuration of  line 14
: EXTI_FTSR_TR15 ( -- x addr ) 15 bit EXTI_FTSR ; \ EXTI_FTSR_TR15, Falling trigger event configuration of  line 15
: EXTI_FTSR_TR16 ( -- x addr ) 16 bit EXTI_FTSR ; \ EXTI_FTSR_TR16, Falling trigger event configuration of  line 16
: EXTI_FTSR_TR17 ( -- x addr ) 17 bit EXTI_FTSR ; \ EXTI_FTSR_TR17, Falling trigger event configuration of  line 17
: EXTI_FTSR_TR19 ( -- x addr ) 19 bit EXTI_FTSR ; \ EXTI_FTSR_TR19, Falling trigger event configuration of  line 19

\ EXTI_SWIER (read-write) Reset:0x00000000
: EXTI_SWIER_SWIER0 ( -- x addr ) 0 bit EXTI_SWIER ; \ EXTI_SWIER_SWIER0, Software Interrupt on line  0
: EXTI_SWIER_SWIER1 ( -- x addr ) 1 bit EXTI_SWIER ; \ EXTI_SWIER_SWIER1, Software Interrupt on line  1
: EXTI_SWIER_SWIER2 ( -- x addr ) 2 bit EXTI_SWIER ; \ EXTI_SWIER_SWIER2, Software Interrupt on line  2
: EXTI_SWIER_SWIER3 ( -- x addr ) 3 bit EXTI_SWIER ; \ EXTI_SWIER_SWIER3, Software Interrupt on line  3
: EXTI_SWIER_SWIER4 ( -- x addr ) 4 bit EXTI_SWIER ; \ EXTI_SWIER_SWIER4, Software Interrupt on line  4
: EXTI_SWIER_SWIER5 ( -- x addr ) 5 bit EXTI_SWIER ; \ EXTI_SWIER_SWIER5, Software Interrupt on line  5
: EXTI_SWIER_SWIER6 ( -- x addr ) 6 bit EXTI_SWIER ; \ EXTI_SWIER_SWIER6, Software Interrupt on line  6
: EXTI_SWIER_SWIER7 ( -- x addr ) 7 bit EXTI_SWIER ; \ EXTI_SWIER_SWIER7, Software Interrupt on line  7
: EXTI_SWIER_SWIER8 ( -- x addr ) 8 bit EXTI_SWIER ; \ EXTI_SWIER_SWIER8, Software Interrupt on line  8
: EXTI_SWIER_SWIER9 ( -- x addr ) 9 bit EXTI_SWIER ; \ EXTI_SWIER_SWIER9, Software Interrupt on line  9
: EXTI_SWIER_SWIER10 ( -- x addr ) 10 bit EXTI_SWIER ; \ EXTI_SWIER_SWIER10, Software Interrupt on line  10
: EXTI_SWIER_SWIER11 ( -- x addr ) 11 bit EXTI_SWIER ; \ EXTI_SWIER_SWIER11, Software Interrupt on line  11
: EXTI_SWIER_SWIER12 ( -- x addr ) 12 bit EXTI_SWIER ; \ EXTI_SWIER_SWIER12, Software Interrupt on line  12
: EXTI_SWIER_SWIER13 ( -- x addr ) 13 bit EXTI_SWIER ; \ EXTI_SWIER_SWIER13, Software Interrupt on line  13
: EXTI_SWIER_SWIER14 ( -- x addr ) 14 bit EXTI_SWIER ; \ EXTI_SWIER_SWIER14, Software Interrupt on line  14
: EXTI_SWIER_SWIER15 ( -- x addr ) 15 bit EXTI_SWIER ; \ EXTI_SWIER_SWIER15, Software Interrupt on line  15
: EXTI_SWIER_SWIER16 ( -- x addr ) 16 bit EXTI_SWIER ; \ EXTI_SWIER_SWIER16, Software Interrupt on line  16
: EXTI_SWIER_SWIER17 ( -- x addr ) 17 bit EXTI_SWIER ; \ EXTI_SWIER_SWIER17, Software Interrupt on line  17
: EXTI_SWIER_SWIER19 ( -- x addr ) 19 bit EXTI_SWIER ; \ EXTI_SWIER_SWIER19, Software Interrupt on line  19

\ EXTI_PR (read-write) Reset:0x00000000
: EXTI_PR_PR0 ( -- x addr ) 0 bit EXTI_PR ; \ EXTI_PR_PR0, Pending bit 0
: EXTI_PR_PR1 ( -- x addr ) 1 bit EXTI_PR ; \ EXTI_PR_PR1, Pending bit 1
: EXTI_PR_PR2 ( -- x addr ) 2 bit EXTI_PR ; \ EXTI_PR_PR2, Pending bit 2
: EXTI_PR_PR3 ( -- x addr ) 3 bit EXTI_PR ; \ EXTI_PR_PR3, Pending bit 3
: EXTI_PR_PR4 ( -- x addr ) 4 bit EXTI_PR ; \ EXTI_PR_PR4, Pending bit 4
: EXTI_PR_PR5 ( -- x addr ) 5 bit EXTI_PR ; \ EXTI_PR_PR5, Pending bit 5
: EXTI_PR_PR6 ( -- x addr ) 6 bit EXTI_PR ; \ EXTI_PR_PR6, Pending bit 6
: EXTI_PR_PR7 ( -- x addr ) 7 bit EXTI_PR ; \ EXTI_PR_PR7, Pending bit 7
: EXTI_PR_PR8 ( -- x addr ) 8 bit EXTI_PR ; \ EXTI_PR_PR8, Pending bit 8
: EXTI_PR_PR9 ( -- x addr ) 9 bit EXTI_PR ; \ EXTI_PR_PR9, Pending bit 9
: EXTI_PR_PR10 ( -- x addr ) 10 bit EXTI_PR ; \ EXTI_PR_PR10, Pending bit 10
: EXTI_PR_PR11 ( -- x addr ) 11 bit EXTI_PR ; \ EXTI_PR_PR11, Pending bit 11
: EXTI_PR_PR12 ( -- x addr ) 12 bit EXTI_PR ; \ EXTI_PR_PR12, Pending bit 12
: EXTI_PR_PR13 ( -- x addr ) 13 bit EXTI_PR ; \ EXTI_PR_PR13, Pending bit 13
: EXTI_PR_PR14 ( -- x addr ) 14 bit EXTI_PR ; \ EXTI_PR_PR14, Pending bit 14
: EXTI_PR_PR15 ( -- x addr ) 15 bit EXTI_PR ; \ EXTI_PR_PR15, Pending bit 15
: EXTI_PR_PR16 ( -- x addr ) 16 bit EXTI_PR ; \ EXTI_PR_PR16, Pending bit 16
: EXTI_PR_PR17 ( -- x addr ) 17 bit EXTI_PR ; \ EXTI_PR_PR17, Pending bit 17
: EXTI_PR_PR19 ( -- x addr ) 19 bit EXTI_PR ; \ EXTI_PR_PR19, Pending bit 19

\ ADC_ISR (read-write) Reset:0x00000000
: ADC_ISR_ADRDY ( -- x addr ) 0 bit ADC_ISR ; \ ADC_ISR_ADRDY, ADC ready
: ADC_ISR_EOSMP ( -- x addr ) 1 bit ADC_ISR ; \ ADC_ISR_EOSMP, End of sampling flag
: ADC_ISR_EOC ( -- x addr ) 2 bit ADC_ISR ; \ ADC_ISR_EOC, End of conversion flag
: ADC_ISR_EOS ( -- x addr ) 3 bit ADC_ISR ; \ ADC_ISR_EOS, End of sequence flag
: ADC_ISR_OVR ( -- x addr ) 4 bit ADC_ISR ; \ ADC_ISR_OVR, ADC overrun
: ADC_ISR_AWD ( -- x addr ) 7 bit ADC_ISR ; \ ADC_ISR_AWD, Analog watchdog flag
: ADC_ISR_EOCAL ( -- x addr ) 11 bit ADC_ISR ; \ ADC_ISR_EOCAL, End Of Calibration flag

\ ADC_IER (read-write) Reset:0x00000000
: ADC_IER_ADRDYIE ( -- x addr ) 0 bit ADC_IER ; \ ADC_IER_ADRDYIE, ADC ready interrupt enable
: ADC_IER_EOSMPIE ( -- x addr ) 1 bit ADC_IER ; \ ADC_IER_EOSMPIE, End of sampling flag interrupt  enable
: ADC_IER_EOCIE ( -- x addr ) 2 bit ADC_IER ; \ ADC_IER_EOCIE, End of conversion interrupt  enable
: ADC_IER_EOSIE ( -- x addr ) 3 bit ADC_IER ; \ ADC_IER_EOSIE, End of conversion sequence interrupt  enable
: ADC_IER_OVRIE ( -- x addr ) 4 bit ADC_IER ; \ ADC_IER_OVRIE, Overrun interrupt enable
: ADC_IER_AWDIE ( -- x addr ) 7 bit ADC_IER ; \ ADC_IER_AWDIE, Analog watchdog interrupt  enable
: ADC_IER_EOCALIE ( -- x addr ) 11 bit ADC_IER ; \ ADC_IER_EOCALIE, End of calibration interrupt  enable

\ ADC_CR (read-write) Reset:0x00000000
: ADC_CR_ADEN ( -- x addr ) 0 bit ADC_CR ; \ ADC_CR_ADEN, ADC enable command
: ADC_CR_ADDIS ( -- x addr ) 1 bit ADC_CR ; \ ADC_CR_ADDIS, ADC disable command
: ADC_CR_ADSTART ( -- x addr ) 2 bit ADC_CR ; \ ADC_CR_ADSTART, ADC start conversion  command
: ADC_CR_ADSTP ( -- x addr ) 4 bit ADC_CR ; \ ADC_CR_ADSTP, ADC stop conversion  command
: ADC_CR_ADVREGEN ( -- x addr ) 28 bit ADC_CR ; \ ADC_CR_ADVREGEN, ADC Voltage Regulator  Enable
: ADC_CR_ADCAL ( -- x addr ) 31 bit ADC_CR ; \ ADC_CR_ADCAL, ADC calibration

\ ADC_CFGR1 (read-write) Reset:0x00000000
: ADC_CFGR1_AWDCH ( %bbbbb -- x addr ) 26 lshift ADC_CFGR1 ; \ ADC_CFGR1_AWDCH, Analog watchdog channel  selection
: ADC_CFGR1_AWDEN ( -- x addr ) 23 bit ADC_CFGR1 ; \ ADC_CFGR1_AWDEN, Analog watchdog enable
: ADC_CFGR1_AWDSGL ( -- x addr ) 22 bit ADC_CFGR1 ; \ ADC_CFGR1_AWDSGL, Enable the watchdog on a single channel  or on all channels
: ADC_CFGR1_DISCEN ( -- x addr ) 16 bit ADC_CFGR1 ; \ ADC_CFGR1_DISCEN, Discontinuous mode
: ADC_CFGR1_AUTOFF ( -- x addr ) 15 bit ADC_CFGR1 ; \ ADC_CFGR1_AUTOFF, Auto-off mode
: ADC_CFGR1_AUTDLY ( -- x addr ) 14 bit ADC_CFGR1 ; \ ADC_CFGR1_AUTDLY, Auto-delayed conversion  mode
: ADC_CFGR1_CONT ( -- x addr ) 13 bit ADC_CFGR1 ; \ ADC_CFGR1_CONT, Single / continuous conversion  mode
: ADC_CFGR1_OVRMOD ( -- x addr ) 12 bit ADC_CFGR1 ; \ ADC_CFGR1_OVRMOD, Overrun management mode
: ADC_CFGR1_EXTEN ( %bb -- x addr ) 10 lshift ADC_CFGR1 ; \ ADC_CFGR1_EXTEN, External trigger enable and polarity  selection
: ADC_CFGR1_EXTSEL ( %bbb -- x addr ) 6 lshift ADC_CFGR1 ; \ ADC_CFGR1_EXTSEL, External trigger selection
: ADC_CFGR1_ALIGN ( -- x addr ) 5 bit ADC_CFGR1 ; \ ADC_CFGR1_ALIGN, Data alignment
: ADC_CFGR1_RES ( %bb -- x addr ) 3 lshift ADC_CFGR1 ; \ ADC_CFGR1_RES, Data resolution
: ADC_CFGR1_SCANDIR ( -- x addr ) 2 bit ADC_CFGR1 ; \ ADC_CFGR1_SCANDIR, Scan sequence direction
: ADC_CFGR1_DMACFG ( -- x addr ) 1 bit ADC_CFGR1 ; \ ADC_CFGR1_DMACFG, Direct memery access  configuration
: ADC_CFGR1_DMAEN ( -- x addr ) 0 bit ADC_CFGR1 ; \ ADC_CFGR1_DMAEN, Direct memory access  enable

\ ADC_CFGR2 (read-write) Reset:0x00000000
: ADC_CFGR2_OVSE ( -- x addr ) 0 bit ADC_CFGR2 ; \ ADC_CFGR2_OVSE, Oversampler Enable
: ADC_CFGR2_OVSR ( %bbb -- x addr ) 2 lshift ADC_CFGR2 ; \ ADC_CFGR2_OVSR, Oversampling ratio
: ADC_CFGR2_OVSS ( %bbbb -- x addr ) 5 lshift ADC_CFGR2 ; \ ADC_CFGR2_OVSS, Oversampling shift
: ADC_CFGR2_TOVS ( -- x addr ) 9 bit ADC_CFGR2 ; \ ADC_CFGR2_TOVS, Triggered Oversampling
: ADC_CFGR2_CKMODE ( %bb -- x addr ) 30 lshift ADC_CFGR2 ; \ ADC_CFGR2_CKMODE, ADC clock mode

\ ADC_SMPR (read-write) Reset:0x00000000
: ADC_SMPR_SMPR ( %bbb -- x addr ) ADC_SMPR ; \ ADC_SMPR_SMPR, Sampling time selection

\ ADC_TR (read-write) Reset:0x0FFF0000
: ADC_TR_HT ( %bbbbbbbbbbb -- x addr ) 16 lshift ADC_TR ; \ ADC_TR_HT, Analog watchdog higher  threshold
: ADC_TR_LT ( %bbbbbbbbbbb -- x addr ) ADC_TR ; \ ADC_TR_LT, Analog watchdog lower  threshold

\ ADC_CHSELR (read-write) Reset:0x00000000
: ADC_CHSELR_CHSEL18 ( -- x addr ) 18 bit ADC_CHSELR ; \ ADC_CHSELR_CHSEL18, Channel-x selection
: ADC_CHSELR_CHSEL17 ( -- x addr ) 17 bit ADC_CHSELR ; \ ADC_CHSELR_CHSEL17, Channel-x selection
: ADC_CHSELR_CHSEL16 ( -- x addr ) 16 bit ADC_CHSELR ; \ ADC_CHSELR_CHSEL16, Channel-x selection
: ADC_CHSELR_CHSEL15 ( -- x addr ) 15 bit ADC_CHSELR ; \ ADC_CHSELR_CHSEL15, Channel-x selection
: ADC_CHSELR_CHSEL14 ( -- x addr ) 14 bit ADC_CHSELR ; \ ADC_CHSELR_CHSEL14, Channel-x selection
: ADC_CHSELR_CHSEL13 ( -- x addr ) 13 bit ADC_CHSELR ; \ ADC_CHSELR_CHSEL13, Channel-x selection
: ADC_CHSELR_CHSEL12 ( -- x addr ) 12 bit ADC_CHSELR ; \ ADC_CHSELR_CHSEL12, Channel-x selection
: ADC_CHSELR_CHSEL11 ( -- x addr ) 11 bit ADC_CHSELR ; \ ADC_CHSELR_CHSEL11, Channel-x selection
: ADC_CHSELR_CHSEL10 ( -- x addr ) 10 bit ADC_CHSELR ; \ ADC_CHSELR_CHSEL10, Channel-x selection
: ADC_CHSELR_CHSEL9 ( -- x addr ) 9 bit ADC_CHSELR ; \ ADC_CHSELR_CHSEL9, Channel-x selection
: ADC_CHSELR_CHSEL8 ( -- x addr ) 8 bit ADC_CHSELR ; \ ADC_CHSELR_CHSEL8, Channel-x selection
: ADC_CHSELR_CHSEL7 ( -- x addr ) 7 bit ADC_CHSELR ; \ ADC_CHSELR_CHSEL7, Channel-x selection
: ADC_CHSELR_CHSEL6 ( -- x addr ) 6 bit ADC_CHSELR ; \ ADC_CHSELR_CHSEL6, Channel-x selection
: ADC_CHSELR_CHSEL5 ( -- x addr ) 5 bit ADC_CHSELR ; \ ADC_CHSELR_CHSEL5, Channel-x selection
: ADC_CHSELR_CHSEL4 ( -- x addr ) 4 bit ADC_CHSELR ; \ ADC_CHSELR_CHSEL4, Channel-x selection
: ADC_CHSELR_CHSEL3 ( -- x addr ) 3 bit ADC_CHSELR ; \ ADC_CHSELR_CHSEL3, Channel-x selection
: ADC_CHSELR_CHSEL2 ( -- x addr ) 2 bit ADC_CHSELR ; \ ADC_CHSELR_CHSEL2, Channel-x selection
: ADC_CHSELR_CHSEL1 ( -- x addr ) 1 bit ADC_CHSELR ; \ ADC_CHSELR_CHSEL1, Channel-x selection
: ADC_CHSELR_CHSEL0 ( -- x addr ) 0 bit ADC_CHSELR ; \ ADC_CHSELR_CHSEL0, Channel-x selection

\ ADC_DR (read-only) Reset:0x00000000
: ADC_DR_DATA? ( --  x ) ADC_DR @ ; \ ADC_DR_DATA, Converted data

\ ADC_CALFACT (read-write) Reset:0x00000000
: ADC_CALFACT_CALFACT ( %bbbbbbb -- x addr ) ADC_CALFACT ; \ ADC_CALFACT_CALFACT, Calibration factor

\ ADC_CCR (read-write) Reset:0x00000000
: ADC_CCR_PRESC ( %bbbb -- x addr ) 18 lshift ADC_CCR ; \ ADC_CCR_PRESC, ADC prescaler
: ADC_CCR_VREFEN ( -- x addr ) 22 bit ADC_CCR ; \ ADC_CCR_VREFEN, VREFINT enable
: ADC_CCR_TSEN ( -- x addr ) 23 bit ADC_CCR ; \ ADC_CCR_TSEN, Temperature sensor enable
: ADC_CCR_VLCDEN ( -- x addr ) 24 bit ADC_CCR ; \ ADC_CCR_VLCDEN, VLCD enable
: ADC_CCR_LFMEN ( -- x addr ) 25 bit ADC_CCR ; \ ADC_CCR_LFMEN, Low Frequency Mode enable

\ DBGMCU_IDCODE (read-only) Reset:0x0
: DBGMCU_IDCODE_DEV_ID? ( --  x ) DBGMCU_IDCODE @ ; \ DBGMCU_IDCODE_DEV_ID, Device Identifier
: DBGMCU_IDCODE_REV_ID? ( --  x ) 16 lshift DBGMCU_IDCODE @ ; \ DBGMCU_IDCODE_REV_ID, Revision Identifier

\ DBGMCU_CR (read-write) Reset:0x0
: DBGMCU_CR_DBG_STOP ( -- x addr ) 1 bit DBGMCU_CR ; \ DBGMCU_CR_DBG_STOP, Debug Stop Mode
: DBGMCU_CR_DBG_STANDBY ( -- x addr ) 2 bit DBGMCU_CR ; \ DBGMCU_CR_DBG_STANDBY, Debug Standby Mode
: DBGMCU_CR_DBG_SLEEP ( -- x addr ) 0 bit DBGMCU_CR ; \ DBGMCU_CR_DBG_SLEEP, Debug Sleep Mode

\ DBGMCU_APB1_FZ (read-write) Reset:0x0
: DBGMCU_APB1_FZ_DBG_TIMER2_STOP ( -- x addr ) 0 bit DBGMCU_APB1_FZ ; \ DBGMCU_APB1_FZ_DBG_TIMER2_STOP, Debug Timer 2 stopped when Core is  halted
: DBGMCU_APB1_FZ_DBG_TIMER6_STOP ( -- x addr ) 4 bit DBGMCU_APB1_FZ ; \ DBGMCU_APB1_FZ_DBG_TIMER6_STOP, Debug Timer 6 stopped when Core is  halted
: DBGMCU_APB1_FZ_DBG_RTC_STOP ( -- x addr ) 10 bit DBGMCU_APB1_FZ ; \ DBGMCU_APB1_FZ_DBG_RTC_STOP, Debug RTC stopped when Core is  halted
: DBGMCU_APB1_FZ_DBG_WWDG_STOP ( -- x addr ) 11 bit DBGMCU_APB1_FZ ; \ DBGMCU_APB1_FZ_DBG_WWDG_STOP, Debug Window Wachdog stopped when Core  is halted
: DBGMCU_APB1_FZ_DBG_IWDG_STOP ( -- x addr ) 12 bit DBGMCU_APB1_FZ ; \ DBGMCU_APB1_FZ_DBG_IWDG_STOP, Debug Independent Wachdog stopped when  Core is halted
: DBGMCU_APB1_FZ_DBG_I2C1_STOP ( -- x addr ) 21 bit DBGMCU_APB1_FZ ; \ DBGMCU_APB1_FZ_DBG_I2C1_STOP, I2C1 SMBUS timeout mode stopped when  core is halted
: DBGMCU_APB1_FZ_DBG_I2C2_STOP ( -- x addr ) 22 bit DBGMCU_APB1_FZ ; \ DBGMCU_APB1_FZ_DBG_I2C2_STOP, I2C2 SMBUS timeout mode stopped when  core is halted
: DBGMCU_APB1_FZ_DBG_I2C3_STOP ( -- x addr ) 30 bit DBGMCU_APB1_FZ ; \ DBGMCU_APB1_FZ_DBG_I2C3_STOP, I2C3 SMBUS timeout mode stopped when  core is halted
: DBGMCU_APB1_FZ_DBG_LPTIMER_STOP ( -- x addr ) 31 bit DBGMCU_APB1_FZ ; \ DBGMCU_APB1_FZ_DBG_LPTIMER_STOP, LPTIM1 counter stopped when core is  halted

\ DBGMCU_APB2_FZ (read-write) Reset:0x0
: DBGMCU_APB2_FZ_DBG_TIMER21_STOP ( -- x addr ) 2 bit DBGMCU_APB2_FZ ; \ DBGMCU_APB2_FZ_DBG_TIMER21_STOP, Debug Timer 21 stopped when Core is  halted
: DBGMCU_APB2_FZ_DBG_TIMER22_STOP ( -- x addr ) 5 bit DBGMCU_APB2_FZ ; \ DBGMCU_APB2_FZ_DBG_TIMER22_STOP, Debug Timer 22 stopped when Core is  halted

\ TIM2_CR1 (read-write) Reset:0x0000
: TIM2_CR1_CKD ( %bb -- x addr ) 8 lshift TIM2_CR1 ; \ TIM2_CR1_CKD, Clock division
: TIM2_CR1_ARPE ( -- x addr ) 7 bit TIM2_CR1 ; \ TIM2_CR1_ARPE, Auto-reload preload enable
: TIM2_CR1_CMS ( %bb -- x addr ) 5 lshift TIM2_CR1 ; \ TIM2_CR1_CMS, Center-aligned mode  selection
: TIM2_CR1_DIR ( -- x addr ) 4 bit TIM2_CR1 ; \ TIM2_CR1_DIR, Direction
: TIM2_CR1_OPM ( -- x addr ) 3 bit TIM2_CR1 ; \ TIM2_CR1_OPM, One-pulse mode
: TIM2_CR1_URS ( -- x addr ) 2 bit TIM2_CR1 ; \ TIM2_CR1_URS, Update request source
: TIM2_CR1_UDIS ( -- x addr ) 1 bit TIM2_CR1 ; \ TIM2_CR1_UDIS, Update disable
: TIM2_CR1_CEN ( -- x addr ) 0 bit TIM2_CR1 ; \ TIM2_CR1_CEN, Counter enable

\ TIM2_CR2 (read-write) Reset:0x0000
: TIM2_CR2_TI1S ( -- x addr ) 7 bit TIM2_CR2 ; \ TIM2_CR2_TI1S, TI1 selection
: TIM2_CR2_MMS ( %bbb -- x addr ) 4 lshift TIM2_CR2 ; \ TIM2_CR2_MMS, Master mode selection
: TIM2_CR2_CCDS ( -- x addr ) 3 bit TIM2_CR2 ; \ TIM2_CR2_CCDS, Capture/compare DMA  selection

\ TIM2_SMCR (read-write) Reset:0x0000
: TIM2_SMCR_ETP ( -- x addr ) 15 bit TIM2_SMCR ; \ TIM2_SMCR_ETP, External trigger polarity
: TIM2_SMCR_ECE ( -- x addr ) 14 bit TIM2_SMCR ; \ TIM2_SMCR_ECE, External clock enable
: TIM2_SMCR_ETPS ( %bb -- x addr ) 12 lshift TIM2_SMCR ; \ TIM2_SMCR_ETPS, External trigger prescaler
: TIM2_SMCR_ETF ( %bbbb -- x addr ) 8 lshift TIM2_SMCR ; \ TIM2_SMCR_ETF, External trigger filter
: TIM2_SMCR_MSM ( -- x addr ) 7 bit TIM2_SMCR ; \ TIM2_SMCR_MSM, Master/Slave mode
: TIM2_SMCR_TS ( %bbb -- x addr ) 4 lshift TIM2_SMCR ; \ TIM2_SMCR_TS, Trigger selection
: TIM2_SMCR_SMS ( %bbb -- x addr ) TIM2_SMCR ; \ TIM2_SMCR_SMS, Slave mode selection

\ TIM2_DIER (read-write) Reset:0x0000
: TIM2_DIER_TDE ( -- x addr ) 14 bit TIM2_DIER ; \ TIM2_DIER_TDE, Trigger DMA request enable
: TIM2_DIER_COMDE ( -- x addr ) 13 bit TIM2_DIER ; \ TIM2_DIER_COMDE, Reserved
: TIM2_DIER_CC4DE ( -- x addr ) 12 bit TIM2_DIER ; \ TIM2_DIER_CC4DE, Capture/Compare 4 DMA request  enable
: TIM2_DIER_CC3DE ( -- x addr ) 11 bit TIM2_DIER ; \ TIM2_DIER_CC3DE, Capture/Compare 3 DMA request  enable
: TIM2_DIER_CC2DE ( -- x addr ) 10 bit TIM2_DIER ; \ TIM2_DIER_CC2DE, Capture/Compare 2 DMA request  enable
: TIM2_DIER_CC1DE ( -- x addr ) 9 bit TIM2_DIER ; \ TIM2_DIER_CC1DE, Capture/Compare 1 DMA request  enable
: TIM2_DIER_UDE ( -- x addr ) 8 bit TIM2_DIER ; \ TIM2_DIER_UDE, Update DMA request enable
: TIM2_DIER_TIE ( -- x addr ) 6 bit TIM2_DIER ; \ TIM2_DIER_TIE, Trigger interrupt enable
: TIM2_DIER_CC4IE ( -- x addr ) 4 bit TIM2_DIER ; \ TIM2_DIER_CC4IE, Capture/Compare 4 interrupt  enable
: TIM2_DIER_CC3IE ( -- x addr ) 3 bit TIM2_DIER ; \ TIM2_DIER_CC3IE, Capture/Compare 3 interrupt  enable
: TIM2_DIER_CC2IE ( -- x addr ) 2 bit TIM2_DIER ; \ TIM2_DIER_CC2IE, Capture/Compare 2 interrupt  enable
: TIM2_DIER_CC1IE ( -- x addr ) 1 bit TIM2_DIER ; \ TIM2_DIER_CC1IE, Capture/Compare 1 interrupt  enable
: TIM2_DIER_UIE ( -- x addr ) 0 bit TIM2_DIER ; \ TIM2_DIER_UIE, Update interrupt enable

\ TIM2_SR (read-write) Reset:0x0000
: TIM2_SR_CC4OF ( -- x addr ) 12 bit TIM2_SR ; \ TIM2_SR_CC4OF, Capture/Compare 4 overcapture  flag
: TIM2_SR_CC3OF ( -- x addr ) 11 bit TIM2_SR ; \ TIM2_SR_CC3OF, Capture/Compare 3 overcapture  flag
: TIM2_SR_CC2OF ( -- x addr ) 10 bit TIM2_SR ; \ TIM2_SR_CC2OF, Capture/compare 2 overcapture  flag
: TIM2_SR_CC1OF ( -- x addr ) 9 bit TIM2_SR ; \ TIM2_SR_CC1OF, Capture/Compare 1 overcapture  flag
: TIM2_SR_TIF ( -- x addr ) 6 bit TIM2_SR ; \ TIM2_SR_TIF, Trigger interrupt flag
: TIM2_SR_CC4IF ( -- x addr ) 4 bit TIM2_SR ; \ TIM2_SR_CC4IF, Capture/Compare 4 interrupt  flag
: TIM2_SR_CC3IF ( -- x addr ) 3 bit TIM2_SR ; \ TIM2_SR_CC3IF, Capture/Compare 3 interrupt  flag
: TIM2_SR_CC2IF ( -- x addr ) 2 bit TIM2_SR ; \ TIM2_SR_CC2IF, Capture/Compare 2 interrupt  flag
: TIM2_SR_CC1IF ( -- x addr ) 1 bit TIM2_SR ; \ TIM2_SR_CC1IF, Capture/compare 1 interrupt  flag
: TIM2_SR_UIF ( -- x addr ) 0 bit TIM2_SR ; \ TIM2_SR_UIF, Update interrupt flag

\ TIM2_EGR (write-only) Reset:0x0000
: TIM2_EGR_TG ( -- x addr ) 6 bit TIM2_EGR ; \ TIM2_EGR_TG, Trigger generation
: TIM2_EGR_CC4G ( -- x addr ) 4 bit TIM2_EGR ; \ TIM2_EGR_CC4G, Capture/compare 4  generation
: TIM2_EGR_CC3G ( -- x addr ) 3 bit TIM2_EGR ; \ TIM2_EGR_CC3G, Capture/compare 3  generation
: TIM2_EGR_CC2G ( -- x addr ) 2 bit TIM2_EGR ; \ TIM2_EGR_CC2G, Capture/compare 2  generation
: TIM2_EGR_CC1G ( -- x addr ) 1 bit TIM2_EGR ; \ TIM2_EGR_CC1G, Capture/compare 1  generation
: TIM2_EGR_UG ( -- x addr ) 0 bit TIM2_EGR ; \ TIM2_EGR_UG, Update generation

\ TIM2_CCMR1_Output (read-write) Reset:0x00000000
: TIM2_CCMR1_Output_OC2CE ( -- x addr ) 15 bit TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output_OC2CE, Output compare 2 clear  enable
: TIM2_CCMR1_Output_OC2M ( %bbb -- x addr ) 12 lshift TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output_OC2M, Output compare 2 mode
: TIM2_CCMR1_Output_OC2PE ( -- x addr ) 11 bit TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output_OC2PE, Output compare 2 preload  enable
: TIM2_CCMR1_Output_OC2FE ( -- x addr ) 10 bit TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output_OC2FE, Output compare 2 fast  enable
: TIM2_CCMR1_Output_CC2S ( %bb -- x addr ) 8 lshift TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output_CC2S, Capture/Compare 2  selection
: TIM2_CCMR1_Output_OC1CE ( -- x addr ) 7 bit TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output_OC1CE, Output compare 1 clear  enable
: TIM2_CCMR1_Output_OC1M ( %bbb -- x addr ) 4 lshift TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output_OC1M, Output compare 1 mode
: TIM2_CCMR1_Output_OC1PE ( -- x addr ) 3 bit TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output_OC1PE, Output compare 1 preload  enable
: TIM2_CCMR1_Output_OC1FE ( -- x addr ) 2 bit TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output_OC1FE, Output compare 1 fast  enable
: TIM2_CCMR1_Output_CC1S ( %bb -- x addr ) TIM2_CCMR1_Output ; \ TIM2_CCMR1_Output_CC1S, Capture/Compare 1  selection

\ TIM2_CCMR1_Input (read-write) Reset:0x00000000
: TIM2_CCMR1_Input_IC2F ( %bbbb -- x addr ) 12 lshift TIM2_CCMR1_Input ; \ TIM2_CCMR1_Input_IC2F, Input capture 2 filter
: TIM2_CCMR1_Input_IC2PSC ( %bb -- x addr ) 10 lshift TIM2_CCMR1_Input ; \ TIM2_CCMR1_Input_IC2PSC, Input capture 2 prescaler
: TIM2_CCMR1_Input_CC2S ( %bb -- x addr ) 8 lshift TIM2_CCMR1_Input ; \ TIM2_CCMR1_Input_CC2S, Capture/compare 2  selection
: TIM2_CCMR1_Input_IC1F ( %bbbb -- x addr ) 4 lshift TIM2_CCMR1_Input ; \ TIM2_CCMR1_Input_IC1F, Input capture 1 filter
: TIM2_CCMR1_Input_IC1PSC ( %bb -- x addr ) 2 lshift TIM2_CCMR1_Input ; \ TIM2_CCMR1_Input_IC1PSC, Input capture 1 prescaler
: TIM2_CCMR1_Input_CC1S ( %bb -- x addr ) TIM2_CCMR1_Input ; \ TIM2_CCMR1_Input_CC1S, Capture/Compare 1  selection

\ TIM2_CCMR2_Output (read-write) Reset:0x00000000
: TIM2_CCMR2_Output_OC4CE ( -- x addr ) 15 bit TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output_OC4CE, Output compare 4 clear  enable
: TIM2_CCMR2_Output_OC4M ( %bbb -- x addr ) 12 lshift TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output_OC4M, Output compare 4 mode
: TIM2_CCMR2_Output_OC4PE ( -- x addr ) 11 bit TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output_OC4PE, Output compare 4 preload  enable
: TIM2_CCMR2_Output_OC4FE ( -- x addr ) 10 bit TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output_OC4FE, Output compare 4 fast  enable
: TIM2_CCMR2_Output_CC4S ( %bb -- x addr ) 8 lshift TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output_CC4S, Capture/Compare 4  selection
: TIM2_CCMR2_Output_OC3CE ( -- x addr ) 7 bit TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output_OC3CE, Output compare 3 clear  enable
: TIM2_CCMR2_Output_OC3M ( %bbb -- x addr ) 4 lshift TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output_OC3M, Output compare 3 mode
: TIM2_CCMR2_Output_OC3PE ( -- x addr ) 3 bit TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output_OC3PE, Output compare 3 preload  enable
: TIM2_CCMR2_Output_OC3FE ( -- x addr ) 2 bit TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output_OC3FE, Output compare 3 fast  enable
: TIM2_CCMR2_Output_CC3S ( %bb -- x addr ) TIM2_CCMR2_Output ; \ TIM2_CCMR2_Output_CC3S, Capture/Compare 3  selection

\ TIM2_CCMR2_Input (read-write) Reset:0x00000000
: TIM2_CCMR2_Input_IC4F ( %bbbb -- x addr ) 12 lshift TIM2_CCMR2_Input ; \ TIM2_CCMR2_Input_IC4F, Input capture 4 filter
: TIM2_CCMR2_Input_IC4PSC ( %bb -- x addr ) 10 lshift TIM2_CCMR2_Input ; \ TIM2_CCMR2_Input_IC4PSC, Input capture 4 prescaler
: TIM2_CCMR2_Input_CC4S ( %bb -- x addr ) 8 lshift TIM2_CCMR2_Input ; \ TIM2_CCMR2_Input_CC4S, Capture/Compare 4  selection
: TIM2_CCMR2_Input_IC3F ( %bbbb -- x addr ) 4 lshift TIM2_CCMR2_Input ; \ TIM2_CCMR2_Input_IC3F, Input capture 3 filter
: TIM2_CCMR2_Input_IC3PSC ( %bb -- x addr ) 2 lshift TIM2_CCMR2_Input ; \ TIM2_CCMR2_Input_IC3PSC, Input capture 3 prescaler
: TIM2_CCMR2_Input_CC3S ( %bb -- x addr ) TIM2_CCMR2_Input ; \ TIM2_CCMR2_Input_CC3S, Capture/Compare 3  selection

\ TIM2_CCER (read-write) Reset:0x0000
: TIM2_CCER_CC4NP ( -- x addr ) 15 bit TIM2_CCER ; \ TIM2_CCER_CC4NP, Capture/Compare 4 output  Polarity
: TIM2_CCER_CC4P ( -- x addr ) 13 bit TIM2_CCER ; \ TIM2_CCER_CC4P, Capture/Compare 3 output  Polarity
: TIM2_CCER_CC4E ( -- x addr ) 12 bit TIM2_CCER ; \ TIM2_CCER_CC4E, Capture/Compare 4 output  enable
: TIM2_CCER_CC3NP ( -- x addr ) 11 bit TIM2_CCER ; \ TIM2_CCER_CC3NP, Capture/Compare 3 output  Polarity
: TIM2_CCER_CC3P ( -- x addr ) 9 bit TIM2_CCER ; \ TIM2_CCER_CC3P, Capture/Compare 3 output  Polarity
: TIM2_CCER_CC3E ( -- x addr ) 8 bit TIM2_CCER ; \ TIM2_CCER_CC3E, Capture/Compare 3 output  enable
: TIM2_CCER_CC2NP ( -- x addr ) 7 bit TIM2_CCER ; \ TIM2_CCER_CC2NP, Capture/Compare 2 output  Polarity
: TIM2_CCER_CC2P ( -- x addr ) 5 bit TIM2_CCER ; \ TIM2_CCER_CC2P, Capture/Compare 2 output  Polarity
: TIM2_CCER_CC2E ( -- x addr ) 4 bit TIM2_CCER ; \ TIM2_CCER_CC2E, Capture/Compare 2 output  enable
: TIM2_CCER_CC1NP ( -- x addr ) 3 bit TIM2_CCER ; \ TIM2_CCER_CC1NP, Capture/Compare 1 output  Polarity
: TIM2_CCER_CC1P ( -- x addr ) 1 bit TIM2_CCER ; \ TIM2_CCER_CC1P, Capture/Compare 1 output  Polarity
: TIM2_CCER_CC1E ( -- x addr ) 0 bit TIM2_CCER ; \ TIM2_CCER_CC1E, Capture/Compare 1 output  enable

\ TIM2_CNT (read-write) Reset:0x00000000
: TIM2_CNT_CNT_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2_CNT ; \ TIM2_CNT_CNT_H, High counter value TIM2  only
: TIM2_CNT_CNT_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_CNT ; \ TIM2_CNT_CNT_L, Low counter value

\ TIM2_PSC (read-write) Reset:0x0000
: TIM2_PSC_PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_PSC ; \ TIM2_PSC_PSC, Prescaler value

\ TIM2_ARR (read-write) Reset:0x00000000
: TIM2_ARR_ARR_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2_ARR ; \ TIM2_ARR_ARR_H, High Auto-reload value TIM2  only
: TIM2_ARR_ARR_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_ARR ; \ TIM2_ARR_ARR_L, Low Auto-reload value

\ TIM2_CCR1 (read-write) Reset:0x00000000
: TIM2_CCR1_CCR1_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2_CCR1 ; \ TIM2_CCR1_CCR1_H, High Capture/Compare 1 value TIM2  only
: TIM2_CCR1_CCR1_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_CCR1 ; \ TIM2_CCR1_CCR1_L, Low Capture/Compare 1  value

\ TIM2_CCR2 (read-write) Reset:0x00000000
: TIM2_CCR2_CCR2_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2_CCR2 ; \ TIM2_CCR2_CCR2_H, High Capture/Compare 2 value TIM2  only
: TIM2_CCR2_CCR2_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_CCR2 ; \ TIM2_CCR2_CCR2_L, Low Capture/Compare 2  value

\ TIM2_CCR3 (read-write) Reset:0x00000000
: TIM2_CCR3_CCR3_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2_CCR3 ; \ TIM2_CCR3_CCR3_H, High Capture/Compare value TIM2  only
: TIM2_CCR3_CCR3_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_CCR3 ; \ TIM2_CCR3_CCR3_L, Low Capture/Compare value

\ TIM2_CCR4 (read-write) Reset:0x00000000
: TIM2_CCR4_CCR4_H ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift TIM2_CCR4 ; \ TIM2_CCR4_CCR4_H, High Capture/Compare value TIM2  only
: TIM2_CCR4_CCR4_L ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_CCR4 ; \ TIM2_CCR4_CCR4_L, Low Capture/Compare value

\ TIM2_DCR (read-write) Reset:0x0000
: TIM2_DCR_DBL ( %bbbbb -- x addr ) 8 lshift TIM2_DCR ; \ TIM2_DCR_DBL, DMA burst length
: TIM2_DCR_DBA ( %bbbbb -- x addr ) TIM2_DCR ; \ TIM2_DCR_DBA, DMA base address

\ TIM2_DMAR (read-write) Reset:0x0000
: TIM2_DMAR_DMAB ( %bbbbbbbbbbbbbbbb -- x addr ) TIM2_DMAR ; \ TIM2_DMAR_DMAB, DMA register for burst  accesses

\ TIM2_OR (read-write) Reset:0x0000
: TIM2_OR_ETR_RMP ( %bbb -- x addr ) TIM2_OR ; \ TIM2_OR_ETR_RMP, Timer2 ETR remap
: TIM2_OR_TI4_RMP ( %bb -- x addr ) 3 lshift TIM2_OR ; \ TIM2_OR_TI4_RMP, Internal trigger

\ TIM6_CR1 (read-write) Reset:0x0000
: TIM6_CR1_ARPE ( -- x addr ) 7 bit TIM6_CR1 ; \ TIM6_CR1_ARPE, Auto-reload preload enable
: TIM6_CR1_OPM ( -- x addr ) 3 bit TIM6_CR1 ; \ TIM6_CR1_OPM, One-pulse mode
: TIM6_CR1_URS ( -- x addr ) 2 bit TIM6_CR1 ; \ TIM6_CR1_URS, Update request source
: TIM6_CR1_UDIS ( -- x addr ) 1 bit TIM6_CR1 ; \ TIM6_CR1_UDIS, Update disable
: TIM6_CR1_CEN ( -- x addr ) 0 bit TIM6_CR1 ; \ TIM6_CR1_CEN, Counter enable

\ TIM6_CR2 (read-write) Reset:0x0000
: TIM6_CR2_MMS ( %bbb -- x addr ) 4 lshift TIM6_CR2 ; \ TIM6_CR2_MMS, Master mode selection

\ TIM6_DIER (read-write) Reset:0x0000
: TIM6_DIER_UDE ( -- x addr ) 8 bit TIM6_DIER ; \ TIM6_DIER_UDE, Update DMA request enable
: TIM6_DIER_UIE ( -- x addr ) 0 bit TIM6_DIER ; \ TIM6_DIER_UIE, Update interrupt enable

\ TIM6_SR (read-write) Reset:0x0000
: TIM6_SR_UIF ( -- x addr ) 0 bit TIM6_SR ; \ TIM6_SR_UIF, Update interrupt flag

\ TIM6_EGR (write-only) Reset:0x0000
: TIM6_EGR_UG ( -- x addr ) 0 bit TIM6_EGR ; \ TIM6_EGR_UG, Update generation

\ TIM6_CNT (read-write) Reset:0x00000000
: TIM6_CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) TIM6_CNT ; \ TIM6_CNT_CNT, Low counter value

\ TIM6_PSC (read-write) Reset:0x0000
: TIM6_PSC_PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIM6_PSC ; \ TIM6_PSC_PSC, Prescaler value

\ TIM6_ARR (read-write) Reset:0x00000000
: TIM6_ARR_ARR ( %bbbbbbbbbbbbbbbb -- x addr ) TIM6_ARR ; \ TIM6_ARR_ARR, Low Auto-reload value

\ TIM21_CR1 (read-write) Reset:0x0000
: TIM21_CR1_CEN ( -- x addr ) 0 bit TIM21_CR1 ; \ TIM21_CR1_CEN, Counter enable
: TIM21_CR1_UDIS ( -- x addr ) 1 bit TIM21_CR1 ; \ TIM21_CR1_UDIS, Update disable
: TIM21_CR1_URS ( -- x addr ) 2 bit TIM21_CR1 ; \ TIM21_CR1_URS, Update request source
: TIM21_CR1_OPM ( -- x addr ) 3 bit TIM21_CR1 ; \ TIM21_CR1_OPM, One-pulse mode
: TIM21_CR1_DIR ( -- x addr ) 4 bit TIM21_CR1 ; \ TIM21_CR1_DIR, Direction
: TIM21_CR1_CMS ( %bb -- x addr ) 5 lshift TIM21_CR1 ; \ TIM21_CR1_CMS, Center-aligned mode  selection
: TIM21_CR1_ARPE ( -- x addr ) 7 bit TIM21_CR1 ; \ TIM21_CR1_ARPE, Auto-reload preload enable
: TIM21_CR1_CKD ( %bb -- x addr ) 8 lshift TIM21_CR1 ; \ TIM21_CR1_CKD, Clock division

\ TIM21_CR2 (read-write) Reset:0x0000
: TIM21_CR2_MMS ( %bbb -- x addr ) 4 lshift TIM21_CR2 ; \ TIM21_CR2_MMS, Master mode selection

\ TIM21_SMCR (read-write) Reset:0x0000
: TIM21_SMCR_SMS ( %bbb -- x addr ) TIM21_SMCR ; \ TIM21_SMCR_SMS, Slave mode selection
: TIM21_SMCR_TS ( %bbb -- x addr ) 4 lshift TIM21_SMCR ; \ TIM21_SMCR_TS, Trigger selection
: TIM21_SMCR_MSM ( -- x addr ) 7 bit TIM21_SMCR ; \ TIM21_SMCR_MSM, Master/Slave mode
: TIM21_SMCR_ETF ( %bbbb -- x addr ) 8 lshift TIM21_SMCR ; \ TIM21_SMCR_ETF, External trigger filter
: TIM21_SMCR_ETPS ( %bb -- x addr ) 12 lshift TIM21_SMCR ; \ TIM21_SMCR_ETPS, External trigger prescaler
: TIM21_SMCR_ECE ( -- x addr ) 14 bit TIM21_SMCR ; \ TIM21_SMCR_ECE, External clock enable
: TIM21_SMCR_ETP ( -- x addr ) 15 bit TIM21_SMCR ; \ TIM21_SMCR_ETP, External trigger polarity

\ TIM21_DIER (read-write) Reset:0x0000
: TIM21_DIER_TIE ( -- x addr ) 6 bit TIM21_DIER ; \ TIM21_DIER_TIE, Trigger interrupt enable
: TIM21_DIER_CC2IE ( -- x addr ) 2 bit TIM21_DIER ; \ TIM21_DIER_CC2IE, Capture/Compare 2 interrupt  enable
: TIM21_DIER_CC1IE ( -- x addr ) 1 bit TIM21_DIER ; \ TIM21_DIER_CC1IE, Capture/Compare 1 interrupt  enable
: TIM21_DIER_UIE ( -- x addr ) 0 bit TIM21_DIER ; \ TIM21_DIER_UIE, Update interrupt enable

\ TIM21_SR (read-write) Reset:0x0000
: TIM21_SR_CC2OF ( -- x addr ) 10 bit TIM21_SR ; \ TIM21_SR_CC2OF, Capture/compare 2 overcapture  flag
: TIM21_SR_CC1OF ( -- x addr ) 9 bit TIM21_SR ; \ TIM21_SR_CC1OF, Capture/Compare 1 overcapture  flag
: TIM21_SR_TIF ( -- x addr ) 6 bit TIM21_SR ; \ TIM21_SR_TIF, Trigger interrupt flag
: TIM21_SR_CC2IF ( -- x addr ) 2 bit TIM21_SR ; \ TIM21_SR_CC2IF, Capture/Compare 2 interrupt  flag
: TIM21_SR_CC1IF ( -- x addr ) 1 bit TIM21_SR ; \ TIM21_SR_CC1IF, Capture/compare 1 interrupt  flag
: TIM21_SR_UIF ( -- x addr ) 0 bit TIM21_SR ; \ TIM21_SR_UIF, Update interrupt flag

\ TIM21_EGR (write-only) Reset:0x0000
: TIM21_EGR_TG ( -- x addr ) 6 bit TIM21_EGR ; \ TIM21_EGR_TG, Trigger generation
: TIM21_EGR_CC2G ( -- x addr ) 2 bit TIM21_EGR ; \ TIM21_EGR_CC2G, Capture/compare 2  generation
: TIM21_EGR_CC1G ( -- x addr ) 1 bit TIM21_EGR ; \ TIM21_EGR_CC1G, Capture/compare 1  generation
: TIM21_EGR_UG ( -- x addr ) 0 bit TIM21_EGR ; \ TIM21_EGR_UG, Update generation

\ TIM21_CCMR1_Output (read-write) Reset:0x00000000
: TIM21_CCMR1_Output_OC2M ( %bbb -- x addr ) 12 lshift TIM21_CCMR1_Output ; \ TIM21_CCMR1_Output_OC2M, Output Compare 2 mode
: TIM21_CCMR1_Output_OC2PE ( -- x addr ) 11 bit TIM21_CCMR1_Output ; \ TIM21_CCMR1_Output_OC2PE, Output Compare 2 preload  enable
: TIM21_CCMR1_Output_OC2FE ( -- x addr ) 10 bit TIM21_CCMR1_Output ; \ TIM21_CCMR1_Output_OC2FE, Output Compare 2 fast  enable
: TIM21_CCMR1_Output_CC2S ( %bb -- x addr ) 8 lshift TIM21_CCMR1_Output ; \ TIM21_CCMR1_Output_CC2S, Capture/Compare 2  selection
: TIM21_CCMR1_Output_OC1M ( %bbb -- x addr ) 4 lshift TIM21_CCMR1_Output ; \ TIM21_CCMR1_Output_OC1M, Output Compare 1 mode
: TIM21_CCMR1_Output_OC1PE ( -- x addr ) 3 bit TIM21_CCMR1_Output ; \ TIM21_CCMR1_Output_OC1PE, Output Compare 1 preload  enable
: TIM21_CCMR1_Output_OC1FE ( -- x addr ) 2 bit TIM21_CCMR1_Output ; \ TIM21_CCMR1_Output_OC1FE, Output Compare 1 fast  enable
: TIM21_CCMR1_Output_CC1S ( %bb -- x addr ) TIM21_CCMR1_Output ; \ TIM21_CCMR1_Output_CC1S, Capture/Compare 1  selection

\ TIM21_CCMR1_Input (read-write) Reset:0x00000000
: TIM21_CCMR1_Input_IC2F ( %bbbb -- x addr ) 12 lshift TIM21_CCMR1_Input ; \ TIM21_CCMR1_Input_IC2F, Input capture 2 filter
: TIM21_CCMR1_Input_IC2PSC ( %bb -- x addr ) 10 lshift TIM21_CCMR1_Input ; \ TIM21_CCMR1_Input_IC2PSC, Input capture 2 prescaler
: TIM21_CCMR1_Input_CC2S ( %bb -- x addr ) 8 lshift TIM21_CCMR1_Input ; \ TIM21_CCMR1_Input_CC2S, Capture/Compare 2  selection
: TIM21_CCMR1_Input_IC1F ( %bbbb -- x addr ) 4 lshift TIM21_CCMR1_Input ; \ TIM21_CCMR1_Input_IC1F, Input capture 1 filter
: TIM21_CCMR1_Input_IC1PSC ( %bb -- x addr ) 2 lshift TIM21_CCMR1_Input ; \ TIM21_CCMR1_Input_IC1PSC, Input capture 1 prescaler
: TIM21_CCMR1_Input_CC1S ( %bb -- x addr ) TIM21_CCMR1_Input ; \ TIM21_CCMR1_Input_CC1S, Capture/Compare 1  selection

\ TIM21_CCER (read-write) Reset:0x0000
: TIM21_CCER_CC2NP ( -- x addr ) 7 bit TIM21_CCER ; \ TIM21_CCER_CC2NP, Capture/Compare 2 output  Polarity
: TIM21_CCER_CC2P ( -- x addr ) 5 bit TIM21_CCER ; \ TIM21_CCER_CC2P, Capture/Compare 2 output  Polarity
: TIM21_CCER_CC2E ( -- x addr ) 4 bit TIM21_CCER ; \ TIM21_CCER_CC2E, Capture/Compare 2 output  enable
: TIM21_CCER_CC1NP ( -- x addr ) 3 bit TIM21_CCER ; \ TIM21_CCER_CC1NP, Capture/Compare 1 output  Polarity
: TIM21_CCER_CC1P ( -- x addr ) 1 bit TIM21_CCER ; \ TIM21_CCER_CC1P, Capture/Compare 1 output  Polarity
: TIM21_CCER_CC1E ( -- x addr ) 0 bit TIM21_CCER ; \ TIM21_CCER_CC1E, Capture/Compare 1 output  enable

\ TIM21_CNT (read-write) Reset:0x00000000
: TIM21_CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) TIM21_CNT ; \ TIM21_CNT_CNT, counter value

\ TIM21_PSC (read-write) Reset:0x0000
: TIM21_PSC_PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIM21_PSC ; \ TIM21_PSC_PSC, Prescaler value

\ TIM21_ARR (read-write) Reset:0x00000000
: TIM21_ARR_ARR ( %bbbbbbbbbbbbbbbb -- x addr ) TIM21_ARR ; \ TIM21_ARR_ARR, Auto-reload value

\ TIM21_CCR1 (read-write) Reset:0x00000000
: TIM21_CCR1_CCR1 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM21_CCR1 ; \ TIM21_CCR1_CCR1, Capture/Compare 1 value

\ TIM21_CCR2 (read-write) Reset:0x00000000
: TIM21_CCR2_CCR2 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM21_CCR2 ; \ TIM21_CCR2_CCR2, Capture/Compare 2 value

\ TIM21_OR (read-write) Reset:0x00000000
: TIM21_OR_ETR_RMP ( %bb -- x addr ) TIM21_OR ; \ TIM21_OR_ETR_RMP, Timer21 ETR remap
: TIM21_OR_TI1_RMP ( %bbb -- x addr ) 2 lshift TIM21_OR ; \ TIM21_OR_TI1_RMP, Timer21 TI1
: TIM21_OR_TI2_RMP ( -- x addr ) 5 bit TIM21_OR ; \ TIM21_OR_TI2_RMP, Timer21 TI2

\ TIM22_CR1 (read-write) Reset:0x0000
: TIM22_CR1_CEN ( -- x addr ) 0 bit TIM22_CR1 ; \ TIM22_CR1_CEN, Counter enable
: TIM22_CR1_UDIS ( -- x addr ) 1 bit TIM22_CR1 ; \ TIM22_CR1_UDIS, Update disable
: TIM22_CR1_URS ( -- x addr ) 2 bit TIM22_CR1 ; \ TIM22_CR1_URS, Update request source
: TIM22_CR1_OPM ( -- x addr ) 3 bit TIM22_CR1 ; \ TIM22_CR1_OPM, One-pulse mode
: TIM22_CR1_DIR ( -- x addr ) 4 bit TIM22_CR1 ; \ TIM22_CR1_DIR, Direction
: TIM22_CR1_CMS ( %bb -- x addr ) 5 lshift TIM22_CR1 ; \ TIM22_CR1_CMS, Center-aligned mode  selection
: TIM22_CR1_ARPE ( -- x addr ) 7 bit TIM22_CR1 ; \ TIM22_CR1_ARPE, Auto-reload preload enable
: TIM22_CR1_CKD ( %bb -- x addr ) 8 lshift TIM22_CR1 ; \ TIM22_CR1_CKD, Clock division

\ TIM22_CR2 (read-write) Reset:0x0000
: TIM22_CR2_MMS ( %bbb -- x addr ) 4 lshift TIM22_CR2 ; \ TIM22_CR2_MMS, Master mode selection

\ TIM22_SMCR (read-write) Reset:0x0000
: TIM22_SMCR_SMS ( %bbb -- x addr ) TIM22_SMCR ; \ TIM22_SMCR_SMS, Slave mode selection
: TIM22_SMCR_TS ( %bbb -- x addr ) 4 lshift TIM22_SMCR ; \ TIM22_SMCR_TS, Trigger selection
: TIM22_SMCR_MSM ( -- x addr ) 7 bit TIM22_SMCR ; \ TIM22_SMCR_MSM, Master/Slave mode
: TIM22_SMCR_ETF ( %bbbb -- x addr ) 8 lshift TIM22_SMCR ; \ TIM22_SMCR_ETF, External trigger filter
: TIM22_SMCR_ETPS ( %bb -- x addr ) 12 lshift TIM22_SMCR ; \ TIM22_SMCR_ETPS, External trigger prescaler
: TIM22_SMCR_ECE ( -- x addr ) 14 bit TIM22_SMCR ; \ TIM22_SMCR_ECE, External clock enable
: TIM22_SMCR_ETP ( -- x addr ) 15 bit TIM22_SMCR ; \ TIM22_SMCR_ETP, External trigger polarity

\ TIM22_DIER (read-write) Reset:0x0000
: TIM22_DIER_TIE ( -- x addr ) 6 bit TIM22_DIER ; \ TIM22_DIER_TIE, Trigger interrupt enable
: TIM22_DIER_CC2IE ( -- x addr ) 2 bit TIM22_DIER ; \ TIM22_DIER_CC2IE, Capture/Compare 2 interrupt  enable
: TIM22_DIER_CC1IE ( -- x addr ) 1 bit TIM22_DIER ; \ TIM22_DIER_CC1IE, Capture/Compare 1 interrupt  enable
: TIM22_DIER_UIE ( -- x addr ) 0 bit TIM22_DIER ; \ TIM22_DIER_UIE, Update interrupt enable

\ TIM22_SR (read-write) Reset:0x0000
: TIM22_SR_CC2OF ( -- x addr ) 10 bit TIM22_SR ; \ TIM22_SR_CC2OF, Capture/compare 2 overcapture  flag
: TIM22_SR_CC1OF ( -- x addr ) 9 bit TIM22_SR ; \ TIM22_SR_CC1OF, Capture/Compare 1 overcapture  flag
: TIM22_SR_TIF ( -- x addr ) 6 bit TIM22_SR ; \ TIM22_SR_TIF, Trigger interrupt flag
: TIM22_SR_CC2IF ( -- x addr ) 2 bit TIM22_SR ; \ TIM22_SR_CC2IF, Capture/Compare 2 interrupt  flag
: TIM22_SR_CC1IF ( -- x addr ) 1 bit TIM22_SR ; \ TIM22_SR_CC1IF, Capture/compare 1 interrupt  flag
: TIM22_SR_UIF ( -- x addr ) 0 bit TIM22_SR ; \ TIM22_SR_UIF, Update interrupt flag

\ TIM22_EGR (write-only) Reset:0x0000
: TIM22_EGR_TG ( -- x addr ) 6 bit TIM22_EGR ; \ TIM22_EGR_TG, Trigger generation
: TIM22_EGR_CC2G ( -- x addr ) 2 bit TIM22_EGR ; \ TIM22_EGR_CC2G, Capture/compare 2  generation
: TIM22_EGR_CC1G ( -- x addr ) 1 bit TIM22_EGR ; \ TIM22_EGR_CC1G, Capture/compare 1  generation
: TIM22_EGR_UG ( -- x addr ) 0 bit TIM22_EGR ; \ TIM22_EGR_UG, Update generation

\ TIM22_CCMR1_Output (read-write) Reset:0x00000000
: TIM22_CCMR1_Output_OC2M ( %bbb -- x addr ) 12 lshift TIM22_CCMR1_Output ; \ TIM22_CCMR1_Output_OC2M, Output Compare 2 mode
: TIM22_CCMR1_Output_OC2PE ( -- x addr ) 11 bit TIM22_CCMR1_Output ; \ TIM22_CCMR1_Output_OC2PE, Output Compare 2 preload  enable
: TIM22_CCMR1_Output_OC2FE ( -- x addr ) 10 bit TIM22_CCMR1_Output ; \ TIM22_CCMR1_Output_OC2FE, Output Compare 2 fast  enable
: TIM22_CCMR1_Output_CC2S ( %bb -- x addr ) 8 lshift TIM22_CCMR1_Output ; \ TIM22_CCMR1_Output_CC2S, Capture/Compare 2  selection
: TIM22_CCMR1_Output_OC1M ( %bbb -- x addr ) 4 lshift TIM22_CCMR1_Output ; \ TIM22_CCMR1_Output_OC1M, Output Compare 1 mode
: TIM22_CCMR1_Output_OC1PE ( -- x addr ) 3 bit TIM22_CCMR1_Output ; \ TIM22_CCMR1_Output_OC1PE, Output Compare 1 preload  enable
: TIM22_CCMR1_Output_OC1FE ( -- x addr ) 2 bit TIM22_CCMR1_Output ; \ TIM22_CCMR1_Output_OC1FE, Output Compare 1 fast  enable
: TIM22_CCMR1_Output_CC1S ( %bb -- x addr ) TIM22_CCMR1_Output ; \ TIM22_CCMR1_Output_CC1S, Capture/Compare 1  selection

\ TIM22_CCMR1_Input (read-write) Reset:0x00000000
: TIM22_CCMR1_Input_IC2F ( %bbbb -- x addr ) 12 lshift TIM22_CCMR1_Input ; \ TIM22_CCMR1_Input_IC2F, Input capture 2 filter
: TIM22_CCMR1_Input_IC2PSC ( %bb -- x addr ) 10 lshift TIM22_CCMR1_Input ; \ TIM22_CCMR1_Input_IC2PSC, Input capture 2 prescaler
: TIM22_CCMR1_Input_CC2S ( %bb -- x addr ) 8 lshift TIM22_CCMR1_Input ; \ TIM22_CCMR1_Input_CC2S, Capture/Compare 2  selection
: TIM22_CCMR1_Input_IC1F ( %bbbb -- x addr ) 4 lshift TIM22_CCMR1_Input ; \ TIM22_CCMR1_Input_IC1F, Input capture 1 filter
: TIM22_CCMR1_Input_IC1PSC ( %bb -- x addr ) 2 lshift TIM22_CCMR1_Input ; \ TIM22_CCMR1_Input_IC1PSC, Input capture 1 prescaler
: TIM22_CCMR1_Input_CC1S ( %bb -- x addr ) TIM22_CCMR1_Input ; \ TIM22_CCMR1_Input_CC1S, Capture/Compare 1  selection

\ TIM22_CCER (read-write) Reset:0x0000
: TIM22_CCER_CC2NP ( -- x addr ) 7 bit TIM22_CCER ; \ TIM22_CCER_CC2NP, Capture/Compare 2 output  Polarity
: TIM22_CCER_CC2P ( -- x addr ) 5 bit TIM22_CCER ; \ TIM22_CCER_CC2P, Capture/Compare 2 output  Polarity
: TIM22_CCER_CC2E ( -- x addr ) 4 bit TIM22_CCER ; \ TIM22_CCER_CC2E, Capture/Compare 2 output  enable
: TIM22_CCER_CC1NP ( -- x addr ) 3 bit TIM22_CCER ; \ TIM22_CCER_CC1NP, Capture/Compare 1 output  Polarity
: TIM22_CCER_CC1P ( -- x addr ) 1 bit TIM22_CCER ; \ TIM22_CCER_CC1P, Capture/Compare 1 output  Polarity
: TIM22_CCER_CC1E ( -- x addr ) 0 bit TIM22_CCER ; \ TIM22_CCER_CC1E, Capture/Compare 1 output  enable

\ TIM22_CNT (read-write) Reset:0x00000000
: TIM22_CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) TIM22_CNT ; \ TIM22_CNT_CNT, counter value

\ TIM22_PSC (read-write) Reset:0x0000
: TIM22_PSC_PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIM22_PSC ; \ TIM22_PSC_PSC, Prescaler value

\ TIM22_ARR (read-write) Reset:0x00000000
: TIM22_ARR_ARR ( %bbbbbbbbbbbbbbbb -- x addr ) TIM22_ARR ; \ TIM22_ARR_ARR, Auto-reload value

\ TIM22_CCR1 (read-write) Reset:0x00000000
: TIM22_CCR1_CCR1 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM22_CCR1 ; \ TIM22_CCR1_CCR1, Capture/Compare 1 value

\ TIM22_CCR2 (read-write) Reset:0x00000000
: TIM22_CCR2_CCR2 ( %bbbbbbbbbbbbbbbb -- x addr ) TIM22_CCR2 ; \ TIM22_CCR2_CCR2, Capture/Compare 2 value

\ TIM22_OR (read-write) Reset:0x00000000
: TIM22_OR_ETR_RMP ( %bb -- x addr ) TIM22_OR ; \ TIM22_OR_ETR_RMP, Timer22 ETR remap
: TIM22_OR_TI1_RMP ( %bb -- x addr ) 2 lshift TIM22_OR ; \ TIM22_OR_TI1_RMP, Timer22 TI1

\ LPUSART1_CR1 (read-write) Reset:0x0000
: LPUSART1_CR1_M1 ( -- x addr ) 28 bit LPUSART1_CR1 ; \ LPUSART1_CR1_M1, Word length
: LPUSART1_CR1_DEAT4 ( -- x addr ) 25 bit LPUSART1_CR1 ; \ LPUSART1_CR1_DEAT4, Driver Enable assertion  time
: LPUSART1_CR1_DEAT3 ( -- x addr ) 24 bit LPUSART1_CR1 ; \ LPUSART1_CR1_DEAT3, DEAT3
: LPUSART1_CR1_DEAT2 ( -- x addr ) 23 bit LPUSART1_CR1 ; \ LPUSART1_CR1_DEAT2, DEAT2
: LPUSART1_CR1_DEAT1 ( -- x addr ) 22 bit LPUSART1_CR1 ; \ LPUSART1_CR1_DEAT1, DEAT1
: LPUSART1_CR1_DEAT0 ( -- x addr ) 21 bit LPUSART1_CR1 ; \ LPUSART1_CR1_DEAT0, DEAT0
: LPUSART1_CR1_DEDT4 ( -- x addr ) 20 bit LPUSART1_CR1 ; \ LPUSART1_CR1_DEDT4, Driver Enable de-assertion  time
: LPUSART1_CR1_DEDT3 ( -- x addr ) 19 bit LPUSART1_CR1 ; \ LPUSART1_CR1_DEDT3, DEDT3
: LPUSART1_CR1_DEDT2 ( -- x addr ) 18 bit LPUSART1_CR1 ; \ LPUSART1_CR1_DEDT2, DEDT2
: LPUSART1_CR1_DEDT1 ( -- x addr ) 17 bit LPUSART1_CR1 ; \ LPUSART1_CR1_DEDT1, DEDT1
: LPUSART1_CR1_DEDT0 ( -- x addr ) 16 bit LPUSART1_CR1 ; \ LPUSART1_CR1_DEDT0, DEDT0
: LPUSART1_CR1_CMIE ( -- x addr ) 14 bit LPUSART1_CR1 ; \ LPUSART1_CR1_CMIE, Character match interrupt  enable
: LPUSART1_CR1_MME ( -- x addr ) 13 bit LPUSART1_CR1 ; \ LPUSART1_CR1_MME, Mute mode enable
: LPUSART1_CR1_M0 ( -- x addr ) 12 bit LPUSART1_CR1 ; \ LPUSART1_CR1_M0, Word length
: LPUSART1_CR1_WAKE ( -- x addr ) 11 bit LPUSART1_CR1 ; \ LPUSART1_CR1_WAKE, Receiver wakeup method
: LPUSART1_CR1_PCE ( -- x addr ) 10 bit LPUSART1_CR1 ; \ LPUSART1_CR1_PCE, Parity control enable
: LPUSART1_CR1_PS ( -- x addr ) 9 bit LPUSART1_CR1 ; \ LPUSART1_CR1_PS, Parity selection
: LPUSART1_CR1_PEIE ( -- x addr ) 8 bit LPUSART1_CR1 ; \ LPUSART1_CR1_PEIE, PE interrupt enable
: LPUSART1_CR1_TXEIE ( -- x addr ) 7 bit LPUSART1_CR1 ; \ LPUSART1_CR1_TXEIE, interrupt enable
: LPUSART1_CR1_TCIE ( -- x addr ) 6 bit LPUSART1_CR1 ; \ LPUSART1_CR1_TCIE, Transmission complete interrupt  enable
: LPUSART1_CR1_RXNEIE ( -- x addr ) 5 bit LPUSART1_CR1 ; \ LPUSART1_CR1_RXNEIE, RXNE interrupt enable
: LPUSART1_CR1_IDLEIE ( -- x addr ) 4 bit LPUSART1_CR1 ; \ LPUSART1_CR1_IDLEIE, IDLE interrupt enable
: LPUSART1_CR1_TE ( -- x addr ) 3 bit LPUSART1_CR1 ; \ LPUSART1_CR1_TE, Transmitter enable
: LPUSART1_CR1_RE ( -- x addr ) 2 bit LPUSART1_CR1 ; \ LPUSART1_CR1_RE, Receiver enable
: LPUSART1_CR1_UESM ( -- x addr ) 1 bit LPUSART1_CR1 ; \ LPUSART1_CR1_UESM, USART enable in Stop mode
: LPUSART1_CR1_UE ( -- x addr ) 0 bit LPUSART1_CR1 ; \ LPUSART1_CR1_UE, USART enable

\ LPUSART1_CR2 (read-write) Reset:0x0000
: LPUSART1_CR2_ADD4_7 ( %bbbb -- x addr ) 28 lshift LPUSART1_CR2 ; \ LPUSART1_CR2_ADD4_7, Address of the USART node
: LPUSART1_CR2_ADD0_3 ( %bbbb -- x addr ) 24 lshift LPUSART1_CR2 ; \ LPUSART1_CR2_ADD0_3, Address of the USART node
: LPUSART1_CR2_MSBFIRST ( -- x addr ) 19 bit LPUSART1_CR2 ; \ LPUSART1_CR2_MSBFIRST, Most significant bit first
: LPUSART1_CR2_TAINV ( -- x addr ) 18 bit LPUSART1_CR2 ; \ LPUSART1_CR2_TAINV, Binary data inversion
: LPUSART1_CR2_TXINV ( -- x addr ) 17 bit LPUSART1_CR2 ; \ LPUSART1_CR2_TXINV, TX pin active level  inversion
: LPUSART1_CR2_RXINV ( -- x addr ) 16 bit LPUSART1_CR2 ; \ LPUSART1_CR2_RXINV, RX pin active level  inversion
: LPUSART1_CR2_SWAP ( -- x addr ) 15 bit LPUSART1_CR2 ; \ LPUSART1_CR2_SWAP, Swap TX/RX pins
: LPUSART1_CR2_STOP ( %bb -- x addr ) 12 lshift LPUSART1_CR2 ; \ LPUSART1_CR2_STOP, STOP bits
: LPUSART1_CR2_CLKEN ( -- x addr ) 11 bit LPUSART1_CR2 ; \ LPUSART1_CR2_CLKEN, Clock enable
: LPUSART1_CR2_ADDM7 ( -- x addr ) 4 bit LPUSART1_CR2 ; \ LPUSART1_CR2_ADDM7, 7-bit Address Detection/4-bit Address  Detection

\ LPUSART1_CR3 (read-write) Reset:0x0000
: LPUSART1_CR3_WUFIE ( -- x addr ) 22 bit LPUSART1_CR3 ; \ LPUSART1_CR3_WUFIE, Wakeup from Stop mode interrupt  enable
: LPUSART1_CR3_WUS ( %bb -- x addr ) 20 lshift LPUSART1_CR3 ; \ LPUSART1_CR3_WUS, Wakeup from Stop mode interrupt flag  selection
: LPUSART1_CR3_DEP ( -- x addr ) 15 bit LPUSART1_CR3 ; \ LPUSART1_CR3_DEP, Driver enable polarity  selection
: LPUSART1_CR3_DEM ( -- x addr ) 14 bit LPUSART1_CR3 ; \ LPUSART1_CR3_DEM, Driver enable mode
: LPUSART1_CR3_DDRE ( -- x addr ) 13 bit LPUSART1_CR3 ; \ LPUSART1_CR3_DDRE, DMA Disable on Reception  Error
: LPUSART1_CR3_OVRDIS ( -- x addr ) 12 bit LPUSART1_CR3 ; \ LPUSART1_CR3_OVRDIS, Overrun Disable
: LPUSART1_CR3_CTSIE ( -- x addr ) 10 bit LPUSART1_CR3 ; \ LPUSART1_CR3_CTSIE, CTS interrupt enable
: LPUSART1_CR3_CTSE ( -- x addr ) 9 bit LPUSART1_CR3 ; \ LPUSART1_CR3_CTSE, CTS enable
: LPUSART1_CR3_RTSE ( -- x addr ) 8 bit LPUSART1_CR3 ; \ LPUSART1_CR3_RTSE, RTS enable
: LPUSART1_CR3_DMAT ( -- x addr ) 7 bit LPUSART1_CR3 ; \ LPUSART1_CR3_DMAT, DMA enable transmitter
: LPUSART1_CR3_DMAR ( -- x addr ) 6 bit LPUSART1_CR3 ; \ LPUSART1_CR3_DMAR, DMA enable receiver
: LPUSART1_CR3_HDSEL ( -- x addr ) 3 bit LPUSART1_CR3 ; \ LPUSART1_CR3_HDSEL, Half-duplex selection
: LPUSART1_CR3_EIE ( -- x addr ) 0 bit LPUSART1_CR3 ; \ LPUSART1_CR3_EIE, Error interrupt enable

\ LPUSART1_BRR (read-write) Reset:0x0000
: LPUSART1_BRR_BRR ( %bbbbbbbbbbbbbbbbbbbb -- x addr ) LPUSART1_BRR ; \ LPUSART1_BRR_BRR, BRR

\ LPUSART1_RQR (write-only) Reset:0x0000
: LPUSART1_RQR_RXFRQ ( -- x addr ) 3 bit LPUSART1_RQR ; \ LPUSART1_RQR_RXFRQ, Receive data flush request
: LPUSART1_RQR_MMRQ ( -- x addr ) 2 bit LPUSART1_RQR ; \ LPUSART1_RQR_MMRQ, Mute mode request
: LPUSART1_RQR_SBKRQ ( -- x addr ) 1 bit LPUSART1_RQR ; \ LPUSART1_RQR_SBKRQ, Send break request

\ LPUSART1_ISR (read-only) Reset:0x00C0
: LPUSART1_ISR_REACK? ( --  1|0 ) 22 bit LPUSART1_ISR bit@ ; \ LPUSART1_ISR_REACK, REACK
: LPUSART1_ISR_TEACK? ( --  1|0 ) 21 bit LPUSART1_ISR bit@ ; \ LPUSART1_ISR_TEACK, TEACK
: LPUSART1_ISR_WUF? ( --  1|0 ) 20 bit LPUSART1_ISR bit@ ; \ LPUSART1_ISR_WUF, WUF
: LPUSART1_ISR_RWU? ( --  1|0 ) 19 bit LPUSART1_ISR bit@ ; \ LPUSART1_ISR_RWU, RWU
: LPUSART1_ISR_SBKF? ( --  1|0 ) 18 bit LPUSART1_ISR bit@ ; \ LPUSART1_ISR_SBKF, SBKF
: LPUSART1_ISR_CMF? ( --  1|0 ) 17 bit LPUSART1_ISR bit@ ; \ LPUSART1_ISR_CMF, CMF
: LPUSART1_ISR_BUSY? ( --  1|0 ) 16 bit LPUSART1_ISR bit@ ; \ LPUSART1_ISR_BUSY, BUSY
: LPUSART1_ISR_CTS? ( --  1|0 ) 10 bit LPUSART1_ISR bit@ ; \ LPUSART1_ISR_CTS, CTS
: LPUSART1_ISR_CTSIF? ( --  1|0 ) 9 bit LPUSART1_ISR bit@ ; \ LPUSART1_ISR_CTSIF, CTSIF
: LPUSART1_ISR_TXE? ( --  1|0 ) 7 bit LPUSART1_ISR bit@ ; \ LPUSART1_ISR_TXE, TXE
: LPUSART1_ISR_TC? ( --  1|0 ) 6 bit LPUSART1_ISR bit@ ; \ LPUSART1_ISR_TC, TC
: LPUSART1_ISR_RXNE? ( --  1|0 ) 5 bit LPUSART1_ISR bit@ ; \ LPUSART1_ISR_RXNE, RXNE
: LPUSART1_ISR_IDLE? ( --  1|0 ) 4 bit LPUSART1_ISR bit@ ; \ LPUSART1_ISR_IDLE, IDLE
: LPUSART1_ISR_ORE? ( --  1|0 ) 3 bit LPUSART1_ISR bit@ ; \ LPUSART1_ISR_ORE, ORE
: LPUSART1_ISR_NF? ( --  1|0 ) 2 bit LPUSART1_ISR bit@ ; \ LPUSART1_ISR_NF, NF
: LPUSART1_ISR_FE? ( --  1|0 ) 1 bit LPUSART1_ISR bit@ ; \ LPUSART1_ISR_FE, FE
: LPUSART1_ISR_PE? ( --  1|0 ) 0 bit LPUSART1_ISR bit@ ; \ LPUSART1_ISR_PE, PE

\ LPUSART1_ICR (write-only) Reset:0x0000
: LPUSART1_ICR_WUCF ( -- x addr ) 20 bit LPUSART1_ICR ; \ LPUSART1_ICR_WUCF, Wakeup from Stop mode clear  flag
: LPUSART1_ICR_CMCF ( -- x addr ) 17 bit LPUSART1_ICR ; \ LPUSART1_ICR_CMCF, Character match clear flag
: LPUSART1_ICR_CTSCF ( -- x addr ) 9 bit LPUSART1_ICR ; \ LPUSART1_ICR_CTSCF, CTS clear flag
: LPUSART1_ICR_TCCF ( -- x addr ) 6 bit LPUSART1_ICR ; \ LPUSART1_ICR_TCCF, Transmission complete clear  flag
: LPUSART1_ICR_IDLECF ( -- x addr ) 4 bit LPUSART1_ICR ; \ LPUSART1_ICR_IDLECF, Idle line detected clear  flag
: LPUSART1_ICR_ORECF ( -- x addr ) 3 bit LPUSART1_ICR ; \ LPUSART1_ICR_ORECF, Overrun error clear flag
: LPUSART1_ICR_NCF ( -- x addr ) 2 bit LPUSART1_ICR ; \ LPUSART1_ICR_NCF, Noise detected clear flag
: LPUSART1_ICR_FECF ( -- x addr ) 1 bit LPUSART1_ICR ; \ LPUSART1_ICR_FECF, Framing error clear flag
: LPUSART1_ICR_PECF ( -- x addr ) 0 bit LPUSART1_ICR ; \ LPUSART1_ICR_PECF, Parity error clear flag

\ LPUSART1_RDR (read-only) Reset:0x0000
: LPUSART1_RDR_RDR? ( --  x ) LPUSART1_RDR @ ; \ LPUSART1_RDR_RDR, Receive data value

\ LPUSART1_TDR (read-write) Reset:0x0000
: LPUSART1_TDR_TDR ( %bbbbbbbbb -- x addr ) LPUSART1_TDR ; \ LPUSART1_TDR_TDR, Transmit data value

\ NVIC_ISER (read-write) Reset:0x00000000
: NVIC_ISER_SETENA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) NVIC_ISER ; \ NVIC_ISER_SETENA, SETENA

\ NVIC_ICER (read-write) Reset:0x00000000
: NVIC_ICER_CLRENA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) NVIC_ICER ; \ NVIC_ICER_CLRENA, CLRENA

\ NVIC_ISPR (read-write) Reset:0x00000000
: NVIC_ISPR_SETPEND ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) NVIC_ISPR ; \ NVIC_ISPR_SETPEND, SETPEND

\ NVIC_ICPR (read-write) Reset:0x00000000
: NVIC_ICPR_CLRPEND ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) NVIC_ICPR ; \ NVIC_ICPR_CLRPEND, CLRPEND

\ NVIC_IPR0 (read-write) Reset:0x00000000
: NVIC_IPR0_PRI_0 ( %bbbbbbbb -- x addr ) NVIC_IPR0 ; \ NVIC_IPR0_PRI_0, priority for interrupt 0
: NVIC_IPR0_PRI_1 ( %bbbbbbbb -- x addr ) 8 lshift NVIC_IPR0 ; \ NVIC_IPR0_PRI_1, priority for interrupt 1
: NVIC_IPR0_PRI_2 ( %bbbbbbbb -- x addr ) 16 lshift NVIC_IPR0 ; \ NVIC_IPR0_PRI_2, priority for interrupt 2
: NVIC_IPR0_PRI_3 ( %bbbbbbbb -- x addr ) 24 lshift NVIC_IPR0 ; \ NVIC_IPR0_PRI_3, priority for interrupt 3

\ NVIC_IPR1 (read-write) Reset:0x00000000
: NVIC_IPR1_PRI_4 ( %bbbbbbbb -- x addr ) NVIC_IPR1 ; \ NVIC_IPR1_PRI_4, priority for interrupt n
: NVIC_IPR1_PRI_5 ( %bbbbbbbb -- x addr ) 8 lshift NVIC_IPR1 ; \ NVIC_IPR1_PRI_5, priority for interrupt n
: NVIC_IPR1_PRI_6 ( %bbbbbbbb -- x addr ) 16 lshift NVIC_IPR1 ; \ NVIC_IPR1_PRI_6, priority for interrupt n
: NVIC_IPR1_PRI_7 ( %bbbbbbbb -- x addr ) 24 lshift NVIC_IPR1 ; \ NVIC_IPR1_PRI_7, priority for interrupt n

\ NVIC_IPR2 (read-write) Reset:0x00000000
: NVIC_IPR2_PRI_8 ( %bbbbbbbb -- x addr ) NVIC_IPR2 ; \ NVIC_IPR2_PRI_8, priority for interrupt n
: NVIC_IPR2_PRI_9 ( %bbbbbbbb -- x addr ) 8 lshift NVIC_IPR2 ; \ NVIC_IPR2_PRI_9, priority for interrupt n
: NVIC_IPR2_PRI_10 ( %bbbbbbbb -- x addr ) 16 lshift NVIC_IPR2 ; \ NVIC_IPR2_PRI_10, priority for interrupt n
: NVIC_IPR2_PRI_11 ( %bbbbbbbb -- x addr ) 24 lshift NVIC_IPR2 ; \ NVIC_IPR2_PRI_11, priority for interrupt n

\ NVIC_IPR3 (read-write) Reset:0x00000000
: NVIC_IPR3_PRI_12 ( %bbbbbbbb -- x addr ) NVIC_IPR3 ; \ NVIC_IPR3_PRI_12, priority for interrupt n
: NVIC_IPR3_PRI_13 ( %bbbbbbbb -- x addr ) 8 lshift NVIC_IPR3 ; \ NVIC_IPR3_PRI_13, priority for interrupt n
: NVIC_IPR3_PRI_14 ( %bbbbbbbb -- x addr ) 16 lshift NVIC_IPR3 ; \ NVIC_IPR3_PRI_14, priority for interrupt n
: NVIC_IPR3_PRI_15 ( %bbbbbbbb -- x addr ) 24 lshift NVIC_IPR3 ; \ NVIC_IPR3_PRI_15, priority for interrupt n

\ NVIC_IPR4 (read-write) Reset:0x00000000
: NVIC_IPR4_PRI_16 ( %bbbbbbbb -- x addr ) NVIC_IPR4 ; \ NVIC_IPR4_PRI_16, priority for interrupt n
: NVIC_IPR4_PRI_17 ( %bbbbbbbb -- x addr ) 8 lshift NVIC_IPR4 ; \ NVIC_IPR4_PRI_17, priority for interrupt n
: NVIC_IPR4_PRI_18 ( %bbbbbbbb -- x addr ) 16 lshift NVIC_IPR4 ; \ NVIC_IPR4_PRI_18, priority for interrupt n
: NVIC_IPR4_PRI_19 ( %bbbbbbbb -- x addr ) 24 lshift NVIC_IPR4 ; \ NVIC_IPR4_PRI_19, priority for interrupt n

\ NVIC_IPR5 (read-write) Reset:0x00000000
: NVIC_IPR5_PRI_20 ( %bbbbbbbb -- x addr ) NVIC_IPR5 ; \ NVIC_IPR5_PRI_20, priority for interrupt n
: NVIC_IPR5_PRI_21 ( %bbbbbbbb -- x addr ) 8 lshift NVIC_IPR5 ; \ NVIC_IPR5_PRI_21, priority for interrupt n
: NVIC_IPR5_PRI_22 ( %bbbbbbbb -- x addr ) 16 lshift NVIC_IPR5 ; \ NVIC_IPR5_PRI_22, priority for interrupt n
: NVIC_IPR5_PRI_23 ( %bbbbbbbb -- x addr ) 24 lshift NVIC_IPR5 ; \ NVIC_IPR5_PRI_23, priority for interrupt n

\ NVIC_IPR6 (read-write) Reset:0x00000000
: NVIC_IPR6_PRI_24 ( %bbbbbbbb -- x addr ) NVIC_IPR6 ; \ NVIC_IPR6_PRI_24, priority for interrupt n
: NVIC_IPR6_PRI_25 ( %bbbbbbbb -- x addr ) 8 lshift NVIC_IPR6 ; \ NVIC_IPR6_PRI_25, priority for interrupt n
: NVIC_IPR6_PRI_26 ( %bbbbbbbb -- x addr ) 16 lshift NVIC_IPR6 ; \ NVIC_IPR6_PRI_26, priority for interrupt n
: NVIC_IPR6_PRI_27 ( %bbbbbbbb -- x addr ) 24 lshift NVIC_IPR6 ; \ NVIC_IPR6_PRI_27, priority for interrupt n

\ NVIC_IPR7 (read-write) Reset:0x00000000
: NVIC_IPR7_PRI_28 ( %bbbbbbbb -- x addr ) NVIC_IPR7 ; \ NVIC_IPR7_PRI_28, priority for interrupt n
: NVIC_IPR7_PRI_29 ( %bbbbbbbb -- x addr ) 8 lshift NVIC_IPR7 ; \ NVIC_IPR7_PRI_29, priority for interrupt n
: NVIC_IPR7_PRI_30 ( %bbbbbbbb -- x addr ) 16 lshift NVIC_IPR7 ; \ NVIC_IPR7_PRI_30, priority for interrupt n
: NVIC_IPR7_PRI_31 ( %bbbbbbbb -- x addr ) 24 lshift NVIC_IPR7 ; \ NVIC_IPR7_PRI_31, priority for interrupt n
