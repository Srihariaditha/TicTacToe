using System.Transactions;
using TiTacToe.Factories;
using TiTacToe.Strategies.BotStrategies;

namespace TiTacToe.Models
{
    public class Bot : Player
    {
        public BotDifficultyLevel botDifficultyLevel { get; set; }
        public BotPlayingStrategy botPlayingStrategy { get; set; }
        public Bot(BotDifficultyLevel botDifficultyLevel)
        {
            this.botDifficultyLevel = botDifficultyLevel;
            this.botPlayingStrategy = BotPlayingStrategyFactory.GetBotPlayingStrategyFactoryByDifficultyLevel(this.botDifficultyLevel);
        }

        public override Move makeMove(Board board)
        {
            return botPlayingStrategy.makeMove(board, this);
        }
    }
}
