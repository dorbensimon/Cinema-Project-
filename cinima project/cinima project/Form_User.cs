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
    public partial class Form_User : Form
    {
        public Form_User()
        {
            InitializeComponent();
        }

        private void Form_User_Load(object sender, EventArgs e)
        {

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
                    str = string.Format(" {0,10} {1,26} {2,34} {3,22} ", mySqlDataReader[0].ToString(), mySqlDataReader[1].ToString(), mySqlDataReader[2].ToString(), mySqlDataReader[3].ToString());
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

        private void movielist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnshowmovie_Click(object sender, EventArgs e)
        {
            DataToList("Select * from Movie_detailss");
        }

        private void btnchoose_Click(object sender, EventArgs e)
        {
            Form2_the_hallcs x = new Form2_the_hallcs();
            x.ShowDialog();
            try
            {
                string the_name = txtbuy.Text;
                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\DOR5995;database=cinima;Integrated Security=SSPI;");//kesher to database
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "update Employed set MovieWatchByUser="+"'" + the_name+ "'"+ " where IDWorker='" + Class_name_user_cs.username + "';"; //command SQL
                int n = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("update  " + n.ToString() + " Employed");
                mySqlConnection.Close();
                Class1_name_of_the_movie_cs.the_name = txtbuy.Text;
            }
            catch (Exception err)
            {
                
                MessageBox.Show(err.Message, "cinima", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     

    }
}
