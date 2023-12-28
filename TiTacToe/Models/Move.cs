namespace TiTacToe.Models
{
    public class Move
    {
        public int row { get; set; }
        public int col { get; set; }

        public Player player { get; set; }

        public Move(int row, int col, Player player)
        {
            this.row = row;
            this.col = col;
            this.player = player;
        }

    }
}
