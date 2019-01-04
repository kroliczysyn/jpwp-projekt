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
            this.IQLabel = new System.Windows.Forms.Label();
            this.IALabel = new System.Windows.Forms.Label();
            this.IPLabel = new System.Windows.Forms.Label();
            this.ILLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.EPLabel = new System.Windows.Forms.Label();
            this.ELabel = new System.Windows.Forms.Label();
            this.DLabel = new System.Windows.Forms.Label();
            this.CLabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.ALabel = new System.Windows.Forms.Label();
            this.CongratsLabel = new System.Windows.Forms.Label();
            this.InfoLevelLabel = new System.Windows.Forms.Label();
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
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click_1);
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
            this.CGLabel.Location = new System.Drawing.Point(251, 290);
            this.CGLabel.Name = "CGLabel";
            this.CGLabel.Size = new System.Drawing.Size(761, 187);
            this.CGLabel.TabIndex = 4;
            this.CGLabel.Text = resources.GetString("CGLabel.Text");
            this.CGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CGLabel.Visible = false;
            // 
            // IQLabel
            // 
            this.IQLabel.BackColor = System.Drawing.Color.Transparent;
            this.IQLabel.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IQLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IQLabel.Location = new System.Drawing.Point(225, 88);
            this.IQLabel.Name = "IQLabel";
            this.IQLabel.Size = new System.Drawing.Size(350, 50);
            this.IQLabel.TabIndex = 5;
            this.IQLabel.Text = "Po pojawieniu sie tej kuli nacisnij \'Q\'";
            this.IQLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IQLabel.Visible = false;
            // 
            // IALabel
            // 
            this.IALabel.BackColor = System.Drawing.Color.Transparent;
            this.IALabel.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IALabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IALabel.Location = new System.Drawing.Point(225, 263);
            this.IALabel.Name = "IALabel";
            this.IALabel.Size = new System.Drawing.Size(350, 50);
            this.IALabel.TabIndex = 6;
            this.IALabel.Text = "Po pojawieniu sie tej kuli nacisnij \'A\'";
            this.IALabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IALabel.Visible = false;
            // 
            // IPLabel
            // 
            this.IPLabel.BackColor = System.Drawing.Color.Transparent;
            this.IPLabel.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IPLabel.Location = new System.Drawing.Point(880, 88);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(350, 50);
            this.IPLabel.TabIndex = 7;
            this.IPLabel.Text = "Po pojawieniu sie tej kuli nacisnij \'P\'";
            this.IPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IPLabel.Visible = false;
            // 
            // ILLabel
            // 
            this.ILLabel.BackColor = System.Drawing.Color.Transparent;
            this.ILLabel.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ILLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ILLabel.Location = new System.Drawing.Point(880, 263);
            this.ILLabel.Name = "ILLabel";
            this.ILLabel.Size = new System.Drawing.Size(350, 50);
            this.ILLabel.TabIndex = 8;
            this.ILLabel.Text = "Po pojawieniu sie tej kuli nacisnij \'L\'";
            this.ILLabel.Visible = false;
            // 
            // InfoLabel
            // 
            this.InfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoLabel.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InfoLabel.Location = new System.Drawing.Point(12, 350);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(1240, 60);
            this.InfoLabel.TabIndex = 9;
            this.InfoLabel.Text = resources.GetString("InfoLabel.Text");
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoLabel.Visible = false;
            // 
            // EPLabel
            // 
            this.EPLabel.BackColor = System.Drawing.Color.Transparent;
            this.EPLabel.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EPLabel.Location = new System.Drawing.Point(380, 410);
            this.EPLabel.Name = "EPLabel";
            this.EPLabel.Size = new System.Drawing.Size(520, 30);
            this.EPLabel.TabIndex = 10;
            this.EPLabel.Text = "poziom E+ (700 ms) jest niedopuszczalnym rezultatem";
            this.EPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EPLabel.Visible = false;
            // 
            // ELabel
            // 
            this.ELabel.BackColor = System.Drawing.Color.Transparent;
            this.ELabel.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ELabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ELabel.Location = new System.Drawing.Point(380, 440);
            this.ELabel.Name = "ELabel";
            this.ELabel.Size = new System.Drawing.Size(520, 30);
            this.ELabel.TabIndex = 11;
            this.ELabel.Text = "poziom E (600 ms) jest złym rezultatem";
            this.ELabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ELabel.Visible = false;
            // 
            // DLabel
            // 
            this.DLabel.BackColor = System.Drawing.Color.Transparent;
            this.DLabel.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DLabel.Location = new System.Drawing.Point(380, 470);
            this.DLabel.Name = "DLabel";
            this.DLabel.Size = new System.Drawing.Size(520, 30);
            this.DLabel.TabIndex = 12;
            this.DLabel.Text = "poziom D (500 ms) jest miernym rezultatem";
            this.DLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DLabel.Visible = false;
            // 
            // CLabel
            // 
            this.CLabel.BackColor = System.Drawing.Color.Transparent;
            this.CLabel.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CLabel.Location = new System.Drawing.Point(380, 500);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(520, 30);
            this.CLabel.TabIndex = 13;
            this.CLabel.Text = "poziom C (400 ms) jest akceptowalnym rezultatem";
            this.CLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CLabel.Visible = false;
            // 
            // BLabel
            // 
            this.BLabel.BackColor = System.Drawing.Color.Transparent;
            this.BLabel.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BLabel.Location = new System.Drawing.Point(380, 530);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(520, 30);
            this.BLabel.TabIndex = 14;
            this.BLabel.Text = "poziom B (350 ms) jest dobrym rezultatem";
            this.BLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BLabel.Visible = false;
            // 
            // ALabel
            // 
            this.ALabel.BackColor = System.Drawing.Color.Transparent;
            this.ALabel.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ALabel.Location = new System.Drawing.Point(380, 560);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(520, 30);
            this.ALabel.TabIndex = 15;
            this.ALabel.Text = "poziom A (300 ms) jest wzorowym rezultatem";
            this.ALabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ALabel.Visible = false;
            // 
            // CongratsLabel
            // 
            this.CongratsLabel.BackColor = System.Drawing.Color.Transparent;
            this.CongratsLabel.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CongratsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CongratsLabel.Location = new System.Drawing.Point(460, 400);
            this.CongratsLabel.Name = "CongratsLabel";
            this.CongratsLabel.Size = new System.Drawing.Size(360, 30);
            this.CongratsLabel.TabIndex = 16;
            this.CongratsLabel.Text = "Gratulacje, twoj refleks jest wzorowy!";
            this.CongratsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CongratsLabel.Visible = false;
            // 
            // InfoLevelLabel
            // 
            this.InfoLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoLevelLabel.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLevelLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InfoLevelLabel.Location = new System.Drawing.Point(450, 399);
            this.InfoLevelLabel.Name = "InfoLevelLabel";
            this.InfoLevelLabel.Size = new System.Drawing.Size(360, 30);
            this.InfoLevelLabel.TabIndex = 17;
            this.InfoLevelLabel.Text = "Poziom wyzej! przyspieszamy!";
            this.InfoLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoLevelLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Orient_.Properties.Resources.tło_jpwp1280x768;
            this.ClientSize = new System.Drawing.Size(1264, 692);
            this.Controls.Add(this.InfoLevelLabel);
            this.Controls.Add(this.CongratsLabel);
            this.Controls.Add(this.ALabel);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.CLabel);
            this.Controls.Add(this.DLabel);
            this.Controls.Add(this.ELabel);
            this.Controls.Add(this.EPLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.ILLabel);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this.IALabel);
            this.Controls.Add(this.IQLabel);
            this.Controls.Add(this.CGLabel);
            this.Controls.Add(this.PBTabelka);
            this.Controls.Add(this.CofButton);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.CGButton);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1280, 768);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label IQLabel;
        private System.Windows.Forms.Label IALabel;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Label ILLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label EPLabel;
        private System.Windows.Forms.Label ELabel;
        private System.Windows.Forms.Label DLabel;
        private System.Windows.Forms.Label CLabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.Label CongratsLabel;
        private System.Windows.Forms.Label InfoLevelLabel;
    }
}

