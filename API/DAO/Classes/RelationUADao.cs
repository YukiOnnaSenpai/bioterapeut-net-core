using System;

namespace API.Dao
{
    public class RelationUADao
    {
        public int? Id { get; set; }
        public String AttendanceStatus { get; set; }
        public int? Rating { get; set; }
        public String Comment { get; set; }
        public UserDao RefUserId { get; set; }
        public AppointmentDao RefAppointmentId { get; set; }
    }
}
