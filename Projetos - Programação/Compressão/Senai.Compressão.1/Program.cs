using System;
// using System.IO;
using System.IO.Compression;

namespace Senai.Compressão._1 {
    class Program {
        static void Main (string[] args) {
            string opcao;
            do {
                System.Console.WriteLine ("========================================================");
                System.Console.WriteLine ("                     Compactação");
                System.Console.WriteLine ("========================================================");
                System.Console.WriteLine ("1 - Compactar");
                System.Console.WriteLine ("2 - Descompactar");

                opcao = Console.ReadLine ();

                switch (opcao) {
                    case "1":
                        string diretorioAlvo = @"PastaParaCompactar";
                        string arquivoDestino = @"PastaCompactada.zip";

                        ZipFile.CreateFromDirectory (diretorioAlvo, arquivoDestino);
                        break;
                    case "2":
                        string arquivoAlvo = @"PastaCompactada.zip";
                        string diretorioDestino = @"PastaExtraida";

                        ZipFile.ExtractToDirectory(arquivoAlvo, diretorioDestino);
                        break;
                    default:
                        System.Console.WriteLine("Insira uma opção válida!!");
                    break;
                }
            } while (opcao != "0");

        }
    }
}