using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustConsoleSnakeII.Common
{
    public struct Position
    {
        private int col;
        private int row;

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

        public Position(int col, int row)
        {
            this.row = row;
            this.col = col;
        }

    }
}
