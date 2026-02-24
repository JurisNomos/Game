Console.WriteLine("Please type your name");

var name = Console.ReadLine();
var date = DateTime.UtcNow;

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

if (gameSelected.Trim().ToLower() == "a")
{
    AdditionGame("Addition game selected");
}
else if (gameSelected.Trim().ToLower() == "s")
{
    SubtractionGame("Subtraction game selected");
}
else if (gameSelected.Trim().ToLower() == "m")
{
    MultiplicationGame("Multiplication game selected");
}
else if (gameSelected.Trim().ToLower() == "d")
{
    DivisionGame("Division game selected");
}
else if (gameSelected.Trim().ToLower() == "q")
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}
else
{
    Console.WriteLine("Invalid input");
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

