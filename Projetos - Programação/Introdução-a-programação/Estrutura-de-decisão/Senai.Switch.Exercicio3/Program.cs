using System;
using Senai.Switch.Exercicio3.Class;

namespace Senai.Switch.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();

            Console.Clear();
            
            System.Console.WriteLine("Insira seu nome:");
            f1.Nome = Console.ReadLine();
            
            System.Console.WriteLine("\nInsira o salário:");
            f1.Salario = double.Parse(Console.ReadLine());

            System.Console.WriteLine("\nCargos");
            System.Console.WriteLine("1 - Escriturário.");
            System.Console.WriteLine("2 - Secretário.");
            System.Console.WriteLine("3 - Caixa.");
            System.Console.WriteLine("4 - Caixa.");
            System.Console.WriteLine("5 - Diretor.");

            System.Console.Write("\nInsira o código da sua profissão: ");
            f1.Codigo = int.Parse(Console.ReadLine());

            switch(f1.Codigo)
            {
                case 1:
                {
                    f1.PercentA = 50;
                    f1.SReajustado = f1.Salario * 1.5;
                    f1.Cargo = "Escriturário";
                    break;
                }

                case 2:
                {
                    f1.PercentA = 35;
                    f1.SReajustado = f1.Salario * 1.35;
                    f1.Cargo = "Secretário";
                    break;
                }

                case 3:
                {
                    f1.PercentA = 20;
                    f1.SReajustado = f1.Salario * 1.2;
                    f1.Cargo = "Caixa";
                    break;
                }

                case 4:
                {
                    f1.PercentA = 10;
                    f1.SReajustado = f1.Salario * 1.1;
                    f1.Cargo = "Gerente";
                    break;
                }
                 
                case 5:
                {
                    f1.Cargo = "Diretor";
                    break;
                }

                default:
                {
                    System.Console.WriteLine("Opção inválida! Informe uma opção entre 1 e 5.");
                    break;
                }
            }
            
            //Saída
            Console.Clear();

            System.Console.WriteLine($"Nome: {f1.Nome}");
            System.Console.WriteLine($"Salário: {f1.Salario}");
            System.Console.WriteLine($"Código: {f1.Codigo}");
            System.Console.WriteLine($"Cargo: {f1.Cargo}");
            if (f1.Codigo == 5)
            {
                System.Console.WriteLine($"Percentual de aumento: sem aumento");
                System.Console.WriteLine($"Salário reajustado: sem reajuste");
            } else {
                System.Console.WriteLine($"Percentual de aumento: {f1.PercentA}%");
                System.Console.WriteLine($"Salário reajustado: {f1.SReajustado.ToString("C")}");
            }

        }
    }
}
