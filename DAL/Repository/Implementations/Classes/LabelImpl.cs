using BioterapeutDAL.Models.Classes;
using BioterapeutDAL.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BioterapeutDAL.Repository.Implementations.Classes
{
    public class LabelImpl : BaseRepositoryImpl<Label, int>
    {
        public override void Delete(int id)
        {
            context.Database.OpenConnection();
            Label tracking = context.Set<Label>().Where(e => e.Id == id).Select(e => e).AsQueryable().FirstOrDefault();
            tracking.IsActive = NOT_ACTIVE;
            Update(tracking);
            context.SaveChanges();
            context.Database.CloseConnection();
        }

        public override Label GetById(int id)
        {
            context.Database.OpenConnection();
            Label queriedValue = context.Set<Label>().Where(e => e.Id == id).AsQueryable().FirstOrDefault();
            context.SaveChanges();
            context.Database.CloseConnection();
            return queriedValue;
        }
    }
}
