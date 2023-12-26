namespace TiTacToe.Models
{
    public class Player
    {
        public Symbol symbol { get => symbol; set => this.symbol = value; }

        public PlayerType playerType {  get; set; }

        public String? name { get; set; }

    }
}
