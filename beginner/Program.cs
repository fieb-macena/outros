using System.Security.Cryptography;
using beginner;

// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "A ";
// Console.WriteLine(myValue.Trim().ToLower() == "a");

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));

// int saleAmount = 1001;
// //int discount = saleAmount > 1000 ? 100 : 50;
// //Console.WriteLine($"Discount: {discount}");
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// Random coin = new Random();
// for (int i = 0; i < 10; i++)
// {
//     int coinToss = coin.Next(2);
//     Console.WriteLine(coinToss == 0 ? "Heads" : "Tails");
// }

// string permission = "asd";
// int level = 19;

// if(permission.Contains("Admin"))
// {
//     Console.WriteLine($"Welcome,{(level > 55 ? " Super": "")} Admin user");
// }
// else if (permission.Contains("Manager"))
// {
//     Console.WriteLine(level >= 20 ? "Contact an Admin for access.": "You do not have sufficient privileges.");
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }

// Console.WriteLine("Teste\tTeste\\\"teste\"");
// // Kon'nichiwa World
// Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
// Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// // User command to run an application
// Console.WriteLine(@"c:\invoices\app.exe -j");

// string projectName = "ACME";

// string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

// Console.WriteLine($"View English output:\n\tc:\\Exercise\\{projectName}\\data.txt");
// Console.WriteLine($"{russianMessage}:\n\tc:\\Exercise\\{projectName}\\ru-RU\\data.txt");

new Media().CalculaMedia();
