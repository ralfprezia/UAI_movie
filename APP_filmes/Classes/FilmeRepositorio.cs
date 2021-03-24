using System;
using System.Collections.Generic;
using APP_filmes.Interfaces;

namespace APP_filmes
{
    public class FilmeRepositorio : IRepositorio<Filme>
    {
         private List<Filme> listaFilme = new List<Filme>();
        public void Atualiza(int id, Filme entidade)
        {
            listaFilme[id] = entidade;
        }

        public void Exclui(int id)// Id como indice do vetor da lista
        {
            listaFilme[id].Excluir();
        }

        public void Insere(Filme entidade)
        {
            listaFilme.Add(entidade);
        }

        public List<Filme> Lista()//método lista retorna uma lista de filmes
        {
            return listaFilme;
        }

        public int ProximoId()
        {
            return listaFilme.Count;//sempre um número na frente
        }

        public Filme RetornaPorId(int id)
        {
           return listaFilme[id];
        }
    }
}