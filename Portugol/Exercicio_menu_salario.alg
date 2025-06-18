inicio
    inteiro opcao
    real salario
    
    escrever "Menu de opões(1 , 2 , 3 , 4 ou 5):\n"
    escrever "1. Imposto\n"
    escrever "2. Novo Salário\n"
    escrever "3. Classificação\n"
    ler opcao
    
    escolhe opcao
        caso 1:
            escrever "Digite seu salário: R$"
            ler salario
            se salario > 850.0 entao
                escrever "seu imposto é: R$" , ( salario * 0.15 )
            senao
                se salario >= 500.0 entao
                    escrever "seu imposto é: R$" , ( salario * 0.10 )
                senao
                    escrever "seu imposto é: R$" , ( salario * 0.05 )
                fimse
            fimse
        caso 2:
            escrever "Digite seu salário: R$"
            ler salario
            se salario > 1500 entao
                escrever "seu aumento é: R$" , ( salario + 25.00 )
            senao
                se salario >= 750.0 entao
                    escrever "seu aumento é: R$" , ( salario + 50.00 )
                senao
                    se salario >= 450.0 entao
                        escrever "seu aumento é: R$" , ( salario + 75.00 )
                    senao
                        escrever "seu aumento é: R$" , ( salario + 100.00 )
                    fimse
                fimse
            fimse
        caso 3:
            escrever "Digite seu salário: R$"
            ler salario
            se salario > 700.0 entao
                escrever "Você é bem remunerado"
            senao
                escrever "Você é mal remunerado"
            fimse
        defeito:
            escrever "Seu codigo informado não é valído."
    fimescolhe
fim

