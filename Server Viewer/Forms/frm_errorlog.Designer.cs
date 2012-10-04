namespace Server_Viewer.Forms
{
    partial class frm_errorlog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_errorlog));
            this.button1 = new System.Windows.Forms.Button();
            frm_errorlog.tb_errors = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(537, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save to TXT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_errors
            // 
            frm_errorlog.tb_errors.Dock = System.Windows.Forms.DockStyle.Top;
            frm_errorlog.tb_errors.Location = new System.Drawing.Point(0, 0);
            frm_errorlog.tb_errors.Multiline = true;
            frm_errorlog.tb_errors.Name = "tb_errors";
            frm_errorlog.tb_errors.ReadOnly = true;
            frm_errorlog.tb_errors.Size = new System.Drawing.Size(537, 286);
            frm_errorlog.tb_errors.TabIndex = 2;
            // 
            // frm_errorlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(537, 313);
            this.Controls.Add(frm_errorlog.tb_errors);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_errorlog";
            this.Text = "Error Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public static System.Windows.Forms.TextBox tb_errors;
    }
}