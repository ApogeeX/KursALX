﻿using KursALX.Lessons.M1.L2.Enums;

namespace KursALX.Lessons.M1.L2
{
    public class L2EnumsAndSwitch
    {
        public static void Run()
        {
            var whiteQueen = new ChessFigure(ChessFigureType.QUEEN, ChessColor.WHITE);

            var blackQueen = new ChessFigure();
            blackQueen.FigureType = ChessFigureType.QUEEN;
            blackQueen.FigureColor = ChessColor.BLACK;

            var whiteKing = new ChessFigure
            {
                FigureType = ChessFigureType.KING,
                FigureColor = ChessColor.WHITE,
            };

            var blackKing = new ChessFigure
            {
                FigureType = ChessFigureType.KING,
                FigureColor = ChessColor.BLACK,
            };

            var whiteBishop = new ChessFigure(ChessFigureType.BISHOP, ChessColor.WHITE);
            
            var blackBishop = new ChessFigure(ChessFigureType.BISHOP, ChessColor.BLACK);

            GetFigureType(whiteKing);
            GetFigureType(blackKing);
            GetFigureType(whiteQueen);
            GetFigureType(blackQueen);
            GetFigureType(blackBishop);
            GetFigureType(whiteBishop);
        }

        private static void GetFigureType(ChessFigure chessFigure)
        {
            switch (chessFigure.FigureType)
            {
                case ChessFigureType.QUEEN:
                    Console.WriteLine("The figure is a queen.");
                    break;
                case ChessFigureType.KING:
                    Console.WriteLine("The figure is a king.");
                    break;
                case ChessFigureType.KNIGHT:
                    Console.WriteLine("The figure is a knight.");
                    break;
                case ChessFigureType.BISHOP:
                    Console.WriteLine("The figure is a bishop.");
                    break;
                case ChessFigureType.ROOK:
                    Console.WriteLine("The figure is a rook.");
                    break;
                case ChessFigureType.PAWN:
                    Console.WriteLine("The figure is a pawn.");
                    break;
                default:
                    Console.WriteLine("The type is undefined...");
                    break;
            }

            Console.WriteLine("The figure hes been classified.");
        }
    }
}
