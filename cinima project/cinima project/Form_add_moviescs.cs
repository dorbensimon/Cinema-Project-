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
    public partial class Form_add_moviescs : Form
    {
        public Form_add_moviescs()
        {
            InitializeComponent();
        }

        private void btnaddmovie_Click(object sender, EventArgs e)
        {
            try
            {
                string strname = txtmoviename.Text;
                int strprice = int.Parse(txtprice.Text);
                string strdate = txtdate.Text;
                int strnumberofseats = int.Parse(txtnumberofseat.Text);
                string strid = txtidmovie.Text;
                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\DOR5995;database=cinima;Integrated Security=SSPI;");//kesher to database
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "insert into Movie_detailss values('" + strname + "','" + strprice + "'," + strdate + ",'" + strnumberofseats + "','" + strid + "');"; //command SQL
                int n = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Insert  " + n.ToString() + " row");
                mySqlConnection.Close();
                txtmoviename.Text = "";
                txtprice.Text = "";
                txtdate.Text = "";
                txtnumberofseat.Text = "";
                txtidmovie.Text = "";

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "cinima", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
