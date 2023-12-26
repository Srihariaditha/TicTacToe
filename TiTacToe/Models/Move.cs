namespace TiTacToe.Models
{
    public class Move
    {
        public Cell? cell { get; set; }

        public Move(Cell cell, Player player)
        {
            this.cell = cell;
            this.cell.player = player;
        }

    }
}
