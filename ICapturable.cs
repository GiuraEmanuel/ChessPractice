using System;
using System.Collections.Generic;
using System.Text;

namespace ChessPractice
{
    public interface ICapturable
    {
        public bool CanBeCaptured { get; set; }
    }
}
