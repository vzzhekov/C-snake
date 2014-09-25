using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustConsoleSnakeII.Common
{
    public static class SetUpConsole
    {
        public static void SetField()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
      
            
        }

        public static void SetCursor(int row, int col)
        {
            Console.SetCursorPosition(row, col);
        }

    }
}
