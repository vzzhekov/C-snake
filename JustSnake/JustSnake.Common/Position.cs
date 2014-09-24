using System;

using System.Linq;

namespace JustSnake.Common
{
   public struct Position
    {
        private int row;
        private int col;
        public int Row
        {
            get { return row; }
            set { row = value; }
        }
        

        public int Col
        {
            get { return col; }
            set { col = value; }
        }

        public Position(int x, int y)
        {
            this.row = x;
            this.col = y;
        }
        


    }
}
