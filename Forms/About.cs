using BattleManager.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BattleManager.Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Resources.version;
        }

        private void LnkGitRepo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/bunnycou/battlemanager") { UseShellExecute = true });
        }
    }
}
