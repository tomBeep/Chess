using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Model
{
    class Location
    {
        int row { get; set; }
        int col { get; set; }

        public Location(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }
}
