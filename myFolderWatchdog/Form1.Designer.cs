
namespace myFolderWatchdog
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_restart_app = new System.Windows.Forms.Button();
            this.lbl_minutes = new System.Windows.Forms.Label();
            this.btn_BrowseFolder = new System.Windows.Forms.Button();
            this.txtbx_root_directory = new System.Windows.Forms.TextBox();
            this.numupdwn_Interval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_number_of_restarts = new System.Windows.Forms.Label();
            this.txtbx_Log = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_app_to_restart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_Checking = new System.Windows.Forms.Label();
            this.lbl_checking_interval = new System.Windows.Forms.Label();
            this.lbl_iterations = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkbx_debug = new System.Windows.Forms.CheckBox();
            this.btn_clear_log = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numupdn_check_Interval = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numupdwn_Interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdn_check_Interval)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(693, 39);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(76, 35);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_restart_app
            // 
            this.btn_restart_app.Location = new System.Drawing.Point(656, 95);
            this.btn_restart_app.Name = "btn_restart_app";
            this.btn_restart_app.Size = new System.Drawing.Size(113, 42);
            this.btn_restart_app.TabIndex = 1;
            this.btn_restart_app.Text = "Restart App";
            this.btn_restart_app.UseVisualStyleBackColor = true;
            this.btn_restart_app.Click += new System.EventHandler(this.btn_restart_app_Click);
            // 
            // lbl_minutes
            // 
            this.lbl_minutes.AutoSize = true;
            this.lbl_minutes.Location = new System.Drawing.Point(301, 165);
            this.lbl_minutes.Name = "lbl_minutes";
            this.lbl_minutes.Size = new System.Drawing.Size(65, 20);
            this.lbl_minutes.TabIndex = 27;
            this.lbl_minutes.Text = "minutes";
            // 
            // btn_BrowseFolder
            // 
            this.btn_BrowseFolder.Location = new System.Drawing.Point(486, 43);
            this.btn_BrowseFolder.Name = "btn_BrowseFolder";
            this.btn_BrowseFolder.Size = new System.Drawing.Size(42, 26);
            this.btn_BrowseFolder.TabIndex = 24;
            this.btn_BrowseFolder.Text = "...";
            // 
            // txtbx_root_directory
            // 
            this.txtbx_root_directory.Location = new System.Drawing.Point(144, 43);
            this.txtbx_root_directory.Name = "txtbx_root_directory";
            this.txtbx_root_directory.Size = new System.Drawing.Size(336, 26);
            this.txtbx_root_directory.TabIndex = 25;
            this.txtbx_root_directory.Text = "C:\\timelapse";
            // 
            // numupdwn_Interval
            // 
            this.numupdwn_Interval.Location = new System.Drawing.Point(175, 163);
            this.numupdwn_Interval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numupdwn_Interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numupdwn_Interval.Name = "numupdwn_Interval";
            this.numupdwn_Interval.Size = new System.Drawing.Size(120, 26);
            this.numupdwn_Interval.TabIndex = 26;
            this.numupdwn_Interval.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Max Gap allowed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Root directory";
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(623, 39);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(64, 35);
            this.btn_Stop.TabIndex = 30;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(544, 39);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(73, 35);
            this.btn_Start.TabIndex = 31;
            this.btn_Start.Text = "Start";
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Number of restarts:";
            // 
            // lbl_number_of_restarts
            // 
            this.lbl_number_of_restarts.AutoSize = true;
            this.lbl_number_of_restarts.Location = new System.Drawing.Point(565, 146);
            this.lbl_number_of_restarts.Name = "lbl_number_of_restarts";
            this.lbl_number_of_restarts.Size = new System.Drawing.Size(18, 20);
            this.lbl_number_of_restarts.TabIndex = 33;
            this.lbl_number_of_restarts.Text = "0";
            // 
            // txtbx_Log
            // 
            this.txtbx_Log.BackColor = System.Drawing.Color.Black;
            this.txtbx_Log.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtbx_Log.ForeColor = System.Drawing.Color.LightGreen;
            this.txtbx_Log.Location = new System.Drawing.Point(12, 274);
            this.txtbx_Log.Multiline = true;
            this.txtbx_Log.Name = "txtbx_Log";
            this.txtbx_Log.ReadOnly = true;
            this.txtbx_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbx_Log.Size = new System.Drawing.Size(776, 164);
            this.txtbx_Log.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Name of App to Restart";
            // 
            // txtbx_app_to_restart
            // 
            this.txtbx_app_to_restart.Location = new System.Drawing.Point(213, 103);
            this.txtbx_app_to_restart.Name = "txtbx_app_to_restart";
            this.txtbx_app_to_restart.Size = new System.Drawing.Size(196, 26);
            this.txtbx_app_to_restart.TabIndex = 35;
            this.txtbx_app_to_restart.Text = "myRTSPStreamer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Age =";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(510, 175);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(21, 20);
            this.lbl_age.TabIndex = 38;
            this.lbl_age.Text = "...";
            // 
            // lbl_Checking
            // 
            this.lbl_Checking.AutoSize = true;
            this.lbl_Checking.Location = new System.Drawing.Point(415, 204);
            this.lbl_Checking.Name = "lbl_Checking";
            this.lbl_Checking.Size = new System.Drawing.Size(90, 20);
            this.lbl_Checking.TabIndex = 39;
            this.lbl_Checking.Text = "Max Gap = ";
            // 
            // lbl_checking_interval
            // 
            this.lbl_checking_interval.AutoSize = true;
            this.lbl_checking_interval.Location = new System.Drawing.Point(510, 204);
            this.lbl_checking_interval.Name = "lbl_checking_interval";
            this.lbl_checking_interval.Size = new System.Drawing.Size(21, 20);
            this.lbl_checking_interval.TabIndex = 40;
            this.lbl_checking_interval.Text = "...";
            // 
            // lbl_iterations
            // 
            this.lbl_iterations.AutoSize = true;
            this.lbl_iterations.Location = new System.Drawing.Point(510, 236);
            this.lbl_iterations.Name = "lbl_iterations";
            this.lbl_iterations.Size = new System.Drawing.Size(21, 20);
            this.lbl_iterations.TabIndex = 42;
            this.lbl_iterations.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Iterations = ";
            // 
            // chkbx_debug
            // 
            this.chkbx_debug.AutoSize = true;
            this.chkbx_debug.Location = new System.Drawing.Point(448, 105);
            this.chkbx_debug.Name = "chkbx_debug";
            this.chkbx_debug.Size = new System.Drawing.Size(83, 24);
            this.chkbx_debug.TabIndex = 43;
            this.chkbx_debug.Text = "Debug";
            this.chkbx_debug.UseVisualStyleBackColor = true;
            // 
            // btn_clear_log
            // 
            this.btn_clear_log.Location = new System.Drawing.Point(537, 95);
            this.btn_clear_log.Name = "btn_clear_log";
            this.btn_clear_log.Size = new System.Drawing.Size(113, 42);
            this.btn_clear_log.TabIndex = 44;
            this.btn_clear_log.Text = "Clear Log";
            this.btn_clear_log.UseVisualStyleBackColor = true;
            this.btn_clear_log.Click += new System.EventHandler(this.btn_clear_log_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "seconds";
            // 
            // numupdn_check_Interval
            // 
            this.numupdn_check_Interval.Location = new System.Drawing.Point(175, 204);
            this.numupdn_check_Interval.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numupdn_check_Interval.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numupdn_check_Interval.Name = "numupdn_check_Interval";
            this.numupdn_check_Interval.Size = new System.Drawing.Size(120, 26);
            this.numupdn_check_Interval.TabIndex = 45;
            this.numupdn_check_Interval.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Check every";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numupdn_check_Interval);
            this.Controls.Add(this.btn_clear_log);
            this.Controls.Add(this.chkbx_debug);
            this.Controls.Add(this.lbl_iterations);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_checking_interval);
            this.Controls.Add(this.lbl_Checking);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbx_app_to_restart);
            this.Controls.Add(this.txtbx_Log);
            this.Controls.Add(this.lbl_number_of_restarts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_minutes);
            this.Controls.Add(this.btn_BrowseFolder);
            this.Controls.Add(this.txtbx_root_directory);
            this.Controls.Add(this.numupdwn_Interval);
            this.Controls.Add(this.btn_restart_app);
            this.Controls.Add(this.btn_close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "myFolderWatchdog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numupdwn_Interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdn_check_Interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_restart_app;
        private System.Windows.Forms.Label lbl_minutes;
        private System.Windows.Forms.Button btn_BrowseFolder;
        private System.Windows.Forms.TextBox txtbx_root_directory;
        private System.Windows.Forms.NumericUpDown numupdwn_Interval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_number_of_restarts;
        private System.Windows.Forms.TextBox txtbx_Log;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_app_to_restart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_Checking;
        private System.Windows.Forms.Label lbl_checking_interval;
        private System.Windows.Forms.Label lbl_iterations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkbx_debug;
        private System.Windows.Forms.Button btn_clear_log;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numupdn_check_Interval;
        private System.Windows.Forms.Label label8;
    }
}

