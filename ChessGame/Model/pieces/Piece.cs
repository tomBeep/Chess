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

        protected Piece(int row,int col,string name, Color color)
        {
            this.location = new Location(row, col);
            this.name = name;
            this.color = color;
        }

        public abstract bool canMove(int targetRow, int targetCol, Board b);
        public abstract bool canMove(int targetRow, int targetCol, Board b);

        public void move(int targetRow, int targetCol, Board b)
        {
            if (this.canMove(targetRow, targetCol, b))
            {
                b.setPiece
                this.row = targetRow;
                this.col = targetCol;
                
            }
            
        }
    }
}
