using KursALX.Lessons.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursALX.Lessons.L2
{
    public class ChessFigure
    {
        public ChessFigureType FigureType;
        public ChessColor FigureColor;

        public ChessFigure() {}
        public ChessFigure(ChessFigureType chessFigureType, ChessColor chessColor)
        {
            FigureType = chessFigureType;
            FigureColor = chessColor;   
        }
    }
}
