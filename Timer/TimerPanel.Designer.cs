namespace MyTimer
{
    partial class TimerPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TimerGroupBox = new System.Windows.Forms.GroupBox();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.TimerTextBox = new System.Windows.Forms.TextBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeLeftLabel = new System.Windows.Forms.Label();
            this.TimerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerGroupBox
            // 
            this.TimerGroupBox.Controls.Add(this.TimeLeftLabel);
            this.TimerGroupBox.Controls.Add(this.TimerLabel);
            this.TimerGroupBox.Controls.Add(this.Stop);
            this.TimerGroupBox.Controls.Add(this.Start);
            this.TimerGroupBox.Controls.Add(this.MessageTextBox);
            this.TimerGroupBox.Controls.Add(this.TimerTextBox);
            this.TimerGroupBox.Controls.Add(this.MessageLabel);
            this.TimerGroupBox.Controls.Add(this.TimeLabel);
            this.TimerGroupBox.Location = new System.Drawing.Point(3, 3);
            this.TimerGroupBox.Name = "TimerGroupBox";
            this.TimerGroupBox.Size = new System.Drawing.Size(482, 82);
            this.TimerGroupBox.TabIndex = 1;
            this.TimerGroupBox.TabStop = false;
            this.TimerGroupBox.Text = "Timer";
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(237, 16);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(13, 13);
            this.TimerLabel.TabIndex = 6;
            this.TimerLabel.Text = "0";
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(394, 37);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(394, 11);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(74, 39);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(281, 20);
            this.MessageTextBox.TabIndex = 3;
            // 
            // TimerTextBox
            // 
            this.TimerTextBox.Location = new System.Drawing.Point(74, 13);
            this.TimerTextBox.Name = "TimerTextBox";
            this.TimerTextBox.Size = new System.Drawing.Size(100, 20);
            this.TimerTextBox.TabIndex = 2;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(6, 42);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(50, 13);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.Text = "Message";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(6, 16);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(30, 13);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "Time";
            // 
            // TimeLeftLabel
            // 
            this.TimeLeftLabel.AutoSize = true;
            this.TimeLeftLabel.Location = new System.Drawing.Point(181, 16);
            this.TimeLeftLabel.Name = "TimeLeftLabel";
            this.TimeLeftLabel.Size = new System.Drawing.Size(50, 13);
            this.TimeLeftLabel.TabIndex = 7;
            this.TimeLeftLabel.Text = "Time left:";
            // 
            // TimerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TimerGroupBox);
            this.Name = "TimerPanel";
            this.Size = new System.Drawing.Size(494, 87);
            this.TimerGroupBox.ResumeLayout(false);
            this.TimerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.TextBox TimerTextBox;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.GroupBox TimerGroupBox;
        private System.Windows.Forms.Label TimeLeftLabel;
    }
}
