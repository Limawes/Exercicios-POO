using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Execucao
    {
        static void Main(string[] args)
        {
            int selecao;
            do
            {
                Console.WriteLine("===========ESCOLHA UM EXERCÍCIO============");
                Console.WriteLine("Escolha um exercício entre 1 e 12: ");
                Console.WriteLine("==========DIGITE  -1 PARA ENCERRAR=========");
                selecao = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                if (selecao == -1)
                {
                    Console.WriteLine("Encerrando ...");
                }

                switch (selecao)
                {
                    case 1:
                        Primeiro exerc1 = new Primeiro();
                        exerc1.Soma();

                        break;
                case 2:
                        Segundo exerc2 = new Segundo();
                        exerc2.Casada();
                        break;
                case 3:
                        Terceiro exerc3 = new Terceiro();
                        exerc3.ParOuImpar();
                        break;
                case 4:
                        Quarto exerc4 = new Quarto();
                        exerc4.SomaOuMutiplica();
                        break;
                case 5:
                        Quinto exerc5 = new Quinto();
                        exerc5.DobroOuTriplo();
                        break;
                case 6:
                        Sexto exerc6 = new Sexto();
                        exerc6.TrueOrFalse();
                        break;
                case 7:
                        Setimo exerc7 = new Setimo();
                        exerc7.SomaParOuImpar();
                        break;

                case 8:
                        Oitavo exerc8 = new Oitavo();
                        exerc8.Decrescente();
                        break;

                case 9:
                        Nono exerc9 = new Nono();
                        exerc9.PesoIdeal();
                        break;

                case 10:
                        Decimo exerc10 = new Decimo();
                        exerc10.IMC();
                        break;

                case 11:
                        DecimoPrimeiro exerc11 = new DecimoPrimeiro();
                        exerc11.Desconto();
                        break;
                        
                case 12: 
                        DecimoSegundo exerc12 = new DecimoSegundo();
                        exerc12.MediaAproveitamento(); 
                        break;

                    default:
                        break;
                }

            } while (selecao != -1);

           
        

        }
    }
}
