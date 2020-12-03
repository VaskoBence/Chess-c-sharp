using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Model
{
    public class Queen : Pieces
    {
        int[,] valid = new int[27, 2];  // ebbe tároluk a valid változókat
        bool TopLeft, TopRight, BotLeft, BotRight; // irány vége ellenőrzés
        bool Top, Bot, Left, Right;
        int a;  // tömb léptetéshez
        int k;  //irány segédváltozók
        public Queen(String PieceType, String PieceColor) : base(PieceType)
        {
            this.PieceColor = PieceColor;
            if (PieceColor == "Wh")
            {
                Sign = "..\\..\\images\\WhQueen.png";
            }
            else
            {
                Sign = "..\\..\\images\\BlQueen.png";
            }
        }

        public override int[,] validMoves(int x, int y, String Color, Pieces[,] pieces)
        {
            TopLeft = TopRight = BotLeft = BotRight = true;
            Top = Bot = Left = Right = true;
            a = 0;

            for (int i = 1; i < pieces.GetLength(0); i++)
            {
               k = i * (-1);
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
                if (x + i <= 7 && y +k <= 7 && x + i >= 0 && y +k >= 0 && BotLeft == true)
                {
                    if (pieces[x + i, y +k].PieceColor == "")
                    {
                        valid[a, 0] = x + i;
                        valid[a, 1] = y +k;
                    }
                    else if (pieces[x + i, y +k].PieceColor != Color)
                    {
                        valid[a, 0] = x + i;
                        valid[a, 1] = y +k;
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
                if (x +k <= 7 && y +k <= 7 && x +k >= 0 && y +k >= 0 && TopLeft == true)
                {
                    if (pieces[x +k, y +k].PieceColor == "")
                    {
                        valid[a, 0] = x +k;
                        valid[a, 1] = y +k;
                    }
                    else if (pieces[x +k, y +k].PieceColor != Color)
                    {
                        valid[a, 0] = x +k;
                        valid[a, 1] = y +k;
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
                if (x +k <= 7 && y + i <= 7 && x +k >= 0 && y + i >= 0 && TopRight == true)
                {
                    if (pieces[x +k, y + i].PieceColor == "")
                    {
                        valid[a, 0] = x +k;
                        valid[a, 1] = y + i;
                    }
                    else if (pieces[x +k, y + i].PieceColor != Color)
                    {
                        valid[a, 0] = x +k;
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

            for (int i = 1; i < pieces.GetLength(0); i++)
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
                if (x - i >= 0 && Top == true)
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
                if (y - i >= 0 && Left == true)
                {
                    if (pieces[x, y - i].PieceColor == "")
                    {
                        valid[a, 0] = x;
                        valid[a, 1] = y - i;
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
