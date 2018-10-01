using System;

namespace Senai.Operadores.Exercicio1 {
    class Program {
        static void Main (string[] args) {
            // byte i;
            // for (i = 1; i <= 3; i++) {   
            //     Console.Clear ();

            //     Console.WriteLine ("Informe o peso da " + i + "ª pessoa: ");
            //     peso_pessoal = float.Parse (Console.ReadLine ());

            //     Console.WriteLine ("Informe o altura da " + i + "ª pessoa: ");
            //     altura_pessoal = float.Parse (Console.ReadLine ());

            //     imc_pessoal = peso_pessoal / (altura_pessoal * altura_pessoal);

            //     Console.Clear ();

            //     Console.WriteLine ("#########################################");
            //     Console.WriteLine ("            " + i + "ª pessoa:");
            //     Console.WriteLine ("#########################################\n");
            //     Console.WriteLine ("Peso: " + peso_pessoal + "\nAltura: " + altura_pessoal + "\nIMC: " + imc_pessoal);
            // }

            #region imc Pessoa 1
            Console.Clear ();

            Console.WriteLine ("Informe o peso da primeira pessoa: ");
            float peso_pessoal = float.Parse (Console.ReadLine ());

            Console.WriteLine ("Informa a altura da primeira pessoa: ");
            float altura_pessoal = float.Parse (Console.ReadLine ());

            // Casting (Conversão)
            float imc_pessoal = (float) (peso_pessoal / Math.Pow(altura_pessoal, 2));

            Console.Clear ();

            Console.WriteLine ("#########################################");
            Console.WriteLine ("           Primeira pessoa:");
            Console.WriteLine ("#########################################\n");
            Console.WriteLine ("Peso: " + peso_pessoal + "\nAltura: " + altura_pessoal + "\nIMC: " + imc_pessoal);
            Console.ReadKey();
            #endregion

            #region imc Pessoa 2
            Console.Clear ();

            Console.WriteLine ("Informe o peso da segunda pessoa: ");
            float peso_pessoal2 = float.Parse (Console.ReadLine ());

            Console.WriteLine ("Informa a altura da segunda pessoa: ");
            float altura_pessoal2 = float.Parse (Console.ReadLine ());

            float imc_pessoal2 = (float) (peso_pessoal2 / Math.Pow (altura_pessoal2, 2));

            Console.Clear ();

            Console.WriteLine ("#########################################");
            Console.WriteLine ("           Segunda pessoa:");
            Console.WriteLine ("#########################################\n");
            Console.WriteLine ($"Peso: { peso_pessoal2 }\nAltura: { altura_pessoal2 }\nIMC: { imc_pessoal2 }");
            #endregion
        }
    }
}