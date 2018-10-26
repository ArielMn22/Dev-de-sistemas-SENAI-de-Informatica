using System;

namespace Senai.Switch.DiaSemana {
    class Program {
        static void Main (string[] args) {
            Console.Clear ();

            System.Console.WriteLine ("Informe um algarismo e mostrarei o mês correspondente:");
            int num = int.Parse (Console.ReadLine ());

            System.Console.WriteLine (); //pula linha

            switch (num) {
                case 1:
                    {
                        System.Console.WriteLine ("Janeiro");
                        break;
                    }

                case 2:
                    {
                        System.Console.WriteLine ("Fevereiro");
                        break;
                    }

                case 3:
                    {
                        System.Console.WriteLine ("Março");
                        break;
                    }

                case 4:
                    {
                        System.Console.WriteLine ("Abril");
                        break;
                    }

                case 5:
                    {
                        System.Console.WriteLine ("Maio");
                        break;
                    }

                case 6:
                    {
                        System.Console.WriteLine ("Junho");
                        break;
                    }

                case 7:
                    {
                        System.Console.WriteLine ("Julho");
                        break;
                    }

                case 8:
                    {
                        System.Console.WriteLine ("Agosto");
                        break;
                    }

                case 9:
                    {
                        System.Console.WriteLine ("Setembro");
                        break;
                    }

                case 10:
                    {
                        System.Console.WriteLine ("Outubro");
                        break;
                    }

                case 11:
                    {
                        System.Console.WriteLine ("Novembro");
                        break;
                    }

                case 12:
                    {
                        System.Console.WriteLine ("Dezembro");
                        break;
                    }

                default:
                    {
                        System.Console.WriteLine ("Insira um número válido entre 1 e 12!");
                        break;
                    }
            }
        }
    }
}