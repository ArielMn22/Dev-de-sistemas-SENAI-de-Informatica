using System;
using Pizzaria.Backend.classes;

namespace Pizzaria.Backend {
    class Program {
        static Usuario[] usuario = new Usuario[500]; // Declarando Array;
        static Produtos[] produto = new Produtos[300]; // Declarando Array;
        static UsuarioControl MetodoUser = new UsuarioControl (); //Declarando e Instanciando Objeto;
        static ProdutoControl MetodoProd = new ProdutoControl (); //Declarando e Instanciando Objeto;
        static string opcao;
        static int IdPL = 0, IdPS = 0;
        static int cUser = 0; // Contador da quantidade de usuarios cadastrados
        static int cProd = 0; // Contador da quantidade de produtos cadastrados
        static void Main (string[] args) {
            do {
                MenuInicio ();
                System.Console.Write ("Insira uma opção: ");
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
                                    System.Console.Write ("Insira uma opção: ");
                                    opcao = Console.ReadLine ();

                                    switch (opcao) {
                                        case "1":
                                            {
                                                CadastroProduto ();
                                                Pausa ();

                                                break;
                                            }
                                        case "2":
                                            {
                                                ListandoProd ();
                                                Pausa ();

                                                break;
                                            }
                                        case "3":
                                            {
                                                System.Console.WriteLine ($"Preço total dos produtos cadastrados: {MetodoProd.ExibirPrecoTotal(produto)}");
                                                Pausa ();

                                                break;
                                            }
                                        case "4":
                                            {
                                                int[] precos = MetodoProd.DiferençaPreco (produto);
                                                System.Console.WriteLine ($"Produto de menor preço:\nId: {produto[precos[0]].Id}\nNome: {produto[precos[0]].Nome}\nPreço: {produto[precos[0]].Preco}\nDescrição: {produto[precos[0]].Descricao}\nCategoria: {produto[precos[0]].Categoria}\nData criada: {produto[precos[0]].DataCriacao}");
                                                System.Console.WriteLine ("-------------------------------------------------");
                                                System.Console.WriteLine ($"Produto de maior preço:\nId: {produto[precos[1]].Id}\nNome: {produto[precos[1]].Nome}\nPreço: {produto[precos[1]].Preco}\nDescrição: {produto[precos[1]].Descricao}\nCategoria: {produto[precos[1]].Categoria}\nData criada: {produto[precos[1]].DataCriacao}");
                                                Pausa ();
                                                break;
                                            }
                                        case "5":
                                            {
                                                AumentarPreco ();
                                                break;
                                            }
                                        case "0":
                                            {
                                                //Sai do loop
                                                break;
                                            }
                                        default:
                                            {
                                                System.Console.WriteLine ("##### Opção invalida #####");
                                                Pausa ();

                                                break;
                                            }
                                    }
                                } while (opcao != "0");
                                opcao = null;
                            } else {
                                System.Console.WriteLine ("E-mail ou senha incorreto.");
                            }

                            break;
                        }

                    case "3":
                        {
                            ListandoUser ();
                            break;
                        }

                    case "0":
                        {
                            // Sai do programa
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine ("##### Opção invalida #####");
                            break;
                        }
                }
                Pausa ();
            } while (opcao != "0");
        }

        #region Menu de opções inicial
        static void MenuInicio () {
            Console.Clear ();

            System.Console.WriteLine (@"
                   Gerenciador de Usuários
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
                    System.Console.WriteLine ($"\nId: {item.Id}\nNome: {item.Nome}\nEmail: {item.Email}\nData criada: {item.DataCriacao}");
                    System.Console.WriteLine ("------------------------------------------");
                }
            }
        }
        #endregion

        #region Menu de pizza
        static void MenuPizza () {
            Console.Clear ();

            System.Console.WriteLine ($@"
                     Pizzaria
            ----------------------------
            1 - Cadastrar produto
            2 - Listar todos os produtos
            3 - Valor total dos produtos
            4 - Produtos de maior e menor preço
            5 - Aumentar Preço
            0 - sair
            ----------------------------");
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
            produto[cProd].Preco = double.Parse (Console.ReadLine ());

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
            } while (categoria != "1" && categoria != "2");

            produto[cProd].Id = cProd + 1;
            produto[cProd].DataCriacao = DateTime.Now;
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
                    System.Console.WriteLine ($"\nId: {item.Id}\nNome: {item.Nome}\nDescrição: {item.Descricao}\nPreço: {item.Preco}\nCategoria: {item.Categoria}\nData criada: {item.DataCriacao}");
                    System.Console.WriteLine ("------------------------------------------");
                }
            }
        }
        #endregion

        #region AumentarPreco
        static void AumentarPreco () {

            foreach (Produtos item in produto) {
                if (item == null) {
                    break;
                } else {
                    System.Console.WriteLine ($"\nId: {item.Id}\nNome: {item.Nome}\nPreço: {item.Preco}");
                    System.Console.WriteLine ("------------------------------------------");
                }
            }

            int userID = 0;

            do {
                System.Console.WriteLine ("Insira o ID do produto que deseja aumentar o preço:");
                userID = int.Parse (Console.ReadLine ());

                if (userID < 0 || produto[userID - 1] == null) {
                    System.Console.WriteLine ("Insira um índice válido.");
                }

            } while (userID < 0 && produto[userID - 1] == null);

            System.Console.WriteLine ("Insira a quantidade que deseja aumentar:");
            float valor = float.Parse (Console.ReadLine ());

            produto[userID - 1].AumentarPreco (valor);

            System.Console.WriteLine ("Preço aumentado com sucesso!");
            Pausa ();
        }
        #endregion

        #region Pausa
        static void Pausa () {
            System.Console.WriteLine ("Aperte [QUALQUER] tecla para continuar...");
            Console.ReadKey ();
        }
        #endregion

    }
}