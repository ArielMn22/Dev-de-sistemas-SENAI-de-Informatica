using System;
using Senai.OO.Pizzaria.MVC.Util;
using Senai.OO.Pizzaria.MVC.ViewModels;
using Senai.OO.Pizzaria.MVC.Repositorio;
using System.Collections.Generic;

namespace Senai.OO.Pizzaria.MVC.ViewControllers {
    public class UsuarioViewsController {
        /// <summary>
        /// Tela de cadastro de usuário
        /// </summary>
        public static void CadastrarUsuario () {
            string email, nome, senha;

            //Nome
            do {
                System.Console.WriteLine ("Informe seu nome:");
                nome = Console.ReadLine ();

                if (string.IsNullOrEmpty (nome)) {
                    System.Console.WriteLine ("Nome inválido!");
                }
            } while (string.IsNullOrEmpty (nome));

            //Email
            do {
                System.Console.WriteLine ("Insira seu email:");
                email = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarEmail (email))
                    System.Console.WriteLine ("Email inválido!");

            } while (!ValidacaoUtil.ValidarEmail (email));

            //Senha
            do {
                System.Console.WriteLine ("Insira sua senha:");
                senha = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarSenha (senha))
                    System.Console.WriteLine ("Senha Inválida!");
            } while (!ValidacaoUtil.ValidarSenha (senha));
        
            #region Controller
                // Cria um objeto do tipo UsuarioRepositorio
                UsuarioViewModel usuarioViewModel = new UsuarioViewModel();

                // Atribui os valores as propriedades;
                usuarioViewModel.Nome = nome;
                usuarioViewModel.Email = email;
                usuarioViewModel.Senha = senha;

                // Cria um objeto do tipo UsuarioRepositorio
                UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

                // Inseri o usuário a List
                usuarioRepositorio.Inserir(usuarioViewModel);
            #endregion
        }

        public static void Listar()
        {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

            List<UsuarioViewModel> lsUsuarios = UsuarioRepositorio.Listar();

            foreach (UsuarioViewModel item in lsUsuarios)
            {
                System.Console.WriteLine($"- {item.Id} {item.Nome} {item.Email}");
            }
        }

        public static UsuarioViewModel Logar()
        {
            string email, senha;

            #region Validar Email
            do {
                System.Console.WriteLine ("Insira seu email:");
                email = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarEmail (email))
                    System.Console.WriteLine ("Email inválido!");

            } while (!ValidacaoUtil.ValidarEmail (email));
            #endregion

            #region Validar Senha
            do {
                System.Console.WriteLine ("Insira sua senha:");
                senha = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarSenha (senha))
                    System.Console.WriteLine ("Senha Inválida!");
            } while (!ValidacaoUtil.ValidarSenha (senha));
            #endregion

            #region Controller
            //Cria objeto do tipo UsuarioRepositorio
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

            //Cria objeto do tipo UsuarioViewsModel
            UsuarioViewModel usuario = usuarioRepositorio.Login(email, senha);

            //Verifica se o e-mail e senha estão corretos
            if (usuario != null)
            {
                // Retorna o usuário
                return usuario;
            } else {
                // Se não existir mostra a mensagem e retorna null
                System.Console.WriteLine("E-mail ou senha inválidos!");
                return null;
            }
            #endregion
        }
    }
}