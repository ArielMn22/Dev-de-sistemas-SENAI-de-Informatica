using System;

namespace Senai.DoWhile.Exercício1 {
    class Program {
        static void Main (string[] args) {
            string nome, telefone;
            int idade;
            string question;

            do {
                Console.Clear(); //Limpa a tela;
                
                System.Console.WriteLine ("Insira seu nome:");
                nome = Console.ReadLine ();

                System.Console.WriteLine ("\nInsira sua idade:");
                idade = int.Parse (Console.ReadLine ());

                System.Console.WriteLine ("\nInsira seu telefone:");
                telefone = Console.ReadLine ();

                // Saída
                System.Console.WriteLine("\nExibindo\n");
                System.Console.WriteLine ($"Nome: {nome}");
                System.Console.WriteLine ($"Telefone: {telefone}");
                System.Console.WriteLine ($"Idade: {idade}");

                System.Console.WriteLine ("\nDeseja realzar mais um cadastro? [SIM/NÃO]");
                question = Console.ReadLine ();

            } while (question.ToUpper() == "SIM");
        }
    }
}