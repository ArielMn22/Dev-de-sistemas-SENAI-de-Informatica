using System;

namespace Senai.Decisão.Exercício3
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            float percent;

            Console.Clear();
            
            System.Console.WriteLine("Insira o valor do salário:");
            salario = double.Parse(Console.ReadLine());

            if(salario <= 1000)
            {
                percent = 25;
                salario = salario + (salario * 0.25);
            } else {
                if(salario <= 2000)
                {
                    percent = 15;
                    salario = salario + (salario * 0.15);
                } else {
                    percent = 10;
                    salario = salario + (salario * 0.10);
                }
            }

            System.Console.WriteLine($"\nSalário final (aumento de {percent}%): {salario.ToString("C")}");

        }
    }
}
