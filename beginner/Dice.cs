namespace beginner;

public class Dice
{
    Random random = new();
    int[] diceRolls = new int[3];
    int points = 0;

    public void Start()
    {
        diceRolls[0] = random.Next(1, 7);
        diceRolls[1] = random.Next(1, 7);
        diceRolls[2] = random.Next(1, 7);

        points = diceRolls[0] + diceRolls[1] + diceRolls[2];

        if (diceRolls[0] == diceRolls[1] || diceRolls[1] == diceRolls[2] || diceRolls[0] == diceRolls[2])
        {
            if (diceRolls[0] == diceRolls[1] && diceRolls[1] == diceRolls[2])
                points += 6;
            else
                points += 2;
        }

        Console.WriteLine($"roll 1: {diceRolls[0]}\nroll 2: {diceRolls[1]}\nroll 3: {diceRolls[2]}\n\nTotal points: {points}");

        // if (points > 15)
        //     Console.WriteLine("\nYou Won!");
        // else
        //     Console.WriteLine("\nYou Lost!");

        switch (points)
        {
            case >= 16 : Console.WriteLine("\nYou won a car!"); break;
            case >= 10 : Console.WriteLine("\nYou won a notebook!"); break;
            case 7 : Console.WriteLine("\nYou won a trip for two!"); break;
            default : Console.WriteLine("\nYou won a kitten!"); break;
        }
    }
}