using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Orient_
{
    class RedBall:Button
    {
        public RedBall() : base()
        {
            //this.ForeColor = Color.BurlyWood;
            this.Location = new Point(200, 200);
            this.Visible = true;
            this.Size = new Size(175, 175);
            //this.Text = "Start";
            this.BackColor = Color.Transparent;
            this.FlatStyle = FlatStyle.Popup;
            this.BackgroundImage = Image.FromFile(@"C:\studia\semestr 5\jpwp projekt\jpwp-projekt\Orient\Orient\Resources\czerwony.png");
        }
    }
}
