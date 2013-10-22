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
    public partial class FREGISTRATION : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        //Int32 count;
        string fname1;

        public FREGISTRATION()
        {
            InitializeComponent();
            UTYPE1.Text = "FACULTY";
            UTYPE1.Enabled = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            /*if (FID.Text != "" && DEPT.Text != "")
            {
                MessageBox.Show(" YOU HAVE FILLED ALL THE ENTERIES !!! ");
                    this.Hide();
            }
            else
            {
                MessageBox.Show(" PLEASE..... \n FILL ALL THE ENTERIES !!! ");//MessageBox.Show(" YOU HAVE FILLED ALL THE ENTERIES !!! ");
                
            }*/
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

       // private void FREGISTRATION_Load(object sender, EventArgs e)
        //{
           
       // }

        private void SIGNUP2_Click(object sender, EventArgs e)
        {

            if (NAME2.Text != "" & UNAME2.Text != "" & PSWD2.Text != "" & CPSWD2.Text != "" & pictureBox2.Image != null & EML2.Text != "" & UTYPE2.Text != "" & FID2.Text != "" & DEPT2.Text != "")
            {
                if (PSWD2.Text != CPSWD2.Text)
                {
                    MessageBox.Show("PLEASE... \n ENTER THE CORRECT PASSWORD !!!");
                }
                else
                {
                    com.Connection = con;
                    com.CommandText = "Select Uname from Faculty_Info where Uname='" + UNAME2.Text + "'";
                    Int32 reg = Convert.ToInt32(UNAME2.Text);
                    Int32 count = Convert.ToInt32(com.ExecuteScalar());
                    if (count == reg)
                    {
                        MessageBox.Show("YOU HAVE ALREADY REGISTERED ");
                    }
                    else
                    {
                        com.CommandText = "insert into Faculty_Info(Fname,Uname,Paswrd,Email,Utype,Fid,Dept) values ('" + NAME2.Text + "','" + UNAME2.Text + "','" + PSWD2.Text + "','" + EML2.Text + "','" + UTYPE1.Text + "','" + FID2.Text + "','" + DEPT2.Text + "')";
                        com.ExecuteNonQuery();
                        com.Dispose();
                        //MessageBox.Show("record inserted");


                        MessageBox.Show("YOU HAVE BEEN REGISTERED SUCCESSFULLY !!!");
                        //     MessageBox.Show("YOUR FINGER PRINT NO IS : "+count);

                       HOME l3 = new HOME();
                        this.Hide();
                        l3.Show();
                    }
                    
                   // MessageBox.Show("YOU HAVE BEEN REGISTERED SUCCESSFULLY !!!");
                    //     MessageBox.Show("YOUR FINGER PRINT NO IS : "+count);

                    //LOGIN_PAGE lp= new LOGIN_PAGE();
                    //this.Hide();
                    //lp.Show();
                }
            }


            else
            {

                MessageBox.Show(" PLEASE..... \n FILL ALL THE ENTERIES, ALL ENTERIES ARE MANDATORY !!! ");
            }
        }

        private void RESET2_Click(object sender, EventArgs e)
        {
            FREGISTRATION fr = new FREGISTRATION();
            this.Hide();
            fr.Show();
        }

        private void CANCEL2_Click(object sender, EventArgs e)
        {
            HOME a2 = new HOME();
            this.Hide();
            a2.Show();
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void FREGISTRATION_Load(object sender, EventArgs e)
        {
            UTYPE2.Text = "FACULTY";
            UTYPE2.Enabled = false;
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

        private void NAME2_TextChanged(object sender, EventArgs e)
        {
            string context = this.NAME2.Text;
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
