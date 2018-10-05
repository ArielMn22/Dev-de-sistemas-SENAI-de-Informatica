using System;

namespace Senai.DoWhile.Exemplo {
    class Program {
        static void Main (string[] args) {
            string senha;
            
            do {
                Console.Clear(); //Limpa a tela, melhorando a usabilidade
                
                // Requisita a senha do usuário
                Console.WriteLine ("Informe sua senha:");
                senha = Console.ReadLine ();
            } while (senha != "123");

            System.Console.WriteLine("Bem-vindo!");
        }
    }
}