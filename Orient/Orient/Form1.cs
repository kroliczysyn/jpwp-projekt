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
        RedBall RB = new RedBall();
        public Form1()
        {
            InitializeComponent();
            SB.Click += StartButton_Click;
            Controls.Add(SB);
        }
        public void StartButton_Click(object sender, EventArgs e)
        {
            SB.Visible = false;
            RB.Location = new Point(300, 300);
            this.Controls.Add(RB);
        }
            private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
