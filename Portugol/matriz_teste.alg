inicio
    inteiro x [ 2 ] [ 5 ]
    inteiro i , j
    //Carregando elementos para uma matriz
    para i de 0 ate 1
        para j de 0 ate 4
            escrever "Digite o número da linha " , i , " e coluna " , j , ": "
            ler x [ i ] [ j ]
        proximo
    proximo
    //Imprimindo elementos de uma matriz
    para i de 0 ate 1
        para j de 0 ate 4
            escrever "x[" , i , "][" , j , "] = "
            escrever x [ i ] [ j ], "\t"
            se j = 4 então
            escrever "\n"
            fimse
        proximo
    proximo
fim

