namespace beginner;

class Course
{
    public string Name { get; set; }
    public double Grade { get; set; }
    public int CreditHours { get; set; }

    public Course(string name, double grade, int creditHours)
    {
        Name = name;
        Grade = grade;
        CreditHours = creditHours;
    }
    //comment for commit;
}