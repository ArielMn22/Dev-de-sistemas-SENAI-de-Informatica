using System;

namespace Senai.Decisão.Exercícios11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; //numero

            Console.Clear();

            System.Console.WriteLine("Insira um número:");
            n = int.Parse(Console.ReadLine());

            if (n%2 == 0)
            {
                System.Console.WriteLine($"\n{n} é par.");
            } else {
                System.Console.WriteLine($"\n{n} é ímpar.");
            }
        }
    }
}
