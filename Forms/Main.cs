using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq; 

namespace BattleManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private int selIndex = 2;
        private int[,] log = new int[100, 2];
        private Dictionary<string, Character> charDict = new(); // string will be 20 char ID, Character will contain the character data // Dictionaries are not sorted!

        // custom functions
        private void select()
        {
            if (!isValidSel()) return;
            selIndex = (int)numInput.Value + 1;
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
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            // restructure to make pressing the button perform the action with the number in the input box
            int num = Utility.keyToNum(e);
            if (num == -1)
            {
                switch (e.Modifiers)
                {
                    case Keys.Control: select(); break;
                    case Keys.Shift: btnHeal_Click(sender, e); break;
                    case Keys.Alt: btnDamage_Click(sender, e); e.SuppressKeyPress = true; break;
                }
                switch (e.KeyCode)
                {
                    case Keys.Back: numInput.Value = 0; break;
                    // case Keys.Enter: btnChar_Click(sender, e); break; // might be annoying to include
                    case Keys.Z: undoLog(); break;
                    case Keys.Delete: btnDelete_Click(sender, e); break;
                }
            }
            else
            {
                if (numInput.Value > 99) numInput.Value = num; else numInput.Value = (numInput.Value * 10) + num;
            }

        }

        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            // nothing yet
        }

        private void Main_Load(object sender, EventArgs e)
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


        // BUTTONS
        private void btnChar_Click(object sender, EventArgs e)
        {
            int niV = (int)numInput.Value;
            List<Character> chars = new();
            for (int i = 1; i <= niV; i++)
            {
                addChar win = new(i);
                win.ShowDialog();
                if (win.character.name.Length > 24) win.character.name = $"{win.character.name[..21]}...";
                if (charDict.ContainsKey(win.character.name)) {
                    MessageBox.Show($"{win.character.name} already exists! It will not be added");
                } else
                {
                    chars.Add(win.character);
                    charDict.Add(win.character.name, win.character);
                }
            }
            foreach (Character c in chars.OrderBy(c => c.init).ToList())
            {
                addToInitList(c);
            }
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            if (!isValidSel()) return;
            int num = (int)numInput.Value;
            modHealth(num, selIndex);
            appendLog(num, selIndex);
            lblDebug.Text = $"Healed {getNameFromInitList(selIndex)} for {num}";
        }

        private void btnDamage_Click(object sender, EventArgs e)
        {
            if (!isValidSel()) return;
            int num = (int)numInput.Value * -1;
            modHealth(num, selIndex);
            appendLog(num, selIndex);
            lblDebug.Text = $"Damaged {getNameFromInitList(selIndex)} for {num * -1}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstInitiative.Items.Clear();
            lstInitiative.Items.Add("| Name                     | HP  | AC |");
            lstInitiative.Items.Add("---------------------------------------");
            lstLog.Items.Clear();
            for (int i = 0; i < log.GetLength(0); i++)
            {
                log[i, 0] = 0;
                log[i, 1] = 0;
            }
            lblDebug.Text = "Hello";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!isValidSel()) return;
            lstInitiative.Items.RemoveAt(selIndex);
        }

        private void btnDebugChars_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 3; i++)
            {
                Character character = new($"char{i}", 20 + i, 10 + i);
                addToInitList(character);
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
            Character character = new(getNameFromInitList(index), health, getACFromInitList(index));
            addToInitList(character, index);
            if (i > -1)
            { //healed
                lblDebug.Text = $"Healed {getNameFromInitList(index)} for {i}";
            }
            else // damaged
            {
                lblDebug.Text = $"Damaged {getNameFromInitList(index)} for {i * -1}";
            }
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
            string charName = getNameFromInitList(selection);
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

        private void addToInitList(Character c, int index = -1)
        {
            /*
             * Formatting is 
             * | Name                     | HP  | AC | 
             * 12345678901234567890123456789012345678901234567890 (this will be a line of '-' )
             * | 123456789012345678901234 | 999 | 99 | Left align items
            */

            string healthTxt;

            // format everything to fit
            if (c.name.Length > 24) // might be obsolete now...
            {
                c.name = $"{c.name[..21]}...";
            }
            else
            {
                for (int i = 0; c.name.Length < 24; i++)
                {
                    c.name += " ";
                }
            }

            if (c.health > 999) c.health = 999; // I don't think anything gets this high?

            if (c.health < 100)
            {
                healthTxt = c.health + " ";
            }
            else healthTxt = c.health.ToString();

            if (c.AC > 99) c.AC = 99;

            string obj = $"| {c.name} | {healthTxt} | {c.AC} |";

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

        private bool isValidSel()
        {
            if (selIndex >= lstInitiative.Items.Count) return false; return true;
        }
    }
}
