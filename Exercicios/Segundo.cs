using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Segundo
    {
        public void Casada()
        {
            string nome;
            string sexo;
            string estCivil;
            int tempoCasada;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("============= // =============");
            Console.WriteLine("VERIFICAR SE É CASADA!");
            Console.WriteLine("============= // =============");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu sexo: (M) ou (F)");
            sexo = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite seu estado civil: ");
            estCivil = Console.ReadLine().ToLower();

            if (sexo == "F" && estCivil == "casada")
            {
                Console.WriteLine("Quanto tempo de casada em anos? ");
                tempoCasada = int.Parse(Console.ReadLine());

                Console.WriteLine("Seu nome: " + nome);
                Console.WriteLine("Seu sexo: " + sexo);
                Console.WriteLine("É casada: " + estCivil);
                Console.WriteLine("Tempo de casada: " + tempoCasada + " anos");

            }
            else
            {
                Console.WriteLine("Seu nome: " + nome);
                Console.WriteLine("Seu sexo: " + sexo);
                Console.WriteLine("É casado(a): " + estCivil);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        }
    }
}
