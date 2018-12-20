using System.ComponentModel.DataAnnotations;

namespace EFDemo.Models.Entities
{
    public abstract class Person
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
