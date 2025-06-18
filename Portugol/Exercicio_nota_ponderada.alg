inicio
    real n1 , n2 , n3 , media
    
    escrever "Digite a nota do trabalho do laboratório (0 a 10): "
    ler n1
    escrever "Digite a nota da avaliação semestral (0 a 10): "
    ler n2
    escrever "Digite a nota do exame final (0 a 10): "
    ler n3
    
    media <- ( ( ( n1 * 2.0 ) + ( n2 * 3.0 ) + ( n3 * 5.0 ) ) / 10.0 )
    escrever "Sua média foi " , media , " -"
    
    se media >= 8 entao
        escrever " Conceito A"
    senao
        se media >= 7 entao
            escrever " Conceito B"
        senao
            se media >= 6 entao
                escrever " Conceito C"
            senao
                se media >= 5 entao
                    escrever " Conceito D"
                senao
                    escrever " Conceito E"
                fimse
            fimse
        fimse
    fimse
fim

