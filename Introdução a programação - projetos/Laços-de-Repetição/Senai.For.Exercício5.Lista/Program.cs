using System;

namespace Senai.For.Exercício5.Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            int q_idade = 0, menor_idade = 0, maior_idade = 0, maior_cinquenta = 0;
            int i; //contador;

            Console.Clear();
            
            System.Console.WriteLine("Insira a quantidade de idades a serem inseridas:");
            q_idade = int.Parse(Console.ReadLine());

            int[] idades = new int[q_idade];

            for (i = 0; i < q_idade; i++)
            {
                Console.WriteLine($"Insira a {i+1}º idade:");
                idades[i] = int.Parse(Console.ReadLine());
                System.Console.WriteLine(); //pula linha;
            }

            for (i = 0; i < q_idade; i++)
            {
                if (idades[i] < 18)
                {
                    menor_idade++;
                } else if (idades[i] > 50) {
                    maior_cinquenta++;
                } else {
                    maior_idade++;
                }
            }

            System.Console.WriteLine("Saída\n");
            System.Console.WriteLine($"Idades menores que 18 anos: {menor_idade}");
            System.Console.WriteLine($"Idades maiores que 18 anos: {maior_idade}");
            System.Console.WriteLine($"Idades maiores que 50 anos: {maior_cinquenta}");
        }
    }
}
