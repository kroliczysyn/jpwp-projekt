using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Orient_
{
    class Time : Timer
    {
        Time(int czas) : base()
        {
            this.Interval = 5000;

        }
    }
}
