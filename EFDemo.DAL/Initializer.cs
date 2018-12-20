using System.Data.Entity;
using EFDemo.Models.Entities;

namespace EFDemo.DAL
{
    public class Initializer : CreateDatabaseIfNotExists<DemoDbContext>
    {
        protected override void Seed(DemoDbContext context)
        {
            base.Seed(context);

            context.People.Add(new Mentor
            {
                Id = 1,
                Name = "John",
                Surname = "Doe",
                Title = "Software engineer"
            });

            context.SaveChanges();

            context.People.Add(new Student
            {
                Id = 2,
                Name = "Anna",
                Surname = "Ivanova",
                MentorId = 1
            });

            context.People.Add(new Student
            {
                Id = 3,
                Name = "Ivan",
                Surname = "Petrov",
                MentorId = 1
            });

            context.SaveChanges();

            context.Tasks.Add(new Task
            {
                Description = "Task 1"
            });

            context.Tasks.Add(new Task
            {
                Description = "Task 2"
            });

            context.SaveChanges();

            context.Records.Add(new JournalRecord {StudentId = 2, TaskId = 1, IsDone = true});
            context.Records.Add(new JournalRecord {StudentId = 2, TaskId = 2, IsDone = false});
            context.Records.Add(new JournalRecord {StudentId = 3, TaskId = 1, IsDone = false});
            context.Records.Add(new JournalRecord {StudentId = 3, TaskId = 2, IsDone = false});

            context.SaveChanges();
        }
    }
}
