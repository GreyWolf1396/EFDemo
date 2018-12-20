using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo.Models.Entities
{
    public class JournalRecord
    {
        [Key]
        [Column(Order = 1)]
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        [Key]
        [Column(Order = 2)]
        public int TaskId { get; set; }

        public virtual Task Task { get; set; }

        public bool IsDone { get; set; }


        public override string ToString()
        {
            return $"{Student.Name} {Student.Surname}    {Task.Description}    {(IsDone ? "Done" : "Not yet")}";
        }
    }
}
