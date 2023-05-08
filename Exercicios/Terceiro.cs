using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Terceiro
    {
        public void ParOuImpar()
        {
            int num;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("============= // =============");
            Console.WriteLine("PAR OU ÍMPAR");
            Console.WriteLine("============= // =============");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Informe um valor: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine(num + " é par");
            } else
            {
                Console.WriteLine(num + " é ímpar");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
