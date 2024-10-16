namespace Week4_Abstraction1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employees employee = new ProjectManager("Hasan", "Çıldırmış");
            employee.Job();

            Console.ReadKey();
        }
    }
}
