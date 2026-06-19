using System.Collections;

namespace beginner;

class DoWhileComparison
{
    public static void Start1()
    {
        string? userInput;
        int chosenNumber = 0;
        bool validInput = false;
        
        do
        {
            Console.WriteLine("Insira um número entre 5 e 10");
            userInput = Console.ReadLine();

            if (userInput != null)
            {
                validInput = int.TryParse(userInput, out chosenNumber);
            }
        }while((validInput && chosenNumber > 4 && chosenNumber < 11) == false);

        Console.WriteLine("Input Accepted");
    }

    public static void Start2()
    {
        string? userInput;
        bool validInput = false;
        string[] cargos = ["advogado","desenvolvedor","professor"];
        Console.WriteLine("Insira o seu cargo");
        
        do
        {
            userInput = Console.ReadLine();

            if (userInput != null)
            {
                foreach(string cargo in cargos)
                {
                    if(cargo == userInput.ToLower().Trim()) validInput = true;
                }
            }
            Console.WriteLine(validInput ? "" : "\nInsira um cargo válido.");
        }while(!validInput);

        Console.WriteLine($"Cargo aceito");
    }
}