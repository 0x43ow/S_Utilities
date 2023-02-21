namespace Utilities.v2
{
    partial class Form2
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
            this.Form1_Button = new System.Windows.Forms.Button();
            this.Settings_Button = new System.Windows.Forms.Button();
            this.Timer_TextBox = new System.Windows.Forms.TextBox();
            this.State_TextBox = new System.Windows.Forms.TextBox();
            this.TimerControl_Button = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.RoundCount_TextBox = new System.Windows.Forms.TextBox();
            this.Skip_Button = new System.Windows.Forms.Button();
            this.ToDo_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Form1_Button
            // 
            this.Form1_Button.Location = new System.Drawing.Point(22, 377);
            this.Form1_Button.Name = "Form1_Button";
            this.Form1_Button.Size = new System.Drawing.Size(195, 23);
            this.Form1_Button.TabIndex = 0;
            this.Form1_Button.Text = "YT download and twitch recover";
            this.Form1_Button.UseVisualStyleBackColor = true;
            this.Form1_Button.Click += new System.EventHandler(this.Form1_Button_Click);
            // 
            // Settings_Button
            // 
            this.Settings_Button.Location = new System.Drawing.Point(339, 33);
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.Size = new System.Drawing.Size(75, 23);
            this.Settings_Button.TabIndex = 1;
            this.Settings_Button.Text = "Settings";
            this.Settings_Button.UseVisualStyleBackColor = true;
            this.Settings_Button.Click += new System.EventHandler(this.Settings_Button_Click);
            // 
            // Timer_TextBox
            // 
            this.Timer_TextBox.BackColor = System.Drawing.Color.SlateGray;
            this.Timer_TextBox.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Timer_TextBox.Location = new System.Drawing.Point(71, 102);
            this.Timer_TextBox.Multiline = true;
            this.Timer_TextBox.Name = "Timer_TextBox";
            this.Timer_TextBox.ReadOnly = true;
            this.Timer_TextBox.Size = new System.Drawing.Size(270, 84);
            this.Timer_TextBox.TabIndex = 2;
            this.Timer_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // State_TextBox
            // 
            this.State_TextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.State_TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.State_TextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.State_TextBox.Location = new System.Drawing.Point(103, 29);
            this.State_TextBox.Multiline = true;
            this.State_TextBox.Name = "State_TextBox";
            this.State_TextBox.ReadOnly = true;
            this.State_TextBox.Size = new System.Drawing.Size(194, 48);
            this.State_TextBox.TabIndex = 3;
            this.State_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimerControl_Button
            // 
            this.TimerControl_Button.Location = new System.Drawing.Point(71, 210);
            this.TimerControl_Button.Name = "TimerControl_Button";
            this.TimerControl_Button.Size = new System.Drawing.Size(75, 23);
            this.TimerControl_Button.TabIndex = 4;
            this.TimerControl_Button.Text = "Start";
            this.TimerControl_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TimerControl_Button.UseVisualStyleBackColor = true;
            this.TimerControl_Button.Click += new System.EventHandler(this.TimerControl_Button_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // RoundCount_TextBox
            // 
            this.RoundCount_TextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoundCount_TextBox.Location = new System.Drawing.Point(241, 210);
            this.RoundCount_TextBox.Name = "RoundCount_TextBox";
            this.RoundCount_TextBox.ReadOnly = true;
            this.RoundCount_TextBox.Size = new System.Drawing.Size(100, 34);
            this.RoundCount_TextBox.TabIndex = 5;
            this.RoundCount_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RoundCount_TextBox.TextChanged += new System.EventHandler(this.RoundCount_TextBox_TextChanged);
            // 
            // Skip_Button
            // 
            this.Skip_Button.Location = new System.Drawing.Point(71, 239);
            this.Skip_Button.Name = "Skip_Button";
            this.Skip_Button.Size = new System.Drawing.Size(75, 23);
            this.Skip_Button.TabIndex = 6;
            this.Skip_Button.Text = "Skip";
            this.Skip_Button.UseVisualStyleBackColor = true;
            this.Skip_Button.Click += new System.EventHandler(this.Skip_Button_Click);
            // 
            // ToDo_Button
            // 
            this.ToDo_Button.Location = new System.Drawing.Point(241, 377);
            this.ToDo_Button.Name = "ToDo_Button";
            this.ToDo_Button.Size = new System.Drawing.Size(75, 23);
            this.ToDo_Button.TabIndex = 7;
            this.ToDo_Button.Text = "To Do";
            this.ToDo_Button.UseVisualStyleBackColor = true;
            this.ToDo_Button.Visible = false;
            this.ToDo_Button.Click += new System.EventHandler(this.ToDo_Button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.ToDo_Button);
            this.Controls.Add(this.Skip_Button);
            this.Controls.Add(this.RoundCount_TextBox);
            this.Controls.Add(this.TimerControl_Button);
            this.Controls.Add(this.State_TextBox);
            this.Controls.Add(this.Timer_TextBox);
            this.Controls.Add(this.Settings_Button);
            this.Controls.Add(this.Form1_Button);
            this.Name = "Form2";
            this.Text = "Pomodoro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Form1_Button;
        private Button Settings_Button;
        private TextBox Timer_TextBox;
        private TextBox State_TextBox;
        private Button TimerControl_Button;
        private System.Windows.Forms.Timer Timer;
        private TextBox RoundCount_TextBox;
        private Button Skip_Button;
        private Button ToDo_Button;
    }
}