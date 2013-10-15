using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_Entry_Project
{
    public partial class FACULTY_PURPOSE : Form
    {
        public FACULTY_PURPOSE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YOU HAVE CHOOSEN THE VALID PURPOSE. \n NOW YOU CAN ENTER !!!");
            LOGIN_PAGE l1 = new LOGIN_PAGE();
            this.Hide();
            l1.Show();
        }

        private void FACULTY_PURPOSE_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
