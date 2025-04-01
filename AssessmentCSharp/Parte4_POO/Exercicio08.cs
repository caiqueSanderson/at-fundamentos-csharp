using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssessmentCSharp.Parte4_POO;

namespace AssessmentCSharp.Parte4_POO
{
    //Problema como a bonificação
    class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal SalarioBase { get; set; }

        public Funcionario(string nome, string cargo, decimal salarioBase)
        {
            Nome = nome;
            Cargo = cargo;
            SalarioBase = salarioBase;
        }

        public virtual decimal CalcularSalario()
        {
            return SalarioBase;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salário: {CalcularSalario():F2}");
        }
    }

    class Gerente : Funcionario
    {
        public Gerente(string nome, decimal salarioBase) : base(nome, "Gerente", salarioBase)
        {
        }
        public override decimal CalcularSalario()
        {
            return SalarioBase * 1.20m;
        }
    }

    internal class Exercicio08
    {
        public void Executar()
        {
            Funcionario funcionario = new Funcionario("João", "Analista de Sistemas", 5000);
            funcionario.ExibirDados();

            Funcionario gerente = new Gerente("Maria", 8000);
            gerente.ExibirDados();
        }
    }
}