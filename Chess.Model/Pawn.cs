using System;
using System.Collections.Generic;
using System.Text;


namespace Chess.Model
{
    public class Pawn : Pieces
    {
        int[,] valid = new int[4, 2];
        public Pawn(String PieceType, String PieceColor) : base(PieceType)
        {
            this.PieceColor = PieceColor;
            if(PieceColor == "Wh")
            {
				
				Sign = "..\\..\\images\\WhPawn.png";
            }
            else
            {
                Sign = "..\\..\\images\\BlPawn.png";
            }
        }

        public override int[,] validMoves(int x, int y, String Color, Pieces[,] pieces)
        {
            

            int ketto; // fehér és fekete esetében más irányba lép 1-et vagy 2-t, így negatív vagy pozitív lesz
            int egy;
            int pawnloc; // ahonnan kezdenek az egyes gyalogok
            String color2;

            // adatok megadása szín alapján
            if (Color == "Wh")
            {
                ketto = -2;
                egy = -1;
                pawnloc = 6;
                color2 = "Bl";
            }
            else
            {
                ketto = 2;
                egy = 1;
                pawnloc = 1;
                color2 = "Wh";
            }

            // egy előre
            if (x + egy < pieces.GetLength(0) && x + egy >= 0)
            {
                if (pieces[x + egy, y].PieceColor == "")
                {
                    valid[0, 0] = x + egy;
                    valid[0, 1] = y;
                }
                else
                {
                    valid[0, 0] = -1;
                }
            }
            // kettő előre
            if (x+ketto < pieces.GetLength(0) && x + ketto >=0 ) 
            {
                if (pieces[x + ketto, y].PieceColor == "" && pieces[x + egy, y].PieceColor == "" && x == pawnloc)
                {
                    valid[1, 0] = x + ketto;
                    valid[1, 1] = y;
                }
                else
                {
                    valid[1, 0] = -1;
                }
            }
            

            //ferdén
            if (y - 1 >= 0 && x + egy < pieces.GetLength(0) && x + egy >= 0)
            {
                if (pieces[x + egy, y - 1].PieceColor == color2 && y - 1 >= 0)
                {
                    valid[2, 0] = x + egy;
                    valid[2, 1] = y - 1;
                }
                else
                {
                    valid[2, 0] = -1;
                }
            }
            else
            {
                valid[2, 0] = -1;
            }

            if (y + 1 <= 7 && x + egy < pieces.GetLength(0) && x + egy >= 0)
            {
                if (pieces[x + egy, y + 1].PieceColor == color2)
                {
                    valid[3, 0] = x + egy;
                    valid[3, 1] = y + 1;
                }
                else
                {
                    valid[3, 0] = -1;
                }
            }
            else
            {
                valid[3, 0] = -1;
            }

            return valid;
		}

    }
}
