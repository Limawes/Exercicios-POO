using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class DecimoSegundo
    {
        public void MediaAproveitamento()
        {
            int numId;
            decimal va1, va2, va3, mediaExer, ma;
            string conceito, status;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("============= // =============");
            Console.WriteLine("MEDIA DE APROVEITAMENTO DE UM ALUNO!");
            Console.WriteLine("============= // =============");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Informe o número de identificação do aluno: ");
            numId = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe as 3 notas obtidas nas verificações: ");
            va1 = decimal.Parse(Console.ReadLine());
            va2 = decimal.Parse(Console.ReadLine());
            va3 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a médias dos exercícios: ");
            mediaExer = decimal.Parse(Console.ReadLine());

            ma = (va1 + va2 * 2 + va3 * 3 + mediaExer) / 7;

            if (ma >= 90)
            {
                conceito = "A";
                status = "APROVADO";
            }
            else if (ma >= 75 && ma < 90)
            {
                conceito = "B";
                status = "APROVADO";
            }
            else if (ma >= 60 && ma < 75)
            {
                conceito = "C";
                status = "APROVADO";
            }
            else if (ma >= 40 && ma < 60)
            {
                conceito = "D";
                status = "REPROVADO";
            }
            else
            {
                conceito = "E";
                status = "REPROVADO";
            }

            Console.WriteLine($"O aluno com a identificação: {numId}");
            Console.WriteLine($"Tem a média: {ma}");
            Console.WriteLine($"O seu conceito é: {conceito}");
            Console.WriteLine($"E o seu status é: {status}");


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
