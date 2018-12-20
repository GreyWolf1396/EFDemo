using System;
using System.Collections.Generic;
using System.Linq;
using EFDemo.DAL;
using EFDemo.Models.Entities;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DemoDbContext();
            Console.WriteLine("Ready to work... \n\n");

            var people = context.People.ToList();
            PrintCollection(people, "People");

            var students = context.People.OfType<Student>().ToList();
            PrintCollection(students, "Students");

            var mentors = context.People.OfType<Mentor>().ToList();
            PrintCollection(mentors, "Mentors");

            Console.ReadKey();
        }
        
        private static void PrintCollection<T>(IEnumerable<T> collection, string name)
        {
            Console.WriteLine($"{name}");
            
            foreach (var element in collection)
            {
                Console.WriteLine(element.ToString());
            }
            Console.WriteLine();
        }
    }
}
