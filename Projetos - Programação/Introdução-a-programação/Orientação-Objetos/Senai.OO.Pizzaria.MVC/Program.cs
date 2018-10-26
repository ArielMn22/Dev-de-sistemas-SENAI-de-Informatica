using System;
using Senai.OO.Pizzaria.MVC.Repositorio;
using Senai.OO.Pizzaria.MVC.Util;
using Senai.OO.Pizzaria.MVC.ViewControllers;
using Senai.OO.Pizzaria.MVC.ViewModels;

namespace Senai.OO.Pizzaria.MVC {
    class Program {
        static void Main (string[] args) {
            // UsuarioViewsController.CadastrarUsuario();

            int opcaoDeslogado = 0, opcaoLogado = 0;

            do {
                MenuUtil.MenuDeslogado ();

                opcaoDeslogado = int.Parse (Console.ReadLine ());

                switch (opcaoDeslogado) {
                    case 1:
                        {
                            UsuarioViewsController.CadastrarUsuario ();
                            break;
                        }

                    case 2:
                        {
                            // Vai para a tela de login e retorna o usuário válido
                            UsuarioViewModel usuarioViewModel = UsuarioViewsController.Logar ();

                            if (usuarioViewModel != null) {
                                System.Console.WriteLine ("Seja bem-vindo " + usuarioViewModel.Nome);

                                do {
                                    // Mostra o menu logado
                                    MenuUtil.MenuLogado ();
                                    // Aguarda opção do usuário
                                    opcaoLogado = int.Parse (Console.ReadLine ());

                                    // Vai para a opção do usuário
                                    switch (opcaoLogado) {
                                        case 0:
                                            System.Console.WriteLine ("Tchau!");
                                            break;

                                        case 1:
                                            ProdutoViewController.CadastrarProduto ();
                                            break;

                                        case 2:
                                            ProdutoViewController.ListarProdutos ();
                                            break;
                                        case 3:
                                            break;

                                        default:
                                            System.Console.WriteLine ("Opção Inválida!");
                                            break;
                                    }
                                    // Verifica se o usuário irá continuar no loop.
                                } while (opcaoLogado != 0);
                            }

                            break;
                        }

                    case 3:
                        {
                            UsuarioViewsController.Listar ();
                            break;
                        }

                    case 0:
                        {
                            System.Console.WriteLine ("Tchau!");
                            break;
                        }

                    default:
                        {
                            System.Console.WriteLine ("Opção inválida!");
                            break;
                        }
                }
            } while (opcaoDeslogado != 0);
        }
    }
}