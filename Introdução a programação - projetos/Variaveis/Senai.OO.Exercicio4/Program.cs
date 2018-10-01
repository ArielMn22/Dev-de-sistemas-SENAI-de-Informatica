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

            //Limpa a tela e mostra o enunciado do programa;
            Console.Clear();
            Console.WriteLine("Cartões de Crédito\n");
            
            #region card1
            //Lendo nome do cartão
            Console.WriteLine("Insira o nome do primeiro cartão:");
            card1.nome = Console.ReadLine();

            //Lendo número do cartão
            Console.WriteLine("\nInsira o número do cartão:");
            card1.numero = Convert.ToInt32(Console.ReadLine());

            //Lendo a data limite do cartão
            Console.WriteLine("\nInsira a data limite de pagamento do cartão de crédito:");
            card1.data_limite = Convert.ToDateTime(Console.ReadLine());
            #endregion //Fim da region card1

            #region card2
            //Lendo nome do cartão
            Console.WriteLine("\nInsira o nome do segundo cartão:");
            card1.nome = Console.ReadLine();

            //Lendo o número do cartão
            Console.WriteLine("\nInsira o número do cartão:");
            card1.numero = Convert.ToInt32(Console.ReadLine());

            //Lendo a data de validade do cartão
            Console.WriteLine("\nInsira a data limite de pagamento do cartão de crédito:");
            card1.data_limite = Convert.ToDateTime(Console.ReadLine());
            #endregion //Final da region card2

            //Saida
            Console.Clear();
            //Mostrando dados do cartão 1
            Console.WriteLine("================================================");
            Console.WriteLine("                   Cálculo");
            Console.WriteLine("================================================");
            Console.WriteLine($"Nome do cartão 1: {card1.nome}");
            Console.WriteLine($"Número: {card1.numero}");
            Console.WriteLine($"Data limite de pagamento: {card1.data_limite.ToShortDateString()}");

            //Mostrando dados do cartão 2
            Console.WriteLine("\n================================================");
            Console.WriteLine("                   Cálculo");
            Console.WriteLine("================================================");
            Console.WriteLine($"Nome do cartão 2: {card2.nome}");
            Console.WriteLine($"Número: {card2.numero}");
            Console.WriteLine($"Data limite de pagamento: {card2.data_limite.ToShortDateString()}");
        }
    }
}