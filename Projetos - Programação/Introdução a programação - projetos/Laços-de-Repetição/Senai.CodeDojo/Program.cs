using System;

namespace Senai.Aulas.DoWhile.Dojo {
    class Program {
        static void Main (string[] args) {
            int cont = 0, dividendo = 0, divisor = 0;
            int negativo = 0;
            Console.Clear ();

            Console.WriteLine ("Insira um numero dividendo");
            dividendo = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Insira o divisor");
            divisor = int.Parse (Console.ReadLine ());

            if (dividendo < 0) {
                dividendo *= -1; //troca o sinal
                negativo = 1;
            }

            if (divisor == 0) {
                System.Console.WriteLine ($"O numero não pode ser dividido por 0");
            } else {

                while (dividendo > 1) {
                    dividendo = dividendo - divisor;

                    cont++;
                }

                if (divisor == 1) {
                    cont++;
                }

                if (negativo == 1) {
                    System.Console.WriteLine ($"Resultado da divisão {cont*-1}");

                } else {
                    System.Console.WriteLine ($"Resultador da divisão: {cont}");

                }
            }

        }
    }
}