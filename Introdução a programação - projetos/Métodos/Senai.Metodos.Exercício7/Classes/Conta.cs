namespace Senai.Metodos.Exercício7.Classes {
    public class Conta {
        #region Propriedades
        public string Nome { get; set; }
        public string Email { get; set; }

        public string Senha { get; set; }
        #endregion

        #region Metodos
        public bool Login () {
            if (Email.Contains ("@")) {
                if (Email == "senai@sp.senai.br" && Senha == "1234") {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }
        #endregion
    }
}