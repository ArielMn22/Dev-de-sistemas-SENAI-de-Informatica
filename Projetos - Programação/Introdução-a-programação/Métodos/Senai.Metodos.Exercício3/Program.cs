using System;
using Senai.Metodos.Exercício3.Classes;

namespace Senai.Metodos.Exercício3 {
    class Program {
        static void Main (string[] args) {
            Garrafa bottle = new Garrafa ();
            bool saida = false; //Quando 'saida' for igual a true, saia do loop.

            do {
                Console.Clear();
                
                Console.WriteLine ("###########################################");
                Console.WriteLine ("             Garrafa Simulator");
                Console.WriteLine ("###########################################");
                System.Console.WriteLine ("1 - Encher a garrafa.\n2 - Esvaziar a garrafa.\n3 - Exibir a quantidade do conteúdo da garrafa.\n");
                
                System.Console.WriteLine("Insira uma opção:");
                string choice = Console.ReadLine ();
                
                System.Console.WriteLine(); //Pula linha
                switch (choice) {
                    case "1":
                        {
                            System.Console.WriteLine ("Insira a quantidade a encher:");
                            float quantidade = float.Parse (Console.ReadLine ());

                            bottle.Encher (quantidade);
                            break;
                        }

                    case "2":
                        {
                            System.Console.WriteLine ("Insira a quantidade a esvaziar:");
                            float quantidade = float.Parse (Console.ReadLine ());

                            bottle.Esvaziar (quantidade);
                            break;
                        }

                    case "3":
                        {
                            System.Console.WriteLine($"A garrafa tem: {bottle.ExibirQuantia ()}mL");
                            System.Console.WriteLine("Aperte [QUALQUER] tecla para sair...");
                            Console.ReadKey();
                            break;
                        }

                    case "sair":
                        {
                            saida = true;
                            break;
                        }

                    default:
                        {
                            System.Console.WriteLine ("Insira uma opção válida!");
                            break;
                        }
                }
            } while (saida != true);
        }
    }
}