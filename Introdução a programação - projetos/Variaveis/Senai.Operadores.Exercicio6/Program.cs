using System;

namespace Senai.Operadores.Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome_p;
            float preco_p;

            Console.Clear();
            Console.WriteLine("Insira o nome e preço de um produto para ter 10% de desconto:\n");

            Console.WriteLine("Insira o nome do produto: ");
            nome_p = Console.ReadLine();

            Console.WriteLine("\nInsira o preço do produto: ");
            preco_p = float.Parse(Console.ReadLine());

            Console.WriteLine("\nResultado:");

            if (preco_p > 0)
            {
                Console.WriteLine($"O preço do produto com 10% de desconto é: R${preco_p * 0.9}.");
            } else {
                Console.WriteLine("Você deve inserir um preço maior que R$0, 00.");
            }
        }
    }
}
