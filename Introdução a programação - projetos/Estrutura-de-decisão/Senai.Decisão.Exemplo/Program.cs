using System;

namespace Senai.Decisão.Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recebendo um número
            System.Console.WriteLine("Insira um número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            //Estrutura de decisão (if)
            if (numero >= 0)
            {
                System.Console.WriteLine("Positivo.");
            } else {
                System.Console.WriteLine("Negativo.");
            }
        }
    }
}
