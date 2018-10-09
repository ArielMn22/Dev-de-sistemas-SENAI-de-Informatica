namespace Senai.Metodos.Exercício4.Classes
{
    /// <summary>
    /// Abre e fecha porta;
    /// </summary>
    public class Porta
    {
        public bool Status {get; set;}

        #region Metodos
        public void Abrir()
        {
            if (Status)
            {
                System.Console.WriteLine("A porta já está aberta...");
            } else {
                Status = true;
                System.Console.WriteLine("A porta abriu!");
            }
        }

        public void Fechar()
        {
            if (Status)
            {
                Status = false;
                System.Console.WriteLine("A porta fechou!");
            } else {
                System.Console.WriteLine("A porta já está fechada...");
            }
        }
        #endregion
    }
}