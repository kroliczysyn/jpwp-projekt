﻿namespace jpwpprobanumerrazeloelo
{
    partial class Orient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orient));
            this.bWyjscie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bWyjscie
            // 
            this.bWyjscie.BackColor = System.Drawing.Color.Transparent;
            this.bWyjscie.Cursor = System.Windows.Forms.Cursors.Default;
            this.bWyjscie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bWyjscie.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bWyjscie.ForeColor = System.Drawing.SystemColors.Control;
            this.bWyjscie.Location = new System.Drawing.Point(521, 169);
            this.bWyjscie.Name = "bWyjscie";
            this.bWyjscie.Size = new System.Drawing.Size(208, 56);
            this.bWyjscie.TabIndex = 0;
            this.bWyjscie.Text = "Wyjdź z gry";
            this.bWyjscie.UseVisualStyleBackColor = false;
            this.bWyjscie.Click += new System.EventHandler(this.bWyjscie_Click);
            // 
            // Orient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.bWyjscie);
            this.MaximumSize = new System.Drawing.Size(1280, 1024);
            this.Name = "Orient";
            this.Text = "Orient!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bWyjscie;
    }
}

