using System;
using Senai.MVC.Pizzaria.Models;
using Senai.MVC.Pizzaria.ViewsControllers;

namespace Senai.MVC.Pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioViewControlles usuarioViewControlles = new UsuarioViewControlles();

            usuarioViewControlles.Cadastrar();
            
            // usuarioViewControlles.Cadastrar();
            // usuarioViewControlles.Cadastrar();

            usuarioViewControlles.Listar();
        }
    }
}
