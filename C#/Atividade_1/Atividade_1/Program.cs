using System;

namespace Atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        { //Inicio

            //Declaração de variáveis
            string nome, dataNascimento, cpf, rg, bairro, rua, numero, CEP, estado, municipio, dddTelefone, telefone;
            double rendaMensal;

            void preencherDados()
            {
                //Método para preencher os dados
                Console.WriteLine("Preenchendo os dados...");
            }


            //Entrada de dados
            Console.WriteLine("Digite seu nome:");
            nome = (Console.ReadLine());
            Console.WriteLine("Digite sua data de nascimento:");
            dataNascimento = (Console.ReadLine());
            Console.WriteLine("Digite seu CPF:");
            cpf = (Console.ReadLine());
            Console.WriteLine("Digite seu RG:");
            rg = (Console.ReadLine());
            Console.WriteLine("Digite seu bairro:");
            bairro = (Console.ReadLine());
            Console.WriteLine("Digite sua rua:");
            rua = (Console.ReadLine());
            Console.WriteLine("Digite seu número:");
            numero = (Console.ReadLine());
            Console.WriteLine("Digite seu CEP:");
            CEP = (Console.ReadLine());
            Console.WriteLine("Digite seu estado:");
            estado = (Console.ReadLine());
            Console.WriteLine("Digite seu município:");
            municipio = (Console.ReadLine());
            Console.WriteLine("Digite seu DDD:");
            dddTelefone = (Console.ReadLine());
            Console.WriteLine("Digite seu telefone:");
            telefone = (Console.ReadLine());
            Console.WriteLine("Digite sua renda mensal:");
            rendaMensal = Convert.ToDouble(Console.ReadLine());


            //Saída de dados
            string endereço = $"Bairro {bairro}, Rua {rua}, {numero}, {municipio}-{estado}, {CEP}";
            Console.WriteLine($"\nNome: {nome}\nData de Nascimento: {dataNascimento}\nCPF: {cpf}\nRG: {rg}\nEndereço: {endereço}\nTelefone: {dddTelefone} {telefone}\nRenda Mensal: R${rendaMensal}");

        } //Fim
    }
}
