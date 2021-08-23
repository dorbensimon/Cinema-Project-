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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        public void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string NameWorker="";
                string StatusWorker = "";
                string idworker = textBox1.Text;
                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\DOR5995;database=cinima;Integrated Security=SSPI;");//kesher to database
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlCommand.CommandText = "Select NameWorker,Status from Employed where IDWorker='" + idworker + "';"; //command sql for select
                mySqlConnection.Open(); //open connection
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();// open mySqlDataReader
                while (mySqlDataReader.Read())
                {
                    NameWorker = mySqlDataReader[0].ToString();
                    StatusWorker = mySqlDataReader[1].ToString();
                    class_worker.Status = StatusWorker;
                    Class_name_user_cs.username = int.Parse(idworker);



                }
                mySqlDataReader.Close();
                mySqlConnection.Close();
                if (NameWorker == "")
                {
                    MessageBox.Show("ERROR ID");
                    textBox1.Text = "";
                }
                else
                {

                    MessageBox.Show("Shalom :" + NameWorker + "\nStatus :" + StatusWorker);

                    Form_select_status x = new Form_select_status();
                    x.ShowDialog();

                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "cinima database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
