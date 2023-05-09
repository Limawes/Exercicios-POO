using System;

class Program {
    static int[] vetor = new int[10];

    static void Main() {
        int opcao = 0;

        do {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Carregar Vetor");
            Console.WriteLine("2 - Listar Vetor");
            Console.WriteLine("3 - Exibir apenas números pares");
            Console.WriteLine("4 - Exibir apenas números ímpares");
            Console.WriteLine("5 - Quantidade de números pares nas posições ímpares");
            Console.WriteLine("6 - Quantidade de números ímpares nas posições pares");
            Console.WriteLine("7 - Sair");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao) {
                case 1:
                    CarregarVetor();
                    break;
                case 2:
                    ListarVetor();
                    break;
                case 3:
                    ExibirNumerosPares();
                    break;
                case 4:
                    ExibirNumerosImpares();
                    break;
                case 5:
                    QuantidadeParesPosicoesImpares();
                    break;
                case 6:
                    QuantidadeImparesPosicoesPares();
                    break;
                case 7:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

        } while (opcao != 7);
    }

    static void CarregarVetor() {
        Console.WriteLine("Digite 10 números inteiros:");

        for (int i = 0; i < 10; i++) {
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    static void ListarVetor() {
        Console.WriteLine("Valores do vetor:");

        for (int i = 0; i < 10; i++) {
            Console.WriteLine(vetor[i]);
        }
    }

    static void ExibirNumerosPares() {
        Console.WriteLine("Números pares do vetor:");

        for (int i = 0; i < 10; i++) {
            if (vetor[i] % 2 == 0) {
                Console.WriteLine(vetor[i]);
            }
        }
    }

    static void ExibirNumerosImpares() {
        Console.WriteLine("Números ímpares do vetor:");

        for (int i = 0; i < 10; i++) {
            if (vetor[i] % 2 != 0) {
                Console.WriteLine(vetor[i]);
            }
        }
    }

    static void QuantidadeParesPosicoesImpares() {
        int contador = 0;

        for (int i = 1; i < 10; i += 2) {
            if (vetor[i] % 2 == 0) {
                contador++;
            }
        }

        Console.WriteLine($"Quantidade de números pares nas posições ímpares: {contador}");
    }

    static void QuantidadeImparesPosicoesPares() {
        int contador = 0;

        for (int i = 0; i < 10; i += 2) {
            if (vetor[i] % 2 != 0) {
                contador++;
            }
        }

        Console.WriteLine($"Quantidade de números ímpares nas posições pares: {contador}");
    }
}
