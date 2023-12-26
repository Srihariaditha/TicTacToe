using System.Xml.Linq;
using TiTacToe.Models;

namespace TiTacToe.Factories
{
    public class GameWinningStrategyEnumFactory
    {
        public static GameWinningStrategy CreateNewGWSByName(string gwsName)
        {
            if (gwsName.Equals("ROW"))
            {
                return GameWinningStrategy.ROW;
            }
            return GameWinningStrategy.ROW;
        }
    }
}
