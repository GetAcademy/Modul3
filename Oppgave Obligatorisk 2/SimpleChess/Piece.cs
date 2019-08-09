using System;

namespace SimpleChess
{
    abstract class Piece
    {
        public string Symbol { get; }
        private readonly string Type;

        public Piece(string type, string symbol)
        {
            Type = type;
            Symbol = symbol;
        }

        public abstract bool Move(string fromPosition, string toPosition);
        
    }
}
