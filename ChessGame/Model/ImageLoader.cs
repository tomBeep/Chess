using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ChessGame.Model
{
    class ImageLoader
    {

        public static readonly BitmapImage BishopB = new BitmapImage(new Uri("pack://application:,,,/Images/BishopB.png"));
        public static readonly BitmapImage PawnB = new BitmapImage(new Uri("pack://application:,,,/Images/PawnB.png"));
        public static readonly BitmapImage QueenB = new BitmapImage(new Uri("pack://application:,,,/Images/QueenB.png"));
        public static readonly BitmapImage KingB = new BitmapImage(new Uri("pack://application:,,,/Images/KingB.png"));
        public static readonly BitmapImage KnightB = new BitmapImage(new Uri("pack://application:,,,/Images/KnightB.png"));
        public static readonly BitmapImage RookB = new BitmapImage(new Uri("pack://application:,,,/Images/RookB.png"));


        public static readonly BitmapImage BishopW = new BitmapImage(new Uri("pack://application:,,,/Images/BishopW.png"));
        public static readonly BitmapImage PawnW = new BitmapImage(new Uri("pack://application:,,,/Images/PawnW.png"));
        public static readonly BitmapImage QueenW = new BitmapImage(new Uri("pack://application:,,,/Images/QueenW.png"));
        public static readonly BitmapImage KingW = new BitmapImage(new Uri("pack://application:,,,/Images/KingW.png"));
        public static readonly BitmapImage KnightW = new BitmapImage(new Uri("pack://application:,,,/Images/KnightW.png"));
        public static readonly BitmapImage RookW = new BitmapImage(new Uri("pack://application:,,,/Images/RookW.png"));

        public static BitmapImage getImage(Piece piece)
        {
            if(piece.color is Color.White)
            {
                if(piece is Bishop)
                {
                    return BishopW;
                }
                else if (piece is Pawn)
                {
                    return PawnW;
                }
                else if (piece is Queen)
                {
                    return QueenW;
                }
                else if (piece is King)
                {
                    return KingW;
                }
                else if (piece is Knight)
                {
                    return KnightW;
                }
                else 
                {
                    return RookW;
                }
            }
            else
            {
                if (piece is Bishop)
                {
                    return BishopB;
                }
                else if (piece is Pawn)
                {
                    return PawnB;
                }
                else if (piece is Queen)
                {
                    return QueenB;
                }
                else if (piece is King)
                {
                    return KingB;
                }
                else if (piece is Knight)
                {
                    return KnightB;
                }
                else
                {
                    return RookB;
                }
            }
        }

    }
}
