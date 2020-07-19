using System.Collections.Generic;

namespace API.Services
{
    public interface IService<TEntity>
    {
        public List<TEntity> GetAll();

        public TEntity GetById(int id);

        public void Add(TEntity dao);

        public void Update(TEntity dao);

        public void Delete(int id);
    }
}
