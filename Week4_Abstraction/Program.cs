using System.Runtime.ConstrainedExecution;
using System;

namespace Week4_Abstraction
{
    public class Program
    {
        public void Main(string[] args)
        {
           ProjectManager person1 = new ProjectManager("Hasan", "Çıldırmış","Project Deparmant");
            person1.Job();

            Console.ReadKey();
        }
    }
}
