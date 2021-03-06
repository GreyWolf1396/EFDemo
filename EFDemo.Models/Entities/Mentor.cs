﻿using System.Collections.Generic;

namespace EFDemo.Models.Entities
{
    public class Mentor : Person
    {
        public string Title { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public override string ToString()
        {
            return base.ToString() +$"      Students: {Students.Count}";
        }
    }
}
