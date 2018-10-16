using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chaos_Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Pleas fill the username field !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Text = "";
                this.textBox1.Focus();
            }
            else if (this.textBox2.Text == "")
            {
                MessageBox.Show("Pleas fill the password field !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox2.Text = "";
                this.textBox2.Focus();
            }
            else if (this.textBox1.Text == "chaos" && this.textBox2.Text == "bank")
            {
                this.toolStrip1.Visible = true;
                this.menuStrip1.Visible = true;
                this.WindowState = FormWindowState.Maximized;
                this.panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Pleas use a valid username or password !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox1.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.panel1.Visible == true)
            {
                this.menuStrip1.Visible = false;
                this.toolStrip1.Visible = false;
            }
            else if (this.panel1.Visible == false)
            {
                this.toolStrip1.Visible = true;
                this.menuStrip1.Visible = true;
                this.panel1.Visible = false;
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.WindowState = FormWindowState.Normal;
            this.menuStrip1.Visible = false;
            this.toolStrip1.Visible = false;
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddClient f = new frmAddClient();
            f.MdiParent = this;
            f.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditClient f = new frmEditClient();
            f.MdiParent = this;
            f.Show();
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            aDDToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            editToolStripMenuItem_Click(sender, e);
        }

        private void viewBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewBalance f = new frmViewBalance();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            viewBalanceToolStripMenuItem_Click(sender, e);
        }

        private void addBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddBank f = new frmAddBank();
            f.MdiParent = this;
            f.Show();
        }

        private void addClientToBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddClientToBank f = new frmAddClientToBank();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            addBankToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            addClientToBankToolStripMenuItem_Click(sender, e);
        }

        private void depositeToClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeposite f = new frmDeposite();
            f.MdiParent = this;
            f.Show();
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWithdraw f = new frmWithdraw();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            depositeToClientToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            withdrawToolStripMenuItem_Click(sender, e);
        }

        private void transferBetweenClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransfers f = new frmTransfers();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            transferBetweenClientsToolStripMenuItem_Click(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.MdiParent = this;
            f.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you need any help in using this software pleas contact us at : info@vldtech.info", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton7_Click(sender, e);
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            helpToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            aboutToolStripMenuItem_Click(sender, e);
        }

        private void depositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepositeReport f = new frmDepositeReport();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            depositeToolStripMenuItem_Click(sender, e);
        }

        private void withdrawToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmWithdrawReport f = new frmWithdrawReport();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            withdrawToolStripMenuItem1_Click(sender, e);
        }

        private void transfersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransferReport f = new frmTransferReport();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            transfersToolStripMenuItem_Click(sender, e);
        }

    }
}
