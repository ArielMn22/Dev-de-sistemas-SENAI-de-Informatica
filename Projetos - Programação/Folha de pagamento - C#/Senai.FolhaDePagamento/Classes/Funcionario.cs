namespace Senai.FolhaDePagamento.Classes
{
    public class Funcionario
    {
        #region Propriedades    
        public string Nome { get; set; }
        public double Salario { get; set; }
        /// <summary>
        /// Deverá ser configurado a partir do Program.cs
        /// </summary>
        /// <value>Valor do Salário Minimo (R$, reais)</value>
        public double SalarioMinimo {get; set;} = 834.5;
        #endregion

        #region Metodos
        public double INSS() => Salario * 0.11;
        public double IRFF() => Salario * 0.075;
        public double ValeTransporte() => Salario * 0.06;
        public double SalarioDescontado() => Salario - (INSS() + IRFF() + ValeTransporte());
        public void AumentarSalario()
        {
            if (Salario <= (2 * SalarioMinimo))
            {
                Salario *= 1.15;
            } else if (Salario <= (4 * SalarioMinimo))
            {
                Salario *= 1.10;
            } else if (Salario <= (8*SalarioMinimo))
            {
                Salario *= 1.08;
            } else {
                Salario *= 1.05;
            }
        }
        #endregion
    }
}