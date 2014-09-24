using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustConsoleSnake.Common
{
    public static class SnakeMove
    {
        public static void Move(Queue<SnakePosition> snakeElements)
        {
            ConsoleKeyInfo userinput = Console.ReadKey();
            int direction = UserControls.Move(userinput);

            SnakePosition[] directions = new SnakePosition[] {
                new SnakePosition(1,0), //right
                new SnakePosition(-1,0), //left
                new SnakePosition(0,1), //down
                new SnakePosition(0,-1), //top
            };


            SnakePosition snakeHead = snakeElements.Last();
            snakeElements.Dequeue();
            SnakePosition nextDirection = directions[direction];
            SnakePosition snakeNewHead = new SnakePosition((snakeHead.Row + nextDirection.Row), nextDirection.Col + snakeHead.Col);
            snakeElements.Enqueue(snakeNewHead);

            foreach (SnakePosition position in snakeElements)
            {
                SnakePrint.Draw(position.Row, position.Col);
            }
        }
    }
}
