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
    public partial class frmAddClientToBank : Form
    {
        String con = @"Data Source=LEOTRIN-PC\SQLSERVER2008;Initial Catalog=Chaos_Bank;User ID=sa;Password=plus66extream";
        int id = -1;

        public frmAddClientToBank()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select ID,Emri,Mbiemri from tblKlient where Nr_Ame='" + this.textBox1.Text + "'", conn);
            try
            {

                SqlDataAdapter adp = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                adp.SelectCommand = cmd;
                adp.Fill(ds, "dataset");
                dv.Table = ds.Tables[0];
                dv.Sort = "id desc";
                dgClient.DataSource = dv;
                dgClient.Refresh();
            }
            catch (SqlException)
            {

            }
            conn.Close();
        }

        private void dgClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Int32.Parse(this.dgClient.CurrentRow.Cells[0].Value.ToString());
            this.txtID.Text = id.ToString();
            this.txtName.Text = this.dgClient.CurrentRow.Cells[1].Value.ToString();
            this.txtLName.Text = this.dgClient.CurrentRow.Cells[2].Value.ToString();
        }

        private void frmAddClientToBank_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblBank", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            this.cmbBankName.DataSource = dt;
            this.cmbBankName.DisplayMember = "Bank";
            this.cmbBankNr.DataSource = dt;
            this.cmbBankNr.DisplayMember = "ID";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal amount = 0;

            if (this.txtAmount.Text == "")
            {
                MessageBox.Show("Pleas fill the Amount field !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                amount = Int32.Parse(this.txtAmount.Text);

                SqlConnection conn = new SqlConnection(con);

                conn.Open();
                String selekt = "Select * from tblAkaunt where IDKlient=" + this.txtID.Text + " and IDBank=" + this.cmbBankNr.Text;
                SqlCommand cmd = new SqlCommand(selekt, conn);
                SqlDataReader rd = cmd.ExecuteReader();


                if (rd.Read() == true)
                {
                    rd.Close();
                    conn.Close();
                    MessageBox.Show("This client already have an acount in this bank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    rd.Close();
                    conn.Close();

                    conn.Open();
                    try
                    {
                        SqlCommand cm = new SqlCommand("Insert into tblAkaunt(IDKlient,IDBank,Vlera) values(" + Int32.Parse(this.txtID.Text) + ", " + Int32.Parse(this.cmbBankNr.Text) + ", " + amount + ")", conn);
                        cm.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        this.txtID.Text = "";
                        this.txtName.Text = "";
                        this.txtLName.Text = "";
                        this.txtAmount.Text = "";

                        conn.Open();
                        SqlCommand cm = new SqlCommand("Select K.ID, K.Emri, K.Mbiemri, K.Adresa, B.Bank, A.Vlera from tblAkaunt as A, tblBank as B, tblKlient as K Where A.IDKlient=K.ID and A.IDBank=B.ID" , conn);
                        try
                        {

                            SqlDataAdapter adp = new SqlDataAdapter();
                            DataSet ds = new DataSet();
                            DataView dv = new DataView();

                            adp.SelectCommand = cm;
                            adp.Fill(ds, "dataset");
                            dv.Table = ds.Tables[0];
                            dv.Sort = "id desc";
                            dgClientBank.DataSource = dv;
                            dgClientBank.Refresh();
                        }
                        catch (SqlException)
                        {

                        }
                        conn.Close();
                    }
                }
            }
        }

        private void dgClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
