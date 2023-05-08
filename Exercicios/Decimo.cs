using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Decimo
    {
        public void IMC()
        {
            decimal peso;
            decimal altura;
            decimal IMC;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("============= // =============");
            Console.WriteLine("CALCULADORA DE IMC");
            Console.WriteLine("============= // =============");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Digite seu peso: (Kg)");
            peso = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura em metros: ");
            altura = decimal.Parse(Console.ReadLine());

            IMC = peso / (altura * altura);

            if (IMC < decimal.Parse("18,5"))
            {
                Console.WriteLine("Você está abaixo do peso!");
            }
            else if (IMC >= decimal.Parse("18,5") && IMC < 25)
            {
                Console.WriteLine("Você está no peso normal!");
            }
            else if (IMC >= 25 && IMC < 30)
            {
                Console.WriteLine("Você está acima do peso!");
            }
            else if (IMC > 30)
            {
                Console.WriteLine("Você está Obeso!");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
