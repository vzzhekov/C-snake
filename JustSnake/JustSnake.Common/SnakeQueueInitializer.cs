using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustSnake.Common
{
    public static class SnakeQueueInitializer
    {
        public static Queue<Position> Initialize(Queue<Position> snakeElement)
        {
            SnakeLenght lenght = new SnakeLenght();
            lenght.SnakeLenghtInitial = 6; 
            for (int i = 0; i < lenght.SnakeLenghtInitial; i++)
            {
                snakeElement.Enqueue(new Position(i, 0));
            }

            return snakeElement; 
        }

    }
}
