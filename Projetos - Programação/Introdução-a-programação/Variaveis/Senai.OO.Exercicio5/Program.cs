using System;
using Senai.OO.Exercicio4.Classes;

namespace Senai.OO.Exercicio4 {
    class Program {
        static void Main (string[] args) {
            Aplicacao ap_1 = new Aplicacao ();
            Aplicacao ap_2 = new Aplicacao ();
            Aplicacao ap_3 = new Aplicacao ();

            Console.Clear();
            #region ap_1
            Console.WriteLine ("Insira o nome da primeira aplicação:");
            ap_1.nome = Console.ReadLine ();

            Console.WriteLine ("\nInsira o valor da aplicação:");
            ap_1.valor = float.Parse (Console.ReadLine ());

            Console.WriteLine ("\nInsira o período de pagamento (em meses):");
            ap_1.periodo = float.Parse (Console.ReadLine ());

            Console.WriteLine ("\nInsira o juros da aplicação (em porcentagem):");
            ap_1.juros = float.Parse (Console.ReadLine ());
            #endregion

            Console.Clear();
            #region ap_2
            Console.WriteLine ("Insira o nome da segunda aplicação:");
            ap_2.nome = Console.ReadLine ();

            Console.WriteLine ("\nInsira o valor da aplicação:");
            ap_2.valor = float.Parse (Console.ReadLine ());

            Console.WriteLine ("\nInsira o período de pagamento (em meses):");
            ap_2.periodo = float.Parse (Console.ReadLine ());

            Console.WriteLine ("\nInsira o juros da aplicação (em porcentagem):");
            ap_2.juros = float.Parse (Console.ReadLine ());
            #endregion

            Console.Clear();
            #region ap_3
            Console.WriteLine ("Insira o nome da terceira aplicação:");
            ap_3.nome = Console.ReadLine ();

            Console.WriteLine ("\nInsira o valor da aplicação:");
            ap_3.valor = float.Parse (Console.ReadLine ());

            Console.WriteLine ("\nInsira o período de pagamento (em meses):");
            ap_3.periodo = float.Parse (Console.ReadLine ());

            Console.WriteLine ("\nInsira o juros da aplicação (em porcentagem):");
            ap_3.juros = float.Parse (Console.ReadLine ());
            #endregion

            // Saída

            Console.WriteLine($"'{ap_1.nome}':\nValor: R${ap_1.valor}\nJuros: {ap_1.juros}%\nPeríodo: {ap_1.periodo} meses\nValor Final: R${ap_1.valor * (ap_1.juros * ap_1.periodo)}");
            Console.WriteLine($"\n'{ap_2.nome}':\nValor: R${ap_2.valor}\nJuros: {ap_2.juros}%\nPeríodo: {ap_2.periodo} meses\nValor Final: R${ap_2.valor * (ap_2.juros * ap_2.periodo)}");
            Console.WriteLine($"\n'{ap_3.nome}':\nValor: R${ap_3.valor}\nJuros: {ap_3.juros}%\nPeríodo: {ap_3.periodo} meses\nValor Final: R${ap_3.valor * (ap_3.juros * ap_3.periodo)}");
        }
    }
}