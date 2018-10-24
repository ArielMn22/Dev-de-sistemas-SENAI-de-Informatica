using System;

namespace Pizzaria.Backend.classes {
    public class Produtos {
        #region Propriedades
        public int Id;
        public string Nome;
        public string Descricao;
        public double Preco;
        public string Categoria;
        public DateTime DataCriacao;
        #endregion

        #region Metodos
        public void AumentarPreco(float quantidade)
        {
            Preco += quantidade;
        }
        #endregion
    }
}