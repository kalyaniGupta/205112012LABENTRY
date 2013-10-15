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
    public partial class SIGN_IN : Form
    {
        public SIGN_IN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN_PAGE l1 = new LOGIN_PAGE();
            this.Hide();
            l1.Show();
        }
    }
}
