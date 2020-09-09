using System.Collections.Generic;

namespace DAO.Converters
{
    public interface IConverter<TEntity, TDao> where TEntity: class where TDao:class
    {
        public TEntity DaoToEntity(TDao dao);

        public TDao EntityToDao(TEntity entity);

        public List<TEntity> DaoListToEntityList(List<TDao> daos);

        public List<TDao> EntityListToDaoList(List<TEntity> entities);
    }
}
