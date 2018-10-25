using System;

namespace Senai.While.Exercício1 {
    class Program {
        static void Main (string[] args) {
            int contador = 0; //Inicia o contador como 0;

            Console.Clear ();
            
            //Recebe o fator da tabuada
            System.Console.WriteLine ("Insira o fator da tabuada:");
            
            int fator = int.Parse (Console.ReadLine ());
            System.Console.WriteLine (); //Pula linha

            //Laço do contador da tabuada
            while (contador <= 10) {
                //Mostra o valor da tabuada;
                System.Console.WriteLine ($"{fator} * {contador} = {fator * contador}");
                contador++;
            }
        }
    }
}