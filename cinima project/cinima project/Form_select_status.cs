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
    public partial class Form_select_status : Form
    {
        public Form_select_status()
        {
            InitializeComponent();
              if (class_worker.Status == "manager")
                btn_manager.Enabled = true;
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btn_manager_Click(object sender, EventArgs e)
        {
            Form_Manager x = new Form_Manager();
            x.ShowDialog();
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            Form_User x = new Form_User();
            x.ShowDialog();
        }
    }
}
