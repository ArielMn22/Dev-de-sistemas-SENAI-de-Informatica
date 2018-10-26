using System;

namespace Senai.OO.Pizzaria.MVC.ViewModels
{
    /// <summary>
    /// Classe que será herdada para outras classes
    /// Definida como 'abstract' para não poder ser instanciada
    /// </summary>
    public abstract class BaseViewModel
    {
        /// <summary>
        /// Id do objeto
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nome do objeto
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Data de criação do objeto
        /// </summary>
        public DateTime DataCriacao { get; set; }
    }
}