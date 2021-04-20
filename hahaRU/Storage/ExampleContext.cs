using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Storage
{
    public class ExampleContext
    {
        public List<Student> Students { get; set; }
        public List<Group> Groups { get; set; }

        public ExampleContext()
        {
            Students = new List<Student>();
            Groups = new List<Group>();

            var group1 = new Group(Guid.NewGuid(), "ИДБ-19-01", "ИТиВС ПО");
            var group2 = new Group(Guid.NewGuid(), "ИДБ-19-02", "ИТиВС ПО");
            var group3 = new Group(Guid.NewGuid(), "ИДБ-19-03", "ИТиВС ПО");
            var group4 = new Group(Guid.NewGuid(), "ИДБ-19-04", "ИТиВС Аналитика");

            Students.Add(new Student(Guid.NewGuid(), "Владислав", "Моисеев", group1));
            Students.Add(new Student(Guid.NewGuid(), "Дмитрий", "Адищев", group1));
            Students.Add(new Student(Guid.NewGuid(), "Василий", "Шелекасов", group1));
            Students.Add(new Student(Guid.NewGuid(), "Денис", "Комарков", group2));
            Students.Add(new Student(Guid.NewGuid(), "Даниил", "Герасимов", group2));
            Students.Add(new Student(Guid.NewGuid(), "Иван", "Штыков", group2));
            Students.Add(new Student(Guid.NewGuid(), "Никита", "Паничев", group3));
            Students.Add(new Student(Guid.NewGuid(), "Леонид", "Ахмедьянов", group3));
            Students.Add(new Student(Guid.NewGuid(), "Роман", "Шумилов", group3));
            Students.Add(new Student(Guid.NewGuid(), "Анастасия", "Накленова", group4));
            Students.Add(new Student(Guid.NewGuid(), "Данил", "Ахметов", group4));
            Students.Add(new Student(Guid.NewGuid(), "Руслан", "Хакимов", group4));

            Groups.Add(group1);
            Groups.Add(group2);
            Groups.Add(group3);
            Groups.Add(group4);
        }

    }
}
