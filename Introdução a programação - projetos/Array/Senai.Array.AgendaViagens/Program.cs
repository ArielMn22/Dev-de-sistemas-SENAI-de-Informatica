using System;
using Senai.Array.AgendaViagens.Classes;

namespace Senai.Array.AgendaViagens {
    class Program {
        static void Main (string[] args) {
            Viagem[] viagens = new Viagem[5];
            int i = 0, j = 0; //contadores

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
                            // viagens[i].Agendar();
                            System.Console.WriteLine ("Insira seu nome:");
                            viagens[i].NomePassageiro = Console.ReadLine ();

                            System.Console.WriteLine ("\nInsira o número do vôo:");
                            viagens[i].NumeroVoo = int.Parse (Console.ReadLine ());

                            System.Console.WriteLine ("\nInsira a data do vôo:");
                            viagens[i].DataVoo = DateTime.Parse (Console.ReadLine ());
                            break;
                        }

                    case "2":
                        {
                            while (j < 5) {
                                System.Console.WriteLine ($"Viagem {j}: {viagens[j].Exibir()}");
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
        }
    }
}