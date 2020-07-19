using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BioterapeutDAL.Models.Classes
{
    public class Label
    {
        [Key]
        public int? Id { get; set; }
        public short? IsActive { get; set; }
        public DateTime? DateTimeCreatedOn { get; set; }
        public String Value { get; set; }
        public List<Merchendise> Merchendises { get; set; }
        public List<LabelTranslation> LabelTranslations { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
