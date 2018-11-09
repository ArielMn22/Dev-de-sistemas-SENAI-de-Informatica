using System;

namespace Senai.Transacao.MVC.Web.Model
{
    public class TransacaoModel
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string Tipo { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}