using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustSnake.Common;
using System.Collections;

namespace JustSnake
{
    class Program
    {
        static void Main()
        
        
        {
            
            Queue<Position> snakeElement = new Queue<Position>();
                 
             
             bool playing = true;
             while (playing)
             {
                 ConsoleKeyInfo userInput = Console.ReadKey();
                 UserControls.Movement(userInput, snakeElement);
             }


        }
    }
}
