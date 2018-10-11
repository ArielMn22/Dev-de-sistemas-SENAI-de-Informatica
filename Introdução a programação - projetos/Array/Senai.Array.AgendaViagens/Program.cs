using System;
using Senai.Array.AgendaViagens.Classes;

namespace Senai.Array.AgendaViagens {
    class Program {
        static void Main (string[] args) {
            Viagem[] viagens = new Viagem[5];
            int i = 0, j = 0; //contadores

            //Alocando
            while (i < 5) {
                viagens[i] = new Viagem (); // Alocando no Heap;
                i++;
            }

            i = 0; //Resetando contador;

            do {
                Console.Clear ();

                System.Console.WriteLine ("##################################################");
                System.Console.WriteLine ("              Agendador de viagens");
                System.Console.WriteLine ("##################################################");

                System.Console.WriteLine ("1 - Agendar uma viagem\n2 - Exibir viagens\n");

                System.Console.Write ("Insira uma opção: ");
                string choice = Console.ReadLine ();

                switch (choice) {
                    case "1":
                        {
                            viagens[i].Agendar ();
                            break;
                        }

                    case "2":
                        {
                            while (j < 5) {
                                System.Console.WriteLine ($"Viagem {j+1}: {viagens[j].Exibir()}");
                                j++;
                            }
                            j = 0;
                            break;
                        }

                    default:
                        {
                            System.Console.WriteLine ("Insira uma opção válida!");
                            break;
                        }
                }
                System.Console.WriteLine ("\nAperte [QUALQUER] tecla para sair...");
                Console.ReadKey ();
                i++;
            } while (i < 5);

            System.Console.WriteLine("Número limite de cadastro de viagens atingido!");
            console.ReadKey();
        }
    }
}