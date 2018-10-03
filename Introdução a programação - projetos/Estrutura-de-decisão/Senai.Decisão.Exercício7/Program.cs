using System;

namespace Senai.Decisão.Exercícios7
{
    class Program
    {
        static void Main(string[] args)
        {
            int qnt; //Quantidade de macas;
            float preco;

            Console.Clear();
            
            System.Console.WriteLine("Insira a quantidade de maçãs a comprar:");
            qnt = int.Parse(Console.ReadLine());

            if (qnt >= 12)
            {
                preco = (float) (qnt * 0.25);
            } else {
                preco = (float) (qnt * 0.3);
            }

            System.Console.WriteLine($"\nO preço a ser pago pelas maçãs é: {preco.ToString("C")}");
        }
    }
}
