using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Orient_
{
    class StartButton : Button   //def przycisku
    {
        public StartButton() : base()
        {
            this.Location = new Point(540, 190);
            this.Visible = true;
            this.Size = new Size(200, 50);
            this.Text = "Start";
            this.BackColor = Color.Transparent;
            this.FlatStyle = FlatStyle.Popup;
            this.Font = new Font("Castellar", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = Color.WhiteSmoke;
        }
    }
}
