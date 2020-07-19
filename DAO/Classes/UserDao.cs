using System;

namespace API.Dao
{
    public class UserDao
    {
        public int? Id { get; set; }
        public String AccountType { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public LocationDao RefLocationId { get; set; }
    }
}
