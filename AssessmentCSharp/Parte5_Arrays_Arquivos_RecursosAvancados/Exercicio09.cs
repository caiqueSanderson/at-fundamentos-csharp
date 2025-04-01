using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentCSharp.Parte5_Arrays_Arquivos_RecursosAvancados
{
    internal class Exercicio09
    {
        public void Executar()
        {
            Console.WriteLine("--- Controle de Estoque via Linha de Comando ---");

            string[,] produtos = new string[5, 3];
            int indiceProduto = 0;

            do
            {
                Console.WriteLine("-- Menu --");
                Console.WriteLine("1. Inserir Produto");
                Console.WriteLine("2. Listar Produtos");
                Console.WriteLine("3. Sair");

                string opcao = Console.ReadLine().Trim();
                switch (opcao)
                {
                    case "1":
                        if (indiceProduto < 5)
                        {
                            Console.WriteLine("- Cadastrar produto -");
                            Console.Write("Insira o nome do produto: ");
                            produtos[indiceProduto, 0] = Console.ReadLine().Trim();

                            Console.Write("Insira a quantidade em estoque: ");
                            produtos[indiceProduto, 1] = Console.ReadLine().Trim();

                            Console.Write("Insira o preço unitário: ");
                            produtos[indiceProduto, 2] = Console.ReadLine().Trim();

                            Console.WriteLine("Produto cadastrado com sucesso");
                            indiceProduto++;
                        }
                        else
                        {
                            Console.WriteLine("Limite de produtos atingido! (Máximo = 5)");
                        }

                        break;
                    case "2":
                        if (indiceProduto == 0)
                        {
                            Console.WriteLine("Nenhum produto cadastrado!");
                        }
                        else
                        {
                            Console.WriteLine("- Listar Produtos -");
                            for (int i = 0; i < indiceProduto; i++)
                            {
                                Console.WriteLine($"Produto: {produtos[i, 0]} | Quantidade: {produtos[i, 1]} | Preço: {produtos[i, 2]}");
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("Saindo do programa...");
                        return;
                    default:
                        Console.WriteLine("Opção inserida inválida!");
                        break;
                }
            }
            while (true);

        }
    }
}
