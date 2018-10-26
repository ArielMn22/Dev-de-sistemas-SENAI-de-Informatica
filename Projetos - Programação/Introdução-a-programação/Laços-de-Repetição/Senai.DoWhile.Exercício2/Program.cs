using System;

namespace Senai.DoWhile.Exercício2 {
    class Program {
        static void Main (string[] args) {
            float numero = 0, cont = 0, soma = 0;
            float media = 0;
            
            Console.Clear();
            
            System.Console.WriteLine("Insira vários números e depois veja a soma e a média deles:\n*OBS: Informe o valor '0' para encerrar\n");
            do {
                System.Console.WriteLine ("Insira um número:");
                numero = float.Parse (Console.ReadLine ());

                soma += numero;

                cont++;
                System.Console.WriteLine(); //Pula linha
            } while (numero != 0);

            media = (float) (soma/(cont-1));

            Console.Clear();
            System.Console.WriteLine("#################################################");
            System.Console.WriteLine("            Contador Two Thousand '2000'");
            System.Console.WriteLine("#################################################");
            System.Console.WriteLine($"Soma dos números: {soma}");
            System.Console.WriteLine($"Quantidade de números inseridos: {cont-1}");
            System.Console.WriteLine($"Média dos números: {media.ToString("N2")}");
        }
    }
}