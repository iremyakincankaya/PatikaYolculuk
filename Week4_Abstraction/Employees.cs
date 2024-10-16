using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Abstraction

{
 
    public abstract class Employees
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string department { get; set; }

        public Employees(string Name, string Surname, string Department)
        {
            name = Name;
            surname = Surname;
            department = Department;
        }
        public abstract void Job();
    }
    public class ProjectManager : Employees
    {
        public ProjectManager(string Name, string Surname, string Department) : base(Name, Surname, Department)
        {
        }
        public override void Job()
        {
            Console.WriteLine($"{name} {surname}, I work as a Project Manager.");
        }
    }
}



