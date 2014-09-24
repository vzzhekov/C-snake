using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustConsoleSnake.Common
{
    public static class SnakePrint
    {
        public static void Draw(int row, int col)
        {
            Console.SetCursorPosition(row, col);
            Console.Write("*");

        }
    }
}
