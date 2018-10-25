namespace Senai.Array.CadastroProdutos.Classes
{
    public class Produto
    {
        #region Propriedades
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        #endregion

        #region Metodos
        public void AumentarValor(float porcent)
        {
            Valor += (Valor * (porcent/100));
        }
        #endregion
    }
}