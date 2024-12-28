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
using System.Windows.Forms.DataVisualization.Charting;
namespace Statistics
{
    public partial class Form1: Form
    {
        public ChartArea chartArea1 = new ChartArea("MainArea1");
        public Series barSeries = new Series("Tasks Completed");
        public ChartArea chartArea2 = new ChartArea("MainArea2");
        public Series pieSeries = new Series("Task Categories");

        int xp_int = 0;


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
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Icon = new System.Drawing.Icon(@"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Icons\add_list-48_45484.ico");

        }

        public string home_path = @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Home\bin\Debug\Home.exe";

        private void Form1_Load(object sender, EventArgs e)
        {
            Total_Time();
            Total_XP();
            Highest_lvl();
            Chart_Call();
        }

        private void Chart_Call()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            chart1.ChartAreas.Add(chartArea1);



            barSeries.ChartType = SeriesChartType.Bar; 
            barSeries.Color = System.Drawing.Color.RoyalBlue; 

            chart1.Series.Add(barSeries);

            chart2.Series.Clear();
            chart2.ChartAreas.Clear();

            chart2.ChartAreas.Add(chartArea2);

            pieSeries.ChartType = SeriesChartType.Pie; 
            pieSeries.Color = System.Drawing.Color.RoyalBlue; 

            chart2.Series.Add(pieSeries);
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
            barSeries.Points.AddXY($"Total Time", total_time.Sum());
            pieSeries.Points.AddXY($"Total Time", total_time.Sum());

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
            barSeries.Points.AddXY("Total XP", total_XP.Sum());
            pieSeries.Points.AddXY("Total XP", total_XP.Sum());
        }

        private void Highest_lvl()
        {
            using (StreamReader reader = new StreamReader(highest_lvl_path))
            {

                highest_lvl_label.Text = $"lvl {reader.ReadLine()}";
                xp_int = Convert.ToInt32(reader.ReadLine());
                barSeries.Points.AddXY("Highest Level", xp_int);
                pieSeries.Points.AddXY("Highest Level", xp_int);
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Execute(home_path);
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
