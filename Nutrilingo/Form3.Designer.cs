
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.weeklyBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.monthlyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(13, 13);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(698, 381);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // weeklyBtn
            // 
            this.weeklyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.weeklyBtn.Location = new System.Drawing.Point(45, 419);
            this.weeklyBtn.Name = "weeklyBtn";
            this.weeklyBtn.Size = new System.Drawing.Size(125, 37);
            this.weeklyBtn.TabIndex = 1;
            this.weeklyBtn.Text = "Show Weekly Stats";
            this.weeklyBtn.UseVisualStyleBackColor = true;
            this.weeklyBtn.Click += new System.EventHandler(this.weeklyBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtn.Location = new System.Drawing.Point(555, 419);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(125, 37);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthlyBtn
            // 
            this.monthlyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.monthlyBtn.Location = new System.Drawing.Point(212, 419);
            this.monthlyBtn.Name = "monthlyBtn";
            this.monthlyBtn.Size = new System.Drawing.Size(125, 37);
            this.monthlyBtn.TabIndex = 5;
            this.monthlyBtn.Text = "Show Monthly Stats";
            this.monthlyBtn.UseVisualStyleBackColor = true;
            this.monthlyBtn.Click += new System.EventHandler(this.monthlyBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 468);
            this.Controls.Add(this.monthlyBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.weeklyBtn);
            this.Controls.Add(this.chart);
            this.Name = "Form3";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button weeklyBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button monthlyBtn;
    }
}