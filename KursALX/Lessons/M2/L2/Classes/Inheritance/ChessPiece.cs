using KursALX.Lessons.M1.L2.Enums;

namespace KursALX.Lessons.M2.L2.Classes.Inheritance
{
    public abstract class ChessPiece
    {
        public ChessColor? Color { get; set; }
        public ChessFigureType? Type { get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public bool IsAlive { get; set; }

        public ChessPiece()
        {
            IsAlive = true;
        }

        public void Move()
        {
            Console.WriteLine("Chess Piece is moving...");
        }

        public void Present()
        {
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Is it alive: {IsAlive}");
            Console.WriteLine($"XPosition: {XPosition}");
            Console.WriteLine($"YPosition: {YPosition}");
        }
    }
}
