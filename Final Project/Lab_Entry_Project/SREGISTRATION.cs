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
    public partial class SREGISTRATION : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        //Int32 count;
        string fname1;

        public SREGISTRATION()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*if (RNO.Text != "" & SEM.Text != "" & BATCH.Text != "" & DEGREE.Text != "" & DPT.Text != "")
            {
                MessageBox.Show(" YOU HAVE FILLED ALL THE ENTERIES !!! ");
                this.Hide(); 
            }
            else
            {
                MessageBox.Show(" PLEASE..... \n FILL ALL THE ENTERIES !!! "); //MessageBox.Show(" YOU HAVE FILLED ALL THE ENTERIES !!! ");
                //this.Hide();
            }*/
        }

        private void UTYP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (NAME3.Text != "" & UNAME3.Text != "" & PSWD3.Text != "" & CPSWD3.Text != "" & pictureBox2.Image != null & EML3.Text != "" & UTYPE3.Text != "" & RNO.Text != "" & SEM.Text != "" & BATCH.Text != "" & DEGREE.Text != "" & DEPT3.Text != "")
            {
                {
                    if (UNAME3.Text != RNO.Text)
                    {
                        MessageBox.Show("For student USERNAME and ROLLNO. must be same");

                    }
                }


                if (PSWD3.Text != CPSWD3.Text)//&& UNAME3.Text != RNO.Text)
                {
                    //MessageBox.Show("For student USERNAME and ROLLNO. must be same");


                    MessageBox.Show("SORRY \n YOUR PASSWORD NOT MATCHED !!!");
                }
                else
                {


                    com.Connection = con;
                    com.CommandText = "Select Uname from Student_Info where Uname='" + UNAME3.Text + "'";
                    Int32 reg = Convert.ToInt32(UNAME3.Text);
                    Int32 count = Convert.ToInt32(com.ExecuteScalar());
                    if (count == reg)
                    {
                        MessageBox.Show("already");
                    }
                    else
                    {
                        com.CommandText = "insert into Student_Info(Sname,Uname,Paswrd,Email,Utype,Rlno,Sem,Batch,Deg,Dept) values ('" + NAME3.Text + "','" + UNAME3.Text + "','" + PSWD3.Text + "','" + EML3.Text + "','" + UTYPE3.Text + "','" + RNO.Text + "','" + SEM.Text + "','" + BATCH.Text + "','" + DEGREE.Text + "','" + DEPT3.Text + "')";
                        com.ExecuteNonQuery();
                        com.Dispose();
                        //MessageBox.Show("record inserted");


                        MessageBox.Show("YOU HAVE BEEN REGISTERED SUCCESSFULLY !!!");
                        LOGIN_PAGE l3 = new LOGIN_PAGE();
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

        private void UTYPE1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SREGISTRATION sr = new SREGISTRATION();
            this.Hide();
            sr.Show();
        }

        private void SREGISTRATION_Load(object sender, EventArgs e)
        {
            UTYPE3.Text = "STUDENT";
            UTYPE3.Enabled = false;

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
            catch
            {
                MessageBox.Show("Connection Failed");
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            HOME r3 = new HOME();
            this.Hide();
            r3.Show();
            /*MessageBox.Show(
                this,
                "YOU HAVE CHOOSEN THE VALID PURPOSE. \n NOW YOU CAN ENTER !!!",
               "",
               MessageBoxButtons.OK,
                MessageBoxIcon.Question);
            /*MessageBox.Show(
                     this, // needs a reference to the "Owner" form
                              "this is my text", // text to be shown in the message box
                   "this is the caption", // Title of the message box
                MessageBoxButtons.OK, // Button to show
                    MessageBoxIcon.Warning);*/
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void RNO_TextChanged(object sender, EventArgs e)
        {
            string context = this.RNO.Text;
            for (int i = 0; i < context.Length; i++)
            {

                if (char.IsNumber(context[i]))
                {

                }
                else
                {
                    MessageBox.Show("ONLY NUMBERS ARE ALLOWED");
                }
            }
            /* if (UNAME3.Text != RNO.Text)
            {
                MessageBox.Show("For student USERNAME and ROLLNO. must be same");
            }*/
        }

        private void NAME3_TextChanged(object sender, EventArgs e)
        {
            string context = this.NAME3.Text;
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

        private void UNAME3_TextChanged(object sender, EventArgs e)
        {
            string context = this.UNAME3.Text;
            for (int i = 0; i < context.Length; i++)
            {

                if (char.IsNumber(context[i]))
                {

                }
                else
                {
                    MessageBox.Show("ONLY NUMBERS ARE ALLOWED");
                    UNAME3.Text = "";
                    UNAME3.Enabled = true;
                }
            }
        }

        private void BATCH_TextChanged(object sender, EventArgs e)
        {
            string context = this.BATCH.Text;
            for (int i = 0; i < context.Length; i++)
            {

                if (char.IsNumber(context[i]))
                {

                }
                else
                {
                    MessageBox.Show("ONLY NUMBERS ARE ALLOWED");
                }
            }
        }

        private void DEGREE_TextChanged(object sender, EventArgs e)
        {
            string context = this.DEGREE.Text;
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

        private void DEPT3_TextChanged(object sender, EventArgs e)
        {
            string context = this.DEPT3.Text;
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

        private void FPNT3_TextChanged(object sender, EventArgs e)
        {

        }

        private void EML3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SEM_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void PSWD3_TextChanged(object sender, EventArgs e)
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
