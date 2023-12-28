using TiTacToe.Models;

namespace TiTacToe.Strategies.BotStrategies
{
    public interface IBotPlayingStrategy
    {
        Move? makeMove(Board board, Player player);
    }
}
