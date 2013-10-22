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
    public partial class LOGOUT : Form
    {
        public static string name;
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        string uname;
        string fname1;

        public void passvalue(string str)
        {
            uname = str;
        }

        public LOGOUT()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = UNM.Text;
            if (pictureBox2.Image != null & UNM.Text != "")
            {
                MessageBox.Show("YOU are logout !!!");
                DateTime now = DateTime.Now;
                // MessageBox.Show("Current time: " + now);
                com.Connection = con;
                com.CommandText = "insert into Logout_Scheduld values ('" + name + "','" + now + "')";
               com.ExecuteNonQuery();
                com.Dispose();


                HOME l1 = new HOME();
                this.Hide();
                l1.Show();
            }
            else
            {
                MessageBox.Show("FOR LOGOUT FILL ENTRY");
            }
        }

        private void LOGOUT_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            // progressBar1.Visible = false;
            pictureBox2.Visible = true;

            con.ConnectionString = "Provider=OraOLEDB.Oracle.1;Persist Security Info=True;User ID=mca1212; password=User129; Data Source=nitt";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                    MessageBox.Show("Connection Success");
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

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
