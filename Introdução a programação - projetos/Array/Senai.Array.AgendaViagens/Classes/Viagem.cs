using System;
    /// <summary>
    /// Comentários precisam ser adicionados!
    /// </summary>
namespace Senai.Array.AgendaViagens.Classes {
    public class Viagem {
        #region Propriedades
        public int NumeroVoo { get; set; }
        public string NomePassageiro { get; set; }
        public DateTime DataVoo { get; set; }
        #endregion

        #region Metodos
        public void Zerar()
        {
            NomePassageiro = "Não Reservado";
            NumeroVoo = 000000;
            DataVoo = DateTime.Parse("11/11/1111");
        }

        public void Agendar () {
            System.Console.WriteLine ("Insira seu nome:");
            NomePassageiro = Console.ReadLine ();

            System.Console.WriteLine ("\nInsira o número do vôo:");
            NumeroVoo = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("\nInsira a data do vôo:");
            try {
                DataVoo = DateTime.Parse (Console.ReadLine ());
            } catch (System.FormatException) {
                System.Console.WriteLine ("Data falhou!");
            }
        }

        public string Exibir () {
            return $"\nNome: {NomePassageiro}\nNúmero da viagem: {NumeroVoo}\nData da viagem: {DataVoo.ToShortDateString()}\n";
        }
        #endregion
    }
}