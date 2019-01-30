using System;

namespace Senai.Financas.Mvc.Web.Models
{
    [Serializable] // Atributo que define se a classe é serializada.
    public class UsuarioModel
    {
        public int ID { get; set; }

        public string Nome {get; set;}

        public string Email { get; set; }

        public string Senha { get; set; }

        public DateTime DataNascimento { get; set; }

        // public UsuarioModel() // Método contrutor padrão.
        // {
        // }

        public UsuarioModel(string email, string senha)
        {
            this.Email = email;
            this.Senha = senha;
        }

        public UsuarioModel(string nome, string email, string senha, DateTime data) // Método contrutor específico.
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataNascimento = data;
        }

        public UsuarioModel(int id, string nome, string email, string senha, DateTime data)
        {
            this.ID = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataNascimento = data;
        }

    }
}