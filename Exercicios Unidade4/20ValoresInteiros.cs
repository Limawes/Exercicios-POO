using System;

class Program {
    static void Main(string[] args) {
        int i = 1;
        int n, soma = 0, maior, menor;

        Console.WriteLine("Digite 20 valores inteiros:");

        // Lê o primeiro valor como o maior e o menor
        n = int.Parse(Console.ReadLine());
        maior = n;
        menor = n;
        soma += n;

        // Loop para ler os 19 valores restantes
        do {
            n = int.Parse(Console.ReadLine());
            soma += n;

            // Verifica se o valor lido é maior ou menor que os valores anteriores
            if (n > maior) {
                maior = n;
            }
            else if (n < menor) {
                menor = n;
            }

            i++;
        } while (i <= 20);

        // Calcula a média dos valores lidos
        double media = (double) soma / 20;

        // Mostra os resultados
        Console.WriteLine("Maior valor: " + maior);
        Console.WriteLine("Menor valor: " + menor);
        Console.WriteLine("Média dos valores: " + media);
    }
}
