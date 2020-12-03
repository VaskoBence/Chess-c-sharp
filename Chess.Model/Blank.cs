using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Model
{
    public class Blank : Pieces
    {
        public Blank(String PieceType, String PieceColor) : base(PieceType)
        {
            this.PieceColor = PieceColor;
            Sign = "..\\..\\images\\Blank.png";
        }

        public override int[,] validMoves(int x,int y, String Color, Pieces[,] pieces)
        {
            int[,] valid = new int[2, 2] { { 1, 2 }, { 1, 2 } };
            return valid;
        }
    }
}
