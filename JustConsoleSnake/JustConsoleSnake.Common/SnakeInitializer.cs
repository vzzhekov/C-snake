using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace JustConsoleSnake.Common
{
    public static class SnakeInitializer
    {
        public static Queue<Position> Start(Queue<Position> snakeElements)
        {
            for (int i = 0; i < 6; i++)
            {
                snakeElements.Enqueue(new Position(i, 0));
            }

            return snakeElements; 

        }
    }
}
