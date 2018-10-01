using System;

namespace Senai.Variaveis.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2;

            Console.Clear();
            Console.WriteLine("Multiplique dois números:\n");

            Console.WriteLine("Insira o primeiro número:");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nInsira o segundo número:");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"\n{n1} * {n2} = {n1 * n2}");
        }
    }
}
