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
    public partial class FACADEMIC : Form
    {
        public FACADEMIC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (FID.Text != "" && DEPT.Text != "")
            {
                MessageBox.Show(" YOU HAVE FILLED ALL THE ENTERIES !!! ");
                    this.Hide();
            }
            else
            {
                MessageBox.Show(" PLEASE..... \n FILL ALL THE ENTERIES !!! ");//MessageBox.Show(" YOU HAVE FILLED ALL THE ENTERIES !!! ");
                
            }
        }
    }
}
