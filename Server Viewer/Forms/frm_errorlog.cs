using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server_Viewer.Forms
{
    public partial class frm_errorlog : Form
    {
        public frm_errorlog()
        {
            InitializeComponent();
            try
            {
                //frm_errorlog.tb_errors = new System.Windows.Forms.TextBox();
            }
            catch { }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TextDatei textiii = new TextDatei();
            textiii.WriteFile(Application.StartupPath + @"\"+Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "-errorlog-save.txt", tb_errors.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_errorlog.tb_errors.Text = "";
        }
    }
}
