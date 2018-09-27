using System;

namespace Senai.Variaveis.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte i = 0;
            float[] numeros; //Para se declarar um vetor, basta colocar o <tipo>[], e os colchetes;
            
            numeros = new float[3];

            Console.Clear();
            for(i=0; i<2; i++)
            {
                Console.WriteLine($"\nInsira {i+1}º número:");
                numeros[i] = float.Parse(Console.ReadLine());
            }

            numeros[i] = (float) (Math.Pow(numeros[0], 2) + Math.Pow(numeros[1], 2));

            Console.WriteLine($"\nA soma dos quadrados é: {numeros[i]}");
        }
    }
}
