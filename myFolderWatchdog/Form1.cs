using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace myFolderWatchdog
{
    public partial class Form1 : Form
    {
        private readonly string appProcessName = "YourAppName"; // without .exe
        private readonly string appExePath = @"C:\Path\To\YourApp.exe";
        private readonly string baseFolder = @"C:\BaseFolder";
        private readonly TimeSpan maxAllowedGap = TimeSpan.FromMinutes(5);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            //timer1.Interval = 30000; // check every 30 seconds
            //timer1.Tick += Timer1_Tick;
            //timer1.Start();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string todayFolder = Path.Combine(
                    baseFolder,
                    DateTime.Now.Year.ToString(),
                    DateTime.Now.Month.ToString("00"),
                    DateTime.Now.Day.ToString("00")
                );

                if (!Directory.Exists(todayFolder))
                    return;

                var newestFile = Directory.GetFiles(todayFolder)
                    .Select(f => new FileInfo(f))
                    .OrderByDescending(f => f.LastWriteTime)
                    .FirstOrDefault();

                if (newestFile == null)
                    return;

                TimeSpan age = DateTime.Now - newestFile.LastWriteTime;

                if (age > maxAllowedGap)
                {
                    RestartApp();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
            }
        }

        private void RestartApp()
        {
            string processPath = "";
            

            foreach (var p in Process.GetProcessesByName("myRTSPStreamer"))
            {
                processPath = p.MainModule.FileName; //get full path so we can restart it
                try { p.Kill(); }
                catch { }
            }

            // Restart it
            Process.Start(processPath);


            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_restart_app_Click(object sender, EventArgs e)
        {
            RestartApp();
        }
    }
}
