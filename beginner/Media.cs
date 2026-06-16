using System.Collections;

namespace beginner;

public class Media
{
    int[] sophia = [93, 87, 98, 95, 100, 0];
    int[] nicolas = [80, 83, 82, 88, 85, 0];
    int[] zahirah = [84, 96, 73, 85, 79, 0];
    int[] jeong = [90, 92, 98, 100, 97, 0];
    int currentAssignments = 5;
    double sophiaMedia, nicolasMedia, zahirahMedia, jeongMedia;

    public void CalculaMedia()
    {
        for (int i = 0; i < currentAssignments; i++)
        {
            sophia[5] += sophia[i];
            nicolas[5] += nicolas[i];
            zahirah[5] += zahirah[i];
            jeong[5] += jeong[i];
        }

        sophiaMedia = (double)sophia[5]/currentAssignments;
        nicolasMedia = (double)nicolas[5]/currentAssignments;
        zahirahMedia = (double)zahirah[5]/currentAssignments;
        jeongMedia = (double)jeong[5]/currentAssignments;

        Console.WriteLine($@"
        Student         Grade
        Sophia          {sophiaMedia}   {CalculaLetra(sophiaMedia)}
        Nicolas         {nicolasMedia}  {CalculaLetra(nicolasMedia)}
        Zahirah         {zahirahMedia}  {CalculaLetra(zahirahMedia)}
        Jeong           {jeongMedia}    {CalculaLetra(jeongMedia)}
        ");
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