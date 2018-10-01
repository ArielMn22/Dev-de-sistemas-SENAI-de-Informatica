using System;

namespace Senai.Decisão.Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            //Recebendo genero            
            System.Console.WriteLine("Insira o gênero [M/F]:");
            char genero = char.Parse(Console.ReadLine());

            if (genero == 'M')
            {
                //Recebendo idade
                System.Console.WriteLine("Insira sua idade:");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 18)
                {
                    System.Console.WriteLine("Apto a retirada de reservista.");
                } else {
                    System.Console.WriteLine("Não apto. Você é menor de idade.");
                }
            } else {
                System.Console.WriteLine("Não apto. Gênero não compatível.");
            }
        }
    }
}
