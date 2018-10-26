using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.MVC.ViewModels;
using Senai.OO.Pizzaria.MVC.ViewControllers;

namespace Senai.OO.Pizzaria.MVC.Repositorio
{
    /// <summary>
    /// Classe responsável pela gravação e leitura dos dados do produto.
    /// </summary>
    public class ProdutoRepositorio
    {
        // Cria um objeto do tipo List
        static List<ProdutoViewModel> lsprodutos = new List<ProdutoViewModel>();
        /// <summary>
        /// Adiciona um usuário a lista.
        /// </summary>
        /// <param name="produto"></param>
        /// <returns></returns>
        public ProdutoViewModel Inserir(ProdutoViewModel produto)
        {
            // Atribui ao Id a quantidade de itens da lista + 1
            produto.Id = lsprodutos.Count + 1;
            // Atribui a DataCriacao ao objeto
            produto.DataCriacao = DateTime.Now;
            // Adiciona o produto na lista
            lsprodutos.Add(produto);
            // Retorna o produto
            return produto;
        }

        /// <summary>
        /// Retorna uma List com todos os produtos cadastrados
        /// </summary>
        /// <returns></returns>
        public List<ProdutoViewModel> Listar()
        {
            return lsprodutos;
        }

        /// <summary>
        /// Busca um produto pelo seu Id
        /// </summary>
        /// <param name="Id">Id do produto.</param>
        public ProdutoViewModel BuscarPorId(int Id)
        {
            // Realiza um loop para encontrar oo objeto dentro da List
            foreach(ProdutoViewModel item in lsprodutos)
            {
                // Se encontrar o Id retorne o mesmo
                if (item.Id == Id)
                {
                    return item;
                }
            }
            //Caso não encontre retorne null.
            return null;
        }
    }
}