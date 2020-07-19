using BioterapeutDAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BioterapeutDAL.Repositories.Implementations
{
    public abstract class BaseRepositoryImpl<TEntity, K> : IRepository<TEntity, K> where TEntity : class
    {
        protected const short ACTIVE = -1;
        protected const short NOT_ACTIVE = 0;
        protected DbContext context;
        protected DbSet<TEntity> DbSet;
        public void Add(TEntity entity)
        {
            context.Database.OpenConnection();
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
            context.Database.CloseConnection();
        }
        public abstract void Delete(K id);

        public List<TEntity> GetAll()
        {
            context.Database.OpenConnection();
            List<TEntity> entities = context.Set<TEntity>().AsQueryable().ToList();
            context.SaveChanges();
            context.Database.CloseConnection();
            return entities;
        }

        public abstract TEntity GetById(K id);
        public void Update(TEntity entity)
        {
            context.Database.OpenConnection();
            context.Set<TEntity>().Update(entity);
            context.SaveChanges();
            context.Database.CloseConnection();
        }
    }
}
