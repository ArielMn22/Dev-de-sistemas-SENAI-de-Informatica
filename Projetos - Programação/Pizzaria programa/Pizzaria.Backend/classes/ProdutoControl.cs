namespace Pizzaria.Backend.classes
{
    public class ProdutoControl
    {
        
        public double ExibirPrecoTotal (Produtos[] produto) {
            double soma = 0;
            foreach (Produtos item in produto) {
                if (item == null) {
                    break;
                } else {
                    soma += item.Preco;
                }
            }

        return soma;
        }

        #region Menor e maior preço de produto
        public int[] DiferençaPreco (Produtos[] produto) {
            int[] retorno = new int[2];
            double PrecoMaior = -10000000, PrecoMenor = 100000000;
            foreach (Produtos item in produto) {
                if (item == null) {
                    break;
                } else {

                    if (item.Preco < PrecoMenor) {
                        PrecoMenor = item.Preco;
                        retorno[0] = (item.Id - 1);
                        
                    }
                    if (item.Preco > PrecoMaior) {
                        PrecoMaior = item.Preco;
                        retorno[1] = (item.Id - 1);
                    }
                }
            }

            return retorno;
        }
        #endregion
    }

    
}