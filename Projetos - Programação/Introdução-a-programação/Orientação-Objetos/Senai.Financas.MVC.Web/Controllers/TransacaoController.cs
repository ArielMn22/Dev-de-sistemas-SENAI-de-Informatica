using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Financas.MVC.Web.Models;

namespace Senai.Financas.MVC.Web.Controllers {
    public class TransacaoController : Controller {
        [HttpGet] // Retorna a tela para que o usuário preencha com os dados
        public IActionResult Cadastrar () {

            if (string.IsNullOrEmpty(HttpContext.Session.GetString("idUsuario")))
            {
                return RedirectToAction("Login", "Usuario");
            }
            return View ();
        }

        [HttpPost] // Recebe as informações do usuário
        public IActionResult Cadastrar (IFormCollection form) {
            TransacaoModel transacaoModel = new TransacaoModel ();
            
            transacaoModel.Id = 1;
            transacaoModel.Descricao = form["descricao"];
            transacaoModel.Valor = decimal.Parse (form["valor"]);
            transacaoModel.Tipo = form["tipo"];
            transacaoModel.DataTransacao = DateTime.Parse (form["data"]);

            using (StreamWriter sw = new StreamWriter ("transacoes.csv")) {
                sw.WriteLine ($"{transacaoModel.Id};{transacaoModel.Descricao};{transacaoModel.Valor};{transacaoModel.Tipo};{transacaoModel.DataTransacao};");
            }

            ViewBag.Mensagem = "Transação cadastrada com sucesso!";

            return View ();
        }
    }
}