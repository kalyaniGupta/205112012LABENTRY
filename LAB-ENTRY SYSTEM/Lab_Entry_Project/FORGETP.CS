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
    public partial class FORGETP : Form
    {
        public FORGETP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RNO.Text != "" & FPNT.Text != "")
            {
                //MessageBox.Show(" PLEASE..... \n FILL ALL THE ENTERIES !!! ");
               // MessageBox.Show(" YOU HAVE FILLED ALL THE ENTERIES !!! ");
                MessageBox.Show(" YOUR PASSWORD IS: \n");
                LOGIN_PAGE l3 = new LOGIN_PAGE();
                this.Hide();
                l3.Show(); 
            }
            else
            {
                MessageBox.Show(" PLEASE..... \n FILL ALL THE ENTERIES !!! "); //MessageBox.Show(" YOU HAVE FILLED ALL THE ENTERIES !!! ");
                //this.Hide(); 
            }
            
        }
    }
}
