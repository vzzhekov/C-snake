using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustConsoleSnake.Common
{
    public static class FoodGenerator
    {
        public static void GenerateRandomFood(int row, int col)
        {
            
            SnakePrint.Draw(row, col, "@");

        }

    }
}
