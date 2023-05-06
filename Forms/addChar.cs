using BattleManager.Forms;
using System;
using System.Transactions;
using System.Windows.Forms;

namespace BattleManager
{
    public partial class addChar : Form
    {
        public Character character = new();
        public addChar(int num)
        {
            InitializeComponent();

            txtName.Text = $"Char {num}";
        }

        public addChar(int num, Character c)
        {
            InitializeComponent();

            txtName.Text = $"{c.name} {num}";
            numAC.Value = c.AC;
            numInit.Value = c.init;
            character = c;
        }

        public addChar(Character c)
        {
            InitializeComponent();

            txtName.Text = c.name;
            numAC.Value = c.AC;
            numInit.Value = c.init;
            character = c;
        }

        private void onEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.btnDone_Click(sender, e);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 24) character.name = $"{txtName.Text[..21]}..."; else character.name = txtName.Text;
            character.health = (int)numHealth.Value;
            character.AC = (int)numAC.Value;
            character.init = (int)numInit.Value;
            Close();
        }

        private void addChar_Load(object sender, EventArgs e)
        {

        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            CharOptions charOptions = new(txtName.Text, character);
            charOptions.ShowDialog();
            character.stats = charOptions.character.stats;
            character.resistances = charOptions.character.resistances;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Text = txtName.Text;
        }

        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= numDuplicate.Value; i++)
            {
                addChar win = new(i, character);
                win.ShowDialog();
            }
        }

        private void numDuplicate_ValueChanged(object sender, EventArgs e)
        {
            btnDuplicate.Text = numDuplicate.Value > 1 ? "Make Duplicates" : "Make Duplicate";
        }
    }
}
