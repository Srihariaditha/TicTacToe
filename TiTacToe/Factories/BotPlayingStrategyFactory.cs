using TiTacToe.Models;
using TiTacToe.Strategies.BotStrategies;

namespace TiTacToe.Factories
{
    public class BotPlayingStrategyFactory
    {
        public static BotPlayingStrategy GetBotPlayingStrategyFactoryByDifficultyLevel(BotDifficultyLevel botDifficultyLevel)
        {
            switch (botDifficultyLevel)
            {
                case BotDifficultyLevel.HARD:
                    return new RandomBotPlayingStrategy();
            }
            return new RandomBotPlayingStrategy();
        }
    }
}
