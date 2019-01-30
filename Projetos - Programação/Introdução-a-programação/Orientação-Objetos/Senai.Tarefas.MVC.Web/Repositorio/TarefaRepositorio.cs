using System;
using System.Collections.Generic;
using System.IO;
using Senai.Tarefas.MVC.Web.Models;

namespace Senai.Tarefas.MVC.Web.Repositorio {
    public class TarefaRepositorio {
        public List<TarefaModel> ListarTarefas () {
            if (!File.Exists("tarefas.csv"))
            {
                using(File.Create("tarefas.csv")) {}; // Cria o arquivo .csv
            }

            string[] linhas = File.ReadAllLines ("tarefas.csv");

            List<TarefaModel> lsTarefas = new List<TarefaModel> ();

            TarefaModel tarefaModel;

            foreach (string linha in linhas) {
                string[] dados = linha.Split (';');

                tarefaModel = new TarefaModel {
                    ID = int.Parse (dados[0]),
                    Nome = dados[1],
                    Descricao = dados[2],
                    Tipo = dados[3],
                    IdUsuario = dados[4],
                    DataCriacao = DateTime.Parse (dados[5])
                };
                
                lsTarefas.Add (tarefaModel);
            }

            return lsTarefas;
        }
    }
}