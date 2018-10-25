using System;

namespace Senai.For.Exercício7.Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=0, c=1;

            Console.Clear();
            
            Console.WriteLine("Sequência de Fibonacci");

            System.Console.WriteLine("\nQuantos números da sequência deseja ver?");
            int quantidade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Sequência");
            for (int i = 0; i < quantidade; i++)
            {
                System.Console.WriteLine(a);
                a = b+c;
                c = b;
                b = a;
            }
        }
    }
}
