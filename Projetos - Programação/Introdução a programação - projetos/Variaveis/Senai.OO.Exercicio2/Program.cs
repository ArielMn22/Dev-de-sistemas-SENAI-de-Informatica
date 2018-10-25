using System;
using Senai.OO.Exercicio2.Classes;

namespace Senai.OO.Exercicio2 {
    class Program {
        static void Main (string[] args) {
            Produto produto1 = new Produto ();
            Produto produto2 = new Produto ();
            Produto produto3 = new Produto ();

            Console.Clear();
            Console.WriteLine ("Calcule a média do preço de três produtos:\n");
            
            #region Produto1
            Console.WriteLine ("Insira o nome do primeiro produto:");
            produto1.Nome = Console.ReadLine ();

            Console.WriteLine ($"\nInsira o preço de '{produto1.Nome}':");
            produto1.Preco = float.Parse (Console.ReadLine ());

            Console.WriteLine ($"\nInsira a quantidade de '{produto1.Nome}' em estoque:");
            produto1.Quantidade = Convert.ToInt32 (Console.ReadLine ());
            #endregion

            #region Produto 2
            Console.WriteLine ("\nInsira o nome do segundo produto:");
            produto2.Nome = Console.ReadLine ();

            Console.WriteLine ($"\nInsira o preço de '{produto2.Nome}':");
            produto2.Preco = float.Parse (Console.ReadLine ());

            Console.WriteLine ($"\nInsira a quantidade de '{produto2.Nome}' em estoque:");
            produto2.Quantidade = Convert.ToInt32 (Console.ReadLine ());
            #endregion

            #region Produto 3
            Console.WriteLine ("\nInsira o nome do terceiro produto:");
            produto3.Nome = Console.ReadLine ();

            Console.WriteLine ($"\nInsira o preço de '{produto3.Nome}':");
            produto3.Preco = float.Parse (Console.ReadLine ());

            Console.WriteLine ($"\nInsira a quantidade de '{produto3.Nome}' em estoque:");
            produto3.Quantidade = Convert.ToInt32 (Console.ReadLine ());    
            #endregion

            //Processamento
            produto1.P_Total = produto1.Preco * produto1.Quantidade;
            produto2.P_Total = produto2.Preco * produto2.Quantidade;
            produto3.P_Total = produto3.Preco * produto3.Quantidade;

            int quantidade_total = produto1.Quantidade + produto2.Quantidade + produto3.Quantidade;
            float media_total = (produto1.P_Total + produto2.P_Total + produto3.P_Total) / quantidade_total;

            //Saida
            Console.Clear();

            Console.WriteLine("Produto 1");
            Console.WriteLine($"Nome: {produto1.Nome}");
            Console.WriteLine($"Preço unitário: {produto1.Preco}");
            Console.WriteLine($"Quantidade em estoque: {produto1.Quantidade}");
            Console.WriteLine($"Preço total: {produto1.P_Total}");

            Console.WriteLine("Aperte [QUALQUER] tecla para continuar...");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Produto 2");
            Console.WriteLine($"Nome: {produto2.Nome}");
            Console.WriteLine($"Preço unitário: {produto2.Preco}");
            Console.WriteLine($"Quantidade em estoque: {produto2.Quantidade}");
            Console.WriteLine($"Preço total: {produto2.P_Total}");
            
            Console.WriteLine("Aperte [QUALQUER] tecla para continuar...");
            Console.ReadKey();
            
            Console.Clear();
            
            Console.WriteLine("Produto 3");
            Console.WriteLine($"Nome: {produto3.Nome}");
            Console.WriteLine($"Preço unitário: {produto3.Preco}");
            Console.WriteLine($"Quantidade em estoque: {produto3.Quantidade}");
            Console.WriteLine($"Preço total: {produto3.P_Total}");

            Console.WriteLine("Aperte [QUALQUER] tecla para continuar...");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine($"Média total dos produtos: R${String.Format("{0:F2}", media_total)}");
        }
    }
}