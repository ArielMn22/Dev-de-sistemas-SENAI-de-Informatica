using System;

namespace Pizzaria.Backend.classes
{
    public class Usuario
    {
        public int Id;
        public string Nome;
        public string Email;
        public string Senha;
        public DateTime DataCriacao;
        /// <summary>
        /// Terá o valor do ID do usuário que está logado
        /// </summary>
        public int LoggedId;
    }
}