using System;

namespace Senai.Variaveis.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float b, exp, result; //base e expoente;

            Console.Clear();
            Console.WriteLine("Calculadora de potenciação\n");

            Console.WriteLine("Insira a base:");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("\nInsira o expoente:");
            exp = float.Parse(Console.ReadLine());

            result = (float) (Math.Pow(b, exp));

            Console.WriteLine($"\n{b}^{exp} = {result}");
        }
    }
}
