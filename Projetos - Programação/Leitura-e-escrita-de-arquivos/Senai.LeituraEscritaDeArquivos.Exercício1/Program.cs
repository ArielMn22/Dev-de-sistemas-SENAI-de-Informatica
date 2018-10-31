using System;
using System.IO;

namespace Senai.LeituraEscritaDeArquivos.Exercício1 {
    class Program {
        static void Main (string[] args) {
            int opcao;

            do {
                System.Console.WriteLine ("========================================");
                System.Console.WriteLine ("               MENU");
                System.Console.WriteLine ("========================================");
                System.Console.WriteLine ("1 - Ler");
                System.Console.WriteLine ("2 - Escrever");

                System.Console.WriteLine ("Insira uma opção: ");
                opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                        {
                            System.Console.WriteLine ("Insira o nome do arquivo que deseja ler:");
                            string arquivoLer = Console.ReadLine ();

                            if (File.Exists (arquivoLer)) {
                                string linha;
                                using (StreamReader ler = new StreamReader (arquivoLer)) {
                                    while ((linha = ler.ReadLine ()) != null) {
                                        System.Console.WriteLine (linha);
                                    }
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine ("Insira o nome do arquivo:");
                            string arquivo = Console.ReadLine ();

                            System.Console.WriteLine ("O que deseja escrever?");
                            string mensagem = Console.ReadLine();
                            
                            using (StreamWriter escrever = new StreamWriter (arquivo)) {
                                escrever.WriteLine (mensagem);
                            }

                            // Mostrando

                            System.Console.WriteLine("Aperte [QUALQUER] tecla para mostrar o arquivo");
                            Console.ReadKey();

                            string linha;
                                using (StreamReader ler = new StreamReader (arquivo)) {
                                    while ((linha = ler.ReadLine ()) != null) {
                                        System.Console.WriteLine (linha);
                                    }
                                }
                                break;
                        }
                    default:
                    break;
                }
            } while (opcao != 0);
        }
    }
}