using System.ComponentModel.DataAnnotations;

namespace EFDemo.Models.Entities
{
    public class JournalRecord
    {
        [Key]
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        [Key]
        public int TaskId { get; set; }

        public virtual Task Task { get; set; }

        public bool IsDone { get; set; }
    }
}
