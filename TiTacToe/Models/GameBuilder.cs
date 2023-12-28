// Game class:
// i. Lots of attributes
// ii. Need validation (every player must have a different symbol
using TiTacToe.Exceptions;
using TiTacToe.Factories;
using TiTacToe.Strategies.WinningStrategies;
namespace TiTacToe.Models
{
    public class GameBuilder
    {

        public List<Player> players;
        public List<GameWinningStrategy> gameWinningStrategies;
        //private GameStatus GameStatus;

        public GameBuilder setPlayers(List<Player> players)
        {
            this.players = players;
            return this;
        }

        public GameBuilder setGameWinningStrategies(List<GameWinningStrategyName> gameWinningStrategyNames)
        {
            this.gameWinningStrategies = new List<GameWinningStrategy>();

            foreach(GameWinningStrategyName gwsName in gameWinningStrategyNames)
            {
                this.gameWinningStrategies.Add(GameWinningStrategyFactory.GetGameWinningStrategyByName(gwsName));
            }
            return this;
        }

        public Game Build() 
        {
            var alreadyExistingCharacters = new HashSet<char>();
            foreach (var player in this.players)
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
            game.Players = this.players;
            //game.GameWinningStrategies.AddRange(this.gameWinningStrategies);
            game.Board = new Board(dimension: this.players.Count+1);
            game.lastMovedPlayerIndex = -1;

            return game;
        }
    }
}
