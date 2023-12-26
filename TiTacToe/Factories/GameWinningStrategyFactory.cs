using System.Data.Common;
using System.Diagnostics.Metrics;
using TiTacToe.Models;
namespace TiTacToe.Factories
{
    public class GameWinningStrategyFactory
    {
        public static GameWinningStrategy  GetGameWinningStrategyByName(GameWinningStrategy GameWinningStrategy)
        {
            switch (GameWinningStrategy)
            {
                case GameWinningStrategy.COLUMN:
                    return GameWinningStrategy.COLUMN;
                    
                //case GameWinningStrategy.ROW: null;
                //case GameWinningStrategy.DIAGONAL: null;
                //case GameWinningStrategy.CORNER: null;
            };
            return GameWinningStrategy.ROW;
        }

        public GameWinningStrategy CreateBotPlayingStrategyForDifficultyLevel(BotDifficultyLevel difficultyLevel)
        {

            GameWinningStrategy strategy = GameWinningStrategy.CORNER;

            switch (difficultyLevel)
            {
                case BotDifficultyLevel.EASY:
                case BotDifficultyLevel.MEDIUM:
                case BotDifficultyLevel.HARD:
                    {
                        strategy = GameWinningStrategy.ROW;
                        break;
                    }

                default:
                    strategy = GameWinningStrategy.COLUMN;
                    break;
            };
            return strategy;

        }
    }
}
