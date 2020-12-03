using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Model
{
    public class Rook : Pieces
    {
        int[,] valid = new int[14, 2];
        int a;
        bool Top, Bot, Left, Right;
        public Rook(String PieceType, String PieceColor) : base(PieceType)
        {
            this.PieceColor = PieceColor;
            if (PieceColor == "Wh")
            {
                Sign = "..\\..\\images\\WhRook.png";
            }
            else
            {
                Sign = "..\\..\\images\\BlRook.png";
            }
        }

        public override int[,] validMoves(int x, int y, String Color, Pieces[,] pieces)
        {
            Top = Bot = Left = Right = true;
            a = 0;

            for (int i = 1; i <pieces.GetLength(0); i++)
            {
                //Bot
                if (x + i <= 7 && Bot == true)
                {
                    if (pieces[x + i, y].PieceColor == "")
                    {
                        valid[a, 0] = x + i;
                        valid[a, 1] = y;
                    }
                    else if (pieces[x + i, y].PieceColor != Color)
                    {
                        valid[a, 0] = x + i;
                        valid[a, 1] = y;
                        Bot = false;
                    }
                    else
                    {
                        valid[a, 0] = -1;
                        valid[a, 1] = -1;
                        Bot = false;
                    }
                    a++;
                }

                //Top
                if ( x - i >= 0 && Top == true)
                {
                    if (pieces[x - i, y].PieceColor == "")
                    {
                        valid[a, 0] = x - i;
                        valid[a, 1] = y;
                    }
                    else if (pieces[x - i, y].PieceColor != Color)
                    {
                        valid[a, 0] = x - i;
                        valid[a, 1] = y;
                        Top = false;
                    }
                    else
                    {
                        valid[a, 0] = -1;
                        valid[a, 1] = -1;
                       Top = false;
                    }
                    a++;
                }

                //Left
                if (y - i >=0 && Left == true)
                {
                    if (pieces[x, y - i].PieceColor == "")
                    {
                        valid[a, 0] = x;
                        valid[a, 1] = y -i;
                    }
                    else if (pieces[x, y - i].PieceColor != Color)
                    {
                        valid[a, 0] = x;
                        valid[a, 1] = y - i;
                        Left = false;
                    }
                    else
                    {
                        valid[a, 0] = -1;
                        valid[a, 1] = -1;
                        Left = false;
                    }
                    a++;
                }

                //Right
                if (y + i <= 7 && Right == true)
                {
                    if (pieces[x, y + i].PieceColor == "")
                    {
                        valid[a, 0] = x;
                        valid[a, 1] = y + i;
                    }
                    else if (pieces[x, y + i].PieceColor != Color)
                    {
                        valid[a, 0] = x;
                        valid[a, 1] = y + i;
                        Right = false;
                    }
                    else
                    {
                        valid[a, 0] = -1;
                        valid[a, 1] = -1;
                        Right = false;
                    }
                    a++;
                }

            }
            for (int i = a; i < valid.GetLength(0); i++)
            {
                valid[i, 0] = -1;
                valid[i, 1] = -1;
            }
            return valid;
        }
    }
}
