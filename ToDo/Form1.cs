using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Character.Image = Image.FromFile(@"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Sprites\Jinn.png");
            Bar.Image = Image.FromFile(@"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Bars\bar7_processed.jpg");
        }

    }
}
