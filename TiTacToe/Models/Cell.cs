namespace TiTacToe.Models
{
    public class Cell
    {
        private int row { get; }
        private int column { get; }
        public Player? player { get; set; }
        private Symbol? symbol { get; set; }

        public Cell(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public Boolean IsEmpty()
        {
            return (symbol == null);
        }

        public void clearCell()
        {
            symbol = null;
        }
    }
}
