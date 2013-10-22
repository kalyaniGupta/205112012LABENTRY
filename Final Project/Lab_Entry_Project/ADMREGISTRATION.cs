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
    public partial class ADMREGISTRATION : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        //Int32 count;
        string fname1;

        public ADMREGISTRATION()
        {
            InitializeComponent();

            //if (pictureBox2.InitialImage. == "Desert.jpg")
            //{
            //    MessageBox.Show("Working...");
            //}
            //else
            //{
            //    MessageBox.Show("NOT Working...");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* if (ID.Text != "" )
            {
                //MessageBox.Show(" PLEASE..... \n FILL ALL THE ENTERIES !!! ");
                MessageBox.Show(" YOU HAVE FILLED ALL THE ENTERIES !!! ");
                this.Hide();
            }
            else
            {
                MessageBox.Show(" PLEASE..... \n FILL ALL THE ENTERIES !!! "); //MessageBox.Show(" YOU HAVE FILLED ALL THE ENTERIES !!! ");
                //this.Hide(); 
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DEP_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (NAME1.Text != "" & UNAME1.Text != "" & PSWD1.Text != "" & CPSWD1.Text != "" & pictureBox1.Image != null & EML1.Text != "" & UTYPE1.Text != "" & AID1.Text != "")
            {
                if (PSWD1.Text != CPSWD1.Text)
                {                    
                    MessageBox.Show("PLEASE... \n ENTER THE CORRECT PASSWORD !!!");
                }
                else
                {
                    com.Connection = con;
                    com.CommandText = "Select Uname from Admin_Info where Uname='" + UNAME1.Text + "'";
                    Int32 reg = Convert.ToInt32(UNAME1.Text);
                    Int32 count = Convert.ToInt32(com.ExecuteScalar());
                    if (count == reg)
                    {
                        MessageBox.Show("YOU HAVE ALREADY REGISTERED YOURSELF...");
                    }
                    else
                    {
                        com.CommandText = "insert into Admin_Info(Aname,Uname,Paswrd,Email,Utype,Aid) values ('" + NAME1.Text + "','" + UNAME1.Text + "','" + PSWD1.Text + "','" + EML1.Text + "','" + UTYPE1.Text + "','" + AID1.Text + "')";
                        com.ExecuteNonQuery();
                        com.Dispose();
                        //MessageBox.Show("record inserted");


                        MessageBox.Show("YOU HAVE BEEN REGISTERED SUCCESSFULLY !!!");
                        //     MessageBox.Show("YOUR FINGER PRINT NO IS : "+count);

                        HOME l3 = new HOME();
                        this.Hide();
                        l3.Show();
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
            ADMREGISTRATION ar = new ADMREGISTRATION();
            this.Hide();
            ar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" YOU HAVE CANCELED YOUR REGISTRATION !!! ");
            HOME a1 = new HOME();
            this.Hide();
            a1.Show();
        }

        private void ADMREGISTRATION_Load(object sender, EventArgs e)
        {
            UTYPE1.Text="ADMIN";
            UTYPE1.Enabled = false;
           // progressBar1.Visible = false;
            pictureBox1.Visible = true;


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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void UTYPE1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void NAME1_TextChanged(object sender, EventArgs e)
        {
            //string context = this.NAME1.Text;
            //for (int i = 0; i < context.Length; i++)
            //{

            //    if (char.IsLetter(context[i]))
            //    {

            //    }
            //    else
            //    {
            //        MessageBox.Show("ONLY ALPHABETS ARE ALLOWED");
            //    }
            //}
        }

        private void UNAME1_TextChanged(object sender, EventArgs e)
        {
            //string context = this.NAME1.Text;
            //for (int i = 0; i < context.Length; i++)
            //{

            //    if (char.IsNumber(context[i]))
            //    {

            //    }
            //    else
            //    {
            //        MessageBox.Show("ONLY NUMBERS ARE ALLOWED");
            //    }
            //}
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
                pictureBox1.ImageLocation = fname1;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void PSWD1_TextChanged(object sender, EventArgs e)
        {
            //string context = this.NAME1.Text;
            //for (int i = 0; i < context.Length; i++)
            //{

            //    if (char.IsLetter(context[i]) && char.IsNumber(context[i]))
            //    {
            //        MessageBox.Show("ALPHANUMERIC FORMATE NOT ALLOWED\n ");
            //    }
            //    else
            //    {
            //        MessageBox.Show("ONLY ALPHABETS ARE ALLOWED");
            //    }
            //}
        }

        private void CPSWD1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

       
    }
}
            
