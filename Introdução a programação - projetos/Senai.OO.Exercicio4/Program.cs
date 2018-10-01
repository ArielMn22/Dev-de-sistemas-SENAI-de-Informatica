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

            Console.Clear();
            Console.WriteLine("Cartões de Crédito\n");
            
            #region card1
            Console.WriteLine("Insira o nome do primeiro cartão:");
            card1.nome = Console.ReadLine();

            Console.WriteLine("\nInsira o número do cartão:");
            card1.numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInsira a data limite de pagamento do cartão de crédito:");
            card1.data_limite = Convert.ToDateTime(Console.ReadLine());
            #endregion

            #region card2
            Console.WriteLine("\nInsira o nome do segundo cartão:");
            card1.nome = Console.ReadLine();

            Console.WriteLine("\nInsira o número do cartão:");
            card1.numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInsira a data limite de pagamento do cartão de crédito:");
            card1.data_limite = Convert.ToDateTime(Console.ReadLine());
            #endregion

            //Saida
            Console.Clear();
            Console.WriteLine($"Nome do cartão 1: {card1.nome}");
            Console.WriteLine($"Número: {card1.numero}");
            Console.WriteLine($"Data limite de pagamento: {card1.data_limite.ToShortDateString()}");

            Console.WriteLine($"\nNome do cartão 2: {card2.nome}");
            Console.WriteLine($"Número: {card2.numero}");
            Console.WriteLine($"Data limite de pagamento: {card2.data_limite.ToShortDateString()}");
        }
    }
}
