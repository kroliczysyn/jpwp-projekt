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
        private int numer = 0;
        private int good = 0;
        private int bad = 0;
        public Form1()
        {
            InitializeComponent();
            SB.Click += StartButton_Click;
            Controls.Add(SB);
        }
        public void StartButton_Click(object sender, EventArgs e)
        {
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
            poziom.KeyUp += poziom_KeyUp;
            int x, y = 0;
            x = r.Next(0, 300);
            y = r.Next(0, 300);
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
            if(numer == 0)
            {
                if(e.KeyCode == Keys.A)
                {
                    good++;
                    poziom.Text = "Obecny wynik: " + good;
                }
            }
        }
    }
}
