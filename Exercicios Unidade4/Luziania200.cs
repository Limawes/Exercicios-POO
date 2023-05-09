using System;

class Program {
    static void Main(string[] args) {
        int i = 1, numFilhos;
        double salario, somaSalario = 0, mediaSalario, somaFilhos = 0, mediaFilhos, maiorSalario = 0, menorSalario = 999999999, countSalario = 0, countTotal = 0, percentual;

        Console.WriteLine("Digite o salário e o número de filhos de 200 pessoas:");

        do {
            Console.Write("Salário: ");
            salario = double.Parse(Console.ReadLine());
            Console.Write("Número de filhos: ");
            numFilhos = int.Parse(Console.ReadLine());

            somaSalario += salario;
            somaFilhos += numFilhos;
            countTotal++;

            if (salario > maiorSalario) {
                maiorSalario = salario;
            }

            if (salario < menorSalario) {
                menorSalario = salario;
            }

            if (salario <= 1500) {
                countSalario++;
            }

            i++;
        } while (i <= 200);

        mediaSalario = somaSalario / 200;
        mediaFilhos = somaFilhos / 200;
        percentual = (countSalario / countTotal) * 100;

        Console.WriteLine("Média do salário: " + mediaSalario.ToString("F2"));
        Console.WriteLine("Média do número de filhos: " + mediaFilhos.ToString("F2"));
        Console.WriteLine("Maior salário: " + maiorSalario);
        Console.WriteLine("Menor salário: " + menorSalario);
        Console.WriteLine("Porcentagem de pessoas com salários até R$1500,00: " + percentual.ToString("F2") + "%");
    }
}
