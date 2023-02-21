namespace Utilities.v2
{
    partial class ToDo
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
            this.YTDownload_Button = new System.Windows.Forms.Button();
            this.Pomodoro_Button = new System.Windows.Forms.Button();
            this.AddTask_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YTDownload_Button
            // 
            this.YTDownload_Button.Location = new System.Drawing.Point(12, 387);
            this.YTDownload_Button.Name = "YTDownload_Button";
            this.YTDownload_Button.Size = new System.Drawing.Size(193, 23);
            this.YTDownload_Button.TabIndex = 0;
            this.YTDownload_Button.Text = "YT download and twitch recover";
            this.YTDownload_Button.UseVisualStyleBackColor = true;
            this.YTDownload_Button.Click += new System.EventHandler(this.YTDownload_Button_Click);
            // 
            // Pomodoro_Button
            // 
            this.Pomodoro_Button.Location = new System.Drawing.Point(211, 387);
            this.Pomodoro_Button.Name = "Pomodoro_Button";
            this.Pomodoro_Button.Size = new System.Drawing.Size(75, 23);
            this.Pomodoro_Button.TabIndex = 1;
            this.Pomodoro_Button.Text = "Pomodoro";
            this.Pomodoro_Button.UseVisualStyleBackColor = true;
            this.Pomodoro_Button.Click += new System.EventHandler(this.Pomodoro_Button_Click);
            // 
            // AddTask_Button
            // 
            this.AddTask_Button.Location = new System.Drawing.Point(25, 40);
            this.AddTask_Button.Name = "AddTask_Button";
            this.AddTask_Button.Size = new System.Drawing.Size(75, 23);
            this.AddTask_Button.TabIndex = 2;
            this.AddTask_Button.Text = "Add Task";
            this.AddTask_Button.UseVisualStyleBackColor = true;
            this.AddTask_Button.Click += new System.EventHandler(this.AddTask_Button_Click);
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 450);
            this.Controls.Add(this.AddTask_Button);
            this.Controls.Add(this.Pomodoro_Button);
            this.Controls.Add(this.YTDownload_Button);
            this.Name = "ToDo";
            this.Text = "ToDo";
            this.ResumeLayout(false);

        }

        #endregion

        private Button YTDownload_Button;
        private Button Pomodoro_Button;
        private Button AddTask_Button;
    }
}