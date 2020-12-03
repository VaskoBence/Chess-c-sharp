using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Model
{
    public class Bishop : Pieces
    {
        int[,] valid = new int[14, 2];  // ebbe tároluk a valid változókat
        bool TopLeft, TopRight, BotLeft, BotRight; // irány vége ellenőrzés
        int a;  // tömb léptetéshez
        int j;  //irány segédváltozók
        public Bishop(String PieceType, String PieceColor) : base(PieceType)
        {
            this.PieceColor = PieceColor;
            if (PieceColor == "Wh")
            {
                Sign = "..\\..\\images\\WhBishop.png";
            }
            else
            {
                Sign = "..\\..\\images\\BlBishop.png";
            }
        }

        public override int[,] validMoves(int x, int y, String Color, Pieces[,] pieces)
        {
            TopLeft = TopRight = BotLeft = BotRight = true;
            a = 0;

            for (int i = 1; i < pieces.GetLength(0); i++)
            {
                j = i * (-1);
                //BotRight
                if (x + i <= 7 && y + i <= 7 && x + i >= 0 && y + i >= 0 && BotRight == true)
                {
                    if (pieces[x + i, y + i].PieceColor == "")
                    {
                        valid[a, 0] = x + i;
                        valid[a, 1] = y + i;
                    }
                    else if (pieces[x + i, y + i].PieceColor != Color)
                    {
                        valid[a, 0] = x + i;
                        valid[a, 1] = y + i;
                        BotRight = false;
                    }
                    else
                    {
                        valid[a, 0] = -1;
                        valid[a, 1] = -1;
                        BotRight = false;
                    }
                    a++;
                }
                //BotLeft
                if (x + i <= 7 && y + j <= 7 && x + i >= 0 && y + j >= 0 && BotLeft == true)
                {
                    if (pieces[x + i, y + j].PieceColor == "")
                    {
                        valid[a, 0] = x + i;
                        valid[a, 1] = y + j;
                    }
                    else if (pieces[x + i, y + j].PieceColor != Color)
                    {
                        valid[a, 0] = x + i;
                        valid[a, 1] = y + j;
                        BotLeft = false;
                    }
                    else
                    {
                        valid[a, 0] = -1;
                        valid[a, 1] = -1;
                        BotLeft = false;
                    }
                    a++;
                }

                //TopLeft
                if (x + j <= 7 && y + j <= 7 && x + j >= 0 && y + j >= 0 && TopLeft == true)
                {
                    if (pieces[x + j, y + j].PieceColor == "")
                    {
                        valid[a, 0] = x + j;
                        valid[a, 1] = y + j;
                    }
                    else if (pieces[x + j, y + j].PieceColor != Color)
                    {
                        valid[a, 0] = x + j;
                        valid[a, 1] = y + j;
                        TopLeft = false;
                    }
                    else
                    {
                        valid[a, 0] = -1;
                        valid[a, 1] = -1;
                        TopLeft = false;
                    }
                    a++;
                }
                //TopRight
                if (x + j <= 7 && y + i <= 7 && x + j >= 0 && y + i >= 0 && TopRight == true)
                {
                    if (pieces[x + j, y + i].PieceColor == "")
                    {
                        valid[a, 0] = x + j;
                        valid[a, 1] = y + i;
                    }
                    else if (pieces[x + j, y + i].PieceColor != Color)
                    {
                        valid[a, 0] = x + j;
                        valid[a, 1] = y + i;
                        TopRight = false;
                    }
                    else
                    {
                        valid[a, 0] = -1;
                        valid[a, 1] = -1;
                        TopRight = false;
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
