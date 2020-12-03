using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Model
{
    
    public class King : Pieces
    {
        int[,] valid = new int[9, 2];
        int a;
        public King(String PieceType, String PieceColor) : base(PieceType)
        {
            this.PieceColor = PieceColor;
            if (PieceColor == "Wh")
            {
                Sign = "..\\..\\images\\WhKing.png";
            }
            else
            {
                Sign = "..\\..\\images\\BlKing.png";
            }
        }

        public override int[,] validMoves(int x, int y, String Color, Pieces[,] pieces)
        {
            a = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (x + i <= 7 && y + j <= 7 && x + i >= 0 && y + j >= 0)
                    {
                        if (pieces[x + i, y + j].PieceColor != Color)
                        {
                            valid[a, 0] = x+i;
                            valid[a, 1] = y+j;
                        }
                        else
                        {
                            valid[a, 0] = -1;
                            valid[a, 1] = -1;
                        }
                    }
                    else
                    {
                        valid[a, 0] = -1;
                        valid[a, 1] = -1;
                    }
                    a++;
                }
            }

            return valid;
        }
    }
}
