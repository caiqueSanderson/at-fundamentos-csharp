using System;

namespace AssessmentCSharp.Parte5_Arrays_Arquivos_RecursosAvancados
{
    internal class Exercicio10
    {
        public void Executar()
        {
            Console.WriteLine("--- Jogo da Adivinhação ---");
            Console.WriteLine("Adivinhe um número entre 1 e 50.");
            Console.WriteLine("Você tem 5 tentativas!");

            Random random = new Random();
            int numeroAleatorio = random.Next(1, 51);
            bool acertou = false;

            for (int i = 0; i < 5 && !acertou; i++)
            {
                bool numeroValido = false;
                int numero = 0;

                while (!numeroValido)
                {
                    Console.Write("Insira o seu palpite: ");
                    string entrada = Console.ReadLine();

                    try
                    {
                        numero = int.Parse(entrada);
                        if (numero >= 1 && numero <= 50)
                        {
                            numeroValido = true;
                        }
                        else
                        {
                            Console.WriteLine("Número fora do intervalo. Tente novamente.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Entrada inválida! Digite um número inteiro.");
                    }
                }

                if (numero == numeroAleatorio)
                {
                    Console.WriteLine("Parabéns! Você acertou o número!");
                    acertou = true;
                }
                else if (numero < numeroAleatorio)
                {
                    Console.WriteLine("O número é maior.");
                }
                else
                {
                    Console.WriteLine("O número é menor.");
                }
            }

            if (!acertou)
            {
                Console.WriteLine($"Você perdeu! O número correto era {numeroAleatorio}.");
            }
        }
    }
}
