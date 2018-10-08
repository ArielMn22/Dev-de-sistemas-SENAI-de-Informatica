using System;
using Senai.Metodos.Exemplo1.Classes;

namespace Senai.Metodos.Exemplo1 {
    class Program {
        static void Main (string[] args) {
            Carro carro1 = new Carro ();

            carro1.CapacidadeTanque = 45;
            carro1.KilometroPorLitro = 14;
            // carro1.NivelTanque = 3000; // Não é possivel realizar esta atribuicao pois o atribute NivelTanque se tornou uma propriedade e esta em 'private'.

            carro1.Abastecer (30);
            carro1.Abastecer (30);
            carro1.Abastecer (30);

            carro1.Ligar ();
            System.Console.WriteLine (carro1.Ligado);
            carro1.Andar (120);
            carro1.Andar (260);
            carro1.Andar (80);
            carro1.Andar (1);
            carro1.Andar (400);
            System.Console.WriteLine (carro1.NivelTanque);
            System.Console.WriteLine ($"Odometro: {carro1.Odometro}");
            float resultado = carro1.PorcentagemNivelTanque ();
            System.Console.WriteLine ($"Porcentagem do tanque: {resultado.ToString("P")}");
        }
    }
}