
namespace Nutrilingo
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.weeklyBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.macroNutrientTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statisticsWeeklyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsWeeklyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(13, 13);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(524, 249);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // weeklyBtn
            // 
            this.weeklyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.weeklyBtn.Location = new System.Drawing.Point(111, 430);
            this.weeklyBtn.Name = "weeklyBtn";
            this.weeklyBtn.Size = new System.Drawing.Size(125, 37);
            this.weeklyBtn.TabIndex = 1;
            this.weeklyBtn.Text = "Show Weekly Stats";
            this.weeklyBtn.UseVisualStyleBackColor = true;
            this.weeklyBtn.Click += new System.EventHandler(this.weeklyBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macroNutrientTypeDataGridViewTextBoxColumn,
            this.day1DataGridViewTextBoxColumn,
            this.day2DataGridViewTextBoxColumn,
            this.day3DataGridViewTextBoxColumn,
            this.day4DataGridViewTextBoxColumn,
            this.day5DataGridViewTextBoxColumn,
            this.day6DataGridViewTextBoxColumn,
            this.day7DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.statisticsWeeklyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // macroNutrientTypeDataGridViewTextBoxColumn
            // 
            this.macroNutrientTypeDataGridViewTextBoxColumn.DataPropertyName = "MacroNutrientType";
            this.macroNutrientTypeDataGridViewTextBoxColumn.HeaderText = "MacroNutrientType";
            this.macroNutrientTypeDataGridViewTextBoxColumn.Name = "macroNutrientTypeDataGridViewTextBoxColumn";
            // 
            // day1DataGridViewTextBoxColumn
            // 
            this.day1DataGridViewTextBoxColumn.DataPropertyName = "Day1";
            this.day1DataGridViewTextBoxColumn.HeaderText = "Day1";
            this.day1DataGridViewTextBoxColumn.Name = "day1DataGridViewTextBoxColumn";
            // 
            // day2DataGridViewTextBoxColumn
            // 
            this.day2DataGridViewTextBoxColumn.DataPropertyName = "Day2";
            this.day2DataGridViewTextBoxColumn.HeaderText = "Day2";
            this.day2DataGridViewTextBoxColumn.Name = "day2DataGridViewTextBoxColumn";
            // 
            // day3DataGridViewTextBoxColumn
            // 
            this.day3DataGridViewTextBoxColumn.DataPropertyName = "Day3";
            this.day3DataGridViewTextBoxColumn.HeaderText = "Day3";
            this.day3DataGridViewTextBoxColumn.Name = "day3DataGridViewTextBoxColumn";
            // 
            // day4DataGridViewTextBoxColumn
            // 
            this.day4DataGridViewTextBoxColumn.DataPropertyName = "Day4";
            this.day4DataGridViewTextBoxColumn.HeaderText = "Day4";
            this.day4DataGridViewTextBoxColumn.Name = "day4DataGridViewTextBoxColumn";
            // 
            // day5DataGridViewTextBoxColumn
            // 
            this.day5DataGridViewTextBoxColumn.DataPropertyName = "Day5";
            this.day5DataGridViewTextBoxColumn.HeaderText = "Day5";
            this.day5DataGridViewTextBoxColumn.Name = "day5DataGridViewTextBoxColumn";
            // 
            // day6DataGridViewTextBoxColumn
            // 
            this.day6DataGridViewTextBoxColumn.DataPropertyName = "Day6";
            this.day6DataGridViewTextBoxColumn.HeaderText = "Day6";
            this.day6DataGridViewTextBoxColumn.Name = "day6DataGridViewTextBoxColumn";
            // 
            // day7DataGridViewTextBoxColumn
            // 
            this.day7DataGridViewTextBoxColumn.DataPropertyName = "Day7";
            this.day7DataGridViewTextBoxColumn.HeaderText = "Day7";
            this.day7DataGridViewTextBoxColumn.Name = "day7DataGridViewTextBoxColumn";
            // 
            // statisticsWeeklyBindingSource
            // 
            this.statisticsWeeklyBindingSource.DataSource = typeof(Nutrilingo.StatisticsWeekly);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(338, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.weeklyBtn);
            this.Controls.Add(this.chart);
            this.Name = "Form3";
            this.Text = "Weekly Statistics";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsWeeklyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button weeklyBtn;
        private System.Windows.Forms.BindingSource statisticsWeeklyBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn macroNutrientTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day7DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}