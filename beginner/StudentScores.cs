namespace beginner.scores;

class StudentScores
{
    public void Start()
    {
        // initialize variables - graded assignments 
        int currentAssignments = 5;

        // Students
        Student[] students = new Student[4];
        students[0] = new Student("Sophia", [90, 86, 87, 98, 100]);
        students[1] = new Student("Andrew", [92, 89, 81, 96, 90]);
        students[2] = new Student("Emma", [90, 85, 87, 98, 68]);
        students[3] = new Student("Logan", [90, 95, 87, 88, 96]);

        int sum;
        decimal gpa;
        string gradeLetter;
        string finalMessage = "Student\t\tGrade\n\n";

        foreach (Student student in students)
        {
            sum = 0;
            gpa = 0;

            foreach (int score in student.scores)
            {
                sum += score;
            }

            gpa = (decimal)(sum) / currentAssignments;

            gradeLetter = gpa switch
            {
                > 96 => "A+",
                > 92 => "A",
                > 89 => "A-",
                > 86 => "B+",
                > 82 => "B",
                > 79 => "B-",
                > 76 => "C+",
                > 72 => "C",
                > 69 => "C-",
                > 66 => "D+",
                > 62 => "D",
                > 59 => "D-",
                _ => "F"
            };

            finalMessage += $"{student.name}\t\t{gpa}\t{gradeLetter}\n";
        }

        finalMessage += "\nPress the Enter key to continue";
        Console.WriteLine(finalMessage);
        Console.ReadLine();
    }

    public struct Student(string _name, int[] _scores)
    {
        public string name = _name;
        public int[] scores = _scores;
    }
}