using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Model
{
    class Board
    {
        public List<Piece> board;
        public List<Piece> graveyard;

        // Creates a standard Chess board with pieces in the standard positions
        public Board()
        {
            board = new List<Piece>(32);
            graveyard = new List<Piece>();
            AddPieces_StandardFormat();
        }

        private void AddPieces_StandardFormat()
        {
            //whites pieces
            this.addPiece(new Rook(new Location(1, 1), Color.White));
            this.addPiece(new Rook(new Location(1, 8), Color.White));
            this.addPiece(new Knight(new Location(1, 2), Color.White));
            this.addPiece(new Knight(new Location(1, 7), Color.White));
            this.addPiece(new Bishop(new Location(1, 3), Color.White));
            this.addPiece(new Bishop(new Location(1, 6), Color.White));
            this.addPiece(new King(new Location(1, 4), Color.White));
            this.addPiece(new Queen(new Location(1, 5), Color.White));
            //whites pawns
            for (int col = 1; col <= 8; col++)
            {
                Location l = new Location(2, col);
                this.addPiece(new Pawn(l, Color.White));
            }

            //blacks pieces
            this.addPiece(new Rook(new Location(8, 1), Color.Black));
            this.addPiece(new Rook(new Location(8, 8), Color.Black));
            this.addPiece(new Knight(new Location(8, 2), Color.Black));
            this.addPiece(new Knight(new Location(8, 7), Color.Black));
            this.addPiece(new Bishop(new Location(8, 3), Color.Black));
            this.addPiece(new Bishop(new Location(8, 6), Color.Black));
            this.addPiece(new King(new Location(8, 4), Color.Black));
            this.addPiece(new Queen(new Location(8, 5), Color.Black));
            //blacks pawns
            for (int col = 1; col <= 8; col++)
            {
                Location l = new Location(7, col);
                this.addPiece(new Pawn(l, Color.Black));
            }
        }

        public void addPiece(Piece newPiece)
        {
            board.Add(newPiece);
        }

        public void removePiece(Piece toBeRemoved)
        {
            board.Remove(toBeRemoved);
            graveyard.Add(toBeRemoved);
        }

        public void removeAtLocation(Location l)
        {
            board.RemoveAll(piece => piece.location.Equals(l));
        }

        public Board clone()
        {
            return null;
        }
    }
}
