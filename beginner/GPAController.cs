using System.Globalization;
namespace beginner;

class GPA
{
    public void CalculoGPA()
    {
        Course[] courses =
        [
            new Course("English 101",4,3),
            new Course("Algebra 101",3,3),
            new Course("Biology 101",3,4),
            new Course("Computer Science I",3,4),
            new Course("Psychology 101",4,3),
        ];
        var student = new Student("Sophia Johnson",courses);

        Console.WriteLine($"Student: {student.Name}\n");
        Console.WriteLine("Course\t\t\tGrade\t\tCredit Hours");
        foreach(Course c in student.Courses)
            Console.WriteLine($"{c.Name}\t{(c.Name == "Computer Science I"?"":"\t")}{c.Grade}\t\t{c.CreditHours}");
        Console.WriteLine($"\nFinal GPA: {student.GPA.ToString("0.00")}");
    }
}