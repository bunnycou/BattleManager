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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            lstInitiative = new System.Windows.Forms.ListBox();
            numInput = new System.Windows.Forms.NumericUpDown();
            lstLog = new System.Windows.Forms.ListBox();
            btnHeal = new System.Windows.Forms.Button();
            btnDamage = new System.Windows.Forms.Button();
            btnUndo = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            pnlMain = new System.Windows.Forms.Panel();
            btnEdit = new System.Windows.Forms.Button();
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
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tsddMain = new System.Windows.Forms.ToolStripDropDownButton();
            addCharsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            clearInitiativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            partiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statBlocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            addTestCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            createPartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            AddPartyMenu = new System.Windows.Forms.ToolStripMenuItem();
            EditPartyMenu = new System.Windows.Forms.ToolStripMenuItem();
            DeletePartyMenu = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            createCreatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            AddStatMenu = new System.Windows.Forms.ToolStripMenuItem();
            EditStatMenu = new System.Windows.Forms.ToolStripMenuItem();
            DeleteStatMenu = new System.Windows.Forms.ToolStripMenuItem();
            genTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cmbStatMenu = new System.Windows.Forms.ToolStripComboBox();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            HelpToolButton = new System.Windows.Forms.ToolStripButton();
            gpActions = new System.Windows.Forms.GroupBox();
            flwActions = new System.Windows.Forms.FlowLayoutPanel();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            lblLogTop = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)numInput).BeginInit();
            pnlMain.SuspendLayout();
            gpCharacter.SuspendLayout();
            gpImmunities.SuspendLayout();
            gpVulnerabilities.SuspendLayout();
            gpResistances.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            gpActions.SuspendLayout();
            SuspendLayout();
            // 
            // lstInitiative
            // 
            lstInitiative.AllowDrop = true;
            lstInitiative.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lstInitiative.FormattingEnabled = true;
            lstInitiative.ImeMode = System.Windows.Forms.ImeMode.On;
            lstInitiative.ItemHeight = 21;
            lstInitiative.Location = new System.Drawing.Point(13, 33);
            lstInitiative.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lstInitiative.Name = "lstInitiative";
            lstInitiative.Size = new System.Drawing.Size(359, 592);
            lstInitiative.TabIndex = 2;
            lstInitiative.DragDrop += LstInitiative_DragDrop;
            lstInitiative.DragOver += LstInitiative_DragOver;
            lstInitiative.MouseDown += LstInitiative_MouseDown;
            // 
            // numInput
            // 
            numInput.Location = new System.Drawing.Point(10, 11);
            numInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numInput.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numInput.Name = "numInput";
            numInput.Size = new System.Drawing.Size(93, 23);
            numInput.TabIndex = 9;
            numInput.KeyDown += NumInput_KeyDown;
            // 
            // lstLog
            // 
            lstLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lstLog.FormattingEnabled = true;
            lstLog.ItemHeight = 16;
            lstLog.Location = new System.Drawing.Point(380, 445);
            lstLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lstLog.Name = "lstLog";
            lstLog.Size = new System.Drawing.Size(359, 180);
            lstLog.TabIndex = 18;
            // 
            // btnHeal
            // 
            btnHeal.Location = new System.Drawing.Point(111, 7);
            btnHeal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHeal.Name = "btnHeal";
            btnHeal.Size = new System.Drawing.Size(70, 27);
            btnHeal.TabIndex = 19;
            btnHeal.Text = "Heal";
            btnHeal.UseVisualStyleBackColor = true;
            btnHeal.Click += BtnHeal_Click;
            // 
            // btnDamage
            // 
            btnDamage.Location = new System.Drawing.Point(111, 40);
            btnDamage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDamage.Name = "btnDamage";
            btnDamage.Size = new System.Drawing.Size(70, 27);
            btnDamage.TabIndex = 20;
            btnDamage.Text = "Damage";
            btnDamage.UseVisualStyleBackColor = true;
            btnDamage.Click += BtnDamage_Click;
            // 
            // btnUndo
            // 
            btnUndo.Location = new System.Drawing.Point(33, 40);
            btnUndo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new System.Drawing.Size(70, 27);
            btnUndo.TabIndex = 21;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += BtnUndo_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(189, 40);
            btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(70, 27);
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
            pnlMain.Controls.Add(btnDamage);
            pnlMain.Controls.Add(btnHeal);
            pnlMain.Location = new System.Drawing.Point(379, 34);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(309, 79);
            pnlMain.TabIndex = 23;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(189, 7);
            btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(70, 27);
            btnEdit.TabIndex = 23;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
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
            gpCharacter.Location = new System.Drawing.Point(379, 119);
            gpCharacter.Name = "gpCharacter";
            gpCharacter.Size = new System.Drawing.Size(359, 287);
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
            btnMore.Location = new System.Drawing.Point(145, 39);
            btnMore.Name = "btnMore";
            btnMore.Size = new System.Drawing.Size(52, 43);
            btnMore.TabIndex = 5;
            btnMore.Text = "More Info";
            btnMore.UseVisualStyleBackColor = true;
            btnMore.Visible = false;
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
            // toolStrip1
            // 
            toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsddMain, toolStripSeparator1, toolStripDropDownButton1, toolStripSeparator3, toolStripDropDownButton2, cmbStatMenu, toolStripSeparator2, HelpToolButton, toolStripSeparator4, lblLogTop });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(1006, 25);
            toolStrip1.TabIndex = 28;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsddMain
            // 
            tsddMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsddMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { addCharsToolStripMenuItem, clearInitiativeToolStripMenuItem, openFolderToolStripMenuItem, addTestCharactersToolStripMenuItem, aboutToolStripMenuItem });
            tsddMain.Image = (System.Drawing.Image)resources.GetObject("tsddMain.Image");
            tsddMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsddMain.Name = "tsddMain";
            tsddMain.Size = new System.Drawing.Size(38, 22);
            tsddMain.Text = "BM";
            // 
            // addCharsToolStripMenuItem
            // 
            addCharsToolStripMenuItem.Name = "addCharsToolStripMenuItem";
            addCharsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            addCharsToolStripMenuItem.Text = "Add Characters";
            addCharsToolStripMenuItem.Click += AddCharsToolStripMenuItem_Click;
            // 
            // clearInitiativeToolStripMenuItem
            // 
            clearInitiativeToolStripMenuItem.Name = "clearInitiativeToolStripMenuItem";
            clearInitiativeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            clearInitiativeToolStripMenuItem.Text = "Clear Initiative";
            clearInitiativeToolStripMenuItem.Click += ClearInitiativeToolStripMenuItem_Click;
            // 
            // openFolderToolStripMenuItem
            // 
            openFolderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { partiesToolStripMenuItem, statBlocksToolStripMenuItem });
            openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            openFolderToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            openFolderToolStripMenuItem.Text = "Open Folder...";
            // 
            // partiesToolStripMenuItem
            // 
            partiesToolStripMenuItem.Name = "partiesToolStripMenuItem";
            partiesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            partiesToolStripMenuItem.Text = "Parties";
            partiesToolStripMenuItem.Click += PartiesToolStripMenuItem_Click;
            // 
            // statBlocksToolStripMenuItem
            // 
            statBlocksToolStripMenuItem.Name = "statBlocksToolStripMenuItem";
            statBlocksToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            statBlocksToolStripMenuItem.Text = "Stat Blocks";
            statBlocksToolStripMenuItem.Click += StatBlocksToolStripMenuItem_Click;
            // 
            // addTestCharactersToolStripMenuItem
            // 
            addTestCharactersToolStripMenuItem.Name = "addTestCharactersToolStripMenuItem";
            addTestCharactersToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            addTestCharactersToolStripMenuItem.Text = "Add Test Characters";
            addTestCharactersToolStripMenuItem.Click += AddTestCharactersToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { createPartyToolStripMenuItem, AddPartyMenu, EditPartyMenu, DeletePartyMenu });
            toolStripDropDownButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new System.Drawing.Size(47, 22);
            toolStripDropDownButton1.Text = "Party";
            // 
            // createPartyToolStripMenuItem
            // 
            createPartyToolStripMenuItem.Name = "createPartyToolStripMenuItem";
            createPartyToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            createPartyToolStripMenuItem.Text = "Create Party";
            createPartyToolStripMenuItem.Click += CreatePartyToolStripMenuItem_Click;
            // 
            // AddPartyMenu
            // 
            AddPartyMenu.Name = "AddPartyMenu";
            AddPartyMenu.Size = new System.Drawing.Size(146, 22);
            AddPartyMenu.Text = "Add Party...";
            AddPartyMenu.DropDownItemClicked += AddPartyMenu_DropDownItemClicked;
            // 
            // EditPartyMenu
            // 
            EditPartyMenu.Name = "EditPartyMenu";
            EditPartyMenu.Size = new System.Drawing.Size(146, 22);
            EditPartyMenu.Text = "Edit Party...";
            EditPartyMenu.DropDownItemClicked += EditPartyMenu_DropDownItemClicked;
            // 
            // DeletePartyMenu
            // 
            DeletePartyMenu.Name = "DeletePartyMenu";
            DeletePartyMenu.Size = new System.Drawing.Size(146, 22);
            DeletePartyMenu.Text = "Delete Party...";
            DeletePartyMenu.DropDownItemClicked += DeletePartyMenu_DropDownItemClicked;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { createCreatureToolStripMenuItem, AddStatMenu, EditStatMenu, DeleteStatMenu, genTestToolStripMenuItem });
            toolStripDropDownButton2.Image = (System.Drawing.Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new System.Drawing.Size(65, 22);
            toolStripDropDownButton2.Text = "Creature";
            // 
            // createCreatureToolStripMenuItem
            // 
            createCreatureToolStripMenuItem.Name = "createCreatureToolStripMenuItem";
            createCreatureToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            createCreatureToolStripMenuItem.Text = "Create Creature";
            createCreatureToolStripMenuItem.Click += CreateCreatureToolStripMenuItem_Click;
            // 
            // AddStatMenu
            // 
            AddStatMenu.Name = "AddStatMenu";
            AddStatMenu.Size = new System.Drawing.Size(164, 22);
            AddStatMenu.Text = "Add Creature...";
            AddStatMenu.Click += AddStatMenu_Click;
            // 
            // EditStatMenu
            // 
            EditStatMenu.Name = "EditStatMenu";
            EditStatMenu.Size = new System.Drawing.Size(164, 22);
            EditStatMenu.Text = "Edit Creature...";
            EditStatMenu.Click += EditStatMenu_Click;
            // 
            // DeleteStatMenu
            // 
            DeleteStatMenu.Name = "DeleteStatMenu";
            DeleteStatMenu.Size = new System.Drawing.Size(164, 22);
            DeleteStatMenu.Text = "Delete Creature...";
            DeleteStatMenu.Click += DeleteStatMenu_Click;
            // 
            // genTestToolStripMenuItem
            // 
            genTestToolStripMenuItem.Name = "genTestToolStripMenuItem";
            genTestToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            genTestToolStripMenuItem.Text = "Gen Test";
            genTestToolStripMenuItem.Click += genTestToolStripMenuItem_Click;
            // 
            // cmbStatMenu
            // 
            cmbStatMenu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            cmbStatMenu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cmbStatMenu.MaxDropDownItems = 99;
            cmbStatMenu.Name = "cmbStatMenu";
            cmbStatMenu.Size = new System.Drawing.Size(121, 25);
            cmbStatMenu.Text = "Creatures...";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // HelpToolButton
            // 
            HelpToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            HelpToolButton.Image = Properties.Resources.help_google_icon;
            HelpToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            HelpToolButton.Name = "HelpToolButton";
            HelpToolButton.Size = new System.Drawing.Size(23, 22);
            HelpToolButton.Text = "Help";
            HelpToolButton.Click += HelpToolButton_Click;
            // 
            // gpActions
            // 
            gpActions.Controls.Add(flwActions);
            gpActions.Location = new System.Drawing.Point(746, 28);
            gpActions.Name = "gpActions";
            gpActions.Size = new System.Drawing.Size(250, 597);
            gpActions.TabIndex = 29;
            gpActions.TabStop = false;
            gpActions.Text = "Actions";
            // 
            // flwActions
            // 
            flwActions.AutoSize = true;
            flwActions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flwActions.Location = new System.Drawing.Point(6, 22);
            flwActions.Name = "flwActions";
            flwActions.Size = new System.Drawing.Size(238, 569);
            flwActions.TabIndex = 0;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // lblLogTop
            // 
            lblLogTop.Name = "lblLogTop";
            lblLogTop.Size = new System.Drawing.Size(154, 22);
            lblLogTop.Text = "Welcome to BattleManager!";
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1006, 631);
            Controls.Add(gpActions);
            Controls.Add(toolStrip1);
            Controls.Add(gpCharacter);
            Controls.Add(pnlMain);
            Controls.Add(lstLog);
            Controls.Add(lstInitiative);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Main";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "BattleManager";
            Load += Main_Load;
            KeyDown += Main_KeyDown;
            KeyUp += Main_KeyUp;
            ((System.ComponentModel.ISupportInitialize)numInput).EndInit();
            pnlMain.ResumeLayout(false);
            gpCharacter.ResumeLayout(false);
            gpCharacter.PerformLayout();
            gpImmunities.ResumeLayout(false);
            gpVulnerabilities.ResumeLayout(false);
            gpResistances.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            gpActions.ResumeLayout(false);
            gpActions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ListBox lstInitiative;
        private System.Windows.Forms.NumericUpDown numInput;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.Button btnDamage;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlMain;
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
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsddMain;
        private System.Windows.Forms.ToolStripMenuItem clearInitiativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton HelpToolButton;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statBlocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCharsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem createPartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditPartyMenu;
        private System.Windows.Forms.ToolStripMenuItem AddPartyMenu;
        private System.Windows.Forms.ToolStripMenuItem DeletePartyMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem createCreatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditStatMenu;
        private System.Windows.Forms.ToolStripMenuItem AddStatMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteStatMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addTestCharactersToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpActions;
        private System.Windows.Forms.FlowLayoutPanel flwActions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox cmbStatMenu;
        private System.Windows.Forms.ToolStripMenuItem genTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel lblLogTop;
    }
}

