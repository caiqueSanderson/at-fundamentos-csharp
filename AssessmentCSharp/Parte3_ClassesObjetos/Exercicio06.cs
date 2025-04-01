using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentCSharp.Parte3_ClassesObjetos
{
    class Aluno
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Curso { get; set; }
        public double MediaNotas { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Curso: {Curso}");
            Console.WriteLine($"Média das Notas: {MediaNotas}");
        }

        public string VerificarAprovacao()
        {
            if (MediaNotas >= 7)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
    }
    internal class Exercicio06
    {
        public void Executar()
        {
            Console.WriteLine("--- Cadastro de Alunos ---");

            Aluno aluno = new Aluno();

            Console.Write("Nome: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Matrícula: ");
            aluno.Matricula = Console.ReadLine();

            Console.Write("Curso: ");
            aluno.Curso = Console.ReadLine();

            Console.Write("Média das Notas: ");
            aluno.MediaNotas = Convert.ToDouble(Console.ReadLine());

            aluno.ExibirDados();

            Console.WriteLine($"Situação: {aluno.VerificarAprovacao()}");
        }
    }

}
