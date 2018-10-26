using System;

namespace Senai.While.Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            long inicio, fim; //Variaveis que receberao os valores de inicio e fim;
            long cont; //Variavel que terá seu valor manipulado nos lacos de repeticao;
            long maior, menor; //Valores que receberao os valores de maior e menor, independente da ordem que o usuario informar;
            
            Console.Clear();
            
            System.Console.WriteLine("Insira um número de início:");
            inicio = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira um número para finalizar:");
            fim = long.Parse(Console.ReadLine());
            
            if (inicio > fim)
            {
                menor = fim;
                maior = inicio;
            } else {
                menor = inicio;
                maior = fim;
            }

            System.Console.WriteLine("\nCrescente:");

            cont = menor;
            while(cont<=maior)
            {
                System.Console.WriteLine(cont);
                cont++;
            }

            cont = maior;
            System.Console.WriteLine("\nInverso:");
            while(cont>=menor)
            {
                System.Console.WriteLine(cont);
                cont--;
            }
        }
    }
}