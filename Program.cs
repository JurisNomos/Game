Console.WriteLine("Please type your name");

var name = Console.ReadLine();
var date = DateTime.UtcNow;

Menu(name, date);

void Menu(string name, DateTime date)
{
    Console.WriteLine("---");
    Console.WriteLine($"Hello {name}. It's {date}. This is your math's game. That's great that you're working on improving yourself");
    Console.WriteLine("\n");
    Console.WriteLine(@$"What game would you like to play today? Choose from the options below: 
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
    Console.WriteLine("---");

    var gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition game selected");
            break;
        case "s":
            SubtractionGame("Subtraction game selected");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected");
            break;
        case "d":
            DivisionGame("Division game selected");
            break;
        case "q":
            Console.WriteLine("Goodbye");
            break;
        default:
            Console.WriteLine("Invalid input");
            Environment.Exit(1);
            break;
    }
}

void AdditionGame(String message)
{
    Console.WriteLine(message);
}

void SubtractionGame(String message)
{
    Console.WriteLine(message);
}

void MultiplicationGame(String message)
{
    Console.WriteLine(message);
}

void DivisionGame(String message)
{
    Console.WriteLine(message);
}
