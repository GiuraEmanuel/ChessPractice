using System;
using System.Collections.Generic;
using System.Text;

namespace ChessPractice
{
    public class Rook : Piece, ICapturable, ICastleable
    {
        public bool CanBeCaptured { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool CanCastle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool hasMoved { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Capture()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

       
    }
}
