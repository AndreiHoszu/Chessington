using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var moves = Enumerable.Empty<Square>();
            var piece = board.FindPiece(this);

            if(this.Player.Equals(Player.Black))
            {
                if(piece.Row + 1 < 8)
                {
                    if (board.GetPiece(new Square(piece.Row + 1, piece.Col)) == null)
                    {
                        moves = moves.Concat(new[] { new Square(piece.Row + 1, piece.Col) });

                        if (piece.Row == 1)
                        {
                            if (board.GetPiece(new Square(piece.Row + 2, piece.Col)) == null)
                            {
                                moves = moves.Concat(new[] { new Square(piece.Row + 2, piece.Col) });
                            }
                        }
                    }

                    if (piece.Col + 1 < 8)
                    {
                        if (board.GetPiece(new Square(piece.Row + 1, piece.Col + 1)) != null)
                        {
                            if (board.GetPiece(new Square(piece.Row + 1, piece.Col + 1)).Player != board.GetPiece(piece).Player)
                            {
                                moves = moves.Concat(new[] { new Square(piece.Row + 1, piece.Col + 1) });
                            }
                        }
                    }

                    if (piece.Col - 1 >= 0)
                    {
                        if (board.GetPiece(new Square(piece.Row + 1, piece.Col - 1)) != null)
                        {
                            if (board.GetPiece(new Square(piece.Row + 1, piece.Col - 1)).Player != board.GetPiece(piece).Player)
                            {
                                moves = moves.Concat(new[] { new Square(piece.Row + 1, piece.Col - 1) });
                            }
                        }
                    }
                }
            }
            else
            {
                if(piece.Row - 1 >= 0)
                {
                    if (board.GetPiece(new Square(piece.Row - 1, piece.Col)) == null)
                    {
                        moves = moves.Concat(new[] { new Square(piece.Row - 1, piece.Col) });

                        if (piece.Row == 7)
                        {
                            if (board.GetPiece(new Square(piece.Row - 2, piece.Col)) == null)
                            {
                                moves = moves.Concat(new[] { new Square(piece.Row - 2, piece.Col) });
                            }
                        }
                    }

                    if (piece.Col + 1 < 8)
                    {
                        if (board.GetPiece(new Square(piece.Row - 1, piece.Col + 1)) != null)
                        {
                            if (board.GetPiece(new Square(piece.Row - 1, piece.Col + 1)).Player != board.GetPiece(piece).Player)
                            {
                                moves = moves.Concat(new[] { new Square(piece.Row - 1, piece.Col + 1) });
                            }
                        }
                    }

                    if (piece.Col - 1 >= 0)
                    {
                        if (board.GetPiece(new Square(piece.Row - 1, piece.Col - 1)) != null)
                        {
                            if (board.GetPiece(new Square(piece.Row - 1, piece.Col - 1)).Player != board.GetPiece(piece).Player)
                            {
                                moves = moves.Concat(new[] { new Square(piece.Row - 1, piece.Col - 1) });
                            }
                        }
                    }
                }
            }

            return moves;
        }
    }
}