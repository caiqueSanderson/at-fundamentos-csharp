using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentCSharp.Parte4_POO
{
    class ContaBancaria
    {
        public string Titular { get; set; }
        private decimal saldo;

        public ContaBancaria(string titular)
        {
            Titular = titular;
            saldo = 0;
        }
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser positivo!");
            }
            else
            {
                saldo += valor;
                Console.WriteLine($"Depósito de R${valor:F2} realizado com sucesso!");
            }

        }
        public void Sacar(decimal valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Tentativa de saque: R${valor}");
                Console.WriteLine("Saldo insuficiente para realizar o saque!");
            }
            else
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R${valor:F2} realizado com sucesso!");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {saldo}");
        }
    }
    internal class Exercicio07
    {
        public void Executar()
        {
            Console.WriteLine("--- Banco Digital (Encapsulamento) ---");

            Console.Write("Titular da conta: ");
            string titular = Console.ReadLine();

            ContaBancaria conta = new ContaBancaria(titular);

            Console.Write("Depósito inicial: ");
            decimal depositoInicial = Convert.ToDecimal(Console.ReadLine());
            conta.Depositar(depositoInicial);

            conta.ExibirSaldo();

            Console.Write("Valor do saque: ");
            decimal saque = Convert.ToDecimal(Console.ReadLine());
            conta.Sacar(saque);

            conta.ExibirSaldo();
        }
    }
}
