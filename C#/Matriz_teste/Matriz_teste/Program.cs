using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[2, 5];
            // Preenchendo a matriz com valores
            for (int i = 0; i <=1; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                    x[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            // Exibindo a matriz
            for (int i = 0; i <= 1; i++)
            {
                Console.Write("\n");
                for (int j = 0; j <= 4; j++)
                {
                    // Console.Write("x[" + i + "," + j + "] = " + x[i, j] + "\n");
                    Console.Write($"X[{i},{j}] = {x[i, j]} \t");
                }
            }
            Console.ReadKey();
        }
    }
}
