using System;

namespace Senai.Matriz.Cadastro_Usuario.Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Informe a quantidade de cadastros:");
            int qCadastros = int.Parse(Console.ReadLine());

            string[,] usuarios = new string[qCadastros, 3];

            for (int i = 0; i < qCadastros ; i++)
            {
                System.Console.WriteLine("Informe o seu nome:");
                usuarios[i, 0] = Console.ReadLine();
                
                System.Console.WriteLine("Informe seu CPF:");
                usuarios[i, 1] = Console.ReadLine();
                
                System.Console.WriteLine("Informe seu telefone:");
                usuarios[i, 2] = Console.ReadLine();
            }

            for (int i = 0; i<qCadastros ; i++)
            {
                System.Console.WriteLine("\n#############################");
                for (int j = 0; j<3; j++)
                {
                    System.Console.WriteLine(usuarios[i, j]);
                }
            }
        }
    }
}
