using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustConsoleSnakeII.Common
{
    public static class UserMovement
    {
        public static int MoveTheSnake(ConsoleKeyInfo userInput)
        {
            int direction = 0;
            if (userInput.Key == ConsoleKey.LeftArrow)
            {
                direction = 1;   
            }
            if (userInput.Key == ConsoleKey.RightArrow)
            {
                direction = 0;
            }
            if (userInput.Key == ConsoleKey.UpArrow)
            {
                direction = 3;
            }
            if (userInput.Key == ConsoleKey.DownArrow)
            {
                direction = 2;
            }

            return direction;

        }

    }
}
