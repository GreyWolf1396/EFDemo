using System.Data.Entity;
using EFDemo.Models.Entities;

namespace EFDemo.Migration
{
    class DemoContext : DbContext
    {
        public DemoContext() : base("DemoConnection")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DemoContext>());
        }

        public DbSet<Mentor> Mentors { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<JournalRecord> JournalRecords { get; set; }
    }
}
