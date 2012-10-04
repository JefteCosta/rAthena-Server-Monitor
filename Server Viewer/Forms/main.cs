using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using Server_Viewer.forms;
using Server_Viewer.Forms;

/* 
 * ToDo Rewrite the Code Idiot!
 * You can make it smaller & Better!
 * But nooooo just sit there and look at the Wall!
 * Nice one Bro!
*/

namespace Server_Viewer
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            try
            {
                //frm_errorlog.tb_errors = new System.Windows.Forms.TextBox();
            }
            catch { }
        }

        private static Boolean onoff = false;
        private static Boolean traymsg = false;

        private static int debugmsgs = 0;
        private static int sqlmsgs = 0;
        private static int errormsgs = 0;
        private static int playermsgs = 0;
        private static int warnmsgs = 0;
        private Point p;

        private void main_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\SM_config.ini"))
            {
                handler.inicreate();
            }
            else
            {
                handler.iniread();
            }

            //tray.Visible = true;

            lb_debug.BackColor = Color.Transparent;
            lb_sql.BackColor = Color.Transparent;
            lb_error.BackColor = Color.Transparent;
            lb_users.BackColor = Color.Transparent;
            lb_warnings.BackColor = Color.Transparent;
            //label2.BackColor = Color.Transparent;

            panel.BackColor = Color.Transparent;

            label1.Focus();

            lb_close.BackColor = Color.Transparent;
            lb_minimaze.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;


            lb_debug.Text = "Debug: " + debugmsgs;
            lb_sql.Text = "SQL: " + sqlmsgs;
            lb_error.Text = "Error: " + errormsgs;
            lb_users.Text = "" + playermsgs;
            lb_warnings.Text = "Warning: " + warnmsgs;
        }

        private void run_Click(object sender, EventArgs e)
        {
            if (!onoff)
            {
                onoff = true;

                try
                {
                    try
                    {
                        KillAll(procnamecfg(handler.loginexepath));
                        KillAll(procnamecfg(handler.charexepath));
                        KillAll(procnamecfg(handler.mapexepath));
                    }
                    catch
                    {

                    }
                    RTBLogin.Clear();
                    RTBChar.Clear();
                    RTBMap.Clear();
                    RunWithRedirect(handler.loginexepath);
                    RunWithRedirect(handler.charexepath);
                    RunWithRedirect(handler.mapexepath);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "\n" + err.StackTrace);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (onoff)
            {
                onoff = false;
                debugmsgs = 0;
                sqlmsgs = 0;
                errormsgs = 0;
                warnmsgs = 0;
                playermsgs = 0;
                lb_debug.Text = "Debug: " + debugmsgs;
                lb_sql.Text = "SQL: " + sqlmsgs;
                lb_error.Text = "Error: " + errormsgs;
                lb_users.Text = "" + playermsgs;
                lb_warnings.Text = "Warning: " + warnmsgs;
                KillAll(procnamecfg(handler.loginexepath));
                KillAll(procnamecfg(handler.charexepath));
                KillAll(procnamecfg(handler.mapexepath));
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
                KillAll(procnamecfg(handler.loginexepath));
                KillAll(procnamecfg(handler.charexepath));
                KillAll(procnamecfg(handler.mapexepath));
                Process me = Process.GetCurrentProcess();
                int i = 0;
                bool flag = true;
                while (flag)
                {
                    me.Threads[i].Dispose();
                    i++;
                    flag = i < me.Threads.Count;

                }
        }

        //VARS
        public Process _process = null;

        //Handlers and Functions
        public void KillAll(string ProcessName)
        {
            foreach (Process p in Process.GetProcesses())
            {
                try
                {
                    if (p.ProcessName.ToLower().Contains(ProcessName.ToLower()) == true)
                    {
                        p.Kill();
                    }
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "\n" + err.StackTrace);
                }
            }
        }

        public string procnamecfg(string cfgname)
        {
                string ret = cfgname.Substring(cfgname.LastIndexOf("\\") + 1, (cfgname.LastIndexOf(".") - 1 - cfgname.LastIndexOf("\\")));
                return ret;
        }

        public void RunWithRedirect(string cmdPath)
        {
            try
            {
                var proc = new Process();

                proc.StartInfo.FileName = cmdPath;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.WorkingDirectory = cmdPath.Substring(0, cmdPath.Length - (cmdPath.Length - cmdPath.LastIndexOf('\\')));
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.EnableRaisingEvents = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.ErrorDataReceived += proc_DataReceived;
                proc.OutputDataReceived += proc_DataReceived;
                proc.Exited += proc_HasExited;
                proc.Start();
                proc.BeginErrorReadLine();
                proc.BeginOutputReadLine();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + "\n\n" + err.StackTrace);
            }
        }

        public void proc_HasExited(object sender, EventArgs e)
        {

            string loginn = procnamecfg(handler.loginexepath);
            string charr = procnamecfg(handler.charexepath);
            string mapp = procnamecfg(handler.mapexepath);
            Process cproc = ((Process)sender);
            string switchval = cproc.ProcessName.ToLower();

            if (switchval == loginn.ToLower())
            {

                Invoke(new MethodInvoker(delegate { RTBLogin.AppendText(">>Login Server - stopped<<" + Environment.NewLine); }));

            }
            if (switchval == charr.ToLower())
            {

                Invoke(new MethodInvoker(delegate { RTBChar.AppendText(">>Char Server - stopped<<" + Environment.NewLine); }));

            }
            if (switchval == mapp.ToLower())
            {

                Invoke(new MethodInvoker(delegate { RTBMap.AppendText(">>Map Server - stopped<<" + Environment.NewLine); }));

            }

        }
        #region Empfänger, RTB Eintragungen
        public void proc_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                string loginn = procnamecfg(handler.loginexepath);
                string charr = procnamecfg(handler.charexepath);
                string mapp = procnamecfg(handler.mapexepath);
                Process cproc = ((Process)sender);
                string switchval = cproc.ProcessName.ToLower();

                if (switchval == loginn.ToLower())
                {
                    Invoke(new MethodInvoker(delegate
                    {
                        #region information
                        if (e.Data.Contains("[Error]"))
                        {
                            errormsgs = errormsgs + 1;
                            lb_error.Text = "Error: " + errormsgs;
                        }
                        else if (e.Data.Contains("[Debug]"))
                        {
                            debugmsgs = debugmsgs + 1;
                            lb_debug.Text = "Debug: " + debugmsgs;
                        }
                        else if (e.Data.Contains("[SQL]"))
                        {
                            sqlmsgs = sqlmsgs + 1;
                            lb_sql.Text = "SQL: " + sqlmsgs;
                        }
                        else if (e.Data.Contains("[Warning]"))
                        {
                            warnmsgs = warnmsgs + 1;
                            lb_warnings.Text = "Warning: " + warnmsgs;
                        }
                        else if (e.Data.Contains("set users"))
                        {
                            try
                            {
                                if (handler.colorOLDREV)
                                {
                                    string[] playercount = e.Data.Split(new Char[] { ':' });
                                    lb_users.Text = playercount[3];
                                }
                                else
                                {
                                    string[] playercount = e.Data.Split(new Char[] { ':' });
                                    lb_users.Text = playercount[2];
                                }
                            }
                            catch
                            {
                                lb_users.Text = "-GetFail-";
                            }
                        }
                        #endregion
                        if (handler.colorMODE)
                        {
                            if (!handler.colorOLDREV)
                            {
                                #region Color Text REV 16400+
                                if (e.Data.Contains("[Status]"))
                                {
                                    handler.AppendText(RTBLogin, "[Status]", handler.Status);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 8);
                                    RTBLogin.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Info]"))
                                {
                                    handler.AppendText(RTBLogin, "[Info]", handler.Info);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 6);
                                    RTBLogin.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Notice]"))
                                {
                                    handler.AppendText(RTBLogin, "[Notice]", handler.Notice);

                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 8);
                                    RTBLogin.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Warning]"))
                                {
                                    handler.AppendText(RTBLogin, "[Warning]", handler.Warning);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 9);
                                    RTBLogin.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Error]"))
                                {
                                    frm_errorlog.tb_errors.AppendText("[Login][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine);
                                    handler.AppendText(RTBLogin, "[Error]", handler.Error);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 7);
                                    RTBLogin.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[SQL]"))
                                {
                                    handler.AppendText(RTBLogin, "[SQL]", handler.SQL);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 5);
                                    RTBLogin.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Debug]"))
                                {
                                    handler.AppendText(RTBLogin, "[Debug]", handler.Debug);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 7);
                                    RTBLogin.AppendText(NewEData + Environment.NewLine);
                                }
                                else
                                {
                                    RTBLogin.AppendText(e.Data + Environment.NewLine);
                                }
                                #endregion
                            }
                            else
                            {
                                #region Color Text REV 16400-
                                string[] RTBLs = e.Data.Split(new Char[] { ']' });
                                if (e.Data.Contains("[Status]"))
                                {
                                    try
                                    {
                                        handler.AppendText(RTBLogin, "[Status]", handler.Status);
                                        RTBLogin.AppendText(RTBLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        handler.AppendText(RTBLogin, "[Status]", handler.Status);
                                        RTBLogin.AppendText(RTBLs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[Info]"))
                                {
                                    try
                                    {
                                        handler.AppendText(RTBLogin, "[Info]", handler.Info);
                                        RTBLogin.AppendText(RTBLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        handler.AppendText(RTBLogin, "[Info]", handler.Info);
                                        RTBLogin.AppendText(RTBLs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[Notice]"))
                                {
                                    try
                                    {
                                        handler.AppendText(RTBLogin, "[Notice]", handler.Notice);
                                        RTBLogin.AppendText(RTBLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        handler.AppendText(RTBLogin, "[Notice]", handler.Notice);
                                        RTBLogin.AppendText(RTBLs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[Warning]"))
                                {
                                    try
                                    {
                                        handler.AppendText(RTBLogin, "[Warning]", handler.Warning);
                                        RTBLogin.AppendText(RTBLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        handler.AppendText(RTBLogin, "[Warning]", handler.Warning);
                                        RTBLogin.AppendText(RTBLs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[Error]"))
                                {
                                    frm_errorlog.tb_errors.AppendText("[Login][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine);

                                    try
                                    {
                                        handler.AppendText(RTBLogin, "[Error]", handler.Error);
                                        RTBLogin.AppendText(RTBLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        handler.AppendText(RTBLogin, "[Error]", handler.Error);
                                        RTBLogin.AppendText(RTBLs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[SQL]"))
                                {
                                    try
                                    {
                                        handler.AppendText(RTBLogin, "[SQL]", handler.SQL);
                                        RTBLogin.AppendText(RTBLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        handler.AppendText(RTBLogin, "[SQL]", handler.SQL);
                                        RTBLogin.AppendText(RTBLs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[Debug]"))
                                {
                                    try
                                    {
                                        handler.AppendText(RTBLogin, "[Debug]", handler.Debug);
                                        RTBLogin.AppendText(RTBLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        handler.AppendText(RTBLogin, "[Debug]", handler.Debug);
                                        RTBLogin.AppendText(RTBLs[1] + Environment.NewLine);
                                    }

                                }
                                else
                                {
                                    RTBLogin.AppendText(e.Data + Environment.NewLine);
                                }
                                #endregion
                            }
                        }
                        else
                        {
                            RTBLogin.AppendText(e.Data + Environment.NewLine);
                            if (e.Data.Contains("[Error]"))
                            {
                                frm_errorlog.tb_errors.AppendText("[Login][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine);
                            }
                        }

                    }));

                }
                if (switchval == charr.ToLower())
                {
                    Invoke(new MethodInvoker(delegate
                    {
                        #region information
                        if (e.Data.Contains("[Error]"))
                        {
                            errormsgs = errormsgs + 1;
                            lb_error.Text = "Error: " + errormsgs;
                        }
                        else if (e.Data.Contains("[Debug]"))
                        {
                            debugmsgs = debugmsgs + 1;
                            lb_debug.Text = "Debug: " + debugmsgs;
                        }
                        else if (e.Data.Contains("[SQL]"))
                        {
                            sqlmsgs = sqlmsgs + 1;
                            lb_sql.Text = "SQL: " + sqlmsgs;
                        }
                        else if (e.Data.Contains("[Warning]"))
                        {
                            warnmsgs = warnmsgs + 1;
                            lb_warnings.Text = "Warning: " + warnmsgs;
                        }
                        #endregion
                        if (handler.colorMODE)
                        {
                            if (!handler.colorOLDREV)
                            {
                                #region Color Text REV 16400+
                                if (e.Data.Contains("[Status]"))
                                {
                                    handler.AppendText(RTBChar, "[Status]", handler.Status);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 8);
                                    RTBChar.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Info]"))
                                {
                                    handler.AppendText(RTBChar, "[Info]", handler.Info);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 6);
                                    RTBChar.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Notice]"))
                                {
                                    handler.AppendText(RTBChar, "[Notice]", handler.Notice);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 8);
                                    RTBChar.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Warning]"))
                                {
                                    handler.AppendText(RTBChar, "[Warning]", handler.Warning);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 9);
                                    RTBChar.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Error]"))
                                {
                                        frm_errorlog.tb_errors.AppendText("[Char][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine);
                                    handler.AppendText(RTBChar, "[Error]", handler.Error);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 7);
                                    RTBChar.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[SQL]"))
                                {
                                    handler.AppendText(RTBChar, "[SQL]", handler.SQL);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 5);
                                    RTBChar.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Debug]"))
                                {
                                    handler.AppendText(RTBChar, "[Debug]", handler.Debug);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 7);
                                    RTBChar.AppendText(NewEData + Environment.NewLine);
                                }
                                else
                                {
                                    RTBChar.AppendText(e.Data + Environment.NewLine);
                                }
                                #endregion
                            }
                            else
                            {
                                #region Color Text REV 16400-
                                string[] RTBCs = e.Data.Split(new Char[] { ']' });
                                if (e.Data.Contains("[Status]"))
                                {
                                    try
                                    {
                                        handler.AppendText(RTBChar, "[Status]", handler.Status);
                                        RTBChar.AppendText(RTBCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        handler.AppendText(RTBChar, "[Status]", handler.Status);
                                        RTBChar.AppendText(RTBCs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[Info]"))
                                {
                                    try
                                    {
                                        handler.AppendText(RTBChar, "[Info]", handler.Info);
                                        RTBChar.AppendText(RTBCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        handler.AppendText(RTBChar, "[Info]", handler.Info);
                                        RTBChar.AppendText(RTBCs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[Notice]"))
                                {
                                    try
                                    {
                                        handler.AppendText(RTBChar, "[Notice]", handler.Notice);
                                        RTBChar.AppendText(RTBCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        handler.AppendText(RTBChar, "[Notice]", handler.Notice);
                                        RTBChar.AppendText(RTBCs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[Warning]"))
                                {
                                    try
                                    {
                                        handler.AppendText(RTBChar, "[Warning]", handler.Warning);
                                        RTBChar.AppendText(RTBCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        handler.AppendText(RTBChar, "[Warning]", handler.Warning);
                                        RTBChar.AppendText(RTBCs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[Error]"))
                                {
                                        frm_errorlog.tb_errors.AppendText("[Char][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine);
                                    try
                                    {
                                        handler.AppendText(RTBChar, "[Error]", handler.Error);
                                        RTBChar.AppendText(RTBCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        handler.AppendText(RTBChar, "[Error]", handler.Error);
                                        RTBChar.AppendText(RTBCs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[SQL]"))
                                {
                                    try
                                    {
                                        handler.AppendText(RTBChar, "[SQL]", handler.SQL);
                                        RTBChar.AppendText(RTBCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        handler.AppendText(RTBChar, "[SQL]", handler.SQL);
                                        RTBChar.AppendText(RTBCs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[Debug]"))
                                {
                                    try
                                    {
                                        handler.AppendText(RTBChar, "[Debug]", handler.Debug);
                                        RTBChar.AppendText(RTBCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        handler.AppendText(RTBChar, "[Debug]", handler.Debug);
                                        RTBChar.AppendText(RTBCs[1] + Environment.NewLine);
                                    }

                                }
                                else
                                {
                                    RTBChar.AppendText(e.Data + Environment.NewLine);
                                }
                                #endregion
                            }
                        }
                        else
                        {
                            if (e.Data.Contains("[Error]"))
                            {
                                frm_errorlog.tb_errors.AppendText("[Char][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine);
                            }
                            RTBChar.AppendText(e.Data + Environment.NewLine);
                        }
                    }));

                }
                if (switchval == mapp.ToLower())
                {

                    Invoke(new MethodInvoker(delegate
                    {
                        #region information
                        if (e.Data.Contains("[Error]"))
                        {
                                frm_errorlog.tb_errors.AppendText("[Error][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine);
                            errormsgs = errormsgs + 1;
                            lb_error.Text = "Error: " + errormsgs;
                        }
                        else if (e.Data.Contains("[Debug]"))
                        {
                            debugmsgs = debugmsgs + 1;
                            lb_debug.Text = "Debug: " + debugmsgs;
                        }
                        else if (e.Data.Contains("[SQL]"))
                        {
                            sqlmsgs = sqlmsgs + 1;
                            lb_sql.Text = "SQL: " + sqlmsgs;
                        }
                        else if (e.Data.Contains("[Warning]"))
                        {
                            warnmsgs = warnmsgs + 1;
                            lb_warnings.Text = "Warning: " + warnmsgs;
                        }
                        #endregion
                        if (handler.colorMODE)
                        {
                            #region color text
                            if (e.Data.Contains("[Status]"))
                            {
                                handler.AppendText(RTBMap, "[Status]", handler.Status);
                                String OriEData = e.Data; String NewEData = OriEData.Remove(0, 8);
                                RTBMap.AppendText(NewEData + Environment.NewLine);
                            }
                            else if (e.Data.Contains("[Info]"))
                            {
                                handler.AppendText(RTBMap, "[Info]", handler.Info);
                                String OriEData = e.Data; String NewEData = OriEData.Remove(0, 6);
                                RTBMap.AppendText(NewEData + Environment.NewLine);
                            }
                            else if (e.Data.Contains("[Notice]"))
                            {
                                handler.AppendText(RTBMap, "[Notice]", handler.Notice);
                                String OriEData = e.Data; String NewEData = OriEData.Remove(0, 8);
                                RTBMap.AppendText(NewEData + Environment.NewLine);
                            }
                            else if (e.Data.Contains("[Warning]"))
                            {
                                handler.AppendText(RTBMap, "[Warning]", handler.Warning);
                                String OriEData = e.Data; String NewEData = OriEData.Remove(0, 9);
                                RTBMap.AppendText(NewEData + Environment.NewLine);
                            }
                            else if (e.Data.Contains("[Error]"))
                            {
                                    frm_errorlog.tb_errors.AppendText("[Error][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine);
                                handler.AppendText(RTBMap, "[Error]", handler.Error);
                                String OriEData = e.Data; String NewEData = OriEData.Remove(0, 7);
                                RTBMap.AppendText(NewEData + Environment.NewLine);
                            }
                            else if (e.Data.Contains("[SQL]"))
                            {
                                handler.AppendText(RTBMap, "[SQL]", handler.SQL);
                                String OriEData = e.Data; String NewEData = OriEData.Remove(0, 5);
                                RTBMap.AppendText(NewEData + Environment.NewLine);
                            }
                            else if (e.Data.Contains("[Debug]"))
                            {
                                handler.AppendText(RTBMap, "[Debug]", handler.Debug);
                                String OriEData = e.Data; String NewEData = OriEData.Remove(0, 7);
                                RTBMap.AppendText(NewEData + Environment.NewLine);
                            }
                            else
                            {
                                RTBMap.AppendText(e.Data + Environment.NewLine);
                                if (e.Data.Contains("[Error]"))
                                {
                                    frm_errorlog.tb_errors.AppendText("[Error][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine);
                                }
                            }
                            #endregion
                        }
                        else
                        {
                            RTBMap.AppendText(e.Data + Environment.NewLine);
                            if (e.Data.Contains("[Error]"))
                            {
                                frm_errorlog.tb_errors.AppendText("[Error][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine);
                            }
                        }
                    }));

                }
            }
        }
        #endregion
        #region close smalli
        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            KillAll(procnamecfg(handler.loginexepath));
            KillAll(procnamecfg(handler.charexepath));
            KillAll(procnamecfg(handler.mapexepath));
        }

        private void RTBLogin_TextChanged(object sender, EventArgs e)
        {
            RTBLogin.ScrollToCaret();
        }

        private void RTBChar_TextChanged(object sender, EventArgs e)
        {
            RTBChar.ScrollToCaret();
        }

        private void RTBMap_TextChanged(object sender, EventArgs e)
        {
            RTBMap.ScrollToCaret();
        }

        private void option_Click(object sender, EventArgs e)
        {
            frm_option frm_opt = new frm_option();
            if (!handler.openopt)
            {
                frm_opt.Show();
                handler.openopt = true;
            }
            else
            {
                //int hwnd = frm_opt.Handle.ToInt32();
                //SetForegroundWindow(hwnd);
                handler.SetForegroundWindowEx(frm_opt);
            }
        }

        private void main_MouseDown(object sender, MouseEventArgs e)
        {
            p.X = e.X;
            p.Y = e.Y;
        }

        private void main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - p.X;
                Top += e.Y - p.Y;
            }
        }

        private void lb_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lb_minimaze_Click(object sender, EventArgs e)
        {
            tray.Visible = true;
            if (!traymsg)
            {
                tray.BalloonTipTitle = "Server Monitor";
                tray.BalloonTipText = "Minimazed to tray.";
                traymsg = true;
                tray.ShowBalloonTip(250);
            }
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
         }
        #endregion

        private void tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            tray.Visible = false;
        }

        private void tray_MouseClick(object sender, MouseEventArgs e)
        {
           /*if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("lol");
            }*/
        }
        #region Text Changed
        private void lb_users_TextChanged(object sender, EventArgs e)
        {
            tc_player.Text = "Player: " + lb_users.Text;
        }

        private void lb_warnings_TextChanged(object sender, EventArgs e)
        {
            tc_warning.Text = lb_warnings.Text;
        }

        private void lb_error_TextChanged(object sender, EventArgs e)
        {
            tc_error.Text = lb_error.Text;
        }

        private void lb_sql_TextChanged(object sender, EventArgs e)
        {
            tc_sql.Text = lb_sql.Text;
        }

        private void lb_debug_TextChanged(object sender, EventArgs e)
        {
            tc_debug.Text = lb_debug.Text;
        }
#endregion

        private void tc_restore_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            tray.Visible = false;
        }

        private void tc_startstop_Click(object sender, EventArgs e)
        {
            if (onoff)
            {
                onoff = false;
                debugmsgs = 0;
                sqlmsgs = 0;
                errormsgs = 0;
                warnmsgs = 0;
                playermsgs = 0;
                lb_debug.Text = "Debug: " + debugmsgs;
                lb_sql.Text = "SQL: " + sqlmsgs;
                lb_error.Text = "Error: " + errormsgs;
                lb_users.Text = "" + playermsgs;
                lb_warnings.Text = "Warning: " + warnmsgs;
                KillAll(procnamecfg(handler.loginexepath));
                KillAll(procnamecfg(handler.charexepath));
                KillAll(procnamecfg(handler.mapexepath));
            }
            else
            {
                onoff = true;

                try
                {
                    try
                    {
                        KillAll(procnamecfg(handler.loginexepath));
                        KillAll(procnamecfg(handler.charexepath));
                        KillAll(procnamecfg(handler.mapexepath));
                    }
                    catch
                    {

                    }
                    RTBLogin.Clear();
                    RTBChar.Clear();
                    RTBMap.Clear();
                    RunWithRedirect(handler.loginexepath);
                    RunWithRedirect(handler.charexepath);
                    RunWithRedirect(handler.mapexepath);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "\n" + err.StackTrace);
                }
            }
        }

        private void tc_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tc_about_Click(object sender, EventArgs e)
        {
            frm_about frm_abt = new frm_about();
            if (!handler.openabt)
            {
                frm_abt.Show();
                handler.openabt = true;
            }
            else
            {
                handler.SetForegroundWindowEx(frm_abt);
            }
            
        }

        private void tc_options_Click(object sender, EventArgs e)
        {
            frm_option frm_opt = new frm_option();
            if (!handler.openopt)
            {
                frm_opt.Show();
                handler.openopt = true;
            }
            else
            {
                handler.SetForegroundWindowEx(frm_opt);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            easteregg egg = new easteregg();
            egg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_errorlog error = new frm_errorlog();
            error.Show();
        }
    }
}
