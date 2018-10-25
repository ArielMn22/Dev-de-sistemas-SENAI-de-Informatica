using System;

namespace Senai.Array.Bingo {
    class Program {
        static void Main (string[] args) {
            //Declaração do array do tipo inteiro
            //Com 5 posições
            int[] cartela = new int[5]; // Forma correta de se declarar um array/vetor em C#.
            int contador = 0, acertos = 0, indice, numero;

            Console.Clear ();

            System.Console.WriteLine ("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            System.Console.WriteLine ("          Bingo do milhão");
            System.Console.WriteLine ("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            #region Recebendo Dados
            do {
                System.Console.WriteLine ($"\nInforme o {contador+1}º número:");
                cartela[contador] = int.Parse (Console.ReadLine ());
                contador++;
            } while (contador < cartela.Length);
            #endregion

            contador = 0; //É necessário zerar o Array/Vetor porque o valor neste momento do código será 5;

            #region Exibindo Dados
            System.Console.WriteLine ("\nNúmeros:\n");
            do {
                System.Console.Write ($" | {cartela[contador]} |");
                contador++;
            } while (contador < cartela.Length);
            #endregion

            #region Sorteia Números
            do {
                System.Console.WriteLine("\nInforme o número sorteado:");
                numero = int.Parse(Console.ReadLine());

                indice = System.Array.IndexOf(cartela, numero);

                if (indice >= 0)
                {
                    acertos++;
                    System.Console.WriteLine($"Você acertou {acertos}, faltam {5 - acertos}.");
                }
            } while (acertos != 5);

            System.Console.WriteLine("BINGO!! Você ganhou!!!");
            #endregion
        }
    }
}