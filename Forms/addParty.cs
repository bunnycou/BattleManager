using System;
using System.Collections.Generic;
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

        private void AddParty_Load(object sender, EventArgs e)
        {

        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= numCount.Value; i++)
            {
                addChar win = new(i);
                win.numInit.Enabled = false;
                win.txtName.Text = $"Party {i}";
                win.ShowDialog();
                members.Add(win.character.Name, win.character);
            }
            Utility.WritePartyFile(txtPartyName.Text, members);
            Close();
        }
    }
}
