using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace BattleManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
        }

        private int selIndex = 2;
        private int[,] log = new int[100, 2];

        // custom functions
        private void ctrlRelease()
        {
            selIndex = (int)numInput.Value+1;
            if (selIndex >= lstInitiative.Items.Count) selIndex = lstInitiative.Items.Count - 1;
            if (selIndex < 2) selIndex = 2;
            lblDebug.Text = $"Selected {getNameFromInitList(selIndex)}";
            numInput.Value = 0;
        }

        private void undoLog()
        {
            if (lstLog.Items.Count == 0) return;
            int amount = log[0, 0];
            int selection = log[0, 1];
            modHealth(amount * -1, selection);
            if (amount > -1)
            {
                lblDebug.Text = $"Undid {amount} healing to {getNameFromInitList(selection)}";
            }
            else
            {
                lblDebug.Text = $"Undid {amount * -1} damage to {getNameFromInitList(selection)}";
            }
            // handle reverting the log array and log list
            lstLog.Items.RemoveAt(0);
            for (int i = 0; i < log.GetLength(0) - 1; i++)
            {
                log[i, 0] = log[i + 1, 0];
                log[i, 1] = log[i + 1, 1];
            }
        }

        // event functions
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // restructure to make pressing the button perform the action with the number in the input box
            int num = keyToNum(e);
            if (num == -1)
            {
                switch (e.Modifiers)
                {
                    case Keys.Control: ctrlRelease(); break;
                    case Keys.Shift: btnHeal_Click(sender, e); break;
                    case Keys.Alt: btnDamage_Click(sender, e); e.SuppressKeyPress = true; break;
                }
                switch (e.KeyCode)
                {
                    case Keys.Back: numInput.Value = 0; break;
                    // case Keys.Enter: btnChar_Click(sender, e); break; // might be annoying to include
                    case Keys.Z: undoLog(); break;
                }
            }
            else
            {
                numInput.Value = (numInput.Value * 10) + num;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // nothing yet
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstInitiative.Items.Add("| Name                     | HP  | AC |");
            lstInitiative.Items.Add("---------------------------------------");

            // check if folders for json exist, create if not, read if they do
            //TODO
        }


        // drag and drop reorder
        private void lstInitiative_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstInitiative.SelectedItem == null) return;
            selIndex = lstInitiative.SelectedIndex;
            if (selIndex < 2) return;
            lstInitiative.DoDragDrop(lstInitiative.SelectedItem, DragDropEffects.Move);
        }

        private void lstInitiative_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lstInitiative_DragDrop(object sender, DragEventArgs e)
        {
            Point point = lstInitiative.PointToClient(new Point(e.X, e.Y));
            int index = lstInitiative.IndexFromPoint(point);
            if (index == -1) index = lstInitiative.Items.Count - 1;
            if (index < 2) index = 2;
            object data = e.Data.GetData(typeof(String));
            // name
            lstInitiative.Items.Remove(data);
            lstInitiative.Items.Insert(index, data);
        }
        // end drag and drop reorder

        private void btnChar_Click(object sender, EventArgs e)
        {
            int niV = (int)numInput.Value;
            List<Character> chars = new();
            for (int i = 1; i <= niV; i++)
            {
                addChar win = new(i);
                win.ShowDialog();
                chars.Add(new Character() { name = win.name, init = win.init, health = win.health, AC = win.AC });
            }
            chars = chars.OrderBy(c => c.init).ToList();
            foreach (Character c in chars)
            {
                appendChar(c);
            }
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            int num = (int)numInput.Value;
            modHealth(num, selIndex);
            appendLog(num, selIndex);
            lblDebug.Text = $"Healed {getNameFromInitList(selIndex)} for {num}";
        }

        private void btnDamage_Click(object sender, EventArgs e)
        {
            int num = (int)numInput.Value * -1;
            modHealth(num, selIndex);
            appendLog(num, selIndex);
            lblDebug.Text = $"Damaged {getNameFromInitList(selIndex)} for {num*-1}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstInitiative.Items.Clear();
            lstInitiative.Items.Add("| Name                     | HP  | AC |");
            lstInitiative.Items.Add("---------------------------------------");
            lstLog.Items.Clear();
            lblDebug.Text = "Hello";
        }

        private void btnDebugChars_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 3; i++)
            {
                addToInitList($"char{i}", 20 + i, 10 + i);
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            undoLog();
        }


        // utility functions
        private void modHealth(int i, int index)
        {
            int health = getHealthFromInitList(index);
            health += i;
            addToInitList(getNameFromInitList(index), health, getACFromInitList(index), index);
            if (i > -1)
            { //healed
                lblDebug.Text = $"Healed {getNameFromInitList(index)} for {i}";
            }
            else // damaged
            {
                lblDebug.Text = $"Damaged {getNameFromInitList(index)} for {i * -1}";
            }
        }

        private void appendChar(Character c)
        {
            addToInitList(c.name, c.health, c.AC);
        }

        private void appendLog(int amount, int selection)
        {
            // modify log array
            for (int i = log.GetLength(0) - 1; i > 0; i--)
            {
                log[i, 0] = log[i - 1, 0];
                log[i, 1] = log[i - 1, 1];
            }
            log[0, 0] = amount;
            log[0, 1] = selection;

            // modify log box
            string charName = lstInitiative.Items[selection].ToString();
            string logMsg;
            if (amount > -1)
            {
                logMsg = $"Healed {charName} for {amount}";
            }
            else
            {
                logMsg = $"Damaged {charName} for {amount * -1}";
            }
            lstLog.Items.Insert(0, logMsg);
        }

        private void addToInitList(string name, int health, int ac, int index = -1)
        {
            /*
             * Formatting is 
             * | Name                     | HP  | AC | 
             * 12345678901234567890123456789012345678901234567890 (this will be a line of - )
             * | 123456789012345678901234 | 999 | 99 | Left align items
            */

            string healthTxt;

            // format everything to fit
            if (name.Length > 24)
            {
                name = $"{name[..21]}...";
            }
            else
            {
                for (int i = 0; name.Length < 24; i++)
                {
                    name += " ";
                }
            }

            if (health > 999) health = 999; // I don't think anything gets this high?

            if (health < 100)
            {
                healthTxt = health + " ";
            }
            else healthTxt = health.ToString();

            if (ac > 99) ac = 99;

            string obj = $"| {name} | {healthTxt} | {ac} |";

            if (index == -1)
            {
                lstInitiative.Items.Add(obj);
            }
            else
            {
                lstInitiative.Items.RemoveAt(index);
                lstInitiative.Items.Insert(index, obj);
            }
        }

        private string getNameFromInitList(int selection)
        {
            return lstInitiative.Items[selection].ToString().Split("|")[1].Trim();
        }

        private int getHealthFromInitList(int selection)
        {
            return int.Parse(lstInitiative.Items[selection].ToString().Split("|")[2].Trim());
        }

        private int getACFromInitList(int selection)
        {
            return int.Parse(lstInitiative.Items[selection].ToString().Split("|")[3].Trim());
        }

        private int keyToNum(KeyEventArgs e)
        {
            return e.KeyData switch
            {
                Keys.D1 or Keys.NumPad1 => 1,
                Keys.D2 or Keys.NumPad2 => 2,
                Keys.D3 or Keys.NumPad3 => 3,
                Keys.D4 or Keys.NumPad4 => 4,
                Keys.D5 or Keys.NumPad5 => 5,
                Keys.D6 or Keys.NumPad6 => 6,
                Keys.D7 or Keys.NumPad7 => 7,
                Keys.D8 or Keys.NumPad8 => 8,
                Keys.D9 or Keys.NumPad9 => 9,
                Keys.D0 or Keys.NumPad0 => 0,
                _ => -1,
            };
        }
    }
    class Character
    {
        public string name { get; set; }
        public int init { get; set; }
        public int health { get; set; }
        public int AC { get; set; }
    }
}
