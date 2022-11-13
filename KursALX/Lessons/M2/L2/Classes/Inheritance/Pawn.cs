using KursALX.Lessons.M1.L2.Enums;

namespace KursALX.Lessons.M2.L2.Classes.Inheritance
{
    public class Pawn : ChessPiece
    {
        public Pawn() : base()
        {
            Type = ChessFigureType.PAWN;
        }

        public void Move()
        {
            Console.WriteLine("The Pawn is moving...");
        }
    }
}
