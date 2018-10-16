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
    public partial class frmAddBank : Form
    {
        String con = @"Data Source=LEOTRIN-PC\SQLSERVER2008;Initial Catalog=Chaos_Bank;User ID=sa;Password=plus66extream";
       
        public frmAddBank()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtAddBank.Text == "")
            {
                MessageBox.Show("Pleas fill the Bank field !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection(con);

                conn.Open();
                String selekt = "Select * from tblBank where Bank='" + this.txtAddBank.Text + "'";
                SqlCommand cmd = new SqlCommand(selekt, conn);
                SqlDataReader rd = cmd.ExecuteReader();


                if (rd.Read() == true)
                {
                    rd.Close();
                    conn.Close();
                    MessageBox.Show("This Bank already excist in the database !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    rd.Close();
                    conn.Close();

                    conn.Open();
                    try
                    {
                        SqlCommand cm = new SqlCommand("Insert into tblBank(Bank) values('" + this.txtAddBank.Text + "')", conn);
                        cm.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        this.txtAddBank.Text = "";
                        conn.Close();
                        conn.Open();
                        SqlCommand coman = new SqlCommand("Select * from tblBank", conn);
                        try
                        {

                            SqlDataAdapter adp = new SqlDataAdapter();
                            DataSet ds = new DataSet();
                            DataView dv = new DataView();

                            adp.SelectCommand = coman;
                            adp.Fill(ds, "dataset");
                            dv.Table = ds.Tables[0];
                            dv.Sort = "id desc";
                            dgBank.DataSource = dv;
                            dgBank.Refresh();
                        }
                        catch (SqlException)
                        {

                        }
                        conn.Close();
                    }
                }
            }
        }

        private void frmAddBank_Load(object sender, EventArgs e)
        {
            this.txtAddBank.Focus();
        }
    }
}
