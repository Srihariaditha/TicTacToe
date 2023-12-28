using System.Data.Common;
using System.Diagnostics.Metrics;
using TiTacToe.Models;
using TiTacToe.Strategies.WinningStrategies;
namespace TiTacToe.Factories
{
    public class GameWinningStrategyFactory
    {
        public static GameWinningStrategy  GetGameWinningStrategyByName(GameWinningStrategyName GameWinningStrategy)
        {
            switch (GameWinningStrategy)
            {
                case GameWinningStrategyName.COLUMN:
                    return new NotGonnaWinGameWinningStrategy();

                //case GameWinningStrategy.ROW: null;
                //case GameWinningStrategy.DIAGONAL: null;
                //case GameWinningStrategy.CORNER: null;
            };
            return new NotGonnaWinGameWinningStrategy();
        }

        public GameWinningStrategyName CreateBotPlayingStrategyForDifficultyLevel(BotDifficultyLevel difficultyLevel)
        {

            GameWinningStrategyName strategy = GameWinningStrategyName.CORNER;

            switch (difficultyLevel)
            {
                case BotDifficultyLevel.EASY:
                case BotDifficultyLevel.MEDIUM:
                case BotDifficultyLevel.HARD:
                    {
                        strategy = GameWinningStrategyName.ROW;
                        break;
                    }

                default:
                    strategy = GameWinningStrategyName.COLUMN;
                    break;
            };
            return strategy;

        }
    }
}
