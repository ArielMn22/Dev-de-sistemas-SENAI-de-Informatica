using System.Collections.Generic;
using Senai.Tarefas.MVC.Web.Models;
using Senai.Tarefas.MVC.Web.Repositorio;

namespace Senai.Tarefas.MVC.Web.Validacao
{
    public class ValidacaoUtil
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>'0' = Usuário é válido;'1' = Nome está vazio;'2' = Email está incorreto;'3' = </returns>
        public int ValidarUsuario(UsuarioModel usuario)
        {
            if (string.IsNullOrEmpty(usuario.Nome))
            {
                return 1;
            }

            if (!usuario.Email.Contains('@') || !usuario.Email.Contains('.'))
            {
                return 2;
            }

            if (usuario.Senha.Length < 6 || string.IsNullOrEmpty(usuario.Senha))
            {
                return 3;
            }

            if (usuario.Tipo == "usuarioComum" || usuario.Tipo == "usuarioAdmin")
            {
                return 4;
            }

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            List<UsuarioModel> lsUsuarios = usuarioRepositorio.ListarUsuarios();

            foreach (UsuarioModel user in lsUsuarios)
            {
                if (usuario.Email == user.Email)
                    return 5;
            }

            return 0;
        }
    }
}