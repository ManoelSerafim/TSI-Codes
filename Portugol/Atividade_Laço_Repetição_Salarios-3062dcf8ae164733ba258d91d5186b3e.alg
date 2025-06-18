início
    inteiro idade
    real salario, numfilhos, maiorsalario
    real somatoriosalarios <- 0.0
    real somatoriofilhos <- 0.0
    real numpessoas <- 0.0
    real numsalarios150 <- 0.0
    maiorsalario <- -1.0
    faz 
        escrever "\nDigite a idade: "
        ler idade
        escrever "\nDigite o salário: R$"
        ler salario
        escrever "\nDigite o número de filhos: "
        ler numfilhos        
        somatoriosalarios <- somatoriosalarios + salario // acumulador
        somatoriofilhos <- somatoriofilhos + numfilhos // acumulador
        numpessoas <- numpessoas + 1.0 // contador   
        se salario > maiorsalario então //Calcula o maior salário
            maiorsalario <- salario
        fimse
        se salario <= 150.0 então // Conta salários até R$ 150
            numsalarios150 <- numsalarios150 + 1.0
        fimse                  
    enquanto idade > 0        
    escrever "A média de salários = R$ ", (somatoriosalarios / numpessoas)
    escrever "A média de filhos = ", (somatoriofilhos / numpessoas)
    escrever "Pessoas com salário até R$ 150 = ", (numsalarios150 * 100 / numpessoas), "% pessoas"
fim 