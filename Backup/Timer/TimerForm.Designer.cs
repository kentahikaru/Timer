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
            this.Timer1GroupBox = new System.Windows.Forms.GroupBox();
            this.Stop1 = new System.Windows.Forms.Button();
            this.Start1 = new System.Windows.Forms.Button();
            this.Message1TextBox = new System.Windows.Forms.TextBox();
            this.Timer1TextBox = new System.Windows.Forms.TextBox();
            this.Message1Label = new System.Windows.Forms.Label();
            this.Time1Label = new System.Windows.Forms.Label();
            this.Timer2GroupBox = new System.Windows.Forms.GroupBox();
            this.Stop2 = new System.Windows.Forms.Button();
            this.Start2 = new System.Windows.Forms.Button();
            this.Message2TextBox = new System.Windows.Forms.TextBox();
            this.Timer2TextBox = new System.Windows.Forms.TextBox();
            this.Message2Label = new System.Windows.Forms.Label();
            this.Timer2Label = new System.Windows.Forms.Label();
            this.Timer1GroupBox.SuspendLayout();
            this.Timer2GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1GroupBox
            // 
            this.Timer1GroupBox.Controls.Add(this.Stop1);
            this.Timer1GroupBox.Controls.Add(this.Start1);
            this.Timer1GroupBox.Controls.Add(this.Message1TextBox);
            this.Timer1GroupBox.Controls.Add(this.Timer1TextBox);
            this.Timer1GroupBox.Controls.Add(this.Message1Label);
            this.Timer1GroupBox.Controls.Add(this.Time1Label);
            this.Timer1GroupBox.Location = new System.Drawing.Point(12, 12);
            this.Timer1GroupBox.Name = "Timer1GroupBox";
            this.Timer1GroupBox.Size = new System.Drawing.Size(482, 82);
            this.Timer1GroupBox.TabIndex = 0;
            this.Timer1GroupBox.TabStop = false;
            this.Timer1GroupBox.Text = "Timer1";
            // 
            // Stop1
            // 
            this.Stop1.Location = new System.Drawing.Point(394, 37);
            this.Stop1.Name = "Stop1";
            this.Stop1.Size = new System.Drawing.Size(75, 23);
            this.Stop1.TabIndex = 5;
            this.Stop1.Text = "Stop";
            this.Stop1.UseVisualStyleBackColor = true;
            this.Stop1.Click += new System.EventHandler(this.Stop1_Click);
            // 
            // Start1
            // 
            this.Start1.Location = new System.Drawing.Point(394, 11);
            this.Start1.Name = "Start1";
            this.Start1.Size = new System.Drawing.Size(75, 23);
            this.Start1.TabIndex = 4;
            this.Start1.Text = "Start";
            this.Start1.UseVisualStyleBackColor = true;
            this.Start1.Click += new System.EventHandler(this.Start1_Click);
            // 
            // Message1TextBox
            // 
            this.Message1TextBox.Location = new System.Drawing.Point(74, 39);
            this.Message1TextBox.Name = "Message1TextBox";
            this.Message1TextBox.Size = new System.Drawing.Size(281, 20);
            this.Message1TextBox.TabIndex = 3;
            // 
            // Timer1TextBox
            // 
            this.Timer1TextBox.Location = new System.Drawing.Point(74, 13);
            this.Timer1TextBox.Name = "Timer1TextBox";
            this.Timer1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Timer1TextBox.TabIndex = 2;
            // 
            // Message1Label
            // 
            this.Message1Label.AutoSize = true;
            this.Message1Label.Location = new System.Drawing.Point(6, 42);
            this.Message1Label.Name = "Message1Label";
            this.Message1Label.Size = new System.Drawing.Size(50, 13);
            this.Message1Label.TabIndex = 1;
            this.Message1Label.Text = "Message";
            // 
            // Time1Label
            // 
            this.Time1Label.AutoSize = true;
            this.Time1Label.Location = new System.Drawing.Point(6, 16);
            this.Time1Label.Name = "Time1Label";
            this.Time1Label.Size = new System.Drawing.Size(30, 13);
            this.Time1Label.TabIndex = 0;
            this.Time1Label.Text = "Time";
            // 
            // Timer2GroupBox
            // 
            this.Timer2GroupBox.Controls.Add(this.Stop2);
            this.Timer2GroupBox.Controls.Add(this.Start2);
            this.Timer2GroupBox.Controls.Add(this.Message2TextBox);
            this.Timer2GroupBox.Controls.Add(this.Timer2TextBox);
            this.Timer2GroupBox.Controls.Add(this.Message2Label);
            this.Timer2GroupBox.Controls.Add(this.Timer2Label);
            this.Timer2GroupBox.Location = new System.Drawing.Point(12, 100);
            this.Timer2GroupBox.Name = "Timer2GroupBox";
            this.Timer2GroupBox.Size = new System.Drawing.Size(482, 82);
            this.Timer2GroupBox.TabIndex = 6;
            this.Timer2GroupBox.TabStop = false;
            this.Timer2GroupBox.Text = "Timer2";
            // 
            // Stop2
            // 
            this.Stop2.Location = new System.Drawing.Point(394, 37);
            this.Stop2.Name = "Stop2";
            this.Stop2.Size = new System.Drawing.Size(75, 23);
            this.Stop2.TabIndex = 5;
            this.Stop2.Text = "Stop";
            this.Stop2.UseVisualStyleBackColor = true;
            this.Stop2.Click += new System.EventHandler(this.Stop2_Click);
            // 
            // Start2
            // 
            this.Start2.Location = new System.Drawing.Point(394, 11);
            this.Start2.Name = "Start2";
            this.Start2.Size = new System.Drawing.Size(75, 23);
            this.Start2.TabIndex = 4;
            this.Start2.Text = "Start";
            this.Start2.UseVisualStyleBackColor = true;
            this.Start2.Click += new System.EventHandler(this.Start2_Click);
            // 
            // Message2TextBox
            // 
            this.Message2TextBox.Location = new System.Drawing.Point(74, 39);
            this.Message2TextBox.Name = "Message2TextBox";
            this.Message2TextBox.Size = new System.Drawing.Size(281, 20);
            this.Message2TextBox.TabIndex = 3;
            // 
            // Timer2TextBox
            // 
            this.Timer2TextBox.Location = new System.Drawing.Point(74, 13);
            this.Timer2TextBox.Name = "Timer2TextBox";
            this.Timer2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Timer2TextBox.TabIndex = 2;
            // 
            // Message2Label
            // 
            this.Message2Label.AutoSize = true;
            this.Message2Label.Location = new System.Drawing.Point(6, 42);
            this.Message2Label.Name = "Message2Label";
            this.Message2Label.Size = new System.Drawing.Size(50, 13);
            this.Message2Label.TabIndex = 1;
            this.Message2Label.Text = "Message";
            // 
            // Timer2Label
            // 
            this.Timer2Label.AutoSize = true;
            this.Timer2Label.Location = new System.Drawing.Point(6, 16);
            this.Timer2Label.Name = "Timer2Label";
            this.Timer2Label.Size = new System.Drawing.Size(30, 13);
            this.Timer2Label.TabIndex = 0;
            this.Timer2Label.Text = "Time";
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 207);
            this.Controls.Add(this.Timer2GroupBox);
            this.Controls.Add(this.Timer1GroupBox);
            this.Name = "TimerForm";
            this.Text = "Timer";
            this.Timer1GroupBox.ResumeLayout(false);
            this.Timer1GroupBox.PerformLayout();
            this.Timer2GroupBox.ResumeLayout(false);
            this.Timer2GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Timer1GroupBox;
        private System.Windows.Forms.Button Stop1;
        private System.Windows.Forms.Button Start1;
        private System.Windows.Forms.TextBox Message1TextBox;
        private System.Windows.Forms.TextBox Timer1TextBox;
        private System.Windows.Forms.Label Message1Label;
        private System.Windows.Forms.Label Time1Label;
        private System.Windows.Forms.GroupBox Timer2GroupBox;
        private System.Windows.Forms.Button Stop2;
        private System.Windows.Forms.Button Start2;
        private System.Windows.Forms.TextBox Message2TextBox;
        private System.Windows.Forms.TextBox Timer2TextBox;
        private System.Windows.Forms.Label Message2Label;
        private System.Windows.Forms.Label Timer2Label;
    }
}

