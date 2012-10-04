using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using Ini;
using System.Runtime.InteropServices;


public static class handler
{
    public static Boolean colorMODE = true;
    public static Boolean colorOLDREV = false;

    public static Boolean openopt = false;
    public static Boolean openabt = false;


    public static Color Status = Color.Lime;
    public static Color Info = Color.White;
    public static Color Notice = Color.White;
    public static Color Warning = Color.Yellow;
    public static Color SQL = Color.PaleVioletRed;
    public static Color Debug = Color.Cyan;
    public static Color Error = Color.Red;

    public static Color SStatus = Color.Lime;
    public static Color SInfo = Color.White;
    public static Color SNotice = Color.White;
    public static Color SWarning = Color.Yellow;
    public static Color SSQL = Color.PaleVioletRed;
    public static Color SDebug = Color.Cyan;
    public static Color SError = Color.Red;

    public static string loginexepath = "/debug/location.exe";
    public static string charexepath = "/debug/location.exe";
    public static string mapexepath = "/debug/location.exe";



    public static void HighlightPhrase(RichTextBox box, string phrase, Color color)
    {
        int pos = box.SelectionStart;
        string s = box.Text;
        for (int ix = 0; ; )
        {
            int jx = s.IndexOf(phrase, ix, StringComparison.CurrentCultureIgnoreCase);
            if (jx < 0) break;
            box.SelectionStart = jx;
            box.SelectionLength = phrase.Length;
            box.SelectionColor = color;
            ix = jx + 1;
        }
        box.SelectionStart = pos;
        box.SelectionLength = 0;
    }

    public static void AppendText(this RichTextBox box, string text, Color color)
    {
        box.SelectionStart = box.TextLength;
        box.SelectionLength = 0;

        box.SelectionColor = color;
        box.AppendText(text);
        box.SelectionColor = box.ForeColor;
    }


    public static void inicreate()
    {
        //configini = INIDatei(Application.StartupPath + "SM_config.ini");
        IniFile Ini = new IniFile(Application.StartupPath + @"\SM_config.ini");
        Ini.IniWriteValue("path", "login", "location/can/be/setup/with/options.exe");
        Ini.IniWriteValue("path", "char", "location/can/be/setup/with/options.exe");
        Ini.IniWriteValue("path", "map", "location/can/be/setup/with/options.exe");
        Ini.IniWriteValue("color", "usecolor", "true");
        Ini.IniWriteValue("color", "oldrev", "false");
        Ini.IniWriteValue("color", "color-status", "124,252,0");
        Ini.IniWriteValue("color", "color-info", "255,255,255");
        Ini.IniWriteValue("color", "color-notice", "255,255,255");
        Ini.IniWriteValue("color", "color-warning", "255,255,0");
        Ini.IniWriteValue("color", "color-error", "255,0,0");
        Ini.IniWriteValue("color", "color-sql", "208,32,144");
        Ini.IniWriteValue("color", "color-debug", "0,255,255");
        iniread();
    }


