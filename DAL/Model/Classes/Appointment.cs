using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BioterapeutDAL.Models.Classes
{
    public class Appointment
    {
        [Key]
        public int? Id { get; set; }
        public short? IsActive { get; set; }
        public DateTime? DateTimeCreatedOn { get; set; }
        public String Type { get; set; }
        public String Description { get; set; }
        public DateTime? DateTimeStart { get; set; }
        public DateTime? DateTimeEnd { get; set; }
        public int? Price { get; set; }
        public Location RefLocationId { get; set; }
        public Label RefLabelId { get; set; }
        public List<RelationUserAppointment> RelationUserAppointments { get; set; }
    }
}
