using System;
using Senai.Metodos.Exercício5.Classes;

namespace Senai.Metodos.Exercício5
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo trian = new Triangulo();

            Console.Clear();
            
            System.Console.WriteLine("Insira o valor do primeiro lado do triângulo:");
            trian.LadoA = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira o valor do segundo lado do triângulo:");
            trian.LadoB = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira o valor do terceiro lado do triângulo:");
            trian.LadoC = float.Parse(Console.ReadLine());

            if (trian.Valido())
            {
                System.Console.WriteLine(trian.Tipo());
            } else {
                System.Console.WriteLine("As medidas do triângulo informado não formam um triângulo.");
            }
        }
    }
}
