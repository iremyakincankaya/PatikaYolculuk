
using Linq_Advanced;

List<Student> students = new List<Student>();

students.Add(new Student { Id = 1, Name ="Ali" });
students.Add(new Student { Id = 2, Name = "Ayşe" });
students.Add(new Student { Id = 3, Name = "Ahmet" });

List<Grade> grades = new List<Grade>();

grades.Add(new Grade { StudentId = 1, Course = "Matematik", Score = 89 });
grades.Add(new Grade { StudentId = 2, Course = "Matematik", Score = 76 });
grades.Add(new Grade { StudentId = 3, Course = "Matematik", Score = 10 });

var studentGrades = students.Join(grades, 
    student => student.Id, 
    grade => grade.StudentId,
    (student,grade) => new
    {
        StutentName =student.Name,
        CourseName = grade.Course,
        Score = grade.Score
    }
    );

foreach (var student in studentGrades)
{
    Console.WriteLine($"Ögrenci Adı: {student.StutentName}, Ders: {student.CourseName}, Not: {student.Score}");
}

var studentsWithGrades = students.GroupJoin(grades,
    student => student.Id,
    grade => grade.StudentId,
    (student, studentGrades) => new 
    {
        StudentName = student.Name,
        Grades = studentGrades,
    });
foreach (var student in studentsWithGrades)
{
    Console.WriteLine(student.StudentName);
    Console.WriteLine("Dersleri>>>");
    foreach ( var grade in student.Grades)
    {
        Console.WriteLine($"Course: {grade.Course}----Score: {grade.Score}");
    }
}

Console.ReadKey();