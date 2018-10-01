using System;

namespace Senai.Examplo.Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Olá Mundo!");
            // DateTime é um tipo de variável utilizado para datas e tempo;

            string nome;
            byte idade;
            float altura;
            char sexo;
            DateTime datanascimento;

            Console.Clear();

            Console.WriteLine("Escreva o seu nome:");
            nome = Console.ReadLine();


            Console.WriteLine("\nInforme a sua idade: ");
            idade = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("\nInforme sua altura: ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("\nInsira seu sexo: ");
            sexo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("\nInsira sua data de nascimentoo: ");
            datanascimento = Convert.ToDateTime(Console.ReadLine());
            
            Console.WriteLine("\nNome: " + nome + ", Idade: " + idade + ", Altura: " + altura + "m" + ", Sexo: " + sexo + ", Data de nascimento: " + datanascimento.ToShortDateString());
        }
    }
}