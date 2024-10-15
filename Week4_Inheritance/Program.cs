using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Student nesnesi tanımlanıyor.
            Student student1 = new Student();
            student1.FirstName = "İrem";
            student1.LastName = "Kaya";
            student1.OgrenciNo = 12345;

            //Teacher nesnesi tanımlanıyor.
            Teacher teacher1 = new Teacher();
            teacher1.FirstName = "Alaattin";
            teacher1.LastName = "Kaya";
            teacher1.MaasBilgisi = 100000;

            //Ögretmen ve ögrenci bilgileri metod çagrılarak ekrana yazdırılır.
            student1.Bilgiler();
            teacher1.Bilgiler();

            Console.ReadKey();

        }

    }
}
