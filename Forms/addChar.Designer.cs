namespace BattleManager
{
    partial class addChar
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
            lblName = new System.Windows.Forms.Label();
            lblHealth = new System.Windows.Forms.Label();
            lblAC = new System.Windows.Forms.Label();
            numHealth = new System.Windows.Forms.NumericUpDown();
            numAC = new System.Windows.Forms.NumericUpDown();
            txtName = new System.Windows.Forms.TextBox();
            btnDone = new System.Windows.Forms.Button();
            numInit = new System.Windows.Forms.NumericUpDown();
            lblInit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)numHealth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numInit).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblName.Location = new System.Drawing.Point(14, 10);
            lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(51, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblHealth
            // 
            lblHealth.AutoSize = true;
            lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblHealth.Location = new System.Drawing.Point(14, 43);
            lblHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new System.Drawing.Size(56, 20);
            lblHealth.TabIndex = 1;
            lblHealth.Text = "Health";
            // 
            // lblAC
            // 
            lblAC.AutoSize = true;
            lblAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAC.Location = new System.Drawing.Point(14, 75);
            lblAC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAC.Name = "lblAC";
            lblAC.Size = new System.Drawing.Size(31, 20);
            lblAC.TabIndex = 2;
            lblAC.Text = "AC";
            // 
            // numHealth
            // 
            numHealth.Location = new System.Drawing.Point(86, 43);
            numHealth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numHealth.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numHealth.Name = "numHealth";
            numHealth.Size = new System.Drawing.Size(140, 23);
            numHealth.TabIndex = 2;
            numHealth.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // numAC
            // 
            numAC.Location = new System.Drawing.Point(86, 74);
            numAC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numAC.Name = "numAC";
            numAC.Size = new System.Drawing.Size(140, 23);
            numAC.TabIndex = 3;
            numAC.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(86, 10);
            txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(139, 23);
            txtName.TabIndex = 1;
            txtName.Text = "Char";
            // 
            // btnDone
            // 
            btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDone.Location = new System.Drawing.Point(86, 134);
            btnDone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDone.Name = "btnDone";
            btnDone.Size = new System.Drawing.Size(140, 45);
            btnDone.TabIndex = 5;
            btnDone.Text = "Finish";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // numInit
            // 
            numInit.Location = new System.Drawing.Point(86, 104);
            numInit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numInit.Name = "numInit";
            numInit.Size = new System.Drawing.Size(140, 23);
            numInit.TabIndex = 4;
            numInit.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblInit
            // 
            lblInit.AutoSize = true;
            lblInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblInit.Location = new System.Drawing.Point(14, 105);
            lblInit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInit.Name = "lblInit";
            lblInit.Size = new System.Drawing.Size(31, 20);
            lblInit.TabIndex = 5;
            lblInit.Text = "Init";
            // 
            // addChar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(246, 193);
            ControlBox = false;
            Controls.Add(numInit);
            Controls.Add(lblInit);
            Controls.Add(btnDone);
            Controls.Add(txtName);
            Controls.Add(numAC);
            Controls.Add(numHealth);
            Controls.Add(lblAC);
            Controls.Add(lblHealth);
            Controls.Add(lblName);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "addChar";
            Text = "Character";
            Load += addChar_Load;
            ((System.ComponentModel.ISupportInitialize)numHealth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAC).EndInit();
            ((System.ComponentModel.ISupportInitialize)numInit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblAC;
        private System.Windows.Forms.NumericUpDown numHealth;
        private System.Windows.Forms.NumericUpDown numAC;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.NumericUpDown numInit;
        private System.Windows.Forms.Label lblInit;
    }
}