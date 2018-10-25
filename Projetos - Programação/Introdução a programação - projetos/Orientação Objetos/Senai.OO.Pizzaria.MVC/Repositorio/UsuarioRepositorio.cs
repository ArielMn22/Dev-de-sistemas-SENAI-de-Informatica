using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.MVC.ViewModels;
using Senai.OO.Pizzaria.MVC.ViewControllers;
using Senai.OO.Pizzaria.MVC.Util;
using Senai.OO.Pizzaria.MVC.Repositorio;

namespace Senai.OO.Pizzaria.MVC.Repositorio {
    /// <summary>
    /// Classe responsável pela leitura e gravação dos dados
    /// referentes ao usuário
    /// </summary>
    public class UsuarioRepositorio {
        //Criação do objeto List<UsuuarioViewModel> que faz parte do
        //namespace System.Collection.Generic
        static List<UsuarioViewModel> lsUsuarios = new List<UsuarioViewModel> ();

        /// <summary>
        /// Metodo para inserir um novo usuário
        /// </summary>
        /// <param name="usuario">Objeto UsuarioViewModel (nome, email, senha)</param>
        /// <returns>Retorna um UsuarioViewModel atualizado.</returns>
        public UsuarioViewModel Inserir (UsuarioViewModel usuario) {
            //Atribui um valor ao ID, verifica a quantiadde de itens na
            //lista e soma 1
            usuario.Id = lsUsuarios.Count + 1;
            //Adiciona a data e hora atual do sistema
            usuario.DataCriacao = DateTime.Now;
            //Adiciona o usuário a List
            lsUsuarios.Add (usuario);
            //Retorna o usuário
            return usuario;
        }

        /// <summary>
        /// Lista todos os usuário.
        /// </summary>
        /// <returns>Retorna um List.</returns>
        public static List<UsuarioViewModel> Listar () {
            return lsUsuarios;
        }

        /// <summary>
        /// Verifica se o usuário é válido
        /// </summary>
        /// <param name="email">Email do usuário.</param>
        /// <param name="senha">Senha do usuário.</param>
        /// <returns>Retorna um usuário caso seja válido e retorna 'null' caso seja inválido.</returns>
        public UsuarioViewModel Login (string email, string senha) {
            // Percorre a lista de usuários
            foreach (UsuarioViewModel item in lsUsuarios) {
                //Verifica se o item/objeto email e senha são iguais aos valores passados
                //por parâmetro
                if (item.Email == email && item.Senha == senha) {
                    // Retorna o item/UsuarioViewModel
                    return item;
                }
            }
            // Caso não encontre usuário retorna 'null'
            return null;
        }
    }
}