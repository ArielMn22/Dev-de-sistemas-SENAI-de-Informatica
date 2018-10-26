using System;
using Senai.Metodos.Exercício4.Classes;

namespace Senai.Metodos.Exercício4 {
    class Program {
        static void Main (string[] args) {
            Porta door = new Porta ();
            bool saida = false;

            Console.Clear();
            
            System.Console.WriteLine ("===============================================================");
            System.Console.WriteLine ("                      Simulador de porta");
            System.Console.WriteLine ("===============================================================");
            System.Console.WriteLine ("1 - Abrir\n2 - Fechar\n*OBS: Insira 'sair' para sair do programa.\n");

            while (saida != true) {

                System.Console.WriteLine ("Insira uma opção:");
                string choice = Console.ReadLine ();

                switch (choice) {
                    case "1":
                        {
                            door.Abrir ();
                            break;
                        }

                    case "2":
                        {
                            door.Fechar ();
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
                System.Console.WriteLine(); //pula linha
            }
        }
    }
}