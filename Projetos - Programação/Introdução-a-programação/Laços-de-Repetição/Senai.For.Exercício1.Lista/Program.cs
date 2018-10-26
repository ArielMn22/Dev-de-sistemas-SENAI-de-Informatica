using System;

namespace Senai.For.Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            // Recebendo número
            System.Console.WriteLine("Insira o número:");
            int x = int.Parse(Console.ReadLine());

            // Recebendo o limite
            System.Console.WriteLine("Insira o limite:");
            int limite = int.Parse(Console.ReadLine());

            // int contador = 1;
            // while (contador <= limite)
            // {
            //     contador++;
            // }

            System.Console.WriteLine(); //Pula linha
            for (int contador = 0; contador <= limite; contador++)
            {
                System.Console.WriteLine($"{x} * {contador} = {x*contador}");
            }
        }
    }
}
