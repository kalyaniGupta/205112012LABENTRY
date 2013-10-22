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

    public partial class FORGETP : Form
    {

        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        string fname1;

        public FORGETP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string count;

            if (UNAM.Text != "" & pictureBox1.Image != null && UTYPE.Text != "")
            {

                if (UTYPE.SelectedItem.ToString() == "ADMIN")
                {
                    com.Connection = con;
                    com.CommandText = "Select Paswrd from Admin_Info where Uname='" + UNAM.Text + "' and Utype='" + UTYPE.Text + "'";
                   // MessageBox.Show("b");
                    //Int32 nam = Convert.ToInt32(UNAME.Text);
                    count = Convert.ToString(com.ExecuteScalar());
                   // SqlDataReader read_rd
                    MessageBox.Show(" YOUR PASSWORD IS: " +count);
                    HOME hm = new HOME();
                    this.Hide();
                    hm.Show();
                }

                if (UTYPE.SelectedItem.ToString() == "FACULTY")
                {
                    com.Connection = con;
                    com.CommandText = "Select Paswrd from Faculty_Info where Uname='" + UNAM.Text + "' and Utype='" + UTYPE.Text + "'";
                    // MessageBox.Show("b");
                    //Int32 nam = Convert.ToInt32(UNAME.Text);
                    count = Convert.ToString(com.ExecuteScalar());
                    // SqlDataReader read_rd
                    MessageBox.Show(" YOUR PASSWORD IS: " + count);
                    HOME hm = new HOME();
                    this.Hide();
                    hm.Show();
                }

                if (UTYPE.SelectedItem.ToString() == "STUDENT")
                {
                    com.Connection = con;
                    com.CommandText = "Select Paswrd from Student_Info where Uname='" + UNAM.Text + "' and Utype='" + UTYPE.Text + "'";
                    // MessageBox.Show("b");
                    //Int32 nam = Convert.ToInt32(UNAME.Text);
                    count = Convert.ToString(com.ExecuteScalar());
                    // SqlDataReader read_rd
                    MessageBox.Show(" YOUR PASSWORD IS: " + count);
                    HOME hm = new HOME();
                    this.Hide();
                    hm.Show();
                }

                if (UTYPE.SelectedItem.ToString() == "OTHERS")
                {
                    com.Connection = con;
                    com.CommandText = "Select Paswrd from Others_Info where Uname='" + UNAM.Text + "' and Utype='" + UTYPE.Text + "'";
                    // MessageBox.Show("b");
                    //Int32 nam = Convert.ToInt32(UNAME.Text);
                    count = Convert.ToString(com.ExecuteScalar());
                    // SqlDataReader read_rd
                    MessageBox.Show(" YOUR PASSWORD IS: " + count);
                    HOME hm = new HOME();
                    this.Hide();
                    hm.Show();
                }

            }
            else
            {
                MessageBox.Show(" PLEASE..... \n FILL ALL THE ENTERIES !!! "); //MessageBox.Show(" YOU HAVE FILLED ALL THE ENTERIES !!! ");
                //this.Hide(); 
            }

        }

        private void FORGETP_Load(object sender, EventArgs e)
        {
            //pictureBox3.Visible = true;

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

        private void UTYPE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string path = @"C:\Users\KALYANI GUPTA\Desktop\pcafterlab\thumb image";
            string roll = UNAM.Text;
            fname1 = Path.Combine(path, roll);
            fname1 = fname1 + ".jpg";
            MessageBox.Show(fname1);
            pictureBox1.ImageLocation = fname1;
        }
    }
}
