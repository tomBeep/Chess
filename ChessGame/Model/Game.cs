using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Model
{
    class Game
    {
        public Board board;
        public Game()
        {
            this.board = new Board();
        }
    }
}
