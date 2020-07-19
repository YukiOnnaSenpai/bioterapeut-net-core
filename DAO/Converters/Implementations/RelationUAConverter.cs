using BioterapeutDAL.Models.Classes;

namespace API.Dao.Converter
{
    public class RelationUAConverter
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
    }
}
