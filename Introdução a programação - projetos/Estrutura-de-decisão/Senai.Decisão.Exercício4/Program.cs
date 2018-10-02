using System;

namespace Senai.Decisão.Exercício4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.Clear();
            
            //Lendo primeiro número
            System.Console.WriteLine("Insira o primeiro número:");
            n1 = int.Parse(Console.ReadLine());

            //Lendo segundo número
            System.Console.WriteLine("\nInsira o segundo número:");
            n2 = int.Parse(Console.ReadLine());

            System.Console.Write("\nO maior número é: ");
            if (n1 > n2)
            {
                System.Console.WriteLine($"{n1}");
            } else {
                System.Console.WriteLine($"{n2}");
            }
            
        }
    }
}
