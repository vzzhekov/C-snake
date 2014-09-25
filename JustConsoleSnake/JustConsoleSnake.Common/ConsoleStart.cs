using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustConsoleSnake.Common
{
    public static class ConsoleStart
    {
        public static void SetHeightAndWidth()
        {
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;

        }

        public static void SetCursor()
        {
            Console.SetCursorPosition((Console.WindowWidth / 6), (Console.WindowHeight / 2));
        }

    }
}
