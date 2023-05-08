using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Setimo
    {
        public void SomaParOuImpar()
        {
            int num;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("============= // =============");
            Console.WriteLine("+5 SE PAR OU +8 SE ÍMPAR");
            Console.WriteLine("============= // =============");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Digite um valor qualquer: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                num += 5;

               if (num % 2 == 0) {
                    Console.WriteLine("O número {0} é par!", num);
                }
                else
                {
                    Console.WriteLine("O número {0} é ímpar!", num);
                }
            }
            else
            {
                num += 8;

                if (num % 2 == 0)
                {
                    Console.WriteLine("O número {0} é par!", num);
                }
                else
                {
                    Console.WriteLine("O número {0} é ímpar!", num);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        }
    }
}
