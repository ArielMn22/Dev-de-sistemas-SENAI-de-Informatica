using System;

namespace Senai.Matriz.Exercício3 {
    class Program {
        static void Main (string[] args) {
            int i, j;

            Console.Clear ();

            System.Console.WriteLine ("O programa criará uma matriz 5x5 de forma aleatória, depois insira um número para ver se a matriz contêm o número indicado...\n");

            System.Console.WriteLine ("Aperte [QUALQUER] tecla para criar a matriz...");
            Console.ReadKey ();

            int[, ] matriz = new int[5, 5];
            bool contem = false;

            Random numeroRandomico = new Random ();

            for (i = 0; i < 5; i++) {
                for (j = 0; j < 5; j++) {
                    matriz[i, j] = numeroRandomico.Next (30);
                }
            }

            System.Console.WriteLine ("\nMatriz Randômica criada com sucesso!");

            System.Console.WriteLine ("\nInsira um número:");
            int user_number = int.Parse (Console.ReadLine ());

            for (i = 0; i < 5; i++) {
                for (j = 0; j < 5; j++) {
                    if (matriz[i, j] == user_number) {
                        System.Console.WriteLine ($"O número {user_number} foi encontrado na matriz, na posição {i},{j}.");
                        contem = true;
                    }
                }
            }

            if (contem == false) {
                System.Console.WriteLine ($"O número {user_number} não foi encontrado na matriz.");
            }

            System.Console.WriteLine (); //pula linha

            for (i = 0; i < 5; i++) {
                for (j = 0; j < 5; j++) {
                    System.Console.Write ($"{matriz[i,j]}\t");
                }
                System.Console.WriteLine ();
            }
        }
    }
}