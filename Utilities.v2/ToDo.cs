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
using static System.Windows.Forms.DataFormats;

namespace Utilities.v2
{
    public partial class ToDo : Form
    {
        //Entry[] entries;
        List<Entry> entries = new List<Entry>();


        public static int Entry_Count = 0;
        Thread Pomodoro_Thread;
        Thread YTDownload_Thread;
        //public string[] lines;
        List<string> lines = new List<string>();
        private class Entry
        {
            public int ID;
            public string Name;
            public string Desc;
            public bool done;


            public Entry(string name, string desc){
                this.ID = Entry_Count++;
                this.Name = name;
                this.Desc = desc;
                this.done = false;
            }
            public Entry()
            {
                this.ID = 0;
                this.Name = string.Empty;
                this.Desc = string.Empty;
                this.done = false;
            }
        }
        private void Read_Log()
        {
            string entries_s = System.IO.File.ReadAllText(@"ToDo.txt");
            
            
            string[] lines_s = entries_s.Split(
            new string[] { Environment.NewLine },
            StringSplitOptions.None
            );
            int max = lines_s.Length;

            foreach (string line in lines_s) lines.Add(line);

            //entries = new Entry[Entry_Count];

            string[] temp;
            for(int i=0; i<max; i++)
            {
                Entry entry = new Entry();
                entries.Add(entry);
                temp = lines[i].Split(',');

                entries[i].ID = Convert.ToInt32(temp[0]);
                entries[i].Name = temp[1];
                entries[i].Desc = temp[2];
                if (temp[3] == "0") entries[i].done = false;
                else entries[i].done = true;

            }
        }
        public ToDo()
        {
            InitializeComponent();
            Read_Log();
        }

        private void YTDownload_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            YTDownload_Thread = new Thread(Open_YTDownload);
            YTDownload_Thread.SetApartmentState(ApartmentState.STA);
            YTDownload_Thread.Start();
        }
        private void Open_YTDownload()
        {
            Application.Run(new Form1());
        }
        private void Open_Pomodoro()
        {
            Application.Run(new Form2());
        }

        private void Pomodoro_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Pomodoro_Thread = new Thread(Open_YTDownload);
            Pomodoro_Thread.SetApartmentState(ApartmentState.STA);
            Pomodoro_Thread.Start();
        }

        private void AddTask(string name, string desc)
        {
            Entry entry = new Entry(name,desc);
            // take data from UI elements

            entries.Add(entry);
            lines.Add(entry.ID.ToString() + ',' + entry.Name + ',' + entry.Desc + ',' + entry.done.ToString());


            UpdateLog();
        }
        private void UpdateLog()
        {
            System.IO.File.WriteAllText(@"ToDo.txt", string.Join('\n', lines.ToArray()));
        }
        private void RemoveTask(int ID)
        {

            entries.Remove(entries[ID]);
            Entry_Count--;
            for (int i = ID; i < entries.Count; i++) entries[i].ID = i;
            lines.Remove(lines[ID]);


            UpdateLog();
        }
        private void AddTask_Button_Click(object sender, EventArgs e)
        {
                   
        }
    }
}
