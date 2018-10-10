namespace Senai.Metodos.Exercício6.Classes
{
    public class ContaBancaria
    {
        #region Propriedades
        public string Nome {get; set;}
        public string CPF {get; set;}
        public double Saldo {get; private set;}    
        #endregion

        #region Metodos
        public void Sacar(double qnt)
        {
            if(qnt > Saldo)
            {
                System.Console.WriteLine("Você não pode sacar um valor maior do que seu saldo...");
            } else {
                Saldo = (double) (Saldo - qnt);
            }
        }

        public void Depositar(double qnt)
        {
            Saldo = (double) (Saldo + qnt);
        }

        public double Mostrar() => Saldo;
        #endregion
    }
}