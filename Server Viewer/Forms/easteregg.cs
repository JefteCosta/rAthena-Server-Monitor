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
    public partial class easteregg : Form
    {
        public easteregg()
        {
            InitializeComponent();
        }

        private void easteregg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fight();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fight();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fight();
        }

        private void fight()
        {
            button5.Visible = true;
        }

        int i1 = 2;
        int i2 = 5;
        int i3 = 2;

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (i1 > 0)
            {
                pictureBox3.Visible = true;
                i1 = i1 - 1;
            }
            else
            {
                pictureBox3.Visible = false;
                timer1.Start();
                timer2.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBar2.Value = i2;
            if (i2 > 0)
            {
                i2 = i2 - 1;
            }
            else
            {
                progressBar2.Value = 0;
                timer3.Start();
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (i3 > 0)
            {
                i3 = i3 - 1;
            }
            else
            {
                pictureBox2.Visible = false;
                groupBox2.Visible = true;
                button5.Visible = false;
                timer3.Stop();
            }
        }
    }
}
