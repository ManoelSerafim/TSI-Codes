using System;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            double salario, salariocombonificacao = 0.0;

            void Exercicio1()
            {
                Console.Write("Digite o código do funcionário (1, 2 ,3 ,4 ou 5): ");
                codigo = Convert.ToInt32(Console.ReadLine());
                if (codigo == 5)
                {
                    Console.WriteLine($"Seu Cargo é Diretor - Você não tem aumento.");
                }
                else if (codigo < 1 || codigo > 5)
                {
                    Console.WriteLine("Código inválido");
                }
                else
                {
                    Console.Write("Digite o salário do funcionário: R$");
                    salario = Convert.ToDouble(Console.ReadLine());

                    switch (codigo)
                    {
                        case 1:
                            Console.WriteLine($"Seu Cargo é Escrituario - Seu aumento é de: R${salario * 0.5}\nSeu novo salario é R${salario * 1.5}");
                            break;
                        case 2:
                            Console.WriteLine($"Seu Cargo é Secretário - Seu aumento é de: R${salario * 0.35}\nSeu novo salario é R${salario * 1.35}");
                            break;
                        case 3:
                            Console.WriteLine($"Seu Cargo é Caixa - Seu aumento é de: R${salario * 0.2}\nSeu novo salario é R${salario * 1.2}");
                            break;
                        case 4:
                            Console.WriteLine($"Seu Cargo é Gerente - Seu aumento é de: R${salario * 0.1}\nSeu novo salario é R${salario * 1.1}");
                            break;
                        default:
                            break;
                    }
                }
            }

            void Exercicio2()
            {
                Console.Write("Digite seu salario: R$");
                salario = Convert.ToDouble(Console.ReadLine());

                // Caclculo da bonificação
                if (salario <= 500)
                {
                    salariocombonificacao = salario * 1.05;
                }
                else if (salario <= 1200)
                {
                    salariocombonificacao = salario * 1.12;
                }

                // Calculo do Auxilio
                if (salario <= 600)
                {
                    salariocombonificacao += 150;
                }
                else
                {
                    salariocombonificacao += 100;
                }

                Console.WriteLine($"Seu salario com bonificação é R${salariocombonificacao}");
            }

            Exercicio2();
        }
    }
}
