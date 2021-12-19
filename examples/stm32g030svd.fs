$40003000 constant IWDG  
              IWDG $0 + constant IWDG.KR 
              IWDG $4 + constant IWDG.PR 
              IWDG $8 + constant IWDG.RLR 
              IWDG $C + constant IWDG.SR 
              IWDG $10 + constant IWDG.WINR 
                
            
              $40002C00 constant WWDG  
              WWDG $0 + constant WWDG.CR 
              WWDG $4 + constant WWDG.CFR 
              WWDG $8 + constant WWDG.SR 
                
            
              $40022000 constant FLASH  
              FLASH $0 + constant FLASH.ACR 
              FLASH $8 + constant FLASH.KEYR 
              FLASH $C + constant FLASH.OPTKEYR 
              FLASH $10 + constant FLASH.SR 
              FLASH $14 + constant FLASH.CR 
              FLASH $18 + constant FLASH.ECCR 
              FLASH $20 + constant FLASH.OPTR 
              FLASH $24 + constant FLASH.PCROP1ASR 
              FLASH $28 + constant FLASH.PCROP1AER 
              FLASH $2C + constant FLASH.WRP1AR 
              FLASH $30 + constant FLASH.WRP1BR 
              FLASH $34 + constant FLASH.PCROP1BSR 
              FLASH $38 + constant FLASH.PCROP1BER 
              FLASH $80 + constant FLASH.SECR 
                
            
              $40021000 constant RCC  
              RCC $0 + constant RCC.CR 
              RCC $4 + constant RCC.ICSCR 
              RCC $8 + constant RCC.CFGR 
              RCC $C + constant RCC.PLLSYSCFGR 
              RCC $18 + constant RCC.CIER 
              RCC $1C + constant RCC.CIFR 
              RCC $20 + constant RCC.CICR 
              RCC $28 + constant RCC.AHBRSTR 
              RCC $24 + constant RCC.IOPRSTR 
              RCC $2C + constant RCC.APBRSTR1 
              RCC $30 + constant RCC.APBRSTR2 
              RCC $34 + constant RCC.IOPENR 
              RCC $38 + constant RCC.AHBENR 
              RCC $3C + constant RCC.APBENR1 
              RCC $40 + constant RCC.APBENR2 
              RCC $44 + constant RCC.IOPSMENR 
              RCC $48 + constant RCC.AHBSMENR 
              RCC $4C + constant RCC.APBSMENR1 
              RCC $50 + constant RCC.APBSMENR2 
              RCC $54 + constant RCC.CCIPR 
              RCC $5C + constant RCC.BDCR 
              RCC $60 + constant RCC.CSR 
                
            
              $40007000 constant PWR  
              PWR $0 + constant PWR.CR1 
              PWR $4 + constant PWR.CR2 
              PWR $8 + constant PWR.CR3 
              PWR $C + constant PWR.CR4 
              PWR $10 + constant PWR.SR1 
              PWR $14 + constant PWR.SR2 
              PWR $18 + constant PWR.SCR 
              PWR $20 + constant PWR.PUCRA 
              PWR $24 + constant PWR.PDCRA 
              PWR $28 + constant PWR.PUCRB 
              PWR $2C + constant PWR.PDCRB 
              PWR $30 + constant PWR.PUCRC 
              PWR $34 + constant PWR.PDCRC 
              PWR $38 + constant PWR.PUCRD 
              PWR $3C + constant PWR.PDCRD 
              PWR $48 + constant PWR.PUCRF 
              PWR $4C + constant PWR.PDCRF 
                
            
              $40020000 constant DMA  
              DMA $0 + constant DMA.ISR 
              DMA $4 + constant DMA.IFCR 
              DMA $8 + constant DMA.CCR1 
              DMA $1C + constant DMA.CCR2 
              DMA $30 + constant DMA.CCR3 
              DMA $44 + constant DMA.CCR4 
              DMA $58 + constant DMA.CCR5 
              DMA $C + constant DMA.CNDTR1 
              DMA $20 + constant DMA.CNDTR2 
              DMA $34 + constant DMA.CNDTR3 
              DMA $48 + constant DMA.CNDTR4 
              DMA $5C + constant DMA.CNDTR5 
              DMA $10 + constant DMA.CPAR1 
              DMA $24 + constant DMA.CPAR2 
              DMA $38 + constant DMA.CPAR3 
              DMA $4C + constant DMA.CPAR4 
              DMA $60 + constant DMA.CPAR5 
              DMA $14 + constant DMA.CMAR1 
              DMA $28 + constant DMA.CMAR2 
              DMA $3C + constant DMA.CMAR3 
              DMA $50 + constant DMA.CMAR4 
              DMA $64 + constant DMA.CMAR5 
                
            
              $40020800 constant DMAMUX  
              DMAMUX $0 + constant DMAMUX.C0CR 
              DMAMUX $4 + constant DMAMUX.C1CR 
              DMAMUX $8 + constant DMAMUX.C2CR 
              DMAMUX $C + constant DMAMUX.C3CR 
              DMAMUX $10 + constant DMAMUX.C4CR 
              DMAMUX $14 + constant DMAMUX.C5CR 
              DMAMUX $18 + constant DMAMUX.C6CR 
              DMAMUX $100 + constant DMAMUX.RG0CR 
              DMAMUX $104 + constant DMAMUX.RG1CR 
              DMAMUX $108 + constant DMAMUX.RG2CR 
              DMAMUX $10C + constant DMAMUX.RG3CR 
              DMAMUX $140 + constant DMAMUX.RGSR 
              DMAMUX $144 + constant DMAMUX.RGCFR 
                
            
              $50000000 constant GPIOA  
              GPIOA $0 + constant GPIOA.MODER 
              GPIOA $4 + constant GPIOA.OTYPER 
              GPIOA $8 + constant GPIOA.OSPEEDR 
              GPIOA $C + constant GPIOA.PUPDR 
              GPIOA $10 + constant GPIOA.IDR 
              GPIOA $14 + constant GPIOA.ODR 
              GPIOA $18 + constant GPIOA.BSRR 
              GPIOA $1C + constant GPIOA.LCKR 
              GPIOA $20 + constant GPIOA.AFRL 
              GPIOA $24 + constant GPIOA.AFRH 
              GPIOA $28 + constant GPIOA.BRR 
                
            
              $50000400 constant GPIOB  
              GPIOB $0 + constant GPIOB.MODER 
              GPIOB $4 + constant GPIOB.OTYPER 
              GPIOB $8 + constant GPIOB.OSPEEDR 
              GPIOB $C + constant GPIOB.PUPDR 
              GPIOB $10 + constant GPIOB.IDR 
              GPIOB $14 + constant GPIOB.ODR 
              GPIOB $18 + constant GPIOB.BSRR 
              GPIOB $1C + constant GPIOB.LCKR 
              GPIOB $20 + constant GPIOB.AFRL 
              GPIOB $24 + constant GPIOB.AFRH 
              GPIOB $28 + constant GPIOB.BRR 
                
            
              $50000800 constant GPIOC  
              GPIOC $0 + constant GPIOC.MODER 
              GPIOC $4 + constant GPIOC.OTYPER 
              GPIOC $8 + constant GPIOC.OSPEEDR 
              GPIOC $C + constant GPIOC.PUPDR 
              GPIOC $10 + constant GPIOC.IDR 
              GPIOC $14 + constant GPIOC.ODR 
              GPIOC $18 + constant GPIOC.BSRR 
              GPIOC $1C + constant GPIOC.LCKR 
              GPIOC $20 + constant GPIOC.AFRL 
              GPIOC $24 + constant GPIOC.AFRH 
              GPIOC $28 + constant GPIOC.BRR 
                
            
              $50000C00 constant GPIOD  
              GPIOD $0 + constant GPIOD.MODER 
              GPIOD $4 + constant GPIOD.OTYPER 
              GPIOD $8 + constant GPIOD.OSPEEDR 
              GPIOD $C + constant GPIOD.PUPDR 
              GPIOD $10 + constant GPIOD.IDR 
              GPIOD $14 + constant GPIOD.ODR 
              GPIOD $18 + constant GPIOD.BSRR 
              GPIOD $1C + constant GPIOD.LCKR 
              GPIOD $20 + constant GPIOD.AFRL 
              GPIOD $24 + constant GPIOD.AFRH 
              GPIOD $28 + constant GPIOD.BRR 
                
            
              $50001400 constant GPIOF  
              GPIOF $0 + constant GPIOF.MODER 
              GPIOF $4 + constant GPIOF.OTYPER 
              GPIOF $8 + constant GPIOF.OSPEEDR 
              GPIOF $C + constant GPIOF.PUPDR 
              GPIOF $10 + constant GPIOF.IDR 
              GPIOF $14 + constant GPIOF.ODR 
              GPIOF $18 + constant GPIOF.BSRR 
              GPIOF $1C + constant GPIOF.LCKR 
              GPIOF $20 + constant GPIOF.AFRL 
              GPIOF $24 + constant GPIOF.AFRH 
              GPIOF $28 + constant GPIOF.BRR 
                
            
              $40023000 constant CRC  
              CRC $0 + constant CRC.DR 
              CRC $4 + constant CRC.IDR 
              CRC $8 + constant CRC.CR 
              CRC $10 + constant CRC.INIT 
              CRC $14 + constant CRC.POL 
                
            
              $40021800 constant EXTI  
              EXTI $0 + constant EXTI.RTSR1 
              EXTI $4 + constant EXTI.FTSR1 
              EXTI $8 + constant EXTI.SWIER1 
              EXTI $C + constant EXTI.RPR1 
              EXTI $10 + constant EXTI.FPR1 
              EXTI $60 + constant EXTI.EXTICR1 
              EXTI $64 + constant EXTI.EXTICR2 
              EXTI $68 + constant EXTI.EXTICR3 
              EXTI $6C + constant EXTI.EXTICR4 
              EXTI $80 + constant EXTI.IMR1 
              EXTI $84 + constant EXTI.EMR1 
                
            
              $40014400 constant TIM16  
              TIM16 $0 + constant TIM16.CR1 
              TIM16 $4 + constant TIM16.CR2 
              TIM16 $C + constant TIM16.DIER 
              TIM16 $10 + constant TIM16.SR 
              TIM16 $14 + constant TIM16.EGR 
              TIM16 $18 + constant TIM16.CCMR1_Output 
              TIM16 $18 + constant TIM16.CCMR1_Input 
              TIM16 $20 + constant TIM16.CCER 
              TIM16 $24 + constant TIM16.CNT 
              TIM16 $28 + constant TIM16.PSC 
              TIM16 $2C + constant TIM16.ARR 
              TIM16 $30 + constant TIM16.RCR 
              TIM16 $34 + constant TIM16.CCR1 
              TIM16 $44 + constant TIM16.BDTR 
              TIM16 $48 + constant TIM16.DCR 
              TIM16 $4C + constant TIM16.DMAR 
              TIM16 $60 + constant TIM16.AF1 
              TIM16 $68 + constant TIM16.TISEL 
                
            
              $40014800 constant TIM17  
              TIM17 $0 + constant TIM17.CR1 
              TIM17 $4 + constant TIM17.CR2 
              TIM17 $C + constant TIM17.DIER 
              TIM17 $10 + constant TIM17.SR 
              TIM17 $14 + constant TIM17.EGR 
              TIM17 $18 + constant TIM17.CCMR1_Output 
              TIM17 $18 + constant TIM17.CCMR1_Input 
              TIM17 $20 + constant TIM17.CCER 
              TIM17 $24 + constant TIM17.CNT 
              TIM17 $28 + constant TIM17.PSC 
              TIM17 $2C + constant TIM17.ARR 
              TIM17 $30 + constant TIM17.RCR 
              TIM17 $34 + constant TIM17.CCR1 
              TIM17 $44 + constant TIM17.BDTR 
              TIM17 $48 + constant TIM17.DCR 
              TIM17 $4C + constant TIM17.DMAR 
              TIM17 $60 + constant TIM17.AF1 
              TIM17 $68 + constant TIM17.TISEL 
                
            
              $40013800 constant USART1  
              USART1 $0 + constant USART1.CR1 
              USART1 $4 + constant USART1.CR2 
              USART1 $8 + constant USART1.CR3 
              USART1 $C + constant USART1.BRR 
              USART1 $10 + constant USART1.GTPR 
              USART1 $14 + constant USART1.RTOR 
              USART1 $18 + constant USART1.RQR 
              USART1 $1C + constant USART1.ISR 
              USART1 $20 + constant USART1.ICR 
              USART1 $24 + constant USART1.RDR 
              USART1 $28 + constant USART1.TDR 
              USART1 $2C + constant USART1.PRESC 
                
            
              $40004400 constant USART2  
              USART2 $0 + constant USART2.CR1 
              USART2 $4 + constant USART2.CR2 
              USART2 $8 + constant USART2.CR3 
              USART2 $C + constant USART2.BRR 
              USART2 $10 + constant USART2.GTPR 
              USART2 $14 + constant USART2.RTOR 
              USART2 $18 + constant USART2.RQR 
              USART2 $1C + constant USART2.ISR 
              USART2 $20 + constant USART2.ICR 
              USART2 $24 + constant USART2.RDR 
              USART2 $28 + constant USART2.TDR 
              USART2 $2C + constant USART2.PRESC 
                
            
              $40013000 constant SPI1  
              SPI1 $0 + constant SPI1.CR1 
              SPI1 $4 + constant SPI1.CR2 
              SPI1 $8 + constant SPI1.SR 
              SPI1 $C + constant SPI1.DR 
              SPI1 $10 + constant SPI1.CRCPR 
              SPI1 $14 + constant SPI1.RXCRCR 
              SPI1 $18 + constant SPI1.TXCRCR 
              SPI1 $1C + constant SPI1.I2SCFGR 
              SPI1 $20 + constant SPI1.I2SPR 
                
            
              $40003800 constant SPI2  
              SPI2 $0 + constant SPI2.CR1 
              SPI2 $4 + constant SPI2.CR2 
              SPI2 $8 + constant SPI2.SR 
              SPI2 $C + constant SPI2.DR 
              SPI2 $10 + constant SPI2.CRCPR 
              SPI2 $14 + constant SPI2.RXCRCR 
              SPI2 $18 + constant SPI2.TXCRCR 
              SPI2 $1C + constant SPI2.I2SCFGR 
              SPI2 $20 + constant SPI2.I2SPR 
                
            
              $40012C00 constant TIM1  
              TIM1 $0 + constant TIM1.CR1 
              TIM1 $4 + constant TIM1.CR2 
              TIM1 $8 + constant TIM1.SMCR 
              TIM1 $C + constant TIM1.DIER 
              TIM1 $10 + constant TIM1.SR 
              TIM1 $14 + constant TIM1.EGR 
              TIM1 $18 + constant TIM1.CCMR1_Output 
              TIM1 $18 + constant TIM1.CCMR1_Input 
              TIM1 $1C + constant TIM1.CCMR2_Output 
              TIM1 $1C + constant TIM1.CCMR2_Input 
              TIM1 $20 + constant TIM1.CCER 
              TIM1 $24 + constant TIM1.CNT 
              TIM1 $28 + constant TIM1.PSC 
              TIM1 $2C + constant TIM1.ARR 
              TIM1 $30 + constant TIM1.RCR 
              TIM1 $34 + constant TIM1.CCR1 
              TIM1 $38 + constant TIM1.CCR2 
              TIM1 $3C + constant TIM1.CCR3 
              TIM1 $40 + constant TIM1.CCR4 
              TIM1 $44 + constant TIM1.BDTR 
              TIM1 $48 + constant TIM1.DCR 
              TIM1 $4C + constant TIM1.DMAR 
              TIM1 $50 + constant TIM1.OR1 
              TIM1 $54 + constant TIM1.CCMR3_Output 
              TIM1 $58 + constant TIM1.CCR5 
              TIM1 $5C + constant TIM1.CCR6 
              TIM1 $60 + constant TIM1.AF1 
              TIM1 $64 + constant TIM1.AF2 
              TIM1 $68 + constant TIM1.TISEL 
                
            
              $40012400 constant ADC  
              ADC $0 + constant ADC.ISR 
              ADC $4 + constant ADC.IER 
              ADC $8 + constant ADC.CR 
              ADC $C + constant ADC.CFGR1 
              ADC $10 + constant ADC.CFGR2 
              ADC $14 + constant ADC.SMPR 
              ADC $20 + constant ADC.AWD1TR 
              ADC $24 + constant ADC.AWD2TR 
              ADC $28 + constant ADC.CHSELR 
              ADC $28 + constant ADC.CHSELR_1 
              ADC $2C + constant ADC.AWD3TR 
              ADC $40 + constant ADC.DR 
              ADC $A0 + constant ADC.AWD2CR 
              ADC $A4 + constant ADC.AWD3CR 
              ADC $B4 + constant ADC.CALFACT 
              ADC $308 + constant ADC.CCR 
                
            
              $40010000 constant SYSCFG  
              SYSCFG $0 + constant SYSCFG.CFGR1 
              SYSCFG $18 + constant SYSCFG.CFGR2 
                
            
              $4000B000 constant TAMP  
              TAMP $0 + constant TAMP.CR1 
              TAMP $4 + constant TAMP.CR2 
              TAMP $C + constant TAMP.FLTCR 
              TAMP $2C + constant TAMP.IER 
              TAMP $30 + constant TAMP.SR 
              TAMP $34 + constant TAMP.MISR 
              TAMP $3C + constant TAMP.SCR 
              TAMP $100 + constant TAMP.BKP0R 
              TAMP $104 + constant TAMP.BKP1R 
              TAMP $108 + constant TAMP.BKP2R 
              TAMP $10C + constant TAMP.BKP3R 
              TAMP $110 + constant TAMP.BKP4R 
                
            
              $40005400 constant I2C1  
              I2C1 $0 + constant I2C1.CR1 
              I2C1 $4 + constant I2C1.CR2 
              I2C1 $8 + constant I2C1.OAR1 
              I2C1 $C + constant I2C1.OAR2 
              I2C1 $10 + constant I2C1.TIMINGR 
              I2C1 $14 + constant I2C1.TIMEOUTR 
              I2C1 $18 + constant I2C1.ISR 
              I2C1 $1C + constant I2C1.ICR 
              I2C1 $20 + constant I2C1.PECR 
              I2C1 $24 + constant I2C1.RXDR 
              I2C1 $28 + constant I2C1.TXDR 
                
            
              $40005800 constant I2C2  
              I2C2 $0 + constant I2C2.CR1 
              I2C2 $4 + constant I2C2.CR2 
              I2C2 $8 + constant I2C2.OAR1 
              I2C2 $C + constant I2C2.OAR2 
              I2C2 $10 + constant I2C2.TIMINGR 
              I2C2 $14 + constant I2C2.TIMEOUTR 
              I2C2 $18 + constant I2C2.ISR 
              I2C2 $1C + constant I2C2.ICR 
              I2C2 $20 + constant I2C2.PECR 
              I2C2 $24 + constant I2C2.RXDR 
              I2C2 $28 + constant I2C2.TXDR 
                
            
              $40002800 constant RTC  
              RTC $0 + constant RTC.TR 
              RTC $4 + constant RTC.DR 
              RTC $8 + constant RTC.SSR 
              RTC $C + constant RTC.ICSR 
              RTC $10 + constant RTC.PRER 
              RTC $14 + constant RTC.WUTR 
              RTC $18 + constant RTC.CR 
              RTC $24 + constant RTC.WPR 
              RTC $28 + constant RTC.CALR 
              RTC $2C + constant RTC.SHIFTR 
              RTC $30 + constant RTC.TSTR 
              RTC $34 + constant RTC.TSDR 
              RTC $38 + constant RTC.TSSSR 
              RTC $40 + constant RTC.ALRMAR 
              RTC $44 + constant RTC.ALRMASSR 
              RTC $48 + constant RTC.ALRMBR 
              RTC $4C + constant RTC.ALRMBSSR 
              RTC $50 + constant RTC.SR 
              RTC $54 + constant RTC.MISR 
              RTC $5C + constant RTC.SCR 
                
            
              $40002000 constant TIM14  
              TIM14 $0 + constant TIM14.CR1 
              TIM14 $C + constant TIM14.DIER 
              TIM14 $10 + constant TIM14.SR 
              TIM14 $14 + constant TIM14.EGR 
              TIM14 $18 + constant TIM14.CCMR1_Output 
              TIM14 $18 + constant TIM14.CCMR1_Input 
              TIM14 $20 + constant TIM14.CCER 
              TIM14 $24 + constant TIM14.CNT 
              TIM14 $28 + constant TIM14.PSC 
              TIM14 $2C + constant TIM14.ARR 
              TIM14 $34 + constant TIM14.CCR1 
              TIM14 $68 + constant TIM14.TISEL 
                
            
              $40000000 constant TIM2  
              TIM2 $0 + constant TIM2.CR1 
              TIM2 $4 + constant TIM2.CR2 
              TIM2 $8 + constant TIM2.SMCR 
              TIM2 $C + constant TIM2.DIER 
              TIM2 $10 + constant TIM2.SR 
              TIM2 $14 + constant TIM2.EGR 
              TIM2 $18 + constant TIM2.CCMR1_Output 
              TIM2 $18 + constant TIM2.CCMR1_Input 
              TIM2 $1C + constant TIM2.CCMR2_Output 
              TIM2 $1C + constant TIM2.CCMR2_Input 
              TIM2 $20 + constant TIM2.CCER 
              TIM2 $24 + constant TIM2.CNT 
              TIM2 $28 + constant TIM2.PSC 
              TIM2 $2C + constant TIM2.ARR 
              TIM2 $34 + constant TIM2.CCR1 
              TIM2 $38 + constant TIM2.CCR2 
              TIM2 $3C + constant TIM2.CCR3 
              TIM2 $40 + constant TIM2.CCR4 
              TIM2 $48 + constant TIM2.DCR 
              TIM2 $4C + constant TIM2.DMAR 
              TIM2 $50 + constant TIM2.OR1 
              TIM2 $60 + constant TIM2.AF1 
              TIM2 $68 + constant TIM2.TISEL 
                
            
              $40000400 constant TIM3  
              TIM3 $0 + constant TIM3.CR1 
              TIM3 $4 + constant TIM3.CR2 
              TIM3 $8 + constant TIM3.SMCR 
              TIM3 $C + constant TIM3.DIER 
              TIM3 $10 + constant TIM3.SR 
              TIM3 $14 + constant TIM3.EGR 
              TIM3 $18 + constant TIM3.CCMR1_Output 
              TIM3 $18 + constant TIM3.CCMR1_Input 
              TIM3 $1C + constant TIM3.CCMR2_Output 
              TIM3 $1C + constant TIM3.CCMR2_Input 
              TIM3 $20 + constant TIM3.CCER 
              TIM3 $24 + constant TIM3.CNT 
              TIM3 $28 + constant TIM3.PSC 
              TIM3 $2C + constant TIM3.ARR 
              TIM3 $34 + constant TIM3.CCR1 
              TIM3 $38 + constant TIM3.CCR2 
              TIM3 $3C + constant TIM3.CCR3 
              TIM3 $40 + constant TIM3.CCR4 
              TIM3 $48 + constant TIM3.DCR 
              TIM3 $4C + constant TIM3.DMAR 
              TIM3 $50 + constant TIM3.OR1 
              TIM3 $60 + constant TIM3.AF1 
              TIM3 $68 + constant TIM3.TISEL 
                
            
              $E000E100 constant NVIC  
              NVIC $0 + constant NVIC.ISER 
              NVIC $80 + constant NVIC.ICER 
              NVIC $100 + constant NVIC.ISPR 
              NVIC $180 + constant NVIC.ICPR 
              NVIC $300 + constant NVIC.IPR0 
              NVIC $304 + constant NVIC.IPR1 
              NVIC $308 + constant NVIC.IPR2 
              NVIC $30C + constant NVIC.IPR3 
              NVIC $310 + constant NVIC.IPR4 
              NVIC $314 + constant NVIC.IPR5 
              NVIC $318 + constant NVIC.IPR6 
              NVIC $31C + constant NVIC.IPR7 
              NVIC $320 + constant NVIC.IPR8 
                
            
              $E000ED90 constant MPU  
              MPU $0 + constant MPU.MPU_TYPER 
              MPU $4 + constant MPU.MPU_CTRL 
              MPU $8 + constant MPU.MPU_RNR 
              MPU $C + constant MPU.MPU_RBAR 
              MPU $10 + constant MPU.MPU_RASR 
                
            
              $E000E010 constant STK  
              STK $0 + constant STK.CSR 
              STK $4 + constant STK.RVR 
              STK $8 + constant STK.CVR 
              STK $C + constant STK.CALIB 
                
            
              $E000ED00 constant SCB  
              SCB $0 + constant SCB.CPUID 
              SCB $4 + constant SCB.ICSR 
              SCB $8 + constant SCB.VTOR 
              SCB $C + constant SCB.AIRCR 
              SCB $10 + constant SCB.SCR 
              SCB $14 + constant SCB.CCR 
              SCB $1C + constant SCB.SHPR2 
              SCB $20 + constant SCB.SHPR3 
                
            
              $40010030 constant VREFBUF  
              VREFBUF $0 + constant VREFBUF.CSR 
              VREFBUF $4 + constant VREFBUF.CCR 
                
            
              $40015800 constant DBG  
              DBG $0 + constant DBG.IDCODE 
              DBG $4 + constant DBG.CR 
              DBG $8 + constant DBG.APB_FZ1 
              DBG $C + constant DBG.APB_FZ2 
                
            
              $E000EF00 constant NVIC_STIR  
              NVIC_STIR $0 + constant NVIC_STIR.STIR 
                
            
              $E000E008 constant SCB_ACTRL  
              SCB_ACTRL $0 + constant SCB_ACTRL.ACTRL 
                
            
              $E000ED88 constant FPU_CPACR  
              FPU_CPACR $0 + constant FPU_CPACR.CPACR 
                
            
              $E000EF34 constant FPU  
              FPU $0 + constant FPU.FPCCR 
              FPU $4 + constant FPU.FPCAR 
              FPU $8 + constant FPU.FPSCR 
                
            
              $40010080 constant SYSCFG_ITLINE  
              SYSCFG_ITLINE $80 + constant SYSCFG_ITLINE.ITLINE0 
              SYSCFG_ITLINE $84 + constant SYSCFG_ITLINE.ITLINE1 
              SYSCFG_ITLINE $88 + constant SYSCFG_ITLINE.ITLINE2 
              SYSCFG_ITLINE $8C + constant SYSCFG_ITLINE.ITLINE3 
              SYSCFG_ITLINE $90 + constant SYSCFG_ITLINE.ITLINE4 
              SYSCFG_ITLINE $94 + constant SYSCFG_ITLINE.ITLINE5 
              SYSCFG_ITLINE $98 + constant SYSCFG_ITLINE.ITLINE6 
              SYSCFG_ITLINE $9C + constant SYSCFG_ITLINE.ITLINE7 
              SYSCFG_ITLINE $A4 + constant SYSCFG_ITLINE.ITLINE9 
              SYSCFG_ITLINE $A8 + constant SYSCFG_ITLINE.ITLINE10 
              SYSCFG_ITLINE $AC + constant SYSCFG_ITLINE.ITLINE11 
              SYSCFG_ITLINE $B0 + constant SYSCFG_ITLINE.ITLINE12 
              SYSCFG_ITLINE $B4 + constant SYSCFG_ITLINE.ITLINE13 
              SYSCFG_ITLINE $B8 + constant SYSCFG_ITLINE.ITLINE14 
              SYSCFG_ITLINE $BC + constant SYSCFG_ITLINE.ITLINE15 
              SYSCFG_ITLINE $C0 + constant SYSCFG_ITLINE.ITLINE16 
              SYSCFG_ITLINE $CC + constant SYSCFG_ITLINE.ITLINE19 
              SYSCFG_ITLINE $D4 + constant SYSCFG_ITLINE.ITLINE21 
              SYSCFG_ITLINE $D8 + constant SYSCFG_ITLINE.ITLINE22 
              SYSCFG_ITLINE $DC + constant SYSCFG_ITLINE.ITLINE23 
              SYSCFG_ITLINE $E0 + constant SYSCFG_ITLINE.ITLINE24 
              SYSCFG_ITLINE $E4 + constant SYSCFG_ITLINE.ITLINE25 
              SYSCFG_ITLINE $E8 + constant SYSCFG_ITLINE.ITLINE26 
              SYSCFG_ITLINE $EC + constant SYSCFG_ITLINE.ITLINE27 
              SYSCFG_ITLINE $F0 + constant SYSCFG_ITLINE.ITLINE28 
              SYSCFG_ITLINE $F4 + constant SYSCFG_ITLINE.ITLINE29 
                
            
              