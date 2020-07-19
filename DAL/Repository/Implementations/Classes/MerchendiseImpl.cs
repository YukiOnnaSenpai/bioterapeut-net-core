using BioterapeutDAL.Models.Classes;
using BioterapeutDAL.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BioterapeutDAL.Repository.Implementations.Classes
{
    public class MerchendiseImpl : BaseRepositoryImpl<Merchendise, int>
    {
        public override void Delete(int id)
        {
            context.Database.OpenConnection();
            Merchendise tracking = context.Set<Merchendise>().Where(e => e.Id == id).Select(e => e).AsQueryable().FirstOrDefault();
            tracking.IsActive = NOT_ACTIVE;
            Update(tracking);
            context.SaveChanges();
            context.Database.CloseConnection();
        }

        public override Merchendise GetById(int id)
        {
            context.Database.OpenConnection();
            Merchendise queriedValue = context.Set<Merchendise>().Where(e => e.Id == id).AsQueryable().FirstOrDefault();
            context.SaveChanges();
            context.Database.CloseConnection();
            return queriedValue;
        }
    }
}
