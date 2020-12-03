using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chess.Model;

namespace Chess.Forms
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Button[,] buttons = new System.Windows.Forms.Button[8, 8];
        public Pieces[,] pieces = new Pieces[8,8];
        System.Windows.Forms.Button[,] steps = new System.Windows.Forms.Button[8, 8];
        Bitmap blades = new Bitmap(System.Drawing.Image.FromFile("..\\..\\images\\blades.png"),new Size(30,30));
        int[] temp = new int[2];
        int[] lastMove = new int[4] { -1, -1, -1, -1 }; // 0,1 -source 0,2 - destination
        Button[] promoteButtons = new Button[4]; 
        Pieces[] reswap = new Pieces[1]; // helping array for reswapping
        public Form1()
        {

            InitializeComponent();

            this.AllowTransparency = true;
            piecesGenerate();
            boardGenerate();
            stepsGenerate();
            blades.MakeTransparent(blades.GetPixel(0, 0));
        }

        #region BoardFunctions  
        // generating buttons
        private void boardGenerate()
        {
         
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j] = new System.Windows.Forms.Button();
                    panel1.Controls.Add(buttons[i, j]);
                    buttons[i, j].BackColor = (j + i) % 2 == 0 ? System.Drawing.Color.Lavender : System.Drawing.Color.SlateGray;
                    buttons[i, j].Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    buttons[i, j].Location = new System.Drawing.Point(j * 50, i * 50);
                    buttons[i, j].Margin = new System.Windows.Forms.Padding(0);
                    buttons[i, j].Name = ("button" + ((i * 8) + (j + 1)));
                    buttons[i, j].Size = new System.Drawing.Size(50, 50);
                    buttons[i, j].TabIndex = 0;
                    buttons[i, j].UseVisualStyleBackColor = false;
                    buttons[i, j].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    buttons[i, j].FlatAppearance.BorderSize = 0;
                    buttons[i, j].Cursor = Cursors.Hand;
                    buttons[i, j].Click += PieceChoose;
                    buttons[i, j].BackgroundImage = new Bitmap(System.Drawing.Image.FromFile(pieces[i,j].Sign),new Size(40,40));
                    buttons[i, j].BackgroundImageLayout = ImageLayout.Center;
                    buttons[i, j].Enabled = false;
                }
            }
            
        }
        // function for replay
        private void boardReset()
        {
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j].BackgroundImage = new Bitmap(System.Drawing.Image.FromFile(pieces[i, j].Sign), new Size(40, 40));
                    steps[i, j].Visible = false;
                }
            }
        }
        // valid buttons press
        private void stepsGenerate()
        {
            for (int i = 0; i < steps.GetLength(0); i++)
            {
                for (int j = 0; j < steps.GetLength(1); j++)
                {
                    steps[i, j] = new System.Windows.Forms.Button();
                    panel1.Controls.Add(steps[i, j]);
                    steps[i, j].Location = new System.Drawing.Point((j * 50)+10, (i * 50)+10);
                    steps[i, j].UseVisualStyleBackColor = true;
                    steps[i, j].Margin = new System.Windows.Forms.Padding(0);
                    steps[i, j].Name = ("button" + ((i * 8) + (j + 1)));
                    steps[i, j].Size = new System.Drawing.Size(30, 30);
                    steps[i, j].Cursor = Cursors.Hand;
                    steps[i, j].Click += PieceMove;
                    steps[i, j].BackgroundImage = blades;
                    steps[i, j].FlatStyle = FlatStyle.Flat;
                    steps[i, j].FlatAppearance.BorderSize = 0;
                    steps[i, j].Visible = false;
                    steps[i, j].BringToFront();
                }
            }
        }

        // generating pieces array
        private void piecesGenerate()
        {
            //black line
            pieces[0, 0] = new Rook("Rook","Bl");
            pieces[0, 1] = new Knight("Knight", "Bl");
            pieces[0, 2] = new Bishop("Bishop", "Bl");
            pieces[0, 3] = new Queen("Queen", "Bl");
            pieces[0, 4] = new King("King", "Bl");
            pieces[0, 5] = new Bishop("Bishop", "Bl");
            pieces[0, 6] = new Knight("Knight", "Bl");
            pieces[0, 7] = new Rook("Rook", "Bl");
            //blank spaces
            for (int i = 2; i < 6; i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    pieces[i, j] = new Blank("","");
                }
            }
            // pawns
            for (int i = 0; i < buttons.GetLength(1); i++)
            {
                pieces[1, i] = new Pawn("Pawn", "Bl");
                pieces[6, i] = new Pawn("Pawn", "Wh");
            }
            // white line
            pieces[7, 0] = new Rook("Rook","Wh");
            pieces[7, 1] = new Knight("Knight", "Wh");
            pieces[7, 2] = new Bishop("Bishop", "Wh");
            pieces[7, 3] = new Queen("Queen", "Wh");
            pieces[7, 4] = new King("King", "Wh");
            pieces[7, 5] = new Bishop("Bishop", "Wh");
            pieces[7, 6] = new Knight("Knight", "Wh");
            pieces[7, 7] = new Rook("Rook", "Wh");
           
        }

        #endregion

        #region ButtonEvents


        // MAIN FUNCTION for play button
        private void play(object sender, EventArgs e)
        {
            Button button = sender as Button;
            String Color = "Wh";
            if(button.Text == "Restart")
            {
               var result = MessageBox.Show("Are you sure you want to restart the game?","",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    InfoText.Text = "White's turn!";
                    piecesGenerate();
                    boardReset();
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (pieces[i, j].PieceColor == Color)
                            {
                                buttons[i, j].Enabled = true;
                            }
                            else
                            {
                                buttons[i, j].Enabled = false;
                            }
                        }
                    }
                }
            }
            else
            {
                InfoText.Text = "White's turn!";
                piecesGenerate();
                boardReset();
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (pieces[i, j].PieceColor == Color)
                        {
                            buttons[i, j].Enabled = true;
                        }
                        else
                        {
                            buttons[i, j].Enabled = false;
                        }
                    }
                }
            }
            

            button.Text = "Restart";
        }
        // bábu mozgatása és játékos váltás
        private void PieceMove(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int x = (int.Parse(button.Name.Remove(0, 6)) - 1) / 8;
            int y = (int.Parse(button.Name.Remove(0, 6)) - 1) % 8;
            Swap(x, y, temp[0], temp[1]);
            lastMove[0] = temp[0];
            lastMove[1] = temp[1];
            lastMove[2] = x;
            lastMove[3] = y;
            // promotion check
            if (pieces[x, y].PieceType == "Pawn" && pieces[x, y].PieceColor == "Wh" && x == 0)
            {
                promotion(x, y, pieces[x, y].PieceColor);
            }
            else if(pieces[x, y].PieceType == "Pawn" && pieces[x, y].PieceColor == "Bl" && x == 7)
            {
                promotion(x, y, pieces[x, y].PieceColor);
            }
            else
            {
                ButtonEnable(pieces[x,y].PieceColor == "Wh"? "Bl" : "Wh");
                ButtonInvisible();
                InfoText.Text = (pieces[x, y].PieceColor == "Wh" ? "Black" : "White")  + "'s turn!" ;
                if(pieces[x,y].PieceType == "King" || pieces[x, y].PieceType == "King")
                {
                    if(pieces[x,y].hasMoved == false)
                    {
                        pieces[x, y].hasMoved = true;
                    }
                }
                LastMoveLabelChange();
                if (checkCheck(pieces[x, y].PieceColor) == true)
                {
                    InfoText.Text += " You are in check!";
                }
                if (checkMate((pieces[x, y].PieceColor == "Wh" ? "Bl" : "Wh")) == true)
                {
                    endGame(pieces[x, y].PieceColor);
                }
            }
        }
       
        // clicking on a piece's button
        private void PieceChoose(object sender, EventArgs e)
        {
            ButtonInvisible();
            // pressed button's place in array
            Button button = sender as Button;
            int x = (int.Parse(button.Name.Remove(0, 6)) - 1) / 8 ;
            int y = (int.Parse(button.Name.Remove(0, 6))-1) % 8;
            temp[0] = x;
            temp[1] = y;
            // whose color is the button
            String Color = pieces[x,y].PieceColor;
            
            //getting the valid positions
            int[,] validMoves = pieces[x, y].validMoves(x,y, Color, pieces);
            //checking for the extra rules
            enPassant(x, y);
            castling(x, y);
            // showing the valid moves
            for (int i = 0; i < validMoves.GetLength(0); i++)
            {
                if(validMoves[i,0]!= -1) 
                {
                    // ...check if we're still in check if we move.
                    reswap[0] = pieces[validMoves[i, 0], validMoves[i, 1]];
                    pieces[validMoves[i, 0], validMoves[i, 1]] = pieces[x, y];
                    pieces[x, y] = new Blank("", "");


                    if (checkCheck(Color == "Wh" ? "Bl" : "Wh") == false)
                    {
                        pieces[x, y] = pieces[validMoves[i, 0], validMoves[i, 1]];
                        pieces[validMoves[i, 0], validMoves[i, 1]] = reswap[0];
                        steps[validMoves[i, 0], validMoves[i, 1]].Visible = true;
                    }
                    else
                    {
                        pieces[x, y] = pieces[validMoves[i, 0], validMoves[i, 1]];
                        pieces[validMoves[i, 0], validMoves[i, 1]] = reswap[0];
                    }
                    
                    
                }
            }

           

        }
        #endregion

        #region HelpingFunctions

        // Button visibility change
        private void ButtonInvisible()
        {
            for (int i = 0; i < steps.GetLength(0); i++)
            {
                for (int j = 0; j < steps.GetLength(1); j++)
                {
                    steps[i, j].Visible = false;
                }
            }
        }

        //writing the previous move
        private void LastMoveLabelChange()
        {
            LastMoveLabel.Text = (Convert.ToChar(lastMove[1] + 65) + "" + Math.Abs(lastMove[0] - 8) +  " -> " + Convert.ToChar(lastMove[3] + 65) + "" + Math.Abs(lastMove[2] - 8)  );
        }

        // enable buttons for given color, disabling the others
        private void ButtonEnable(String Color)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (pieces[i, j].PieceColor == Color)
                    {
                        buttons[i, j].Enabled = true;
                    }
                    else
                    {
                        buttons[i, j].Enabled = false;
                    }
                }
            }
        }

        // moving the piece to a new location
        private void Swap(int i, int j, int x, int y)
        {
            pieces[i, j] = pieces[x, y];
            pieces[x, y] = new Blank("", "");
            buttons[i, j].BackgroundImage = buttons[x, y].BackgroundImage;
            buttons[x, y].BackgroundImage = base.BackgroundImage;
        }

        #endregion

        #region SpecialMoves

       
        // en passant
        public void enPassant(int x,int y)
        {
            if(lastMove[0]!= -1)
            {

                if (pieces[lastMove[2], lastMove[3]].PieceType =="Pawn" && Math.Abs(lastMove[0]-lastMove[2]) == 2 && x == lastMove[2])
                {
                    if (y - 1 == lastMove[3])
                    {
                        steps[lastMove[2], lastMove[3]].Visible = true;
                        steps[lastMove[2], lastMove[3]].Click -= PieceMove;
                        steps[lastMove[2], lastMove[3]].Click += enPassantClick;
                    }
                    if (y + 1 == lastMove[3])
                    {
                        steps[lastMove[2], lastMove[3]].Visible = true;
                        steps[lastMove[2], lastMove[3]].Click -= PieceMove;
                        steps[lastMove[2], lastMove[3]].Click += enPassantClick;
                    }
                }
            }
        }    
        
        public void enPassantClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int x = (int.Parse(button.Name.Remove(0, 6)) - 1) / 8;
            int y = (int.Parse(button.Name.Remove(0, 6)) - 1) % 8;
            int one = pieces[temp[0], temp[1]].PieceColor == "Wh" ? -1 : 1;
            Swap(x+one, y, temp[0], temp[1]);

            // en passant stuff
            pieces[x, y] = new Blank("", "");
            buttons[x, y].BackgroundImage = base.BackgroundImage;

            ButtonEnable(pieces[x+one, y].PieceColor == "Wh" ? "Bl" : "Wh");
            ButtonInvisible();
            InfoText.Text = (pieces[x+one, y].PieceColor == "Wh" ? "Black" : "White") + "'s turn";
            steps[lastMove[2], lastMove[3]].Click += PieceMove;
            steps[lastMove[2], lastMove[3]].Click -= enPassantClick;

            lastMove[0] = temp[0];
            lastMove[1] = temp[1];
            lastMove[2] = x;
            lastMove[3] = y;
            LastMoveLabelChange();
        }


        // promotion
        public void promotion(int x, int y, String Color)
        {
            // disable everything, except the promotion stuff, so you won't skip it 
            foreach (Button item in this.Controls.OfType<Button>())
            {
                item.Enabled = false;
            }
            foreach (Button item in panel1.Controls.OfType<Button>())
            {
                item.Enabled = false;
            }
            ButtonInvisible();
            if(Color == "Wh")
            {
                promoteBishop.BackgroundImage = new Bitmap(System.Drawing.Image.FromFile("..\\..\\images\\WhBishop.png"), new Size(40, 40));
                promoteKnight.BackgroundImage = new Bitmap(System.Drawing.Image.FromFile("..\\..\\images\\WhKnight.png"), new Size(40, 40));
                promoteRook.BackgroundImage = new Bitmap(System.Drawing.Image.FromFile("..\\..\\images\\WhRook.png"), new Size(40, 40));
                promoteQueen.BackgroundImage = new Bitmap(System.Drawing.Image.FromFile("..\\..\\images\\WhQueen.png"), new Size(40, 40));
            }
            else
            {
                promoteBishop.BackgroundImage = new Bitmap(System.Drawing.Image.FromFile("..\\..\\images\\BlBishop.png"), new Size(40, 40));
                promoteKnight.BackgroundImage = new Bitmap(System.Drawing.Image.FromFile("..\\..\\images\\BlKnight.png"), new Size(40, 40));
                promoteRook.BackgroundImage = new Bitmap(System.Drawing.Image.FromFile("..\\..\\images\\BlRook.png"), new Size(40, 40));
                promoteQueen.BackgroundImage = new Bitmap(System.Drawing.Image.FromFile("..\\..\\images\\BlQueen.png"), new Size(40, 40));

            }
            // make the promotion panel visible
            promotePanel.Visible = true;

        }

        public void promote_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            String type = button.Name.Remove(0, 7);
            button1.Text = type;
            String Color;
            if (lastMove[2] == 0)
            {
                Color = "Wh";
            }
            else
            {
                Color = "Bl";
            }
            switch (type)
            {
                case "Knight":
                    pieces[lastMove[2], lastMove[3]] = new Knight("Knight", Color);
                    break;
                case "Bishop":
                    pieces[lastMove[2], lastMove[3]] = new Bishop("Bishop", Color);
                    break;
                case "Rook":
                    pieces[lastMove[2], lastMove[3]] = new Rook("Rook", Color);
                    break;
                case "Queen":
                    pieces[lastMove[2], lastMove[3]] = new Queen("Queen", Color);
                    break;
            }
            foreach (Button item in this.Controls.OfType<Button>())
            {
                item.Enabled = true;
            }
            foreach (Button item in panel1.Controls.OfType<Button>())
            {
                item.Enabled = true;
            }

            buttons[lastMove[2], lastMove[3]].BackgroundImage = new Bitmap(System.Drawing.Image.FromFile(pieces[lastMove[2], lastMove[3]].Sign), new Size(40, 40));
            ButtonEnable(Color == "Wh" ? "Bl" : "Wh");
            promotePanel.Visible = false;
            ButtonInvisible();


            InfoText.Text = (pieces[lastMove[2], lastMove[3]].PieceColor == "Wh" ? "Black" : "White") + "'s turn!";
            if (pieces[lastMove[2],lastMove[3]].PieceType == "King" || pieces[lastMove[2],lastMove[3]].PieceType == "King")
            {
                if (pieces[lastMove[2],lastMove[3]].hasMoved == false)
                {
                    pieces[lastMove[2],lastMove[3]].hasMoved = true;
                }
            }
            LastMoveLabelChange();
            if (checkCheck(pieces[lastMove[2],lastMove[3]].PieceColor) == true)
            {
                InfoText.Text += " You are in check!";
            }
            if (checkMate((pieces[lastMove[2],lastMove[3]].PieceColor == "Wh" ? "Bl" : "Wh")) == true)
            {
                endGame(pieces[lastMove[2],lastMove[3]].PieceColor);
            }
        }


        // castling
        public void castling(int x, int y)
        {
            if(pieces[x,y].PieceType == "King" && pieces[x, y].hasMoved == false)
            {
                if (pieces[x, 0].PieceType == "Rook" && pieces[x, 0].hasMoved == false && pieces[x, 1].PieceType == "" && pieces[x, 2].PieceType == "" && pieces[x, 3].PieceType == "" && checkCheck(pieces[x,4].PieceColor == "Wh" ? "Bl" : "Wh") == false)
                {
                    pieces[x, 3] = pieces[x, 0];
                    pieces[x, 0] = new Blank("", "");
                    pieces[x, 2] = pieces[x, 4];
                    pieces[x, 4] = new Blank("", "");
                    if (checkCheck(pieces[x, 2].PieceColor == "Wh" ? "Bl" : "Wh") == false) 
                    {

                        steps[x, 2].Visible = true;
                        steps[x, 2].Click -= PieceMove;
                        steps[x, 2].Click += castlingClick;
                    }
                    pieces[x, 0] = pieces[x, 3];
                    pieces[x, 3] = new Blank("", "");
                    pieces[x, 4] = pieces[x, 2];
                    pieces[x, 2] = new Blank("", "");

                }
                if(pieces[x, 7].PieceType == "Rook" && pieces[x, 0].hasMoved == false && pieces[x, 6].PieceType == "" && pieces[x, 5].PieceType == "" && checkCheck(pieces[x, 4].PieceColor == "Wh" ? "Bl" : "Wh") == false) 
                {
                    pieces[x, 5] = pieces[x, 7];
                    pieces[x, 7] = new Blank("", "");
                    pieces[x, 6] = pieces[x, 4];
                    pieces[x, 4] = new Blank("", "");

                    if (checkCheck(pieces[x, 6].PieceColor == "Wh" ? "Bl" : "Wh") == false)
                    {

                        steps[x, 6].Visible = true;
                        steps[x, 6].Click -= PieceMove;
                        steps[x, 6].Click += castlingClick;
                    }
                    pieces[x, 7] = pieces[x, 5];
                    pieces[x, 5] = new Blank("", "");
                    pieces[x, 4] = pieces[x, 6];
                    pieces[x, 6] = new Blank("", "");
                }
            }
        }
        
        public void castlingClick(object sender, EventArgs e) 
        {
            Button button = sender as Button;
            int x = (int.Parse(button.Name.Remove(0, 6)) - 1) / 8;
            int y = (int.Parse(button.Name.Remove(0, 6)) - 1) % 8;
            Swap(x, y, temp[0], temp[1]);
            if(y == 6)
            {
                Swap( x, 5, x, 7);
            }
            else if(y == 2)
            {
                Swap( x, 3, x, 0);
            }

            ButtonEnable(pieces[x, y].PieceColor == "Wh" ? "Bl" : "Wh");
            ButtonInvisible();
            InfoText.Text = (pieces[x, y].PieceColor == "Wh" ? "Black" : "White") + "'s turn";
            steps[lastMove[2], lastMove[3]].Click += PieceMove;
            steps[lastMove[2], lastMove[3]].Click -= castlingClick;

            lastMove[0] = temp[0];
            lastMove[1] = temp[1];
            lastMove[2] = x;
            lastMove[3] = y;
        }


        // check and checkmate
        public bool checkCheck(String Color)
        {
            // check if the valid move's type is a king, then it's in check
            for(int i = 0; i < pieces.GetLength(0); i++)
            {
                for (int j = 0; j < pieces.GetLength(1); j++)
                {
                    if(pieces[i,j].PieceColor == Color)
                    {
                        int[,] validMoves = pieces[i, j].validMoves(i, j, Color, pieces);
                        for (int k = 0; k < validMoves.GetLength(0); k++)
                        {
                            if (validMoves[k, 0] != -1)
                            {
                                if(pieces[validMoves[k, 0], validMoves[k, 1]].PieceType == "King")
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;

        }

        public bool checkMate(String Color)
        {
            // check all of our pieces,...
            for (int i = 0; i < pieces.GetLength(0); i++)
            {
                for (int j = 0; j < pieces.GetLength(1); j++)
                {
                    if (pieces[i, j].PieceColor == Color)
                    {   
                        // ..check all pieces' valid moves,...
                        int[,] validMoves = pieces[i, j].validMoves(i, j, Color, pieces);
                        for (int k = 0; k < validMoves.GetLength(0); k++)
                        {
                            if (validMoves[k, 0] != -1)
                            {
                                // ...check if we're still in check if we move.
                                reswap[0] = pieces[validMoves[k, 0], validMoves[k, 1]];
                                pieces[validMoves[k, 0], validMoves[k, 1]] = pieces[i, j];
                                pieces[i, j] = new Blank("", "");

                                
                                if (checkCheck(Color == "Wh" ? "Bl" : "Wh") == false)
                                {
                                    pieces[i, j] = pieces[validMoves[k, 0], validMoves[k, 1]];
                                    pieces[validMoves[k, 0], validMoves[k, 1]] = reswap[0];
                                    return false;
                                }
                                else
                                {
                                    pieces[i, j] = pieces[validMoves[k, 0], validMoves[k, 1]];
                                    pieces[validMoves[k, 0], validMoves[k, 1]] = reswap[0];
                                }

                            }
                        }
                    }
                }
            }
            return true;
        }

        // gameover
        public void endGame(String Color)
        {
            String WinnerString = (Color == "Wh" ? "White" : "Black") + " won the game. Congratulations!";
            for (int i = 0; i < pieces.GetLength(0); i++)
            {
                for (int j = 0; j < pieces.GetLength(1); j++)
                {
                    buttons[i, j].Enabled = false;
                }
            }
            InfoText.Text = WinnerString;
            button1.Text = "Play";
            MessageBox.Show(WinnerString);  
        }
        #endregion
    }

}

