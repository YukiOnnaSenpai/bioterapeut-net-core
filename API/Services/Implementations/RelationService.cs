using API.Dao;
using API.Dao.Converter;
using BioterapeutDAL.Models.Classes;
using BioterapeutDAL.Repositories.Interfaces;
using BioterapeutDAL.Repository.Implementations.Classes;
using DAO.Converters;
using System.Collections.Generic;

namespace API.Services.Implementations
{
    public class RelationService : IService<RelationUADao>
    {
        private readonly IConverter<RelationUserAppointment, RelationUADao> _converter;
        private readonly IRepository<RelationUserAppointment, int> _repository;

        public RelationService(IRepository<RelationUserAppointment, int> repository, IConverter<RelationUserAppointment, RelationUADao> converter)
        {
            _repository = repository;
            _converter = converter;
        }
        public void Add(RelationUADao dao)
        {
            RelationUserAppointment entity = _converter.DaoToEntity(dao);
            _repository.Add(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<RelationUADao> GetAll()
        {
            return _converter.EntityListToDaoList(_repository.GetAll());
        }

        public RelationUADao GetById(int id)
        {
            return _converter.EntityToDao(_repository.GetById(id));
        }

        public void Update(RelationUADao dao)
        {
            _repository.Update(_converter.DaoToEntity(dao));
        }
    }
}
