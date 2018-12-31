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
    class CurrentLevel : TextBox //Label
    {
        public CurrentLevel() : base()
        {
            this.AutoSize = false;
            this.Size = new Size(300, 40);
            this.Location = new Point(10, 650);
            this.Visible = true;
            this.ReadOnly = true;
            this.Font = new Font("Castellar", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = Color.WhiteSmoke;
        }
    }
}
