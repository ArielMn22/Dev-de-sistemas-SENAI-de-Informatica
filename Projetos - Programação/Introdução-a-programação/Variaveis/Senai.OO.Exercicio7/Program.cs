using System;
using Senai.OO.Exercicio7.Classes;

namespace Senai.OO.Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();
            
            Console.Clear();

            #region func1
            Console.WriteLine("Insira o nome do funcionário:");
            func1.nome = Console.ReadLine();

            Console.WriteLine($"Insira o salário do funcionário '{func1.nome}':");
            func1.salarioFix = float.Parse(Console.ReadLine());

            Console.WriteLine($"Insira o total de vendas do funcionário '{func1.nome}':");
            func1.vendas = float.Parse(Console.ReadLine());
            #endregion
        
            Console.Clear();
            
            #region func2
            Console.WriteLine("Insira o nome do funcionário:");
            func2.nome = Console.ReadLine();

            Console.WriteLine($"Insira o salário do funcionário '{func2.nome}':");
            func2.salarioFix = float.Parse(Console.ReadLine());

            Console.WriteLine($"Insira o total de vendas do funcionário '{func2.nome}':");
            func2.vendas = float.Parse(Console.ReadLine());
            #endregion

            // Saida
            Console.Clear();
            Console.WriteLine("Salários:\n");
            Console.WriteLine($"{func1.nome}:");
            Console.WriteLine($"Total a receber: R${func1.salarioFix + (func1.vendas*0.15)}");

            Console.WriteLine($"\n{func2.nome}:");
            Console.WriteLine($"Total a receber: R${func2.salarioFix + (func2.vendas*0.15)}");
        }
    }
}
