using TiTacToe.Models;

namespace TiTacToe.Strategies.BotStrategies
{
    public class RandomBotPlayingStrategy : BotPlayingStrategy
    {
        public override Move? makeMove(Board board, Player player)
        {
            foreach (List<Cell> rows in board.board)
            {
                foreach (Cell cell in rows)
                {
                    if (cell.player == null)
                    {
                        return new Move(cell.row, cell.col, player);
                    }
                }
            }
            return null;
        }
    }
}
