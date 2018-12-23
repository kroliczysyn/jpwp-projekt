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
    class CurrentLevel : TextBox
    {
        public CurrentLevel() : base()
        {
            this.Size = new Size(50, 200);
            this.Location = new Point(500, 500);
            this.Visible = true;
        }
    }
}
