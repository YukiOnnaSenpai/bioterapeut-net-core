using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BioterapeutDAL.Models.Classes
{
    public class ApplicationUser
    {
        [Key]
        public int? Id { get; set; }
        public short? IsActive { get; set; }
        public DateTime? DateTimeCreatedOn { get; set; }
        public String AccountType { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public Location RefLocationId { get; set; }
        public List<RelationUserAppointment> RelationUserAppointments { get; set; }
    }
}
