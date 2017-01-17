using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace MyTimer
{
    public partial class TimerPanel : UserControl
    {
        private System.Windows.Forms.Timer timer = null;
        int seconds = 0;

        public TimerPanel(int num)
        {
            InitializeComponent();
            this.TimerGroupBox.Text = this.TimerGroupBox.Text + " " + num.ToString();
        }

        /**< Add new timer panel and initialize it */
        private void Start_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TimerTextBox.Text, out seconds))
            {
                MessageBox.Show("Time is not a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timerHandler);
            timer.Start();
            this.TimerLabel.Text = seconds.ToString();
            this.Start.Enabled = false;
        }

        /**< Handler is executed each second, when time is up, show message box with given message */
        private void timerHandler(Object myObject, EventArgs myEventArgs)
        {
            seconds--;
            this.TimerLabel.Text = seconds.ToString();
            if(seconds == 0)
            {
                timer.Stop();
                this.Start.Enabled = true;
                MessageBox.Show(MessageTextBox.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        /**< Stop timer */
        private void Stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            this.Start.Enabled = true;
            MessageBox.Show("Timer Stopped.");
        }

    }
}
