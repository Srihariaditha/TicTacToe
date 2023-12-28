namespace TiTacToe.Models
{
    public class Cell
    {
        public int row { get; }
        public int col { get; }
        public Player? player { get; set; }
        public Symbol? symbol { get; set; }

        public Cell(int row, int column)
        {
            this.row = row;
            this.col = column;
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
