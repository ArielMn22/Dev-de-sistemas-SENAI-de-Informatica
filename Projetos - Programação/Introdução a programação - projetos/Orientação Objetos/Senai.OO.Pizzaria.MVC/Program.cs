using System;
using Senai.OO.Pizzaria.MVC.Util;
using Senai.OO.Pizzaria.MVC.ViewModels;
using Senai.OO.Pizzaria.MVC.ViewControllers;
using Senai.OO.Pizzaria.MVC.Repositorio;

namespace Senai.OO.Pizzaria.MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            // UsuarioViewsController.CadastrarUsuario();

            int opcaoDeslogado = 0;

            do{
                MenuUtil.MenuDeslogado();

                opcaoDeslogado = int.Parse(Console.ReadLine());

                switch (opcaoDeslogado)
                {
                    case 1:
                    {
                        UsuarioViewsController.CadastrarUsuario();
                        break;
                    }

                    case 3:
                    {
                        UsuarioViewModel.Listar();
                        break;
                    }

                    case 0:
                    {
                        System.Console.WriteLine("Tchau!");
                        break;
                    }

                    default:
                    {
                        System.Console.WriteLine("Opção inválida!");
                        break;
                    }
                }
            } while (opcaoDeslogado != 0);
        }
    }
}
