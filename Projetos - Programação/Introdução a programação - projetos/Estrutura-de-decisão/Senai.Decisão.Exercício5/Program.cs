using System;

namespace Senai.Decisão.Exercício5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime anoAtual = DateTime.Now;
            int anoNascimento;

            Console.Clear();
            
            System.Console.WriteLine("Insira seu ano de nascimento:");
            anoNascimento = int.Parse(Console.ReadLine());

            System.Console.WriteLine();

            if (anoAtual.Year - anoNascimento >= 16)
            {
                System.Console.WriteLine("Você pode votar este ano!");
            } else {
                System.Console.WriteLine("Você não pode votar este ano!");
            }
        }
    }
}
