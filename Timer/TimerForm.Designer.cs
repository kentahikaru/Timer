namespace MyTimer
{
    partial class TimerForm
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
            this.TimerFatherPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimerFatherPanel
            // 
            this.TimerFatherPanel.Location = new System.Drawing.Point(13, 28);
            this.TimerFatherPanel.Name = "TimerFatherPanel";
            this.TimerFatherPanel.Size = new System.Drawing.Size(518, 332);
            this.TimerFatherPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(490, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_Timer_Click);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TimerFatherPanel);
            this.Name = "TimerForm";
            this.Text = "Timer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TimerFatherPanel;
        private System.Windows.Forms.Button button1;
    }
}

