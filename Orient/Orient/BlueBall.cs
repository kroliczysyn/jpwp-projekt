﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Orient_
{
    class BlueBall : PictureBox                     //definicja wygladu obiektu
    {
        public BlueBall() : base()
        {
            this.Location = new Point(200, 200);
            this.Visible = true;
            this.Size = new Size(175, 175);
            this.BackColor = Color.Transparent;
            var bmp = new Bitmap(Orient_.Properties.Resources.niebieski);
            this.Image = bmp; 
        }
    }
}
