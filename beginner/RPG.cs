namespace beginner;

public class RPG
{
    public static void Start()
    {
        int heroHealth = 20;
        int monsterHealth = 20;
        Random random = new();

        while (heroHealth > 0 && monsterHealth > 0)
        {
            int diceRoll = random.Next(1, 5);
            monsterHealth -= diceRoll;

            if (monsterHealth > 0)
            {
                diceRoll = random.Next(1, 5);
                heroHealth -= diceRoll;
            }

            Console.WriteLine($"Vida Herói: {heroHealth} / Vida Monstro {monsterHealth}");
        }

        Console.WriteLine(heroHealth > monsterHealth ? "O herói venceu!" : "O monstro venceu!");
    }
}