using BioterapeutDAL.Models.Classes;
using System.Collections.Generic;

namespace API.Dao.Converter
{
    public class MerchendiseConverter
    {
        public MerchendiseConverter()
        { 
        }
        private readonly LabelConverter converter;

		public Merchendise DaoToEntity(MerchendiseDao dao)
		{
            Merchendise entity = new Merchendise
            {
                Id = dao.Id,
                Description = dao.Description,
                Name = dao.Name,
                Price = dao.Price,
                Type = dao.Type,
                RefLabelId = converter.DaoToEntity(dao.RefLabelId),
                HasStock = dao.HasStock
            };
            return entity;
		}

		public MerchendiseDao EntityToDao(Merchendise entity)
		{
            MerchendiseDao dao = new MerchendiseDao
            {
                Id = entity.Id,
                Description = entity.Description,
                Name = entity.Name,
                Price = entity.Price,
                Type = entity.Type,
                RefLabelId = converter.EntityToDao(entity.RefLabelId),
                HasStock = entity.HasStock
            };
            return dao;
		}

		public List<Merchendise> DaoListToEntityList(List<MerchendiseDao> daos)
		{
			List<Merchendise> entities = new List<Merchendise>();
			foreach (MerchendiseDao dao in daos)
			{
				entities.Add(DaoToEntity(dao));
			}
			return entities;
		}

		public List<MerchendiseDao> EntityListToDaoList(List<Merchendise> entities)
		{
			List<MerchendiseDao> daos = new List<MerchendiseDao>();
			foreach (Merchendise entity in entities)
			{
				daos.Add(EntityToDao(entity));
			}
			return daos;
		}
	}
}
