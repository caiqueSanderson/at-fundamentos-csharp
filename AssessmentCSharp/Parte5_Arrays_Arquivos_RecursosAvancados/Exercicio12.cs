using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentCSharp.Parte5_Arrays_Arquivos_RecursosAvancados
{
    internal class Exercicio12
    {
        private const string NomeArquivo = "contatos.txt";
        public void Executar()
        {
            Console.WriteLine("--- Formatos de Exibição ---");
            while (true)
            {
                Console.WriteLine("\n-- Menu --");
                Console.WriteLine("1 - Adicionar novo contato");
                Console.WriteLine("2 - Listar contatos cadastrados");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine().Trim();

                switch (opcao)
                {
                    case "1":
                        AdicionarContato();
                        break;
                    case "2":
                        ListarContatos();
                        break;
                    case "3":
                        Console.WriteLine("Encerrando programa...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            }
        }

        private void AdicionarContato()
        {
            Console.Write("\nNome: ");
            string nome = Console.ReadLine().Trim();

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine().Trim();

            Console.Write("Email: ");
            string email = Console.ReadLine().Trim();

            string contato = $"{nome},{telefone},{email}";

            try
            {
                using (StreamWriter writer = new StreamWriter(NomeArquivo, true))
                {
                    writer.WriteLine(contato);
                }
                Console.WriteLine("Contato cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar o contato: {ex.Message}");
            }
        }

        private void ListarContatos()
        {
            List<Contato> contatos = CarregarContatos();

            if (!File.Exists(NomeArquivo) || contatos.Count == 0)
            {
                Console.WriteLine("Nenhum contato cadastrado.");
                return;
            }

            Console.WriteLine("\nEscolha o formato de exibição: ");
            Console.WriteLine(" 1. Markdown");
            Console.WriteLine(" 2. Tabela");
            Console.WriteLine(" 3. Texto Puro");
            Console.Write("Opção: ");

            string opcao = Console.ReadLine();
            ContatoFormatter formatter;

            switch (opcao)
            {
                case "1":
                    formatter = new MarkdownFormatter();
                    break;
                case "2":
                    formatter = new TabelaFormatter();
                    break;
                case "3":
                    formatter = new RawTextFormatter();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    return;
            }

            formatter.ExibirContatos(contatos);
        }

        private List<Contato> CarregarContatos()
        {
            List<Contato> contatos = new List<Contato>();

            try
            {
                string[] linhas = File.ReadAllLines(NomeArquivo);
                foreach (string linha in linhas)
                {
                    string[] info = linha.Split(",");
                    if (info.Length == 3)
                    {
                        contatos.Add(new Contato(info[0].Trim(), info[1].Trim(), info[2].Trim()));
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler os contatos: {ex.Message}");
            }

            return contatos;
        }

        internal class Contato
        {
            public string Nome { get; set; }
            public string Telefone { get; set; }
            public string Email { get; set; }

            public Contato(string nome, string tefone, string email)
            {
                Nome = nome;
                Telefone = tefone;
                Email = email;
            }

        }

        abstract class ContatoFormatter
        {
            public abstract void ExibirContatos(List<Contato> contatos);
        }

        class MarkdownFormatter : ContatoFormatter
        {
            public override void ExibirContatos(List<Contato> contatos)
            {
                Console.WriteLine("\n## Lista de Contatos\n");
                foreach (Contato contato in contatos)
                {
                    Console.WriteLine($"- **Nome:** {contato.Nome}");
                    Console.WriteLine($"- Telefone: {contato.Telefone}");
                    Console.WriteLine($"- Email: {contato.Email}\n");
                }
            }
        }

        class TabelaFormatter : ContatoFormatter
        {
            public override void ExibirContatos(List<Contato> contatos)
            {
                Console.WriteLine("\nLista de Contatos\n");
                Console.WriteLine("\n----------------------------------------");
                Console.WriteLine("|  Nome  |  Telefone  |  Email  |");
                Console.WriteLine("----------------------------------------");

                foreach (Contato contato in contatos)
                {
                    Console.WriteLine($"| {contato.Nome,-12} | {contato.Telefone,-12} | {contato.Email,-12} |");
                }

                Console.WriteLine("----------------------------------------\n");
            }
        }

        class RawTextFormatter : ContatoFormatter
        {
            public override void ExibirContatos(List<Contato> contatos)
            {
                Console.WriteLine("\nLista de Contatos\n");
                foreach (var contato in contatos)
                {
                    Console.WriteLine($"Nome: {contato.Nome} | Telefone: {contato.Telefone} | Email: {contato.Email}");
                }
            }
        }
    }
}
