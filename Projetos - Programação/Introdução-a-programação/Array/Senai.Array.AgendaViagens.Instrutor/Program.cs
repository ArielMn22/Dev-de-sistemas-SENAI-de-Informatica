using System;

namespace Senai.Array.AgendaViagens.Correção
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bem-vindo ao Tsukamoto Airlines");

            int resposta;
            int[] numeroPassagem = new int[3];
            string nomePassagem = new string[3];
            DateTime[] dataVoo = new DateTime[3];

            do{
                System.Console.WriteLine("----------------Digite uma opção-----------------");
                System.Console.WriteLine("1 - Agendar Viagem");
                System.Console.WriteLine("2 - Exibir Viagens");
                System.Console.WriteLine("0 - Sair");

                resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:
                    {

                        break;
                    }

                    case 2:
                    {
                        
                        break;
                    }

                    case 0:
                    {
                        break;
                    }
                    default:
                }
            } while (false); //Necessita ser arrumada
        }
    }
}
