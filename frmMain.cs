using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PSS_Launch
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            // Get the value from the settings file and set the form title
            this.Text = Settings1.Default.WindowName;

            // Ensure settings have defaults
            if (string.IsNullOrEmpty(Settings1.Default.URL))
            {
                Settings1.Default.URL = "fms.smdltd.co.uk";
                Settings1.Default.Save();
            }

            if (string.IsNullOrEmpty(Settings1.Default.PSS))
            {
                Settings1.Default.PSS = "PSS.fmp12";
                Settings1.Default.Save();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void picBtnPSS_Click(object sender, EventArgs e)
        {
            // Get domain and filename from the settings
            string domain = Settings1.Default.URL;
            string fileName = Settings1.Default.PSS;

            // Construct the full URL
            string url = $"fmp://{domain}/{fileName}";

            // Open the URL
            try
            {
                // Use Process.Start in a cross-platform compatible way
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Ensures the shell handles the URL
                };

                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open URL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void picBtnPSS_MouseEnter(object sender, EventArgs e)
        {
            string url = Settings1.Default.URL;
            string fn = Settings1.Default.PSS;
            string tooltip = $"fmp://{url}/{fn}";
            lblInfo.Text = tooltip;
            lblEnter.Font = new Font(this.lblEnter.Font, this.lblEnter.Font.Style | FontStyle.Underline);
        }
        private void picBtnPSS_MouseLeave(object sender, EventArgs e)
        {
            //debug
            lblInfo.Text = null;
            lblEnter.Font = new Font(this.lblEnter.Font, this.lblEnter.Font.Style & ~FontStyle.Underline);
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            string url = "http://psslimited.co.uk/";

            try
            {
                // Use Process.Start in a cross-platform compatible way
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Ensures the shell handles the URL
                };

                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open URL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picLogo_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "https://psslimited.co.uk/";
        }
        private void picLogo_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Text = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the settings form and pass the reference to frmMain
            frmSettings settingsForm = new frmSettings(this);
            settingsForm.ShowDialog();
        }
    }
}
