using System;

class Program {
    static void Main(string[] args) {
        int i = 1;
        char codigo;
        double valor, totalVista = 0, totalPrazo = 0, totalCompras = 0;

        Console.WriteLine("Digite o código (V ou P) e o valor de 15 transações:");

        do {
            Console.Write("Código: ");
            codigo = char.Parse(Console.ReadLine());
            Console.Write("Valor: ");
            valor = double.Parse(Console.ReadLine());

            if (codigo == 'V') {
                totalVista += valor;
            }
            else if (codigo == 'P') {
                totalPrazo += valor;
            }

            totalCompras += valor;

            i++;
        } while (i <= 15);

        Console.WriteLine("Valor total das compras à vista: " + totalVista);
        Console.WriteLine("Valor total das compras a prazo: " + totalPrazo);
        Console.WriteLine("Valor total das compras efetuadas: " + totalCompras);
    }
}
