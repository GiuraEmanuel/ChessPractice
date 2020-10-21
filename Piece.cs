using System;
using System.Collections.Generic;
using System.Text;

namespace ChessPractice
{

    public abstract class Piece
    {
        //public abstract bool CanBeCaptured { get; set; }
        public PieceType PieceType { get; set; }
        public abstract void Move();
        public abstract void Capture();
    }
}
