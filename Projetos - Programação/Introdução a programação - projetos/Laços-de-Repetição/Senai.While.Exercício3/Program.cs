using System;

namespace Senai.While.Exercício3 {
    class Program {
        static void Main (string[] args) {
            //Calculadora do Fulano

            int x = 0, y = 0; //Valores para calculo do usuario;
            int? first = null; //Validacao para verificar se o usuario definiu os valores de x e y;
            int choice = 1; //Variavel que guardara a escolha do usuario;

            Console.Clear ();

            System.Console.Write ("Informe-nos o seu nome: ");
            string nome = Console.ReadLine ();

            while (choice != 0) {
                Console.Clear ();

                System.Console.WriteLine ("##################################################");
                System.Console.WriteLine ($"            Calculadora do {nome}");
                // System.Console.WriteLine($"{Guid.NewGuid()}");
                System.Console.WriteLine ("##################################################");
                System.Console.WriteLine ("[1] - Defina os valores de X e Y");
                System.Console.WriteLine ("[2] - Soma");
                System.Console.WriteLine ("[3] - Subtração");
                System.Console.WriteLine ("[4] - Multiplicação");
                System.Console.WriteLine ("[5] - Divisão");
                System.Console.WriteLine ("[6] - Potência");
                System.Console.WriteLine ("[0] - Sair");

                System.Console.Write ("\nInsira uma opção: ");
                choice = int.Parse (Console.ReadLine ());

                if (first == null && choice != 1) {
                    System.Console.WriteLine ("\nExecute a [1] primeira opção para mudar os valores de 'x' e 'y'...");
                    Console.ReadKey ();
                } else {
                    switch (choice) {
                        case 1:
                            {
                                Console.Clear ();
                                System.Console.WriteLine ("Insira o valor de 'x':");
                                x = int.Parse (Console.ReadLine ());

                                System.Console.WriteLine ("\nInsira o valor de 'y':");
                                y = int.Parse (Console.ReadLine ());

                                first = 0;
                                break;
                            }

                        case 2:
                            {
                                Console.Clear ();
                                System.Console.WriteLine ($"{x} + {y} = {x+y}");
                                System.Console.WriteLine ("Aperte [QUALQUER] tecla para sair...");
                                Console.ReadKey ();
                                break;
                            }

                        case 3:
                            {
                                Console.Clear ();
                                System.Console.WriteLine ($"{x} - {y} = {x-y}");
                                System.Console.WriteLine ("Aperte [QUALQUER] tecla para sair...");
                                Console.ReadKey ();
                                break;
                            }

                        case 4:
                            {
                                Console.Clear ();
                                System.Console.WriteLine ($"{x} * {y} = {x * y}");
                                System.Console.WriteLine ("Aperte [QUALQUER] tecla para sair...");
                                Console.ReadKey ();
                                break;
                            }

                        case 5:
                            {
                                Console.Clear ();
                                try
                                {
                                    System.Console.WriteLine ($"{x} / {y} = {x/y}");
                                } catch (System.DivideByZeroException){
                                    System.Console.WriteLine("Não é possível dividir por zero...");
                                }

                                System.Console.WriteLine ("Aperte [QUALQUER] tecla para sair...");
                                Console.ReadKey ();
                                break;
                            }

                        case 6:
                            {
                                Console.Clear ();
                                System.Console.WriteLine ($"{x} ^ {y} = {Math.Pow(x, y)}");
                                System.Console.WriteLine ("Aperte [QUALQUER] tecla para sair...");
                                Console.ReadKey ();
                                break;
                            }

                        case 0:
                            {
                                Console.Clear ();
                                System.Console.WriteLine ("Saindo...");
                                break;
                            }

                        default:
                            {
                                Console.Clear ();
                                System.Console.WriteLine ("Insira uma opção válida!");
                                System.Console.WriteLine ("Aperte [QUALQUER] tecla para sair...");
                                Console.ReadKey ();
                                break;
                            }
                    }
                }

            }
        }
    }
}