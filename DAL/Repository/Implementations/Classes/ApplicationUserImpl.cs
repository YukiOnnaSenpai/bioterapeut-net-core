using BioterapeutDAL.Models.Classes;
using BioterapeutDAL.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BioterapeutDAL.Repository.Implementations.Classes
{
    public class ApplicationUserImpl : BaseRepositoryImpl<ApplicationUser, int>
    {
        public override void Delete(int id)
        {
            context.Database.OpenConnection();
            ApplicationUser tracking = context.Set<ApplicationUser>().Where(e => e.Id == id).Select(e => e).AsQueryable().FirstOrDefault();
            tracking.IsActive = NOT_ACTIVE;
            Update(tracking);
            context.SaveChanges();
            context.Database.CloseConnection();
        }

        public override ApplicationUser GetById(int id)
        {
            context.Database.OpenConnection();
            ApplicationUser tracking = context.Set<ApplicationUser>().Where(e => e.Id == id).AsQueryable().FirstOrDefault();
            context.SaveChanges();
            context.Database.CloseConnection();
            return tracking;
        }
    }
}
