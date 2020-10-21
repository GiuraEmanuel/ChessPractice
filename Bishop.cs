using System;
using System.Collections.Generic;
using System.Text;

namespace ChessPractice
{
    public class Bishop : Piece, ICapturable
    {
        public bool CanBeCaptured { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
