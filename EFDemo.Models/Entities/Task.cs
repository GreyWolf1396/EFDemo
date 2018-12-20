using System.ComponentModel.DataAnnotations;

namespace EFDemo.Models.Entities
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }
    }
}
