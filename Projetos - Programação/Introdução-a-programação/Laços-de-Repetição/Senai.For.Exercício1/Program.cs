using System;

namespace Senai.For.Exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            // Recebendo número;
            System.Console.WriteLine("Insira um número inteiro e par:");
            int num = int.Parse(Console.ReadLine());

            for (int i=0; i<100; i++)
            {
                num+=2;
                System.Console.WriteLine($"{i+1}º número: {num}");
            }
        }
    }
}
