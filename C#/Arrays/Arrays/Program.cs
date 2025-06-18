using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[6]; // Array de inteiros para armazenar números

            string[] nomes = new string[6]; // Array de strings para armazenar nomes

            int colocacao; // Variável para armazenar a colocação do candidato

            // Preenchendo o array com valores fornecidos pelo usuário
            for (int i = 0; i < 3/*nomes.Length*/; i++)
            {
                Console.Write($"Digite o nome do candidato: ");
                nomes[i] = Console.ReadLine();

                Console.Write($"Digite a nota do candidato {nomes[i]}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Exibindo os nomes e notas dos candidatos
            Console.WriteLine("\nDigite a colocação do candidato (1 a 6) para ver os detalhes:");
            colocacao = 1 - Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nDetalhes do candidato {nomes[colocacao]} com nota {notas[colocacao]}");

            Console.ReadKey(); // Mantém o console aberto até que uma tecla seja pressionada
        }
    }
}
