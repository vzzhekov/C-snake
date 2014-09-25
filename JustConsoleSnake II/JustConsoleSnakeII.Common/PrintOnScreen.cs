using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustConsoleSnakeII.Common
{
    public static class PrintOnScreen
    {

        public static void PrintWithInts(int row, int col, string symbol)
        {
            SetUpConsole.SetCursor(row, col);
            Console.Write(symbol);
        }

        public static void PrintWithPosition(Position position, string symbol)
        {
            Console.SetCursorPosition(position.Row, position.Col);
            Console.Write(symbol);
        }
    }
}
