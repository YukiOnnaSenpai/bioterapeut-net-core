using BioterapeutDAL.Models.Classes;
using DAO.Converters;
using System.Collections.Generic;

namespace API.Dao.Converter
{
    public class AppointmentConverter
    {
        private LabelConverter _labelConverter;
        private LocationConverter _locationConverter;

        public AppointmentConverter() 
        {
            _labelConverter = new LabelConverter();
            _locationConverter = new LocationConverter();
        }

        public Appointment DaoToEntity(AppointmentDao dao) 
        {
            Appointment entity = new Appointment
            {
                Id = dao.Id,
                DateTimeEnd = dao.DateTimeEnd,
                DateTimeStart = dao.DateTimeStart,
                Description = dao.Description,
                Price = dao.Price,
                Type = dao.Type,
                RefLabelId = _labelConverter.DaoToEntity(dao.RefLabelId),
                RefLocationId = _locationConverter.DaoToEntity(dao.RefLocationId)
            };
            return entity;
        }

        public AppointmentDao EntityToDao(Appointment entity)
        {
            AppointmentDao dao = new AppointmentDao
            {
                Id = entity.Id,
                DateTimeEnd = entity.DateTimeEnd,
                DateTimeStart = entity.DateTimeStart,
                Description = entity.Description,
                Price = entity.Price,
                Type = entity.Type,
                RefLabelId = _labelConverter.EntityToDao(entity.RefLabelId),
                RefLocationId = _locationConverter.EntityToDao(entity.RefLocationId)
            };
            return dao;
        }

        public List<Appointment> DaoListToEntityList(List<AppointmentDao> daos)
        {
            List<Appointment> entities = new List<Appointment>();
            foreach (AppointmentDao dao in daos)
            {
                entities.Add(DaoToEntity(dao));
            }
            return entities;
        }

        public List<AppointmentDao> EntityListToDaoList(List<Appointment> entities)
        {
            List<AppointmentDao> daos = new List<AppointmentDao>();
            foreach (Appointment entity in entities) 
            {
                daos.Add(EntityToDao(entity));
            }
            return daos;
        }
    }
}
