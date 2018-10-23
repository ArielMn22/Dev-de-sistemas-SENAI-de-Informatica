using Pizzaria.Backend.classes;

namespace Pizzaria.Backend.classes {
    public class UsuarioControl {
        #region Verificação para cadastro

        public int ReadEmail (string userEmail) {
            if (userEmail.Contains ('@') && userEmail.Contains ('.')) {
                return 0;
            } else {
                return 1;
            }
        }

        public int ReadSenha (string userSenha) {
            if (userSenha.Length >= 6) {
                return 0;
            } else {
                return 1;
            }
        }
        #endregion

        #region Verificação para login
        static bool logado = false;
        public bool Login (Usuario[] usuario, string email, string senha) {
            foreach (Usuario item in usuario) {
                if (item == null) {
                    break;
                } else {
                    if (item.Email == email && item.Senha == senha) {
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion
    }
}