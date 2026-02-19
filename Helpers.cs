using PlayGame;

namespace Game
{
    internal class Helpers
    {
        internal static List<Play> games = new List<Play>
        {
            /*
            new Play { Date = DateTime.Now.AddDays(1), Type = PlayType.Addition, Score = 5 },
            new Play { Date = DateTime.Now.AddDays(2), Type = PlayType.Multiplication, Score = 4 },
            new Play { Date = DateTime.Now.AddDays(3), Type = PlayType.Division, Score = 4 },
            new Play { Date = DateTime.Now.AddDays(4), Type = PlayType.Subtraction, Score = 3 },
            new Play { Date = DateTime.Now.AddDays(5), Type = PlayType.Addition, Score = 1 },
            new Play { Date = DateTime.Now.AddDays(6), Type = PlayType.Multiplication, Score = 2 },
            new Play { Date = DateTime.Now.AddDays(7), Type = PlayType.Division, Score = 3 },
            new Play { Date = DateTime.Now.AddDays(8), Type = PlayType.Subtraction, Score = 4 },
            new Play { Date = DateTime.Now.AddDays(9), Type = PlayType.Addition, Score = 4 },
            new Play { Date = DateTime.Now.AddDays(10), Type = PlayType.Multiplication, Score = 1 },
            new Play { Date = DateTime.Now.AddDays(11), Type = PlayType.Subtraction, Score = 0 },
            new Play { Date = DateTime.Now.AddDays(12), Type = PlayType.Division, Score = 2 },
            new Play { Date = DateTime.Now.AddDays(13), Type = PlayType.Subtraction, Score = 5 },
            */
        };

        internal static void getGame()
        {
            // var gamesToPrint = games.Where(x => x.Date > new DateTime(2022, 08, 09)).OrderByDescending(x => x.Score);

            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("---");

            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} pts");
            }

            Console.WriteLine("---\n");
            Console.WriteLine("Press any key to return to main menu");
            Console.ReadLine();
        }

        internal static void addToHistory(int gameScore, PlayType gameType)
        {
            games.Add(new Play
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }

        internal static int[] getDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(0, 99);
            var secondNumber = random.Next(0, 99);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try again.");
                result = Console.ReadLine();
            }

            return result;
        }

        internal static string getName()
        {
            Console.WriteLine("Please type your name");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name can't be empty");
                name = Console.ReadLine();
            }

            return name;
        }
    }
}