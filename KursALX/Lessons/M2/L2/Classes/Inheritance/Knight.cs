using KursALX.Lessons.M1.L2.Enums;

namespace KursALX.Lessons.M2.L2.Classes.Inheritance
{
    public class Knight : ChessPiece
    {
        public Knight() : base()
        {
            Type = ChessFigureType.KNIGHT;
        }

        public void Move()
        {
            Console.WriteLine("The Knight is moving...");
        }
    }
}
