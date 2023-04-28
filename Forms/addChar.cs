using System;
using System.Windows.Forms;

namespace BattleManager
{
    public partial class addChar : Form
    {

        public String name;
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
            this.Enabled = false;
            this.Close();
        }

        private void addChar_Load(object sender, EventArgs e)
        {

        }
    }
}
