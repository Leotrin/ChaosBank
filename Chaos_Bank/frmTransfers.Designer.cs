namespace Chaos_Bank
{
    partial class frmTransfers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransfers));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.cmbBanka = new System.Windows.Forms.ComboBox();
            this.cmbBankNr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbBanka2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBankNr2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgClients = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbNrKlientitFrom = new System.Windows.Forms.ComboBox();
            this.cmbNrKlientit2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBanka);
            this.groupBox1.Controls.Add(this.txtFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBankNr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From (Nr.Ame) :";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(6, 19);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(188, 20);
            this.txtFrom.TabIndex = 1;
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbBanka2);
            this.groupBox2.Controls.Add(this.cmbBankNr2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 49);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To (Nr.Ame) :";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(6, 19);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(188, 20);
            this.txtTo.TabIndex = 1;
            this.txtTo.TextChanged += new System.EventHandler(this.txtTo_TextChanged);
            // 
            // cmbBanka
            // 
            this.cmbBanka.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBanka.FormattingEnabled = true;
            this.cmbBanka.Location = new System.Drawing.Point(373, 18);
            this.cmbBanka.Name = "cmbBanka";
            this.cmbBanka.Size = new System.Drawing.Size(114, 21);
            this.cmbBanka.TabIndex = 15;
            // 
            // cmbBankNr
            // 
            this.cmbBankNr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBankNr.Location = new System.Drawing.Point(283, 18);
            this.cmbBankNr.Name = "cmbBankNr";
            this.cmbBankNr.Size = new System.Drawing.Size(40, 21);
            this.cmbBankNr.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bank :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Banka ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Amount :";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(61, 19);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(154, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // cmbBanka2
            // 
            this.cmbBanka2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBanka2.FormattingEnabled = true;
            this.cmbBanka2.Location = new System.Drawing.Point(373, 18);
            this.cmbBanka2.Name = "cmbBanka2";
            this.cmbBanka2.Size = new System.Drawing.Size(114, 21);
            this.cmbBanka2.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Bank :";
            // 
            // cmbBankNr2
            // 
            this.cmbBankNr2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBankNr2.Location = new System.Drawing.Point(283, 18);
            this.cmbBankNr2.Name = "cmbBankNr2";
            this.cmbBankNr2.Size = new System.Drawing.Size(40, 21);
            this.cmbBankNr2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Banka ID :";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(61, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Transfer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgClients
            // 
            this.dgClients.AllowUserToAddRows = false;
            this.dgClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClients.Location = new System.Drawing.Point(12, 122);
            this.dgClients.Name = "dgClients";
            this.dgClients.Size = new System.Drawing.Size(735, 262);
            this.dgClients.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbNrKlientit2);
            this.groupBox3.Controls.Add(this.cmbNrKlientitFrom);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(527, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 104);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // cmbNrKlientitFrom
            // 
            this.cmbNrKlientitFrom.FormattingEnabled = true;
            this.cmbNrKlientitFrom.Location = new System.Drawing.Point(9, 46);
            this.cmbNrKlientitFrom.Name = "cmbNrKlientitFrom";
            this.cmbNrKlientitFrom.Size = new System.Drawing.Size(26, 21);
            this.cmbNrKlientitFrom.TabIndex = 17;
            this.cmbNrKlientitFrom.Visible = false;
            // 
            // cmbNrKlientit2
            // 
            this.cmbNrKlientit2.FormattingEnabled = true;
            this.cmbNrKlientit2.Location = new System.Drawing.Point(9, 73);
            this.cmbNrKlientit2.Name = "cmbNrKlientit2";
            this.cmbNrKlientit2.Size = new System.Drawing.Size(26, 21);
            this.cmbNrKlientit2.TabIndex = 18;
            this.cmbNrKlientit2.Visible = false;
            // 
            // frmTransfers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 396);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgClients);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransfers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Transfers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.ComboBox cmbBanka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBankNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBanka2;
        private System.Windows.Forms.ComboBox cmbBankNr2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgClients;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbNrKlientitFrom;
        private System.Windows.Forms.ComboBox cmbNrKlientit2;
    }
}