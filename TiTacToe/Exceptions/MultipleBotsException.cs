
using System.Reflection.PortableExecutable;

namespace TiTacToe.Exceptions
{
    public class MultipleBotsException : SystemException
    {
        public MultipleBotsException(char c)
        {
            Console.WriteLine("Symbol " + c + " is repeated twice.");
        }
    }
}
