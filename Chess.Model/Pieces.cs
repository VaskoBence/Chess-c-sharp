using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Model
{
	public abstract class Pieces
    {

		public String PieceColor { get; protected set; } // fekete,fehér, vagy semmi, ha üres a mező
		public  String PieceType { get; protected set; } // bástya, paraszt, huszár, stb...
		public String Sign { get; protected set; }
		public bool hasMoved { get; set; } = false;
		public Pieces(String PieceType)
		{
			this.PieceType = PieceType;
		}			
		
		public abstract int[,] validMoves(int x, int y, String Color, Pieces[,] pieces);


	}
}
