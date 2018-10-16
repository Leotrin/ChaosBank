namespace Chaos_Bank
{
    partial class frmWithdraw
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
            this.dgClientBank = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbBankNr = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBankName = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgClient = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientBank)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgClientBank
            // 
            this.dgClientBank.AllowUserToAddRows = false;
            this.dgClientBank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClientBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientBank.Location = new System.Drawing.Point(13, 176);
            this.dgClientBank.Name = "dgClientBank";
            this.dgClientBank.Size = new System.Drawing.Size(658, 265);
            this.dgClientBank.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbBankNr);
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbBankName);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.txtLName);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(259, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 160);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // cmbBankNr
            // 
            this.cmbBankNr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBankNr.FormattingEnabled = true;
            this.cmbBankNr.Location = new System.Drawing.Point(272, 94);
            this.cmbBankNr.Name = "cmbBankNr";
            this.cmbBankNr.Size = new System.Drawing.Size(54, 21);
            this.cmbBankNr.TabIndex = 5;
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Location = new System.Drawing.Point(79, 121);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(131, 20);
            this.txtAmount.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Amount :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Withdraw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Bank :";
            // 
            // cmbBankName
            // 
            this.cmbBankName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBankName.Location = new System.Drawing.Point(79, 94);
            this.cmbBankName.Name = "cmbBankName";
            this.cmbBankName.Size = new System.Drawing.Size(187, 21);
            this.cmbBankName.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(79, 16);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(95, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(79, 68);
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.Size = new System.Drawing.Size(131, 20);
            this.txtLName.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 42);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(131, 20);
            this.txtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // dgClient
            // 
            this.dgClient.AllowUserToAddRows = false;
            this.dgClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClient.Location = new System.Drawing.Point(13, 68);
            this.dgClient.Name = "dgClient";
            this.dgClient.Size = new System.Drawing.Size(240, 102);
            this.dgClient.TabIndex = 11;
            this.dgClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClient_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 52);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for Client type Nr. Ame :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.dgClientBank);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgClient);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWithdraw";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Withdraw";
            ((System.ComponentModel.ISupportInitialize)(this.dgClientBank)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClientBank;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbBankNr;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBankName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}