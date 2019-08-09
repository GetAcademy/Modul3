using System;
using System.Collections.Generic;
using System.Text;


namespace SimpleChess
{
    internal partial class Rook : Piece
    {
        
        public Rook(string Type,string Symbol = "TRN") : base(Type,Symbol)
        {
            
        }

        public override bool Move(string fromPosition, string toPosition)
        {
            return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
        }
    }
}
