using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Nono
    {
        public void PesoIdeal()
        {
            decimal altura;
            string sexo;
            decimal pesoIdeal;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("============= // =============");
            Console.WriteLine("CALCULADORA DE PESO IDEAL");
            Console.WriteLine("============= // =============");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Informe seu sexo: (M) ou (F): ");
            sexo = Console.ReadLine().ToUpper();

            Console.WriteLine("Informe sua altura: ");
            altura = decimal.Parse(Console.ReadLine());

            if (sexo == "M")
            {
                pesoIdeal = (decimal.Parse(("72,7")) * altura) - 58;
                Console.WriteLine("Seu peso ideal é: " +  pesoIdeal);
            }
            else
            {
                pesoIdeal =(decimal.Parse(("62,1")) * altura) - decimal.Parse("44,7");
                Console.WriteLine("Seu peso ideal é: " + pesoIdeal);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
