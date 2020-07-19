using System;

namespace API.Dao
{
    public class AppointmentDao
    {
        public int? Id { get; set; }
        public String Type { get; set; }
        public String Description { get; set; }
        public DateTime? DateTimeStart { get; set; }
        public DateTime? DateTimeEnd { get; set; }
        public int? Price { get; set; }
        public LocationDao RefLocationId { get; set; }
        public LabelDao RefLabelId { get; set; }
    }
}
