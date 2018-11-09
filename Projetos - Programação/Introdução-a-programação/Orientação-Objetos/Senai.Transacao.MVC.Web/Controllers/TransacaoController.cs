using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Senai.Transacao.MVC.Web.Model;

namespace Senai.Transacao.MVC.Web.Controllers
{
    public class TransacaoController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar() => View();

        [HttpPost]
        public ActionResult Cadastrar(IFormCollection form)
        {
            TransacaoModel transacaoModel = new TransacaoModel();

            transacaoModel.Tipo = form["tipo"];
            transacaoModel.Descricao = form["descricao"];
            transacaoModel.Valor = Double.Parse(form["valor"]);
            transacaoModel.DataCriacao = DateTime.Parse(form["dataCriacao"]);

            using(StreamWriter sw = new StreamWriter("transacoes.csv"))
            {
                sw.WriteLine($"{transacaoModel.DataCriacao};{transacaoModel.Descricao};{transacaoModel.Tipo};{transacaoModel.Valor}");
            }

            @ViewBag.Mensagem = "Transação cadastrada com sucesso!";

            return View();
        }
    }
}