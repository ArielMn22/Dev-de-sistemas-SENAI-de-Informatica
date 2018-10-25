namespace Senai.Metodos.Exemplo1.Classes {
    /// <summary>
    /// Calcula a quantidade de Kilometros por Litro do que o carro percorre.
    /// </summary>
    public class Carro {
        #region Atributos
            public float KilometroPorLitro;
            public int CapacidadeTanque;
            public float NivelTanque {get; private set;}
            public bool Ligado;
            public float Odometro {get; private set;}
        #endregion

        #region Metodos
            /// <summary>
            /// Ligar o carro, altera o valor da variável bool 'Ligado' para 'true'.
            /// </summary>
            public void Ligar()
            {
                Ligado = true;
                System.Console.WriteLine("Carro ligado!");
            }
            
            /// <summary>
            /// Abastece o carro, mudando o atributo, NivelTanque.
            /// </summary>
            /// <param name="quantidade">Quantidade de litros para abastecer.</param>
            public void Abastecer(float quantidade)
            {
                if (NivelTanque + quantidade <= CapacidadeTanque)
                {
                    NivelTanque += quantidade;
                } else {
                    System.Console.WriteLine("Tanque cheio!");
                }
            }

            public void Andar(float kilometragem)
            {
                if (Ligado)
                {
                    float consumo = kilometragem/KilometroPorLitro;
                    System.Console.WriteLine("Carro vai consumir " + consumo + " litros.");

                    //Verifica se o tanque possui combustível suficiente para completar a viagem;
                    if (NivelTanque >= consumo)
                    {
                        Odometro += kilometragem; //Sobe o odometro conforme o km rodado;
                        NivelTanque -= consumo;
                    } else {
                        System.Console.WriteLine("Carro não possui combustível suficiente...");
                    }

                } else {
                    System.Console.WriteLine("Ligue o carro antes de andar.");
                }
            }

            public float PorcentagemNivelTanque()
            {
                float porcentagem = NivelTanque / CapacidadeTanque;

                return porcentagem;
            }
        #endregion
    }
}