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


            Queue<SnakePosition> snakeElements = new Queue<SnakePosition>();
            SnakeInitializer.Start(snakeElements);
            int direction = 0;
            
            while (true)
            {
                if (Console.KeyAvailable) { 
                ConsoleKeyInfo userinput = Console.ReadKey();
                direction = UserControls.Move(userinput);
                }
                SnakeMove.Move(snakeElements,direction);
                
            }
            
         
        }
    }
}
