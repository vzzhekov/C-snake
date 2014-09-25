﻿using System;
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

            int threadSleep = 100;
            
            Position[] directions = new Position[] {
                new Position(0,1), //right
                new Position(0, -1), //left
                new Position(1, 0), //down
                new Position(-1,0), //up
            };

            Queue<Position> snakeElements = new Queue<Position>();
            for (int i = 0; i < 6; i++)
            {
                snakeElements.Enqueue(new Position(1, i));
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

                if (snakeNewHead.Row < 0 || snakeNewHead.Col < 0 || snakeNewHead.Row >= Console.WindowWidth || snakeNewHead.Col >= Console.WindowHeight)
                {

                    SetUpConsole.SetCursor(10,10);
                    Console.WriteLine("Game Over");

                    return;

                }
                
                
                
                
                
                if (snakeNewHead.Col == food.Col && snakeNewHead.Row == food.Row)
                {


                    food = new Position(randomNumberGenerator.Next(2, Console.WindowHeight-1), randomNumberGenerator.Next(2, Console.WindowWidth));
                    score++;
                    threadSleep= threadSleep - 4;
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
               

                PrintOnScreen.PrintWithInts(Console.WindowWidth/3,0,"Score: "  + ((snakeElements.Count() -6)*10).ToString());

                
                Thread.Sleep(threadSleep);

            }


        }
    }
}
