using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace PluginNamer
{
    public partial class frmMain : Form
    {
        private readonly BackgroundWorker bgWorker = new BackgroundWorker();
        private readonly DatabaseEntries DatabaseEntries = new DatabaseEntries();

        public frmMain()
        {
            InitializeComponent();

            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;

            txtFolder.Text = DatabaseEntries.PluginDatabaseFolder;
        }



        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            if(dlgFolder.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = dlgFolder.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            txtFolder.Enabled = false;
            numFontSize.Enabled = false;
            btnBrowseFolder.Enabled = false;
            pbrMain.Visible = true;

            bgWorker.RunWorkerAsync();
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DatabaseEntries.Clear();
            if(!txtFolder.Text.ToLower().EndsWith("plugin database"))
            {
                throw new Exception("Selected folder does not point to a FL Studio plugin database");
            }

            DatabaseEntries.FindEntries(txtFolder.Text);

            DatabaseEntries.ProcessEntries((int)numFontSize.Value);
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbrMain.Visible = false;

            if (e.Error != null)
            {
                MessageBox.Show(this, e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnStart.Enabled = true;
            txtFolder.Enabled = true;
            numFontSize.Enabled = true;
            btnBrowseFolder.Enabled = true;
        }
    }
}
