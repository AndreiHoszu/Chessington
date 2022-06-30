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

            if (this.Player.Equals(Player.Black))
            {
                return new[] { new Square(piece.Row + 1, piece.Col) };
            }
            else
            {
                return new[] { new Square(piece.Row - 1, piece.Col) };
            }

            return moves;
        }
    }
}