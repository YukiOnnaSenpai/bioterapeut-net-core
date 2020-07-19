
using BioterapeutDAL.Models.Classes;
using DAO.Converters;
using System.Collections.Generic;

namespace API.Dao.Converter
{
    public class LabelTranslationConverter : IConverter<LabelTranslation, LabelTranslationDao>
    {
        public LabelTranslationConverter()
        { 
        }

        private readonly LabelConverter converter;

        public LabelTranslation DaoToEntity(LabelTranslationDao dao)
        {
            LabelTranslation entity = new LabelTranslation
            {
                Id = dao.Id,
                RefLabelId = converter.DaoToEntity(dao.RefLabelId),
                Language = dao.Language,
                TranslationValue = dao.TranslationValue
            };
            return entity;
        }

        public LabelTranslationDao EntityToDao(LabelTranslation entity)
        {
            LabelTranslationDao dao = new LabelTranslationDao
            {
                Id = entity.Id,
                RefLabelId = converter.EntityToDao(entity.RefLabelId),
                Language = entity.Language,
                TranslationValue = entity.TranslationValue
            };
            return dao;
        }

        public List<LabelTranslation> DaoListToEntityList(List<LabelTranslationDao> daos)
        {
            List<LabelTranslation> entities = new List<LabelTranslation>();
            foreach (LabelTranslationDao dao in daos)
            {
                entities.Add(DaoToEntity(dao));
            }
            return entities;
        }

        public List<LabelTranslationDao> EntityListToDaoList(List<LabelTranslation> entities)
        {
            List<LabelTranslationDao> daos = new List<LabelTranslationDao>();
            foreach (LabelTranslation entity in entities)
            {
                daos.Add(EntityToDao(entity));
            }
            return daos;
        }
    }
}
