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
        public static Queue<SnakePosition> Start(Queue<SnakePosition> snakeElements)
        {
            for (int i = 0; i < 6; i++)
            {
                snakeElements.Enqueue(new SnakePosition(i, 0));
            }

            return snakeElements; 

        }
    }
}
