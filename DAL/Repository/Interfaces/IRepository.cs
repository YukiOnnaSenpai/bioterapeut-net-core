using System.Collections.Generic;

namespace BioterapeutDAL.Repositories.Interfaces
{
    public interface IRepository <TEntity, K> where TEntity:class
    {
        void Add(TEntity entity);
        List<TEntity> GetAll();
        void Update(TEntity entity);
        void Delete(K id);
        TEntity GetById(K id);
    }
}
