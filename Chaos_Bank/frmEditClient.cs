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
    public partial class frmEditClient : Form
    {

        String con = @"Data Source=LEOTRIN-PC\SQLSERVER2008;Initial Catalog=Chaos_Bank;User ID=sa;Password=plus66extream";
        int id = -1;
        String gjinia;

        public frmEditClient()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select ID,Emri,Mbiemri, Gjinia, Adresa, Qyteti, Nr_Ame from tblKlient where Emri Like '" + this.textBox1.Text + "%'", conn);
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

        private void dgClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Int32.Parse(this.dgClient.CurrentRow.Cells[0].Value.ToString());
            this.txtName.Text = this.dgClient.CurrentRow.Cells[1].Value.ToString();
            this.txtLName.Text = this.dgClient.CurrentRow.Cells[2].Value.ToString();
            this.cmbGjinia.Text = this.dgClient.CurrentRow.Cells[3].Value.ToString();
            this.txtAddress.Text = this.dgClient.CurrentRow.Cells[4].Value.ToString();
            this.cmbQyteti.Text = this.dgClient.CurrentRow.Cells[5].Value.ToString();
            this.txtNrAme.Text = this.dgClient.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
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
            else if (this.cmbQyteti.Text == "")
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

                    conn.Open();
                    try
                    {
                        SqlCommand cm = new SqlCommand("Update tblKlient set Emri='" + this.txtName.Text + "', Mbiemri='" + this.txtLName.Text + "', Gjinia='" + gjinia + "', Adresa='" + this.txtAddress.Text + "', Qyteti='" + this.cmbQyteti.Text + "', Nr_Ame='" + this.txtNrAme.Text + "' where ID=" + id, conn);
                        cm.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        textBox1_TextChanged(sender, e);
                        this.txtName.Text = "";
                        this.txtLName.Text = "";
                        this.cmbGjinia.Text = "";
                        this.txtAddress.Text = "";
                        this.cmbQyteti.Text = "";
                        this.txtNrAme.Text = "";
                        id = -1;
                    }
                }
            }
        }
    }
}