    public static void iniread()
    {
        IniFile Ini = new IniFile(Application.StartupPath + @"\SM_config.ini");
        loginexepath = Ini.IniReadValue("path","login");
        charexepath = Ini.IniReadValue("path", "char");
        mapexepath = Ini.IniReadValue("path", "map");

        colorMODE = Convert.ToBoolean(Ini.IniReadValue("color", "usecolor"));
        colorOLDREV = Convert.ToBoolean(Ini.IniReadValue("color", "oldrev"));

        string[] colorrgb;
        #region Get Color INI
        try
        {
            colorrgb = Ini.IniReadValue("color", "color-status").Split(new Char[] { ',' });
            Status = Color.FromArgb(255, Convert.ToInt32(colorrgb[0]), Convert.ToInt32(colorrgb[1]), Convert.ToInt32(colorrgb[2]));
        }
        catch
        {
            Status = SStatus;
        }

        try
        {
            colorrgb = Ini.IniReadValue("color", "color-info").Split(new Char[] { ',' });
            Info = Color.FromArgb(255, Convert.ToInt32(colorrgb[0]), Convert.ToInt32(colorrgb[1]), Convert.ToInt32(colorrgb[2]));
        }
        catch
        {
            Info = SInfo;
        }

        try
        {
            colorrgb = Ini.IniReadValue("color", "color-notice").Split(new Char[] { ',' });
            Notice = Color.FromArgb(255, Convert.ToInt32(colorrgb[0]), Convert.ToInt32(colorrgb[1]), Convert.ToInt32(colorrgb[2]));
        }
        catch
        {
            Notice = SNotice;
        }

        try
        {
            colorrgb = Ini.IniReadValue("color", "color-warning").Split(new Char[] { ',' });
            Warning = Color.FromArgb(255, Convert.ToInt32(colorrgb[0]), Convert.ToInt32(colorrgb[1]), Convert.ToInt32(colorrgb[2]));
        }
        catch
        {
            Warning = SWarning;
        }

        try
        {
            colorrgb = Ini.IniReadValue("color", "color-error").Split(new Char[] { ',' });
            Error = Color.FromArgb(255, Convert.ToInt32(colorrgb[0]), Convert.ToInt32(colorrgb[1]), Convert.ToInt32(colorrgb[2]));
        }
        catch
        {
            Error = SError;
        }

        try
        {
            colorrgb = Ini.IniReadValue("color", "color-sql").Split(new Char[] { ',' });
            SQL = Color.FromArgb(255, Convert.ToInt32(colorrgb[0]), Convert.ToInt32(colorrgb[1]), Convert.ToInt32(colorrgb[2]));
        }
        catch
        {
            SQL = SSQL;
        }

        try
        {
            colorrgb = Ini.IniReadValue("color", "color-debug").Split(new Char[] { ',' });
            Debug = Color.FromArgb(255, Convert.ToInt32(colorrgb[0]), Convert.ToInt32(colorrgb[1]), Convert.ToInt32(colorrgb[2]));
        }
        catch
        {
            Debug = SDebug;
        }
#endregion

    }

    public static void saveopt()
    {
        IniFile Ini = new IniFile(Application.StartupPath + @"\SM_config.ini");
        Ini.IniWriteValue("path", "login", loginexepath);
        Ini.IniWriteValue("path", "char", charexepath);
        Ini.IniWriteValue("path", "map", mapexepath);
        Ini.IniWriteValue("color", "usecolor", Convert.ToString(colorMODE));
        Ini.IniWriteValue("color", "oldrev", Convert.ToString(colorOLDREV));
        Ini.IniWriteValue("color", "color-status", Status.R + "," + Status.G + "," + Status.B);
        Ini.IniWriteValue("color", "color-info",Info.R + "," + Info.G + "," + Info.B);
        Ini.IniWriteValue("color", "color-notice", Notice.R + "," + Notice.G + "," + Notice.B);
        Ini.IniWriteValue("color", "color-warning", Warning.R + "," + Warning.G + "," + Warning.B);
        Ini.IniWriteValue("color", "color-error", Error.R + "," + Error.G + "," + Error.B);
        Ini.IniWriteValue("color", "color-sql", SQL.R + "," + SQL.G + "," + SQL.B);
        Ini.IniWriteValue("color", "color-debug", Debug.R + "," + Debug.G + "," + Debug.B);
    }

    [DllImport("User32.dll")]
    static extern bool SetForegroundWindow(IntPtr hWnd);

    [DllImport("User32.dll")]
    public static extern int AttachThreadInput(IntPtr idAttach, IntPtr idAttachTo, bool fAttach);

    [DllImport("User32.dll")]
    public static extern IntPtr GetForegroundWindow();

    [DllImport("User32.dll")]
    public static extern IntPtr GetWindowThreadProcessId(IntPtr hwnd, IntPtr lpdwProcessId);

    public static void SetForegroundWindowEx(Form window)
    {
        IntPtr hndl = window.Handle;
        IntPtr threadID1 = GetWindowThreadProcessId(GetForegroundWindow(), IntPtr.Zero);
        IntPtr threadID2 = GetWindowThreadProcessId(hndl, IntPtr.Zero);
        window.TopMost = true;

        if (threadID1 == threadID2)
        {
            SetForegroundWindow(hndl);
        }
        else
        {
            AttachThreadInput(threadID2, threadID1, true);
            SetForegroundWindow(hndl); ;
            AttachThreadInput(threadID2, threadID1, false);
        }
    }
}