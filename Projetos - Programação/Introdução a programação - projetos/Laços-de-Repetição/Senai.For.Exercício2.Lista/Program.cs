using System;

namespace Senai.For.Exercício2.Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Clear();
            
            System.Console.WriteLine("Exiba os números de 200 até 0:");
            System.Console.WriteLine();
            System.Console.WriteLine("Aperte [ENTER] para começar...");
            Console.ReadKey();

            for (number = 200; number >= 0; number --)
            {
                System.Console.WriteLine(number);
            }
        }
    }
}
