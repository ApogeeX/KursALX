using KursALX.Lessons.M1.L2.Enums;

namespace KursALX.Lessons.M2.L2.Classes.Inheritance
{
    public class Queen : ChessPiece
    {
        public Queen() : base()
        {
            Type = ChessFigureType.QUEEN;
        }

        public void Move()
        {
            Console.WriteLine("The Queen is moving...");
        }
    }
}
