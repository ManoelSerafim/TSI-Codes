inicio
    inteiro codigo
    real salarioatual
    
    escrever "Escreva seu codigo de cargo (1 , 2 , 3 , 4 ou 5): "
    ler codigo
    escrever "Escreva seu salario atual: R$ "
    ler salarioatual
    
    escolhe codigo
        caso 1:
            escrever "Seu cargo é Escriturário. Seu aumento é de: R$" , ( salarioatual * 0.5 ) , " e seu novo salario é de: R$" , ( salarioatual * 1.5 )
        caso 2:
            escrever "Seu cargo é Secretário. Seu aumento é de: R$" , ( salarioatual * 0.35 ) , " e seu novo salario é de: R$" , ( salarioatual * 1.35 )
        caso 3:
            escrever "Seu cargo é Caixa. Seu aumento é de: R$" , ( salarioatual * 0.2 ) , " e seu novo salario é de: R$" , ( salarioatual * 1.2 )
        caso 4:
            escrever "Seu cargo é Gerente. Seu aumento é de: R$" , ( salarioatual * 0.1 ) , " e seu novo salario é de: R$" , ( salarioatual * 1.1 )
        caso 5:
            escrever "Seu cargo é Diretor e não possui aumento; Seu salario permanece R$" , salarioatual
        defeito:
            escrever "Seu codigo informado não é valído."
    fimescolhe
fim

