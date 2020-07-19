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
    public class LocationService : IService<LocationDao>
    {
        private readonly IRepository<Location, int> _repository;
        private readonly IConverter<Location, LocationDao> _converter;

        public LocationService(IRepository<Location, int> repository, IConverter<Location, LocationDao> converter)
        {
            _repository = repository;
            _converter = converter;
        }
        public void Add(LocationDao dao)
        {
            Location entity = _converter.DaoToEntity(dao);
            _repository.Add(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<LocationDao> GetAll()
        {
            return _converter.EntityListToDaoList(_repository.GetAll());
        }

        public LocationDao GetById(int id)
        {
            return _converter.EntityToDao(_repository.GetById(id));
        }

        public void Update(LocationDao dao)
        {
            _repository.Update(_converter.DaoToEntity(dao));
        }
    }
}
