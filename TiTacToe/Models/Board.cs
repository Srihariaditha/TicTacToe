// 1. Make classes with private attributes
// 2. Create getters and setters for those
// 3. Always create a constructor that initializes those attributes

namespace TiTacToe.Models

{
    public class Board
    {
        public  int dimension { get; set; }

        public List<List<Cell>> board { get; }

        public Board(int dimension)
        {
            this.dimension = dimension;
            this.board = new List<List<Cell>>();

            for (int i = 0; i < dimension; i++)
            {
                board.Add(new List<Cell>());
                for (int j = 0; j < dimension; j++)
                {
                    board[i].Add(new Cell());
                }
            }
        }
    }
}
