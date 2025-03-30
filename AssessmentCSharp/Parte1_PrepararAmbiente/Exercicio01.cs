namespace AssessmentCSharp.Parte1_PrepararAmbiente
{
    internal class Exercicio01
    {
        public void Executar()
        {
            Console.WriteLine("--- Primeiro Programa ---");

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira sua data de nascimento: ");
            string dataNascimento = Console.ReadLine();

            Console.WriteLine($"Olá, meu nome é {nome}!");
            Console.WriteLine($"Nasci em {dataNascimento} e estou aprendendo C#.");
        }
    }
}
