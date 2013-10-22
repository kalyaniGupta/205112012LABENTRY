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
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            REGISTRATION_HOME s2 = new REGISTRATION_HOME();
            this.Hide();
            s2.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           CHANGEP cp = new CHANGEP();
            this.Hide();
            cp.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FORGETP fp = new FORGETP();
            this.Hide();
            fp.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             LOGOUT lg = new LOGOUT();
            this.Hide();
            lg.Show();
        }

        private void HOME_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           LOGIN_PAGE  lg = new LOGIN_PAGE();
            this.Hide();
            lg.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
