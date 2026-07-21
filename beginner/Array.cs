namespace beginner;

public class ArrayManipulation
{
    public static void Start()
    {
        string pangram = "The quick brown fox jumps over the lazy dog";
        string[] words = pangram.Split();
        pangram = "";
        for (int i = 0; i<words.Length; i++)
        {
            var temp = words[i].ToCharArray();
            Array.Reverse(temp);
            words[i] = new string(temp);
            pangram += words[i] + " ";
        }
        
        Console.WriteLine(pangram);
    }

    public static void Orders()
    {
        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
        string[] orders = orderStream.Split(",");
        Array.Sort(orders);
        for (int i = 0; i < orders.Length; i++)
        {
            if(orders[i].Length != 4)
                orders[i] = orders[i] + " - Error";
            
            Console.WriteLine(orders[i]);
        }

    }
}