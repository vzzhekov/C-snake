using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustConsoleSnakeII.Common;
using System.Threading; 


namespace JustConsoleSnake_II
{
    class Program
    {
        static void Main()
        {
            SetUpConsole.SetField();


            
            Position[] directions = new Position[] {
                new Position(0,1), //right
                new Position(0, -1), //left
                new Position(1, 0), //down
                new Position(-1,0), //up
            };

            Queue<Position> snakeElements = new Queue<Position>();
            for (int i = 0; i < 6; i++)
            {
                snakeElements.Enqueue(new Position(0, i));
            }
            int score = 0;

            Random randomNumberGenerator = new Random();
            Position food = new Position(randomNumberGenerator.Next(0, Console.WindowHeight), randomNumberGenerator.Next(0, Console.WindowWidth));

            int direction = 0;

            while (true)
            {

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    direction = UserMovement.MoveTheSnake(userInput);
                }

                Position snakeHead = snakeElements.Last();
                Position nextDirection = directions[direction];
                Position snakeNewHead = new Position((snakeHead.Col + nextDirection.Col), nextDirection.Row + snakeHead.Row);
                snakeElements.Enqueue(snakeNewHead);
                if (snakeNewHead.Col == food.Col && snakeNewHead.Row == food.Row)
                {


                    food = new Position(randomNumberGenerator.Next(0, Console.WindowHeight), randomNumberGenerator.Next(0, Console.WindowWidth));
                    score++;
                }

                else
                {

                    snakeElements.Dequeue();
                }


                Console.Clear();
                foreach (Position position in snakeElements)
                {
                    PrintOnScreen.PrintWithPosition(position, "*");
                }

                PrintOnScreen.PrintWithPosition(food, "@");

                PrintOnScreen.PrintWithInts(Console.WindowWidth/2,0,"Score: "  + score.ToString());

                int threadSleep = 100;
                Thread.Sleep(threadSleep);

            }


        }
    }
}
