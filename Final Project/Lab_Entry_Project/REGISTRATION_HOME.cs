using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Lab_Entry_Project
{
    public partial class REGISTRATION_HOME : Form
    {

   //     OleDbConnection con = new OleDbConnection();
     //   OleDbCommand com = new OleDbCommand();
       // OleDbDataReader dr;
       // Int32 count;
        public REGISTRATION_HOME()
        {
            InitializeComponent();
        }

        private void REGISTRATION_Load(object sender, EventArgs e)
        { 
            
        /*    con.ConnectionString = "PROVIDER=MSDAORA; USER ID=system; PASSWORD=root; Unicode=true;";
            try
            { 
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                      MessageBox.Show("Connection Success");
                      com.Connection = con;
                      com.CommandText = "select max(fno)  from registration ";
                      count = Convert.ToInt32(com.ExecuteScalar());
                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
            */
        }
           // groupBox3.Visible = false;
            //groupBox4.Visible = false;
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LOGIN_PAGE l2 = new LOGIN_PAGE();
           // this.Hide();
            //l2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            REGISTRATION_HOME r2 = new REGISTRATION_HOME();
            this.Hide();
            r2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            String val = UTYP.SelectedItem + "";
           // MessageBox.Show("USER: " + val);
            if (val.Equals("FACULTY"))
            {
                MessageBox.Show("USER: " + val); 
                FREGISTRATION f2 = new FREGISTRATION();
                this.Hide();
                f2.Show();

            }
            if (val.Equals("STUDENT"))
            {
                MessageBox.Show("USER: " + val);
                SREGISTRATION s3 = new SREGISTRATION();
                this.Hide();
                s3.Show();

            }
            if (val.Equals("OTHERS"))
            {
                MessageBox.Show("USER: " + val);
                OREGISTRATION o4 = new OREGISTRATION();
                this.Hide();
                o4.Show();

            }
            if (val.Equals("ADMIN"))
            {
                MessageBox.Show("USER: " + val); 
                ADMREGISTRATION a1 = new ADMREGISTRATION();
                this.Hide();
                a1.Show();
            }

            if (val.Equals(""))
            {
               MessageBox.Show("FIRST FILL THE USERTYPE ");
            }

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  String val = comboBox2.SelectedItem + "";
            MessageBox.Show("User: " + val);
            if (val.Equals("STUDENT"))
            {
                groupBox3.Visible = true;
            }
           // String val1 = comboBox2.SelectedItem + "";
            //MessageBox.Show("User: " + val1);
            //if (val1.Equals("FACULTY"))
            //{
              //  groupBox4.Visible = true;
            //}*/
           // String val = comboBox2.SelectedItem + "";
           // MessageBox.Show("User: " + val);
           // if (val.Equals("FACULTY"))
           // {
               // FACADEMIC f = new FACADEMIC();
                //this.Hide();
                //f.Show();
                
            //}
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            /*String val = UTYP.SelectedItem + "";
            MessageBox.Show("USER: " + val);
            if (val.Equals("FACULTY"))
            {
                FREGISTRATION f = new FREGISTRATION();
                this.Hide();
                f.Show();

            }
           // String val = comboBox1.SelectedItem + "";
           // MessageBox.Show("User: " + val);
            if (val.Equals("STUDENT"))
            {
                SREGISTRATION s = new SREGISTRATION();
                this.Hide();
                s.Show();

            }
            if (val.Equals("OTHERS"))
            {
                OREGISTRATION o = new OREGISTRATION();
                this.Hide();
                o.Show();

            }
            if (val.Equals("ADMIN"))
            {
                ADMREGISTRATION a2 = new ADMREGISTRATION();
                this.Hide();
                a2.Show();

            }*/
            
        }

        private void NAME_TextChanged(object sender, EventArgs e)
        {
            /*string context = this.NAME.Text;
            for (int i = 0; i < context.Length; i++)
            {

                if (char.IsLetter(context[i]))
                {

                }
                else
                {
                    MessageBox.Show("ONLY ALPHABETS ARE ALLOWED");
                }
            }*/
        }

        private void PSWD_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            HOME l = new HOME();
            this.Hide();
            l.Show();
        }
    }
}
