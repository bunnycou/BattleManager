using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleManager.Forms
{
    public partial class addParty : Form
    {
        public addParty()
        {
            InitializeComponent();
        }

        public Dictionary<string, Character> members = new();

        private void addParty_Load(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= numCount.Value; i++)
            {
                addChar win = new(i);
                win.numInit.Enabled = false;
                win.txtName.Text = $"Party {i}";
                win.ShowDialog();
                members.Add(win.character.name, win.character);
            }
            Utility.writePartyFile(txtPartyName.Text, members);
            Close();
        }
    }
}
