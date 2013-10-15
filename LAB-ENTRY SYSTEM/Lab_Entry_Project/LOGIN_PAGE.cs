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
    public partial class LOGIN_PAGE : Form
    {
        public LOGIN_PAGE()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //ADMIN_PURPOSE a1 = new ADMIN_PURPOSE();
            //this.Hide();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*if (radioButton1.Checked == true)
            {
                ADMIN_PURPOSE a = new ADMIN_PURPOSE();
                a.Show();
                this.Hide();
            }
            if (radioButton2.Checked == true)
            {
                FACULTY_PURPOSE f = new FACULTY_PURPOSE();
                f.Show();
                this.Hide();
            }
            if (radioButton3.Checked == true)
            {
                STUDENT_PURPOSE s = new STUDENT_PURPOSE();
                this.Hide();
                s.Show();
            }
            if (radioButton4.Checked == true)
            {
                OTERS_PURPOSE o = new OTERS_PURPOSE();
                this.Hide();
                o.Show();
            }*/

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (UNAME.Text != "" & PWD.Text != "" & FPNT.Text != "" & UTYPE.Text != "")
            {
            
                if (UTYPE.SelectedItem.ToString() == "ADMIN")
                {
                    ADMIN_PURPOSE a = new ADMIN_PURPOSE();
                    a.Show();
                    this.Hide();
                }
                if (UTYPE.SelectedItem.ToString() == "FACULTY")
                {
                    FACULTY_PURPOSE f = new FACULTY_PURPOSE();
                    f.Show();
                    this.Hide();
                }
                if (UTYPE.SelectedItem.ToString() == "STUDENT")
                {
                    STUDENT_PURPOSE s = new STUDENT_PURPOSE();
                    this.Hide();
                    s.Show();
                }
                if (UTYPE.SelectedItem.ToString() == "OTHERS")
                {
                    OTERS_PURPOSE o = new OTERS_PURPOSE();
                    this.Hide();
                    o.Show();
                }
            

            /*
            SIGN_IN s1 = new SIGN_IN();
            this.Hide();
            s1.Show();
             * */
           
            }
            else
            {
                MessageBox.Show(" PLEASE..... \n FILL ALL THE ENTERIES !!! ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton4.Checked == true)
            {
                AREGISTRATION a2 = new AREGISTRATION();
                this.Hide();
                a2.Show();
            }
            if (radioButton3.Checked == true)
            {
                SREGISTRATION r1 = new SREGISTRATION();
                this.Hide();
                r1.Show();
            }*/
            AREGISTRATION s2 = new AREGISTRATION();
            this.Hide();
            s2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //CANCEl c1 = new CANCEl();
            //this.Hide();
            //c1.Show();/
            MessageBox.Show("YOU HAVE BEEN CANCELD YOUR LOG_IN  :( !!!");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void PWD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FORGETP p = new FORGETP();
            this.Hide();
            p.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CHANGEP p = new CHANGEP();
            this.Hide();
            p.Show();
        }

        

       

       
    }
}
