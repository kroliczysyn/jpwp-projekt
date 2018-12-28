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
            poziom.KeyUp += poziom_KeyUp;
        }
        public void StartButton_Click(object sender, EventArgs e)
        {
            poziom.BackColor = Color.FromArgb(255, 255, 0, 0);
            poziom.Text = "Aktualny poziom E+";
            Controls.Add(poziom);
            SB.Visible = false;
            timer1.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (good == 15)
            {
                good = 0;
                if (level == 5)
                {
                    level = 5;
                }
                else
                {
                    level++;
                }
            }
            switch(level)
            {
                case 0:
                    poziom.BackColor = Color.FromArgb(255, 255, 0, 0);//Maroon;
                    poziom.Text = "Aktualny poziom E+";
                    timer1.Stop();
                    timer1.Interval = 800;//1000;
                    timer1.Start();
                    break;
                case 1:
                    poziom.BackColor = Color.FromArgb(255, 234, 133, 9);//IndianRed;
                    poziom.Text = "Aktualny poziom E";
                    timer1.Stop();
                    timer1.Interval = 750;
                    timer1.Start();
                    break;
                case 2:
                    poziom.BackColor = Color.FromArgb(255, 226, 180, 11);
                    poziom.Text = "Aktualny poziom D";
                    timer1.Stop();
                    timer1.Interval = 700;
                    timer1.Start();
                    break;
                case 3:
                    poziom.BackColor = Color.FromArgb(255, 211, 234, 7);
                    poziom.Text = "Aktualny poziom C";
                    timer1.Stop();
                    timer1.Interval = 600;
                    timer1.Start();
                    break;
                case 4:
                    poziom.BackColor = Color.FromArgb(255, 109, 232, 16);
                    poziom.Text = "Aktualny poziom B";
                    timer1.Stop();
                    timer1.Interval = 500;
                    timer1.Start();
                    break;
                case 5:
                    poziom.BackColor = Color.FromArgb(255, 17, 226, 13);//Lime;
                    poziom.Text = "Aktualny poziom A";
                    timer1.Stop();
                    timer1.Interval = 450;
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
        }
        private void poziom_KeyUp(object sender, KeyEventArgs e)
        {
            if(check == 0)
            {
                if (numer == 0)
                {
                    if (e.KeyCode == Keys.A)
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
                    if (e.KeyCode == Keys.S)
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
                    if (e.KeyCode == Keys.W)
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
                    if (e.KeyCode == Keys.D)
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
            }
        }
    }
}
