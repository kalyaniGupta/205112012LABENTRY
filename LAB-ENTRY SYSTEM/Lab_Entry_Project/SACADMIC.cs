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
    public partial class SACADMIC : Form
    {
        public SACADMIC()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RNO.Text != "" & SEM.Text != "" & BATCH.Text != "" & DEGREE.Text != "" & DPT.Text != "")
            {
                MessageBox.Show(" YOU HAVE FILLED ALL THE ENTERIES !!! ");
                this.Hide(); 
            }
            else
            {
                MessageBox.Show(" PLEASE..... \n FILL ALL THE ENTERIES !!! "); //MessageBox.Show(" YOU HAVE FILLED ALL THE ENTERIES !!! ");
                //this.Hide();
            }
        }
    }
}
