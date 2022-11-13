
using KursALX.Lessons.M1.L2.Enums;
using KursALX.Lessons.M2.L2.Classes.Inheritance;

namespace KursALX.Lessons.M2.L2
{
    public class L2Inheritance
    {
        public static void Run()
        {
            King king = new King();
            king.XPosition = 1;
            king.YPosition = 1;
            king.Color = ChessColor.BLACK;
            king.Move();
            king.Present();
            ConfirmLiveness(king);

            Queen queen = new Queen();
            queen.Move();
            queen.XPosition = 1;
            queen.YPosition = 1;
            queen.Color = ChessColor.WHITE;
            queen.Present();
            ConfirmLiveness(queen);

            Bishop bishop = new Bishop();
            bishop.Move();
            bishop.XPosition = 1;
            bishop.YPosition = 1;
            bishop.Color = ChessColor.WHITE;
            bishop.Present();
            ConfirmLiveness(bishop);

            Rook rook = new Rook();
            rook.Move();
            rook.XPosition = 1;
            rook.YPosition = 1;
            rook.Color = ChessColor.WHITE;
            rook.Present();
            ConfirmLiveness(rook);

            Knight knight = new Knight();
            knight.Move();
            knight.XPosition = 1;
            knight.YPosition = 1;
            knight.Color = ChessColor.WHITE;
            knight.Present();
            ConfirmLiveness(knight);

            Pawn pawn = new Pawn();
            pawn.Move();
            pawn.XPosition = 1;
            pawn.YPosition = 1;
            pawn.Color = ChessColor.WHITE;
            pawn.Present();
            ConfirmLiveness(pawn);
        }

        public static void ConfirmLiveness(ChessPiece queen)
        {
            if (queen.IsAlive)
            {
                Console.WriteLine("The piece is alive!");
            }
            else
            {
                Console.WriteLine("The piece is dead...");
            }
            Console.WriteLine();
        }
    }
}
