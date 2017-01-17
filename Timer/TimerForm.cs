/**
 * @brief Countdown timer(s) for warious things
 * @author Lukas Sandala
 * @date December 2016
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

/**< Main timer form holding panels containing "timers" */
namespace MyTimer
{
    public partial class TimerForm : Form
    {
        public TimerForm()
        {
            InitializeComponent();
            /**< Add first panel into the collection */
            this.TimerFatherPanel.Controls.Add(new TimerPanel(this.TimerFatherPanel.Controls.Count));
            this.TimerFatherPanel.AutoScroll = true;
        }

        /**< With each click add new timer panel */
        private void Add_Timer_Click(object sender, EventArgs e)
        {
            TimerPanel tp = new TimerPanel(this.TimerFatherPanel.Controls.Count);
            tp.Show();
            tp.Location = new Point(0, tp.Height * this.TimerFatherPanel.Controls.Count); // add new panel offsetted in Y axis;
            this.TimerFatherPanel.Controls.Add(tp);
        }

    }
}