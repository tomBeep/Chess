using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Model
{
    abstract class Piece
    {
        Location location;

        string name { get; set; }

        Color color { get; set; }

        protected Piece(Location location, string name, Color color)
        {
            this.location = location;
            this.name = name;
            this.color = color;
        }

        public abstract bool canMove(Location targetLocation, Board board);
        public abstract List<Location> availableMoves(int targetRow, int targetCol, Board b);

        public void move(Location targetLocation, Board board)
        { 
            // Ensure that the location we are moving to is a valid move.
            if (this.canMove(targetLocation, board))
            {
                board.removeAtLocation(targetLocation);// Removes any pieces that are at the target location
                this.location = targetLocation;
            }
            else
            {
                string errorMsg = String.Format("The move using Piece {0} to target location {1} was invalid", this, targetLocation);
                throw new InvalidChessMoveException(errorMsg);
            }
            
        }
    }
}
