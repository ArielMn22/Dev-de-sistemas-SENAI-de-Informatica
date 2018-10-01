using System;
using Senai.OO.Exercicio3.Classes;

namespace Senai.OO.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta p1 = new Conta(); //p1 = pessoa1;
            Conta p2 = new Conta(); //p2 = pessoa1;
            Conta p3 = new Conta(); //p3 = pessoa1;

            Console.WriteLine("Contas bancárias\n");

            #region conta 1
            Console.WriteLine("Insira o nome da primeira conta:");
            p1.nome = Console.ReadLine();

            Console.WriteLine($"\nInsira o número da conta '{p1.nome}':");
            p1.numero = Convert.ToInt32(Console.ReadLine());

            Console.Write($"\nInsira o saldo da conta '{p1.nome}':");
            p1.saldo = float.Parse(Console.ReadLine());
            #endregion

            #region conta 2
            Console.WriteLine("\nInsira o nome da segunda conta:");
            p2.nome = Console.ReadLine();

            Console.WriteLine($"\nInsira o número da conta '{p2.nome}':");
            p2.numero = Convert.ToInt32(Console.ReadLine());

            Console.Write($"\nInsira o saldo da conta '{p2.nome}':");
            p2.saldo = float.Parse(Console.ReadLine());
            #endregion

            #region conta 3
            Console.WriteLine("\nInsira o nome da terceira conta:");
            p3.nome = Console.ReadLine();

            Console.WriteLine($"\nInsira o número da conta '{p3.nome}':");
            p3.numero = Convert.ToInt32(Console.ReadLine());

            Console.Write($"\nInsira o saldo da conta '{p3.nome}':");
            p3.saldo = float.Parse(Console.ReadLine());
            #endregion

            //Saida
            Console.WriteLine("\nConta 1");
            Console.WriteLine($"Nome: {p1.nome}");
            Console.WriteLine($"Número: {p1.numero}");
            Console.WriteLine($"Saldo: {p1.saldo}");

            Console.WriteLine("Aperte [QUALQUER] tecla para continuar...\n");
            Console.ReadKey();

            Console.WriteLine("Conta 2");
            Console.WriteLine($"Nome: {p2.nome}");
            Console.WriteLine($"Número: {p2.numero}");
            Console.WriteLine($"Saldo: {p2.saldo}");
            
            Console.WriteLine("Aperte [QUALQUER] tecla para continuar...\n");
            Console.ReadKey();

            Console.WriteLine("Conta 3");
            Console.WriteLine($"Nome: {p3.nome}");
            Console.WriteLine($"Número: {p3.numero}");
            Console.WriteLine($"Saldo: {p3.saldo}");

            Console.WriteLine($"\nSaldo total das contas juntas: {p1.saldo + p2.saldo + p3.saldo}");
        }
    }
}
