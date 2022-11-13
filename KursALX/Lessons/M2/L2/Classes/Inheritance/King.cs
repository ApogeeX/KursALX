using KursALX.Lessons.M1.L2.Enums;

namespace KursALX.Lessons.M2.L2.Classes.Inheritance
{
    public class King : ChessPiece
    {
        public bool Checked { get; set; }

        public King() : base()
        {
            Checked = false;
            Type = ChessFigureType.KING;
        }

        public void Move()
        {
            Console.WriteLine("The King is moving...");
        }
    }
}

