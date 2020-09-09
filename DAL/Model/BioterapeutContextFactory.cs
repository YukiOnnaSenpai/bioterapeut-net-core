using BioterapeutDAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DAL.Model
{
    public class BioterapeutContextFactory : IDesignTimeDbContextFactory<BioterapeutContext>
    {
        public BioterapeutContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BioterapeutContext>();
            optionsBuilder.UseSqlServer(@"Data Source = ; Initial Catalog = ; Integrated Security=SSPI;");

            return new BioterapeutContext(optionsBuilder.Options);
        }
    }
}
