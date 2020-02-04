using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Model
{
    class King : Piece
    {
        public King(Location location, Color color) : base(location, "King", color)
        {

        }

        public override bool canMove(Location targetLocation, Board board)
        {
            return true;
        }
        public override List<Location> availableMoves(int targetRow, int targetCol, Board b)
        {

            return null;
        }
    }
}
