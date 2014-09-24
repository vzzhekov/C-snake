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
   
            
            while (true)
            {

                SnakeMove.Move(snakeElements);

            }


        }
    }
}
