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

        public string newItem;

        public Form1()
        {
            InitializeComponent();
            Add.Click += Add_Click;
            Remove.Click += Remove_Click;
            Clear.Click += Clear_Click;
            ClearChecked.Click += ClearChecked_Click;
        }

        private void ClearChecked_Click(object sender, EventArgs e)
        {
            var Items = new List<object>();

            foreach (var checkedItem in Content.CheckedItems)
            {
                Items.Add(checkedItem);
            }

            foreach (var item in Items)
            {
                Content.Items.Remove(item);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Content.Items.Clear();
        }

        

        private void Remove_Click(object sender, EventArgs e)
        {
            newItem = Input.Text;

            if (Content.Items.Contains(newItem))
            {
                Content.Items.Remove(Input.Text);
            }
            else
            {
                MessageBox.Show("No Item to delete!");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Character.Image = Image.FromFile(@"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Sprites\Jinn.png");
            Bar.Image = Image.FromFile(@"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Bars\bar11.jpg");
        }

        private void Add_Click(object sender, EventArgs e)
        {
            newItem = Input.Text;

            if (!Content.Items.Contains(newItem))
            {
                if (!string.IsNullOrWhiteSpace(newItem))
                {
                    Content.Items.Add(newItem);
                    Input.Clear();
                }
            }
        }
    }
}
