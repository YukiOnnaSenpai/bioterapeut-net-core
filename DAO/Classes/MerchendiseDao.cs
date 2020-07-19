using System;

namespace API.Dao
{
    public class MerchendiseDao
    {
        public int? Id { get; set; }
        public String Type { get; set; }
        public String Name { get; set; }
        public decimal? Price { get; set; }
        public String Description { get; set; }
        public bool HasStock { get; set; }
        public LabelDao RefLabelId { get; set; }
    }
}
