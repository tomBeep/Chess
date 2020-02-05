using ChessGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
        Piece selectedPiece;
        public GameBoard()
        {
            InitializeComponent();
            game = new Game();
            refreshBoard();
        }

        public void refreshBoard()
        {
            // First step is to clear the board of all old images.
            clearBoard();

            // Now we look at each piece on the board and assign the correct image to the correct square.
            List<Piece> pieces = game.board.board;
            foreach (Piece p in pieces)
            {
                Image i = new ImagePiece
                {
                    Source = ImageLoader.getImage(p),
                    Piece = p
                };
                Border square = (Border)VisualTreeHelper.GetChild(grid, (64 - p.location.FlatComputerCoordinate()));
                square.Child = i;
            }
        }
        private void clearBoard()
        {
            for (int i = 0; i < 64; i++)
            {
                Border square = (Border)VisualTreeHelper.GetChild(grid, i);
                square.Child = null;
            }
        }

        private void Mouse_Pressed(object sender, MouseEventArgs e)
        {
            Border square = (Border)sender;
            Piece p = null;
            if (square.Child != null)
            {
                ImagePiece img = (ImagePiece)(square.Child);
                p = img.Piece;
            }
            Console.WriteLine("Mouse Pressed: " + p.location);
            selectedPiece = p;
        }

        private void Mouse_Released(object sender, MouseEventArgs e)
        {
            UniformGrid gr = (UniformGrid)sender;
            double squareWidth = gr.ActualWidth / 8;
            double squareHeight = gr.ActualHeight / 8;
            int clickedCol = 8 - (int)(e.GetPosition(gr).X / squareWidth);
            int clickedRow = 8 - (int)(e.GetPosition(gr).Y / squareHeight);
            Location clickedLocation = new Location(clickedRow, clickedCol);

            selectedPiece.move(clickedLocation, game.board);
            this.refreshBoard();
        }
    }

    class ImagePiece : Image
    {
        public Piece Piece { get; set; }
    }
}
