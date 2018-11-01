using System;
using System.IO;
using System.Collections.Generic;
using Senai.MVC.Pizzaria.Models;

namespace Senai.MVC.Pizzaria.ViewsControllers {
    public class UsuarioViewControlles {
        static int contador = 1;
        public void Cadastrar () {
            #region View
            System.Console.WriteLine ("Informe o seu nome:");
            string nome = Console.ReadLine ();

            System.Console.WriteLine ("Informe o seu e-mail:");
            string email = Console.ReadLine ();

            System.Console.WriteLine ("Informe sua senha:");
            string senha = Console.ReadLine ();
            #endregion

            #region Controller
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel ();
            List<UsuarioViewModel> lsusuarios = ListarUsuarios();

            usuarioViewModel.ID = lsusuarios.Count + 1;
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;
            usuarioViewModel.DataCriacao = DateTime.Now;

            using (StreamWriter sw = new StreamWriter ("usuarios.csv", true)) {
                sw.WriteLine ($"{usuarioViewModel.ID};{usuarioViewModel.Nome};{usuarioViewModel.Email};{usuarioViewModel.Senha};{usuarioViewModel.DataCriacao}");
            }

            System.Console.WriteLine ("Usuário cadastrado com sucesso!");
            contador++;
            #endregion
        }

        public void Logar () {
            #region View
            System.Console.WriteLine ("Informe seu e-mail:");
            string email = Console.ReadLine ();

            System.Console.WriteLine ("Informe sua senha:");
            string senha = Console.ReadLine ();
            #endregion

            #region Controller
            List<UsuarioViewModel> lsusuarios = ListarUsuarios();

            foreach(UsuarioViewModel item in lsusuarios)
            {
                if (item.Email == email && item.Senha == senha) {
                    System.Console.WriteLine ("Acesso liberado!");
                    break;
                }
            }
        
            #endregion
        }

        public void Listar()
        {
            #region Controller
            List<UsuarioViewModel> lsusuarios = ListarUsuarios();
            #endregion

            #region View
                foreach(UsuarioViewModel item in lsusuarios)
                {
                    System.Console.WriteLine($"{item.ID} - {item.Nome} - {item.Email} - {item.DataCriacao}");
                }
            #endregion
        }

        private List<UsuarioViewModel> ListarUsuarios()
        {
            #region Controller
            List<UsuarioViewModel> lsusuarios = new List<UsuarioViewModel>();

            UsuarioViewModel usuario;

            string[] linhas = File.ReadAllLines("usuarios.csv");

            foreach(string item in linhas)
            {
                string[] dados = item.Split(';');
                usuario = new UsuarioViewModel();
                usuario.ID = int.Parse(dados[0]);
                usuario.Nome = dados[1];
                usuario.Email = dados[2];
                usuario.Senha = dados[3];
                usuario.DataCriacao = DateTime.Parse(dados[4]);

                lsusuarios.Add(usuario);
            }
            #endregion

            return lsusuarios;
        }
    }
}