using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class DecimoPrimeiro
    {
        public void Desconto()
        {
            decimal precoProduto;
            decimal precoDesconto;
            decimal precoJuros;
            decimal parcela;
            int codPagamento;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("============= // =============");
            Console.WriteLine("CALCULAR JUROS OU DESCONTO!");
            Console.WriteLine("============= // =============");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Informe o preço do produto desejado");
            precoProduto = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe o código da modalidade de pagamento: ");
            Console.WriteLine(" 1 - À vista em dinheiro ou cheque com 10% de desconto.");
            Console.WriteLine(" 2 - À vista no cartão de crédito com 15% de desconto.");
            Console.WriteLine(" 3 - Em duas vezes, preço normal sem juros.");
            Console.WriteLine(" 4 - Em três vezes, preço normal com juros de 10%.");
            codPagamento = int.Parse(Console.ReadLine());

            while (codPagamento != 1 && codPagamento != 2 && codPagamento != 3 && codPagamento != 4)
            {
                Console.WriteLine("Valor inválido, informe somente as opções disponíveis!");
                codPagamento = int.Parse(Console.ReadLine());
            }

            if (codPagamento == 1)
            {
                precoDesconto = precoProduto - ((precoProduto * 10) / 100);
                Console.WriteLine("Pagamento em dinheiro ou cheque com 10% de desconto: Total " +
                    precoDesconto.ToString("C"));
            }
            else if (codPagamento == 2)
            {
                precoDesconto = precoProduto - ((precoProduto * 15) / 100);
                Console.WriteLine("Pagamento à vista no crédito com 15% de desconto: Total " + 
                    precoDesconto.ToString("C"));
            }
            else if (codPagamento == 3)
            {
                parcela = precoProduto / 2;
                Console.WriteLine("Pagamento em duas vezes, preço normal sem juros: Total " + 
                    precoProduto.ToString("C"));
                Console.WriteLine("Com cada parecela no valor de: " + parcela.ToString("C"));
            }
            else
            {
                precoJuros = precoProduto + ((precoProduto * 10) / 100);
                parcela = precoJuros / 3;
                Console.WriteLine("Pagamento em tres vezes com acréscimo de 10 %: Total " +
                    precoJuros.ToString("C"));
                Console.WriteLine($"Com cada parcela no valor de: " + parcela.ToString("C"));
                
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        }
    }
}
