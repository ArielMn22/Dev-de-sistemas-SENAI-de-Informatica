using System;

namespace Senai.Switch.DiaSemana {
    class Program {
        static void Main (string[] args) {
            Console.Clear ();

            System.Console.WriteLine ("Informe o dia semana entre 1 e 7:");
            int diaSemana = int.Parse (Console.ReadLine ());

            System.Console.WriteLine (); //pula linha

            switch (diaSemana) {
                case 1:
                    {
                        System.Console.WriteLine ("Domingo");
                        break;
                    }

                case 2:
                    {
                        System.Console.WriteLine ("Segunda-feira");
                        break;
                    }

                case 3:
                    {
                        System.Console.WriteLine ("Terça-feira");
                        break;
                    }

                case 4:
                    {
                        System.Console.WriteLine ("Quarta-feira");
                        break;
                    }

                case 5:
                    {
                        System.Console.WriteLine ("Quinta-feira");
                        break;
                    }

                case 6:
                    {
                        System.Console.WriteLine ("Sexta-feira");
                        break;
                    }

                case 7:
                    {
                        System.Console.WriteLine ("Sábado");
                        break;
                    }

                default:
                    {
                        System.Console.WriteLine ("Insira um número válido!");
                        break;
                    }
            }
        }
    }
}