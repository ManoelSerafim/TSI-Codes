inicio
    inteiro num [ 20 ]
    inteiro i
    //Preenche o array
    para i de 0 ate 19
        escrever "Digite um número " , i , ": "
        ler num [ i ]
    proximo
    //Exibe os números pósitivos do array
    para i de 0 ate 19
        se num [ i ] > 0 entao
            escrever "O número " , num [ i ] , " é positivo \n"
        senao
            //Não faz nada, números negativos...
        fimse
    proximo
fim

