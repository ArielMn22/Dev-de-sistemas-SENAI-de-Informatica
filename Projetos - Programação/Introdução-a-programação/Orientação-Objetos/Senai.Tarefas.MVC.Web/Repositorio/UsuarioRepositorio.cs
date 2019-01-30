using System;
using System.Collections.Generic;
using System.IO;
using Senai.Tarefas.MVC.Web.Models;

namespace Senai.Tarefas.MVC.Web.Repositorio
{
    public class UsuarioRepositorio
    {
        public List<UsuarioModel> ListarUsuarios()
        {
            if (!System.IO.File.Exists ("usuarios.csv")) {
                using (System.IO.File.Create ("usuarios.csv")) { };
            }
            
            string[] linhas = File.ReadAllLines("usuarios.csv");

            UsuarioModel usuarioModel;

            List<UsuarioModel> lsUsuarios = new List<UsuarioModel>();

            foreach(string linha in linhas)
            {
                string[] dados = linha.Split(';');
                
                usuarioModel = new UsuarioModel
                {
                    ID = int.Parse(dados[0]),
                    Nome = dados[1],
                    Email = dados[2],
                    Senha = dados[3],
                    Tipo = dados[4],
                    DataCriacao = DateTime.Parse(dados[5])
                };

                lsUsuarios.Add(usuarioModel);
            }

            return lsUsuarios;
        }

        public UsuarioModel BuscarUsuario(string email, string senha)
        {
            List<UsuarioModel> lsUsuarios = ListarUsuarios();

            foreach(UsuarioModel user in lsUsuarios)
            {
                if (email == user.Email && senha == user.Senha)
                {
                    return user;
                }
            }

            return null;
        }
    }
}