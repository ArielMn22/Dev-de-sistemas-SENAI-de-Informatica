using System;

namespace Senai.Decisão.Exercício6
{
    class Program
    {
        static void Main(string[] args)
        {
            string userPassword, password = "1234";

            Console.Clear();
            
            System.Console.WriteLine("Insira sua senha:");
            userPassword = Console.ReadLine();
            
            System.Console.WriteLine(); //Pula linha

            if (userPassword == password)
            {
                System.Console.WriteLine("ACESSO GARANTIDO!");
            } else {
                System.Console.WriteLine("ACESSO NEGADO!");
            }
        }
    }
}
