using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Knight : Piece
    {
        public Knight(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var moves = Enumerable.Empty<Square>();
            var piece = board.FindPiece(this);

            if (piece.Row + 1 < 8 && piece.Col + 2 < 8)
            {
                moves = moves.Concat(new[] { new Square(piece.Row + 1, piece.Col + 2) });
            }

            if (piece.Row + 1 < 8 && piece.Col - 2 >= 0)
            {
                moves = moves.Concat(new[] { new Square(piece.Row + 1, piece.Col - 2) });
            }

            if (piece.Row + 2 < 8 && piece.Col + 1 < 8)
            {
                moves = moves.Concat(new[] { new Square(piece.Row + 2, piece.Col + 1) });
            }

            if (piece.Row + 2 < 8 && piece.Col -1 >= 0)
            {
                moves = moves.Concat(new[] { new Square(piece.Row + 2, piece.Col - 1) });
            }

            if (piece.Row - 1 >= 0 && piece.Col + 2 < 8)
            {
                moves = moves.Concat(new[] { new Square(piece.Row - 1, piece.Col + 2) });
            }

            if (piece.Row - 1 >= 0 && piece.Col - 2 >= 0)
            {
                moves = moves.Concat(new[] { new Square(piece.Row - 1, piece.Col - 2) });
            }

            if (piece.Row - 2 >= 0 && piece.Col + 1 < 8)
            {
                moves = moves.Concat(new[] { new Square(piece.Row - 2, piece.Col + 1) });
            }

            if (piece.Row - 2 >= 0 && piece.Col - 1 >= 0)
            {
                moves = moves.Concat(new[] { new Square(piece.Row - 2, piece.Col - 1) });
            }

            return moves;
        }
    }
}