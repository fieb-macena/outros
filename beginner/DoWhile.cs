namespace beginner;

class DoWhile
{
    public static void Start()
    {
        Random random = new();
        int current = random.Next(1, 11);

        // do{
        //     current = random.Next(1, 11);
        //     Console.WriteLine(current);
        // } while (current != 7);

        // while (current >= 3)
        // {
        //     Console.WriteLine(current);
        //     current = random.Next(1, 11);
        // }
        // Console.WriteLine($"Last number: {current}");

        do
        {
            current = random.Next(1, 11);

            if (current >= 8) continue;

            Console.WriteLine(current);
        } while (current != 7);


    }
}