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

namespace Home
{
    public partial class Form1 : Form
    {
        public string Version_Number = "1.0";


        public Form1()
        {
            InitializeComponent();
            Start.Click += Start_Click;
            Quit.Click += Quit_Click;
            LevelBtn.Click += LevelBtn_Click;
            StatsBtn.Click += StatsBtn_Click;
            Version.Text = $"Version: v{Version_Number}";

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

        private void StatsBtn_Click(object sender, EventArgs e)
        {
            Execute(@"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Statistics\bin\Debug\Statistics.exe");
        }

        private void LevelBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Execute(@"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\bin\Debug\ToDo.exe");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
