namespace AssessmentCSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("--- Escolha o exercício ---");
            Console.WriteLine("Exercicio 1 - Criando e Executando seu Primeiro Programa");
            Console.WriteLine("Exercicio 2 - Manipulação de Strings - Cifrador de Nome");
            Console.WriteLine("Exercicio 3 - Calculadora de Operações Matemáticas");
            Console.WriteLine("Exercicio 4 - Manipulação de Datas - Dias até o próximo aniversário");
            Console.WriteLine("Exercicio 5 - Tempo Restante para Conclusão do Curso");
            Console.WriteLine("Exercicio 6 - Cadastro de Alunos");
            Console.WriteLine("Exercicio 7 - Banco Digital (Encapsulamento)");
            Console.WriteLine("Exercício 8 - Cadastro de Funcionários (Herança)");
            Console.WriteLine("Exercicio 9 - Controle de Estoque via Linha de Comando");
            Console.WriteLine("Exercicio 10 - Jogo de Adivinhação");
            Console.WriteLine("Exercicio 11 - Cadastro e Listagem de Contatos");
            Console.WriteLine("Exercicio 12 - Formatos de Exibição");

            Console.Write("Sua escolha: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    var exercicio01 = new Parte1_PrepararAmbiente.Exercicio01();
                    exercicio01.Executar();
                    break;
                case "2":
                    var exercicio02 = new Parte2_ElementosBasicos.Exercicio02();
                    exercicio02.Executar();
                    break;
                case "3":
                    var exercicio03 = new Parte2_ElementosBasicos.Exercicio03();
                    exercicio03.Executar();
                    break;
                case "4":
                    var exercicio04 = new Parte2_ElementosBasicos.Exercicio04();
                    exercicio04.Executar();
                    break;
                case "5":
                    var exercicio05 = new Parte2_ElementosBasicos.Exercicio05();
                    exercicio05.Executar();
                    break;
                case "6":
                    var exercicio06 = new Parte3_ClassesObjetos.Exercicio06();
                    exercicio06.Executar();
                    break;
                case "7":
                    var exercicio07 = new Parte4_POO.Exercicio07();
                    exercicio07.Executar();
                    break;
                case "8":
                    var exercicio08 = new Parte4_POO.Exercicio08();
                    exercicio08.Executar();
                    break;
                case "9":
                    var exercicio09 = new Parte5_Arrays_Arquivos_RecursosAvancados.Exercicio09();
                    exercicio09.Executar();
                    break;
                case "10":
                    var exercicio10 = new Parte5_Arrays_Arquivos_RecursosAvancados.Exercicio10();
                    exercicio10.Executar();
                    break;
                case "11":
                    var exercicio11 = new Parte5_Arrays_Arquivos_RecursosAvancados.Exercicio11();
                    exercicio11.Executar();
                    break;
                case "12":
                    var exercicio12 = new Parte5_Arrays_Arquivos_RecursosAvancados.Exercicio12();
                    exercicio12.Executar();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
