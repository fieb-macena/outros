// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
bool validEntry = false;

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "?";
            //animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPhysicalDescription = "tbd";
            //animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalPersonalityDescription = "";
            //animalNickname = "lola";
            animalNickname = "";
            break;
        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        case 3:
            animalSpecies = "dog";
            animalID = "d3";
            animalAge = "5";
            animalPhysicalDescription = "medium black, white and brown female weighing about 20kg.";
            animalPersonalityDescription = "friendly and lazy";
            animalNickname = "Luna";
            break;
        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }


    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

do
{
    //Console.Clear();
    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // Console.WriteLine($"You selected menu option {menuSelection}.");
    // Console.WriteLine("Press the Enter key to continue");
    // readResult = Console.ReadLine();

    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("\nPress the Enter key to continue.");
            Console.ReadKey();
            break;
        case "2":
            string anotherPet = "y";
            int petCount = 0;

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("Pet limit reached\n");
                break;
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");

                while (anotherPet == "y" && petCount < maxPets)
                {
                    do
                    {
                        Console.WriteLine("Type \"dog\" for a new dog entry and \"cat\" for cat entry");
                        readResult = Console.ReadLine().ToLower();
                        if (readResult == "dog" || readResult == "cat")
                            validEntry = true;
                        animalSpecies = readResult;
                    } while (!validEntry);
                    validEntry = false;

                    do
                    {
                        Console.WriteLine("Enter the pet's age or enter ? if unknown");
                        readResult = Console.ReadLine().ToLower();
                        if (readResult != null && (int.TryParse(readResult, out int number) || readResult == "?"))
                            validEntry = true;
                        animalAge = readResult;
                    } while (!validEntry);
                    validEntry = false;

                    Console.WriteLine("Enter the pet's nickname");
                    readResult = Console.ReadLine();
                    if (readResult == "" || readResult == null)
                        animalNickname = "tbd";
                    else
                        animalNickname = readResult;

                    Console.WriteLine("Enter the pet's physical description");
                    readResult = Console.ReadLine();
                    if (readResult == "" || readResult == null)
                        animalPhysicalDescription = "tbd";
                    else
                        animalPhysicalDescription = readResult;

                    Console.WriteLine("Enter the pet's personality description");
                    readResult = Console.ReadLine();
                    if (readResult == "" || readResult == null)
                        animalPersonalityDescription = "tbd";
                    else
                        animalPersonalityDescription = readResult;



                    animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                    ourAnimals[petCount, 0] = "ID #: " + animalID;
                    ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                    ourAnimals[petCount, 2] = "Age: " + animalAge;
                    ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                    ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                    ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                    Console.WriteLine("\nPet successfully added\n");

                    petCount++;

                    do
                    {
                        Console.WriteLine("Do you want to add another pet? type \"y\" or \"n\"");
                        anotherPet = Console.ReadLine().ToLower();
                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }
            Console.ReadKey();
            break;
        case "3":
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    if (ourAnimals[i, 2] == "" || ourAnimals[i, 2] == "Age: ?" || ourAnimals[i, 2] == "Age: ")
                    {
                        Console.WriteLine($"The pet ({ourAnimals[i, 0]}) age is not defined, please insert an updated value");
                        do
                        {
                            readResult = Console.ReadLine();
                            if (int.TryParse(readResult, out int number))
                            {
                                validEntry = true;
                                ourAnimals[i, 2] = $"Age: {readResult}";
                            }
                            else
                            {
                                Console.WriteLine("Insert a valid value");
                            }
                        } while (!validEntry);
                        validEntry = false;
                    }

                    if (ourAnimals[i, 4] == "Physical description: tbd" || ourAnimals[i, 4] == "" || ourAnimals[i, 4] == "Physical description: ")
                    {
                        Console.WriteLine($"The pet ({ourAnimals[i, 0]}) physical description is not defined, please insert an updated value");
                        do
                        {
                            readResult = Console.ReadLine();
                            if (readResult == null || readResult == "" || readResult == "tbd")
                            {
                                Console.WriteLine("Insert a valid value");
                            }
                            else
                            {
                                validEntry = true;
                                ourAnimals[i, 4] = $"Physical description: {readResult}";
                            }
                        } while (!validEntry);
                        validEntry = false;
                    }
                }
            }
            Console.WriteLine("\nAll animals have valid age and description.\nPress the Enter key to continue.\n");
            Console.ReadKey();
            break;
        case "4":
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    if (ourAnimals[i, 3] == "" || ourAnimals[i, 3] == "Nickname: tbd"  || ourAnimals[i, 3] == "Nickname: ")
                    {
                        Console.WriteLine($"The pet ({ourAnimals[i, 0]}) nickname is not defined, please insert an updated value");
                        do
                        {
                            readResult = Console.ReadLine();
                            if (readResult == null || readResult == "" || readResult == "tbd")
                            {
                                Console.WriteLine("Insert a valid value");
                            }
                            else
                            {
                                validEntry = true;
                                ourAnimals[i, 3] = $"Nickname: {readResult}";
                            }
                        } while (!validEntry);
                        validEntry = false;
                    }

                    if (ourAnimals[i, 5] == "Personality: tbd" || ourAnimals[i, 5] == "" || ourAnimals[i, 5] == "Personality: ")
                    {
                        Console.WriteLine($"The pet ({ourAnimals[i, 0]}) personality is not defined, please insert an updated value");
                        do
                        {
                            readResult = Console.ReadLine();
                            if (readResult == null || readResult == "" || readResult == "tbd")
                            {
                                Console.WriteLine("Insert a valid value");
                            }
                            else
                            {
                                validEntry = true;
                                ourAnimals[i, 5] = $"Personality: {readResult}";
                            }
                        } while (!validEntry);
                        validEntry = false;
                    }
                }
            }
            Console.WriteLine("\nAll animals have valid nickname and personality.\nPress the Enter key to continue.\n");
            Console.ReadKey();
            break;
        case "5":
            break;
        case "6":
            break;
        case "7":
            break;
        case "8":
            break;
        default:
            break;
    }

} while (menuSelection != "exit");