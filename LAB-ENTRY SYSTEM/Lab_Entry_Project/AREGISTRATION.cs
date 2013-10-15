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
    public partial class AREGISTRATION : Form
    {

   //     OleDbConnection con = new OleDbConnection();
     //   OleDbCommand com = new OleDbCommand();
       // OleDbDataReader dr;
       // Int32 count;
        public AREGISTRATION()
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
            AREGISTRATION r2 = new AREGISTRATION();
            this.Hide();
            r2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NAME.Text != "" & UNM.Text != "" & PSWD.Text != "" & CPSWD.Text != "" & FPNT.Text != "" & EML.Text != "" & UTYP.Text != "" )
                {
                    if (PSWD.Text  !=   CPSWD.Text)
                    {
                        MessageBox.Show("PLEASE... \n ENTER THE CORRECT PASSWORD !!!");
                    }
                    else 
                    {   
                        MessageBox.Show("YOU HAVE BEEN REGISTERED SUCCESSFULLY !!!");
                   //     MessageBox.Show("YOUR FINGER PRINT NO IS : "+count);

                        LOGIN_PAGE l3 = new LOGIN_PAGE();
                        this.Hide();
                        l3.Show();
                    }
                 }
                
               
                else
                {

                    MessageBox.Show(" PLEASE..... \n FILL ALL THE ENTERIES, ALL ENTERIES ARE MANDATORY !!! ");
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
            String val = UTYP.SelectedItem + "";
            MessageBox.Show("USER: " + val);
            if (val.Equals("FACULTY"))
            {
                FACADEMIC f = new FACADEMIC();
                //this.Hide();
                f.Show();

            }
           // String val = comboBox1.SelectedItem + "";
           // MessageBox.Show("User: " + val);
            if (val.Equals("STUDENT"))
            {
                SACADMIC s = new SACADMIC();
                //this.Hide();
                s.Show();

            }
            if (val.Equals("OTHERS"))
            {
                OACADEMIC o = new OACADEMIC();
                //this.Hide();
                o.Show();

            }
            if (val.Equals("ADMIN"))
            {
                AACADEMIC a2 = new AACADEMIC();
                //this.Hide();
                a2.Show();

            }
            
        }
    }
}

