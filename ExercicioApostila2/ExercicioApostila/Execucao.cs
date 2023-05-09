using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioApostila
{
    internal class Execucao
    {
        public static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            carro1.Marca = "Chevrolet";
            carro1.Modelo = "Camaro";
            carro1.Ano = 2022;
            carro1.Cor = "Amerelo";
            carro1.VelocidadeMaxima = 290;
            carro1.Potencia = 455;

            Console.WriteLine("Carro 1:");
            Console.WriteLine("Marca: " + carro1.Marca);
            Console.WriteLine("Modelo: " + carro1.Modelo);
            Console.WriteLine("Ano: " + carro1.Ano);
            Console.WriteLine("Cor: " + carro1.Cor);
            Console.WriteLine("Velocidade Máxima: " + carro1.VelocidadeMaxima);
            Console.WriteLine("Potência: " + carro1.Potencia);

            string run = carro1.Acelerar();
            Console.WriteLine(run);
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            run = carro1.Freiar();
            Console.WriteLine(run);
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine();
        }
    }
}
