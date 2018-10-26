using System;
using Senai.Metodos.Exercício2.Classes;

namespace Senai.Metodos.Exercício2 {
    class Program {
        static void Main (string[] args) {
            Calculadora calc = new Calculadora ();
            bool saida = false; //Verifica a saida do loop.

            Console.Clear();

            Console.WriteLine ("Calculadora Ariel 2000 Two Thousand Version 2.0\n");

            System.Console.WriteLine ("Insira o primeiro valor:");
            float n1 = float.Parse (Console.ReadLine ()); //n1 = numero 1

            System.Console.WriteLine ("Insira o segundo valor:");
            float n2 = float.Parse (Console.ReadLine ()); //n2 = numero 2

            do {
                Console.Clear ();
                System.Console.WriteLine ("###################################################");
                System.Console.WriteLine ("                    Operações");
                System.Console.WriteLine ("###################################################");
                System.Console.WriteLine($"Números informados: {n1} e {n2}\n**Digite 'sair' para finalizar o programa.");
                System.Console.WriteLine ("1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n");

                System.Console.Write ("Insira uma operação para realizar com os dois valores inseridos anteriormente: ");
                string choice = Console.ReadLine ();

                switch (choice) {
                    case "1":
                        {
                            System.Console.WriteLine (calc.Soma (n1, n2));
                            break;
                        }

                    case "2":
                        {
                            System.Console.WriteLine (calc.Subtrair (n1, n2));
                            break;
                        }

                    case "3":
                        {
                            System.Console.WriteLine (calc.Multiplicacao (n1, n2));
                            break;
                        }

                    case "4":
                        {
                            System.Console.WriteLine (calc.Divisao (n1, n2));
                            break;
                        }

                    case "sair":
                        {
                            System.Console.WriteLine ("");
                            saida = true;
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine ("Insira uma opção válida!");
                            break;
                        }

                }
                System.Console.WriteLine ("Aperte [QUALQUER] tecla para continuar...");
                Console.ReadKey ();

            } while (saida != true);
        }
    }
}