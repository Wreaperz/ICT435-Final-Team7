
namespace PACMAN
{
    partial class mainform
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
            this.components = new System.ComponentModel.Container();
            this.programLabel1 = new System.Windows.Forms.Label();
            this.programLabel2 = new System.Windows.Forms.Label();
            this.getStartedbtn = new System.Windows.Forms.Button();
            this.programLabel3 = new System.Windows.Forms.Label();
            this.pacmanMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.blueghostImg = new System.Windows.Forms.PictureBox();
            this.yellowghostImg = new System.Windows.Forms.PictureBox();
            this.pinkghostImg = new System.Windows.Forms.PictureBox();
            this.redghostImg = new System.Windows.Forms.PictureBox();
            this.pinkTimer = new System.Windows.Forms.Timer(this.components);
            this.yellowTimer = new System.Windows.Forms.Timer(this.components);
            this.redTimer = new System.Windows.Forms.Timer(this.components);
            this.blueTimer = new System.Windows.Forms.Timer(this.components);
            this.ashleyImg = new System.Windows.Forms.PictureBox();
            this.calebImg = new System.Windows.Forms.PictureBox();
            this.taylorImg = new System.Windows.Forms.PictureBox();
            this.isaiImg = new System.Windows.Forms.PictureBox();
            this.lucioImg = new System.Windows.Forms.PictureBox();
            this.pacmangif = new System.Windows.Forms.PictureBox();
            this.programLabel4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.blueghostImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowghostImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkghostImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redghostImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ashleyImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calebImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taylorImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isaiImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucioImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacmangif)).BeginInit();
            this.SuspendLayout();
            // 
            // programLabel1
            // 
            this.programLabel1.AutoEllipsis = true;
            this.programLabel1.Font = new System.Drawing.Font("Source Code Pro Black", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programLabel1.ForeColor = System.Drawing.Color.Yellow;
            this.programLabel1.Location = new System.Drawing.Point(260, 201);
            this.programLabel1.Name = "programLabel1";
            this.programLabel1.Size = new System.Drawing.Size(726, 32);
            this.programLabel1.TabIndex = 0;
            this.programLabel1.Tag = "frontLabels";
            this.programLabel1.Text = "The Prioritized Audit of Captures by Manual";
            this.programLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // programLabel2
            // 
            this.programLabel2.AutoEllipsis = true;
            this.programLabel2.AutoSize = true;
            this.programLabel2.Font = new System.Drawing.Font("Source Code Pro Black", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programLabel2.ForeColor = System.Drawing.Color.Yellow;
            this.programLabel2.Location = new System.Drawing.Point(235, 233);
            this.programLabel2.Name = "programLabel2";
            this.programLabel2.Size = new System.Drawing.Size(767, 34);
            this.programLabel2.TabIndex = 0;
            this.programLabel2.Tag = "frontLabels";
            this.programLabel2.Text = "Analysis over a Network (P.A.C. M.A.N.) Project";
            // 
            // getStartedbtn
            // 
            this.getStartedbtn.BackColor = System.Drawing.Color.White;
            this.getStartedbtn.FlatAppearance.BorderSize = 0;
            this.getStartedbtn.Font = new System.Drawing.Font("Source Code Pro Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getStartedbtn.Location = new System.Drawing.Point(522, 390);
            this.getStartedbtn.Name = "getStartedbtn";
            this.getStartedbtn.Size = new System.Drawing.Size(179, 50);
            this.getStartedbtn.TabIndex = 1;
            this.getStartedbtn.Text = "Get Started!";
            this.getStartedbtn.UseVisualStyleBackColor = false;
            this.getStartedbtn.Click += new System.EventHandler(this.getStartedbtn_Click);
            // 
            // programLabel3
            // 
            this.programLabel3.AutoEllipsis = true;
            this.programLabel3.AutoSize = true;
            this.programLabel3.Font = new System.Drawing.Font("Sitka Banner", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programLabel3.ForeColor = System.Drawing.Color.Yellow;
            this.programLabel3.Location = new System.Drawing.Point(294, 278);
            this.programLabel3.Name = "programLabel3";
            this.programLabel3.Size = new System.Drawing.Size(664, 26);
            this.programLabel3.TabIndex = 2;
            this.programLabel3.Tag = "frontLabels";
            this.programLabel3.Text = "Team Members: Ashley Godinez, Caleb Carpenter, Isai Rocha, Lucio Rubio, and Taylo" +
    "r Antonich";
            // 
            // pacmanMoveTimer
            // 
            this.pacmanMoveTimer.Enabled = true;
            this.pacmanMoveTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // blueghostImg
            // 
            this.blueghostImg.InitialImage = null;
            this.blueghostImg.Location = new System.Drawing.Point(350, 50);
            this.blueghostImg.Name = "blueghostImg";
            this.blueghostImg.Size = new System.Drawing.Size(68, 65);
            this.blueghostImg.TabIndex = 3;
            this.blueghostImg.TabStop = false;
            // 
            // yellowghostImg
            // 
            this.yellowghostImg.InitialImage = null;
            this.yellowghostImg.Location = new System.Drawing.Point(450, 50);
            this.yellowghostImg.Name = "yellowghostImg";
            this.yellowghostImg.Size = new System.Drawing.Size(68, 65);
            this.yellowghostImg.TabIndex = 4;
            this.yellowghostImg.TabStop = false;
            // 
            // pinkghostImg
            // 
            this.pinkghostImg.InitialImage = null;
            this.pinkghostImg.Location = new System.Drawing.Point(650, 50);
            this.pinkghostImg.Name = "pinkghostImg";
            this.pinkghostImg.Size = new System.Drawing.Size(68, 65);
            this.pinkghostImg.TabIndex = 5;
            this.pinkghostImg.TabStop = false;
            // 
            // redghostImg
            // 
            this.redghostImg.InitialImage = null;
            this.redghostImg.Location = new System.Drawing.Point(550, 50);
            this.redghostImg.Name = "redghostImg";
            this.redghostImg.Size = new System.Drawing.Size(68, 65);
            this.redghostImg.TabIndex = 6;
            this.redghostImg.TabStop = false;
            // 
            // pinkTimer
            // 
            this.pinkTimer.Enabled = true;
            this.pinkTimer.Tick += new System.EventHandler(this.pinkTimer_Tick);
            // 
            // yellowTimer
            // 
            this.yellowTimer.Enabled = true;
            this.yellowTimer.Tick += new System.EventHandler(this.yellowTimer_Tick);
            // 
            // redTimer
            // 
            this.redTimer.Enabled = true;
            this.redTimer.Tick += new System.EventHandler(this.redTimer_Tick);
            // 
            // blueTimer
            // 
            this.blueTimer.Enabled = true;
            this.blueTimer.Tick += new System.EventHandler(this.blueTimer_Tick);
            // 
            // ashleyImg
            // 
            this.ashleyImg.InitialImage = null;
            this.ashleyImg.Location = new System.Drawing.Point(43, 375);
            this.ashleyImg.Name = "ashleyImg";
            this.ashleyImg.Size = new System.Drawing.Size(68, 65);
            this.ashleyImg.TabIndex = 7;
            this.ashleyImg.TabStop = false;
            // 
            // calebImg
            // 
            this.calebImg.InitialImage = null;
            this.calebImg.Location = new System.Drawing.Point(117, 375);
            this.calebImg.Name = "calebImg";
            this.calebImg.Size = new System.Drawing.Size(68, 65);
            this.calebImg.TabIndex = 8;
            this.calebImg.TabStop = false;
            // 
            // taylorImg
            // 
            this.taylorImg.InitialImage = null;
            this.taylorImg.Location = new System.Drawing.Point(191, 375);
            this.taylorImg.Name = "taylorImg";
            this.taylorImg.Size = new System.Drawing.Size(68, 65);
            this.taylorImg.TabIndex = 9;
            this.taylorImg.TabStop = false;
            // 
            // isaiImg
            // 
            this.isaiImg.InitialImage = null;
            this.isaiImg.Location = new System.Drawing.Point(266, 375);
            this.isaiImg.Name = "isaiImg";
            this.isaiImg.Size = new System.Drawing.Size(68, 65);
            this.isaiImg.TabIndex = 10;
            this.isaiImg.TabStop = false;
            // 
            // lucioImg
            // 
            this.lucioImg.InitialImage = null;
            this.lucioImg.Location = new System.Drawing.Point(340, 375);
            this.lucioImg.Name = "lucioImg";
            this.lucioImg.Size = new System.Drawing.Size(68, 65);
            this.lucioImg.TabIndex = 11;
            this.lucioImg.TabStop = false;
            // 
            // pacmangif
            // 
            this.pacmangif.InitialImage = null;
            this.pacmangif.Location = new System.Drawing.Point(850, 50);
            this.pacmangif.Name = "pacmangif";
            this.pacmangif.Size = new System.Drawing.Size(68, 65);
            this.pacmangif.TabIndex = 0;
            this.pacmangif.TabStop = false;
            this.pacmangif.Click += new System.EventHandler(this.pacmangif_Click);
            // 
            // programLabel4
            // 
            this.programLabel4.AutoEllipsis = true;
            this.programLabel4.AutoSize = true;
            this.programLabel4.Font = new System.Drawing.Font("Sitka Banner", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programLabel4.ForeColor = System.Drawing.Color.Yellow;
            this.programLabel4.Location = new System.Drawing.Point(294, 313);
            this.programLabel4.Name = "programLabel4";
            this.programLabel4.Size = new System.Drawing.Size(250, 26);
            this.programLabel4.TabIndex = 12;
            this.programLabel4.Tag = "frontLabels";
            this.programLabel4.Text = "ICT 435 - Senior Project - Fall 2021";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1278, 644);
            this.Controls.Add(this.programLabel4);
            this.Controls.Add(this.lucioImg);
            this.Controls.Add(this.isaiImg);
            this.Controls.Add(this.taylorImg);
            this.Controls.Add(this.calebImg);
            this.Controls.Add(this.ashleyImg);
            this.Controls.Add(this.redghostImg);
            this.Controls.Add(this.pinkghostImg);
            this.Controls.Add(this.yellowghostImg);
            this.Controls.Add(this.blueghostImg);
            this.Controls.Add(this.programLabel3);
            this.Controls.Add(this.getStartedbtn);
            this.Controls.Add(this.programLabel2);
            this.Controls.Add(this.programLabel1);
            this.Controls.Add(this.pacmangif);
            this.Name = "mainform";
            this.Text = "P.A.C. M.A.N.";
            ((System.ComponentModel.ISupportInitialize)(this.blueghostImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowghostImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkghostImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redghostImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ashleyImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calebImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taylorImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isaiImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucioImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacmangif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label programLabel1;
        private System.Windows.Forms.Label programLabel2;
        private System.Windows.Forms.Button getStartedbtn;
        private System.Windows.Forms.Label programLabel3;
        private System.Windows.Forms.Timer pacmanMoveTimer;
        private System.Windows.Forms.PictureBox blueghostImg;
        private System.Windows.Forms.PictureBox yellowghostImg;
        private System.Windows.Forms.PictureBox pinkghostImg;
        private System.Windows.Forms.PictureBox redghostImg;
        private System.Windows.Forms.Timer pinkTimer;
        private System.Windows.Forms.Timer yellowTimer;
        private System.Windows.Forms.Timer redTimer;
        private System.Windows.Forms.Timer blueTimer;
        private System.Windows.Forms.PictureBox ashleyImg;
        private System.Windows.Forms.PictureBox calebImg;
        private System.Windows.Forms.PictureBox taylorImg;
        private System.Windows.Forms.PictureBox isaiImg;
        private System.Windows.Forms.PictureBox lucioImg;
        private System.Windows.Forms.PictureBox pacmangif;
        private System.Windows.Forms.Label programLabel4;
    }
}

