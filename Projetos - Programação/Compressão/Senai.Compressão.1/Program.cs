using System;
using System.IO; // Namespace utilizada para utilização da Classe 'File'.
using System.IO.Compression; // Utilizada para compactar e descompactar arquivos.

namespace Senai.Compressão._1 {
    class Program {
        static void Main (string[] args) {
            string opcao;

            // Realiza o loop até o usuário colocar a opção '0'
            do {
                Console.Clear ();

                System.Console.WriteLine ("========================================================");
                System.Console.WriteLine ("                     Compactação");
                System.Console.WriteLine ("========================================================");
                System.Console.WriteLine ("1 - Compactar");
                System.Console.WriteLine ("2 - Descompactar");
                System.Console.WriteLine ("0 - Sair");

                System.Console.Write ("Insira uma opção: ");
                opcao = Console.ReadLine ();

                string directoryName = null;
                string fileDestino = null;

                switch (opcao) {
                    case "1":
                        System.Console.WriteLine ("Informe o caminho/nome da pasta que deseja compactar:");
                        directoryName = Console.ReadLine ();

                        System.Console.WriteLine ("Informe o caminho/nome do arquivo após a compactação:");
                        fileDestino = Console.ReadLine ();

                        if (!Directory.Exists (directoryName))
                        {
                            System.Console.WriteLine("Diretório alvo não encontrado...");
                        } else if (File.Exists (fileDestino)) {
                            System.Console.WriteLine ("O arquivo já foi compactado...");
                        } else {
                            ZipFile.CreateFromDirectory (directoryName, fileDestino);
                        }

                        System.Console.WriteLine("\nAperte [QUALQUER] tecla para continuar...");
                        Console.ReadKey();

                        break;
                    case "2":
                        System.Console.WriteLine ("Informe o caminho do arquivo .zip que deseja descompactar:");
                        directoryName = Console.ReadLine ();
                        //directoryName = Path.GetFullPath (directoryName);

                        System.Console.WriteLine ("Informe o nome do diretório junto com seu caminho:");
                        fileDestino = Console.ReadLine ();
                        //fileDestino = Path.GetFullPath (fileDestino);

                        if (!File.Exists (directoryName))
                        {
                            System.Console.WriteLine("Diretório alvo não encontrado...");
                        } else if (Directory.Exists (fileDestino)) {
                            System.Console.WriteLine ("O arquivo já foi descompactado...");
                        } else {
                            ZipFile.ExtractToDirectory (directoryName, fileDestino);
                        }
                        
                        System.Console.WriteLine("\nAperte [QUALQUER] tecla para continuar...");
                        Console.ReadKey ();

                        break;

                    case "0":
                        Console.Clear();
                        
                        System.Console.WriteLine("Tchau...");

                        break;

                    default:
                        System.Console.WriteLine ("Insira uma opção válida!!");
                        break;
                }
            } while (opcao != "0");

        }
    }
}