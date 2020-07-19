using System;

namespace API.Dao.Converter
{
    public class LabelTranslationDao
    {
        public int? Id { get; set; }
        public String Language { get; set; }
        public String TranslationValue { get; set; }
        public LabelDao RefLabelId { get; set; }
    }
}
