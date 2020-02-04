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
        public GameBoard()
        {
            InitializeComponent();

            Game g = new Game();
            List <Piece> ls =  g.board.board;
            foreach (Piece p in ls)
            {
                Image i = new Image();
                i.Source = ImageLoader.getImage(p);
                Border square = (Border) VisualTreeHelper.GetChild(grid, p.location.FlatBoardPos()-1);
                square.Child = i;
            }
        }

        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }
    }


}
