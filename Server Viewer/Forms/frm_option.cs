using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Server_Viewer;
using System.IO;

namespace Server_Viewer.forms
{
    public partial class frm_option : Form
    {
        public frm_option()
        {
            InitializeComponent();
        }

        TextDatei c_textdatei = new TextDatei();
        string configmainpath = Application.StartupPath + @"\ServerMonitor.txt";

        private void bt_loginpath_Click(object sender, EventArgs e)
        {
            string Pfad = string.Empty;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Login (*.exe)|*.exe|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Pfad = openFileDialog1.FileName;
                handler.loginexepath = Pfad;
                this.tb_loginpath.Text = Pfad;
            }
        }

        private void bt_charpath_Click(object sender, EventArgs e)
        {
            string Pfad = string.Empty;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Char (*.exe)|*.exe|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Pfad = openFileDialog1.FileName;
                handler.charexepath = Pfad;
                this.tb_charpath.Text = Pfad;
            }
        }

        private void bt_mappath_Click(object sender, EventArgs e)
        {
            string Pfad = string.Empty;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Map (*.exe)|*.exe|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Pfad = openFileDialog1.FileName;
                handler.mapexepath = Pfad;
                this.tb_mappath.Text = Pfad;
            }
        }

        private void start_Load(object sender, EventArgs e)
        {
            lb_status.ForeColor = handler.Status;
            lb_debug.ForeColor = handler.Debug;
            lb_error.ForeColor = handler.Error;
            lb_info.ForeColor = handler.Info;
            lb_notice.ForeColor = handler.Notice;
            lb_sql.ForeColor = handler.SQL;
            lb_warning.ForeColor = handler.Warning;

            lb_status.BackColor = Color.Transparent;
            lb_debug.BackColor = Color.Transparent;
            lb_error.BackColor = Color.Transparent;
            lb_info.BackColor = Color.Transparent;
            lb_notice.BackColor = Color.Transparent;
            lb_sql.BackColor = Color.Transparent;
            lb_warning.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            gb_color.BackColor = Color.Transparent;

            tb_loginpath.Text = handler.loginexepath;
            tb_charpath.Text = handler.charexepath;
            tb_mappath.Text = handler.charexepath;

            if (handler.colorMODE)
                cb_coloronoff.Checked = true;

            if (handler.colorOLDREV)
                cb_oldrev.Checked = true;
        }
        #region buttons and loads
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_coloronoff.Checked)
                handler.colorMODE = true;
            else
                handler.colorMODE = false;
        }

        private void cb_oldrev_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_oldrev.Checked)
                handler.colorOLDREV = true;
            else
                handler.colorOLDREV = false;
        }

        private void lb_status_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lb_status.ForeColor = colorDlg.Color;
            handler.Status = colorDlg.Color;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_okey_Click(object sender, EventArgs e)
        {
            handler.saveopt();
            Close();
        }

        private void lb_warning_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lb_warning.ForeColor = colorDlg.Color;
            handler.Warning = colorDlg.Color;
        }

        private void lb_error_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lb_error.ForeColor = colorDlg.Color;
            handler.Error = colorDlg.Color;
        }

        private void lb_info_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lb_info.ForeColor = colorDlg.Color;
            handler.Info = colorDlg.Color;
        }

        private void lb_notice_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lb_notice.ForeColor = colorDlg.Color;
            handler.Notice = colorDlg.Color;
        }

        private void lb_sql_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lb_sql.ForeColor = colorDlg.Color;
            handler.SQL = colorDlg.Color;
        }

        private void lb_debug_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lb_debug.ForeColor = colorDlg.Color;
            handler.Debug = colorDlg.Color;
        }
        #endregion

        private void frm_option_FormClosing(object sender, FormClosingEventArgs e)
        {
            handler.openopt = false;
        }
    }
}
