using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace cinima_project
{
    public partial class formUpdatenumofseats : Form
    {
        public formUpdatenumofseats()
        {
            InitializeComponent();
        }

        private void btnupdatenumofseats_Click(object sender, EventArgs e)
        {
            try
            {
                string idproduct = txtidtodelete.Text;
                float numofSeats = float.Parse(txtnumofseats.Text);
                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\DOR5995;database=cinima;Integrated Security=SSPI;");//kesher to database
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "update Movie_detailss set Number_of_Seats=" + numofSeats + " where idmovie='" + idproduct + "';"; //command SQL
                int n = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("update " + n.ToString() + " Movie_detailss");
                mySqlConnection.Close();
                txtidtodelete.Text = "";
                txtnumofseats.Text = "";

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Cinema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
