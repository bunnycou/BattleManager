using BattleManager.Forms;
using System;
using System.Windows.Forms;

namespace BattleManager
{
    public partial class addChar : Form
    {
        public Character character = new();
        public addChar(int num)
        {
            InitializeComponent();

            Text = $"Character {num}";
            txtName.Text = $"Char {num}";
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
            character.savingThrows = charOptions.character.savingThrows;
            character.resistances = charOptions.character.resistances;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Text = txtName.Text;
        }
    }
}
