using System;
using Senai.Decisão.Exercício12.Classes;

namespace Senai.Decisão.Exercício12 {
    class Program {
        static void Main (string[] args) {

            UserData uData = new UserData ();

            Console.Clear ();

            System.Console.WriteLine ("Insira uma data\n");

            System.Console.WriteLine ("Insira o dia:");
            uData.Day = int.Parse (Console.ReadLine ());

            if (uData.Day <= 31 && uData.Day >= 1) {

                //Recebe o mês
                System.Console.WriteLine ("\nInsira o mês:");
                uData.Month = int.Parse (Console.ReadLine ());
                
                if (uData.Month <= 12 && uData.Month >= 1) {
                    
                    //Recebe o ano
                    System.Console.WriteLine ("\nInsira o ano:");
                    uData.Year = int.Parse (Console.ReadLine ());
                    
                    if (uData.Year <= 2013 && uData.Year >= 1) {
                        System.Console.WriteLine ($"'{uData.Day}/{uData.Month}/{uData.Year}' é uma data válida!"); //DATA VALIDA
                    } else {
                        System.Console.WriteLine ($"{uData.Year} não é um ano válido (ainda não chegamos em tal ano)."); //ANO INVALIDO
                    }
                } else {
                    System.Console.WriteLine ($"{uData.Month} não é um mês válido."); //MES INVALIDO
                }
            } else {
                System.Console.WriteLine ($"{uData.Day} não é um dia válido, os meses só possuem entre 1 a 31 dias."); //DIA INVALIDO 
            }
        }
    }
}