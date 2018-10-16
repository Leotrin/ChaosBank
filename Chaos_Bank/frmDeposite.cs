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
    public partial class frmDeposite : Form
    {
        String conn = @"Data Source=LEOTRIN-PC\SQLSERVER2008;Initial Catalog=Chaos_Bank;User ID=sa;Password=plus66extream";
        int id;

        public frmDeposite()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ID,Emri,Mbiemri from tblKlient where Nr_Ame='" + this.textBox1.Text + "'", con);
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
            con.Close();
        }

        private void dgClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Int32.Parse(this.dgClient.CurrentRow.Cells[0].Value.ToString());
            this.txtID.Text = id.ToString();
            this.txtName.Text = this.dgClient.CurrentRow.Cells[1].Value.ToString();
            this.txtLName.Text = this.dgClient.CurrentRow.Cells[2].Value.ToString();

            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Distinct B.ID,B.Bank from tblBank as B, tblKlient as K, tblAkaunt as A where A.IDKlient=" + id + " and B.ID=A.IDBank", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            this.cmbBankName.DataSource = dt;
            this.cmbBankName.DisplayMember = "Bank";
            this.cmbBankNr.DataSource = dt;
            this.cmbBankNr.DisplayMember = "ID";
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtAmount.Text == "")
            {
                MessageBox.Show("Pleas fill the Amount field !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int banknr = Int32.Parse(this.cmbBankNr.Text);
                SqlConnection con = new SqlConnection(conn);

                con.Open();

                SqlTransaction tr = con.BeginTransaction();

                try
                {


                    String update = "Update tblAkaunt set Vlera=Vlera+" + Int32.Parse(this.txtAmount.Text) + " Where IDKlient=" + id + " and IDBank=" + Int32.Parse(this.cmbBankNr.Text) ;
                    SqlCommand cmd = new SqlCommand(update, con, tr);
                    cmd.ExecuteNonQuery();

                    String update1 = "Insert into tblSherbimi (IDKlient, Sherbimi, Data, Vlera, IDBank) values(" + Int32.Parse(this.txtID.Text) + " , 'Deposite' , @data , " + Int32.Parse(this.txtAmount.Text) + ", " + Int32.Parse(this.cmbBankNr.Text) + ")";
                    SqlCommand cmd1 = new SqlCommand(update1, con, tr);
                    SqlParameter parameterData = new SqlParameter("@data", SqlDbType.Date);
                    parameterData.Value = DateTime.Now.ToShortDateString();
                    cmd1.Parameters.Add(parameterData);



                   

                    cmd1.ExecuteNonQuery();


                    tr.Commit();

                }
                catch (SqlException ex)
                {
                    tr.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MessageBox.Show("Deposite registered sucssefuly!", "Information");
                    con.Close();

                    this.txtID.Text = "";
                    this.txtLName.Text = "";
                    this.txtName.Text = "";
                    this.cmbBankNr.Text = "";
                    this.cmbBankName.Text = "";
                    this.txtAmount.Text = "";
                    this.textBox1.Text = "";

                    con.Open();
                    SqlCommand cm = new SqlCommand("Select K.ID, K.Emri, K.Mbiemri, K.Adresa, B.Bank, A.Vlera from tblAkaunt as A, tblBank as B, tblKlient as K Where A.IDKlient=K.ID and A.IDBank=B.ID and A.IDKlient=" + id + " and A.IDBank = " + banknr, con);
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
                    con.Close();
                }
            }
        }
    }
}
