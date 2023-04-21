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
            this.lstInitiative = new System.Windows.Forms.ListBox();
            this.btnChar = new System.Windows.Forms.Button();
            this.numChar = new System.Windows.Forms.NumericUpDown();
            this.lstHealth = new System.Windows.Forms.ListBox();
            this.lstAC = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.Label();
            this.txtHealth = new System.Windows.Forms.Label();
            this.txtAC = new System.Windows.Forms.Label();
            this.lblDebug = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numChar)).BeginInit();
            this.SuspendLayout();
            // 
            // lstInitiative
            // 
            this.lstInitiative.AllowDrop = true;
            this.lstInitiative.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInitiative.FormattingEnabled = true;
            this.lstInitiative.ImeMode = System.Windows.Forms.ImeMode.On;
            this.lstInitiative.ItemHeight = 25;
            this.lstInitiative.Location = new System.Drawing.Point(13, 38);
            this.lstInitiative.Name = "lstInitiative";
            this.lstInitiative.Size = new System.Drawing.Size(125, 629);
            this.lstInitiative.TabIndex = 2;
            this.lstInitiative.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstInitiative_DragDrop);
            this.lstInitiative.DragOver += new System.Windows.Forms.DragEventHandler(this.lstInitiative_DragOver);
            this.lstInitiative.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstInitiative_MouseDown);
            // 
            // btnChar
            // 
            this.btnChar.Location = new System.Drawing.Point(486, 14);
            this.btnChar.Name = "btnChar";
            this.btnChar.Size = new System.Drawing.Size(80, 23);
            this.btnChar.TabIndex = 3;
            this.btnChar.Text = "Add Chars";
            this.btnChar.UseVisualStyleBackColor = true;
            this.btnChar.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // numChar
            // 
            this.numChar.Location = new System.Drawing.Point(379, 17);
            this.numChar.Name = "numChar";
            this.numChar.Size = new System.Drawing.Size(80, 20);
            this.numChar.TabIndex = 9;
            this.numChar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lstHealth
            // 
            this.lstHealth.AllowDrop = true;
            this.lstHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHealth.FormattingEnabled = true;
            this.lstHealth.ItemHeight = 25;
            this.lstHealth.Location = new System.Drawing.Point(144, 38);
            this.lstHealth.Name = "lstHealth";
            this.lstHealth.Size = new System.Drawing.Size(63, 629);
            this.lstHealth.TabIndex = 10;
            // 
            // lstAC
            // 
            this.lstAC.AllowDrop = true;
            this.lstAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAC.FormattingEnabled = true;
            this.lstAC.ItemHeight = 25;
            this.lstAC.Location = new System.Drawing.Point(213, 38);
            this.lstAC.Name = "lstAC";
            this.lstAC.Size = new System.Drawing.Size(63, 629);
            this.lstAC.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(12, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(61, 24);
            this.txtName.TabIndex = 12;
            this.txtName.Text = "Name";
            // 
            // txtHealth
            // 
            this.txtHealth.AutoSize = true;
            this.txtHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHealth.Location = new System.Drawing.Point(140, 9);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(64, 24);
            this.txtHealth.TabIndex = 13;
            this.txtHealth.Text = "Health";
            // 
            // txtAC
            // 
            this.txtAC.AutoSize = true;
            this.txtAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAC.Location = new System.Drawing.Point(209, 9);
            this.txtAC.Name = "txtAC";
            this.txtAC.Size = new System.Drawing.Size(36, 24);
            this.txtAC.TabIndex = 14;
            this.txtAC.Text = "AC";
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebug.Location = new System.Drawing.Point(315, 148);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(230, 37);
            this.lblDebug.TabIndex = 15;
            this.lblDebug.Text = "DEBUG_TEXT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.txtAC);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstAC);
            this.Controls.Add(this.lstHealth);
            this.Controls.Add(this.numChar);
            this.Controls.Add(this.btnChar);
            this.Controls.Add(this.lstInitiative);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Battle Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numChar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstInitiative;
        private System.Windows.Forms.Button btnChar;
        private System.Windows.Forms.NumericUpDown numChar;
        private System.Windows.Forms.ListBox lstHealth;
        private System.Windows.Forms.ListBox lstAC;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtHealth;
        private System.Windows.Forms.Label txtAC;
        private System.Windows.Forms.Label lblDebug;
    }
}

