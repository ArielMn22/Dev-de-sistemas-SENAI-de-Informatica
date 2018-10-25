using System;

namespace Senai.Decisão.Exercícios10 {
    class Program {
        static void Main (string[] args) {
            int lados;
            float medida;
            float area;

            Console.Clear();
            
            System.Console.WriteLine ("Insira a quantidade de lados da figura regular:");
            lados = int.Parse (Console.ReadLine ());

            if (lados == 3) { //TRIANGULO
                System.Console.WriteLine ("\nInsira a quantidade de lados da figura regular:");
                medida = float.Parse (Console.ReadLine ());

                area = (float) ((Math.Pow(medida, 2) * Math.Sqrt(3))/4);

                System.Console.WriteLine ($"\nA figura é um triângulo:\nÁrea: {area.ToString("n2")}cm²");
            } else if (lados == 4) { //QUADRADO
                System.Console.WriteLine ("\nInsira a quantidade de lados da figura regular:");
                medida = float.Parse (Console.ReadLine ());

                area = (float) medida * medida;

                System.Console.WriteLine ($"\nA figura é um quadrado:\nÁrea: {area.ToString("n2")}cm²");
            } else if (lados == 5) { //PENTAGONO
                System.Console.WriteLine ("\nA figura é um pentágono.");
            } else { //NENHUM DOS ANTERIORES
                System.Console.WriteLine ("\nO número de lados é inválido.");
            }
        }
    }
}
