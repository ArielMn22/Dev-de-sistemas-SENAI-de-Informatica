using System;
using Senai.OO.Exercicio4.Classes;

namespace Senai.OO.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoDeCredito card1 = new CartaoDeCredito();
            CartaoDeCredito card2 = new CartaoDeCredito();

            Console.WriteLine("Cartões de Crédito\n");
            
            #region card1
            Console.WriteLine("Insira o nome do primeiro cartão:");
            card1.nome = Console.ReadLine();

            Console.WriteLine("Insira o número do cartão:");
            card1.numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a data limite de pagamento do cartão de crédito:");
            card1.data_limite = Convert.ToDateTime(Console.ReadLine());
            #endregion

            #region card2
            Console.WriteLine("Insira o nome do primeiro cartão:");
            card1.nome = Console.ReadLine();

            Console.WriteLine("Insira o número do cartão:");
            card1.numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a data limite de pagamento do cartão de crédito:");
            card1.data_limite = Convert.ToDateTime(Console.ReadLine());
            #endregion

            //CONTINUAR
        }
    }
}
