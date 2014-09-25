using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using JustConsoleSnake.Common;

namespace JustConsoleSnake
{
    class Program
    {
        static void Main()
        {


            Queue<Position> snakeElements = new Queue<Position>();
            SnakeInitializer.Start(snakeElements);
            int direction = 0;
            ConsoleStart.SetHeightAndWidth();
            
            Random randomNumberGenerator = new Random();
           

            while (true)
            {
                
                if (Console.KeyAvailable) { 
                ConsoleKeyInfo userinput = Console.ReadKey();
                direction = UserControls.Move(userinput);
                }
                SnakeMove.Move(snakeElements, direction, randomNumberGenerator);
                
            }
            
         
        }
    }
}
