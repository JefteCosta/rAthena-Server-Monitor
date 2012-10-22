namespace Server_Viewer
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.lb_warnings = new System.Windows.Forms.Label();
            this.lb_users = new System.Windows.Forms.Label();
            this.lb_error = new System.Windows.Forms.Label();
            this.lb_sql = new System.Windows.Forms.Label();
            this.lb_debug = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.RTBLogin = new System.Windows.Forms.RichTextBox();
            this.RTBChar = new System.Windows.Forms.RichTextBox();
            this.RTBMap = new System.Windows.Forms.RichTextBox();
            this.btn_option = new System.Windows.Forms.Button();
            this.lb_close = new System.Windows.Forms.Label();
            this.lb_minimaze = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.traycon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tc_restore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tc_startstop = new System.Windows.Forms.ToolStripMenuItem();
            this.tc_options = new System.Windows.Forms.ToolStripMenuItem();
            this.tc_info = new System.Windows.Forms.ToolStripMenuItem();
            this.tc_player = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tc_error = new System.Windows.Forms.ToolStripMenuItem();
            this.tc_warning = new System.Windows.Forms.ToolStripMenuItem();
            this.tc_sql = new System.Windows.Forms.ToolStripMenuItem();
            this.tc_debug = new System.Windows.Forms.ToolStripMenuItem();
            this.tc_about = new System.Windows.Forms.ToolStripMenuItem();
            this.tc_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.traycon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_warnings
            // 
            this.lb_warnings.AutoSize = true;
            this.lb_warnings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_warnings.Location = new System.Drawing.Point(43, 49);
            this.lb_warnings.Name = "lb_warnings";
            this.lb_warnings.Size = new System.Drawing.Size(50, 13);
            this.lb_warnings.TabIndex = 33;
            this.lb_warnings.Text = "Warning:";
            this.lb_warnings.TextChanged += new System.EventHandler(this.lb_warnings_TextChanged);
            // 
            // lb_users
            // 
            this.lb_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_users.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_users.Location = new System.Drawing.Point(0, 0);
            this.lb_users.Name = "lb_users";
            this.lb_users.Size = new System.Drawing.Size(51, 19);
            this.lb_users.TabIndex = 32;
            this.lb_users.Text = "0";
            this.lb_users.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_users.TextChanged += new System.EventHandler(this.lb_users_TextChanged);
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_error.Location = new System.Drawing.Point(214, 49);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(32, 13);
            this.lb_error.TabIndex = 31;
            this.lb_error.Text = "Error:";
            this.lb_error.TextChanged += new System.EventHandler(this.lb_error_TextChanged);
            // 
            // lb_sql
            // 
            this.lb_sql.AutoSize = true;
            this.lb_sql.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_sql.Location = new System.Drawing.Point(477, 49);
            this.lb_sql.Name = "lb_sql";
            this.lb_sql.Size = new System.Drawing.Size(31, 13);
            this.lb_sql.TabIndex = 30;
            this.lb_sql.Text = "SQL:";
            this.lb_sql.TextChanged += new System.EventHandler(this.lb_sql_TextChanged);
            // 
            // lb_debug
            // 
            this.lb_debug.AutoSize = true;
            this.lb_debug.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_debug.Location = new System.Drawing.Point(658, 49);
            this.lb_debug.Name = "lb_debug";
            this.lb_debug.Size = new System.Drawing.Size(42, 13);
            this.lb_debug.TabIndex = 29;
            this.lb_debug.Text = "Debug:";
            this.lb_debug.TextChanged += new System.EventHandler(this.lb_debug_TextChanged);
            // 
            // btn_stop
            // 
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_stop.Image")));
            this.btn_stop.Location = new System.Drawing.Point(25, 457);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(120, 40);
            this.btn_stop.TabIndex = 35;
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_run
            // 
            this.btn_run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_run.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_run.Image = ((System.Drawing.Image)(resources.GetObject("btn_run.Image")));
            this.btn_run.Location = new System.Drawing.Point(85, 404);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(120, 40);
            this.btn_run.TabIndex = 34;
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.run_Click);
            // 
            // RTBLogin
            // 
            this.RTBLogin.BackColor = System.Drawing.SystemColors.ControlText;
            this.RTBLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.RTBLogin.Location = new System.Drawing.Point(211, 127);
            this.RTBLogin.Name = "RTBLogin";
            this.RTBLogin.ReadOnly = true;
            this.RTBLogin.Size = new System.Drawing.Size(512, 138);
            this.RTBLogin.TabIndex = 39;
            this.RTBLogin.Text = "Login Server... Waiting... ";
            this.RTBLogin.TextChanged += new System.EventHandler(this.RTBLogin_TextChanged);
            // 
            // RTBChar
            // 
            this.RTBChar.BackColor = System.Drawing.SystemColors.ControlText;
            this.RTBChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBChar.ForeColor = System.Drawing.Color.Gainsboro;
            this.RTBChar.Location = new System.Drawing.Point(211, 271);
            this.RTBChar.Name = "RTBChar";
            this.RTBChar.ReadOnly = true;
            this.RTBChar.Size = new System.Drawing.Size(512, 138);
            this.RTBChar.TabIndex = 40;
            this.RTBChar.Text = "Char Server... Waiting... ";
            this.RTBChar.TextChanged += new System.EventHandler(this.RTBChar_TextChanged);
            // 
            // RTBMap
            // 
            this.RTBMap.BackColor = System.Drawing.SystemColors.ControlText;
            this.RTBMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBMap.ForeColor = System.Drawing.Color.Gainsboro;
            this.RTBMap.Location = new System.Drawing.Point(211, 415);
            this.RTBMap.Name = "RTBMap";
            this.RTBMap.ReadOnly = true;
            this.RTBMap.Size = new System.Drawing.Size(512, 138);
            this.RTBMap.TabIndex = 41;
            this.RTBMap.Text = "Map Server... Waiting... ";
            this.RTBMap.TextChanged += new System.EventHandler(this.RTBMap_TextChanged);
            // 
            // btn_option
            // 
            this.btn_option.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_option.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_option.Image = ((System.Drawing.Image)(resources.GetObject("btn_option.Image")));
            this.btn_option.Location = new System.Drawing.Point(85, 503);
            this.btn_option.Name = "btn_option";
            this.btn_option.Size = new System.Drawing.Size(120, 40);
            this.btn_option.TabIndex = 42;
            this.btn_option.UseVisualStyleBackColor = true;
            this.btn_option.Click += new System.EventHandler(this.option_Click);
            // 
            // lb_close
            // 
            this.lb_close.AutoSize = true;
            this.lb_close.Location = new System.Drawing.Point(709, 69);
            this.lb_close.Name = "lb_close";
            this.lb_close.Size = new System.Drawing.Size(14, 13);
            this.lb_close.TabIndex = 43;
            this.lb_close.Text = "X";
            this.lb_close.Click += new System.EventHandler(this.lb_close_Click);
            // 
            // lb_minimaze
            // 
            this.lb_minimaze.AutoSize = true;
            this.lb_minimaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_minimaze.Location = new System.Drawing.Point(697, 68);
            this.lb_minimaze.Name = "lb_minimaze";
            this.lb_minimaze.Size = new System.Drawing.Size(12, 16);
            this.lb_minimaze.TabIndex = 44;
            this.lb_minimaze.Text = "-";
            this.lb_minimaze.Click += new System.EventHandler(this.lb_minimaze_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "v2.2.6";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lb_users);
            this.panel.Location = new System.Drawing.Point(349, 34);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(51, 19);
            this.panel.TabIndex = 46;
            // 
            // tray
            // 
            this.tray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tray.ContextMenuStrip = this.traycon;
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "Server-Monitor";
            this.tray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tray_MouseClick);
            this.tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tray_MouseDoubleClick);
            // 
            // traycon
            // 
            this.traycon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tc_restore,
            this.toolStripSeparator1,
            this.tc_startstop,
            this.tc_options,
            this.tc_info,
            this.tc_about,
            this.tc_exit});
            this.traycon.Name = "traycon";
            this.traycon.Size = new System.Drawing.Size(153, 164);
            // 
            // tc_restore
            // 
            this.tc_restore.Name = "tc_restore";
            this.tc_restore.Size = new System.Drawing.Size(152, 22);
            this.tc_restore.Text = "Restore";
            this.tc_restore.Click += new System.EventHandler(this.tc_restore_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // tc_startstop
            // 
            this.tc_startstop.Name = "tc_startstop";
            this.tc_startstop.Size = new System.Drawing.Size(152, 22);
            this.tc_startstop.Text = "Control";
            this.tc_startstop.Click += new System.EventHandler(this.tc_startstop_Click);
            // 
            // tc_options
            // 
            this.tc_options.Name = "tc_options";
            this.tc_options.Size = new System.Drawing.Size(152, 22);
            this.tc_options.Text = "Options";
            this.tc_options.Click += new System.EventHandler(this.tc_options_Click);
            // 
            // tc_info
            // 
            this.tc_info.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tc_player,
            this.toolStripSeparator2,
            this.tc_error,
            this.tc_warning,
            this.tc_sql,
            this.tc_debug});
            this.tc_info.Name = "tc_info";
            this.tc_info.Size = new System.Drawing.Size(152, 22);
            this.tc_info.Text = "Information";
            // 
            // tc_player
            // 
            this.tc_player.Name = "tc_player";
            this.tc_player.Size = new System.Drawing.Size(131, 22);
            this.tc_player.Text = "Players: 0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(128, 6);
            // 
            // tc_error
            // 
            this.tc_error.Name = "tc_error";
            this.tc_error.Size = new System.Drawing.Size(131, 22);
            this.tc_error.Text = "Error: 0";
            // 
            // tc_warning
            // 
            this.tc_warning.Name = "tc_warning";
            this.tc_warning.Size = new System.Drawing.Size(131, 22);
            this.tc_warning.Text = "Warning: 0";
            // 
            // tc_sql
            // 
            this.tc_sql.Name = "tc_sql";
            this.tc_sql.Size = new System.Drawing.Size(131, 22);
            this.tc_sql.Text = "SQL: 0";
            // 
            // tc_debug
            // 
            this.tc_debug.Name = "tc_debug";
            this.tc_debug.Size = new System.Drawing.Size(131, 22);
            this.tc_debug.Text = "Debug: 0";
            // 
            // tc_about
            // 
            this.tc_about.Name = "tc_about";
            this.tc_about.Size = new System.Drawing.Size(152, 22);
            this.tc_about.Text = "About";
            this.tc_about.Click += new System.EventHandler(this.tc_about_Click);
            // 
            // tc_exit
            // 
            this.tc_exit.Name = "tc_exit";
            this.tc_exit.Size = new System.Drawing.Size(152, 22);
            this.tc_exit.Text = "Exit";
            this.tc_exit.Click += new System.EventHandler(this.tc_exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(3, 2);
            this.label2.TabIndex = 47;
            this.label2.Text = " ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(191)))), ((int)(((byte)(62)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.button2.Location = new System.Drawing.Point(638, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 22);
            this.button2.TabIndex = 49;
            this.button2.Text = "Open Error log";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 580);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lb_minimaze);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_close);
            this.Controls.Add(this.btn_option);
            this.Controls.Add(this.RTBMap);
            this.Controls.Add(this.RTBChar);
            this.Controls.Add(this.RTBLogin);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.lb_warnings);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.lb_sql);
            this.Controls.Add(this.lb_debug);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Server Monitor";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.Load += new System.EventHandler(this.main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_MouseMove);
            this.panel.ResumeLayout(false);
            this.traycon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_warnings;
        private System.Windows.Forms.Label lb_users;
        private System.Windows.Forms.Label lb_error;
        private System.Windows.Forms.Label lb_sql;
        private System.Windows.Forms.Label lb_debug;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.RichTextBox RTBLogin;
        private System.Windows.Forms.RichTextBox RTBChar;
        private System.Windows.Forms.RichTextBox RTBMap;
        private System.Windows.Forms.Button btn_option;
        private System.Windows.Forms.Label lb_close;
        private System.Windows.Forms.Label lb_minimaze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.ContextMenuStrip traycon;
        private System.Windows.Forms.ToolStripMenuItem tc_startstop;
        private System.Windows.Forms.ToolStripMenuItem tc_info;
        private System.Windows.Forms.ToolStripMenuItem tc_warning;
        private System.Windows.Forms.ToolStripMenuItem tc_error;
        private System.Windows.Forms.ToolStripMenuItem tc_sql;
        private System.Windows.Forms.ToolStripMenuItem tc_debug;
        private System.Windows.Forms.ToolStripMenuItem tc_about;
        private System.Windows.Forms.ToolStripMenuItem tc_restore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tc_options;
        private System.Windows.Forms.ToolStripMenuItem tc_player;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tc_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;

    }
}

