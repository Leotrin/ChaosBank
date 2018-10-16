using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Chaos_Bank
{
    public partial class frmViewBalance : Form
    {
        String con = @"Data Source=LEOTRIN-PC\SQLSERVER2008;Initial Catalog=Chaos_Bank;User ID=sa;Password=plus66extream";
       
        public frmViewBalance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select K.ID, B.Bank, A.Vlera from tblAkaunt as A, tblKlient as K, tblBank as B where A.IDKlient=K.ID and A.IDBank=B.ID and K.Nr_Ame='" + this.txtNrAme.Text + "' ", conn);
           
            DataTable dt = new DataTable();
            da.Fill(dt);

            this.cmbBank.DataSource = dt;
            this.cmbBank.DisplayMember = "Bank";
            this.cmbAmount.DataSource = dt;
            this.cmbAmount.DisplayMember = "Vlera";
            conn.Close();
        }

        private void frmViewBalance_Load(object sender, EventArgs e)
        {
            this.txtNrAme.Focus();
        }
    }
}
