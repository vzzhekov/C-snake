using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustSnake.Common
{
    public static class SnakePrint
    {
        public static void Draw(int row, int collumn) {
            Console.SetCursorPosition(row, collumn);
            Console.Write("*");
        }
    }
}
