using System;

namespace Senai.Decisão.Exercícios9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;

            System.Console.WriteLine("Insira o primeiro número:");
            n1 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("\nInsira o segundo número:");
            n2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("\nInsira o terceiro número:");
            n3 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("\nInsira o quarto número:");
            n4 = int.Parse(Console.ReadLine());
            
            if ((n1 % 2 == 0) || (n1 % 3 == 0))
            {
                System.Console.WriteLine($"\n- {n1} é divisível por 2 ou 3;");
            }

            if ((n2 % 2 == 0) || (n2 % 3 == 0))
            {
                System.Console.WriteLine($"- {n2} é divisível por 2 ou 3;");
            }

            if ((n3 % 2 == 0) || (n3 % 3 == 0))
            {
                System.Console.WriteLine($"- {n3} é divisível por 2 ou 3;");
            }

            if ((n4 % 2 == 0) || (n4 % 3 == 0))
            {
                System.Console.WriteLine($"- {n4} é divisível por 2 ou 3;");
            }
        }
    }
}
