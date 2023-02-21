using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

 
namespace Utilities.v2
{
    public partial class Form2 : Form
    {
        public static int round_time = 20;
        public static int short_break = 5;
        public static int long_break = 15;
        public static int max_round_count = 4;
        public static int round_count = 0;
        //0: focus, 1 short break, 2 long break
        public int state = 0;
        public bool pause = true;
        public int total_time;
        public int SECONDS_PER_MINUTE = 60;
        public int max_time;
        Thread form1thread;
        Thread ToDo_thread;

        
        public static class FormState
        {
            public static int time=0;
            public static int rounds=0; 
            public static bool pauseS= true;
        }

        public Form2()
        {
            InitializeComponent();
            total_time = FormState.time;
            round_count = FormState.rounds;
            pause = FormState.pauseS;
            RoundCount_TextBox.Text = round_count.ToString() + '/' + max_round_count.ToString();
            Timer.Stop();
        }

        private void Form1_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            form1thread = new Thread(Open_Form1);
            form1thread.SetApartmentState(ApartmentState.STA);
            form1thread.Start();
            
        }
        private void Open_Form1()
        {
            Application.Run(new Form1()); 
        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            FormState.time = total_time;
            FormState.rounds = round_count;
            FormState.pauseS = pause;

            pause = true;
            Timer.Stop();
            TimerControl_Button.Text = "Resume";
            var form3 = new Form3();
            form3.Show();
        }

        private void TimerControl_Button_Click(object sender, EventArgs e)
        {
            if (pause)
            {
                pause = false;
                TimerControl_Button.Text = "Stop";
                Timer.Start();
                RoundCount_TextBox.Text = round_count.ToString() + '/' + max_round_count.ToString();
            }
            else
            {
                pause = true;
                TimerControl_Button.Text = "Resume";
                Timer.Stop();
            }
        }
        private string Set_MaxTime()
        {
            string message_box_message = string.Empty;
            switch (state)
            {
                case 0:
                    State_TextBox.Text = "Focus";
                    max_time = round_time;
                    message_box_message = "Begin a short break";

                    break;
                case 1:
                    State_TextBox.Text = "Short Break";
                    max_time = short_break;
                    message_box_message = "focus again";
                    break;
                case 2:
                    State_TextBox.Text = "Long Break";
                    max_time = long_break;
                    message_box_message = "focus again";
                    break;
            }
            max_time *= SECONDS_PER_MINUTE;
            return message_box_message;

        }
        private void Set_State()
        {
            switch (state)
            {
                case 0:
                    if (round_count == max_round_count)
                    {
                        state = 2;
                        round_count = 0;
                        break;
                    }
                    state = 1;
                    break;
                case 1:
                    state = 0;
                    break;
                case 2:
                    state = 0;
                    break;

            }

        }
        private string Time_Display(int seconds)
        {
            return TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss"); 
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            string message_box = Set_MaxTime();
            
            
            total_time++;


            Timer_TextBox.Text = Time_Display(total_time);
            


            if (total_time == max_time)
            {
                if (state == 0)
                {
                    round_count++;
                }
                if (!pause)
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    MessageBox.Show(message_box,"timer finished",MessageBoxButtons.OK);
                }
                Set_State();

                total_time= 0;
                RoundCount_TextBox.Text = round_count.ToString() + '/' + max_round_count.ToString();
                
            }
            
            
        }

        private void RoundCount_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Skip_Button_Click(object sender, EventArgs e)
        {
            if (state == 0) round_count++;
            total_time= 0;
            Set_State();
            RoundCount_TextBox.Text = round_count.ToString() + '/' + max_round_count.ToString();
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
    }
}
