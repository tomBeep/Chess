using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Model
{
    class Pawn : Piece
    {
        public Pawn(Location location, Color color) : base(location, "Pawn" , color)
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
