using System;
using Senai.Metodos.Exercício7.Classes;

namespace Senai.Metodos.Exercício7 {
    class Program {
        static void Main (string[] args) {
            Conta conta1 = new Conta ();
            bool saida = false;

            do {
                Console.Clear ();

                System.Console.WriteLine ("========================================");
                System.Console.WriteLine ("                Login");
                System.Console.WriteLine ("========================================");
                System.Console.WriteLine ("\nInsira seu nome:");
                conta1.Nome = Console.ReadLine ();

                System.Console.WriteLine ("\nInsira seu e-mail:");
                conta1.Email = Console.ReadLine ();

                if (conta1.Email.Contains ("@")) {
                    System.Console.WriteLine ("\nInsira sua senha:");
                    conta1.Senha = Console.ReadLine ();

                    System.Console.WriteLine (); //pula linha
                    if (conta1.Login ()) {
                        System.Console.WriteLine ($"Bem-vindo de volta Sr. {conta1.Nome}!");

                        saida = true;
                    } else {
                        System.Console.WriteLine ("E-mail ou senha incorretos!");
                    }
                } else {
                    System.Console.WriteLine ("O e-mail informado deve conter um '@'...");
                }
                System.Console.WriteLine ("Aperte [QUALQUER] tecla para continuar...");
                Console.ReadKey ();
            } while (saida != true);
        }
    }
}