using System;

namespace Senai.Operadores.Exercicio5 {
    class Program {
        static void Main (string[] args) {
            float preco;
            int q_min, q_max, ea, em; // ea = estoque atual, em = estoque médio;

            Console.Clear();

            Console.WriteLine ("Insira o preço do produto: ");
            preco = float.Parse (Console.ReadLine ());

            Console.WriteLine ("\nInsira a quantidade mínima no estoque: ");
            q_min = Convert.ToInt32 (Console.ReadLine ());

            Console.WriteLine("\nInsira a quantidade máxima deste produto: ");
            q_max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInsira a quantidade atual deste produto no estoque: ");
            ea = Convert.ToInt32(Console.ReadLine());

            //Processamento

            em = (q_min + q_max) / 2;

            Console.WriteLine("\nEstoque médio: " + em);
            Console.WriteLine($"Custo total do produto considerando o estoque médio: R${preco*em}");
            Console.WriteLine($"Custo total do produto considerando o estoque atual: R${preco*ea}");
        }
    }
}