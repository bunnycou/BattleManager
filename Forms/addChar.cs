using BattleManager.Forms;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Transactions;
using System.Windows.Forms;

namespace BattleManager
{
    public partial class addChar : Form
    {
        public Character character = new();
        public List<Character> duplicates = new();
        public bool duplicate = false;
        public addChar(int num)
        {
            InitializeComponent();

            txtName.Text = $"Char {num}";
        }

        public addChar(int num, Character c)
        {
            InitializeComponent();

            txtName.Text = $"{c.name} {num}";
            numHealth.Value = c.health;
            numAC.Value = c.AC;
            numInit.Value = c.init;
            character = c;
        }

        public addChar(Character c)
        {
            InitializeComponent();

            txtName.Text = c.name;
            numHealth.Value = c.health;
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
            if (duplicate)
            {
                for (int i = 1; i <= numDuplicate.Value; i++)
                {
                    Character dupeChar = character.Clone();
                    if (dupeChar.name.Length > 21) dupeChar.name = dupeChar.name[..^3] + "... " + i; else dupeChar.name = dupeChar.name + " " + i;
                    duplicates.Add(dupeChar);
                }
            }
            Close();
        }

        private void addChar_Load(object sender, EventArgs e)
        {

        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            CharOptions charOptions = new(txtName.Text, character);
            charOptions.ShowDialog();
            character = charOptions.character;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Text = txtName.Text;
        }

        private void chkDuplicate_CheckedChanged(object sender, EventArgs e)
        {
            numDuplicate.Enabled = chkDuplicate.Checked;
            duplicate = chkDuplicate.Checked;
        }
    }
}
