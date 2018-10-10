using System;

namespace Senai.Array.AgendaViagens.Classes
{
    public class Viagem
    {
        #region Propriedades
        public int NumeroVoo {get; set;}
        public string NomePassageiro {get; set;}
        public DateTime DataVoo {get; set;}
        #endregion

        #region Metodos
        public void Agendar()
        {
            System.Console.WriteLine("Insira seu nome:");
            NomePassageiro = Console.ReadLine();
            
            System.Console.WriteLine("\nInsira o número do vôo:");
            NumeroVoo = int.Parse(Console.ReadLine());

            System.Console.WriteLine("\nInsira a data do vôo:");
            DataVoo = DateTime.Parse(Console.ReadLine());
        }

        public string Exibir()
        {
            return $"\nNome: {NomePassageiro}\nNúmero da viagem: {NumeroVoo}\nData da viagem: {DataVoo}\n";
        }
        #endregion
    }
}