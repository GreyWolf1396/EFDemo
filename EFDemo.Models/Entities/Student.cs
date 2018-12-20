using System.Collections.Generic;
using System.Linq;

namespace EFDemo.Models.Entities
{
    public class Student : Person
    {
        public int MentorId { get; set; }

        public virtual Mentor Mentor { get; set; }

        public virtual ICollection<JournalRecord> Records { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"    Mentor: {Mentor.Name}    Tasks finished: {Records.Count(r => r.IsDone)}";
        }
    }
}
