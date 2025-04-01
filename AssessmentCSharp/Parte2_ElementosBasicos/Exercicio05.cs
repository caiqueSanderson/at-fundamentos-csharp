using System;
using System.Globalization;

namespace AssessmentCSharp.Parte2_ElementosBasicos
{
    internal class Exercicio05
    {
        public void Executar()
        {
            Console.WriteLine("--- Tempo Restante para a Conclusão do Curso ---");

            DateTime dataFormatura = new DateTime(2026, 12, 15);
            DateTime dataAtual;

            while (true)
            {
                Console.Write("Insira a data atual (dd/mm/yyyy): ");
                string entrada = Console.ReadLine();

                if (DateTime.TryParseExact(entrada, "dd/mm/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataAtual))
                {
                    if (dataAtual > DateTime.Today)
                    {
                        Console.WriteLine("Erro: A data informada não pode ser no futuro!");
                        continue;
                    }
                    if (dataAtual > dataFormatura)
                    {
                        Console.WriteLine("Parabéns! Você já deveria estar formado!");
                        return;
                    }
                    break; 
                }
                else
                {
                    Console.WriteLine("Erro: Formato inválido. Digite a data no formato dd/mm/yyyy.");
                }
            }

            int dias = dataFormatura.Day - dataAtual.Day;
            int meses = dataFormatura.Month - dataAtual.Month;
            int anos = dataFormatura.Year - dataAtual.Year;

            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month);
            }

            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            if (anos > 0)
            {
                Console.WriteLine($"Faltam {anos} anos, {meses} meses e {dias} dias para sua formatura!");
            }
            else
            {
                Console.WriteLine($"Faltam {meses} meses e {dias} dias para sua formatura!");
            }

            if (anos == 0 && meses < 6)
            {
                Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
            }
        }
    }
}
