using ChessGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChessGame
{
    /// <summary>
    /// Interaction logic for GameBaord.xaml
    /// </summary>
    public partial class GameBoard : Page
    {
        Game game;
        public GameBoard()
        {
            InitializeComponent();
            game = new Game();
            refreshBoard();
         }

        public void refreshBoard()
        {
            List<Piece> ls = game.board.board;
            clearBoard();

            // Looks at each piece on the board and assigns the correct image to the correct square.
            foreach (Piece p in ls)
            {
                Image i = new Image();
                i.Source = ImageLoader.getImage(p);
                Border square = (Border)VisualTreeHelper.GetChild(grid, (64 - p.location.FlatBoardPos()));
                square.Child = i;
            }
        }
        public void clearBoard()
        {
            for(int i = 0; i<64; i++)
            {
                Border square = (Border)VisualTreeHelper.GetChild(grid, i);
                square.Child = null;
            }
        }
    }


}
