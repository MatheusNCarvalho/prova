using System.Collections.Generic;

namespace prova.exercicio_02
{
    public interface IServiceBase<TEntity> where TEntity : Veiculo
    {
        void Add(TEntity entity);
        TEntity BuscarPorId(int id);
        IList<TEntity> Get();
    }
}