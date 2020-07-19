using API.Dao;
using API.Dao.Converter;
using BioterapeutDAL.Models.Classes;
using BioterapeutDAL.Repositories.Implementations;
using BioterapeutDAL.Repositories.Interfaces;
using BioterapeutDAL.Repository.Implementations.Classes;
using DAO.Converters;
using System.Collections.Generic;

namespace API.Services.Implementations
{
    public class AppointmentService : IService<AppointmentDao>
    {
        private readonly IRepository<Appointment,int> _repository;
        private readonly IConverter<Appointment, AppointmentDao> _converter;

        public AppointmentService(IRepository<Appointment, int> repository, IConverter<Appointment, AppointmentDao> converter)
        {
            _repository = repository;
            _converter = converter;
        }

        public void Add(AppointmentDao dao)
        {
            Appointment entity = _converter.DaoToEntity(dao);
            _repository.Add(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<AppointmentDao> GetAll()
        {
            return _converter.EntityListToDaoList(_repository.GetAll());
        }

        public AppointmentDao GetById(int id)
        {
            return _converter.EntityToDao(_repository.GetById(id));
        }

        public void Update(AppointmentDao dao)
        {
            _repository.Update(_converter.DaoToEntity(dao));
        }
    }
}
