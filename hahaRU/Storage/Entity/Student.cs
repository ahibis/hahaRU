using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Storage.Entity
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Group Group { get; set; }
        public Student(Guid id, string name, string lastName, Group group)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Group = group;
        }
    }
}
