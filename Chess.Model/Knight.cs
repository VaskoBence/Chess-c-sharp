using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Model
{
    public class Knight : Pieces
    {
        int[,] valid = new int[8, 2];
        int a;
        public Knight(String PieceType, String PieceColor) : base(PieceType)
        {
            this.PieceColor = PieceColor;
            if (PieceColor == "Wh")
            {
                Sign = "..\\..\\images\\WhKnight.png";
            }
            else
            {
                Sign = "..\\..\\images\\BlKnight.png";
            }
        }

        public override int[,] validMoves(int x, int y, String Color, Pieces[,] pieces)
        {
            a = 0;
            for (int i = -2; i < 3; i++)
            {
                for (int j = -2; j < 3; j++)
                {
                    if (Math.Abs(i) + Math.Abs(j) == 3)
                    {
                        if(x+i<=7 && y+j<=7 && x+i>=0 && y+j >= 0)
                        {
                            if (pieces[x + i, y + j].PieceColor != Color)
                            {
                                valid[a, 0] = x + i;
                                valid[a, 1] = y + j;
                                a++;
                            }
                            else
                            {
                                valid[a, 0] = -1;
                                valid[a, 1] = -1;
                                a++;
                            }
                        }
                        else
                        {
                            valid[a, 0] = -1;
                            valid[a, 1] = -1;
                            a++;
                        }
                    }
                }
            }
            return valid;
        }
    }
}
