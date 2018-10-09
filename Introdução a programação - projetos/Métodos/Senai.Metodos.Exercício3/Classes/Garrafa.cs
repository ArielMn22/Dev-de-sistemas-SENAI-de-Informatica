namespace Senai.Metodos.Exercício3.Classes
{
    public class Garrafa
    {
        public float Conteudo {get; private set;}

        #region Metodos
            /// <summary>
            /// Enche a garrafa com a quantidade informada nos parâmetros.
            /// </summary>
            /// <param name="qtd">Quantidade que será adicionada na garrafa.</param>
            public void Encher(float qtd)
            {
                Conteudo += qtd; // Conteudo = Conteudo + qtd;
            }

            /// <summary>
            /// Esvazia a garrafa com a quantidade informada no parâmetro.
            /// </summary>
            /// <param name="qtd">Quantidade que será esvaziada da garrafa.</param>
            public void Esvaziar(float qtd)
            {
                Conteudo -= qtd;
            }

            /// <summary>
            /// Retorna a quantidade do conteúdo da garrafa.
            /// </summary>
            /// <returns></returns>
            public float ExibirQuantia() => Conteudo;

        #endregion
    }
}