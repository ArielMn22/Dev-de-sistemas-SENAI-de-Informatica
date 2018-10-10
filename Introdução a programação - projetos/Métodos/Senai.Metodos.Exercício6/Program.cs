using System;
using Senai.Metodos.Exercício6.Classes;

namespace Senai.Metodos.Exercício6 {
    class Program {
        static void Main (string[] args) {
            ContaBancaria conta = new ContaBancaria ();
            bool saida = false;

            Console.Clear();
            
            System.Console.WriteLine ("##########################################");
            System.Console.WriteLine ("                 Banco");
            System.Console.WriteLine ("##########################################");

            System.Console.WriteLine("Insira seu nome:");
            conta.Nome = Console.ReadLine();

            System.Console.WriteLine("\nInsira seu CPF:");
            conta.CPF = Console.ReadLine();
            
            while (saida != true) {
                Console.Clear ();

                System.Console.WriteLine ("##########################################");
                System.Console.WriteLine ("                 Banco");
                System.Console.WriteLine ("##########################################");
                System.Console.WriteLine($"Conta de: '{conta.Nome}'");
                System.Console.WriteLine($"CPF: '{conta.CPF}'");
                System.Console.WriteLine ("*OBS: Escreva 'sair' para finalizar o programa.");
                System.Console.WriteLine ("1 - Sacar\n2 - Depositar\n3 - Mostrar Saldo\n");

                System.Console.WriteLine ("Insira uma opção:");
                string choice = Console.ReadLine ();

                switch (choice) {
                    case "1":
                        {
                            System.Console.WriteLine ("Insira a quantidade que deseja sacar:");
                            double qnt = double.Parse (Console.ReadLine ());

                            conta.Sacar (qnt);
                            break;
                        }

                    case "2":
                        {
                            System.Console.WriteLine ("Insira a quantidade que deseja depositar:");
                            double qnt = float.Parse (Console.ReadLine ());

                            conta.Depositar (qnt);
                            break;
                        }

                    case "3":
                        {
                            System.Console.WriteLine ($"Você possui atualmente, {conta.Mostrar().ToString("C")} na sua conta.");
                            conta.Mostrar ();
                            break;
                        }

                    case "sair":
                        {
                            saida = true;
                            break;
                        }

                    default:
                        {
                            System.Console.WriteLine ("Insira uma opção válida.");
                            break;
                        }
                }
                System.Console.WriteLine ("\nAperte qualquer tecla para continuar...");
                Console.ReadKey ();
            }
        }
    }
}