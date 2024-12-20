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
namespace Statistics
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            Home.Click += Home_Click;
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
