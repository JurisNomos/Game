namespace MyFirstProgram
{
    internal class Helpers
    {
        static List<string> games = [];

        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(1, 100);
            var secondNumber = random.Next(1, 100);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 100);
                secondNumber = random.Next(1, 100);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("---");
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("---\n");
            Console.WriteLine("Press any key to return to main menu");
            Console.ReadLine();
        }

        internal static void AddToHistory(int gameScore, string gameType)
        {
            games.Add($"{DateTime.Now} - {gameType}: {gameScore} pts");
        }

    }
}