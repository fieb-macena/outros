namespace beginner;

public class Conversion()
{
    public static void Start()
    {
        string[] values = { "12.3", "45", "ABC", "11", "DEF" };
        string text = "";
        double sum = 0;

        foreach (string value in values)
        {
            if(double.TryParse(value,out double n))
                sum += n;
            else
                text += value;
        }

        Console.WriteLine($"Message: {text}\nTotal: {sum}");
    }
}