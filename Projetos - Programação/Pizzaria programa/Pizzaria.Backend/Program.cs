using System;
using Pizzaria.Backend.classes;

namespace Pizzaria.Backend {
    class Program {
        static Usuario[] usuario = new Usuario[500];
        static Produtos[] produto = new Produtos[300];
        static UsuarioControl MetodoUser = new UsuarioControl ();
        static string opcao;
        static int cUser = 0; // Contador da quanditade de usuarios cadastrados
        static int cProd = 0;
        static void Main (string[] args) {
            do {
                MenuInicio ();
                opcao = Console.ReadLine ();
                switch (opcao) {
                    case "1":
                        {
                            Cadastro ();
                            break;
                        }

                    case "2":
                        {
                            string loginEmail = LerEmail ();
                            string loginSenha = LerSenha ();
                            if (MetodoUser.Login (usuario, loginEmail, loginSenha) == true) {
                                do {
                                    MenuPizza ();
                                    opcao = Console.ReadLine ();
                                    switch (opcao) {
                                        case "1":
                                            {
                                                CadastroProduto ();
                                                break;
                                            }
                                        case "2":
                                            {
                                                break;
                                            }
                                        case "3":
                                            {
                                                break;
                                            }
                                    }
                                } while (true);
                            } else {
                                System.Console.WriteLine ("E-mail ou senha incorreto");
                            }

                            break;
                        }

                    case "3":
                        {
                            ListandoUser();
                            break;
                        }

                    default:
                        {
                            System.Console.WriteLine ("##### Opção invalida #####");
                            break;
                        }
                }

            } while (opcao != "0");
        }

        #region Menu de opções inicial
        static void MenuInicio () {
            System.Console.WriteLine (@"
                ---------------------------
                1 - Cadastrar novo usuario
                2 - Logar
                3 - Listar Usuarios
                0 - Sair
                ---------------------------");
        }
        #endregion

        #region Cadastro de usuario
        /// <summary>
        /// Metodo para cadastro de usuario
        /// </summary>
        static void Cadastro () {
            usuario[cUser] = new Usuario ();

            System.Console.WriteLine ("Informe o nome do usuario:");
            usuario[cUser].Nome = Console.ReadLine ();

            usuario[cUser].Email = LerEmail ();
            usuario[cUser].Senha = LerSenha ();

            usuario[cUser].DataCriacao = DateTime.Now; //Data de criação
            usuario[cUser].Id = cUser + 1;
            Console.Clear ();
            System.Console.WriteLine ("Cadastro feito sucesso!");
            
            cUser++;
        }
        #endregion

        #region Efetuar Login
        static bool logado;
        static void Login () {
            Console.Clear ();
            string email, senha;
            email = LerEmail ();
            senha = LerSenha ();

            foreach (Usuario item in usuario) {
                if (item.Email == email && item.Senha == senha) {
                    logado = true;
                    break;
                }
            }
        }
        #endregion

        #region Metodos de ler email e senha
        static string LerEmail () {
            #region Email
            string email;
            do {
                System.Console.WriteLine ("Informe o e-mail do usuário:");
                email = Console.ReadLine ();
                if (MetodoUser.ReadEmail (email) == 0) {
                    return email;
                } else {
                    System.Console.WriteLine ("Insira um e-mail que contenha '@' e '.'");
                }
            } while (true);
            #endregion
        }

        static string LerSenha () {
            string senha;
            do {
                System.Console.WriteLine ("Informe a senha do usuário:");
                senha = Console.ReadLine ();
                if (MetodoUser.ReadSenha (senha) == 0) {
                    return senha;
                } else {
                    System.Console.WriteLine ("Insira uma senha que possui ao menos 6 caractéres.");
                }
            } while (true);
        }
        #endregion

        #region listando usuarios
        /// <summary>
        /// Metodo que lista todos usuarios cadasrados
        /// </summary>
        static void ListandoUser () {
            foreach (Usuario item in usuario) {
                if (item == null) {
                    break;
                } else {
                    System.Console.WriteLine ($"Id: {item.Id}\n Nome: {item.Nome}\n Email: {item.Email}\n Data criada: {item.DataCriacao}");
                }
            }
        }
        #endregion

        #region Menu de pizza
        static void MenuPizza () {
            System.Console.WriteLine (@"
            1 - Cadastrar produto
            2 - Listar todos os produtos
            3 - Valor total dos produtos
            0 - sair");
        }
        #endregion

        #region Cadastro de produto
        static void CadastroProduto () {
            produto[cProd] = new Produtos (); //Instanciando

            System.Console.WriteLine ("Informe o Nome do produto:");
            produto[cProd].Nome = Console.ReadLine ();

            System.Console.WriteLine ("Descreva o produto:");
            produto[cProd].Descricao = Console.ReadLine ();

            System.Console.WriteLine ("Informe o preço do produto:");
            produto[cProd].Preco = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Informe a categoria do produto:");
            System.Console.WriteLine ("1 - Pizza");
            System.Console.WriteLine ("2 - Bebida");

            string categoria;
            do {
                System.Console.Write ("Insira uma opção: ");
                categoria = Console.ReadLine ();
                if (categoria == "1") produto[cProd].Categoria = "Pizza";
                else if (categoria == "2") produto[cProd].Categoria = "Bebida";
                else System.Console.WriteLine ("Opção inválida...");
            } while (categoria != "1" || categoria != "2");

            produto[cProd].Id = cProd + 1;
            cProd++;
        }
        #endregion

        #region listar todos os produtos
        /// <summary>
        /// Metodo que lista todos produtos cadasrados
        /// </summary>
        static void ListandoProd () {
            foreach (Produtos item in produto) {
                if (item == null) {
                    break;
                } else {
                    System.Console.WriteLine ($"Id: {item.Id}\n Nome: {item.Nome}\n Descrição: {item.Descricao}\nPreço: {item.Preco}\nCategoria: {item.Categoria}\nData criada: {item.DataCriacao}");
                }
            }
        }
        #endregion

        #region Exibir Preço Total (Produtos)
        static void ExibirPrecoTotal () {
            double soma = 0;
            foreach (Produtos item in produto) {
                if (item == null)
                {
                    break;
                } else {
                    soma += item.Preco;
                }
            }

            System.Console.WriteLine($"Preço total dos produtos cadastrados: {soma.ToString("C")}");
        }
        #endregion
    }
}