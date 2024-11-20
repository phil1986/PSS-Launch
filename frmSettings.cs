using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace PSS_Launch
{
    public partial class frmSettings : Form
    {
        private frmMain mainForm;
        public frmSettings(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            //var appVersion = Assembly.GetExecutingAssembly().GetName().Version;
            Version appVersion = Assembly.GetExecutingAssembly().GetName().Version;
            // Load settings into text boxes
            txtDomain.Text = Settings1.Default.URL;
            txtFileName.Text = Settings1.Default.PSS;
            txtWindowTitle.Text = Settings1.Default.WindowName;
            chkExitAfterLaunch.Checked = Settings1.Default.exitAfterLaunch;
            lblVersion.Text = $"v: {appVersion.Major}.{appVersion.Minor}.{appVersion.Build}.{appVersion.Revision}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Update settings from the user inputs
            Settings1.Default.WindowName = txtWindowTitle.Text;
            Settings1.Default.URL = txtDomain.Text;
            Settings1.Default.PSS = txtFileName.Text;
            Settings1.Default.exitAfterLaunch = chkExitAfterLaunch.Checked;

            // Save the settings to persist them
            Settings1.Default.Save();
            // Update the main form's title dynamically
            mainForm.Text = txtWindowTitle.Text;

            MessageBox.Show("Settings saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the settings form
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
