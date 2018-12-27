using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Orient_
{
    class RedBall:PictureBox
    {
        public RedBall() : base()
        {
            this.BackColor = Color.Transparent;
            this.BackgroundImageLayout = ImageLayout.Tile;
            this.Location = new Point(200, 200);
            this.Visible = true;
            this.Size = new Size(175, 175);
            this.TabStop = false;
            var bmp = new Bitmap(Orient_.Properties.Resources.czerwony);
            this.Image = bmp;
            //this.Image = Image.FromFile(@"C:\studia\semestr 5\jpwp projekt\jpwp-projekt\Orient\Orient\Resources\czerwony.png");
        }
    }
}
