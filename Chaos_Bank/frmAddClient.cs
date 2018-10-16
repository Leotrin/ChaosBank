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
    public partial class frmAddClient : Form
    {

        String con = @"Data Source=LEOTRIN-PC\SQLSERVER2008;Initial Catalog=Chaos_Bank;User ID=sa;Password=plus66extream";
        String gjinia;

        public frmAddClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.cmbGjinia.Text == "Female")
            {
                gjinia = "F";
            }
            else if (this.cmbGjinia.Text == "Male")
            {
                gjinia = "M";
            }

            if (this.txtName.Text == "")
            {
                MessageBox.Show("Please fill the Name field !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtLName.Text == "")
            {
                MessageBox.Show("Please fill the LName field !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtAddress.Text == "")
            {
                MessageBox.Show("Please fill the Address field !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtNrAme.Text == "")
            {
                MessageBox.Show("Please fill the Nr.Ame field !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.cmbGjinia.Text == "")
            {
                MessageBox.Show("Please choose Gender !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(this.cmbQyteti.Text == "")
            {
                 MessageBox.Show("Please choose the City !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection(con);

                conn.Open();
                String selekt = "Select * from tblKlient where Nr_Ame='" + this.txtNrAme.Text + "'";
                SqlCommand cmd = new SqlCommand(selekt, conn);
                SqlDataReader rd = cmd.ExecuteReader();


                if (rd.Read() == true)
                {
                    rd.Close();
                    conn.Close();
                    MessageBox.Show("This client already excist in the database !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    rd.Close();
                    conn.Close();
                    try
                    {

                        conn.Open();
                        String add = "Insert Into tblKlient(Emri, Mbiemri, Gjinia, Adresa, Qyteti, Nr_Ame) values('" + this.txtName.Text + "', '" + this.txtLName.Text + "', '" + gjinia + "', '" + this.txtAddress.Text + "', '" + this.cmbQyteti.Text + "', '" + this.txtNrAme.Text + "')";
                        SqlCommand cmdd = new SqlCommand(add, conn);
                        cmdd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (SqlException)
                    {
                    }
                    finally
                    {
                        MessageBox.Show("Client registered sucssefuly !", "Info", MessageBoxButtons.OK);
                        this.txtName.Text = "";
                        this.txtLName.Text = "";
                        this.txtAddress.Text = "";
                        this.txtNrAme.Text = "";
                        this.cmbQyteti.Text = "";
                        this.cmbGjinia.Text = "";
                        conn.Open();
                        SqlCommand coman = new SqlCommand("Select * from tblKlient", conn);
                        try
                        {

                            SqlDataAdapter adp = new SqlDataAdapter();
                            DataSet ds = new DataSet();
                            DataView dv = new DataView();

                            adp.SelectCommand = coman;
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
                }
            }
        }
    }
}
