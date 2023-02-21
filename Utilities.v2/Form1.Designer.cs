namespace Utilities.v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DownloadButton = new System.Windows.Forms.Button();
            this.Ytdlp_TextField = new System.Windows.Forms.TextBox();
            this.PlayList_CheckBox = new System.Windows.Forms.CheckBox();
            this.AudioOnly_CheckBox = new System.Windows.Forms.CheckBox();
            this.Location_Button = new System.Windows.Forms.Button();
            this.TwitcherRecover_Textfield = new System.Windows.Forms.TextBox();
            this.RecoverTwitch_Button = new System.Windows.Forms.Button();
            this.YTsearch_Button = new System.Windows.Forms.Button();
            this.YTsearch_Textfield = new System.Windows.Forms.TextBox();
            this.TwitchRecover_label = new System.Windows.Forms.Label();
            this.YTsearch_label = new System.Windows.Forms.Label();
            this.YTDL_label = new System.Windows.Forms.Label();
            this.SearchDownload_Button = new System.Windows.Forms.Button();
            this.PlayList_EndIndex_Button = new System.Windows.Forms.TextBox();
            this.PlayList_StartIndex_Button = new System.Windows.Forms.TextBox();
            this.Pomodoro_Button = new System.Windows.Forms.Button();
            this.Exit_Completion_CheckBox = new System.Windows.Forms.CheckBox();
            this.ToDo_Button = new System.Windows.Forms.Button();
            this.YTName_Button = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(50, 84);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(75, 23);
            this.DownloadButton.TabIndex = 0;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // Ytdlp_TextField
            // 
            this.Ytdlp_TextField.Location = new System.Drawing.Point(50, 55);
            this.Ytdlp_TextField.Name = "Ytdlp_TextField";
            this.Ytdlp_TextField.Size = new System.Drawing.Size(306, 23);
            this.Ytdlp_TextField.TabIndex = 1;
            this.Ytdlp_TextField.Text = "url";
            this.Ytdlp_TextField.TextChanged += new System.EventHandler(this.Ytdlp_TextField_TextChanged);
            // 
            // PlayList_CheckBox
            // 
            this.PlayList_CheckBox.AutoSize = true;
            this.PlayList_CheckBox.Location = new System.Drawing.Point(209, 88);
            this.PlayList_CheckBox.Name = "PlayList_CheckBox";
            this.PlayList_CheckBox.Size = new System.Drawing.Size(90, 19);
            this.PlayList_CheckBox.TabIndex = 2;
            this.PlayList_CheckBox.Text = "Slice Playlist";
            this.PlayList_CheckBox.UseVisualStyleBackColor = true;
            this.PlayList_CheckBox.CheckedChanged += new System.EventHandler(this.PlayList_CheckBox_CheckedChanged);
            // 
            // AudioOnly_CheckBox
            // 
            this.AudioOnly_CheckBox.AutoSize = true;
            this.AudioOnly_CheckBox.Location = new System.Drawing.Point(298, 88);
            this.AudioOnly_CheckBox.Name = "AudioOnly_CheckBox";
            this.AudioOnly_CheckBox.Size = new System.Drawing.Size(58, 19);
            this.AudioOnly_CheckBox.TabIndex = 3;
            this.AudioOnly_CheckBox.Text = "Audio";
            this.AudioOnly_CheckBox.UseVisualStyleBackColor = true;
            this.AudioOnly_CheckBox.CheckedChanged += new System.EventHandler(this.AudioOnly_CheckBox_CheckedChanged);
            // 
            // Location_Button
            // 
            this.Location_Button.Location = new System.Drawing.Point(128, 84);
            this.Location_Button.Name = "Location_Button";
            this.Location_Button.Size = new System.Drawing.Size(75, 23);
            this.Location_Button.TabIndex = 4;
            this.Location_Button.Text = "Location";
            this.Location_Button.UseVisualStyleBackColor = true;
            this.Location_Button.Click += new System.EventHandler(this.Location_Button_Click);
            // 
            // TwitcherRecover_Textfield
            // 
            this.TwitcherRecover_Textfield.Location = new System.Drawing.Point(50, 290);
            this.TwitcherRecover_Textfield.Name = "TwitcherRecover_Textfield";
            this.TwitcherRecover_Textfield.Size = new System.Drawing.Size(306, 23);
            this.TwitcherRecover_Textfield.TabIndex = 5;
            this.TwitcherRecover_Textfield.Text = "url";
            this.TwitcherRecover_Textfield.TextChanged += new System.EventHandler(this.TwitcherRecover_Textfield_TextChanged);
            // 
            // RecoverTwitch_Button
            // 
            this.RecoverTwitch_Button.Location = new System.Drawing.Point(50, 319);
            this.RecoverTwitch_Button.Name = "RecoverTwitch_Button";
            this.RecoverTwitch_Button.Size = new System.Drawing.Size(75, 23);
            this.RecoverTwitch_Button.TabIndex = 6;
            this.RecoverTwitch_Button.Text = "Recover";
            this.RecoverTwitch_Button.UseVisualStyleBackColor = true;
            this.RecoverTwitch_Button.Click += new System.EventHandler(this.RecoverTwitch_Button_Click);
            // 
            // YTsearch_Button
            // 
            this.YTsearch_Button.Location = new System.Drawing.Point(50, 237);
            this.YTsearch_Button.Name = "YTsearch_Button";
            this.YTsearch_Button.Size = new System.Drawing.Size(75, 23);
            this.YTsearch_Button.TabIndex = 7;
            this.YTsearch_Button.Text = "Search";
            this.YTsearch_Button.UseVisualStyleBackColor = true;
            this.YTsearch_Button.Click += new System.EventHandler(this.YTsearch_Button_Click);
            // 
            // YTsearch_Textfield
            // 
            this.YTsearch_Textfield.Location = new System.Drawing.Point(50, 208);
            this.YTsearch_Textfield.Name = "YTsearch_Textfield";
            this.YTsearch_Textfield.Size = new System.Drawing.Size(306, 23);
            this.YTsearch_Textfield.TabIndex = 8;
            this.YTsearch_Textfield.Text = "Search term";
            this.YTsearch_Textfield.TextChanged += new System.EventHandler(this.YTsearch_Textfield_TextChanged);
            // 
            // TwitchRecover_label
            // 
            this.TwitchRecover_label.AutoSize = true;
            this.TwitchRecover_label.Location = new System.Drawing.Point(50, 272);
            this.TwitchRecover_label.Name = "TwitchRecover_label";
            this.TwitchRecover_label.Size = new System.Drawing.Size(131, 15);
            this.TwitchRecover_label.TabIndex = 10;
            this.TwitchRecover_label.Text = "Recover Twitch Streams";
            // 
            // YTsearch_label
            // 
            this.YTsearch_label.AutoSize = true;
            this.YTsearch_label.Location = new System.Drawing.Point(50, 190);
            this.YTsearch_label.Name = "YTsearch_label";
            this.YTsearch_label.Size = new System.Drawing.Size(89, 15);
            this.YTsearch_label.TabIndex = 11;
            this.YTsearch_label.Text = "Search Youtube";
            // 
            // YTDL_label
            // 
            this.YTDL_label.AutoSize = true;
            this.YTDL_label.Location = new System.Drawing.Point(50, 37);
            this.YTDL_label.Name = "YTDL_label";
            this.YTDL_label.Size = new System.Drawing.Size(146, 15);
            this.YTDL_label.TabIndex = 12;
            this.YTDL_label.Text = "Download Youtube Videos";
            // 
            // SearchDownload_Button
            // 
            this.SearchDownload_Button.Location = new System.Drawing.Point(131, 237);
            this.SearchDownload_Button.Name = "SearchDownload_Button";
            this.SearchDownload_Button.Size = new System.Drawing.Size(160, 23);
            this.SearchDownload_Button.TabIndex = 13;
            this.SearchDownload_Button.Text = "Search and Download";
            this.SearchDownload_Button.UseVisualStyleBackColor = true;
            this.SearchDownload_Button.Click += new System.EventHandler(this.SearchDownload_Button_Click);
            // 
            // PlayList_EndIndex_Button
            // 
            this.PlayList_EndIndex_Button.Location = new System.Drawing.Point(131, 137);
            this.PlayList_EndIndex_Button.Name = "PlayList_EndIndex_Button";
            this.PlayList_EndIndex_Button.Size = new System.Drawing.Size(75, 23);
            this.PlayList_EndIndex_Button.TabIndex = 14;
            this.PlayList_EndIndex_Button.Text = "End Index";
            this.PlayList_EndIndex_Button.Visible = false;
            this.PlayList_EndIndex_Button.TextChanged += new System.EventHandler(this.PlayList_EndIndex_Button_TextChanged);
            // 
            // PlayList_StartIndex_Button
            // 
            this.PlayList_StartIndex_Button.Location = new System.Drawing.Point(50, 137);
            this.PlayList_StartIndex_Button.Name = "PlayList_StartIndex_Button";
            this.PlayList_StartIndex_Button.Size = new System.Drawing.Size(75, 23);
            this.PlayList_StartIndex_Button.TabIndex = 15;
            this.PlayList_StartIndex_Button.Text = "Start Index";
            this.PlayList_StartIndex_Button.Visible = false;
            this.PlayList_StartIndex_Button.TextChanged += new System.EventHandler(this.PlayList_StartIndex_Button_TextChanged);
            // 
            // Pomodoro_Button
            // 
            this.Pomodoro_Button.Location = new System.Drawing.Point(50, 362);
            this.Pomodoro_Button.Name = "Pomodoro_Button";
            this.Pomodoro_Button.Size = new System.Drawing.Size(75, 23);
            this.Pomodoro_Button.TabIndex = 16;
            this.Pomodoro_Button.Text = "Pomodoro";
            this.Pomodoro_Button.UseVisualStyleBackColor = true;
            this.Pomodoro_Button.Click += new System.EventHandler(this.Pomodoro_Button_Click);
            // 
            // Exit_Completion_CheckBox
            // 
            this.Exit_Completion_CheckBox.AutoSize = true;
            this.Exit_Completion_CheckBox.Location = new System.Drawing.Point(209, 112);
            this.Exit_Completion_CheckBox.Name = "Exit_Completion_CheckBox";
            this.Exit_Completion_CheckBox.Size = new System.Drawing.Size(126, 19);
            this.Exit_Completion_CheckBox.TabIndex = 17;
            this.Exit_Completion_CheckBox.Text = "Exit on completion";
            this.Exit_Completion_CheckBox.UseVisualStyleBackColor = true;
            this.Exit_Completion_CheckBox.CheckedChanged += new System.EventHandler(this.Exit_Completion_CheckBox_CheckedChanged);
            // 
            // ToDo_Button
            // 
            this.ToDo_Button.Location = new System.Drawing.Point(147, 362);
            this.ToDo_Button.Name = "ToDo_Button";
            this.ToDo_Button.Size = new System.Drawing.Size(75, 23);
            this.ToDo_Button.TabIndex = 18;
            this.ToDo_Button.Text = "To Do";
            this.ToDo_Button.UseVisualStyleBackColor = true;
            this.ToDo_Button.Visible = false;
            this.ToDo_Button.Click += new System.EventHandler(this.ToDo_Button_Click);
            // 
            // YTName_Button
            // 
            this.YTName_Button.Location = new System.Drawing.Point(50, 108);
            this.YTName_Button.Name = "YTName_Button";
            this.YTName_Button.Size = new System.Drawing.Size(153, 23);
            this.YTName_Button.TabIndex = 19;
            this.YTName_Button.Text = "Name";
            this.YTName_Button.TextChanged += new System.EventHandler(this.YTName_Button_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.YTName_Button);
            this.Controls.Add(this.ToDo_Button);
            this.Controls.Add(this.Exit_Completion_CheckBox);
            this.Controls.Add(this.Pomodoro_Button);
            this.Controls.Add(this.PlayList_StartIndex_Button);
            this.Controls.Add(this.PlayList_EndIndex_Button);
            this.Controls.Add(this.SearchDownload_Button);
            this.Controls.Add(this.YTDL_label);
            this.Controls.Add(this.YTsearch_label);
            this.Controls.Add(this.TwitchRecover_label);
            this.Controls.Add(this.YTsearch_Textfield);
            this.Controls.Add(this.YTsearch_Button);
            this.Controls.Add(this.RecoverTwitch_Button);
            this.Controls.Add(this.TwitcherRecover_Textfield);
            this.Controls.Add(this.Location_Button);
            this.Controls.Add(this.AudioOnly_CheckBox);
            this.Controls.Add(this.PlayList_CheckBox);
            this.Controls.Add(this.Ytdlp_TextField);
            this.Controls.Add(this.DownloadButton);
            this.Name = "Form1";
            this.Text = "Utilities";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DownloadButton;
        private TextBox Ytdlp_TextField;
        private CheckBox PlayList_CheckBox;
        private CheckBox AudioOnly_CheckBox;
        private Button Location_Button;
        private TextBox TwitcherRecover_Textfield;
        private Button RecoverTwitch_Button;
        private Button YTsearch_Button;
        private TextBox YTsearch_Textfield;
        private Label TwitchRecover_label;
        private Label YTsearch_label;
        private Label YTDL_label;
        private Button SearchDownload_Button;
        private TextBox PlayList_EndIndex_Button;
        private TextBox PlayList_StartIndex_Button;
        private Button Pomodoro_Button;
        private CheckBox Exit_Completion_CheckBox;
        private Button ToDo_Button;
        private TextBox YTName_Button;
    }
}