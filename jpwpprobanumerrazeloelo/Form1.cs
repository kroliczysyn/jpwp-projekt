using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jpwpprobanumerrazeloelo
{
    public partial class Orient : Form
    {
        Button PowrotButton = new Button();
        public Orient()
        {
            InitializeComponent();
        }

        private void bWyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bInfo_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Form2 settingsForm = new Form2();

            // Show the settings form
            settingsForm.Show();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(bInfo);
            Controls.Remove(bWyjscie);
            Controls.Remove(PlayButton);
            this.Controls.Add(PowrotButton);
        }

        private void PowrotButton_Click(object sender, EventArgs e)
        {
            this.Controls.Add(bInfo);
            this.Controls.Add(bWyjscie);
            this.Controls.Add(PlayButton);
            this.Controls.Remove(PowrotButton);
        }
    }
}
