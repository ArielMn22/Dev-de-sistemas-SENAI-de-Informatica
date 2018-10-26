using System;

namespace Senai.OO.Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            byte i;
            string palavra;

            Console.Clear();
            Console.WriteLine("Insira uma palavra:");
            palavra = Console.ReadLine();

            //processing
            int palavra_length = palavra.Length;

            Console.Clear();
            Console.WriteLine($"Palavra inteira: {palavra}");
            Console.WriteLine($"Primeira letra: {palavra[0]}");
            Console.WriteLine($"Última letra: {palavra[palavra_length-1]}");

            Console.Write("Primeira à terceira letra: ");
            for(i=0; i<3; i++)
            {
                Console.Write($"{palavra[i]}");
            }
            
            Console.WriteLine($"\nQuarta letra: {palavra[3]}");
            
            Console.Write("Todas menos a primeira letra: ");
            for(i=1; i<palavra_length; i++)
            {
                Console.Write($"{palavra[i]}");
            }

            Console.WriteLine($"\nAs duas últimas letras: {palavra[palavra_length-2]}{palavra[palavra_length-1]}");

        }
    }
}
