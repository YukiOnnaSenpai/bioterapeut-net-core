using BioterapeutDAL.Models.Classes;
using BioterapeutDAL.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BioterapeutDAL.Repository.Implementations.Classes
{
    public class RelationUserAppointmentImpl : BaseRepositoryImpl<RelationUserAppointment, int>
    {
        public override void Delete(int id)
        {
            context.Database.OpenConnection();
            RelationUserAppointment tracking = context.Set<RelationUserAppointment>().Where(e => e.Id == id).Select(e => e).AsQueryable().FirstOrDefault();
            tracking.IsActive = NOT_ACTIVE;
            Update(tracking);
            context.SaveChanges();
            context.Database.CloseConnection();
        }

        public override RelationUserAppointment GetById(int id)
        {
            context.Database.OpenConnection();
            RelationUserAppointment queriedValue = context.Set<RelationUserAppointment>().Where(e => e.Id == id).AsQueryable().FirstOrDefault();
            context.SaveChanges();
            context.Database.CloseConnection();
            return queriedValue;
        }
    }
}
