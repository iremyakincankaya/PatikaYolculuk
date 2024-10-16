using System;

namespace Week4_Abstraction1
{
    public abstract class Employees
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }

        public Employees(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
        }

        public abstract void Job();
    }

    public class ProjectManager : Employees
    {
        public ProjectManager(string name, string surname)
            : base(name, surname, "Project Management") // Departmanı sabit olarak belirliyoruz
        {
        }

        public override void Job()
        {
            Console.WriteLine($"{Name} {Surname}, I work as a Project Manager.");
        }
    }
}



