using System;
using System.Collections.Generic;

namespace Senai.Bingo {
    class Program {
        static void Main (string[] args) {
            List<int> numeroSorteados = new List<int>();
            Random rand = new Random();

            string comando = "";
            
            while (true) {
                
                int numeroRandomico = 0;

                do {
                    numeroRandomico = rand.Next(50);
                } while (numeroSorteados.Contains(numeroRandomico));

                numeroSorteados.Add(numeroRandomico);

                System.Console.WriteLine($"Novo numero: {numeroRandomico}");
                System.Console.WriteLine("Aperte ENTER");
                Console.ReadKey();

            }

        }
    }
}