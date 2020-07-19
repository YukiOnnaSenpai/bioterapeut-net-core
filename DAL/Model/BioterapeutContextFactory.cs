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
            optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-UG4V85N; Initial Catalog = Bioterapeut.NET; Integrated Security=SSPI;");

            return new BioterapeutContext(optionsBuilder.Options);
        }
    }
}
