using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Oitavo
    {
        public void Decrescente()
        {
            int n1;
            int n2;
            int n3;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("============= // =============");
            Console.WriteLine("NÚMEROS NA ORDEM DESCRESCENTE");
            Console.WriteLine("============= // =============");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            n3 = int.Parse(Console.ReadLine());

            int a;
            int b;
            int c;

            if (n1 > n2 && n2 > n3)
            {
                a = n1;
                b = n2;
                c = n3;
                Console.WriteLine("Os valores em ordem Decrecente são: {0} {1} {2}", a, b, c);
            }
            else if (n2 > n1 && n1 > n3)
            {
                a = n2;
                b = n1;
                c = n3;
                Console.WriteLine("Os valores em ordem Decrecente são: {0} {1} {2}", a, b, c);
            }
            else if (n3 > n1 && n1 > n2)
            {
                a = n3;
                b = n1;
                c = n2;
                Console.WriteLine("Os valores em ordem Decrecente são: {0} {1} {2}", a, b, c);
            }
            else if (n3 > n2 && n2 > n1)
            {
                a = n3;
                b = n2;
                c = n1;
                Console.WriteLine("Os valores em ordem Decrescente são: {0} {1} {2}", a, b, c);

            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        }
    }
}
