namespace TiTacToe.Models
{
    public class Bot : Player
    {
        private BotDifficultyLevel botDifficultyLevel { get; set; }

        public Bot(BotDifficultyLevel botDifficultyLevel)
        {
            this.botDifficultyLevel = botDifficultyLevel;
        }
    }
}
