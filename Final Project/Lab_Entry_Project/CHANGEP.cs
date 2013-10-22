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
    public partial class CHANGEP : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        //Int32 count;
        public CHANGEP()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            CHANGEP cp = new CHANGEP();
            this.Hide();
            cp.Show();
        }

        private void CHANGEP_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=OraOLEDB.Oracle.1;Persist Security Info=True;User ID=mca1212; password=User129; Data Source=nitt";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                   // MessageBox.Show("Connection Success");
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
             if (UNM.Text != "" &  & OPWD.Text != "" & NPWD.Text != "" & CPWD.Text != "")
                {
                    if (NPWD.Text  !=   CPWD.Text)
                    {
                        MessageBox.Show(" PASSWORD ARE NOT MATCHED \n PLEASE...ENTER THE CORRECT PASSWORD!!!");
                    }
                    else 
                    {
                        com.Connection = con;
                        com.CommandText = "update Student_Info set Paswrd= '" + NPWD.Text + "' WHERE Uname = '" + UNM.Text + "'";//(Sname,Uname,Paswrd,Email,Utype,Rlno,Sem,Batch,Deg,Dept) values ('" + RNO.Text + "','" + OPWD.Text + "','" + NPWD.Text + "')";
                        com.ExecuteNonQuery();
                        com.Dispose();
                        //MessageBox.Show("record inserted");
                    
                        
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

        private void NPWD_TextChanged(object sender, EventArgs e)
        {

        }

        private void UNM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FPNT_TextChanged(object sender, EventArgs e)
        {

        }

        private void UNM_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CPWD_TextChanged(object sender, EventArgs e)
        {

        }

        private void OPWD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NPWD_TextChanged_1(object sender, EventArgs e)
        {

        }

       
    }
}
