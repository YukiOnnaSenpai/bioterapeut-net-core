using API.Dao;
using API.Dao.Converter;
using BioterapeutDAL.Models.Classes;
using BioterapeutDAL.Repositories.Interfaces;
using BioterapeutDAL.Repository.Implementations.Classes;
using DAO.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Implementations
{
    public class MerchendiseService : IService<MerchendiseDao>
    {
        private readonly IRepository<Merchendise, int> _repository;
        private readonly IConverter<Merchendise, MerchendiseDao> _converter;

        public MerchendiseService(IRepository<Merchendise, int> repository, IConverter<Merchendise, MerchendiseDao> converter)
        {
            _repository = repository;
            _converter = converter;
        }

        public void Add(MerchendiseDao dao)
        {
            Merchendise entity = _converter.DaoToEntity(dao);
            _repository.Add(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<MerchendiseDao> GetAll()
        {
            return _converter.EntityListToDaoList(_repository.GetAll());
        }

        public MerchendiseDao GetById(int id)
        {
            return _converter.EntityToDao(_repository.GetById(id));
        }

        public void Update(MerchendiseDao dao)
        {
            _repository.Update(_converter.DaoToEntity(dao));
        }
    }
}
