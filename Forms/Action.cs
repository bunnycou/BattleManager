using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleManager.Forms
{
    public partial class Action : Form
    {
        public Action(string name = "", string desc = "")
        {
            InitializeComponent();
            txtActName.Text = name;
            txtActDesc.Text = desc;
        }

        private void Action_Load(object sender, EventArgs e)
        {

        }

        private void OnEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.BtnDone_Click(sender, e);
            }
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
