using API.Dao.Converter;
using BioterapeutDAL.Models.Classes;
using BioterapeutDAL.Repositories.Interfaces;
using BioterapeutDAL.Repository.Implementations.Classes;
using DAO.Converters;
using System.Collections.Generic;

namespace API.Services.Implementations
{
    public class LabelTranslationService : IService<LabelTranslationDao>
    {
        private readonly IRepository<LabelTranslation, int> _repository;
        private readonly IConverter<LabelTranslation, LabelTranslationDao> _converter;

        public LabelTranslationService(IRepository<LabelTranslation, int> repository, IConverter<LabelTranslation, LabelTranslationDao> converter)
        {
            _repository = repository;
            _converter = converter;
        }
        public void Add(LabelTranslationDao dao)
        {
            LabelTranslation entity = _converter.DaoToEntity(dao);
            _repository.Add(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<LabelTranslationDao> GetAll()
        {
            return _converter.EntityListToDaoList(_repository.GetAll());
        }

        public LabelTranslationDao GetById(int id)
        {
            return _converter.EntityToDao(_repository.GetById(id));
        }

        public void Update(LabelTranslationDao dao)
        {
            _repository.Update(_converter.DaoToEntity(dao));
        }
    }
}
