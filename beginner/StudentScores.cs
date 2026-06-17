namespace beginner.scores;

class StudentScores
{
    public void Start()
    {
        int currentAssignments = 5;

        Student[] students = new Student[8];
        students[0] = new Student("Sophia", [90, 86, 87, 98, 100, 94, 90]);
        students[1] = new Student("Andrew", [92, 89, 81, 96, 90, 89]);
        students[2] = new Student("Emma", [90, 85, 87, 98, 68, 89, 89, 89]);
        students[3] = new Student("Logan", [90, 95, 87, 88, 96, 96]);
        students[4] = new Student("Becky", [92, 91, 90, 91, 92, 92, 92]);
        students[5] = new Student("Chris", [84, 86, 88, 90, 92, 94, 96, 98]);
        students[6] = new Student("Eric", [80, 90, 100, 80, 90, 100, 80, 90]);
        students[7] = new Student("Gregor", [91, 91, 91, 91, 91, 91, 91]);

        decimal normalGrades, extraGrades, totalGpa, normalGpa;
        string gradeLetter;
        string finalMessage = "\nStudent\t\tGrade\t\tOverall Grade\t\tExtra Credit\n\n";
        int extraGradesCount;

        foreach (Student student in students)
        {
            normalGrades = 0;
            extraGrades = 0;
            totalGpa = 0;
            extraGradesCount = 0;

            //scores above the number of currentAssignments are extra scores and worth 10% of a normal exam
            for (int i = 0; i < student.scores.Length; i++)
            {
                if (i >= currentAssignments)
                {
                    extraGrades += student.scores[i];
                    extraGradesCount++;
                }
                else
                    normalGrades += student.scores[i];
            }

            normalGpa = normalGrades / currentAssignments;
            totalGpa = (normalGrades + extraGrades / 10) / currentAssignments;

            gradeLetter = totalGpa switch
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

            finalMessage += $"{student.name}\t\t{normalGpa}\t\t{totalGpa}\t{gradeLetter}\t\t{extraGrades/extraGradesCount} ({totalGpa-normalGpa}  pts)\n";
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