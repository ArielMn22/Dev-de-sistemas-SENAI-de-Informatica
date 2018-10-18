using System;
using Senai.ForEach.Exemplo1.Classes;

namespace Senai.ForEach.Exemplo1 {
    class Program {
        static Usuario[] arrayUsuarios;
        static int contador = 0;

        static void Main (string[] args) {
            Console.WriteLine ("Informe a quantidade de usuários:");
            int quantUsuarios = int.Parse (Console.ReadLine ());

            //Indica a quantidade de usuários do Array
            arrayUsuarios = new Usuario[quantUsuarios];

            int opcao = 0;

            do {
                MontarMenu ();

                opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                        {
                            CadastrarUsuario ();
                            break;
                        }

                    case 2:
                        {
                            ListarUsuario ();
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine ("Insira uma opção válida!");
                            break;
                        }
                }
            } while (opcao != 0);
        }

        static void MontarMenu () {
            System.Console.WriteLine ("Menu de opções");
            System.Console.WriteLine ("1 - Cadastrar");
            System.Console.WriteLine ("2 - Listar");
            System.Console.WriteLine ("0 - Sair");
        }

        static void CadastrarUsuario () {
            bool emailValido = false;
            string email;

            arrayUsuarios[contador] = new Usuario ();

            #region Nome
            System.Console.WriteLine ("Insira seu nome:");
            arrayUsuarios[contador].Nome = Console.ReadLine ();
            #endregion

            #region Email
            do {

                System.Console.WriteLine ("Informe seu e-mail:");
                email = Console.ReadLine ();

                if (email.Contains ('@')) {
                    arrayUsuarios[contador].Email = email;
                    emailValido = true;
                    break;
                }
            } while (!emailValido); //Verifica se é falso
            #endregion

            #region Senha
            bool senhaValida = false;
            string senha;

            do {
                System.Console.WriteLine ("Insforme a senha:");
                senha = Console.ReadLine ();

                if (senha.Length >= 4) {
                    arrayUsuarios[contador].Senha = senha;
                    // senha = senhaValida; //Não é necessário por conta do breask;
                    break;
                } else {
                    System.Console.WriteLine ("Senha inválida!");
                }
            } while (true); //Quem sairá do 'while' será o Break;
            #endregion

            System.Console.WriteLine ("Usuário cadastrado com sucesso!");
            contador++;
        }

        static void ListarUsuario () {
            foreach (Usuario item in arrayUsuarios) {
                if (item != null)
                {
                    System.Console.WriteLine ($"{item.Nome} - {item.Email}");
                }
            }
        }
    }
}