using System;
using System.Collections.Generic;
using System.Text;

namespace DAO.Converters
{
    public interface IConverter<TEntity> where TEntity: class
    {
        public TEntity DaoToEntity(TEntity dao);

        public TEntity EntityToDao(TEntity entity);
    }
}
