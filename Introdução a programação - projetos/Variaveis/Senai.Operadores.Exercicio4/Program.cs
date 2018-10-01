using System;

namespace Senai.Operadores.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float C, F;

            Console.Clear();
            Console.WriteLine("Conversor de temperatura, insira a temperatura em Celsius para converter em Farehnheit.\n");

            Console.WriteLine("Insira a temperatura (em Celsius): ");
            C = float.Parse(Console.ReadLine());

            F = (9 * C + 160) / 5; // Converte a tempera em Celsius 'C', para Farehnheit 'F';

            Console.WriteLine($"{C} C° = {F} F°");
        }
    }
}
