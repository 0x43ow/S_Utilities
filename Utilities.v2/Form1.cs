using System.Diagnostics;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Threading;


namespace Utilities.v2
{
    public partial class Form1 : Form
    {
        //input
        public string url_YT = string.Empty;
        public string url_twitch = string.Empty;
        public string searchterm_YT = string.Empty;
        public string location = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        public string options = string.Empty;
        public string output_name = string.Empty;

        //commands
        public string playlist_command = "--playlist-items ";
        public string audio_command = " --extract-audio ";
        public string yt_dlp = @"/C yt-dlp.exe ";
        public string path_command = "--paths ";
        public string recover_command = @"/C python3 recover_streams.py ";
        public string search_command = "/C python3 YTsearch.py \"";

        //flags
        public bool playlist = false;
        public bool audio_only = false;
        public bool display_messages = true;
        public bool exit_on_completion = false;

        //indices
        public int index_start = 1;
        public int index_end = 0;
        Thread form2_thread;
        Thread ToDo_thread;

        public Form1()
        {
            InitializeComponent();
        }
        private void Run_Process(string args)
        {
            using (Process myProcess = new Process())
            {
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.StartInfo.FileName = "cmd";
                myProcess.StartInfo.Arguments = args;
                myProcess.Start();
                myProcess.WaitForExit();
            }
        }
        private void DownloadButton_Click(object sender, EventArgs e)
        {

            options += path_command + location + " ";
            if (audio_only)
            { 
                options += audio_command;
                if (output_name != string.Empty)
                {
                    options += "-o \"" + output_name + "\".%OPUS ";
                }
            }
            else
            {
                if (output_name != string.Empty)
                {
                    options += "-o \"" + output_name + "\" ";
                }
            }

            if (playlist)
                options += playlist_command + index_start + " " + index_end + " ";


            Run_Process(yt_dlp + options + url_YT);

            if (exit_on_completion)
                this.Close();
            else
                MessageBox.Show("finished");


            options = string.Empty;
            output_name = string.Empty;


        }

        private void Ytdlp_TextField_TextChanged(object sender, EventArgs e)
        {
            url_YT = Ytdlp_TextField.Text;
        }

        private void PlayList_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (playlist)
            {
                playlist = false;
                PlayList_StartIndex_Button.Visible = false;
                PlayList_EndIndex_Button.Visible = false;
            }

            else
            {
                playlist = true;
                PlayList_StartIndex_Button.Visible = true;
                PlayList_EndIndex_Button.Visible = true;
            }
        }

        private void AudioOnly_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (audio_only)
                audio_only = false;

            else
                audio_only = true;
        }

        private void Location_Button_Click(object sender, EventArgs e)
        {
            //choosing saving location button
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = location;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                location = dialog.FileName;
            }
        }

        private void TwitcherRecover_Textfield_TextChanged(object sender, EventArgs e)
        {
            url_twitch = TwitcherRecover_Textfield.Text;    
        }

        private void RecoverTwitch_Button_Click(object sender, EventArgs e)
        {
            //recover stream button
            Run_Process(recover_command + url_twitch);
            MessageBox.Show("copied link to clipboard");
        }

        private void YTsearch_Textfield_TextChanged(object sender, EventArgs e)
        {
            searchterm_YT = YTsearch_Textfield.Text;
        }

        private void YTsearch_Button_Click(object sender, EventArgs e)
        {
            Run_Process(search_command + searchterm_YT + "\"");
            if (display_messages)
                MessageBox.Show("copied link to clipboard");   
        }

        private void SearchDownload_Button_Click(object sender, EventArgs e)
        {
            display_messages = false;
            YTsearch_Button.PerformClick();
            url_YT = Clipboard.GetText();
            DownloadButton.PerformClick();
            display_messages = true;
        }

        private void PlayList_StartIndex_Button_TextChanged(object sender, EventArgs e)
        {
            try
            {
                index_start = Convert.ToInt32(PlayList_StartIndex_Button.Text);
            }
            catch
            {
                error_message();
            }
            if (index_start <= 0) error_message();
        }

        private void PlayList_EndIndex_Button_TextChanged(object sender, EventArgs e)
        {
            try
            {
                index_end = Convert.ToInt32(PlayList_EndIndex_Button.Text);
            }
            catch
            {
                error_message();
            }
            if (index_end <= 0)
            {
                error_message();
            }
        }

        private void error_message()
        {
            playlist = false;
            PlayList_CheckBox.Checked = false;
            MessageBox.Show("invalid number");
        }

        private void Pomodoro_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            form2_thread = new Thread(Run_Form2);
            form2_thread.SetApartmentState(ApartmentState.STA);
            form2_thread.Start();  
        }
        private void Run_Form2()
        {
            Application.Run(new Form2());
        }

        private void Exit_Completion_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (exit_on_completion)
                exit_on_completion = false;

            else
                exit_on_completion = true;
        }

        private void ToDo_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            ToDo_thread = new Thread(Open_ToDo);
            ToDo_thread.SetApartmentState(ApartmentState.STA);
            ToDo_thread.Start();
        }
        private void Open_ToDo()
        {
            Application.Run(new ToDo());
        }

        private void YTName_Button_TextChanged(object sender, EventArgs e)
        {
            output_name =  YTName_Button.Text;
        }
    }
}