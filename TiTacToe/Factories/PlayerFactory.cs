using TiTacToe.Models;

namespace TiTacToe.Factories
{
    public class PlayerFactory
    {
        public static Player CreateHumanPlayer(string name, char c)
        {
            Player player = new Player();
            player.playerType = PlayerType.HUMAN;
            player.name = name;
            player.symbol = new Symbol(Convert.ToChar(c));

            return player;
        }

        public static Player CreateBotPlayer(string name, char c, BotDifficultyLevel level)
        {
            Bot bot = new Bot(level);
            bot.playerType = PlayerType.BOT;
            bot.name = name;
            bot.symbol = new Symbol(Convert.ToChar(c));

            return bot;
        }


    }
}
