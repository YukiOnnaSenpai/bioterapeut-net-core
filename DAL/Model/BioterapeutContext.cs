using BioterapeutDAL.Models.Classes;
using Microsoft.EntityFrameworkCore;

namespace BioterapeutDAL.Models
{
    public class BioterapeutContext : DbContext
    {
        public BioterapeutContext(DbContextOptions options) : base(options) { }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Label> Label { get; set; }
        public DbSet<LabelTranslation> LabelTranslations { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Merchendise> Merchendise { get; set; }
        public DbSet<RelationUserAppointment> RelationUserAppointment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Label>().HasMany(u => u.Merchendises).WithOne(l => l.RefLabelId);
            modelBuilder.Entity<Label>().HasMany(u => u.LabelTranslations).WithOne(l => l.RefLabelId);
            modelBuilder.Entity<Label>().HasMany(u => u.Appointments).WithOne(l => l.RefLabelId);
            modelBuilder.Entity<ApplicationUser>().HasMany(u => u.RelationUserAppointments).WithOne(a => a.RefUserId);
            modelBuilder.Entity<Appointment>().HasMany(u => u.RelationUserAppointments).WithOne(a => a.RefAppointmentId);
            modelBuilder.Entity<Location>().HasMany(u => u.Users).WithOne(a => a.RefLocationId);
            modelBuilder.Entity<Location>().HasMany(u => u.Appointments).WithOne(a => a.RefLocationId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-UG4V85N; Initial Catalog = Bioterapeut.NET; Integrated Security=SSPI;");
        }
    }
}
