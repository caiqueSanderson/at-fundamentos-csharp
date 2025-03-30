namespace AssessmentCSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("--- Escolha o exercício ---");
            Console.WriteLine("Exercicio 1 - Criando e Executando seu Primeiro Programa");
            Console.WriteLine("Exercicio 2 - Manipulação de Strings - Cifrador de Nome");

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
            }
        }
    }
}
