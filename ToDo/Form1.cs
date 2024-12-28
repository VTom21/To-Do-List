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

namespace ToDo
{

    public partial class Form1 : Form
    {
        class Tasks
        {

            public string Task { get; set; }
            public string Priority { get; set; }

            public Tasks(string _Task, string _Priority)
            {
                Task = _Task;
                Priority = _Priority;
            }

            public override string ToString()
            {
                return $"{Task} - {Priority}";
            }

            public override bool Equals(object obj)
            {
                if (obj is Tasks otherTask)
                {
                    return this.Task == otherTask.Task && this.Priority == otherTask.Priority;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return (Task, Priority).GetHashCode();
            }


        }

        public string newItem;
        public int seconds = 0;
        public int minutes = 0;
        public int hours = 0;
        public int total_time = 0;


        public string[] Rankings = new string[] { "Rookie", "Guardian", "Sergeant", "Novice", "Ace", "Iridescent" };

        //Paths

        public string home_path = @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Home\bin\Debug\Home.exe";

        public string[] character_links = new string[] {
            @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Sprites\Viking.png",
            @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Sprites\Rogue.png",
            @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Sprites\Mage.png",
            @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Sprites\Jinn.png",
            @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Sprites\Minotaur.png",
            @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Sprites\Minotaur2.png" };

        public string[] bar_links = new string[] {
        @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Bars\bar1.jpg",
        @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Bars\bar2.jpg",
        @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Bars\bar3.jpg",
        @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Bars\bar4.jpg",
        @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Bars\bar5.jpg",
        @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Bars\bar6.jpg",
        @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Bars\bar7.jpg",
        @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Bars\bar8.jpg",
        @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Bars\bar9.jpg",
        @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Bars\bar10.jpg",
        @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Bars\bar11.jpg"
        };

        public string full_time_txt = @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Text Files\total time.txt";
        public string total_xp_txt = @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Text Files\total xp.txt";
        public string highest_lvl_txt = @"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Text Files\level.txt";

        public int XP = 0;

        public int level = 1;

        public int xp_limit = 100;

        public int totalXP = 0;



        public Form1()
        {
            InitializeComponent();
            this.Icon = new System.Drawing.Icon(@"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Icons\add_list-48_45484.ico");
            Add.Click += Add_Click;
            Remove.Click += Remove_Click;
            Clear.Click += Clear_Click;
            ClearChecked.Click += ClearChecked_Click;
            Home.Click += Home_Click;
            timer1.Tick += Timer1_Tick;
            Timer_Start();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

            PriorityBox.Items.Add("Low");
            PriorityBox.Items.Add("Medium");
            PriorityBox.Items.Add("High");

            PriorityBox.SelectedItem = "Low";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Confirm Exit", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel = true;  
            }
            else
            {
                TotalTime();
                TotalXP();
                Highest_lvl();
            }


        }

        private void TotalTime()
        {
            using(StreamWriter writer = new StreamWriter(full_time_txt, true))
            {
                writer.WriteLine(total_time);
            }
        }

        private void TotalXP()
        {
            using (StreamWriter writer = new StreamWriter(total_xp_txt, true))
            {
                writer.WriteLine(totalXP);
            }
        }

        private void Highest_lvl()
        {
            int line;
            using (StreamReader reader = new StreamReader(highest_lvl_txt))
            {
                line = int.Parse(reader.ReadLine());
            }


            if (level > line)
            {
                using (StreamWriter writer = new StreamWriter(highest_lvl_txt, false))
                {
                    writer.WriteLine(level);
                }
            }

        }

        private void Timer_Start()
        {
            timer1.Start();
            timer1.Interval = 1000;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            total_time++;

            if (seconds >= 60)
            {
                seconds = 0;
                minutes++;
            }

            if (minutes >= 60)
            {
                minutes = 0;
                hours++;
            }


            Time_label.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }


