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
        StartButton SB = new StartButton();
        BlueBall BB = new BlueBall();
        RedBall RB = new RedBall();
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            SB.Click += StartButton_Click;
            Controls.Add(SB);
        }
        public void StartButton_Click(object sender, EventArgs e)
        {
            SB.Visible = false;
            timer1.Enabled = true;
        }
            private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int lastBall = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y, numer = 0;
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
    }
}
