using System;
using System.Collections.Generic;
using System.Text;

namespace ChessPractice
{
    public interface ICastable
    {
        public bool CanCastle { get; set; }
        public bool hasMoved { get; set; }
    }
}
