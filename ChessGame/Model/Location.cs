using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Model
{
    //Chess Locations start at 1,1 (A1) in the bottom left. (Like a graph)
    class Location
    {
        public int row { get; set; }
        public int col { get; set; }

        public Location(int row, int col)
        {
            this.row = row;
            this.col = col;
        }

        public override bool Equals(Object o)
        {
            if (o is Location)
            {
                Location l = (Location)o;
                return l.row == this.row && l.col == this.col;
            }
            return false;
        }

        public override string ToString()
        {
            char c = (char)(col + 64);
            return "" + c + row;
        }

        public int FlatComputerCoordinate()
        {
            // Returns the flattened coordinates based on a computer, eg A8 (row = 8, col = 1) = 1, 81 = 64
            return (row - 1) * 8 + (col);
        }
    }
}
