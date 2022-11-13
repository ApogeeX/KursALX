
using KursALX.Lessons.M1.L2.Enums;
using KursALX.Lessons.M2.L2.Classes.Inheritance;

namespace KursALX.Lessons.M2.L2
{
    public class L2Inheritance
    {
        public static void Run()
        {
            ChessPiece chessPiece = new ChessPiece();
            chessPiece.XPosition = 1;
            chessPiece.YPosition = 1;
            chessPiece.Move();
            chessPiece.Present();
            Queen queen = new Queen();
            queen.Move();
            queen.XPosition = 1;
            queen.YPosition = 1;
            queen.Color = ChessColor.WHITE;
            queen.Present();
        }
    }
}
