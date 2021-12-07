$40003000 device: IWDG  
              IWDG $0 register: IWDG:KR 
              IWDG $4 register: IWDG:PR 
              IWDG $8 register: IWDG:RLR 
              IWDG $C register: IWDG:SR 
              IWDG $10 register: IWDG:WINR 
                
            
              $40002C00 device: WWDG  
              WWDG $0 register: WWDG:CR 
              WWDG $4 register: WWDG:CFR 
              WWDG $8 register: WWDG:SR 
                
            
              $40022000 device: FLASH  
              FLASH $0 register: FLASH:ACR 
              FLASH $8 register: FLASH:KEYR 
              FLASH $C register: FLASH:OPTKEYR 
              FLASH $10 register: FLASH:SR 
              FLASH $14 register: FLASH:CR 
              FLASH $18 register: FLASH:ECCR 
              FLASH $20 register: FLASH:OPTR 
              FLASH $24 register: FLASH:PCROP1ASR 
              FLASH $28 register: FLASH:PCROP1AER 
              FLASH $2C register: FLASH:WRP1AR 
              FLASH $30 register: FLASH:WRP1BR 
              FLASH $34 register: FLASH:PCROP1BSR 
              FLASH $38 register: FLASH:PCROP1BER 
              FLASH $80 register: FLASH:SECR 
                
            
              $40021000 device: RCC  
              RCC $0 register: RCC:CR 
              RCC $4 register: RCC:ICSCR 
              RCC $8 register: RCC:CFGR 
              RCC $C register: RCC:PLLSYSCFGR 
              RCC $18 register: RCC:CIER 
              RCC $1C register: RCC:CIFR 
              RCC $20 register: RCC:CICR 
              RCC $28 register: RCC:AHBRSTR 
              RCC $24 register: RCC:IOPRSTR 
              RCC $2C register: RCC:APBRSTR1 
              RCC $30 register: RCC:APBRSTR2 
              RCC $34 register: RCC:IOPENR 
              RCC $38 register: RCC:AHBENR 
              RCC $3C register: RCC:APBENR1 
              RCC $40 register: RCC:APBENR2 
              RCC $44 register: RCC:IOPSMENR 
              RCC $48 register: RCC:AHBSMENR 
              RCC $4C register: RCC:APBSMENR1 
              RCC $50 register: RCC:APBSMENR2 
              RCC $54 register: RCC:CCIPR 
              RCC $5C register: RCC:BDCR 
              RCC $60 register: RCC:CSR 
                
            
              $40007000 device: PWR  
              PWR $0 register: PWR:CR1 
              PWR $4 register: PWR:CR2 
              PWR $8 register: PWR:CR3 
              PWR $C register: PWR:CR4 
              PWR $10 register: PWR:SR1 
              PWR $14 register: PWR:SR2 
              PWR $18 register: PWR:SCR 
              PWR $20 register: PWR:PUCRA 
              PWR $24 register: PWR:PDCRA 
              PWR $28 register: PWR:PUCRB 
              PWR $2C register: PWR:PDCRB 
              PWR $30 register: PWR:PUCRC 
              PWR $34 register: PWR:PDCRC 
              PWR $38 register: PWR:PUCRD 
              PWR $3C register: PWR:PDCRD 
              PWR $48 register: PWR:PUCRF 
              PWR $4C register: PWR:PDCRF 
                
            
              $40020000 device: DMA  
              DMA $0 register: DMA:ISR 
              DMA $4 register: DMA:IFCR 
              DMA $8 register: DMA:CCR1 
              DMA $1C register: DMA:CCR2 
              DMA $30 register: DMA:CCR3 
              DMA $44 register: DMA:CCR4 
              DMA $58 register: DMA:CCR5 
              DMA $C register: DMA:CNDTR1 
              DMA $20 register: DMA:CNDTR2 
              DMA $34 register: DMA:CNDTR3 
              DMA $48 register: DMA:CNDTR4 
              DMA $5C register: DMA:CNDTR5 
              DMA $10 register: DMA:CPAR1 
              DMA $24 register: DMA:CPAR2 
              DMA $38 register: DMA:CPAR3 
              DMA $4C register: DMA:CPAR4 
              DMA $60 register: DMA:CPAR5 
              DMA $14 register: DMA:CMAR1 
              DMA $28 register: DMA:CMAR2 
              DMA $3C register: DMA:CMAR3 
              DMA $50 register: DMA:CMAR4 
              DMA $64 register: DMA:CMAR5 
                
            
              $40020800 device: DMAMUX  
              DMAMUX $0 register: DMAMUX:C0CR 
              DMAMUX $4 register: DMAMUX:C1CR 
              DMAMUX $8 register: DMAMUX:C2CR 
              DMAMUX $C register: DMAMUX:C3CR 
              DMAMUX $10 register: DMAMUX:C4CR 
              DMAMUX $14 register: DMAMUX:C5CR 
              DMAMUX $18 register: DMAMUX:C6CR 
              DMAMUX $100 register: DMAMUX:RG0CR 
              DMAMUX $104 register: DMAMUX:RG1CR 
              DMAMUX $108 register: DMAMUX:RG2CR 
              DMAMUX $10C register: DMAMUX:RG3CR 
              DMAMUX $140 register: DMAMUX:RGSR 
              DMAMUX $144 register: DMAMUX:RGCFR 
                
            
              $50000000 device: GPIOA  
              GPIOA $0 register: GPIOA:MODER 
              GPIOA $4 register: GPIOA:OTYPER 
              GPIOA $8 register: GPIOA:OSPEEDR 
              GPIOA $C register: GPIOA:PUPDR 
              GPIOA $10 register: GPIOA:IDR 
              GPIOA $14 register: GPIOA:ODR 
              GPIOA $18 register: GPIOA:BSRR 
              GPIOA $1C register: GPIOA:LCKR 
              GPIOA $20 register: GPIOA:AFRL 
              GPIOA $24 register: GPIOA:AFRH 
              GPIOA $28 register: GPIOA:BRR 
                
            
              $50000400 device: GPIOB  
              GPIOB $0 register: GPIOB:MODER 
              GPIOB $4 register: GPIOB:OTYPER 
              GPIOB $8 register: GPIOB:OSPEEDR 
              GPIOB $C register: GPIOB:PUPDR 
              GPIOB $10 register: GPIOB:IDR 
              GPIOB $14 register: GPIOB:ODR 
              GPIOB $18 register: GPIOB:BSRR 
              GPIOB $1C register: GPIOB:LCKR 
              GPIOB $20 register: GPIOB:AFRL 
              GPIOB $24 register: GPIOB:AFRH 
              GPIOB $28 register: GPIOB:BRR 
                
            
              $50000800 device: GPIOC  
              GPIOC $0 register: GPIOC:MODER 
              GPIOC $4 register: GPIOC:OTYPER 
              GPIOC $8 register: GPIOC:OSPEEDR 
              GPIOC $C register: GPIOC:PUPDR 
              GPIOC $10 register: GPIOC:IDR 
              GPIOC $14 register: GPIOC:ODR 
              GPIOC $18 register: GPIOC:BSRR 
              GPIOC $1C register: GPIOC:LCKR 
              GPIOC $20 register: GPIOC:AFRL 
              GPIOC $24 register: GPIOC:AFRH 
              GPIOC $28 register: GPIOC:BRR 
                
            
              $50000C00 device: GPIOD  
              GPIOD $0 register: GPIOD:MODER 
              GPIOD $4 register: GPIOD:OTYPER 
              GPIOD $8 register: GPIOD:OSPEEDR 
              GPIOD $C register: GPIOD:PUPDR 
              GPIOD $10 register: GPIOD:IDR 
              GPIOD $14 register: GPIOD:ODR 
              GPIOD $18 register: GPIOD:BSRR 
              GPIOD $1C register: GPIOD:LCKR 
              GPIOD $20 register: GPIOD:AFRL 
              GPIOD $24 register: GPIOD:AFRH 
              GPIOD $28 register: GPIOD:BRR 
                
            
              $50001400 device: GPIOF  
              GPIOF $0 register: GPIOF:MODER 
              GPIOF $4 register: GPIOF:OTYPER 
              GPIOF $8 register: GPIOF:OSPEEDR 
              GPIOF $C register: GPIOF:PUPDR 
              GPIOF $10 register: GPIOF:IDR 
              GPIOF $14 register: GPIOF:ODR 
              GPIOF $18 register: GPIOF:BSRR 
              GPIOF $1C register: GPIOF:LCKR 
              GPIOF $20 register: GPIOF:AFRL 
              GPIOF $24 register: GPIOF:AFRH 
              GPIOF $28 register: GPIOF:BRR 
                
            
              $40023000 device: CRC  
              CRC $0 register: CRC:DR 
              CRC $4 register: CRC:IDR 
              CRC $8 register: CRC:CR 
              CRC $10 register: CRC:INIT 
              CRC $14 register: CRC:POL 
                
            
              $40021800 device: EXTI  
              EXTI $0 register: EXTI:RTSR1 
              EXTI $4 register: EXTI:FTSR1 
              EXTI $8 register: EXTI:SWIER1 
              EXTI $C register: EXTI:RPR1 
              EXTI $10 register: EXTI:FPR1 
              EXTI $60 register: EXTI:EXTICR1 
              EXTI $64 register: EXTI:EXTICR2 
              EXTI $68 register: EXTI:EXTICR3 
              EXTI $6C register: EXTI:EXTICR4 
              EXTI $80 register: EXTI:IMR1 
              EXTI $84 register: EXTI:EMR1 
                
            
              $40014400 device: TIM16  
              TIM16 $0 register: TIM16:CR1 
              TIM16 $4 register: TIM16:CR2 
              TIM16 $C register: TIM16:DIER 
              TIM16 $10 register: TIM16:SR 
              TIM16 $14 register: TIM16:EGR 
              TIM16 $18 register: TIM16:CCMR1_Output 
              TIM16 $18 register: TIM16:CCMR1_Input 
              TIM16 $20 register: TIM16:CCER 
              TIM16 $24 register: TIM16:CNT 
              TIM16 $28 register: TIM16:PSC 
              TIM16 $2C register: TIM16:ARR 
              TIM16 $30 register: TIM16:RCR 
              TIM16 $34 register: TIM16:CCR1 
              TIM16 $44 register: TIM16:BDTR 
              TIM16 $48 register: TIM16:DCR 
              TIM16 $4C register: TIM16:DMAR 
              TIM16 $60 register: TIM16:AF1 
              TIM16 $68 register: TIM16:TISEL 
                
            
              $40014800 device: TIM17  
              TIM17 $0 register: TIM17:CR1 
              TIM17 $4 register: TIM17:CR2 
              TIM17 $C register: TIM17:DIER 
              TIM17 $10 register: TIM17:SR 
              TIM17 $14 register: TIM17:EGR 
              TIM17 $18 register: TIM17:CCMR1_Output 
              TIM17 $18 register: TIM17:CCMR1_Input 
              TIM17 $20 register: TIM17:CCER 
              TIM17 $24 register: TIM17:CNT 
              TIM17 $28 register: TIM17:PSC 
              TIM17 $2C register: TIM17:ARR 
              TIM17 $30 register: TIM17:RCR 
              TIM17 $34 register: TIM17:CCR1 
              TIM17 $44 register: TIM17:BDTR 
              TIM17 $48 register: TIM17:DCR 
              TIM17 $4C register: TIM17:DMAR 
              TIM17 $60 register: TIM17:AF1 
              TIM17 $68 register: TIM17:TISEL 
                
            
              $40013800 device: USART1  
              USART1 $0 register: USART1:CR1 
              USART1 $4 register: USART1:CR2 
              USART1 $8 register: USART1:CR3 
              USART1 $C register: USART1:BRR 
              USART1 $10 register: USART1:GTPR 
              USART1 $14 register: USART1:RTOR 
              USART1 $18 register: USART1:RQR 
              USART1 $1C register: USART1:ISR 
              USART1 $20 register: USART1:ICR 
              USART1 $24 register: USART1:RDR 
              USART1 $28 register: USART1:TDR 
              USART1 $2C register: USART1:PRESC 
                
            
              $40004400 device: USART2  
              USART2 $0 register: USART2:CR1 
              USART2 $4 register: USART2:CR2 
              USART2 $8 register: USART2:CR3 
              USART2 $C register: USART2:BRR 
              USART2 $10 register: USART2:GTPR 
              USART2 $14 register: USART2:RTOR 
              USART2 $18 register: USART2:RQR 
              USART2 $1C register: USART2:ISR 
              USART2 $20 register: USART2:ICR 
              USART2 $24 register: USART2:RDR 
              USART2 $28 register: USART2:TDR 
              USART2 $2C register: USART2:PRESC 
                
            
              $40013000 device: SPI1  
              SPI1 $0 register: SPI1:CR1 
              SPI1 $4 register: SPI1:CR2 
              SPI1 $8 register: SPI1:SR 
              SPI1 $C register: SPI1:DR 
              SPI1 $10 register: SPI1:CRCPR 
              SPI1 $14 register: SPI1:RXCRCR 
              SPI1 $18 register: SPI1:TXCRCR 
              SPI1 $1C register: SPI1:I2SCFGR 
              SPI1 $20 register: SPI1:I2SPR 
                
            
              $40003800 device: SPI2  
              SPI2 $0 register: SPI2:CR1 
              SPI2 $4 register: SPI2:CR2 
              SPI2 $8 register: SPI2:SR 
              SPI2 $C register: SPI2:DR 
              SPI2 $10 register: SPI2:CRCPR 
              SPI2 $14 register: SPI2:RXCRCR 
              SPI2 $18 register: SPI2:TXCRCR 
              SPI2 $1C register: SPI2:I2SCFGR 
              SPI2 $20 register: SPI2:I2SPR 
                
            
              $40012C00 device: TIM1  
              TIM1 $0 register: TIM1:CR1 
              TIM1 $4 register: TIM1:CR2 
              TIM1 $8 register: TIM1:SMCR 
              TIM1 $C register: TIM1:DIER 
              TIM1 $10 register: TIM1:SR 
              TIM1 $14 register: TIM1:EGR 
              TIM1 $18 register: TIM1:CCMR1_Output 
              TIM1 $18 register: TIM1:CCMR1_Input 
              TIM1 $1C register: TIM1:CCMR2_Output 
              TIM1 $1C register: TIM1:CCMR2_Input 
              TIM1 $20 register: TIM1:CCER 
              TIM1 $24 register: TIM1:CNT 
              TIM1 $28 register: TIM1:PSC 
              TIM1 $2C register: TIM1:ARR 
              TIM1 $30 register: TIM1:RCR 
              TIM1 $34 register: TIM1:CCR1 
              TIM1 $38 register: TIM1:CCR2 
              TIM1 $3C register: TIM1:CCR3 
              TIM1 $40 register: TIM1:CCR4 
              TIM1 $44 register: TIM1:BDTR 
              TIM1 $48 register: TIM1:DCR 
              TIM1 $4C register: TIM1:DMAR 
              TIM1 $50 register: TIM1:OR1 
              TIM1 $54 register: TIM1:CCMR3_Output 
              TIM1 $58 register: TIM1:CCR5 
              TIM1 $5C register: TIM1:CCR6 
              TIM1 $60 register: TIM1:AF1 
              TIM1 $64 register: TIM1:AF2 
              TIM1 $68 register: TIM1:TISEL 
                
            
              $40012400 device: ADC  
              ADC $0 register: ADC:ISR 
              ADC $4 register: ADC:IER 
              ADC $8 register: ADC:CR 
              ADC $C register: ADC:CFGR1 
              ADC $10 register: ADC:CFGR2 
              ADC $14 register: ADC:SMPR 
              ADC $20 register: ADC:AWD1TR 
              ADC $24 register: ADC:AWD2TR 
              ADC $28 register: ADC:CHSELR 
              ADC $28 register: ADC:CHSELR_1 
              ADC $2C register: ADC:AWD3TR 
              ADC $40 register: ADC:DR 
              ADC $A0 register: ADC:AWD2CR 
              ADC $A4 register: ADC:AWD3CR 
              ADC $B4 register: ADC:CALFACT 
              ADC $308 register: ADC:CCR 
                
            
              $40010000 device: SYSCFG  
              SYSCFG $0 register: SYSCFG:CFGR1 
              SYSCFG $18 register: SYSCFG:CFGR2 
                
            
              $4000B000 device: TAMP  
              TAMP $0 register: TAMP:CR1 
              TAMP $4 register: TAMP:CR2 
              TAMP $C register: TAMP:FLTCR 
              TAMP $2C register: TAMP:IER 
              TAMP $30 register: TAMP:SR 
              TAMP $34 register: TAMP:MISR 
              TAMP $3C register: TAMP:SCR 
              TAMP $100 register: TAMP:BKP0R 
              TAMP $104 register: TAMP:BKP1R 
              TAMP $108 register: TAMP:BKP2R 
              TAMP $10C register: TAMP:BKP3R 
              TAMP $110 register: TAMP:BKP4R 
                
            
              $40005400 device: I2C1  
              I2C1 $0 register: I2C1:CR1 
              I2C1 $4 register: I2C1:CR2 
              I2C1 $8 register: I2C1:OAR1 
              I2C1 $C register: I2C1:OAR2 
              I2C1 $10 register: I2C1:TIMINGR 
              I2C1 $14 register: I2C1:TIMEOUTR 
              I2C1 $18 register: I2C1:ISR 
              I2C1 $1C register: I2C1:ICR 
              I2C1 $20 register: I2C1:PECR 
              I2C1 $24 register: I2C1:RXDR 
              I2C1 $28 register: I2C1:TXDR 
                
            
              $40005800 device: I2C2  
              I2C2 $0 register: I2C2:CR1 
              I2C2 $4 register: I2C2:CR2 
              I2C2 $8 register: I2C2:OAR1 
              I2C2 $C register: I2C2:OAR2 
              I2C2 $10 register: I2C2:TIMINGR 
              I2C2 $14 register: I2C2:TIMEOUTR 
              I2C2 $18 register: I2C2:ISR 
              I2C2 $1C register: I2C2:ICR 
              I2C2 $20 register: I2C2:PECR 
              I2C2 $24 register: I2C2:RXDR 
              I2C2 $28 register: I2C2:TXDR 
                
            
              $40002800 device: RTC  
              RTC $0 register: RTC:TR 
              RTC $4 register: RTC:DR 
              RTC $8 register: RTC:SSR 
              RTC $C register: RTC:ICSR 
              RTC $10 register: RTC:PRER 
              RTC $14 register: RTC:WUTR 
              RTC $18 register: RTC:CR 
              RTC $24 register: RTC:WPR 
              RTC $28 register: RTC:CALR 
              RTC $2C register: RTC:SHIFTR 
              RTC $30 register: RTC:TSTR 
              RTC $34 register: RTC:TSDR 
              RTC $38 register: RTC:TSSSR 
              RTC $40 register: RTC:ALRMAR 
              RTC $44 register: RTC:ALRMASSR 
              RTC $48 register: RTC:ALRMBR 
              RTC $4C register: RTC:ALRMBSSR 
              RTC $50 register: RTC:SR 
              RTC $54 register: RTC:MISR 
              RTC $5C register: RTC:SCR 
                
            
              $40002000 device: TIM14  
              TIM14 $0 register: TIM14:CR1 
              TIM14 $C register: TIM14:DIER 
              TIM14 $10 register: TIM14:SR 
              TIM14 $14 register: TIM14:EGR 
              TIM14 $18 register: TIM14:CCMR1_Output 
              TIM14 $18 register: TIM14:CCMR1_Input 
              TIM14 $20 register: TIM14:CCER 
              TIM14 $24 register: TIM14:CNT 
              TIM14 $28 register: TIM14:PSC 
              TIM14 $2C register: TIM14:ARR 
              TIM14 $34 register: TIM14:CCR1 
              TIM14 $68 register: TIM14:TISEL 
                
            
              $40000000 device: TIM2  
              TIM2 $0 register: TIM2:CR1 
              TIM2 $4 register: TIM2:CR2 
              TIM2 $8 register: TIM2:SMCR 
              TIM2 $C register: TIM2:DIER 
              TIM2 $10 register: TIM2:SR 
              TIM2 $14 register: TIM2:EGR 
              TIM2 $18 register: TIM2:CCMR1_Output 
              TIM2 $18 register: TIM2:CCMR1_Input 
              TIM2 $1C register: TIM2:CCMR2_Output 
              TIM2 $1C register: TIM2:CCMR2_Input 
              TIM2 $20 register: TIM2:CCER 
              TIM2 $24 register: TIM2:CNT 
              TIM2 $28 register: TIM2:PSC 
              TIM2 $2C register: TIM2:ARR 
              TIM2 $34 register: TIM2:CCR1 
              TIM2 $38 register: TIM2:CCR2 
              TIM2 $3C register: TIM2:CCR3 
              TIM2 $40 register: TIM2:CCR4 
              TIM2 $48 register: TIM2:DCR 
              TIM2 $4C register: TIM2:DMAR 
              TIM2 $50 register: TIM2:OR1 
              TIM2 $60 register: TIM2:AF1 
              TIM2 $68 register: TIM2:TISEL 
                
            
              $40000400 device: TIM3  
              TIM3 $0 register: TIM3:CR1 
              TIM3 $4 register: TIM3:CR2 
              TIM3 $8 register: TIM3:SMCR 
              TIM3 $C register: TIM3:DIER 
              TIM3 $10 register: TIM3:SR 
              TIM3 $14 register: TIM3:EGR 
              TIM3 $18 register: TIM3:CCMR1_Output 
              TIM3 $18 register: TIM3:CCMR1_Input 
              TIM3 $1C register: TIM3:CCMR2_Output 
              TIM3 $1C register: TIM3:CCMR2_Input 
              TIM3 $20 register: TIM3:CCER 
              TIM3 $24 register: TIM3:CNT 
              TIM3 $28 register: TIM3:PSC 
              TIM3 $2C register: TIM3:ARR 
              TIM3 $34 register: TIM3:CCR1 
              TIM3 $38 register: TIM3:CCR2 
              TIM3 $3C register: TIM3:CCR3 
              TIM3 $40 register: TIM3:CCR4 
              TIM3 $48 register: TIM3:DCR 
              TIM3 $4C register: TIM3:DMAR 
              TIM3 $50 register: TIM3:OR1 
              TIM3 $60 register: TIM3:AF1 
              TIM3 $68 register: TIM3:TISEL 
                
            
              $E000E100 device: NVIC  
              NVIC $0 register: NVIC:ISER 
              NVIC $80 register: NVIC:ICER 
              NVIC $100 register: NVIC:ISPR 
              NVIC $180 register: NVIC:ICPR 
              NVIC $300 register: NVIC:IPR0 
              NVIC $304 register: NVIC:IPR1 
              NVIC $308 register: NVIC:IPR2 
              NVIC $30C register: NVIC:IPR3 
              NVIC $310 register: NVIC:IPR4 
              NVIC $314 register: NVIC:IPR5 
              NVIC $318 register: NVIC:IPR6 
              NVIC $31C register: NVIC:IPR7 
              NVIC $320 register: NVIC:IPR8 
                
            
              $E000ED90 device: MPU  
              MPU $0 register: MPU:MPU_TYPER 
              MPU $4 register: MPU:MPU_CTRL 
              MPU $8 register: MPU:MPU_RNR 
              MPU $C register: MPU:MPU_RBAR 
              MPU $10 register: MPU:MPU_RASR 
                
            
              $E000E010 device: STK  
              STK $0 register: STK:CSR 
              STK $4 register: STK:RVR 
              STK $8 register: STK:CVR 
              STK $C register: STK:CALIB 
                
            
              $E000ED00 device: SCB  
              SCB $0 register: SCB:CPUID 
              SCB $4 register: SCB:ICSR 
              SCB $8 register: SCB:VTOR 
              SCB $C register: SCB:AIRCR 
              SCB $10 register: SCB:SCR 
              SCB $14 register: SCB:CCR 
              SCB $1C register: SCB:SHPR2 
              SCB $20 register: SCB:SHPR3 
                
            
              $40010030 device: VREFBUF  
              VREFBUF $0 register: VREFBUF:CSR 
              VREFBUF $4 register: VREFBUF:CCR 
                
            
              $40015800 device: DBG  
              DBG $0 register: DBG:IDCODE 
              DBG $4 register: DBG:CR 
              DBG $8 register: DBG:APB_FZ1 
              DBG $C register: DBG:APB_FZ2 
                
            
              $E000EF00 device: NVIC_STIR  
              NVIC_STIR $0 register: NVIC_STIR:STIR 
                
            
              $E000E008 device: SCB_ACTRL  
              SCB_ACTRL $0 register: SCB_ACTRL:ACTRL 
                
            
              $E000ED88 device: FPU_CPACR  
              FPU_CPACR $0 register: FPU_CPACR:CPACR 
                
            
              $E000EF34 device: FPU  
              FPU $0 register: FPU:FPCCR 
              FPU $4 register: FPU:FPCAR 
              FPU $8 register: FPU:FPSCR 
                
            
              $40010080 device: SYSCFG_ITLINE  
              SYSCFG_ITLINE $80 register: SYSCFG_ITLINE:ITLINE0 
              SYSCFG_ITLINE $84 register: SYSCFG_ITLINE:ITLINE1 
              SYSCFG_ITLINE $88 register: SYSCFG_ITLINE:ITLINE2 
              SYSCFG_ITLINE $8C register: SYSCFG_ITLINE:ITLINE3 
              SYSCFG_ITLINE $90 register: SYSCFG_ITLINE:ITLINE4 
              SYSCFG_ITLINE $94 register: SYSCFG_ITLINE:ITLINE5 
              SYSCFG_ITLINE $98 register: SYSCFG_ITLINE:ITLINE6 
              SYSCFG_ITLINE $9C register: SYSCFG_ITLINE:ITLINE7 
              SYSCFG_ITLINE $A4 register: SYSCFG_ITLINE:ITLINE9 
              SYSCFG_ITLINE $A8 register: SYSCFG_ITLINE:ITLINE10 
              SYSCFG_ITLINE $AC register: SYSCFG_ITLINE:ITLINE11 
              SYSCFG_ITLINE $B0 register: SYSCFG_ITLINE:ITLINE12 
              SYSCFG_ITLINE $B4 register: SYSCFG_ITLINE:ITLINE13 
              SYSCFG_ITLINE $B8 register: SYSCFG_ITLINE:ITLINE14 
              SYSCFG_ITLINE $BC register: SYSCFG_ITLINE:ITLINE15 
              SYSCFG_ITLINE $C0 register: SYSCFG_ITLINE:ITLINE16 
              SYSCFG_ITLINE $CC register: SYSCFG_ITLINE:ITLINE19 
              SYSCFG_ITLINE $D4 register: SYSCFG_ITLINE:ITLINE21 
              SYSCFG_ITLINE $D8 register: SYSCFG_ITLINE:ITLINE22 
              SYSCFG_ITLINE $DC register: SYSCFG_ITLINE:ITLINE23 
              SYSCFG_ITLINE $E0 register: SYSCFG_ITLINE:ITLINE24 
              SYSCFG_ITLINE $E4 register: SYSCFG_ITLINE:ITLINE25 
              SYSCFG_ITLINE $E8 register: SYSCFG_ITLINE:ITLINE26 
              SYSCFG_ITLINE $EC register: SYSCFG_ITLINE:ITLINE27 
              SYSCFG_ITLINE $F0 register: SYSCFG_ITLINE:ITLINE28 
              SYSCFG_ITLINE $F4 register: SYSCFG_ITLINE:ITLINE29 
                
            
              