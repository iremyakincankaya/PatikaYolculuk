using System.Threading.Channels;

namespace Week4_Inheritance
{
    public abstract class BaseKisi
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void Bilgiler();
    }
    //Teacher ve Student sınıfları Base i miras alacak.
    public class Teacher : BaseKisi
    {
        public double MaasBilgisi { get; set; }

        public override void Bilgiler()
        {
            Console.WriteLine($"Ögretmen: {FirstName} {LastName} ");
            Console.WriteLine($"Maaşı: {MaasBilgisi}");
        }
    }
    public class Student : BaseKisi
    {
        public int OgrenciNo { get; set; }
        public override void Bilgiler()
        {
            Console.WriteLine($"Ögrenci: {FirstName} {LastName}");
            Console.WriteLine($"Numarası: {OgrenciNo}");
        }
    }
}
