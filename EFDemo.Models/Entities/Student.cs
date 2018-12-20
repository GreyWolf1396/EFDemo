using System.Collections.Generic;

namespace EFDemo.Models.Entities
{
    public class Student : Person
    {
        public int MentorId { get; set; }

        public virtual Mentor Mentor { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
