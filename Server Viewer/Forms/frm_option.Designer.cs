namespace Server_Viewer.forms
{
    partial class frm_option
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_option));
            this.tb_loginpath = new System.Windows.Forms.TextBox();
            this.bt_loginpath = new System.Windows.Forms.Button();
            this.bt_charpath = new System.Windows.Forms.Button();
            this.tb_charpath = new System.Windows.Forms.TextBox();
            this.bt_mappath = new System.Windows.Forms.Button();
            this.tb_mappath = new System.Windows.Forms.TextBox();
            this.btn_okey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.gb_color = new System.Windows.Forms.GroupBox();
            this.lb_debug = new System.Windows.Forms.Label();
            this.lb_sql = new System.Windows.Forms.Label();
            this.lb_notice = new System.Windows.Forms.Label();
            this.lb_info = new System.Windows.Forms.Label();
            this.lb_error = new System.Windows.Forms.Label();
            this.lb_warning = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.cb_oldrev = new System.Windows.Forms.CheckBox();
            this.cb_coloronoff = new System.Windows.Forms.CheckBox();
            this.gb_color.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_loginpath
            // 
            this.tb_loginpath.Location = new System.Drawing.Point(48, 12);
            this.tb_loginpath.Name = "tb_loginpath";
            this.tb_loginpath.ReadOnly = true;
            this.tb_loginpath.Size = new System.Drawing.Size(242, 20);
            this.tb_loginpath.TabIndex = 1;
            // 
            // bt_loginpath
            // 
            this.bt_loginpath.Location = new System.Drawing.Point(296, 12);
            this.bt_loginpath.Name = "bt_loginpath";
            this.bt_loginpath.Size = new System.Drawing.Size(27, 20);
            this.bt_loginpath.TabIndex = 2;
            this.bt_loginpath.Text = "...";
            this.bt_loginpath.UseVisualStyleBackColor = true;
            this.bt_loginpath.Click += new System.EventHandler(this.bt_loginpath_Click);
            // 
            // bt_charpath
            // 
            this.bt_charpath.Location = new System.Drawing.Point(296, 38);
            this.bt_charpath.Name = "bt_charpath";
            this.bt_charpath.Size = new System.Drawing.Size(27, 20);
            this.bt_charpath.TabIndex = 4;
            this.bt_charpath.Text = "...";
            this.bt_charpath.UseVisualStyleBackColor = true;
            this.bt_charpath.Click += new System.EventHandler(this.bt_charpath_Click);
            // 
            // tb_charpath
            // 
            this.tb_charpath.Location = new System.Drawing.Point(48, 38);
            this.tb_charpath.Name = "tb_charpath";
            this.tb_charpath.ReadOnly = true;
            this.tb_charpath.Size = new System.Drawing.Size(242, 20);
            this.tb_charpath.TabIndex = 3;
            // 
            // bt_mappath
            // 
            this.bt_mappath.Location = new System.Drawing.Point(296, 64);
            this.bt_mappath.Name = "bt_mappath";
            this.bt_mappath.Size = new System.Drawing.Size(27, 20);
            this.bt_mappath.TabIndex = 6;
            this.bt_mappath.Text = "...";
            this.bt_mappath.UseVisualStyleBackColor = true;
            this.bt_mappath.Click += new System.EventHandler(this.bt_mappath_Click);
            // 
            // tb_mappath
            // 
            this.tb_mappath.Location = new System.Drawing.Point(48, 64);
            this.tb_mappath.Name = "tb_mappath";
            this.tb_mappath.ReadOnly = true;
            this.tb_mappath.Size = new System.Drawing.Size(242, 20);
            this.tb_mappath.TabIndex = 5;
            // 
            // btn_okey
            // 
            this.btn_okey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_okey.BackgroundImage")));
            this.btn_okey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_okey.Location = new System.Drawing.Point(9, 256);
            this.btn_okey.Name = "btn_okey";
            this.btn_okey.Size = new System.Drawing.Size(152, 40);
            this.btn_okey.TabIndex = 0;
            this.btn_okey.UseVisualStyleBackColor = true;
            this.btn_okey.Click += new System.EventHandler(this.btn_okey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Char:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Map:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancel.BackgroundImage")));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(170, 256);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(153, 40);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // gb_color
            // 
            this.gb_color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gb_color.BackgroundImage")));
            this.gb_color.Controls.Add(this.lb_debug);
            this.gb_color.Controls.Add(this.lb_sql);
            this.gb_color.Controls.Add(this.lb_notice);
            this.gb_color.Controls.Add(this.lb_info);
            this.gb_color.Controls.Add(this.lb_error);
            this.gb_color.Controls.Add(this.lb_warning);
            this.gb_color.Controls.Add(this.lb_status);
            this.gb_color.Controls.Add(this.cb_oldrev);
            this.gb_color.Controls.Add(this.cb_coloronoff);
            this.gb_color.Location = new System.Drawing.Point(9, 92);
            this.gb_color.Name = "gb_color";
            this.gb_color.Size = new System.Drawing.Size(313, 94);
            this.gb_color.TabIndex = 11;
            this.gb_color.TabStop = false;
            this.gb_color.Text = "Color settings";
            // 
            // lb_debug
            // 
            this.lb_debug.AutoSize = true;
            this.lb_debug.Location = new System.Drawing.Point(6, 67);
            this.lb_debug.Name = "lb_debug";
            this.lb_debug.Size = new System.Drawing.Size(45, 13);
            this.lb_debug.TabIndex = 8;
            this.lb_debug.Text = "[Debug]";
            this.lb_debug.Click += new System.EventHandler(this.lb_debug_Click);
            // 
            // lb_sql
            // 
            this.lb_sql.AutoSize = true;
            this.lb_sql.Location = new System.Drawing.Point(242, 39);
            this.lb_sql.Name = "lb_sql";
            this.lb_sql.Size = new System.Drawing.Size(34, 13);
            this.lb_sql.TabIndex = 7;
            this.lb_sql.Text = "[SQL]";
            this.lb_sql.Click += new System.EventHandler(this.lb_sql_Click);
            // 
            // lb_notice
            // 
            this.lb_notice.AutoSize = true;
            this.lb_notice.Location = new System.Drawing.Point(192, 39);
            this.lb_notice.Name = "lb_notice";
            this.lb_notice.Size = new System.Drawing.Size(44, 13);
            this.lb_notice.TabIndex = 6;
            this.lb_notice.Text = "[Notice]";
            this.lb_notice.Click += new System.EventHandler(this.lb_notice_Click);
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.Location = new System.Drawing.Point(155, 39);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(31, 13);
            this.lb_info.TabIndex = 5;
            this.lb_info.Text = "[Info]";
            this.lb_info.Click += new System.EventHandler(this.lb_info_Click);
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.Location = new System.Drawing.Point(114, 39);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(35, 13);
            this.lb_error.TabIndex = 4;
            this.lb_error.Text = "[Error]";
            this.lb_error.Click += new System.EventHandler(this.lb_error_Click);
            // 
            // lb_warning
            // 
            this.lb_warning.AutoSize = true;
            this.lb_warning.Location = new System.Drawing.Point(55, 39);
            this.lb_warning.Name = "lb_warning";
            this.lb_warning.Size = new System.Drawing.Size(53, 13);
            this.lb_warning.TabIndex = 3;
            this.lb_warning.Text = "[Warning]";
            this.lb_warning.Click += new System.EventHandler(this.lb_warning_Click);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(6, 39);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(43, 13);
            this.lb_status.TabIndex = 2;
            this.lb_status.Text = "[Status]";
            this.lb_status.Click += new System.EventHandler(this.lb_status_Click);
            // 
            // cb_oldrev
            // 
            this.cb_oldrev.AutoSize = true;
            this.cb_oldrev.Enabled = false;
            this.cb_oldrev.Location = new System.Drawing.Point(104, 19);
            this.cb_oldrev.Name = "cb_oldrev";
            this.cb_oldrev.Size = new System.Drawing.Size(132, 17);
            this.cb_oldrev.TabIndex = 1;
            this.cb_oldrev.Text = "Revision 1580 or older";
            this.cb_oldrev.UseVisualStyleBackColor = true;
            this.cb_oldrev.CheckedChanged += new System.EventHandler(this.cb_oldrev_CheckedChanged);
            // 
            // cb_coloronoff
            // 
            this.cb_coloronoff.AutoSize = true;
            this.cb_coloronoff.Location = new System.Drawing.Point(6, 19);
            this.cb_coloronoff.Name = "cb_coloronoff";
            this.cb_coloronoff.Size = new System.Drawing.Size(92, 17);
            this.cb_coloronoff.TabIndex = 0;
            this.cb_coloronoff.Text = "Activate Color";
            this.cb_coloronoff.UseVisualStyleBackColor = true;
            this.cb_coloronoff.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frm_option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(335, 308);
            this.Controls.Add(this.gb_color);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_okey);
            this.Controls.Add(this.bt_mappath);
            this.Controls.Add(this.tb_mappath);
            this.Controls.Add(this.bt_charpath);
            this.Controls.Add(this.tb_charpath);
            this.Controls.Add(this.bt_loginpath);
            this.Controls.Add(this.tb_loginpath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_option";
            this.Text = "ServerMonitor - Option";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_option_FormClosing);
            this.Load += new System.EventHandler(this.start_Load);
            this.gb_color.ResumeLayout(false);
            this.gb_color.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_loginpath;
        private System.Windows.Forms.Button bt_loginpath;
        private System.Windows.Forms.Button bt_charpath;
        private System.Windows.Forms.TextBox tb_charpath;
        private System.Windows.Forms.Button bt_mappath;
        private System.Windows.Forms.TextBox tb_mappath;
        private System.Windows.Forms.Button btn_okey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox gb_color;
        private System.Windows.Forms.Label lb_warning;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.CheckBox cb_oldrev;
        private System.Windows.Forms.CheckBox cb_coloronoff;
        private System.Windows.Forms.Label lb_notice;
        private System.Windows.Forms.Label lb_info;
        private System.Windows.Forms.Label lb_error;
        private System.Windows.Forms.Label lb_sql;
        private System.Windows.Forms.Label lb_debug;
    }
}