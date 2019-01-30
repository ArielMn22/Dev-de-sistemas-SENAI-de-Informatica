using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Senai.Financas.Mvc.Web.Models;
using Senai_Financas_Web_Mvc_Tarde.Interfaces;

namespace Senai_Financas_Web_Mvc_Tarde.Repositorios {
    public class UsuarioRepositorioSerializacao : IUsuario {
        #region Métodos da classe
        /// <summary>
        /// Lista que armazena todos os usuários cadastrados no sistema.
        /// </summary>
        private List<UsuarioModel> UsuariosSalvos { get; set; }

        public UsuarioRepositorioSerializacao () {
            // O método construtor é uma ótima alternatica para
            // instanciar seus objetos.
            // Verificando se já existe um arquivo serializado...
            if (File.Exists ("usuarios.dat")) {
                // Ler o arquivo
                UsuariosSalvos = LerArquivoSerializado ();
            } else {
                UsuariosSalvos = new List<UsuarioModel> ();
            }
        }
        #endregion

        public UsuarioModel BuscarPorEmailESenha (string email, string senha) {
            throw new System.NotImplementedException ();
        }

        public UsuarioModel BuscarPorID (int id) {
            // Percorre todos os usuários buscando pelo ID.
            foreach (UsuarioModel usuario in UsuariosSalvos) {
                if (id == usuario.ID) {
                    return usuario;
                }
            }

            // Caso não encontre o usuário pelo id.
            return null;
        }

        public UsuarioModel Cadastrar (UsuarioModel usuario) {
            // Adiciona o usuário na lista.
            usuario.ID = UsuariosSalvos.Count + 1;

            // Adicionando usuário na lista;
            UsuariosSalvos.Add(usuario);
            
            EscreverNoArquivo ();

            return usuario;
        }

        private void EscreverNoArquivo () {
            // Serializando a lista com todos os usuários cadastrados
            // MemoryStream: Irá armazenar os bytes da lista quando ela for serializada.
            MemoryStream memoria = new MemoryStream ();

            // BinaryFormatter: Objeto que fará a serialização.
            BinaryFormatter serializadora = new BinaryFormatter ();

            serializadora.Serialize (memoria, UsuariosSalvos);

            // Pegando os bytes salvos na memória.
            byte[] bytes = memoria.ToArray ();

            // Grava os bytes no arquivo .bat
            File.WriteAllBytes ("usuarios.dat", bytes);
        }

        public UsuarioModel Editar (UsuarioModel usuario) {
            throw new System.NotImplementedException ();
        }

        public void Excluir (int id) {
            // Buscando o usuário pelo id.
            UsuarioModel usuarioBuscado = BuscarPorID (id);

            // Caso o usuario buscado tenha sido encontrado...
            if (usuarioBuscado != null) {
                UsuariosSalvos.Remove (usuarioBuscado);

                // Temos que atualizar o arquivo com a lista sem o objeto.
                EscreverNoArquivo();
            }
        }

        public List<UsuarioModel> Listar () {
            return UsuariosSalvos;
        }

        private List<UsuarioModel> LerArquivoSerializado () {
            // Lê os butes do arquivo
            byte[] bytesSerializados = File.ReadAllBytes ("usuarios.dat");

            // Cria o fluxo de memória com os butes do arquivo serializado;
            MemoryStream memoria = new MemoryStream (bytesSerializados);

            BinaryFormatter serializador = new BinaryFormatter ();

            return (List<UsuarioModel>) serializador.Deserialize (memoria);
        }
    }
}