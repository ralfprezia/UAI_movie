using System;

namespace APP_filmes
{
    public class Filme : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Filme(Genero genero, int id, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;//(Apenas marcação) nunca atribua "true"
        }

        public override string ToString()//converte os objetos para string e ,
        {
            string retorno = "";//retorna os valores
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        //Encapsulamento
        public string retornaTitulo()
        {
            return this.Titulo;
        }

        internal int retornaId()//quando for exibir a listagem dos filmes
        {
            return this.Id;
        }

        internal bool retornaExcluido()//quando for exibir a listagem dos filmes
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;//Marca o excluido como true
        }


    }
}