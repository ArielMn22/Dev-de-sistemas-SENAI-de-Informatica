namespace Senai.OO.Pizzaria.MVC.ViewModels
{
    /// <summary>
    /// Classe que representa a entidade 'produto'
    /// Herda a classe 'BaseViewModel'
    /// </summary>
    public class ProdutoViewModel : BaseViewModel
    {
        /// <summary>
        /// Descricao do produto.
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Preco do produto.
        /// </summary>
        public float Preco { get; set; }
        /// <summary>
        /// Categoria do produto.
        /// </summary>
        /// <value></value>
        public string Categoria { get; set; }
    }
}