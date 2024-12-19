using System.Windows.Forms;

namespace ToDo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add = new System.Windows.Forms.Button();
            this.Content = new System.Windows.Forms.CheckedListBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvl_label = new System.Windows.Forms.Label();
            this.xp_label = new System.Windows.Forms.Label();
            this.Remove = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ClearChecked = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.Ranking_label = new System.Windows.Forms.Label();
            this.Character = new System.Windows.Forms.PictureBox();
            this.Bar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(236)))));
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.Add.Location = new System.Drawing.Point(101, 136);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(104, 45);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add Item";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(217)))));
            this.Content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Content.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Content.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.Content.FormattingEnabled = true;
            this.Content.Location = new System.Drawing.Point(88, 196);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(241, 312);
            this.Content.TabIndex = 1;
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(217)))));
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.Input.Location = new System.Drawing.Point(101, 105);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(214, 25);
            this.Input.TabIndex = 2;
            this.Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.label1.Location = new System.Drawing.Point(157, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "To Do List";
            // 
            // lvl_label
            // 
            this.lvl_label.AutoSize = true;
            this.lvl_label.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvl_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.lvl_label.Location = new System.Drawing.Point(12, 687);
            this.lvl_label.Name = "lvl_label";
            this.lvl_label.Size = new System.Drawing.Size(34, 19);
            this.lvl_label.TabIndex = 4;
            this.lvl_label.Text = "lvl 1";
            // 
            // xp_label
            // 
            this.xp_label.AutoSize = true;
            this.xp_label.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.xp_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.xp_label.Location = new System.Drawing.Point(46, 687);
            this.xp_label.Name = "xp_label";
            this.xp_label.Size = new System.Drawing.Size(65, 19);
            this.xp_label.TabIndex = 5;
            this.xp_label.Text = "0/100 XP";
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(236)))));
            this.Remove.FlatAppearance.BorderSize = 0;
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.Remove.Location = new System.Drawing.Point(211, 136);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(104, 45);
            this.Remove.TabIndex = 0;
            this.Remove.Text = "Remove Item";
            this.Remove.UseVisualStyleBackColor = false;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(236)))));
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.Clear.Location = new System.Drawing.Point(101, 536);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(104, 45);
            this.Clear.TabIndex = 0;
            this.Clear.Text = "Clear All";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(46, 1118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "0/100 XP";
            // 
            // ClearChecked
            // 
            this.ClearChecked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(236)))));
            this.ClearChecked.FlatAppearance.BorderSize = 0;
            this.ClearChecked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearChecked.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearChecked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.ClearChecked.Location = new System.Drawing.Point(211, 536);
            this.ClearChecked.Name = "ClearChecked";
            this.ClearChecked.Size = new System.Drawing.Size(104, 45);
            this.ClearChecked.TabIndex = 0;
            this.ClearChecked.Text = "Clear Checked";
            this.ClearChecked.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(156, 1118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "0/100 XP";
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(236)))));
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.Home.Location = new System.Drawing.Point(162, 587);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(104, 45);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            // 
            // Ranking_label
            // 
            this.Ranking_label.AutoSize = true;
            this.Ranking_label.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ranking_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.Ranking_label.Location = new System.Drawing.Point(117, 687);
            this.Ranking_label.Name = "Ranking_label";
            this.Ranking_label.Size = new System.Drawing.Size(50, 19);
            this.Ranking_label.TabIndex = 4;
            this.Ranking_label.Text = "Novice";
            // 
            // Character
            // 
            this.Character.Location = new System.Drawing.Point(285, 623);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(139, 115);
            this.Character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Character.TabIndex = 6;
            this.Character.TabStop = false;
            // 
            // Bar
            // 
            this.Bar.Location = new System.Drawing.Point(16, 709);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(139, 21);
            this.Bar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bar.TabIndex = 7;
            this.Bar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(424, 740);
            this.Controls.Add(this.Bar);
            this.Controls.Add(this.Character);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xp_label);
            this.Controls.Add(this.Ranking_label);
            this.Controls.Add(this.lvl_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.ClearChecked);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Add);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.CheckedListBox Content;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lvl_label;
        private System.Windows.Forms.Label xp_label;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ClearChecked;
        private System.Windows.Forms.Label label5;
        private Button Home;
        private Label Ranking_label;
        private PictureBox Character;
        private PictureBox Bar;
    }
}

