namespace Chaos_Bank
{
    partial class frmAddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddClient));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGjinia = new System.Windows.Forms.ComboBox();
            this.dgClient = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNrAme = new System.Windows.Forms.TextBox();
            this.cmbQyteti = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbQyteti);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNrAme);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbGjinia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 259);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add User Information";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(199, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 49);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "City :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(94, 108);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(160, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name :";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(94, 55);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(160, 20);
            this.txtLName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 20);
            this.txtName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender :";
            // 
            // cmbGjinia
            // 
            this.cmbGjinia.FormattingEnabled = true;
            this.cmbGjinia.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbGjinia.Location = new System.Drawing.Point(94, 81);
            this.cmbGjinia.Name = "cmbGjinia";
            this.cmbGjinia.Size = new System.Drawing.Size(160, 21);
            this.cmbGjinia.TabIndex = 2;
            // 
            // dgClient
            // 
            this.dgClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClient.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClient.Location = new System.Drawing.Point(278, 21);
            this.dgClient.Name = "dgClient";
            this.dgClient.Size = new System.Drawing.Size(535, 254);
            this.dgClient.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nr. Ame :";
            // 
            // txtNrAme
            // 
            this.txtNrAme.Location = new System.Drawing.Point(94, 160);
            this.txtNrAme.Name = "txtNrAme";
            this.txtNrAme.Size = new System.Drawing.Size(160, 20);
            this.txtNrAme.TabIndex = 5;
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
            this.cmbQyteti.Location = new System.Drawing.Point(94, 134);
            this.cmbQyteti.Name = "cmbQyteti";
            this.cmbQyteti.Size = new System.Drawing.Size(160, 21);
            this.cmbQyteti.TabIndex = 4;
            // 
            // frmAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(825, 287);
            this.Controls.Add(this.dgClient);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddClient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Cient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbGjinia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgClient;
        private System.Windows.Forms.ComboBox cmbQyteti;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNrAme;
    }
}