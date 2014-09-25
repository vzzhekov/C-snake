using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustConsoleSnake.Common
{
    public static class SnakeMove
    {
         
        
        public static void Move(Queue<Position> snakeElements, int dir, Random randomGenerator)
        {
            
            {
                int score = 0;
                Position food = new Position(5, 5);
                Position innderFood;

                int direction = dir; 
                Position[] directions = new Position[] {
                new Position(1,0), //right
                new Position(-1,0), //left
                new Position(0,1), //down
                new Position(0,-1), //top
                                };

                
                Position snakeHead = snakeElements.Last();
                Position nextDirection = directions[direction];
                Position snakeNewHead = new Position((snakeHead.Row + nextDirection.Row), nextDirection.Col + snakeHead.Col);
                  snakeElements.Enqueue(snakeNewHead);

                  if (snakeNewHead.Row < 0 || snakeNewHead.Col < 0 || snakeNewHead.Row >= Console.WindowWidth || snakeNewHead.Col >= Console.WindowHeight)
                  {

                      ConsoleStart.SetCursor();
                      Console.WriteLine("Game Over");

                      return;
                      
                  }

                  if (snakeNewHead.Row == food.Col && snakeNewHead.Col == food.Row)
                {

                    score++;
                    food = new Position(randomGenerator.Next(0, Console.WindowHeight), randomGenerator.Next(0, Console.WindowWidth));
                    innderFood = food; 
                    //TODO:Feed
                }
                
                else
                {
                   
                    snakeElements.Dequeue();
                }


                Console.Clear();
                
               
                foreach (Position position in snakeElements)
                {
                    SnakePrint.Draw(position.Row, position.Col,"*");
                }

                FoodGenerator.GenerateRandomFood(food.Col, food.Row);

                Console.WriteLine("Score: {0}", score);
                //Console.WriteLine("{0} - {1}", food.Col, food.Row);
                //Console.WriteLine("{0} - {1}", snakeNewHead.Col, snakeNewHead.Row);
                int threadSleep = 100;
                Thread.Sleep(threadSleep);
                
            }

           
        }
    }
}
