using System;
using TiTacToe.Models;

namespace TiTacToe.Strategies.WinningStrategies
{
    public class GameWinningStrategy
    {
        public virtual bool checkVictory(Board board, Move lastMove)
        {
            return false;
        }
    }
}
