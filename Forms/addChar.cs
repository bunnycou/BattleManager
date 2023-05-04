using BattleManager.Forms;
using System;
using System.Windows.Forms;

namespace BattleManager
{
    public partial class addChar : Form
    {

        public string name;
        public int health;
        public int AC;
        public int init;

        public addChar(int num)
        {
            InitializeComponent();

            Text = $"Character {num}";
            txtName.Text = $"Char {num}";

            txtName.KeyDown += onEnter;
            numHealth.KeyDown += onEnter;
            numAC.KeyDown += onEnter;
            KeyDown += onEnter;
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
            name = txtName.Text;
            health = (int)numHealth.Value;
            AC = (int)numAC.Value;
            init = (int)numInit.Value;
            Enabled = false;
            Close();
        }

        private void addChar_Load(object sender, EventArgs e)
        {

        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Character character = new(name, init, health, AC);
            CharOptions charOptions = new(txtName.Text, character);
            charOptions.ShowDialog();

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Text = txtName.Text;
        }
    }
}
