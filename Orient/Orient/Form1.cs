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
        public Form1()
        {
            InitializeComponent();
            StartButton a = new StartButton();
            //RedBall b = new RedBall();
            Controls.Add(a);
            //Controls.Add(b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
