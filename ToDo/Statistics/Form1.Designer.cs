﻿
namespace Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.xp_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.total_xp_label = new System.Windows.Forms.Label();
            this.total_time_label = new System.Windows.Forms.Label();
            this.highest_lvl_label = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.label1.Location = new System.Drawing.Point(131, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Statistics";
            // 
            // xp_label
            // 
            this.xp_label.AutoSize = true;
            this.xp_label.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.xp_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.xp_label.Location = new System.Drawing.Point(105, 344);
            this.xp_label.Name = "xp_label";
            this.xp_label.Size = new System.Drawing.Size(124, 19);
            this.xp_label.TabIndex = 6;
            this.xp_label.Text = "Total XP Collected:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.label2.Location = new System.Drawing.Point(115, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total time spent:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.label3.Location = new System.Drawing.Point(98, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Highest lvl reached:";
            // 
            // total_xp_label
            // 
            this.total_xp_label.AutoSize = true;
            this.total_xp_label.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.total_xp_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.total_xp_label.Location = new System.Drawing.Point(235, 344);
            this.total_xp_label.Name = "total_xp_label";
            this.total_xp_label.Size = new System.Drawing.Size(17, 19);
            this.total_xp_label.TabIndex = 6;
            this.total_xp_label.Text = "0";
            // 
            // total_time_label
            // 
            this.total_time_label.AutoSize = true;
            this.total_time_label.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.total_time_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.total_time_label.Location = new System.Drawing.Point(235, 377);
            this.total_time_label.Name = "total_time_label";
            this.total_time_label.Size = new System.Drawing.Size(17, 19);
            this.total_time_label.TabIndex = 6;
            this.total_time_label.Text = "0";
            // 
            // highest_lvl_label
            // 
            this.highest_lvl_label.AutoSize = true;
            this.highest_lvl_label.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.highest_lvl_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.highest_lvl_label.Location = new System.Drawing.Point(235, 414);
            this.highest_lvl_label.Name = "highest_lvl_label";
            this.highest_lvl_label.Size = new System.Drawing.Size(17, 19);
            this.highest_lvl_label.TabIndex = 6;
            this.highest_lvl_label.Text = "0";
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(236)))));
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.Home.Location = new System.Drawing.Point(308, 683);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(104, 45);
            this.Home.TabIndex = 7;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(16, 463);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(387, 184);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(25, 85);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(378, 184);
            this.chart2.TabIndex = 9;
            this.chart2.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(424, 740);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.highest_lvl_label);
            this.Controls.Add(this.total_time_label);
            this.Controls.Add(this.total_xp_label);
            this.Controls.Add(this.xp_label);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label xp_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label total_xp_label;
        private System.Windows.Forms.Label total_time_label;
        private System.Windows.Forms.Label highest_lvl_label;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

