using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Orient_
{
    public partial class Form1 : Form
    {
        CurrentLevel poziom = new CurrentLevel();
        ExitButton EB = new ExitButton();
        StartButton SB = new StartButton();
        BlueBall BB = new BlueBall();
        GreenBall GB = new GreenBall();
        RedBall RB = new RedBall();
        YellowBall YB = new YellowBall();
        Random r = new Random();
        private int level = 0;
        private int check = 0;
        private int numer = 0;
        private int good = 0;
        private int bad = 0;
        private int lastBall = 0;
        private int lastX = 0;
        private int lastY = 0;
        public Form1()
        {
            var bmp = new Bitmap(Orient_.Properties.Resources.tło_jpwp1280x768);
            this.BackgroundImage = bmp;
            this.Size = new Size(1280, 730);
            InitializeComponent();
            SB.Click += StartButton_Click;
            Controls.Add(SB);
            Controls.Add(EB);
            PBTabelka.Visible = false;
            EB.Click += ExitButton_Click;
            CofButton.Visible = false;
        }
        public void StartButton_Click(object sender, EventArgs e)
        {
            CofButton.Visible = true;
            InfoButton.Visible = false;
            CGButton.Visible = false;
            Controls.Remove(EB);
            poziom.BackColor = Color.FromArgb(255, 255, 0, 0);
            poziom.Text = "Aktualny poziom E+";
            Controls.Add(poziom);
            Controls.Remove(SB);
            timer1.Enabled = true;
        }
        public void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
                
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (good == 10)
            {
                good = 0;
                if (level == 5)
                {
                    level = 5;
                }
                else
                {
                    level++;
                    InfoLevelLabel.Text = "Poziom wyzej! Przyspieszamy!";
                    Controls.Add(InfoLevelLabel);
                    InfoLevelLabel.Visible = true;
                    InfoLevelLabel.BringToFront();
                    InfoLevelLabel.Update();
                    System.Threading.Thread.Sleep(1500);
                    Controls.Remove(InfoLevelLabel);
                }
            }
            if (bad == 5)
            {
                bad = 0;
                if (level == 0)
                {
                    level = 0;
                }
                else
                {
                    level--;
                    InfoLevelLabel.Text = "Poziom nizej! Zwalniamy!";
                    Controls.Add(InfoLevelLabel);
                    InfoLevelLabel.Visible = true;
                    InfoLevelLabel.BringToFront();
                    InfoLevelLabel.Update();
                    System.Threading.Thread.Sleep(1500);
                    Controls.Remove(InfoLevelLabel);
                }
            }
            switch (level)
            {
                case 0:
                    poziom.BackColor = Color.FromArgb(255, 255, 0, 0);
                    poziom.Text = "Aktualny poziom E+";
                    timer1.Stop();
                    timer1.Interval = 700;
                    timer1.Start();
                    break;
                case 1:
                    poziom.BackColor = Color.FromArgb(255, 234, 133, 9);
                    poziom.Text = "Aktualny poziom E";
                    timer1.Stop();
                    timer1.Interval = 600;
                    timer1.Start();
                    break;
                case 2:
                    poziom.BackColor = Color.FromArgb(255, 226, 180, 11);
                    poziom.Text = "Aktualny poziom D";
                    timer1.Stop();
                    timer1.Interval = 500;
                    timer1.Start();
                    break;
                case 3:
                    poziom.BackColor = Color.FromArgb(255, 211, 234, 7);
                    poziom.Text = "Aktualny poziom C";
                    timer1.Stop();
                    timer1.Interval = 400;
                    timer1.Start();
                    break;
                case 4:
                    poziom.BackColor = Color.FromArgb(255, 109, 232, 16);
                    poziom.Text = "Aktualny poziom B";
                    timer1.Stop();
                    timer1.Interval = 350;
                    timer1.Start();
                    break;
                case 5:
                    poziom.BackColor = Color.FromArgb(255, 17, 226, 13);
                    poziom.Text = "Aktualny poziom A";
                    timer1.Stop();
                    timer1.Interval = 300;
                    timer1.Start();
                    break;
            }
            check = 0;
            int x, y, diffX, diffY = 0;
            x = r.Next(0, 1100);
            diffX = lastX - x;
            if (Math.Abs(diffX) < 175)
            {
                x = r.Next(0, 1100);
            }
            y = r.Next(0, 400);
            diffY = lastY - y;
            if (Math.Abs(diffY) <175)
            {
                y = r.Next(0, 400);
            }
            lastY = y;
            lastX = x;
            numer = r.Next(0, 4);
            switch (lastBall)
            {
                case 0:
                    this.Controls.Remove(RB);
                    break;
                case 1:
                    this.Controls.Remove(BB);
                    break;
                case 2:
                    this.Controls.Remove(GB);
                    break;
                case 3:
                    this.Controls.Remove(YB);
                    break;
            }
            switch (numer)
            {
                case 0:
                    RB.Location = new Point(x, y);
                    this.Controls.Add(RB);
                    lastBall = 0;
                    break;
                case 1:
                    BB.Location = new Point(x, y);
                    this.Controls.Add(BB);
                    lastBall = 1;
                    break;
                case 2:
                    BB.Location = new Point(x, y);
                    this.Controls.Add(GB);
                    lastBall = 2;
                    break;
                case 3:
                    BB.Location = new Point(x, y);
                    this.Controls.Add(YB);
                    lastBall = 3;
                    break;
            }
            if (good == 1 && level == 5)
            {
                timer1.Stop();
                switch (lastBall)
                {
                    case 0:
                        this.Controls.Remove(RB);
                        break;
                    case 1:
                        this.Controls.Remove(BB);
                        break;
                    case 2:
                        this.Controls.Remove(GB);
                        break;
                    case 3:
                        this.Controls.Remove(YB);
                        break;
                }
                Controls.Remove(poziom);
                CongratsLabel.Visible = true;
            }
        }
      
        protected override bool ProcessCmdKey(ref Message msg, Keys e)
        {
            if (check == 0)
            {
                if (numer == 0)
                {
                    if (e == Keys.Q)
                    {
                        good++;
                        check = 1;
                    }
                    else
                    {
                        bad++;
                        check = 1;
                    }
                }
                else if (numer == 1)
                {
                    if (e == Keys.A)
                    {
                        good++;
                        check = 1;
                    }
                    else
                    {
                        bad++;
                        check = 1;
                    }
                }
                else if (numer == 2)
                {
                    if (e == Keys.P)
                    {
                        good++;
                        check = 1;
                    }
                    else
                    {
                        bad++;
                        check = 1;
                    }
                }
                else if (numer == 3)
                {
                    if (e == Keys.L)
                    {
                        good++;
                        check = 1;
                    }
                    else
                    {
                        bad++;
                        check = 1;
                    }
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, e);
        }
        private void CofButton_Click(object sender, EventArgs e)
        {
            EPLabel.Visible = false;
            ELabel.Visible = false;
            DLabel.Visible = false;
            CLabel.Visible = false;
            BLabel.Visible = false;
            ALabel.Visible = false;
            Controls.Remove(poziom);
            Controls.Remove(RB);
            Controls.Remove(GB);
            Controls.Remove(BB);
            Controls.Remove(YB);
            CGLabel.Visible = false;
            InfoButton.Visible = true;
            CGButton.Visible = true;
            IALabel.Visible = false;
            IQLabel.Visible = false;
            IPLabel.Visible = false;
            ILLabel.Visible = false;
            InfoLabel.Visible = false;
            PBTabelka.Visible = false;
            CofButton.Visible = false;
            CongratsLabel.Visible = false;
            Controls.Add(SB);
            Controls.Add(EB);
            timer1.Stop();
            timer1.Enabled = false;
            good = 0;
            bad = 0;
        }

        private void CGButton_Click(object sender, EventArgs e)
        {
            CGLabel.Visible = true;
            PBTabelka.Visible = true;
            Controls.Remove(SB);
            Controls.Remove(EB);
            CGButton.Visible = false;
            InfoButton.Visible = false;
            CofButton.Visible = true;
        }
        private void InfoButton_Click(object sender, EventArgs e)
        {
           
        }

        private void InfoButton_Click_1(object sender, EventArgs e)
        {
            Controls.Remove(SB);
            Controls.Remove(EB);
            CGButton.Visible = false;
            InfoButton.Visible = false;
            CofButton.Visible = true;
            IALabel.Visible = true;
            IQLabel.Visible = true;
            IPLabel.Visible = true;
            ILLabel.Visible = true;
            InfoLabel.Visible = true;
            Controls.Add(RB);
            Controls.Add(BB);
            Controls.Add(GB);
            Controls.Add(YB);
            RB.Location = new Point(50, 0);
            BB.Location = new Point(50, 175);
            GB.Location = new Point(705, 0);
            YB.Location = new Point(705, 175);
            EPLabel.Visible = true;
            ELabel.Visible = true;
            DLabel.Visible = true;
            CLabel.Visible = true;
            BLabel.Visible = true;
            ALabel.Visible = true;
        }
    }
}
