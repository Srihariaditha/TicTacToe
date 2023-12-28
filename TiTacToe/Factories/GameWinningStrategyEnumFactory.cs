using System.Xml.Linq;
using TiTacToe.Models;

namespace TiTacToe.Factories
{
    public class GameWinningStrategyEnumFactory
    {
        public static GameWinningStrategyName CreateNewGWSByName(string gwsName)
        {
            if (gwsName.Equals("ROW"))
            {
                return GameWinningStrategyName.ROW;
            }
            return GameWinningStrategyName.ROW;
        }
    }
}
