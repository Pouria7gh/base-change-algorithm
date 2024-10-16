using BaseChangeAlgorithm.converClasses;

bool exit = false;
while(exit == false)
{
    System.Console.WriteLine("------------------------------------------------");
    Console.WriteLine("Insert {1} to convert base 10 into base 2.");
    Console.WriteLine("Insert {2} to convert base 10 into base 8.");
    Console.WriteLine("Insert {3} to convert base 10 into base 16.");
    Console.WriteLine("Insert {0} to exit.");
    System.Console.WriteLine("------------------------------------------------");
    string optionsInput = Console.ReadLine();
    try
    {
        int options = int.Parse(optionsInput);
        string numberInput;
        switch(options)
        {
            case 1:
                Console.WriteLine("Enter your number:");
                numberInput = Console.ReadLine();
                try
                {
                    int number = int.Parse(numberInput);
                    Console.WriteLine($"Your number's equivalent in base 2: {Binary.ConvertToBinary(number)}\nPress any key to continue...");
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("Wrong input value");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            break;
            case 2:
                Console.WriteLine("Enter your number:");
                numberInput = Console.ReadLine();
                try
                {
                    int number = int.Parse(numberInput);
                    Console.WriteLine($"Your number's equivalent in base 8: {Octal.ConvertToOctal(number)}\nPress any key to continue...");
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("Wrong input value");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            break;
            case 3:
                Console.WriteLine("Enter your number:");
                numberInput = Console.ReadLine();
                try
                {
                    int number = int.Parse(numberInput);
                    Console.WriteLine($"Your number's equivalent in base 16: {Hexadecimal.ConvertToHexadecimal(number)}\nPress any key to continue...");
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("Wrong input value");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            break;
            case 0:
                exit = true;
                Console.WriteLine("Thanks for checking out <3 \nPress any key to exit...");
                Console.ReadKey();
            break;
        }
    }
    catch
    {
        Console.WriteLine("Wrong input value");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}