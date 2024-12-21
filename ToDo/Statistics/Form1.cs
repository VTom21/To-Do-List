using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace Statistics
{
    public partial class Form1: Form
    {

        public List<int> total_time = new List<int>();
        public List<int> total_XP = new List<int>();

        public string total_time_path = @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Text Files\total time.txt";
        public string total_XP_path = @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Text Files\total xp.txt";
        public string highest_lvl_path = @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Text Files\level.txt";
        public int seconds;
        public int minutes;
        public int hours;
        public int days;
        public Form1()
        {
            InitializeComponent();
            Home.Click += Home_Click;
            this.Load += Form1_Load;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Total_Time();
            Total_XP();
            Highest_lvl();
        }

        

        private void Total_Time()
        {
            using(StreamReader reader = new StreamReader(total_time_path))
            {
                while (!reader.EndOfStream)
                {
                    total_time.Add(int.Parse(reader.ReadLine()));
                }
            }
            days = total_time.Sum() / 86400;
            hours = (total_time.Sum() % 86400) / 3600;  
            minutes = (total_time.Sum() % 3600) / 60;   
            seconds = total_time.Sum() % 60;

            total_time_label.Text = $"{days:D1}d {hours:D1}h {minutes:D1}m {seconds:D1}s ";

        }

        private void Total_XP()
        {
            using (StreamReader reader = new StreamReader(total_XP_path))
            {
                while (!reader.EndOfStream)
                {
                    total_XP.Add(int.Parse(reader.ReadLine()));
                }
            }

            total_xp_label.Text = $"{total_XP.Sum()} XP";
        }

        private void Highest_lvl()
        {
            using (StreamReader reader = new StreamReader(highest_lvl_path))
            {

                highest_lvl_label.Text = $"lvl {reader.ReadLine()}";
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Execute(@"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Home\bin\Debug\Home.exe");
        }

        private void Execute(string path)
        {
            try
            {
                Process.Start(path);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening the application: {ex.Message}");
            }
        }

    }
}
