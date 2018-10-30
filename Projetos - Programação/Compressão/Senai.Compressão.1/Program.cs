using System;
using System.IO; // Namespace utilizada para utilização da Classe 'File'.
using System.IO.Compression; // Utilizada para compactar e descompactar arquivos.

namespace Senai.Compressão._1 {
    class Program {
        static void Main (string[] args) {
            string opcao;

            // Realiza o loop até o usuário colocar a opção '0'
            do {
                // Limpa a tela
                Console.Clear ();

                System.Console.WriteLine ("========================================================");
                System.Console.WriteLine ("                     Compactação");
                System.Console.WriteLine ("========================================================");
                System.Console.WriteLine ("1 - Compactar");
                System.Console.WriteLine ("2 - Descompactar");
                System.Console.WriteLine ("0 - Sair");

                System.Console.Write ("Insira uma opção: ");
                opcao = Console.ReadLine (); // Lê a opção do usuário

                switch (opcao) {
                    case "1":
                        System.Console.WriteLine ("Informe o caminho/nome da pasta que deseja compactar:");
                        string pastaParaCompactar = Console.ReadLine (); // Pasta que será compactada

                        System.Console.WriteLine ("Informe o caminho/nome do arquivo .zip após a compactação:");
                        string arquivoZipDestino = Console.ReadLine (); // O nome que o arquivo .zip terá depois de ser compactado

                        // Caso a pasta que deseja compactar não exista mostre a mensagem de erro
                        if (!Directory.Exists (pastaParaCompactar)) {
                            System.Console.WriteLine ("Diretório alvo não encontrado...");
                        } else if (File.Exists (arquivoZipDestino)) { // Caso o arquivo .zip exista mostre a mensagem de erro.
                            System.Console.WriteLine ("O arquivo já foi compactado...");
                        } else {
                            // Caso as duas condições forem falsas, o programa compacta a pasta...
                            ZipFile.CreateFromDirectory (pastaParaCompactar, arquivoZipDestino);
                        }

                        System.Console.WriteLine ("\nAperte [QUALQUER] tecla para continuar...");
                        Console.ReadKey (); //Pausa o programa
                        break;

                    case "2":
                        System.Console.WriteLine ("Informe o caminho do arquivo .zip que deseja descompactar:");
                        string arquivoZip = Console.ReadLine (); // Arquivo .zip que será descompactado

                        System.Console.WriteLine ("Informe o nome do diretório junto com seu caminho:");
                        string diretorioDestino = Console.ReadLine (); // Pasta que será criada para guardar os arquivos do .zip

                        // Caso o arquivo que deverá ser descompactado não exista mostre a mensagem de erro...
                        if (!File.Exists (arquivoZip)) {
                            System.Console.WriteLine ("Diretório alvo não encontrado...");
                        } else if (Directory.Exists (diretorioDestino)) { // Caso o diretório destino já exista mostre a mensagem de erro...
                            System.Console.WriteLine ("O arquivo já foi descompactado...");
                        } else {
                            // Caso as duas condições forem falsas, o arquivo será extraido.
                            ZipFile.ExtractToDirectory (arquivoZip, diretorioDestino);
                        }

                        System.Console.WriteLine ("\nAperte [QUALQUER] tecla para continuar...");
                        Console.ReadKey ();
                        break;

                    case "0":
                        Console.Clear ();

                        System.Console.WriteLine ("Tchau...");
                        break;

                    default:
                        System.Console.WriteLine ("Insira uma opção válida!!");
                        break;
                }
            } while (opcao != "0");

        }
    }
}