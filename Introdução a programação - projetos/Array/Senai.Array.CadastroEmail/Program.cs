using System;
using Senai.Array.CadastroEmail.Classes;

namespace Senai.Array.CadastroEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario[] user = new Usuario[10];
            int i = 0, j; //Contador
            string choice;

            do{
                Console.Clear();
                
            System.Console.WriteLine("=======================================================");
            System.Console.WriteLine("                 Cadastro de Usuários");
            System.Console.WriteLine("=======================================================");
            System.Console.WriteLine("1 - Cadastrar uma novo usuário.\n2 - Exibir usuários existentes.\n3 - Acessar Sistema.\n0 - Sair do programa.");

            System.Console.Write("\nInsira uma opção: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                {
                    if (i < 10)
                    user[i] = new Usuario();
                    {
                        if(user[i].Cadastrar() == 0)
                        {
                            i++;
                        } else {
                            user[i].Zerar();
                        }
                    }
                    break;
                }

                case "2":
                {
                    if (i==0)
                    {
                        System.Console.WriteLine("Nenhum usuário cadastrado...");
                    } else {
                        for (j=0; j<i; j++)
                        {
                            user[j].Exibir();
                        }
                    }
                    
                    System.Console.WriteLine("Aperte [QUALQUER] tecla para continuar...");
                    Console.ReadKey();
                
                    break;
                }

                case "3":
                {
                    if (i==0)
                    {
                        System.Console.WriteLine("Não há usuários cadastrados!");
                    } else {
                        System.Console.WriteLine("Insira seu e-mail:");
                        string loginEmail = Console.ReadLine();
                    
                        System.Console.WriteLine("Insira sua senha:");
                        string loginSenha = Console.ReadLine();


                        for (j=0; j<i; j++)
                        {
                            if (loginEmail == user[j].Email)
                            {
                                if (loginSenha == user[j].Senha)
                                {
                                    System.Console.WriteLine($"Bem-vindo de volta Sr.{user[j].Nome}!");
                                } else {
                                    System.Console.WriteLine("Usuário ou senha incorretos!");
                                }
                            } else {
                                System.Console.WriteLine("Usuário ou senha incorretos!");
                            }
                        }

                    }

                    System.Console.WriteLine("Aperte [QUALQUER] tecla para continuar...");
                    Console.ReadKey();

                    break;
                }

                default:
                {
                    System.Console.WriteLine("Insira uma opção válida.");
                    
                    System.Console.WriteLine("Aperte [QUALQUER] tecla para continuar...");
                    Console.ReadKey();
                    break;
                }
            }
        } while(choice != "0");
        }
    }
}
