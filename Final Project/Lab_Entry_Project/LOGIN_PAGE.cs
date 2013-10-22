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
    public partial class LOGIN_PAGE : Form
    {
        public static string name, role;
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        //Int32 count;
        string fname1, fname2;
        string uname;

        public LOGIN_PAGE()
        {
            InitializeComponent();
           // MessageBox.Show(LOGOUT.name);
            name = string.Empty;
            role = string.Empty;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
             progressBar1.Visible = false;
            pictureBox2.Visible = true;


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
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //ADMIN_PURPOSE a1 = new ADMIN_PURPOSE();
            //this.Hide();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*if (radioButton1.Checked == true)
            {
                ADMIN_PURPOSE a = new ADMIN_PURPOSE();
                a.Show();
                this.Hide();
            }
            if (radioButton2.Checked == true)
            {
                FACULTY_PURPOSE f = new FACULTY_PURPOSE();
                f.Show();
                this.Hide();
            }
            if (radioButton3.Checked == true)
            {
                STUDENT_PURPOSE s = new STUDENT_PURPOSE();
                this.Hide();
                s.Show();
            }
            if (radioButton4.Checked == true)
            {
                OTERS_PURPOSE o = new OTERS_PURPOSE();
                this.Hide();
                o.Show();
            }*/

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = UNAME.Text;
            role = UTYPE.SelectedItem.ToString();
            string str = UNAME.Text;
            if (UNAME.Text != "" & pictureBox1.Image != null & pictureBox2.Image != null & UTYPE.Text != "")
            {

                com.Connection = con;

                Bitmap img1, img2;
                int count2 = 0, count1 = 0;
                bool flag = true;
                progressBar1.Visible = true;
                string img1_ref, img2_ref;
                img1 = new Bitmap(fname1);
                img2 = new Bitmap(fname2);
                progressBar1.Maximum = img1.Width;
                if (img1.Width == img2.Width && img1.Height == img2.Height)
                {
                    for (int i = 0; i < img1.Width; i++)
                    {
                        for (int j = 0; j < img1.Height; j++)
                        {
                            img1_ref = img1.GetPixel(i, j).ToString();
                            img2_ref = img2.GetPixel(i, j).ToString();
                            if (img1_ref != img2_ref)
                            {
                                count2++;
                                flag = false;
                                break;
                            }
                            count1++;
                        }
                        progressBar1.Value++;
                    }
                    if (flag == false)
                        MessageBox.Show("SORRY, \n YOUR FINGERPRINT DOES NOT MATCHED ");
                    else
                    {
                        MessageBox.Show(" YOUR FINGER PRINT IS MATCHED");
                        //  HOME a2 = new HOME();
                        //this.Hide();
                        //a2.Show();
                        if (UTYPE.SelectedItem.ToString() == "ADMIN")
                        {
                            com.CommandText = "Select Uname from Admin_Info where paswrd='" + PWD.Text + "'";
                            Int32 nam = Convert.ToInt32(UNAME.Text);
                            Int32 count = Convert.ToInt32(com.ExecuteScalar());
                            if (count == nam)
                            {
                                // MessageBox.Show("okkk");
                                ADMIN_PURPOSE adm = new ADMIN_PURPOSE();// STUDENT_PURPOSE ob = new STUDENT_PURPOSE();
                                adm.passvalue(str);
                                adm.Show();
                                Hide();
                            }
                        }
                            if (UTYPE.SelectedItem.ToString() == "FACULTY")
                            {
                                com.CommandText = "Select Uname from Faculty_Info where paswrd='" + PWD.Text + "'";
                                Int32 nam1 = Convert.ToInt32(UNAME.Text);
                                Int32 count3 = Convert.ToInt32(com.ExecuteScalar());
                                if (count3 == nam1)
                                {
                                    FACULTY_PURPOSE adm = new FACULTY_PURPOSE();
                                    adm.passvalue(str);
                                    adm.Show();
                                    Hide();
                                }
                            }
                           
                            if (UTYPE.SelectedItem.ToString() == "STUDENT")
                              {
                                com.CommandText = "Select Uname from Student_Info where paswrd='" + PWD.Text + "'";
                                Int32 nam1 = Convert.ToInt32(UNAME.Text);
                                Int32 count3 = Convert.ToInt32(com.ExecuteScalar());
                                if (count3 == nam1)
                                {
                                    STUDENT_PURPOSE adm = new STUDENT_PURPOSE();
                                    adm.passvalue(str);
                                    adm.Show();
                                    Hide();
                                }
                            }

                            if (UTYPE.SelectedItem.ToString() == "OTHERS")
                            {
                                com.CommandText = "Select Uname from Others_Info where paswrd='" + PWD.Text + "'";
                                Int32 nam1 = Convert.ToInt32(UNAME.Text);
                                Int32 count3 = Convert.ToInt32(com.ExecuteScalar());
                                if (count3 == nam1)
                                {
                                    OTHERS_PURPOSE adm = new OTHERS_PURPOSE();
                                    adm.passvalue(str);
                                    adm.Show();
                                    Hide();
                                }
                            }
                      }
                }
                else
                {
                    MessageBox.Show("can not compare this images");
                    this.Dispose();
                }
       }
                else
                {
                    MessageBox.Show(" PLEASE..... \n FILL ALL THE ENTERIES !!! ");
                }



         
           //     }
           //     if (flag == false)
           //         MessageBox.Show("SORRY, \n YOUR FINGERPRINT DOES NOT MATCHED ");
           //     else
           //     {
           //         MessageBox.Show(" YOUR FINGER PRINT IS MATCHED");
           //         HOME a2 = new HOME();
           //         this.Hide();
           //         a2.Show();
           //      /*  ..... if (UTYPE.SelectedItem.ToString() == "ADMIN")
           //     {
           //         ADMIN_PURPOSE a = new ADMIN_PURPOSE();
           //          this.Hide();
           //         a.Show();
           //         //    impliment these also for logintome
           //         // com.CommandText = "Select Uname from Admin_Info where Utype='" + UTYPE.Text + "'";
           //         // Int32 nam = Convert.ToInt32(UNAME.Text);
           //         //Int32 count = Convert.ToInt32(com.ExecuteScalar());
           //         //if (count == nam)
           //         //{
           //         //   MessageBox.Show("okkk");
           //         //    ADMIN_PURPOSE a = new ADMIN_PURPOSE();// STUDENT_PURPOSE ob = new STUDENT_PURPOSE();
           //         //    a.passvalue(str);
           //         //    a.Show();
           //         //    Hide();

           //         //    //a.Show();
           //         //    //this.Hide();
           //         //}
           //         //else
           //         //{
           //         //    MessageBox.Show("wrong");
           //         //}

           //     }*/

           //     }
           // }
           // else
           // {
           //     MessageBox.Show("can not compare this images");
           //     this.Dispose();
           // }

           //// name = UNAME.Text;
           ////// MessageBox.Show("YOU are logout !!!");
           //// DateTime now = DateTime.Now;
           ////  MessageBox.Show("Current time: " + now);
           //// com.Connection = con;
           //// com.CommandText = "insert into mytime values ('" + uname + "','" + now + "')";
           //// //  com.ExecuteNonQuery();
           //// com.Dispose();


           //// HOME l1 = new HOME();
           //// this.Hide();
           //// l1.Show();
            


           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton4.Checked == true)
            {
                AREGISTRATION a2 = new AREGISTRATION();
                this.Hide();
                a2.Show();
            }
            if (radioButton3.Checked == true)
            {
                SREGISTRATION r1 = new SREGISTRATION();
                this.Hide();
                r1.Show();
            }*/
            REGISTRATION_HOME s2 = new REGISTRATION_HOME();
            this.Hide();
            s2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* MessageBox.Show(
                         this, // needs a reference to the "Owner" form
                                  "this is my text", // text to be shown in the message box
                       "this is the caption", // Title of the message box
                    MessageBoxButtons.OK, // Button to show
                        MessageBoxIcon.Warning); // Icon to show//CANCEl c1 = new CANCEl();
            //this.Hide();
            //c1.Show();/*/
           MessageBox.Show("YOU HAVE BEEN CANCELD YOUR LOG_IN  :( !!!");
           HOME m = new HOME();
           this.Hide();
           m.Show();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (UTYPE.SelectedItem.ToString() == "ADMIN")
            //{
            //    ADMIN_PURPOSE a = new ADMIN_PURPOSE();
            //    this.Hide();
            //    a.Show();

            //}
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void PWD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //pictureBox3.Visible = true;    
            FORGETP p = new FORGETP();
                this.Hide();
                p.Show();
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             
              CHANGEP p = new CHANGEP();
              this.Hide();
              p.Show();

        }

        private void UNAME_TextChanged(object sender, EventArgs e)
        {
            
             /*string context = this.UNAME.Text;
             for (int i = 0; i < context.Length; i++)
              {

                if (char.IsLetter(context[i]))
                {

                }
                else
                {
                    MessageBox.Show("only alphabats are allowed");
                }
              }*/
          
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           /* HOME s2 = new HOME ();
            this.Hide();
            s2.Show(); */
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FORGETP fp = new FORGETP();
            this.Hide();
            fp.Show(); 
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CHANGEP cp = new CHANGEP();
            this.Hide();
            cp.Show();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
           // HOME cp = new HOME ();
           //this.Hide();
            //cp.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
           /* PictureBox picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(100, 50),
                Location = new Point(14, 17),
                Image = Image.FromFile(@"C:\Documents and Settings\205112012\Desktop\kalyani12"),
                SizeMode = PictureBoxSizeMode.CenterImage
            };
            //p.Controls.Add(picture);*/

        }

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string path = @"C:\Documents and Settings\205112012\Desktop\pcafterlab\THUMB IMAGES";
            string roll = UNAME.Text;
            fname1 = Path.Combine(path, roll);
            fname1 = fname1 + ".jpg";
           // MessageBox.Show(fname1);
            pictureBox1.ImageLocation = fname1;
            //openFileDialog1.FileName = "";
            //openFileDialog1.Title = "Images";
            //openFileDialog1.Filter = "All Images|*.jpg; *.bmp; *.png";
            //openFileDialog1.ShowDialog();
            //if (openFileDialog1.FileName.ToString() != "")
            //{
            //    fname1 = openFileDialog1.FileName.ToString();
            //    pictureBox1.ImageLocation = fname1;
            //}
        }

        private void linkLabel2_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog2.FileName = "";
            openFileDialog2.Title = "Images";
            openFileDialog2.Filter = "All Images|*.jpg; *.bmp; *.png";
            openFileDialog2.ShowDialog();
            if (openFileDialog2.FileName.ToString() != "")
            {
                fname2 = openFileDialog2.FileName.ToString();
                pictureBox2.ImageLocation = fname2;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LOGIN_PAGE rp= new LOGIN_PAGE ();
            this.Hide();
            rp.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
