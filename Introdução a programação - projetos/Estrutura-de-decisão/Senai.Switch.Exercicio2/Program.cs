using System;

namespace Senai.Switch.Exercicio2 {
    class Program {
        static void Main (string[] args) {
            Console.Clear();
            
            System.Console.WriteLine ("#########################################");
            System.Console.WriteLine ("              Cálcula Área");
            System.Console.WriteLine ("#########################################\n");
            System.Console.WriteLine ("1 - Triângulo\n2 - Quadrado\n3 - Círculo\n");

            System.Console.Write("Insira uma opção: ");
            char choice = char.Parse (Console.ReadLine ());
            
            float medida, area;
            float PI = (float) (3.14);

            System.Console.WriteLine(); //pula linha
            switch (choice) {
                case '1':
                    {
                        System.Console.WriteLine ("Informe a medida do triângulo:");
                        medida = float.Parse (Console.ReadLine ());

                        area = (float) ((medida * ((medida / 2) * Math.Sqrt (3))) / 2);

                        System.Console.WriteLine ($"\nÁrea do triângulo: {area.ToString("n2")}cm²");
                        break;
                    }

                case '2':
                    {
                        System.Console.WriteLine ("Informe a medida do lado do quadrado:");
                        medida = float.Parse (Console.ReadLine ());

                        area = (float) (medida * medida);

                        System.Console.WriteLine ($"Área do quadrado: {area.ToString("n2")}cm²");
                        break;
                    }

                case '3':
                    {
                        System.Console.WriteLine ("Informe o diâmetro do círculo:");
                        medida = float.Parse (Console.ReadLine ());

                        area = (float) (PI * Math.Pow ((medida / 2), 2));

                        System.Console.WriteLine ($"Área do círculo: {area.ToString("n2")}cm²");
                        break;
                    }
                default:
                {
                    System.Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
                }
            }
        }
    }
}