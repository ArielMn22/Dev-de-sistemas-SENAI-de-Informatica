namespace Senai.Metodos.Exercício2.Classes
{
    public class Calculadora
    {
        #region Metodos
        public float Soma(float Num1, float Num2)
        {
            return (float) (Num1 + Num2);
        }

        public float Subtrair(float Num1, float Num2)
        {
            return (float) (Num1 - Num2);
        }

        public float Multiplicacao(float Num1, float Num2)
        {
            return (float) (Num1 * Num2);
        }

        public float Divisao(float Num1, float Num2)
        {
            return (float) (Num1 / Num2);
        }
        #endregion
    }
}