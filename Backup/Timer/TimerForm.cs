using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace MyTimer
{
    public partial class TimerForm : Form
    {
        private System.Windows.Forms.Timer timer1 = null;
        private System.Windows.Forms.Timer timer2 = null;

        public TimerForm()
        {
            InitializeComponent();
        }

        private void Start1_Click(object sender, EventArgs e)
        {
            
            int seconds = 0;
            if (!int.TryParse(Timer1TextBox.Text, out seconds))
            {
                MessageBox.Show("Time is not a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = seconds * 1000;
            timer1.Tick += new EventHandler(timer1Handler);
            timer1.Start();
        }

        private void timer1Handler(Object myObject, EventArgs myEventArgs)
        {
            timer1.Stop();

            MessageBox.Show(Message1TextBox.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Stop1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Timer1 Stopped.");
        }

        private void Start2_Click(object sender, EventArgs e)
        {
            int seconds = 0;
            if (!int.TryParse(Timer2TextBox.Text, out seconds))
            {
                MessageBox.Show("Time is not a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            timer2 = new System.Windows.Forms.Timer();
            timer2.Interval = seconds * 1000;
            timer2.Tick += new EventHandler(timer2Handler);
            timer2.Start();
        }

        private void timer2Handler(Object myObject, EventArgs myEventArgs)
        {
            timer2.Stop();

            MessageBox.Show(Message2TextBox.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Stop2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            MessageBox.Show("Timer2 Stopped.");
        }

     
    }
}