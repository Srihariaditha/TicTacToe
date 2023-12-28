namespace TiTacToe.Models
{
    public class Player
    {
        public Symbol symbol { get => symbol; set => this.symbol = value; }

        public PlayerType playerType {  get; set; }

        public String? name { get; set; }

        public virtual Move makeMove(Board board)
        {
            Console.WriteLine("What row (starting from 1)");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What Column (starting from 1)");
            int col = Convert.ToInt32(Console.ReadLine());

            Move move = new Move(row, col, this);
            return move;
        }

    }
}
