﻿using System.Collections.Generic;
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

            for (var i = 0; i < 8; i++)
            {
                if (piece.Row != i)
                {
                    moves = moves.Concat(new[] { new Square(i, i) });
                }
            }

            for (var i = 1; i < 8; i++)
            {
                if (piece.Col != i)
                {
                    moves = moves.Concat(new[] { new Square(i, 8 - i) });
                }
            }

            return moves;
        }
    }
}