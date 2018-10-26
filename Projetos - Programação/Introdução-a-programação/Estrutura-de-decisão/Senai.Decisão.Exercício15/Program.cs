using System;

namespace Senai.Decisão.Exercício15 {
    class Program {
        static void Main (string[] args) {
            double salario;
            int percent;

            Console.Clear();
            
            System.Console.WriteLine ("Informe o salário:");
            salario = double.Parse (Console.ReadLine ());

            if (salario <= 300) {
                salario *= 1.1;
                percent = 10;
            } else if (salario <= 600) {
                salario *= 1.11;
                percent = 11;
            } else if (salario <= 900) {
                salario *= 1.12;
                percent = 12;
            } else if (salario <= 1500) {
                salario *= 1.06;
                percent = 6;
            } else if (salario <= 2000) {
                salario *= 1.03;
                percent = 3;
            } else {
                percent = 0;
            }

            System.Console.WriteLine($"\nAumento de {percent}%\nSalário reajustado: {salario.ToString("C")}");
        }
    }
}