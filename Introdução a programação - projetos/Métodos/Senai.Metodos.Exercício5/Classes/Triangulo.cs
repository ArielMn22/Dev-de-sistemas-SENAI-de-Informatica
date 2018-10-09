namespace Senai.Metodos.Exercício5.Classes
{
    public class Triangulo
    {
        #region Propriedades
        public float LadoA, LadoB, LadoC;
        #endregion

        public bool Valido()
        {
            if (LadoA < (LadoB+LadoC) && LadoB < (LadoA + LadoC) && LadoC < (LadoA + LadoB))
            {
                return true;
            } else {
                return false;
            }
        }

        public string Tipo()
        {
            if (LadoA == LadoB && LadoA == LadoC)
            {
                return "Equilátero";
            } else if (LadoA == LadoB || LadoA == LadoC || LadoB == LadoC)
            {
                return "Isósceles";
            } else {
                return "Escaleno";
            }
        }
    }
}