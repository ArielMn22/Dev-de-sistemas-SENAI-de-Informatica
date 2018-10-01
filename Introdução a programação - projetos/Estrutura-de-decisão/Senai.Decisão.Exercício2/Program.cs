using System;

namespace Senai.Decisão.Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.Clear();
            
            Console.WriteLine("Insira o primeiro número:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInsira o primeiro número:");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInsira o primeiro número:");
            n3 = int.Parse(Console.ReadLine());
        
            System.Console.WriteLine("\nSaída");
            if (n1>n2)
            {
                if(n1>n3)
                {
                    if(n2>n3)
                    {
                        System.Console.WriteLine($"maior: {n1}");
                        System.Console.WriteLine($"menor: {n2}");
                    } else {
                        System.Console.WriteLine($"maior: {n1}");
                        System.Console.WriteLine($"menor: {n3}");
                    }
                } else {
                    System.Console.WriteLine($"maior: {n3}");
                    System.Console.WriteLine($"menor: {n2}");
                }
            } else {
                if (n2>n3)
                {
                    if(n3>n1)
                    {
                        System.Console.WriteLine($"maior: {n2}");
                        System.Console.WriteLine($"menor: {n1}");
                    } else {
                        System.Console.WriteLine($"maior: {n2}");
                        System.Console.WriteLine($"menor: {n3}");
                    }
                } else {
                    System.Console.WriteLine($"maior: {n3}");
                    System.Console.WriteLine($"menor: {n1}");
                }
            }
        }
    }
}
