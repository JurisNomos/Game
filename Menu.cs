namespace Game
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void showMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine($"Hello {name}. It's {date}. This is your math's game. That's great that you're working on improving yourself\n");
            Console.WriteLine("Press any key to show menu");
            Console.ReadLine();
            Console.WriteLine("\n");

            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($"What game would you like to play today? Choose from the options below:");
                Console.WriteLine("---");
                Console.WriteLine("V - View Previous Games\nA - Addition\nS - Subtraction\nM - Multplication\nD - Division\nQ - Quit game");
                Console.WriteLine("---");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.getGame();
                        break;
                    case "a":
                        gameEngine.additionGame("Addition game");
                        break;
                    case "s":
                        gameEngine.subtractionGame("Subtraction game");
                        break;
                    case "m":
                        gameEngine.multplicationGame("Multplication game");
                        break;
                    case "d":
                        gameEngine.divisionGame("Division game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (isGameOn);
        }
    }
}