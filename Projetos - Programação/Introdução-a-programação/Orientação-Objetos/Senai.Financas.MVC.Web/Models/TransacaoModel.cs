using System;

namespace Senai.Financas.MVC.Web.Models
{
    public class TransacaoModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Tipo { get; set; }
        public DateTime DataTransacao { get; set; }
    }
}