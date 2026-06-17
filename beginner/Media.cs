using System.Collections;

namespace beginner;

public class Media
{
    readonly int currentAssignments = 5;
    double sophiaMedia, nicolasMedia, zahirahMedia, jeongMedia;

    public void Main()
    {
        int[] sophia = [93, 87, 98, 95, 100, 0];
        int[] nicolas = [80, 83, 82, 88, 85, 0];
        int[] zahirah = [84, 96, 73, 85, 79, 0];
        int[] jeong = [90, 92, 98, 100, 97, 0];

        sophiaMedia = CalculaMedia(sophia);
        nicolasMedia = CalculaMedia(nicolas);
        zahirahMedia = CalculaMedia(zahirah);
        jeongMedia = CalculaMedia(jeong);

        Console.WriteLine($@"
        Student         Grade
        Sophia          {sophiaMedia}       {CalculaLetra(sophiaMedia)}
        Nicolas         {nicolasMedia}       {CalculaLetra(nicolasMedia)}
        Zahirah         {zahirahMedia}       {CalculaLetra(zahirahMedia)}
        Jeong           {jeongMedia}       {CalculaLetra(jeongMedia)}");
    }

    public double CalculaMedia(int[] notas)
    {
        for (int i = 0; i < currentAssignments; i++)
        {
            notas[currentAssignments] += notas[i];
        }
        return (double)notas[currentAssignments] / currentAssignments;
    }

    static string CalculaLetra(double media)
    {
        return media switch
        {
            > 96 => "A+",
            > 92 => "A",
            > 89 => "A-",
            > 86 => "B+",
            > 82 => "B",
            _ => "",
        };
    }
}