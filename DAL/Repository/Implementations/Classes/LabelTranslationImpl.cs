using BioterapeutDAL.Models.Classes;
using BioterapeutDAL.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BioterapeutDAL.Repository.Implementations.Classes
{
    public class LabelTranslationImpl : BaseRepositoryImpl<LabelTranslation, int>
    {
        public override void Delete(int id)
        {
            context.Database.OpenConnection();
            LabelTranslation tracking = context.Set<LabelTranslation>().Where(e => e.Id == id).Select(e => e).AsQueryable().FirstOrDefault();
            tracking.IsActive = NOT_ACTIVE;
            Update(tracking);
            context.SaveChanges();
            context.Database.CloseConnection();
        }

        public override LabelTranslation GetById(int id)
        {
            context.Database.OpenConnection();
            LabelTranslation queriedValue = context.Set<LabelTranslation>().Where(e => e.Id == id).AsQueryable().FirstOrDefault();
            context.SaveChanges();
            context.Database.CloseConnection();
            return queriedValue;
        }
    }
}
