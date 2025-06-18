using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atvd_matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[2, 2];
            int[,] result = new int[2, 2];
            int maior = -1000;

            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j <= 1; j++)
                {
                    // Preenchendo a matriz com valores
                    Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                    // Atribuindo o valor maior
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                    }
                }

            }

            for (int i = 0; i <= 1; i++)
            {
                Console.Write("\n");
                for (int j = 0; j <= 1; j++)
                {
                    // Calculando o resultado
                    result[i, j] = (matriz[i, j] * maior);
                    // Exibindo o resultado
                    Console.Write($"Resultado[{i},{j}] = {result[i, j]} \t");
                }
            }
            Console.ReadKey();
        }
    }
}
