namespace beginner;

class Student
{

    public string Name { get; set; }
    public Course[] Courses { get; set; }
    public double GPA { get; set; }

    public Student(string name, Course[] courses)
    {
        Name = name;
        Courses = courses;

        double totalCreditHours = 0;
        double totalGradePoints = 0;
        foreach (Course x in courses)
        {
            totalCreditHours += x.CreditHours;
            totalGradePoints += x.Grade * x.CreditHours;
        }
        GPA = totalGradePoints / totalCreditHours;
    }

}