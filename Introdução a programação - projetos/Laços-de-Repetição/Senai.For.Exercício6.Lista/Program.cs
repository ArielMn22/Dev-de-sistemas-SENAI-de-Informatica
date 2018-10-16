using System;

namespace Senai.For.Exercício6.Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            float maior = (float) ((2147483647) * (-1));
            float menor = (float) (2147483647);
            float user_num = 0;
            
            int q_numeros = 0, i;

            Console.Clear();
            
            System.Console.WriteLine("Insira a quantidade de números a serem informados:");
            q_numeros = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("**OBS: Só insira valores maiores que '0'.");
            
            for (i = 0; i<q_numeros ; i++)
            {
                System.Console.WriteLine($"Insira o {i+1}º número:");
                user_num = float.Parse(Console.ReadLine());
                
                maior = (user_num > maior) ? user_num : maior;
                menor = (user_num < menor) ? user_num : menor;
            }

            System.Console.WriteLine($"\nO maior número é: {maior}");
            System.Console.WriteLine($"O menor número é: {menor}");
        }
    }
}
