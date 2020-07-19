using BioterapeutDAL.Models.Classes;
using DAO.Converters;
using System.Collections.Generic;

namespace API.Dao.Converter
{
    public class RelationUAConverter :IConverter<RelationUserAppointment, RelationUADao>
    {
        public RelationUAConverter()
        { 
        }
        private readonly AppointmentConverter appointmentConverter;
        private readonly UserConverter userConverter;

        public RelationUserAppointment DaoToEntity(RelationUADao dao)
        {
            RelationUserAppointment entity = new RelationUserAppointment
            {
                Id = dao.Id,
                RefAppointmentId = appointmentConverter.DaoToEntity(dao.RefAppointmentId),
                RefUserId = userConverter.DaoToEntity(dao.RefUserId),
                AttendanceStatus = dao.AttendanceStatus,
                Comment = dao.Comment,
                Rating = dao.Rating
            };
            return entity;
        }

        public RelationUADao EntityToDao(RelationUserAppointment entity)
        {
            RelationUADao dao = new RelationUADao
            {
                Id = entity.Id,
                RefAppointmentId = appointmentConverter.EntityToDao(entity.RefAppointmentId),
                RefUserId = userConverter.EntityToDao(entity.RefUserId),
                AttendanceStatus = entity.AttendanceStatus,
                Comment = entity.Comment,
                Rating = entity.Rating
            };
            return dao;
        }

        public List<RelationUserAppointment> DaoListToEntityList(List<RelationUADao> daos)
        {
            List<RelationUserAppointment> entities = new List<RelationUserAppointment>();
            foreach (RelationUADao dao in daos)
            {
                entities.Add(DaoToEntity(dao));
            }
            return entities;
        }

        public List<RelationUADao> EntityListToDaoList(List<RelationUserAppointment> entities)
        {
            List<RelationUADao> daos = new List<RelationUADao>();
            foreach (RelationUserAppointment entity in entities)
            {
                daos.Add(EntityToDao(entity));
            }
            return daos;
        }
    }
}
