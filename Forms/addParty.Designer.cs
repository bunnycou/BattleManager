namespace BattleManager.Forms
{
    partial class AddParty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddParty));
            lblPartyName = new System.Windows.Forms.Label();
            txtPartyName = new System.Windows.Forms.TextBox();
            tblParty = new System.Windows.Forms.TableLayoutPanel();
            lblPartyCount = new System.Windows.Forms.Label();
            numCount = new System.Windows.Forms.NumericUpDown();
            btnDone = new System.Windows.Forms.Button();
            tblParty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCount).BeginInit();
            SuspendLayout();
            // 
            // lblPartyName
            // 
            lblPartyName.AutoSize = true;
            lblPartyName.Dock = System.Windows.Forms.DockStyle.Fill;
            lblPartyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPartyName.Location = new System.Drawing.Point(3, 0);
            lblPartyName.Name = "lblPartyName";
            lblPartyName.Size = new System.Drawing.Size(102, 45);
            lblPartyName.TabIndex = 0;
            lblPartyName.Text = "Party Name";
            lblPartyName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPartyName
            // 
            txtPartyName.Dock = System.Windows.Forms.DockStyle.Fill;
            txtPartyName.Location = new System.Drawing.Point(111, 3);
            txtPartyName.Name = "txtPartyName";
            txtPartyName.Size = new System.Drawing.Size(296, 23);
            txtPartyName.TabIndex = 1;
            txtPartyName.Text = "Party";
            // 
            // tblParty
            // 
            tblParty.ColumnCount = 2;
            tblParty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.3414631F));
            tblParty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.65854F));
            tblParty.Controls.Add(lblPartyName, 0, 0);
            tblParty.Controls.Add(txtPartyName, 1, 0);
            tblParty.Controls.Add(lblPartyCount, 0, 1);
            tblParty.Controls.Add(numCount, 1, 1);
            tblParty.Location = new System.Drawing.Point(12, 12);
            tblParty.Name = "tblParty";
            tblParty.RowCount = 2;
            tblParty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tblParty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tblParty.Size = new System.Drawing.Size(410, 91);
            tblParty.TabIndex = 2;
            // 
            // lblPartyCount
            // 
            lblPartyCount.AutoSize = true;
            lblPartyCount.Dock = System.Windows.Forms.DockStyle.Fill;
            lblPartyCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPartyCount.Location = new System.Drawing.Point(3, 45);
            lblPartyCount.Name = "lblPartyCount";
            lblPartyCount.Size = new System.Drawing.Size(102, 46);
            lblPartyCount.TabIndex = 2;
            lblPartyCount.Text = "Party Count";
            lblPartyCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numCount
            // 
            numCount.Dock = System.Windows.Forms.DockStyle.Left;
            numCount.Location = new System.Drawing.Point(111, 48);
            numCount.Name = "numCount";
            numCount.Size = new System.Drawing.Size(100, 23);
            numCount.TabIndex = 2;
            numCount.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // btnDone
            // 
            btnDone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDone.Location = new System.Drawing.Point(175, 109);
            btnDone.Name = "btnDone";
            btnDone.Size = new System.Drawing.Size(75, 55);
            btnDone.TabIndex = 3;
            btnDone.Text = "Create Party";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += BtnDone_Click;
            // 
            // AddParty
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(434, 176);
            Controls.Add(btnDone);
            Controls.Add(tblParty);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "AddParty";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "New Party";
            Load += AddParty_Load;
            tblParty.ResumeLayout(false);
            tblParty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblPartyName;
        private System.Windows.Forms.TextBox txtPartyName;
        private System.Windows.Forms.TableLayoutPanel tblParty;
        private System.Windows.Forms.Label lblPartyCount;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Button btnDone;
    }
}