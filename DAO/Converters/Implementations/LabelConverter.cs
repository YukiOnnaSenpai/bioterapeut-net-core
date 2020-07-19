using BioterapeutDAL.Models.Classes;
using System.Collections.Generic;

namespace API.Dao.Converter
{
    public class LabelConverter
    {
        public LabelConverter()
        { 

        }
        public Label DaoToEntity(LabelDao dao)
        {
            Label entity = new Label
            {
                Id = dao.Id,
                Value = dao.Value
            };
            return entity;
        }

        public LabelDao EntityToDao(Label entity)
        {
            LabelDao dao = new LabelDao
            {
                Id = entity.Id,
                Value = entity.Value
            };
            return dao;
        }

        public List<Label> DaoListToEntityList(List<LabelDao> daos)
        {
            List<Label> entities = new List<Label>();
            foreach (LabelDao dao in daos)
            {
                entities.Add(DaoToEntity(dao));
            }
            return entities;
        }

        public List<LabelDao> EntityListToDaoList(List<Label> entities)
        {
            List<LabelDao> daos = new List<LabelDao>();
            foreach (Label entity in entities)
            {
                daos.Add(EntityToDao(entity));
            }
            return daos;
        }
    }
}
