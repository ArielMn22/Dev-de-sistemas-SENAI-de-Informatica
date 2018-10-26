namespace Senai.OO.Pizzaria.MVC.Util {
    /// <summary>
    /// Classe responsável pelas validações no sistema
    /// </summary>
    public class ValidacaoUtil {
        /// <summary>
        /// Metodo responsável por validar o email.
        /// </summary>
        /// <param name="email">Email a ser verificado.</param>
        /// <returns>Retorna email válido ou email inválido.</returns>
        public static bool ValidarEmail (string email) {
            //Se o email recebido tiver '@' e '.'; Retorne true
            if (email.Contains ('@') && email.Contains ('.'))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Metodo responsável por validar a senha.
        /// </summary>
        /// <param name="senha">Senha a ser verificada.</param>
        /// <returns>Retorna senha válida inválida</returns>
        public static bool ValidarSenha (string senha) {
            if (senha.Length >= 6)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Metodo responsável por validar a categoria.
        /// </summary>
        /// <param name="categoria">Categoria a ser validada.</param>
        /// <returns>Retorna se é válida ou não.</returns>
        public static bool ValidarCategoria (string categoria) {
            if (categoria.ToLower () == "pizza" || categoria.ToLower () == "bebida")
                return true;
            else
                return false;
        }
    }
}