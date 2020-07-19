using System;
using System.ComponentModel.DataAnnotations;

namespace BioterapeutDAL.Models.Classes
{
    public class LabelTranslation
    {
        [Key]
        public int? Id { get; set; }
        public short? IsActive { get; set; }
        public DateTime? DateTimeCreatedOn { get; set; }
        public String Language { get; set; }
        public String TranslationValue { get; set; }
        public Label RefLabelId { get; set; }
    }
}
