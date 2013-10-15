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
    public partial class OTERS_PURPOSE : Form
    {
        public OTERS_PURPOSE()
        {
            InitializeComponent();
        }

        private void OTERS_PURPOSE_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YOU HAVE CHOOSEN THE VALID PURPOSE. \n NOW YOU CAN ENTER !!!");
            LOGIN_PAGE l1 = new LOGIN_PAGE();
            this.Hide();
            l1.Show();
        }
    }
}
