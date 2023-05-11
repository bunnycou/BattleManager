using BattleManager.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BattleManager
{
    public partial class AddChar : Form
    {
        public Character character = new();
        public List<Character> duplicates = new();
        public bool duplicate = false;

        public AddChar(int num, bool creature = false)
        {
            InitializeComponent();

            txtName.Text = $"Char {num}";
            character.Creature = creature;
        }

        public AddChar(Character c)
        {
            InitializeComponent();

            txtName.Text = c.Name;
            numHealth.Value = c.Health;
            numAC.Value = c.AC;
            numInit.Value = c.Init;
            character = c;
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
            if (txtName.Text.Length > 24) character.Name = $"{txtName.Text[..21]}..."; else character.Name = txtName.Text;
            character.Health = (int)numHealth.Value;
            character.AC = (int)numAC.Value;
            character.Init = (int)numInit.Value;
            if (duplicate)
            {
                for (int i = 1; i <= numDuplicate.Value; i++)
                {
                    Character dupeChar = character.Clone();
                    if (dupeChar.Name.Length > 21) dupeChar.Name = dupeChar.Name[..^3] + "... " + i; else dupeChar.Name = dupeChar.Name + " " + i;
                    duplicates.Add(dupeChar);
                }
            }
            Close();
        }

        private void AddChar_Load(object sender, EventArgs e)
        {

        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            CharOptions charOptions = new(txtName.Text, character);
            charOptions.ShowDialog();
            character = charOptions.character;
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            Text = txtName.Text;
        }

        private void ChkDuplicate_CheckedChanged(object sender, EventArgs e)
        {
            numDuplicate.Enabled = chkDuplicate.Checked;
            duplicate = chkDuplicate.Checked;
        }
    }
}
