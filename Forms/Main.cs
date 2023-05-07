using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using BattleManager.Forms;

namespace BattleManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private int selIndex = 2;
        private readonly int[,] log = new int[100, 2];
        private readonly Dictionary<string, Character> charDict = new(); // string will be 20 char ID, Character will contain the character data // Dictionaries are not sorted!

        // custom functions
        private void SelectInit()
        {
            if (!IsValidSel()) return;
            if (selIndex >= lstInitiative.Items.Count) selIndex = lstInitiative.Items.Count - 1;
            if (selIndex < 2) selIndex = 2;
            lblDebug.Text = $"Selected {GetNameFromInitList(selIndex)}";
            numInput.Value = 0;
            LoadCharacterDisplay();
        }

        private void LoadCharacterDisplay()
        {
            // get char
            Character c = GetCharFromInitList(selIndex);
            // set base
            gpCharacter.Text = c.Name;
            lblHealth.Text = c.Health.ToString();
            lblAC.Text = c.AC.ToString();
            lblInit.Text = c.Init.ToString();
            lblLevel.Text = c.Level.ToString();
            //set Stats
            // update todo
            lblStrVal.Text = Utility.GetStatString(c, Character.Stat.Str);
            lblDexVal.Text = Utility.GetStatString(c, Character.Stat.Dex);
            lblConVal.Text = Utility.GetStatString(c, Character.Stat.Con);
            lblIntVal.Text = Utility.GetStatString(c, Character.Stat.Int);
            lblWisVal.Text = Utility.GetStatString(c, Character.Stat.Wis);
            lblChaVal.Text = Utility.GetStatString(c, Character.Stat.Cha);
            // dc adv   
            cbStrAdv.Checked = c.Stats[Character.Stat.Str][2] == 1;
            cbDexAdv.Checked = c.Stats[Character.Stat.Dex][2] == 1;
            cbConAdv.Checked = c.Stats[Character.Stat.Con][2] == 1;
            cbIntAdv.Checked = c.Stats[Character.Stat.Int][2] == 1;
            cbWisAdv.Checked = c.Stats[Character.Stat.Wis][2] == 1;
            cbChaAdv.Checked = c.Stats[Character.Stat.Cha][2] == 1;
            //set res
            List<Character.DmgType> resistant = new();
            List<Character.DmgType> vulnerable = new();
            List<Character.DmgType> immune = new();

            foreach (Character.DmgType type in c.Resistances.Keys)
            {
                switch (c.Resistances[type])
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

        private void UndoLog()
        {
            if (lstLog.Items.Count == 0) return;
            int amount = log[0, 0];
            int selection = log[0, 1];
            ModHealth(amount * -1, selection);
            if (amount == 0) return;
            if (amount > -1)
            {
                lblDebug.Text = $"Undid {amount} healing to {GetNameFromInitList(selection)}";
            }
            else
            {
                lblDebug.Text = $"Undid {amount * -1} damage to {GetNameFromInitList(selection)}";
            }
            // handle reverting the log array and log list
            lstLog.Items.RemoveAt(0);
            for (int i = 0; i < log.GetLength(0) - 1; i++)
            {
                log[i, 0] = log[i + 1, 0];
                log[i, 1] = log[i + 1, 1];
            }
        }

        private void ModHealth(int i, int index)
        {
            if (i == 0) return;
            Character character = charDict[GetNameFromInitList(index)];
            character.Health += i;
            LoadInitiativeReorder();
            if (i > -1)
            { //healed
                lblDebug.Text = $"Healed {GetNameFromInitList(index)} for {i}";
            }
            else // damaged
            {
                lblDebug.Text = $"Damaged {GetNameFromInitList(index)} for {i * -1}";
            }
            LoadCharacterDisplay();
        }

        private void AppendLog(int amount, int selection)
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
            string charName = GetNameFromInitList(selection);
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

        private void LoadInitiative() // new character is added, sort list by original initiative, then update everyones initiative order
        {
            ClearInit();
            foreach (Character c in charDict.Values.OrderByDescending(c => c.Init))
            {
                lstInitiative.Items.Add(Utility.CharToString(c));
            }
            UpdateInitiative();
        }

        private void LoadInitiativeReorder() // sort list by hidden initiative order number
        {
            ClearInit();
            foreach (Character c in charDict.Values.OrderBy(c => c.InitOrder))
            {
                lstInitiative.Items.Add(Utility.CharToString(c));
            }
        }

        private void UpdateInitiative()
        {
            for (int i = 2; i < lstInitiative.Items.Count; i++)
            {
                Character temp = GetCharFromInitList(i);
                temp.InitOrder = i;
                charDict.Remove(temp.Name);
                charDict.Add(temp.Name, temp);
            }
        }

        private string GetNameFromInitList(int selection)
        {
            return !IsValidSel() ? null : lstInitiative.Items[selection].ToString().Split("|")[1].Trim();
        }

        private Character GetCharFromInitList(int selection)
        {
            return charDict[GetNameFromInitList(selection)];
        }

        private bool IsValidSel()
        {
            if (selIndex >= lstInitiative.Items.Count) return false; return true;
        }

        private void AddCharToDict(Character character)
        {
            if (charDict.ContainsKey(character.Name)) MessageBox.Show($"{character.Name} already exists! It will not be added");
            else charDict.Add(character.Name, character);
        }

        private void LoadParties()
        {
            cbParty.Items.Clear();
            foreach (string f in Utility.GetPartyFiles())
            {
                cbParty.Items.Add(f.Split("\\")[^1][..^5]);
            }
        }

        private void LoadStatblocks()
        {
            cbStatBlock.Items.Clear();
            foreach (string f in Utility.GetStatFiles())
            {
                cbStatBlock.Items.Add(f.Split("\\")[^1][..^5]);
            }
        }

        private void ClearInit()
        {
            lstInitiative.Items.Clear();
            lstInitiative.Items.Add("| Name                     | HP  | AC |");
            lstInitiative.Items.Add("---------------------------------------");
        }

        // event functions
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            // restructure to make pressing the button perform the action with the number in the input box
            int num = Utility.KeyToNum(e);
            if (num == -1)
            {
                switch (e.Modifiers)
                {
                    case Keys.Control: selIndex = (int)numInput.Value + 1; numInput.Value = 0; SelectInit(); break;
                    case Keys.Shift: BtnHeal_Click(sender, e); break;
                    case Keys.Alt: BtnDamage_Click(sender, e); e.SuppressKeyPress = true; break;
                }
                switch (e.KeyCode)
                {
                    case Keys.Back: numInput.Value = 0; break;
                    // case Keys.Enter: btnChar_Click(sender, e); break; // might be annoying to include
                    case Keys.Z: UndoLog(); break;
                    case Keys.Delete: BtnDelete_Click(sender, e); break;
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
            Utility.InitializeFolders();
            LoadParties();
            LoadStatblocks();
        }


        // drag and drop reorder
        private void LstInitiative_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstInitiative.SelectedItem == null) return;
            selIndex = lstInitiative.SelectedIndex;
            if (selIndex < 2) return;
            SelectInit();
            lstInitiative.DoDragDrop(lstInitiative.SelectedItem, DragDropEffects.Move);
        }

        private void LstInitiative_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void LstInitiative_DragDrop(object sender, DragEventArgs e)
        {
            Point point = lstInitiative.PointToClient(new Point(e.X, e.Y));
            int index = lstInitiative.IndexFromPoint(point);
            if (index == -1) index = lstInitiative.Items.Count - 1;
            if (index < 2) index = 2;
            selIndex = index;
            object data = e.Data.GetData(typeof(String));
            lstInitiative.Items.Remove(data);
            lstInitiative.Items.Insert(index, data);
            UpdateInitiative();
            LoadCharacterDisplay();
        }
        // end drag and drop reorder


        // BUTTONS
        private void BtnChar_Click(object sender, EventArgs e)
        {
            int niV = (int)numInput.Value;
            for (int i = 1; i <= niV; i++)
            {
                addChar win = new(i);
                win.ShowDialog();
                if (win.duplicate)
                {
                    foreach (Character dupe in win.duplicates)
                    {
                        AddCharToDict(dupe);
                    }
                }
                else AddCharToDict(win.character);
            }
            // clear initiative and redraw it for each person in the charDict
            LoadInitiative();
        }

        private void BtnHeal_Click(object sender, EventArgs e)
        {
            if (!IsValidSel()) return;
            int num = (int)numInput.Value;
            if (num == 0) return;
            ModHealth(num, selIndex);
            AppendLog(num, selIndex);
        }

        private void BtnDamage_Click(object sender, EventArgs e)
        {
            if (!IsValidSel()) return;
            int num = (int)numInput.Value * -1;
            if (num == 0) return;
            ModHealth(num, selIndex);
            AppendLog(num, selIndex);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            charDict.Clear();
            ClearInit();
            lstLog.Items.Clear();
            for (int i = 0; i < log.GetLength(0); i++)
            {
                log[i, 0] = 0;
                log[i, 1] = 0;
            }
            lblDebug.Text = "Welcome to BattleManager!";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!IsValidSel()) return;
            charDict.Remove(GetCharFromInitList(selIndex).Name);
            lstInitiative.Items.RemoveAt(selIndex);
            for (int i = 0; i < log.GetLength(0); i++)
            {
                if (log[i, 1] == selIndex)
                {
                    log[i, 0] = 0;
                    log[i, 1] = 0;
                }
            }
        }

        private void BtnDebugChars_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 3; i++)
            {
                Character character = new(name: $"char{i}", AC: 10 + i, health: 20 + i);
                AddCharToDict(character);
            }
            LoadInitiative();
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            UndoLog();
        }

        private void BtnCreateParty_Click(object sender, EventArgs e)
        {
            addParty win = new();
            win.ShowDialog();
            LoadParties();
        }

        private void BtnDeleteParty_Click(object sender, EventArgs e)
        {
            Utility.DeletePartyFile(cbParty.Text);
            cbParty.Text = "";
            LoadParties();
        }

        private void BtnAddParty_Click(object sender, EventArgs e)
        {
            if (Utility.GetParty(cbParty.Text) == null) return;
            foreach (Character c in Utility.GetParty(cbParty.Text).Values)
            {
                addChar win = new(c);
                win.ShowDialog();
                AddCharToDict(win.character);
            }
            LoadInitiative();
        }

        private void BtnEditParty_Click(object sender, EventArgs e)
        {
            Dictionary<string, Character> members = new();
            if (Utility.GetParty(cbParty.Text) == null) return;
            foreach (Character c in Utility.GetParty(cbParty.Text).Values)
            {
                addChar win = new(c);
                win.ShowDialog();
                members.Add(win.character.Name, win.character);
            }
            Utility.WritePartyFile(cbParty.Text, members);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!IsValidSel()) return;
            Character c = GetCharFromInitList(selIndex);
            charDict.Remove(c.Name);
            addChar win = new(c);
            win.ShowDialog();
            AddCharToDict(win.character);
            LoadInitiativeReorder();
            LoadCharacterDisplay();
        }

        private void BtnMore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void NumInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (Utility.KeyToNum(e) != -1)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
