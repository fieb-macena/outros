namespace beginner;

public class Renewal
{
    public static void Start()
    {
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        //int discountPercentage = 0;

        switch (daysUntilExpiration)
        {
            case 0 : Console.WriteLine("Your subscription has expired."); break;
            case < 2 : Console.WriteLine($"Your subscription will expire within a day.\nRenew now and save 20%!"); break;
            case < 6 : Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days.\nRenew now and save 10%!"); break;
            case < 11 : Console.WriteLine("Your subscription will expire soon. Renew now!"); break;
            default : break;
        }
    }
}
