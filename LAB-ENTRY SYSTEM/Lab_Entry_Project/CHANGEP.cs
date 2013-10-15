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
    public partial class CHANGEP : Form
    {
        public CHANGEP()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CHANGEP_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
             if (RNO.Text != "" & FPNT.Text != "" & OPWD.Text != "" & NPWD.Text != "" & CPWD.Text != "")
                {
                    if (NPWD.Text  !=   CPWD.Text)
                    {
                        MessageBox.Show(" PASSWORD ARE NOT MATCHED \n PLEASE...ENTER THE CORRECT PASSWORD!!!");
                    }
                    else 
                    {   
                        MessageBox.Show("YOU HAVE BEEN CHANGED YOUR PASSWORD SUCCESSFULLY !!!");
                   //     MessageBox.Show("YOUR FINGER PRINT NO IS : "+count);
                        LOGIN_PAGE l3 = new LOGIN_PAGE();
                        this.Hide();
                        l3.Show();
                    }
                 }
                
               
                else
                {

                    MessageBox.Show(" PLEASE..... \n FILL ALL THE ENTERIES !!! ");
                }
        
        }
    }
}
