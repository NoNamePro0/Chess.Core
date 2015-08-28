﻿using NUnit.Framework;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ChessDotNet.Tests
{
    [TestFixture]
    public class ChessBoardTests
    {
        static readonly ChessPiece kw = new ChessPiece(Pieces.King, Players.White);
        static readonly ChessPiece kb = new ChessPiece(Pieces.King, Players.Black);
        static readonly ChessPiece qw = new ChessPiece(Pieces.Queen, Players.White);
        static readonly ChessPiece qb = new ChessPiece(Pieces.Queen, Players.Black);
        static readonly ChessPiece rw = new ChessPiece(Pieces.Rook, Players.White);
        static readonly ChessPiece rb = new ChessPiece(Pieces.Rook, Players.Black);
        static readonly ChessPiece nw = new ChessPiece(Pieces.Knight, Players.White);
        static readonly ChessPiece nb = new ChessPiece(Pieces.Knight, Players.Black);
        static readonly ChessPiece bw = new ChessPiece(Pieces.Bishop, Players.White);
        static readonly ChessPiece bb = new ChessPiece(Pieces.Bishop, Players.Black);
        static readonly ChessPiece pw = new ChessPiece(Pieces.Pawn, Players.White);
        static readonly ChessPiece pb = new ChessPiece(Pieces.Pawn, Players.Black);
        static readonly ChessPiece o = ChessPiece.None;

        [Test]
        public void TestArrayGetting()
        {
            Chessboard cb = new Chessboard();
            int one = (int)Position.Ranks.One;
            int two = (int)Position.Ranks.Two;
            int three = (int)Position.Ranks.Three;
            int four = (int)Position.Ranks.Four;
            int five = (int)Position.Ranks.Five;
            int six = (int)Position.Ranks.Six;
            int seven = (int)Position.Ranks.Seven;
            int eight = (int)Position.Ranks.Eight;
            int a = (int)Position.Files.A;
            int b = (int)Position.Files.B;
            int c = (int)Position.Files.C;
            int d = (int)Position.Files.D;
            int e = (int)Position.Files.E;
            int f = (int)Position.Files.F;
            int g = (int)Position.Files.G;
            int h = (int)Position.Files.H;
            Assert.AreEqual(rw, cb.Board[one, a]);
            Assert.AreEqual(nw, cb.Board[one, b]);
            Assert.AreEqual(bw, cb.Board[one, c]);
            Assert.AreEqual(qw, cb.Board[one, d]);
            Assert.AreEqual(kw, cb.Board[one, e]);
            Assert.AreEqual(bw, cb.Board[one, f]);
            Assert.AreEqual(nw, cb.Board[one, g]);
            Assert.AreEqual(rw, cb.Board[one, h]);
            Assert.AreEqual(pw, cb.Board[two, a]);
            Assert.AreEqual(pw, cb.Board[two, b]);
            Assert.AreEqual(pw, cb.Board[two, c]);
            Assert.AreEqual(pw, cb.Board[two, d]);
            Assert.AreEqual(pw, cb.Board[two, e]);
            Assert.AreEqual(pw, cb.Board[two, f]);
            Assert.AreEqual(pw, cb.Board[two, g]);
            Assert.AreEqual(pw, cb.Board[two, h]);
            Assert.AreEqual(o, cb.Board[three, a]);
            Assert.AreEqual(o, cb.Board[three, b]);
            Assert.AreEqual(o, cb.Board[three, c]);
            Assert.AreEqual(o, cb.Board[three, d]);
            Assert.AreEqual(o, cb.Board[three, e]);
            Assert.AreEqual(o, cb.Board[three, f]);
            Assert.AreEqual(o, cb.Board[three, g]);
            Assert.AreEqual(o, cb.Board[three, h]);
            Assert.AreEqual(o, cb.Board[four, a]);
            Assert.AreEqual(o, cb.Board[four, b]);
            Assert.AreEqual(o, cb.Board[four, c]);
            Assert.AreEqual(o, cb.Board[four, d]);
            Assert.AreEqual(o, cb.Board[four, e]);
            Assert.AreEqual(o, cb.Board[four, f]);
            Assert.AreEqual(o, cb.Board[four, g]);
            Assert.AreEqual(o, cb.Board[four, h]);
            Assert.AreEqual(o, cb.Board[five, a]);
            Assert.AreEqual(o, cb.Board[five, b]);
            Assert.AreEqual(o, cb.Board[five, c]);
            Assert.AreEqual(o, cb.Board[five, d]);
            Assert.AreEqual(o, cb.Board[five, e]);
            Assert.AreEqual(o, cb.Board[five, f]);
            Assert.AreEqual(o, cb.Board[five, g]);
            Assert.AreEqual(o, cb.Board[five, h]);
            Assert.AreEqual(o, cb.Board[six, a]);
            Assert.AreEqual(o, cb.Board[six, b]);
            Assert.AreEqual(o, cb.Board[six, c]);
            Assert.AreEqual(o, cb.Board[six, d]);
            Assert.AreEqual(o, cb.Board[six, e]);
            Assert.AreEqual(o, cb.Board[six, f]);
            Assert.AreEqual(o, cb.Board[six, g]);
            Assert.AreEqual(o, cb.Board[six, h]);
            Assert.AreEqual(pb, cb.Board[seven, a]);
            Assert.AreEqual(pb, cb.Board[seven, b]);
            Assert.AreEqual(pb, cb.Board[seven, c]);
            Assert.AreEqual(pb, cb.Board[seven, d]);
            Assert.AreEqual(pb, cb.Board[seven, e]);
            Assert.AreEqual(pb, cb.Board[seven, f]);
            Assert.AreEqual(pb, cb.Board[seven, g]);
            Assert.AreEqual(pb, cb.Board[seven, h]);
            Assert.AreEqual(rb, cb.Board[eight, a]);
            Assert.AreEqual(nb, cb.Board[eight, b]);
            Assert.AreEqual(bb, cb.Board[eight, c]);
            Assert.AreEqual(qb, cb.Board[eight, d]);
            Assert.AreEqual(kb, cb.Board[eight, e]);
            Assert.AreEqual(bb, cb.Board[eight, f]);
            Assert.AreEqual(nb, cb.Board[eight, g]);
            Assert.AreEqual(rb, cb.Board[eight, h]);
        }

        [Test]
        public void TestGetPieceAt()
        {
            Chessboard cb = new Chessboard();
            Position.Ranks one = Position.Ranks.One;
            Position.Ranks two = Position.Ranks.Two;
            Position.Ranks three = Position.Ranks.Three;
            Position.Ranks four = Position.Ranks.Four;
            Position.Ranks five = Position.Ranks.Five;
            Position.Ranks six = Position.Ranks.Six;
            Position.Ranks seven = Position.Ranks.Seven;
            Position.Ranks eight = Position.Ranks.Eight;
            Position.Files a = Position.Files.A;
            Position.Files b = Position.Files.B;
            Position.Files c = Position.Files.C;
            Position.Files d = Position.Files.D;
            Position.Files e = Position.Files.E;
            Position.Files f = Position.Files.F;
            Position.Files g = Position.Files.G;
            Position.Files h = Position.Files.H;
            Assert.AreEqual(rw, cb.GetPieceAt(a, one));
            Assert.AreEqual(nw, cb.GetPieceAt(b, one));
            Assert.AreEqual(bw, cb.GetPieceAt(c, one));
            Assert.AreEqual(qw, cb.GetPieceAt(d, one));
            Assert.AreEqual(kw, cb.GetPieceAt(e, one));
            Assert.AreEqual(bw, cb.GetPieceAt(f, one));
            Assert.AreEqual(nw, cb.GetPieceAt(g, one));
            Assert.AreEqual(rw, cb.GetPieceAt(h, one));
            Assert.AreEqual(pw, cb.GetPieceAt(a, two));
            Assert.AreEqual(pw, cb.GetPieceAt(b, two));
            Assert.AreEqual(pw, cb.GetPieceAt(c, two));
            Assert.AreEqual(pw, cb.GetPieceAt(d, two));
            Assert.AreEqual(pw, cb.GetPieceAt(e, two));
            Assert.AreEqual(pw, cb.GetPieceAt(f, two));
            Assert.AreEqual(pw, cb.GetPieceAt(g, two));
            Assert.AreEqual(pw, cb.GetPieceAt(h, two));
            Assert.AreEqual(o, cb.GetPieceAt(a, three));
            Assert.AreEqual(o, cb.GetPieceAt(b, three));
            Assert.AreEqual(o, cb.GetPieceAt(c, three));
            Assert.AreEqual(o, cb.GetPieceAt(d, three));
            Assert.AreEqual(o, cb.GetPieceAt(e, three));
            Assert.AreEqual(o, cb.GetPieceAt(f, three));
            Assert.AreEqual(o, cb.GetPieceAt(g, three));
            Assert.AreEqual(o, cb.GetPieceAt(h, three));
            Assert.AreEqual(o, cb.GetPieceAt(a, four));
            Assert.AreEqual(o, cb.GetPieceAt(b, four));
            Assert.AreEqual(o, cb.GetPieceAt(c, four));
            Assert.AreEqual(o, cb.GetPieceAt(d, four));
            Assert.AreEqual(o, cb.GetPieceAt(e, four));
            Assert.AreEqual(o, cb.GetPieceAt(f, four));
            Assert.AreEqual(o, cb.GetPieceAt(g, four));
            Assert.AreEqual(o, cb.GetPieceAt(h, four));
            Assert.AreEqual(o, cb.GetPieceAt(a, five));
            Assert.AreEqual(o, cb.GetPieceAt(b, five));
            Assert.AreEqual(o, cb.GetPieceAt(c, five));
            Assert.AreEqual(o, cb.GetPieceAt(d, five));
            Assert.AreEqual(o, cb.GetPieceAt(e, five));
            Assert.AreEqual(o, cb.GetPieceAt(f, five));
            Assert.AreEqual(o, cb.GetPieceAt(g, five));
            Assert.AreEqual(o, cb.GetPieceAt(h, five));
            Assert.AreEqual(o, cb.GetPieceAt(a, six));
            Assert.AreEqual(o, cb.GetPieceAt(b, six));
            Assert.AreEqual(o, cb.GetPieceAt(c, six));
            Assert.AreEqual(o, cb.GetPieceAt(d, six));
            Assert.AreEqual(o, cb.GetPieceAt(e, six));
            Assert.AreEqual(o, cb.GetPieceAt(f, six));
            Assert.AreEqual(o, cb.GetPieceAt(g, six));
            Assert.AreEqual(o, cb.GetPieceAt(h, six));
            Assert.AreEqual(pb, cb.GetPieceAt(a, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(b, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(c, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(d, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(e, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(f, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(g, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(h, seven));
            Assert.AreEqual(rb, cb.GetPieceAt(a, eight));
            Assert.AreEqual(nb, cb.GetPieceAt(b, eight));
            Assert.AreEqual(bb, cb.GetPieceAt(c, eight));
            Assert.AreEqual(qb, cb.GetPieceAt(d, eight));
            Assert.AreEqual(kb, cb.GetPieceAt(e, eight));
            Assert.AreEqual(bb, cb.GetPieceAt(f, eight));
            Assert.AreEqual(nb, cb.GetPieceAt(g, eight));
            Assert.AreEqual(rb, cb.GetPieceAt(h, eight));
        }

        [Test]
        public void TestCustomInitialize()
        {
            Position.Ranks one = Position.Ranks.One;
            Position.Ranks two = Position.Ranks.Two;
            Position.Ranks three = Position.Ranks.Three;
            Position.Ranks four = Position.Ranks.Four;
            Position.Ranks five = Position.Ranks.Five;
            Position.Ranks six = Position.Ranks.Six;
            Position.Ranks seven = Position.Ranks.Seven;
            Position.Ranks eight = Position.Ranks.Eight;
            Position.Files a = Position.Files.A;
            Position.Files b = Position.Files.B;
            Position.Files c = Position.Files.C;
            Position.Files d = Position.Files.D;
            Position.Files e = Position.Files.E;
            Position.Files f = Position.Files.F;
            Position.Files g = Position.Files.G;
            Position.Files h = Position.Files.H;
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { rb, o, bb, qb, kb, bb, nb, rb },
                { pb, pb, pb, pb, pb, pb, pb, pb },
                { o, o, nb, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, pw, o, o, o },
                { o, o, o, o, o, o, o, o },
                { pw, pw, pw, pw, o, pw, pw, pw },
                { rw, nw, bw, qw, kw, bw, nw, rw }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Assert.AreEqual(rw, cb.GetPieceAt(a, one));
            Assert.AreEqual(nw, cb.GetPieceAt(b, one));
            Assert.AreEqual(bw, cb.GetPieceAt(c, one));
            Assert.AreEqual(qw, cb.GetPieceAt(d, one));
            Assert.AreEqual(kw, cb.GetPieceAt(e, one));
            Assert.AreEqual(bw, cb.GetPieceAt(f, one));
            Assert.AreEqual(nw, cb.GetPieceAt(g, one));
            Assert.AreEqual(rw, cb.GetPieceAt(h, one));
            Assert.AreEqual(pw, cb.GetPieceAt(a, two));
            Assert.AreEqual(pw, cb.GetPieceAt(b, two));
            Assert.AreEqual(pw, cb.GetPieceAt(c, two));
            Assert.AreEqual(pw, cb.GetPieceAt(d, two));
            Assert.AreEqual(o, cb.GetPieceAt(e, two));
            Assert.AreEqual(pw, cb.GetPieceAt(f, two));
            Assert.AreEqual(pw, cb.GetPieceAt(g, two));
            Assert.AreEqual(pw, cb.GetPieceAt(h, two));
            Assert.AreEqual(o, cb.GetPieceAt(a, three));
            Assert.AreEqual(o, cb.GetPieceAt(b, three));
            Assert.AreEqual(o, cb.GetPieceAt(c, three));
            Assert.AreEqual(o, cb.GetPieceAt(d, three));
            Assert.AreEqual(o, cb.GetPieceAt(e, three));
            Assert.AreEqual(o, cb.GetPieceAt(f, three));
            Assert.AreEqual(o, cb.GetPieceAt(g, three));
            Assert.AreEqual(o, cb.GetPieceAt(h, three));
            Assert.AreEqual(o, cb.GetPieceAt(a, four));
            Assert.AreEqual(o, cb.GetPieceAt(b, four));
            Assert.AreEqual(o, cb.GetPieceAt(c, four));
            Assert.AreEqual(o, cb.GetPieceAt(d, four));
            Assert.AreEqual(pw, cb.GetPieceAt(e, four));
            Assert.AreEqual(o, cb.GetPieceAt(f, four));
            Assert.AreEqual(o, cb.GetPieceAt(g, four));
            Assert.AreEqual(o, cb.GetPieceAt(h, four));
            Assert.AreEqual(o, cb.GetPieceAt(a, five));
            Assert.AreEqual(o, cb.GetPieceAt(b, five));
            Assert.AreEqual(o, cb.GetPieceAt(c, five));
            Assert.AreEqual(o, cb.GetPieceAt(d, five));
            Assert.AreEqual(o, cb.GetPieceAt(e, five));
            Assert.AreEqual(o, cb.GetPieceAt(f, five));
            Assert.AreEqual(o, cb.GetPieceAt(g, five));
            Assert.AreEqual(o, cb.GetPieceAt(h, five));
            Assert.AreEqual(o, cb.GetPieceAt(a, six));
            Assert.AreEqual(o, cb.GetPieceAt(b, six));
            Assert.AreEqual(cb.GetPieceAt(c, six), nb);
            Assert.AreEqual(o, cb.GetPieceAt(d, six));
            Assert.AreEqual(o, cb.GetPieceAt(e, six));
            Assert.AreEqual(o, cb.GetPieceAt(f, six));
            Assert.AreEqual(o, cb.GetPieceAt(g, six));
            Assert.AreEqual(o, cb.GetPieceAt(h, six));
            Assert.AreEqual(pb, cb.GetPieceAt(a, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(b, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(c, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(d, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(e, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(f, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(g, seven));
            Assert.AreEqual(pb, cb.GetPieceAt(h, seven));
            Assert.AreEqual(rb, cb.GetPieceAt(a, eight));
            Assert.AreEqual(o, cb.GetPieceAt(b, eight));
            Assert.AreEqual(bb, cb.GetPieceAt(c, eight));
            Assert.AreEqual(qb, cb.GetPieceAt(d, eight));
            Assert.AreEqual(kb, cb.GetPieceAt(e, eight));
            Assert.AreEqual(bb, cb.GetPieceAt(f, eight));
            Assert.AreEqual(nb, cb.GetPieceAt(g, eight));
            Assert.AreEqual(rb, cb.GetPieceAt(h, eight));
        }

        [Test]
        public void TestValidMoveWhitePawn()
        {
            Chessboard cb = new Chessboard();

            Move move1 = new Move(new Position(Position.Files.A, Position.Ranks.Two), new Position(Position.Files.A, Position.Ranks.Three), Players.White);

            Assert.True(cb.IsValidMove(move1), "move1 is considered invalid");
        }

        [Test]
        public void TestValidMoveWhitePawn_TwoSteps()
        {
            Chessboard cb = new Chessboard();

            Move move1 = new Move(new Position(Position.Files.D, Position.Ranks.Two), new Position(Position.Files.D, Position.Ranks.Four), Players.White);

            Assert.True(cb.IsValidMove(move1), "move1 is considered invalid");
        }

        [Test]
        public void TestValidMoveWhitePawn_Capture()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Two), new Position(Position.Files.E, Position.Ranks.Four), Players.White);
            Move move2 = new Move(new Position(Position.Files.D, Position.Ranks.Seven), new Position(Position.Files.D, Position.Ranks.Five), Players.Black);
            Move move3 = new Move(new Position(Position.Files.E, Position.Ranks.Four), new Position(Position.Files.D, Position.Ranks.Five), Players.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3));
        }

        [Test]
        public void TestValidMoveWhitePawn_EnPassant()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Two), new Position(Position.Files.E, Position.Ranks.Four), Players.White);
            Move move2 = new Move(new Position(Position.Files.E, Position.Ranks.Seven), new Position(Position.Files.E, Position.Ranks.Six), Players.Black);
            Move move3 = new Move(new Position(Position.Files.E, Position.Ranks.Four), new Position(Position.Files.E, Position.Ranks.Five), Players.White);
            Move move4 = new Move(new Position(Position.Files.D, Position.Ranks.Seven), new Position(Position.Files.D, Position.Ranks.Five), Players.Black);
            Move move5 = new Move(new Position(Position.Files.E, Position.Ranks.Five), new Position(Position.Files.D, Position.Ranks.Six), Players.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);

            Assert.True(cb.IsValidMove(move5));
        }

        [Test]
        public void TestInvalidMoveWhitePawn_EnPassant()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Two), new Position(Position.Files.E, Position.Ranks.Four), Players.White);
            Move move2 = new Move(new Position(Position.Files.E, Position.Ranks.Seven), new Position(Position.Files.E, Position.Ranks.Six), Players.Black);
            Move move3 = new Move(new Position(Position.Files.E, Position.Ranks.Four), new Position(Position.Files.E, Position.Ranks.Five), Players.White);
            Move move4 = new Move(new Position(Position.Files.H, Position.Ranks.Seven), new Position(Position.Files.H, Position.Ranks.Five), Players.Black);
            Move move5 = new Move(new Position(Position.Files.E, Position.Ranks.Five), new Position(Position.Files.D, Position.Ranks.Six), Players.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);

            Assert.False(cb.IsValidMove(move5));
        }

        [Test]
        public void TestInvalidMoveWhitePawn_NoCapture()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Two), new Position(Position.Files.E, Position.Ranks.Four), Players.White);
            Move move2 = new Move(new Position(Position.Files.D, Position.Ranks.Seven), new Position(Position.Files.D, Position.Ranks.Six), Players.Black);
            Move move3 = new Move(new Position(Position.Files.E, Position.Ranks.Four), new Position(Position.Files.D, Position.Ranks.Five), Players.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3));
        }

        [Test]
        public void TestInvalidMoveWhitePawn_TwoStepsBlockingPiece()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { kw, o, kb, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, pb, o, o, o },
                { o, o, o, o, pw, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Move move = new Move(new Position(Position.Files.E, Position.Ranks.Two), new Position(Position.Files.E, Position.Ranks.Four), Players.White);

            Assert.False(cb.IsValidMove(move), "move is considered valid");

        }

        [Test]
        public void TestInvalidMoveWhitePawn_TwoStepsNotOnRankTwo()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Two), new Position(Position.Files.E, Position.Ranks.Three), Players.White);
            Move move2 = new Move(new Position(Position.Files.E, Position.Ranks.Three), new Position(Position.Files.E, Position.Ranks.Five), Players.White);

            cb.ApplyMove(move1, true);

            Assert.False(cb.IsValidMove(move2), "move2 is considered valid");
        }

        [Test]
        public void TestValidMoveWhiteKnight()
        {
            Chessboard cb = new Chessboard();

            Move move1 = new Move(new Position(Position.Files.B, Position.Ranks.One), new Position(Position.Files.C, Position.Ranks.Three), Players.White);

            Assert.True(cb.IsValidMove(move1), "move1 is considered invalid");
        }

        [Test]
        public void TestValidMoveWhiteBishopC()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.D, Position.Ranks.Two), new Position(Position.Files.D, Position.Ranks.Three), Players.White);
            Move move2 = new Move(new Position(Position.Files.C, Position.Ranks.One), new Position(Position.Files.F, Position.Ranks.Four), Players.White);

            cb.ApplyMove(move1, true);

            Assert.True(cb.IsValidMove(move2), "move2 is considered invalid");
        }

        [Test]
        public void TestValidMoveWhiteBishopF()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Two), new Position(Position.Files.E, Position.Ranks.Three), Players.White);
            Move move2 = new Move(new Position(Position.Files.F, Position.Ranks.One), new Position(Position.Files.C, Position.Ranks.Four), Players.White);

            cb.ApplyMove(move1, true);

            Assert.True(cb.IsValidMove(move2), "move2 is considered invalid");
        }

        [Test]
        public void TestValidMoveWhiteRookA()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.A, Position.Ranks.Two), new Position(Position.Files.A, Position.Ranks.Three), Players.White);
            Move move2 = new Move(new Position(Position.Files.A, Position.Ranks.One), new Position(Position.Files.A, Position.Ranks.Two), Players.White);

            cb.ApplyMove(move1, true);

            Assert.True(cb.IsValidMove(move2), "move2 is considered invalid");
        }

        [Test]
        public void TestValidMoveWhiteRookH()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.H, Position.Ranks.Two), new Position(Position.Files.H, Position.Ranks.Three), Players.White);
            Move move2 = new Move(new Position(Position.Files.H, Position.Ranks.One), new Position(Position.Files.H, Position.Ranks.Two), Players.White);

            cb.ApplyMove(move1, true);

            Assert.True(cb.IsValidMove(move2), "move2 is considered invalid");
        }

        [Test]
        public void TestValidMoveWhiteQueenDiagonal()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Two), new Position(Position.Files.E, Position.Ranks.Three), Players.White);
            Move move2 = new Move(new Position(Position.Files.D, Position.Ranks.One), new Position(Position.Files.H, Position.Ranks.Five), Players.White);

            cb.ApplyMove(move1, true);

            Assert.True(cb.IsValidMove(move2), "move2 is considered invalid");
        }

        [Test]
        public void TestValidMoveWhiteQueenVertical()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.D, Position.Ranks.Two), new Position(Position.Files.D, Position.Ranks.Three), Players.White);
            Move move2 = new Move(new Position(Position.Files.D, Position.Ranks.One), new Position(Position.Files.D, Position.Ranks.Two), Players.White);

            cb.ApplyMove(move1, true);

            Assert.True(cb.IsValidMove(move2), "move2 is considered invalid");
        }

        [Test]
        public void TestValidMoveWhiteQueenHorizontal()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.B, Position.Ranks.One), new Position(Position.Files.C, Position.Ranks.Three), Players.White);
            Move move2 = new Move(new Position(Position.Files.D, Position.Ranks.Two), new Position(Position.Files.D, Position.Ranks.Three), Players.White);
            Move move3 = new Move(new Position(Position.Files.C, Position.Ranks.One), new Position(Position.Files.D, Position.Ranks.Two), Players.White);
            Move move4 = new Move(new Position(Position.Files.D, Position.Ranks.One), new Position(Position.Files.C, Position.Ranks.One), Players.White);
            Move move5 = new Move(new Position(Position.Files.D, Position.Ranks.One), new Position(Position.Files.B, Position.Ranks.One), Players.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);

            Assert.True(cb.IsValidMove(move4), "move4 is considered invalid");
            Assert.True(cb.IsValidMove(move5), "move5 is considered invalid");
        }

        [Test]
        public void TestValidMoveWhiteKingDiagonal()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.F, Position.Ranks.Two), new Position(Position.Files.F, Position.Ranks.Three), Players.White);
            Move move2 = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.F, Position.Ranks.Two), Players.White);

            cb.ApplyMove(move1, true);

            Assert.True(cb.IsValidMove(move2), "move2 is considered invalid");
        }

        [Test]
        public void TestValidMoveWhiteKingHorizontal()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.D, Position.Ranks.Two), new Position(Position.Files.D, Position.Ranks.Three), Players.White);
            Move move2 = new Move(new Position(Position.Files.D, Position.Ranks.One), new Position(Position.Files.D, Position.Ranks.Two), Players.White);
            Move move3 = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.D, Position.Ranks.One), Players.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3), "move3 is considered invalid");
        }

        [Test]
        public void TestValidMoveWhiteKingVertical()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Two), new Position(Position.Files.E, Position.Ranks.Three), Players.White);
            Move move2 = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.E, Position.Ranks.Two), Players.White);

            cb.ApplyMove(move1, true);

            Assert.True(cb.IsValidMove(move2), "move2 is considered invalid");
        }

        [Test]
        public void TestValidMoveWhiteKing_KingSideCastling()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, kb, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, rw }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.G, Position.Ranks.One), Players.White);

            Assert.True(cb.IsValidMove(move1), "move1 is considered invalid");
        }

        [Test]
        public void TestValidMoveWhiteKing_QueenSideCastling()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, kb, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { rw, o, o, o, kw, o, o, rw }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.C, Position.Ranks.One), Players.White);

            Assert.True(cb.IsValidMove(move1), "move1 is considered invalid");
        }

        [Test]
        public void TestInvalidMoveWhiteKing_KingSideCastling_WouldPassThroughCheck()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, kb, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, rb, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, rw }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.G, Position.Ranks.One), Players.White);

            Assert.False(cb.IsValidMove(move1), "move1 is considered valid");
        }

        [Test]
        public void TestInvalidMoveWhiteKing_QueenSideCastling_WouldPassThroughCheck()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, kb, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, rb, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { rw, o, o, o, kw, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.C, Position.Ranks.One), Players.White);

            Assert.False(cb.IsValidMove(move1), "move1 is considered valid");
        }

        [Test]
        public void TestValidMoveWhiteKing_KingSideCastling_WouldNotPassThroughCheck()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, kb, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, rb },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { rw, o, o, o, kw, o, o, rw }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.G, Position.Ranks.One), Players.White);

            Assert.True(cb.IsValidMove(move1), "move1 is considered invalid");
        }

        [Test]
        public void TestValidMoveWhiteKing_QueenSideCastling_WouldNotPassThroughCheck()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, kb, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, rb, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { rw, o, o, o, kw, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.C, Position.Ranks.One), Players.White);

            Assert.True(cb.IsValidMove(move1), "move1 is considered invalid");
        }

        [Test]
        public void TestInvalidMoveWhiteKing_KingSideCastling_BlockingPiece1()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, kb, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, rw, rw }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.G, Position.Ranks.One), Players.White);

            Assert.False(cb.IsValidMove(move1), "move1 is considered valid");
        }

        [Test]
        public void TestInvalidMoveWhiteKing_QueenSideCastling_BlockingPiece1()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, o, o, o, kb },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { rw, rw, o, o, kw, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.C, Position.Ranks.One), Players.White);

            Assert.False(cb.IsValidMove(move1), "move1 is considered valid");
        }

        [Test]
        public void TestInvalidMoveWhiteKing_KingSideCastling_BlockingPiece2()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, kb, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, rw, o, rw }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.G, Position.Ranks.One), Players.White);

            Assert.False(cb.IsValidMove(move1), "move1 is considered valid");
        }

        [Test]
        public void TestInvalidMoveWhiteKing_QueenSideCastling_BlockingPiece2()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, kb, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { rw, o, rw, o, kw, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.C, Position.Ranks.One), Players.White);

            Assert.False(cb.IsValidMove(move1), "move1 is considered valid");
        }

        [Test]
        public void TestInvalidMoveWhiteKing_QueenSideCastling_BlockingPiece3()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, kb, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { rw, o, o, rw, kw, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.C, Position.Ranks.One), Players.White);

            Assert.False(cb.IsValidMove(move1), "move1 is considered valid");
        }

        [Test]
        public void TestInvalidMoveWhiteKing_KingSideCastling_NoRook()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, kb, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.G, Position.Ranks.One), Players.White);

            Assert.False(cb.IsValidMove(move1), "move1 is considered valid");
        }

        [Test]
        public void TestInvalidMoveWhiteKing_QueenSideCastling_NoRook()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, kb, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.C, Position.Ranks.One), Players.White);

            Assert.False(cb.IsValidMove(move1), "move1 is considered valid");
        }

        [Test]
        public void TestInvalidMoveWhiteKing_KingSideCastling_RookMoved()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, kb, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, rw }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Move move1 = new Move(new Position(Position.Files.H, Position.Ranks.One), new Position(Position.Files.H, Position.Ranks.Two), Players.White);
            Move move2 = new Move(new Position(Position.Files.B, Position.Ranks.Eight), new Position(Position.Files.B, Position.Ranks.Seven), Players.Black);
            Move move3 = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.G, Position.Ranks.One), Players.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3), "move3 is considered valid");
        }

        [Test]
        public void TestInvalidMoveWhiteKing_QueenSideCastling_RookMoved()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, kb, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { rw, o, o, o, kw, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Move move1 = new Move(new Position(Position.Files.A, Position.Ranks.One), new Position(Position.Files.A, Position.Ranks.Two), Players.White);
            Move move2 = new Move(new Position(Position.Files.B, Position.Ranks.Eight), new Position(Position.Files.B, Position.Ranks.Seven), Players.Black);
            Move move3 = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.C, Position.Ranks.One), Players.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3), "move3 is considered valid");
        }

        [Test]
        public void TestInvalidMoveWhiteKing_KingSideCastling_KingMoved()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, kb, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, rw }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.D, Position.Ranks.One), Players.White);
            Move move2 = new Move(new Position(Position.Files.B, Position.Ranks.Eight), new Position(Position.Files.B, Position.Ranks.Seven), Players.Black);
            Move move3 = new Move(new Position(Position.Files.D, Position.Ranks.One), new Position(Position.Files.F, Position.Ranks.One), Players.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3), "move3 is considered valid");
        }

        [Test]
        public void TestInvalidMoveWhiteKing_QueenSideCastling_KingMoved()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, kb, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { rw, o, o, o, kw, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.D, Position.Ranks.One), Players.White);
            Move move2 = new Move(new Position(Position.Files.B, Position.Ranks.Eight), new Position(Position.Files.B, Position.Ranks.Seven), Players.Black);
            Move move3 = new Move(new Position(Position.Files.D, Position.Ranks.One), new Position(Position.Files.B, Position.Ranks.One), Players.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3), "move3 is considered valid");
        }

        [Test]
        public void TestValidMoveBlackPawn()
        {
            Chessboard cb = new Chessboard();

            Move move1 = new Move(new Position(Position.Files.A, Position.Ranks.Seven), new Position(Position.Files.A, Position.Ranks.Six), Players.Black);

            Assert.True(cb.IsValidMove(move1), "move1 is considered invalid");
        }

        [Test]
        public void TestValidMoveBlackPawn_TwoSteps()
        {
            Chessboard cb = new Chessboard();

            Move move1 = new Move(new Position(Position.Files.D, Position.Ranks.Seven), new Position(Position.Files.D, Position.Ranks.Five), Players.Black);

            Assert.True(cb.IsValidMove(move1), "move1 is considered invalid");
        }

        [Test]
        public void TestValidMoveBlackPawn_Capture()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Seven), new Position(Position.Files.E, Position.Ranks.Five), Players.Black);
            Move move2 = new Move(new Position(Position.Files.D, Position.Ranks.Two), new Position(Position.Files.D, Position.Ranks.Four), Players.White);
            Move move3 = new Move(new Position(Position.Files.E, Position.Ranks.Five), new Position(Position.Files.D, Position.Ranks.Four), Players.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3));
        }

        [Test]
        public void TestValidMoveBlackPawn_EnPassant()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.B, Position.Ranks.One), new Position(Position.Files.A, Position.Ranks.Three), Players.White);
            Move move2 = new Move(new Position(Position.Files.E, Position.Ranks.Seven), new Position(Position.Files.E, Position.Ranks.Five), Players.Black);
            Move move3 = new Move(new Position(Position.Files.E, Position.Ranks.Two), new Position(Position.Files.E, Position.Ranks.Three), Players.White);
            Move move4 = new Move(new Position(Position.Files.E, Position.Ranks.Five), new Position(Position.Files.E, Position.Ranks.Four), Players.Black);
            Move move5 = new Move(new Position(Position.Files.D, Position.Ranks.Two), new Position(Position.Files.D, Position.Ranks.Four), Players.White);
            Move move6 = new Move(new Position(Position.Files.E, Position.Ranks.Four), new Position(Position.Files.D, Position.Ranks.Three), Players.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);
            cb.ApplyMove(move5, true);

            Assert.True(cb.IsValidMove(move6));
        }

        [Test]
        public void TestInvalidMoveBlackPawn_EnPassant()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.B, Position.Ranks.One), new Position(Position.Files.A, Position.Ranks.Three), Players.White);
            Move move2 = new Move(new Position(Position.Files.E, Position.Ranks.Seven), new Position(Position.Files.E, Position.Ranks.Five), Players.Black);
            Move move3 = new Move(new Position(Position.Files.E, Position.Ranks.Two), new Position(Position.Files.E, Position.Ranks.Three), Players.White);
            Move move4 = new Move(new Position(Position.Files.E, Position.Ranks.Five), new Position(Position.Files.E, Position.Ranks.Four), Players.Black);
            Move move5 = new Move(new Position(Position.Files.H, Position.Ranks.Two), new Position(Position.Files.H, Position.Ranks.Four), Players.White);
            Move move6 = new Move(new Position(Position.Files.E, Position.Ranks.Four), new Position(Position.Files.D, Position.Ranks.Three), Players.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);
            cb.ApplyMove(move5, true);

            Assert.False(cb.IsValidMove(move6));
        }

        [Test]
        public void TestInvalidMoveBlackPawn_NoCapture()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Seven), new Position(Position.Files.E, Position.Ranks.Five), Players.Black);
            Move move2 = new Move(new Position(Position.Files.D, Position.Ranks.Two), new Position(Position.Files.D, Position.Ranks.Three), Players.White);
            Move move3 = new Move(new Position(Position.Files.E, Position.Ranks.Five), new Position(Position.Files.D, Position.Ranks.Four), Players.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3));
        }

        [Test]
        public void TestInvalidMoveBlackPawn_TwoStepsBlockingPiece()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, pb, o, o, o },
                { o, o, o, o, pw, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { kw, o, kb, o, o, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            Move move = new Move(new Position(Position.Files.E, Position.Ranks.Seven), new Position(Position.Files.E, Position.Ranks.Five), Players.Black);

            Assert.False(cb.IsValidMove(move), "move is considered valid");

        }

        [Test]
        public void TestInvalidMoveBlackPawn_TwoStepsNotOnRankSeven()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Seven), new Position(Position.Files.E, Position.Ranks.Six), Players.Black);
            Move move2 = new Move(new Position(Position.Files.E, Position.Ranks.Six), new Position(Position.Files.E, Position.Ranks.Four), Players.Black);

            cb.ApplyMove(move1, true);

            Assert.False(cb.IsValidMove(move2), "move2 is considered valid");
        }

        [Test]
        public void TestValidMoveBlackKnight()
        {
            Chessboard cb = new Chessboard();

            Move move1 = new Move(new Position(Position.Files.B, Position.Ranks.Eight), new Position(Position.Files.C, Position.Ranks.Six), Players.Black);

            Assert.True(cb.IsValidMove(move1), "move1 is considered invalid");
        }

        [Test]
        public void TestValidMoveBlackBishopC()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.D, Position.Ranks.Seven), new Position(Position.Files.D, Position.Ranks.Six), Players.Black);
            Move move2 = new Move(new Position(Position.Files.C, Position.Ranks.Eight), new Position(Position.Files.F, Position.Ranks.Five), Players.Black);

            cb.ApplyMove(move1, true);

            Assert.True(cb.IsValidMove(move2), "move2 is considered invalid");
        }

        [Test]
        public void TestValidMoveBlackBishopF()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Seven), new Position(Position.Files.E, Position.Ranks.Six), Players.Black);
            Move move2 = new Move(new Position(Position.Files.F, Position.Ranks.Eight), new Position(Position.Files.C, Position.Ranks.Five), Players.Black);

            cb.ApplyMove(move1, true);

            Assert.True(cb.IsValidMove(move2), "move2 is considered invalid");
        }

        [Test]
        public void TestValidMoveBlackQueenDiagonal()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Seven), new Position(Position.Files.E, Position.Ranks.Six), Players.Black);
            Move move2 = new Move(new Position(Position.Files.D, Position.Ranks.Eight), new Position(Position.Files.H, Position.Ranks.Four), Players.Black);

            cb.ApplyMove(move1, true);

            Assert.True(cb.IsValidMove(move2), "move2 is considered invalid");
        }

        [Test]
        public void TestValidMoveBlackQueenVertical()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.D, Position.Ranks.Seven), new Position(Position.Files.D, Position.Ranks.Six), Players.Black);
            Move move2 = new Move(new Position(Position.Files.D, Position.Ranks.Eight), new Position(Position.Files.D, Position.Ranks.Seven), Players.Black);

            cb.ApplyMove(move1, true);

            Assert.True(cb.IsValidMove(move2), "move2 is considered invalid");
        }

        [Test]
        public void TestValidMoveBlackQueenHorizontal()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.B, Position.Ranks.Eight), new Position(Position.Files.C, Position.Ranks.Six), Players.Black);
            Move move2 = new Move(new Position(Position.Files.D, Position.Ranks.Seven), new Position(Position.Files.D, Position.Ranks.Six), Players.Black);
            Move move3 = new Move(new Position(Position.Files.C, Position.Ranks.Eight), new Position(Position.Files.D, Position.Ranks.Seven), Players.Black);
            Move move4 = new Move(new Position(Position.Files.D, Position.Ranks.Eight), new Position(Position.Files.C, Position.Ranks.Eight), Players.Black);
            Move move5 = new Move(new Position(Position.Files.D, Position.Ranks.Eight), new Position(Position.Files.B, Position.Ranks.Eight), Players.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);

            Assert.True(cb.IsValidMove(move4), "move4 is considered invalid");
            Assert.True(cb.IsValidMove(move5), "move5 is considered invalid");
        }

        [Test]
        public void TestValidMoveBlackKingDiagonal()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.F, Position.Ranks.Seven), new Position(Position.Files.F, Position.Ranks.Six), Players.Black);
            Move move2 = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.F, Position.Ranks.Seven), Players.Black);

            cb.ApplyMove(move1, true);

            Assert.True(cb.IsValidMove(move2), "move2 is considered invalid");
        }

        [Test]
        public void TestValidMoveBlackKingHorizontal()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.D, Position.Ranks.Seven), new Position(Position.Files.D, Position.Ranks.Six), Players.Black);
            Move move2 = new Move(new Position(Position.Files.D, Position.Ranks.Eight), new Position(Position.Files.D, Position.Ranks.Seven), Players.Black);
            Move move3 = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.D, Position.Ranks.Eight), Players.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3), "move3 is considered invalid");
        }

        [Test]
        public void TestValidMoveBlackKingVertical()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Seven), new Position(Position.Files.E, Position.Ranks.Six), Players.Black);
            Move move2 = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.E, Position.Ranks.Seven), Players.Black);

            cb.ApplyMove(move1, true);

            Assert.True(cb.IsValidMove(move2), "move2 is considered invalid");
        }

        [Test]
        public void TestValidMoveBlackKing_KingSideCastling()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, kb, o, o, rb },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.G, Position.Ranks.Eight), Players.Black);

            Assert.True(cb.IsValidMove(move1), "move1 is considered invalid");
        }

        [Test]
        public void TestValidMoveBlackKing_QueenSideCastling()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { rb, o, o, o, kb, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.C, Position.Ranks.Eight), Players.Black);

            Assert.True(cb.IsValidMove(move1), "move1 is considered invalid");
        }

        [Test]
        public void TestInvalidMoveBlackKing_KingSideCastling_WouldPassThroughCheck()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, kb, o, o, rb },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, rw, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.G, Position.Ranks.Eight), Players.Black);

            Assert.False(cb.IsValidMove(move1), "move1 is considered valid");
        }

        [Test]
        public void TestInvalidMoveBlackKing_QueenSideCastling_WouldPassThroughCheck()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { rb, o, o, o, kb, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, rw, kw, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.C, Position.Ranks.Eight), Players.Black);

            Assert.False(cb.IsValidMove(move1), "move1 is considered valid");
        }

        [Test]
        public void TestValidMoveBlackKing_KingSideCastling_WouldNotPassThroughCheck()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, kb, o, o, rb },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, rw }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.G, Position.Ranks.Eight), Players.Black);

            Assert.True(cb.IsValidMove(move1), "move1 is considered invalid");
        }

        [Test]
        public void TestValidMoveBlackKing_QueenSideCastling_WouldNotPassThroughCheck()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { rb, o, o, o, kb, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, rw, o, o, kw, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.C, Position.Ranks.Eight), Players.Black);

            Assert.True(cb.IsValidMove(move1), "move1 is considered invalid");
        }

        [Test]
        public void TestInvalidMoveBlackKing_KingSideCastling_BlockingPiece1()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, kb, o, rb, rb },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, o}
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.G, Position.Ranks.Eight), Players.Black);

            Assert.False(cb.IsValidMove(move1), "move1 is considered valid");
        }

        [Test]
        public void TestInvalidMoveBlackKing_QueenSideCastling_BlockingPiece1()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { rb, rb, o, o, kb, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.C, Position.Ranks.Eight), Players.Black);

            Assert.False(cb.IsValidMove(move1), "move1 is considered valid");
        }

        [Test]
        public void TestInvalidMoveBlackKing_KingSideCastling_BlockingPiece2()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, kb, rb, o, rb },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.G, Position.Ranks.Eight), Players.Black);

            Assert.False(cb.IsValidMove(move1), "move1 is considered valid");
        }

        [Test]
        public void TestInvalidMoveBlackKing_QueenSideCastling_BlockingPiece2()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { rb, o, rb, o, kb, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.C, Position.Ranks.Eight), Players.Black);

            Assert.False(cb.IsValidMove(move1), "move1 is considered valid");
        }

        [Test]
        public void TestInvalidMoveBlackKing_QueenSideCastling_BlockingPiece3()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { rb, o, o, rb, kb, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.C, Position.Ranks.Eight), Players.Black);

            Assert.False(cb.IsValidMove(move1), "move1 is considered valid");
        }

        [Test]
        public void TestInvalidMoveBlackKing_KingSideCastling_NoRook()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, kb, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.G, Position.Ranks.Eight), Players.Black);

            Assert.False(cb.IsValidMove(move1), "move1 is considered valid");
        }

        [Test]
        public void TestInvalidMoveBlackKing_QueenSideCastling_NoRook()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, kb, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.C, Position.Ranks.Eight), Players.Black);

            Assert.False(cb.IsValidMove(move1), "move1 is considered valid");
        }

        [Test]
        public void TestInvalidMoveBlackKing_KingSideCastling_RookMoved()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, kb, o, o, rb },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, kw, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            Move move1 = new Move(new Position(Position.Files.H, Position.Ranks.Eight), new Position(Position.Files.H, Position.Ranks.Seven), Players.Black);
            Move move2 = new Move(new Position(Position.Files.B, Position.Ranks.One), new Position(Position.Files.B, Position.Ranks.Two), Players.White);
            Move move3 = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.G, Position.Ranks.Eight), Players.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3), "move3 is considered valid");
        }

        [Test]
        public void TestInvalidMoveBlackKing_QueenSideCastling_RookMoved()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { rb, o, o, o, kb, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, kw, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            Move move1 = new Move(new Position(Position.Files.A, Position.Ranks.Eight), new Position(Position.Files.A, Position.Ranks.Seven), Players.Black);
            Move move2 = new Move(new Position(Position.Files.B, Position.Ranks.One), new Position(Position.Files.B, Position.Ranks.Two), Players.White);
            Move move3 = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.C, Position.Ranks.Eight), Players.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3), "move3 is considered valid");
        }

        [Test]
        public void TestInvalidMoveBlackKing_KingSideCastling_KingMoved()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, kb, o, o, rb },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, kw, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.D, Position.Ranks.Eight), Players.Black);
            Move move2 = new Move(new Position(Position.Files.B, Position.Ranks.One), new Position(Position.Files.B, Position.Ranks.Two), Players.White);
            Move move3 = new Move(new Position(Position.Files.D, Position.Ranks.Eight), new Position(Position.Files.F, Position.Ranks.Eight), Players.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3), "move3 is considered valid");
        }

        [Test]
        public void TestInvalidMoveBlackKing_QueenSideCastling_KingMoved()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { rb, o, o, o, kb, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, kw, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.D, Position.Ranks.Eight), Players.Black);
            Move move2 = new Move(new Position(Position.Files.B, Position.Ranks.One), new Position(Position.Files.B, Position.Ranks.Two), Players.White);
            Move move3 = new Move(new Position(Position.Files.D, Position.Ranks.Eight), new Position(Position.Files.B, Position.Ranks.Eight), Players.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3), "move3 is considered valid");
        }

        [Test]
        public void TestInvalidMoveWhite_WouldBeInCheck()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { kw, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, qb },
                { pw, o, o, pb, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, kb, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Move move = new Move(new Position(Position.Files.A, Position.Ranks.Eight), new Position(Position.Files.A, Position.Ranks.Seven), Players.White);

            Assert.False(cb.IsValidMove(move));
        }

        [Test]
        public void TestInvalidMoveWhite_WouldBeCheckmated()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, kb, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, rb },
                { o, o, o, kw, nb, o, rb, o }
            };

            Chessboard cb = new Chessboard(board, Players.White);
            Move move = new Move(new Position(Position.Files.D, Position.Ranks.One), new Position(Position.Files.E, Position.Ranks.One), Players.White);

            Assert.False(cb.IsValidMove(move));
        }

        [Test]
        public void TestInvalidMoveWhiteRook_NoPassThrough()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, o, o, o, o },
                { rw, o, o, o, pw, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, kw, o, kb, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            Move move = new Move(new Position(Position.Files.A, Position.Ranks.Seven), new Position(Position.Files.G, Position.Ranks.Seven), Players.White);

            Assert.False(cb.IsValidMove(move));
        }

        [Test]
        public void TestInvalidMoveBlackKing_NoAdjacentKings()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, kb, o, kw, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            Move move1 = new Move(new Position(Position.Files.D, Position.Ranks.Six), new Position(Position.Files.E, Position.Ranks.Six), Players.Black);
            Move move2 = new Move(new Position(Position.Files.D, Position.Ranks.Six), new Position(Position.Files.E, Position.Ranks.Seven), Players.Black);
            Move move3 = new Move(new Position(Position.Files.D, Position.Ranks.Six), new Position(Position.Files.E, Position.Ranks.Five), Players.Black);

            Assert.False(cb.IsValidMove(move1), "move1 is considered valid");
            Assert.False(cb.IsValidMove(move2), "move2 is considered valid");
            Assert.False(cb.IsValidMove(move3), "move3 is considered valid");
        }

        [Test]
        public void TestApplyMoveWhitePawn()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Two), new Position(Position.Files.E, Position.Ranks.Three), Players.White);
            Assert.True(cb.ApplyMove(move1, false));
            ChessPiece[,] expected = new ChessPiece[8, 8]
            {
                { rb, nb, bb, qb, kb, bb, nb, rb },
                { pb, pb, pb, pb, pb, pb, pb, pb },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, pw, o, o, o },
                { pw, pw, pw, pw, o, pw, pw, pw },
                { rw, nw, bw, qw, kw, bw, nw, rw }
            };
            Assert.AreEqual(expected, cb.Board, "Unexpected board layout after applying move1");
            Move move2 = new Move(new Position(Position.Files.E, Position.Ranks.Three), new Position(Position.Files.E, Position.Ranks.Four), Players.White);
            Assert.True(cb.ApplyMove(move2, true));
            expected = new ChessPiece[8, 8]
            {
                { rb, nb, bb, qb, kb, bb, nb, rb },
                { pb, pb, pb, pb, pb, pb, pb, pb },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, pw, o, o, o },
                { o, o, o, o, o, o, o, o },
                { pw, pw, pw, pw, o, pw, pw, pw },
                { rw, nw, bw, qw, kw, bw, nw, rw }
            };
            Assert.AreEqual(expected, cb.Board, "Unexpected board layout after applying move2");
        }

        [Test]
        public void TestApplyMoveWhitePawn_EnPassant()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.E, Position.Ranks.Two), new Position(Position.Files.E, Position.Ranks.Four), Players.White);
            Move move2 = new Move(new Position(Position.Files.E, Position.Ranks.Seven), new Position(Position.Files.E, Position.Ranks.Six), Players.Black);
            Move move3 = new Move(new Position(Position.Files.E, Position.Ranks.Four), new Position(Position.Files.E, Position.Ranks.Five), Players.White);
            Move move4 = new Move(new Position(Position.Files.D, Position.Ranks.Seven), new Position(Position.Files.D, Position.Ranks.Five), Players.Black);
            Move move5 = new Move(new Position(Position.Files.E, Position.Ranks.Five), new Position(Position.Files.D, Position.Ranks.Six), Players.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);
            cb.ApplyMove(move5, true);

            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { rb, nb, bb, qb, kb, bb, nb, rb },
                { pb, pb, pb, o, o, pb, pb, pb },
                { o, o, o, pw, pb, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { pw, pw, pw, pw, o, pw, pw, pw },
                { rw, nw, bw, qw, kw, bw, nw, rw }
            };

            Assert.AreEqual(board, cb.Board, "Unexpected board layout after en passant capture.");
        }

        [Test]
        public void TestApplyMoveWhitePawn_PromotionToQueen()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, o, o, o, o },
                { pw, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, kw, o, kb, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Move move = new Move(new Position(Position.Files.A, Position.Ranks.Seven), new Position(Position.Files.A, Position.Ranks.Eight), Players.White, Pieces.Queen);
            Chessboard cb = new Chessboard(board, Players.White);
            Assert.True(cb.ApplyMove(move, false), "move should be valid");

            ChessPiece[,] expected = new ChessPiece[8, 8]
            {
                { qw, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, kw, o, kb, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Assert.AreEqual(expected, cb.Board);
        }

        [Test]
        public void TestApplyMoveBlackPawn_PromotionToQueen()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, kw, o, kb, pb, o },
                { o, o, o, o, o, o, o, o }
            };
            Move move = new Move(new Position(Position.Files.G, Position.Ranks.Two), new Position(Position.Files.G, Position.Ranks.One), Players.Black, Pieces.Queen);
            Chessboard cb = new Chessboard(board, Players.Black);
            Assert.True(cb.ApplyMove(move, false), "move should be valid");

            ChessPiece[,] expected = new ChessPiece[8, 8]
            {
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, kw, o, kb, o, o },
                { o, o, o, o, o, o, qb, o }
            };
            Assert.AreEqual(expected, cb.Board);
        }

        [Test]
        public void TestInvalidMoveWhitePawnPromotion_NoPieceSpecified()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, o, o, o, o },
                { pw, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, kw, o, kb, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Move move = new Move(new Position(Position.Files.A, Position.Ranks.Seven), new Position(Position.Files.A, Position.Ranks.Eight), Players.White);
            Chessboard cb = new Chessboard(board, Players.White);
            Assert.False(cb.IsValidMove(move), "move should be invalid");
        }

        [Test]
        public void TestInvalidMoveBlackPawnPromotion_NoPieceSpecified()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, kw, o, kb, pb, o },
                { o, o, o, o, o, o, o, o }
            };
            Move move = new Move(new Position(Position.Files.G, Position.Ranks.Two), new Position(Position.Files.G, Position.Ranks.One), Players.Black);
            Chessboard cb = new Chessboard(board, Players.Black);
            Assert.False(cb.IsValidMove(move), "move should be invalid");
        }

        [Test]
        public void TestApplyMoveBlackPawn_EnPassant()
        {
            Chessboard cb = new Chessboard();
            Move move1 = new Move(new Position(Position.Files.B, Position.Ranks.One), new Position(Position.Files.A, Position.Ranks.Three), Players.White);
            Move move2 = new Move(new Position(Position.Files.E, Position.Ranks.Seven), new Position(Position.Files.E, Position.Ranks.Five), Players.Black);
            Move move3 = new Move(new Position(Position.Files.E, Position.Ranks.Two), new Position(Position.Files.E, Position.Ranks.Three), Players.White);
            Move move4 = new Move(new Position(Position.Files.E, Position.Ranks.Five), new Position(Position.Files.E, Position.Ranks.Four), Players.Black);
            Move move5 = new Move(new Position(Position.Files.D, Position.Ranks.Two), new Position(Position.Files.D, Position.Ranks.Four), Players.White);
            Move move6 = new Move(new Position(Position.Files.E, Position.Ranks.Four), new Position(Position.Files.D, Position.Ranks.Three), Players.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);
            cb.ApplyMove(move5, true);
            cb.ApplyMove(move6, true);

            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { rb, nb, bb, qb, kb, bb, nb, rb },
                { pb, pb, pb, pb, o, pb, pb, pb },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { nw, o, o, pb, pw, o, o, o },
                { pw, pw, pw, o, o, pw, pw, pw },
                { rw, o, bw, qw, kw, bw, nw, rw }
            };

            Assert.AreEqual(board, cb.Board, "Unexpected board layout after en passant capture.");
        }

        [Test]
        public void TestApplyMoveWhiteKing_KingSideCastling()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, kb, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, rw }
            };
            Move move = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.G, Position.Ranks.One), Players.White);
            Chessboard cb = new Chessboard(board, Players.White);
            cb.ApplyMove(move, true);

            ChessPiece[,] expected = new ChessPiece[8, 8]
            {
                { o, o, o, o, kb, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, rw, kw, o }
            };

            Assert.AreEqual(expected, cb.Board);
        }

        [Test]
        public void TestApplyMoveWhiteKing_QueenSideCastling()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, kb, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { rw, o, o, o, kw, o, o, o }
            };
            Move move = new Move(new Position(Position.Files.E, Position.Ranks.One), new Position(Position.Files.C, Position.Ranks.One), Players.White);
            Chessboard cb = new Chessboard(board, Players.White);
            cb.ApplyMove(move, true);

            ChessPiece[,] expected = new ChessPiece[8, 8]
            {
                { o, o, o, o, kb, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, kw, rw, o, o, o, o }
            };

            Assert.AreEqual(expected, cb.Board);
        }

        [Test]
        public void TestApplyMoveBlackKing_KingSideCastling()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, kb, o, o, rb },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, o }
            };
            Move move = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.G, Position.Ranks.Eight), Players.Black);
            Chessboard cb = new Chessboard(board, Players.Black);
            cb.ApplyMove(move, true);

            ChessPiece[,] expected = new ChessPiece[8, 8]
            {
                { o, o, o, o, o, rb, kb, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, o }
            };

            Assert.AreEqual(expected, cb.Board);
        }

        [Test]
        public void TestApplyMoveBlackKing_QueenSideCastling()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { rb, o, o, o, kb, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, o }
            };
            Move move = new Move(new Position(Position.Files.E, Position.Ranks.Eight), new Position(Position.Files.C, Position.Ranks.Eight), Players.Black);
            Chessboard cb = new Chessboard(board, Players.Black);
            cb.ApplyMove(move, true);

            ChessPiece[,] expected = new ChessPiece[8, 8]
            {
                { o, o, kb, rb, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kw, o, o, o }
            };

            Assert.AreEqual(expected, cb.Board);
        }

        [Test]
        public void TestGetValidMovesWhiteStartingPosition()
        {
            Chessboard cb = new Chessboard();
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(Players.White);
            List<Move> expected = new List<Move>()
            {
                new Move("A2", "A3", Players.White),
                new Move("A2", "A4", Players.White),
                new Move("B2", "B3", Players.White),
                new Move("B2", "B4", Players.White),
                new Move("C2", "C3", Players.White),
                new Move("C2", "C4", Players.White),
                new Move("D2", "D3", Players.White),
                new Move("D2", "D4", Players.White),
                new Move("E2", "E3", Players.White),
                new Move("E2", "E4", Players.White),
                new Move("F2", "F3", Players.White),
                new Move("F2", "F4", Players.White),
                new Move("G2", "G3", Players.White),
                new Move("G2", "G4", Players.White),
                new Move("H2", "H3", Players.White),
                new Move("H2", "H4", Players.White),
                new Move("B1", "A3", Players.White),
                new Move("B1", "C3", Players.White),
                new Move("G1", "F3", Players.White),
                new Move("G1", "H3", Players.White)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public void TestGetValidMovesBlackStartingPosition()
        {
            Chessboard cb = new Chessboard();
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(Players.Black);
            List<Move> expected = new List<Move>()
            {
                new Move("A7", "A6", Players.Black),
                new Move("A7", "A5", Players.Black),
                new Move("B7", "B6", Players.Black),
                new Move("B7", "B5", Players.Black),
                new Move("C7", "C6", Players.Black),
                new Move("C7", "C5", Players.Black),
                new Move("D7", "D6", Players.Black),
                new Move("D7", "D5", Players.Black),
                new Move("E7", "E6", Players.Black),
                new Move("E7", "E5", Players.Black),
                new Move("F7", "F6", Players.Black),
                new Move("F7", "F5", Players.Black),
                new Move("G7", "G6", Players.Black),
                new Move("G7", "G5", Players.Black),
                new Move("H7", "H6", Players.Black),
                new Move("H7", "H5", Players.Black),
                new Move("B8", "A6", Players.Black),
                new Move("B8", "C6", Players.Black),
                new Move("G8", "F6", Players.Black),
                new Move("G8", "H6", Players.Black)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public void TestGetValidMovesWhiteKing()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, kb, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, kw, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Position(Position.Files.D, Position.Ranks.Four));
            List<Move> expected = new List<Move>()
            {
                new Move("D4", "C3", Players.White),
                new Move("D4", "C4", Players.White),
                new Move("D4", "C5", Players.White),
                new Move("D4", "D3", Players.White),
                new Move("D4", "D5", Players.White),
                new Move("D4", "E3", Players.White),
                new Move("D4", "E4", Players.White),
                new Move("D4", "E5", Players.White)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public void TestGetValidMovesWhiteKnight()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, kw, o, kb, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, nw, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Position(Position.Files.D, Position.Ranks.Four));
            List<Move> expected = new List<Move>()
            {
                new Move("D4", "C2", Players.White),
                new Move("D4", "B3", Players.White),
                new Move("D4", "C6", Players.White),
                new Move("D4", "B5", Players.White),
                new Move("D4", "E2", Players.White),
                new Move("D4", "E6", Players.White),
                new Move("D4", "F3", Players.White),
                new Move("D4", "F5", Players.White)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public void TestGetValidMovesWhiteBishop()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, kw, o, kb, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, bw, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Position(Position.Files.D, Position.Ranks.Four));
            List<Move> expected = new List<Move>()
            {
                new Move("D4", "A1", Players.White),
                new Move("D4", "B2", Players.White),
                new Move("D4", "C3", Players.White),
                new Move("D4", "E5", Players.White),
                new Move("D4", "F6", Players.White),
                new Move("D4", "G7", Players.White),
                new Move("D4", "H8", Players.White),
                new Move("D4", "G7", Players.White),
                new Move("D4", "F6", Players.White),
                new Move("D4", "E5", Players.White),
                new Move("D4", "C3", Players.White),
                new Move("D4", "B2", Players.White),
                new Move("D4", "A1", Players.White)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public void TestGetValidMovesWhiteRook()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, kw, o, kb, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, rw, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Position(Position.Files.D, Position.Ranks.Four));
            List<Move> expected = new List<Move>()
            {
                new Move("D4", "D1", Players.White),
                new Move("D4", "D2", Players.White),
                new Move("D4", "D3", Players.White),
                new Move("D4", "D5", Players.White),
                new Move("D4", "D6", Players.White),
                new Move("D4", "D7", Players.White),
                new Move("D4", "D8", Players.White),
                new Move("D4", "A4", Players.White),
                new Move("D4", "B4", Players.White),
                new Move("D4", "C4", Players.White),
                new Move("D4", "E4", Players.White),
                new Move("D4", "F4", Players.White),
                new Move("D4", "G4", Players.White),
                new Move("D4", "H4", Players.White)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public void TestGetValidMovesWhiteQueen()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, kw, o, kb, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, qw, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.White);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Position(Position.Files.D, Position.Ranks.Four));
            List<Move> expected = new List<Move>()
            {
                new Move("D4", "D1", Players.White),
                new Move("D4", "D2", Players.White),
                new Move("D4", "D3", Players.White),
                new Move("D4", "D5", Players.White),
                new Move("D4", "D6", Players.White),
                new Move("D4", "D7", Players.White),
                new Move("D4", "D8", Players.White),
                new Move("D4", "A4", Players.White),
                new Move("D4", "B4", Players.White),
                new Move("D4", "C4", Players.White),
                new Move("D4", "E4", Players.White),
                new Move("D4", "F4", Players.White),
                new Move("D4", "G4", Players.White),
                new Move("D4", "H4", Players.White),
                new Move("D4", "A1", Players.White),
                new Move("D4", "B2", Players.White),
                new Move("D4", "C3", Players.White),
                new Move("D4", "E5", Players.White),
                new Move("D4", "F6", Players.White),
                new Move("D4", "G7", Players.White),
                new Move("D4", "H8", Players.White),
                new Move("D4", "G7", Players.White),
                new Move("D4", "F6", Players.White),
                new Move("D4", "E5", Players.White),
                new Move("D4", "C3", Players.White),
                new Move("D4", "B2", Players.White),
                new Move("D4", "A1", Players.White)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public void TestGetValidMovesBlackKing()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { kw, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, kb, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Position(Position.Files.D, Position.Ranks.Four));
            List<Move> expected = new List<Move>()
            {
                new Move("D4", "C3", Players.Black),
                new Move("D4", "C4", Players.Black),
                new Move("D4", "C5", Players.Black),
                new Move("D4", "D3", Players.Black),
                new Move("D4", "D5", Players.Black),
                new Move("D4", "E3", Players.Black),
                new Move("D4", "E4", Players.Black),
                new Move("D4", "E5", Players.Black)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public void TestGetValidMovesBlackKnight()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, kw, o, kb, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, nb, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Position(Position.Files.D, Position.Ranks.Four));
            List<Move> expected = new List<Move>()
            {
                new Move("D4", "C2", Players.Black),
                new Move("D4", "B3", Players.Black),
                new Move("D4", "C6", Players.Black),
                new Move("D4", "B5", Players.Black),
                new Move("D4", "E2", Players.Black),
                new Move("D4", "E6", Players.Black),
                new Move("D4", "F3", Players.Black),
                new Move("D4", "F5", Players.Black)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public void TestGetValidMovesBlackBishop()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, kw, o, kb, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, bb, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Position(Position.Files.D, Position.Ranks.Four));
            List<Move> expected = new List<Move>()
            {
                new Move("D4", "A1", Players.Black),
                new Move("D4", "B2", Players.Black),
                new Move("D4", "C3", Players.Black),
                new Move("D4", "E5", Players.Black),
                new Move("D4", "F6", Players.Black),
                new Move("D4", "G7", Players.Black),
                new Move("D4", "H8", Players.Black),
                new Move("D4", "G7", Players.Black),
                new Move("D4", "F6", Players.Black),
                new Move("D4", "E5", Players.Black),
                new Move("D4", "C3", Players.Black),
                new Move("D4", "B2", Players.Black),
                new Move("D4", "A1", Players.Black)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public void TestGetValidMovesBlackRook()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, kw, o, kb, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, rb, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Position(Position.Files.D, Position.Ranks.Four));
            List<Move> expected = new List<Move>()
            {
                new Move("D4", "D1", Players.Black),
                new Move("D4", "D2", Players.Black),
                new Move("D4", "D3", Players.Black),
                new Move("D4", "D5", Players.Black),
                new Move("D4", "D6", Players.Black),
                new Move("D4", "D7", Players.Black),
                new Move("D4", "D8", Players.Black),
                new Move("D4", "A4", Players.Black),
                new Move("D4", "B4", Players.Black),
                new Move("D4", "C4", Players.Black),
                new Move("D4", "E4", Players.Black),
                new Move("D4", "F4", Players.Black),
                new Move("D4", "G4", Players.Black),
                new Move("D4", "H4", Players.Black)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public void TestGetValidMovesBlackQueen()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, kw, o, kb, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, qb, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Position(Position.Files.D, Position.Ranks.Four));
            List<Move> expected = new List<Move>()
            {
                new Move("D4", "D1", Players.Black),
                new Move("D4", "D2", Players.Black),
                new Move("D4", "D3", Players.Black),
                new Move("D4", "D5", Players.Black),
                new Move("D4", "D6", Players.Black),
                new Move("D4", "D7", Players.Black),
                new Move("D4", "D8", Players.Black),
                new Move("D4", "A4", Players.Black),
                new Move("D4", "B4", Players.Black),
                new Move("D4", "C4", Players.Black),
                new Move("D4", "E4", Players.Black),
                new Move("D4", "F4", Players.Black),
                new Move("D4", "G4", Players.Black),
                new Move("D4", "H4", Players.Black),
                new Move("D4", "A1", Players.Black),
                new Move("D4", "B2", Players.Black),
                new Move("D4", "C3", Players.Black),
                new Move("D4", "E5", Players.Black),
                new Move("D4", "F6", Players.Black),
                new Move("D4", "G7", Players.Black),
                new Move("D4", "H8", Players.Black),
                new Move("D4", "G7", Players.Black),
                new Move("D4", "F6", Players.Black),
                new Move("D4", "E5", Players.Black),
                new Move("D4", "C3", Players.Black),
                new Move("D4", "B2", Players.Black),
                new Move("D4", "A1", Players.Black)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach (Move move in expected)
            {
                Assert.True(actual.Contains(move), "Actual does not contain " + move.ToString());
            }
        }

        [Test]
        public void TestIsWhiteInCheck()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, o, o, o, o, o },
                { kw, o, o, o, o, o, o, qb },
                { pw, o, o, pb, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { kb, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.White);

            Assert.AreEqual(GameStatus.Events.Check, cb.Status.Event);
            Assert.AreEqual(Players.Black, cb.Status.PlayerWhoCausedEvent);
            Assert.AreEqual("White is in check", cb.Status.EventExplanation);
        }

        [Test]
        public void TestIsWhiteNotInCheck()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { kw, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, qb },
                { pw, o, o, pb, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, kb, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.White);

            Assert.AreEqual(GameStatus.Events.None, cb.Status.Event);
        }

        [Test]
        public void TestIsBlackInCheck()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, nw, o, o, o, o },
                { o, kb, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { kw, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, pb },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);

            Assert.AreEqual(GameStatus.Events.Check, cb.Status.Event);
            Assert.AreEqual(Players.White, cb.Status.PlayerWhoCausedEvent);
            Assert.AreEqual("Black is in check", cb.Status.EventExplanation);
        }

        [Test]
        public void TestIsBlackNotInCheck()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, o, nb, o, o, o, o },
                { o, kb, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { kw, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, pb },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);

            Assert.AreEqual(GameStatus.Events.None, cb.Status.Event);
        }

        [Test]
        public void TestBlackCheckmated()
        {
            Chessboard cb = new Chessboard();
            cb.ApplyMove(new Move("E2", "E4", Players.White), true);
            cb.ApplyMove(new Move("E7", "E5", Players.Black), true);
            cb.ApplyMove(new Move("F1", "C4", Players.White), true);
            cb.ApplyMove(new Move("D7", "D6", Players.Black), true);
            cb.ApplyMove(new Move("D1", "F3", Players.White), true);
            cb.ApplyMove(new Move("H7", "H6", Players.Black), true);
            Assert.True(cb.ApplyMove(new Move("F3", "F7", Players.White), false));

            Assert.AreEqual(GameStatus.Events.Checkmate, cb.Status.Event);
            Assert.AreEqual(Players.White, cb.Status.PlayerWhoCausedEvent);
            Assert.AreEqual("Black is checkmated", cb.Status.EventExplanation);
        }

        [Test]
        public void TestBlackStalemated()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { kb, o, kw, o, o, o, o, o },
                { o, o, qw, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);

            Assert.AreEqual(GameStatus.Events.Stalemate, cb.Status.Event);
            Assert.AreEqual(Players.White, cb.Status.PlayerWhoCausedEvent);
            Assert.AreEqual("Stalemate", cb.Status.EventExplanation);
        }

        [Test]
        public void TestBlackNotStalemated()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { kb, o, kw, o, o, o, o, o },
                { o, o, qw, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, new List<Move>() { new Move("A7", "A8", Players.Black) });

            Assert.AreEqual(GameStatus.Events.None, cb.Status.Event);
            Assert.AreEqual(Players.None, cb.Status.PlayerWhoCausedEvent);
            Assert.AreEqual("No special event", cb.Status.EventExplanation);
        }

        [Test]
        public void TestBlackNotStalematedAfterApplyMove()
        {
            ChessPiece[,] board = new ChessPiece[8, 8]
            {
                { o, o, kw, o, o, o, o, o },
                { kb, o, qw, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o },
                { o, o, o, o, o, o, o, o }
            };
            Chessboard cb = new Chessboard(board, Players.Black);

            Assert.True(cb.ApplyMove(new Move("A7", "A8", Players.Black), false));

            Assert.AreEqual(GameStatus.Events.None, cb.Status.Event);
            Assert.AreEqual(Players.None, cb.Status.PlayerWhoCausedEvent);
            Assert.AreEqual("No special event", cb.Status.EventExplanation);
        }
    }
}
