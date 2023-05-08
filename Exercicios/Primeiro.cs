using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Primeiro
    {
        public void Soma()
        {
            int a;
            int b;
            int c;
            int soma;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("============= // =============");
            Console.WriteLine("SOMAR DOIS VALORES E VERIFICAR SE É MAIOR OU MENOR QUE O TERCEIRO");
            Console.WriteLine("============= // =============");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Informe o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de C: ");
            c = int.Parse(Console.ReadLine());

            soma = a + b;

            if (soma < c)
            {
                Console.WriteLine("A soma de " + a + " + " + b + " é menor que " + c);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
