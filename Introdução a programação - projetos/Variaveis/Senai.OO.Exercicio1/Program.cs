using System;
using Senai.OO.Exercicio1.Classes;

namespace Senai.OO.Exercicio1 {
    class Program {
        static void Main(string[] args) {
            Pessoa pessoa = new Pessoa(); //Pessoa = Classe, enquanto 'pessoa' = Objeto;

            Console.Clear();
            Console.WriteLine("Informe o nome da pessoa:");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine ("\nInforme a altura da pessoa:");
            pessoa.Altura = float.Parse(Console.ReadLine());

            Console.WriteLine ("\nInforme o peso da pessoa:");
            pessoa.Peso = float.Parse(Console.ReadLine());

            Console.WriteLine($"\nO nome da pessoa é {pessoa.Nome}, seu peso é {pessoa.Peso} e sua altura é {pessoa.Altura}, IMC = {pessoa.Peso/Math.Pow(pessoa.Altura, 2)}.");
        }
    }
}