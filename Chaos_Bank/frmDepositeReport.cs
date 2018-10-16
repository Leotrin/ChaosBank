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
    public partial class frmDepositeReport : Form
    {
        String conn = @"Data Source=LEOTRIN-PC\SQLSERVER2008;Initial Catalog=Chaos_Bank;User ID=sa;Password=plus66extream";
       
        public frmDepositeReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cm = new SqlCommand("Select Distinct Sh.ID, K.Emri, K.Mbiemri, K.Adresa, B.Bank, Sh.Vlera from tblSherbimi as Sh, tblBank as B, tblKlient as K Where Sh.IDKlient=K.ID and Sh.IDBank=B.ID and Sh.Sherbimi='Deposite' and Data=@data", con);
            SqlParameter parameterData = new SqlParameter("@data", SqlDbType.Date);
            parameterData.Value = this.dtData.Value;
            cm.Parameters.Add(parameterData);
            try
            {

                SqlDataAdapter adp = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                adp.SelectCommand = cm;
                adp.Fill(ds, "dataset");
                dv.Table = ds.Tables[0];
                dv.Sort = "id desc";
                dgDeposite.DataSource = dv;
                dgDeposite.Refresh();
            }
            catch (SqlException)
            {
                
            }
            con.Close();
        }
    }
}
