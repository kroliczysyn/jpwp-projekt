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
            this.AutoSize = false;
            this.Size = new Size(300, 40);
            this.Location = new Point(10, 650);
            this.Visible = true;
            this.ReadOnly = true;
            /*
            this.BackColor = Color.Maroon;                       //e+ rating
            this.BackColor = Color.IndianRed;                    //e rating
            this.BackColor = Color.FromArgb(255, 236, 107, 45);  //d rating
            this.BackColor = Color.FromArgb(255, 248, 242, 31);  //c rating
            this.BackColor = Color.FromArgb(255, 139, 253, 26);  //b rating
            this.BackColor = Color.Maroon;                       //a rating
            */
            
        }
    }
}
