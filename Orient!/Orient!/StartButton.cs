using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Orient_
{
    class StartButton : Button
    {
        Random rnd = new Random();
        public StartButton() : base()
        {
            this.ForeColor = Color.BurlyWood;
            this.Location = new Point(100, 100);
            this.Visible = true;
            this.Size = new Size(200, 50);
            this.Text = "Start";
            this.BackColor = Color.Transparent;
            this.FlatStyle = FlatStyle.Popup;
            this.Click += StartButton_Click;
        }
        void StartButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            int score = rnd.Next(0, 0);
            switch (score)
            {
                case 0:
                    RedBall b = new RedBall();
                    Controls.Add(b);
                    break;
            }
        }
    }
}
