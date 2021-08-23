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
    public partial class Form_Manager : Form
    {
        public Form_Manager()
        {
            InitializeComponent();
        }
        public void DataToList(string strSQL)
        {
            try
            {
                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\DOR5995;database=cinima;Integrated Security=SSPI;");//kesher to database
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlCommand.CommandText = strSQL;//command sql for select
                mySqlConnection.Open(); //open connection
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();// open mySqlDataReader
                movielist.Items.Clear();
                string str = "";
                string str1 = "";
                str1 = string.Format("{0,10} {1,20} {2,30} {3,26} ", "Movie Name", "price", "Date", "Number of Seat");
                movielist.Items.Add(str1);
                while (mySqlDataReader.Read())  //read to end table
                {
                    str = string.Format(" {0,10} {1,26} {2,34} {3,22} ",  mySqlDataReader[0].ToString(), mySqlDataReader[1].ToString(), mySqlDataReader[2].ToString(), mySqlDataReader[3].ToString());
                    movielist.Items.Add(str);
                }
                mySqlDataReader.Close();
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "cinima database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnshowmovie_Click(object sender, EventArgs e)
        {
            DataToList("Select * from Movie_detailss");
        }

        private void movielist_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnaddmovies_Click(object sender, EventArgs e)
        {
            Form_add_moviescs x = new Form_add_moviescs();
            x.ShowDialog();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Form_delete_ x = new Form_delete_();
            x.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_update_price x = new form_update_price();
            x.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formUpdatenumofseats x = new formUpdatenumofseats();
            x.ShowDialog();
        }
    }
}
