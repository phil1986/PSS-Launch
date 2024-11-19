namespace PSS_Launch
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            picLogo = new PictureBox();
            lblInfo = new Label();
            picBtnPSS = new PictureBox();
            lblEnter = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBtnPSS).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(59, 181, 233);
            pictureBox1.Location = new Point(-8, 390);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 30);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(70, 99, 172);
            pictureBox2.Location = new Point(204, 390);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(212, 30);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(228, 21, 21);
            pictureBox3.Location = new Point(416, 390);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(212, 30);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(620, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.DodgerBlue;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(50, 20);
            fileToolStripMenuItem.Text = "Menu";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.RightToLeft = RightToLeft.No;
            settingsToolStripMenuItem.Size = new Size(125, 22);
            settingsToolStripMenuItem.Text = "Settings...";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.RightToLeft = RightToLeft.No;
            exitToolStripMenuItem.Size = new Size(125, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(12, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(224, 57);
            picLogo.TabIndex = 4;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            picLogo.MouseEnter += picLogo_MouseEnter;
            picLogo.MouseLeave += picLogo_MouseLeave;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.FromArgb(59, 181, 233);
            lblInfo.Location = new Point(4, 393);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(97, 15);
            lblInfo.TabIndex = 5;
            lblInfo.Text = "Philip McGeehan";
            // 
            // picBtnPSS
            // 
            picBtnPSS.BackColor = Color.Transparent;
            picBtnPSS.BackgroundImage = (Image)resources.GetObject("picBtnPSS.BackgroundImage");
            picBtnPSS.BackgroundImageLayout = ImageLayout.Zoom;
            picBtnPSS.Cursor = Cursors.Hand;
            picBtnPSS.Location = new Point(204, 122);
            picBtnPSS.Name = "picBtnPSS";
            picBtnPSS.Size = new Size(212, 137);
            picBtnPSS.TabIndex = 6;
            picBtnPSS.TabStop = false;
            picBtnPSS.Click += picBtnPSS_Click;
            picBtnPSS.MouseEnter += picBtnPSS_MouseEnter;
            picBtnPSS.MouseLeave += picBtnPSS_MouseLeave;
            // 
            // lblEnter
            // 
            lblEnter.BackColor = Color.Transparent;
            lblEnter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnter.ForeColor = Color.White;
            lblEnter.Location = new Point(204, 259);
            lblEnter.Name = "lblEnter";
            lblEnter.Size = new Size(212, 21);
            lblEnter.TabIndex = 7;
            lblEnter.Text = "Enter";
            lblEnter.TextAlign = ContentAlignment.TopCenter;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(620, 411);
            Controls.Add(lblEnter);
            Controls.Add(picBtnPSS);
            Controls.Add(lblInfo);
            Controls.Add(picLogo);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phil McGeehan";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBtnPSS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void PicLogo_MouseEnter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private PictureBox picLogo;
        private Label lblInfo;
        private PictureBox picBtnPSS;
        private Label lblEnter;
    }
}
