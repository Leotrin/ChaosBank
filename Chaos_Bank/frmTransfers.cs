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
    public partial class frmTransfers : Form
    {
        String conn = @"Data Source=LEOTRIN-PC\SQLSERVER2008;Initial Catalog=Chaos_Bank;User ID=sa;Password=plus66extream";
       
        public frmTransfers()
        {
            InitializeComponent();
        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select Distinct K.ID as Klienti, B.ID, B.Bank, A.Vlera from tblAkaunt as A, tblKlient as K, tblBank as B where A.IDKlient=K.ID and A.IDBank=B.ID and K.Nr_Ame='" + this.txtFrom.Text + "' ", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            this.cmbBankNr.DataSource = dt;
            this.cmbBankNr.DisplayMember = "ID";
            this.cmbBanka.DataSource = dt;
            this.cmbBanka.DisplayMember = "Bank";
            this.cmbNrKlientitFrom.DataSource = dt;
            this.cmbNrKlientitFrom.DisplayMember = "Klienti";
            con.Close();
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select Distinct K.ID as Klienti, B.ID, B.Bank, A.Vlera from tblAkaunt as A, tblKlient as K, tblBank as B where A.IDKlient=K.ID and A.IDBank=B.ID and K.Nr_Ame='" + this.txtTo.Text + "' ", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            this.cmbBankNr2.DataSource = dt;
            this.cmbBankNr2.DisplayMember = "ID";
            this.cmbBanka2.DataSource = dt;
            this.cmbBanka2.DisplayMember = "Bank";
            this.cmbNrKlientit2.DataSource = dt;
            this.cmbNrKlientit2.DisplayMember = "Klienti";
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

                SqlConnection con = new SqlConnection(conn);

                con.Open();

                SqlTransaction tr = con.BeginTransaction();
                try
                {


                    String update = "Update tblAkaunt set Vlera=Vlera-" + Int32.Parse(this.txtAmount.Text) + " Where IDKlient=" + Int32.Parse(this.cmbNrKlientitFrom.Text) + " and IDBank=" + Int32.Parse(this.cmbBankNr.Text);
                    SqlCommand cmd = new SqlCommand(update, con, tr);
                    cmd.ExecuteNonQuery();

                    String update1 = "Insert into tblSherbimi (IDKlient, Sherbimi, Data, Vlera, IDBank) values(" + Int32.Parse(this.cmbNrKlientitFrom.Text) + " , 'Transfer Withdraw' , @data , " + Int32.Parse(this.txtAmount.Text) + ", " + Int32.Parse(this.cmbBankNr.Text) + ")";
                    SqlCommand cmd1 = new SqlCommand(update1, con, tr);
                    SqlParameter parameterData = new SqlParameter("@data", SqlDbType.Date);
                    parameterData.Value = DateTime.Now.ToShortDateString();
                    cmd1.Parameters.Add(parameterData);
                    cmd1.ExecuteNonQuery();

                    String update2 = "Update tblAkaunt set Vlera=Vlera+" + Int32.Parse(this.txtAmount.Text) + " Where IDKlient=" + Int32.Parse(this.cmbNrKlientit2.Text) + " and IDBank=" + Int32.Parse(this.cmbBankNr2.Text);
                    SqlCommand cmd2 = new SqlCommand(update2, con, tr);
                    cmd2.ExecuteNonQuery();

                    String update3 = "Insert into tblSherbimi (IDKlient, Sherbimi, Data, Vlera, IDBank) values(" + Int32.Parse(this.cmbNrKlientit2.Text) + " , 'Transfer Deposite' , @data , " + Int32.Parse(this.txtAmount.Text) + ", " + Int32.Parse(this.cmbBankNr2.Text) + ")";
                    SqlCommand cmd3 = new SqlCommand(update3, con, tr);
                    SqlParameter parameterData1 = new SqlParameter("@data", SqlDbType.Date);
                    parameterData1.Value = DateTime.Now.ToShortDateString();
                    cmd3.Parameters.Add(parameterData1);
                    cmd3.ExecuteNonQuery();


                    tr.Commit();

                }
                catch (SqlException ex)
                {
                    tr.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MessageBox.Show("Transaction completed !", "Information");
                    con.Close();

                    con.Open();
                    SqlCommand cm = new SqlCommand("Select Distinct K.ID, K.Emri, K.Mbiemri, K.Adresa, B.Bank, A.Vlera from tblAkaunt as A, tblBank as B, tblKlient as K Where A.IDKlient=K.ID and A.IDBank=B.ID and (A.IDKlient=" + Int32.Parse(this.cmbNrKlientitFrom.Text) + " or A.IDKlient=" + Int32.Parse(this.cmbNrKlientit2.Text) + ") and (A.IDBank = " + Int32.Parse(this.cmbBankNr.Text) + " or A.IDBank=" + Int32.Parse(this.cmbBankNr2.Text) + ")", con);
                    try
                    {

                        SqlDataAdapter adp = new SqlDataAdapter();
                        DataSet ds = new DataSet();
                        DataView dv = new DataView();

                        adp.SelectCommand = cm;
                        adp.Fill(ds, "dataset");
                        dv.Table = ds.Tables[0];
                        dv.Sort = "id desc";
                        dgClients.DataSource = dv;
                        dgClients.Refresh();
                    }
                    catch (SqlException)
                    {

                    }
                    con.Close();
                    this.txtFrom.Text = "";
                    this.txtTo.Text = "";
                    this.txtAmount.Text = "";
                    this.cmbBankNr.Text = "";
                    this.cmbBanka2.Text = "";
                    this.cmbBanka.Text = "";
                    this.cmbBanka2.Text = "";
                }
            }
        }
    }
}
