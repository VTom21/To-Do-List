using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Level_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Write();
            Home.Click += Home_Click;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Icon = new System.Drawing.Icon(@"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Icons\add_list-48_45484.ico");
        }

        public string home_path = @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Home\bin\Debug\Home.exe";

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

        private void Home_Click(object sender, EventArgs e)
        {
            Execute(home_path);
        }

        private void Write()
        {


            string[] lvl = new string[] { "level 1-4", "level 5-24", "level 25-49", "level 50-74", "level 75-99", "level 100+" };
            string[] Rankings = new string[] { "Rookie", "Guardian", "Sergeant", "Novice", "Ace", "Iridescent" };
            Label[] labels = new Label[] {label1,label2,label3,label4,label5,label6};

            Label[] labels2 = new Label[] { label7, label8, label9, label10, label11, label12 };

            string[] character_links = new string[] {
            @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Sprites\Viking.png",
            @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Sprites\Rogue.png",
            @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Sprites\Mage.png",
            @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Sprites\Jinn.png",
            @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Sprites\Minotaur.png",
            @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Sprites\Minotaur2.png" };

            PictureBox[] pictureboxes = new PictureBox[] {pictureBox1,pictureBox2,pictureBox3,pictureBox4,pictureBox5,pictureBox6};

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].AutoSize = false;
                labels[i].Size = new Size(150, 30);  
                labels[i].Text = lvl[i]; 
                labels[i].TextAlign = ContentAlignment.MiddleCenter; 

                labels2[i].AutoSize = false;
                labels2[i].Size = new Size(150, 30);  
                labels2[i].Text = Rankings[i]; 
                labels2[i].TextAlign = ContentAlignment.MiddleCenter;


                if (File.Exists(character_links[i]))
                {
                    pictureboxes[i].Image = Image.FromFile(character_links[i]); 
                }

                pictureboxes[i].SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}


