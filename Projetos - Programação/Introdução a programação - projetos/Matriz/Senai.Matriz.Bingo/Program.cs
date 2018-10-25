using System;

namespace Senai.Bingo {
    class Program {
        static void Main (string[] args) {

            Console.Clear();
            
            //Nossa cartela
            int[, ] cartela = new int[5, 3];
            bool[, ] marcacoes = new bool[5, 3];

            //Objeto de numeros aleatorios
            Random rand = new Random ();

            //Laço dentro do outro
            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 3; j++) {
                    cartela[i, j] = rand.Next (50);
                    marcacoes[i, j] = false;
                }
            }

            //Laço do menu
            string comando = "";

            do {
                Console.Clear();
                
                //Desenhando a cartela na tela
                for (int i = 0; i < 5; i++) {
                    for (int j = 0; j < 3; j++) {
                        if (marcacoes[i, j]) {
                            Console.Write ($"X\t");
                        } else {
                            Console.Write ($"{cartela[i,j]}\t");
                        }
                    }
                    Console.WriteLine ();
                }

                System.Console.WriteLine ("[1]. Informar coordenada");
                System.Console.WriteLine ("[0]. Sair");
                System.Console.WriteLine("\nInsira uma opção:");
                comando = Console.ReadLine ();

                switch (comando) {
                    case "1":
                        System.Console.WriteLine ("Informe a coordenada X: ");
                        int x = int.Parse (Console.ReadLine ());
                        System.Console.WriteLine ("Informe a coordenada Y: ");
                        int y = int.Parse (Console.ReadLine ());

                        if (x >= 0 && x < 5 && y >= 0 && y < 3) {
                            marcacoes[x, y] = true;
                        }

                        break;
                }

            } while (comando != "0");

        }
    }
}