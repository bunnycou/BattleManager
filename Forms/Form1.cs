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

        private int oldIndex = 0;
        private int selIndex = 0;
        private int inputNum = 0;
        private bool keyPressed = false;
        private bool reading = false;
        private int[,] log = new int[2, 2];

        // custom functions
        private void ctrlRelease()
        {
            onRelease();
            selIndex = inputNum;
            lblDebug.Text = $"Selected {lstInitiative.Items[selIndex]}";
        }

        private void shiftRelease()
        {
            onRelease();
            modHealth(inputNum, selIndex);
            lblDebug.Text = $"Healed {lstInitiative.Items[selIndex]} for {inputNum}";
        }

        private void altRelease()
        {
            onRelease();
            modHealth(inputNum * -1, selIndex);
            lblDebug.Text = $"Damaged {lstInitiative.Items[selIndex]} for {inputNum}";
        }

        private void onRelease()
        {
            reading = false;
            numInput.Value = 0;
        }

        private void undoLog()
        {
            int amount = log[0, 0];
            int selection = log[0, 1];
            modHealth(amount * -1, selection);
            if ( amount > -1)
            {
                lblDebug.Text = $"Undid {amount} healing to {lstInitiative.Items[selection]}";
            } else
            {
                lblDebug.Text = $"Undid {amount*-1} damage to {lstInitiative.Items[selection]}";
            }
        }

        // event functions
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (keyPressed)
            {
                return;
            } else
            {
                keyPressed = true;
            }
            if (reading) // reading input
            {
                int num = keyToNum(e);
                if (num != -1)
                {
                    inputNum = (inputNum * 10) + num;
                    lblDebug.Text = inputNum.ToString();
                } else
                {
                    switch (e.Modifiers)
                    {
                        case Keys.Control: ctrlRelease(); reading = false; break;
                        case Keys.Shift: shiftRelease(); reading = false; break;
                        case Keys.Alt: e.SuppressKeyPress = true; altRelease(); reading = false; break;
                    }
                }
            } else // no active input being read
            {
                int num = keyToNum(e);
                if (num != -1)
                {
                    int niV = (int)numInput.Value;
                    if (niV >= numInput.Maximum/10)
                    {
                        numInput.Value = num;
                    } else
                    {
                        numInput.Value = (numInput.Value * 10) + num;
                    }
                } else
                {
                    switch (e.Modifiers)
                    {
                        case Keys.Control: inputNum = 0; reading = true; break;
                        case Keys.Shift: inputNum = 0; reading = true; break;
                        case Keys.Alt: e.SuppressKeyPress = true; inputNum = 0; reading = true; break;
                    }
                    switch (e.KeyCode)
                    {
                        case Keys.Back: numInput.Value = 0; break;
                        case Keys.Enter: btnChar_Click(sender, e); break;
                        case Keys.Z: undoLog(); break;
                    }
                }
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            keyPressed = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // i keep double clicking the form to access the code so this will always be here-
        }

        private void lstInitiative_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstInitiative.SelectedItem == null) return;
            oldIndex = lstInitiative.SelectedIndex;
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
            if (index < 0) index = lstInitiative.Items.Count - 1;
            if (oldIndex < 0) oldIndex = 0;
            object data = e.Data.GetData(typeof(String));
            // name
            lstInitiative.Items.Remove(data);
            lstInitiative.Items.Insert(index, data);
            //health
            object health = lstHealth.Items[oldIndex];
            lstHealth.Items.RemoveAt(oldIndex);
            lstHealth.Items.Insert(index, health);
            //ac
            object ac = lstAC.Items[oldIndex];
            lstAC.Items.RemoveAt(oldIndex);
            lstAC.Items.Insert(index, ac);
        }

        private void btnChar_Click(object sender, EventArgs e)
        {
            int niV = (int)numInput.Value;
            List<Character> chars = new List<Character>();
            for (int i = 1; i <= niV; i++)
            {
                addChar win = new addChar(i);
                win.ShowDialog();
                chars.Add(new Character() { name = win.name, init = win.init, health = win.health, AC = win.AC });
            }
            chars = chars.OrderBy(c => c.init).ToList();
            foreach (Character c in chars)
            {
                appendChar(c);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstInitiative.Items.Clear();
            lstHealth.Items.Clear();
            lstAC.Items.Clear();
        }

        private void btnDebugChars_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 3; i++)
            {
                lstInitiative.Items.Add($"char{i}");
                lstHealth.Items.Add(20 + i);
                lstAC.Items.Add(10 + i);
            }
        }


        // utility functions
        private void modHealth(int i, int index)
        {
            int health = Int32.Parse(lstHealth.Items[index].ToString());
            health += i;
            lstHealth.Items.RemoveAt(index);
            lstHealth.Items.Insert(index, health);
            appendLog(i, index);
        }

        private void appendChar(Character c)
        {
            lstInitiative.Items.Add(c.name);
            lstHealth.Items.Add(c.health);
            lstAC.Items.Add(c.AC);
        }

        private void appendLog(int amount, int selection)
        {
            // modify log array
            for (int i = 0; i < log.GetLength(0)-1; i++)
            {
                log[i + 1, 0] = log[i, 0];
                log[i + 1, 1] = log[i, 1];
            }
            log[0, 0] = amount;
            log[0, 1] = selection;

            // modify log box
            string charName = lstInitiative.Items[selection].ToString();
            string logMsg;
            if (amount > -1)
            {
                logMsg = $"Healed {charName} for {amount}";
            } else
            {
                logMsg = $"Damaged {charName} for {amount*-1}";
            }
            lstLog.Items.Add(logMsg);
        }

        private int keyToNum(KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.D1:
                case Keys.NumPad1:
                    return 1;

                case Keys.D2:
                case Keys.NumPad2:
                    return 2;

                case Keys.D3:
                case Keys.NumPad3:
                    return 3;

                case Keys.D4:
                case Keys.NumPad4:
                    return 4;

                case Keys.D5:
                case Keys.NumPad5:
                    return 5;

                case Keys.D6:
                case Keys.NumPad6:
                    return 6;

                case Keys.D7:
                case Keys.NumPad7:
                    return 7;

                case Keys.D8:
                case Keys.NumPad8:
                    return 8;

                case Keys.D9:
                case Keys.NumPad9:
                    return 9;

                case Keys.D0:
                case Keys.NumPad0:
                    return 0;
                default:
                    return -1;
            }
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
