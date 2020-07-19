using API.Dao;
using API.Dao.Converter;
using BioterapeutDAL.Models.Classes;
using BioterapeutDAL.Repositories.Interfaces;
using BioterapeutDAL.Repository.Implementations.Classes;
using DAO.Converters;
using System.Collections.Generic;

namespace API.Services.Implementations
{
    public class LabelService : IService<LabelDao>
    {
        private readonly IRepository<Label, int> _repository;
        private readonly IConverter<Label, LabelDao> _converter;

        public LabelService(IRepository<Label, int> repository, IConverter<Label, LabelDao> converter)
        {
            _repository = repository;
            _converter = converter;
        }
        public void Add(LabelDao dao)
        {
            Label entity = _converter.DaoToEntity(dao);
            _repository.Add(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<LabelDao> GetAll()
        {
            return _converter.EntityListToDaoList(_repository.GetAll());
        }

        public LabelDao GetById(int id)
        {
            return _converter.EntityToDao(_repository.GetById(id));
        }

        public void Update(LabelDao dao)
        {
            _repository.Update(_converter.DaoToEntity(dao));
        }
    }
}
