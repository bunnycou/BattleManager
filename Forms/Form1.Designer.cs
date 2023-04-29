namespace BattleManager
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)numInput).BeginInit();
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
            lstInitiative.DragDrop += lstInitiative_DragDrop;
            lstInitiative.DragOver += lstInitiative_DragOver;
            lstInitiative.MouseDown += lstInitiative_MouseDown;
            // 
            // btnChar
            // 
            btnChar.Location = new System.Drawing.Point(545, 73);
            btnChar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnChar.Name = "btnChar";
            btnChar.Size = new System.Drawing.Size(93, 27);
            btnChar.TabIndex = 3;
            btnChar.Text = "Add Chars";
            btnChar.UseVisualStyleBackColor = true;
            btnChar.Click += btnChar_Click;
            // 
            // numInput
            // 
            numInput.Location = new System.Drawing.Point(432, 106);
            numInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numInput.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numInput.Name = "numInput";
            numInput.Size = new System.Drawing.Size(93, 23);
            numInput.TabIndex = 9;
            numInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDebug
            // 
            lblDebug.AutoSize = true;
            lblDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDebug.Location = new System.Drawing.Point(668, 317);
            lblDebug.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDebug.Name = "lblDebug";
            lblDebug.Size = new System.Drawing.Size(61, 25);
            lblDebug.TabIndex = 15;
            lblDebug.Text = "Hello";
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(716, 78);
            btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(93, 27);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDebugChars
            // 
            btnDebugChars.Location = new System.Drawing.Point(866, 82);
            btnDebugChars.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDebugChars.Name = "btnDebugChars";
            btnDebugChars.Size = new System.Drawing.Size(93, 48);
            btnDebugChars.TabIndex = 17;
            btnDebugChars.Text = "Add 3 Test Characters";
            btnDebugChars.UseVisualStyleBackColor = true;
            btnDebugChars.Click += btnDebugChars_Click;
            // 
            // lstLog
            // 
            lstLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lstLog.FormattingEnabled = true;
            lstLog.ItemHeight = 16;
            lstLog.Location = new System.Drawing.Point(668, 345);
            lstLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lstLog.Name = "lstLog";
            lstLog.Size = new System.Drawing.Size(583, 324);
            lstLog.TabIndex = 18;
            // 
            // btnHeal
            // 
            btnHeal.Location = new System.Drawing.Point(545, 106);
            btnHeal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHeal.Name = "btnHeal";
            btnHeal.Size = new System.Drawing.Size(93, 27);
            btnHeal.TabIndex = 19;
            btnHeal.Text = "Heal";
            btnHeal.UseVisualStyleBackColor = true;
            btnHeal.Click += btnHeal_Click;
            // 
            // btnDamage
            // 
            btnDamage.Location = new System.Drawing.Point(545, 139);
            btnDamage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDamage.Name = "btnDamage";
            btnDamage.Size = new System.Drawing.Size(93, 27);
            btnDamage.TabIndex = 20;
            btnDamage.Text = "Damage";
            btnDamage.UseVisualStyleBackColor = true;
            btnDamage.Click += btnDamage_Click;
            // 
            // btnUndo
            // 
            btnUndo.Location = new System.Drawing.Point(545, 216);
            btnUndo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new System.Drawing.Size(93, 27);
            btnUndo.TabIndex = 21;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1264, 681);
            Controls.Add(btnUndo);
            Controls.Add(btnDamage);
            Controls.Add(btnHeal);
            Controls.Add(lstLog);
            Controls.Add(btnDebugChars);
            Controls.Add(btnClear);
            Controls.Add(lblDebug);
            Controls.Add(numInput);
            Controls.Add(btnChar);
            Controls.Add(lstInitiative);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            HelpButton = true;
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Battle Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numInput).EndInit();
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
    }
}

