using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var moves = Enumerable.Empty<Square>();
            var piece = board.FindPiece(this);

            for (var i = piece.Row + 1; i < 8; i++)
            {
                if (board.GetPiece(new Square(i, i)) != null)
                {
                    if (board.GetPiece(new Square(i, i)).Player != board.GetPiece(piece).Player)
                    {
                        moves = moves.Concat(new[] { new Square(i, i) });
                    }
                    break;
                }

                moves = moves.Concat(new[] { new Square(i, i) });
            }

            for (var i = piece.Row - 1; i >= 0; i--)
            {
                if (board.GetPiece(new Square(i, i)) != null)
                {
                    if (board.GetPiece(new Square(i, i)).Player != board.GetPiece(piece).Player)
                    {
                        moves = moves.Concat(new[] { new Square(i, i) });
                    }
                    break;
                }
                moves = moves.Concat(new[] { new Square(i, i) });
            }

            for (var i = piece.Col + 1; i < 8; i++)
            {
                if (board.GetPiece(new Square(8 - i, i)) != null)
                {
                    if (board.GetPiece(new Square(8 - i, i)).Player != board.GetPiece(piece).Player)
                    {
                        moves = moves.Concat(new[] { new Square(8 - i, i) });
                    }
                    break;
                }
                moves = moves.Concat(new[] { new Square(8 - i, i) });
            }

            for (var i = piece.Col - 1; i >= 1; i--)
            {
                if (board.GetPiece(new Square(8 - i, i)) != null)
                {
                    if (board.GetPiece(new Square(8 - i, i)).Player != board.GetPiece(piece).Player)
                    {
                        moves = moves.Concat(new[] { new Square(8 - i, i) });
                    }
                    break;
                }
                moves = moves.Concat(new[] { new Square(8 - i, i) });
            }

            return moves;
        }
    }
}