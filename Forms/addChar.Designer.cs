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
            this.lblName = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblAC = new System.Windows.Forms.Label();
            this.numHealth = new System.Windows.Forms.NumericUpDown();
            this.numAC = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.Location = new System.Drawing.Point(12, 37);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(56, 20);
            this.lblHealth.TabIndex = 1;
            this.lblHealth.Text = "Health";
            // 
            // lblAC
            // 
            this.lblAC.AutoSize = true;
            this.lblAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAC.Location = new System.Drawing.Point(12, 65);
            this.lblAC.Name = "lblAC";
            this.lblAC.Size = new System.Drawing.Size(31, 20);
            this.lblAC.TabIndex = 2;
            this.lblAC.Text = "AC";
            // 
            // numHealth
            // 
            this.numHealth.Location = new System.Drawing.Point(74, 37);
            this.numHealth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numHealth.Name = "numHealth";
            this.numHealth.Size = new System.Drawing.Size(120, 20);
            this.numHealth.TabIndex = 2;
            this.numHealth.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numAC
            // 
            this.numAC.Location = new System.Drawing.Point(74, 64);
            this.numAC.Name = "numAC";
            this.numAC.Size = new System.Drawing.Size(120, 20);
            this.numAC.TabIndex = 3;
            this.numAC.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Char";
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(74, 90);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(120, 39);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Finish";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // addChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 141);
            this.ControlBox = false;
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.numAC);
            this.Controls.Add(this.numHealth);
            this.Controls.Add(this.lblAC);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblName);
            this.Name = "addChar";
            this.Text = "Character";
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblAC;
        private System.Windows.Forms.NumericUpDown numHealth;
        private System.Windows.Forms.NumericUpDown numAC;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDone;
    }
}