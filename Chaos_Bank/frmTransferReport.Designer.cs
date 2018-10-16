namespace Chaos_Bank
{
    partial class frmTransferReport
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
            this.dgDeposite = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDeposite)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgDeposite
            // 
            this.dgDeposite.AllowUserToAddRows = false;
            this.dgDeposite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDeposite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDeposite.Location = new System.Drawing.Point(12, 74);
            this.dgDeposite.Name = "dgDeposite";
            this.dgDeposite.Size = new System.Drawing.Size(572, 294);
            this.dgDeposite.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtData);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 56);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(11, 23);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(107, 20);
            this.dtData.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTransferReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(595, 379);
            this.Controls.Add(this.dgDeposite);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransferReport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Transfer Report";
            ((System.ComponentModel.ISupportInitialize)(this.dgDeposite)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDeposite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Button button1;
    }
}