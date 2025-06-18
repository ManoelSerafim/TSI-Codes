using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sintomas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char menuselction;
            double num1;
            double num2;
            double result;

            // Exibe o menu de operações
            void Menu()
            {
                Console.WriteLine("Menu Calculadora");
                Console.WriteLine("Soma (+)");
                Console.WriteLine("Subtração (-)");
                Console.WriteLine("Multiplicação (*)");
                Console.WriteLine("Divisão (/)");
                Console.WriteLine("Escolha a opção de operação");
                menuselction = Convert.ToChar(Console.ReadLine());
            }

            // Verifica a opção escolhida
            void VerificaSeleção()
            {
                switch (menuselction)
                {
                    case '+':
                        Console.WriteLine("Você escolheu a operação de soma");
                        Console.WriteLine("Digite o primeiro número");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 + num2;
                        Console.WriteLine($"Resultado da soma: {num1} + {num2} = {result}");
                        break;
                    case '-':
                        Console.WriteLine("Você escolheu a operação de subtração");
                        Console.WriteLine("Digite o primeiro número");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 - num2;
                        Console.WriteLine($"Resultado da subtração: {num1} - {num2} = {result}");
                        break;
                    case '*':
                        Console.WriteLine("Você escolheu a operação de multiplicação");
                        Console.WriteLine("Digite o primeiro número");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 * num2;
                        Console.WriteLine($"Resultado da multiplicação: {num1} * {num2} = {result}");
                        break;
                    case '/':
                        Console.WriteLine("Você escolheu a operação de divisão");
                        Console.WriteLine("Digite o primeiro número");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        if (num2 == 0)
                        {
                            Console.WriteLine("Divisão por zero não é permitida.");
                            Console.WriteLine("Retornando pro Menu");
                            Logic();
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Resultado da divisão: {num1} / {num2} = {result}");
                        }
                        break;

                }
            }

            // Método para verificar se o usuário deseja continuar
            void Logic()
            {
                Menu();
                VerificaSeleção();
            }

            // Chama o método Logic para iniciar o programa
            while (true) {
            Logic();
        }
        }
    }
}
