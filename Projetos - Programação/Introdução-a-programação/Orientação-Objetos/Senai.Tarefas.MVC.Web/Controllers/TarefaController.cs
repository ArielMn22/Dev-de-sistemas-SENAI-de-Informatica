using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Senai.Tarefas.MVC.Web.Models;
using System.IO;
using Senai.Tarefas.MVC.Web.Repositorio;
using System.Collections.Generic;

namespace Senai.Tarefas.MVC.Web.Controllers
{
    public class TarefaController : Controller
    {
        [HttpGet]
        public IActionResult Cadastrar()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("idUsuario")))
            {
                return RedirectToAction("Login", "Usuario");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form)
        {
            TarefaRepositorio tarefaRepositorio = new TarefaRepositorio();

            List<TarefaModel> lsTarefas = tarefaRepositorio.ListarTarefas();

            TarefaModel tarefaModel = new TarefaModel
            {
                ID = lsTarefas.Count + 1,
                Nome = form["nome"],
                Descricao = form["descricao"],
                Tipo = form["tipo"],
                IdUsuario = HttpContext.Session.GetString("idUsuario"),
                DataCriacao = DateTime.Now
            };

            using (StreamWriter sw = new StreamWriter("tarefas.csv", true))
            {
                sw.WriteLine($"{tarefaModel.ID};{tarefaModel.Nome};{tarefaModel.Descricao};{tarefaModel.Tipo};{tarefaModel.IdUsuario};{tarefaModel.DataCriacao}");
            }

            @ViewBag.Mensagem = "Tarefa cadastrada com sucesso!";

            return View();
        }
    }
}