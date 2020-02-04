using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Model
{
    //Locations start at 1,1 in the bottom left. (Like a graph)
    class Location
    {
        public int row { get; set; }
        public int col { get; set; }

        public Location(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }
}
