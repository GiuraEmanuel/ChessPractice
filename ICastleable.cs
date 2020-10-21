using System;
using System.Collections.Generic;
using System.Text;

namespace ChessPractice
{
    public interface ICastleable
    {
        public bool hasMoved { get; set; }
        public bool CanCastle { get; set; }
    }
}
