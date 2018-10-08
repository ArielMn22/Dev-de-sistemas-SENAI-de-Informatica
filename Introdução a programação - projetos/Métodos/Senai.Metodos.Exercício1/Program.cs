using System;
using Senai.Metodos.Exercício1.Classes;

namespace Senai.Metodos.Exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret1 = new Retangulo();

            Console.WriteLine("Insira o valor do lado A:");
            ret1.LadoA = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor do lado B:");
            ret1.LadoB = float.Parse(Console.ReadLine());

            System.Console.WriteLine($"\nÁrea do retângulo: {ret1.Area()}cm²\nPerímetro: {ret1.Perimetro()}cm");;
        }
    }
}
