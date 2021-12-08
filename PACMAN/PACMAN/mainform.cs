using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PACMAN
{
    public partial class mainform : Form
    {
        int formWidth = 0;
        int formHeight = 0;

        #region PacMan and Ghost Movement Vars
        bool moveRight = true;
        bool moveDown = false;
        bool moveLeft = false;
        bool moveUp = false;
        int blueMove = 0;
        int yellowMove = 0;
        int pinkMove = 0;
        int redMove = 0;
        #endregion

        #region Elements for Screens 1 and 2
        Label meetTheTeam = new Label();
        Label ashleyLb = new Label();
        Label calebLb = new Label();
        Label taylorLb = new Label();
        Label isaiLb = new Label();
        Label lucioLb = new Label();
        Button letsGo = new Button();
        #endregion

        #region Screen 3 Elements
        TextBox pcapFileTB = new TextBox();
        TextBox srcIPTB = new TextBox();
        TextBox dstIPTB = new TextBox();
        TextBox srcPortTB = new TextBox();
        TextBox dstPortTB = new TextBox();
        TextBox srcMACTB = new TextBox();
        TextBox dstMACTB = new TextBox();

        Label pcapFileLb = new Label();
        Label srcIPLb = new Label();
        Label dstIPLb = new Label();
        Label srcPortLb = new Label();
        Label dstPortLb = new Label();
        Label srcMACLb = new Label();
        Label dstMACLb = new Label();

        Label fileCatLabel = new Label();
        Label ipCatLabel = new Label();
        Label portCatLabel = new Label();
        Label macCatLabel = new Label();

        PictureBox pacmangamePB = new PictureBox();
        #endregion

        string pcapFileName = "";
        string srcIP = "";
        string dstIP = "";
        string srcPort = "";
        string dstPort = "";
        string srcMAC = "";
        string dstMAC = "";

        public mainform()
        {
            InitializeComponent();

            formWidth = this.Width;
            formHeight = this.Height;

            pacmangif.Image = Image.FromFile("images/pacman64-right.gif");
            blueghostImg.Image = Image.FromFile("images/blueghost.png");
            yellowghostImg.Image = Image.FromFile("images/yellowghost.png");
            pinkghostImg.Image = Image.FromFile("images/pinkghost.png");
            redghostImg.Image = Image.FromFile("images/redghost.png");

            #region ENABLE and VISIBLE for Screen 2 Elements (DISABLE/NOT VISIBLE)
            ashleyImg.Enabled = false;
            calebImg.Enabled = false;
            taylorImg.Enabled = false;
            isaiImg.Enabled = false;
            lucioImg.Enabled = false;

            ashleyImg.Visible = false;
            calebImg.Visible = false;
            taylorImg.Visible = false;
            isaiImg.Visible = false;
            lucioImg.Visible = false;

            letsGo.Enabled = false;
            letsGo.Visible = false;
            #endregion

            programLabel1.Location = new Point(((formWidth / 2) - (programLabel1.Width / 2)), formHeight / 3);
            programLabel2.Location = new Point(((formWidth / 2) - (programLabel2.Width / 2)), formHeight / 3 + programLabel2.Height + 5);
            programLabel3.Location = new Point(((formWidth / 2) - (programLabel3.Width / 2)), formHeight / 3 + programLabel3.Height * 3);
            programLabel4.Location = new Point(((formWidth / 2) - (programLabel4.Width / 2)), formHeight / 3 + programLabel4.Height * 4);
            getStartedbtn.Location = new Point(((formWidth / 2) - (getStartedbtn.Width / 2)), formHeight / 3 + formHeight / 3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {         
            #region PacMan Movement
            if (moveRight == true)
            {
                if (pacmangif.Left < 1100)
                {                 
                    // move PacMan RIGHT
                    pacmangif.Left += 50;
                }
                else if (pacmangif.Left == 1100)
                {
                    pacmangif.Image = Image.FromFile("images/pacman64-down.gif");
                    moveRight = false;
                    moveDown = true;
                }
            }   
            else if(moveDown == true)
            {
                if (pacmangif.Top < 550)
                {                    
                    // move PacMan DOWN
                    pacmangif.Top += 50;
                }
                else if (pacmangif.Top == 550)
                {
                    pacmangif.Image = Image.FromFile("images/pacman64-left.gif");
                    moveDown = false;
                    moveLeft = true;
                }
            }            
            else if(moveLeft == true)
            {
                if (pacmangif.Left > 100)
                {                    
                    // move PacMan LEFT
                    pacmangif.Left -= 50;
                }
                else if (pacmangif.Left == 100)
                {
                    pacmangif.Image = Image.FromFile("images/pacman64-up.gif");
                    moveDown = false;
                    moveUp = true;                
                }
            }
            if(moveUp == true)
            {
                if (pacmangif.Top > 50)
                {                    
                    // move PacMan UP
                    pacmangif.Top -= 50;
                }
                else if (pacmangif.Top == 50)
                {
                    pacmangif.Image = Image.FromFile("images/pacman64-right.gif");
                    moveUp = false;
                    moveRight = true;
                }
            }
            #endregion
        }

        private void blueTimer_Tick(object sender, EventArgs e)
        {
            #region Blue Ghost Movement
            if (blueMove == 0)
            {
                if (blueghostImg.Left < 1100)
                {
                    blueghostImg.Left += 50;
                }
                else if (blueghostImg.Left == 1100)
                {
                    // Change blueMove int to 1 (down)
                    blueMove = 1;
                }
            }
            else if (blueMove == 1)
            {
                if (blueghostImg.Top < 550)
                {
                    blueghostImg.Top += 50;
                }
                else if (blueghostImg.Top == 550)
                {
                    // Change blueMove int to 2 (Left)
                    blueMove = 2;
                }
            }
            else if (blueMove == 2)
            {
                if (blueghostImg.Left > 100)
                {
                    blueghostImg.Left -= 50;
                }
                else if (blueghostImg.Left == 100)
                {
                    // Change blueMove int to 3 (Up)
                    blueMove = 3;
                }
            }
            else if (blueMove == 3)
            {
                if (blueghostImg.Top > 50)
                {
                    blueghostImg.Top -= 50;
                }
                else if (blueghostImg.Top == 50)
                {
                    // Change blueMove int to 0 (Right)
                    blueMove = 0;
                }
            }
            #endregion
        }
        private void yellowTimer_Tick(object sender, EventArgs e)
        {
            #region Yellow Ghost Movement
            if (yellowMove == 0)
            {
                if (yellowghostImg.Left < 1100)
                {
                    yellowghostImg.Left += 50;
                }
                else if (yellowghostImg.Left == 1100)
                {
                    // Change blueMove int to 1 (down)
                    yellowMove = 1;
                }
            }
            else if (yellowMove == 1)
            {
                if (yellowghostImg.Top < 550)
                {
                    yellowghostImg.Top += 50;
                }
                else if (yellowghostImg.Top == 550)
                {
                    // Change blueMove int to 2 (Left)
                    yellowMove = 2;
                }
            }
            else if (yellowMove == 2)
            {
                if (yellowghostImg.Left > 100)
                {
                    yellowghostImg.Left -= 50;
                }
                else if (yellowghostImg.Left == 100)
                {
                    // Change blueMove int to 3 (Up)
                    yellowMove = 3;
                }
            }
            else if (yellowMove == 3)
            {
                if (yellowghostImg.Top > 50)
                {
                    yellowghostImg.Top -= 50;
                }
                else if (yellowghostImg.Top == 50)
                {
                    // Change blueMove int to 0 (Right)
                    yellowMove = 0;
                }
            }
            #endregion
        }
        private void pinkTimer_Tick(object sender, EventArgs e)
        {
            #region Pink Ghost Movement
            if (pinkMove == 0)
            {
                if (pinkghostImg.Left < 1100)
                {
                    pinkghostImg.Left += 50;
                }
                else if (pinkghostImg.Left == 1100)
                {
                    // Change blueMove int to 1 (down)
                    pinkMove = 1;
                }
            }
            else if (pinkMove == 1)
            {
                if (pinkghostImg.Top < 550)
                {
                    pinkghostImg.Top += 50;
                }
                else if (pinkghostImg.Top == 550)
                {
                    // Change blueMove int to 2 (Left)
                    pinkMove = 2;
                }
            }
            else if (pinkMove == 2)
            {
                if (pinkghostImg.Left > 100)
                {
                    pinkghostImg.Left -= 50;
                }
                else if (pinkghostImg.Left == 100)
                {
                    // Change blueMove int to 3 (Up)
                    pinkMove = 3;
                }
            }
            else if (pinkMove == 3)
            {
                if (pinkghostImg.Top > 50)
                {
                    pinkghostImg.Top -= 50;
                }
                else if (pinkghostImg.Top == 50)
                {
                    // Change blueMove int to 0 (Right)
                    pinkMove = 0;
                }
            }
            #endregion
        }
        private void redTimer_Tick(object sender, EventArgs e)
        {
            #region Red Ghost Movement
            if (redMove == 0)
            {
                if (redghostImg.Left < 1100)
                {
                    redghostImg.Left += 50;
                }
                else if (redghostImg.Left == 1100)
                {
                    // Change blueMove int to 1 (down)
                    redMove = 1;
                }
            }
            else if (redMove == 1)
            {
                if (redghostImg.Top < 550)
                {
                    redghostImg.Top += 50;
                }
                else if (redghostImg.Top == 550)
                {
                    // Change blueMove int to 2 (Left)
                    redMove = 2;
                }
            }
            else if (redMove == 2)
            {
                if (redghostImg.Left > 100)
                {
                    redghostImg.Left -= 50;
                }
                else if (redghostImg.Left == 100)
                {
                    // Change blueMove int to 3 (Up)
                    redMove = 3;
                }
            }
            else if (redMove == 3)
            {
                if (redghostImg.Top > 50)
                {
                    redghostImg.Top -= 50;
                }
                else if (redghostImg.Top == 50)
                {
                    // Change blueMove int to 0 (Right)
                    redMove = 0;
                }
            }
            #endregion
        }

        private void getStartedbtn_Click(object sender, EventArgs e)
        {
            #region ENABLE and VISIBLE for Screen 1 Elements (DISABLE/NOT VISIBLE)
            programLabel1.Enabled = false;
            programLabel2.Enabled = false;
            programLabel3.Enabled = false;
            programLabel4.Enabled = false;

            programLabel1.Visible = false;
            programLabel2.Visible = false;
            programLabel3.Visible = false;
            programLabel4.Visible = false;

            getStartedbtn.Enabled = false;
            getStartedbtn.Visible = false;
            #endregion

            ashleyImg.Visible = true;
            calebImg.Visible = true;
            taylorImg.Visible = true;
            isaiImg.Visible = true;
            lucioImg.Visible = true;

            letsGo.Enabled = true;

            #region Team Photos
            ashleyImg.Size = new Size(267, 112);
            calebImg.Size = new Size(194, 192);
            taylorImg.Size = new Size(217, 111);
            isaiImg.Size = new Size(194, 192);
            lucioImg.Size = new Size(175, 189);

            ashleyImg.Image = Image.FromFile("images/ashley.png");
            calebImg.Image = Image.FromFile("images/caleb.png");
            taylorImg.Image = Image.FromFile("images/taylor.png");
            isaiImg.Image = Image.FromFile("images/isai.png");
            lucioImg.Image = Image.FromFile("images/lucio.png");

            ashleyImg.Location = new Point(281, 411);
            calebImg.Location = new Point(353, 171);
            taylorImg.Location = new Point(787, 411);
            isaiImg.Location = new Point(568, 171);
            lucioImg.Location = new Point(772, 171);

            ashleyImg.Enabled = true;
            calebImg.Enabled = true;
            taylorImg.Enabled = true;
            isaiImg.Enabled = true;
            lucioImg.Enabled = true;

            meetTheTeam = new Label();
            meetTheTeam.Text = "- Meet the Team -";
            meetTheTeam.Location = new Point(490, 115);
            meetTheTeam.ForeColor = Color.Yellow;
            meetTheTeam.AutoSize = true;
            meetTheTeam.Font = new Font("Source Code Pro Black", 20);
            this.Controls.Add(meetTheTeam);

            ashleyLb = new Label();
            ashleyLb.Text = "Ashley Godinez";
            ashleyLb.Location = new Point(360, 530);
            ashleyLb.ForeColor = Color.White;
            ashleyLb.AutoSize = true;
            this.Controls.Add(ashleyLb);

            calebLb = new Label();
            calebLb.Text = "Caleb Carpenter";
            calebLb.Location = new Point(380, 370);
            calebLb.ForeColor = Color.White;
            calebLb.AutoSize = true;
            this.Controls.Add(calebLb);

            taylorLb = new Label();
            taylorLb.Text = "Taylor Antonich";
            taylorLb.Location = new Point(830, 530);
            taylorLb.ForeColor = Color.White;
            taylorLb.AutoSize = true;
            this.Controls.Add(taylorLb);

            isaiLb = new Label();
            isaiLb.Text = "Isai Rocha";
            isaiLb.Location = new Point(610, 370);
            isaiLb.ForeColor = Color.White;
            isaiLb.AutoSize = true;
            this.Controls.Add(isaiLb);

            lucioLb = new Label();
            lucioLb.Text = "Lucio Rubio";
            lucioLb.Location = new Point(800, 370);
            lucioLb.ForeColor = Color.White;
            lucioLb.AutoSize = true;
            this.Controls.Add(lucioLb);
            #endregion        

            letsGo = new Button();
            letsGo.Size = new Size(140, 70);
            letsGo.Location = new Point(570, 435);
            letsGo.Text = "Let's Go!!";
            letsGo.ForeColor = Color.Black;
            letsGo.BackColor = Color.White;
            letsGo.Font = new Font("Source Code Pro Black", 12);
            letsGo.Click += new EventHandler(letsGo_Click);
            this.Controls.Add(letsGo);
        }

        private void ScapyFrontEnd()
        {          
            #region Disable All Previous Elements
            // "Let's Go!!" Button
            letsGo.Enabled = false;
            letsGo.Visible = false;

            // Team Photos and Labels (VISIBILITY)
            ashleyImg.Visible = false;
            calebImg.Visible = false;
            taylorImg.Visible = false;
            isaiImg.Visible = false;
            lucioImg.Visible = false;

            meetTheTeam.Visible = false;
            ashleyLb.Visible = false;
            calebLb.Visible = false;
            taylorLb.Visible = false;
            isaiLb.Visible = false;
            lucioLb.Visible = false;

            // PacMan and Ghosts (VISIBILITY)
            pacmangif.Visible = false;
            blueghostImg.Visible = false;
            yellowghostImg.Visible = false;
            pinkghostImg.Visible = false;
            redghostImg.Visible = false;


            // Team Photos and Labels (ENABLE)
            ashleyImg.Enabled = false;
            calebImg.Enabled = false;
            taylorImg.Enabled = false;
            isaiImg.Enabled = false;
            lucioImg.Enabled = false;

            meetTheTeam.Enabled = false;
            ashleyLb.Enabled = false;
            calebLb.Enabled = false;
            taylorLb.Enabled = false;
            isaiLb.Enabled = false;
            lucioLb.Enabled = false;

            // PacMan and Ghosts (ENABLE)
            pacmangif.Enabled = false;
            blueghostImg.Enabled = false;
            yellowghostImg.Enabled = false;
            pinkghostImg.Enabled = false;
            redghostImg.Enabled = false;


            // Movement Timers
            pacmanMoveTimer.Enabled = false;
            blueTimer.Enabled = false;
            yellowTimer.Enabled = false;
            pinkTimer.Enabled = false;
            redTimer.Enabled = false;
            #endregion

            Font basicTBFont = new Font("Source Code Pro Black", 12);
            Font basicLbFont = new Font("Source Code Pro Black", 10);

            #region PCAP File Name Category (Main Label, Textbox, and header Label)
            pcapFileTB = new TextBox();
            pcapFileTB.Size = new Size(300, 20);
            pcapFileTB.Location = new Point(formWidth / 2 - 20, formHeight - formHeight + 60);
            pcapFileTB.Font = basicTBFont;

            pcapFileLb = new Label();
            pcapFileLb.AutoSize = true;
            pcapFileLb.Text = "Name";
            pcapFileLb.Location = new Point(formWidth / 2 - 20, formHeight - formHeight + 40);
            pcapFileLb.Font = basicLbFont;
            pcapFileLb.ForeColor = Color.White;
            pcapFileLb.BackColor = Color.Black;

            fileCatLabel = new Label();
            fileCatLabel.AutoSize = true;
            fileCatLabel.Text = " Enter PCAP File Name (with '.pcap') ";
            fileCatLabel.Location = new Point(formWidth / 2 - 20, 12);
            fileCatLabel.Font = basicLbFont;
            fileCatLabel.ForeColor = Color.White;
            fileCatLabel.BackColor = Color.Black;

            this.Controls.Add(pcapFileTB);
            this.Controls.Add(pcapFileLb);
            this.Controls.Add(fileCatLabel);
            #endregion

            #region Graphics (rectangles) for Page 3 Design
            Graphics filenameGraphics = this.CreateGraphics();
            using (Pen yelPen = new Pen(Color.Yellow, 1))
            {
                filenameGraphics.DrawRectangle(yelPen, (formWidth / 2 - 30), 20, 320, 80);
                yelPen.Dispose();
                filenameGraphics.Dispose();
            }

            Graphics ipGraphics = this.CreateGraphics();
            using (Pen yelPen = new Pen(Color.Yellow, 1))
            {
                ipGraphics.DrawRectangle(yelPen, (formWidth / 2 - 30), 120, 640, 80);
                yelPen.Dispose();
                ipGraphics.Dispose();
            }

            Graphics portGraphics = this.CreateGraphics();
            using (Pen yelPen = new Pen(Color.Yellow, 1))
            {
                portGraphics.DrawRectangle(yelPen, (formWidth / 2 - 30), 220, 640, 80);
                yelPen.Dispose();
                portGraphics.Dispose();
            }

            Graphics macGraphics = this.CreateGraphics();
            using (Pen yelPen = new Pen(Color.Yellow, 1))
            {
                macGraphics.DrawRectangle(yelPen, (formWidth / 2 - 30), 320, 640, 80);
                yelPen.Dispose();
                macGraphics.Dispose();
            }
            #endregion

            #region SRC/DST IP, SRC/DST Port, SRC/DST MAC - TextBoxes
            srcIPTB = new TextBox();
            srcIPTB.Size = new Size(300, 20);
            srcIPTB.Location = new Point(formWidth / 2 - 20, 160);
            srcIPTB.Font = basicTBFont;

            dstIPTB = new TextBox();
            dstIPTB.Size = new Size(300, 20);
            dstIPTB.Location = new Point((formWidth / 2 - 20) + (formWidth / 4), 160);
            dstIPTB.Font = basicTBFont;

            srcPortTB = new TextBox();
            srcPortTB.Size = new Size(300, 20);
            srcPortTB.Location = new Point(formWidth / 2 - 20, 260);
            srcPortTB.Font = basicTBFont;

            dstPortTB = new TextBox();
            dstPortTB.Size = new Size(300, 20);
            dstPortTB.Location = new Point((formWidth / 2 - 20) + (formWidth / 4), 260);
            dstPortTB.Font = basicTBFont;

            srcMACTB = new TextBox();
            srcMACTB.Size = new Size(300, 20);
            srcMACTB.Location = new Point(formWidth / 2 - 20, 360);
            srcMACTB.Font = basicTBFont;

            dstMACTB = new TextBox();
            dstMACTB.Size = new Size(300, 20);
            dstMACTB.Location = new Point((formWidth / 2 - 20) + (formWidth / 4), 360);
            dstMACTB.Font = basicTBFont;

            this.Controls.Add(srcIPTB);
            this.Controls.Add(dstIPTB);
            this.Controls.Add(srcPortTB);
            this.Controls.Add(dstPortTB);
            this.Controls.Add(srcMACTB);
            this.Controls.Add(dstMACTB);
            #endregion

            #region SRC/DST IP, SRC/DST Port, SRC/DST MAC - Labels
            srcIPLb = new Label();
            srcIPLb.AutoSize = true;
            srcIPLb.Text = "Source";
            srcIPLb.Location = new Point(formWidth / 2 - 20, 140);
            srcIPLb.Font = basicLbFont;
            srcIPLb.ForeColor = Color.White;
            srcIPLb.BackColor = Color.Black;

            dstIPLb = new Label();
            dstIPLb.AutoSize = true;
            dstIPLb.Text = "Destination";
            dstIPLb.Location = new Point((formWidth / 2 - 20) + (formWidth / 4), 140);
            dstIPLb.Font = basicLbFont;
            dstIPLb.ForeColor = Color.White;
            dstIPLb.BackColor = Color.Black;

            srcPortLb = new Label();
            srcPortLb.AutoSize = true;
            srcPortLb.Text = "Source";
            srcPortLb.Location = new Point(formWidth / 2 - 20, 240);
            srcPortLb.Font = basicLbFont;
            srcPortLb.ForeColor = Color.White;
            srcPortLb.BackColor = Color.Black;

            dstPortLb = new Label();
            dstPortLb.AutoSize = true;
            dstPortLb.Text = "Destination";
            dstPortLb.Location = new Point((formWidth / 2 - 20) + (formWidth / 4), 240);
            dstPortLb.Font = basicLbFont;
            dstPortLb.ForeColor = Color.White;
            dstPortLb.BackColor = Color.Black;

            srcMACLb = new Label();
            srcMACLb.AutoSize = true;
            srcMACLb.Text = "Source";
            srcMACLb.Location = new Point(formWidth / 2 - 20, 340);
            srcMACLb.Font = basicLbFont;
            srcMACLb.ForeColor = Color.White;
            srcMACLb.BackColor = Color.Black;

            dstMACLb = new Label();
            dstMACLb.AutoSize = true;
            dstMACLb.Text = "Destination";
            dstMACLb.Location = new Point((formWidth / 2 - 20) + (formWidth / 4), 340);
            dstMACLb.Font = basicLbFont;
            dstMACLb.ForeColor = Color.White;
            dstMACLb.BackColor = Color.Black;

            this.Controls.Add(srcIPLb);
            this.Controls.Add(dstIPLb);
            this.Controls.Add(srcPortLb);
            this.Controls.Add(dstPortLb);
            this.Controls.Add(srcMACLb);
            this.Controls.Add(dstMACLb);
            #endregion

            #region Category Labels
            ipCatLabel = new Label();
            ipCatLabel.AutoSize = true;
            ipCatLabel.Text = "Enter Source And Destination IP Addresses";
            ipCatLabel.Location = new Point(formWidth / 2 - 20, 112);
            ipCatLabel.Font = basicLbFont;
            ipCatLabel.ForeColor = Color.White;
            ipCatLabel.BackColor = Color.Black;

            portCatLabel = new Label();
            portCatLabel.AutoSize = true;
            portCatLabel.Text = "Enter Source and Destination Ports";
            portCatLabel.Location = new Point(formWidth / 2 - 20, 212);
            portCatLabel.Font = basicLbFont;
            portCatLabel.ForeColor = Color.White;
            portCatLabel.BackColor = Color.Black;

            macCatLabel = new Label();
            macCatLabel.AutoSize = true;
            macCatLabel.Text = "Enter Source and Destination MAC Addresses";
            macCatLabel.Location = new Point(formWidth / 2 - 20, 312);
            macCatLabel.Font = basicLbFont;
            macCatLabel.ForeColor = Color.White;
            macCatLabel.BackColor = Color.Black;

            this.Controls.Add(ipCatLabel);
            this.Controls.Add(portCatLabel);
            this.Controls.Add(macCatLabel);
            #endregion

            pacmangamePB = new PictureBox();
            pacmangamePB.Size = new Size(440, 428);
            pacmangamePB.Location = new Point(70, 40);
            pacmangamePB.Image = Image.FromFile("images/pacmangame3.gif");
            this.Controls.Add(pacmangamePB);

            Button runScapy = new Button();
            runScapy.Size = new Size(160, 70);
            runScapy.Location = new Point(formWidth / 14 - 30, 525);
            runScapy.Text = "CHOMP!!";
            runScapy.ForeColor = Color.Black;
            runScapy.BackColor = Color.White;
            runScapy.Font = new Font("Source Code Pro Black", 20);
            runScapy.Click += new EventHandler(runScapy_Click);
            this.Controls.Add(runScapy);
        }

        private void ScapySkeleton(string filename, string sourceIP, string destinationIP, string sourcePort, string destinationPort, string sourceMAC, string destinationMAC)
        {
            #region Set Default Values if None are Passed
            // Set Default Values
            if (filename == "")
            {
                filename = "default.pcap";
            }
            if (sourceIP == "")
            {
                sourceIP = "192.168.1.137";
            }
            if (destinationIP == "")
            {
                destinationIP = "172.217.166.100";
            }
            if (sourcePort == "")
            {
                sourcePort = "46324";
            }
            if (destinationPort == "")
            {
                destinationPort = "443";
            }
            #endregion

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:/Windows/py.exe";
            start.Arguments = "scapy/ScapySkeletonV4.py " + filename + " " + sourceIP + " " + destinationIP + " " + sourcePort + " " + destinationPort + " " + sourceMAC + " " + destinationMAC;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    MessageBox.Show(result);
                }
            }
        }

        void letsGo_Click(Object sender, EventArgs e)
        {
            ScapyFrontEnd();
        }

        void runScapy_Click(Object sender, EventArgs e)
        {
            pcapFileName = pcapFileTB.Text;
            srcIP = srcIPTB.Text;
            dstIP = dstIPTB.Text;
            srcPort = srcPortTB.Text;
            dstPort = dstPortTB.Text;
            srcMAC = srcMACTB.Text;
            dstMAC = dstMACTB.Text;
            ScapySkeleton(pcapFileName, srcIP, dstIP, srcPort, dstPort, srcMAC, dstMAC);
        }

        #region Useless References
        private void pacmangif_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}