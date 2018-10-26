using System;

namespace Senai.Decisão.Exercícios8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.Clear();
            
            Console.WriteLine("Ordem Crescente\n");

            System.Console.WriteLine("Insira o primeiro número:");
            n1 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira o segundo número:");
            n2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira o terceiro número:");
            n3 = int.Parse(Console.ReadLine());

            System.Console.WriteLine(); //pula linha

            if (n1 < n2 && n1 < n3)
            {
                if (n2 < n3)
                {
                    System.Console.WriteLine($"{n1}, {n2}, {n3}");
                } else {
                    System.Console.WriteLine($"{n1}, {n3}, {n2}");
                }
            } else {
                if (n2<n1 && n2<n3)
                {
                    if (n1 < n3)
                    {
                        System.Console.WriteLine($"{n2}, {n1}, {n3}");
                    } else {
                        System.Console.WriteLine($"{n2}, {n3}, {n1}");
                    }
                } else {
                        if (n1 < n2)
                        {
                            System.Console.WriteLine($"{n3}, {n1}, {n2}");
                        } else {
                            System.Console.WriteLine($"{n3}, {n2}, {n1}");
                        }
                }
            }
        }
    }
}
