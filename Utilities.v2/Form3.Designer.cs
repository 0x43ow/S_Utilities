namespace Utilities.v2
{
    partial class Form3
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
            this.ExitSettings_Button = new System.Windows.Forms.Button();
            this.MaxRounds_Button = new System.Windows.Forms.Button();
            this.MaxRounds_TextBox = new System.Windows.Forms.TextBox();
            this.ShortBreak_Button = new System.Windows.Forms.Button();
            this.ShortBreak_TextBox = new System.Windows.Forms.TextBox();
            this.RoundTime_Button = new System.Windows.Forms.Button();
            this.RoundTime_TextBox = new System.Windows.Forms.TextBox();
            this.LongBreak_Button = new System.Windows.Forms.Button();
            this.LongBreak_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExitSettings_Button
            // 
            this.ExitSettings_Button.Location = new System.Drawing.Point(43, 375);
            this.ExitSettings_Button.Name = "ExitSettings_Button";
            this.ExitSettings_Button.Size = new System.Drawing.Size(75, 23);
            this.ExitSettings_Button.TabIndex = 0;
            this.ExitSettings_Button.Text = "Exit Settings";
            this.ExitSettings_Button.UseVisualStyleBackColor = true;
            this.ExitSettings_Button.Click += new System.EventHandler(this.ExitSettings_Button_Click);
            // 
            // MaxRounds_Button
            // 
            this.MaxRounds_Button.Location = new System.Drawing.Point(32, 88);
            this.MaxRounds_Button.Name = "MaxRounds_Button";
            this.MaxRounds_Button.Size = new System.Drawing.Size(75, 23);
            this.MaxRounds_Button.TabIndex = 1;
            this.MaxRounds_Button.Text = "save";
            this.MaxRounds_Button.UseVisualStyleBackColor = true;
            this.MaxRounds_Button.Click += new System.EventHandler(this.MaxRounds_Button_Click);
            // 
            // MaxRounds_TextBox
            // 
            this.MaxRounds_TextBox.Location = new System.Drawing.Point(32, 59);
            this.MaxRounds_TextBox.Name = "MaxRounds_TextBox";
            this.MaxRounds_TextBox.Size = new System.Drawing.Size(100, 23);
            this.MaxRounds_TextBox.TabIndex = 2;
            this.MaxRounds_TextBox.Text = "Max rounds";
            this.MaxRounds_TextBox.TextChanged += new System.EventHandler(this.MaxRounds_TextBox_TextChanged);
            // 
            // ShortBreak_Button
            // 
            this.ShortBreak_Button.Location = new System.Drawing.Point(32, 192);
            this.ShortBreak_Button.Name = "ShortBreak_Button";
            this.ShortBreak_Button.Size = new System.Drawing.Size(75, 23);
            this.ShortBreak_Button.TabIndex = 3;
            this.ShortBreak_Button.Text = "save";
            this.ShortBreak_Button.UseVisualStyleBackColor = true;
            this.ShortBreak_Button.Click += new System.EventHandler(this.ShortBreak_Button_Click);
            // 
            // ShortBreak_TextBox
            // 
            this.ShortBreak_TextBox.Location = new System.Drawing.Point(32, 163);
            this.ShortBreak_TextBox.Name = "ShortBreak_TextBox";
            this.ShortBreak_TextBox.Size = new System.Drawing.Size(100, 23);
            this.ShortBreak_TextBox.TabIndex = 4;
            this.ShortBreak_TextBox.Text = "Short break time";
            // 
            // RoundTime_Button
            // 
            this.RoundTime_Button.Location = new System.Drawing.Point(199, 88);
            this.RoundTime_Button.Name = "RoundTime_Button";
            this.RoundTime_Button.Size = new System.Drawing.Size(75, 23);
            this.RoundTime_Button.TabIndex = 5;
            this.RoundTime_Button.Text = "save";
            this.RoundTime_Button.UseVisualStyleBackColor = true;
            this.RoundTime_Button.Click += new System.EventHandler(this.RoundTime_Button_Click);
            // 
            // RoundTime_TextBox
            // 
            this.RoundTime_TextBox.Location = new System.Drawing.Point(199, 59);
            this.RoundTime_TextBox.Name = "RoundTime_TextBox";
            this.RoundTime_TextBox.Size = new System.Drawing.Size(100, 23);
            this.RoundTime_TextBox.TabIndex = 6;
            this.RoundTime_TextBox.Text = "Round time";
            // 
            // LongBreak_Button
            // 
            this.LongBreak_Button.Location = new System.Drawing.Point(199, 194);
            this.LongBreak_Button.Name = "LongBreak_Button";
            this.LongBreak_Button.Size = new System.Drawing.Size(75, 23);
            this.LongBreak_Button.TabIndex = 7;
            this.LongBreak_Button.Text = "save";
            this.LongBreak_Button.UseVisualStyleBackColor = true;
            this.LongBreak_Button.Click += new System.EventHandler(this.LongBreak_Button_Click);
            // 
            // LongBreak_TextBox
            // 
            this.LongBreak_TextBox.Location = new System.Drawing.Point(199, 165);
            this.LongBreak_TextBox.Name = "LongBreak_TextBox";
            this.LongBreak_TextBox.Size = new System.Drawing.Size(100, 23);
            this.LongBreak_TextBox.TabIndex = 8;
            this.LongBreak_TextBox.Text = "Long break time";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(391, 450);
            this.Controls.Add(this.LongBreak_TextBox);
            this.Controls.Add(this.LongBreak_Button);
            this.Controls.Add(this.RoundTime_TextBox);
            this.Controls.Add(this.RoundTime_Button);
            this.Controls.Add(this.ShortBreak_TextBox);
            this.Controls.Add(this.ShortBreak_Button);
            this.Controls.Add(this.MaxRounds_TextBox);
            this.Controls.Add(this.MaxRounds_Button);
            this.Controls.Add(this.ExitSettings_Button);
            this.Name = "Form3";
            this.Text = "Pomodoro Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ExitSettings_Button;
        private Button MaxRounds_Button;
        private TextBox MaxRounds_TextBox;
        private Button ShortBreak_Button;
        private TextBox ShortBreak_TextBox;
        private Button RoundTime_Button;
        private TextBox RoundTime_TextBox;
        private Button LongBreak_Button;
        private TextBox LongBreak_TextBox;
    }
}