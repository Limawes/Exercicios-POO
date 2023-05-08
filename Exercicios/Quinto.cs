using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Quinto
    {
        public void DobroOuTriplo()
        {
            int n1;
            int dobro;
            int triplo;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("============= // =============");
            Console.WriteLine("VERIFICAR O DOBRO OU TRIPLO");
            Console.WriteLine("============= // =============");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Informe um valor: ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 > 0)
            {
                dobro = n1 * 2;
                Console.WriteLine("Número positivo, e o dobro é: " + dobro);
            }
            else
            {
                triplo = n1 * 3;
                Console.WriteLine("Número negativo, e o triplo é: " + triplo);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
