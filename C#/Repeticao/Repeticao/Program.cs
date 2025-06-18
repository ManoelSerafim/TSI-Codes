using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool continuar = true;
            //DateTime data = DateTime.Now;
            
            /*for (int i = 1000; i >= 1; i--)
            { 
                Console.WriteLine($"i:{i}");
            }
            TimeSpan tempo = DateTime.Now - data;
            Console.WriteLine($"Tempo gasto: {tempo.TotalSeconds} s");
            while (continuar)
            { */


            double n1, n2;
            int resposta;
            string voltar;
            do
            {
                Console.WriteLine("Digite a opção do menu\n1 - Somar 2 números\n2 - Raiz Quadrada de um número\n3 - Sair");
                resposta = Convert.ToInt16(Console.ReadLine());
                switch (resposta)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Digite o primeiro número:");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número:");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"A soma é: {n1 + n2}");
                        Console.WriteLine("Pressione qualquer tecla para sair");
                        voltar = Console.ReadLine();
                        if (voltar.ToLower() == "sair")
                        {
                            resposta = 3; // Sair do loop
                        }
                        else
                        {
                            Console.Clear();
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Digite um número para calcular a raiz quadrada:");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        if (n1 < 0)
                        {
                            Console.WriteLine("Não é possível calcular a raiz quadrada de um número negativo.");
                        }
                        else
                        {
                            Console.WriteLine($"A raiz quadrada de {n1} é: {Math.Sqrt(n1)}");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }
            } while (resposta != 3);
        }
    }
}
