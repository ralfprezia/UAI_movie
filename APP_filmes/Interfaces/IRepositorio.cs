using System.Collections.Generic;

namespace APP_filmes.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();//Ex: no lugar do T seria Filme//Inter face tem um método lista que retorna uma lista de T
         T RetornaPorId(int id);//Método que passa um Id por parâmetro e retorna, um T como parâmetro

         void Insere(T entidade);
         void Exclui(int id);
         void Atualiza(int id, T entidade);
         int ProximoId();//retorna o próximo id

    }
}