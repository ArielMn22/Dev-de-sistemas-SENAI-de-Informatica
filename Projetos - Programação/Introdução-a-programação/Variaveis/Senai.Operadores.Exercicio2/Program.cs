using System;

namespace Senai.Operadores.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b; // a = altura, b = base, A = Area do retângulo;

            Console.Clear();
            
            Console.WriteLine("Calcule a área de um retângulo.\n");

            Console.WriteLine("Insira a base do triângulo (em cm): ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("\nInsira a altura do triângulo (em cm): ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine($"\nA área do retângulo é: { a * b }cm.");
        }
    }
}
