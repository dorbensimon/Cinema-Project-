using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinima_project
{
    public partial class Form2_the_hallcs : Form
    {
        public Form2_the_hallcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your order \n The Movie " + Class1_name_of_the_movie_cs.the_name + "was successfully added to the list");
        }
    }
}
