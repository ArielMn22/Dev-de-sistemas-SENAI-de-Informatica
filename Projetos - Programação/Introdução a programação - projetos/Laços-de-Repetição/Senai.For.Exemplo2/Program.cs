using System;

namespace Senai.For.Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recebendo número base;
            Console.WriteLine("Insira um número:");
            int x = int.Parse(Console.ReadLine());

            for (int contador = 200; contador >= 0; contador--)
            {
                System.Console.WriteLine($"{x} * {contador} = {x*contador}");
            }
        }
    }
}
