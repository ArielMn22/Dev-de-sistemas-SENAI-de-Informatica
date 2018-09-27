using System;

namespace Senai.Operadores.Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            float dolar, real;

            Console.Clear();
            Console.WriteLine("Conversor de dólar para real:\n");

            Console.WriteLine("Insira a quantidade de reais a serem convertidos:");
            real = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor do dólar em reais:");
            dolar = float.Parse(Console.ReadLine());

            Console.WriteLine($"R${real} = US${real * dolar}");
        }
    }
}
