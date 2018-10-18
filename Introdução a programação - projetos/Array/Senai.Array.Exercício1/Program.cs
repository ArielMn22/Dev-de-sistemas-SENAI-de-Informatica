using System;
using Senai.Array.Exercicio1;

namespace Senai.Array.AgendaViagens {
    class Program {
        static void Main (string[] args) {
            Viagem[] viagens = new Viagem[5];
            int i = 0; // Contador, conta quantos cadastros foram realizados e direciona para o devido vetor;
            int j = 0; // Contador, conta as posições para a exibição das reservas;

            bool saida = false; // Verifica a saída do laço 'while';

            // Alocando
            while (i < 5) {
                viagens[i] = new Viagem (); // Alocando no Heap;
                viagens[i].Zerar (); // Zera as posições do objeto, como 'Não Reservado';
                i++;
            }

            i = 0; //Resetando contador;

            do {
                Console.Clear ();

                System.Console.WriteLine ("##################################################");
                System.Console.WriteLine ("              Agendador de viagens");
                System.Console.WriteLine ("##################################################");
                System.Console.WriteLine ("*OBS: Digite 'sair' para finalizar o programa.");
                System.Console.WriteLine ("1 - Agendar uma viagem\n2 - Exibir viagens\n");

                System.Console.Write ("Insira uma opção: ");
                string choice = Console.ReadLine ();

                System.Console.WriteLine (); //pula linha
                switch (choice) {
                    case "1":
                        {
                            if (i < 5) {
                                viagens[i].Agendar ();
                                i++;
                            } else {
                                System.Console.WriteLine ("Número limite de cadastro de viagens atingido!");
                            }

                            break;
                        }

                    case "2":
                        {
                            if (i == 0) {
                                System.Console.WriteLine("Não há viagens reservadas...");
                            } else {
                                while (j < i) {
                                    System.Console.WriteLine ("===============");
                                    System.Console.WriteLine ($"Viagem {j+1}: {viagens[j].Exibir()}");
                                    j++;
                                }
                            }
                            j = 0;
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
                System.Console.WriteLine ("\nAperte [QUALQUER] tecla para sair...");
                Console.ReadKey ();
            } while (saida != true);
        }
    }
}