using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Sexto
    {
        public void TrueOrFalse()
        {
            bool valor1, valor2;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("============= // =============");
            Console.WriteLine("VERDADEIRO OU FALSO");
            Console.WriteLine("============= // =============");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Digite o primeiro valor booleano (true ou false): ");
            valor1 = bool.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor booleano (true ou false): ");
            valor2 = bool.Parse(Console.ReadLine());

            if (valor1 && valor2)
            {
                Console.WriteLine("Ambos são verdadeiros");
            }
            else if (!valor1 && !valor2)
            {
                Console.WriteLine("Ambos são falsos");
            }
            else
            {
                Console.WriteLine("Um dos valores é falso");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
