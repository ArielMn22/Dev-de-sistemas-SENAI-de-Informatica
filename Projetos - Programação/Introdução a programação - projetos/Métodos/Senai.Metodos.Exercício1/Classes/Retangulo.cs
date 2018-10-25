namespace Senai.Metodos.Exercício1.Classes {
    public class Retangulo {
        #region Atributos
        public float LadoA;
        public float LadoB;
        #endregion

        #region Metodos
        /// <summary>
        /// Calcula a area do retangulo.
        /// </summary>
        /// <returns></returns>
        public float Area() => LadoA * LadoB; //Utilizando expressão em Lambda, vem do javascript;

        /// <summary>
        /// Calcula o perimetro do retangulo.
        /// </summary>
        /// <returns></returns>
        public float Perimetro() => (2*LadoA) + (2*LadoB);

        #endregion

    }
}