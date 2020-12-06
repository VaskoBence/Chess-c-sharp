namespace Chess.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.promotePanel = new System.Windows.Forms.Panel();
            this.promoteQueen = new System.Windows.Forms.Button();
            this.promoteRook = new System.Windows.Forms.Button();
            this.promoteBishop = new System.Windows.Forms.Button();
            this.promoteKnight = new System.Windows.Forms.Button();
            this.promoteLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.InfoText = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.promotePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.promotePanel);
            this.panel1.Location = new System.Drawing.Point(30, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 0;
            // 
            // promotePanel
            // 
            this.promotePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.promotePanel.Controls.Add(this.promoteQueen);
            this.promotePanel.Controls.Add(this.promoteRook);
            this.promotePanel.Controls.Add(this.promoteBishop);
            this.promotePanel.Controls.Add(this.promoteKnight);
            this.promotePanel.Controls.Add(this.promoteLabel);
            this.promotePanel.Location = new System.Drawing.Point(69, 165);
            this.promotePanel.Name = "promotePanel";
            this.promotePanel.Size = new System.Drawing.Size(205, 94);
            this.promotePanel.TabIndex = 21;
            this.promotePanel.Visible = false;
            // 
            // promoteQueen
            // 
            this.promoteQueen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.promoteQueen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.promoteQueen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.promoteQueen.Location = new System.Drawing.Point(151, 41);
            this.promoteQueen.Name = "promoteQueen";
            this.promoteQueen.Size = new System.Drawing.Size(40, 40);
            this.promoteQueen.TabIndex = 4;
            this.promoteQueen.UseVisualStyleBackColor = true;
            this.promoteQueen.Click += new System.EventHandler(this.promote_Click);
            // 
            // promoteRook
            // 
            this.promoteRook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.promoteRook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.promoteRook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.promoteRook.Location = new System.Drawing.Point(105, 41);
            this.promoteRook.Name = "promoteRook";
            this.promoteRook.Size = new System.Drawing.Size(40, 40);
            this.promoteRook.TabIndex = 3;
            this.promoteRook.UseVisualStyleBackColor = true;
            this.promoteRook.Click += new System.EventHandler(this.promote_Click);
            // 
            // promoteBishop
            // 
            this.promoteBishop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.promoteBishop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.promoteBishop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.promoteBishop.Location = new System.Drawing.Point(59, 41);
            this.promoteBishop.Name = "promoteBishop";
            this.promoteBishop.Size = new System.Drawing.Size(40, 40);
            this.promoteBishop.TabIndex = 2;
            this.promoteBishop.UseVisualStyleBackColor = true;
            this.promoteBishop.Click += new System.EventHandler(this.promote_Click);
            // 
            // promoteKnight
            // 
            this.promoteKnight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.promoteKnight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.promoteKnight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.promoteKnight.Location = new System.Drawing.Point(13, 41);
            this.promoteKnight.Name = "promoteKnight";
            this.promoteKnight.Size = new System.Drawing.Size(40, 40);
            this.promoteKnight.TabIndex = 1;
            this.promoteKnight.UseVisualStyleBackColor = true;
            this.promoteKnight.Click += new System.EventHandler(this.promote_Click);
            // 
            // promoteLabel
            // 
            this.promoteLabel.AutoSize = true;
            this.promoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.promoteLabel.Location = new System.Drawing.Point(2, 13);
            this.promoteLabel.Name = "promoteLabel";
            this.promoteLabel.Size = new System.Drawing.Size(203, 16);
            this.promoteLabel.TabIndex = 0;
            this.promoteLabel.Text = "You can promote your pawn!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(471, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(5, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Wheat;
            this.label2.Location = new System.Drawing.Point(5, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Wheat;
            this.label3.Location = new System.Drawing.Point(5, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Wheat;
            this.label4.Location = new System.Drawing.Point(5, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Wheat;
            this.label5.Location = new System.Drawing.Point(5, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Wheat;
            this.label6.Location = new System.Drawing.Point(5, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Wheat;
            this.label7.Location = new System.Drawing.Point(5, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Wheat;
            this.label8.Location = new System.Drawing.Point(5, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Wheat;
            this.label9.Location = new System.Drawing.Point(45, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Wheat;
            this.label10.Location = new System.Drawing.Point(95, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "B";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Wheat;
            this.label11.Location = new System.Drawing.Point(145, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "C";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.Wheat;
            this.label12.Location = new System.Drawing.Point(195, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "D";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.Wheat;
            this.label13.Location = new System.Drawing.Point(245, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "E";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.Wheat;
            this.label14.Location = new System.Drawing.Point(295, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "F";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.Wheat;
            this.label15.Location = new System.Drawing.Point(345, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "G";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.Wheat;
            this.label16.Location = new System.Drawing.Point(395, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "H";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(471, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.play);
            // 
            // InfoText
            // 
            this.InfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InfoText.ForeColor = System.Drawing.SystemColors.Control;
            this.InfoText.Location = new System.Drawing.Point(30, 443);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(400, 29);
            this.InfoText.TabIndex = 20;
            this.InfoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(448, 204);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 20);
            this.label17.TabIndex = 21;
            this.label17.Text = "Last move:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(452, 236);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(154, 160);
            this.listBox1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(634, 481);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Chess";
            this.panel1.ResumeLayout(false);
            this.promotePanel.ResumeLayout(false);
            this.promotePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.Panel promotePanel;
        private System.Windows.Forms.Label promoteLabel;
        private System.Windows.Forms.Button promoteQueen;
        private System.Windows.Forms.Button promoteRook;
        private System.Windows.Forms.Button promoteBishop;
        private System.Windows.Forms.Button promoteKnight;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox listBox1;
    }
}

