using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentCSharp.Parte2_ElementosBasicos
{
    internal class Exercicio04
    {
        public void Executar()
        {
            Console.WriteLine("--- Manipulação de Datas - Dias até o próximo aniversário ---");

            Console.WriteLine("Insira sua data de nascimento(dd-mm-yyyy)");
            bool dataValida = false;
            do
            {
                string dataNascimento = Console.ReadLine();
                if (DateTime.TryParse(dataNascimento, out DateTime dataNascimentoValida))
                {
                    DateTime dataAtual = DateTime.Now;
                    DateTime proximoAniversario = new DateTime(dataAtual.Year, dataNascimentoValida.Month, dataNascimentoValida.Day);
                    if (proximoAniversario < dataAtual)
                    {
                        proximoAniversario = proximoAniversario.AddYears(1);
                    }

                    int diasFaltando = proximoAniversario.Subtract(dataAtual).Days;
                    Console.WriteLine($"Faltam {diasFaltando} dias para o seu próximo aniversário");

                    if (diasFaltando == 0)
                    {
                        Console.WriteLine("Feliz aniversário!");
                    }

                    if (diasFaltando < 7)
                    {
                        Console.WriteLine("Seu aniversário está chegando! Se prepare para comemorar!");
                    }
                    {
                        Console.WriteLine("Amanhã é seu aniversário!");
                    }
                    dataValida = true;
                }
                else
                {
                    Console.WriteLine("Data inválida, insira novamente");
                }
            }
            while (!dataValida);

        }
    }
}
