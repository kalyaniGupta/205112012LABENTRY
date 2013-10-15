using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_Entry_Project
{
    public partial class AACADEMIC : Form
    {
        public AACADEMIC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ID.Text != "" & DEPT.Text != "")
            {
                //MessageBox.Show(" PLEASE..... \n FILL ALL THE ENTERIES !!! ");
                MessageBox.Show(" YOU HAVE FILLED ALL THE ENTERIES !!! ");
                this.Hide();
            }
            else
            {
                MessageBox.Show(" PLEASE..... \n FILL ALL THE ENTERIES !!! "); //MessageBox.Show(" YOU HAVE FILLED ALL THE ENTERIES !!! ");
                //this.Hide(); 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
