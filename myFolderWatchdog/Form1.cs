using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace myFolderWatchdog
{
    public partial class Form1 : Form
    {
        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number
            Log("App started: " + DateTime.Now.ToString("HH:mm:ss"));
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            timer1.Interval = Int32.Parse(numupdn_check_Interval.Text) * 1000; //30000; // check every 30 seconds;
            timer1.Tick += Timer1_Tick;
            timer1.Start();

            Log("Watchdog started: " + DateTime.Now.ToString("HH:mm:ss"));
        }

        private int iterations_counter;
        private int restart_counter;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            iterations_counter++;
            // max gap allowed to be missing
            TimeSpan CheckingInterval = TimeSpan.FromMinutes(int.Parse(numupdwn_Interval.Text));

            try
            {
                DateTime myDate = DateTime.Now;

                string todayFolder = Path.Combine(
                    txtbx_root_directory.Text.Trim(),
                    myDate.ToString("yyyy"),
                    myDate.ToString("MMM"),
                    myDate.ToString("dd")
                );

                string todayFile = "C" + todayFolder.Substring(1) + "\\heartbeat.txt";

                if ((!Directory.Exists(todayFolder)) || (!File.Exists(todayFile)))
                {
                    // If watched app has not written file we give it a chance to by waiting a few iterations.
                    counter++; // inc counter

                    if (counter > 3)
                    {
                        //Tried more than 3 minutes, watched app must have locked.
                        RestartApp();
                        counter = 0; // reset counter
                    }

                    return; // carry on watching
                }
                   

                DateTime LastWriteTime = File.GetLastWriteTime(todayFolder);
                TimeSpan age = DateTime.Now - LastWriteTime;

                if (age > CheckingInterval)
                {
                    RestartApp();
                    lbl_number_of_restarts.Text = restart_counter++.ToString();
                    Log("Missing Images: " + DateTime.Now.ToString("HH:mm:ss"));
                }
                
                lbl_age.Text = age.ToString();
                lbl_checking_interval.Text = CheckingInterval.ToString();
                lbl_iterations.Text = iterations_counter.ToString();

            }
            catch (Exception ex)
            {
                //Debug.WriteLine("Error: " + ex.Message);
                Log("Error: " + ex.Message + ": " + DateTime.Now.ToString("HH:mm:ss"));
            }

            if (chkbx_debug.Checked)
                Log("Watchdog running: " + DateTime.Now.ToString("HH:mm:ss"));
        }

        private void RestartApp()
        {
            string processPath = "";
            int counter = Int32.Parse(lbl_number_of_restarts.Text);

            //if more than one running we close them all
            foreach (var p in Process.GetProcessesByName(txtbx_app_to_restart.Text.Trim()))
            {
                processPath = p.MainModule.FileName; //get full path so we can restart it
                try { p.Kill(); }
                catch { }
            }

            // Restart it
            Process.Start(processPath, "true");

            lbl_number_of_restarts.Text = counter++.ToString();

            Log("Auto restart of locked app: " + DateTime.Now.ToString("HHmmss"));
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_restart_app_Click(object sender, EventArgs e)
        {
            RestartApp();
        }

        private void Log(string message)
        {

            DateTime myDate = DateTime.Now;
            string FolderPath = Path.Combine(txtbx_root_directory.Text.Trim(), myDate.ToString("yyyy"),
                myDate.ToString("MMM"), myDate.ToString("dd"));
            string timestamp = DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss");
            string line = $"{timestamp}  {message}";


            Directory.CreateDirectory(FolderPath); //create if not already there

            // Write to on-screen log
            txtbx_Log.AppendText(line + Environment.NewLine);

            // Write to watchdog_log.txt 
            try
            {
                string logPath = Path.Combine(FolderPath, "watchdog_log.txt");
                File.AppendAllText(logPath, line + Environment.NewLine);
            }
            catch
            {
                // Avoid crashing if log file fails
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btn_clear_log_Click(object sender, EventArgs e)
        {
            txtbx_Log.Clear();
            lbl_iterations.Text = "0";
        }
    }
}
