inicio
    inteiro idade
    caracter sexo
    real controle <- 0.0
    inteiro numsalario150 <- 0
    real maiorsalario <- -1.0
    real numfilhos , medfilhos , sumfilhos <- 0.0
    real salario , medsalario , sumsalario <- 0.0
    
    faz
        escrever "Insira sua idade: "
        ler idade
        se idade > 0 entao
            //escrever "Escreva seu Sexo (M/F): "
            //ler sexo
            escrever "Escreva seu Salario: "
            ler salario
            se salario > maiorsalario entao
                maiorsalario <- salario
            fimse
            se salario <= 150.0 entao
                numsalario150 <- numsalario150 + 1
            fimse
            
            sumsalario <- sumsalario + salario// acumulador
            
            escrever "Escreva o Numero de Filhos: "
            ler numfilhos
            sumfilhos <- sumfilhos + numfilhos
            
            controle <- controle + 1.0// contador
            medsalario <- ( sumsalario / controle )
            medfilhos <- ( sumfilhos / controle )
        fimse
    enquanto idade > 0
    escrever "\nMedia de salarios é: R$" , medsalario
    escrever "\nMedia de Filhos é: " , medfilhos
    escrever "\nO Maior Salário é: " , maiorsalario
    escrever "\nA Porcentagem de Salarios até 150: " , ( ( numsalario150 * 100 ) / controle ) , "%"
fim

