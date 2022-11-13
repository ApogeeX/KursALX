using KursALX.Lessons.M1.L2.Enums;

namespace KursALX.Lessons.M2.L2.Classes.Inheritance
{
    public class Rook : ChessPiece
    {
        public Rook() : base()
        {
            Type = ChessFigureType.ROOK;
        }
        public void Move()
        {
            Console.WriteLine("The Rook is moving...");
        }
    }
}
