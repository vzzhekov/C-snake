using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace JustSnake.Common
{
    public static class UserControls
    {

        public static void Movement(ConsoleKeyInfo userInput, Queue<Position> snakeElement)
        {
            Position[] directions = new Position[] {
                new Position(0,1), //right
                new Position(0,-1), //left
                new Position(1,0), //down
                new Position(-1,0), //top
            };

            SnakeQueueInitializer.Initialize(snakeElement);
            
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
            foreach (Position position in snakeElement)
            {
                SnakePrint.Draw(position.Row, position.Col);
            }

            Position snakeHead = snakeElement.Last();
            snakeElement.Dequeue();
            Position nextDirection = directions[direction];
            Position snakeNewHead = new Position((snakeHead.Row + nextDirection.Row), nextDirection.Col + snakeHead.Col);
            snakeElement.Enqueue(snakeNewHead);

            foreach (Position position in snakeElement)
            {
                SnakePrint.Draw(position.Row, position.Col);
            }

        }

    }
}
