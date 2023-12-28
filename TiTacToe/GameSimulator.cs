using TiTacToe.Factories;
using TiTacToe.Models;

namespace TiTacToe
{
    public class GameSimulator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How Many Players?");
            var val = Console.ReadLine();
            int py = Convert.ToInt32(val);
            Console.WriteLine("How Many Bots?");
            int bots = Convert.ToInt32(Console.ReadLine());
            var players = new List<Player>();
            for (int i = 0; i < bots; i++)
            {
                Console.WriteLine($"Name of Bot {i}");
                String botName = Convert.ToString(Console.ReadLine());
                Console.WriteLine($"Symbol of Bot {i + 1}");
                char s = Convert.ToChar(Console.ReadLine());
                Console.WriteLine($"Select Difficulty of bot {i + 1} ");
                string bdlStr = Console.ReadLine();
                BotDifficultyLevel bdl = BotDifficultyLevelFactory.GetBotDifficultyLevelByName(bdlStr);
                players.Add(PlayerFactory.CreateBotPlayer(botName, s, bdl));
            }

            for (int i = bots; i < py; i++)
            {
                Console.WriteLine($"Name of Player {py - i-1}");
                String botName = Convert.ToString(Console.ReadLine());
                Console.WriteLine($"Symbol of Bot {py - i - 1}");
                char s = Convert.ToChar(Console.ReadLine());
                players.Add(PlayerFactory.CreateHumanPlayer(botName, s));
            }

            Console.WriteLine("How Many WSC?");
            int wsc = Convert.ToInt32(Console.ReadLine());
            var gameWinningStrategies = new List<GameWinningStrategyName>();
            for (int i = 0; i < wsc; i++)
            {
                Console.WriteLine($"Strategy {i}");
                string gwsName = Console.ReadLine();
                gameWinningStrategies.Add(GameWinningStrategyEnumFactory.CreateNewGWSByName(gwsName));
            }

            GameBuilder gameBuilder = new GameBuilder();
            Game game = gameBuilder.setPlayers(players)
                .setGameWinningStrategies(gameWinningStrategies) 
                .Build();
            while (game.gameStatus == GameStatus.IN_PROGRESS)
            {
                game.makeMove();
            }
        }
    }
}
// Client -> Main -> Controller -> Models

// person interacts by 1 by 1 giving inputs into the command line and playing the game
// Lifecycle of a game
// 0. Start a game
// 1. Create Players, choose symbols
// 2. Determine the size
// 3. Decide Winning Rules