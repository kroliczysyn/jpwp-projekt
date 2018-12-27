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
        RedBall RB = new RedBall();
        Random r = new Random();
        private int level = 0;
        private int check = 0;
        private int numer = 0;
        private int good = 0;
        private int bad = 0;
        //private int zadymka = 0;
        public Form1()
        {
            this.Size = new Size(1280, 730);
            InitializeComponent();
            SB.Click += StartButton_Click;
            Controls.Add(SB);
            poziom.KeyUp += poziom_KeyUp;
        }
        public void StartButton_Click(object sender, EventArgs e)
        {
            poziom.BackColor = Color.FromArgb(255, 255, 0, 0);
            poziom.Text = "Aktualny poziom 0";
            Controls.Add(poziom);
            SB.Visible = false;
            timer1.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int lastBall = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //zadymka++;
            /*if (zadymka < 5)
            {
                poziom.BackColor = Color.FromArgb(255, 255, 0, 0);//Maroon;
            }
            else if (zadymka < 10)
            {
                poziom.BackColor = Color.FromArgb(255, 234, 133, 9);//IndianRed;
            }
            else if (zadymka < 15)
            {
                poziom.BackColor = Color.FromArgb(255, 226, 180, 11);
            }
            else if (zadymka < 20)
            {
                poziom.BackColor = Color.FromArgb(255, 211, 234, 7);
            }
            else if (zadymka < 25)
            {
                poziom.BackColor = Color.FromArgb(255, 109, 232, 16);
            }
            else
            {
                poziom.BackColor = Color.FromArgb(255, 17, 226, 13);//Lime;
            }*/
            if (good == 15)
            {
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
                    timer1.Stop();
                    timer1.Interval = 800;//1000;
                    timer1.Start();
                    break;
                case 1:
                    poziom.BackColor = Color.FromArgb(255, 234, 133, 9);//IndianRed;
                    timer1.Stop();
                    timer1.Interval = 750;
                    timer1.Start();
                    break;
                case 2:
                    poziom.BackColor = Color.FromArgb(255, 226, 180, 11);
                    timer1.Stop();
                    timer1.Interval = 700;
                    timer1.Start();
                    break;
                case 3:
                    poziom.BackColor = Color.FromArgb(255, 211, 234, 7);
                    timer1.Stop();
                    timer1.Interval = 600;
                    timer1.Start();
                    break;
                case 4:
                    poziom.BackColor = Color.FromArgb(255, 109, 232, 16);
                    timer1.Stop();
                    timer1.Interval = 500;
                    timer1.Start();
                    break;
                case 5:
                    poziom.BackColor = Color.FromArgb(255, 17, 226, 13);//Lime;
                    timer1.Stop();
                    timer1.Interval = 500;
                    timer1.Start();
                    break;
            }
            poziom.Text = "Aktualny poziom: " + level;
            check = 0;
            int x, y = 0;
            x = r.Next(0, 1100);
            y = r.Next(0, 400);
            numer = r.Next(0, 2);
            switch (lastBall)
            {
                case 0:
                    this.Controls.Remove(RB);
                    break;
                case 1:
                    this.Controls.Remove(BB);
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
            }
        }
    }
}
