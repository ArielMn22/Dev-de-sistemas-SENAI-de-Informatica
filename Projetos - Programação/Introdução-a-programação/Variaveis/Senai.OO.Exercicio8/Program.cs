using System;
using Senai.OO.Exercicio8.Classes;

namespace Senai.OO.Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();
            
            Console.Clear();
            #region func1
            Console.WriteLine("Insira o número do funcionário 1:");
            func1.numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de horas trabalhadas do funcionário 1:");
            func1.horas = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor da hora do funcionário 1:");
            func1.vHora = float.Parse(Console.ReadLine());
            #endregion
            
            Console.Clear();
            #region func2
            Console.WriteLine("Insira o número do funcionário 2:");
            func2.numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de horas trabalhadas do funcionário 2:");
            func2.horas = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor da hora do funcionário 2:");
            func2.vHora = float.Parse(Console.ReadLine());
            #endregion

            // Saida
            Console.Clear();
            Console.WriteLine("Funcionário 1\n");
            Console.WriteLine($"Número: {func1.numero}");
            Console.WriteLine($"Salário: R${func1.horas*func1.vHora}\n");

            Console.WriteLine("Funcionário 2\n");
            Console.WriteLine($"Número: {func2.numero}");
            Console.WriteLine($"Salário: R${func2.horas*func2.vHora}");
        }
    }
}
