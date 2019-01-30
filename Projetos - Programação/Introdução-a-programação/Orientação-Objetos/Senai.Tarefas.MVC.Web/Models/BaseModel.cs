using System;

namespace Senai.Tarefas.MVC.Web.Models
{
    public class BaseModel
    {
        public int ID { get; set; }
        public string  Nome { get; set; }
        public string Tipo { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}