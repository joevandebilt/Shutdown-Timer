using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Shutdown_Timer
{
    public partial class ShutdownTimer : Form
    {
        int TotalSeconds = int.MaxValue;
        int Hours = 0;
        int Minutes = 0;
        
        public ShutdownTimer()
        {
            InitializeComponent();

            for (int i=0; i<60;i++)
            {
                cmbTotalMinutes.Items.Add(i.ToString());
            }
            cmbTotalMinutes.SelectedIndex = 1;

            for (int i=0;i<24;i++)
            {
                cmbTotalHours.Items.Add(i.ToString());
            }
            cmbTotalHours.SelectedIndex = 0;
        }

        private void cmdDoThings_Click(object sender, EventArgs e)
        {
            if (tmrMainTimer.Enabled == true)
            {
                cmdDoThings.Text = "Start";
                tmrMainTimer.Enabled = false;
            }
            else
            {
                bool DontRun = false;
                int temp;
                
                if (int.TryParse(cmbTotalMinutes.Text, out temp)) Minutes = temp;
                else DontRun = true;

                if (int.TryParse(cmbTotalHours.Text, out temp)) Hours = temp;
                else DontRun = true;
                
                if (!DontRun)
                {
                    if (((Hours * 60 * 60) + (Minutes * 60)) < TotalSeconds) TotalSeconds = (Hours * 60 * 60) + (Minutes * 60);
                    tmrMainTimer.Enabled = true;
                    TimeSpan t = TimeSpan.FromSeconds(TotalSeconds);
                    lblSeconds.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);

                }
                else MessageBox.Show("How did you fuck that up?");
                cmdDoThings.Text = "Stop";

                cmbTotalMinutes.Enabled = false;
                cmbTotalHours.Enabled = false;
            }
        }

        private void tmrMainTimer_Tick(object sender, EventArgs e)
        {
            TotalSeconds--;

            if (TotalSeconds == -1)
            {
                tmrMainTimer.Enabled = false;
                Process.Start("shutdown.exe", "/p");
            }

            TimeSpan t = TimeSpan.FromSeconds(TotalSeconds);
            lblSeconds.Text = string.Format("{0:D2}:{1:D2}:{2:D2}",t.Hours,t.Minutes,t.Seconds);
        }

        private void cmdQuit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?","Quit",MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            tmrMainTimer.Enabled = false;
            lblSeconds.Text = "99:99:99";
            TotalSeconds = int.MaxValue;
            cmdDoThings.Text = "Start";
            cmbTotalMinutes.Enabled = true;
            cmbTotalHours.Enabled = true;
            cmbTotalMinutes.SelectedIndex = 1;
            cmbTotalHours.SelectedIndex = 0;

        }
    }
}
