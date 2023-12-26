using TiTacToe.Models;

namespace TiTacToe.Factories
{
    public class BotDifficultyLevelFactory
    {
        public static BotDifficultyLevel GetBotDifficultyLevelByName(String s) {
            BotDifficultyLevel bdl;
            switch (s)
            {
                case "EASY":
                    bdl = BotDifficultyLevel.EASY;
                    break;
                case "MEDIUM":
                    bdl = BotDifficultyLevel.MEDIUM;
                    break;
                default:
                    bdl = BotDifficultyLevel.EASY;
                    break;
            }
            return bdl;
        }
    }
}
