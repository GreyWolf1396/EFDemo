using System.Data.Entity;
using EFDemo.Models.Entities;

namespace EFDemo.DAL
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext() : base("DemoConnection")
        {
            Database.SetInitializer(new Initializer());
        }

        public DbSet<Person> People { get; set; }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<JournalRecord> Records { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Mentor>().ToTable("Mentor");
        }
    }
}
