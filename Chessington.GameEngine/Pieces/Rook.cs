using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var moves = Enumerable.Empty<Square>();
            var piece = board.FindPiece(this);

            for (var i = piece.Row + 1; i < 8; i++)
            {
                if (board.GetPiece(new Square(i, piece.Col)) != null)
                {
                    break;
                }

                moves = moves.Concat(new[] { new Square(i, piece.Col) });
            }

            for (var i = piece.Row - 1; i >= 0; i--)
            {
                if (board.GetPiece(new Square(i, piece.Col)) != null)
                {
                    break;
                }
                moves = moves.Concat(new[] { new Square(i, piece.Col) });
            }

            for (var i = piece.Col + 1; i < 8; i++)
            {
                if (board.GetPiece(new Square(piece.Row, i)) != null)
                {
                    break;
                }
                moves = moves.Concat(new[] { new Square(piece.Row, i) });
            }

            for (var i = piece.Col - 1; i >= 0; i--)
            {
                if (board.GetPiece(new Square(piece.Row, i)) != null)
                {
                    break;
                }
                moves = moves.Concat(new[] { new Square(piece.Row, i) });
            }

            return moves;
        }
    }
}