using System;
using System.Collections.Generic;
using System.Text;

namespace ChessPractice
{
    public class King : Piece, ICastleable
    {
        public bool IsInCheck { get; private set; }
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
        public void Castle()
        {
            
        }

        private void RightSideCastling()
        {

        }
        private void LeftSideCastling()
        {

        }

    }
}
