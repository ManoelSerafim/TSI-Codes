inicio
    real n1 , n2 , n3 , media
    
    escrever "Digite Sua primeira nota (0 a 10): "
    ler n1
    escrever "Digite sua segunda nota (0 a 10): "
    ler n2
    escrever "Digite sua terceira nota (0 a 10): "
    ler n3
    media <- ( n1 + n2 + n3 ) / 3.0
    
    escrever "Sua media é: " , media , " - "
    
    se media >= 7.0 entao
        escrever "Aprovado"
    senao
        se media >= 3.0 entao
            escrever "Exame"
            escrever "\nSua nota para passar no exame é: " , ( 12.0 - media )
        senao
            escrever "Reprovado"
        fimse
    fimse
fim

