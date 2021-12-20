$40003000 constant IWDG  
              IWDG $0 + constant IWDG_KR 
              IWDG $4 + constant IWDG_PR 
              IWDG $8 + constant IWDG_RLR 
              IWDG $C + constant IWDG_SR 
              IWDG $10 + constant IWDG_WINR 
                
            
              $40002C00 constant WWDG  
              WWDG $0 + constant WWDG_CR 
              WWDG $4 + constant WWDG_CFR 
              WWDG $8 + constant WWDG_SR 
                
            
              $40022000 constant FLASH  
              FLASH $0 + constant FLASH_ACR 
              FLASH $8 + constant FLASH_KEYR 
              FLASH $C + constant FLASH_OPTKEYR 
              FLASH $10 + constant FLASH_SR 
              FLASH $14 + constant FLASH_CR 
              FLASH $18 + constant FLASH_ECCR 
              FLASH $20 + constant FLASH_OPTR 
              FLASH $24 + constant FLASH_PCROP1ASR 
              FLASH $28 + constant FLASH_PCROP1AER 
              FLASH $2C + constant FLASH_WRP1AR 
              FLASH $30 + constant FLASH_WRP1BR 
              FLASH $34 + constant FLASH_PCROP1BSR 
              FLASH $38 + constant FLASH_PCROP1BER 
              FLASH $80 + constant FLASH_SECR 
                
            
              $40021000 constant RCC  
              RCC $0 + constant RCC_CR 
              RCC $4 + constant RCC_ICSCR 
              RCC $8 + constant RCC_CFGR 
              RCC $C + constant RCC_PLLSYSCFGR 
              RCC $18 + constant RCC_CIER 
              RCC $1C + constant RCC_CIFR 
              RCC $20 + constant RCC_CICR 
              RCC $28 + constant RCC_AHBRSTR 
              RCC $24 + constant RCC_IOPRSTR 
              RCC $2C + constant RCC_APBRSTR1 
              RCC $30 + constant RCC_APBRSTR2 
              RCC $34 + constant RCC_IOPENR 
              RCC $38 + constant RCC_AHBENR 
              RCC $3C + constant RCC_APBENR1 
              RCC $40 + constant RCC_APBENR2 
              RCC $44 + constant RCC_IOPSMENR 
              RCC $48 + constant RCC_AHBSMENR 
              RCC $4C + constant RCC_APBSMENR1 
              RCC $50 + constant RCC_APBSMENR2 
              RCC $54 + constant RCC_CCIPR 
              RCC $5C + constant RCC_BDCR 
              RCC $60 + constant RCC_CSR 
                
            
              $40007000 constant PWR  
              PWR $0 + constant PWR_CR1 
              PWR $4 + constant PWR_CR2 
              PWR $8 + constant PWR_CR3 
              PWR $C + constant PWR_CR4 
              PWR $10 + constant PWR_SR1 
              PWR $14 + constant PWR_SR2 
              PWR $18 + constant PWR_SCR 
              PWR $20 + constant PWR_PUCRA 
              PWR $24 + constant PWR_PDCRA 
              PWR $28 + constant PWR_PUCRB 
              PWR $2C + constant PWR_PDCRB 
              PWR $30 + constant PWR_PUCRC 
              PWR $34 + constant PWR_PDCRC 
              PWR $38 + constant PWR_PUCRD 
              PWR $3C + constant PWR_PDCRD 
              PWR $48 + constant PWR_PUCRF 
              PWR $4C + constant PWR_PDCRF 
                
            
              $40020000 constant DMA  
              DMA $0 + constant DMA_ISR 
              DMA $4 + constant DMA_IFCR 
              DMA $8 + constant DMA_CCR1 
              DMA $1C + constant DMA_CCR2 
              DMA $30 + constant DMA_CCR3 
              DMA $44 + constant DMA_CCR4 
              DMA $58 + constant DMA_CCR5 
              DMA $C + constant DMA_CNDTR1 
              DMA $20 + constant DMA_CNDTR2 
              DMA $34 + constant DMA_CNDTR3 
              DMA $48 + constant DMA_CNDTR4 
              DMA $5C + constant DMA_CNDTR5 
              DMA $10 + constant DMA_CPAR1 
              DMA $24 + constant DMA_CPAR2 
              DMA $38 + constant DMA_CPAR3 
              DMA $4C + constant DMA_CPAR4 
              DMA $60 + constant DMA_CPAR5 
              DMA $14 + constant DMA_CMAR1 
              DMA $28 + constant DMA_CMAR2 
              DMA $3C + constant DMA_CMAR3 
              DMA $50 + constant DMA_CMAR4 
              DMA $64 + constant DMA_CMAR5 
                
            
              $40020800 constant DMAMUX  
              DMAMUX $0 + constant DMAMUX_C0CR 
              DMAMUX $4 + constant DMAMUX_C1CR 
              DMAMUX $8 + constant DMAMUX_C2CR 
              DMAMUX $C + constant DMAMUX_C3CR 
              DMAMUX $10 + constant DMAMUX_C4CR 
              DMAMUX $14 + constant DMAMUX_C5CR 
              DMAMUX $18 + constant DMAMUX_C6CR 
              DMAMUX $100 + constant DMAMUX_RG0CR 
              DMAMUX $104 + constant DMAMUX_RG1CR 
              DMAMUX $108 + constant DMAMUX_RG2CR 
              DMAMUX $10C + constant DMAMUX_RG3CR 
              DMAMUX $140 + constant DMAMUX_RGSR 
              DMAMUX $144 + constant DMAMUX_RGCFR 
                
            
              $50000000 constant GPIOA  
              GPIOA $0 + constant GPIOA_MODER 
              GPIOA $4 + constant GPIOA_OTYPER 
              GPIOA $8 + constant GPIOA_OSPEEDR 
              GPIOA $C + constant GPIOA_PUPDR 
              GPIOA $10 + constant GPIOA_IDR 
              GPIOA $14 + constant GPIOA_ODR 
              GPIOA $18 + constant GPIOA_BSRR 
              GPIOA $1C + constant GPIOA_LCKR 
              GPIOA $20 + constant GPIOA_AFRL 
              GPIOA $24 + constant GPIOA_AFRH 
              GPIOA $28 + constant GPIOA_BRR 
                
            
              $50000400 constant GPIOB  
              GPIOB $0 + constant GPIOB_MODER 
              GPIOB $4 + constant GPIOB_OTYPER 
              GPIOB $8 + constant GPIOB_OSPEEDR 
              GPIOB $C + constant GPIOB_PUPDR 
              GPIOB $10 + constant GPIOB_IDR 
              GPIOB $14 + constant GPIOB_ODR 
              GPIOB $18 + constant GPIOB_BSRR 
              GPIOB $1C + constant GPIOB_LCKR 
              GPIOB $20 + constant GPIOB_AFRL 
              GPIOB $24 + constant GPIOB_AFRH 
              GPIOB $28 + constant GPIOB_BRR 
                
            
              $50000800 constant GPIOC  
              GPIOC $0 + constant GPIOC_MODER 
              GPIOC $4 + constant GPIOC_OTYPER 
              GPIOC $8 + constant GPIOC_OSPEEDR 
              GPIOC $C + constant GPIOC_PUPDR 
              GPIOC $10 + constant GPIOC_IDR 
              GPIOC $14 + constant GPIOC_ODR 
              GPIOC $18 + constant GPIOC_BSRR 
              GPIOC $1C + constant GPIOC_LCKR 
              GPIOC $20 + constant GPIOC_AFRL 
              GPIOC $24 + constant GPIOC_AFRH 
              GPIOC $28 + constant GPIOC_BRR 
                
            
              $50000C00 constant GPIOD  
              GPIOD $0 + constant GPIOD_MODER 
              GPIOD $4 + constant GPIOD_OTYPER 
              GPIOD $8 + constant GPIOD_OSPEEDR 
              GPIOD $C + constant GPIOD_PUPDR 
              GPIOD $10 + constant GPIOD_IDR 
              GPIOD $14 + constant GPIOD_ODR 
              GPIOD $18 + constant GPIOD_BSRR 
              GPIOD $1C + constant GPIOD_LCKR 
              GPIOD $20 + constant GPIOD_AFRL 
              GPIOD $24 + constant GPIOD_AFRH 
              GPIOD $28 + constant GPIOD_BRR 
                
            
              $50001400 constant GPIOF  
              GPIOF $0 + constant GPIOF_MODER 
              GPIOF $4 + constant GPIOF_OTYPER 
              GPIOF $8 + constant GPIOF_OSPEEDR 
              GPIOF $C + constant GPIOF_PUPDR 
              GPIOF $10 + constant GPIOF_IDR 
              GPIOF $14 + constant GPIOF_ODR 
              GPIOF $18 + constant GPIOF_BSRR 
              GPIOF $1C + constant GPIOF_LCKR 
              GPIOF $20 + constant GPIOF_AFRL 
              GPIOF $24 + constant GPIOF_AFRH 
              GPIOF $28 + constant GPIOF_BRR 
                
            
              $40023000 constant CRC  
              CRC $0 + constant CRC_DR 
              CRC $4 + constant CRC_IDR 
              CRC $8 + constant CRC_CR 
              CRC $10 + constant CRC_INIT 
              CRC $14 + constant CRC_POL 
                
            
              $40021800 constant EXTI  
              EXTI $0 + constant EXTI_RTSR1 
              EXTI $4 + constant EXTI_FTSR1 
              EXTI $8 + constant EXTI_SWIER1 
              EXTI $C + constant EXTI_RPR1 
              EXTI $10 + constant EXTI_FPR1 
              EXTI $60 + constant EXTI_EXTICR1 
              EXTI $64 + constant EXTI_EXTICR2 
              EXTI $68 + constant EXTI_EXTICR3 
              EXTI $6C + constant EXTI_EXTICR4 
              EXTI $80 + constant EXTI_IMR1 
              EXTI $84 + constant EXTI_EMR1 
                
            
              $40014400 constant TIM16  
              TIM16 $0 + constant TIM16_CR1 
              TIM16 $4 + constant TIM16_CR2 
              TIM16 $C + constant TIM16_DIER 
              TIM16 $10 + constant TIM16_SR 
              TIM16 $14 + constant TIM16_EGR 
              TIM16 $18 + constant TIM16_CCMR1_Output 
              TIM16 $18 + constant TIM16_CCMR1_Input 
              TIM16 $20 + constant TIM16_CCER 
              TIM16 $24 + constant TIM16_CNT 
              TIM16 $28 + constant TIM16_PSC 
              TIM16 $2C + constant TIM16_ARR 
              TIM16 $30 + constant TIM16_RCR 
              TIM16 $34 + constant TIM16_CCR1 
              TIM16 $44 + constant TIM16_BDTR 
              TIM16 $48 + constant TIM16_DCR 
              TIM16 $4C + constant TIM16_DMAR 
              TIM16 $60 + constant TIM16_AF1 
              TIM16 $68 + constant TIM16_TISEL 
                
            
              $40014800 constant TIM17  
              TIM17 $0 + constant TIM17_CR1 
              TIM17 $4 + constant TIM17_CR2 
              TIM17 $C + constant TIM17_DIER 
              TIM17 $10 + constant TIM17_SR 
              TIM17 $14 + constant TIM17_EGR 
              TIM17 $18 + constant TIM17_CCMR1_Output 
              TIM17 $18 + constant TIM17_CCMR1_Input 
              TIM17 $20 + constant TIM17_CCER 
              TIM17 $24 + constant TIM17_CNT 
              TIM17 $28 + constant TIM17_PSC 
              TIM17 $2C + constant TIM17_ARR 
              TIM17 $30 + constant TIM17_RCR 
              TIM17 $34 + constant TIM17_CCR1 
              TIM17 $44 + constant TIM17_BDTR 
              TIM17 $48 + constant TIM17_DCR 
              TIM17 $4C + constant TIM17_DMAR 
              TIM17 $60 + constant TIM17_AF1 
              TIM17 $68 + constant TIM17_TISEL 
                
            
              $40013800 constant USART1  
              USART1 $0 + constant USART1_CR1 
              USART1 $4 + constant USART1_CR2 
              USART1 $8 + constant USART1_CR3 
              USART1 $C + constant USART1_BRR 
              USART1 $10 + constant USART1_GTPR 
              USART1 $14 + constant USART1_RTOR 
              USART1 $18 + constant USART1_RQR 
              USART1 $1C + constant USART1_ISR 
              USART1 $20 + constant USART1_ICR 
              USART1 $24 + constant USART1_RDR 
              USART1 $28 + constant USART1_TDR 
              USART1 $2C + constant USART1_PRESC 
                
            
              $40004400 constant USART2  
              USART2 $0 + constant USART2_CR1 
              USART2 $4 + constant USART2_CR2 
              USART2 $8 + constant USART2_CR3 
              USART2 $C + constant USART2_BRR 
              USART2 $10 + constant USART2_GTPR 
              USART2 $14 + constant USART2_RTOR 
              USART2 $18 + constant USART2_RQR 
              USART2 $1C + constant USART2_ISR 
              USART2 $20 + constant USART2_ICR 
              USART2 $24 + constant USART2_RDR 
              USART2 $28 + constant USART2_TDR 
              USART2 $2C + constant USART2_PRESC 
                
            
              $40013000 constant SPI1  
              SPI1 $0 + constant SPI1_CR1 
              SPI1 $4 + constant SPI1_CR2 
              SPI1 $8 + constant SPI1_SR 
              SPI1 $C + constant SPI1_DR 
              SPI1 $10 + constant SPI1_CRCPR 
              SPI1 $14 + constant SPI1_RXCRCR 
              SPI1 $18 + constant SPI1_TXCRCR 
              SPI1 $1C + constant SPI1_I2SCFGR 
              SPI1 $20 + constant SPI1_I2SPR 
                
            
              $40003800 constant SPI2  
              SPI2 $0 + constant SPI2_CR1 
              SPI2 $4 + constant SPI2_CR2 
              SPI2 $8 + constant SPI2_SR 
              SPI2 $C + constant SPI2_DR 
              SPI2 $10 + constant SPI2_CRCPR 
              SPI2 $14 + constant SPI2_RXCRCR 
              SPI2 $18 + constant SPI2_TXCRCR 
              SPI2 $1C + constant SPI2_I2SCFGR 
              SPI2 $20 + constant SPI2_I2SPR 
                
            
              $40012C00 constant TIM1  
              TIM1 $0 + constant TIM1_CR1 
              TIM1 $4 + constant TIM1_CR2 
              TIM1 $8 + constant TIM1_SMCR 
              TIM1 $C + constant TIM1_DIER 
              TIM1 $10 + constant TIM1_SR 
              TIM1 $14 + constant TIM1_EGR 
              TIM1 $18 + constant TIM1_CCMR1_Output 
              TIM1 $18 + constant TIM1_CCMR1_Input 
              TIM1 $1C + constant TIM1_CCMR2_Output 
              TIM1 $1C + constant TIM1_CCMR2_Input 
              TIM1 $20 + constant TIM1_CCER 
              TIM1 $24 + constant TIM1_CNT 
              TIM1 $28 + constant TIM1_PSC 
              TIM1 $2C + constant TIM1_ARR 
              TIM1 $30 + constant TIM1_RCR 
              TIM1 $34 + constant TIM1_CCR1 
              TIM1 $38 + constant TIM1_CCR2 
              TIM1 $3C + constant TIM1_CCR3 
              TIM1 $40 + constant TIM1_CCR4 
              TIM1 $44 + constant TIM1_BDTR 
              TIM1 $48 + constant TIM1_DCR 
              TIM1 $4C + constant TIM1_DMAR 
              TIM1 $50 + constant TIM1_OR1 
              TIM1 $54 + constant TIM1_CCMR3_Output 
              TIM1 $58 + constant TIM1_CCR5 
              TIM1 $5C + constant TIM1_CCR6 
              TIM1 $60 + constant TIM1_AF1 
              TIM1 $64 + constant TIM1_AF2 
              TIM1 $68 + constant TIM1_TISEL 
                
            
              $40012400 constant ADC  
              ADC $0 + constant ADC_ISR 
              ADC $4 + constant ADC_IER 
              ADC $8 + constant ADC_CR 
              ADC $C + constant ADC_CFGR1 
              ADC $10 + constant ADC_CFGR2 
              ADC $14 + constant ADC_SMPR 
              ADC $20 + constant ADC_AWD1TR 
              ADC $24 + constant ADC_AWD2TR 
              ADC $28 + constant ADC_CHSELR 
              ADC $28 + constant ADC_CHSELR_1 
              ADC $2C + constant ADC_AWD3TR 
              ADC $40 + constant ADC_DR 
              ADC $A0 + constant ADC_AWD2CR 
              ADC $A4 + constant ADC_AWD3CR 
              ADC $B4 + constant ADC_CALFACT 
              ADC $308 + constant ADC_CCR 
                
            
              $40010000 constant SYSCFG  
              SYSCFG $0 + constant SYSCFG_CFGR1 
              SYSCFG $18 + constant SYSCFG_CFGR2 
                
            
              $4000B000 constant TAMP  
              TAMP $0 + constant TAMP_CR1 
              TAMP $4 + constant TAMP_CR2 
              TAMP $C + constant TAMP_FLTCR 
              TAMP $2C + constant TAMP_IER 
              TAMP $30 + constant TAMP_SR 
              TAMP $34 + constant TAMP_MISR 
              TAMP $3C + constant TAMP_SCR 
              TAMP $100 + constant TAMP_BKP0R 
              TAMP $104 + constant TAMP_BKP1R 
              TAMP $108 + constant TAMP_BKP2R 
              TAMP $10C + constant TAMP_BKP3R 
              TAMP $110 + constant TAMP_BKP4R 
                
            
              $40005400 constant I2C1  
              I2C1 $0 + constant I2C1_CR1 
              I2C1 $4 + constant I2C1_CR2 
              I2C1 $8 + constant I2C1_OAR1 
              I2C1 $C + constant I2C1_OAR2 
              I2C1 $10 + constant I2C1_TIMINGR 
              I2C1 $14 + constant I2C1_TIMEOUTR 
              I2C1 $18 + constant I2C1_ISR 
              I2C1 $1C + constant I2C1_ICR 
              I2C1 $20 + constant I2C1_PECR 
              I2C1 $24 + constant I2C1_RXDR 
              I2C1 $28 + constant I2C1_TXDR 
                
            
              $40005800 constant I2C2  
              I2C2 $0 + constant I2C2_CR1 
              I2C2 $4 + constant I2C2_CR2 
              I2C2 $8 + constant I2C2_OAR1 
              I2C2 $C + constant I2C2_OAR2 
              I2C2 $10 + constant I2C2_TIMINGR 
              I2C2 $14 + constant I2C2_TIMEOUTR 
              I2C2 $18 + constant I2C2_ISR 
              I2C2 $1C + constant I2C2_ICR 
              I2C2 $20 + constant I2C2_PECR 
              I2C2 $24 + constant I2C2_RXDR 
              I2C2 $28 + constant I2C2_TXDR 
                
            
              $40002800 constant RTC  
              RTC $0 + constant RTC_TR 
              RTC $4 + constant RTC_DR 
              RTC $8 + constant RTC_SSR 
              RTC $C + constant RTC_ICSR 
              RTC $10 + constant RTC_PRER 
              RTC $14 + constant RTC_WUTR 
              RTC $18 + constant RTC_CR 
              RTC $24 + constant RTC_WPR 
              RTC $28 + constant RTC_CALR 
              RTC $2C + constant RTC_SHIFTR 
              RTC $30 + constant RTC_TSTR 
              RTC $34 + constant RTC_TSDR 
              RTC $38 + constant RTC_TSSSR 
              RTC $40 + constant RTC_ALRMAR 
              RTC $44 + constant RTC_ALRMASSR 
              RTC $48 + constant RTC_ALRMBR 
              RTC $4C + constant RTC_ALRMBSSR 
              RTC $50 + constant RTC_SR 
              RTC $54 + constant RTC_MISR 
              RTC $5C + constant RTC_SCR 
                
            
              $40002000 constant TIM14  
              TIM14 $0 + constant TIM14_CR1 
              TIM14 $C + constant TIM14_DIER 
              TIM14 $10 + constant TIM14_SR 
              TIM14 $14 + constant TIM14_EGR 
              TIM14 $18 + constant TIM14_CCMR1_Output 
              TIM14 $18 + constant TIM14_CCMR1_Input 
              TIM14 $20 + constant TIM14_CCER 
              TIM14 $24 + constant TIM14_CNT 
              TIM14 $28 + constant TIM14_PSC 
              TIM14 $2C + constant TIM14_ARR 
              TIM14 $34 + constant TIM14_CCR1 
              TIM14 $68 + constant TIM14_TISEL 
                
            
              $40000000 constant TIM2  
              TIM2 $0 + constant TIM2_CR1 
              TIM2 $4 + constant TIM2_CR2 
              TIM2 $8 + constant TIM2_SMCR 
              TIM2 $C + constant TIM2_DIER 
              TIM2 $10 + constant TIM2_SR 
              TIM2 $14 + constant TIM2_EGR 
              TIM2 $18 + constant TIM2_CCMR1_Output 
              TIM2 $18 + constant TIM2_CCMR1_Input 
              TIM2 $1C + constant TIM2_CCMR2_Output 
              TIM2 $1C + constant TIM2_CCMR2_Input 
              TIM2 $20 + constant TIM2_CCER 
              TIM2 $24 + constant TIM2_CNT 
              TIM2 $28 + constant TIM2_PSC 
              TIM2 $2C + constant TIM2_ARR 
              TIM2 $34 + constant TIM2_CCR1 
              TIM2 $38 + constant TIM2_CCR2 
              TIM2 $3C + constant TIM2_CCR3 
              TIM2 $40 + constant TIM2_CCR4 
              TIM2 $48 + constant TIM2_DCR 
              TIM2 $4C + constant TIM2_DMAR 
              TIM2 $50 + constant TIM2_OR1 
              TIM2 $60 + constant TIM2_AF1 
              TIM2 $68 + constant TIM2_TISEL 
                
            
              $40000400 constant TIM3  
              TIM3 $0 + constant TIM3_CR1 
              TIM3 $4 + constant TIM3_CR2 
              TIM3 $8 + constant TIM3_SMCR 
              TIM3 $C + constant TIM3_DIER 
              TIM3 $10 + constant TIM3_SR 
              TIM3 $14 + constant TIM3_EGR 
              TIM3 $18 + constant TIM3_CCMR1_Output 
              TIM3 $18 + constant TIM3_CCMR1_Input 
              TIM3 $1C + constant TIM3_CCMR2_Output 
              TIM3 $1C + constant TIM3_CCMR2_Input 
              TIM3 $20 + constant TIM3_CCER 
              TIM3 $24 + constant TIM3_CNT 
              TIM3 $28 + constant TIM3_PSC 
              TIM3 $2C + constant TIM3_ARR 
              TIM3 $34 + constant TIM3_CCR1 
              TIM3 $38 + constant TIM3_CCR2 
              TIM3 $3C + constant TIM3_CCR3 
              TIM3 $40 + constant TIM3_CCR4 
              TIM3 $48 + constant TIM3_DCR 
              TIM3 $4C + constant TIM3_DMAR 
              TIM3 $50 + constant TIM3_OR1 
              TIM3 $60 + constant TIM3_AF1 
              TIM3 $68 + constant TIM3_TISEL 
                
            
              $E000E100 constant NVIC  
              NVIC $0 + constant NVIC_ISER 
              NVIC $80 + constant NVIC_ICER 
              NVIC $100 + constant NVIC_ISPR 
              NVIC $180 + constant NVIC_ICPR 
              NVIC $300 + constant NVIC_IPR0 
              NVIC $304 + constant NVIC_IPR1 
              NVIC $308 + constant NVIC_IPR2 
              NVIC $30C + constant NVIC_IPR3 
              NVIC $310 + constant NVIC_IPR4 
              NVIC $314 + constant NVIC_IPR5 
              NVIC $318 + constant NVIC_IPR6 
              NVIC $31C + constant NVIC_IPR7 
              NVIC $320 + constant NVIC_IPR8 
                
            
              $E000ED90 constant MPU  
              MPU $0 + constant MPU_MPU_TYPER 
              MPU $4 + constant MPU_MPU_CTRL 
              MPU $8 + constant MPU_MPU_RNR 
              MPU $C + constant MPU_MPU_RBAR 
              MPU $10 + constant MPU_MPU_RASR 
                
            
              $E000E010 constant STK  
              STK $0 + constant STK_CSR 
              STK $4 + constant STK_RVR 
              STK $8 + constant STK_CVR 
              STK $C + constant STK_CALIB 
                
            
              $E000ED00 constant SCB  
              SCB $0 + constant SCB_CPUID 
              SCB $4 + constant SCB_ICSR 
              SCB $8 + constant SCB_VTOR 
              SCB $C + constant SCB_AIRCR 
              SCB $10 + constant SCB_SCR 
              SCB $14 + constant SCB_CCR 
              SCB $1C + constant SCB_SHPR2 
              SCB $20 + constant SCB_SHPR3 
                
            
              $40010030 constant VREFBUF  
              VREFBUF $0 + constant VREFBUF_CSR 
              VREFBUF $4 + constant VREFBUF_CCR 
                
            
              $40015800 constant DBG  
              DBG $0 + constant DBG_IDCODE 
              DBG $4 + constant DBG_CR 
              DBG $8 + constant DBG_APB_FZ1 
              DBG $C + constant DBG_APB_FZ2 
                
            
              $E000EF00 constant NVIC_STIR  
              NVIC_STIR $0 + constant NVIC_STIR_STIR 
                
            
              $E000E008 constant SCB_ACTRL  
              SCB_ACTRL $0 + constant SCB_ACTRL_ACTRL 
                
            
              $E000ED88 constant FPU_CPACR  
              FPU_CPACR $0 + constant FPU_CPACR_CPACR 
                
            
              $E000EF34 constant FPU  
              FPU $0 + constant FPU_FPCCR 
              FPU $4 + constant FPU_FPCAR 
              FPU $8 + constant FPU_FPSCR 
                
            
              $40010080 constant SYSCFG_ITLINE  
              SYSCFG_ITLINE $80 + constant SYSCFG_ITLINE_ITLINE0 
              SYSCFG_ITLINE $84 + constant SYSCFG_ITLINE_ITLINE1 
              SYSCFG_ITLINE $88 + constant SYSCFG_ITLINE_ITLINE2 
              SYSCFG_ITLINE $8C + constant SYSCFG_ITLINE_ITLINE3 
              SYSCFG_ITLINE $90 + constant SYSCFG_ITLINE_ITLINE4 
              SYSCFG_ITLINE $94 + constant SYSCFG_ITLINE_ITLINE5 
              SYSCFG_ITLINE $98 + constant SYSCFG_ITLINE_ITLINE6 
              SYSCFG_ITLINE $9C + constant SYSCFG_ITLINE_ITLINE7 
              SYSCFG_ITLINE $A4 + constant SYSCFG_ITLINE_ITLINE9 
              SYSCFG_ITLINE $A8 + constant SYSCFG_ITLINE_ITLINE10 
              SYSCFG_ITLINE $AC + constant SYSCFG_ITLINE_ITLINE11 
              SYSCFG_ITLINE $B0 + constant SYSCFG_ITLINE_ITLINE12 
              SYSCFG_ITLINE $B4 + constant SYSCFG_ITLINE_ITLINE13 
              SYSCFG_ITLINE $B8 + constant SYSCFG_ITLINE_ITLINE14 
              SYSCFG_ITLINE $BC + constant SYSCFG_ITLINE_ITLINE15 
              SYSCFG_ITLINE $C0 + constant SYSCFG_ITLINE_ITLINE16 
              SYSCFG_ITLINE $CC + constant SYSCFG_ITLINE_ITLINE19 
              SYSCFG_ITLINE $D4 + constant SYSCFG_ITLINE_ITLINE21 
              SYSCFG_ITLINE $D8 + constant SYSCFG_ITLINE_ITLINE22 
              SYSCFG_ITLINE $DC + constant SYSCFG_ITLINE_ITLINE23 
              SYSCFG_ITLINE $E0 + constant SYSCFG_ITLINE_ITLINE24 
              SYSCFG_ITLINE $E4 + constant SYSCFG_ITLINE_ITLINE25 
              SYSCFG_ITLINE $E8 + constant SYSCFG_ITLINE_ITLINE26 
              SYSCFG_ITLINE $EC + constant SYSCFG_ITLINE_ITLINE27 
              SYSCFG_ITLINE $F0 + constant SYSCFG_ITLINE_ITLINE28 
              SYSCFG_ITLINE $F4 + constant SYSCFG_ITLINE_ITLINE29 
                
            
              