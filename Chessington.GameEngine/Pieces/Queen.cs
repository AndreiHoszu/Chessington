using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var moves = Enumerable.Empty<Square>();
            var piece = board.FindPiece(this);

            for (var i = piece.Row + 1; i < 8; i++)
            {
                if (board.GetPiece(new Square(i, piece.Col)) != null)
                {
                    if (board.GetPiece(new Square(i, piece.Col)).Player != board.GetPiece(piece).Player)
                    {
                        moves = moves.Concat(new[] { new Square(i, piece.Col) });
                    }
                    break;
                }

                moves = moves.Concat(new[] { new Square(i, piece.Col) });
            }

            for (var i = piece.Row - 1; i >= 0; i--)
            {
                if (board.GetPiece(new Square(i, piece.Col)) != null)
                {
                    if (board.GetPiece(new Square(i, piece.Col)).Player != board.GetPiece(piece).Player)
                    {
                        moves = moves.Concat(new[] { new Square(i, piece.Col) });
                    }
                    break;
                }
                moves = moves.Concat(new[] { new Square(i, piece.Col) });
            }

            for (var i = piece.Col + 1; i < 8; i++)
            {
                if (board.GetPiece(new Square(piece.Row, i)) != null)
                {
                    if (board.GetPiece(new Square(piece.Row, i)).Player != board.GetPiece(piece).Player)
                    {
                        moves = moves.Concat(new[] { new Square(piece.Row, i) });
                    }
                    break;
                }
                moves = moves.Concat(new[] { new Square(piece.Row, i) });
            }

            for (var i = piece.Col - 1; i >= 0; i--)
            {
                if (board.GetPiece(new Square(piece.Row, i)) != null)
                {
                    if (board.GetPiece(new Square(piece.Row, i)).Player != board.GetPiece(piece).Player)
                    {
                        moves = moves.Concat(new[] { new Square(piece.Row, i) });
                    }
                    break;
                }
                moves = moves.Concat(new[] { new Square(piece.Row, i) });
            }

            for (var i = 1; i < 8; i++)
            {
                var row = piece.Row + i;
                var col = piece.Col + i;
                if (row >= 0 && row <= 7 && col >= 0 && col <= 7)
                {
                    if (board.GetPiece(new Square(row, col)) != null)
                    {
                        if (board.GetPiece(new Square(row, col)).Player != board.GetPiece(piece).Player)
                        {
                            moves = moves.Concat(new[] { new Square(row, col) });
                        }

                        break;
                    }

                    moves = moves.Concat(new[] { new Square(row, col) });
                }
            }

            for (var i = 1; i < 8; i++)
            {
                var row = piece.Row - i;
                var col = piece.Col - i;
                if (row >= 0 && row <= 7 && col >= 0 && col <= 7)
                {
                    if (board.GetPiece(new Square(row, col)) != null)
                    {
                        if (board.GetPiece(new Square(row, col)).Player != board.GetPiece(piece).Player)
                        {
                            moves = moves.Concat(new[] { new Square(row, col) });
                        }

                        break;
                    }

                    moves = moves.Concat(new[] { new Square(row, col) });
                }
            }

            for (var i = 1; i < 8; i++)
            {
                var row = piece.Row + i;
                var col = piece.Col - i;
                if (row >= 0 && row <= 7 && col >= 0 && col <= 7)
                {
                    if (board.GetPiece(new Square(row, col)) != null)
                    {
                        if (board.GetPiece(new Square(row, col)).Player != board.GetPiece(piece).Player)
                        {
                            moves = moves.Concat(new[] { new Square(row, col) });
                        }

                        break;
                    }

                    moves = moves.Concat(new[] { new Square(row, col) });
                }
            }

            for (var i = 1; i < 8; i++)
            {
                var row = piece.Row - i;
                var col = piece.Col + i;
                if (row >= 0 && row <= 7 && col >= 0 && col <= 7)
                {
                    if (board.GetPiece(new Square(row, col)) != null)
                    {
                        if (board.GetPiece(new Square(row, col)).Player != board.GetPiece(piece).Player)
                        {
                            moves = moves.Concat(new[] { new Square(row, col) });
                        }

                        break;
                    }

                    moves = moves.Concat(new[] { new Square(row, col) });
                }
            }

            return moves;
        }
    }
}