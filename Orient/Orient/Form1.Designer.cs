namespace Orient_
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CGButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.CofButton = new System.Windows.Forms.Button();
            this.PBTabelka = new System.Windows.Forms.PictureBox();
            this.CGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBTabelka)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CGButton
            // 
            this.CGButton.BackColor = System.Drawing.Color.Transparent;
            this.CGButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CGButton.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CGButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CGButton.Location = new System.Drawing.Point(540, 290);
            this.CGButton.Name = "CGButton";
            this.CGButton.Size = new System.Drawing.Size(200, 50);
            this.CGButton.TabIndex = 0;
            this.CGButton.Text = "Cel Gry";
            this.CGButton.UseVisualStyleBackColor = false;
            this.CGButton.Click += new System.EventHandler(this.CGButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.Color.Transparent;
            this.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InfoButton.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InfoButton.Location = new System.Drawing.Point(540, 390);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(200, 50);
            this.InfoButton.TabIndex = 1;
            this.InfoButton.Text = "Instrukcja";
            this.InfoButton.UseVisualStyleBackColor = false;
            // 
            // CofButton
            // 
            this.CofButton.BackColor = System.Drawing.Color.Transparent;
            this.CofButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CofButton.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CofButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CofButton.Location = new System.Drawing.Point(1070, 640);
            this.CofButton.Name = "CofButton";
            this.CofButton.Size = new System.Drawing.Size(200, 50);
            this.CofButton.TabIndex = 2;
            this.CofButton.Text = "Cofnij";
            this.CofButton.UseVisualStyleBackColor = false;
            this.CofButton.Click += new System.EventHandler(this.CofButton_Click);
            // 
            // PBTabelka
            // 
            this.PBTabelka.Image = global::Orient_.Properties.Resources.tabelka;
            this.PBTabelka.Location = new System.Drawing.Point(255, 12);
            this.PBTabelka.Name = "PBTabelka";
            this.PBTabelka.Size = new System.Drawing.Size(759, 284);
            this.PBTabelka.TabIndex = 3;
            this.PBTabelka.TabStop = false;
            this.PBTabelka.Visible = false;
            // 
            // CGLabel
            // 
            this.CGLabel.BackColor = System.Drawing.Color.Transparent;
            this.CGLabel.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CGLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CGLabel.Location = new System.Drawing.Point(253, 290);
            this.CGLabel.Name = "CGLabel";
            this.CGLabel.Size = new System.Drawing.Size(761, 187);
            this.CGLabel.TabIndex = 4;
            this.CGLabel.Text = resources.GetString("CGLabel.Text");
            this.CGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CGLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Orient_.Properties.Resources.tło_jpwp1280x768;
            this.ClientSize = new System.Drawing.Size(1264, 692);
            this.Controls.Add(this.CGLabel);
            this.Controls.Add(this.PBTabelka);
            this.Controls.Add(this.CofButton);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.CGButton);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1280, 768);
            this.Name = "Form1";
            this.Text = "Orient!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBTabelka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button CGButton;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button CofButton;
        private System.Windows.Forms.PictureBox PBTabelka;
        private System.Windows.Forms.Label CGLabel;
    }
}

