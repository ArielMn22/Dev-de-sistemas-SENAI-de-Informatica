using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Tarefas.MVC.Web.Models;
using Senai.Tarefas.MVC.Web.Repositorio;
using Senai.Tarefas.MVC.Web.Validacao;

namespace Senai.Tarefas.MVC.Web.Controllers {
    public class UsuarioController : Controller {
        [HttpGet]
        public IActionResult Cadastrar () {
            return View ();
        }

        [HttpPost]
        public IActionResult Cadastrar (IFormCollection form) {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
            ValidacaoUtil validacaoUtil = new ValidacaoUtil ();

            List<UsuarioModel> lsUsuarios = usuarioRepositorio.ListarUsuarios ();

            UsuarioModel usuarioModel = new UsuarioModel {
                ID = lsUsuarios.Count + 1,
                Nome = form["nome"],
                Email = form["email"],
                Senha = form["senha"],
                Tipo = form["tipo"],
                DataCriacao = DateTime.Now
            };

            switch (validacaoUtil.ValidarUsuario (usuarioModel)) {
                case 0:
                    if (!System.IO.File.Exists ("usuarios.csv")) {
                        using (System.IO.File.Create ("usuarios.csv")) { };
                    } else {
                        using (StreamWriter sw = new StreamWriter ("usuarios.csv", true)) {
                            sw.WriteLine ($"{usuarioModel.ID};{usuarioModel.Nome};{usuarioModel.Email};{usuarioModel.Senha};{usuarioModel.Tipo};{usuarioModel.DataCriacao}");
                        }
                    }
                    
                    @ViewBag.Logado = "1";
                    @ViewBag.Mensagem = "Usuário Cadastrado com sucesso!";
                    break;

                case 1:
                    @ViewBag.Mensagem = "O nome não pode estar vazio.";
                    break;

                case 2:
                    @ViewBag.Mensagem = "Email incorreto, o mesmo deve possuir '@' e '.'";
                    break;

                case 3:
                    @ViewBag.Mensagem = "A senha deve ter pelo 6 caractéres.";
                    break;

                case 4:
                    @ViewBag.Mensagem = "O usuário deve possuir um tipo!";
                    break;

                case 5:
                    @ViewBag.Mensagem = $"O e-mail {usuarioModel.Email} já está cadastrado em nosso sistema.";
                break;
            }

            return View ();
        }

        [HttpGet]
        public IActionResult Login () {
            return View ();
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            UsuarioModel usuarioModel = new UsuarioModel {
                Email = form["email"],
                Senha = form["senha"]
            };

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();

            UsuarioModel usuario = usuarioRepositorio.BuscarUsuario (usuarioModel.Email, usuarioModel.Senha);

            if (usuario != null) {
                HttpContext.Session.SetString ("idUsuario", usuario.ID.ToString ());

                @ViewBag.Mensagem = "Login realizado com sucesso!";

                return RedirectToAction ("Cadastrar", "Tarefa");
            } else {
                @ViewBag.Mensagem = "Acesso negado!";
            }

            return View ();
        }
    }
}