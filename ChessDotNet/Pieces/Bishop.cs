﻿namespace ChessDotNet.Pieces
{
    public class Bishop : Piece
    {
        public override Player Owner
        {
            get;
            set;
        }

        public Bishop(Player owner)
        {
            Owner = owner;
        }

        public override char GetFenCharacter()
        {
            return Owner == Player.White ? 'B' : 'b';
        }

        public override bool IsValidMove(Move move, ChessGame game)
        {
            Utilities.ThrowIfNull(move, "move");
            Utilities.ThrowIfNull(game, "game");
            Position origin = move.OriginalPosition;
            Position destination = move.NewPosition;

            PositionDistance posDelta = new PositionDistance(origin, destination);
            if (posDelta.DistanceX != posDelta.DistanceY)
                return false;
            bool increasingRank = (int)destination.Rank > (int)origin.Rank;
            bool increasingFile = (int)destination.File > (int)origin.File;
            for (int f = (int)origin.File + (increasingFile ? 1 : -1), r = (int)origin.Rank + (increasingRank ? 1 : -1);
                 increasingFile ? f < (int)destination.File : f > (int)destination.File;
                 f += increasingFile ? 1 : -1, r += increasingRank ? 1 : -1)
            {
                if (game.GetPieceAt((File)f, (Rank)r) != null)
                {
                    return false;
                }
            }
            return true;
        }

        public override float GetRelativePieceValue()
        {
            return 3;
        }
    }
}