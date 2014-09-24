using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustConsoleSnake.Common
{
    public static class UserControls
    {
        public static int Move(ConsoleKeyInfo userInput)
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
