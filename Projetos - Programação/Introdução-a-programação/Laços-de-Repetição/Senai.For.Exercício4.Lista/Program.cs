using System;

namespace Senai.For.Exercício4.Lista {
    class Program {
        static void Main (string[] args) {
            int quantidade = 0, soma = 0, user_num = 0;
            float media = 0;

            Console.Clear();
            
            System.Console.WriteLine("Insira a quantidade de números que vão ser inseridos:");
            quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++) {
                System.Console.WriteLine($"Insira o {i+1}º número:");
                soma += int.Parse(Console.ReadLine());
                
                //Old Version
                // user_num = int.Parse(Console.ReadLine());
                // soma += user_num;
            }

            media = (float) (soma / quantidade);

            System.Console.WriteLine("\nSaída");
            System.Console.WriteLine($"Soma: {soma}\nMédia: {media}");
        }
    }
}