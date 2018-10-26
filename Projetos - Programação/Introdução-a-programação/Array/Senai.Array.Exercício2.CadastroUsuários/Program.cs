using System;
using Senai.Array.Exercício2.CadastroUsuários.Classes;

namespace Senai.Array.Exercício2.CadastroUsuários {
    class Program {
        static void Main (string[] args) {
            int i, j; //Contadores;

            Console.Clear();
            
            //Mostrando menu
            System.Console.WriteLine ("##########################################");
            System.Console.WriteLine ("          Cadastro de Usuários");
            System.Console.WriteLine ("##########################################");

            //Recebendo a quantidade de usuarios a serem cadastrados
            System.Console.WriteLine ("\nInsira a quantidade de usuários a serem cadastrados:");
            int nVetor = int.Parse (Console.ReadLine ());

            Usuario[] user = new Usuario[nVetor];

            for (i = 0; i < nVetor; i++) {
                user[i] = new Usuario();

                System.Console.WriteLine($"\nInsira o nome do {i+1}º usuário:");
                user[i].Nome = Console.ReadLine();
                
                System.Console.WriteLine($"Insira a idade de '{user[i].Nome}':");
                user[i].Idade = int.Parse(Console.ReadLine());

                System.Console.WriteLine($"Insira o endereço de '{user[i].Nome}':");
                user[i].Endereco = Console.ReadLine();
            }

            Console.Clear();
            
            System.Console.WriteLine("###########################################");
            System.Console.WriteLine("            Usuários Cadastrados");
            System.Console.WriteLine("###########################################");
            
            // j = 0; //Criado para mostrar
            for (i = user.Length; i>0 ; i--)
            {
                System.Console.WriteLine($"\n- {(user.Length - i) + 1}º, {user[i-1].Nome}, {user[i-1].Idade}, {user[i-1].Endereco}.");
            }
        }
    }
}