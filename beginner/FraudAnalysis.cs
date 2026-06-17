#pragma warning disable IDE0044
using System.Runtime.CompilerServices;

namespace beginner;

class FraudAnalysis
{
    string[] fraudulentOrderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
    int[] inventory = { 200, 450, 700, 175, 250 };
    public void Start()
    {
        // fraudulentOrderIDs[0] = "A123";
        // fraudulentOrderIDs[1] = "B456";
        // fraudulentOrderIDs[2] = "C789";

        // Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        // Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        // Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        // fraudulentOrderIDs[0] = "F000";

        // Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

        // Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

        // int sum = 0;
        // int bin = 0;
        // foreach (int items in inventory)
        // {
        //     sum += items;
        //     bin++;
        //     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        // }
        // Console.WriteLine($"We have {sum} items in inventory.");

        foreach (string order in fraudulentOrderIDs)
        {
            if (order.StartsWith("B", StringComparison.CurrentCultureIgnoreCase))
                Console.WriteLine(order);
        }
    }
}