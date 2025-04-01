using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentCSharp.Parte2_ElementosBasicos
{
    internal class Exercicio03
    {
        public void Executar()
        {
            Console.WriteLine("--- Calculadora de Operações Matemáticas ---");
            double primeiroNumero = LerNumero("Insira o primeiro numero: ");

            double segundoNumero = LerNumero("Insira o segundo numero: ");

            Console.WriteLine("Operações selecionáveis");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            Console.Write("Insira a operação desejada: ");
            string opcao = Console.ReadLine();

            switch (opcao.Trim())
            {
                case "1":
                    Console.WriteLine($"{primeiroNumero} + {segundoNumero} = {primeiroNumero + segundoNumero}");
                    break;
                case "2":
                    Console.WriteLine($"{primeiroNumero} - {segundoNumero} = {primeiroNumero - segundoNumero}");
                    break;
                case "3":
                    Console.WriteLine($"{primeiroNumero} * {segundoNumero} = {primeiroNumero * segundoNumero}");
                    break;
                case "4":
                    if (segundoNumero == 0)
                    {
                        Console.WriteLine("Não é possível dividir por zero!");
                        break;
                    }
                    Console.WriteLine($"{primeiroNumero} / {segundoNumero} = {primeiroNumero / segundoNumero}");
                    break;
                default:
                    Console.WriteLine("Insira uma opção válida!");
                    break;
            }

        }

        private double LerNumero(string mensagem)
        {
            double numero;
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out numero))
                {
                    return numero;
                }
                Console.WriteLine("Entrada inválida! Digite um número válido.");
            }
        }
    }
}
