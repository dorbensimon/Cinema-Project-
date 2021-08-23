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
    public partial class Form_delete_ : Form
    {
        public Form_delete_()
        {
            InitializeComponent();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string iddelete = txtid.Text;
                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\DOR5995;database=cinima;Integrated Security=SSPI;");//kesher to database
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "delete from Movie_detailss where idmovie='" + iddelete + "';"; //command SQL
                int n = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Delete " + n.ToString() + " Movie_detailss");
                mySqlConnection.Close();
                txtid.Text = "";

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "cinima", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
