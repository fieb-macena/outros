using System.Globalization;

namespace beginner;

public class Formatting
{
    public static void Composite()
    {
        string first = "Hello";
        string second = "World";
        string result = string.Format("{0} {1}!", first, second);
        string result2 = string.Format("{0} {1} {0}!", first, second);
        Console.WriteLine($"{result} \n{result2}");
    }

    public static void Interpolation()
    {
        string first = "Hello";
        string second = "World";
        Console.WriteLine($"{first} {second}!");
        Console.WriteLine($"{second} {first}!");
        Console.WriteLine($"{first} {first} {first}!");
    }

    public static void Currency()
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");
        decimal price = 123.45m;
        int discount = 50;
        Console.WriteLine($"Price: {price:C} (Save {discount:C})");

        decimal measurement = 123456.78912m;
        Console.WriteLine($"Measurement: {measurement:N2} units");

        decimal tax = .36785m;
        Console.WriteLine($"Tax rate: {tax:P2}");
    }

    public static void Combining()
    {
        decimal price = 67.55m;
        decimal salePrice = 59.99m;

        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");
        string yourDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price. ", price - salePrice, price);
        yourDiscount += $"A discount of {(price - salePrice) / price:P2}!";
        Console.WriteLine(yourDiscount);
    }

    public static void Invoice()
    {
        int invoiceNumber = 1201;
        decimal productShares = 25.4568m;
        decimal subtotal = 2750.00m;
        decimal taxPercentage = .15825m;
        decimal total = 3185.19m;

        Console.WriteLine($"\n\nInvoice Number: {invoiceNumber}");
        Console.WriteLine($"   Shares: {productShares:N3} Product");
        Console.WriteLine($"     Sub Total: {subtotal:C}");
        Console.WriteLine($"           Tax: {taxPercentage:P2}");
        Console.WriteLine($"     Total Billed: {total:C}");

        Console.WriteLine();
    }

    public static void Teste()
    {
        string p = "macena";
        string p2 = "jul";

        Console.WriteLine($"{p.PadRight(10, '-').PadLeft(20, '-')}\n{p2.PadRight(10, '-').PadLeft(20, '-')}");
    }

    public static void Padding()
    {
        string paymentId = "769C";
        string payeeName = "Mr. Stephen Ortega";
        string paymentAmount = "$5,000.00";

        var formattedLine = paymentId.PadRight(6);
        formattedLine += payeeName.PadRight(24);
        formattedLine += paymentAmount.PadLeft(10);

        Console.WriteLine("1234567890123456789012345678901234567890");
        Console.WriteLine(formattedLine);
    }

    public static void Exercise()
    {
        string customerName = "Ms. Barros";

        string currentProduct = "Magic Yield";
        int currentShares = 2975000;
        decimal currentReturn = 0.1275m;
        decimal currentProfit = 55000000.0m;

        string newProduct = "Glorious Future";
        decimal newReturn = 0.13125m;
        decimal newProfit = 63000000.0m;

        Console.WriteLine($"Dear {customerName},\nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
        Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n\nOur new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.");

        Console.WriteLine("Here's a quick comparison:\n");

        string comparisonMessage = "";

        comparisonMessage += $"{currentProduct.PadRight(20)}{String.Format("{0:P}", currentReturn).PadRight(10)}{String.Format("{0:C}", currentProfit).PadRight(20)}";
        comparisonMessage += $"\n{newProduct.PadRight(20)}{String.Format("{0:P}", newReturn).PadRight(10)}{String.Format("{0:C}", newProfit).PadRight(20)}";

        Console.WriteLine(comparisonMessage);
    }
}