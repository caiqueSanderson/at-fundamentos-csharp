using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentCSharp.Parte5_Arrays_Arquivos_RecursosAvancados
{
    internal class Exercicio11
    {
        private const string NomeArquivo = "contatos.txt";
        public void Executar()
        {
            while (true)
            {
                Console.WriteLine("--- Cadastro e Listagem de Contatos ---");
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
            if (!File.Exists(NomeArquivo))
            {
                Console.WriteLine("Nenhum contato cadastrado.");
                return;
            }

            try
            {
                string[] linhas = File.ReadAllLines(NomeArquivo);

                if (linhas.Length == 0)
                {
                    Console.WriteLine("Nenhum contato cadastrado.");
                }
                else
                {
                    Console.WriteLine("\nContatos Cadastrados:");
                    foreach (string linha in linhas)
                    {
                        string[] info = linha.Split(",");
                        if (info.Length == 3)
                        {
                            Console.WriteLine($"Nome: {info[0]} | Telefone: {info[1]} | Email: {info[2]}");
                        }
                    }

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler os contatos: {ex.Message}");
            }
        }
    }
}
