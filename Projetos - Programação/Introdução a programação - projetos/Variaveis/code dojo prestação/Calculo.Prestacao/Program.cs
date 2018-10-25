using System;
using Calculo.Prestacao.classe;

namespace Calculo.Prestacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Juros prod = new Juros();
            
            Console.Clear();
            //Recebendo o nome do produto;
            Console.WriteLine("Insira o nome do produto:");
            prod.nome = Console.ReadLine();

            //Recebendo o valor do produto;
            Console.WriteLine("Insira o valor do produto (reais R$):");
            prod.vReal = float.Parse(Console.ReadLine());

            //Recebendo a quantidade de prestações;
            Console.WriteLine("Insira a quantidade de prestações:");
            prod.qPrestacao = Convert.ToInt32(Console.ReadLine());

            // Processamento

            prod.vPrestacao = prod.vReal / prod.qPrestacao; //Valor da prestação

            prod.vAcrescimo = (float) (prod.vPrestacao * (0.05 * (prod.qPrestacao - 1))); //Valor do acréscimo

            prod.vMensal = prod.vPrestacao + prod.vAcrescimo; //Valor a ser pago mensalmente (valor da prestação + acréscimo)

            prod.vTotal = prod.vMensal * prod.qPrestacao; //Valor total a ser pago;

            //Saída
            Console.WriteLine($"nome do preoduto {prod.nome}");
            Console.WriteLine($"valor real {prod.vReal}");
            Console.WriteLine($"Valor real de cada prestação (sem acréscimo): {(prod.vReal/prod.qPrestacao)};
            Console.WriteLine($"Valor do acréscimo:{prod.vAcrescimo}");
            Console.WriteLine($"Valor de cada mensalidade (acréscimo incluído): {prod.vMensal}");
            Console.WriteLine($"Total a ser pago: {prod.vTotal}");

        }
    }
}
