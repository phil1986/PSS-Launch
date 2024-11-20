namespace PSS_Launch
{
    partial class frmSettings
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
            btnSave = new Button();
            txtDomain = new TextBox();
            txtFileName = new TextBox();
            lblDomain = new Label();
            lblFileName = new Label();
            btnClose = new Button();
            txtWindowTitle = new TextBox();
            lblTitle = new Label();
            lblVersion = new Label();
            chkExitAfterLaunch = new CheckBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(178, 222);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 34);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtDomain
            // 
            txtDomain.Location = new Point(28, 89);
            txtDomain.Name = "txtDomain";
            txtDomain.Size = new Size(338, 23);
            txtDomain.TabIndex = 1;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(28, 147);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(338, 23);
            txtFileName.TabIndex = 2;
            // 
            // lblDomain
            // 
            lblDomain.AutoSize = true;
            lblDomain.Location = new Point(12, 71);
            lblDomain.Name = "lblDomain";
            lblDomain.Size = new Size(131, 15);
            lblDomain.TabIndex = 3;
            lblDomain.Text = "URL to FileMaker Server";
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(12, 129);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(116, 15);
            lblFileName.TabIndex = 3;
            lblFileName.Text = "Filename of Solution";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(277, 222);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(89, 34);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtWindowTitle
            // 
            txtWindowTitle.Location = new Point(28, 31);
            txtWindowTitle.Name = "txtWindowTitle";
            txtWindowTitle.Size = new Size(338, 23);
            txtWindowTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(118, 15);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Launch Window Title";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(12, 232);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(45, 15);
            lblVersion.TabIndex = 3;
            lblVersion.Text = "Version";
            // 
            // chkExitAfterLaunch
            // 
            chkExitAfterLaunch.AutoSize = true;
            chkExitAfterLaunch.Location = new Point(28, 188);
            chkExitAfterLaunch.Name = "chkExitAfterLaunch";
            chkExitAfterLaunch.Size = new Size(156, 19);
            chkExitAfterLaunch.TabIndex = 4;
            chkExitAfterLaunch.Text = "Close the launcher after?";
            chkExitAfterLaunch.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 265);
            Controls.Add(chkExitAfterLaunch);
            Controls.Add(lblVersion);
            Controls.Add(lblFileName);
            Controls.Add(lblTitle);
            Controls.Add(lblDomain);
            Controls.Add(txtFileName);
            Controls.Add(txtWindowTitle);
            Controls.Add(txtDomain);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSettings";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Launch Settings";
            TopMost = true;
            Load += frmSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtDomain;
        private TextBox txtFileName;
        private Label lblDomain;
        private Label lblFileName;
        private Button btnClose;
        private TextBox txtWindowTitle;
        private Label lblTitle;
        private Label lblVersion;
        private CheckBox chkExitAfterLaunch;
    }
}