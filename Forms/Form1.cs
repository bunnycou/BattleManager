using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyDown += Form1_KeyDown;
        }

        private int oldIndex = 0;
        private int selIndex = 0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                selIndex = keyToNum(e) - 1;
                if (selIndex < 0) selIndex = 0;
                lblDebug.Text = selIndex.ToString();

            } else if (e.Modifiers == Keys.Shift) // increase Health
            {
                int health = Int32.Parse(lstHealth.Items[selIndex].ToString());
                health += keyToNum(e);
                lstHealth.Items.RemoveAt(selIndex);
                lstHealth.Items.Insert(selIndex, health);

            } else if (e.Modifiers == Keys.Alt) // decrease Health
            {
                int health = Int32.Parse(lstHealth.Items[selIndex].ToString());
                health -= keyToNum(e);
                lstHealth.Items.RemoveAt(selIndex);
                lstHealth.Items.Insert(selIndex, health);
            }
        }

        private int keyToNum(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    return 1;

                case Keys.D2:
                    return 2;
                    
                case Keys.D3:
                    return 3;
                    
                case Keys.D4:
                    return 4;
                    
                case Keys.D5:
                    return 5;
                    
                case Keys.D6:
                    return 6;
                    
                case Keys.D7:
                    return 7;
                    
                case Keys.D8:
                    return 8;
                    
                case Keys.D9:
                    return 9;
                    
                case Keys.D0:
                    return 10;

                default:
                    return 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstInitiative_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.lstInitiative.SelectedItem == null) return;
            oldIndex = this.lstInitiative.SelectedIndex;
            lblDebug.Text = oldIndex.ToString();
            this.lstInitiative.DoDragDrop(this.lstInitiative.SelectedItem, DragDropEffects.Move);
        }

        private void lstInitiative_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lstInitiative_DragDrop(object sender, DragEventArgs e)
        {
            Point point = lstInitiative.PointToClient(new Point(e.X, e.Y));
            int index = this.lstInitiative.IndexFromPoint(point);
            if (index < 0) index = this.lstInitiative.Items.Count - 1;
            if (oldIndex < 0) oldIndex = 0;
            object data = e.Data.GetData(typeof(String));
            // name
            this.lstInitiative.Items.Remove(data);
            this.lstInitiative.Items.Insert(index, data);
            //health
            object health = this.lstHealth.Items[oldIndex];
            this.lstHealth.Items.RemoveAt(oldIndex);
            this.lstHealth.Items.Insert(index, health);
            //ac
            object ac = this.lstAC.Items[oldIndex];
            this.lstAC.Items.RemoveAt(oldIndex);
            this.lstAC.Items.Insert(index, ac);
            lblDebug.Text = index.ToString();
        }

        private void btnChar_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= this.numChar.Value; i++)
            {
                addChar win = new addChar(i);
                win.ShowDialog();
                this.lstInitiative.Items.Add(win.name);
                this.lstHealth.Items.Add(win.health);
                this.lstAC.Items.Add(win.AC);
            }
        }
    }
}
