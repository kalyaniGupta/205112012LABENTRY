﻿using System;
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
    public partial class ADMIN_PURPOSE : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;

        string uname;


        public void passvalue(string str)
        {
            uname = str;
        }

        public ADMIN_PURPOSE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Text == "")
            {
                MessageBox.Show("Please...\n FIRST CHOOSE THE PURPOSE");
                // STUDENT_PURPOSE sp = new STUDENT_PURPOSE();
                //this.Hide();
                //sp.Show();
            }
            /*com.Connection = con;
            com.CommandText = "insert into Sighin_Info(Uname,Paswrd,Utype) values ('" + UNAME.Text + "','" + PWD.Text + "','" + UTYPE.Text + "')";
            com.ExecuteNonQuery();
            com.Dispose();*/
            //MessageBox.Show("record inserted");
            else
            {
                /*com.Connection = con;
               // com.CommandText = "select * from Sigin Paswrd= '" + NPWD.Text + "' WHERE Uname = '" + UNM.Text + "'";//(Sname,Uname,Paswrd,Email,Utype,Rlno,Sem,Batch,Deg,Dept) values ('" + RNO.Text + "','" + OPWD.Text + "','" + NPWD.Text + "')";
                //com.CommandText = "update Student_Info set Paswrd= '" + NPWD.Text + "' WHERE Uname = '" + UNM.Text + "'";//(Sname,Uname,Paswrd,Email,Utype,Rlno,Sem,Batch,Deg,Dept) values ('" + RNO.Text + "','" + OPWD.Text + "','" + NPWD.Text + "')";
                com.ExecuteNonQuery();
                com.Dispose();*/


                MessageBox.Show("YOU HAVE CHOOSEN THE VALID PURPOSE. \n NOW YOU CAN ENTER !!!");
                DateTime now = DateTime.Now;
                MessageBox.Show("Current time: " + now);
                com.Connection = con;
                com.CommandText = "insert into Login_Scheduld values ('" + uname + "','" + now + "')";
                com.ExecuteNonQuery();
                com.Dispose();

               // MessageBox.Show("YOU HAVE CHOOSEN THE VALID PURPOSE. \n NOW YOU CAN ENTER !!!");
               HOME l1 = new HOME();
                this.Hide();
                l1.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("YOU HAVE CHOOSEN THE VALID PURPOSE. \n NOW YOU CAN ENTER !!!");
            //LOGIN_PAGE l1 = new LOGIN_PAGE();
           // this.Hide();
            //l1.Show();
        }

        private void ADMIN_PURPOSE_Load(object sender, EventArgs e)
        {
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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
