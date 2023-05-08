using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Quarto
    {
        public void SomaOuMutiplica()
        {
            int a;
            int b;

            int soma;
            int mult;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("============= // =============");
            Console.WriteLine("SOMA OU MULTIPLICA");
            Console.WriteLine("============= // =============");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Informe um valor: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe outro valor: ");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                soma = a + b;
                Console.WriteLine("Os valores são iguais, e a soma deles é: " + soma);
            }
            else
            {
                mult = a * b;
                Console.WriteLine("Os valores são diferentes, e a multiplicação entre eles é: "+ mult);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
