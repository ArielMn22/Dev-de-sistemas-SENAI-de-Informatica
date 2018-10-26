using System;
using Senai.Array.CadastroProdutos.Classes;

namespace Senai.Array.CadastroProdutos {
    class Program {
        static string opcao;
        static Produto[] products; //Declarando para todas as funções
        static int i; //Contador de cadastros

        static void Main (string[] args) {
            Console.Clear ();

            System.Console.WriteLine ("==================================================");
            System.Console.WriteLine ("             Mercadinho Simulator");
            System.Console.WriteLine ("==================================================");
            System.Console.WriteLine ("Informe quantos produtos serão cadastrados:");
            int qProdutos = int.Parse (Console.ReadLine ());

            products = new Produto[qProdutos]; //Declarando Array;

            do {
                Menu ();

                switch (opcao) {
                    case "1":
                        {
                            CadastrarProduto ();
                            break;
                        }
                    case "2":
                        {
                            ListarProdutos ();
                            break;
                        }
                    case "3":
                        {
                            AumentarValor ();
                            break;
                        }

                    case "4":
                        {
                            MostrarTotal ();
                            break;
                        }

                    case "0":
                        {
                            break;
                        }
                }
            } while (opcao != "0");
        }

        static void Menu () {
            Console.Clear ();

            System.Console.WriteLine ("==================================================");
            System.Console.WriteLine ("             Mercadinho Simulator");
            System.Console.WriteLine ("==================================================");
            System.Console.WriteLine ("1 - Cadastrar Produto.");
            System.Console.WriteLine ("2 - Listar Produtos.");
            System.Console.WriteLine ("3 - Aumentar o valor de um produto.");
            System.Console.WriteLine ("4 - Mostrar a quantidade de produtos e o valor total.");
            System.Console.WriteLine ("0 - Sair do programa.");

            System.Console.Write ("\nInsira uma opção: ");
            opcao = Console.ReadLine ();
        }

        static void CadastrarProduto () {
            if (i < products.Length) {
                products[i] = new Produto (); //Instanciando Objeto

                System.Console.WriteLine ("\nInsira o nome do produto:");
                products[i].Nome = Console.ReadLine ();

                System.Console.WriteLine ("\nInsira o ID do produto:");
                products[i].ID = int.Parse (Console.ReadLine ());

                System.Console.WriteLine ("\nInsira a quantidade do produto:");
                products[i].Quantidade = int.Parse (Console.ReadLine ());

                System.Console.WriteLine ("\nInsira o preço unitário do produto:");
                products[i].Valor = double.Parse (Console.ReadLine ());
                i++;
                System.Console.WriteLine ("\nUsuário cadastrado com sucesso!");
            } else {
                System.Console.WriteLine ("Número máximo de usuários cadastrados!");
            }

            Pausa ();
        }

        static void ListarProdutos () {
            foreach (Produto item in products) {
                if (item != null)
                    System.Console.WriteLine ($"Produto:{item.Nome}\nID: {item.ID}\nQuantidade: {item.Quantidade}\nValor: {item.Valor.ToString("C")}\n");
            }
            Pausa ();
        }

        static void AumentarValor () {
            System.Console.WriteLine ("Informe quantos porcento deseja de aumento para o produto (não é necessário colocar % ao final do número):");
            float porcent = float.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Informe o ID do produto:");
            int ID = int.Parse (Console.ReadLine ());

            int j;
            bool achou = false;
            for (j = 0; j < i; j++) {
                if (ID == products[j].ID) {
                    products[j].AumentarValor (porcent);
                    achou = true;
                }
            }

            if (achou != true) {
                System.Console.WriteLine ("ID não compatível com os produtos cadastrados.");
            }
            Pausa ();
        }
        static void MostrarTotal () {
            int j, quantTotal = 0;
            double valorTotal = 0;

            for (j = 0; j < i; j++) {
                valorTotal = (double) (valorTotal + (products[j].Valor * products[j].Quantidade));
            }

            for (j = 0; j < i; j++) {
                quantTotal = quantTotal + products[j].Quantidade;
            }

            System.Console.WriteLine ($"Quantidade total de produtos: {quantTotal}");
            System.Console.WriteLine ($"Soma total dos valores (valor x produto): {valorTotal.ToString("C")}");

            Pausa ();
        }
        static void Pausa () {
            System.Console.WriteLine ("Aperte [QUALQUER] tecla para continuar...");
            Console.ReadKey ();
        }
    }
}