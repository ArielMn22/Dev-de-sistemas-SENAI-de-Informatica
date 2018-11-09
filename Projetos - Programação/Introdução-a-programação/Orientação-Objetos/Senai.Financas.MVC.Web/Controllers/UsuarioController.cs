using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Senai.Financas.MVC.Web.Models;

namespace Senai.Financas.MVC.Web.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(IFormCollection form)
        {
            UsuarioModel usuarioModel = new UsuarioModel();

            usuarioModel.Nome = form["nome"];
            usuarioModel.Email = form["email"];
            usuarioModel.DataNascimento = DateTime.Parse(form["dataNascimento"]);

            using(StreamWriter sw = new StreamWriter("usuarios.csv", true))
            {
                sw.WriteLine($"{usuarioModel.Nome};{usuarioModel.Email};{usuarioModel.DataNascimento}");
            }

            ViewBag.Mensagem = "Usuário cadastrado com sucesso!";
            return View();
        }
    }
}