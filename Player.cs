using System;
using System.Collections.Generic;
using System.Text;

namespace ChessPractice
{
    public class Player
    {
        public string Name { get; set; }
        public List<Piece> pieces = new List<Piece>();

        public Player(string _name)
        {
            Name = _name;
        }
    }
}
