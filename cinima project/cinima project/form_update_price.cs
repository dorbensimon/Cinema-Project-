using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Data.SqlClient;


namespace cinima_project
{
    public partial class form_update_price : Form
    {
        public form_update_price()
        {
            InitializeComponent();
        }

        private void form_update_price_Load(object sender, EventArgs e)
        {

        }

        private void btnupdateprice_Click(object sender, EventArgs e)
        {
            try
            {
                string idproduct = txtidtodelete.Text;
                float price = float.Parse(txtprice.Text);
                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\DOR5995;database=cinima;Integrated Security=SSPI;");//kesher to database
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "update Movie_detailss set Price=" + price + " where idmovie='" + idproduct + "';"; //command SQL
                int n = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("update " + n.ToString() + " Movie_detailss");
                mySqlConnection.Close();
                txtidtodelete.Text = "";
                txtprice.Text = "";

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Cinema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
