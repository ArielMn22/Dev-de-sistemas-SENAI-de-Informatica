using System;

namespace Senai.Switch.Rodízio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            
            System.Console.WriteLine("Insira o último digito da sua placa:");
            int digito = int.Parse(Console.ReadLine());

            switch (digito)
            {
                case 1: case 2:
                {
                    System.Console.WriteLine("Segunda-feira");
                    break;
                }

                case 3: case 4:
                {
                    System.Console.WriteLine("Terça-feira");
                    break;
                }

                case 5: case 6:
                {
                    System.Console.WriteLine("Quarta-feira");
                    break;
                }

                case 7: case 8:
                {
                    System.Console.WriteLine("Quinta-feira");
                    break;
                }

                case 9: case 0:
                {
                    System.Console.WriteLine("Sexta-feira");
                    break;
                }

                default:
                {
                    System.Console.WriteLine("Número inválido, insira somente o último algarismo da placa.");
                    break;
                }
            }
        }
    }
}
