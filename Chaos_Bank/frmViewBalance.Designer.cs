namespace Chaos_Bank
{
    partial class frmViewBalance
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
            this.cmbAmount = new System.Windows.Forms.ComboBox();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNrAme = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAmount
            // 
            this.cmbAmount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbAmount.FormattingEnabled = true;
            this.cmbAmount.Location = new System.Drawing.Point(247, 70);
            this.cmbAmount.Name = "cmbAmount";
            this.cmbAmount.Size = new System.Drawing.Size(189, 21);
            this.cmbAmount.TabIndex = 11;
            // 
            // cmbBank
            // 
            this.cmbBank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBank.Location = new System.Drawing.Point(247, 31);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(189, 21);
            this.cmbBank.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Amount :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Banka :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNrAme);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 79);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nr. Ame";
            // 
            // txtNrAme
            // 
            this.txtNrAme.Location = new System.Drawing.Point(6, 19);
            this.txtNrAme.Name = "txtNrAme";
            this.txtNrAme.Size = new System.Drawing.Size(188, 20);
            this.txtNrAme.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "View Balance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmViewBalance
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(462, 105);
            this.Controls.Add(this.cmbAmount);
            this.Controls.Add(this.cmbBank);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewBalance";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "View Balance";
            this.Load += new System.EventHandler(this.frmViewBalance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAmount;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNrAme;
        private System.Windows.Forms.Button button1;
    }
}