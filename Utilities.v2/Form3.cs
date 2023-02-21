using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities.v2
{
    public partial class Form3 : Form
    {   
        //public Form2 form2 = new Form2();
        public Form3()
        {
            InitializeComponent();
        }

        private void ExitSettings_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            //form2.Show();
        }

        private void MaxRounds_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaxRounds_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Form2.max_round_count = Convert.ToInt32(MaxRounds_TextBox.Text);
            }
            catch
            {
                MessageBox.Show("invalid number, the max round count is " + Form2.max_round_count);
            }
            if (Form2.max_round_count <= 0)
            {
                MessageBox.Show("invalid number, the max round count is set to 4");
                Form2.max_round_count = 4;
            }
        }

        private void RoundTime_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Form2.round_time = Convert.ToInt32(RoundTime_TextBox.Text);
            }
            catch
            {
                MessageBox.Show("invalid number, the round tme is  " + Form2.round_time);
            }
            if (Form2.round_time <= 0)
            {
                MessageBox.Show("invalid number, the round time is set to 20");
                Form2.round_time = 20;
            }

        }

        private void ShortBreak_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Form2.short_break = Convert.ToInt32(ShortBreak_TextBox.Text);
            }
            catch
            {
                MessageBox.Show("invalid number, the short break time is " + Form2.short_break);
            }
            if (Form2.short_break <= 0)
            {
                MessageBox.Show("invalid number, the short break time is set to 5");
                Form2.short_break = 5;
            }

        }

        private void LongBreak_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Form2.long_break = Convert.ToInt32(LongBreak_TextBox.Text);
            }
            catch
            {
                MessageBox.Show("invalid number, the long break time is " + Form2.long_break);
            }
            if (Form2.long_break <= 0)
            {
                MessageBox.Show("invalid number, the long break time is set to 15");
                Form2.long_break = 5;
            }
        }
    }
}
