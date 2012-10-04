using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Server_Viewer.Forms
{
    public partial class frm_about : Form
    {
        public frm_about()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("http://rathena.org/board/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("http://irataprojects.de/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("http://irataprojects.de/");
        }

        private void frm_about_FormClosing(object sender, FormClosingEventArgs e)
        {
            handler.openabt = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://rathena.org/board/topic/67465-server-monitor/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://creativecommons.org/licenses/by-nc-sa/3.0/");
        }

    }
}
