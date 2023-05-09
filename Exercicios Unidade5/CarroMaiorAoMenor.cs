using System;
using System.Collections.Generic;

class Carro {
    public string Marca { get; set; }
    public double Valor { get; set; }
    public string Cor { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
}

class Program {
    static void Main(string[] args) {
        List<Carro> carros = new List<Carro>();

        Console.WriteLine("Digite as informações dos carros (ou digite 'sair' para finalizar):");

        while (true) {
            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            if (marca.ToLower() == "sair") {
                break;
            }

            Console.Write("Valor: ");
            double valor = double.Parse(Console.ReadLine());

            Console.Write("Cor: ");
            string cor = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            carros.Add(new Carro { Marca = marca, Valor = valor, Cor = cor, Modelo = modelo, Ano = ano });
        }

        carros.Sort((x, y) => y.Valor.CompareTo(x.Valor));

        Console.WriteLine("Carros ordenados pelo valor do maior para o menor:");
        foreach (Carro carro in carros) {
            Console.WriteLine("{0} {1} {2} {3} {4}", carro.Marca, carro.Valor, carro.Cor, carro.Modelo, carro.Ano);
        }
    }
}
