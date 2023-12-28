using TiTacToe.Models;

namespace TiTacToe.Strategies.WinningStrategies
{
    public class NotGonnaWinGameWinningStrategy : GameWinningStrategy
    {
        public override bool checkVictory(Board board, Move lastMove)
        {
            return false;
        }
    }
}
