using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustConsoleSnake.Common
{
    public struct SnakePosition
    {
        private int row;

        public int Row
        {
            get { return row; }
            set { row = value; }
        }
        private int col;

        public int Col
        {
            get { return col; }
            set { col = value; }
        }

        public SnakePosition(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }
}
