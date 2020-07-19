using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BioterapeutDAL.Models.Classes
{
    public class Location
    {
        [Key]
        public int? Id { get; set; }
        public short? IsActive { get; set; }
        public DateTime? DateTimeCreatedOn { get; set; }
        public String Country { get; set; }
        public String City { get; set; }
        public String Address { get; set; }
        public String  Language { get; set; }
        public List<ApplicationUser> Users { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
