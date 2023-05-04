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
    public partial class CharOptions : Form
    {
        public CharOptions(string Name, Character C)
        {
            InitializeComponent();
            Text = Name;
            character = C;
        }

        public Character character;

        private void CharOptions_Load(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
