using System;

namespace Exercicio_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vetor1;
            vetor1 = new double[10];

            double[] vetor2;
            vetor2 = new double[10];

            // Resultados
            double[] vetor3;
            vetor3 = new double[10];

            char menu;

            // Leitura dos vetores
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("Digite o valor do vetor 1: ");
                vetor1[i] = Convert.ToDouble(Console.ReadLine());

            }

            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine("Digite o valor do vetor 2: ");
                vetor2[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Menu de operações
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("A - Somar os vetores");
            Console.WriteLine("B - Subtração dos vetores");
            Console.WriteLine("C - Multiplicação de um vetor por escalar (Inteiro)");

            // Lê a opção do usuário
            menu = Convert.ToChar(Console.ReadLine());

            // Verifica a opção escolhida e executa a operação correspondente
            switch (menu)
            {

                case 'A': // Soma
                    for (int i = 0; i < vetor1.Length; i++)
                    {
                        vetor3[i] = vetor1[i] + vetor2[i];
                    }
                    break;

                case 'B': // Subtração
                    for (int i = 0; i < vetor1.Length; i++)
                    {
                        vetor3[i] = vetor1[i] - vetor2[i];
                    }
                    break;

                case 'C': // Multiplicação de um vetor por escalar
                    Console.WriteLine("Digite o valor do escalar (Inteiro): ");
                    int escalar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escolha o vetor: ");
                    Console.WriteLine("1 - Vetor 1");
                    Console.WriteLine("2 - Vetor 2");
                    int vetorEscolhido = Convert.ToInt32(Console.ReadLine());

                    if (vetorEscolhido == 1)
                    {
                        for (int i = 0; i < vetor1.Length; i++)
                        {
                            vetor3[i] = vetor1[i] * escalar;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < vetor2.Length; i++)
                        {
                            vetor3[i] = vetor2[i] * escalar;
                        }

                    }
                    break;
            }

            // Exibir resultados
            for (int i = 0; i < vetor3.Length; i++)
            {
                Console.WriteLine($"Resultado {i + 1}: {vetor3[i]}");
            }
            Console.ReadKey();

        }
    }
}
