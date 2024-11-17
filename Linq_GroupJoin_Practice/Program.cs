using Linq_GroupJoin_Practice;
//students listesi olusturma
List<Students> students = new List<Students>()
{
    new Students(1,"Ali",1),
    new Students(2,"Ayşe",2),
    new Students(3,"Mehmet",1),
    new Students(4,"Fatma",3),
    new Students(5,"Ahmet",2)
};
//classes listesi oluşturma
List<Classes> classes = new List<Classes>()
{
    new Classes(1, "Matematik"),
    new Classes(2, "Türkçe"),
    new Classes(3, "Kimya")
};
//Her sınıfın altında o sınıfa ait olan öğrencilerin listelendiği bir sonuç elde edin. Sonuçları sınıf adıyla birlikte, o sınıfa ait öğrencilerin isimleriyle birlikte ekrana yazdıran bir LINQ sorgusu yazın.

var result = classes.GroupJoin(students,
    students => students.ClassId,
    classes => classes.ClassId,
    (classes, studentGroups) => new
    {
        Classes = classes,
        StudentsGroup = studentGroups.ToList(),
    });
//classes ana kategorisi altında öğrencileri gruplayıp ekrana yazdırma
foreach (var item in result)
{
    Console.WriteLine($"Class: {item.Classes.ClassName}");
    foreach (var student in item.StudentsGroup)
    {
        Console.WriteLine($"  Student: {student.StudentName}");
    }
}

Console.ReadKey();

