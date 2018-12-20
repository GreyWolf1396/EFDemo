using System.Data.Entity;
using EFDemo.Models.Entities;

namespace EFDemo.DAL
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext() : base("DemoConnection") { }

        public DbSet<Person> People { get; set; }

        //public DbSet<Task> Tasks { get; set; }

        //public DbSet<JournalRecord> Records { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            ////Table_Per_Type
            //modelBuilder.Entity<Student>().ToTable("Student");
            //modelBuilder.Entity<Mentor>().ToTable("Mentor");

            ////Table_Per_Class
            //modelBuilder.Entity<Student>().Map(m =>
            //{
            //    m.MapInheritedProperties();
            //    m.ToTable("Student");
            //});
            //modelBuilder.Entity<Mentor>().Map(m =>
            //{
            //    m.MapInheritedProperties();
            //    m.ToTable("Mentor");
            //});
        }
    }
}
