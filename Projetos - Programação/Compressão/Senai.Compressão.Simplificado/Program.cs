using System;
using System.IO.Compression;

namespace Senai.Compressão.Simplificado
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Compactar

            string diretorioParaCompactar = @"bin";
            string arquivoZipDestino = @"arquivo.zip";

            ZipFile.CreateFromDirectory(diretorioParaCompactar, arquivoZipDestino);
            
            #endregion

            #region Descompactar
                
            string zipParaDescompactar = @"arquivo.zip";
            string diretorioDestino = @"descompactada";

            ZipFile.ExtractToDirectory(zipParaDescompactar, diretorioDestino);
            
            #endregion
        }
    }
}
