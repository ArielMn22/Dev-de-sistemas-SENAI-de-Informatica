using System;
using System.IO; // abilita input e output para o usuario stream 

namespace Senai.Leitura.Escrita
{
    class Program
    {
        static int[] numeros = new int[5]; // vetor para guardar os numeros randomecos 
        static string Linha; 
        static Random rand = new Random(); // para gerar numeros aleatoria 
        static void Main(string[] args)
        {
           if (File.Exists("string.txt")) // verifica se o arquivo existe 
           {
               System.Console.WriteLine("\nO arquivo ja existe");
               using(StreamReader ler = new StreamReader("string.txt")){ // inicia o a leitura do arquivo 
                   while ((Linha = ler.ReadLine()) != null) // armazena a leitura dentro da string linha 
                   {
                       System.Console.WriteLine($"{Linha}");
                   }
               }
           }
            
               else{ 
                   for (int i = 0; i < 5; i++) // armazena dentro do array os numeros randomicos 
                   {
                       numeros[i] = rand.Next(1000);
                   }
                   using(StreamWriter Escrever = new StreamWriter("string.txt")){ // inicia o processo de escrita no arquivo se o arquivo nao exite ele cria 
                       for (int i = 0; i < 5; i++)          { // escreve o array de numeros dentro do arquivo de texto 
                           Escrever.WriteLine(numeros[i]);
                       }
                   }

                   using(StreamReader ler =  new StreamReader("string.txt")){ // le o qu esta escrito em cima no arquivo de texto 
                       string Linha;
                       while ((Linha = ler.ReadLine()) != null){
                           System.Console.WriteLine($"{Linha}");
                       }
                       
                   }
               }
           }
          
        }
    }


