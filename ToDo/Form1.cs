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
            this.Themes.SelectedIndexChanged += new System.EventHandler(this.comboBoxThemes_SelectedIndexChanged);
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
            Themes.Items.Add("Cyan");
            Themes.Items.Add("Dark");
            Themes.Items.Add("Purple");
            Themes.Items.Add("Holographic");
            Themes.Items.Add("Tropical");
            Themes.Items.Add("Red");

            Themes.SelectedIndex = 0;
            string selectedTheme = Themes.SelectedItem.ToString();

            ApplyTheme(selectedTheme);

            Character.Image = Image.FromFile(character_links[0]);
            Bar.Image = Image.FromFile(bar_links[0]);
        }

        private void ApplyTheme(string theme)
        {
            switch (theme)
            {
                case "Dark":
                    Dark_Theme();
                    break;
                case "Purple":
                    Purple_Theme();
                    break;
                case "Holographic":
                    Holographic_White();
                    break;
                case "Tropical":
                    Orange_Theme();
                    break;
                case "Red":
                    Red_Theme();
                    break;
                default:
                    Default_Theme(); 
                    break;
            }
        }

        private void Default_Theme()
        {

            ApplyThemeToControls(
                System.Drawing.Color.FromArgb(199, 232, 239),  
                System.Drawing.Color.FromArgb(92, 95, 95)     
            );


            Themes.ForeColor = System.Drawing.Color.FromArgb(92, 95, 95);
            Themes.BackColor = System.Drawing.Color.FromArgb(199, 232, 239);

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = (Button)ctrl;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.ForeColor = Color.FromArgb(92, 95, 95);
                    btn.BackColor = Color.FromArgb(160, 222, 236);
                    btn.FlatAppearance.BorderColor = Color.White;
                }
                if (ctrl is TextBox || ctrl is RichTextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.BackColor = Color.FromArgb(160, 222, 236);
                    tb.ForeColor = Color.FromArgb(92, 95, 95);
                    tb.BorderStyle = BorderStyle.None;
                    tb.Font = new Font("Sitka Text", tb.Font.Size, FontStyle.Regular);
                }
                if (ctrl is CheckedListBox)
                {
                    CheckedListBox clb = (CheckedListBox)ctrl;
                    clb.ForeColor = Color.FromArgb(92, 95, 95);
                    clb.BackColor = Color.FromArgb(160, 222, 236);
                    clb.Font = new Font("Sitka Text", 14.25F, FontStyle.Regular); 

                }
                if (ctrl is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctrl;
                    cb.DropDownStyle = ComboBoxStyle.DropDownList; 
                    cb.ForeColor = Color.FromArgb(92, 95, 95);
                    cb.BackColor = Color.FromArgb(160, 222, 236);
                }
            }

        }

        private void Dark_Theme()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);  
            this.ForeColor = Color.White;  

            ApplyThemeToControls(Color.FromArgb(30, 30, 30), Color.Red);

            Themes.ForeColor = Color.White;
            Themes.BackColor = Color.FromArgb(45, 45, 45);  

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = (Button)ctrl;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.ForeColor = Color.Red;  
                    btn.BackColor = Color.FromArgb(65, 67, 69);  
                    btn.FlatAppearance.BorderColor = Color.White;  
                }

                if (ctrl is TextBox || ctrl is RichTextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.BackColor = Color.FromArgb(65, 67, 69);  
                    tb.ForeColor = Color.Red;  
                    tb.BorderStyle = BorderStyle.None;
                    tb.Font = new Font("Sitka Text", tb.Font.Size, FontStyle.Regular);
                }

                if (ctrl is CheckedListBox)
                {
                    CheckedListBox clb = (CheckedListBox)ctrl;
                    clb.ForeColor = Color.Red;  
                    clb.BackColor = Color.FromArgb(65, 67, 69);  
                    clb.Font = new Font("Sitka Text", 14.25F, FontStyle.Regular);
                }

                if (ctrl is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctrl;
                    cb.DropDownStyle = ComboBoxStyle.DropDownList;  
                    cb.ForeColor = Color.Red;  
                    cb.BackColor = Color.FromArgb(65, 67, 69);  
                }

            }
        }

        private void Purple_Theme()
        {
            this.BackColor = Color.FromArgb(157, 80, 187);  
            this.ForeColor = Color.FromArgb(255, 255, 255);  

            ApplyThemeToControls(Color.FromArgb(157, 80, 187), Color.FromArgb(255, 255, 255));

            Themes.ForeColor = Color.FromArgb(255, 255, 255);  
            Themes.BackColor = Color.FromArgb(35, 37, 38);  

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = (Button)ctrl;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.ForeColor = Color.FromArgb(255, 255, 255);  
                    btn.BackColor = Color.FromArgb(110, 72, 170);  
                    btn.FlatAppearance.BorderColor = Color.FromArgb(35, 37, 38);  
                }

                if (ctrl is TextBox || ctrl is RichTextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.BackColor = Color.FromArgb(35, 37, 38);  
                    tb.ForeColor = Color.FromArgb(255, 255, 255);  
                    tb.BorderStyle = BorderStyle.FixedSingle;  
                }

                if (ctrl is CheckedListBox)
                {
                    CheckedListBox clb = (CheckedListBox)ctrl;
                    clb.ForeColor = Color.FromArgb(255, 255, 255);  
                    clb.BackColor = Color.FromArgb(35, 37, 38);  
                }

                if (ctrl is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctrl;
                    cb.DropDownStyle = ComboBoxStyle.DropDownList;
                    cb.ForeColor = Color.FromArgb(255, 255, 255);  
                    cb.BackColor = Color.FromArgb(35, 37, 38);  
                }

                if (ctrl is ListBox)
                {
                    ctrl.ForeColor = Color.FromArgb(255, 255, 255);  
                    ctrl.BackColor = Color.FromArgb(35, 37, 38);  
                }
            }
        }

        private void Holographic_White()
        {
            // Set form background to a very dark gray for a sleek, subtle look
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.FromArgb(255, 255, 255);

            ApplyThemeToControls(Color.FromArgb(30, 30, 30), Color.FromArgb(255, 255, 255));

            Themes.ForeColor = Color.FromArgb(255, 255, 255);
            Themes.BackColor = Color.FromArgb(30, 30, 30);

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = (Button)ctrl;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.ForeColor = Color.FromArgb(255, 255, 255);
                    btn.BackColor = Color.FromArgb(80, 80, 80);
                    btn.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
                }

                if (ctrl is TextBox || ctrl is RichTextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.BackColor = Color.FromArgb(40, 40, 40);
                    tb.ForeColor = Color.FromArgb(255, 255, 255);
                    tb.BorderStyle = BorderStyle.FixedSingle;
                }

                if (ctrl is CheckedListBox)
                {
                    CheckedListBox clb = (CheckedListBox)ctrl;
                    clb.ForeColor = Color.FromArgb(255, 255, 255);
                    clb.BackColor = Color.FromArgb(40, 40, 40);
                }

                if (ctrl is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctrl;
                    cb.DropDownStyle = ComboBoxStyle.DropDownList;
                    cb.ForeColor = Color.FromArgb(255, 255, 255);
                    cb.BackColor = Color.FromArgb(40, 40, 40);
                }

                if (ctrl is ListBox)
                {
                    ctrl.ForeColor = Color.FromArgb(255, 255, 255);
                    ctrl.BackColor = Color.FromArgb(40, 40, 40);
                }
            }
        }



        private void Orange_Theme()
        {
            this.BackColor = Color.FromArgb(255, 153, 51);  // Form background
            this.ForeColor = Color.FromArgb(255, 255, 255);  // White text

            ApplyThemeToControls(Color.FromArgb(255, 153, 51), Color.FromArgb(255, 255, 255));

            Themes.ForeColor = Color.FromArgb(255, 255, 255);
            Themes.BackColor = Color.FromArgb(255, 153, 51);

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.ForeColor = Color.FromArgb(255, 255, 255);
                    btn.BackColor = Color.FromArgb(255, 140, 0);  // Medium orange
                    btn.FlatAppearance.BorderColor = Color.FromArgb(255, 120, 0);  // Darker orange for border
                }
                else if (ctrl is TextBox || ctrl is RichTextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.BackColor = Color.FromArgb(255, 179, 89);  // Light orange for textboxes
                    tb.ForeColor = Color.FromArgb(0, 0, 0);  // Black text
                    tb.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (ctrl is CheckedListBox || ctrl is ComboBox || ctrl is ListBox)
                {
                    ctrl.ForeColor = Color.FromArgb(0, 0, 0);  // Black text for controls
                    ctrl.BackColor = Color.FromArgb(255, 179, 89);  // Light orange for controls
                }
            }
        }

        private void Red_Theme()
        {
            // Set form background to a deep, vibrant red
            this.BackColor = Color.FromArgb(229, 57, 53);  // Rich red color (#e53935)
            this.ForeColor = Color.FromArgb(255, 255, 255);  // White text for high contrast

            ApplyThemeToControls(Color.FromArgb(229, 57, 53), Color.FromArgb(255, 255, 255));

            Themes.ForeColor = Color.FromArgb(255, 255, 255);
            Themes.BackColor = Color.FromArgb(229, 57, 53);  // Same rich red for themes background

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.ForeColor = Color.FromArgb(255, 255, 255);
                    btn.BackColor = Color.FromArgb(227, 93, 91);  // Slightly lighter red (#e35d5b)
                    btn.FlatAppearance.BorderColor = Color.FromArgb(204, 51, 51);  // Darker red for the border
                }
                else if (ctrl is TextBox || ctrl is RichTextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.BackColor = Color.FromArgb(243, 134, 132);  // Lighter, soft red-pink for textboxes
                    tb.ForeColor = Color.FromArgb(0, 0, 0);  // Black text
                    tb.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (ctrl is CheckedListBox || ctrl is ComboBox || ctrl is ListBox)
                {
                    ctrl.ForeColor = Color.FromArgb(0, 0, 0);  // Black text
                    ctrl.BackColor = Color.FromArgb(243, 134, 132);  // Lighter, soft red-pink for controls
                }
            }
        }


        private void ApplyThemeToControls(Color backColor, Color foreColor)
        {
            this.BackColor = backColor;
            this.ForeColor = foreColor;

            foreach (Control ctrl in this.Controls)
            {
                ApplyControlColors(ctrl, backColor, foreColor);
            }
        }

        private void ApplyControlColors(Control ctrl, Color backColor, Color foreColor)
        {
            ctrl.BackColor = backColor;
            ctrl.ForeColor = foreColor;

            if (ctrl is Button)
            {
                Button btn = (Button)ctrl;

                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new System.Drawing.Font("Sitka Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                btn.ForeColor = foreColor;
                btn.BackColor = (backColor == Color.White) ? Color.FromArgb(160, 222, 236) : Color.FromArgb(50, 50, 50);
            }

            if (ctrl is ComboBox)
            {
                ComboBox cb = (ComboBox)ctrl;
                cb.DropDownStyle = ComboBoxStyle.DropDownList; 
                cb.ForeColor = foreColor;
                cb.BackColor = (backColor == Color.White) ? Color.FromArgb(200, 214, 217) : Color.FromArgb(30, 30, 30);
            }

            if (ctrl is TextBox || ctrl is RichTextBox)
            {
                TextBox tb = (TextBox)ctrl;
                tb.BackColor = (backColor == Color.White) ? Color.FromArgb(200, 214, 217) : Color.FromArgb(30, 30, 30);
                tb.ForeColor = foreColor;
                tb.BorderStyle = BorderStyle.None;
                tb.Font = new Font("Sitka Text", tb.Font.Size, FontStyle.Regular);
            }

            if (ctrl is Label)
            {
                Label lbl = (Label)ctrl;
                lbl.ForeColor = foreColor;
                lbl.BackColor = backColor;
                lbl.Font = new Font("Sitka Text", lbl.Font.Size, FontStyle.Regular);
            }

            if (ctrl is CheckedListBox)
            {
                CheckedListBox clb = (CheckedListBox)ctrl;
                clb.ForeColor = foreColor;
                clb.BackColor = (backColor == Color.White) ? Color.FromArgb(200, 214, 217) : Color.FromArgb(30, 30, 30);
                clb.Font = new Font("Sitka Text", 14.25F, FontStyle.Regular);  

            }

            if (ctrl.HasChildren)
            {
                foreach (Control childCtrl in ctrl.Controls)
                {
                    ApplyControlColors(childCtrl, backColor, foreColor);
                }
            }
        }



        private void comboBoxThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTheme = Themes.SelectedItem.ToString();
            ApplyTheme(selectedTheme);
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
