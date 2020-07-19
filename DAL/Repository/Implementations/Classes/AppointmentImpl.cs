using BioterapeutDAL.Models.Classes;
using BioterapeutDAL.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BioterapeutDAL.Repository.Implementations.Classes
{
    public class AppointmentImpl : BaseRepositoryImpl<Appointment, int>
    {
        public override void Delete(int id)
        {
            context.Database.OpenConnection();
            Appointment tracking = context.Set<Appointment>().Where(e => e.Id == id).Select(e => e).AsQueryable().FirstOrDefault();
            tracking.IsActive = NOT_ACTIVE;
            Update(tracking);
            context.SaveChanges();
            context.Database.CloseConnection();
        }

        public override Appointment GetById(int id)
        {
            context.Database.OpenConnection();
            Appointment queriedValue = context.Set<Appointment>().Where(e => e.Id == id).AsQueryable().FirstOrDefault();
            context.SaveChanges();
            context.Database.CloseConnection();
            return queriedValue;
        }
    }
}