        private void Execute(string path)
        {
            try
            {
                Application.Exit();
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening the application: {ex.Message}","Error Opening",MessageBoxButtons.OK);
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Execute(home_path);
        }

        private void Check_Bar()
        {
            double progressPercentage = (double) XP / xp_limit * 100;

            if (progressPercentage <= 10)
            {
                Bar.Image = Image.FromFile(bar_links[0]);  
            }
            else if (progressPercentage <= 20)
            {
                Bar.Image = Image.FromFile(bar_links[1]);  
            }
            else if (progressPercentage <= 30)
            {
                Bar.Image = Image.FromFile(bar_links[2]);  
            }
            else if (progressPercentage <= 40)
            {
                Bar.Image = Image.FromFile(bar_links[3]);  
            }
            else if (progressPercentage <= 50)
            {
                Bar.Image = Image.FromFile(bar_links[4]);  
            }
            else if (progressPercentage <= 60)
            {
                Bar.Image = Image.FromFile(bar_links[5]);  
            }
            else if (progressPercentage <= 70)
            {
                Bar.Image = Image.FromFile(bar_links[6]);  
            }
            else if (progressPercentage <= 80)
            {
                Bar.Image = Image.FromFile(bar_links[7]);  
            }
            else if (progressPercentage <= 90)
            {
                Bar.Image = Image.FromFile(bar_links[8]);  
            }
            else if (progressPercentage <= 100)
            {
                Bar.Image = Image.FromFile(bar_links[9]);  
            }
            else
            {
                Bar.Image = Image.FromFile(bar_links[10]);  
            }
        }




        private void Check_Ranking()
        {

            switch (level)
            {
                case 1:
                    Ranking_label.Text = $"{Rankings[0]}";
                    Character.Image = Image.FromFile(character_links[0]);
                    break;
                case 5:
                    Ranking_label.Text = $"{Rankings[1]}";
                    Character.Image = Image.FromFile(character_links[1]);
                    break;
                case 25:
                    Ranking_label.Text = $"{Rankings[2]}";
                    Character.Image = Image.FromFile(character_links[2]);
                    break;
                case 50:
                    Ranking_label.Text = $"{Rankings[3]}";
                    Character.Image = Image.FromFile(character_links[3]);
                    break;
                case 75:
                    Ranking_label.Text = $"{Rankings[4]}";
                    Character.Image = Image.FromFile(character_links[4]);
                    break;
                case int n when(n >= 100):
                    Ranking_label.Text = $"{Rankings[5]}";
                    Character.Image = Image.FromFile(character_links[5]);
                    break;
                default:
                    Ranking_label.Text = $"{Rankings[0]}";
                    Character.Image = Image.FromFile(character_links[0]);
                    break;
            }
        }

        private void ClearChecked_Click(object sender, EventArgs e)
        {
            var itemsToRemove = new List<Tasks>(); 
            int totalXPForCheckedTasks = 0; 

            foreach (var checkedItem in Content.CheckedItems)
            {
                if (checkedItem is Tasks task)
                {
                    int taskXP = 0;

                    switch (task.Priority)
                    {
                        case "Low":
                            taskXP = 5;
                            break;
                        case "Medium":
                            taskXP = 10;
                            break;
                        case "High":
                            taskXP = 15;
                            break;
                        default:
                            taskXP = 5; 
                            break;
                    }

                    totalXPForCheckedTasks += taskXP;
                    totalXP += taskXP;
                    itemsToRemove.Add(task); 
                }
            }

            XP += totalXPForCheckedTasks;

            while (XP >= xp_limit)
            {
                XP -= xp_limit;
                xp_limit += 100;
                level++;
                Check_Ranking(); 
            }

            xp_label.Text = $"{XP}/{xp_limit} XP";
            lvl_label.Text = $"lvl {level}";

            Check_Bar();

            foreach (var task in itemsToRemove)
            {
                Content.Items.Remove(task); 
            }
        }









        private void Clear_Click(object sender, EventArgs e)
        {
            Content.Items.Clear();
        }

        

        private void Remove_Click(object sender, EventArgs e)
        {
            newItem = Input.Text;
            Tasks remove = null;


            if (!string.IsNullOrEmpty(newItem))
            {
                foreach (Tasks task in Content.Items)
                {
                    if (task.Task == newItem)
                    {
                        remove = task;
                        break; 
                    }
                }

                if (remove != null)
                {
                    Content.Items.Remove(remove);
                    Input.Clear();
                }
                else
                {
                    MessageBox.Show("No Item to delete!", "Remove Fail", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No Item to delete!", "Remove Fail", MessageBoxButtons.OK);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Character.Image = Image.FromFile(character_links[0]);
            Bar.Image = Image.FromFile(bar_links[0]);
        }



        private void Add_Click(object sender, EventArgs e)
        {
            newItem = Input.Text;
            string selectedPriority = PriorityBox.SelectedItem.ToString();

            Tasks taskItem = new Tasks(newItem, selectedPriority);

            if (!Content.Items.Contains(taskItem))  
            {
                if (!string.IsNullOrWhiteSpace(newItem))
                {
                    Content.Items.Add(taskItem);  
                    Input.Clear();
                }
            }
            else
            {
                MessageBox.Show("Cannot add the same item twice!", "Duplicate Error", MessageBoxButtons.OK);
                Input.Clear();
            }
        }
    }
}
