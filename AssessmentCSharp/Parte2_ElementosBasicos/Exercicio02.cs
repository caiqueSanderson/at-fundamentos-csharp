using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentCSharp.Parte2_ElementosBasicos
{
    internal class Exercicio02
    {
        public void Executar()
        {
            Console.WriteLine("--- Manipulação de Strings - Cifrador de Nome ---");

            Console.Write("Insira seu nome completo: ");
            string nome = Console.ReadLine();
            char[] nomeArray = nome.ToCharArray();

            for (int i = 0; i < nomeArray.Length; i++)
            {
                if (char.IsLetter(nomeArray[i]))
                {
                    nomeArray[i] = (char)(nomeArray[i] + 2);
                }
            }

            string nomeCifrado = new string(nomeArray);
            Console.WriteLine($"Nome cifrado: {nomeCifrado}");
        }
    }
}
