using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Imaging;


namespace Lab_Entry_Project
{
    public partial class OREGISTRATION : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        //Int32 count;
        string fname1;
        
        public OREGISTRATION()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NID4.Text != "" && DEPT4.Text != "")
            {
                MessageBox.Show(" YOU HAVE FILLED ALL THE ENTERIES !!! ");
                this.Hide();
            }
            else
            {
                MessageBox.Show(" PLEASE..... \n FILL ALL THE ENTERIES !!! ");//MessageBox.Show(" YOU HAVE FILLED ALL THE ENTERIES !!! ");

            }
        }

        private void OID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (NAME4.Text != "" & UNAME4.Text != "" & PSWD4.Text != "" & CPSWD4.Text != "" & pictureBox2.Image != null & EML4.Text != "" & UTYPE4.Text != "" & NID4.Text != "" & DEPTT4.Text != "")
            {
                if (PSWD4.Text != CPSWD4.Text)
                {
                    MessageBox.Show("PLEASE... \n ENTER THE CORRECT PASSWORD !!!");
                }
                else
                {
                    com.Connection = con;
                    com.CommandText = "Select Uname from Faculty_Info where Uname='" + UNAME4.Text + "'";
                    Int32 reg = Convert.ToInt32(UNAME4.Text);
                    Int32 count = Convert.ToInt32(com.ExecuteScalar());
                    if (count == reg)
                    {
                        MessageBox.Show("YOU HAVE ALREADY REGISTERED OR USER NAME ALREADY USED");
                    }
                    else
                    {
                        com.CommandText = "insert into Others_Info(name,Uname,Paswrd,Email,Utype,Nid,Dept) values ('" + NAME4.Text + "','" + UNAME4.Text + "','" + PSWD4.Text + "','" + EML4.Text + "','" + UTYPE4.Text + "','" + NID4.Text + "','" + DEPTT4.Text + "')";
                        com.ExecuteNonQuery();
                        com.Dispose();
                        //MessageBox.Show("record inserted");


                        MessageBox.Show("YOU HAVE BEEN REGISTERED SUCCESSFULLY !!!");
                        //     MessageBox.Show("YOUR FINGER PRINT NO IS : "+count);

                        HOME l3 = new HOME();
                        this.Hide();
                        l3.Show();
                    
                    //MessageBox.Show("YOU HAVE BEEN REGISTERED SUCCESSFULLY !!!");
                    //     MessageBox.Show("YOUR FINGER PRINT NO IS : "+count);

                   // LOGIN_PAGE l3 = new LOGIN_PAGE();
                    //this.Hide();
                    //l3.Show();
                }
            }
           }

            else
            {

                MessageBox.Show(" PLEASE..... \n FILL ALL THE ENTERIES, ALL ENTERIES ARE MANDATORY !!! ");
            }
        }
  

        private void button1_Click_1(object sender, EventArgs e)
        {
            OREGISTRATION or = new OREGISTRATION();
            this.Hide();
            or.Show();
        }

        private void OREGISTRATION_Load(object sender, EventArgs e)
        {
            UTYPE4.Text = "OTHERS";
            UTYPE4.Enabled = false;
            // progressBar1.Visible = false;
            pictureBox2.Visible = true;


            con.ConnectionString = "Provider=OraOLEDB.Oracle.1;Persist Security Info=True;User ID=mca1212; password=User129; Data Source=nitt";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                    //MessageBox.Show("Connection Success");
                    //com.Connection = con;
                    //com.CommandText = "select max(fno)  from registration ";
                    // count = Convert.ToInt32(com.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            HOME a4 = new  HOME();
            this.Hide();
            a4.Show();
        }

        private void NAME44_TextChanged(object sender, EventArgs e)
        {
            string context = this.NAME44.Text;
            for (int i = 0; i < context.Length; i++)
            {

                if (char.IsLetter(context[i]))
                {

                }
                else
                {
                    MessageBox.Show("ONLY ALPHABETS ARE ALLOWED");
                }
            }
        }

        private void UTYPE4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Images";
            openFileDialog1.Filter = "All Images|*.jpg; *.bmp; *.png";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName.ToString() != "")
            {
                fname1 = openFileDialog1.FileName.ToString();
                pictureBox2.ImageLocation = fname1;
            }
        }
    }
}
