using System;
using System.ComponentModel.DataAnnotations;

namespace BioterapeutDAL.Models.Classes
{
    public class Merchendise
    {
        [Key]
        public int? Id { get; set; }
        public short? IsActive { get; set; }
        public DateTime? DateTimeCreatedOn { get; set; }
        public String Type { get; set; }
        public String Name { get; set; }
        public decimal? Price { get; set; }
        public String Description { get; set; }
        public bool HasStock { get; set; }
        public Label RefLabelId { get; set; }
    }
}
