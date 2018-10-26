using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.MVC.Util;
using Senai.OO.Pizzaria.MVC.Repositorio;
using Senai.OO.Pizzaria.MVC.ViewModels;

namespace Senai.OO.Pizzaria.MVC.ViewControllers
{
    /// <summary>
    /// Classe responsável pela View e Controller do produto.
    /// </summary>
    public class ProdutoViewController
    {
        static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();

        public static void CadastrarProduto()
        {
            string nome, descricao, preco, categoria;

            #region View
                // Recebe o nome
                do{
                    System.Console.WriteLine("Insira seu nome:");
                    nome = Console.ReadLine();
                    
                    if (string.IsNullOrEmpty(nome))
                        System.Console.WriteLine("Nome do produto inválido");

                }while (string.IsNullOrEmpty(nome));

                // Recebe a descrição
                do
                {
                    System.Console.WriteLine("Insira a descrição do produto:");
                    descricao = Console.ReadLine();
                    
                    if (string.IsNullOrEmpty(descricao))
                        System.Console.WriteLine("Descrição inválida");

                } while (string.IsNullOrEmpty(descricao));

                // Recebe o preço
                do{
                    System.Console.WriteLine("Insira o preço do produto:");
                    preco = Console.ReadLine();
                    
                    if (string.IsNullOrEmpty(preco))
                        System.Console.WriteLine("Preço inválido!");
                } while (string.IsNullOrEmpty(preco));
                
                // Recebe a categoria
                do{
                    System.Console.WriteLine("Insira a categoria do produto:");
                    categoria = Console.ReadLine();
                    
                    if (!ValidacaoUtil.ValidarCategoria(categoria))
                    {
                        System.Console.WriteLine("Categoria inválida!");
                    }
                } while (!ValidacaoUtil.ValidarCategoria(categoria));
            #endregion

            #region Controller
                // Cria um objeto ProdutoViewModel
                ProdutoViewModel produtoViewModel = new ProdutoViewModel();
                // Atribui os valores ao objeto produtoViewModel
                produtoViewModel.Nome = nome;
                produtoViewModel.Descricao = descricao;
                produtoViewModel.Preco = float.Parse(preco);
                produtoViewModel.Categoria = categoria;

                // Inseri o produto atraves do repositório
                produtoRepositorio.Inserir(produtoViewModel);

                // Mostra uma mensagem para o usuário, dizendo que o produto foi cadastrado com sucesso!
                System.Console.WriteLine("Produto Cadastrado");
            #endregion
        }

        public static void ListarProdutos()
        {
            List<ProdutoViewModel> lsprodutos = produtoRepositorio.Listar();

            foreach(ProdutoViewModel item in lsprodutos)
            {
                System.Console.WriteLine($"{item.Id} - {item.Nome} - {item.Preco.ToString("C")}");
            }

            int idProduto = 0;

            do
            {
                System.Console.WriteLine("Informe o Id do produto para mais informações ou 0 para sair:");
                // Obtem o Id do produto.
                idProduto = int.Parse(Console.ReadLine());

                // Verifica se o Id informado é zero, caso seja, saíra do loop.
                if (idProduto == 0)
                {
                    break;
                }

                // Declara um objeto do tipo ProdutoViewModel
                ProdutoViewModel produtoViewModel = produtoRepositorio.BuscarPorId(idProduto);

                // Verifica se o produto existe
                if (produtoViewModel != null)
                {
                    // Caso exista mostra todos os dados do objeto.
                    System.Console.WriteLine($@"- {produtoViewModel.Id}
                                                - {produtoViewModel.Nome}
                                                - {produtoViewModel.Descricao}
                                                - {produtoViewModel.Preco}");
                } else {
                    // Caso não exista mostre 'produto nãoa encontrado'
                    System.Console.WriteLine("Produto não encontrado.");
                }
            }while (idProduto != 0);
        }
    }
}