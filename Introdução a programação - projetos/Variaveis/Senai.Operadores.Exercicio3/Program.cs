using System;

namespace Senai.Operarios.Exercicio3 {
    class Program {
        static void Main (string[] args) {
            byte i;
            float preco = 0, soma = 0, media = 0;

            Console.Clear();
            for (i = 0; i < 5; i++) {
                Console.WriteLine ($"Insira o preço do {i+1}º produto: ");
                preco = float.Parse(Console.ReadLine());

                soma = soma + preco;
            }

            media = soma / i;

            Console.WriteLine("A média dos preços é: R$" + media);
        }
    }
}