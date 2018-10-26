using System;

namespace Senai.Array.CadastroEmail.Classes
{
    public class Usuario
    {
        #region Propriedades
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Senha {get; set;}
        #endregion

        #region Metodos
        /// <summary>
        /// Zera o usuário, para o caso do 'Nome' ter sido definido, mas o e-mail foi incerto.
        /// </summary>
        public void Zerar()
        {
            Nome = null;
            Email = null;
            Senha = null;
        }

        /// <summary>
        /// Cadastra usuários e retorna se ocorreram erros ou não.
        /// </summary>
        /// <returns>1 - Email não contém '@'. 2 - Senha não possui ao menos 4 digitos. 0 - Cadastro efetuado com sucesso!</returns>
        public int Cadastrar()
        {
            System.Console.WriteLine("Insira seu nome:");
            Nome = Console.ReadLine();

            System.Console.WriteLine("Insira seu e-mail:");
            Email = Console.ReadLine();
            
            if (Email.Contains('@')!=true)
            {
                System.Console.WriteLine("O e-mail informado deve conter um '@'.");
                
                System.Console.WriteLine("Aperte [QUALQUER] tecla para continuar...");
                Console.ReadKey();
                
                return 1;
            } else {
                System.Console.WriteLine("Insira sua senha:");
                Senha = Console.ReadLine();
            
                if (Senha.Length < 4)
                {
                    System.Console.WriteLine("A senha informada deve conter ao menos 4 digitos.");
                    
                    System.Console.WriteLine("Aperte [QUALQUER] tecla para continuar...");
                    Console.ReadKey();
                
                    return 2;
                }
            }

            return 0;
        }

        public void Exibir()
        {
            System.Console.WriteLine($"Usuário: {Nome}\nE-mail: {Email}\n");
        }
        #endregion
    }
}