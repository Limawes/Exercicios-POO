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
    static List<Carro> carros = new List<Carro>();

    static void Main(string[] args) {
        while (true) {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Cadastrar um carro");
            Console.WriteLine("2 - Excluir um carro");
            Console.WriteLine("3 - Listar carros ordenados pelo valor do menor para o maior");
            Console.WriteLine("4 - Sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao) {
                case 1:
                    CadastrarCarro();
                    break;

                case 2:
                    ExcluirCarro();
                    break;

                case 3:
                    ListarCarros();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CadastrarCarro() {
        Console.Write("Marca: ");
        string marca = Console.ReadLine();

        Console.Write("Valor: ");
        double valor = double.Parse(Console.ReadLine());

        Console.Write("Cor: ");
        string cor = Console.ReadLine();

        Console.Write("Modelo: ");
        string modelo = Console.ReadLine();

        Console.Write("Ano: ");
        int ano = int.Parse(Console.ReadLine());

        carros.Add(new Carro { Marca = marca, Valor = valor, Cor = cor, Modelo = modelo, Ano = ano });

        Console.WriteLine("Carro cadastrado com sucesso!");
    }

    static void ExcluirCarro() {
        Console.Write("Digite o índice do carro a ser excluído: ");
        int indice = int.Parse(Console.ReadLine());

        if (indice < 0 || indice >= carros.Count) {
            Console.WriteLine("Índice inválido. Tente novamente.");
        } else {
            carros.RemoveAt(indice);
            Console.WriteLine("Carro excluído com sucesso!");
        }
    }

    static void ListarCarros() {
        if (carros.Count == 0) {
            Console.WriteLine("Não há carros cadastrados.");
        } else {
            carros.Sort((x, y) => x.Valor.CompareTo(y.Valor));

            Console.WriteLine("Carros ordenados pelo valor do menor para o maior:");
            for (int i = 0; i < carros.Count; i++) {
                Console.WriteLine("{0}: {1} {2} {3} {4} {5}", i, carros[i].Marca, carros[i].Valor, carros[i].Cor, carros[i].Modelo, carros[i].Ano);
            }
        }
    }
}
