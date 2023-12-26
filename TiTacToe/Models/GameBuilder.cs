// Game class:
// i. Lots of attributes
// ii. Need validation (every player must have a different symbol
using TiTacToe.Exceptions;
using TiTacToe.Factories;
namespace TiTacToe.Models
{
    public class GameBuilder
    {

        private List<Player> Players;
        private List<GameWinningStrategy> GameWinningStrategies;
        private GameStatus GameStatus;

        public GameBuilder setPlayers(List<Player> players)
        {
            this.Players = players;
            return this;
        }

        public GameBuilder setGameWinningStrategies(List<GameWinningStrategy> GameWinningStrategies)
        {
            this.GameWinningStrategies = GameWinningStrategies;
            foreach (GameWinningStrategy gameWinningStrategyName in  this.GameWinningStrategies)
            {
                this.GameWinningStrategies.Add(GameWinningStrategyFactory.GetGameWinningStrategyByName(gameWinningStrategyName));
            }
            return this;
        }

        public Game Build() 
        {
            var alreadyExistingCharacters = new HashSet<char>();
            foreach (var player in this.Players)
            {
                var s = Convert.ToChar(player?.symbol);
                if (alreadyExistingCharacters.Contains(s))
                {
                    throw new MultipleBotsException(s);
                }
                alreadyExistingCharacters.Add(s);
            }

            Game game = new Game();
            game.gameStatus = GameStatus.IN_PROGRESS;
            game.GameWinningStrategies = new List<GameWinningStrategy>();
            game.Moves = new List<Move>();
            game.Players = this.Players);
            game.GameWinningStrategies.AddRange(this.GameWinningStrategies);
            game.Board = new Board(dimension: Players.Count+1);
            game.lastMovedPlayerIndex = -1;

            return game;
        }
    }
}
