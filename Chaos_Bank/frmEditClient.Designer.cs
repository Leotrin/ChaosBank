namespace Chaos_Bank
{
    partial class frmEditClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditClient));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNrAme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgClient = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbQyteti = new System.Windows.Forms.ComboBox();
            this.cmbGjinia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbQyteti);
            this.groupBox2.Controls.Add(this.cmbGjinia);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNrAme);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtLName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 324);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search for :";
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(136, 265);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(58, 45);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nr. Ame :";
            // 
            // txtNrAme
            // 
            this.txtNrAme.Location = new System.Drawing.Point(6, 239);
            this.txtNrAme.Name = "txtNrAme";
            this.txtNrAme.Size = new System.Drawing.Size(188, 20);
            this.txtNrAme.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Address :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(6, 162);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(188, 20);
            this.txtAddress.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name :";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(6, 83);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(188, 20);
            this.txtLName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 20);
            this.txtName.TabIndex = 8;
            // 
            // dgClient
            // 
            this.dgClient.AllowUserToAddRows = false;
            this.dgClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClient.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClient.GridColor = System.Drawing.Color.LightSlateGray;
            this.dgClient.Location = new System.Drawing.Point(218, 12);
            this.dgClient.Name = "dgClient";
            this.dgClient.Size = new System.Drawing.Size(632, 382);
            this.dgClient.TabIndex = 5;
            this.dgClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClient_CellContentClick);
            this.dgClient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClient_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 52);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "City";
            // 
            // cmbQyteti
            // 
            this.cmbQyteti.FormattingEnabled = true;
            this.cmbQyteti.Items.AddRange(new object[] {
            "Shkup",
            "Tetov",
            "Gostivar",
            "Kercov",
            "Struge",
            "Kumanove",
            "Diber",
            "Oher",
            "Manastir",
            "Presp",
            "Veles",
            "Shtip",
            "Strumic"});
            this.cmbQyteti.Location = new System.Drawing.Point(6, 201);
            this.cmbQyteti.Name = "cmbQyteti";
            this.cmbQyteti.Size = new System.Drawing.Size(188, 21);
            this.cmbQyteti.TabIndex = 20;
            // 
            // cmbGjinia
            // 
            this.cmbGjinia.FormattingEnabled = true;
            this.cmbGjinia.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbGjinia.Location = new System.Drawing.Point(6, 122);
            this.cmbGjinia.Name = "cmbGjinia";
            this.cmbGjinia.Size = new System.Drawing.Size(188, 21);
            this.cmbGjinia.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Gender :";
            // 
            // frmEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 406);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgClient);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditClient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Client";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNrAme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbQyteti;
        private System.Windows.Forms.ComboBox cmbGjinia;
    }
}