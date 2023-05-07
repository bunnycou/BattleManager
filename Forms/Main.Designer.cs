namespace BattleManager
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstInitiative = new System.Windows.Forms.ListBox();
            btnChar = new System.Windows.Forms.Button();
            numInput = new System.Windows.Forms.NumericUpDown();
            lblDebug = new System.Windows.Forms.Label();
            btnClear = new System.Windows.Forms.Button();
            btnDebugChars = new System.Windows.Forms.Button();
            lstLog = new System.Windows.Forms.ListBox();
            btnHeal = new System.Windows.Forms.Button();
            btnDamage = new System.Windows.Forms.Button();
            btnUndo = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            pnlMain = new System.Windows.Forms.Panel();
            btnEdit = new System.Windows.Forms.Button();
            btnCreateParty = new System.Windows.Forms.Button();
            btnAddParty = new System.Windows.Forms.Button();
            btnDeleteParty = new System.Windows.Forms.Button();
            gpParty = new System.Windows.Forms.GroupBox();
            btnEditParty = new System.Windows.Forms.Button();
            cbParty = new System.Windows.Forms.ComboBox();
            gpStatBlocks = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            btnEditStatBlock = new System.Windows.Forms.Button();
            cbStatBlock = new System.Windows.Forms.ComboBox();
            btnDeleteStatBlock = new System.Windows.Forms.Button();
            btnCreateStatBlock = new System.Windows.Forms.Button();
            btnAddStatBlock = new System.Windows.Forms.Button();
            gpCharacter = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            btnMore = new System.Windows.Forms.Button();
            gpImmunities = new System.Windows.Forms.GroupBox();
            lblImmunities = new System.Windows.Forms.Label();
            gpVulnerabilities = new System.Windows.Forms.GroupBox();
            lblVulnerabilities = new System.Windows.Forms.Label();
            gpResistances = new System.Windows.Forms.GroupBox();
            lblResistances = new System.Windows.Forms.Label();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            cbChaAdv = new System.Windows.Forms.CheckBox();
            cbWisAdv = new System.Windows.Forms.CheckBox();
            cbIntAdv = new System.Windows.Forms.CheckBox();
            cbConAdv = new System.Windows.Forms.CheckBox();
            cbDexAdv = new System.Windows.Forms.CheckBox();
            lblChaVal = new System.Windows.Forms.Label();
            lblWisVal = new System.Windows.Forms.Label();
            lblIntVal = new System.Windows.Forms.Label();
            lblConVal = new System.Windows.Forms.Label();
            lblDexVal = new System.Windows.Forms.Label();
            lblStr = new System.Windows.Forms.Label();
            lblDex = new System.Windows.Forms.Label();
            lblCon = new System.Windows.Forms.Label();
            lblInt = new System.Windows.Forms.Label();
            lblWis = new System.Windows.Forms.Label();
            lblCha = new System.Windows.Forms.Label();
            lblStrVal = new System.Windows.Forms.Label();
            cbStrAdv = new System.Windows.Forms.CheckBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label2 = new System.Windows.Forms.Label();
            lblLevel = new System.Windows.Forms.Label();
            lblHealthText = new System.Windows.Forms.Label();
            lblACText = new System.Windows.Forms.Label();
            lblInitiativeText = new System.Windows.Forms.Label();
            lblHealth = new System.Windows.Forms.Label();
            lblAC = new System.Windows.Forms.Label();
            lblInit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)numInput).BeginInit();
            pnlMain.SuspendLayout();
            gpParty.SuspendLayout();
            gpStatBlocks.SuspendLayout();
            gpCharacter.SuspendLayout();
            gpImmunities.SuspendLayout();
            gpVulnerabilities.SuspendLayout();
            gpResistances.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lstInitiative
            // 
            lstInitiative.AllowDrop = true;
            lstInitiative.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lstInitiative.FormattingEnabled = true;
            lstInitiative.ImeMode = System.Windows.Forms.ImeMode.On;
            lstInitiative.ItemHeight = 21;
            lstInitiative.Location = new System.Drawing.Point(13, 14);
            lstInitiative.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lstInitiative.Name = "lstInitiative";
            lstInitiative.Size = new System.Drawing.Size(370, 655);
            lstInitiative.TabIndex = 2;
            lstInitiative.DragDrop += LstInitiative_DragDrop;
            lstInitiative.DragOver += LstInitiative_DragOver;
            lstInitiative.MouseDown += LstInitiative_MouseDown;
            // 
            // btnChar
            // 
            btnChar.Location = new System.Drawing.Point(105, 7);
            btnChar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnChar.Name = "btnChar";
            btnChar.Size = new System.Drawing.Size(93, 27);
            btnChar.TabIndex = 3;
            btnChar.Text = "Add Chars";
            btnChar.UseVisualStyleBackColor = true;
            btnChar.Click += BtnChar_Click;
            // 
            // numInput
            // 
            numInput.Location = new System.Drawing.Point(4, 40);
            numInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numInput.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numInput.Name = "numInput";
            numInput.Size = new System.Drawing.Size(93, 23);
            numInput.TabIndex = 9;
            numInput.KeyDown += NumInput_KeyDown;
            // 
            // lblDebug
            // 
            lblDebug.AutoSize = true;
            lblDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDebug.Location = new System.Drawing.Point(756, 396);
            lblDebug.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDebug.Name = "lblDebug";
            lblDebug.Size = new System.Drawing.Size(277, 25);
            lblDebug.TabIndex = 15;
            lblDebug.Text = "Welcome to BattleManager!";
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(206, 23);
            btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(93, 27);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // btnDebugChars
            // 
            btnDebugChars.Location = new System.Drawing.Point(567, 621);
            btnDebugChars.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDebugChars.Name = "btnDebugChars";
            btnDebugChars.Size = new System.Drawing.Size(93, 48);
            btnDebugChars.TabIndex = 17;
            btnDebugChars.Text = "Add Test Characters";
            btnDebugChars.UseVisualStyleBackColor = true;
            btnDebugChars.Click += BtnDebugChars_Click;
            // 
            // lstLog
            // 
            lstLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lstLog.FormattingEnabled = true;
            lstLog.ItemHeight = 16;
            lstLog.Location = new System.Drawing.Point(756, 425);
            lstLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lstLog.Name = "lstLog";
            lstLog.Size = new System.Drawing.Size(500, 244);
            lstLog.TabIndex = 18;
            // 
            // btnHeal
            // 
            btnHeal.Location = new System.Drawing.Point(105, 40);
            btnHeal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHeal.Name = "btnHeal";
            btnHeal.Size = new System.Drawing.Size(93, 27);
            btnHeal.TabIndex = 19;
            btnHeal.Text = "Heal";
            btnHeal.UseVisualStyleBackColor = true;
            btnHeal.Click += BtnHeal_Click;
            // 
            // btnDamage
            // 
            btnDamage.Location = new System.Drawing.Point(105, 73);
            btnDamage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDamage.Name = "btnDamage";
            btnDamage.Size = new System.Drawing.Size(93, 27);
            btnDamage.TabIndex = 20;
            btnDamage.Text = "Damage";
            btnDamage.UseVisualStyleBackColor = true;
            btnDamage.Click += BtnDamage_Click;
            // 
            // btnUndo
            // 
            btnUndo.Location = new System.Drawing.Point(105, 132);
            btnUndo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new System.Drawing.Size(93, 27);
            btnUndo.TabIndex = 21;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += BtnUndo_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(206, 56);
            btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(93, 27);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(btnEdit);
            pnlMain.Controls.Add(numInput);
            pnlMain.Controls.Add(btnUndo);
            pnlMain.Controls.Add(btnDelete);
            pnlMain.Controls.Add(btnChar);
            pnlMain.Controls.Add(btnClear);
            pnlMain.Controls.Add(btnDamage);
            pnlMain.Controls.Add(btnHeal);
            pnlMain.Location = new System.Drawing.Point(390, 15);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(309, 172);
            pnlMain.TabIndex = 23;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(206, 89);
            btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(93, 27);
            btnEdit.TabIndex = 23;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnCreateParty
            // 
            btnCreateParty.Location = new System.Drawing.Point(6, 22);
            btnCreateParty.Name = "btnCreateParty";
            btnCreateParty.Size = new System.Drawing.Size(75, 47);
            btnCreateParty.TabIndex = 0;
            btnCreateParty.Text = "Create Party";
            btnCreateParty.UseVisualStyleBackColor = true;
            btnCreateParty.Click += BtnCreateParty_Click;
            // 
            // btnAddParty
            // 
            btnAddParty.Location = new System.Drawing.Point(6, 75);
            btnAddParty.Name = "btnAddParty";
            btnAddParty.Size = new System.Drawing.Size(75, 47);
            btnAddParty.TabIndex = 1;
            btnAddParty.Text = "Add\r\nParty";
            btnAddParty.UseVisualStyleBackColor = true;
            btnAddParty.Click += BtnAddParty_Click;
            // 
            // btnDeleteParty
            // 
            btnDeleteParty.Location = new System.Drawing.Point(6, 128);
            btnDeleteParty.Name = "btnDeleteParty";
            btnDeleteParty.Size = new System.Drawing.Size(75, 47);
            btnDeleteParty.TabIndex = 2;
            btnDeleteParty.Text = "Delete Party";
            btnDeleteParty.UseVisualStyleBackColor = true;
            btnDeleteParty.Click += BtnDeleteParty_Click;
            // 
            // gpParty
            // 
            gpParty.Controls.Add(btnEditParty);
            gpParty.Controls.Add(cbParty);
            gpParty.Controls.Add(btnDeleteParty);
            gpParty.Controls.Add(btnCreateParty);
            gpParty.Controls.Add(btnAddParty);
            gpParty.Location = new System.Drawing.Point(1038, 12);
            gpParty.Name = "gpParty";
            gpParty.Size = new System.Drawing.Size(218, 185);
            gpParty.TabIndex = 25;
            gpParty.TabStop = false;
            gpParty.Text = "Party";
            // 
            // btnEditParty
            // 
            btnEditParty.Location = new System.Drawing.Point(111, 22);
            btnEditParty.Name = "btnEditParty";
            btnEditParty.Size = new System.Drawing.Size(75, 47);
            btnEditParty.TabIndex = 4;
            btnEditParty.Text = "Edit\r\nParty";
            btnEditParty.UseVisualStyleBackColor = true;
            btnEditParty.Click += BtnEditParty_Click;
            // 
            // cbParty
            // 
            cbParty.FormattingEnabled = true;
            cbParty.Location = new System.Drawing.Point(87, 88);
            cbParty.Name = "cbParty";
            cbParty.Size = new System.Drawing.Size(121, 23);
            cbParty.TabIndex = 3;
            // 
            // gpStatBlocks
            // 
            gpStatBlocks.Controls.Add(label1);
            gpStatBlocks.Controls.Add(btnEditStatBlock);
            gpStatBlocks.Controls.Add(cbStatBlock);
            gpStatBlocks.Controls.Add(btnDeleteStatBlock);
            gpStatBlocks.Controls.Add(btnCreateStatBlock);
            gpStatBlocks.Controls.Add(btnAddStatBlock);
            gpStatBlocks.Location = new System.Drawing.Point(1038, 203);
            gpStatBlocks.Name = "gpStatBlocks";
            gpStatBlocks.Size = new System.Drawing.Size(218, 182);
            gpStatBlocks.TabIndex = 26;
            gpStatBlocks.TabStop = false;
            gpStatBlocks.Text = "Stat Blocks";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(96, 141);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 15);
            label1.TabIndex = 28;
            label1.Text = "not implemented";
            // 
            // btnEditStatBlock
            // 
            btnEditStatBlock.Location = new System.Drawing.Point(110, 19);
            btnEditStatBlock.Name = "btnEditStatBlock";
            btnEditStatBlock.Size = new System.Drawing.Size(75, 47);
            btnEditStatBlock.TabIndex = 8;
            btnEditStatBlock.Text = "Edit\r\nStat Block";
            btnEditStatBlock.UseVisualStyleBackColor = true;
            // 
            // cbStatBlock
            // 
            cbStatBlock.FormattingEnabled = true;
            cbStatBlock.Location = new System.Drawing.Point(86, 85);
            cbStatBlock.Name = "cbStatBlock";
            cbStatBlock.Size = new System.Drawing.Size(121, 23);
            cbStatBlock.TabIndex = 7;
            // 
            // btnDeleteStatBlock
            // 
            btnDeleteStatBlock.Location = new System.Drawing.Point(5, 125);
            btnDeleteStatBlock.Name = "btnDeleteStatBlock";
            btnDeleteStatBlock.Size = new System.Drawing.Size(75, 47);
            btnDeleteStatBlock.TabIndex = 6;
            btnDeleteStatBlock.Text = "Delete\r\nStat Block";
            btnDeleteStatBlock.UseVisualStyleBackColor = true;
            // 
            // btnCreateStatBlock
            // 
            btnCreateStatBlock.Location = new System.Drawing.Point(5, 19);
            btnCreateStatBlock.Name = "btnCreateStatBlock";
            btnCreateStatBlock.Size = new System.Drawing.Size(75, 47);
            btnCreateStatBlock.TabIndex = 4;
            btnCreateStatBlock.Text = "Create\r\nStat Block";
            btnCreateStatBlock.UseVisualStyleBackColor = true;
            // 
            // btnAddStatBlock
            // 
            btnAddStatBlock.Location = new System.Drawing.Point(5, 72);
            btnAddStatBlock.Name = "btnAddStatBlock";
            btnAddStatBlock.Size = new System.Drawing.Size(75, 47);
            btnAddStatBlock.TabIndex = 5;
            btnAddStatBlock.Text = "Add\r\n Stat Block";
            btnAddStatBlock.UseVisualStyleBackColor = true;
            // 
            // gpCharacter
            // 
            gpCharacter.Controls.Add(label4);
            gpCharacter.Controls.Add(btnMore);
            gpCharacter.Controls.Add(gpImmunities);
            gpCharacter.Controls.Add(gpVulnerabilities);
            gpCharacter.Controls.Add(gpResistances);
            gpCharacter.Controls.Add(tableLayoutPanel3);
            gpCharacter.Controls.Add(tableLayoutPanel1);
            gpCharacter.Location = new System.Drawing.Point(390, 193);
            gpCharacter.Name = "gpCharacter";
            gpCharacter.Size = new System.Drawing.Size(359, 312);
            gpCharacter.TabIndex = 27;
            gpCharacter.TabStop = false;
            gpCharacter.Text = "Character";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(139, 107);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 13);
            label4.TabIndex = 6;
            label4.Text = "proficiency?";
            // 
            // btnMore
            // 
            btnMore.Location = new System.Drawing.Point(6, 283);
            btnMore.Name = "btnMore";
            btnMore.Size = new System.Drawing.Size(75, 23);
            btnMore.TabIndex = 5;
            btnMore.Text = "More Info";
            btnMore.UseVisualStyleBackColor = true;
            btnMore.Click += BtnMore_Click;
            // 
            // gpImmunities
            // 
            gpImmunities.Controls.Add(lblImmunities);
            gpImmunities.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            gpImmunities.Location = new System.Drawing.Point(203, 190);
            gpImmunities.Name = "gpImmunities";
            gpImmunities.Size = new System.Drawing.Size(150, 90);
            gpImmunities.TabIndex = 4;
            gpImmunities.TabStop = false;
            gpImmunities.Text = "Immunities (x0)";
            // 
            // lblImmunities
            // 
            lblImmunities.Dock = System.Windows.Forms.DockStyle.Fill;
            lblImmunities.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblImmunities.Location = new System.Drawing.Point(3, 19);
            lblImmunities.Name = "lblImmunities";
            lblImmunities.Size = new System.Drawing.Size(144, 68);
            lblImmunities.TabIndex = 1;
            lblImmunities.Text = "None";
            // 
            // gpVulnerabilities
            // 
            gpVulnerabilities.Controls.Add(lblVulnerabilities);
            gpVulnerabilities.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            gpVulnerabilities.Location = new System.Drawing.Point(203, 100);
            gpVulnerabilities.Name = "gpVulnerabilities";
            gpVulnerabilities.Size = new System.Drawing.Size(150, 90);
            gpVulnerabilities.TabIndex = 4;
            gpVulnerabilities.TabStop = false;
            gpVulnerabilities.Text = "Vulnerabilities (x2)";
            // 
            // lblVulnerabilities
            // 
            lblVulnerabilities.Dock = System.Windows.Forms.DockStyle.Fill;
            lblVulnerabilities.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblVulnerabilities.Location = new System.Drawing.Point(3, 19);
            lblVulnerabilities.Name = "lblVulnerabilities";
            lblVulnerabilities.Size = new System.Drawing.Size(144, 68);
            lblVulnerabilities.TabIndex = 1;
            lblVulnerabilities.Text = "None";
            // 
            // gpResistances
            // 
            gpResistances.Controls.Add(lblResistances);
            gpResistances.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            gpResistances.Location = new System.Drawing.Point(203, 10);
            gpResistances.Name = "gpResistances";
            gpResistances.Size = new System.Drawing.Size(150, 90);
            gpResistances.TabIndex = 3;
            gpResistances.TabStop = false;
            gpResistances.Text = "Resistances (x1/2)";
            // 
            // lblResistances
            // 
            lblResistances.Dock = System.Windows.Forms.DockStyle.Fill;
            lblResistances.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblResistances.Location = new System.Drawing.Point(3, 19);
            lblResistances.Name = "lblResistances";
            lblResistances.Size = new System.Drawing.Size(144, 68);
            lblResistances.TabIndex = 0;
            lblResistances.Text = "None";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            tableLayoutPanel3.Controls.Add(cbChaAdv, 2, 5);
            tableLayoutPanel3.Controls.Add(cbWisAdv, 2, 4);
            tableLayoutPanel3.Controls.Add(cbIntAdv, 2, 3);
            tableLayoutPanel3.Controls.Add(cbConAdv, 2, 2);
            tableLayoutPanel3.Controls.Add(cbDexAdv, 2, 1);
            tableLayoutPanel3.Controls.Add(lblChaVal, 1, 5);
            tableLayoutPanel3.Controls.Add(lblWisVal, 1, 4);
            tableLayoutPanel3.Controls.Add(lblIntVal, 1, 3);
            tableLayoutPanel3.Controls.Add(lblConVal, 1, 2);
            tableLayoutPanel3.Controls.Add(lblDexVal, 1, 1);
            tableLayoutPanel3.Controls.Add(lblStr, 0, 0);
            tableLayoutPanel3.Controls.Add(lblDex, 0, 1);
            tableLayoutPanel3.Controls.Add(lblCon, 0, 2);
            tableLayoutPanel3.Controls.Add(lblInt, 0, 3);
            tableLayoutPanel3.Controls.Add(lblWis, 0, 4);
            tableLayoutPanel3.Controls.Add(lblCha, 0, 5);
            tableLayoutPanel3.Controls.Add(lblStrVal, 1, 0);
            tableLayoutPanel3.Controls.Add(cbStrAdv, 2, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(6, 121);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.Size = new System.Drawing.Size(178, 156);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // cbChaAdv
            // 
            cbChaAdv.AutoSize = true;
            cbChaAdv.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cbChaAdv.Dock = System.Windows.Forms.DockStyle.Fill;
            cbChaAdv.Enabled = false;
            cbChaAdv.Location = new System.Drawing.Point(151, 128);
            cbChaAdv.Name = "cbChaAdv";
            cbChaAdv.Size = new System.Drawing.Size(24, 25);
            cbChaAdv.TabIndex = 17;
            cbChaAdv.UseVisualStyleBackColor = true;
            // 
            // cbWisAdv
            // 
            cbWisAdv.AutoSize = true;
            cbWisAdv.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cbWisAdv.Dock = System.Windows.Forms.DockStyle.Fill;
            cbWisAdv.Enabled = false;
            cbWisAdv.Location = new System.Drawing.Point(151, 103);
            cbWisAdv.Name = "cbWisAdv";
            cbWisAdv.Size = new System.Drawing.Size(24, 19);
            cbWisAdv.TabIndex = 16;
            cbWisAdv.UseVisualStyleBackColor = true;
            // 
            // cbIntAdv
            // 
            cbIntAdv.AccessibleDescription = "";
            cbIntAdv.AutoSize = true;
            cbIntAdv.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cbIntAdv.Dock = System.Windows.Forms.DockStyle.Fill;
            cbIntAdv.Enabled = false;
            cbIntAdv.Location = new System.Drawing.Point(151, 78);
            cbIntAdv.Name = "cbIntAdv";
            cbIntAdv.Size = new System.Drawing.Size(24, 19);
            cbIntAdv.TabIndex = 15;
            cbIntAdv.UseVisualStyleBackColor = true;
            // 
            // cbConAdv
            // 
            cbConAdv.AutoSize = true;
            cbConAdv.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cbConAdv.Dock = System.Windows.Forms.DockStyle.Fill;
            cbConAdv.Enabled = false;
            cbConAdv.Location = new System.Drawing.Point(151, 53);
            cbConAdv.Name = "cbConAdv";
            cbConAdv.Size = new System.Drawing.Size(24, 19);
            cbConAdv.TabIndex = 14;
            cbConAdv.UseVisualStyleBackColor = true;
            // 
            // cbDexAdv
            // 
            cbDexAdv.AutoSize = true;
            cbDexAdv.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cbDexAdv.Dock = System.Windows.Forms.DockStyle.Fill;
            cbDexAdv.Enabled = false;
            cbDexAdv.Location = new System.Drawing.Point(151, 28);
            cbDexAdv.Name = "cbDexAdv";
            cbDexAdv.Size = new System.Drawing.Size(24, 19);
            cbDexAdv.TabIndex = 13;
            cbDexAdv.UseVisualStyleBackColor = true;
            // 
            // lblChaVal
            // 
            lblChaVal.AutoSize = true;
            lblChaVal.Dock = System.Windows.Forms.DockStyle.Fill;
            lblChaVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblChaVal.Location = new System.Drawing.Point(54, 125);
            lblChaVal.Name = "lblChaVal";
            lblChaVal.Size = new System.Drawing.Size(91, 31);
            lblChaVal.TabIndex = 11;
            lblChaVal.Text = "10 (+0)";
            lblChaVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWisVal
            // 
            lblWisVal.AutoSize = true;
            lblWisVal.Dock = System.Windows.Forms.DockStyle.Fill;
            lblWisVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblWisVal.Location = new System.Drawing.Point(54, 100);
            lblWisVal.Name = "lblWisVal";
            lblWisVal.Size = new System.Drawing.Size(91, 25);
            lblWisVal.TabIndex = 10;
            lblWisVal.Text = "10 (+0)";
            lblWisVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIntVal
            // 
            lblIntVal.AutoSize = true;
            lblIntVal.Dock = System.Windows.Forms.DockStyle.Fill;
            lblIntVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblIntVal.Location = new System.Drawing.Point(54, 75);
            lblIntVal.Name = "lblIntVal";
            lblIntVal.Size = new System.Drawing.Size(91, 25);
            lblIntVal.TabIndex = 9;
            lblIntVal.Text = "10 (+0)";
            lblIntVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConVal
            // 
            lblConVal.AutoSize = true;
            lblConVal.Dock = System.Windows.Forms.DockStyle.Fill;
            lblConVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblConVal.Location = new System.Drawing.Point(54, 50);
            lblConVal.Name = "lblConVal";
            lblConVal.Size = new System.Drawing.Size(91, 25);
            lblConVal.TabIndex = 8;
            lblConVal.Text = "10 (+0)";
            lblConVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDexVal
            // 
            lblDexVal.AutoSize = true;
            lblDexVal.Dock = System.Windows.Forms.DockStyle.Fill;
            lblDexVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblDexVal.Location = new System.Drawing.Point(54, 25);
            lblDexVal.Name = "lblDexVal";
            lblDexVal.Size = new System.Drawing.Size(91, 25);
            lblDexVal.TabIndex = 7;
            lblDexVal.Text = "10 (+0)";
            lblDexVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStr
            // 
            lblStr.AutoSize = true;
            lblStr.Dock = System.Windows.Forms.DockStyle.Fill;
            lblStr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblStr.Location = new System.Drawing.Point(3, 0);
            lblStr.Name = "lblStr";
            lblStr.Size = new System.Drawing.Size(45, 25);
            lblStr.TabIndex = 0;
            lblStr.Text = "STR";
            lblStr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDex
            // 
            lblDex.AutoSize = true;
            lblDex.Dock = System.Windows.Forms.DockStyle.Fill;
            lblDex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDex.Location = new System.Drawing.Point(3, 25);
            lblDex.Name = "lblDex";
            lblDex.Size = new System.Drawing.Size(45, 25);
            lblDex.TabIndex = 1;
            lblDex.Text = "DEX";
            lblDex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCon
            // 
            lblCon.AutoSize = true;
            lblCon.Dock = System.Windows.Forms.DockStyle.Fill;
            lblCon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCon.Location = new System.Drawing.Point(3, 50);
            lblCon.Name = "lblCon";
            lblCon.Size = new System.Drawing.Size(45, 25);
            lblCon.TabIndex = 2;
            lblCon.Text = "CON";
            lblCon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInt
            // 
            lblInt.AutoSize = true;
            lblInt.Dock = System.Windows.Forms.DockStyle.Fill;
            lblInt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblInt.Location = new System.Drawing.Point(3, 75);
            lblInt.Name = "lblInt";
            lblInt.Size = new System.Drawing.Size(45, 25);
            lblInt.TabIndex = 3;
            lblInt.Text = "INT";
            lblInt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWis
            // 
            lblWis.AutoSize = true;
            lblWis.Dock = System.Windows.Forms.DockStyle.Fill;
            lblWis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblWis.Location = new System.Drawing.Point(3, 100);
            lblWis.Name = "lblWis";
            lblWis.Size = new System.Drawing.Size(45, 25);
            lblWis.TabIndex = 4;
            lblWis.Text = "WIS";
            lblWis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCha
            // 
            lblCha.AutoSize = true;
            lblCha.Dock = System.Windows.Forms.DockStyle.Fill;
            lblCha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCha.Location = new System.Drawing.Point(3, 125);
            lblCha.Name = "lblCha";
            lblCha.Size = new System.Drawing.Size(45, 31);
            lblCha.TabIndex = 5;
            lblCha.Text = "CHA";
            lblCha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStrVal
            // 
            lblStrVal.AutoSize = true;
            lblStrVal.Dock = System.Windows.Forms.DockStyle.Fill;
            lblStrVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblStrVal.Location = new System.Drawing.Point(54, 0);
            lblStrVal.Name = "lblStrVal";
            lblStrVal.Size = new System.Drawing.Size(91, 25);
            lblStrVal.TabIndex = 6;
            lblStrVal.Text = "10 (+0)";
            lblStrVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbStrAdv
            // 
            cbStrAdv.AutoSize = true;
            cbStrAdv.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cbStrAdv.Dock = System.Windows.Forms.DockStyle.Fill;
            cbStrAdv.Enabled = false;
            cbStrAdv.Location = new System.Drawing.Point(151, 3);
            cbStrAdv.Name = "cbStrAdv";
            cbStrAdv.Size = new System.Drawing.Size(24, 19);
            cbStrAdv.TabIndex = 12;
            cbStrAdv.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.1428566F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.8571434F));
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(lblLevel, 0, 3);
            tableLayoutPanel1.Controls.Add(lblHealthText, 0, 0);
            tableLayoutPanel1.Controls.Add(lblACText, 0, 1);
            tableLayoutPanel1.Controls.Add(lblInitiativeText, 0, 2);
            tableLayoutPanel1.Controls.Add(lblHealth, 1, 0);
            tableLayoutPanel1.Controls.Add(lblAC, 1, 1);
            tableLayoutPanel1.Controls.Add(lblInit, 1, 2);
            tableLayoutPanel1.Location = new System.Drawing.Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new System.Drawing.Size(133, 96);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(3, 72);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 24);
            label2.TabIndex = 6;
            label2.Text = "Level";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            lblLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLevel.Location = new System.Drawing.Point(79, 72);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new System.Drawing.Size(51, 24);
            lblLevel.TabIndex = 7;
            lblLevel.Text = "0";
            lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHealthText
            // 
            lblHealthText.AutoSize = true;
            lblHealthText.Dock = System.Windows.Forms.DockStyle.Fill;
            lblHealthText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblHealthText.Location = new System.Drawing.Point(3, 0);
            lblHealthText.Name = "lblHealthText";
            lblHealthText.Size = new System.Drawing.Size(70, 24);
            lblHealthText.TabIndex = 0;
            lblHealthText.Text = "Health";
            lblHealthText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblACText
            // 
            lblACText.AutoSize = true;
            lblACText.Dock = System.Windows.Forms.DockStyle.Fill;
            lblACText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblACText.Location = new System.Drawing.Point(3, 24);
            lblACText.Name = "lblACText";
            lblACText.Size = new System.Drawing.Size(70, 24);
            lblACText.TabIndex = 1;
            lblACText.Text = "AC";
            lblACText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInitiativeText
            // 
            lblInitiativeText.AutoSize = true;
            lblInitiativeText.Dock = System.Windows.Forms.DockStyle.Fill;
            lblInitiativeText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblInitiativeText.Location = new System.Drawing.Point(3, 48);
            lblInitiativeText.Name = "lblInitiativeText";
            lblInitiativeText.Size = new System.Drawing.Size(70, 24);
            lblInitiativeText.TabIndex = 2;
            lblInitiativeText.Text = "Initiative";
            lblInitiativeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHealth
            // 
            lblHealth.AutoSize = true;
            lblHealth.Dock = System.Windows.Forms.DockStyle.Fill;
            lblHealth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblHealth.Location = new System.Drawing.Point(79, 0);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new System.Drawing.Size(51, 24);
            lblHealth.TabIndex = 3;
            lblHealth.Text = "0";
            lblHealth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAC
            // 
            lblAC.AutoSize = true;
            lblAC.Dock = System.Windows.Forms.DockStyle.Fill;
            lblAC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAC.Location = new System.Drawing.Point(79, 24);
            lblAC.Name = "lblAC";
            lblAC.Size = new System.Drawing.Size(51, 24);
            lblAC.TabIndex = 4;
            lblAC.Text = "0";
            lblAC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInit
            // 
            lblInit.AutoSize = true;
            lblInit.Dock = System.Windows.Forms.DockStyle.Fill;
            lblInit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblInit.Location = new System.Drawing.Point(79, 48);
            lblInit.Name = "lblInit";
            lblInit.Size = new System.Drawing.Size(51, 24);
            lblInit.TabIndex = 5;
            lblInit.Text = "0";
            lblInit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1264, 681);
            Controls.Add(gpCharacter);
            Controls.Add(gpStatBlocks);
            Controls.Add(gpParty);
            Controls.Add(pnlMain);
            Controls.Add(lstLog);
            Controls.Add(btnDebugChars);
            Controls.Add(lblDebug);
            Controls.Add(lstInitiative);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            HelpButton = true;
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Main";
            Text = "BattleManager";
            Load += Main_Load;
            KeyDown += Main_KeyDown;
            KeyUp += Main_KeyUp;
            ((System.ComponentModel.ISupportInitialize)numInput).EndInit();
            pnlMain.ResumeLayout(false);
            gpParty.ResumeLayout(false);
            gpStatBlocks.ResumeLayout(false);
            gpStatBlocks.PerformLayout();
            gpCharacter.ResumeLayout(false);
            gpCharacter.PerformLayout();
            gpImmunities.ResumeLayout(false);
            gpVulnerabilities.ResumeLayout(false);
            gpResistances.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ListBox lstInitiative;
        private System.Windows.Forms.Button btnChar;
        private System.Windows.Forms.NumericUpDown numInput;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDebugChars;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.Button btnDamage;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnDeleteParty;
        private System.Windows.Forms.Button btnAddParty;
        private System.Windows.Forms.Button btnCreateParty;
        private System.Windows.Forms.GroupBox gpParty;
        private System.Windows.Forms.ComboBox cbParty;
        private System.Windows.Forms.GroupBox gpStatBlocks;
        private System.Windows.Forms.ComboBox cbStatBlock;
        private System.Windows.Forms.Button btnDeleteStatBlock;
        private System.Windows.Forms.Button btnCreateStatBlock;
        private System.Windows.Forms.Button btnAddStatBlock;
        private System.Windows.Forms.Button btnEditParty;
        private System.Windows.Forms.Button btnEditStatBlock;
        private System.Windows.Forms.GroupBox gpCharacter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHealthText;
        private System.Windows.Forms.Label lblACText;
        private System.Windows.Forms.Label lblInitiativeText;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblAC;
        private System.Windows.Forms.Label lblInit;
        private System.Windows.Forms.Label lblChaVal;
        private System.Windows.Forms.Label lblWisVal;
        private System.Windows.Forms.Label lblIntVal;
        private System.Windows.Forms.Label lblConVal;
        private System.Windows.Forms.Label lblDexVal;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblWis;
        private System.Windows.Forms.Label lblCha;
        private System.Windows.Forms.Label lblStrVal;
        private System.Windows.Forms.GroupBox gpImmunities;
        private System.Windows.Forms.Label lblImmunities;
        private System.Windows.Forms.GroupBox gpVulnerabilities;
        private System.Windows.Forms.Label lblVulnerabilities;
        private System.Windows.Forms.GroupBox gpResistances;
        private System.Windows.Forms.Label lblResistances;
        private System.Windows.Forms.CheckBox cbChaAdv;
        private System.Windows.Forms.CheckBox cbWisAdv;
        private System.Windows.Forms.CheckBox cbIntAdv;
        private System.Windows.Forms.CheckBox cbConAdv;
        private System.Windows.Forms.CheckBox cbDexAdv;
        private System.Windows.Forms.CheckBox cbStrAdv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEdit;
    }
}

