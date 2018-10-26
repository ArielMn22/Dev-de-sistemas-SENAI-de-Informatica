using System;

namespace Senai.Decisão.Exercício16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n1, n2, result;

            Console.Clear();
            
            System.Console.WriteLine("Insira o primeiro valor:");
            n1 = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Insira o segundo valor:");
            n2 = int.Parse(Console.ReadLine());

            result = n1 + n2;

            if (result > 10)
            {
                n=5;
                System.Console.WriteLine($"Soma: {result} + {n} = {result + n}");
            } else {
                n=7;
                System.Console.WriteLine($"Soma: {result} - {n} = {result - n}");
            }
        }
    }
}
