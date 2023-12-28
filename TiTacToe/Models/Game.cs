using System;
using TiTacToe.Models;
using TiTacToe.Strategies.WinningStrategies;

namespace TiTacToe.Models
{
    public class Game
    {
        private List<Player> players;
        public List<Player> Players { get => players; set => players = value; }

        private Board board;
        public Board Board { get => board; set => board = value; }

        private List<Move> moves;
        public List<Move> Moves { get => moves; set => moves = value; }

        private List<GameWinningStrategy> gameWinningStrategies;
        public List<GameWinningStrategy> GameWinningStrategies { get => gameWinningStrategies; set => gameWinningStrategies = value; }
        public int lastMovedPlayerIndex { get; set; }
        public GameStatus gameStatus { get; set; }
        public Player winner {  get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Game() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public static GameBuilder getGameBuilder()
        {
            return new GameBuilder();
        }

        public List<Player> getPlayers()
        {
            return players;
        }

//      private Game()
//        {
//            this.Players = new List<Player>();
//            this.Moves = new List<Move>();
//            this.GameWinningStrategies = new List<GameWinningStrategy>();
//            this.lastMovedPlayerIndex = -1;
//            this.gameStatus = GameStatus.IN_PROGRESS;
//        }

        public void makeMove()
        {
            this.board.display();
            this.lastMovedPlayerIndex += 1;
            this.lastMovedPlayerIndex %= this.Players.Count;

            Move pmove = this.Players[this.lastMovedPlayerIndex].makeMove(this.board);

            if (this.board.getCell(pmove.row,pmove.col).player == null)
            {
                Console.WriteLine("bad move");
                return;
            }
            this.moves.Add(pmove);
            this.board.getCell(pmove.row, pmove.col).player = this.Players[this.lastMovedPlayerIndex];

            //var filledCells = 1;

            foreach (GameWinningStrategy strategy in this.GameWinningStrategies)
            {
                if (strategy.checkVictory(this.board, pmove))
                {
                    gameStatus = GameStatus.ENDED;
                    winner = this.Players[lastMovedPlayerIndex];
                    return;
                }
            }

            if (Moves.Count == this.board.dimension * this.board.dimension)
            {
                gameStatus = GameStatus.DRAW;
                return;
            }
        }


    }
}