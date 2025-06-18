inicio
    inteiro x [ 2 ] [ 2 ]
    inteiro resultante [ 2 ] [ 2 ]
    inteiro i , j
    inteiro maior <- -1000
    
    //Carregando elementos para a matriz
    para i de 0 ate 1
        para j de 0 ate 1
            escrever "Digite o número da linha " , i , " e coluna " , j , ": "
            ler x [ i ] [ j ]
            //Seleção do maior elemento
            se x [ i ] [ j ] > maior entao
                maior <- x [ i ] [ j ]
            fimse
        proximo
    proximo
    
    //Multiplicação por maior
    para i de 0 ate 1
        para j de 0 ate 1
            resultante [ i ] [ j ] <- ( x [ i ] [ j ] * maior )
            //Imprimindo elementos de uma matriz
            escrever "Resultado: X[" , i , " , " , j , "] = " , resultante [ i ] [ j ] , "\t"
        proximo
        escrever "\n"
    proximo
fim

