using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class King : Piece
    {
        public King(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var moves = Enumerable.Empty<Square>();
            var piece = board.FindPiece(this);

            if (piece.Row + 1 < 8)
            {
                if (piece.Col + 1 < 8)
                {
                    moves = moves.Concat(new[] { new Square(piece.Row + 1, piece.Col + 1) });
                }

                if (piece.Col - 1 >= 0)
                {
                    moves = moves.Concat(new[] { new Square(piece.Row + 1, piece.Col - 1) });
                }

                moves = moves.Concat(new[] { new Square(piece.Row + 1, piece.Col) });
            }

            if (piece.Col + 1 < 8)
            {
                moves = moves.Concat(new[] { new Square(piece.Row, piece.Col + 1) });
            }

            if (piece.Col - 1 >= 0)
            {
                moves = moves.Concat(new[] { new Square(piece.Row, piece.Col - 1) });
            }

            if (piece.Row - 1 >= 0)
            {
                if (piece.Col + 1 < 8)
                {
                    moves = moves.Concat(new[] { new Square(piece.Row - 1, piece.Col + 1) });
                }

                if (piece.Col - 1 >= 0)
                {
                    moves = moves.Concat(new[] { new Square(piece.Row - 1, piece.Col - 1) });
                }

                moves = moves.Concat(new[] { new Square(piece.Row - 1, piece.Col) });
            }

            return moves;
        }
    }
}