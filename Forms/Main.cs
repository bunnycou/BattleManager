using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using BattleManager.Forms;
using System.IO;
using System.Reflection;
using System.ComponentModel;

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
            if (selIndex >= lstInitiative.Items.Count) selIndex = lstInitiative.Items.Count - 1;
            if (selIndex < 2) selIndex = 2;
            lblDebug.Text = $"Selected {getNameFromInitList(selIndex)}";
            numInput.Value = 0;
            loadCharacterDisplay();
        }

        private void loadCharacterDisplay()
        {
            // get char
            Character c = getCharFromInitList(selIndex);
            // set base
            gpCharacter.Text = c.name;
            lblHealth.Text = c.health.ToString();
            lblAC.Text = c.AC.ToString();
            lblInit.Text = c.init.ToString();
            //set dc
            lblStrVal.Text = c.savingThrows[Character.Stat.Str][0] >= 0 ? $"+{c.savingThrows[Character.Stat.Str][0]}" : c.savingThrows[Character.Stat.Str][0].ToString();
            lblDexVal.Text = c.savingThrows[Character.Stat.Dex][0] >= 0 ? $"+{c.savingThrows[Character.Stat.Dex][0]}" : c.savingThrows[Character.Stat.Dex][0].ToString();
            lblConVal.Text = c.savingThrows[Character.Stat.Con][0] >= 0 ? $"+{c.savingThrows[Character.Stat.Con][0]}" : c.savingThrows[Character.Stat.Con][0].ToString();
            lblIntVal.Text = c.savingThrows[Character.Stat.Int][0] >= 0 ? $"+{c.savingThrows[Character.Stat.Int][0]}" : c.savingThrows[Character.Stat.Int][0].ToString();
            lblWisVal.Text = c.savingThrows[Character.Stat.Wis][0] >= 0 ? $"+{c.savingThrows[Character.Stat.Wis][0]}" : c.savingThrows[Character.Stat.Wis][0].ToString();
            lblChaVal.Text = c.savingThrows[Character.Stat.Cha][0] >= 0 ? $"+{c.savingThrows[Character.Stat.Cha][0]}" : c.savingThrows[Character.Stat.Cha][0].ToString();
            // dc adv
            cbStrAdv.Checked = c.savingThrows[Character.Stat.Str][1] == 1 ? true : false;
            cbDexAdv.Checked = c.savingThrows[Character.Stat.Dex][1] == 1 ? true : false;
            cbConAdv.Checked = c.savingThrows[Character.Stat.Con][1] == 1 ? true : false;
            cbIntAdv.Checked = c.savingThrows[Character.Stat.Int][1] == 1 ? true : false;
            cbWisAdv.Checked = c.savingThrows[Character.Stat.Wis][1] == 1 ? true : false;
            cbChaAdv.Checked = c.savingThrows[Character.Stat.Cha][1] == 1 ? true : false;
            //set res
            List<Character.DmgType> resistant = new();
            List<Character.DmgType> vulnerable = new();
            List<Character.DmgType> immune = new();

            foreach (Character.DmgType type in c.resistances.Keys)
            {
                switch (c.resistances[type])
                {
                    case Character.ResType.Resistant: resistant.Add(type); break;
                    case Character.ResType.Vulnerable: vulnerable.Add(type); break;
                    case Character.ResType.Immune: immune.Add(type); break;
                }
            }
            lblResistances.Text = string.Join(", ", resistant);
            lblVulnerabilities.Text = string.Join(", ", vulnerable);
            lblImmunities.Text = string.Join(", ", immune);
            if (lblResistances.Text == "") lblResistances.Text = "None";
            if (lblVulnerabilities.Text == "") lblVulnerabilities.Text = "None";
            if (lblImmunities.Text == "") lblImmunities.Text = "None";
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

        private void modHealth(int i, int index)
        {
            if (i == 0) return;
            Character character = charDict[getNameFromInitList(index)];
            character.health += i;
            loadInitiative();
            if (i > -1)
            { //healed
                lblDebug.Text = $"Healed {getNameFromInitList(index)} for {i}";
            }
            else // damaged
            {
                lblDebug.Text = $"Damaged {getNameFromInitList(index)} for {i * -1}";
            }
            loadCharacterDisplay();
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

        private void loadInitiative()
        {
            clearInit();
            foreach (Character c in charDict.Values.OrderByDescending(c => c.init))
            {
                lstInitiative.Items.Add(charToString(c));
            }
        }

        private void updateInitiative(Character c)
        {
            int upIndex = selIndex - 1;
            int downIndex = selIndex + 1;
            int init;

            if (upIndex < 2) init = getCharFromInitList(downIndex).init+1;
            else if (downIndex > lstInitiative.Items.Count - 1) init = getCharFromInitList(upIndex).init-1;
            else
            {
                int upInit = getCharFromInitList(upIndex).init;
                int downInit = getCharFromInitList(downIndex).init;
                if (upInit == downInit) init = upInit;
                else init = upInit - 1;
            }
            c.init = init;
        }

        private string charToString(Character c)
        {
            string health;
            string name = c.name;
            string ac = c.AC.ToString();

            for (int i = 0; name.Length < 24; i++)
            {
                name += " ";
            }

            if (c.health > 999) c.health = 999; // I don't think anything gets this high?

            if (c.health < 100) health = c.health + " ";
            else health = c.health.ToString();

            if (c.AC > 99) ac = "99";

            return $"| {name} | {health} | {ac} |";
        }

        private string getNameFromInitList(int selection)
        {
            if (selection < 2) selection = 2;
            else if (selection > lstInitiative.Items.Count - 1) selection = lstInitiative.Items.Count - 1;
            return lstInitiative.Items[selection].ToString().Split("|")[1].Trim();
        }

        private Character getCharFromInitList(int selection)
        {
            return charDict[getNameFromInitList(selection)];
        }

        private bool isValidSel()
        {
            if (selIndex >= lstInitiative.Items.Count) return false; return true;
        }

        private void addCharToDict(Character character)
        {
            if (charDict.ContainsKey(character.name)) MessageBox.Show($"{character.name} already exists! It will not be added");
            else charDict.Add(character.name, character);
        }

        private void loadParties()
        {
            cbParty.Items.Clear();
            foreach (string f in Utility.getPartyFiles())
            {
                cbParty.Items.Add(f.Split("\\")[^1][..^5]);
            }
        }

        private void loadStatblocks()
        {
            cbStatBlock.Items.Clear();
            foreach (string f in Utility.getStatFiles())
            {
                cbStatBlock.Items.Add(f.Split("\\")[^1][..^5]);
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
                    case Keys.Control: selIndex = selIndex = (int)numInput.Value + 1; numInput.Value = 0; select(); break;
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

            // Initialize folders if needed
            Utility.initializeFolders();
            loadParties();
            loadStatblocks();
        }


        // drag and drop reorder
        private void lstInitiative_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstInitiative.SelectedItem == null) return;
            selIndex = lstInitiative.SelectedIndex;
            if (selIndex < 2) return;
            select();
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
            selIndex = index;
            object data = e.Data.GetData(typeof(String));
            lstInitiative.Items.Remove(data);
            lstInitiative.Items.Insert(index, data);
            updateInitiative(getCharFromInitList(lstInitiative.Items.IndexOf(data)));
            loadCharacterDisplay();
        }
        // end drag and drop reorder


        // BUTTONS
        private void btnChar_Click(object sender, EventArgs e)
        {
            int niV = (int)numInput.Value;
            for (int i = 1; i <= niV; i++)
            {
                addChar win = new(i);
                win.ShowDialog();
                addCharToDict(win.character);
            }
            // clear initiative and redraw it for each person in the charDict
            loadInitiative();
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            if (!isValidSel()) return;
            int num = (int)numInput.Value;
            if (num == 0) return;
            modHealth(num, selIndex);
            appendLog(num, selIndex);
        }

        private void btnDamage_Click(object sender, EventArgs e)
        {
            if (!isValidSel()) return;
            int num = (int)numInput.Value * -1;
            if (num == 0) return;
            modHealth(num, selIndex);
            appendLog(num, selIndex);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            charDict.Clear();
            clearInit();
            lstLog.Items.Clear();
            for (int i = 0; i < log.GetLength(0); i++)
            {
                log[i, 0] = 0;
                log[i, 1] = 0;
            }
            lblDebug.Text = "Welcome to BattleManager!";
        }

        private void clearInit()
        {
            lstInitiative.Items.Clear();
            lstInitiative.Items.Add("| Name                     | HP  | AC |");
            lstInitiative.Items.Add("---------------------------------------");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!isValidSel()) return;
            lstInitiative.Items.RemoveAt(selIndex);
        }

        private void btnDebugChars_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                Character character = new($"char{i}", 10 + i, 20 + i, 10+i);
                addCharToDict(character);
            }
            loadInitiative();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            undoLog();
        }

        private void btnCreateParty_Click(object sender, EventArgs e)
        {
            addParty win = new();
            win.ShowDialog();
            loadParties();
        }

        private void btnDeleteParty_Click(object sender, EventArgs e)
        {
            Utility.deletePartyFile(cbParty.Text);
            cbParty.Text = "";
            loadParties();
        }

        private void btnAddParty_Click(object sender, EventArgs e)
        {
            if (Utility.getParty(cbParty.Text) == null) return;
            foreach (Character c in Utility.getParty(cbParty.Text).Values)
            {
                addChar win = new(0);
                win.txtName.Text = c.name;
                win.numAC.Value = c.AC;
                win.numHealth.Value = c.health;
                win.character = c;
                win.ShowDialog();
                charDict.Add(c.name, c);
            }
            loadInitiative();
        }

        private void btnEditParty_Click(object sender, EventArgs e)
        {
            Dictionary<string, Character> members = new();
            if (Utility.getParty(cbParty.Text) == null) return;
            foreach (Character c in Utility.getParty(cbParty.Text).Values)
            {
                addChar win = new(0);
                win.txtName.Text = c.name;
                win.numAC.Value = c.AC;
                win.numHealth.Value = c.health;
                win.character = c;
                win.ShowDialog();
                members.Add(win.character.name, win.character);
            }
            Utility.writePartyFile(cbParty.Text, members);
        }
    }
}
