using System;

namespace Senai.While.Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            long inicio, fim;
            long aux; //Variável para a troca de valores;

            Console.Clear();
            
            System.Console.WriteLine("Insira um número de início:");
            inicio = int.Parse(Console.ReadLine());

            long inicioAux = inicio; //Coloca um valor auxiliar para inicio;

            System.Console.WriteLine("Insira um número para finalizar:");
            fim = long.Parse(Console.ReadLine());
            
            if (inicio > fim)
            {
                aux = inicio;
                inicio = fim;
                fim = aux;
            }

            System.Console.WriteLine("\nCrescente:");

            while(inicioAux<=fim)
            {
                System.Console.WriteLine($"{inicioAux}");
                inicioAux++;
            }

            System.Console.WriteLine("\nInverso:");
            while(fim>=inicio)
            {
                System.Console.WriteLine($"{fim}");
                fim--;
            }
        }
    }
}