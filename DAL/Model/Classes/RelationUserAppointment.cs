using System;
using System.ComponentModel.DataAnnotations;

namespace BioterapeutDAL.Models.Classes
{
    public class RelationUserAppointment
    {
        [Key]
        public int? Id { get; set; }
        public short? IsActive { get; set; }
        public DateTime? DateTimeCreatedOn { get; set; }
        public String AttendanceStatus { get; set; }
        public int? Rating { get; set; }
        public String Comment { get; set; }
        public ApplicationUser RefUserId { get; set; }
        public Appointment RefAppointmentId { get; set; }

    }
}
